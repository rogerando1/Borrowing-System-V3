using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Borrowing_System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Borrowing_System
{
    public partial class AccountManagementPage : Form
    {
        public static AccountManagementPage instance;
        public static string employeePersonID { get; set; }
        public static string employeeFname { get; set; }
        public static string employeeMinitial { get; set; }
        public static string employeeLname { get; set; }
        public static string employeeUsername { get; set; }
        public static string employeePassword { get; set; }
        public static string employeePosition { get; set; }

        public static string studentFirstName { get; set; }
        public static string studentMiddleInitial { get; set; }
        public static string studentLastName { get; set; }
        public static string studentId { get; set; }
        public static string studentProgram { get; set; }
        public static string studentYearLevel { get; set; }

        public static string instructorId { get; set; }
        public static string instructorName { get; set; }
        public static string instructorCourseId { get; set; }
        public static string instructorCourseName { get; set; }
        public static string instructorCourseSection { get; set; }
        public static string instructorCourseStartTime { get; set; }
        public static string instructorCourseEndTime { get; set; }

        public static string instructorId1 { get; set; }
        public static string instructor1Firstname { get; set; }
        public static string instructor1MiddleInitial { get; set; }
        public static string instructor1Lastname { get; set; }

        public static string courseId { get; set; }
        public static string courseName { get; set; }

        public AccountManagementPage()
        {
            InitializeComponent();
            instance = this;
        }

        private void AccountManagementPage_Load(object sender, EventArgs e)
        {
            instructorlistTxtbx.Items.Add("(Select Instructor)");
            //Employee Data
            MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT Person.personID, Person.firstname, Person.middleinitial, Person.lastname, Accounts.username, Accounts.password_, Accounts.position FROM Person " +
                "INNER JOIN Accounts ON Person.personID = Accounts.personID", mySqlConnection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            employeeData.DataSource = dataTable;

            //Student Data
            mySqlCommand = new MySqlCommand("SELECT Person.firstname AS studentFirstname, Person.middleinitial AS studentMiddleInitial, Person.lastname AS studentLastname, Student.studentID, Student.program, Student.yearlevel FROM Person " +
                "INNER JOIN Student ON Person.personID = Student.personID", mySqlConnection);
            mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            studentData.DataSource = dataTable;


            //Show Instructor Data from Instructor Table
            mySqlCommand = new MySqlCommand("SELECT Instructor.instructorID, Person.firstname AS instructorFirstname, Person.middleinitial AS instructorMiddleInitial, Person.lastname AS instructorLastname FROM Instructor " +
                               "INNER JOIN Person ON Instructor.personID = Person.personID", mySqlConnection);
            mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            instructorData.DataSource = dataTable;



            //Schedule Data
            mySqlCommand = new MySqlCommand("SELECT  CourseTime.instructorID, Person.firstname AS instructorFirstname, Person.middleinitial AS instructorMiddleInitial, " +
                "Person.lastname AS instructorLastname, CourseTime.courseID, Course.coursename, CourseTime.section, CourseTime.startTime, CourseTime.endTime,  " +
                "CONCAT(IFNULL(Person.firstname, ''), ' ', IFNULL(Person.middleinitial, ''), '. ', IFNULL(Person.lastname, '')) AS instructorName FROM CourseTime " +
                "INNER JOIN Instructor ON CourseTime.instructorID = Instructor.instructorID " +
                "INNER JOIN Person ON Instructor.personID = Person.personID " +
                "INNER JOIN Course ON CourseTime.courseID = Course.courseID ", mySqlConnection);
            mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            scheduleData.DataSource = dataTable;

            //Show all Course Table only, no inner join. Just courseID and coursename
            mySqlCommand = new MySqlCommand("SELECT Course.courseID, Course.coursename FROM Course", mySqlConnection);
            mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            courseData.DataSource = dataTable;

            mySqlConnection.Close();
            FillComboBox();
        }

        public void refreshData()
        {
            if (employeeBTN.BackColor == Color.FromArgb(252, 168, 115))
            {
                //Refresh Employee List Data
                MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT Person.personID, Person.firstname, Person.middleinitial, Person.lastname, Accounts.username, Accounts.password_, Accounts.position FROM Person INNER JOIN Accounts ON Person.personID = Accounts.personID", mySqlConnection);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                employeeData.DataSource = dataTable;
                mySqlConnection.Close();
            }
            else if (studentBTN.BackColor == Color.FromArgb(252, 168, 115))
            {
                //Refresh Student List Data
                MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT Person.firstname AS studentFirstname, Person.middleinitial AS studentMiddleInitial, Person.lastname AS studentLastname, Student.studentID, Student.program, Student.yearlevel FROM Person INNER JOIN Student ON Person.personID = Student.personID", mySqlConnection);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                studentData.DataSource = dataTable;
                mySqlConnection.Close();
            }
            else if (scheduleBTN.BackColor == Color.FromArgb(252, 168, 115))
            {
                //Refresh Schedule List Data
                MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT  CourseTime.instructorID, Person.firstname AS instructorFirstname, Person.middleinitial AS instructorMiddleInitial, Person.lastname AS instructorLastname, CourseTime.courseID, Course.coursename, CourseTime.section, CourseTime.startTime, CourseTime.endTime,  CONCAT(IFNULL(Person.firstname, ''), ' ', IFNULL(Person.middleinitial, ''), '. ', IFNULL(Person.lastname, '')) AS instructorName FROM CourseTime INNER JOIN Instructor ON CourseTime.instructorID = Instructor.instructorID INNER JOIN Person ON Instructor.personID = Person.personID INNER JOIN Course ON CourseTime.courseID = Course.courseID ", mySqlConnection);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                scheduleData.DataSource = dataTable;
                mySqlConnection.Close();

            }
            else if (instructorBTN.BackColor == Color.FromArgb(252, 168, 115))
            {
                //Refresh Instructor List Data
                MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT Instructor.instructorID, Person.firstname AS ins_first_name, Person.middleinitial AS ins_middle_initial, Person.lastname AS ins_last_name FROM Instructor INNER JOIN Person ON Instructor.personID = Person.personID", mySqlConnection);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                instructorData.DataSource = dataTable;
                mySqlConnection.Close();
            }
            else
            {
                //Refresh Course List Data
                MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT Course.courseID, Course.coursename FROM Course", mySqlConnection);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                courseData.DataSource = dataTable;
                mySqlConnection.Close();
            }
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            try
            {

                if (employeeBTN.BackColor == Color.FromArgb(252, 168, 115))
                {
                    //SEARCH EMPLOYEE
                    MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand($"SELECT Person.personID, Person.firstname, Person.middleinitial, Person.lastname, Accounts.username, Accounts.password_, Accounts.position FROM Person INNER JOIN Accounts ON Person.personID = Accounts.personID WHERE Person.firstname LIKE '%{searchData.Text}%' OR Person.lastname LIKE '%{searchData.Text}%' OR Accounts.username LIKE '%{searchData.Text}%' OR Accounts.position LIKE '%{searchData.Text}%'", mySqlConnection);
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                    DataTable dataTable = new DataTable();
                    mySqlDataAdapter.Fill(dataTable);
                    employeeData.DataSource = dataTable;
                    mySqlConnection.Close();


                }
                else if (studentBTN.BackColor == Color.FromArgb(252, 168, 115))
                {
                    //SEARCH STUDENT
                    MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand($"SELECT Person.firstname AS studentFirstname, Person.middleinitial AS studentMiddleInitial, Person.lastname AS studentLastname, Student.studentID, Student.program, Student.yearlevel FROM Person INNER JOIN Student ON Person.personID = Student.personID WHERE Person.firstname LIKE '%{searchData.Text}%' OR Person.lastname LIKE '%{searchData.Text}%' OR Student.studentID LIKE '%{searchData.Text}%' OR Student.program LIKE '%{searchData.Text}%' OR Student.yearlevel LIKE '%{searchData.Text}%'", mySqlConnection);
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                    DataTable dataTable = new DataTable();
                    mySqlDataAdapter.Fill(dataTable);
                    studentData.DataSource = dataTable;
                    mySqlConnection.Close();
                }
                else if (instructorBTN.BackColor == Color.FromArgb(252, 168, 115))
                {
                    //SEARCH INSTRUCTOR

                }
                else if (scheduleBTN.BackColor == Color.FromArgb(252, 168, 115))
                {
                    //SEARCH SCHEDULE
                    MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand($"SELECT  CourseTime.instructorID, Person.firstname AS instructorFirstname, Person.middleinitial AS instructorMiddleInitial, Person.lastname AS instructorLastname, CourseTime.courseID, Course.coursename, CourseTime.section, CourseTime.startTime, CourseTime.endTime,  CONCAT(IFNULL(Person.firstname, ''), ' ', IFNULL(Person.middleinitial, ''), '. ', IFNULL(Person.lastname, '')) AS instructorName FROM CourseTime INNER JOIN Instructor ON CourseTime.instructorID = Instructor.instructorID INNER JOIN Person ON Instructor.personID = Person.personID INNER JOIN Course ON CourseTime.courseID = Course.courseID WHERE Person.firstname LIKE '%{searchData.Text}%' OR Person.lastname LIKE '%{searchData.Text}%' OR Course.coursename LIKE '%{searchData.Text}%' OR CourseTime.section LIKE '%{searchData.Text}%' OR CONCAT(IFNULL(Person.firstname, ''), ' ', IFNULL(Person.middleinitial, ''), '. ', IFNULL(Person.lastname, '')) LIKE '%{searchData.Text}%'", mySqlConnection);
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                    DataTable dataTable = new DataTable();
                    mySqlDataAdapter.Fill(dataTable);
                    scheduleData.DataSource = dataTable;
                    mySqlConnection.Close();
                }
                else
                {
                    //SEARCH COURSE
                    MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand($"SELECT Course.courseID, Course.coursename FROM Course WHERE Course.courseID LIKE '%{searchData.Text}%' OR Course.coursename LIKE '%{searchData.Text}%'", mySqlConnection);
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                    DataTable dataTable = new DataTable();
                    mySqlDataAdapter.Fill(dataTable);
                    courseData.DataSource = dataTable;
                    mySqlConnection.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchData_TextChanged(object sender, EventArgs e)
        {
            if (scheduleBTN.BackColor == Color.FromArgb(252, 168, 115))
            {
                if (searchData.Text == "")
                {
                    //Show all instructors
                    MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    connection.Open();
                    string query = "SELECT CourseTime.instructorID, Person.firstname AS instructorFirstname, Person.middleinitial AS instructorMiddleinitial, Person.lastname AS instructorLastname, " +
                        "CourseTime.courseID, Course.coursename,  CourseTime.section, CourseTime.startTime, CourseTime.endTime, " +
                        "CONCAT(IFNULL(Person.firstname, ''), ' ', IFNULL(Person.middleinitial, ''), '. ', IFNULL(Person.lastname, '')) AS instructorName FROM CourseTime " +
                        "INNER JOIN Instructor ON CourseTime.instructorID = Instructor.instructorID " +
                        "INNER JOIN Person ON Instructor.personID = Person.personID " +
                        "INNER JOIN Course on CourseTime.courseID = Course.courseID";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    scheduleData.DataSource = dt;
                }
            }
            else
            {
                if (searchData.Text == "")
                {
                    AccountManagementPage_Load(sender, e);
                }
            }

        }

        private void employeeBTN_Click(object sender, EventArgs e)
        {
            employeeList1.BringToFront();
            studentBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            scheduleBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            courseBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            employeeBTN.BackColor = Color.FromArgb(252, 168, 115); //SELECTED
            instructorBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            scheduleData.Visible = false;
            studentData.Visible = false;
            instructorData.Visible = false;
            employeeData.Visible = true;
            courseData.Visible = false;
            instructorlistTxtbx.Visible = false;


        }

        private void studentBTN_Click(object sender, EventArgs e)
        {
            studentList1.BringToFront();
            studentBTN.BackColor = Color.FromArgb(252, 168, 115); //SELECTED
            scheduleBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            courseBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            employeeBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            instructorBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            studentData.Visible = true;
            instructorData.Visible = false;
            scheduleData.Visible = false;
            employeeData.Visible = false;
            courseData.Visible = false;
            instructorlistTxtbx.Visible = false;


        }

        private void instructorBTN_Click(object sender, EventArgs e)
        {
            instructorList1.BringToFront();
            studentBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            scheduleBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            courseBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            employeeBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            instructorBTN.BackColor = Color.FromArgb(252, 168, 115); //SELECTED
            scheduleData.Visible = false;
            studentData.Visible = false;
            instructorData.Visible = true;
            employeeData.Visible = false;
            courseData.Visible = false;
            instructorlistTxtbx.Visible = false;
        }

        private void courseBTN_Click(object sender, EventArgs e)
        {
            courseList1.BringToFront();
            studentBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            scheduleBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            courseBTN.BackColor = Color.FromArgb(252, 168, 115); //SELECTED
            employeeBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            instructorBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            scheduleData.Visible = false;
            studentData.Visible = false;
            instructorData.Visible = false;
            employeeData.Visible = false;
            courseData.Visible = true;
            instructorlistTxtbx.Visible = false;
        }

        private void employeeData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.employeeData.Rows[e.RowIndex];
                employeePersonID = row.Cells["personID"].Value.ToString();
                employeeFname = row.Cells["firstname"].Value.ToString();
                employeeMinitial = row.Cells["middleinitial"].Value.ToString();
                employeeLname = row.Cells["lastname"].Value.ToString();
                employeeUsername = row.Cells["username"].Value.ToString();
                employeePassword = row.Cells["password_"].Value.ToString();
                employeePosition = row.Cells["position"].Value.ToString();
                employeeList1.updateEmployeeList();
            }
        }

        private void scheduleBTN_Click(object sender, EventArgs e)
        {
            instructorlistTxtbx.Visible = true;
            scheduleList1.BringToFront();
            studentBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            scheduleBTN.BackColor = Color.FromArgb(252, 168, 115); //SELECTED
            courseBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            employeeBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            instructorBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            scheduleData.Visible = true;
            studentData.Visible = false;
            employeeData.Visible = false;
            courseData.Visible = false;
        }

        private void studentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = studentData.Rows[e.RowIndex];
                studentId = row.Cells["studentID"].Value.ToString();
                studentFirstName = row.Cells["studentFirstname"].Value.ToString();
                studentMiddleInitial = row.Cells["studentMiddleInitial"].Value.ToString();
                studentLastName = row.Cells["studentLastname"].Value.ToString();
                studentProgram = row.Cells["program"].Value.ToString();
                studentYearLevel = row.Cells["yearlevel"].Value.ToString();
                studentList1.updateStudentList();

            }
        }

        private void studentData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void instructorlistTxtbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (instructorlistTxtbx.SelectedItem == null || instructorlistTxtbx.Text == "(Select Instructor)")
            {
                //Show all instructors
                MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                connection.Open();
                string query = "SELECT CourseTime.instructorID, Person.firstname AS instructorFirstname, Person.middleinitial AS instructorMiddleinitial, Person.lastname AS instructorLastname, " +
                    "CourseTime.courseID, Course.coursename,  CourseTime.section, CourseTime.startTime, CourseTime.endTime, " +
                    "CONCAT(IFNULL(Person.firstname, ''), ' ', IFNULL(Person.middleinitial, ''), '. ', IFNULL(Person.lastname, '')) AS instructorName FROM CourseTime " +
                    "INNER JOIN Instructor ON CourseTime.instructorID = Instructor.instructorID " +
                    "INNER JOIN Person ON Instructor.personID = Person.personID " +
                    "INNER JOIN Course on CourseTime.courseID = Course.courseID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                scheduleData.DataSource = dt;

            }

            else
            {
                string instructorName = instructorlistTxtbx.SelectedItem.ToString();
                MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                connection.Open();
                string query = "SELECT CourseTime.instructorID, Person.firstname AS instructorFirstname, Person.middleinitial AS instructorMiddleinitial, Person.lastname AS instructorLastname, " +
                    "CourseTime.courseID, Course.coursename,  CourseTime.section, CourseTime.startTime, CourseTime.endTime, " +
                    "CONCAT(IFNULL(Person.firstname, ''), ' ', IFNULL(Person.middleinitial, ''), '. ', IFNULL(Person.lastname, '')) AS instructorName FROM CourseTime " +
                    "INNER JOIN Instructor ON CourseTime.instructorID = Instructor.instructorID " +
                    "INNER JOIN Person ON Instructor.personID = Person.personID " +
                    "INNER JOIN Course on CourseTime.courseID = Course.courseID " +
                    "WHERE CONCAT(IFNULL(Person.firstname, ''), ' ', IFNULL(Person.middleinitial, ''), '. ', IFNULL(Person.lastname, '')) = @instructorName";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@instructorName", instructorName);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                scheduleData.DataSource = dt;
            }
        }

        private void FillComboBox()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT CONCAT(IFNULL(Person.firstname, ''), ' ', IFNULL(Person.middleinitial, ''), '. ', IFNULL(Person.lastname, '')) AS personID FROM Instructor " +
                                                             "INNER JOIN Person ON Instructor.personID = Person.personID ", connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string instructorName = reader.GetString("personID");
                    instructorlistTxtbx.Items.Add(instructorName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void employeeList1_Load(object sender, EventArgs e)
        {

        }

        private void instructorData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = scheduleData.Rows[e.RowIndex];
                instructorId = row.Cells["instructorID"].Value.ToString();
                instructorName = row.Cells["instructorname"].Value.ToString();
                instructorCourseId = row.Cells["instructorcourseId"].Value.ToString();
                instructorCourseName = row.Cells["instructorcName"].Value.ToString();
                instructorCourseSection = row.Cells["instructorSection"].Value.ToString();
                instructorCourseStartTime = row.Cells["instructorStartTime"].Value.ToString();
                instructorCourseEndTime = row.Cells["instructorEndTime"].Value.ToString();
                scheduleList1.updateInstructorList();
            }
        }

        private void courseData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = courseData.Rows[e.RowIndex];
                courseName = row.Cells["coursename"].Value.ToString();
                courseId = row.Cells["courseID"].Value.ToString();
                courseList1.updateCourseList();
            }
        }

        private void searchData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBTN.PerformClick();
            }
        }

        private void instructorData_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = instructorData.Rows[e.RowIndex];
                instructorId1 = row.Cells["instructor_ID"].Value.ToString();
                instructor1Firstname = row.Cells["ins_first_name"].Value.ToString();
                instructor1MiddleInitial = row.Cells["ins_middle_initial"].Value.ToString();
                instructor1Lastname = row.Cells["ins_last_name"].Value.ToString();
                instructorList1.updateInstructorList();

            }
        }
    }
}
