using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suanfa_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int a = Convert.ToInt32(Console.ReadKey());
            //int b = Convert.ToInt32(Console.ReadKey());
            //Console.WriteLine("{0},{1}",a,b);
            //a = a + b;
            //b = a - b;
            //a = a - b;
            //Console.WriteLine("{0},{1}",a,b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "anniu";
            label1.Text = "今天的第二节课是visual basic课程";
        }
    }
}
