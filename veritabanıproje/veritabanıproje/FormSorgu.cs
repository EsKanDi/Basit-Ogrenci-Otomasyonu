using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veritabanıproje
{
    public partial class FormSorgu : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-816Q00A\\SQLEXPRESS;Initial Catalog=projeodevi;Integrated Security=True");


        public FormSorgu()
        {
            InitializeComponent();
        }



        string id, tcno, isim, soyisim, bolum, sınıf, heskodu, ogrno;

        private void linkLabel_kontrolsistemi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormGirisKontrol frmkontrol = new FormGirisKontrol();
            frmkontrol.Show();
        }

        private void FormSorgu_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button_listele;
        }

        private void FormSorgu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        


        private void button_listele_Click(object sender, EventArgs e)
        {
            connection.Open();
            
            SqlCommand selectcommand = new SqlCommand("select * from OkulSistemi", connection);
            SqlDataReader reader = selectcommand.ExecuteReader();
            string sonuc, toplam="";
            while (reader.Read()) {
                if (reader["Bölüm"].ToString() == comboBox_bolumsecim.Text && reader["Sınıf"].ToString()==comboBox_sınıfsecım.Text || comboBox_bolumsecim.Text=="Bölüm Seçimi Yapınız" && comboBox_sınıfsecım.Text=="Sınıf Seçimi Yapınız" || reader["Bölüm"].ToString()==comboBox_bolumsecim.Text && comboBox_sınıfsecım.Text == "Sınıf Seçimi Yapınız" || comboBox_bolumsecim.Text == "Bölüm Seçimi Yapınız" && reader["Sınıf"].ToString() == comboBox_sınıfsecım.Text)
                { 
            if (checkBox_ıd.Checked)
            {
                id = reader["ÖğrenciID"].ToString();
            }
            if (checkBox_tcno.Checked)
            {
                tcno = reader["TCNo"].ToString();
            }            
            if (checkBox_isim.Checked)
            {
                isim = reader["İsim"].ToString();
            }
            if (checkBox_soyisim.Checked)
            {
                soyisim = reader["Soyisim"].ToString();
            }
            if (checkBox_ogrno.Checked)
            {
                ogrno = reader["ÖğrenciNo"].ToString();
            }
            if (checkBox_bolum.Checked)
            {
                bolum = reader["Bölüm"].ToString();
            }
            if (checkBox_sınıf.Checked)
            {
                sınıf = reader["Sınıf"].ToString();
            }
            if (checkBox_heskodu.Checked)
            {
                heskodu = reader["HesKodu"].ToString();
            }
               
            sonuc=id +" " +tcno +" " +isim +" " +soyisim +" " +ogrno +" " +bolum +" " +sınıf +" " +heskodu +"// ";
                    toplam = toplam + sonuc;
            }
            }
            MessageBox.Show(toplam);
            connection.Close();
        }

        private void button_ekledon_Click(object sender, EventArgs e)
        {
            FormEkle frmekle = new FormEkle();
            frmekle.Show();
            this.Hide();
        }
    }
}
