﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using SimpleIdServer.IdServer.Domains;

namespace SimpleIdServer.IdServer.UI;

public interface IOTPRegisterOptions
{
    public OTPAlgs OTPAlg { get; }
    public string OTPValue { get; set; }
    public int OTPCounter { get; set; }
    public string HttpBody { get; }
}
