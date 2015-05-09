using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Count_length
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入一个需要计算的字符串");
            string str = Console.ReadLine();
            Console.WriteLine(str.Length);
        }
    }
}
