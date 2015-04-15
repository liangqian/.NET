using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit_test_1
{
    class Student:Persion  //继承父类
    {

      

        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

         
        public void Study()
        {
            Console.WriteLine("学习");
        }
    }
}
