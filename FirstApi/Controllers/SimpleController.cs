using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oops;

namespace FirstApi.Controllers
{
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    
    public class SimpleController : ControllerBase
    {
        [EnableCors("AllowOrigin")]
        [HttpGet("/Greet")]
        public string Greeting(string pName)
        {
            return $"Hello {pName}";
        }

        [DisableCors]
        [HttpGet("/allNames")]

        public List<string> AllNames()
        {
            List<string> names = new List<string>() { "Mayur", "Sneha", "Shipla" };
            return names;
        }

        [HttpGet("/getAllEmployees")]
        public List<KpmgEmployee> GetAllEmployees()
        {
            List<KpmgEmployee> kpmgEmployee = new List<KpmgEmployee>();
            kpmgEmployee.Add(new KpmgEmployee()
            {EmpID = 100,Name = "Mayur",Designation = "Analyst"});
            kpmgEmployee.Add(new KpmgEmployee()
            {EmpID = 101,Name = "Sneha",   Designation = "Analyst"            });
            kpmgEmployee.Add(new KpmgEmployee()
            {EmpID = 102,Name = "Shilpa",Designation = "Analyst"   });
            return kpmgEmployee;

        }

        [HttpGet("/employees/search/{pName}")]

        public List<KpmgEmployee> SearchEmployee([FromRoute] string pName)
        {
            List<KpmgEmployee> allEmps = GetAllEmployees();
            return allEmps.Where((emp) => { return emp.Name == pName; }).ToList();
        }

        [HttpGet("/employees/search/{dDes}/{sName}")]

        public List<KpmgEmployee> SearchDes([FromRoute] string sName, string dDes)
        {
            List<KpmgEmployee> sEmp = GetAllEmployees();
            return sEmp.Where((emp) => { return emp.Name.Contains(sName) && emp.Designation == dDes; }).ToList();
          
        }

        [HttpGet("/Iaction")]
        public IActionResult GetUsingIaction()
        {
            List<KpmgEmployee> kpmgEmployee = new List<KpmgEmployee>();
            kpmgEmployee.Add(new KpmgEmployee()
            { EmpID = 100, Name = "Mayur", Designation = "Analyst" });
            kpmgEmployee.Add(new KpmgEmployee()
            { EmpID = 101, Name = "Sneha", Designation = "Analyst" });
            kpmgEmployee.Add(new KpmgEmployee()
            { EmpID = 102, Name = "Shilpa", Designation = "Analyst" });
            return Ok(kpmgEmployee);

        }

    }

    
}
