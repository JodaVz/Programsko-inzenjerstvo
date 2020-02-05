namespace PI_Vjezbe_6_RandomNekiKurac
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
            this.popisBrojeva = new System.Windows.Forms.ListBox();
            this.unosKreni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // popisBrojeva
            // 
            this.popisBrojeva.FormattingEnabled = true;
            this.popisBrojeva.Location = new System.Drawing.Point(44, 54);
            this.popisBrojeva.Name = "popisBrojeva";
            this.popisBrojeva.Size = new System.Drawing.Size(254, 251);
            this.popisBrojeva.TabIndex = 0;
            // 
            // unosKreni
            // 
            this.unosKreni.Location = new System.Drawing.Point(319, 54);
            this.unosKreni.Name = "unosKreni";
            this.unosKreni.Size = new System.Drawing.Size(75, 23);
            this.unosKreni.TabIndex = 1;
            this.unosKreni.Text = "Go";
            this.unosKreni.UseVisualStyleBackColor = true;
            this.unosKreni.Click += new System.EventHandler(this.unosKreni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 599);
            this.Controls.Add(this.unosKreni);
            this.Controls.Add(this.popisBrojeva);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox popisBrojeva;
        private System.Windows.Forms.Button unosKreni;
    }
}

