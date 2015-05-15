using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace XML_drag_propipdad
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);

            XmlElement order = doc.CreateElement("Order");
            doc.AppendChild(order);

            XmlElement customerName = doc.CreateElement("CustomerName");
            order.AppendChild(customerName);
            customerName.InnerXml = "<p>====</p>";

            XmlElement customerNumber = doc.CreateElement("CustomerName");
            order.AppendChild(customerNumber);
            customerNumber.InnerText = "15733229560";

            XmlElement items = doc.CreateElement("items");
            items.SetAttribute("Color","Red");
            order.AppendChild(items);

            //items.SetAttribute("Color", "Red");
            //扎准目录，添加属性的XML标签 


            XmlElement orderItem1 = doc.CreateElement("OrderItem");
            //给节点添加属性
            orderItem1.SetAttribute("Name", "chongiwawa");
            orderItem1.SetAttribute("Count", "10");
            items.AppendChild(orderItem1);


            XmlElement orderItem2 = doc.CreateElement("OrderItem");
            //给节点添加属性
            orderItem2.SetAttribute("Name", "chongiwawa");
            orderItem2.SetAttribute("Count", "10");
            items.AppendChild(orderItem2);


            XmlElement orderItem3 = doc.CreateElement("OrderItem");
            //给节点添加属性
            orderItem3.SetAttribute("Name", "chongiwawa");
            orderItem3.SetAttribute("Count", "10");
            items.AppendChild(orderItem3);


            doc.Save("order.xml");
            Console.Write("保存成功");



        }
    }
}
