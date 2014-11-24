using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testhello
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            string s = "qwe";
            
            int[] d=new int[12];

            for (a = 0; a <= 11; a++)
            {
                d[a] = a;
            }
            Console.WriteLine(a);
            Console.WriteLine(s);
            for (a = 0; a <= 11; a++)
            {
                Console.Write(d[a]);
            }

            Console.Read();
        }
    }
}
