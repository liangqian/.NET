using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_Review
{
    class Program
    {
        /// <summary>
        /// 声明一个长度50的数组，随机给数组赋值，并可以让用户输入一个数字n，按一行N个数输出数组
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {

                int[] nums = new int[50];
                Random r = new Random();
                for (int i = 0; i < nums.Length; i++)
                {
                    int rNumber = r.Next(0, 10);
                    nums[i] = rNumber;
                }
                Console.WriteLine("请输入一个数字");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write(nums[i] + "\t");    //第4个元素+1%n==0
                    if ((i + 1) % n == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
            catch { }
        }
    }
}
