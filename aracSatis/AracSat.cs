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
    public partial class aracSat : Form
    {
        public aracSat()
        {
            InitializeComponent();
        }

        private void AracSat_Load(object sender, EventArgs e)
        {
            LoadAracMarka();
            LoadAracRenk();
            LoadAracYakit();
            LoadAracVites();
            LoadSehir();
        }

        public void SetKullaniciBilgileri(string kullaniciName, string kullaniciPhone)
        {
            lblKullanici.Text = kullaniciName;
            lblTelefon.Text = kullaniciPhone;
        }
        private void LoadAracMarka()
        {

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=aracBilgi;Integrated Security=True";


            string query = "SELECT AracMarka FROM dbo_aracMarka";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();


                    cbMarka.Items.Clear();


                    while (reader.Read())
                    {
                        cbMarka.Items.Add(reader["AracMarka"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void LoadAracRenk()
        {

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=aracBilgi;Integrated Security=True";


            string query = "SELECT renk FROM aracRenk";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();


                    cbRenk.Items.Clear();


                    while (reader.Read())
                    {
                        cbRenk.Items.Add(reader["renk"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void LoadAracYakit()
        {

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=aracBilgi;Integrated Security=True";


            string query = "SELECT YakıtName FROM dbo.Yakit";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);


                    cbYakit.Items.Clear();


                    foreach (DataRow row in table.Rows)
                    {
                        cbYakit.Items.Add(row["YakıtName"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void LoadAracVites()
        {

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=aracBilgi;Integrated Security=True";


            string query = "SELECT vitesName FROM dbo.Vites";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();


                    cbVites.Items.Clear();


                    while (reader.Read())
                    {
                        cbVites.Items.Add(reader["vitesName"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void LoadSehir()
        {

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=aracBilgi;Integrated Security=True";


            string query = "SELECT SehirName FROM dbo.Sehir";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();


                    cbSehir.Items.Clear();


                    while (reader.Read())
                    {
                        cbSehir.Items.Add(reader["SehirName"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnIlan_Click(object sender, EventArgs e)
        {
            SaveAracData();
        }


        private void SaveAracData()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=aracBilgi;Integrated Security=True";
            string query = "INSERT INTO dbo_arac (aracMarka, aracRenk, aracYakit, aracFiyat, aracVites, aracKilometre, aracSehir, aracSahibi, aracSahibiTelefon) " +
                           "VALUES (@aracMarka, @aracRenk, @aracYakit, @aracFiyat, @aracVites, @aracKilometre, @aracSehir, @aracSahibi, @aracSahibiTelefon)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    command.Parameters.AddWithValue("@aracMarka", cbMarka.SelectedItem?.ToString());
                    command.Parameters.AddWithValue("@aracRenk", cbRenk.SelectedItem?.ToString());
                    command.Parameters.AddWithValue("@aracYakit", cbYakit.SelectedItem?.ToString());
                    command.Parameters.AddWithValue("@aracFiyat", nudFiyat.Value);
                    command.Parameters.AddWithValue("@aracVites", cbVites.SelectedItem?.ToString());
                    command.Parameters.AddWithValue("@aracKilometre", nudKilometre.Value); 
                    command.Parameters.AddWithValue("@aracSehir", cbSehir.SelectedItem?.ToString());

                    
                    command.Parameters.AddWithValue("@aracSahibi", lblKullanici.Text); 
                    command.Parameters.AddWithValue("@aracSahibiTelefon", lblTelefon.Text); 

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Araç başarıyla kaydedildi.");
                    }
                    else
                    {
                        MessageBox.Show("Araç kaydedilemedi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnUstMenu_Click(object sender, EventArgs e)
        {
            Islem islem = new Islem();
            islem.ShowDialog();
        }
    }
}
