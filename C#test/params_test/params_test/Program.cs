using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace params_test
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] score = { 80, 79, 93 };
            //Program.Inpull("装三",score);
            Inpull("张三",79,89,38,89);   //
            Console.ReadKey();
        }

        public static void Inpull(string name,int id, params int[] score)  //params定义不定项的数组
        {
            int sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            Console.WriteLine("{0}这次考试的总成绩是{1},学号是{2}", name, sum,id);
        }
    }
}
