namespace ReflexTraining
{
    partial class FormTretaIgra
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
            this.lblVreme = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblMiss = new System.Windows.Forms.Label();
            this.lblHit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTezina = new System.Windows.Forms.ComboBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBestScore = new System.Windows.Forms.Label();
            this.lblPrethodniPoeni = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPoeni = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlIgra = new ReflexTraining.pnlIgra();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStartGame = new System.Windows.Forms.Label();
            this.pnlIgra.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVreme.Location = new System.Drawing.Point(487, 309);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(43, 24);
            this.lblVreme.TabIndex = 24;
            this.lblVreme.Text = "120";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(318, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Seconds Remaining:";
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(267, 385);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(45, 13);
            this.lblLeft.TabIndex = 22;
            this.lblLeft.Text = "-500 pts";
            // 
            // lblMiss
            // 
            this.lblMiss.AutoSize = true;
            this.lblMiss.Location = new System.Drawing.Point(267, 365);
            this.lblMiss.Name = "lblMiss";
            this.lblMiss.Size = new System.Drawing.Size(45, 13);
            this.lblMiss.TabIndex = 21;
            this.lblMiss.Text = "-100 pts";
            // 
            // lblHit
            // 
            this.lblHit.AutoSize = true;
            this.lblHit.Location = new System.Drawing.Point(267, 346);
            this.lblHit.Name = "lblHit";
            this.lblHit.Size = new System.Drawing.Size(48, 13);
            this.lblHit.TabIndex = 20;
            this.lblHit.Text = "+300 pts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "For Every Left:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "For Every Miss:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "For Every Hit:";
            // 
            // cbTezina
            // 
            this.cbTezina.FormattingEnabled = true;
            this.cbTezina.Location = new System.Drawing.Point(12, 309);
            this.cbTezina.Name = "cbTezina";
            this.cbTezina.Size = new System.Drawing.Size(109, 21);
            this.cbTezina.TabIndex = 16;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(12, 336);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(139, 23);
            this.btnNewGame.TabIndex = 14;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(209, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Rules:";
            // 
            // lblBestScore
            // 
            this.lblBestScore.AutoSize = true;
            this.lblBestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestScore.Location = new System.Drawing.Point(503, 381);
            this.lblBestScore.Name = "lblBestScore";
            this.lblBestScore.Size = new System.Drawing.Size(16, 17);
            this.lblBestScore.TabIndex = 33;
            this.lblBestScore.Text = "0";
            // 
            // lblPrethodniPoeni
            // 
            this.lblPrethodniPoeni.AutoSize = true;
            this.lblPrethodniPoeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrethodniPoeni.Location = new System.Drawing.Point(503, 361);
            this.lblPrethodniPoeni.Name = "lblPrethodniPoeni";
            this.lblPrethodniPoeni.Size = new System.Drawing.Size(16, 17);
            this.lblPrethodniPoeni.TabIndex = 32;
            this.lblPrethodniPoeni.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(334, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Your Best Score:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Previous Points:";
            // 
            // lblPoeni
            // 
            this.lblPoeni.AutoSize = true;
            this.lblPoeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoeni.Location = new System.Drawing.Point(503, 339);
            this.lblPoeni.Name = "lblPoeni";
            this.lblPoeni.Size = new System.Drawing.Size(16, 17);
            this.lblPoeni.TabIndex = 29;
            this.lblPoeni.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(334, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Current Points:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 362);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(139, 23);
            this.btnReset.TabIndex = 34;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Top Scorers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlIgra
            // 
            this.pnlIgra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlIgra.Controls.Add(this.label9);
            this.pnlIgra.Controls.Add(this.lblStartGame);
            this.pnlIgra.Location = new System.Drawing.Point(0, 0);
            this.pnlIgra.Name = "pnlIgra";
            this.pnlIgra.Size = new System.Drawing.Size(584, 303);
            this.pnlIgra.TabIndex = 1;
            this.pnlIgra.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlIgra_Paint);
            this.pnlIgra.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlIgra_MouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(292, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 22);
            this.label9.TabIndex = 1;
            // 
            // lblStartGame
            // 
            this.lblStartGame.AutoSize = true;
            this.lblStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartGame.Location = new System.Drawing.Point(266, 137);
            this.lblStartGame.Name = "lblStartGame";
            this.lblStartGame.Size = new System.Drawing.Size(0, 22);
            this.lblStartGame.TabIndex = 0;
            // 
            // FormTretaIgra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 412);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblBestScore);
            this.Controls.Add(this.lblPrethodniPoeni);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPoeni);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblVreme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.lblMiss);
            this.Controls.Add(this.lblHit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTezina);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.pnlIgra);
            this.Name = "FormTretaIgra";
            this.Text = "Exact Aiming Game";
            this.pnlIgra.ResumeLayout(false);
            this.pnlIgra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pnlIgra pnlIgra;
        private System.Windows.Forms.Label lblStartGame;
        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblMiss;
        private System.Windows.Forms.Label lblHit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTezina;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBestScore;
        private System.Windows.Forms.Label lblPrethodniPoeni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPoeni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
    }
}