using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Highfive.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HighfiveController : ControllerBase
    {
        [HttpGet("Ping")]
        public IActionResult Ping()
        {
            return new OkObjectResult("Pong");
        }
    }
}
