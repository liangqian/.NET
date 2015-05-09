using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mutifly
{
    class Program
    {
        /// <summary>
        /// 打印乘法口诀表
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("{0}*{1}={2}\t",i,j,i*j);
                }
                Console.WriteLine();

            }
            
        }
    }
}
