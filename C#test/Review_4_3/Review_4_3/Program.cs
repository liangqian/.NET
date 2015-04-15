using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Persion lQ = new Persion("梁仟",-21,'j');
            //new:1、在内存中开辟一个内存空间，2、在开辟的对象中创建对象 ，3、调用对象的构造函数
            lQ.Sayhello();
            Persion.Sayhi();
            Persion.Sayhi();
            Console.ReadKey();
        }
    }
}
