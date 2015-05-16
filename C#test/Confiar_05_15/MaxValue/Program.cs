using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxValue
{
    public delegate int DelCompare(object o1, object o2);
    class Program
    {
        static void Main(string[] args)
        {
            object[] o = { "das", "daskjdkajs", "dkajshdkjahsdhsakjdh" };
            object result = GetMax(o, delegate(object o1, object o2)
            {
                string s1 = (string)o1;
                string s2 = (string)o2;
                return s1.Length - s2.Length;
            });
            Console.WriteLine(result);
        }
        public static object GetMax(object[] nums, DelCompare del)             //比较大小
        {
            object max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                //传递委托进来，怎么比较
                if (del(max, nums[i]) < 0)
                {
                    max = nums[i];
                }
            }
            return max;
        }
        //public static int Compare(object o1, object o2)
        //{
        //    int n1 = (int)o1;
        //    int n2 = (int)o2;
        //    return n1 - n2;
        //}
        //public static int Compare2(object o1, object o2)
        //{
        //    string s1 = (string)o1;
        //    string s2 = (string)o2;
        //    return s1.Length - s2.Length;
        //}


        //public static string GetMax(string[] name)       //最长的字符串 ，比较长度
        //{
        //    string max=name[0];
        //    for (int i = 0; i < name.Length; i++)
        //    {
        //        if (max.Length < name[i].Length)
        //        {
        //            max=name[i];
        //        }
        //    }
        //    return max;
        //}
    }
}
