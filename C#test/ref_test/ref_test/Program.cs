using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_test
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = 5000;
            jiangjin(ref salary);
            Console.WriteLine(salary);

            int n1 = 10;
            int n2 = 20;
            Exchang(ref n1, ref n2);
            Console.WriteLine("{0}、{1}", n1, n2);
            Console.ReadKey();
        }
        public static void jiangjin(ref double s)
        {
            s += 500;
        }
        public static void chengfa(double s)
        {
            s -= 500;
        }

        public static void Exchang(ref int n1,ref int n2)
        {
            n1 = n1 - n2;
            n2 = n1 + n2;
            n1 = n2 - n1;
        }
    }
}
