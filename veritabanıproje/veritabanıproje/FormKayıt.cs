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
    public partial class FormKayıt : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-816Q00A\\SQLEXPRESS; Initial Catalog = projeodevi; Integrated Security = TRUE");

        public FormKayıt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGiris frmgiris = new FormGiris();
            frmgiris.Show();
            this.Hide();
        }


        private void button_kayıtol_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            String kayit = "insert into GirisBilgileri (username,password) values(@username,@password)";
            SqlCommand insertcommand = new SqlCommand(kayit, connection);
            SqlCommand selectcommand = new SqlCommand("select username from GirisBilgileri", connection);
            SqlDataReader usernamereader = selectcommand.ExecuteReader();

            while (usernamereader.Read())
            {
                string username = usernamereader["username"].ToString();
                usernamereader.Close();
                if (textBox_username.Text != username)
                {
                    insertcommand.Parameters.AddWithValue("@username", textBox_username.Text);
                    insertcommand.Parameters.AddWithValue("@password", textBox_password.Text);
                    insertcommand.ExecuteNonQuery();
                    MessageBox.Show("Başarıyla Kaydınız Yapıldı");
                    break;
                    
                }
                else
                {
                    MessageBox.Show("Bu Kullanıcı Adı Daha Önceden Kullanılmıştır");
                    break;
                }


            }

        }

        private void button_girisdon_Click(object sender, EventArgs e)
        {
            FormGiris frmgrs = new FormGiris();
            frmgrs.Show();
            this.Hide();
        }

        private void FormKayıt_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormKayıt_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button_kayıtol;
        }
    }
}

