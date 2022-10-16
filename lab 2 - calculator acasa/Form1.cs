using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2___calculator_acasa
{
    public partial class Form1 : Form
    {
        string Operation;
        double FirstNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text ="1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = null;
            textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text += ".";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(label1.Text);
            textBox1.Text = "0";
            Operation = "+";
            //label1.Text += "+";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(label1.Text);
            textBox1.Text = "0";
            Operation = "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(label1.Text);
            textBox1.Text = "0";
            Operation = "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(label1.Text);
            textBox1.Text = "0";
            Operation = "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //label1.Text+='=';
            var SecondNumber = Convert.ToDouble(label1.Text);
            double Result;

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                    textBox1.Text = "Cannot divide by zero";
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           /* double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(label1.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }*/
        }
    }
}
