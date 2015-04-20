using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beauty_Of_Programing
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int[] a = Puzzle(new int[] {1,5,6,9,-8,-54,-657 });
            //    foreach (int i in a)
            //    {
            //        Console.WriteLine(i);
            //    }

            //string str1 = Console.ReadLine();
            //string str2 = Console.ReadLine();
            //Puzzle(str1, str2);


            //string str = Console.ReadLine();
            //int a = Convert.ToInt32(str);
            //Console.Write(a);
            int[] a = { 1,2,1};
            int re= Puzzle(a);
            Console.Write(re);

            Console.ReadKey();

        }

        //public static int Puzzle(string s1, string s2)
        //{
        //    if (s1.Contains(s2))
        //    {
        //        int index1 = s1.IndexOf(s2);
        //        return index1;
        //    }
        //    else
        //    {
        //        return -1;
        //    }
        //    return 0;

        //}


        //public static int[] Puzzle(int[] a)
        //{
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        if (a[i] < 0)
        //        {
        //            a[i] = -a[i];
        //        }
        //        else
        //        {
        //            a[i] = a[i];
        //        }
        //    }
        //    return a;

        //public static bool Puzzle(int[] a)
        //{
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        for (int j = i + 1; j < a.Length; j++)
        //        {
        //            if (a[i] == a[j])
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    return false;

        //}

        public static int Puzzle(int[] a)
        {

                return a[a.Length-1];
        }





    }
}
