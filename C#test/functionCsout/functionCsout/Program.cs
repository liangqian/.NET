using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionCsout
{
    class Program
    {
        public static int Getmax(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;   //两个值比较，如果真，则输出n1,否则输出n2；
        }
        public static void PlayGame()
        {
            Console.WriteLine("正在游戏中......\n");
        }
        public static void Single_char()
        {
            string Mystring = "NCEPUNMC";       //定义一个字符串
            char[] Mychar = Mystring.ToCharArray();     //将字符串转换成字符串数组
            foreach (char Single_char in Mychar)
            {
                Console.WriteLine("{0}", Single_char);
            }
            Console.WriteLine();
            //for (int i = 0; i < Mychar.Length; i++)
            //{
            //    char CharTemp;
            //    CharTemp = Mychar[i];
            //    Mychar[i] = Mychar[Mychar.Length - 1 - i];
            //    Mychar[Mychar.Length - 1 - i] = CharTemp;
            //}
            for (int i = 0; i < Mychar.Length; i++)
            {
                Console.WriteLine("{0}\t",Mychar[i]);
            }
        }
        static void Main(string[] args)
        {
            //求两个整数之间的最大值
            int n1 = 41;
            int n2 = 12;
            Console.WriteLine("输出：{0}\n", Program.Getmax(n1, n2));
            Program.PlayGame();
            Program.Single_char();
            Console.ReadKey();

        }
 
    }
}
