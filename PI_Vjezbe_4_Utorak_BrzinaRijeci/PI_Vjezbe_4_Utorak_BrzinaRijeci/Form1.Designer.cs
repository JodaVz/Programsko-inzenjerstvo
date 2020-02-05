namespace PI_Vjezbe_4_Utorak_BrzinaRijeci
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
            this.upisRecenice = new System.Windows.Forms.TextBox();
            this.upisProvjere = new System.Windows.Forms.TextBox();
            this.gumbPotvrda = new System.Windows.Forms.Button();
            this.ispisBrzina = new System.Windows.Forms.TextBox();
            this.ispisZnakovi = new System.Windows.Forms.TextBox();
            this.ispisUkupnoVrijeme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // upisRecenice
            // 
            this.upisRecenice.Location = new System.Drawing.Point(344, 100);
            this.upisRecenice.Name = "upisRecenice";
            this.upisRecenice.Size = new System.Drawing.Size(249, 20);
            this.upisRecenice.TabIndex = 0;
            this.upisRecenice.TextChanged += new System.EventHandler(this.upisRecenice_TextChanged);
            this.upisRecenice.Enter += new System.EventHandler(this.upisRecenice_Enter);
            this.upisRecenice.Leave += new System.EventHandler(this.upisRecenice_Leave);
            // 
            // upisProvjere
            // 
            this.upisProvjere.Location = new System.Drawing.Point(344, 142);
            this.upisProvjere.Name = "upisProvjere";
            this.upisProvjere.Size = new System.Drawing.Size(249, 20);
            this.upisProvjere.TabIndex = 1;
            this.upisProvjere.TextChanged += new System.EventHandler(this.upisProvjere_TextChanged);
            // 
            // gumbPotvrda
            // 
            this.gumbPotvrda.Location = new System.Drawing.Point(611, 96);
            this.gumbPotvrda.Name = "gumbPotvrda";
            this.gumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.gumbPotvrda.TabIndex = 2;
            this.gumbPotvrda.Text = "Kraj";
            this.gumbPotvrda.UseVisualStyleBackColor = true;
            this.gumbPotvrda.Click += new System.EventHandler(this.gumbPotvrda_Click);
            // 
            // ispisBrzina
            // 
            this.ispisBrzina.Location = new System.Drawing.Point(126, 88);
            this.ispisBrzina.Name = "ispisBrzina";
            this.ispisBrzina.Size = new System.Drawing.Size(100, 20);
            this.ispisBrzina.TabIndex = 3;
            // 
            // ispisZnakovi
            // 
            this.ispisZnakovi.Location = new System.Drawing.Point(126, 115);
            this.ispisZnakovi.Name = "ispisZnakovi";
            this.ispisZnakovi.Size = new System.Drawing.Size(100, 20);
            this.ispisZnakovi.TabIndex = 4;
            // 
            // ispisUkupnoVrijeme
            // 
            this.ispisUkupnoVrijeme.Location = new System.Drawing.Point(126, 142);
            this.ispisUkupnoVrijeme.Name = "ispisUkupnoVrijeme";
            this.ispisUkupnoVrijeme.Size = new System.Drawing.Size(100, 20);
            this.ispisUkupnoVrijeme.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Brzina tipkanja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vrijeme upisa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ukupno vrijeme";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 485);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ispisUkupnoVrijeme);
            this.Controls.Add(this.ispisZnakovi);
            this.Controls.Add(this.ispisBrzina);
            this.Controls.Add(this.gumbPotvrda);
            this.Controls.Add(this.upisProvjere);
            this.Controls.Add(this.upisRecenice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox upisRecenice;
        private System.Windows.Forms.TextBox upisProvjere;
        private System.Windows.Forms.Button gumbPotvrda;
        private System.Windows.Forms.TextBox ispisBrzina;
        private System.Windows.Forms.TextBox ispisZnakovi;
        private System.Windows.Forms.TextBox ispisUkupnoVrijeme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

