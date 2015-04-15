using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrary_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums={12,4,-6,96,86,2,35,465,78,-960};
            int max=int.MinValue;   //赋值，int能使用的最小值
            int min=int.MaxValue;   //赋值，int能使用的最大值
            int sum = 0;
            int average;
            for(int i=0;i<nums.Length;i++)
            {
                if(nums[i]>max)
                {
                    max=nums[i];
                }
                if (nums[i] < min)
                {
                    min = nums[i];
                }
                sum += nums[i];
            }
            average = sum / nums.Length;
            Console.WriteLine("这{1}个数中最大的一个是：{0}\n",max,nums.Length);
            Console.WriteLine("这{1}个数中最小的一个是：{0}\n",min,nums.Length);
            Console.WriteLine("这{0}个数的总和是：{1}\n", nums.Length, sum);
            Console.WriteLine("这{0}个数的平均数是：{1}\n", nums.Length, average);
         Console.ReadKey();
        }
    }
}
