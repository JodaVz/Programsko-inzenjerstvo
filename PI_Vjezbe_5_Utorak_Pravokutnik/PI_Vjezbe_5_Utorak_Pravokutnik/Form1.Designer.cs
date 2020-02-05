namespace PI_Vjezbe_5_Utorak_Pravokutnik
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
            this.popisPravokutnika = new System.Windows.Forms.ListBox();
            this.unosPravokutnikVisina = new System.Windows.Forms.TextBox();
            this.unosPravokutnikSirina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unosPravokutnikPotvrda = new System.Windows.Forms.Button();
            this.odabirOperacije = new System.Windows.Forms.ComboBox();
            this.ispisRezultat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.unosRacunaj = new System.Windows.Forms.Button();
            this.pomocnitest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // popisPravokutnika
            // 
            this.popisPravokutnika.FormattingEnabled = true;
            this.popisPravokutnika.Location = new System.Drawing.Point(12, 12);
            this.popisPravokutnika.Name = "popisPravokutnika";
            this.popisPravokutnika.Size = new System.Drawing.Size(147, 134);
            this.popisPravokutnika.TabIndex = 0;
            // 
            // unosPravokutnikVisina
            // 
            this.unosPravokutnikVisina.Location = new System.Drawing.Point(13, 179);
            this.unosPravokutnikVisina.Name = "unosPravokutnikVisina";
            this.unosPravokutnikVisina.Size = new System.Drawing.Size(100, 20);
            this.unosPravokutnikVisina.TabIndex = 1;
            // 
            // unosPravokutnikSirina
            // 
            this.unosPravokutnikSirina.Location = new System.Drawing.Point(120, 178);
            this.unosPravokutnikSirina.Name = "unosPravokutnikSirina";
            this.unosPravokutnikSirina.Size = new System.Drawing.Size(100, 20);
            this.unosPravokutnikSirina.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Visina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sirina";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // unosPravokutnikPotvrda
            // 
            this.unosPravokutnikPotvrda.Location = new System.Drawing.Point(227, 175);
            this.unosPravokutnikPotvrda.Name = "unosPravokutnikPotvrda";
            this.unosPravokutnikPotvrda.Size = new System.Drawing.Size(75, 23);
            this.unosPravokutnikPotvrda.TabIndex = 5;
            this.unosPravokutnikPotvrda.Text = "Dodaj pravokutnik";
            this.unosPravokutnikPotvrda.UseVisualStyleBackColor = true;
            this.unosPravokutnikPotvrda.Click += new System.EventHandler(this.unosPravokutnikPotvrda_Click);
            // 
            // odabirOperacije
            // 
            this.odabirOperacije.FormattingEnabled = true;
            this.odabirOperacije.Location = new System.Drawing.Point(180, 12);
            this.odabirOperacije.Name = "odabirOperacije";
            this.odabirOperacije.Size = new System.Drawing.Size(158, 21);
            this.odabirOperacije.TabIndex = 6;
            // 
            // ispisRezultat
            // 
            this.ispisRezultat.Location = new System.Drawing.Point(180, 125);
            this.ispisRezultat.Name = "ispisRezultat";
            this.ispisRezultat.Size = new System.Drawing.Size(100, 20);
            this.ispisRezultat.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rezultat operacije";
            // 
            // unosRacunaj
            // 
            this.unosRacunaj.Location = new System.Drawing.Point(287, 121);
            this.unosRacunaj.Name = "unosRacunaj";
            this.unosRacunaj.Size = new System.Drawing.Size(75, 23);
            this.unosRacunaj.TabIndex = 9;
            this.unosRacunaj.Text = "Racunaj";
            this.unosRacunaj.UseVisualStyleBackColor = true;
            this.unosRacunaj.Click += new System.EventHandler(this.unosRacunaj_Click);
            // 
            // pomocnitest
            // 
            this.pomocnitest.Location = new System.Drawing.Point(180, 304);
            this.pomocnitest.Name = "pomocnitest";
            this.pomocnitest.Size = new System.Drawing.Size(100, 20);
            this.pomocnitest.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pomocni ispis za kontrolu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 487);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pomocnitest);
            this.Controls.Add(this.unosRacunaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ispisRezultat);
            this.Controls.Add(this.odabirOperacije);
            this.Controls.Add(this.unosPravokutnikPotvrda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unosPravokutnikSirina);
            this.Controls.Add(this.unosPravokutnikVisina);
            this.Controls.Add(this.popisPravokutnika);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox popisPravokutnika;
        private System.Windows.Forms.TextBox unosPravokutnikVisina;
        private System.Windows.Forms.TextBox unosPravokutnikSirina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button unosPravokutnikPotvrda;
        private System.Windows.Forms.ComboBox odabirOperacije;
        private System.Windows.Forms.TextBox ispisRezultat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button unosRacunaj;
        private System.Windows.Forms.TextBox pomocnitest;
        private System.Windows.Forms.Label label4;
    }
}

