namespace WindowsFormsApp1
{
    partial class FrmDoktorBilgiDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorBilgiDüzenle));
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSıfre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbBrans = new System.Windows.Forms.ComboBox();
            this.BtnBilgiGüncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(159, 81);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(156, 29);
            this.TxtSoyad.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(81, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Soyad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(159, 32);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(156, 29);
            this.TxtAd.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(111, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ad:";
            // 
            // MskTc
            // 
            this.MskTc.Enabled = false;
            this.MskTc.Location = new System.Drawing.Point(159, 131);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(156, 29);
            this.MskTc.TabIndex = 30;
            this.MskTc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "TC Kimlik No:";
            // 
            // TxtSıfre
            // 
            this.TxtSıfre.Location = new System.Drawing.Point(159, 226);
            this.TxtSıfre.Name = "TxtSıfre";
            this.TxtSıfre.Size = new System.Drawing.Size(156, 29);
            this.TxtSıfre.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(93, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Sifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(82, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "Brans:";
            // 
            // CmbBrans
            // 
            this.CmbBrans.FormattingEnabled = true;
            this.CmbBrans.Location = new System.Drawing.Point(159, 178);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(156, 31);
            this.CmbBrans.TabIndex = 38;
            // 
            // BtnBilgiGüncelle
            // 
            this.BtnBilgiGüncelle.BackColor = System.Drawing.Color.Lavender;
            this.BtnBilgiGüncelle.Location = new System.Drawing.Point(159, 272);
            this.BtnBilgiGüncelle.Name = "BtnBilgiGüncelle";
            this.BtnBilgiGüncelle.Size = new System.Drawing.Size(156, 43);
            this.BtnBilgiGüncelle.TabIndex = 39;
            this.BtnBilgiGüncelle.Text = "Güncelle";
            this.BtnBilgiGüncelle.UseVisualStyleBackColor = false;
            this.BtnBilgiGüncelle.Click += new System.EventHandler(this.BtnBilgiGüncelle_Click);
            // 
            // FrmDoktorBilgiDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(416, 343);
            this.Controls.Add(this.BtnBilgiGüncelle);
            this.Controls.Add(this.CmbBrans);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSıfre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MskTc);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorBilgiDüzenle";
            this.Text = "Bilgi Düzenleme";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSıfre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbBrans;
        private System.Windows.Forms.Button BtnBilgiGüncelle;
    }
}