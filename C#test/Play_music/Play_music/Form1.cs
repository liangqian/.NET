using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Play_music
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //存储音乐文件的全路径
        List<string> list = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择音乐文件";
            ofd.InitialDirectory = @"C:\Users\Leong\Desktop\Music";
            ofd.Filter = "音乐文件|*.wav|所有文件|*.*";
            ofd.Multiselect = true;
            ofd.ShowDialog();
            string[] path1 = ofd.FileNames;
            for (int i = 0; i < path1.Length; i++)
            {
                listBox1.Items.Add(Path.GetFileName(path1[i]));
                //将音乐文件的全路径存储到泛型集合中
                list.Add(path1[i]);

            }
        }
             /// <summary>
             /// 双击实现播放
             /// </summary>
             /// <param name="sender"></param>
             /// <param name="e"></param>

        SoundPlayer Sp = new SoundPlayer();

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Sp.SoundLocation = list[listBox1.SelectedIndex];
            Sp.Play();
        }
             /// <summary>
             /// 点击实现上下一曲
             /// </summary>
             /// <param name="sender"></param>
             /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //下一曲
            int index = listBox1.SelectedIndex; //获得当前选中的索引
            if (index == 0)                     
            {
                index=listBox1.Items.Count;
            }
            index --;

            listBox1.SelectedIndex = index;
            Sp.SoundLocation=list[index];
            Sp.Play();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            index++;
            if (index == listBox1.Items.Count)
            {
                index = 0;
            }
            //将改变后的索引重新赋值给我当前选中项的索引
            listBox1.SelectedIndex = index;
            Sp.SoundLocation=list[index];
            Sp.Play();

        }
    }
}
