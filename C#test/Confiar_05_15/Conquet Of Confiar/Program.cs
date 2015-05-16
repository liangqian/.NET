using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conquet_Of_Confiar
{
    class Program
    {
        //声明一个委托指向一个函数   ，跟所指向的函数有相同的签名
        public delegate void DelSayhi(string name);



        static void Main(string[] args)
        {
            //DelSayhi del = SayhiChinese;//new DelSayhi(SayhiChinese);     //创建委托对象指向一个函数    ,或者使用方法作为类型传递
            //del("LS");
            //Test("LQ",del);

            //DelSayhi ddel = SayhiEnglish;
            //ddel("BBB");

            Test("LQ",SayhiEnglish);
            Test("LSS",SayhiChinese);

        }

        public static void Test(string name,DelSayhi del)
        {
            //调用
            del(name);
            
        }
        public static void SayhiChinese(string name)
        {
            Console.WriteLine("吃了吗？"+name);
        }
        public static void SayhiEnglish(string name)
        {
            Console.WriteLine("Nice to meet Yuo"+name);
        }
    }
}
