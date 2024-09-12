using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorSuper
{
    //convert: chuyển đổi giá trị
    public partial class Form1 : Form
    {
        double number1;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "8";
            }
            else
            {
                richTextBox1.Text += "8";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "7";
            }
            else
            {
                richTextBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "9";
            }
            else
            {
                richTextBox1.Text += "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "4";
            }
            else
            {
                richTextBox1.Text += "4";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "5";
            }
            else
            {
                richTextBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "6";
            }
            else
            {
                richTextBox1.Text += "6";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "1";
            }
            else
            {
                richTextBox1.Text += "1";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "2";
            }
            else
            {
                richTextBox1.Text += "2";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "3";
            }
            else
            {
                richTextBox1.Text += "3";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "0";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            operation = "/";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            operation = "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            if (richTextBox1.Text == "0"&& richTextBox1.Text!=null)
            {
                richTextBox1.Text = "-";
                number1 = Convert.ToDouble(richTextBox1.Text);
                richTextBox1.Text = "0";
                operation = "-";
            }
            else
            {
                number1 = Convert.ToDouble(richTextBox1.Text);
                richTextBox1.Text = "0";
                operation = "-";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            operation = "+";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += ".";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1);
            }
            if(richTextBox1.Text.Length<=0)
            {
                richTextBox1.Text = "0";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double result;
            double number2;

            number2 = Convert.ToDouble(richTextBox1.Text);
            if (operation == "+")
            {
                result = (number1 + number2);
                richTextBox1.Text = Convert.ToString(result);
                char[] charKEY = richTextBox1.Text.ToCharArray();
                Array.Reverse(charKEY);
                string k = new string(charKEY);
                richTextBox1.Text = k;
                number1 = result;
            }
            if (operation == "-")
            {
                
                result = (number1 - number2);
                richTextBox1.Text = Convert.ToString(result);
                char[] c=richTextBox1.Text.ToCharArray();
                Array.Reverse(c);
                string t= new string(c);
                richTextBox1.Text = t;
                number1 = result;
            }
            if (operation == "*")
            {
                result = (number1 * number2);
                richTextBox1.Text = Convert.ToString(result);
                number1 = result;
            }
            if (operation == "/")
            {
                if (number2 == 0)
                {
                    richTextBox1.Text = "ERROR";
                }
                else
                {
                    result = (number1 / number2);
                    richTextBox1.Text += Convert.ToString(result);
                    richTextBox1.Text = richTextBox1.Text.Substring(1);
                    number1 = result;
                }
            }
        }
    }
}
