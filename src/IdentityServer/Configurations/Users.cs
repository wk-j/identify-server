using System.Collections.Generic;
using IdentityServer4.Test;
using System.Security.Claims;
using IdentityModel;

namespace IdentityServer.Configurations {
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
}