namespace PI_Vjezbe_4_Ponedeljak_Boje
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
            this.bojeUnosPCrvena = new System.Windows.Forms.TextBox();
            this.bojeUnosPlava = new System.Windows.Forms.TextBox();
            this.bojeUnosZelena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ispisBoja = new System.Windows.Forms.ListView();
            this.potvrdaUnosa = new System.Windows.Forms.Button();
            this.potvrdaPromjene = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bojeUnosPCrvena
            // 
            this.bojeUnosPCrvena.Location = new System.Drawing.Point(234, 81);
            this.bojeUnosPCrvena.Name = "bojeUnosPCrvena";
            this.bojeUnosPCrvena.Size = new System.Drawing.Size(100, 20);
            this.bojeUnosPCrvena.TabIndex = 0;
            // 
            // bojeUnosPlava
            // 
            this.bojeUnosPlava.Location = new System.Drawing.Point(234, 133);
            this.bojeUnosPlava.Name = "bojeUnosPlava";
            this.bojeUnosPlava.Size = new System.Drawing.Size(100, 20);
            this.bojeUnosPlava.TabIndex = 1;
            // 
            // bojeUnosZelena
            // 
            this.bojeUnosZelena.Location = new System.Drawing.Point(234, 107);
            this.bojeUnosZelena.Name = "bojeUnosZelena";
            this.bojeUnosZelena.Size = new System.Drawing.Size(100, 20);
            this.bojeUnosZelena.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Crvena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zelena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Plava";
            // 
            // ispisBoja
            // 
            this.ispisBoja.Location = new System.Drawing.Point(493, 81);
            this.ispisBoja.Name = "ispisBoja";
            this.ispisBoja.Size = new System.Drawing.Size(130, 211);
            this.ispisBoja.TabIndex = 6;
            this.ispisBoja.UseCompatibleStateImageBehavior = false;
            this.ispisBoja.View = System.Windows.Forms.View.List;
            // 
            // potvrdaUnosa
            // 
            this.potvrdaUnosa.Location = new System.Drawing.Point(341, 129);
            this.potvrdaUnosa.Name = "potvrdaUnosa";
            this.potvrdaUnosa.Size = new System.Drawing.Size(75, 23);
            this.potvrdaUnosa.TabIndex = 7;
            this.potvrdaUnosa.Text = "Unos Boja";
            this.potvrdaUnosa.UseVisualStyleBackColor = true;
            this.potvrdaUnosa.Click += new System.EventHandler(this.potvrdaUnosa_Click);
            // 
            // potvrdaPromjene
            // 
            this.potvrdaPromjene.Location = new System.Drawing.Point(341, 159);
            this.potvrdaPromjene.Name = "potvrdaPromjene";
            this.potvrdaPromjene.Size = new System.Drawing.Size(75, 23);
            this.potvrdaPromjene.TabIndex = 8;
            this.potvrdaPromjene.Text = "Promjena Boja";
            this.potvrdaPromjene.UseVisualStyleBackColor = true;
            this.potvrdaPromjene.Click += new System.EventHandler(this.potvrdaPromjene_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 544);
            this.Controls.Add(this.potvrdaPromjene);
            this.Controls.Add(this.potvrdaUnosa);
            this.Controls.Add(this.ispisBoja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bojeUnosZelena);
            this.Controls.Add(this.bojeUnosPlava);
            this.Controls.Add(this.bojeUnosPCrvena);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bojeUnosPCrvena;
        private System.Windows.Forms.TextBox bojeUnosPlava;
        private System.Windows.Forms.TextBox bojeUnosZelena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView ispisBoja;
        private System.Windows.Forms.Button potvrdaUnosa;
        private System.Windows.Forms.Button potvrdaPromjene;
    }
}

