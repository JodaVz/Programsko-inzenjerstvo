namespace PI_Vjezbe_6_RandomPractive_MaloDretvice
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
            this.unosArtiklKolicina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.unosArtiklPotvrda = new System.Windows.Forms.Button();
            this.ispisArtiklOdabrani = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ispisOdabraniNaziv = new System.Windows.Forms.TextBox();
            this.unosNovaCijena = new System.Windows.Forms.TextBox();
            this.unosNovaKolicina = new System.Windows.Forms.TextBox();
            this.unosPromjenaPotvrdi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // popisArtikala
            // 
            this.popisArtikala.FormattingEnabled = true;
            this.popisArtikala.Location = new System.Drawing.Point(33, 50);
            this.popisArtikala.Name = "popisArtikala";
            this.popisArtikala.Size = new System.Drawing.Size(305, 420);
            this.popisArtikala.TabIndex = 0;
            this.popisArtikala.MouseDown += new System.Windows.Forms.MouseEventHandler(this.popisArtikala_MouseDown);
            // 
            // unosArtiklNaziv
            // 
            this.unosArtiklNaziv.Location = new System.Drawing.Point(33, 494);
            this.unosArtiklNaziv.Name = "unosArtiklNaziv";
            this.unosArtiklNaziv.Size = new System.Drawing.Size(100, 20);
            this.unosArtiklNaziv.TabIndex = 1;
            // 
            // unosArtiklCijena
            // 
            this.unosArtiklCijena.Location = new System.Drawing.Point(33, 521);
            this.unosArtiklCijena.Name = "unosArtiklCijena";
            this.unosArtiklCijena.Size = new System.Drawing.Size(100, 20);
            this.unosArtiklCijena.TabIndex = 2;
            // 
            // unosArtiklKolicina
            // 
            this.unosArtiklKolicina.Location = new System.Drawing.Point(33, 548);
            this.unosArtiklKolicina.Name = "unosArtiklKolicina";
            this.unosArtiklKolicina.Size = new System.Drawing.Size(100, 20);
            this.unosArtiklKolicina.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv Artikla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cijena Artikla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kolicina Artikla";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // unosArtiklPotvrda
            // 
            this.unosArtiklPotvrda.Location = new System.Drawing.Point(33, 574);
            this.unosArtiklPotvrda.Name = "unosArtiklPotvrda";
            this.unosArtiklPotvrda.Size = new System.Drawing.Size(75, 23);
            this.unosArtiklPotvrda.TabIndex = 7;
            this.unosArtiklPotvrda.Text = "Dodaj Artikl";
            this.unosArtiklPotvrda.UseVisualStyleBackColor = true;
            this.unosArtiklPotvrda.Click += new System.EventHandler(this.unosArtiklPotvrda_Click);
            // 
            // ispisArtiklOdabrani
            // 
            this.ispisArtiklOdabrani.Location = new System.Drawing.Point(434, 66);
            this.ispisArtiklOdabrani.Name = "ispisArtiklOdabrani";
            this.ispisArtiklOdabrani.Size = new System.Drawing.Size(214, 20);
            this.ispisArtiklOdabrani.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Provjera Odabranog";
            // 
            // ispisOdabraniNaziv
            // 
            this.ispisOdabraniNaziv.Location = new System.Drawing.Point(434, 130);
            this.ispisOdabraniNaziv.Name = "ispisOdabraniNaziv";
            this.ispisOdabraniNaziv.Size = new System.Drawing.Size(100, 20);
            this.ispisOdabraniNaziv.TabIndex = 10;
            // 
            // unosNovaCijena
            // 
            this.unosNovaCijena.Location = new System.Drawing.Point(434, 157);
            this.unosNovaCijena.Name = "unosNovaCijena";
            this.unosNovaCijena.Size = new System.Drawing.Size(100, 20);
            this.unosNovaCijena.TabIndex = 11;
            // 
            // unosNovaKolicina
            // 
            this.unosNovaKolicina.Location = new System.Drawing.Point(434, 184);
            this.unosNovaKolicina.Name = "unosNovaKolicina";
            this.unosNovaKolicina.Size = new System.Drawing.Size(100, 20);
            this.unosNovaKolicina.TabIndex = 12;
            // 
            // unosPromjenaPotvrdi
            // 
            this.unosPromjenaPotvrdi.Location = new System.Drawing.Point(434, 211);
            this.unosPromjenaPotvrdi.Name = "unosPromjenaPotvrdi";
            this.unosPromjenaPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.unosPromjenaPotvrdi.TabIndex = 13;
            this.unosPromjenaPotvrdi.Text = "Potvrdi Promjene";
            this.unosPromjenaPotvrdi.UseVisualStyleBackColor = true;
            this.unosPromjenaPotvrdi.Click += new System.EventHandler(this.unosPromjenaPotvrdi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(553, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Naziv";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nova cijena";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(553, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nova kolicina";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 644);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.unosPromjenaPotvrdi);
            this.Controls.Add(this.unosNovaKolicina);
            this.Controls.Add(this.unosNovaCijena);
            this.Controls.Add(this.ispisOdabraniNaziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ispisArtiklOdabrani);
            this.Controls.Add(this.unosArtiklPotvrda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unosArtiklKolicina);
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
        private System.Windows.Forms.TextBox unosArtiklKolicina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button unosArtiklPotvrda;
        private System.Windows.Forms.TextBox ispisArtiklOdabrani;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ispisOdabraniNaziv;
        private System.Windows.Forms.TextBox unosNovaCijena;
        private System.Windows.Forms.TextBox unosNovaKolicina;
        private System.Windows.Forms.Button unosPromjenaPotvrdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

