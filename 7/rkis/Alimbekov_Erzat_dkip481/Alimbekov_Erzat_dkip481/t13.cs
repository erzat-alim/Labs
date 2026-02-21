using System;
using System.Windows.Forms;
using static System.Math;

namespace Alimbekov_Erzat_dkip481
{
    public partial class t13 : Form
    {
        public t13()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int upper = 0;
            int lower = 0;
            string text = this.textBoxString.Text;
            for (int i=0; i < text.Length; i++)
            {
                if (char.IsLower(text[i])) { upper += 1; } else { lower += 1; }
            }
            this.labelResult.Text = $"Результат:"
                + "\nПрописные:{Math.Round(Convert.ToDouble(lower * 100 / (lower+upper)), 4)}%" 
                + "\nСтрочные: {Math.Round(Convert.ToDouble(upper * 100 / (lower + upper)), 2)}%";
        }
    }
}
