using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace aracSatis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAracMarka();
            LoadAracRenk();
            LoadAracYakit();
            LoadAracVites();
            LoadSehir();
            minFiyat.Minimum = 0;
            minFiyat.Maximum = 10000000; 
            maxFiyat.Minimum = 0;
            maxFiyat.Maximum = 10000000; 
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

                    
                    cbAracMarka.Items.Clear();

                    
                    while (reader.Read())
                    {
                        cbAracMarka.Items.Add(reader["AracMarka"].ToString());
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

                    
                    cbAracRenk.Items.Clear();

                    
                    while (reader.Read())
                    {
                        cbAracRenk.Items.Add(reader["renk"].ToString());
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

                   
                    cbAracYakıt.Items.Clear();

                    
                    foreach (DataRow row in table.Rows)
                    {
                        cbAracYakıt.Items.Add(row["YakıtName"].ToString());
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

                   
                    cbAracVites.Items.Clear();

                    
                    while (reader.Read())
                    {
                        cbAracVites.Items.Add(reader["vitesName"].ToString());
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


        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void aracFiltrele_Click(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=aracBilgi;Integrated Security=True";

            
            string selectedMarka = cbAracMarka.SelectedItem?.ToString();
            string selectedRenk = cbAracRenk.SelectedItem?.ToString();
            string selectedYakit = cbAracYakıt.SelectedItem?.ToString();
            string selectedVites = cbAracVites.SelectedItem?.ToString();
            string selectedSehir = cbSehir.SelectedItem?.ToString();

            
            decimal minFiyatt = minFiyat.Value; 
            decimal maxFiyatt = maxFiyat.Value; 

            
            string query = "SELECT * FROM dbo_arac WHERE 1=1";

            if (!string.IsNullOrEmpty(selectedMarka))
                query += " AND aracMarka = @aracMarka";
            if (!string.IsNullOrEmpty(selectedRenk))
                query += " AND aracRenk = @aracRenk";
            if (!string.IsNullOrEmpty(selectedYakit))
                query += " AND aracYakit = @aracYakit";
            if (!string.IsNullOrEmpty(selectedVites))
                query += " AND aracVites = @aracVites";
            if (!string.IsNullOrEmpty(selectedSehir))
                query += " AND aracSehir = @aracSehir";

            
            query += " AND aracFiyat BETWEEN @minFiyat AND @maxFiyat";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    
                    if (!string.IsNullOrEmpty(selectedMarka))
                        command.Parameters.AddWithValue("@aracMarka", selectedMarka);
                    if (!string.IsNullOrEmpty(selectedRenk))
                        command.Parameters.AddWithValue("@aracRenk", selectedRenk);
                    if (!string.IsNullOrEmpty(selectedYakit))
                        command.Parameters.AddWithValue("@aracYakit", selectedYakit);
                    if (!string.IsNullOrEmpty(selectedVites))
                        command.Parameters.AddWithValue("@aracVites", selectedVites);
                    if (!string.IsNullOrEmpty(selectedSehir))
                        command.Parameters.AddWithValue("@aracSehir", selectedSehir);

                    
                    command.Parameters.AddWithValue("@minFiyat", minFiyatt); 
                    command.Parameters.AddWithValue("@maxFiyat", maxFiyatt); 

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    
                    dgridListe.DataSource = table; 

                    
                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("Seçimlerinize uygun araç bulunamadı.");
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

