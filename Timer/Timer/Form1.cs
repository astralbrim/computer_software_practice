using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        private int endTime;
        private bool isTimerStart;
        public Form1()
        {
            InitializeComponent();
        }
        private void Reset_TextBox(TextBox textBox)
        {
            textBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isTimerStart)
            {
                bool isNumber = int.TryParse(textBox1.Text, out endTime);
                if (isNumber) endTime *= 10;
                if (!isNumber)
                {
                    Reset_TextBox(textBox1);
                    MessageBox.Show("数字を入力してください");
                }
                else
                {
                    if(!(endTime <= 600 && endTime >= 100))
                    {
                        endTime = 100;
                        textBox1.Text = "10";
                    }
                    Reset_TextBox(textBox2);
                    timer1.Start();
                    isTimerStart = true;
                }
            }else
            {
                timer1.Stop();
                isTimerStart = false;
                textBox2.Text = (endTime / 10).ToString();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (endTime-- == -100)
            {
                timer1.Stop();
                isTimerStart = false;
                MessageBox.Show("指定時間を大幅に超過しました");
            }
           
        }

    }
}
