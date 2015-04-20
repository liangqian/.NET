using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream_4_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //对于大文件
            //FileStream    操作字节
            //StreamReader  StreamWriter    操作字符

            //FileStream fsRead = new FileStream(@"C:\Users\l\Desktop\吃.txt", FileMode.OpenOrCreate, FileAccess.Read);  //文件的操作，文件内容的操作
            //byte[] buffer = new byte[1024 * 5 * 1024];        //定义每次读取的字节数
            //int r = fsRead.Read(buffer, 0, buffer.Length);     //定义读取文件的长度,根据文件长度判断
            //string s = Encoding.GetEncoding("UTF-8").GetString(buffer, 0, r); //限制解码的起始部分。从0开始读到r
            //fsRead.Close();     //关闭文件流
            //fsRead.Dispose();   //进行GC不能进行的垃圾回收机制
            //Console.WriteLine("{0}{1}", r, s);

            //using (FileStream fsWrite = new FileStream(@"C:\Users\l\Desktop\New.txt",FileMode.OpenOrCreate,FileAccess.Write))
            //{
            //    string str = Console.ReadLine();
            //    byte[] buffer1 = Encoding.Default.GetBytes(str); //获取字符数组
            //    fsWrite.Write(buffer1,0,buffer1.Length);      //定义写入长度
            //}
            //Console.WriteLine("写入完成");

            //对多媒体文件的负责，原理就是读取跟写入
            //string source = @"C:\Users\l\Desktop\8、使用FileStream实现多媒体文件的复制.avi";
            //string target = @"C:\Users\l\Desktop\NEW.avi";
            //CopyFile(source,target);
            //Console.WriteLine("复制成功");

            //使用streamread读取文本文件
            using (StreamReader sr = new StreamReader(@"C:\Users\l\Desktop\吃.txt"))
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());   //打印读取到的文本，实际读取操作就是sr.ReadLine()
                }
            }
            //使用streamwrite读取文件
            using (StreamWriter sw = new StreamWriter(@"C:\Users\l\Desktop\rename.txt"))    //定义写入目标地址
            {
                sw.Write(Console.ReadLine());   //进行写入操作
            }
            Console.WriteLine("OK ");





        }

        //public static void CopyFile(string source, string target)
        //{
        //    //创建负责写入的流
        //    using (FileStream fsread=new FileStream (target,FileMode.OpenOrCreate,FileAccess.Read))
        //    {
        //        byte[] buffer = new byte[1024*1024*5];
        //        while(true)
        //        {
        //            //文件可能比较大，所以读取的时候通过循环读取
        //            //返回一次读取能读取到的字节数
        //            int r = fsread.Read(buffer, 0, buffer.Length);
        //            if (r == 0)
        //            {
        //                break;
        //            }
        //            fsread.Write(buffer,0,r);
        //        }



        //    }
        //}

    }
}
