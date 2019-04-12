using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalgame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;  //輸入英文字
            string jiami = "";
            int number = 0;               //設number= 零

            number = int.Parse(textBox3.Text);  //int格式的格子

            for (int i = 0; i < text.Length; i++)   //使用For回圈
            {
                if ((char)(text[i]) == 122)
                {
                    jiami += (char)(96 + number);
                }
                else if ((char)(text[i]) == 90)
                {
                    jiami += (char)(64 + number);
                }
                else
                {
                    jiami += (char)(text[i] + number);
                } //加密輸入英文字加上加密的數字 和swtich一樣     
            }
            textBox2.Text = jiami;                //顯示加密後的英文字
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text2 = textBox4.Text;    //輸入英文字
            string jiemi = "";
            int number2 = 0;                //設number= 零

            number2 = int.Parse(textBox5.Text);   //int格式的格子
            for (int i = 0; i <text2.Length;i++)  //使用For回圈
            {
                jiemi += (char)(text2[i] - number2);   //輸入英文字減掉輸入解密的數字
            }

            textBox6.Text = jiemi;            //顯示解密後的英文字
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
