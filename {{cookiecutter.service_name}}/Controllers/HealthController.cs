using Microsoft.AspNetCore.Mvc;

namespace {{cookiecutter.namespace}}.Controllers
{
    [ApiController]
    [Route("api/health")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                status = "UP",
                service = "{{cookiecutter.service_name}}"
            });
        }
    }
}
