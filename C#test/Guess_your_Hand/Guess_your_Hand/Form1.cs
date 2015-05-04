using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_your_Hand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSTone_Click(object sender, EventArgs e)
        {
            string str = "石头";
            PlayGame(str);

        }

        private void PlayGame(string str)
        {
            lblPlayer.Text = str;
            Player player = new Player();
            int playNum = player.ShowFist(str);

            Computer cpu = new Computer();
            int cpunum = cpu.ShowFist();
            lblPlayer.Text = cpu.Fist;

            Result res = Judger.Judge(playNum, cpunum);
            lblResult.Text = res.ToString();
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            string str = "石头";
            PlayGame(str);

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            string str = "布";
            PlayGame(str);
        }
    }
}
