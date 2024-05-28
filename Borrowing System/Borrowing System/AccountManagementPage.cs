using Borrowing_System.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Borrowing_System
{
    public partial class AccountManagementPage : Form
    {
        Image normalImage = Properties.Resources.delete1;
        Image hoverImage = Properties.Resources.delete2;
        private DataGridViewCell selectedCell = null;

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
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT Instructor.instructorID, Person.firstname AS instructorFirstname, Person.middleinitial AS instructorMiddleInitial, Person.lastname AS instructorLastname FROM Instructor INNER JOIN Person ON Instructor.personID = Person.personID", mySqlConnection);
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
                    MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand($"SELECT Instructor.instructorID, Person.firstname AS instructorFirstname, Person.middleinitial AS instructorMiddleInitial, Person.lastname AS instructorLastname FROM Instructor INNER JOIN Person ON Instructor.personID = Person.personID WHERE Person.firstname LIKE '%{searchData.Text}%' OR Person.lastname LIKE '%{searchData.Text}%'", mySqlConnection);
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                    DataTable dataTable = new DataTable();
                    mySqlDataAdapter.Fill(dataTable);
                    instructorData.DataSource = dataTable;
                    mySqlConnection.Close();
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
            try
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
                if (e.ColumnIndex == employeeData.Columns["removeEmployee"].Index)
                {
                    //Change image when selected
                    selectedCell = employeeData[e.ColumnIndex, e.RowIndex];
                    employeeData.InvalidateCell(e.ColumnIndex, e.RowIndex);
                    employeeData.Refresh();
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                            connection.Open();
                            MySqlCommand cmd = new MySqlCommand("DELETE FROM Accounts WHERE personID = @personID", connection);
                            cmd.Parameters.AddWithValue("@personID", employeePersonID);
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Record has been deleted successfully!", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refreshData();
                            employeeList1.clearBtn_Click(sender, e);


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        selectedCell = null;
                        employeeData.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.studentData.Rows[e.RowIndex];
                    studentFirstName = row.Cells["studentFirstname"].Value.ToString();
                    studentMiddleInitial = row.Cells["studentMiddleInitial"].Value.ToString();
                    studentLastName = row.Cells["studentLastname"].Value.ToString();
                    studentId = row.Cells["studentID"].Value.ToString();
                    studentProgram = row.Cells["program"].Value.ToString();
                    studentYearLevel = row.Cells["yearlevel"].Value.ToString();
                    studentList1.updateStudentList();
                }
                //Delete Student
                if (e.ColumnIndex == studentData.Columns["removeStudent"].Index)
                {
                    //Change image when selected
                    selectedCell = studentData[e.ColumnIndex, e.RowIndex];
                    studentData.InvalidateCell(e.ColumnIndex, e.RowIndex);
                    studentData.Refresh();
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                            connection.Open();
                            MySqlCommand cmd = new MySqlCommand("DELETE FROM Student WHERE studentID = @studentID", connection);
                            cmd.Parameters.AddWithValue("@studentID", studentId);
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Record has been deleted successfully!", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refreshData();
                            studentList1.clearBTN_Click(sender, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        selectedCell = null;
                        studentData.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                DataGridViewRow row = instructorData.Rows[e.RowIndex];
                instructorId1 = row.Cells["instructor_ID"].Value.ToString();
                instructor1Firstname = row.Cells["ins_first_name"].Value.ToString();
                instructor1MiddleInitial = row.Cells["ins_middle_initial"].Value.ToString();
                instructor1Lastname = row.Cells["ins_last_name"].Value.ToString();
                instructorList1.updateInstructorList();
                instructorData.Refresh();
            }
            //delete instructor
            if (e.ColumnIndex == instructorData.Columns["removeInstructor"].Index)
            {
                try
                {
                    //Change image when selected
                    selectedCell = instructorData[e.ColumnIndex, e.RowIndex];
                    instructorData.InvalidateCell(e.ColumnIndex, e.RowIndex);
                    instructorData.Refresh();
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                            connection.Open();
                            MySqlCommand cmd = new MySqlCommand("DELETE FROM Instructor WHERE instructorID = @instructorID", connection);
                            cmd.Parameters.AddWithValue("@instructorID", instructorId1);
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Record has been deleted successfully!", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refreshData();
                            instructorList1.clearBTN_Click(sender, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        selectedCell = null;
                        instructorData.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
            if (e.ColumnIndex == courseData.Columns["removeCourse"].Index)
            {
                try
                {
                    //Change image when selected
                    selectedCell = courseData[e.ColumnIndex, e.RowIndex];
                    courseData.InvalidateCell(e.ColumnIndex, e.RowIndex);
                    courseData.Refresh();
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                            connection.Open();
                            MySqlCommand cmd = new MySqlCommand("DELETE FROM Course WHERE courseID = @courseID", connection);
                            cmd.Parameters.AddWithValue("@courseID", courseId);
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Record has been deleted successfully!", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refreshData();
                            courseList1.clearBTN_Click(sender, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        selectedCell = null;
                        courseData.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void searchData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBTN.PerformClick();
            }
        }

        private void employeeData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == employeeData.Columns["removeEmployee"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var image = normalImage;
                if (selectedCell != null && selectedCell.RowIndex == e.RowIndex && selectedCell.ColumnIndex == e.ColumnIndex)
                {
                    image = hoverImage;
                }

                var w = image.Width;
                var h = image.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(image, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void employeeData_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == employeeData.Columns["removeEmployee"].Index)
            {
                employeeData.Cursor = Cursors.Hand;
            }
        }

        private void employeeData_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == employeeData.Columns["removeEmployee"].Index)
            {
                employeeData.Cursor = Cursors.Default;
            }
        }

        private void studentData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == studentData.Columns["removeStudent"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var image = normalImage;
                if (selectedCell != null && selectedCell.RowIndex == e.RowIndex && selectedCell.ColumnIndex == e.ColumnIndex)
                {
                    image = hoverImage;
                }

                var w = image.Width;
                var h = image.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(image, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void studentData_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == studentData.Columns["removeStudent"].Index)
            {
                studentData.Cursor = Cursors.Hand;
            }
        }

        private void studentData_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == studentData.Columns["removeStudent"].Index)
            {
                studentData.Cursor = Cursors.Default;
            }
        }

        private void instructorData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == instructorData.Columns["removeInstructor"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var image = normalImage;
                if (selectedCell != null && selectedCell.RowIndex == e.RowIndex && selectedCell.ColumnIndex == e.ColumnIndex)
                {
                    image = hoverImage;
                }

                var w = image.Width;
                var h = image.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(image, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void instructorData_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == instructorData.Columns["removeInstructor"].Index)
            {
                instructorData.Cursor = Cursors.Hand;
            }
        }

        private void instructorData_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == instructorData.Columns["removeInstructor"].Index)
            {
                instructorData.Cursor = Cursors.Default;
            }
        }

        private void scheduleData_CellClick(object sender, DataGridViewCellEventArgs e)
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
            if (e.ColumnIndex == scheduleData.Columns["removeSchedule"].Index)
            {
                try
                {
                    //Change image when selected
                    selectedCell = scheduleData[e.ColumnIndex, e.RowIndex];
                    scheduleData.InvalidateCell(e.ColumnIndex, e.RowIndex);
                    scheduleData.Refresh();
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                        connection.Open();
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM CourseTime WHERE instructorID = @instructorID AND courseID = @courseID", connection);
                        cmd.Parameters.AddWithValue("@instructorID", instructorId);
                        cmd.Parameters.AddWithValue("@courseID", instructorCourseId);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Record has been deleted successfully!", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshData();
                        scheduleList1.clearBtn_Click(sender, e);
                    }
                    else
                    {
                        selectedCell = null;
                        scheduleData.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void courseData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == courseData.Columns["removeCourse"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var image = normalImage;
                if (selectedCell != null && selectedCell.RowIndex == e.RowIndex && selectedCell.ColumnIndex == e.ColumnIndex)
                {
                    image = hoverImage;
                }

                var w = image.Width;
                var h = image.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(image, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void courseData_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == courseData.Columns["removeCourse"].Index)
            {
                courseData.Cursor = Cursors.Hand;
            }
        }

        private void courseData_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == courseData.Columns["removeCourse"].Index)
            {
                courseData.Cursor = Cursors.Default;
            }
        }

        private void scheduleData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == scheduleData.Columns["removeSchedule"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var image = normalImage;
                if (selectedCell != null && selectedCell.RowIndex == e.RowIndex && selectedCell.ColumnIndex == e.ColumnIndex)
                {
                    image = hoverImage;
                }

                var w = image.Width;
                var h = image.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(image, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void scheduleData_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == scheduleData.Columns["removeSchedule"].Index)
            {
                scheduleData.Cursor = Cursors.Hand;
            }
        }

        private void scheduleData_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == scheduleData.Columns["removeSchedule"].Index)
            {
                scheduleData.Cursor = Cursors.Default;
            }
        }
    }
}
