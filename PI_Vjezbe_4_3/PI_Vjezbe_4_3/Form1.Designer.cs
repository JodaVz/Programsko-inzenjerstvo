namespace PI_Vjezbe_4_3
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
            this.OperacijaZbroji = new System.Windows.Forms.RadioButton();
            this.OperacijaOduzmi = new System.Windows.Forms.RadioButton();
            this.OperacijaPomnozi = new System.Windows.Forms.RadioButton();
            this.OperacijaPodjeli = new System.Windows.Forms.RadioButton();
            this.unosBroja = new System.Windows.Forms.TextBox();
            this.prikazRezultata = new System.Windows.Forms.TextBox();
            this.PotvrdaUnosa = new System.Windows.Forms.Button();
            this.listPovijestUnosa = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OperacijaZbroji
            // 
            this.OperacijaZbroji.AutoSize = true;
            this.OperacijaZbroji.Location = new System.Drawing.Point(38, 60);
            this.OperacijaZbroji.Name = "OperacijaZbroji";
            this.OperacijaZbroji.Size = new System.Drawing.Size(51, 17);
            this.OperacijaZbroji.TabIndex = 0;
            this.OperacijaZbroji.TabStop = true;
            this.OperacijaZbroji.Text = "Zbroji";
            this.OperacijaZbroji.UseVisualStyleBackColor = true;
            this.OperacijaZbroji.CheckedChanged += new System.EventHandler(this.OperacijaZbroji_CheckedChanged);
            // 
            // OperacijaOduzmi
            // 
            this.OperacijaOduzmi.AutoSize = true;
            this.OperacijaOduzmi.Location = new System.Drawing.Point(38, 83);
            this.OperacijaOduzmi.Name = "OperacijaOduzmi";
            this.OperacijaOduzmi.Size = new System.Drawing.Size(60, 17);
            this.OperacijaOduzmi.TabIndex = 1;
            this.OperacijaOduzmi.TabStop = true;
            this.OperacijaOduzmi.Text = "Oduzmi";
            this.OperacijaOduzmi.UseVisualStyleBackColor = true;
            this.OperacijaOduzmi.CheckedChanged += new System.EventHandler(this.OperacijaOduzmi_CheckedChanged);
            // 
            // OperacijaPomnozi
            // 
            this.OperacijaPomnozi.AutoSize = true;
            this.OperacijaPomnozi.Location = new System.Drawing.Point(38, 106);
            this.OperacijaPomnozi.Name = "OperacijaPomnozi";
            this.OperacijaPomnozi.Size = new System.Drawing.Size(65, 17);
            this.OperacijaPomnozi.TabIndex = 2;
            this.OperacijaPomnozi.TabStop = true;
            this.OperacijaPomnozi.Text = "Pomnozi";
            this.OperacijaPomnozi.UseVisualStyleBackColor = true;
            this.OperacijaPomnozi.CheckedChanged += new System.EventHandler(this.OperacijaPomnozi_CheckedChanged);
            // 
            // OperacijaPodjeli
            // 
            this.OperacijaPodjeli.AutoSize = true;
            this.OperacijaPodjeli.Location = new System.Drawing.Point(38, 129);
            this.OperacijaPodjeli.Name = "OperacijaPodjeli";
            this.OperacijaPodjeli.Size = new System.Drawing.Size(56, 17);
            this.OperacijaPodjeli.TabIndex = 3;
            this.OperacijaPodjeli.TabStop = true;
            this.OperacijaPodjeli.Text = "Podjeli";
            this.OperacijaPodjeli.UseVisualStyleBackColor = true;
            this.OperacijaPodjeli.CheckedChanged += new System.EventHandler(this.OperacijaPodjeli_CheckedChanged);
            // 
            // unosBroja
            // 
            this.unosBroja.Location = new System.Drawing.Point(152, 60);
            this.unosBroja.Name = "unosBroja";
            this.unosBroja.Size = new System.Drawing.Size(100, 20);
            this.unosBroja.TabIndex = 4;
            // 
            // prikazRezultata
            // 
            this.prikazRezultata.Location = new System.Drawing.Point(268, 59);
            this.prikazRezultata.Name = "prikazRezultata";
            this.prikazRezultata.Size = new System.Drawing.Size(100, 20);
            this.prikazRezultata.TabIndex = 5;
            // 
            // PotvrdaUnosa
            // 
            this.PotvrdaUnosa.Location = new System.Drawing.Point(152, 106);
            this.PotvrdaUnosa.Name = "PotvrdaUnosa";
            this.PotvrdaUnosa.Size = new System.Drawing.Size(75, 23);
            this.PotvrdaUnosa.TabIndex = 6;
            this.PotvrdaUnosa.Text = "Klikni me!";
            this.PotvrdaUnosa.UseVisualStyleBackColor = true;
            this.PotvrdaUnosa.Click += new System.EventHandler(this.PotvrdaUnosa_Click);
            // 
            // listPovijestUnosa
            // 
            this.listPovijestUnosa.Location = new System.Drawing.Point(361, 170);
            this.listPovijestUnosa.Name = "listPovijestUnosa";
            this.listPovijestUnosa.Size = new System.Drawing.Size(154, 241);
            this.listPovijestUnosa.TabIndex = 7;
            this.listPovijestUnosa.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Unesite broj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rezultat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Povijest unosa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 423);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listPovijestUnosa);
            this.Controls.Add(this.PotvrdaUnosa);
            this.Controls.Add(this.prikazRezultata);
            this.Controls.Add(this.unosBroja);
            this.Controls.Add(this.OperacijaPodjeli);
            this.Controls.Add(this.OperacijaPomnozi);
            this.Controls.Add(this.OperacijaOduzmi);
            this.Controls.Add(this.OperacijaZbroji);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton OperacijaZbroji;
        private System.Windows.Forms.RadioButton OperacijaOduzmi;
        private System.Windows.Forms.RadioButton OperacijaPomnozi;
        private System.Windows.Forms.RadioButton OperacijaPodjeli;
        private System.Windows.Forms.TextBox unosBroja;
        private System.Windows.Forms.TextBox prikazRezultata;
        private System.Windows.Forms.Button PotvrdaUnosa;
        private System.Windows.Forms.ListView listPovijestUnosa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

