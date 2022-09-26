using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_20220926
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string a = "Mom said\"It's too late! Hurry!\"";
            //string a = @"D:\sfsdfsdfsdfsfhgh\.jpg";
            //加@是告訴電腦 後面那些不是特殊字元.可以正常輸出

            string a = "巨匠電腦\r\n桃園認證中心";
            textBox1.Text = a;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = "";
            string a = "巨匠電腦桃園認證中心桃園市政府";
            result = result + "字串長度" + a.Length + "\r\n";
            result = result + "字串長度" + a.Substring(10) + "\r\n";
            result = result + "字串長度" + a.Substring(4, 2) + "\r\n";
            //從頭找
            result = result + "尋找位置" + a.IndexOf("桃園") + "\r\n";
            result = result + "尋找位置" + a.IndexOf("桃園,5") + "\r\n";
            //從尾找
            result = result + "尋找位置" + a.LastIndexOf("桃園") + "\r\n";
            result = result + "尋找位置" + a.LastIndexOf("桃園,6") + "\r\n";

            //取代
            result = result + "取代" + a.Replace("桃園", "台北") + "\r\n";
            //插入
            result = result + "尋找位置" + a.Insert(10, "新竹") + "\r\n";

            string b = "AA,BB:CC,DD,EE.FF";
            string[] bb = b.Split(',', ':', '.');
            for (int i = 0; i < bb.Length; i++)
                result += bb[i] + "\r\n";
            textBox1.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string result = "";

            //i 只放在for迴圈裡表示i只會存在for回圈內
            //若要擴大宣告範圍 可將i放置在迴圈外面
            // for (初始區,邏輯判斷,執行區)
            // 每區不見得要出現!ex:int i 可以不出現
            for (int i = 1; i <= 10; i += 2)
            {
                result += i.ToString() + "巨匠電腦\r\n";
            }

            textBox1.Text = result;



        }

        private void button4_Click(object sender, EventArgs e)
        {

            int total = 0;

            for (int i = 300; i <= 1500; i = i + 1)
            {
                total += i;
            }
            textBox1.Text = total.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int total_2 = 0;
            for (int i = 300; i <= 1500; i = i + 2)
            {
                total_2 += i;

            }
            textBox1.Text = total_2.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int total_奇 = 0;
            for (int i = 301; i <= 1500; i = i + 2)
            {
                total_奇 += i;

            }
            textBox1.Text = total_奇.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int total = 0;
            int total_odd = 0;
            int total_even = 0;

            for (int i = 300; i <= 1500; i++)
            {
                total += i;
                if (i % 2 == 0)
                    total_even += i;
                else
                    total_odd += i;

            }
            string result = "";
            result += "總和" + total + "\r\n";
            result += "奇數總和" + total_odd + "\r\n";
            result += "偶數總和" + total_even + "\r\n";

            textBox1.Text = result;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            long total = 1; //總和 //加上long-->改變DATA TYPE 把字升級(看筆記)
            int count = 0; //次方
            string result = "";
            while (total <= 2000000000)
            {
                total = total * 3; 
                count = count + 1;
                result += "3的" + count + "次方 總和是" + total + "\r\n";
            }
            
            textBox1.Text = result;
        }

        private void button9_Click(object sender, EventArgs e)
        { //do與while的差別---->如果一開始測試條件就是false的情況之下
          //do會逐一做完 while不會
            long total = 1; 
            int count = 0;
            string result = "";
            do
            {
                total = total * 3;
                count = count + 1;
                result += "3的" + count + "次方 總和是" + total + "\r\n";
            } while (total <= 2000000000);
            textBox1.Text = result;
        }
    }
}
