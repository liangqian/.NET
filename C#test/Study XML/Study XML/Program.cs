using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Study_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            //通过代码创建XML文档
            //1、引用命名空间
            //2、创建XML文档
            XmlDocument doc = new XmlDocument();
            //３、创建第一个行描述信息，并且添加到Doc文档中
            XmlDeclaration dec=  doc.CreateXmlDeclaration("1.0","utf-8",null);
            doc.AppendChild(dec);
            //４、创建根节点

            //创建根节点
            XmlElement books= doc.CreateElement("Books");
            doc.AppendChild(books);
            //5、给根节点Books创建子节点
            XmlElement book1 = doc.CreateElement("Book");
            books.AppendChild(book1);

            //6、给Book1添加子节点
            XmlElement Name1 =doc.CreateElement ("Name");
            book1.AppendChild(Name1);
            Name1.InnerText = "福尔摩斯探案集";

            XmlElement price1 = doc.CreateElement("price");
            book1.AppendChild(price1);
            price1.InnerText = "$10";

            XmlElement description = doc.CreateElement("description");
            book1.AppendChild(description);
            description.InnerText = "好有悬念的书，好喜欢看，(❤ ω ❤)";

            XmlElement book2 = doc.CreateElement("Book");
            books.AppendChild(book2);

            XmlElement name2 = doc.CreateElement("Name");
            book2.AppendChild(name2);
            name2.InnerText ="水浒传";

            XmlElement price2 = doc.CreateElement("price");
            book2.AppendChild(price2);
            price2.InnerText = "$20";

            XmlElement description2 = doc.CreateElement("description");
            book2.AppendChild(description2);
            description2.InnerText = "108个基佬";

            XmlElement book3 = doc.CreateElement("book");
            books.AppendChild(book3);

            XmlElement name3 = doc.CreateElement("Name");
            book3.AppendChild(name3);
            name3.InnerText = "名侦探狄仁杰";

            XmlElement price3 = doc.CreateElement("price");
            book3.AppendChild(price3);
            price3.InnerText = "$20";

            XmlElement description3 = doc.CreateElement("description");
            book3.AppendChild(description3);
            description3.InnerText = "渣！！！";






            doc.Save("Book.xml");
            

            Console.Write("保存成功");
        }

    }
}
