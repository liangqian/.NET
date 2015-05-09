using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace String_05_08
{
    class Program
    {
        static void Main(string[] args)
        {
            //15.	用方法来实现：有一个字符串数组：{ "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" },请输出最长的字符串。
            string[] name = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            Console.WriteLine("最长的名字是：{0}",Getlongeststr(name));
            

        }
        public static string Getlongeststr(string[] name)
        {
            string max=name[0];
            for (int i = 1; i < name.Length; i++)
            {
                if (name[i].Length > max.Length)
                {
                    max=name[i];
                }
            }
            return max;
        }
    }
}
