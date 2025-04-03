using System;
using System.Data;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class StudentPage_Individual : Form
    {
        private int StudentId;

        public StudentPage_Individual(int studentId)
        {
            InitializeComponent();
            this.StudentId = studentId;
        }

        private void StudentPage_Individual_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            try
            {
                DataRow studentData = DatabaseConnection.GetStudentById(StudentId);

                if (studentData != null)
                {
                    // Populate the form with student data
                    IdValueLabel.Text = studentData["studentId"].ToString();

                    // Full name
                    string firstName = studentData["firstName"].ToString();
                    string middleName = studentData["middleName"].ToString();
                    string lastName = studentData["lastName"].ToString();
                    FullNameValueLabel.Text = $"{firstName} {middleName} {lastName}";

                    // Personal information
                    FirstNameValueLabel.Text = firstName;
                    MiddleNameValueLabel.Text = middleName;
                    LastNameValueLabel.Text = lastName;
                    NicknameValueLabel.Text = studentData["nickname"].ToString();
                    BirthdateValueLabel.Text = studentData["birthdate"].ToString();
                    AgeValueLabel.Text = studentData["age"].ToString();

                    // Address information
                    string houseNo = studentData["houseNo"].ToString();
                    string brgyName = studentData["brgyName"].ToString();
                    string municipality = studentData["municipality"].ToString();
                    string province = studentData["province"].ToString();
                    string region = studentData["region"].ToString();
                    string country = studentData["country"].ToString();

                    AddressValueLabel.Text = $"House No. {houseNo}, {brgyName}, {municipality}, {province}, {region}, {country}";

                    // Contact information
                    ContactValueLabel.Text = studentData["studContactNo"].ToString();
                    EmailValueLabel.Text = studentData["emailAddress"].ToString();

                    // Guardian information
                    GuardianValueLabel.Text = $"{studentData["guardianFirstName"]} {studentData["guardianLastName"]}";

                    // Academic information
                    CourseValueLabel.Text = studentData["courseName"].ToString();
                    YearValueLabel.Text = studentData["yearLvl"].ToString();

                    // Other information
                    HobbiesValueLabel.Text = studentData["hobbies"].ToString();
                }
                else
                {
                    MessageBox.Show("Student record not found!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student data: " + ex.Message);
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}