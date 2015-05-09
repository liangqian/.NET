using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simple_cals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                int Number1 = Convert.ToInt32(textBox1.Text.Trim());
                int Number2 = Convert.ToInt32(textBox2.Text.Trim());
                string opera = comboBox1.SelectedItem.ToString();
                if (opera == "+")
                {
                    label1.Text = (Number1 + Number2).ToString();
                }
                else if (opera == "-")
                {
                    label1.Text = (Number1 - Number2).ToString();
                }
                else if (opera == "*")
                {
                    label1.Text = (Number1 * Number2).ToString();
                }
                else
                {
                    label1.Text = (Number1 / Number2).ToString();

                }
            }
            catch
            {
                MessageBox.Show("请进行正确的输入选择操作：");
            }
        }
    }
}
