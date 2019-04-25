using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityServer.Controllers {
    [Route("api/[controller]/[action]")]
    [Authorize]
    public class HelloController : ControllerBase {

        [HttpGet]
        public string Hi() {
            return "Hi";
        }

        [HttpGet]
        public string Go() {
            return "Go";
        }
    }
}