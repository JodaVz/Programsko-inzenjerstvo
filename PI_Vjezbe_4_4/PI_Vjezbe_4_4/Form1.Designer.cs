namespace PI_Vjezbe_4_4
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
            this.unosTeksta = new System.Windows.Forms.TextBox();
            this.ispisTeksta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // unosTeksta
            // 
            this.unosTeksta.Location = new System.Drawing.Point(148, 111);
            this.unosTeksta.Name = "unosTeksta";
            this.unosTeksta.Size = new System.Drawing.Size(100, 20);
            this.unosTeksta.TabIndex = 0;
            this.unosTeksta.TextChanged += new System.EventHandler(this.unosTeksta_TextChanged);
            // 
            // ispisTeksta
            // 
            this.ispisTeksta.Location = new System.Drawing.Point(297, 110);
            this.ispisTeksta.Multiline = true;
            this.ispisTeksta.Name = "ispisTeksta";
            this.ispisTeksta.Size = new System.Drawing.Size(100, 188);
            this.ispisTeksta.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 499);
            this.Controls.Add(this.ispisTeksta);
            this.Controls.Add(this.unosTeksta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox unosTeksta;
        private System.Windows.Forms.TextBox ispisTeksta;
    }
}

