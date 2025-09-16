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
    public partial class t26 : Form
    {
        public t26()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int factorial = 1;
            for (int i = 2; i < Convert.ToInt32(this.textBoxNumber.Text); i++)
            {
                factorial *= i;
            }
            this.labelResult.Text = "Результат: " + factorial.ToString();
        }
    }
}
