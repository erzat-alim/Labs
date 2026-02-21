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
    public partial class t19 : Form
    {
        public t19()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int even = 0;
            int odd = 0;
            for (int i=0;i<textBoxNumber.Text.Length;i++)
            {
                _ = Convert.ToInt32(textBoxNumber.Text[i].ToString()) % 2 == 0 ? even++ : odd++;
            }
            this.labelResult.Text = $"Результат: \nЧетные: {even}\nНечетные: {odd}";
        }
    }
}
