using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace admin
{
    public partial class Menufrom : Form
    {
        private MySqlConnection conn;
        private string name;
        private string id;
        private string role;
        private string tablesName = "";

        public Menufrom(string name, string loggedIn, string userRole)
        {
            InitializeComponent();
            // label name
            this.name = name;
            id = loggedIn;
            role = userRole;

            //database conn
            string server = "localhost";
            string database = "watches";
            string uid = "root";
            string pwd = "root";

            string connectionString = $"server={server};database={database};uid={uid};pwd={pwd}";
            conn = new MySqlConnection(connectionString);

            //searchbox default value
            searchTextBox.GotFocus += searchTextBox_GotFocus;
            searchTextBox.LostFocus += searchTextBox_LostFocus;
            searchTextBox.Text = "Keresés a termék neve alapján...";

            //load Combos
            LoadComboBoxData();
        }

        //-----------------------------------------------------------------------//
        //welcome label 
        private void Menufrom_Load(object sender, EventArgs e)
        {
            
            watchesFill();
            welcomeLbl.Text = $"Üdvözöljük, {name}!";
            textBoxId.Text = role;

            if(role == "2")
            {
                usersManagementBtn.Visible = false;
                orderDeleteBtn.Visible = false;
                deleteOrderIdTextBox.Visible = false;
            }
        }

        //import watches
        private void watchesFill()
        {
            try
            {
                conn.Open();
                tablesName = "watches.base";
                MySqlCommand command = new MySqlCommand($"SELECT * FROM watches.alltablesview;", conn);
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

        //import orders 
        private void ordersFill()
        {
            try
            {
                conn.Open();
                tablesName = "watches.orders";
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

        //import users
        private void usersFill()
        {
            try
            {
                conn.Open();
                tablesName = "watches.users";
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

        //render watches onclick
        private void watchesBtn_Click(object sender, EventArgs e)
        {
            searchTextBox.Visible = true;
            searchBtn.Visible = true;
            addNewUser.Visible = false;
            deleteOrderIdTextBox.Visible = false;
            orderDeleteBtn.Visible = false;
            panel2.Visible = true;
            watchesFill();
        }

        //render orders onclick
        private void ordersBtn_Click(object sender, EventArgs e)
        {
            ordersFill();
            searchTextBox.Visible = false;
            searchBtn.Visible = false;
            addNewUser.Visible = false;
            deleteOrderIdTextBox.Visible = true;
            orderDeleteBtn.Visible = true;
            panel2.Visible = false;
        }

        //render users onclick
        private void usersManagementBtn_Click(object sender, EventArgs e)
        {
            usersFill();
            searchTextBox.Visible = false;
            searchBtn.Visible = false;
            addNewUser.Visible = true;
            deleteOrderIdTextBox.Visible = false;
            orderDeleteBtn.Visible = false;
        }

        //-----------------------------------------------------------------------//
        //search in datagridview function
        private void SearchInDataGridView()
        {
            DataTable dataTable = dataGridView1.DataSource as DataTable;
            if (dataTable != null)
            {
                string searchTerm = searchTextBox.Text;
                string filterExpression = $"watchName LIKE '%{searchTerm.ToLower()}%' OR watchName LIKE '%{searchTerm.ToUpper()}%'";
                dataTable.DefaultView.RowFilter = filterExpression;

                if (dataTable.DefaultView.Count == 0)
                {
                    noResultsLbl.Visible = true;
                    noResultsLbl.Text = "Nincs találat.";
                }
                else
                {
                    noResultsLbl.Visible = false;
                }
            }
        }

        //set default text 
        private void searchTextBox_GotFocus(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Keresés a termék neve alapján...")
            {
                searchTextBox.Text = "";
                searchTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        //remove default text
        private void searchTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                searchTextBox.Text = "Keresés a termék neve alapján...";
                searchTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        //searn onclick
        private void searchBtn_Click_1(object sender, EventArgs e)
        {
            SearchInDataGridView();
        }
        //-----------------------------------------------------------------------//

        private void LoadComboBoxData()
        {
            try
            {
                conn.Open();

                AddCommboBox("SELECT material FROM dialmaterial", dialMaterialComboBox);
                AddCommboBox("SELECT diameter FROM casediameter", caseDiameterComboBox);
                AddCommboBox("SELECT thickness FROM casethickness", caseThicknessComboBox);
                AddCommboBox("SELECT material FROM strapmaterial", strapMaterialComboBox);
                AddCommboBox("SELECT bandWidth FROM bandwidth", bandWidthComboBox);
                AddCommboBox("SELECT color FROM dialcolor", dialComboBox);
                AddCommboBox("SELECT material FROM casematerial", caseMaterialComboBox);
                AddCommboBox("SELECT date FROM date", dateComboBox);
                AddCommboBox("SELECT movement FROM movement", movementComboBox);
                boxComboBox.Items.Add("Van");
                boxComboBox.Items.Add("Nincs");
                paperComboBox.Items.Add("Van");
                paperComboBox.Items.Add("Nincs");


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


        private void AddCommboBox(string query, ComboBox comboBox)
        {
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader[0]);
                    }
                }
            }
        }

        // filterBtn_Click_1 method
        private void filterBtn_Click_1(object sender, EventArgs e)
        {
            // Check if any of the combo boxes have a selected item
            if (dialMaterialComboBox.SelectedItem != null || caseMaterialComboBox.SelectedItem != null || bandWidthComboBox.SelectedItem != null || dialComboBox.SelectedItem != null || caseMaterialComboBox.SelectedItem != null 
                || dateComboBox.SelectedItem != null || movementComboBox.SelectedItem != null || boxComboBox.SelectedItem != null || paperComboBox.SelectedItem != null )
            {
                FilterDataGridView();
            }
            else
            {
                MessageBox.Show("Kérem, válasszon ki legalább egy értéket a szűréshez.", "Hiányzó érték", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // FilterDataGridView method
        private void FilterDataGridView()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM watches.alltablesview WHERE 1=1"; // Base SQL query

                if (dialMaterialComboBox.SelectedItem != null)
                {
                    query += " AND dialMaterial = @dialMaterial";
                }
                if (caseMaterialComboBox.SelectedItem != null)
                {
                    query += " AND caseMaterial = @caseMaterial";
                }
                if (bandWidthComboBox.SelectedItem != null)
                {
                    query += " AND bandWidth = @bandWidth";
                }
                if (dialComboBox.SelectedItem != null)
                {
                    query += " AND dialColor = @dialColor";
                }
                if (caseMaterialComboBox.SelectedItem != null)
                {
                    query += " AND caseMaterial = @caseMaterial";
                }
                if (dateComboBox.SelectedItem != null)
                {
                    query += " AND date = @date";
                }
                if (movementComboBox.SelectedItem != null)
                {
                    query += " AND movement = @movement";
                }

                if (boxComboBox.SelectedItem != null)
                {
                    if (boxComboBox.SelectedItem.ToString() == "Van")
                    {
                        query += " AND box = 1";
                    }
                    else if (boxComboBox.SelectedItem.ToString() == "Nincs")
                    {
                        query += " AND box = 0";
                    }
                }

                if (paperComboBox.SelectedItem != null)
                {
                    if (paperComboBox.SelectedItem.ToString() == "Van")
                    {
                        query += " AND paper = 1";
                    }
                    else if (paperComboBox.SelectedItem.ToString() == "Nincs")
                    {
                        query += " AND paper = 0";
                    }
                }


                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@dialMaterial", dialMaterialComboBox.SelectedItem);
                command.Parameters.AddWithValue("@caseMaterial", caseMaterialComboBox.SelectedItem);
                command.Parameters.AddWithValue("@bandWidth", bandWidthComboBox.SelectedItem);
                command.Parameters.AddWithValue("@dialColor", dialComboBox.SelectedItem);
                command.Parameters.AddWithValue("@date", dateComboBox.SelectedItem);
                command.Parameters.AddWithValue("@movement", movementComboBox.SelectedItem);
                command.Parameters.AddWithValue("@box", boxComboBox.SelectedItem);
                command.Parameters.AddWithValue("@paper", paperComboBox.SelectedItem);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt a szűrés során: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        //strip
        private void felhasználókToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form1 = new Login();
            form1.Show();
            this.Hide();
        }

        //logout
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztosan ki szeretne jelentkezni?", "Kijelentkezés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Bezárjuk az aktuális ablakot
                this.Close();

                // Megjelenítjük a bejelentkező ablakot
                Login loginForm = new Login();
                loginForm.Show();
            }
        }

        private void kapcsolatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string emailAddress = "example@gmail.com"; 
            string fullName = "Mészáros Sándor"; 

            string subject = "Kapcsolatfelvétel"; 
            string body = $"Kedves {fullName},\n\n"; 

            string mailtoLink = $"mailto:{emailAddress}?subject={subject}&body={body}";

            Process.Start(mailtoLink);
        }

        private AlapadatokForm alapadatokForm = null;

        private void alapadatokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ellenőrizd, hogy az alapadatokForm már meg van-e nyitva
            if (alapadatokForm == null || alapadatokForm.IsDisposed)
            {
                alapadatokForm = new AlapadatokForm(conn);
                alapadatokForm.Show();
            }
            else
            {
                // Ha már meg van nyitva, akkor csak az ablakot hozd elő
                alapadatokForm.BringToFront();
            }
        }

        private void clearFilterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM watches.alltablesview"; // Alap SQL lekérdezés

                // Töröld a szűrőfeltételeket itt

                MySqlCommand command = new MySqlCommand(query, conn);
                // Add parameters for other filters

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt a szűrési feltételek törlésekor: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void addNewUser_Click(object sender, EventArgs e)
        {

            AddUser newUserForm = new AddUser(conn, id);
            newUserForm.Show();
            this.Close();
        }

        private void elérhetőségToolStripMenuItem_Click(object sender, EventArgs e)
        {
            elérhetőségToolStripMenuItem.Width = 3000; 
            string[] contactData = new string[6];
            contactData[0] = "Név:";
            contactData[1] = "Mészáros Sándor";
            contactData[2] = "Tel:";
            contactData[3] = "06 30 123 4567";
            contactData[4] = "Email:";
            contactData[5] = "devsupport@thepillar.com";

            contactNameText.Text = contactData[0] + " " + contactData[1];
            contactTelText.Text = contactData[2] + " " + contactData[3];
            contactEmailText.Text = contactData[4] + " " + contactData[5];
        }

        private void orderDeleteBtn_Click(object sender, EventArgs e)
        {
            string orderIdToDelete = deleteOrderIdTextBox.Text;

            // Check if the order ID is provided
            if (string.IsNullOrEmpty(orderIdToDelete))
            {
                MessageBox.Show("Kérem adjon meg egy megrendelés azonosítót!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmation popup for deletion
            DialogResult result = MessageBox.Show("Biztosan törölni szeretné ezt a megrendelést?", "Megrendelés törlése", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM watches.orders WHERE id = @orderId";
                    MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, conn);
                    deleteCommand.Parameters.AddWithValue("@orderId", orderIdToDelete);

                    int rowsAffected = deleteCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("A megrendelés sikeresen törölve lett.", "Sikeres törlés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        deleteOrderIdTextBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Nincs olyan megrendelés az adatbázisban ezzel az azonosítóval.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba történt a megrendelés törlése közben: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}