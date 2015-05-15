using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace Add__XML
{
    class Program
    {
        static void Main(string[] args)
        {
            ////追加XML文档  ,目的是存储需存储的信息
            //XmlDocument doc = new XmlDocument();

            //XmlElement books;

            //if (File.Exists("Book.xml"))
            //{
            //    //如果文件存在，在根节点下添加子节点
            //    //加载XML
            //    doc.Load("Book.xml");
            //    //获得根节点
            //    books = doc.DocumentElement;

            //}
            //else
            //{
            //    //如果文件不存在，则先创建第一行，再床架子节点                              
            //    //创建第一行
            //    XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);    //声明
            //    doc.AppendChild(dec);
            //    //创建根节点
            //    books = doc.CreateElement("Books");
            //    doc.AppendChild(books);
            //}
            ////追加XML，添加内容   ,这是在创建了根节点的基础上，继续添加需要保存的XML

            //XmlDocument doc = new XmlDocument();
            //XmlElement books;

            //if (File.Exists("Book.xml"))
            //{
            //    doc.Load("Book.xml");
            //    books = doc.DocumentElement;
            //}
            //else
            //{
            //    XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            //    doc.AppendChild(dec);
            //    books = doc.CreateElement("Books");
            //}
            //XmlElement book4 = doc.CreateElement("Book");
            //books.AppendChild(book4);
            //book4.SetAttribute("Createer","RoyLeong");

            //XmlElement name4 = doc.CreateElement("Name");
            //book4.AppendChild(name4);
            //name4.InnerText = "Unity ３Ｄ大师";

            //XmlElement price4 = doc.CreateElement("Price");
            //book4.AppendChild(price4);
            //price4.InnerText = "$10000000000";

            //XmlElement description4 = doc.CreateElement("desvription");
            //book4.AppendChild(description4);
            //description4.InnerText = "好看好看，非常好";
            //doc.Save("Book.xml");     //必须保存才能成功
            //Console.Write("成功");

            //XmlDocument doc = new XmlDocument();
            //doc.Load("Book.xml");
            //XmlElement books = doc.DocumentElement;

            //XmlNodeList xn1 = books.ChildNodes;         //获取子节点集合
            //foreach (XmlNode items in xn1)
            //{
            //    Console.WriteLine(items.InnerText);    //获取标签的内容，内容是存储在innertext中的
            //}

            //XmlDocument doc = new XmlDocument();
            //doc.Load("Book.xml");

            //XmlNodeList xnl = doc.SelectNodes("/Books/Book5");       //获取标签属性
            //foreach (XmlNode items in xnl)
            //{
            //    Console.WriteLine(items.Attributes["Createer"].Value);
            //}

            XmlDocument doc = new XmlDocument();
            doc.Load("Book.xml");

            XmlNode xn = doc.SelectSingleNode("/Books/Book5/Name");
            xn.RemoveAll();
            doc.Save("Book.xml");






















        }
    }
}
