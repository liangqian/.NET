using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 匿名函数
{
        delegate  void DelSayHi(string name);

    class Program
    {
        static void Main(string[] args)
        {
            //DelSayHi del = delegate(string name)   //匿名函数
            //{
            //    Console.WriteLine("你好"+name);
            //};
            //del("Liangqian");
            //del("Leishan");

            Console.WriteLine();
            Console.WriteLine("Lamda 表达式");
            Console.WriteLine();

            //DelSayHi dell = (string name) => { Console.WriteLine("你好"+name); };
            //dell("shanshan");
            //Console.WriteLine();

            DelSayHi del = delegate(string name) { Console.WriteLine("你好呀"+name); };
            del("啥觉得好");

          



        }
      
        //public static void SayHiChinese(string name)
        //{
        //    Console.WriteLine("你好"+name);
        //}
        //public static void SayHiEnglish(string name)
        //{
        //    Console.WriteLine("Hello"+name);
        //}
    }
}
