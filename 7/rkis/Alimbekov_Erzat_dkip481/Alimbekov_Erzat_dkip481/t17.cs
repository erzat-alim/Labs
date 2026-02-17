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
    public partial class t17 : Form
    {
        public t17()
        {
            InitializeComponent();
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(textBoxNumber.Text);
            int result = year % 4 == 0 ? 366 : 365;
            this.labelResult.Text = "Результат: " + result;
        }
    }
}
