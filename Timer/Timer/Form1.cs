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
        int endTime;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text, out endTime))
            {
                timer1.Start();
            }else
            {
                textBox1.Text = "";
                MessageBox.Show("数字を入力してください");
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox2.Text = endTime.ToString();
            if (endTime-- == 0)
            {
                timer1.Stop();
                MessageBox.Show("時間になりました。");
            }
           
        }

    }
}
