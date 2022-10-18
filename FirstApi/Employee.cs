using System.ComponentModel.DataAnnotations;
namespace FirstApi
{
    public class Employee
    {

        [Key]
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }

        public double Salary { get; set; }

    }
}
