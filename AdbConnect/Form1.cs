using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AdbConnect
{
    public partial class Form1 : Form,ICallBacck
    {
        public Form1()
        {
            InitializeComponent();
            AsyncUdpSever aus = new AsyncUdpSever(this);
            Thread t = new Thread(new ThreadStart(aus.ReceiveMsg));
            t.Start();
            Console.Read();
        }

        public void onSuccess(AndroidDevice device)
        {
            notifyIcon1.ShowBalloonTip(1000,"ADB 成功连接",device.Model, ToolTipIcon.Info);
        }

        private void exitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.notifyIcon1.Visible = false;
            Application.Exit();
        }
        
      
    }
}
