using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GitHub.Controllers {
    [Route("api/[controller]/[action]")]
    [Authorize]
    public class HelloController : ControllerBase {

        [HttpGet]
        public string Hi() => "Hello";
    }
}