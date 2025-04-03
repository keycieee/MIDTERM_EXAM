using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentManagementSystem
{
    public class DatabaseConnection
    {
        private static string connectionString = "server=localhost;database=StudentInfoDB;uid=root;pwd=;";

        // Retrieve all students for the main page
        public static DataTable GetAllStudents()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT s.studentId, CONCAT(s.firstName, ' ', s.lastName) AS FullName 
                                FROM StudentRecordTB s";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
            }

            return dataTable;
        }

        // Retrieve specific student record with course and year information
        public static DataRow GetStudentById(int studentId)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT s.*, c.courseName, y.yearLvl
                                FROM StudentRecordTB s
                                LEFT JOIN CourseTB c ON s.courseId = c.courseId
                                LEFT JOIN YearTB y ON s.yearId = y.yearId
                                WHERE s.studentId = @StudentId";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StudentId", studentId);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving student data: " + ex.Message);
            }

            if (dataTable.Rows.Count > 0)
                return dataTable.Rows[0];
            else
                return null;
        }
    }
}
