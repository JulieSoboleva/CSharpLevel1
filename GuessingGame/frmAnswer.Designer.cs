namespace GuessingGame
{
    partial class frmAnswer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnswer));
            this.tbUserAnswer = new System.Windows.Forms.TextBox();
            this.bCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUserAnswer
            // 
            this.tbUserAnswer.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbUserAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserAnswer.Location = new System.Drawing.Point(0, 0);
            this.tbUserAnswer.Name = "tbUserAnswer";
            this.tbUserAnswer.Size = new System.Drawing.Size(203, 22);
            this.tbUserAnswer.TabIndex = 2;
            // 
            // bCheck
            // 
            this.bCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.bCheck.Location = new System.Drawing.Point(0, 22);
            this.bCheck.Name = "bCheck";
            this.bCheck.Size = new System.Drawing.Size(203, 28);
            this.bCheck.TabIndex = 3;
            this.bCheck.Text = "Проверить";
            this.bCheck.UseVisualStyleBackColor = true;
            this.bCheck.Click += new System.EventHandler(this.bCheck_Click);
            // 
            // frmAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(203, 52);
            this.Controls.Add(this.bCheck);
            this.Controls.Add(this.tbUserAnswer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnswer";
            this.Text = "Введите Ваш ответ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAnswer_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbUserAnswer;
        private System.Windows.Forms.Button bCheck;
    }
}