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


            if (BMI < 18.5) 
            label4.Text = "身體素質指數 : 過瘦了!";
            
            else if (BMI < 24)

            label4.Text = "身體素質指數 : 正常範圍!";

            else
                label4.Text = "身體素質指數 : 過胖了!";

        }
    }
}
