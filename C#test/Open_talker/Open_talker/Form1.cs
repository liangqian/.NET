using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Open_talker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //点击弹出对话框
            OpenFileDialog ofd = new OpenFileDialog();
            //对话框的标题
            ofd.Title = "请选择要打开的文本文件";
            //设置对话框多选
            ofd.Multiselect = true;
            //设置对话框的初始目录
            ofd.InitialDirectory = @"C:\Users\Leong\Desktop\";
            //设置对话框的文件类型
            ofd.Filter = "文本文件|*.txt|媒体文件|*.mp3|所有文件|*";
            //展示对话框
            ofd.ShowDialog();
            //获得在打开对话框中选中文件的路径
            string path= ofd.FileName;
            if (path == "")
            {
                return;
            }
            using (FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer=new byte[1024*1024*5];
                //实际读取的字节数
                int r = fsRead.Read(buffer,0,buffer.Length);

                string str= Encoding.GetEncoding("GB2312").GetString(buffer,0,buffer.Length);
                textBox1.Text = str;

            }
        }
    }
}
