using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_4_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Hashtable ht = new Hashtable();
            ht.Add(1, "张三");
            ht.Add(2, true);
            ht.Add(3, '男');
            ht.Add(false, "错误的");
            ht[1] = "NEw";  //替换掉原来的值

            //abc----cba
            if (!ht.ContainsKey("abc"))
            {
                ht.Add("abc", "cba");
            }
            else
            {
                Console.WriteLine("已经包含了这个值");
            }


            //ht.Clear();
            try
            {
                ht.Remove("abc");
            }
            catch
            {
                ht.Clear();
            }


            //在键值对集合中，是通过键找值
            string zx = (string)ht[false];
            Console.WriteLine(zx);
            Console.WriteLine(ht[1]);   //根据键找值
            foreach (var i in ht.Keys)  //遍历循环，避免了for中无法识别的false索引---（效率高高）
            {
                Console.WriteLine("{0}-{1}", i, ht[i]);

            }
            Console.WriteLine();
            
            
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            //for (int i = 0; i < ht.Count; i++)
            //{
            //    Console.WriteLine(ht[i]);   //注意：不能遍历出false
            //}
            Console.ReadKey();


        }
    }
}
