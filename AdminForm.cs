using System;
using System.Data;
using System.Windows.Forms;
using Dapper;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class AdminForm : Form
    {
        private readonly string connectionString = "Server=localhost;Database=academicsystem;User ID=root;Password=;";

        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    string sql = "INSERT INTO Users (first_name, last_name, username, password, role) VALUES (@FirstName, @LastName, @Username, @Password, @Role)";
                    var parameters = new
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Username = txtFirstName.Text, // Automatically assigns first name as username
                        Password = txtLastName.Text, // Automatically assigns last name as password
                        Role = cmbRole.Text
                    };
                    connection.Execute(sql, parameters);
                    MessageBox.Show("User created successfully!");
                }
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void LoadUsers()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM Users";
                    var users = connection.Query(sql);
                    dgvUsers.DataSource = users;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}");
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    string sql = "DELETE FROM Users WHERE Username = @Username";
                    var parameters = new { Username = txtUsername.Text };
                    connection.Execute(sql, parameters);
                    MessageBox.Show("User deleted successfully!");
                }
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }
    }
}
