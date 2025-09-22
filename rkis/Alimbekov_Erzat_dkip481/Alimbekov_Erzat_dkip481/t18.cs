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
using static System.Math;
namespace Alimbekov_Erzat_dkip481
{
    public partial class t18 : Form
    {
        public t18()
        {
            InitializeComponent();
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCulc_Click(object sender, EventArgs e)
        {
            string[] numbers_raw = textBoxNumbers.Text.Split();
            int[] nums = new int[numbers_raw.Length];
            for (int i = 0; i < numbers_raw.Length; i++)
            {
                nums[i] = Convert.ToInt32(numbers_raw[i]);
            }
            double avg = nums.Sum() / (double)nums.Length;

            string result = "";
            int deviation = Convert.ToInt32(textBoxDev.Text);
            for (int i = 0;i < nums.Length;i++)
            {
                if (Abs(nums[i] - avg) > deviation) { result += $" {nums[i]}"; }
            }
            this.labelResult.Text = $"Результат: \n{result}";
        }
    }
}
