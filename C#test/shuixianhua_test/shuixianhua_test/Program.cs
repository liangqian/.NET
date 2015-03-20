using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shuixianhua_test              //寻找水仙花数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Input a Number between 100 to 999");
            string munber = Console.ReadLine();
            int munber1 = Convert.ToInt32(munber);
            int m, n, l, k, p;
            m = munber1 / 100;
            n = munber1 % 100 / 10;
            l = munber1 % 10 % 10;
            k = 100 * m + 10 * 10 + l;
            p = m * m * m + n * n * n + l * l * l;
            if (p == k)
            {
                Console.WriteLine("This is a 水仙花数！");
            }
            Console.WriteLine("List every number:{0} ,{1} ,{2}", m,n,l);
            Console.ReadKey();
        }
    }
}
