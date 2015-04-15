using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit_test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver l = new Driver("梁仟",21,'男',1);
            l.SayHello();
            l.Drive();

            Teacher q = new Teacher("雷",21,'女',200);
            Console.WriteLine("我的宝贝是{0}闪，今年{1}岁，是个非常好的{2}孩子，日收入￥{3}",q.Name,q.Age,q.Gendar,q.Salary);


            Console.ReadKey();
            
        }
    }

}
