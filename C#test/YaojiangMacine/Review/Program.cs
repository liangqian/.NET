using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            ////通过进程打开应用程序
            //Process.Start("notepad");
            //Process.Start("iexplore","http://baidu.com");
            //Process.Start("chrome","http://google.com");

            ////通过进程打开指定的文件
            //ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\Leong\Desktop\putty.exe");
            //Process p = new Process();
            //p.StartInfo = psi;
            //p.Start();
            
            //进程跟线程的关系？ 一个进程是包含多个线程；单线程容易造成程序的假死
            //前台线程，后台线程
            /* Start（）；标志线程随时可以调用
             * 不允许跨线程的，但是，取消跨线程的检测就可以
             */



        }
    }
}
