namespace WindowsFormsApp1
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.TxtSıfre = new System.Windows.Forms.TextBox();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.BtnKayıtOl = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSıfre
            // 
            this.TxtSıfre.Location = new System.Drawing.Point(175, 370);
            this.TxtSıfre.Name = "TxtSıfre";
            this.TxtSıfre.Size = new System.Drawing.Size(156, 29);
            this.TxtSıfre.TabIndex = 5;
            // 
            // MskTc
            // 
            this.MskTc.Location = new System.Drawing.Point(175, 271);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(156, 29);
            this.MskTc.TabIndex = 3;
            this.MskTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(109, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "TC Kimlik No:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(175, 172);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(156, 29);
            this.TxtAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(127, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ad:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(175, 221);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(156, 29);
            this.TxtSoyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(97, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(84, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Telefon:";
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(175, 320);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(156, 29);
            this.MskTelefon.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(80, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cinsiyet:";
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(175, 418);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(156, 31);
            this.CmbCinsiyet.TabIndex = 6;
            // 
            // BtnKayıtOl
            // 
            this.BtnKayıtOl.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BtnKayıtOl.Location = new System.Drawing.Point(175, 464);
            this.BtnKayıtOl.Name = "BtnKayıtOl";
            this.BtnKayıtOl.Size = new System.Drawing.Size(156, 43);
            this.BtnKayıtOl.TabIndex = 7;
            this.BtnKayıtOl.Text = "Kayıt Ol";
            this.BtnKayıtOl.UseVisualStyleBackColor = false;
            this.BtnKayıtOl.Click += new System.EventHandler(this.BtnKayıtOl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.BtnKayıtOl;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(456, 550);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnKayıtOl);
            this.Controls.Add(this.CmbCinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MskTelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSıfre);
            this.Controls.Add(this.MskTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "Hasta Kayıt";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSıfre;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.Button BtnKayıtOl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}