﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using SimpleIdServer.IdServer.Builders;
using SimpleIdServer.IdServer.Domains;
using System.Collections.Generic;

namespace SimpleIdServer.IdServer.Startup
{
    public class IdServerConfiguration
    {
        public static ICollection<Scope> Scopes => new List<Scope>
        {
            Constants.StandardScopes.OpenIdScope,
            Constants.StandardScopes.Profile
        };

        public static ICollection<User> Users => new List<User>
        {
            UserBuilder.Create("administrator", "password", "Administrator").Build()
        };

        public static ICollection<Client> Clients => new List<Client>
        {
            ClientBuilder.BuildTraditionalWebsiteClient("website", "password", "http://localhost:60001/signin-oidc").AddScope("openid", "profile").Build()
        };
    }
}