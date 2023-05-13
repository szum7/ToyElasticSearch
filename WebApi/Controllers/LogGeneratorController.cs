using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogGeneratorController : ControllerBase
    {
        private readonly Serilog.ILogger _logger;

        public LogGeneratorController(Serilog.ILogger logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.Error(new NullReferenceException(), "This is a custom error with a custom property: {customProperty}", 123);
            return Ok("Success");
        }
    }
}