namespace PI_Vjezbe_4_Gudeki
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
            this.unosBojeCrna = new System.Windows.Forms.RadioButton();
            this.unosBojeSiva = new System.Windows.Forms.RadioButton();
            this.unosBojeRoza = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.unosSpolMuski = new System.Windows.Forms.RadioButton();
            this.unosSpolZenski = new System.Windows.Forms.RadioButton();
            this.upisSpolNedorecen = new System.Windows.Forms.RadioButton();
            this.unosPotvrda = new System.Windows.Forms.Button();
            this.ispisSvihGudeka = new System.Windows.Forms.ListBox();
            this.unosImeGudeka = new System.Windows.Forms.TextBox();
            this.filtarPoBoji = new System.Windows.Forms.Button();
            this.FiltarPoSpolu = new System.Windows.Forms.Button();
            this.ispisFiltrirano = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boje";
            // 
            // unosBojeCrna
            // 
            this.unosBojeCrna.AutoSize = true;
            this.unosBojeCrna.Location = new System.Drawing.Point(13, 43);
            this.unosBojeCrna.Name = "unosBojeCrna";
            this.unosBojeCrna.Size = new System.Drawing.Size(100, 21);
            this.unosBojeCrna.TabIndex = 1;
            this.unosBojeCrna.TabStop = true;
            this.unosBojeCrna.Text = "Crni Gudek";
            this.unosBojeCrna.UseVisualStyleBackColor = true;
            this.unosBojeCrna.CheckedChanged += new System.EventHandler(this.unosBojeCrna_CheckedChanged);
            // 
            // unosBojeSiva
            // 
            this.unosBojeSiva.AutoSize = true;
            this.unosBojeSiva.Location = new System.Drawing.Point(13, 71);
            this.unosBojeSiva.Name = "unosBojeSiva";
            this.unosBojeSiva.Size = new System.Drawing.Size(97, 21);
            this.unosBojeSiva.TabIndex = 2;
            this.unosBojeSiva.TabStop = true;
            this.unosBojeSiva.Text = "Sivi Gudek";
            this.unosBojeSiva.UseVisualStyleBackColor = true;
            this.unosBojeSiva.CheckedChanged += new System.EventHandler(this.unosBojeSiva_CheckedChanged);
            // 
            // unosBojeRoza
            // 
            this.unosBojeRoza.AutoSize = true;
            this.unosBojeRoza.Location = new System.Drawing.Point(13, 99);
            this.unosBojeRoza.Name = "unosBojeRoza";
            this.unosBojeRoza.Size = new System.Drawing.Size(103, 21);
            this.unosBojeRoza.TabIndex = 3;
            this.unosBojeRoza.TabStop = true;
            this.unosBojeRoza.Text = "Rozi Gudek";
            this.unosBojeRoza.UseVisualStyleBackColor = true;
            this.unosBojeRoza.CheckedChanged += new System.EventHandler(this.unosBojeRoza_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Spol";
            // 
            // unosSpolMuski
            // 
            this.unosSpolMuski.AutoSize = true;
            this.unosSpolMuski.Location = new System.Drawing.Point(3, 20);
            this.unosSpolMuski.Name = "unosSpolMuski";
            this.unosSpolMuski.Size = new System.Drawing.Size(111, 21);
            this.unosSpolMuski.TabIndex = 5;
            this.unosSpolMuski.TabStop = true;
            this.unosSpolMuski.Text = "Muški Gudek";
            this.unosSpolMuski.UseVisualStyleBackColor = true;
            this.unosSpolMuski.CheckedChanged += new System.EventHandler(this.unosSpolMuski_CheckedChanged);
            // 
            // unosSpolZenski
            // 
            this.unosSpolZenski.AutoSize = true;
            this.unosSpolZenski.Location = new System.Drawing.Point(3, 48);
            this.unosSpolZenski.Name = "unosSpolZenski";
            this.unosSpolZenski.Size = new System.Drawing.Size(140, 21);
            this.unosSpolZenski.TabIndex = 6;
            this.unosSpolZenski.TabStop = true;
            this.unosSpolZenski.Text = "Zenska Gudekica";
            this.unosSpolZenski.UseVisualStyleBackColor = true;
            this.unosSpolZenski.CheckedChanged += new System.EventHandler(this.unosSpolZenski_CheckedChanged);
            // 
            // upisSpolNedorecen
            // 
            this.upisSpolNedorecen.AutoSize = true;
            this.upisSpolNedorecen.Location = new System.Drawing.Point(3, 76);
            this.upisSpolNedorecen.Name = "upisSpolNedorecen";
            this.upisSpolNedorecen.Size = new System.Drawing.Size(130, 21);
            this.upisSpolNedorecen.TabIndex = 7;
            this.upisSpolNedorecen.TabStop = true;
            this.upisSpolNedorecen.Text = "Nedorečen Gud";
            this.upisSpolNedorecen.UseVisualStyleBackColor = true;
            this.upisSpolNedorecen.CheckedChanged += new System.EventHandler(this.upisSpolNedorecen_CheckedChanged);
            // 
            // unosPotvrda
            // 
            this.unosPotvrda.Location = new System.Drawing.Point(281, 125);
            this.unosPotvrda.Name = "unosPotvrda";
            this.unosPotvrda.Size = new System.Drawing.Size(75, 23);
            this.unosPotvrda.TabIndex = 8;
            this.unosPotvrda.Text = "Oink!";
            this.unosPotvrda.UseVisualStyleBackColor = true;
            this.unosPotvrda.Click += new System.EventHandler(this.unosPotvrda_Click);
            // 
            // ispisSvihGudeka
            // 
            this.ispisSvihGudeka.FormattingEnabled = true;
            this.ispisSvihGudeka.ItemHeight = 16;
            this.ispisSvihGudeka.Location = new System.Drawing.Point(16, 202);
            this.ispisSvihGudeka.Name = "ispisSvihGudeka";
            this.ispisSvihGudeka.Size = new System.Drawing.Size(235, 212);
            this.ispisSvihGudeka.TabIndex = 9;
            // 
            // unosImeGudeka
            // 
            this.unosImeGudeka.Location = new System.Drawing.Point(12, 126);
            this.unosImeGudeka.Name = "unosImeGudeka";
            this.unosImeGudeka.Size = new System.Drawing.Size(239, 22);
            this.unosImeGudeka.TabIndex = 10;
            // 
            // filtarPoBoji
            // 
            this.filtarPoBoji.Location = new System.Drawing.Point(258, 202);
            this.filtarPoBoji.Name = "filtarPoBoji";
            this.filtarPoBoji.Size = new System.Drawing.Size(141, 23);
            this.filtarPoBoji.TabIndex = 11;
            this.filtarPoBoji.Text = "Filtriraj boje";
            this.filtarPoBoji.UseVisualStyleBackColor = true;
            this.filtarPoBoji.Click += new System.EventHandler(this.filtarPoBoji_Click);
            // 
            // FiltarPoSpolu
            // 
            this.FiltarPoSpolu.Location = new System.Drawing.Point(258, 231);
            this.FiltarPoSpolu.Name = "FiltarPoSpolu";
            this.FiltarPoSpolu.Size = new System.Drawing.Size(141, 23);
            this.FiltarPoSpolu.TabIndex = 12;
            this.FiltarPoSpolu.Text = "Filtriraj spolove";
            this.FiltarPoSpolu.UseVisualStyleBackColor = true;
            this.FiltarPoSpolu.Click += new System.EventHandler(this.FiltarPoSpolu_Click);
            // 
            // ispisFiltrirano
            // 
            this.ispisFiltrirano.Location = new System.Drawing.Point(436, 202);
            this.ispisFiltrirano.Multiline = true;
            this.ispisFiltrirano.Name = "ispisFiltrirano";
            this.ispisFiltrirano.Size = new System.Drawing.Size(168, 191);
            this.ispisFiltrirano.TabIndex = 13;
            this.ispisFiltrirano.TextChanged += new System.EventHandler(this.ispisFiltrirano_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.upisSpolNedorecen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.unosSpolMuski);
            this.panel1.Controls.Add(this.unosSpolZenski);
            this.panel1.Location = new System.Drawing.Point(122, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ispisFiltrirano);
            this.Controls.Add(this.FiltarPoSpolu);
            this.Controls.Add(this.filtarPoBoji);
            this.Controls.Add(this.unosImeGudeka);
            this.Controls.Add(this.ispisSvihGudeka);
            this.Controls.Add(this.unosPotvrda);
            this.Controls.Add(this.unosBojeRoza);
            this.Controls.Add(this.unosBojeSiva);
            this.Controls.Add(this.unosBojeCrna);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton unosBojeCrna;
        private System.Windows.Forms.RadioButton unosBojeSiva;
        private System.Windows.Forms.RadioButton unosBojeRoza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton unosSpolMuski;
        private System.Windows.Forms.RadioButton unosSpolZenski;
        private System.Windows.Forms.RadioButton upisSpolNedorecen;
        private System.Windows.Forms.Button unosPotvrda;
        private System.Windows.Forms.ListBox ispisSvihGudeka;
        private System.Windows.Forms.TextBox unosImeGudeka;
        private System.Windows.Forms.Button filtarPoBoji;
        private System.Windows.Forms.Button FiltarPoSpolu;
        private System.Windows.Forms.TextBox ispisFiltrirano;
        private System.Windows.Forms.Panel panel1;
    }
}

