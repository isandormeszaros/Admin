using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace admin
{
    public partial class Form1 : Form
    {
        private MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();

            string server = "localhost";
            string database = "watches";
            string uid = "root";
            string pwd = "root";

            string connectionString = $"server={server};database={database};uid={uid};pwd={pwd}";
            conn = new MySqlConnection(connectionString);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string user_password = passwordtextBox.Text;

            try
            {
                conn.Open();

                string query = "SELECT * FROM users WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", user_password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int userRole = Convert.ToInt32(reader["role"]);

                        switch (userRole)
                        {
                            case 1: // Felhasználó
                                MessageBox.Show("Sikeres bejelentkezés felhasználóként.");
                                // Ide írhatod a felhasználói felületre való navigálást
                                break;
                            case 2: // Regisztrátor
                                MessageBox.Show("Sikeres bejelentkezés regisztrátorként.");
                                // Ide írhatod a regisztrátori felületre való navigálást
                                break;
                            case 3: // Adminisztrátor
                                MessageBox.Show("Sikeres bejelentkezés adminisztrátorként.");
                                Menufrom form2 = new Menufrom();
                                form2.Show();
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
                    usernameTextBox.Clear();
                    passwordtextBox.Clear();
                    usernameTextBox.Focus();
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
            usernameTextBox.Clear();
            passwordtextBox.Clear();
        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}