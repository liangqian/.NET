using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Average_marks
{
    class Program
    {
        /// <summary>
        /// 18.	为教师编写一个程序，该程序使用一个数组存储30个学生的考试成绩，
        /// 并给各个数组元素指定一个1-100的随机值，然后计算平均成绩。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] vals=new int[30];
            Random r = new Random();
            for (int i = 0; i < vals.Length; i++)
            {
                vals[i] = r.Next(0,100);
            }
            Console.WriteLine("这三十个学生的成绩是：{0:0.00}",Avg(vals));

        }
        public static double Avg(int[] vals)
        {
            double avg = 0;
            int sum = 0;
            for (int i = 0; i < vals.Length; i++)
            {
                sum += vals[i];
            }
            avg = sum / vals.Length;
            return avg;
        }
    }
}
