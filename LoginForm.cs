using System;
using System.Data;
using System.Windows.Forms;
using Dapper;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {


        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Query to check the user in the database and get their role
            string query = "SELECT role FROM Users WHERE username = @Username AND password = @Password";

            using (MySqlConnection connection = new MySqlConnection(Constants.CONNECTIONSTRING))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read(); // Move to the first record
                        string userRole = reader["role"].ToString(); // Get the role from the database

                        // Check user role and show the appropriate form
                        this.Hide(); // Hide the login form

                        if (userRole == "admin")
                        {
                            AdminForm adminForm = new AdminForm();
                            adminForm.Show(); // Show admin form
                        }
                        else if (userRole == "teacher")
                        {
                            TeacherForm teacherForm = new TeacherForm();
                            teacherForm.Show(); // Show teacher form
                        }
                        else if (userRole == "student")
                        {
                            StudentForm studentForm = new StudentForm();
                            studentForm.Show(); // Show student form
                        }
                    }
                    else
                    {
                        // Invalid login, provide feedback
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

    }
}
