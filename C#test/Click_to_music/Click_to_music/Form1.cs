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
using System.Media;

namespace Click_to_music
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> listsong=new List<string> ();
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] path = Directory.GetFiles(@"C:\Users\Leong\Desktop\Music");
            for (int i = 0; i < path.Length; i++)
            {
                string filename = Path.GetFileName(path[i]);
                listBox1.Items.Add(filename);
                listsong.Add(path[i]);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //只能播放.wav格式的音频文件
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = listsong[listBox1.SelectedIndex];
            sp.Play();
        }
    }
}
