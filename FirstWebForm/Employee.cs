using System;

namespace FirstWebForm
{
    [Serializable()]
    public class Employee
    {
        public Employee()
        {
        }

        public int EmpID { get; set; }
        public string EName { get; set; }
        public string Designation { get; set; }
    }
}