using System;
using static System.Math;
using System.Windows.Forms;

namespace Alimbekov_Erzat_dkip481
{
    public partial class t5 : Form
    {
        public t5()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int rows = Convert.ToInt32(this.numericUpDownRows.Value);
            int columns = Convert.ToInt32(this.numericUpDownColumns.Value);
            string raw_matrix = this.textBoxMatrix.Text;
            string[] lines = new string[rows];
            int max_value = 0;
            for (int i = 0; i < rows; i++)
            {
                lines[i] = raw_matrix.Split('\n')[i].ToString();
                for (int j = 0; j < columns; j++)
                {
                    if (Abs(Convert.ToInt32(lines[i].Split()[j].ToString())) > max_value)
                    { max_value = Abs(Convert.ToInt32(lines[i].Split()[j].ToString())); }
                }
            }
            labelResult.Text = $"Результат: \n{max_value}";
        }
    }
}
