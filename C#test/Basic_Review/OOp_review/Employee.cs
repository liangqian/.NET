using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOp_review
{
    class Employee:Persion
    {
        public double Salary
        {
            get;
            set;
        }
        public override void SayHi()
        {
            Console.WriteLine("子类hello");
        }
    }
}
