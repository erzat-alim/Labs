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
    public partial class t6 : Form
    {
        public t6()
        {
            InitializeComponent();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(this.textBoxNum1.Text);
            int num2 = Convert.ToInt32(this.textBoxNum2.Text);

            this.labelResult.Text = "Результат: " + ((num1 + num2)/2).ToString();
        }
    }
}
