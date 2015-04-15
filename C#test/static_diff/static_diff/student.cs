using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_diff
{
     public static class student
    {
         private static string _name;

         public static string name
         {
             set { student._name = value; }
             get { return student._name; }
         }
         public static void M1()
         {
             Console.WriteLine("Hello world!");
         }

    }
}
