namespace PI_Vjezbe_4_2
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
            this.Potvrda = new System.Windows.Forms.Button();
            this.KategorijaHrana = new System.Windows.Forms.RadioButton();
            this.KategorijaZabava = new System.Windows.Forms.RadioButton();
            this.KategorijaZdravlje = new System.Windows.Forms.RadioButton();
            this.KategorijaEdukacija = new System.Windows.Forms.RadioButton();
            this.UpisCijena = new System.Windows.Forms.TextBox();
            this.IspisTrosak = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Potvrda
            // 
            this.Potvrda.Location = new System.Drawing.Point(295, 102);
            this.Potvrda.Name = "Potvrda";
            this.Potvrda.Size = new System.Drawing.Size(75, 23);
            this.Potvrda.TabIndex = 0;
            this.Potvrda.Text = "Klikni me!";
            this.Potvrda.UseVisualStyleBackColor = true;
            this.Potvrda.Click += new System.EventHandler(this.Potvrda_Click);
            // 
            // KategorijaHrana
            // 
            this.KategorijaHrana.AutoSize = true;
            this.KategorijaHrana.Location = new System.Drawing.Point(72, 102);
            this.KategorijaHrana.Name = "KategorijaHrana";
            this.KategorijaHrana.Size = new System.Drawing.Size(54, 17);
            this.KategorijaHrana.TabIndex = 1;
            this.KategorijaHrana.TabStop = true;
            this.KategorijaHrana.Text = "Hrana";
            this.KategorijaHrana.UseVisualStyleBackColor = true;
            this.KategorijaHrana.CheckedChanged += new System.EventHandler(this.KategorijaHrana_CheckedChanged);
            // 
            // KategorijaZabava
            // 
            this.KategorijaZabava.AutoSize = true;
            this.KategorijaZabava.Location = new System.Drawing.Point(72, 126);
            this.KategorijaZabava.Name = "KategorijaZabava";
            this.KategorijaZabava.Size = new System.Drawing.Size(62, 17);
            this.KategorijaZabava.TabIndex = 2;
            this.KategorijaZabava.TabStop = true;
            this.KategorijaZabava.Text = "Zabava";
            this.KategorijaZabava.UseVisualStyleBackColor = true;
            this.KategorijaZabava.CheckedChanged += new System.EventHandler(this.KategorijaZabava_CheckedChanged);
            // 
            // KategorijaZdravlje
            // 
            this.KategorijaZdravlje.AutoSize = true;
            this.KategorijaZdravlje.Location = new System.Drawing.Point(72, 150);
            this.KategorijaZdravlje.Name = "KategorijaZdravlje";
            this.KategorijaZdravlje.Size = new System.Drawing.Size(63, 17);
            this.KategorijaZdravlje.TabIndex = 3;
            this.KategorijaZdravlje.TabStop = true;
            this.KategorijaZdravlje.Text = "Zdravlje";
            this.KategorijaZdravlje.UseVisualStyleBackColor = true;
            this.KategorijaZdravlje.CheckedChanged += new System.EventHandler(this.KategorijaZdravlje_CheckedChanged);
            // 
            // KategorijaEdukacija
            // 
            this.KategorijaEdukacija.AutoSize = true;
            this.KategorijaEdukacija.Location = new System.Drawing.Point(72, 174);
            this.KategorijaEdukacija.Name = "KategorijaEdukacija";
            this.KategorijaEdukacija.Size = new System.Drawing.Size(72, 17);
            this.KategorijaEdukacija.TabIndex = 4;
            this.KategorijaEdukacija.TabStop = true;
            this.KategorijaEdukacija.Text = "Edukacija";
            this.KategorijaEdukacija.UseVisualStyleBackColor = true;
            this.KategorijaEdukacija.CheckedChanged += new System.EventHandler(this.KategorijaEdukacija_CheckedChanged);
            // 
            // UpisCijena
            // 
            this.UpisCijena.Location = new System.Drawing.Point(169, 102);
            this.UpisCijena.Name = "UpisCijena";
            this.UpisCijena.Size = new System.Drawing.Size(100, 20);
            this.UpisCijena.TabIndex = 5;
            // 
            // IspisTrosak
            // 
            this.IspisTrosak.Location = new System.Drawing.Point(169, 150);
            this.IspisTrosak.Multiline = true;
            this.IspisTrosak.Name = "IspisTrosak";
            this.IspisTrosak.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.IspisTrosak.Size = new System.Drawing.Size(93, 233);
            this.IspisTrosak.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 529);
            this.Controls.Add(this.IspisTrosak);
            this.Controls.Add(this.UpisCijena);
            this.Controls.Add(this.KategorijaEdukacija);
            this.Controls.Add(this.KategorijaZdravlje);
            this.Controls.Add(this.KategorijaZabava);
            this.Controls.Add(this.KategorijaHrana);
            this.Controls.Add(this.Potvrda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Potvrda;
        private System.Windows.Forms.RadioButton KategorijaHrana;
        private System.Windows.Forms.RadioButton KategorijaZabava;
        private System.Windows.Forms.RadioButton KategorijaZdravlje;
        private System.Windows.Forms.RadioButton KategorijaEdukacija;
        private System.Windows.Forms.TextBox UpisCijena;
        private System.Windows.Forms.TextBox IspisTrosak;
    }
}

