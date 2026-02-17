using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Alimbekov_Erzat_dkip481
{
    public partial class t14 : Form
    {
        public t14()
        {
            InitializeComponent();
        }

        private void buttonCulc_Click(object sender, EventArgs e)
        {
            string[] raw_p1 = textBox1.Text.Split();
            double[] p1 = raw_p1.Select(s => Convert.ToDouble(s)).ToArray();
            string[] raw_p2 = textBox2.Text.Split();
            double[] p2 = raw_p2.Select(s => Convert.ToDouble(s)).ToArray();

            double k = (p2[1] - p1[1]) / (p2[0] - p1[0]);
            double b = p1[1] - k * p1[0];

            this.labelResult.Text = $"Результат: y = {k}x + {b}";
        }
    }
}
