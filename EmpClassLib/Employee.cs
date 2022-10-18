using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EmpClassLib
{
    public class Employee: Person
    {
        /*public int Empid { get; set; }
        public string Designation { get; set; }

        public Employee(string pName,int pAge,int Empid,string Designation) : base(pName, pAge)
        {
            this.Empid = Empid;
            this.Designation = Designation;
        }*/

        public int days { get; set; }

        //abstract
        public override void Leave()
        {
            Console.WriteLine($"I will take leave for {this.days} days");
        }

        //overriding
        public override void AssignLeave()
        {
            Console.WriteLine("I will not be available at office tommorrow");
        }
    }
}
