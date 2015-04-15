using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit_test_1
{
    class Persion
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }

        }


        private char _gendar;
        public char Gendar
        {
            get { return _gendar; }
            set { _gendar = value; }
        }
        public void SayHello()
        {
            Console.WriteLine("Hello;");
        }
        public Persion(string name,int age,char gendar)
        {
            this.Name = name;
            this.Age = age;
            this.Gendar = gendar;
        }
        public Persion()
        {
 
        }
    }
}
