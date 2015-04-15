using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipy_81
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=1;i<10;i++)
            {
                for(int j=1;j<=i;j++)       //在右下角显示
                {
                    Console.Write("{0}*{1}={2}\t", i, j, i * j);      //write在一行显示
                }
                Console.WriteLine();            //执行完了一行就换行
            }
            Console.ReadKey();
        }
    }
}
