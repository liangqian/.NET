using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Nums = { 12, 3, 5, 71, 93, 33, 4, 4, 6, 8, 10 };
            Console.WriteLine("这几个数的平均数是{0:0}", GetAverage(Nums));
            Console.WriteLine("将这几个数按照冒泡排序的升序是：");
            int[] NewNums = GetOrder(Nums);
            for (int i = 0; i < NewNums.Length; i++)
            {
                Console.WriteLine(NewNums[i]);
            }
            Array.Reverse(Nums);
            for (int i = 0; i < NewNums.Length; i++)
            {
                Console.WriteLine(NewNums[i]);
            }
        }
        public static double GetAverage(int[] Nums)
        {
            double sum = 0;
            for (int i = 0; i < Nums.Length; i++)
            {
                sum += Nums[i];
            }
            double average = sum / Nums.Length;
            return average;
        }
        public static int[] GetOrder(int[] Nums)
        {
            for (int i = 0; i < Nums.Length - 1; i++)
            {
                for (int j = 0; j < Nums.Length - i - 1; j++)
                {
                    if (Nums[j] > Nums[j + 1])
                    {
                        int Temp = Nums[j];
                        Nums[j] = Nums[j + 1];
                        Nums[j + 1] = Temp;
                    }
                }
            }
            return Nums;
        }


    }
}
