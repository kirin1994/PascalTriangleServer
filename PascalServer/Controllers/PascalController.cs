using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PascalServer.Models;
using PascalServer.Services;

namespace PascalServer.Controllers
{
    [Route("api/pascal")]
    public class PascalController : ControllerBase
    {
        [HttpGet("calculate")]
        public ActionResult<string> Get([FromQuery] CalculateParameters calculateParameters)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pascalTriangle = PascalService.CalculatePascalTriangle(calculateParameters.NumberOfIterations, calculateParameters.Modulo);

            var pascalTriangleObject = new PascalJson(pascalTriangle, calculateParameters.NumberOfIterations, calculateParameters.Modulo);

            var pascalJsonFormat = JsonConvert.SerializeObject(pascalTriangleObject);

            return pascalJsonFormat;
        }

    }
}
