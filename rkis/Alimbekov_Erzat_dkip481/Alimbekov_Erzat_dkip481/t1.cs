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
    public partial class t1 : Form
    {
        public t1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = this.textBoxNumber.Text.Trim();
            //this.textBoxNumber.Text = "";
            int sum = 0;
            try
            {
                for (int i = 1; i < txt.Length; i += 2)
                {
                    sum += Convert.ToInt32(txt[i].ToString());
                }
                this.labelResult.Text = "Результат: " + sum.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message + "\r\n\rВведите число");
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    if (openFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        string path = openFileDialog.FileName;
        //        this.labelResult.Text += '\n' + path;
        //    }
        //    SaveFileDialog saveFileDialog = new SaveFileDialog();
        //}
    }
}
