using System;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class frmAnswer : Form
    {
        public int userNumber;
        public Action answer;

        public frmAnswer()
        {
            InitializeComponent();
        }

        private void bCheck_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbUserAnswer.Text, out userNumber))
                MessageBox.Show("Введите число", "Внимание");
            else
                answer();
        }

        private void frmAnswer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
