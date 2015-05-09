using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plus_count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第一个数");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入的两个数中最大的是{0}",GetMax(n1,n2));


        }
        private static int GetMax(int n1, int n2)
        {
            int Maxi;
            if (n1 > n2)
            {
                Maxi = n1;
            }
            else
            {
                Maxi = n2;
            }

            return Maxi;
        }
    }
}
