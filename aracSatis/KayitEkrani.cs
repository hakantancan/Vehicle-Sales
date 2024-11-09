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
    public partial class KayitEkrani : Form
    {
        public KayitEkrani()
        {
            InitializeComponent();
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=aracBilgi;Integrated Security=True";
            string name = tbName.Text;
            string surname = tbSurname.Text;
            string phone = tbPhone.Text;
            string mail = tbMail.Text;
            string password = tbSifre.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Kullanici (kullaniciName, kullaniciSurname, kullaniciPhone, kullaniciMail, kullaniciPassword) " +
                               "VALUES (@name, @surname, @phone, @mail, @password)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@surname", surname);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@mail", mail);
                command.Parameters.AddWithValue("@password", password);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Kayıt başarılı!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt başarısız!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
    }

