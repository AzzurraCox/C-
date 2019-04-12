using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class Form2 : Form
    {
        public Form2()//Tic Tac Toe 的名字設定畫面
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.SetPlayerName(p1.Text, p2.Text);
            this.Close();
        }

        private void p2_KeyPress(object sender, KeyPressEventArgs e)//避免按到enter鍵
        {
            if (e.KeyChar.ToString() == "\r")
                button1.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)//對電腦的按鈕
        {
            Form1.SetPlayerName(p1.Text, p2.Text = ("COMPUTER"));
            this.Close();
        }
    }
}
