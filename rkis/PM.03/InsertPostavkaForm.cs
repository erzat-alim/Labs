using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace PM._03
{
    public partial class InsertPostavkaForm : MetroFramework.Forms.MetroForm
    {
        private readonly string fail = @"C:\Users\desckjett\docs\dogovor.docx";
        public InsertPostavkaForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            var detal = comboBoxDetail.Text;
            var kolichestvo = numericUpDownKolichestvo.Text;
            var summa = numericUpDownSumma.Text;
            var garantiya = textBoxGarantiya.Text;
            var postavschik = comboBoxPostavschik.Text;
            var data_postavki = dateTimePickerData.Text;
            var wordap = new Word.Application();

            wordap.Visible = false;

            var worddoc = wordap.Documents.Open(fail);

            ReplaceWord("{Name_p}", postavschik, worddoc);
            ReplaceWord("{Name_d}", detal, worddoc);
            ReplaceWord("{Kolichestvo}", kolichestvo, worddoc);
            ReplaceWord("{Summa}", summa, worddoc);
            ReplaceWord("{Garantiya}", garantiya, worddoc);
            ReplaceWord("{Data_postavki}", data_postavki, worddoc);

            worddoc.SaveAs2(@"C:\Users\desckjett\docs\dogovor1.docx");
            worddoc.Close();
        }
        private void ReplaceWord(string stubreplace, string text, Word.Document worddoc)
        {
            var range = worddoc.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubreplace, ReplaceWith: text);
        }
    }
}
