using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Count_100_plus
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sum=0;
            //Console.WriteLine("一百个数的和：");
            //for (int i = 0; i <= 100; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            int[] nums = { 12, 56, 6, 534, 8, 3, 34, 345, 8678643 };
            int mmm = GetMax(020, 206, 223, 102);         //用了parmas之后，传入参数可以是数组，也可以是数，那就是可变参数
            Console.WriteLine(mmm);
            Console.WriteLine("1-100的奇数和是：");
            Console.WriteLine(GetJIsum());
            Console.WriteLine("1-100的所有素数之和：{0}", GetPrimeSum());
            Console.WriteLine(Isprime(GetPrimeSum()));
            Console.ReadKey();


        }
        public static int GetMax(params int[] val)  // parmas表示可变参数
        {
            int max = val[0];
            for (int i = 1; i < val.Length; i++)
            {
                if (val[i] > max)
                {
                    max = val[i];
                }
            }
            return max;

        }
        public static int GetJIsum()
        {
            int sum = 0;
            for (int i = 0; i < 101; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            return sum;


        }
        public static bool Isprime(int n)
        {
            if (n < 2)    //小于2的是1，肯定不是素数
            {
                return false;
            }
            else
            {
                for (int i = 2; i < n; i++)         //判断素数
                {
                    if (n % i == 0)                           //如果有能被1和它本身整除的就不是素数
                    {
                        return false;
                    }

                }
                return true;
            }
        }
        public static int GetPrimeSum()
        {
            int sum = 0;
            for (int i = 0; i < 101; i++)
            {
                if (Isprime(i))     //判断是否为素数
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
