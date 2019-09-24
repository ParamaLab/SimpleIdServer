﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using Newtonsoft.Json.Linq;
using SimpleIdServer.OAuth.Api.Token.Helpers;
using SimpleIdServer.OAuth.Api.Token.TokenBuilders;
using SimpleIdServer.OAuth.Api.Token.TokenProfiles;
using SimpleIdServer.OAuth.Api.Token.Validators;
using SimpleIdServer.OAuth.DTOs;
using SimpleIdServer.OAuth.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleIdServer.OAuth.Api.Token.Handlers
{
    public class ClientCredentialsHandler : BaseCredentialsHandler
    {
        private readonly IClientCredentialsGrantTypeValidator _clientCredentialsGrantTypeValidator;
        private readonly IEnumerable<ITokenProfile> _tokenProfiles;
        private readonly IEnumerable<ITokenBuilder> _tokenBuilders;

        public ClientCredentialsHandler(IClientCredentialsGrantTypeValidator clientCredentialsGrantTypeValidator, IEnumerable<ITokenProfile> tokenProfiles,
            IEnumerable<ITokenBuilder> tokenBuilders, IClientAuthenticationHelper clientAuthenticationHelper) : base(clientAuthenticationHelper)
        {
            _clientCredentialsGrantTypeValidator = clientCredentialsGrantTypeValidator;
            _tokenProfiles = tokenProfiles;
            _tokenBuilders = tokenBuilders;
        }

        public override string GrantType { get => "client_credentials"; }

        public override async Task<JObject> Handle(HandlerContext context)
        {
            _clientCredentialsGrantTypeValidator.Validate(context);
            var oauthClient = await AuthenticateClient(context);
            context.SetClient(oauthClient);
            var scopes = ScopeHelper.Validate(context.Request.HttpBody.GetStr(TokenRequestParameters.Scope), oauthClient.AllowedScopes.Select(s => s.Name));
            var result = BuildResult(context, scopes);
            foreach (var tokenBuilder in _tokenBuilders)
            {
                await tokenBuilder.Build(scopes, context).ConfigureAwait(false);
            }

            _tokenProfiles.First(t => t.Profile == context.Client.PreferredTokenProfile).Enrich(context);
            foreach(var kvp in context.Response.Parameters)
            {
                result.Add(kvp.Key, kvp.Value);
            }

            return result;
        }
    }
}