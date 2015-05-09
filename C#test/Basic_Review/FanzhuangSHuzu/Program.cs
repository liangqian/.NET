using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FanzhuangSHuzu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "中国", "美国", "巴西", "澳大利亚", "加拿大" };
            for (int i = 0; i < str.Length/2; i++)
            {
                string Temp=str[i];
                str[i]=str[str.Length-1-i];
                str[str.Length - 1 - i] = Temp;
            }
            //foreach (var item in str)
            //{
            //    Console.Write("{0}\t",item);
            //}
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write("{0}\t",str[i]);
            }
        }
    }
}
