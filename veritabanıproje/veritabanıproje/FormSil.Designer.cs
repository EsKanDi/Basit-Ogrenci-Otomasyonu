
namespace veritabanıproje
{
    partial class FormSil
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
            this.textBox_ıd = new System.Windows.Forms.TextBox();
            this.label_ıd = new System.Windows.Forms.Label();
            this.button_eklegit = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Silme Sistemi";
            // 
            // textBox_ıd
            // 
            this.textBox_ıd.Location = new System.Drawing.Point(276, 88);
            this.textBox_ıd.Name = "textBox_ıd";
            this.textBox_ıd.Size = new System.Drawing.Size(100, 22);
            this.textBox_ıd.TabIndex = 1;
            // 
            // label_ıd
            // 
            this.label_ıd.AutoSize = true;
            this.label_ıd.Location = new System.Drawing.Point(180, 91);
            this.label_ıd.Name = "label_ıd";
            this.label_ıd.Size = new System.Drawing.Size(75, 17);
            this.label_ıd.TabIndex = 2;
            this.label_ıd.Text = "Öğrenci ID";
            // 
            // button_eklegit
            // 
            this.button_eklegit.Location = new System.Drawing.Point(12, 173);
            this.button_eklegit.Name = "button_eklegit";
            this.button_eklegit.Size = new System.Drawing.Size(201, 49);
            this.button_eklegit.TabIndex = 3;
            this.button_eklegit.Text = "<--- Ekleme Sistemine Dön";
            this.button_eklegit.UseVisualStyleBackColor = true;
            this.button_eklegit.Click += new System.EventHandler(this.button_eklegit_Click);
            // 
            // button_sil
            // 
            this.button_sil.Location = new System.Drawing.Point(259, 136);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(121, 45);
            this.button_sil.TabIndex = 4;
            this.button_sil.Text = "Öğrenciyi Sil";
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // FormSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 234);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.button_eklegit);
            this.Controls.Add(this.label_ıd);
            this.Controls.Add(this.textBox_ıd);
            this.Controls.Add(this.label1);
            this.Name = "FormSil";
            this.Text = "FormSil";
            this.Load += new System.EventHandler(this.FormSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ıd;
        private System.Windows.Forms.Label label_ıd;
        private System.Windows.Forms.Button button_eklegit;
        private System.Windows.Forms.Button button_sil;
    }
}