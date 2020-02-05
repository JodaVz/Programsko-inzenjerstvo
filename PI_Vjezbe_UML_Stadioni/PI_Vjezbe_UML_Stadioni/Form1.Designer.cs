namespace PI_Vjezbe_UML_Stadioni
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
            this.listaStadiona = new System.Windows.Forms.ListBox();
            this.unosStadion = new System.Windows.Forms.TextBox();
            this.unosStadionPotvrda = new System.Windows.Forms.Button();
            this.unosAdresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaStadiona
            // 
            this.listaStadiona.FormattingEnabled = true;
            this.listaStadiona.Location = new System.Drawing.Point(12, 12);
            this.listaStadiona.Name = "listaStadiona";
            this.listaStadiona.Size = new System.Drawing.Size(140, 173);
            this.listaStadiona.TabIndex = 0;
            // 
            // unosStadion
            // 
            this.unosStadion.Location = new System.Drawing.Point(158, 25);
            this.unosStadion.Name = "unosStadion";
            this.unosStadion.Size = new System.Drawing.Size(100, 20);
            this.unosStadion.TabIndex = 1;
            // 
            // unosStadionPotvrda
            // 
            this.unosStadionPotvrda.Location = new System.Drawing.Point(264, 42);
            this.unosStadionPotvrda.Name = "unosStadionPotvrda";
            this.unosStadionPotvrda.Size = new System.Drawing.Size(105, 23);
            this.unosStadionPotvrda.TabIndex = 2;
            this.unosStadionPotvrda.Text = "Dodaj Stadion";
            this.unosStadionPotvrda.UseVisualStyleBackColor = true;
            this.unosStadionPotvrda.Click += new System.EventHandler(this.unosStadionPotvrda_Click);
            // 
            // unosAdresa
            // 
            this.unosAdresa.Location = new System.Drawing.Point(158, 66);
            this.unosAdresa.Name = "unosAdresa";
            this.unosAdresa.Size = new System.Drawing.Size(100, 20);
            this.unosAdresa.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv stadiona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adresa stadiona";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unosAdresa);
            this.Controls.Add(this.unosStadionPotvrda);
            this.Controls.Add(this.unosStadion);
            this.Controls.Add(this.listaStadiona);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaStadiona;
        private System.Windows.Forms.TextBox unosStadion;
        private System.Windows.Forms.Button unosStadionPotvrda;
        private System.Windows.Forms.TextBox unosAdresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

