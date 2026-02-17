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
    public partial class t10 : Form
    {
        public t10()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            string number = this.textBoxNumber.Text;
            int[] digits = new int[number.Length];
            for (int i=0;i<number.Length; i++)
            {
                digits[i] = Convert.ToInt32(number[i].ToString());
            }
            int multiple = 1;
            for (int i=0;i<digits.Length; i++)
            {
                multiple *= digits[i];
            }
            this.labelResult.Text = $"Результат:\nСумма = {digits.Sum()}" 
                + "\nПроизведение = {multiple}";
        }
    }
}
