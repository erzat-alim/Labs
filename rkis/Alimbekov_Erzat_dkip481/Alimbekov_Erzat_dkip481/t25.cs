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
    public partial class t25 : Form
    {
        public t25()
        {
            InitializeComponent();
        }

        private void buttonCulc_Click(object sender, EventArgs e)
        {
            string[] param1 = textBox1.Text.Split('-');
            string[] param2 = textBox2.Text.Split('-');

            labelResult.Text = $"Результат:\n{param1[0]}-{param2[1]}\n{param2[0]}-{param1[1]}";
        }
    }
}
