using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C:\\Users\\Channe\\Desktop\\下载.png","about");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("202.206.223.102","about");
        }
    }
}
