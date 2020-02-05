namespace PI_Vjezba_1_1Wf
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
            this.prviBrojUnos = new System.Windows.Forms.TextBox();
            this.prviBroj = new System.Windows.Forms.Label();
            this.drugiBroj = new System.Windows.Forms.Label();
            this.rezultat = new System.Windows.Forms.Label();
            this.drugiBrojUnos = new System.Windows.Forms.TextBox();
            this.rezultatIspis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // prviBrojUnos
            // 
            this.prviBrojUnos.Location = new System.Drawing.Point(413, 165);
            this.prviBrojUnos.Name = "prviBrojUnos";
            this.prviBrojUnos.Size = new System.Drawing.Size(100, 20);
            this.prviBrojUnos.TabIndex = 0;
            this.prviBrojUnos.TextChanged += new System.EventHandler(this.prviBrojUnos_TextChanged);
            // 
            // prviBroj
            // 
            this.prviBroj.AutoSize = true;
            this.prviBroj.Location = new System.Drawing.Point(410, 149);
            this.prviBroj.Name = "prviBroj";
            this.prviBroj.Size = new System.Drawing.Size(46, 13);
            this.prviBroj.TabIndex = 1;
            this.prviBroj.Text = "Prvi Broj";
            this.prviBroj.Click += new System.EventHandler(this.label1_Click);
            // 
            // drugiBroj
            // 
            this.drugiBroj.AutoSize = true;
            this.drugiBroj.Location = new System.Drawing.Point(621, 148);
            this.drugiBroj.Name = "drugiBroj";
            this.drugiBroj.Size = new System.Drawing.Size(53, 13);
            this.drugiBroj.TabIndex = 2;
            this.drugiBroj.Text = "Drugi Broj";
            // 
            // rezultat
            // 
            this.rezultat.AutoSize = true;
            this.rezultat.Location = new System.Drawing.Point(820, 149);
            this.rezultat.Name = "rezultat";
            this.rezultat.Size = new System.Drawing.Size(41, 13);
            this.rezultat.TabIndex = 3;
            this.rezultat.Text = "rezultat";
            // 
            // drugiBrojUnos
            // 
            this.drugiBrojUnos.Location = new System.Drawing.Point(624, 164);
            this.drugiBrojUnos.Name = "drugiBrojUnos";
            this.drugiBrojUnos.Size = new System.Drawing.Size(100, 20);
            this.drugiBrojUnos.TabIndex = 4;
            this.drugiBrojUnos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rezultatIspis
            // 
            this.rezultatIspis.Location = new System.Drawing.Point(823, 165);
            this.rezultatIspis.Name = "rezultatIspis";
            this.rezultatIspis.Size = new System.Drawing.Size(100, 20);
            this.rezultatIspis.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 739);
            this.Controls.Add(this.rezultatIspis);
            this.Controls.Add(this.drugiBrojUnos);
            this.Controls.Add(this.rezultat);
            this.Controls.Add(this.drugiBroj);
            this.Controls.Add(this.prviBroj);
            this.Controls.Add(this.prviBrojUnos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prviBrojUnos;
        private System.Windows.Forms.Label prviBroj;
        private System.Windows.Forms.Label drugiBroj;
        private System.Windows.Forms.Label rezultat;
        private System.Windows.Forms.TextBox drugiBrojUnos;
        private System.Windows.Forms.TextBox rezultatIspis;
    }
}

