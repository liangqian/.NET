using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lishi_zhuanhuan_04_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student s = new Student();
            //Person p = s;       //里氏转换
            //Person p = new Student();

            //string str = string.Join("|", new string[] { "1", "2", "3", "4" });
            //Console.WriteLine(str);

            //if (p is Student)
            //{
            //    Student ss = (Student)p;
            //    ss.StudentSayhllo();
            //}
            //else
            //{
            //    Console.WriteLine("转换失败");
            //}

            //Student t = p as Student;
            //t.StudentSayhllo();


            //创建十个对象，通过循环，去调用

            Student s = new Student();
            Person p = new Person();
            Shuaige sg = new Shuaige();

            Person[] pers = new Person[10];
            Random r = new Random();

            for (int i = 0; i < pers.Length; i++)
            {
                int rNumber = r.Next(1, 7);
                switch (rNumber)
                {
                    case 1: pers[i] = new Student();
                        break;
                    case 2: pers[i] = new Teacher();
                        break;
                    case 3: pers[i] = new Shuaige();
                        break;
                    case 4: pers[i] = new Beautiful_girl();
                        break;
                    case 5: pers[i] = new Yeshou();
                        break;
                    case 6: pers[i] = new Person();
                        break;
                }
            }
            for (int i = 0; i < pers.Length; i++)
            {
                if (pers[i] is Student)
                {
                    ((Student)pers[i]).StudentSayhllo();
                }
                else if (pers[i] is Teacher)
                {
                    ((Teacher)pers[i]).TeacherSayhllo();
                }
                else if (pers[i] is Beautiful_girl)
                {
                    ((Beautiful_girl)pers[i]).Beautiful_sayHello();
                }
                else if (pers[i] is Shuaige)
                {
                    ((Shuaige)pers[i]).ShuaigeSayhello();
                }
                else if (pers[i] is Yeshou)
                {
                    ((Yeshou)pers[i]).SYeshouSayHello();
                }
            }





            Console.ReadKey();
        }
    }
}
