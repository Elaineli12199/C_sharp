using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_20220922
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            float Height,Weight;
            Height = float.Parse(textBox1.Text);
            Weight = float.Parse(textBox2.Text);

            double BMI;
            BMI = Weight / ((Height / 100)*(Height / 100));
            label3.Text = "你的BMI值為" + BMI.ToString("F2");
        }
    }
}
