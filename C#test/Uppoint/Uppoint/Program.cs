using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppoint
{
    class Program
    {
        static void Main(string[] args)     //冒泡排序法
        {
            int[] nums = { 0, 1, 56, 3, 4, 123, 645, 23, 564, 9 };
            foreach (int i in nums)
            {
                Console.WriteLine("{0}", i);

            }
            Console.WriteLine();
            Array.Sort(nums);   //只能对数组进行升序的排序
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = 0; j < nums.Length - i - 1; j++)
            //    {
            //        if (nums[j] > nums[j + 1])
            //        {
            //            int temp = nums[j];
            //            nums[j] = nums[j + 1];
            //            nums[j + 1] = temp;
            //        }
            //    }

            //}
            foreach (int i in nums)
            {
                Console.WriteLine("{0}", i);
            }
            Console.WriteLine();

            Array.Reverse(nums);
            foreach (int i in nums)
            {
                Console.WriteLine("{0}", i);

            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
