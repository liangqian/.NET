using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace File_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = File.ReadAllLines(@"C:\Users\Leong\Desktop\工资表.txt",Encoding.UTF8);
            for (int i = 0; i < str.Length; i++)
            {
                string[] strNew = str[i].Split(new char[] { '！' }, StringSplitOptions.RemoveEmptyEntries);
                int salary = int.Parse(strNew[1])*2;
                str[i] = strNew[0] + "！"+salary.ToString();
            }
            File.WriteAllLines(@"C:\Users\Leong\Desktop\工资表.txt",str);
            Console.ReadKey();
        }
    }
}
