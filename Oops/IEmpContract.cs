using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public interface IEmpContract
    {
        int WorkHoursClause();
        string SickLeavesClause();
    }

    public class KpmgEmployee : IEmpContract
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string SickLeavesClause()
        {
            return "Employee is allowed to take 5 sick leaves per month.";
        }

        public int WorkHoursClause()
        {
            return 8;
        }
    }

    public class DellEmployee : IEmpContract
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string SickLeavesClause()
        {
            return "Employees are allowed to take 6 sick leaves";
        }

        public int WorkHoursClause()
        {
            return 8;
        }
    }

    class MyClass: ParentClass, IContract1, IContract2
    {

    }

    internal interface IContract1
    {
    }

    internal interface IContract2
    {
    }

    internal class ParentClass
    {
    }
}
