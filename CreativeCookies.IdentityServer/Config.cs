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
        public static List<TestUser> GetUsers()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "freeUser",
                    Username = "freeUser",
                    Password = "password",
                    
                    Claims = new []
                    {
                        new Claim("name", "freeUser"),
                        new Claim(JwtClaimTypes.Profile, "freeUser"),
                        new Claim(JwtClaimTypes.Email, "mariusz.budzisz@yahoo.com"),
                        new Claim("role", "consumer"),
                        new Claim("subscriptionLevel", "freeUser")
                    }
                },
                new TestUser
                {
                    SubjectId = "paidUser",
                    Username = "paidUser",
                    Password = "password",

                    Claims = new []
                    {
                        new Claim("name", "paidUser"),
                        new Claim(JwtClaimTypes.Profile, "paidUser"),
                        new Claim(JwtClaimTypes.Email, "mariusz.budzisz@yahoo.com"),
                        new Claim("role", "consumer"),
                        new Claim("subscriptionLevel", "paidUser")
                    }
                },
                new TestUser
                {
                    SubjectId = "admin",
                    Username = "admin",
                    Password = "password",

                    Claims = new []
                    {
                        new Claim("name", "admin"),
                        new Claim(JwtClaimTypes.Profile, "admin"),
                        new Claim(JwtClaimTypes.Email, "mariusz.budzisz@yahoo.com"),
                        new Claim("role", "admin"),
                        new Claim("subscriptionLevel", "admin")
                    }
                }
            };
        }
        public static IEnumerable<IdentityResource> Ids =>
            new IdentityResource[]
            { 
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
                new IdentityResource(
                    "roles",
                    "Your role(s)",
                    new List<string>(){ "role" }),
                new IdentityResource(
                    "subscriptionLevel",
                    "Your subscription level",
                    new List<string>(){ "subscriptionLevel" })
            };

        public static IEnumerable<ApiResource> Apis =>
            new ApiResource[] 
            { 
                new ApiResource("api","Api")
            };
        
        public static IEnumerable<Client> Clients =>
            new Client[] 
            { 
                new Client
                {
                    ClientId = "ro.client",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,

                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes = {"api"}
                },
                new Client
                {
                    ClientId = "spa-client",
                    ClientName = "SPA",
                    RequireClientSecret = false,
                    AllowedGrantTypes = GrantTypes.Code,
                    RequirePkce = true,
                    AllowAccessTokensViaBrowser = false,
                    RequireConsent = false,

                    RedirectUris = { "https://localhost:44370/signin-callback", "http://localhosts:44370/assets/silent-callback.html" },
                    PostLogoutRedirectUris = { "https://localhost:44370/signout-callback" },
                    AllowedCorsOrigins =     { "https://localhost:44370" },

                     AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Email,
                        "roles",
                        "subscriptionLevel"
                    },
                    AccessTokenLifetime = 600
                },
                new Client
                {
                    ClientId = "aspdotnet",
                    ClientName = "ASPdotNET Client",
                    AllowedGrantTypes = GrantTypes.Implicit,

                    // where to redirect to after login
                    RedirectUris = { "https://localhost:44370/signin-oidc" },

                    // where to redirect to after logout
                    PostLogoutRedirectUris = { "https://localhost:44370/signout-callback-oidc" },

                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Email
                    }
                }
            };
        
    }
}