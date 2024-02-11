namespace list_koleksiyonu
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
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtNumaraN = new System.Windows.Forms.TextBox();
            this.lbSayi = new System.Windows.Forms.ListBox();
            this.lbMetin = new System.Windows.Forms.ListBox();
            this.lbNesne = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdSoyadN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkleSayi = new System.Windows.Forms.Button();
            this.btnEkleMetin = new System.Windows.Forms.Button();
            this.btnEkleNesne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(85, 49);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(100, 20);
            this.txtNumara.TabIndex = 0;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(307, 49);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtNumaraN
            // 
            this.txtNumaraN.Location = new System.Drawing.Point(505, 42);
            this.txtNumaraN.Name = "txtNumaraN";
            this.txtNumaraN.Size = new System.Drawing.Size(100, 20);
            this.txtNumaraN.TabIndex = 2;
            // 
            // lbSayi
            // 
            this.lbSayi.FormattingEnabled = true;
            this.lbSayi.Location = new System.Drawing.Point(65, 135);
            this.lbSayi.Name = "lbSayi";
            this.lbSayi.Size = new System.Drawing.Size(120, 173);
            this.lbSayi.TabIndex = 3;
            // 
            // lbMetin
            // 
            this.lbMetin.FormattingEnabled = true;
            this.lbMetin.Location = new System.Drawing.Point(287, 135);
            this.lbMetin.Name = "lbMetin";
            this.lbMetin.Size = new System.Drawing.Size(120, 173);
            this.lbMetin.TabIndex = 4;
            // 
            // lbNesne
            // 
            this.lbNesne.FormattingEnabled = true;
            this.lbNesne.Location = new System.Drawing.Point(485, 135);
            this.lbNesne.Name = "lbNesne";
            this.lbNesne.Size = new System.Drawing.Size(120, 173);
            this.lbNesne.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numara";
            // 
            // txtAdSoyadN
            // 
            this.txtAdSoyadN.Location = new System.Drawing.Point(505, 68);
            this.txtAdSoyadN.Name = "txtAdSoyadN";
            this.txtAdSoyadN.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyadN.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ad Soyad";
            // 
            // btnEkleSayi
            // 
            this.btnEkleSayi.Location = new System.Drawing.Point(85, 75);
            this.btnEkleSayi.Name = "btnEkleSayi";
            this.btnEkleSayi.Size = new System.Drawing.Size(100, 23);
            this.btnEkleSayi.TabIndex = 12;
            this.btnEkleSayi.Text = "Sayı Ekle";
            this.btnEkleSayi.UseVisualStyleBackColor = true;
            this.btnEkleSayi.Click += new System.EventHandler(this.btnEkleSayi_Click);
            // 
            // btnEkleMetin
            // 
            this.btnEkleMetin.Location = new System.Drawing.Point(307, 75);
            this.btnEkleMetin.Name = "btnEkleMetin";
            this.btnEkleMetin.Size = new System.Drawing.Size(100, 23);
            this.btnEkleMetin.TabIndex = 13;
            this.btnEkleMetin.Text = "Metin Ekle";
            this.btnEkleMetin.UseVisualStyleBackColor = true;
            this.btnEkleMetin.Click += new System.EventHandler(this.btnEkleMetin_Click);
            // 
            // btnEkleNesne
            // 
            this.btnEkleNesne.Location = new System.Drawing.Point(505, 94);
            this.btnEkleNesne.Name = "btnEkleNesne";
            this.btnEkleNesne.Size = new System.Drawing.Size(100, 23);
            this.btnEkleNesne.TabIndex = 14;
            this.btnEkleNesne.Text = "Nesne Ekle";
            this.btnEkleNesne.UseVisualStyleBackColor = true;
            this.btnEkleNesne.Click += new System.EventHandler(this.btnEkleNesne_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 379);
            this.Controls.Add(this.btnEkleNesne);
            this.Controls.Add(this.btnEkleMetin);
            this.Controls.Add(this.btnEkleSayi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdSoyadN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNesne);
            this.Controls.Add(this.lbMetin);
            this.Controls.Add(this.lbSayi);
            this.Controls.Add(this.txtNumaraN);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtNumara);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtNumaraN;
        private System.Windows.Forms.ListBox lbSayi;
        private System.Windows.Forms.ListBox lbMetin;
        private System.Windows.Forms.ListBox lbNesne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdSoyadN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEkleSayi;
        private System.Windows.Forms.Button btnEkleMetin;
        private System.Windows.Forms.Button btnEkleNesne;
    }
}

