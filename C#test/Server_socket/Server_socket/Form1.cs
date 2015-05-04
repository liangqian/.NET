using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            Socket socketwatch = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            IPAddress ip = IPAddress.Any;
            //创建端口号对象
            IPEndPoint point = new IPEndPoint(ip,Convert.ToInt32(txtPort.Text));
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
        void Listen(object s)
        {
            Socket socketwatch = s as Socket;
            //等待客户端的连接
            while (true)
            {
                Socket socketsend = socketwatch.Accept();
                //202.206.221.91
                ShowMsg(socketsend.RemoteEndPoint.ToString() + ": " + "连接成功");
            }
            
 
        }
    }
}
