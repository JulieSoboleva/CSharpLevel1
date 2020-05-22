namespace Doubler
{
    partial class frmDoubler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoubler));
            this.lCurrent = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lCounter = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiGame = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.bCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lTarget = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lSteps = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lCurrent
            // 
            this.lCurrent.AutoSize = true;
            this.lCurrent.Location = new System.Drawing.Point(155, 101);
            this.lCurrent.Name = "lCurrent";
            this.lCurrent.Size = new System.Drawing.Size(16, 17);
            this.lCurrent.TabIndex = 0;
            this.lCurrent.Text = "0";
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(232, 43);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(116, 23);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+ 1";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Location = new System.Drawing.Point(232, 72);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(116, 23);
            this.btnCommand2.TabIndex = 2;
            this.btnCommand2.Text = "x 2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(232, 130);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(116, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lText
            // 
            this.lText.AutoSize = true;
            this.lText.Location = new System.Drawing.Point(12, 130);
            this.lText.Name = "lText";
            this.lText.Size = new System.Drawing.Size(110, 17);
            this.lText.TabIndex = 4;
            this.lText.Text = "Сделано ходов:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Текущее значение:";
            // 
            // lCounter
            // 
            this.lCounter.AutoSize = true;
            this.lCounter.Location = new System.Drawing.Point(155, 130);
            this.lCounter.Name = "lCounter";
            this.lCounter.Size = new System.Drawing.Size(16, 17);
            this.lCounter.TabIndex = 6;
            this.lCounter.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGame});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(360, 28);
            this.menuStrip1.TabIndex = 7;
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
            this.tsmiNewGame.Size = new System.Drawing.Size(136, 26);
            this.tsmiNewGame.Text = "Новая";
            this.tsmiNewGame.Click += new System.EventHandler(this.tsmiNewGame_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(136, 26);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(232, 101);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(116, 23);
            this.bCancel.TabIndex = 8;
            this.bCancel.Text = "Отменить ход";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Получить число:";
            // 
            // lTarget
            // 
            this.lTarget.AutoSize = true;
            this.lTarget.Location = new System.Drawing.Point(155, 43);
            this.lTarget.Name = "lTarget";
            this.lTarget.Size = new System.Drawing.Size(16, 17);
            this.lTarget.TabIndex = 10;
            this.lTarget.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Максимум шагов:";
            // 
            // lSteps
            // 
            this.lSteps.AutoSize = true;
            this.lSteps.Location = new System.Drawing.Point(155, 72);
            this.lSteps.Name = "lSteps";
            this.lSteps.Size = new System.Drawing.Size(16, 17);
            this.lSteps.TabIndex = 12;
            this.lSteps.Text = "0";
            // 
            // frmDoubler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 176);
            this.Controls.Add(this.lSteps);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lTarget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lCounter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lText);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCommand2);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lCurrent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDoubler";
            this.Text = "Удвоитель";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDoubler_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCurrent;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lCounter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiGame;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewGame;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lTarget;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lSteps;
    }
}

