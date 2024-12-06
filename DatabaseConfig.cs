using MySql.Data.MySqlClient;
using System;

public class DatabaseConfig
{
    // Connection string
    private string connectionString = "Server=localhost;Database=academicsystem;User ID=root;Password=;";

    // Method to open a connection
    public MySqlConnection OpenConnection()
    {
        MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();
        return connection;
    }

    // Method to create a new user
    public void CreateUser(string firstName, string lastName, string username, string password, string role)
    {
        using (var connection = OpenConnection())
        {
            string query = "INSERT INTO Users (first_name, last_name, username, password, role) " +
                           "VALUES (@FirstName, @LastName, @Username, @Password, @Role)";
            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Role", role);

                cmd.ExecuteNonQuery();
            }
        }
    }

    // Method to create a group
    public void CreateGroup(string groupName)
    {
        using (var connection = OpenConnection())
        {
            string query = "INSERT INTO `Groups` (group_name) VALUES (@GroupName)";
            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@GroupName", groupName);
                cmd.ExecuteNonQuery();
            }
        }
    }

    // Method to create a new lecture
    public void CreateLecture(string lectureName, string description, int teacherId)
    {
        using (var connection = OpenConnection())
        {
            string query = "INSERT INTO Lectures (lecture_name, lecture_description, teacher_id) " +
                           "VALUES (@LectureName, @Description, @TeacherId)";
            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@LectureName", lectureName);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@TeacherId", teacherId);
                cmd.ExecuteNonQuery();
            }
        }
    }

    // Method to assign a group to a lecture
    public void AssignGroupToLecture(int groupId, int lectureId)
    {
        using (var connection = OpenConnection())
        {
            string query = "INSERT INTO Group_Lectures (group_id, lecture_id) VALUES (@GroupId, @LectureId)";
            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@GroupId", groupId);
                cmd.Parameters.AddWithValue("@LectureId", lectureId);
                cmd.ExecuteNonQuery();
            }
        }
    }

    // Method to assign a grade to a student
    public void AssignGrade(int studentId, int lectureId, decimal grade)
    {
        using (var connection = OpenConnection())
        {
            string query = "INSERT INTO Grades (student_id, lecture_id, grade) VALUES (@StudentId, @LectureId, @Grade)";
            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@StudentId", studentId);
                cmd.Parameters.AddWithValue("@LectureId", lectureId);
                cmd.Parameters.AddWithValue("@Grade", grade);
                cmd.ExecuteNonQuery();
            }
        }
    }

    // Method to get all users (for admin or management)
    public void GetAllUsers()
    {
        using (var connection = OpenConnection())
        {
            string query = "SELECT * FROM Users";
            using (var cmd = new MySqlCommand(query, connection))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["user_id"]} - {reader["first_name"]} {reader["last_name"]} ({reader["role"]})");
                    }
                }
            }
        }
    }

    // Method to get all groups
    public void GetAllGroups()
    {
        using (var connection = OpenConnection())
        {
            string query = "SELECT * FROM `Groups`";
            using (var cmd = new MySqlCommand(query, connection))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["group_id"]} - {reader["group_name"]}");
                    }
                }
            }
        }
    }

    // Method to get all lectures
    public void GetAllLectures()
    {
        using (var connection = OpenConnection())
        {
            string query = "SELECT * FROM Lectures";
            using (var cmd = new MySqlCommand(query, connection))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["lecture_id"]} - {reader["lecture_name"]} ({reader["teacher_id"]})");
                    }
                }
            }
        }
    }
}
