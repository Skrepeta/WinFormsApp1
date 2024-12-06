using System;
using System.Data;
using System.Windows.Forms;
using Dapper;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class TeacherForm : Form
    {
        private readonly string connectionString = "Server=localhost;Database=academicsystem;User ID=root;Password=;";

        public TeacherForm()
        {
            InitializeComponent();
        }

        private void btnSaveGrade_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    string sql = "UPDATE Grades SET Grade = @Grade WHERE student_id = @user_id AND lecture_id = @lecture_id";
                    var parameters = new
                    {
                        Grade = txtGrade.Text,
                        student_id = txtStudentId.Text,
                        lecture_id = txtLectureId.Text
                    };
                    connection.Execute(sql, parameters);
                    MessageBox.Show("Grade updated successfully!");
                }
                LoadGrades();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void LoadGrades()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM Grades";
                    var grades = connection.Query(sql);
                    dgvGrades.DataSource = grades;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading grades: {ex.Message}");
            }
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            LoadGrades();
        }
    }
}

