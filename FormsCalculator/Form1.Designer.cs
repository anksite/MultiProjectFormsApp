namespace FormsCalculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.b_hitung = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_hasil = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nilai A";
            // 
            // tb_a
            // 
            this.tb_a.Location = new System.Drawing.Point(56, 10);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(216, 20);
            this.tb_a.TabIndex = 1;
            // 
            // tb_b
            // 
            this.tb_b.Location = new System.Drawing.Point(56, 36);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(216, 20);
            this.tb_b.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nilai B";
            // 
            // b_hitung
            // 
            this.b_hitung.Location = new System.Drawing.Point(197, 80);
            this.b_hitung.Name = "b_hitung";
            this.b_hitung.Size = new System.Drawing.Size(75, 23);
            this.b_hitung.TabIndex = 4;
            this.b_hitung.Text = "HITUNG";
            this.b_hitung.UseVisualStyleBackColor = true;
            this.b_hitung.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_hasil);
            this.groupBox1.Location = new System.Drawing.Point(16, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 130);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasil";
            // 
            // lb_hasil
            // 
            this.lb_hasil.FormattingEnabled = true;
            this.lb_hasil.Location = new System.Drawing.Point(7, 20);
            this.lb_hasil.Name = "lb_hasil";
            this.lb_hasil.Size = new System.Drawing.Size(243, 108);
            this.lb_hasil.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.b_hitung);
            this.Controls.Add(this.tb_b);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_a);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.TextBox tb_b;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_hitung;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lb_hasil;
    }
}

