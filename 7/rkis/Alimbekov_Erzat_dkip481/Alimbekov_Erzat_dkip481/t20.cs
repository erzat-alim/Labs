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
    public partial class t20 : Form
    {
        public t20()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(this.textBoxNumber.Text);
            this.labelResult.Text = 
                $"Результат:\nf({x}) = {(x*x - 2*x + 23).ToString()}";
        }
    }
}
