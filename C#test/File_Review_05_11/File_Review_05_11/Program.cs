using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace File_Review_05_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\Users\Leong\Desktop\linux基本命令总结.txt";
            //Console.WriteLine( Path.ChangeExtension(path,"jpg"));

            //string path = @"C:\Users\Leong\Desktop\linux基本命令总结.txt";
            //Console.WriteLine(Path.GetDirectoryName(path)); //获得目录

            //File,操作文件
            //File.Create(@"C:\Users\Leong\Desktop\l总结.txt");
            //File.Delete(@"C:\Users\Leong\Desktop\l总结.txt");
            //File.Copy(@"C:\Users\Leong\Desktop\linux基本命令总结.txt", @"C:\Users\Leong\Desktop\linux基本命令总结1.txt");
            

            //使用FIle类读取数据 
            //byte[] Rf= File.ReadAllBytes(@"C:\Users\Leong\Desktop\linux基本命令总结.txt");

            //string str = Encoding.UTF8.GetString(Rf,0,Rf.Length) ;
            //Console.WriteLine(str);

            //string[] str = File.ReadAllLines(@"C:\Users\Leong\Desktop\linux基本命令总结.txt",Encoding.UTF8);
            //foreach (var item in str)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine( File.ReadAllText(@"C:\Users\Leong\Desktop\linux基本命令总结.txt"));

            //===================我是分割线=====================================
            //string str = File.ReadAllText(@"C:\Users\Leong\Desktop\linux基本命令总结.txt");
            //byte[] bf = Encoding.UTF8.GetBytes(str);
            ////File.WriteAllBytes(@"C:\Users\Leong\Desktop\今天是最后一天复习了.txt",bf);
            ////File.WriteAllLines(@"C:\Users\Leong\Desktop\今天是最后一天复习了.html",new string[] {str});
            //File.AppendAllText(@"C:\Users\Leong\Desktop\今天是最后一天复习了.txt",str);

            //Directory.CreateDirectory(@"C:\Users\Leong\Desktop\xinjianwenjianjia");
            //Directory.Delete(@"C:\Users\Leong\Desktop\xinjianwenjianjia",true);

            //string[] str= Directory.GetFiles(@"C:\Users\Leong\Desktop\Temple Document","*.flv");
            //foreach (var item in str)
            //{
            //    Console.WriteLine(item);
            //}


            




            


        }
    }
}
