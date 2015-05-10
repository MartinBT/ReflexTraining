namespace ReflexTraining
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIgraPrva = new System.Windows.Forms.Button();
            this.btnIgraVtora = new System.Windows.Forms.Button();
            this.btnIgraTreta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose your game:";
            // 
            // btnIgraPrva
            // 
            this.btnIgraPrva.Enabled = false;
            this.btnIgraPrva.Location = new System.Drawing.Point(50, 163);
            this.btnIgraPrva.Name = "btnIgraPrva";
            this.btnIgraPrva.Size = new System.Drawing.Size(110, 35);
            this.btnIgraPrva.TabIndex = 3;
            this.btnIgraPrva.Text = "Press Reaction";
            this.btnIgraPrva.UseVisualStyleBackColor = true;
            this.btnIgraPrva.Click += new System.EventHandler(this.btnIgraPrva_Click);
            // 
            // btnIgraVtora
            // 
            this.btnIgraVtora.Enabled = false;
            this.btnIgraVtora.Location = new System.Drawing.Point(188, 163);
            this.btnIgraVtora.Name = "btnIgraVtora";
            this.btnIgraVtora.Size = new System.Drawing.Size(110, 35);
            this.btnIgraVtora.TabIndex = 4;
            this.btnIgraVtora.Text = "Fast Aiming";
            this.btnIgraVtora.UseVisualStyleBackColor = true;
            this.btnIgraVtora.Click += new System.EventHandler(this.btnIgraVtora_Click);
            // 
            // btnIgraTreta
            // 
            this.btnIgraTreta.Enabled = false;
            this.btnIgraTreta.Location = new System.Drawing.Point(321, 163);
            this.btnIgraTreta.Name = "btnIgraTreta";
            this.btnIgraTreta.Size = new System.Drawing.Size(110, 35);
            this.btnIgraTreta.TabIndex = 5;
            this.btnIgraTreta.Text = "Exact Aiming";
            this.btnIgraTreta.UseVisualStyleBackColor = true;
            this.btnIgraTreta.Click += new System.EventHandler(this.btnIgraTreta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.btnIgraTreta);
            this.Controls.Add(this.btnIgraVtora);
            this.Controls.Add(this.btnIgraPrva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ReflexTraining Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIgraPrva;
        private System.Windows.Forms.Button btnIgraVtora;
        private System.Windows.Forms.Button btnIgraTreta;
    }
}

