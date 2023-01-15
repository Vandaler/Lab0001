using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_calculator
{
    public partial class Form1 : Form
    {
        double input1 = 0.00;
        string operation = "";
        double input2 = 0.00;
        double result = 0.00;
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            input1 = double.Parse(ResultBox1.Text);
            ResultBox1.Text = "";
            operation = "+";
            HistoryBx1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HistoryBx1.Clear();
            if (ResultBox1.Text == "0")
                ResultBox1.Text = "9";
            else
                ResultBox1.Text += "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            input1 = double.Parse(ResultBox1.Text);
            ResultBox1.Text = "";
            operation = "*";
            HistoryBx1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (ResultBox1.Text.Contains("-"))
                ResultBox1.Text = ResultBox1.Text.Trim('-');
            else
                ResultBox1.Text = "-" + ResultBox1.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (ResultBox1.Text.Length > 0)
            {
                ResultBox1.Text = ResultBox1.Text.Remove(ResultBox1.Text.Length - 1, 1);
            }
            if (ResultBox1.Text == "")
            {
                ResultBox1.Text = "0";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ResultBox1.Clear();
            if (ResultBox1.Text == String.Empty)
            {
                HistoryBx1.Text = "Cleared!";
                ResultBox1.Text = "0";
            }
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            input1 = double.Parse(ResultBox1.Text);
            ResultBox1.Text = "";
            operation = "-";
            HistoryBx1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            input1 = double.Parse(ResultBox1.Text);
            ResultBox1.Text = "";
            operation = "/";
            HistoryBx1.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ResultBox1.Text == "0")
            {
                ResultBox1.Text = "6";
                HistoryBx1.Clear();
            }
            else
                ResultBox1.Text += "6";
                HistoryBx1.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (ResultBox1.Text == "0")
            {
                ResultBox1.Text = "7";
                HistoryBx1.Clear();
            }
            else
                ResultBox1.Text += "7";
                HistoryBx1.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (ResultBox1.Text == "0")
            {
                ResultBox1.Text = "8";
                HistoryBx1.Clear();
            }
            else
                ResultBox1.Text += "8";
                HistoryBx1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (ResultBox1.Text == "0")
            {
                ResultBox1.Text = "0";
                HistoryBx1.Clear();
            }
            else
                ResultBox1.Text += "0";
                HistoryBx1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ResultBox1.Text == "0")
            {
                ResultBox1.Text = "2";
                HistoryBx1.Clear();
            }
            else
                ResultBox1.Text += "2";
                HistoryBx1.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ResultBox1.Text == "0")
            {
                ResultBox1.Text = "3";
                HistoryBx1.Clear();
            }
            else
                ResultBox1.Text += "3";
                HistoryBx1.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ResultBox1.Text == "0")
            {
                ResultBox1.Text = "4";
                HistoryBx1.Clear();
            }
            else
                ResultBox1.Text += "4";
                HistoryBx1.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ResultBox1.Text == "0")
            {
                ResultBox1.Text = "5";
                HistoryBx1.Clear();
            }
            else
                ResultBox1.Text += "5";
                HistoryBx1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ResultBox1.Text == "0")
            {
                ResultBox1.Text = "1";
                HistoryBx1.Clear();
            }
            else
                ResultBox1.Text += "1";
                HistoryBx1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input2 = double.Parse(ResultBox1.Text);
            if (operation == "+")
            {
                result = input1 + input2;
                ResultBox1.Text = result.ToString("#,###.#####");
                HistoryBx1.Text = ($"{input1.ToString("#,###.#####")}{operation}{input2.ToString("#,###.#####")} = \n");
            }
            else if (operation == "-")
            {
                result = input1 - input2;
                ResultBox1.Text = result.ToString("#,###.#####");
                HistoryBx1.Text = ($"{input1.ToString("#,###.#####")}{operation}{input2.ToString("#,###.#####")} = \n");
            }
            else if (operation == "*")
            {
                result = input1 * input2;
                ResultBox1.Text = result.ToString("#,###.#####");
                HistoryBx1.Text = ($"{input1.ToString("#,###.#####")}{operation}{input2.ToString("#,###.#####")} = \n");
            }
            else
                result = input1 / input2;
                ResultBox1.Text = result.ToString("#,###.#####");
                HistoryBx1.Text = ($"{input1.ToString("#,###.#####")}{operation}{input2.ToString("#,###.#####")} = \n");
            operation = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ResultBox1.Text.Contains(".")) {
                ResultBox1.Text += ".";
                HistoryBx1.Clear();
            };
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            ResultBox1.Text = "0";
            result = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
