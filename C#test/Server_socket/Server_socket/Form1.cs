using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Server_socket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //当点击开始监听时候，在服务器端创建一个负责监听IP地址跟端口好的Socket
            Socket socketwatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Any;
            //创建端口号对象
            IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
            //监听
            socketwatch.Bind(point);      //绑定监听端口
            ShowMsg("监听成功");
            socketwatch.Listen(10);      //同一个时段，设置监听端口数量，超出就排队 （监听队列）

            Thread th = new Thread(Listen);
            th.IsBackground = true;
            th.Start(socketwatch);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        void ShowMsg(string str)
        {
            txtLog.AppendText(str + "\r\n");  //追加
        }
        /// <summary>
        /// 等待客户端的连接，并且创建与之通信的Socket
        /// </summary>

        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();
        Socket socketsend;
        void Listen(object s)
        {
            Socket socketwatch = s as Socket;
            //等待客户端的连接
            while (true)
            {
                try
                {
                    //负责跟客户端通信的Socket
                    socketsend = socketwatch.Accept();
                    //将远程连接的客户端的IP地址和Socket存储下拉框中
                    dicSocket.Add(socketsend.RemoteEndPoint.ToString(), socketsend);
                    //将远程客户端的IP地址和端口号存储在下拉框中
                    cboUser.Items.Add(socketsend.RemoteEndPoint.ToString());
                    //202.206.221.91
                    ShowMsg(socketsend.RemoteEndPoint.ToString() + ": " + "连接成功");

                    //开启一个新线程不停的接受客户端发过来的消息
                    Thread th = new Thread(Recive);
                    th.IsBackground = true;
                    th.Start(socketsend);
                }
                catch { }
            }


        }

        private void txtLog_TextChanged(object sender, EventArgs e)
        {

        }
        void Recive(object o)
        {
            Socket socketSend = o as Socket;
            while (true)
            {
                try
                {
                    //客户端连接成功之后，服务器应该接受客户端发来的消息
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    //实际接受到的有效字节
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }
                    string str = Encoding.UTF8.GetString(buffer, 0, r);
                    ShowMsg(socketSend.RemoteEndPoint + ":" + str);
                }
                catch
                {
                }
            }
        }

        /// <summary>
        /// 服务器给客户端发消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string str = txtMsg.Text;
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
                List<byte> list = new List<byte>();
                list.Add(0);
                list.AddRange(buffer);

                //将泛型集合转换成数组
                byte[] newbuffer = list.ToArray();

                //获得用户在下拉框中选中的IP地址
                string ip = cboUser.SelectedItem.ToString();
                dicSocket[ip].Send(newbuffer);

                //socketsend.Send(buffer);
            }
            catch
            {
                MessageBox.Show("请在下拉框中选择你要发送的对象");
            }


        }

        /// <summary>
        /// 选择要发生的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\Leong\Desktop";
            ofd.Title="选择需要发送的文件";
            ofd.Filter = "所有文件|*.*";
            ofd.ShowDialog();

            txtPath.Text = ofd.FileName;

        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            //获得要发送的文件路径
            string path = txtPath.Text;
            using (FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer=new byte[1024*1024*5];
                int r = fsRead.Read(buffer, 0, buffer.Length);
                List<byte> list = new List<byte>();
                list.Add(1);
                list.AddRange(buffer);
                byte[] newbuffer = list.ToArray();
                dicSocket[cboUser.SelectedItem.ToString()].Send(newbuffer,0,r+1,SocketFlags.None); //注意加一为位子
            }
        }

        private void btnVertebra_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] buffer = new byte[1];
                buffer[0] = 2;
                dicSocket[cboUser.SelectedItem.ToString()].Send(buffer);
            }
            catch
            {
                MessageBox.Show("请从下拉框中选择对应的接受对象");
            }

        }
    }
}
