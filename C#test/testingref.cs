using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void ShowDouble(ref int val)
        {
            val *= 2;
            Console.WriteLine("val doubled = {0}", val);
        }
        static void Main(string[] args)
        {
            int myNumber = 5;
            Console.WriteLine("myNumber = {0}", myNumber);
            ShowDouble(ref myNumber);
            Console.WriteLine("myNumber = {0}", myNumber);      //直接引用
            Console.ReadKey();
        }
    }
}
