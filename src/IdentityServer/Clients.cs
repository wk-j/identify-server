using System.Linq;
using System.Collections.Generic;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System.Security.Claims;
using IdentityModel;

namespace IdentityServer {

    class Users {
        public static List<TestUser> Get() {
            return new List<TestUser> {
                new TestUser {
                    SubjectId = "5BE86359-073C-434B-AD2D-A3932222DABE",
                    Username = "wk",
                    Password = "password",
                    Claims = new List<Claim> {
                        new Claim(JwtClaimTypes.Email, "wk@gmail.com"),
                        new Claim(JwtClaimTypes.Role, "admin")
                    }
                }
            };
        }
    }

    class Resources {
        public static IEnumerable<IdentityResource> GetIdentityResources() {
            return new List<IdentityResource> {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
                new IdentityResource {
                    Name = "role",
                    UserClaims = new List<string> { "role"}
                }
            };
        }

        public static IEnumerable<ApiResource> GetApiResources() {
            return new List<ApiResource> {
                new ApiResource {
                    Name = "customAPI",
                    DisplayName = "Custom API",
                    Description = "Custom API Access",
                    UserClaims = new List<string> { "role"},
                    ApiSecrets = new List<Secret>  { new Secret("scopeSecret".Sha256())},
                    Scopes = new List<Scope> {
                        new Scope("customAPI.read"),
                        new Scope("customAPI.write")
                    }
                }
            };
        }
    }

    class Clients {
        public static IEnumerable<Client> Get() {
            return new List<Client> {
                new Client {
                    ClientId  = "oauthClient",
                    ClientName = "Example Client Credentials Client Application",
                    AllowedGrantTypes = new [] { GrantType.ClientCredentials },
                    ClientSecrets = new List<Secret> {
                        new Secret("superSecretPassword".Sha256())
                    },
                    AllowedScopes = new List<string>  { "customAPI.read"}
                }
            };

        }
    }

}