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
    public partial class t8 : Form
    {
        public t8()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int rows = Convert.ToInt32(this.numericUpDownRows.Value);
            int columns = Convert.ToInt32(this.numericUpDownColumns.Value);
            string raw_matrix = this.textBoxMatrix.Text;
            string[] lines = new string[rows];
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                lines[i] = raw_matrix.Split('\n')[i].ToString();
                for (int j = 0; j < columns; j++)
                {
                    if (i==j && Convert.ToInt32(lines[i].Split()[j].ToString()) > 0) { count++; }
                }
            }
            labelResult.Text = $"Результат: \n{count} элементов";
        }

        private void labelTask_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownRows_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownColumns_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMatrix_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
