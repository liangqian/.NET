using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace select_shuixianhuashu_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,m, n, l;
            Console.WriteLine("这是在100~1000之间的随机数：");
            for (i = 100; i < 1000; i++)
            {
                m = i / 100;    //拆分百位
                n = i / 10 % 10;    //拆分十位
                l = i % 10;     //拆分个位
                if (i == m * m * m + n * n * n + l * l * l)
                {
                    Console.WriteLine("{0}",i);
                }
            }
            Console.ReadKey();
        }
    }
}
