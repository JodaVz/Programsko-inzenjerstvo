namespace PI_Vjezbe_7_Vjezbaaa
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
            this.components = new System.ComponentModel.Container();
            this.brojac = new System.Windows.Forms.Timer(this.components);
            this.unosTeksta = new System.Windows.Forms.TextBox();
            this.unosTekstaPotvrda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brojac
            // 
            this.brojac.Enabled = true;
            this.brojac.Interval = 500;
            this.brojac.Tick += new System.EventHandler(this.brojac_Tick);
            // 
            // unosTeksta
            // 
            this.unosTeksta.Location = new System.Drawing.Point(38, 63);
            this.unosTeksta.Name = "unosTeksta";
            this.unosTeksta.Size = new System.Drawing.Size(100, 20);
            this.unosTeksta.TabIndex = 0;
            // 
            // unosTekstaPotvrda
            // 
            this.unosTekstaPotvrda.Location = new System.Drawing.Point(166, 59);
            this.unosTekstaPotvrda.Name = "unosTekstaPotvrda";
            this.unosTekstaPotvrda.Size = new System.Drawing.Size(75, 23);
            this.unosTekstaPotvrda.TabIndex = 1;
            this.unosTekstaPotvrda.Text = "Unesi tekst";
            this.unosTekstaPotvrda.UseVisualStyleBackColor = true;
            this.unosTekstaPotvrda.Click += new System.EventHandler(this.unosTekstaPotvrda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 541);
            this.Controls.Add(this.unosTekstaPotvrda);
            this.Controls.Add(this.unosTeksta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer brojac;
        private System.Windows.Forms.TextBox unosTeksta;
        private System.Windows.Forms.Button unosTekstaPotvrda;
    }
}

