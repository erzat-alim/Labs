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
    public partial class InsertVipiskaForm : MetroFramework.Forms.MetroForm
    {
        private readonly string fail = @"C:\Users\desckjett\docs\vipiska.docx";
        public InsertVipiskaForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var detal = comboBoxDetail.Text;
            var kolichestvo = numericUpDownKolichestvo.Text;
            var summa = numericUpDownSumma.Text;
            var data_vipiski = dateTimePickerData.Text;
            var wordap = new Word.Application();

            wordap.Visible = false;

            var worddoc = wordap.Documents.Open(fail);

            ReplaceWord("{Name}", detal, worddoc);
            ReplaceWord("{kolichestvo}", kolichestvo, worddoc);
            ReplaceWord("{summa}", summa, worddoc);
            ReplaceWord("{summal}", summa, worddoc);
            ReplaceWord("{Data_vipiski}", data_vipiski, worddoc);

            worddoc.SaveAs2(@"C:\Users\desckjett\docs\vipiska1.docx");
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
