using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_20220930
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //陣列
            /*
            int[] xx; //宣告  要四人房!
            xx = new int[5]; //具體化 要五間四人房!
            */

            //先告知一班有幾人
            int[] xx = new int[5];
            //並把大家編入各自學號
            xx[0] = 90; 
            xx[1] = 80;
            xx[2] = 70;
            xx[3] = 60;
            xx[4] = 50;

            string result = "";
            /* result += xx[0] + "\r\n";
            result += xx[1] + "\r\n";
            result += xx[2] + "\r\n";
            result += xx[3] + "\r\n";
            result += xx[4] + "\r\n"; */
            //將答案列印出來可以用FOR迴圈 實現

            for (int i =0; i < 5; i++)
            {
                result += xx[i] + "\r\n";
            }

            textBox1.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            //int[] xx = new int[] { 90,80,70,60,50,40,30,20,1};
            //也可以寫成 更簡易的寫法
            int[] xx = { 90,80,70,60,50,40,30,20,10};
            //若 不知道有多少個變數 可以用LENGTH語法實現 
            //此方法較好 哪天code需要大更動 較不會有問題
            string result = "";
            int total = 0;

            for(int i = 0;i < xx.Length; i++)
            {
                result += xx[i] + "\r\n";
            }
            textBox1.Text = result;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 指派一個工作人員(aa)到各房間把房客叫出來! (更有效率)
            int[] xx = new int[] { 90, 80, 70, 60, 50, 40, 30, 20, 1 };
            string result = "";
            int total = 0;

            foreach(int aa in xx)
            {
                total = aa;
                result += aa + "\r\n";
            }

            result += "總和: " + total;
            textBox1.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
   
            int[,] xx = new int[4, 5]; //三列*四格
            xx[0, 0] = 90;
            xx[0, 2] = 90;
            xx[0, 3] = 90;
            xx[1, 0] = 90;
            xx[1, 1] = 90;
            xx[2, 1] = 90;
            xx[2, 2] = 90;
            xx[2, 3] = 90;

            string result = "";

            result +="第0維度"+ xx.GetLength(0)+"\r\n";
            result += "第1維度" + xx.GetLength(1)+"\r\n";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++) 
                {
                    result += xx[i, j] + "\t"; //換列
                }

                result += "\r\n"; //換行
            }

            textBox1.Text = result;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //選擇排序法
            
            int[] xx = {50,70,60,90,80 };

            for (int i= 0; i < xx.Length - 1; i++)
            {// -1 意思是不用再跟i後面的那個比了

                for (int j = i +1;j<xx.Length;j++)
                {
                    if (xx[j]>xx[i])
                    {
                        //如何讓兩位數換位置?
                        //需先假設一個第三者 否則兩數字互換 會被電腦覆蓋
                        int temp = xx[i];
                        xx[i] = xx[j];
                        xx[j] = temp;
                    }
                        
                }
            }


            string result = "";
            foreach (int aa in xx)
            {

                result += aa + "\r\n";
            }
            textBox1.Text = result;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random rr = new Random();
            // rr.Next(100); //最大值是100 但是是小於100
            string result = "";

            for (int i =1; i <=50; i++)

                result += rr.Next(100) + "\r\n";

            textBox1.Text = result;
        }
    }
}
/*
 *回家作業:
        1.三大基礎排序法 插入 / 選擇 / 泡沫
        2.大樂透開獎程式 (不得重複 去除重複的數值)                  
           2-1 重抽法
           2-2 真實世界中的抽獎 (抽過的不會放回母體)
     */