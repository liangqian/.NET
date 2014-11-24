using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Point ms_d = new Point();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(256, 256);
            pictureBox1.Location = new Point(10, 10);

            pictureBox1.Load("C:\\Users\\Channe\\Desktop\\下载.png");
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ms_d = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int drt_x, drt_y;
            if(e.Button==MouseButtons.Left)
            {
                drt_x = e.X - ms_d.X;
                drt_y = e.Y - ms_d.Y;

                pictureBox1.Location = new Point(pictureBox1.Location.X + drt_x, pictureBox1.Location.Y + drt_y);
            }
        }
    }
}
