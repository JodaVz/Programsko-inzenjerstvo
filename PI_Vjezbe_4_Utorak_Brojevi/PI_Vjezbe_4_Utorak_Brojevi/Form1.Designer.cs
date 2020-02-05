namespace PI_Vjezbe_4_Utorak_Brojevi
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
            this.unosBroj = new System.Windows.Forms.TextBox();
            this.ispisNormalna = new System.Windows.Forms.TextBox();
            this.ispisSortirana = new System.Windows.Forms.TextBox();
            this.unosBroja = new System.Windows.Forms.Button();
            this.unosSortiraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unosBroj
            // 
            this.unosBroj.Location = new System.Drawing.Point(59, 37);
            this.unosBroj.Name = "unosBroj";
            this.unosBroj.Size = new System.Drawing.Size(100, 20);
            this.unosBroj.TabIndex = 0;
            // 
            // ispisNormalna
            // 
            this.ispisNormalna.Location = new System.Drawing.Point(21, 167);
            this.ispisNormalna.Multiline = true;
            this.ispisNormalna.Name = "ispisNormalna";
            this.ispisNormalna.Size = new System.Drawing.Size(100, 144);
            this.ispisNormalna.TabIndex = 1;
            // 
            // ispisSortirana
            // 
            this.ispisSortirana.Location = new System.Drawing.Point(172, 167);
            this.ispisSortirana.Multiline = true;
            this.ispisSortirana.Name = "ispisSortirana";
            this.ispisSortirana.Size = new System.Drawing.Size(100, 144);
            this.ispisSortirana.TabIndex = 2;
            // 
            // unosBroja
            // 
            this.unosBroja.Location = new System.Drawing.Point(192, 33);
            this.unosBroja.Name = "unosBroja";
            this.unosBroja.Size = new System.Drawing.Size(75, 23);
            this.unosBroja.TabIndex = 3;
            this.unosBroja.Text = "Unesi";
            this.unosBroja.UseVisualStyleBackColor = true;
            this.unosBroja.Click += new System.EventHandler(this.unosBroja_Click);
            // 
            // unosSortiraj
            // 
            this.unosSortiraj.Location = new System.Drawing.Point(192, 63);
            this.unosSortiraj.Name = "unosSortiraj";
            this.unosSortiraj.Size = new System.Drawing.Size(75, 23);
            this.unosSortiraj.TabIndex = 4;
            this.unosSortiraj.Text = "Sortiraj";
            this.unosSortiraj.UseVisualStyleBackColor = true;
            this.unosSortiraj.Click += new System.EventHandler(this.unosSortiraj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 491);
            this.Controls.Add(this.unosSortiraj);
            this.Controls.Add(this.unosBroja);
            this.Controls.Add(this.ispisSortirana);
            this.Controls.Add(this.ispisNormalna);
            this.Controls.Add(this.unosBroj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox unosBroj;
        private System.Windows.Forms.TextBox ispisNormalna;
        private System.Windows.Forms.TextBox ispisSortirana;
        private System.Windows.Forms.Button unosBroja;
        private System.Windows.Forms.Button unosSortiraj;
    }
}

