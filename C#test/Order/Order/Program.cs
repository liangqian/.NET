using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] a ={1,3,24,54,657,234};
            Console.WriteLine("输出数组：");
            for (i=0; i < 6;i++ )
            {
                Console.WriteLine("输出{0}:  这是第{1}个数字：{2}", i, i, a[i]);
            }
            Console.ReadKey();

        }
    }
}
