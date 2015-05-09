using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace String_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "  hello      world,你  好 世界   !    ";
            string str1 = str.Trim();
            string[] newStr = str1.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            str1 = string.Join(" ", newStr);
            Console.WriteLine(str1);
        }
    }
}
