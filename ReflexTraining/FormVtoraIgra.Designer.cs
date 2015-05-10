namespace ReflexTraining
{
    partial class FormVtoraIgra
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
            this.cbBrzina = new System.Windows.Forms.ComboBox();
            this.cbTezina = new System.Windows.Forms.ComboBox();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPoeni = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTopIgraci = new System.Windows.Forms.Button();
            this.btnNovaIgra = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPrethodniPoeni = new System.Windows.Forms.Label();
            this.lblBestScore = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlIgra = new ReflexTraining.pnlIgra();
            this.lblStartGame = new System.Windows.Forms.Label();
            this.pnlIgra.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbBrzina
            // 
            this.cbBrzina.FormattingEnabled = true;
            this.cbBrzina.Location = new System.Drawing.Point(102, 309);
            this.cbBrzina.Name = "cbBrzina";
            this.cbBrzina.Size = new System.Drawing.Size(75, 21);
            this.cbBrzina.TabIndex = 20;
            // 
            // cbTezina
            // 
            this.cbTezina.FormattingEnabled = true;
            this.cbTezina.Location = new System.Drawing.Point(12, 309);
            this.cbTezina.Name = "cbTezina";
            this.cbTezina.Size = new System.Drawing.Size(84, 21);
            this.cbTezina.TabIndex = 19;
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.Location = new System.Drawing.Point(519, 310);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(43, 24);
            this.lblSeconds.TabIndex = 18;
            this.lblSeconds.Text = "120";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(333, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Seconds Remaining:";
            // 
            // lblPoeni
            // 
            this.lblPoeni.AutoSize = true;
            this.lblPoeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoeni.Location = new System.Drawing.Point(503, 344);
            this.lblPoeni.Name = "lblPoeni";
            this.lblPoeni.Size = new System.Drawing.Size(16, 17);
            this.lblPoeni.TabIndex = 16;
            this.lblPoeni.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "For every hit: +100pts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "For every miss: -100pts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Current Points:";
            // 
            // btnTopIgraci
            // 
            this.btnTopIgraci.Location = new System.Drawing.Point(12, 383);
            this.btnTopIgraci.Name = "btnTopIgraci";
            this.btnTopIgraci.Size = new System.Drawing.Size(165, 22);
            this.btnTopIgraci.TabIndex = 12;
            this.btnTopIgraci.Text = "Top Scores";
            this.btnTopIgraci.UseVisualStyleBackColor = true;
            this.btnTopIgraci.Click += new System.EventHandler(this.btnTopIgraci_Click);
            // 
            // btnNovaIgra
            // 
            this.btnNovaIgra.Location = new System.Drawing.Point(12, 333);
            this.btnNovaIgra.Name = "btnNovaIgra";
            this.btnNovaIgra.Size = new System.Drawing.Size(165, 22);
            this.btnNovaIgra.TabIndex = 11;
            this.btnNovaIgra.Text = "New Game";
            this.btnNovaIgra.UseVisualStyleBackColor = true;
            this.btnNovaIgra.Click += new System.EventHandler(this.btnNovaIgra_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Rules:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Previous Points:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(334, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Your Best Score:";
            // 
            // lblPrethodniPoeni
            // 
            this.lblPrethodniPoeni.AutoSize = true;
            this.lblPrethodniPoeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrethodniPoeni.Location = new System.Drawing.Point(503, 366);
            this.lblPrethodniPoeni.Name = "lblPrethodniPoeni";
            this.lblPrethodniPoeni.Size = new System.Drawing.Size(16, 17);
            this.lblPrethodniPoeni.TabIndex = 24;
            this.lblPrethodniPoeni.Text = "0";
            // 
            // lblBestScore
            // 
            this.lblBestScore.AutoSize = true;
            this.lblBestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestScore.Location = new System.Drawing.Point(503, 386);
            this.lblBestScore.Name = "lblBestScore";
            this.lblBestScore.Size = new System.Drawing.Size(16, 17);
            this.lblBestScore.TabIndex = 25;
            this.lblBestScore.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 358);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(165, 22);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pnlIgra
            // 
            this.pnlIgra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlIgra.Controls.Add(this.lblStartGame);
            this.pnlIgra.Location = new System.Drawing.Point(0, 0);
            this.pnlIgra.Name = "pnlIgra";
            this.pnlIgra.Size = new System.Drawing.Size(584, 303);
            this.pnlIgra.TabIndex = 0;
            this.pnlIgra.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlIgra_Paint);
            this.pnlIgra.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlIgra_MouseClick);
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
            // FormVtoraIgra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 412);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblBestScore);
            this.Controls.Add(this.lblPrethodniPoeni);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbBrzina);
            this.Controls.Add(this.cbTezina);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPoeni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTopIgraci);
            this.Controls.Add(this.btnNovaIgra);
            this.Controls.Add(this.pnlIgra);
            this.Name = "FormVtoraIgra";
            this.Text = "Fast Aiming Game";
            this.pnlIgra.ResumeLayout(false);
            this.pnlIgra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pnlIgra pnlIgra;
        private System.Windows.Forms.ComboBox cbBrzina;
        private System.Windows.Forms.ComboBox cbTezina;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPoeni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTopIgraci;
        private System.Windows.Forms.Button btnNovaIgra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPrethodniPoeni;
        private System.Windows.Forms.Label lblBestScore;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblStartGame;
    }
}