using System;
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
            //File.Create(@"C:\Users\l\Desktop\GOPR1609d.MP4");
            //Console.WriteLine("创建成功！");
            //File.Delete(@"C:\Users\l\Desktop\GOPR1609d.MP4");

            //复制
            Stopwatch sw = new Stopwatch();
            sw.Start();
            try
            {
                File.Copy(@"C:\Users\l\Desktop\新建文件夹\啊都比.png", @"C:\Users\l\Desktop\新建文件夹\new.png");
                Console.WriteLine("复制成功");
            }
            catch
            {
                File.Delete(@"C:\Users\l\Desktop\新建文件夹\new.png");
                Console.WriteLine("删除成功");
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();

        }
    }
}
