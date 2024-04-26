using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace admin
{
    public partial class AlapadatokForm : Form
    {
        private MySqlConnection conn;
        private string tablesName = "";

        public AlapadatokForm(MySqlConnection connection)
        {
            InitializeComponent();
            conn = connection;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM watches.allbrandsview";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable; // Load data into dataGridView1
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt az adatok betöltésekor: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        private void AlapadatokForm_Load(object sender, EventArgs e)
        {
            // This method might contain any initialization logic you need when the form is loaded.
            // For example, you can call the LoadData method here.
        }

        private void backToThePage_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void brandBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                tablesName = "watches.allbrandsview";
                MySqlCommand command = new MySqlCommand($"SELECT * FROM {tablesName};", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void caseDiameterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                tablesName = "watches.casediameter";
                MySqlCommand command = new MySqlCommand($"SELECT * FROM {tablesName};", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void caseMaterialBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                tablesName = "watches.allcasematerialcount";
                MySqlCommand command = new MySqlCommand($"SELECT * FROM {tablesName};", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void caseThicknessBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                tablesName = "watches.casethickness";
                MySqlCommand command = new MySqlCommand($"SELECT * FROM {tablesName};", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                tablesName = "watches.alldatescount";
                MySqlCommand command = new MySqlCommand($"SELECT * FROM {tablesName};", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dialColorBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                tablesName = "watches.alldialcolorscount";
                MySqlCommand command = new MySqlCommand($"SELECT * FROM {tablesName};", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dialMaterialBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                tablesName = "watches.alldialmaterialcount";
                MySqlCommand command = new MySqlCommand($"SELECT * FROM {tablesName};", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void movementBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                tablesName = "watches.allmovementscount";
                MySqlCommand command = new MySqlCommand($"SELECT * FROM {tablesName};", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void strapMaterialBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                tablesName = "watches.allstrapmaterialcount";
                MySqlCommand command = new MySqlCommand($"SELECT * FROM {tablesName};", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void bandWidthBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                tablesName = "watches.allbandwidthscount";
                MySqlCommand command = new MySqlCommand($"SELECT * FROM {tablesName};", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void waterResistanceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                tablesName = "watches.allwaterresistancescount";
                MySqlCommand command = new MySqlCommand($"SELECT * FROM {tablesName};", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void rolesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                tablesName = "watches.roles";
                MySqlCommand command = new MySqlCommand($"SELECT * FROM {tablesName};", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
