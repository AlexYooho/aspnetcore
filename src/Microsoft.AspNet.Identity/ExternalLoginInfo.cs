// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Security.Claims;

namespace Microsoft.AspNet.Identity
{
    public class ExternalLoginInfo(ClaimsIdentity externalIdentity, string loginProvider, string providerKey,
        string displayName) : UserLoginInfo(loginProvider, providerKey, displayName)
    {
        public ClaimsIdentity ExternalIdentity { get; set; } = externalIdentity;
    }
}