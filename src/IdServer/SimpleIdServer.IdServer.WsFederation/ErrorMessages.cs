﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace SimpleIdServer.IdServer.WsFederation
{
    public static class ErrorMessages
    {
        public const string UNKNOWN_RP = "the relying party doesn't exist";
        public const string WSFEDERATION_NOT_ENABLED = "ws-federation is not enabled";
        public const string UNSUPPORTED_TOKENTYPE = "the token type is not supported";
        public const string NO_CLAIM = "token cannot be generated if there is no claim, please specify one or more scope in the client";
    }
}
