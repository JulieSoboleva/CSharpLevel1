using System;
using Class_Udvoitel;
using System.Windows.Forms;

namespace Doubler
{
    public partial class frmDoubler : Form
    {
        Udvoitel udvoitel = new Udvoitel();

        public frmDoubler()
        {
            InitializeComponent();
            tsmiNewGame.PerformClick();
        }

        void ShowInfo()
        {
            lTarget.Text = udvoitel.Finish.ToString();
            lSteps.Text = udvoitel.Steps.ToString();
            lCurrent.Text = udvoitel.ToString();
            lCounter.Text = udvoitel.Count.ToString();
            if (udvoitel.CheckResult())
                if (MessageBox.Show("Заданное число получено!\n\n Начать новую игру?", "Поздравление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    tsmiNewGame_Click(null, null);
            if (udvoitel.CheckSteps())
                if (MessageBox.Show("Ходы закончились!\n\n Начать новую игру?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    tsmiNewGame_Click(null, null);
        }

        private void frmDoubler_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Выход", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            udvoitel.Plus();
            ShowInfo();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            udvoitel.Multi();
            ShowInfo();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            udvoitel.Reset();
            ShowInfo();
        }

        private void tsmiNewGame_Click(object sender, EventArgs e)
        {
            udvoitel = new Udvoitel();
            ShowInfo();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            udvoitel.Back();
            ShowInfo();
        }
    }
}
