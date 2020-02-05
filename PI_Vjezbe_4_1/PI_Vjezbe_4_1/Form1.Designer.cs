namespace PI_Vjezbe_4_1
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
            this.PrviBit = new System.Windows.Forms.TextBox();
            this.DrugiBit = new System.Windows.Forms.TextBox();
            this.TreciBit = new System.Windows.Forms.TextBox();
            this.CetvrtiBit = new System.Windows.Forms.TextBox();
            this.PetiBit = new System.Windows.Forms.TextBox();
            this.SestiBit = new System.Windows.Forms.TextBox();
            this.SedmiBit = new System.Windows.Forms.TextBox();
            this.OsmiBit = new System.Windows.Forms.TextBox();
            this.IspisDekadskog = new System.Windows.Forms.TextBox();
            this.GumbZaPretvorbu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PrviBit
            // 
            this.PrviBit.Location = new System.Drawing.Point(70, 147);
            this.PrviBit.Name = "PrviBit";
            this.PrviBit.Size = new System.Drawing.Size(28, 20);
            this.PrviBit.TabIndex = 0;
            // 
            // DrugiBit
            // 
            this.DrugiBit.Location = new System.Drawing.Point(104, 147);
            this.DrugiBit.Name = "DrugiBit";
            this.DrugiBit.Size = new System.Drawing.Size(28, 20);
            this.DrugiBit.TabIndex = 1;
            // 
            // TreciBit
            // 
            this.TreciBit.Location = new System.Drawing.Point(138, 147);
            this.TreciBit.Name = "TreciBit";
            this.TreciBit.Size = new System.Drawing.Size(28, 20);
            this.TreciBit.TabIndex = 2;
            // 
            // CetvrtiBit
            // 
            this.CetvrtiBit.Location = new System.Drawing.Point(172, 147);
            this.CetvrtiBit.Name = "CetvrtiBit";
            this.CetvrtiBit.Size = new System.Drawing.Size(28, 20);
            this.CetvrtiBit.TabIndex = 3;
            // 
            // PetiBit
            // 
            this.PetiBit.Location = new System.Drawing.Point(206, 147);
            this.PetiBit.Name = "PetiBit";
            this.PetiBit.Size = new System.Drawing.Size(28, 20);
            this.PetiBit.TabIndex = 4;
            // 
            // SestiBit
            // 
            this.SestiBit.Location = new System.Drawing.Point(240, 147);
            this.SestiBit.Name = "SestiBit";
            this.SestiBit.Size = new System.Drawing.Size(28, 20);
            this.SestiBit.TabIndex = 5;
            // 
            // SedmiBit
            // 
            this.SedmiBit.Location = new System.Drawing.Point(274, 147);
            this.SedmiBit.Name = "SedmiBit";
            this.SedmiBit.Size = new System.Drawing.Size(28, 20);
            this.SedmiBit.TabIndex = 6;
            // 
            // OsmiBit
            // 
            this.OsmiBit.Location = new System.Drawing.Point(308, 147);
            this.OsmiBit.Name = "OsmiBit";
            this.OsmiBit.Size = new System.Drawing.Size(28, 20);
            this.OsmiBit.TabIndex = 7;
            // 
            // IspisDekadskog
            // 
            this.IspisDekadskog.Location = new System.Drawing.Point(70, 206);
            this.IspisDekadskog.Name = "IspisDekadskog";
            this.IspisDekadskog.Size = new System.Drawing.Size(266, 20);
            this.IspisDekadskog.TabIndex = 8;
            // 
            // GumbZaPretvorbu
            // 
            this.GumbZaPretvorbu.Location = new System.Drawing.Point(362, 143);
            this.GumbZaPretvorbu.Name = "GumbZaPretvorbu";
            this.GumbZaPretvorbu.Size = new System.Drawing.Size(75, 23);
            this.GumbZaPretvorbu.TabIndex = 9;
            this.GumbZaPretvorbu.Text = "Klikni me!";
            this.GumbZaPretvorbu.UseVisualStyleBackColor = true;
            this.GumbZaPretvorbu.Click += new System.EventHandler(this.GumbZaPretvorbu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "U Decimalni";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 247);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GumbZaPretvorbu);
            this.Controls.Add(this.IspisDekadskog);
            this.Controls.Add(this.OsmiBit);
            this.Controls.Add(this.SedmiBit);
            this.Controls.Add(this.SestiBit);
            this.Controls.Add(this.PetiBit);
            this.Controls.Add(this.CetvrtiBit);
            this.Controls.Add(this.TreciBit);
            this.Controls.Add(this.DrugiBit);
            this.Controls.Add(this.PrviBit);
            this.Name = "Form1";
            this.Text = "Binarni u dekadski";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PrviBit;
        private System.Windows.Forms.TextBox DrugiBit;
        private System.Windows.Forms.TextBox TreciBit;
        private System.Windows.Forms.TextBox CetvrtiBit;
        private System.Windows.Forms.TextBox PetiBit;
        private System.Windows.Forms.TextBox SestiBit;
        private System.Windows.Forms.TextBox SedmiBit;
        private System.Windows.Forms.TextBox OsmiBit;
        private System.Windows.Forms.TextBox IspisDekadskog;
        private System.Windows.Forms.Button GumbZaPretvorbu;
        private System.Windows.Forms.Label label1;
    }
}

