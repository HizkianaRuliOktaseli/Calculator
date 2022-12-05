namespace Calculator
{
    partial class FormCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.operasi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNilaiA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNilaiB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operasi";
            // 
            // operasi
            // 
            this.operasi.FormattingEnabled = true;
            this.operasi.Items.AddRange(new object[] {
            "Penjumlahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.operasi.Location = new System.Drawing.Point(92, 57);
            this.operasi.Name = "operasi";
            this.operasi.Size = new System.Drawing.Size(272, 24);
            this.operasi.TabIndex = 1;
            this.operasi.SelectedIndexChanged += new System.EventHandler(this.operasi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nilai A";
            // 
            // textNilaiA
            // 
            this.textNilaiA.Location = new System.Drawing.Point(92, 107);
            this.textNilaiA.Name = "textNilaiA";
            this.textNilaiA.Size = new System.Drawing.Size(272, 22);
            this.textNilaiA.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nilai B";
            // 
            // textNilaiB
            // 
            this.textNilaiB.Location = new System.Drawing.Point(92, 158);
            this.textNilaiB.Name = "textNilaiB";
            this.textNilaiB.Size = new System.Drawing.Size(272, 22);
            this.textNilaiB.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Proses";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textNilaiB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNilaiA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.operasi);
            this.Controls.Add(this.label1);
            this.Name = "FormCalculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox operasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNilaiA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNilaiB;
        private System.Windows.Forms.Button button1;
    }
}