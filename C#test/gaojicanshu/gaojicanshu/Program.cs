using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gaojicanshu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 415, 23, 4, 3, 5, 34, 85, 5 };
            int[] res = GetMaxMinSumAvg(numbers);
            Console.WriteLine("最大值是:{0}；\n最小值是:{1}；\n总和是:{2};\n平均数是:{3};\n", res[0], res[1], res[2], res[3]);
            int max = 0;
            int min = 0;
            int sum = 0;
            int avg = 0;
            bool b;
            string s;
            string msg;
            double d;
            int result;
            bool bl = mytryPrase("123564", out result);
            Console.WriteLine("转换情况：{0}；转换结果：{1}\n", bl, result);
            Test(numbers, out max, out min, out sum, out avg, out b, out s, out d);
            Console.WriteLine("请输入用户名：\n");
            string name = Console.ReadLine();
            Console.WriteLine("请输入密码：\n");
            string pwd = Console.ReadLine();
            b=Program.Islogin(name,pwd,out msg);
            Console.WriteLine("登陆结果：{0}",b);
            Console.WriteLine("登陆状态信息：{0}",msg);
            //Console.WriteLine(max);
            //Console.WriteLine(min);
            //Console.WriteLine(sum);
            //Console.WriteLine(avg);
            //Console.WriteLine("{0} {1} {2}", b, s, d);
            Console.ReadKey();
        }

        public static int[] GetMaxMinSumAvg(int[] nums)
        {
            int[] res = new int[4];
            res[0] = nums[0];
            res[1] = nums[0];
            res[2] = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > res[0])
                {
                    res[0] = nums[i];                
                }
                if(nums[i]<res[1])
                {
                    res[1]=nums[i];
                }
                res[2]+=nums[i];
            }
            res[3]=res[2]/nums.Length;
            return res;
        }

        public static void Test(int[] nums, out int max, out int min, out int sum, out int avg, out bool b, out string s, out double d)
        {
            //out参数要求方法在方法内部必须为其赋值
            max = nums[0];
            min = nums[0];
            sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                if (nums[i] < min)
                {
                    min = nums[i];
                }
                sum += nums[i];
            }
            avg = sum / nums.Length;
            b = true;
            s = "123";
            d = 0.13231;

        }
       
        public static bool Islogin(string name,string pwd,out string msg)
        {
            if (name=="Admin" && pwd=="123456")
            {
                msg = "登陆成功";   //return必须在后面，后面的才能继续执行
                return true;
            }
            else if (name != "Admin")
            {
                msg = "用户名错误";
                return false;
            }
            else if (pwd != "123456")
            {
                msg = "密码错误";
                return false;
            }
            else
            {
                msg = "未知错误";
                return false;
            }
        }

        public static bool mytryPrase(string num, out int result)
        {
            result = 0;
            try
            {
                result = Convert.ToInt32(num);      //转换过程；转换成三三十二位
                return true;
            }
            catch           //如果转换不成功的话，就直接返回错误
            {
                return false;
            }
        }
    
    }
}
