using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope_code
{
    class Program
    {
        static string myString;         //定义全局变量-->>这个必须有。
        static void write()
        {
            string myString = "String defined in Write()";
            Console.WriteLine("Now in Write()");
            Console.WriteLine("Locate string = {0}", myString);
            Console.WriteLine("Global string = {0}", Program.myString);
        }
        static void Main(string[] args)
        {
            string myString = "String defined in main()";
            Program.myString = "Global string";
            write();
            Console.WriteLine("\nNow in main()");
            Console.WriteLine("Locate string = {0}", myString);
            Console.WriteLine("Global string = {0}", Program.myString);
            Console.ReadKey();
        }
    }
}
