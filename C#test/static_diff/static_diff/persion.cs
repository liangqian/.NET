using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_diff
{
    class persion
    {
        public void M1()
        {
            Console.WriteLine("非静态的方法");
        }
        public static void M2()
        {
            Console.WriteLine("静态的方法");
        }
    }
}
