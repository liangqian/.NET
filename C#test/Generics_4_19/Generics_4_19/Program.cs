using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_4_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();   //确定集合的类型
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            //list.AddRange(list);
            //int[] Nums = list.ToArray();    //泛型转化为数组
            //List<int> listTwo = Nums.ToList();  //数组转化成泛型
            //foreach (int item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //char[] chs = { 's','d','a'};
            //List<char> listchar = chs.ToList();
            //char[] chs2 = listchar.ToArray();
            //foreach (char item in listchar)
            //{
            //    Console.WriteLine(item);
            //}


            //拆箱，装箱
            //int n = 10;
            //object o = n;   //把值类型转化成引用类型
            //int nn = (int)o;    //拆箱
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            ////ArrayList list = new ArrayList();   //00:00:01.2725077
            //List<int> list = new List<int>();   //00:00:00.1745848  //泛型就是避免了装箱根拆箱的过程
            //for (int i = 0; i < 10000000;i++ )
            //{
            //    list.Add(i);    //进行装箱操作
            //}
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);

            


            Console.ReadKey();

        }
    }
}
