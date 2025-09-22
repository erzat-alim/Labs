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
    public partial class t16 : Form
    {
        public t16()
        {
            InitializeComponent();
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int digits = textBoxNumber.Text.Length;
            string pm = "положительное";
            if (Convert.ToInt32(textBoxNumber.Text) < 0)
            {
                digits--;
                pm = "отрицательное";
            }
            this.labelResult.Text = $"Результат: \nКоливество цифр: {digits}\nЧисло {pm}";
        }
    }
}
