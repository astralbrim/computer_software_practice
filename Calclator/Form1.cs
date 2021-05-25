using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calclator
{
    public partial class Calclator : Form
    {
        public Calclator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (input1.Text != "")
            {
                int result;
                if (!int.TryParse(input1.Text, out result))
                {
                    input1.Text = "";
                    MessageBox.Show("入力できる値は数字のみです");
                }
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            int textBox1;
            int textBox2;

            bool result1 = int.TryParse(input1.Text, out textBox1);
            bool result2 = int.TryParse(input2.Text, out textBox2);

            if (!(result1 || result2))
            {
                MessageBox.Show("数値を入力してください");
                return;
            }

            if (input2.Text == "0" || inputSynbol.Text == "/" || inputSynbol.Text == "%")
            {
                MessageBox.Show("0でわれませんよ");
                return;
            }

            string symbol = inputSynbol.Text;
            float ans = 0;
            switch (symbol)
            {
                case "+":
                    ans = textBox2 + textBox1;
                    break;
                case "-":
                    ans = textBox2 - textBox1;
                    break;
                case "/":
                    ans = textBox2 / textBox1;
                    break;
                case "*":
                    ans = textBox1 * textBox2;
                    break;
                case "%":
                    ans = textBox2 % textBox1;
                    break;
              
            }

            output1.Text = Convert.ToString(ans);
        }

        private void input2_TextChanged(object sender, EventArgs e)
        {
            if (input2.Text != "")
            {
                int result;
                if (!int.TryParse(input2.Text, out result))
                {
                    input2.Text = "";
                    MessageBox.Show("入力できる値は数字のみです");
                }
            }
        }
    }
}
