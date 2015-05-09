using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace String_count
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "患者：“大夫，我咳嗽得很重。”     大夫：“你多大年记？”     患者：“七十五岁。”     大夫：“二十岁咳嗽吗”患者：“不咳嗽。”     大夫：“四十岁时咳嗽吗？”     患者：“也不咳嗽。”     大夫：“那现在不咳嗽，还要等到什么时咳嗽？”";
            int index = str.IndexOf("咳嗽");
            int i=1;
            Console.WriteLine("第一次出现咳嗽的位置是{0}",index);
            while (index != -1)
            {
                i++;
                index = str.IndexOf("咳嗽",index+1);
                if (index == -1)
                {
                    break;
                }
                Console.WriteLine("第{0}次找到咳嗽的位置是{1}",i,index);
            }
        }
    }
}
