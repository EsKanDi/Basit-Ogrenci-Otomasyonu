using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace veritabanıproje
{
    public partial class FormGiris : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-816Q00A\\SQLEXPRESS;Initial Catalog=projeodevi;Integrated Security=True");

        public FormGiris()
        {
            InitializeComponent();
        }

        
        

        private void textBox_username_Enter(object sender, EventArgs e)
        {
            if(textBox_username.Text=="Kullanıcı Adı")
            {
                textBox_username.Text = "";
            }
        }

        private void textBox_username_Leave(object sender, EventArgs e)
        {
            if (textBox_username.Text == "")
            {
                textBox_username.Text = "Kullanıcı Adı";
            }
        }

        private void textBox_password_Enter(object sender, EventArgs e)
        {
            if (textBox_password.Text == "Şifre")
            {
                textBox_password.Text = "";
            }
        }

        private void textBox_password_Leave(object sender, EventArgs e)
        {
            if (textBox_password.Text == "")
            {
                textBox_password.Text = "Şifre";
            }
        }
        bool doru;
        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox_username.Text;
            String password = textBox_password.Text;
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand selectcommand = new SqlCommand("select * from GirisBilgileri", connection);
            SqlDataReader reader = selectcommand.ExecuteReader();

            while (reader.Read())
            {
                
                if (username == reader["username"].ToString() && password == reader["password"].ToString())
                {
                    doru = true;
                    break;
                }
                else
                {
                    doru = false;
                }

            }
            
            if (doru == true)
            {
                MessageBox.Show("Başarıyla Giriş Yaptınız");
                FormEkle frmekle = new FormEkle();
                frmekle.Show();
                this.Hide();
            }
            else { 
                MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre");
                reader.Close();
            }

            connection.Close();
            
        }

        private void linkLabel_kayıt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormKayıt frmkayıt = new FormKayıt();
            frmkayıt.Show();
            this.Hide();
        }

        private void FormGiris_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }
    }
}
