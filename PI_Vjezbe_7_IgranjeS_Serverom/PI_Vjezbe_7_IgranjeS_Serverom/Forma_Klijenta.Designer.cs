namespace PI_Vjezbe_7_IgranjeS_Serverom
{
    partial class Forma_Klijenta
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
            this.unosPoruka = new System.Windows.Forms.TextBox();
            this.posaljiPoruku = new System.Windows.Forms.Button();
            this.brojac = new System.Windows.Forms.Timer(this.components);
            this.unosHash = new System.Windows.Forms.TextBox();
            this.unosRecenice = new System.Windows.Forms.TextBox();
            this.unosHashPotvrda = new System.Windows.Forms.Button();
            this.unosRecenicePotvrda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unosPoruka
            // 
            this.unosPoruka.Location = new System.Drawing.Point(12, 12);
            this.unosPoruka.Name = "unosPoruka";
            this.unosPoruka.Size = new System.Drawing.Size(154, 20);
            this.unosPoruka.TabIndex = 3;
            // 
            // posaljiPoruku
            // 
            this.posaljiPoruku.Location = new System.Drawing.Point(172, 12);
            this.posaljiPoruku.Name = "posaljiPoruku";
            this.posaljiPoruku.Size = new System.Drawing.Size(102, 23);
            this.posaljiPoruku.TabIndex = 4;
            this.posaljiPoruku.Text = "Posalji poruku";
            this.posaljiPoruku.UseVisualStyleBackColor = true;
            this.posaljiPoruku.Click += new System.EventHandler(this.posaljiPoruku_Click);
            // 
            // brojac
            // 
            this.brojac.Enabled = true;
            this.brojac.Interval = 500;
            this.brojac.Tick += new System.EventHandler(this.brojac_Tick);
            // 
            // unosHash
            // 
            this.unosHash.Location = new System.Drawing.Point(13, 39);
            this.unosHash.Name = "unosHash";
            this.unosHash.Size = new System.Drawing.Size(153, 20);
            this.unosHash.TabIndex = 5;
            // 
            // unosRecenice
            // 
            this.unosRecenice.Location = new System.Drawing.Point(12, 66);
            this.unosRecenice.Name = "unosRecenice";
            this.unosRecenice.Size = new System.Drawing.Size(154, 20);
            this.unosRecenice.TabIndex = 6;
            // 
            // unosHashPotvrda
            // 
            this.unosHashPotvrda.Location = new System.Drawing.Point(172, 37);
            this.unosHashPotvrda.Name = "unosHashPotvrda";
            this.unosHashPotvrda.Size = new System.Drawing.Size(102, 23);
            this.unosHashPotvrda.TabIndex = 7;
            this.unosHashPotvrda.Text = "Posalji HASH";
            this.unosHashPotvrda.UseVisualStyleBackColor = true;
            this.unosHashPotvrda.Click += new System.EventHandler(this.unosHashPotvrda_Click);
            // 
            // unosRecenicePotvrda
            // 
            this.unosRecenicePotvrda.Location = new System.Drawing.Point(172, 62);
            this.unosRecenicePotvrda.Name = "unosRecenicePotvrda";
            this.unosRecenicePotvrda.Size = new System.Drawing.Size(102, 23);
            this.unosRecenicePotvrda.TabIndex = 8;
            this.unosRecenicePotvrda.Text = "Posalji Recenicu";
            this.unosRecenicePotvrda.UseVisualStyleBackColor = true;
            this.unosRecenicePotvrda.Click += new System.EventHandler(this.unosRecenicePotvrda_Click);
            // 
            // Forma_Klijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 108);
            this.Controls.Add(this.unosRecenicePotvrda);
            this.Controls.Add(this.unosHashPotvrda);
            this.Controls.Add(this.unosRecenice);
            this.Controls.Add(this.unosHash);
            this.Controls.Add(this.posaljiPoruku);
            this.Controls.Add(this.unosPoruka);
            this.Name = "Forma_Klijenta";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox unosPoruka;
        private System.Windows.Forms.Button posaljiPoruku;
        private System.Windows.Forms.Timer brojac;
        private System.Windows.Forms.TextBox unosHash;
        private System.Windows.Forms.TextBox unosRecenice;
        private System.Windows.Forms.Button unosHashPotvrda;
        private System.Windows.Forms.Button unosRecenicePotvrda;
    }
}

