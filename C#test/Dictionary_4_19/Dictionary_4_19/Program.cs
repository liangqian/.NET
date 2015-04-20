using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_4_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();        //对于键值对，键是int，值是string
            dic.Add(1, "LQ");
            dic.Add(2, "LS");
            dic.Add(3, "FB");
            dic[1] = "新来的";
            foreach (KeyValuePair<int, string> kv in dic)
            {
                Console.WriteLine("{0}(❤ ω ❤){1}", kv.Key, kv.Value);
            }

            //Dictionary<int, char> dict = new Dictionary<int, char>();
            //Console.Write("请输入内容：");
            //string str = Console.ReadLine();
            //char[] chs = str.ToCharArray();
            //for (int i = 0; i < chs.Length; i++)
            //{
            //    dict.Add(i, chs[i]);
            //}
            //foreach (KeyValuePair<int, char> kv in dict)
            //{
            //    Console.WriteLine("{0}===={1}", kv.Key, kv.Value);
            //}

            //Console.WriteLine("请输入：");
            //string Input = Console.ReadLine();
            //char[] chs=new char[Input.Length];
            //int ii = 0;
            //foreach (var item in Input)
            //{
            //    chs[ii]=item;
            //    ii++;
            //}
            //foreach (var item in chs)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] Nu = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //List<int> listOu = new List<int>();
            //List<int> listJi = new List<int>();
            //for (int i = 0; i < Nu.Length; i++)
            //{
            //    if (Nu[i] % 2 == 0)
            //    {
            //        listOu.Add(Nu[i]);
            //    }
            //    else
            //    {
            //        listJi.Add(Nu[i]);
            //    }
            //}
            //listJi.AddRange(listOu);    //奇数添加偶数，奇数在左边
            //foreach (var itm in listJi)
            //{
            //    Console.Write(itm);
            //}

            //统计字符串里面字符出现的个数
            string str = Console.ReadLine();
            Dictionary<char, int> Dicx = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]==' ')
                {
                    continue;
                }
                if (Dicx.ContainsKey(str[i]))
                {
                    Dicx[str[i]]++;
                }
                else
                {
                    Dicx[str[i]] = 1;

                }

            }
            foreach (KeyValuePair<char, int> ky in Dicx)
            {
                Console.WriteLine("{0}===={1}",ky.Key,ky.Value);
            }




            Console.ReadKey();
        }
    }
}
