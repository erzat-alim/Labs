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
    public partial class t21 : Form
    {
        public t21()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            string text = this.textBoxNumber.Text;
            char[] arr = text.ToCharArray();
            Array.Reverse(arr);
            text = new String(arr);
            this.labelResult.Text = "Результат: " + text;
        }
    }
}
