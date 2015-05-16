using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Confiar_05_15
{
    class Program
    {
        //声明委托
        public delegate string DelProStr(string name);
        static void Main(string[] args)
        {
            //三个需求
            //1、将字符串数组中每个元素转换成大写
            //2、将一个字符串数组中的每个元素都转换成小写
            //3、将一个字符串数组中每个元素两边都加上双引号

            string[] names = { "abCde", "HijkLmn", "Opqrst", "UvwXyz" };
            //PrcessStrSYH(names);

            Prostr(names, delegate(string name)
            {
                return "\""+name+"\" ";                    //匿名函数
            });


            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }




        }
        public static void Prostr(string[] name, DelProStr del)
        {
            for (int i = 0; i < name.Length; i++)
            {
                name[i] = del(name[i]);
            }
        }
        //public static string StrToupper(string name)
        //{
        //    return name.ToUpper();
        //}
        //public static string StrTolower(string name)
        //{
        //    return name.ToLower();
        //}
        //public static string StrSYH(string name)
        //{
        //    return "\"" + name + "\"";
        //}


        //public static void ProcessStrToUpper(string[] names)
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        names[i] = names[i].ToUpper();
        //    }
        //}

        //public static void ProcessStrTolower(string[] names)
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        names[i] = names[i].ToLower();
        //    }
        //}

        //public static void PrcessStrSYH(string[] names)
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        names[i] ="\""+ names[i]+"\"";
        //    }
        // }


    }
}
