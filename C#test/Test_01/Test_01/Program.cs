using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你的考试成绩：");
            int cscore = Convert.ToInt32(Console.ReadLine());
            string lever = GetLevel(cscore);
            Console.WriteLine("你得到的成绩等级是：{0}",lever);
        }

        public static string GetLevel(int score)
        {
            string level = null;
            if (score > 90)
            {
                level = "优";
            }
            else if (score >= 80)
            {
                level = "良";
            }
            else if (score >= 70)
            {
                level = "中";
            }
            else if (score >= 60)
            {
                level = "差";
            }
            else
            {
                level = "不及格";
            }  


            return level;
        }
    }
}
