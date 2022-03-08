
namespace veritabanıproje
{
    partial class FormSorgu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSorgu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_ekledon = new System.Windows.Forms.Button();
            this.button_listele = new System.Windows.Forms.Button();
            this.checkBox_ıd = new System.Windows.Forms.CheckBox();
            this.checkBox_tcno = new System.Windows.Forms.CheckBox();
            this.checkBox_isim = new System.Windows.Forms.CheckBox();
            this.checkBox_soyisim = new System.Windows.Forms.CheckBox();
            this.checkBox_sınıf = new System.Windows.Forms.CheckBox();
            this.checkBox_heskodu = new System.Windows.Forms.CheckBox();
            this.checkBox_bolum = new System.Windows.Forms.CheckBox();
            this.checkBox_ogrno = new System.Windows.Forms.CheckBox();
            this.comboBox_bolumsecim = new System.Windows.Forms.ComboBox();
            this.comboBox_sınıfsecım = new System.Windows.Forms.ComboBox();
            this.linkLabel_kontrolsistemi = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(21)))), ((int)(((byte)(31)))));
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(221, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Görünteleme Sistemi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Görmek İstediğiniz Özellikleri Seçin";
            // 
            // button_ekledon
            // 
            this.button_ekledon.Location = new System.Drawing.Point(36, 375);
            this.button_ekledon.Name = "button_ekledon";
            this.button_ekledon.Size = new System.Drawing.Size(206, 48);
            this.button_ekledon.TabIndex = 10;
            this.button_ekledon.Text = "<--- Ekleme Sistemine Dön";
            this.button_ekledon.UseVisualStyleBackColor = true;
            this.button_ekledon.Click += new System.EventHandler(this.button_ekledon_Click);
            // 
            // button_listele
            // 
            this.button_listele.Location = new System.Drawing.Point(595, 375);
            this.button_listele.Name = "button_listele";
            this.button_listele.Size = new System.Drawing.Size(184, 48);
            this.button_listele.TabIndex = 11;
            this.button_listele.Text = "Öğrencileri Listele";
            this.button_listele.UseVisualStyleBackColor = true;
            this.button_listele.Click += new System.EventHandler(this.button_listele_Click);
            // 
            // checkBox_ıd
            // 
            this.checkBox_ıd.AutoSize = true;
            this.checkBox_ıd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(107)))), ((int)(((byte)(106)))));
            this.checkBox_ıd.Location = new System.Drawing.Point(259, 224);
            this.checkBox_ıd.Name = "checkBox_ıd";
            this.checkBox_ıd.Size = new System.Drawing.Size(95, 21);
            this.checkBox_ıd.TabIndex = 12;
            this.checkBox_ıd.Text = "Öğrenci Id";
            this.checkBox_ıd.UseVisualStyleBackColor = false;
            // 
            // checkBox_tcno
            // 
            this.checkBox_tcno.AutoSize = true;
            this.checkBox_tcno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(107)))), ((int)(((byte)(106)))));
            this.checkBox_tcno.Location = new System.Drawing.Point(259, 251);
            this.checkBox_tcno.Name = "checkBox_tcno";
            this.checkBox_tcno.Size = new System.Drawing.Size(66, 21);
            this.checkBox_tcno.TabIndex = 13;
            this.checkBox_tcno.Text = "TCNo";
            this.checkBox_tcno.UseVisualStyleBackColor = false;
            // 
            // checkBox_isim
            // 
            this.checkBox_isim.AutoSize = true;
            this.checkBox_isim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(107)))), ((int)(((byte)(106)))));
            this.checkBox_isim.Location = new System.Drawing.Point(259, 275);
            this.checkBox_isim.Name = "checkBox_isim";
            this.checkBox_isim.Size = new System.Drawing.Size(54, 21);
            this.checkBox_isim.TabIndex = 15;
            this.checkBox_isim.Text = "İsim";
            this.checkBox_isim.UseVisualStyleBackColor = false;
            // 
            // checkBox_soyisim
            // 
            this.checkBox_soyisim.AutoSize = true;
            this.checkBox_soyisim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(107)))), ((int)(((byte)(106)))));
            this.checkBox_soyisim.Location = new System.Drawing.Point(259, 302);
            this.checkBox_soyisim.Name = "checkBox_soyisim";
            this.checkBox_soyisim.Size = new System.Drawing.Size(78, 21);
            this.checkBox_soyisim.TabIndex = 14;
            this.checkBox_soyisim.Text = "Soyisim";
            this.checkBox_soyisim.UseVisualStyleBackColor = false;
            // 
            // checkBox_sınıf
            // 
            this.checkBox_sınıf.AutoSize = true;
            this.checkBox_sınıf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(107)))), ((int)(((byte)(106)))));
            this.checkBox_sınıf.Location = new System.Drawing.Point(446, 278);
            this.checkBox_sınıf.Name = "checkBox_sınıf";
            this.checkBox_sınıf.Size = new System.Drawing.Size(57, 21);
            this.checkBox_sınıf.TabIndex = 19;
            this.checkBox_sınıf.Text = "Sınıf";
            this.checkBox_sınıf.UseVisualStyleBackColor = false;
            // 
            // checkBox_heskodu
            // 
            this.checkBox_heskodu.AutoSize = true;
            this.checkBox_heskodu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(107)))), ((int)(((byte)(106)))));
            this.checkBox_heskodu.Location = new System.Drawing.Point(446, 302);
            this.checkBox_heskodu.Name = "checkBox_heskodu";
            this.checkBox_heskodu.Size = new System.Drawing.Size(92, 21);
            this.checkBox_heskodu.TabIndex = 18;
            this.checkBox_heskodu.Text = "Hes Kodu";
            this.checkBox_heskodu.UseVisualStyleBackColor = false;
            // 
            // checkBox_bolum
            // 
            this.checkBox_bolum.AutoSize = true;
            this.checkBox_bolum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(107)))), ((int)(((byte)(106)))));
            this.checkBox_bolum.Location = new System.Drawing.Point(446, 251);
            this.checkBox_bolum.Name = "checkBox_bolum";
            this.checkBox_bolum.Size = new System.Drawing.Size(69, 21);
            this.checkBox_bolum.TabIndex = 17;
            this.checkBox_bolum.Text = "Bölüm";
            this.checkBox_bolum.UseVisualStyleBackColor = false;
            // 
            // checkBox_ogrno
            // 
            this.checkBox_ogrno.AutoSize = true;
            this.checkBox_ogrno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(107)))), ((int)(((byte)(106)))));
            this.checkBox_ogrno.Location = new System.Drawing.Point(446, 224);
            this.checkBox_ogrno.Name = "checkBox_ogrno";
            this.checkBox_ogrno.Size = new System.Drawing.Size(102, 21);
            this.checkBox_ogrno.TabIndex = 16;
            this.checkBox_ogrno.Text = "Öğrenci No";
            this.checkBox_ogrno.UseVisualStyleBackColor = false;
            // 
            // comboBox_bolumsecim
            // 
            this.comboBox_bolumsecim.FormattingEnabled = true;
            this.comboBox_bolumsecim.Items.AddRange(new object[] {
            "Bölüm Seçimi Yapınız",
            "Bilgisayar Mühendisliği",
            "Biyoloji",
            "Jeoloji Mühendisliği",
            "Diş Hekimliği",
            "Yazılım Mühendisliği",
            "Türkçe  Öğretmenliği",
            "Eczacılık",
            "Mekatronik Mühendisliği",
            "Fizik",
            "Veterinerlik",
            "İlahiyat",
            "Matematik",
            "Kimya Mühendisliği"});
            this.comboBox_bolumsecim.Location = new System.Drawing.Point(615, 188);
            this.comboBox_bolumsecim.Name = "comboBox_bolumsecim";
            this.comboBox_bolumsecim.Size = new System.Drawing.Size(164, 24);
            this.comboBox_bolumsecim.TabIndex = 20;
            this.comboBox_bolumsecim.Text = "Bölüm Seçimi Yapınız";
            // 
            // comboBox_sınıfsecım
            // 
            this.comboBox_sınıfsecım.FormattingEnabled = true;
            this.comboBox_sınıfsecım.Items.AddRange(new object[] {
            "Sınıf Seçimi Yapınız",
            "1",
            "2",
            "3",
            "4"});
            this.comboBox_sınıfsecım.Location = new System.Drawing.Point(615, 275);
            this.comboBox_sınıfsecım.Name = "comboBox_sınıfsecım";
            this.comboBox_sınıfsecım.Size = new System.Drawing.Size(164, 24);
            this.comboBox_sınıfsecım.TabIndex = 21;
            this.comboBox_sınıfsecım.Text = "Sınıf Seçimi Yapınız";
            // 
            // linkLabel_kontrolsistemi
            // 
            this.linkLabel_kontrolsistemi.AutoSize = true;
            this.linkLabel_kontrolsistemi.Location = new System.Drawing.Point(301, 348);
            this.linkLabel_kontrolsistemi.Name = "linkLabel_kontrolsistemi";
            this.linkLabel_kontrolsistemi.Size = new System.Drawing.Size(192, 17);
            this.linkLabel_kontrolsistemi.TabIndex = 22;
            this.linkLabel_kontrolsistemi.TabStop = true;
            this.linkLabel_kontrolsistemi.Text = "Öğrenci Kontrol Etme Sistemi";
            this.linkLabel_kontrolsistemi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_kontrolsistemi_LinkClicked);
            // 
            // FormSorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.linkLabel_kontrolsistemi);
            this.Controls.Add(this.comboBox_sınıfsecım);
            this.Controls.Add(this.comboBox_bolumsecim);
            this.Controls.Add(this.checkBox_sınıf);
            this.Controls.Add(this.checkBox_heskodu);
            this.Controls.Add(this.checkBox_bolum);
            this.Controls.Add(this.checkBox_ogrno);
            this.Controls.Add(this.checkBox_isim);
            this.Controls.Add(this.checkBox_soyisim);
            this.Controls.Add(this.checkBox_tcno);
            this.Controls.Add(this.checkBox_ıd);
            this.Controls.Add(this.button_listele);
            this.Controls.Add(this.button_ekledon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSorgu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSorgu_FormClosed);
            this.Load += new System.EventHandler(this.FormSorgu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_ekledon;
        private System.Windows.Forms.Button button_listele;
        private System.Windows.Forms.CheckBox checkBox_ıd;
        private System.Windows.Forms.CheckBox checkBox_tcno;
        private System.Windows.Forms.CheckBox checkBox_isim;
        private System.Windows.Forms.CheckBox checkBox_soyisim;
        private System.Windows.Forms.CheckBox checkBox_sınıf;
        private System.Windows.Forms.CheckBox checkBox_heskodu;
        private System.Windows.Forms.CheckBox checkBox_bolum;
        private System.Windows.Forms.CheckBox checkBox_ogrno;
        private System.Windows.Forms.ComboBox comboBox_bolumsecim;
        private System.Windows.Forms.ComboBox comboBox_sınıfsecım;
        private System.Windows.Forms.LinkLabel linkLabel_kontrolsistemi;
    }
}