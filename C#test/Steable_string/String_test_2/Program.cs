using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入你心中想的那个人的名字：");
            //string name = Console.ReadLine();
            //Console.WriteLine("你心中想的那个人的名字长度是：{0},{1}",name.Length,name.ToUpper());

            //Console.WriteLine("请输入你们俩喜欢的课程，(❤ ω ❤)");
            //string s1 = Console.ReadLine();
            //Console.WriteLine("再输入");
            //string s2 = Console.ReadLine();
            ////s2 = s2.ToUpper();
            //if (s1.Equals(s2,StringComparison.OrdinalIgnoreCase))   //比较的时候，调用比较算法，忽略大小的差异
            //{
            //    Console.WriteLine("你们俩喜欢的课程一样：(❤ ω ❤)");
            //}
            //else
            //{
            //    Console.WriteLine("你们喜欢的课程不同(❤ ω ❤)");
            //}

            //string s = "a d f + _ =r ";
            //char[] chs = { ' ','+','_','='};
            //string[] str = s.Split(chs, StringSplitOptions.RemoveEmptyEntries);

            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}

            string s = "2015-04-03 22:21:00";

            char[] chs = { '-'};
            string[] data = s.Split(new char[] { '-','：' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }




            Console.ReadKey();
        }
    }
}
