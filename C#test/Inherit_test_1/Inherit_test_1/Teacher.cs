using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit_test_1
{
    class Teacher:Persion   //继承父类
    {

        public Teacher(string name,int age,char gendar,int salary):base(name,age,gendar)
        {
            this.Salary = salary;
        }

        private int _salary;
        public int Salary
        {
            get { return _salary; }
            set { _salary=value;}
        }

       
        public void Teach()
        {
            Console.WriteLine("教书");
        }
    }
}
