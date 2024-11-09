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

namespace aracSatis
{
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=aracBilgi;Integrated Security=True";
            string mail = tbMail.Text;
            string sifre = tbSifre.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Kullanici WHERE kullaniciMail = @mail AND kullaniciPassword = @sifre";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@mail", mail);
                command.Parameters.AddWithValue("@sifre", sifre);

                connection.Open();
                object result = command.ExecuteScalar();
                int userCount = (result != null) ? Convert.ToInt32(result) : 0;

                if (userCount > 0)
                {
                  
                    string infoQuery = "SELECT kullaniciName, kullaniciPhone FROM Kullanici WHERE kullaniciMail = @mail";
                    SqlCommand infoCommand = new SqlCommand(infoQuery, connection);
                    infoCommand.Parameters.AddWithValue("@mail", mail);

                    SqlDataReader reader = infoCommand.ExecuteReader();

                    if (reader.Read())
                    {
                        
                        string kullaniciName = reader["kullaniciName"].ToString();
                        string kullaniciPhone = reader["kullaniciPhone"].ToString();

                        
                        aracSat aracSat = new aracSat();
                        aracSat.SetKullaniciBilgileri(kullaniciName, kullaniciPhone);
                        reader.Close(); 
                        aracSat.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı bilgileri alınamadı.");
                    }
                }
                else
                {
                    MessageBox.Show("Hatalı e-posta veya şifre.");
                }
            }
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            KayitEkrani kayitekrani = new KayitEkrani();
            kayitekrani.ShowDialog();
        }

        private void KullaniciGiris_Load(object sender, EventArgs e)
        {

        }
    }
    }

