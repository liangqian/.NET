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

namespace List_box_04_29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] path1 = Directory.GetFiles(@"C:\Users\Leong\Desktop\aa");
        List<string> list = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < path1.Length; i++)
            {
                string filename = Path.GetFileName(path1[i]);
                listBox1.Items.Add(Path.GetFileName(filename));
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(path1[listBox1.SelectedIndex]); //显示选中的索引
        }
    }
}
