using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oops;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KpmgController : ControllerBase
    {
        [HttpGet("/kpmg/get")]
        public IActionResult GetStr()
        {
            return Ok(_actions);
        }

        [HttpGet("/kpmg/search/{empID}")]

        public IActionResult GetEmployee([FromRoute] int empID) {
            KpmgEmployee? employ = _actions.Where((s) => { return s.EmpID == empID; }).FirstOrDefault();   
            return Ok(employ.Name);
        }
        private static List<KpmgEmployee> _actions = new List<KpmgEmployee>();

        [HttpPost("/kpmg/insert")]

        public IActionResult InsertStr([FromBody] KpmgEmployee str)
        {
            if (str == null)
            {
                return BadRequest("none is not allowed");
            }
           
            _actions.Add(str);
            return Created("/kpmg/insert", $"{str} added successfully");
        }

        [HttpPut("/kpmg/update/{empId}")]

        public IActionResult UpdateStr([FromRoute] int empId, [FromBody] KpmgEmployee newStr)
        {
            KpmgEmployee? foundStr = _actions.Where((s) => { return s.EmpID == empId; }).ToList().FirstOrDefault();
            if (foundStr == null)
            {
                return NotFound();
            }
            foundStr.Name = newStr.Name;
            foundStr.Designation = newStr.Designation; 
            //_actions.Add(oldStr);
            return NoContent();

        }

        [HttpDelete("/kpmg/delete/{empID}")]

        public IActionResult RemoveStr([FromRoute] int empID)
        {
            KpmgEmployee? foundEmp = _actions.Where((emp) => { return emp.EmpID == empID; }).FirstOrDefault();
            bool isSuccessfull = _actions.Remove(foundEmp);
            if (isSuccessfull == true)
            {
                return Ok($"Deletion successful for {empID}");
            }
            else
            {
                return NotFound();
            }

        }


    }
}
