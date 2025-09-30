using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alimbekov_Erzat_dkip481_2
{
    public partial class Form1 : Form
    {
        private bool point = true;
        private double firstArgument, secondArgument;
        public enum Actions { Plus, Minus, Product, Divide};
        Actions action;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += button0.Text;
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (point) textBox1.Text += buttonPoint.Text;
            point = false;
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            textBox1.Text = (-Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            point = true;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            point = Argument(textBox1.Text, out secondArgument);
            textBox1.Text = Solution(action, firstArgument, secondArgument);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            point = Argument(textBox1.Text, out firstArgument);
            action = Actions.Minus;
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            point = Argument(textBox1.Text, out firstArgument);
            action = Actions.Product;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            point = Argument(textBox1.Text, out firstArgument);
            action = Actions.Divide;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            point = Argument(textBox1.Text, out firstArgument);
            action = Actions.Plus;
        }
        private string Solution(Actions ac, double a1, double a2)
        {
            switch (ac)
            {
                case Actions.Plus:
                    return (a1 + a2).ToString();
                case Actions.Minus:
                    return (a1 - a2).ToString();
                case Actions.Product:
                    return (a1 * a2).ToString();
                case Actions.Divide:
                    return (a1 / a2).ToString();
            }
            return "";
        }
        private bool Argument(string txt, out double arg)
        {
            if (!double.TryParse(txt, out double argument))
            {
                MessageBox.Show("Enter correct number");
            }
            textBox1.Text = string.Empty;
            arg = argument;
            return true;
        }
    }
}
