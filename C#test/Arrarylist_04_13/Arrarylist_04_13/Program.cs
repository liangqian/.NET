using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrarylist_04_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add(3.14);
            //list.Add("LQ");
            //list.Add(true);
            //list.Add('男');
            ////list.Clear();
            //list.Add(5000m);
            //list.AddRange(new int[] {1,1,54,3,546,});
            //list.AddRange(new string[] {"sd","dsdakjh",""});
            ////list.AddRange(list);  //反转
            ////list.RemoveRange(8,8);
            //list.Insert(1,"dlkasjhdkjlas");
            //list.InsertRange(0, new int[] { 2, 6, 36, 635 });
            //bool f= !list.Contains(1);
            //Console.WriteLine(f);
            //list.Reverse();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    //if (list[i] is Person)
            //    //{
            //    //    ((Person)list[i]).SayHllo();
            //    //}
            //    //else if (list[i] is int[])
            //    //{
            //    //    for (int j = 0; j < ((int[])list[i]).Length; j++)
            //    //    {
            //    //        Console.WriteLine(((int[])list[i])[j]);
            //    //    }
            //    //}
            //    //else
            //    //{
            //        Console.WriteLine(list[i]);
            //    //}
            //}


            //ArrayList list = new ArrayList();
            ////count 实际包含
            //// capcty 可以包含
            //list.Add(1);
            //list.Add(5);
            //list.Add(5);
            //list.Add(5);
            //list.Add("dioqwooowooohhkl");
            //Console.WriteLine(list.Count);      //显示当前集合长度
            //Console.WriteLine(list.Capacity);   //显示数组能存储的集合长度

            //ArrayList list = new ArrayList();
            //list.AddRange(new int[] { 5, 687, 6, 564, 987, 534, 36 });
            //int sum = 0;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    sum += (int)list[i];        //因为默认的list数组中添加的对象默认是objct类型（object类型是一起类的父类，在这里是进行里氏转换，强转成int）
            //}
            //Console.WriteLine(sum);
            //list.Sort();
            //list.Reverse();
            //int max = (int)list[0];
            //Console.WriteLine(max);

            ArrayList list = new ArrayList();
            Random r = new Random();
            int yum = r.Next(1,100);
            for (int i = 0; i < 10; i++)
            {
                int rNum = r.Next(0, 10);
                //判断重复
                if (!list.Contains(rNum))
                {
                    list.Add(rNum);
                }
                else
                {
                    i--;    //如果有数据未赋值成功，那么，重来
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }


            Console.ReadKey();

        }
    }
}
