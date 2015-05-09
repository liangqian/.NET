using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smart_Student_count
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listName=new List<string>();
            while (true)
            {
                Console.WriteLine("请输入学员姓名： ");
                string name = Console.ReadLine();
                if (name != "quit")
                {
                    listName.Add(name);
                }
                else
                {
                    break;
                }
               
            }
            Console.WriteLine("总共输入了{0}个学员", listName.Count);
            int i = 0;
            try
            {
                foreach (string item in listName)
                {
                    if (item[1] == '王')
                    {
                        i++;
                    }
                    Console.WriteLine(item);
                }
            }
            catch { }
            Console.WriteLine("姓王的学员有{0}个",i);
 
        }
    }
}
