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
        bool point = true;
        double firstArgument, secondArgument;
        Actions actions = Actions.None;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            bool point = true;
            if (point) textBox1.Text += buttonPoint.Text;
            point = false;
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            textBox1.Text = (-Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void buttonDelite_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            point = true;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            point = GetArgument(textBox1.Text, out firstArgument);
            actions = Actions.Plus;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            point = GetArgument(textBox1.Text, out firstArgument);
            actions = Actions.Minus;
        }

        private void buttonPower_Click(object sender, EventArgs e)
        {
            point = GetArgument(textBox1.Text, out firstArgument);
            actions = Actions.Power;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            point = GetArgument(textBox1.Text, out firstArgument);
            actions = Actions.Divide;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            point = GetArgument(textBox1.Text, out secondArgument);
            if (actions == Actions.Divide && Math.Abs(secondArgument) < double.Epsilon)
            {
                MessageBox.Show("Деление на ноль невозможно.");
                return;
            }

            string result = Solution(actions, firstArgument, secondArgument);
            if (string.IsNullOrEmpty(result))
                return;
            textBox1.Text = result;
        }
        private string Solution(Actions act, double a1, double a2)
        {
            double value;
            switch (act)
            {
                case Actions.Plus:
                    value = a1 + a2;
                    break; ;
                case Actions.Minus:
                    value = a1 - a2;
                    break;
                case Actions.Power:
                    value = a1 * a2;
                    break;
                case Actions.Divide:
                    value = a1 / a2;
                    break;
                default:
                    return "";
            }
            return value.ToString();
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double x)) { MessageBox.Show("Введите корректное число."); return; }
            double v = x * x;
            if (double.IsInfinity(v) || double.IsNaN(v)) { MessageBox.Show("Переполнение/неопределённость результата."); return; }
            textBox1.Text = v.ToString();
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double x)) { MessageBox.Show("Введите корректное число."); return; }
            if (x < 0) { MessageBox.Show("Нельзя извлечь корень из отрицательного числа."); return; }
            textBox1.Text = Math.Sqrt(x).ToString();
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double x)) { MessageBox.Show("Введите корректное число."); return; }
            textBox1.Text = Math.Sin(x).ToString();
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double x)) { MessageBox.Show("Введите корректное число."); return; }
            textBox1.Text = Math.Cos(x).ToString();
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double x)) { MessageBox.Show("Введите корректное число."); return; }
            double v = Math.Tan(x);
            if (double.IsInfinity(v) || double.IsNaN(v)) { MessageBox.Show("Тангенс не определён для этого значения."); return; }
            textBox1.Text = v.ToString();
        }

        private void buttonFact_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double x)) { MessageBox.Show("Введите корректное число."); return; }
            if (x < 0 || Math.Abs(x - Math.Truncate(x)) > 0) { MessageBox.Show("Факториал определён только для целых неотрицательных чисел."); return; }

            int n = (int)x;
            double r = 1.0;
            for (int i = 2; i <= n; i++)
            {
                r *= i;
                if (double.IsInfinity(r) || double.IsNaN(r)) { MessageBox.Show("Переполнение/неопределённость результата."); return; }
            }
            textBox1.Text = r.ToString();
        }

        private void buttonReciprocal_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double x)) { MessageBox.Show("Введите корректное число."); return; }
            if (Math.Abs(x) < double.Epsilon) { MessageBox.Show("Деление на ноль невозможно."); return; }
            textBox1.Text = (1.0 / x).ToString();
        }

        private void buttonPi_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.PI.ToString();
            point = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double x)) { MessageBox.Show("Введите корректное число."); return; }
            double t = Math.Tan(x);
            if (double.IsInfinity(t) || double.IsNaN(t) || Math.Abs(t) < 1e-15) { MessageBox.Show("Котангенс не определён для этого значения."); return; }
            textBox1.Text = (1.0 / t).ToString();
        }

        private void buttonSecond_Click(object sender, EventArgs e)
        {
            if (buttonSecond.Text == "2nd")
            {
                buttonSecond.Text = "1st";
                buttonSin.Text = "asin";
                buttonCos.Text = "acos";
                buttonTan.Text = "atan";
                buttonCot.Text = "acot";
            }
            else
            {
                buttonSecond.Text = "2nd";
                buttonSin.Text = "sin";
                buttonCos.Text = "cos";
                buttonTan.Text = "tan";
                buttonCot.Text = "cot";
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            firstArgument = 0;
            secondArgument = 0;
            actions = Actions.None;
            point = true;
        }

        private bool GetArgument(string txt, out double arg)
        {

            if (!double.TryParse(txt, out double argument))
            {
                MessageBox.Show("Введите корректное число");
            }
            textBox1.Text = string.Empty;
            arg = argument;
            return true;
        }
    }
}
