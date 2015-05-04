using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 线程类
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread th;

        private void button1_Click(object sender, EventArgs e)
        {
            //创建一个线程去执行这个方法
            //标记这个线程准备就绪，具体执行时间看CPU中央处理器
            //将线程设置为后台线程
            th = new Thread(Test);
            th.IsBackground = true;
            th.Start();
           
        }
        private void Test()
        {
            for (int i = 0; ; i++)
            {
                Thread.Sleep(300);
                textBox1.Text = i.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //取消跨线程的访问
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //当你点击关闭窗口的时候，判断新线程是否为null
            if (th != null)
            {
                //结束这个线程
                th.Abort();
            }
        }
    }
}
