using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace IdentityServer.Controllers {
    [Route("api/[controller]/[action]")]
    [Authorize]
    public class HelloController : ControllerBase {

        [HttpGet]
        public string Hi() {
            var json = JsonConvert.SerializeObject(this.User.Identity, Formatting.Indented, new JsonSerializerSettings {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            Console.WriteLine("{0}", json);
            return "Hi";
        }

        [HttpGet]
        public string Go() {
            return "Go";
        }
    }
}