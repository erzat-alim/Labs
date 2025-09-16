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
    public partial class t23 : Form
    {
        public t23()
        {
            InitializeComponent();
        }

        private void buttonCulc_Click(object sender, EventArgs e)
        {
            string result = "\n";
            for (int i=Convert.ToInt32(this.textBoxA.Text);
                i<=Convert.ToInt32(this.textBoxB.Text); 
                i++)
            {
                result += $"{i*i} ";
            }
            this.labelResult.Text = "Результат:" + result;
        }
    }
}
