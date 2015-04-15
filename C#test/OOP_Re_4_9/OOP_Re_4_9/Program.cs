using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Re_4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string s1 = "今天天气真好他们在跳啦啦操呢";
            string[] shs = s1.Split();
            foreach (string i in shs)
            {
                //Console.WriteLine(i);
            }
            sw.Stop();
            //Console.WriteLine(sw.Elapsed);
            if (s1.Contains("啦啦操"))     //替换是否包含 相关字符串
            {
                s1 = s1.Replace("啦啦操", "***");   //字符串替换
            }
            //Console.WriteLine(s1);
            Console.WriteLine();
            string s2 = s1.Substring(2, 4);
            //Console.WriteLine(s2);
            Console.WriteLine();
            Console.WriteLine(s1);
            if (s1.StartsWith("今天"))    //判断开头字符
            {
                //Console.WriteLine("这是以‘今天’开头的");
            }
            if (s1.EndsWith("呢"))       //判断结尾字符
            {
                //Console.WriteLine("这句话是以‘呢’结尾");
            }

            int index1 = s1.IndexOf("*", 0);    //从标志位开始算起第一次出现
            int index2 = s1.LastIndexOf("*");   //默认是从开头开始
            int sL = index2 - index1;
            string s3 = s1.Substring(index1, sL + 1);     //把字符中的‘***’截取下来
            Console.WriteLine(s3);


            string str = "  ds d d  ";
            string str1 = str.Trim();   //去字符空格
            Console.WriteLine(str1);
            str1 = str.TrimStart();
            Console.WriteLine(str1);
            if (s1.Contains("***"))
            {
                s1 = s1.Replace("***", "健美");
            }
            char[] chs = s1.ToCharArray();
            for (int i = 0; i < chs.Length; i++)
            {
                Console.WriteLine(chs[i]);
            }
            Console.WriteLine();
            string swd = string.Join("||", chs);
            Console.WriteLine(swd);

            Console.ReadKey();

        }
    }
}
