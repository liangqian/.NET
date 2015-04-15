using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace construstor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student Input = new Student();
            //Console.WriteLine("统计成绩");
            //Console.WriteLine("请输入你的姓名：");
            //Input.Name = Console.ReadLine();
            //Console.WriteLine("请输入你的年龄：");
            //Input.Age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("输入你的性别：");
            //Input.Gendar = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine("输入你的语文成绩：");
            //Input.Chinese = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("输入你的数学成绩：");
            //Input.Math = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("输入你的英语成绩：");
            //Input.English = Convert.ToInt32(Console.ReadLine());
            //Input.Sayhello();
            //Input.ShowScore();
            Student s = new Student("张",150,150,150);
            s.Sayhello();
            s.ShowScore();
            

            Student lq = new Student("liangqian",21,'男',150,150,150);       //使用构造函数，在类中；只是写一次代码就够了
            //lq.Name = "liangqian";
            //lq.Age = 21;
            //lq.Gendar = '男';
            //lq.Chinese = 100;
            //lq.Math = 100;
            //lq.English = 100;
            lq.Sayhello();
            lq.ShowScore();
            Student ls = new Student("leishan",21,'女',10,150,150);
            //ls.Name = "leishan";
            //ls.Age = 21;
            //ls.Gendar = '女';
            //ls.Chinese = 130;
            //ls.Math = 130;
            //ls.English = 130;
            ls.Sayhello();
            ls.ShowScore();

            Console.ReadKey();
        }
    }
}
