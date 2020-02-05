namespace PI_Vjezbe_4_Utorak_Rijeci
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
            this.unosRecenice = new System.Windows.Forms.TextBox();
            this.ispisObratna = new System.Windows.Forms.TextBox();
            this.ispisSlova = new System.Windows.Forms.TextBox();
            this.ispisRijeci = new System.Windows.Forms.TextBox();
            this.unosPretraga = new System.Windows.Forms.TextBox();
            this.gumbPotvrda = new System.Windows.Forms.Button();
            this.ispisPretraga = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // unosRecenice
            // 
            this.unosRecenice.Location = new System.Drawing.Point(162, 51);
            this.unosRecenice.Name = "unosRecenice";
            this.unosRecenice.Size = new System.Drawing.Size(256, 20);
            this.unosRecenice.TabIndex = 0;
            // 
            // ispisObratna
            // 
            this.ispisObratna.Location = new System.Drawing.Point(162, 78);
            this.ispisObratna.Name = "ispisObratna";
            this.ispisObratna.Size = new System.Drawing.Size(256, 20);
            this.ispisObratna.TabIndex = 1;
            // 
            // ispisSlova
            // 
            this.ispisSlova.Location = new System.Drawing.Point(48, 51);
            this.ispisSlova.Name = "ispisSlova";
            this.ispisSlova.Size = new System.Drawing.Size(100, 20);
            this.ispisSlova.TabIndex = 2;
            // 
            // ispisRijeci
            // 
            this.ispisRijeci.Location = new System.Drawing.Point(48, 78);
            this.ispisRijeci.Name = "ispisRijeci";
            this.ispisRijeci.Size = new System.Drawing.Size(100, 20);
            this.ispisRijeci.TabIndex = 3;
            // 
            // unosPretraga
            // 
            this.unosPretraga.Location = new System.Drawing.Point(162, 105);
            this.unosPretraga.Name = "unosPretraga";
            this.unosPretraga.Size = new System.Drawing.Size(100, 20);
            this.unosPretraga.TabIndex = 4;
            // 
            // gumbPotvrda
            // 
            this.gumbPotvrda.Location = new System.Drawing.Point(269, 101);
            this.gumbPotvrda.Name = "gumbPotvrda";
            this.gumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.gumbPotvrda.TabIndex = 5;
            this.gumbPotvrda.Text = "Klikni me!";
            this.gumbPotvrda.UseVisualStyleBackColor = true;
            this.gumbPotvrda.Click += new System.EventHandler(this.gumbPotvrda_Click);
            // 
            // ispisPretraga
            // 
            this.ispisPretraga.Location = new System.Drawing.Point(162, 132);
            this.ispisPretraga.Name = "ispisPretraga";
            this.ispisPretraga.Size = new System.Drawing.Size(100, 20);
            this.ispisPretraga.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 410);
            this.Controls.Add(this.ispisPretraga);
            this.Controls.Add(this.gumbPotvrda);
            this.Controls.Add(this.unosPretraga);
            this.Controls.Add(this.ispisRijeci);
            this.Controls.Add(this.ispisSlova);
            this.Controls.Add(this.ispisObratna);
            this.Controls.Add(this.unosRecenice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox unosRecenice;
        private System.Windows.Forms.TextBox ispisObratna;
        private System.Windows.Forms.TextBox ispisSlova;
        private System.Windows.Forms.TextBox ispisRijeci;
        private System.Windows.Forms.TextBox unosPretraga;
        private System.Windows.Forms.Button gumbPotvrda;
        private System.Windows.Forms.TextBox ispisPretraga;
    }
}

