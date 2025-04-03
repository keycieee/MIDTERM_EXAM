using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentManagementSystem
{
    public partial class StudentPage : Form
    {
        public StudentPage()
        {
            InitializeComponent();
        }

        private void StudentPage_Load(object sender, EventArgs e)
        {
            LoadAllStudents();
        }

        private void LoadAllStudents()
        {
            try
            {
                DataTable studentsData = DatabaseConnection.GetAllStudents();
                studentsDataGridView.DataSource = studentsData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students data: " + ex.Message);
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if (studentsDataGridView.SelectedRows.Count > 0)
            {
                int selectedStudentId = Convert.ToInt32(studentsDataGridView.SelectedRows[0].Cells["StudentID"].Value);
                StudentPage_Individual studentPageIndividual = new StudentPage_Individual(selectedStudentId);
                studentPageIndividual.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a student to view details.");
            }
        }

       

        private void HeaderLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
