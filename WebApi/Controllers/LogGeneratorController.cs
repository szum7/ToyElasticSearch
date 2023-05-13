using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogGeneratorController : ControllerBase
    {
        private readonly ILogger<LogGeneratorController> _logger;

        public LogGeneratorController(ILogger<LogGeneratorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}