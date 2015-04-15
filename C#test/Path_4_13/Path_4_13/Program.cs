using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path_4_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"F:\C#2014\特供精品.Net基础全套视频教程2014版--03c#高级\02--面向对象继承\特供.Net基础全套视频教程2014版（第十一天）\video.txt";
            //int indx = str.LastIndexOf("\\");
            //str=str.Substring(indx +1);
            //Console.WriteLine(str);

            Console.WriteLine(Path.GetFileName(str));   //快速获得文件名
            Console.WriteLine(Path.GetFileNameWithoutExtension(str));   //获得文件名，不带扩展名
            Console.WriteLine(Path.GetExtension(str));      //直接获得文件扩展名
            Console.WriteLine(Path.GetDirectoryName(str));  //获得文件夹名称
            Console.WriteLine(Path.GetFullPath(str));       //获得文件所在的目录的全路径
            Console.WriteLine(Path.Combine(@"c:\dic\","b.txt"));    //合并路径


            Console.ReadKey();
        }
    }
}
