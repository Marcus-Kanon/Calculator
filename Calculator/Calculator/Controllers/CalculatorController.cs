using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Calculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [Route("{a}/{op}/{b}")]
        [HttpGet]
        public string Get(double a, string op, double b)
        {
            if(op == "+")
                return JsonConvert.SerializeObject(a + b);
            if (op == "-")
                return JsonConvert.SerializeObject(a - b);
            if (op == "*")
                return JsonConvert.SerializeObject(a * b);
            if (op == ",")
                return JsonConvert.SerializeObject(a / b);

            return "FEL!";

        }
    }
}