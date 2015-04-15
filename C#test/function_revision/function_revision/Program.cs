using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_revision
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入两个数字，第一个要比第二个大
            Console.WriteLine("请输入两个数字（注：第一个要比第二个小）");
            Console.WriteLine("请输入第一个数字");
            string str1 = Console.ReadLine();
            int intnum1 = Getnumber(str1);
            Console.WriteLine("请输入第二个数字");
            string str2 = Console.ReadLine();
            int intnum2 = Getnumber(str2);
            Judge(intnum1, intnum2);
            Console.WriteLine("你输入的是：{0}、{1}",intnum1,intnum2);
            int sum=Getsum(intnum1,intnum2);
            Console.WriteLine("输入的两个数之和：{0}",sum);
            Console.ReadKey();

        }
        public static int Getsum(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Getnumber(string s)
        {
            while (true)
            {
                try
                {
                    int num = Convert.ToInt32(s);
                    return num;
                }
                catch
                {
                    Console.WriteLine("输入有误，请再次输入；");
                    s = Console.ReadLine();
                }
            }
            
        }
        public static void Judge(int n1, int n2)
        {

            while (true)
            {
                if (n1 > n2)
                {
                    Console.WriteLine("你输入的数字不符合第一个比第二个小的要求，请重新输入");
                    string s1 = Console.ReadLine();
                    n1 = Getnumber(s1);
                    Console.WriteLine("请重新输入第二个数字");
                    string s2 = Console.ReadLine();
                    n2 = Getnumber(s2);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
