using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTS_20220921
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            string inputText = Height_box.Text;
            int userHeight = int.Parse(inputText);
            label1.Text = "Ans:" + userWeight.ToString() + "kg";
        }
    }
}
