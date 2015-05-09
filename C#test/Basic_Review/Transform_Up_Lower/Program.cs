using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Transform_Up_Lower
{
    class Program
    {
        /// <summary>
        /// 编写一个函数,接收一个字符串,把用户输入的字符串中的第一个字母转换成小写然后返回(命名规范  骆驼命名)   name       s.SubString(0,1)      s.SubString(1);
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个字符串");
            string s = Console.ReadLine();
            string sNew = ProcessStr(s);
            Console.WriteLine(sNew);
        }
        public static string ProcessStr(string str)
        {
            string s = str.Substring(0, 1).ToLower();
            return s + str.Substring(1);
        }
    }
}
