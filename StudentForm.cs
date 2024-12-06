using System;
using System.Data;
using System.Windows.Forms;
using Dapper;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class StudentForm : Form
    {
        private readonly string connectionString = "Server=localhost;Database=academicsystem;User ID=root;Password=;";

        public StudentForm()
        {
            InitializeComponent();
        }

        private void LoadGrades()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM grades WHERE student_id = @student_id";
                    var parameters = new { user_id = txtStudentId.Text };
                    var grades = connection.Query(sql, parameters);
                    dgvGrades.DataSource = grades;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading grades: {ex.Message}");
            }
        }

        private void btnViewGrades_Click(object sender, EventArgs e)
        {
            LoadGrades();
        }
    }
}
