using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            reload();
            Console.ReadKey();
        }
        public static int i = 0;    //全局变量，不管后面怎么调用i，都不会影响到i的值，每个类下的方法都可以访问到这个变量
        public static void reload()
        {
            Console.WriteLine("从前有座山");
            Console.WriteLine("上山有座庙");
            Console.WriteLine("庙里有个和尚");
            Console.WriteLine("从前有座山");
            Console.WriteLine("讲的故事是：");
            i++;
            if (i >10)
            {
                return;
            }
            reload();
        }


    }
}
