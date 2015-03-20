using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arr
{
    class Program
    {
        static void Main(string[] args)
        {
            //数组类型[] 数组名称 = new 数组类型 [数组长度]；
            int[] nums = new int[10];       //数组的长度一旦固定之后不能改变，同时，如果是赋值的话，不能超出数组界限
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i + 1;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            int[] arr = { 1, 2,4, 5, 3, 465, 64 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0}\n", arr[i]);
            }
                //Console.ReadKey();
            string[] name = { "老子", "老马", "老杨", "老张", "老王" };
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            Console.ReadKey();
        }
    }
}
