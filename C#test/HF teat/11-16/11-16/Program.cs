﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInteger;
            string myString;
            myInteger = 17;
            myString = "\"myInteger\" is";      /*转义字符*/
            Console.WriteLine("{0} {1}.", myString, myInteger);
            Console.ReadKey();
        }
    }
}
