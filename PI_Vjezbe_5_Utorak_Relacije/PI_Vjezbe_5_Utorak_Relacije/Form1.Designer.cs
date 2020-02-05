namespace PI_Vjezbe_5_Utorak_Relacije
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
            this.popisAuta = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unosAutoIme = new System.Windows.Forms.TextBox();
            this.unosAutoBrzina = new System.Windows.Forms.TextBox();
            this.unosAutoPotvrda = new System.Windows.Forms.Button();
            this.popisRelacija = new System.Windows.Forms.ListBox();
            this.unosRelacijeIme = new System.Windows.Forms.TextBox();
            this.unosRelacijeX = new System.Windows.Forms.TextBox();
            this.unosRelacijeY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.unosRelacijaPotvrda = new System.Windows.Forms.Button();
            this.testPrva = new System.Windows.Forms.TextBox();
            this.testDruga = new System.Windows.Forms.TextBox();
            this.odabirPrva = new System.Windows.Forms.Button();
            this.odabirDruga = new System.Windows.Forms.Button();
            this.ispisRelacijaUdaljenost = new System.Windows.Forms.TextBox();
            this.odabirAutomobila = new System.Windows.Forms.Button();
            this.ispisRezultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // popisAuta
            // 
            this.popisAuta.FormattingEnabled = true;
            this.popisAuta.Location = new System.Drawing.Point(12, 12);
            this.popisAuta.Name = "popisAuta";
            this.popisAuta.Size = new System.Drawing.Size(166, 173);
            this.popisAuta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vrsta auta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Brzina auta";
            // 
            // unosAutoIme
            // 
            this.unosAutoIme.Location = new System.Drawing.Point(16, 220);
            this.unosAutoIme.Name = "unosAutoIme";
            this.unosAutoIme.Size = new System.Drawing.Size(100, 20);
            this.unosAutoIme.TabIndex = 3;
            // 
            // unosAutoBrzina
            // 
            this.unosAutoBrzina.Location = new System.Drawing.Point(134, 220);
            this.unosAutoBrzina.Name = "unosAutoBrzina";
            this.unosAutoBrzina.Size = new System.Drawing.Size(57, 20);
            this.unosAutoBrzina.TabIndex = 4;
            // 
            // unosAutoPotvrda
            // 
            this.unosAutoPotvrda.Location = new System.Drawing.Point(16, 246);
            this.unosAutoPotvrda.Name = "unosAutoPotvrda";
            this.unosAutoPotvrda.Size = new System.Drawing.Size(75, 23);
            this.unosAutoPotvrda.TabIndex = 5;
            this.unosAutoPotvrda.Text = "Dodaj auto";
            this.unosAutoPotvrda.UseVisualStyleBackColor = true;
            this.unosAutoPotvrda.Click += new System.EventHandler(this.unosAutoPotvrda_Click);
            // 
            // popisRelacija
            // 
            this.popisRelacija.FormattingEnabled = true;
            this.popisRelacija.Location = new System.Drawing.Point(244, 10);
            this.popisRelacija.Name = "popisRelacija";
            this.popisRelacija.Size = new System.Drawing.Size(150, 173);
            this.popisRelacija.TabIndex = 6;
            // 
            // unosRelacijeIme
            // 
            this.unosRelacijeIme.Location = new System.Drawing.Point(244, 219);
            this.unosRelacijeIme.Name = "unosRelacijeIme";
            this.unosRelacijeIme.Size = new System.Drawing.Size(100, 20);
            this.unosRelacijeIme.TabIndex = 7;
            // 
            // unosRelacijeX
            // 
            this.unosRelacijeX.Location = new System.Drawing.Point(351, 219);
            this.unosRelacijeX.Name = "unosRelacijeX";
            this.unosRelacijeX.Size = new System.Drawing.Size(100, 20);
            this.unosRelacijeX.TabIndex = 8;
            // 
            // unosRelacijeY
            // 
            this.unosRelacijeY.Location = new System.Drawing.Point(458, 219);
            this.unosRelacijeY.Name = "unosRelacijeY";
            this.unosRelacijeY.Size = new System.Drawing.Size(100, 20);
            this.unosRelacijeY.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lokacija";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "X koordinata";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Y koordinata";
            // 
            // unosRelacijaPotvrda
            // 
            this.unosRelacijaPotvrda.Location = new System.Drawing.Point(247, 245);
            this.unosRelacijaPotvrda.Name = "unosRelacijaPotvrda";
            this.unosRelacijaPotvrda.Size = new System.Drawing.Size(97, 23);
            this.unosRelacijaPotvrda.TabIndex = 13;
            this.unosRelacijaPotvrda.Text = "Dodaj relaciju";
            this.unosRelacijaPotvrda.UseVisualStyleBackColor = true;
            this.unosRelacijaPotvrda.Click += new System.EventHandler(this.unosRelacijaPotvrda_Click);
            // 
            // testPrva
            // 
            this.testPrva.Location = new System.Drawing.Point(401, 13);
            this.testPrva.Name = "testPrva";
            this.testPrva.Size = new System.Drawing.Size(100, 20);
            this.testPrva.TabIndex = 14;
            // 
            // testDruga
            // 
            this.testDruga.Location = new System.Drawing.Point(401, 40);
            this.testDruga.Name = "testDruga";
            this.testDruga.Size = new System.Drawing.Size(100, 20);
            this.testDruga.TabIndex = 15;
            // 
            // odabirPrva
            // 
            this.odabirPrva.Location = new System.Drawing.Point(530, 9);
            this.odabirPrva.Name = "odabirPrva";
            this.odabirPrva.Size = new System.Drawing.Size(143, 23);
            this.odabirPrva.TabIndex = 16;
            this.odabirPrva.Text = "Potvrda prve relacije";
            this.odabirPrva.UseVisualStyleBackColor = true;
            this.odabirPrva.Click += new System.EventHandler(this.odabirPrva_Click);
            // 
            // odabirDruga
            // 
            this.odabirDruga.Location = new System.Drawing.Point(530, 39);
            this.odabirDruga.Name = "odabirDruga";
            this.odabirDruga.Size = new System.Drawing.Size(143, 23);
            this.odabirDruga.TabIndex = 17;
            this.odabirDruga.Text = "Potvrda druge relacije";
            this.odabirDruga.UseVisualStyleBackColor = true;
            this.odabirDruga.Click += new System.EventHandler(this.odabirDruga_Click);
            // 
            // ispisRelacijaUdaljenost
            // 
            this.ispisRelacijaUdaljenost.Location = new System.Drawing.Point(401, 86);
            this.ispisRelacijaUdaljenost.Name = "ispisRelacijaUdaljenost";
            this.ispisRelacijaUdaljenost.Size = new System.Drawing.Size(272, 20);
            this.ispisRelacijaUdaljenost.TabIndex = 18;
            // 
            // odabirAutomobila
            // 
            this.odabirAutomobila.Location = new System.Drawing.Point(401, 113);
            this.odabirAutomobila.Name = "odabirAutomobila";
            this.odabirAutomobila.Size = new System.Drawing.Size(100, 23);
            this.odabirAutomobila.TabIndex = 19;
            this.odabirAutomobila.Text = "Odaberi autic";
            this.odabirAutomobila.UseVisualStyleBackColor = true;
            this.odabirAutomobila.Click += new System.EventHandler(this.odabirAutomobila_Click);
            // 
            // ispisRezultat
            // 
            this.ispisRezultat.Location = new System.Drawing.Point(401, 143);
            this.ispisRezultat.Name = "ispisRezultat";
            this.ispisRezultat.Size = new System.Drawing.Size(359, 20);
            this.ispisRezultat.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 568);
            this.Controls.Add(this.ispisRezultat);
            this.Controls.Add(this.odabirAutomobila);
            this.Controls.Add(this.ispisRelacijaUdaljenost);
            this.Controls.Add(this.odabirDruga);
            this.Controls.Add(this.odabirPrva);
            this.Controls.Add(this.testDruga);
            this.Controls.Add(this.testPrva);
            this.Controls.Add(this.unosRelacijaPotvrda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.unosRelacijeY);
            this.Controls.Add(this.unosRelacijeX);
            this.Controls.Add(this.unosRelacijeIme);
            this.Controls.Add(this.popisRelacija);
            this.Controls.Add(this.unosAutoPotvrda);
            this.Controls.Add(this.unosAutoBrzina);
            this.Controls.Add(this.unosAutoIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.popisAuta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox popisAuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox unosAutoIme;
        private System.Windows.Forms.TextBox unosAutoBrzina;
        private System.Windows.Forms.Button unosAutoPotvrda;
        private System.Windows.Forms.ListBox popisRelacija;
        private System.Windows.Forms.TextBox unosRelacijeIme;
        private System.Windows.Forms.TextBox unosRelacijeX;
        private System.Windows.Forms.TextBox unosRelacijeY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button unosRelacijaPotvrda;
        private System.Windows.Forms.TextBox testPrva;
        private System.Windows.Forms.TextBox testDruga;
        private System.Windows.Forms.Button odabirPrva;
        private System.Windows.Forms.Button odabirDruga;
        private System.Windows.Forms.TextBox ispisRelacijaUdaljenost;
        private System.Windows.Forms.Button odabirAutomobila;
        private System.Windows.Forms.TextBox ispisRezultat;
    }
}

