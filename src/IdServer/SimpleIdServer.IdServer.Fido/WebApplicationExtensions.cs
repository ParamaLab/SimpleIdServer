﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using SimpleIdServer.IdServer.Fido;
using SimpleIdServer.IdServer.Options;

namespace Microsoft.AspNetCore.Builder
{
    public static class WebApplicationExtensions
    {
        public static WebApplication UseFIDO(this WebApplication webApplication)
        {
            var opts = webApplication.Services.GetRequiredService<IOptions<IdServerHostOptions>>().Value;
            var usePrefix = opts.UseRealm;

            webApplication.MapControllerRoute("beginQRRegister",
                pattern: (usePrefix ? "{prefix}/" : string.Empty) + Constants.EndPoints.BeginQRCodeRegister,
                defaults: new { controller = "U2FRegister", action = "BeginQRCode" });
            webApplication.MapControllerRoute("readRegisterQRCode",
                pattern: (usePrefix ? "{prefix}/" : string.Empty) + Constants.EndPoints.ReadRegisterQRCode + "/{sessionId}",
                defaults: new { controller = "U2FRegister", action = "ReadQRCode" });
            webApplication.MapControllerRoute("U2FStatusRegistration",
                pattern: (usePrefix ? "{prefix}/" : string.Empty) + Constants.EndPoints.RegisterStatus + "/{sessionId}",
                defaults: new { controller = "U2FRegister", action = "GetStatus" });
            webApplication.MapControllerRoute("beginRegister",
                pattern: (usePrefix ? "{prefix}/" : string.Empty) + Constants.EndPoints.BeginRegister,
                defaults: new { controller = "U2FRegister", action = "Begin" });
            webApplication.MapControllerRoute("endRegister",
                pattern: (usePrefix ? "{prefix}/" : string.Empty) + Constants.EndPoints.EndRegister,
                defaults: new { controller = "U2FRegister", action = "End" });

            webApplication.MapControllerRoute("beginQRLogin",
                pattern: (usePrefix ? "{prefix}/" : string.Empty) + Constants.EndPoints.BeginQRCodeLogin,
                defaults: new { controller = "U2FLogin", action = "BeginQRCode" });
            webApplication.MapControllerRoute("U2FStatusLogin",
                pattern: (usePrefix ? "{prefix}/" : string.Empty) + Constants.EndPoints.LoginStatus + "/{sessionId}",
                defaults: new { controller = "U2FLogin", action = "GetStatus" });
            webApplication.MapControllerRoute("beginLogin",
                pattern: (usePrefix ? "{prefix}/" : string.Empty) + Constants.EndPoints.BeginLogin,
                defaults: new { controller = "U2FLogin", action = "Begin" });
            webApplication.MapControllerRoute("endLogin",
                pattern: (usePrefix ? "{prefix}/" : string.Empty) + Constants.EndPoints.EndLogin,
                defaults: new { controller = "U2FLogin", action = "End" });
            webApplication.MapControllerRoute("readLoginQRCode",
                pattern: (usePrefix ? "{prefix}/" : string.Empty) + Constants.EndPoints.ReadLoginQRCode + "/{sessionId}",
                defaults: new { controller = "U2FLogin", action = "ReadQRCode" });

            return webApplication;
        }
    }
}
