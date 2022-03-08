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
    public partial class FormEkle : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-816Q00A\\SQLEXPRESS;Initial Catalog=projeodevi;Integrated Security=True");

        public FormEkle()
        {
            InitializeComponent();
            
        }

        private void FormEkle_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConnectionState.Closed == connection.State)
                    connection.Open();
                String kayit = "insert into OkulSistemi (ÖğrenciID,TCNo,İsim,Soyisim,ÖğrenciNo,Bölüm,Sınıf,Heskodu) values(@ıd,@tcno,@isim,@soyisim,@no,@bolum,@sınıf,@heskod)";
                SqlCommand insertcommand = new SqlCommand(kayit, connection);

                insertcommand.Parameters.AddWithValue("@ıd", textBox_ıd.Text);
                insertcommand.Parameters.AddWithValue("@tcno", textBox_tcno.Text);
                insertcommand.Parameters.AddWithValue("@isim", textBox_isim.Text);
                insertcommand.Parameters.AddWithValue("@soyisim", textBox_soyisim.Text);
                insertcommand.Parameters.AddWithValue("@no", textBox_ogrno.Text);
                insertcommand.Parameters.AddWithValue("@bolum", textBox_bolum.Text);
                insertcommand.Parameters.AddWithValue("@sınıf", textBox_sınıf.Text);
                insertcommand.Parameters.AddWithValue("@heskod", textBox_heskod.Text);

                insertcommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Öğrenci Eklendi");

            }
            catch(Exception hata)
            {
                MessageBox.Show("Hata Meydana Geldi" + hata.Message);
            }
    }

        FormGiris frmgrs = new FormGiris();
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            frmgrs.Show();
            this.Hide();
        }

        private void button_sorgugit_Click(object sender, EventArgs e)
        {
            FormSorgu frmsorgu = new FormSorgu();
            frmsorgu.Show();
            this.Hide();
        }

        private void FormEkle_Load_1(object sender, EventArgs e)
        {
            linkLabel1.Size = new Size(160, 25);
            this.AcceptButton = button_ekle;
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSil frsil = new FormSil();
            frsil.Show();
        }

        private void FormEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
