using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_20220923
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // int score = int.Parse(textBox1.Text);
            //if (score >= 60) label1.Text = "及格囉";
            int score = int.Parse(textBox1.Text);

            if (score >= 60)
            {
                label1.Text = "及格囉";
                label1.ForeColor = Color.Blue;
            } 
            //括號是代表範圍 
            //if後面若有好幾個句子 括號就用來讓電腦區分if與else句子的各自範圍
            else
            {
                label1.Text = "去重考吧你哈哈";
                label1.ForeColor = Color.Red;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int inputNum = int.Parse(textBox1.Text);
            if (inputNum >= 1000)
                label1.Text = "4位數以上";
            else if (inputNum <= 9 && inputNum > 0 )
                label1.Text = "個位數";
            else if (inputNum <= 99 && inputNum > 0)
                label1.Text = "2位數";
            else if (inputNum <= 999 && inputNum > 0)
                label1.Text = "3位數";

            else
                label1.Text = "負數";
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int inputNum = int.Parse(textBox1.Text);
            if (inputNum >= 90)
                label1.Text = "甲等";
            else if (inputNum >= 80)
                label1.Text = "乙等";
            else if (inputNum >= 70)
                label1.Text = "丙等";
            else if (inputNum >= 60)
                label1.Text = "丁等";
            else
                label1.Text = "戊";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int choice = int.Parse(textBox2.Text);
            string s = "";
            switch (choice)
            {
                case 1:s = "豬排"; break;
                case 2: s = "雞排"; break;
                case 3: s = "牛排"; break;
                case 4: s = "羊排"; break;
                default:s = "不要給我亂選拉!";break;
            }

            label2.Text = s;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int choice = int.Parse(textBox3.Text);
            string s = "";
            switch (choice)
            {
                case 1: s = "成人票 $250"; break;
                case 2: s = "雙人套票 $ 450"; break;
                case 3: 
                case 4: s = "軍種票或敬老票 $200"; break;
                default: s = "不要給我亂選拉!"; break;
            }

            label3.Text = s;
        }
    }
}