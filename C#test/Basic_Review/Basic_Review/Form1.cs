using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Basic_Review
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = GetLevel(Convert.ToInt32(textBox1.Text));

            }
            catch
            { }

        }
        private static string GetLevel(int Score)
        {
            string level;
            switch (Score/10)
            {
                case 10:
                case 9: level = "优秀";
                    break;
                case 8: level = "良好";
                    break;
                case 7: level = "一般";
                    break;
                case 6: level = "及格";
                    break;
                default: level = "差劲";
                    break;
            }
            return level;
        }
    }
}
