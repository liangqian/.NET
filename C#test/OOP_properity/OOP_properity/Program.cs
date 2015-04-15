using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_properity
{
    class Program
    {
        static void Main(string[] args)
        {
            persions liangqain = new persions();
            Console.WriteLine("请输入你的名字：");
            liangqain.name = Console.ReadLine();
            Console.WriteLine("输入你的年龄：");
            liangqain.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入你的性别");
            liangqain.gendar = Convert.ToChar(Console.ReadLine());
            liangqain.hello();
            Console.ReadKey();
        }
    }
}
