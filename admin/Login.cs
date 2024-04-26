using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace admin
{
    public partial class Login : Form
    {
        private MySqlConnection conn;
        
        public Login()
        {
            InitializeComponent();
            showPassCheck.CheckedChanged += new EventHandler(showPassCheck_CheckedChanged);

            string server = "localhost";
            string database = "watches";
            string uid = "root";
            string pwd = "root";

            string connectionString = $"server={server};database={database};uid={uid};pwd={pwd}";
            conn = new MySqlConnection(connectionString);

            passwordtextBox.UseSystemPasswordChar = true;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string user_password = passwordtextBox.Text;

            //string name = nameTextBox.Text = "Nagy Emese";
            //string user_password = passwordtextBox.Text = "user2";


            try
            {
                conn.Open();

                string query = "SELECT id, role FROM users WHERE users.name = @name AND users.password = SHA2(@password, 256);";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@password", user_password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string loggedIn;
                        int userRole = Convert.ToInt32(reader["role"]);
                        loggedIn = Convert.ToString(reader["id"]);
                        textBoxId.Text = Convert.ToString(userRole);
                        switch (userRole)
                        {
                            case 2: // Operátor admin
                                MessageBox.Show("Sikeres bejelentkezés operátor adminként.", "Sikeres bejelentkezés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Menufrom operatorAdminForm = new Menufrom(name, loggedIn, Convert.ToString(userRole));
                                operatorAdminForm.Show();
                                this.Hide();

                                 
                                break;
                            case 3: // Szuperadmin
                                MessageBox.Show("Sikeres bejelentkezés szuperadminként.", "Sikeres bejelentkezés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Menufrom superAdminForm = new Menufrom(name, loggedIn, Convert.ToString(userRole));
                                superAdminForm.Show();
                                this.Hide();
                                break;
                            default:
                                MessageBox.Show("Nincs megfelelő jogosultság.");
                                break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hibás bejelentkezési adatok", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nameTextBox.Clear();
                    passwordtextBox.Clear();
                    nameTextBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            passwordtextBox.Clear();
        }


        private void showPassCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCheck.Checked)
            {
                passwordtextBox.UseSystemPasswordChar = false;
                showPassCheck.Text = "Jelszó elrejtése";
            }
            else
            {
                passwordtextBox.UseSystemPasswordChar = true;
                showPassCheck.Text = "Jelszó mutatása";
            }
        }
    }
}