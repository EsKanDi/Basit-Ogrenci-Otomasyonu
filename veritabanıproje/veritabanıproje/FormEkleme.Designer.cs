
namespace veritabanıproje
{
    partial class FormEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEkle));
            this.button_ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ıd = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_tcno = new System.Windows.Forms.Label();
            this.label_ögrencino = new System.Windows.Forms.Label();
            this.label_heskodu = new System.Windows.Forms.Label();
            this.label_isim = new System.Windows.Forms.Label();
            this.label_soyisim = new System.Windows.Forms.Label();
            this.label_bölüm = new System.Windows.Forms.Label();
            this.label_sınıf = new System.Windows.Forms.Label();
            this.textBox_tcno = new System.Windows.Forms.TextBox();
            this.textBox_ogrno = new System.Windows.Forms.TextBox();
            this.textBox_heskod = new System.Windows.Forms.TextBox();
            this.textBox_isim = new System.Windows.Forms.TextBox();
            this.textBox_soyisim = new System.Windows.Forms.TextBox();
            this.textBox_bolum = new System.Windows.Forms.TextBox();
            this.textBox_sınıf = new System.Windows.Forms.TextBox();
            this.button_girisdon = new System.Windows.Forms.Button();
            this.button_sorgugit = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button_ekle
            // 
            this.button_ekle.Location = new System.Drawing.Point(294, 399);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(165, 42);
            this.button_ekle.TabIndex = 0;
            this.button_ekle.Text = "Öğrenci Ekle";
            this.button_ekle.UseVisualStyleBackColor = false;
            this.button_ekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(211)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(312, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci Ekleme Sistemi      ";
            // 
            // textBox_ıd
            // 
            this.textBox_ıd.Location = new System.Drawing.Point(180, 132);
            this.textBox_ıd.Name = "textBox_ıd";
            this.textBox_ıd.Size = new System.Drawing.Size(100, 22);
            this.textBox_ıd.TabIndex = 2;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(107)))), ((int)(((byte)(106)))));
            this.label_id.Location = new System.Drawing.Point(93, 137);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(73, 17);
            this.label_id.TabIndex = 3;
            this.label_id.Text = "Öğrenci Id";
            // 
            // label_tcno
            // 
            this.label_tcno.AutoSize = true;
            this.label_tcno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(107)))), ((int)(((byte)(106)))));
            this.label_tcno.Location = new System.Drawing.Point(84, 199);
            this.label_tcno.Name = "label_tcno";
            this.label_tcno.Size = new System.Drawing.Size(90, 17);
            this.label_tcno.TabIndex = 4;
            this.label_tcno.Text = "TC Numarası";
            // 
            // label_ögrencino
            // 
            this.label_ögrencino.AutoSize = true;
            this.label_ögrencino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(107)))), ((int)(((byte)(106)))));
            this.label_ögrencino.Location = new System.Drawing.Point(86, 253);
            this.label_ögrencino.Name = "label_ögrencino";
            this.label_ögrencino.Size = new System.Drawing.Size(80, 17);
            this.label_ögrencino.TabIndex = 5;
            this.label_ögrencino.Text = "Öğrenci No";
            // 
            // label_heskodu
            // 
            this.label_heskodu.AutoSize = true;
            this.label_heskodu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(107)))), ((int)(((byte)(106)))));
            this.label_heskodu.Location = new System.Drawing.Point(93, 314);
            this.label_heskodu.Name = "label_heskodu";
            this.label_heskodu.Size = new System.Drawing.Size(70, 17);
            this.label_heskodu.TabIndex = 6;
            this.label_heskodu.Text = "Hes Kodu";
            // 
            // label_isim
            // 
            this.label_isim.AutoSize = true;
            this.label_isim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(107)))), ((int)(((byte)(106)))));
            this.label_isim.Location = new System.Drawing.Point(461, 137);
            this.label_isim.Name = "label_isim";
            this.label_isim.Size = new System.Drawing.Size(32, 17);
            this.label_isim.TabIndex = 7;
            this.label_isim.Tag = "";
            this.label_isim.Text = "İsim";
            // 
            // label_soyisim
            // 
            this.label_soyisim.AutoSize = true;
            this.label_soyisim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(107)))), ((int)(((byte)(106)))));
            this.label_soyisim.Location = new System.Drawing.Point(461, 199);
            this.label_soyisim.Name = "label_soyisim";
            this.label_soyisim.Size = new System.Drawing.Size(56, 17);
            this.label_soyisim.TabIndex = 8;
            this.label_soyisim.Text = "Soyisim";
            // 
            // label_bölüm
            // 
            this.label_bölüm.AutoSize = true;
            this.label_bölüm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(107)))), ((int)(((byte)(106)))));
            this.label_bölüm.Location = new System.Drawing.Point(461, 250);
            this.label_bölüm.Name = "label_bölüm";
            this.label_bölüm.Size = new System.Drawing.Size(47, 17);
            this.label_bölüm.TabIndex = 9;
            this.label_bölüm.Text = "Bölüm";
            // 
            // label_sınıf
            // 
            this.label_sınıf.AutoSize = true;
            this.label_sınıf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(107)))), ((int)(((byte)(106)))));
            this.label_sınıf.Location = new System.Drawing.Point(461, 309);
            this.label_sınıf.Name = "label_sınıf";
            this.label_sınıf.Size = new System.Drawing.Size(35, 17);
            this.label_sınıf.TabIndex = 10;
            this.label_sınıf.Text = "Sınıf";
            // 
            // textBox_tcno
            // 
            this.textBox_tcno.Location = new System.Drawing.Point(180, 194);
            this.textBox_tcno.Name = "textBox_tcno";
            this.textBox_tcno.Size = new System.Drawing.Size(100, 22);
            this.textBox_tcno.TabIndex = 11;
            // 
            // textBox_ogrno
            // 
            this.textBox_ogrno.Location = new System.Drawing.Point(180, 250);
            this.textBox_ogrno.Name = "textBox_ogrno";
            this.textBox_ogrno.Size = new System.Drawing.Size(100, 22);
            this.textBox_ogrno.TabIndex = 12;
            // 
            // textBox_heskod
            // 
            this.textBox_heskod.Location = new System.Drawing.Point(180, 309);
            this.textBox_heskod.Name = "textBox_heskod";
            this.textBox_heskod.Size = new System.Drawing.Size(100, 22);
            this.textBox_heskod.TabIndex = 13;
            // 
            // textBox_isim
            // 
            this.textBox_isim.Location = new System.Drawing.Point(543, 134);
            this.textBox_isim.Name = "textBox_isim";
            this.textBox_isim.Size = new System.Drawing.Size(100, 22);
            this.textBox_isim.TabIndex = 14;
            // 
            // textBox_soyisim
            // 
            this.textBox_soyisim.Location = new System.Drawing.Point(543, 194);
            this.textBox_soyisim.Name = "textBox_soyisim";
            this.textBox_soyisim.Size = new System.Drawing.Size(100, 22);
            this.textBox_soyisim.TabIndex = 15;
            // 
            // textBox_bolum
            // 
            this.textBox_bolum.Location = new System.Drawing.Point(543, 245);
            this.textBox_bolum.Name = "textBox_bolum";
            this.textBox_bolum.Size = new System.Drawing.Size(100, 22);
            this.textBox_bolum.TabIndex = 16;
            // 
            // textBox_sınıf
            // 
            this.textBox_sınıf.Location = new System.Drawing.Point(543, 304);
            this.textBox_sınıf.Name = "textBox_sınıf";
            this.textBox_sınıf.Size = new System.Drawing.Size(100, 22);
            this.textBox_sınıf.TabIndex = 17;
            // 
            // button_girisdon
            // 
            this.button_girisdon.Location = new System.Drawing.Point(39, 400);
            this.button_girisdon.Name = "button_girisdon";
            this.button_girisdon.Size = new System.Drawing.Size(176, 42);
            this.button_girisdon.TabIndex = 18;
            this.button_girisdon.Text = "<--- Girişe Dön";
            this.button_girisdon.UseVisualStyleBackColor = true;
            this.button_girisdon.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button_sorgugit
            // 
            this.button_sorgugit.Location = new System.Drawing.Point(516, 400);
            this.button_sorgugit.Name = "button_sorgugit";
            this.button_sorgugit.Size = new System.Drawing.Size(176, 41);
            this.button_sorgugit.TabIndex = 19;
            this.button_sorgugit.Text = "Öğrenci Sorgusu --->";
            this.button_sorgugit.UseVisualStyleBackColor = true;
            this.button_sorgugit.Click += new System.EventHandler(this.button_sorgugit_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(314, 344);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(145, 17);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Öğrenci Silme Sistemi";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(812, 483);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button_sorgugit);
            this.Controls.Add(this.button_girisdon);
            this.Controls.Add(this.textBox_sınıf);
            this.Controls.Add(this.textBox_bolum);
            this.Controls.Add(this.textBox_soyisim);
            this.Controls.Add(this.textBox_isim);
            this.Controls.Add(this.textBox_heskod);
            this.Controls.Add(this.textBox_ogrno);
            this.Controls.Add(this.textBox_tcno);
            this.Controls.Add(this.label_sınıf);
            this.Controls.Add(this.label_bölüm);
            this.Controls.Add(this.label_soyisim);
            this.Controls.Add(this.label_isim);
            this.Controls.Add(this.label_heskodu);
            this.Controls.Add(this.label_ögrencino);
            this.Controls.Add(this.label_tcno);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.textBox_ıd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_ekle);
            this.Name = "FormEkle";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEkle_FormClosed);
            this.Load += new System.EventHandler(this.FormEkle_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ıd;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_tcno;
        private System.Windows.Forms.Label label_ögrencino;
        private System.Windows.Forms.Label label_heskodu;
        private System.Windows.Forms.Label label_isim;
        private System.Windows.Forms.Label label_soyisim;
        private System.Windows.Forms.Label label_bölüm;
        private System.Windows.Forms.Label label_sınıf;
        private System.Windows.Forms.TextBox textBox_tcno;
        private System.Windows.Forms.TextBox textBox_ogrno;
        private System.Windows.Forms.TextBox textBox_heskod;
        private System.Windows.Forms.TextBox textBox_isim;
        private System.Windows.Forms.TextBox textBox_soyisim;
        private System.Windows.Forms.TextBox textBox_bolum;
        private System.Windows.Forms.TextBox textBox_sınıf;
        private System.Windows.Forms.Button button_girisdon;
        private System.Windows.Forms.Button button_sorgugit;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

