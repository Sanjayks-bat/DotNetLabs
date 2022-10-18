using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActionsController : ControllerBase
    {
        [HttpGet("/str/get")]
        public IActionResult GetStr()
        {
            return Ok(_actions);
        }

        private static List<string> _actions = new List<string>();

        [HttpPost("/str/insert")]

        public IActionResult InsertStr([FromBody] string str)
        {
            if(str == "none")
            {
                return BadRequest("none is not allowed"); 
            }
            _actions.Add(str);
            return Created("/str/insert",$"{str} added successfully");
        }

        [HttpPut("/str/update/{oldStr}")]

        public IActionResult UpdateStr([FromRoute] string oldStr, [FromBody] string newStr)
        {
            string? foundStr = _actions.Where((s) => { return s == oldStr; }).ToList().FirstOrDefault();
            if(foundStr == null || foundStr == "")
            {
                return NotFound();
            }
            oldStr = newStr;
            _actions.Add(oldStr);
            return NoContent();

        }

        [HttpDelete("/str/delete/{strToRemove}")]

        public IActionResult RemoveStr([FromRoute] string strToRemove)
        {
            bool isSuccessfull = _actions.Remove(strToRemove);
            if(isSuccessfull == true)
            {
                return Ok($"Deletion successful for {strToRemove}");
            }
            else
            {
                return NotFound();
            }

        }
    }

}
