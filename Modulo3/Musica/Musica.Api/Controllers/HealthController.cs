using Microsoft.AspNetCore.Mvc;

namespace Musica.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthControlles : ControllerBase
    {
        [HttpGet]
        public IActionResult Health ()
        {
            return Ok("Health");
        }

    }
}