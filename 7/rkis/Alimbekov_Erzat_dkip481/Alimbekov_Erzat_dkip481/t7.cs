using System;
using System.Windows.Forms;

namespace Alimbekov_Erzat_dkip481
{
    public partial class t7 : Form
    {
        public t7()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int rows = Convert.ToInt32(this.numericUpDownRows.Value);
            int columns = Convert.ToInt32(this.numericUpDownColumns.Value);
            string raw_matrix = this.textBoxMatrix.Text;
            string[] lines = new string[rows];
            int sum = 0;
            int prod = 1;
            for (int i = 0; i < rows; i++)
            {
                lines[i] = raw_matrix.Split('\n')[i].ToString();
                for (int j = 0; j < columns; j++)
                {
                    sum += Convert.ToInt32(lines[i].Split()[j].ToString());
                    prod *= Convert.ToInt32(lines[i].Split()[j].ToString());
                }
            }
            labelResult.Text = $"Результат: \nСумма: {sum}\nПроизведение: {prod}";
        }
    }
}
