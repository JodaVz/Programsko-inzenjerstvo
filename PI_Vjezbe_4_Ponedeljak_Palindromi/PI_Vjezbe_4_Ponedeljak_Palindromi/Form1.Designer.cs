namespace PI_Vjezbe_4_Ponedeljak_Palindromi
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
            this.upisRecenice = new System.Windows.Forms.TextBox();
            this.potvrdaRezultata = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // upisRecenice
            // 
            this.upisRecenice.Location = new System.Drawing.Point(152, 132);
            this.upisRecenice.Name = "upisRecenice";
            this.upisRecenice.Size = new System.Drawing.Size(486, 20);
            this.upisRecenice.TabIndex = 0;
            this.upisRecenice.TextChanged += new System.EventHandler(this.upisRecenice_TextChanged);
            // 
            // potvrdaRezultata
            // 
            this.potvrdaRezultata.AutoSize = true;
            this.potvrdaRezultata.Location = new System.Drawing.Point(152, 169);
            this.potvrdaRezultata.Name = "potvrdaRezultata";
            this.potvrdaRezultata.Size = new System.Drawing.Size(35, 13);
            this.potvrdaRezultata.TabIndex = 1;
            this.potvrdaRezultata.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 502);
            this.Controls.Add(this.potvrdaRezultata);
            this.Controls.Add(this.upisRecenice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox upisRecenice;
        private System.Windows.Forms.Label potvrdaRezultata;
    }
}

