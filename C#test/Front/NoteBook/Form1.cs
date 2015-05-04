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

namespace NoteBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //加载程序的时候，隐藏Panel
            panel1.Visible = false;
            //取消文本框的自动换行
            textBox1.WordWrap = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //点击按钮的时候，隐藏pannel
            panel1.Visible = false;
        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void 隐藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        List<string> list = new List<string>();
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开对话框
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择需要打开的文本文件";
            ofd.InitialDirectory = @"C:\Users\Leong\Desktop";
            ofd.Multiselect = true;
            ofd.Filter = "文本文件|*.txt|所有文件|*。*";
            ofd.ShowDialog();
            //获得文件路径
            string path = ofd.FileName;
            list.Add(path); //将文件全路径存储在泛型集合中
            string filename = Path.GetFileName(path);
            listBox1.Items.Add(filename);
            if (path == "")
            {
                return;
            }
            using (FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer=new byte[1024*1024*5];
                int r = fsRead.Read(buffer,0,buffer.Length);
                textBox1.Text = Encoding.Default.GetString(buffer,0,r);
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"C:\Users\Leong\Desktop";
            sfd.Title = "请选择需要保存的文件路径";
            sfd.Filter = "文本文件|*.txt|所有文件|*.*";
            sfd.ShowDialog();

            string path = sfd.FileName;
            if (path == "")
            {
                return;
            }
            using (FileStream wfd = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                byte[] buffer = Encoding.Default.GetBytes(textBox1.Text);
                wfd.Write(buffer,0,buffer.Length);
            }
            MessageBox.Show("写入成功");
        }

        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (自动换行ToolStripMenuItem.Text == "★自动换行")
            {
                textBox1.WordWrap = true;
                自动换行ToolStripMenuItem.Text = "☆取消自动换行";
            }
            else if (自动换行ToolStripMenuItem.Text == "☆取消自动换行")
            {
                textBox1.WordWrap = false;
                自动换行ToolStripMenuItem.Text = "★自动换行";
            }

        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            textBox1.Font = fd.Font;

        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            textBox1.ForeColor = cd.Color;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //双击打开对应文件
            //获得全路径
            string path =list[listBox1.SelectedIndex];
            using (FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = fsRead.Read(buffer,0,buffer.Length);
                textBox1.Text = Encoding.Default.GetString(buffer,0,r);
            }
        }
    }
}
