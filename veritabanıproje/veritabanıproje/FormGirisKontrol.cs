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
    public partial class FormGirisKontrol : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-816Q00A\\SQLEXPRESS;Initial Catalog=projeodevi;Integrated Security=True;MultipleActiveResultSets=True");
        public FormGirisKontrol()
        {
            InitializeComponent();
        }

        private void FormGirisKontrol_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button_kontrolet;
        }

        private void button_ekledon_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_kontrolet_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand saglıkreader = new SqlCommand("select * from SağlıkBakanlığı", connection);
            SqlCommand rektorreader = new SqlCommand("select * from Rektörlük", connection);
            SqlCommand okulreader = new SqlCommand("select * from OkulSistemi", connection);
            SqlCommand kimlikreader = new SqlCommand("select * from Kimlik", connection);
            SqlDataReader sglkrdr = saglıkreader.ExecuteReader();
            SqlDataReader okulrdr = okulreader.ExecuteReader();
            SqlDataReader rktrrdr = rektorreader.ExecuteReader();
            string tcno = "", ogrno = "", sonuc = "";


            while (okulrdr.Read())
            {
                if (textBox_ıd.Text == okulrdr["ÖğrenciID"].ToString())
                {
                    tcno = okulrdr["TCNo"].ToString();
                    ogrno = okulrdr["ÖğrenciNo"].ToString();

                    while (sglkrdr.Read())
                    {
                        if (sglkrdr["TCNo"].ToString() == tcno)
                        {
                            if (sglkrdr["Riskli"].ToString() == "True")
                            {
                                sonuc = "Riskli";
                            }
                            else
                            {
                                sonuc = "Risksiz";
                            }
                        }

                    }
                    sglkrdr.Close();

                    while (rktrrdr.Read())
                    {
                        if (rktrrdr["ÖğrenciNo"].ToString() == ogrno)
                        {
                            if (rktrrdr["UzaklaştırmaVarMı"].ToString() == "True")
                            {
                                sonuc = sonuc + " Ve Disiplin Cezazı Bulunmaktadır";
                            }
                            else
                            {
                                sonuc = sonuc + " Ve Disiplin Cezası Bulunmamaktadır";
                            }
                        }

                    }
                    rktrrdr.Close();
                }
            }
            MessageBox.Show(sonuc);
            connection.Close();
        }
    }
}