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
    public partial class Form15 : Form
    {
        private int secretNumber;
        private int attempts;
        private Random random = new Random();
        public Form15()
        {
            InitializeComponent();
            StartNewGame();
        }
        private void StartNewGame()
        {
            secretNumber = random.Next(1, 101);
            attempts = 0;
            labelInfo.Text = "Я загадал число от 1 до 100. Попробуй угадать!";
            textBoxGuess.Text = "";
            labelResult.Text = "";
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            try
            {
                int guess = int.Parse(textBoxGuess.Text);
                attempts++;

                if (guess < secretNumber)
                    labelResult.Text = "Загаданное число БОЛЬШЕ";
                else if (guess > secretNumber)
                    labelResult.Text = "Загаданное число МЕНЬШЕ";
                else
                {
                    labelResult.Text = $"Поздравляю! Вы угадали за {attempts} попыток";
                    buttonNewGame.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            StartNewGame();
            buttonNewGame.Enabled = false;
        }
    }
}