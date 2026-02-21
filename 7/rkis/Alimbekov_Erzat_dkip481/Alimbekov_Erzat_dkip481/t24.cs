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
    public partial class t24 : Form
    {
        public t24()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBoxNumber.Text);
            if ((number % 10 >= 5 && number % 10 <=9 || number % 10 == 0) || (number % 100 >= 10 && number % 100 <= 20))
            {
                labelResult.Text = "яблок";
            } 
            else if(number % 10 >= 2 && number % 10 <= 4)
            {
                labelResult.Text = "яблока";
            }
            else
            {
                labelResult.Text = "яблоко";
            }
        }
    }
}
