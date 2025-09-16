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
    public partial class t3 : Form
    {
        public t3()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            string text = this.textBox.Text;
            string even = "";
            string odd = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 0) { even += text[i]; } else { odd += text[i]; }
            }
            this.labelResult.Text += $"\nЧетные символы: {even}\nНечетные символы:{odd}";
        }
    }
}
