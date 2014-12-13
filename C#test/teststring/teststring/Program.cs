using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teststring
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "This is a test.";        //定义字符串
            char[] separator = {' '};                    //定义字符变量
            string[] myWords;                           //定义字符 数组
            myWords = myString.Split(separator);        //将字符串拆分
            foreach (string word in myWords)           //输出
            {
                Console.WriteLine("{0}",word);
            }
            Console.ReadKey();                          //停顿
        }
    }
}
