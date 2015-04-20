using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flie_4_13
{
    class Program
    {
        static void Main(string[] args)
        {
            ////File.Create(@"C:\Users\l\Desktop\GOPR1609d.MP4");
            ////Console.WriteLine("创建成功！");
            ////File.Delete(@"C:\Users\l\Desktop\GOPR1609d.MP4");

            ////复制
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //try
            //{
            //    File.Copy(@"C:\Users\l\Desktop\新建文件夹\啊都比.png", @"C:\Users\l\Desktop\新建文件夹\new.png");
            //    Console.WriteLine("复制成功");
            //}
            //catch
            //{
            //    File.Delete(@"C:\Users\l\Desktop\新建文件夹\new.png");
            //    Console.WriteLine("删除成功");
            //}
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);
            //Console.ReadKey();

            //ArrayList list = new ArrayList();
            //list.Add(123);
            //list.AddRange(new int[] { 54, 6, 86, 98, 54 });
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            //Hashtable ht = new Hashtable();
            //ht.Add(1,"123");
            //ht.Add(2,new int[] {1,5,67,3,564,14});
            //ht.Add(3.14,"什么鬼");
            //if (ht.ContainsKey(3.14))   //判断是否存在某个值
            //{
            //    Console.WriteLine("这里确实存在“什么鬼”");
            //}
            //foreach(var item in ht.Keys)
            //{
            //    Console.WriteLine("键--{0}，值=={1}",item,ht[item]);
            //}
            //string name = Path.GetFileNameWithoutExtension(@"C:\Users\l\Desktop\MATLAB实验报告.pdf");
            //Console.WriteLine(name);

            //Byte[] filename_1= File.ReadAllBytes(@" C:\Users\l\Desktop\新建文本文档.txt");
            ////将字节数组中的每一个元素都要按照我们指定的编码格式解码成字符串
            ////UTF-8 GB2312 GBK ASCII Unicode
            //string filename= Encoding.GetEncoding("UTF-8").GetString(filename_1);
            //Byte[] filename1= Encoding.Default.GetBytes(filename);
            //File.WriteAllBytes(@"C:\Users\l\Desktop\Test.txt",filename1);


            //Console.WriteLine(filename);

            //string[] cont= File.ReadAllLines(@"C:\Users\l\Desktop\Test.txt",Encoding.Default);
            //foreach(string item in cont)
            //{
            //    Console.WriteLine(item);
            //}
            //string str = File.ReadAllText(@"",Encoding.Default);
            //Console.WriteLine(str);

            File.WriteAllLines(@"C:\Users\l\Desktop\Test1.txt", new string[] { "fe", "das", "asd" });
            Console.WriteLine("OK");




            Console.ReadKey();

        }
    }
}
