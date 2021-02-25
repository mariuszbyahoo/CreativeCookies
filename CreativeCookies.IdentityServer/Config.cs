// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace CreativeCookies.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> Ids =>
            new IdentityResource[]
            { 
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
                new IdentityResource(
                    "roles",
                    "Your role(s)",
                    new List<string>(){ "role" })
            };

        public static IEnumerable<ApiResource> Apis =>
            new ApiResource[] 
            { // In order to add custom claims to the access token add those claims to the requested
                // claims property in ApiResource
                new ApiResource("api","Api", new List<string>{ "role" })
            };
        
        public static IEnumerable<Client> Clients =>
            new Client[] 
            { 
                new Client
                {
                    ClientId = "spa-client",
                    ClientName = "SPA",
                    RequireClientSecret = false,
                    AllowedGrantTypes = GrantTypes.Code,
                    RequirePkce = true,
                    AllowAccessTokensViaBrowser = false,
                    RequireConsent = false,
                    AlwaysSendClientClaims = true,


                    RedirectUris = { "https://localhost:44370/signin-callback", "https://localhost:44370/assets/silent-callback.html" },
                    PostLogoutRedirectUris = { "https://localhost:44370/signout-callback" },
                    AllowedCorsOrigins =     { "https://localhost:44370" },

                     AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Email,
                        "api",
                        "roles",
                    },
                    AccessTokenLifetime = 600
                }
            };
        
    }
}