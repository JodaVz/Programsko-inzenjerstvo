namespace Server
{
    partial class Forma_Servera
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
            this.porukaPrimljena = new System.Windows.Forms.TextBox();
            this.unosSlusajPotvrda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // porukaPrimljena
            // 
            this.porukaPrimljena.Location = new System.Drawing.Point(12, 36);
            this.porukaPrimljena.Multiline = true;
            this.porukaPrimljena.Name = "porukaPrimljena";
            this.porukaPrimljena.Size = new System.Drawing.Size(313, 267);
            this.porukaPrimljena.TabIndex = 0;
            // 
            // unosSlusajPotvrda
            // 
            this.unosSlusajPotvrda.Location = new System.Drawing.Point(12, 7);
            this.unosSlusajPotvrda.Name = "unosSlusajPotvrda";
            this.unosSlusajPotvrda.Size = new System.Drawing.Size(140, 23);
            this.unosSlusajPotvrda.TabIndex = 1;
            this.unosSlusajPotvrda.Text = "Pocni Slusati";
            this.unosSlusajPotvrda.UseVisualStyleBackColor = true;
            this.unosSlusajPotvrda.Click += new System.EventHandler(this.unosSlusajPotvrda_Click);
            // 
            // Forma_Servera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 316);
            this.Controls.Add(this.unosSlusajPotvrda);
            this.Controls.Add(this.porukaPrimljena);
            this.Name = "Forma_Servera";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox porukaPrimljena;
        private System.Windows.Forms.Button unosSlusajPotvrda;
    }
}

