using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 进程Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] pros = Process.GetProcesses();
            foreach (var items in pros)
            {
                Console.WriteLine(items);
            }
            //Process.Start("calc");
            //Process.Start("mspaint");
            //Process.Start("chrome","http://youtube.com");
            //通过一个进程打开指定文件
            ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\Leong\Desktop\微信截图_20150430160436.png");
            //第一，创建进程
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();

        }
    }
}
