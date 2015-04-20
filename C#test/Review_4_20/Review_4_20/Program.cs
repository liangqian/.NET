using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_4_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();

            //Dictionary<int, string> dic = new Dictionary<int, string>();
            //dic.Add(1, "leishan");
            //dic.Add(2, "liangqian");
            //dic[3] = "dashdkjash";
            //foreach (KeyValuePair<int, string> kv in dic)
            //{
            //    Console.WriteLine("{0}******{1}", kv.Key, kv.Value);
            //}
            //Console.WriteLine();
            //string str;
            //using (FileStream fsread = new FileStream(@"C:\Users\l\Desktop\强哥讲的linux基本命令总结.txt", FileMode.OpenOrCreate, FileAccess.Read))
            //{
            //    byte[] buffer = new byte[1024 * 1024 * 5];      //指定每次读入的长度
            //    int r = fsread.Read(buffer, 0, buffer.Length);
            //    str = Encoding.GetEncoding("UTF-8").GetString(buffer, 0, r);
            //    Console.WriteLine(str);
            //} 
            //using (FileStream fswrite = new FileStream(@"C:\Users\l\Desktop\linux基本命令总结.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    byte[] bb = Encoding.GetEncoding("UTF-8").GetBytes(str);
            //    fswrite.Write(bb,0,bb.Length);

            //}
            //Console.WriteLine("写入成功");

            //多态：一个方法可以表现出多种类型，消除多个子类之间的代码差异
            //虚方法和抽象类

            Persion ps = new Headnster();
            ps.Standup();
            Persion pss = new Teacher();
            pss.Standup();



        }

        public abstract class Persion
        {
            public abstract void Standup();
        }
        public class Student : Persion
        {
            public override void Standup()
            {
                Console.WriteLine("学生起立，校长好");
                //throw new NotImplementedException();
            }
        }
        public class Teacher : Persion
        {
            public override void Standup()
            {
                Console.WriteLine("老师起立，校长好");
                //throw new NotImplementedException();
            }
        }
        public class Headnster : Persion
        {
            public override void Standup()
            {
                Console.WriteLine("校长起来，领导好");
                //throw new NotImplementedException();
            }
        }
        public class Xiaoxuesheng : Persion
        {
            public override void Standup()
            {
                Console.WriteLine("小学生起立，校长好啊");
                //throw new NotImplementedException();
            }
        }




    }
}
