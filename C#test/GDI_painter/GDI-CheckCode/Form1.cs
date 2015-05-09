using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GDI_CheckCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.GotFocus += textBox1_GotFocus;
            textBox1.LostFocus += textBox1_LostFocus;
        }

        /// <summary>
        /// 点击更换验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        string str1 = null;
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            string str = null;

            for (int i = 0; i < 5; i++)   //画数字
            {
                int rNum = r.Next(0, 9);
                str += rNum;
            }
            str1 = str;

            //创建GDI对象
            Bitmap bmp = new Bitmap(120, 40);    //创建一个图，确定尺寸
            Graphics g = Graphics.FromImage(bmp);
            for (int i = 0; i < 5; i++)           //画字符串
            {
                Point p = new Point(i * 20, 0);
                string[] fonts = { "微软雅黑", "宋体", "隶书", "黑体", "仿宋" };
                Color[] colors = { Color.Red, Color.Purple, Color.Green, Color.Gold, Color.Blue };
                g.DrawString(str[i].ToString(), new Font(fonts[r.Next(0, 5)], 20, FontStyle.Bold), new SolidBrush(colors[r.Next(0, 5)]), p);
            }

            for (int i = 0; i < 25; i++)              //画干扰线，注意尺寸
            {
                Point p1 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                Point p2 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                g.DrawLine(new Pen(Brushes.Brown), p1, p2);

            }
            for (int i = 0; i < 500; i++)                                 //添加干扰颗粒
            {
                Point p = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                bmp.SetPixel(p.X, p.Y, Color.Blue);
            }
            //将图片镶嵌到picturebox中
            pictureBox1.Image = bmp;
            textBox1.Focus();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == str1)
            {
                MessageBox.Show("登陆成功");
            }
            else
            {
                MessageBox.Show("请输入验证码");
                pictureBox1_Click(sender, e);
            }

        }


        int a = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1_Click(sender, e);
            textBox1.GotFocus += textBox1_GotFocus;
            textBox1.LostFocus += textBox1_LostFocus;
            textBox1.Focus();
            this.textBox1.Text = "请输入验证码";
            button1.Focus();
            
        }

        void textBox1_LostFocus(object sender, EventArgs e)
        {

               // this.textBox1.Text = "";
            //textBox1.Text = "";
        }

        void textBox1_GotFocus(object sender, EventArgs e)
        {
            //if(textBox1.Text=="请输入验证码")
            if(a<=1)            
            {
                a++;
                this.textBox1.Text = "请输入验证码";
                button1.Focus();
            }
            else
            {
                this.textBox1.Text = "";
                a++;
            }    
            

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //textBox1.Text = "";
        }
    }
}
