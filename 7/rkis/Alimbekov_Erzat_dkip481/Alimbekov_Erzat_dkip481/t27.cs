using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Math;

namespace Alimbekov_Erzat_dkip481
{
    public partial class t27 : Form
    {
        public t27()
        {
            InitializeComponent();
        }

        private void buttonCulc_Click(object sender, EventArgs e)
        {
            string[] numbers_string = textBoxNumbers.Text.Split();
            double[] numbers = numbers_string.Select(num => Convert.ToDouble(num)).ToArray();
            double result = 1;
            for (int i = 0; i < numbers.Length; i++) { result *= numbers[i]; }
            labelResult.Text = $"Результат: \n{Round(result, Convert.ToInt32(textBoxApprox.Text))}";
        }
    }
}
