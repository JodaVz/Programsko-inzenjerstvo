namespace DNA
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
            this.txtBazaUpis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnMutiraj = new System.Windows.Forms.Button();
            this.txtPrethodna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstListaBaza = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.txtTestRandom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBazaUpis
            // 
            this.txtBazaUpis.Location = new System.Drawing.Point(165, 231);
            this.txtBazaUpis.Name = "txtBazaUpis";
            this.txtBazaUpis.Size = new System.Drawing.Size(100, 20);
            this.txtBazaUpis.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Upiši bazu";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(300, 231);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 2;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnMutiraj
            // 
            this.btnMutiraj.Location = new System.Drawing.Point(300, 274);
            this.btnMutiraj.Name = "btnMutiraj";
            this.btnMutiraj.Size = new System.Drawing.Size(75, 23);
            this.btnMutiraj.TabIndex = 3;
            this.btnMutiraj.Text = "Mutiraj";
            this.btnMutiraj.UseVisualStyleBackColor = true;
            this.btnMutiraj.Click += new System.EventHandler(this.btnMutiraj_Click);
            // 
            // txtPrethodna
            // 
            this.txtPrethodna.Location = new System.Drawing.Point(300, 348);
            this.txtPrethodna.Name = "txtPrethodna";
            this.txtPrethodna.Size = new System.Drawing.Size(100, 20);
            this.txtPrethodna.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vrijednost prije mutacije";
            // 
            // lstListaBaza
            // 
            this.lstListaBaza.Location = new System.Drawing.Point(591, 210);
            this.lstListaBaza.Name = "lstListaBaza";
            this.lstListaBaza.Size = new System.Drawing.Size(83, 308);
            this.lstListaBaza.TabIndex = 6;
            this.lstListaBaza.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Popis baza";
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(164, 88);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(100, 20);
            this.txtTest.TabIndex = 8;
            // 
            // txtTestRandom
            // 
            this.txtTestRandom.Location = new System.Drawing.Point(129, 385);
            this.txtTestRandom.Name = "txtTestRandom";
            this.txtTestRandom.Size = new System.Drawing.Size(100, 20);
            this.txtTestRandom.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 671);
            this.Controls.Add(this.txtTestRandom);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstListaBaza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrethodna);
            this.Controls.Add(this.btnMutiraj);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBazaUpis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBazaUpis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnMutiraj;
        private System.Windows.Forms.TextBox txtPrethodna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstListaBaza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.TextBox txtTestRandom;
    }
}

