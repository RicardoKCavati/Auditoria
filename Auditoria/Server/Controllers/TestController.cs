using Microsoft.AspNetCore.Mvc;

namespace Auditoria.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpPost("test")]
        public IEnumerable<string> TestEndpoint(bool isName)
        {
            if (isName)
            {
                return new string[] { "nome1", "nome2", "nome3" };
            }

            return new string[] { "test1", "test2", "test3" };
        }
    }
}
