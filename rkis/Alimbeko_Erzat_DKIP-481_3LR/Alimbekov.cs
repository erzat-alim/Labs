using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alimbeko_Erzat_DKIP_481_3LR
{
    public partial class Alimbekov : Form
    {
        public Alimbekov()
        {
            InitializeComponent();
        }

        

        private void buttonChars_Click(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            labelChars.Text = txt.Length.ToString();

        }

        private void buttonLetter_Click(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            uint countLetter = (uint)txt.Count(char.IsLetter);
            labelLetter.Text = countLetter.ToString();
        }

        private void buttonWords_Click(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            int countWord = txt.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
            labelWords.Text = countWord.ToString();
        }

        private void buttonStrings_Click(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            int countString = txt.Split(new char[] {'\n'}).Length;
            labelStrings.Text = countString.ToString();
        }
        private string stringRecover = string.Empty;
        private void buttonClear_Click(object sender, EventArgs e)
        {
            stringRecover = textBox1.Text;
            textBox1.Clear();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (stringRecover == string.Empty) { return; }
            textBox1.Text = stringRecover;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = File.ReadAllText(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка записи файла: {ex.Message}");
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            try
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, textBox1.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка чтения файла: {ex.Message}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLetterCount_Click(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            char letter = 
            uint countLetter = (uint)txt.Count();
            labelLetter.Text = countLetter.ToString();
        }
    }
}
