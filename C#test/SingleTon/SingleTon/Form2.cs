using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SingleTon
{
    public partial class Form2 : Form
    {
        //全局唯一的单例
        public static Form2 FrmSingle=null;    //要在静态函数中访问的字段，必须是静态字段
        private Form2()
        {
            InitializeComponent();
        }
        public static Form2 GetSingle()
        {
            if (FrmSingle == null)
            {
                FrmSingle = new Form2();       //只给Form2创建一个对象，点了一次之后就不能再点击
            }
            return FrmSingle;
        }
    }
}
