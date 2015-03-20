using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmunList
{
    public enum Genda
    {
        男,
        女
    }
    public enum Seasons
    {
        Spring,
        Sunmer,
        Autumn,
        winter
    }
    public enum QQstate
    {
        Online = 10,    //设置枚举强制转换的时候的起始编码数
        offline,        //11
        Busy,           //12
        Away,           //13
        Qme             //14
    }
    public enum Qstate
    {
        Online = 1,
        offline,
        busy,
        Away,
        Qme
    }
    public enum Ncepu
    {
        运行部,
        技术部,
        办公室,
        信息部,
        组织部
    }
    class Program
    {
        static void Main(string[] args)
        {
            int l = 3;      //与这个相似
            string o = "技术部";
            Genda M = Genda.男;  //调用枚举变量里面的值
            Seasons S = Seasons.winter;
            Console.WriteLine("{0}是{1}的美好季节！", S, M);
            Console.WriteLine(QQstate.Qme);
            Console.WriteLine((int)QQstate.Away);       //枚举类型强制转换成数字类型
            Console.WriteLine((int)QQstate.Online);
            Seasons season = (Seasons)l;                //将数字类型强制转换成枚举类型的内容
            Seasons sea = (Seasons)87;
            Ncepu bu = (Ncepu)Enum.Parse(typeof(Ncepu),o);  //将字符串转换成枚举类型里面的内容，记住这个语法！！（字符串类型与枚举默认类型是兼容的）
            Console.WriteLine(season);
            Console.WriteLine(sea);                     //如果目标转换类型不存在，直接显示的是该数字
            Console.WriteLine(bu);
            //Console.ReadKey();

            //选择QQ状态
            Console.WriteLine("请选择一个QQ状态：  \n 1--在线 2--离线 3--繁忙 4--离开 5--Q我吧");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1": Qstate s1 = (Qstate)Enum.Parse(typeof(Qstate), input);
                    Console.WriteLine("你的在线状态是{0}",s1);
                    break;
                case "2": Qstate s2 = (Qstate)Enum.Parse(typeof(Qstate), input);
                    Console.WriteLine("你的在线状态是{0}",s2);
                    break;
                case "3": Qstate s3 = (Qstate)Enum.Parse(typeof(Qstate), input);
                    Console.WriteLine("你的在线状态是{0}", s3);
                    break;
                case "4": Qstate s4 = (Qstate)Enum.Parse(typeof(Qstate), input);
                    Console.WriteLine("你的在线状态是{0}", s4);
                    break;
                case "5": Qstate s5 = (Qstate)Enum.Parse(typeof(Qstate), input);
                    Console.WriteLine("你的在线状态是{0}", s5);
                    break;
            }
            Console.ReadKey();
        }
    }
}
