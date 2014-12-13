using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace changing_value
{
    class Program
    {
        static int SumVals(params int[] vals)
        {
            int sum = 0;
            foreach (int val in vals)
            {
                sum += val;
            }
            return sum;
        }
        static void Main(string[] args)     //将数组的数据相加
        {
            int Sum = SumVals(1, 5, 2, 9, 8);
            Console.WriteLine("Summed Value = {0}", Sum);
            Console.ReadKey();
        }
    }
}
