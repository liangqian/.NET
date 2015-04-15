using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_test
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建persion类的对象,就是实例化一个类的过程
            persion liangqian = new persion();
            study Roy = new study();
            liangqian.age = 22;
            liangqian.Gendar ='男';
            liangqian._name = "梁仟";
            liangqian.CHLSS();
            Console.WriteLine("请输入你的科目：");
            Roy._subject = Console.ReadLine();
            Console.WriteLine("请输入你的得分：");
            Roy.marks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入你的任课老师：");
            Roy._masterTeacher = Console.ReadLine();
            Roy.lesson();
            persion leishan = new persion();
            leishan.age = 21;
            leishan.Gendar='女';
            leishan._name = "累闪";
            leishan.CHLSS();
            leishan.hao();
            Console.ReadKey();
        }
    }
}
