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
    public partial class FormSil : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-816Q00A\\SQLEXPRESS;Initial Catalog=projeodevi;Integrated Security=True");
        public FormSil()
        {
            InitializeComponent();
        }



        private void FormSil_Load(object sender, EventArgs e)
        {
            label1.Size = new Size(230, 40);
            this.AcceptButton = button_sil;
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand deletecommand = new SqlCommand("delete from OkulSistemi where ÖğrenciID=" + textBox_ıd.Text.ToString(),connection);
            SqlCommand readercommand = new SqlCommand("Select ÖğrenciId from OkulSistemi", connection);
            SqlDataReader reader = readercommand.ExecuteReader();

            while (reader.Read()){
                if (textBox_ıd.Text == reader["ÖğrenciID"].ToString())
                {
                    deletecommand.ExecuteNonQuery();
                    MessageBox.Show("Öğrenci Başarıyla Silindi");
                    break;
                }
            }
            connection.Close();
        }

        private void button_eklegit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
