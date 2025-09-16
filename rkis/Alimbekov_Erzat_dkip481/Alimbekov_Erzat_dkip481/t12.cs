using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace Alimbekov_Erzat_dkip481
{
    public partial class t12 : Form
    {
        public t12()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(numericUpDownN.Value);
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                int p1 = Convert.ToInt32(this.textBoxPoint1.Text.Split()[i].ToString());
                int p2 = Convert.ToInt32(this.textBoxPoint2.Text.Split()[i].ToString());
                sum += (p1 - p2) * (p1 - p2);
            }
            this.labelResult.Text = "Результат: " + Math.Round(Math.Sqrt(sum), 2).ToString();
        }
    }
}
