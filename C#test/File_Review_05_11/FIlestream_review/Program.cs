using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FIlestream_review
{
    class Program
    {
        

        static void Main(string[] args)
        {
         //string str;

            ////FileStream StreamReader StreamWriter  
            ////垃圾回收系统不会回收文件流的资源
            //using (FileStream fsRead = new FileStream(@"C:\Users\Leong\Desktop\工资表.txt", FileMode.OpenOrCreate, FileAccess.Read))
            //{
            //    byte[] bf = new byte[1024 * 1024 * 5];      //控制每次读取的文件数量，防止出现撑死
            //    //表示本次读取到的实际有效字节数
            //    int r = fsRead.Read(bf, 0, bf.Length);
            //    string s = Encoding.UTF8.GetString(bf, 0, r);
            //    Console.Write(s);
            //    str = s;

            //}

            //using (FileStream fsWrite = new FileStream(@"C:\Users\Leong\Desktop\工.txt", FileMode.Append, FileAccess.Write))
            //{
            //    string s = str; 
            //    byte[] bf = Encoding.UTF8.GetBytes(s);
            //    fsWrite.Write(bf,0,bf.Length);
            //}

            //using (FileStream fsRead = new FileStream(@"C:\Users\Leong\Desktop\工资表.txt", FileMode.OpenOrCreate, FileAccess.Read))
            //{
            //    using (StreamReader sr = new StreamReader(fsRead))
            //    {
            //        while (!sr.EndOfStream)
            //        {
            //            Console.WriteLine(sr.ReadLine());
            //        }
            //    }
            //}

            //using (StreamWriter sw = new StreamWriter(@"C:\Users\Leong\Desktop\工资.txt",true,Encoding.Default,(new byte[1024*1024]).Length))
            //{
            //    sw.WriteLine("hhhhhhh");
            //}

            string Newstr;
            using (FileStream fsRead = new FileStream(@"C:\Users\Leong\Desktop\工资表.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer=new byte[1024*1024*5];
                int r = fsRead.Read(buffer,0,buffer.Length);
                string str = Encoding.UTF8.GetString(buffer,0,r);
                Newstr = str;
                Console.WriteLine(str);
            }

            using (FileStream fsWrite = new FileStream(@"C:\Users\Leong\Desktop\工资表.txt", FileMode.Append, FileAccess.Write))
            {
                byte[] buffer = Encoding.UTF8.GetBytes(Newstr);
                fsWrite.Write(buffer,0,buffer.Length);
            }



        }
    }
}
