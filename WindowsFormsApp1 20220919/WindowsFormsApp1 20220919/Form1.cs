using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_20220919
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "按鈕1被按囉";
            textBox1.Text = "按鈕1按按";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(223,221,117);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Beige;
        }

        private void button3_Click(object sender, EventArgs e)
        {   /*
            int aa; //宣告 
            (為了代替"記不起來的記憶體存取位置")
            (用存摺舉例:用戶名代替難記的帳號)
            aa = 100; //賦值 */
            int aa = 100;
            aa = aa + 200;
            /*label1.Text = aa;文字與數字是水火不容的 但可以透過to string轉換*/
            label1.Text = aa.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string aa = textBox1.Text;
            int bb = int.Parse(aa); /*把aa轉成語bb相同的性質:數字*/
            bb = bb + 200;
            label1.Text = bb.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text; //讓使用者輸入身高
            int userHeight = int.Parse(inputText); //身高
            int userWight = userHeight - 110; //標準體重=身高-110
            label1.Text = "你的標準體重為:" + userWight.ToString() + "公斤";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /* 運算規則中
            1. 整數的運算結果皆為整數
            2.任何數與浮點數運算的結果會自動轉為浮點數
            3.整數的處理:預設接自動判定為int,運算上也會轉成inT處理 
            */
            int a = 20;
            int b = 3;
            // label1.Text = (a / b).ToString();
            // label1.Text = (1.0*a / b).ToString(); 強制變成浮點數
            label1.Text = ((double)a / b).ToString();
        
        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            /* short a =32767;
             * short b = (short)(a+2);
             * label.Text = b.ToString(); */
            long a = 123456789;
            short b = (short)a;
            label1.Text = b.ToString();
    }
    }
}
