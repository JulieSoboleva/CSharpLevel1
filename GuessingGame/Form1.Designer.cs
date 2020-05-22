namespace GuessingGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiGame = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lNumber = new System.Windows.Forms.Label();
            this.lMaxCount = new System.Windows.Forms.Label();
            this.lResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lCount = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGame});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(422, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiGame
            // 
            this.tsmiGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewGame,
            this.toolStripMenuItem1,
            this.tsmiExit});
            this.tsmiGame.Name = "tsmiGame";
            this.tsmiGame.Size = new System.Drawing.Size(57, 24);
            this.tsmiGame.Text = "Игра";
            // 
            // tsmiNewGame
            // 
            this.tsmiNewGame.Name = "tsmiNewGame";
            this.tsmiNewGame.Size = new System.Drawing.Size(224, 26);
            this.tsmiNewGame.Text = "Новая";
            this.tsmiNewGame.Click += new System.EventHandler(this.tsmiNewGame_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(224, 26);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Угадайте число от 1 до 100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Максимальное количество попыток:";
            // 
            // lNumber
            // 
            this.lNumber.AutoSize = true;
            this.lNumber.Location = new System.Drawing.Point(348, 47);
            this.lNumber.Name = "lNumber";
            this.lNumber.Size = new System.Drawing.Size(16, 17);
            this.lNumber.TabIndex = 11;
            this.lNumber.Text = "0";
            this.lNumber.Visible = false;
            // 
            // lMaxCount
            // 
            this.lMaxCount.AutoSize = true;
            this.lMaxCount.Location = new System.Drawing.Point(348, 76);
            this.lMaxCount.Name = "lMaxCount";
            this.lMaxCount.Size = new System.Drawing.Size(16, 17);
            this.lMaxCount.TabIndex = 12;
            this.lMaxCount.Text = "0";
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Location = new System.Drawing.Point(16, 108);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(0, 17);
            this.lResult.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Количество оставшихся попыток:";
            // 
            // lCount
            // 
            this.lCount.AutoSize = true;
            this.lCount.Location = new System.Drawing.Point(348, 140);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(16, 17);
            this.lCount.TabIndex = 15;
            this.lCount.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 176);
            this.Controls.Add(this.lCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.lMaxCount);
            this.Controls.Add(this.lNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Угадай число";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiGame;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewGame;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lNumber;
        private System.Windows.Forms.Label lMaxCount;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lCount;
    }
}

