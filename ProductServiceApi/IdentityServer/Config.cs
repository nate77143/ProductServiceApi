using Duende.IdentityServer.Models;
using System.Collections.Generic;

namespace IdentityServer
{
    public class Config
    {
        public static IEnumerable<Client> Clients =>
            new Client[]
            {
               new Client
               {
                    ClientId = "productClient",
                    AllowedGrantTypes = new List<string> { GrantType.ClientCredentials },
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes = { "productApi" }
               }
            };
        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("productApi", "Product API")
            };
     }
}
