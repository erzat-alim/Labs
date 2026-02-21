using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM._03
{
    public partial class Menu : MetroFramework.Forms.MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PM._03.Properties.Settings.Default.l = 1;
            Form1 WorkSpace = new Form1();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PM._03.Properties.Settings.Default.l = 2;
            Form1 WorkSpace = new Form1();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PM._03.Properties.Settings.Default.l = 3;
            Form1 WorkSpace = new Form1();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PM._03.Properties.Settings.Default.l = 4;
            Form1 WorkSpace = new Form1();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PM._03.Properties.Settings.Default.l = 5;
            Form1 WorkSpace = new Form1();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PM._03.Properties.Settings.Default.l = 6;
            Form1 WorkSpace = new Form1();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PM._03.Properties.Settings.Default.l = 7;
            Form1 WorkSpace = new Form1();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PM._03.Properties.Settings.Default.l = 8;
            Form1 WorkSpace = new Form1();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PM._03.Properties.Settings.Default.l = 9;
            Form1 WorkSpace = new Form1();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }
    }
}
