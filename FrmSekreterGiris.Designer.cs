namespace WindowsFormsApp1
{
    partial class FrmSekreterGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterGiris));
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.TxtSıfre = new System.Windows.Forms.TextBox();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.Location = new System.Drawing.Point(408, 292);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(120, 34);
            this.BtnGirisYap.TabIndex = 21;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = true;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // TxtSıfre
            // 
            this.TxtSıfre.Location = new System.Drawing.Point(372, 245);
            this.TxtSıfre.Name = "TxtSıfre";
            this.TxtSıfre.Size = new System.Drawing.Size(156, 29);
            this.TxtSıfre.TabIndex = 20;
            this.TxtSıfre.Text = "1234";
            this.TxtSıfre.UseSystemPasswordChar = true;
            // 
            // MskTc
            // 
            this.MskTc.Location = new System.Drawing.Point(372, 199);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(156, 29);
            this.MskTc.TabIndex = 19;
            this.MskTc.Text = "55555555555";
            this.MskTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(292, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Sifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(202, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "TC Kimlik No:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(216, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 53);
            this.label1.TabIndex = 15;
            this.label1.Text = "SEKRETER GİRİŞ PANELİ";
            // 
            // FrmSekreterGiris
            // 
            this.AcceptButton = this.BtnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(703, 344);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.TxtSıfre);
            this.Controls.Add(this.MskTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekreter Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGirisYap;
        private System.Windows.Forms.TextBox TxtSıfre;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}