using System.Linq;
using System.Collections.Generic;
using IdentityServer4.Models;

namespace IdentityServer.Configurations {

    class Clients {
        public static IEnumerable<Client> Get() {
            return new List<Client> {
                new Client {
                    ClientId  = "oauthClient",
                    ClientName = "Example Client Credentials Client Application",
                    AllowedGrantTypes = new [] { GrantType.ClientCredentials, GrantType.ResourceOwnerPassword },
                    ClientSecrets = new List<Secret> {
                        new Secret("superSecretPassword".Sha256())
                    },
                    AllowedScopes = new List<string>  { "customAPI.read"}
                }
            };
        }
    }
}