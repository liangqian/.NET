using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steable_string
{
    class Program
    {
        static void Main(string[] args)
        {
            ////字符串的不可变性
            //string name = "梁仟";
            //name = "累闪";
            //Console.WriteLine(name);
            //Console.ReadKey();

            //string s1 = "zhangsan";
            //string s2 = "zhangsan"; 
            //s1,s2共同指向堆中的同一块空间

            //string&char

            //string s = "abcdefg";   //通过下标访问每个字符,但是不能改变
            //s[0] = 'p'; //不能实现，因为只读

            //char[] ch = s.ToCharArray();

            //s=new string(ch);

            //Console.WriteLine("{0} {1}",s[1],ch[2]);

            StringBuilder sb = new StringBuilder();
            string str = null;
            //创建了一个定时器，记录程序运行时间
            //Stopwatch sw = new Stopwatch();     //调用计时类
            //sw.Start(); //开始计时
            //for (int i = 0; i < 100; i++)
            //{
            //    str += i;
            //}
            //sw.Stop();  //停止计时
            //Console.WriteLine(sb.ToString());
            //Console.WriteLine(sw.Elapsed);  //输出运行时间

            //string str = "国家关键人物老赵";
            //if (str.Contains("老赵"))
            //{
            //    str= str.Replace("老赵","**");    //如果检测有老赵的关键字，就用**,替换
            //}
            //Console.WriteLine(str);

            //substring   截取字符串

            //string str = "今天天气很好，出处好风光";
            //str= str.Substring(1,6);      //截取指定的字符(截取起点，字符长度)
            //Console.WriteLine(str);

            //string str1 = "今天天气很好，出处好风光。";
            //if (str1.StartsWith("今天"))
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}
            //if (str1.EndsWith("风光"))
            //{
            //    Console.WriteLine("是以风光结尾");
            //}
            //else
            //{
            //    Console.WriteLine("不是以风光结尾");
            //}

            string str1 = "今2234天天气很好，出处好风光";
            int index = str1.IndexOf("天", 2); //字符串中字符第一次出现的位置
            Console.WriteLine(index);

            //string str = "今天天气很好,出处好风光";
            //int index = str.LastIndexOf("风");     //最后一次出现的位置
            //Console.WriteLine(index);

            //string path = @"c:s\d\a\v\c\sd\g\lei.mp3";
            //int index = path.LastIndexOf("\\"); //帅选出最后一次出现\的位置,\\表示是\(转义字符）
            //Console.WriteLine(index);
            //path= path.Substring(index+1);  //不包括所指定的起始位
            //Console.WriteLine(path);

            //string str = "           djsk       ds dsj   "; // 去掉不了中间的空格
            //str = str.Trim();   //去掉字符前面和后面的空格，可以代替下面两行
            //str = str.TrimStart();    //去掉字符前面的空格
            //str = str.TrimEnd();  //去掉后面的空格
            //Console.WriteLine(str);

            //string str = Console.ReadLine();
            //if (string.IsNullOrEmpty(str))    //判断空字符
            //{
            //    Console.WriteLine("是空字符串");
            //}
            //else
            //{
            //    Console.WriteLine("不是空字符");
            //}

            //string[] name = { "张三", "4", "5", "6" };
            //string strNew = string.Join("|","ds","ds","dsew","dwdeqw");  //往数组中插入分隔符,后面的是待插入的数组
            //Console.WriteLine(strNew);


            ////倒叙循环
            //string str = Console.ReadLine();
            //for (int i = str.Length - 1; i > 0; i--)
            //{
            //    Console.WriteLine(str[i]);
            //}



            ////字符倒转
            //string str = Console.ReadLine();
            //char[] chs = str.ToCharArray();     //将string转成char数组
            //for (int i = 0; i < chs.Length / 2; i++)
            //{
            //    char temp = chs[i];
            //    chs[i] = chs[chs.Length - i - 1];
            //    chs[chs.Length - i - 1] = temp;
            //}
            //for (int i = 0; i < chs.Length; i++)
            //{
            //    Console.WriteLine(chs[i]);
            //}
            //str = new string(chs);
            //Console.WriteLine(chs);


            ////字符倒置
            //string str = "Hello C Sharp";
            //string[] strNew = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < strNew.Length; i++)
            //{
            //    Console.WriteLine(strNew[i]);
            //}
            //for (int i = 0; i < strNew.Length / 2; i++)
            //{
            //    string trmp = strNew[i];
            //    strNew[i] = strNew[strNew.Length - i - 1];
            //    strNew[strNew.Length - i - 1] = trmp;
            //}
            //for (int i = 0; i < strNew.Length; i++)
            //{
            //    Console.WriteLine(strNew[i]);
            //}




            Console.ReadKey();

        }
    }
}
