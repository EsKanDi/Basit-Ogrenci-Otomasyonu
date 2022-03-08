
namespace veritabanıproje
{
    partial class FormGirisKontrol
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
            this.button_kontrolet = new System.Windows.Forms.Button();
            this.button_ekledon = new System.Windows.Forms.Button();
            this.textBox_ıd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Giriş İzni Kontrol Sistemi";
            // 
            // button_kontrolet
            // 
            this.button_kontrolet.Location = new System.Drawing.Point(365, 135);
            this.button_kontrolet.Name = "button_kontrolet";
            this.button_kontrolet.Size = new System.Drawing.Size(165, 39);
            this.button_kontrolet.TabIndex = 1;
            this.button_kontrolet.Text = "Öğrenciyi Kontrol Et";
            this.button_kontrolet.UseVisualStyleBackColor = true;
            this.button_kontrolet.Click += new System.EventHandler(this.button_kontrolet_Click);
            // 
            // button_ekledon
            // 
            this.button_ekledon.Location = new System.Drawing.Point(47, 135);
            this.button_ekledon.Name = "button_ekledon";
            this.button_ekledon.Size = new System.Drawing.Size(191, 39);
            this.button_ekledon.TabIndex = 2;
            this.button_ekledon.Text = "<---- Ekleme Sistemine Dön";
            this.button_ekledon.UseVisualStyleBackColor = true;
            this.button_ekledon.Click += new System.EventHandler(this.button_ekledon_Click);
            // 
            // textBox_ıd
            // 
            this.textBox_ıd.Location = new System.Drawing.Point(243, 83);
            this.textBox_ıd.Name = "textBox_ıd";
            this.textBox_ıd.Size = new System.Drawing.Size(100, 22);
            this.textBox_ıd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Öğrenci ID";
            // 
            // FormGirisKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 229);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ıd);
            this.Controls.Add(this.button_ekledon);
            this.Controls.Add(this.button_kontrolet);
            this.Controls.Add(this.label1);
            this.Name = "FormGirisKontrol";
            this.Text = "FormGirisKontrol";
            this.Load += new System.EventHandler(this.FormGirisKontrol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_kontrolet;
        private System.Windows.Forms.Button button_ekledon;
        private System.Windows.Forms.TextBox textBox_ıd;
        private System.Windows.Forms.Label label2;
    }
}