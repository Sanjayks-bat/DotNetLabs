using IntegrationLab.Data;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oops;

namespace IntegrationLab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]

    
    public class RectControleer : ControllerBase
    {
        private static List<Rectangle> _rect = new List<Rectangle>();
        LabApi context = null;

        public RectControleer(LabApi ctx)
        {
            context = ctx;
        }

        [HttpPost("/insert")]

        public IActionResult Insert([FromBody] Rectangle l)
        {
            _rect.Add(l);
            return Created("/insert", l);

        }

        [HttpGet("/getRec")]

        public IActionResult Get()
        {
            return Ok(_rect);
        }

    }
}
