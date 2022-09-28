using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_20220928
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
            for (int i = 1; i <= 42; i++)
            {
                result += i + ".巨匠電腦\r\n";
                if (i == 20) break;

            }
            textBox1.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        { //設 逢4倍數 跳過
            string result = "";
            for (int i = 1; i <= 42; i++)
            {

                if (i % 4 == 0) continue; //略過4倍數 其他繼續的意思
                // % 代表除以
                result += i + ".巨匠電腦\r\n";
            }
            textBox1.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*無窮迴圈應用 EX: 時鐘,
             for ( ; ;) 使用空for!
             while ( true) ----->只要是對的 WHILE就會一直做下去 */

            string result = "";
            int i = 0;
            while (true)
            {
                if (++i % 4 == 0) continue;
                result += i + ".巨匠電腦\r\n";
                if (i == 45) break;
            }
            textBox1.Text = result;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            string result = "";
            for (int i = 1; i <= 5; i++)
            {
                result += "外圈第" + i + "圈\r\n";
                for (int j = 1; j <= 5; j++)
                {
                    result += "  內圈第" + j + "圈\r\n";
                }

            }
            textBox1.Text = result;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //九九乘法表
            string result = "";

            int j = 1;
            for (int i = 1; i <= 9; i++)
            {
                for (j = 1; j <= 9; j++)
                {
                    result += i + "*" + j + "=" + i * j + "\t ";

                }

                result += "\r\n";

            }
            textBox1.Text = result;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //九九乘法表
            string result = "";

            int j = 1;
            for (int i = 1; i <= 9; i++)
            {
                for (j = 1; j <= 9; j++)
                {
                    result += i + "*" + j + "=" + i * j + "\t ";
                    if (i == 6 && j == 6) break;
                }

                result += "\r\n";
                if (i == 6 ) break;

            }
            textBox1.Text = result;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //九九乘法表 6*6 停下來
            string result = "";
            bool isBreak = false;

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    //result += i + "*" + j + "=" + (i * j).ToString("00"); //美化數字排列
                    result += string.Format("{0}*{1}={2:00}", i, j, i * j);
                    // 0 1 2 為位置 , 00為格式
                    
                    if (i == 6 && j == 6)
                    {
                        isBreak = true;
                        break;
                    }
                }
                if (isBreak) break;
                result += "\r\n";

            }
            textBox1.Text = result;
        }

        private void button9_Click(object sender, EventArgs e)
        {  
            //格式化
            string a = "";
            int b = 123456789;
            double c = 0.56789;
            DateTime d = DateTime.Now;


            string result = "";
            result += b.ToString("c")+ "\r\n";
            result += c.ToString("p") + "\r\n";
            result += c.ToString("#.0%") + "\r\n";
            result += d.ToShortTimeString() + "\r\n";
            result += d.ToLongTimeString() + "\r\n";
            result += d.ToString("D") + "\r\n"; // long day
            result += d.ToString("d") + "\r\n"; //short day
            result += d.ToString("yyyy-MM-dd dddd HH:mm:ss") + "\r\n"; // C# fomat 自訂字串可找到相對應文字

            //result += "A的值 : " +a + "B的值 :" + b +"C的值:" +c + "D的值: " +d +"\r\n";
            //可以轉換成以下方式寫: 
            //result += string.Format("A的值:{0}, B的值:{1}, B的值:{2}, C的值:{3}, D的值:{3}", a,b,c,d);
            //加入想要的格式 可以參照下方寫法:
            result += string.Format("A的值:{0}, B的值:{1:C}, B的值:{2:P}, C的值:{3:D}, 再次B的值:{1:#.0}", a, b, c, d);


            textBox1.Text = result;
            //作業: 列出2-1000的質數
            //100-1000的水仙花數
             
        }
    }
}
