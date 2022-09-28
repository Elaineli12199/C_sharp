using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search_20220927
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            string counting = "";
            string text = textBox1.Text;
            string get_text = textBox2.Text;
            int location = text.IndexOf(get_text);

            string[] tt = text.Split(',', '(', ')', ':', '。');




            ///location > 0
            if (location >= 0)
            {
          
                 result = result + "已搜尋到關鍵字:'" + textBox2.Text + "'\r\n位置在: " + location + "\r\n";
                 label2.Text = result;
            }

            else
                result = "-1";
            label2.Text = "查無此字";

            int count = 0;
            while (count < text.Length)
            {
                count = count + 1;
                counting = count + "個" + textBox2.Text;
                label3.Text = counting;

            }
        }
    




         /* for (int i = 0; i<text.Length; i++)
                {
                    result += tt[i] + "\r\n";
                    label2.Text = result + "已搜尋到關鍵字:" + textBox2.Text;
                    label3.Text = result + "位置在:" + location;
                } */
