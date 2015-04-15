using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    public enum Genda   //枚举
    {
        male,
        female
    }
    public struct Persion   //结构
    {
        public string _name;
        public int _age;
        public Genda _sex;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Genda s = Genda.female;
            string m = "male";
            Genda g = (Genda)Enum.Parse(typeof(Genda), m);
            Console.WriteLine("ls is {0};\n",s);
            Console.WriteLine(g);

            Persion lq;
            lq._name = "liangqian";
            lq._age = 20;
            lq._sex = Genda.male;
            Console.WriteLine();
            Console.WriteLine("我是{0}，{1}，今年{2}",lq._name,lq._age,lq._sex);
            //int[] nums = { 1, 15, 6, 86, 321, 87, 3 };
            int[] nums;
            nums=new int[10]{12,45,65,354,64,634,3,564,56,564};
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - i - 1; j++)       //比较几次是由前面的i决定的
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
                
            }
            foreach (int op in nums)
            {
                Console.WriteLine("{0}", op);
            }
            Console.WriteLine();
            //Array.Sort(nums);         功能跟前面的的排序算法一样
            Array.Reverse(nums);        //反转
            foreach (int op in nums)
            {
                Console.WriteLine("{0}", op);
            }
                Console.ReadKey();
        }
    }
}
