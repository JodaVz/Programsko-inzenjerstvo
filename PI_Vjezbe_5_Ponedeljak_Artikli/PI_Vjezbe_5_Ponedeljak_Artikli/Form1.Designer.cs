namespace PI_Vjezbe_5_Ponedeljak_Artikli
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
            this.popisArtikala = new System.Windows.Forms.ListBox();
            this.unosArtiklNaziv = new System.Windows.Forms.TextBox();
            this.unosArtiklCijena = new System.Windows.Forms.TextBox();
            this.UnosArtiklKolicina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.unosArtiklPotvrda = new System.Windows.Forms.Button();
            this.unosRacun = new System.Windows.Forms.ListBox();
            this.unosRacunPotvrda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // popisArtikala
            // 
            this.popisArtikala.FormattingEnabled = true;
            this.popisArtikala.Location = new System.Drawing.Point(12, 12);
            this.popisArtikala.Name = "popisArtikala";
            this.popisArtikala.Size = new System.Drawing.Size(136, 160);
            this.popisArtikala.TabIndex = 0;
            // 
            // unosArtiklNaziv
            // 
            this.unosArtiklNaziv.Location = new System.Drawing.Point(47, 293);
            this.unosArtiklNaziv.Name = "unosArtiklNaziv";
            this.unosArtiklNaziv.Size = new System.Drawing.Size(100, 20);
            this.unosArtiklNaziv.TabIndex = 1;
            // 
            // unosArtiklCijena
            // 
            this.unosArtiklCijena.Location = new System.Drawing.Point(47, 320);
            this.unosArtiklCijena.Name = "unosArtiklCijena";
            this.unosArtiklCijena.Size = new System.Drawing.Size(100, 20);
            this.unosArtiklCijena.TabIndex = 2;
            // 
            // UnosArtiklKolicina
            // 
            this.UnosArtiklKolicina.Location = new System.Drawing.Point(47, 347);
            this.UnosArtiklKolicina.Name = "UnosArtiklKolicina";
            this.UnosArtiklKolicina.Size = new System.Drawing.Size(100, 20);
            this.UnosArtiklKolicina.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kolicina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cijena";
            // 
            // unosArtiklPotvrda
            // 
            this.unosArtiklPotvrda.Location = new System.Drawing.Point(170, 343);
            this.unosArtiklPotvrda.Name = "unosArtiklPotvrda";
            this.unosArtiklPotvrda.Size = new System.Drawing.Size(75, 23);
            this.unosArtiklPotvrda.TabIndex = 7;
            this.unosArtiklPotvrda.Text = "Unesi";
            this.unosArtiklPotvrda.UseVisualStyleBackColor = true;
            this.unosArtiklPotvrda.Click += new System.EventHandler(this.unosArtiklPotvrda_Click);
            // 
            // unosRacun
            // 
            this.unosRacun.FormattingEnabled = true;
            this.unosRacun.Location = new System.Drawing.Point(362, 10);
            this.unosRacun.Name = "unosRacun";
            this.unosRacun.Size = new System.Drawing.Size(141, 160);
            this.unosRacun.TabIndex = 8;
            // 
            // unosRacunPotvrda
            // 
            this.unosRacunPotvrda.Location = new System.Drawing.Point(362, 177);
            this.unosRacunPotvrda.Name = "unosRacunPotvrda";
            this.unosRacunPotvrda.Size = new System.Drawing.Size(141, 23);
            this.unosRacunPotvrda.TabIndex = 9;
            this.unosRacunPotvrda.Text = "Dodaj na racun";
            this.unosRacunPotvrda.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 564);
            this.Controls.Add(this.unosRacunPotvrda);
            this.Controls.Add(this.unosRacun);
            this.Controls.Add(this.unosArtiklPotvrda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UnosArtiklKolicina);
            this.Controls.Add(this.unosArtiklCijena);
            this.Controls.Add(this.unosArtiklNaziv);
            this.Controls.Add(this.popisArtikala);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox popisArtikala;
        private System.Windows.Forms.TextBox unosArtiklNaziv;
        private System.Windows.Forms.TextBox unosArtiklCijena;
        private System.Windows.Forms.TextBox UnosArtiklKolicina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button unosArtiklPotvrda;
        private System.Windows.Forms.ListBox unosRacun;
        private System.Windows.Forms.Button unosRacunPotvrda;
    }
}

