
namespace veritabanıproje
{
    partial class FormKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKayıt));
            this.button_girisdon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_kayıtol = new System.Windows.Forms.Button();
            this.label_kullanıcıadı = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_girisdon
            // 
            this.button_girisdon.Location = new System.Drawing.Point(23, 393);
            this.button_girisdon.Name = "button_girisdon";
            this.button_girisdon.Size = new System.Drawing.Size(112, 41);
            this.button_girisdon.TabIndex = 0;
            this.button_girisdon.Text = "<--- Girişe Dön";
            this.button_girisdon.UseVisualStyleBackColor = true;
            this.button_girisdon.Click += new System.EventHandler(this.button_girisdon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kayıt Olma Sistemi";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(131, 146);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(100, 22);
            this.textBox_username.TabIndex = 2;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(131, 208);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(100, 22);
            this.textBox_password.TabIndex = 3;
            // 
            // button_kayıtol
            // 
            this.button_kayıtol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kayıtol.Location = new System.Drawing.Point(131, 266);
            this.button_kayıtol.Name = "button_kayıtol";
            this.button_kayıtol.Size = new System.Drawing.Size(100, 36);
            this.button_kayıtol.TabIndex = 4;
            this.button_kayıtol.Text = "Kayıt Ol";
            this.button_kayıtol.UseVisualStyleBackColor = true;
            this.button_kayıtol.Click += new System.EventHandler(this.button_kayıtol_Click);
            // 
            // label_kullanıcıadı
            // 
            this.label_kullanıcıadı.AutoSize = true;
            this.label_kullanıcıadı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.label_kullanıcıadı.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kullanıcıadı.Location = new System.Drawing.Point(30, 146);
            this.label_kullanıcıadı.Name = "label_kullanıcıadı";
            this.label_kullanıcıadı.Size = new System.Drawing.Size(92, 26);
            this.label_kullanıcıadı.TabIndex = 5;
            this.label_kullanıcıadı.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre";
            // 
            // FormKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(402, 473);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_kullanıcıadı);
            this.Controls.Add(this.button_kayıtol);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_girisdon);
            this.Name = "FormKayıt";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKayıt_FormClosed);
            this.Load += new System.EventHandler(this.FormKayıt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_girisdon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_kayıtol;
        private System.Windows.Forms.Label label_kullanıcıadı;
        private System.Windows.Forms.Label label2;
    }
}