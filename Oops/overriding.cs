using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public class Parent
    {
        public virtual void ChooseCareer()
        {
            Console.WriteLine("Take admission for BE CSE");
        }
        public void NoNightOuts()
        {
            Console.WriteLine("Night outs not allowed");
        }
    }

    public class Child: Parent
    {
        public override void ChooseCareer()
        {
            Console.WriteLine("I will become Cricketer");
        }

        public void NoNightOuts()
        {
            Console.WriteLine("I'm Going in...");
        }
    }

    
}
