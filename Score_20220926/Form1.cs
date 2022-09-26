using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Score_20220926
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int choice = int.Parse(textBox1.Text);

            string S = "";

            switch(choice)
            {
                case 1: S = "90~100";
                    label2.Text = "你的分數評比為 : 優等"; break;
                case 2: S = "80~90";
                    label2.Text = "你的分數評比為 : 甲等"; break;
                case 3: S = "70~80";
                        label2.Text = "你的分數評比為 : 乙等"; ; break;
                case 4: S = "60~70";
                    label2.Text = "你的分數評比為 : 丙等"; break;
                case 5: S = "60分以下";
                    label2.Text = "你的分數評比為 : 戊等"; break;
            }

        }
    }
}
