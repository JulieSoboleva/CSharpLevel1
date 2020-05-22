using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        Guessing guess = new Guessing();
        frmAnswer frmAns = new frmAnswer();
        
        public Form1()
        {
            InitializeComponent();
            tsmiNewGame.PerformClick();
        }

        private void tsmiNewGame_Click(object sender, EventArgs e)
        {
            guess = new Guessing();
            ShowInfo("");
            frmAns.Show();
            frmAns.answer = DoIfUserAnswer;
        }

        private void DoIfUserAnswer()
        {
            bool result;
            string text = guess.CheckAnswer(frmAns.userNumber, out result);
            if (result)
            {
                ShowInfo(text, true);
                if (MessageBox.Show(text + "\n\nНачать новую игру?", "Поздравление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    tsmiNewGame_Click(null, null);
            }
            else
            {
                if (!guess.HasAttempts())
                {
                    if (MessageBox.Show($"Попыток больше не осталось. Загаданное число: {guess.Number}\n\nНачать новую игру?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        tsmiNewGame_Click(null, null);
                }
                else
                    ShowInfo(text);
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
            frmAns.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Выход", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        void ShowInfo(string resText, bool showNumber=false)
        {
            lNumber.Text = guess.Number.ToString();
            lMaxCount.Text = guess.maxCount.ToString();
            lResult.Text = resText;
            lNumber.Visible = showNumber;
            lCount.Text = guess.Count.ToString();
        }
    }
}
