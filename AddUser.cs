using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace admin
{
    public partial class AddUser : Form
    {
        private MySqlConnection conn;
        private string loggedIn;

        public AddUser(MySqlConnection connection, string userId)
        {
            InitializeComponent();

            loggedIn = userId;

            conn = connection;;

            roleComboBox.Items.Add("Operátoradmin");
            roleComboBox.Items.Add("Szuperadmin");
            deleteComboBox.Items.Add("Operátoradmin");
            deleteComboBox.Items.Add("Szuperadmin");
        }


        private void addNewUser_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string userEmail = emailTextBox.Text;
            string password = passwordTextBox.Text;
            string confirmPassword = confPasswordTextBox.Text;
            string userPhone = phoneTextBox.Text;
            string userAddress = addressTextBox.Text;
            int role = roleComboBox.SelectedIndex + 1;

            //all fields filled
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(userEmail) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(userPhone) || string.IsNullOrEmpty(userAddress))
            {
                MessageBox.Show("Kérem töltse ki az összes mezőt", "Hiányzó adatok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;            }

            //email validation
            if (!IsValidEmail(userEmail))
            {
                MessageBox.Show("Kérem adjon meg egy érvényes email címet", "Érvénytelen email cím", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //pass validation
            if (password != confirmPassword)
            {
                MessageBox.Show("A jelszó és a megerősített jelszó nem egyezik meg", "Jelszó hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //pass length check
            if (!IsValidPassword(password))
            {
                MessageBox.Show("A jelszónak legalább 6 karakter hosszúnak kell lennie, és tartalmaznia kell speciális karaktereket és számot", "Érvénytelen jelszó", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //phone number validation
            if (!IsValidPhoneNumber(userPhone))
            {
                MessageBox.Show("A telefonszámnak 9 karakter hosszúnak kell lennie, és csak számokat tartalmazhat", "Érvénytelen telefonszám", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            try
            {
                conn.Open();
                string query = "INSERT INTO watches.users (name, userEmail, password, userPhone, userAddress, role) VALUES (@name, @email, SHA2(@password, 256), @phone, @userAddress, @role)";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@email", userEmail);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@phone", userPhone);
                command.Parameters.AddWithValue("@userAddress", userAddress);
                command.Parameters.AddWithValue("@role", role);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 0)
                {
                    MessageBox.Show("Sikertelen adatbázis művelet: Nem sikerült új felhasználót hozzáadni.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    nameTextBox.Text = "";
                    emailTextBox.Text = "";
                    passwordTextBox.Text = "";
                    confPasswordTextBox.Text = "";
                    phoneTextBox.Text = "";
                    addressTextBox.Text = "";
                    roleComboBox.SelectedIndex = -1;
                    MessageBox.Show("Új felhasználó sikeresen hozzáadva az adatbázishoz.", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt az adatbázishoz való hozzáadás közben: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPassword(string password)
        {
            return password.Length >= 6 && System.Text.RegularExpressions.Regex.IsMatch(password, @"[A-Za-z0-9]+") && System.Text.RegularExpressions.Regex.IsMatch(password, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return phoneNumber.Length == 9 && System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d+$");
        }

        //delete user btn
        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            string id = deleteIdTextBox.Text;

            if (id == loggedIn)
            {
                MessageBox.Show("Nem törölheti saját felhasználói fiókját.", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            DialogResult result = MessageBox.Show("Biztosan törölni szeretné ezt a felhasználót?", "Felhasználó törlése", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM watches.users WHERE id = @id";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@id", id);

                    int affectedRows = command.ExecuteNonQuery();

                    if (affectedRows == 0)
                    {
                        MessageBox.Show("Nincs ilyen felhasználó.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Felhasználó törölve.", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba történt az adatbázishoz való hozzáadás közben: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
                deleteIdTextBox.Clear();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            deletePassTextBox.UseSystemPasswordChar = true;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
        }

        private void confPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            confPasswordTextBox.UseSystemPasswordChar = true;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            string id = modifyIdTextBox.Text;
            string name = deleteNameTextBox.Text;
            string userEmail = deleteEmailTextBox.Text;
            string password = deletePassTextBox.Text;
            string userPhone = deletePhoneTextBox.Text;
            string userAddress = deleteAddressTextBox.Text;
            int role = deleteComboBox.SelectedIndex + 1;

            try
            {
                conn.Open();

                string queryOriginalData = "SELECT * FROM watches.users WHERE id = @id";
                MySqlCommand commandOriginalData = new MySqlCommand(queryOriginalData, conn);
                commandOriginalData.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = commandOriginalData.ExecuteReader();

                string originalName = "";
                string originalEmail = "";
                string originalPassword = "";
                string originalPhone = "";
                string originalAddress = "";
                int originalRole = 0;

                if (reader.Read())
                {
                    originalName = reader["name"].ToString();
                    originalEmail = reader["userEmail"].ToString();
                    originalPassword = reader["password"].ToString();
                    originalPhone = reader["userPhone"].ToString();
                    originalAddress = reader["userAddress"].ToString();
                    originalRole = Convert.ToInt32(reader["role"]);
                }
                reader.Close();

                if (name == originalName && userEmail == originalEmail && password == originalPassword &&
                    userPhone == originalPhone && userAddress == originalAddress && role == originalRole)
                {
                    MessageBox.Show("Nincs változás az adatokban.", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidUpdateEmail(userEmail))
                {
                    MessageBox.Show("Kérem adjon meg egy érvényes email címet.", "Érvénytelen email cím", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidUpdatePassword(password))
                {
                    MessageBox.Show("A jelszónak legalább 8 karakter hosszúnak kell lennie, és tartalmaznia kell speciális karaktereket és számot.", "Érvénytelen jelszó", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (userEmail != originalEmail && IsEmailExist(userEmail))
                {
                    MessageBox.Show("Az email cím már foglalt. Kérem adjon meg másik email címet.", "Foglalt email cím", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (userPhone != originalPhone && IsPhoneExist(userPhone))
                {
                    MessageBox.Show("A telefonszám már foglalt. Kérem adjon meg másik telefonszámot.", "Foglalt telefonszám", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidUpdatePhone(userPhone))
                {
                    MessageBox.Show("A telefonszámnak 9 karakter hosszúnak kell lennie, és csak számokat tartalmazhat.", "Érvénytelen telefonszám", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "UPDATE watches.users SET ";
                bool updateNull = false;

                if (!string.IsNullOrEmpty(name))
                {
                    query += "name = @name, ";
                    updateNull = true;
                }
                if (!string.IsNullOrEmpty(userEmail))
                {
                    query += "userEmail = @email, ";
                    updateNull = true;
                }
                if (!string.IsNullOrEmpty(password))
                {
                    query += "password = SHA2(@password, 256), ";
                    updateNull = true;
                }
                if (!string.IsNullOrEmpty(userPhone))
                {
                    query += "userPhone = @phone, ";
                    updateNull = true;
                }
                if (!string.IsNullOrEmpty(userAddress))
                {
                    query += "userAddress = @address, ";
                    updateNull = true;
                }
                if (role > 0)
                {
                    query += "role = @role, ";
                    updateNull = true;
                }

                if (updateNull)
                {
                    query = query.Remove(query.Length - 2);
                }
                else
                {
                    MessageBox.Show("Nincs változás az adatokban.", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                query += " WHERE id = @id";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);
                if (!string.IsNullOrEmpty(name))
                    command.Parameters.AddWithValue("@name", name);
                if (!string.IsNullOrEmpty(userEmail))
                    command.Parameters.AddWithValue("@email", userEmail);
                if (!string.IsNullOrEmpty(password))
                    command.Parameters.AddWithValue("@password", password);
                if (!string.IsNullOrEmpty(userPhone))
                    command.Parameters.AddWithValue("@phone", userPhone);
                if (!string.IsNullOrEmpty(userAddress))
                    command.Parameters.AddWithValue("@address", userAddress);
                if (role > 0)
                    command.Parameters.AddWithValue("@role", role);

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 0)
                {
                    MessageBox.Show("Sikertelen adatbázis művelet: Nincs ilyen felhasználó vagy a felhasználó adatai nem változtak.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    modifyIdTextBox.Text = "";
                    deleteNameTextBox.Text = "";
                    deleteEmailTextBox.Text = "";
                    deletePassTextBox.Text = "";
                    deletePhoneTextBox.Text = "";
                    deleteAddressTextBox.Text = "";
                    deleteComboBox.SelectedIndex = -1;
                    MessageBox.Show("Felhasználó adatai sikeresen módosítva az adatbázisban.", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt: " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        private bool IsValidUpdateEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidUpdatePassword(string password)
        {
            return password.Length >= 8 && System.Text.RegularExpressions.Regex.IsMatch(password, @"[A-Za-z0-9]+") && System.Text.RegularExpressions.Regex.IsMatch(password, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
        }

        private bool IsValidUpdatePhone(string phoneNumber)
        {
            return phoneNumber.Length == 9 && System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d+$");
        }

        private bool IsEmailExist(string email)
        {
            string query = "SELECT COUNT(*) FROM watches.users WHERE userEmail = @email";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@email", email);
            int count = Convert.ToInt32(command.ExecuteScalar());
            return count > 0;
        }

        private bool IsPhoneExist(string phone)
        {
            string query = "SELECT COUNT(*) FROM watches.users WHERE userPhone = @phone";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@phone", phone);
            int count = Convert.ToInt32(command.ExecuteScalar());
            return count > 0;
        }

        private void backToThePage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}