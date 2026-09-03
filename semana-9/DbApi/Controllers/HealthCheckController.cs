using Microsoft.AspNetCore.Mvc;

namespace dbApi.Controllers
{
    [ApiController]
    [Route("health")]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public IActionResult HealthCheck()
        {
            return StatusCode(200, "Healthy");
        }
    }


}