using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GDI_painter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ////////一张纸，一支笔，两点，绘制直线对象
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //创建GDI对象
            Graphics g = this.CreateGraphics();//new Graphics();
            Pen pen = new Pen(Brushes.Blue);  //创建画笔对象
            //创建两点
            Point p1 = new Point(200,200);
            Point p2 = new Point(300,300);

            g.DrawLine(pen,p1,p2);


        }
        int i = 0;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            i++;
            label1.Text = i.ToString();
            //创建GDI对象
            Graphics g = this.CreateGraphics();//new Graphics();
            Pen pen = new Pen(Brushes.Blue);  //创建画笔对象
            //创建两点
            Point p1 = new Point(200, 200);
            Point p2 = new Point(300, 300);

            g.DrawLine(pen, p1, p2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Pen pen = new Pen(Brushes.Blue);
            Size size = new System.Drawing.Size(100,100);
            Rectangle rec=new Rectangle(new Point(50 ,50),size);
            g.DrawRectangle(pen,rec);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Blue);
            Size size = new System.Drawing.Size(180,180);
            Rectangle rec = new Rectangle(new Point(150,150),size);
            g.DrawPie(pen,rec,60,10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawString("BBBBB",new Font("宋体",20,FontStyle.Underline),Brushes.Black ,new Point(300,300));
        }
    }
}
