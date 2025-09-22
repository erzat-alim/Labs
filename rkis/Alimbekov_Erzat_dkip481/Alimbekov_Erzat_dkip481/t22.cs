using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alimbekov_Erzat_dkip481
{
    public partial class t22 : Form
    {
        public t22()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int rows = Convert.ToInt32(this.numericUpDownRows.Value);
            int columns = Convert.ToInt32(this.numericUpDownColumns.Value);
            string raw_matrix = this.textBoxMatrix.Text;
            string[] lines = new string[rows];
            int number = Convert.ToInt32(this.textBoxNumber.Text);
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                lines[i] = raw_matrix.Split('\n')[i].ToString();
                for (int j = 0; j < columns; j++)
                {
                    _ = number == Convert.ToInt32(lines[i].Split()[j].ToString()) ? count++ : count+=0;
                }
            }
            labelResult.Text = $"Результат: {count} раз";
        }
    }
}
