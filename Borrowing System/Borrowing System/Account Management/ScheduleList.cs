using Borrowing_System.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borrowing_System.Account_Management
{
    public partial class ScheduleList : UserControl
    {
        public ScheduleList()
        {
            InitializeComponent();
        }

        public void updateInstructorList()
        {
            instructorIDTxtbx.Text = AccountManagementPage.instructorId;
            instructornameTxtbx.Text = AccountManagementPage.instructorName;
            courseIDTxtbx.Text = AccountManagementPage.instructorCourseId;
            coursenameTxtbx.Text = AccountManagementPage.instructorCourseName;
            sectionTxtbx.Text = AccountManagementPage.instructorCourseSection;
            starttimeTxtbx.Text = AccountManagementPage.instructorCourseStartTime;
            endtimeTxtbx.Text = AccountManagementPage.instructorCourseEndTime;
        }

        private void courseIDTxtbx_TextChanged(object sender, EventArgs e)
        {           
            courseTimer.Stop();
            courseTimer.Start();
        }

        private void instructorIDTxtbx_TextChanged(object sender, EventArgs e)
        {
            if (instructorIDTxtbx.Text.Length == 11)
            {
                //Read Instructor Name and store it into the instructornameTxtbx
                MySqlConnection conn = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                conn.Open();
                MySqlCommand command = new MySqlCommand($"SELECT CONCAT(p.firstname, ' ', p.middleinitial, ' ', p.lastname) as FullName FROM Instructor i INNER JOIN Person p ON i.personID = p.personID WHERE i.instructorID = '{instructorIDTxtbx.Text}'", conn);
                MySqlDataReader mySqlDataReader = command.ExecuteReader();
                if (mySqlDataReader.Read())
                {
                    instructornameTxtbx.Text = mySqlDataReader.GetString("FullName");
                }
                conn.Close();

            }
            else if (instructorIDTxtbx.Text.Length > 11)
            {
                return;
            }
            else if (instructorIDTxtbx.Text.Length == 0)
            {
                instructornameTxtbx.Text = "";
            }
            else
            {
                return;
            }
        }

        private void instructornameTxtbx_TextChanged(object sender, EventArgs e)
        {
            instructorTimer.Stop();
            instructorTimer.Start();
        }

        public void clearBtn_Click(object sender, EventArgs e)
        {
            instructorIDTxtbx.Text = "";
            instructornameTxtbx.Text = "";
            courseIDTxtbx.Text = "";
            coursenameTxtbx.Text = "";
            sectionTxtbx.Text = "";
            starttimeTxtbx.Value = DateTime.Today;
            endtimeTxtbx.Value = DateTime.Today;
        }

        private void createBTN_Click(object sender, EventArgs e)
        {
            string startTime = DateTime.Parse(starttimeTxtbx.Text).ToString("HH:mm:ss");
            string endTime = DateTime.Parse(endtimeTxtbx.Text).ToString("HH:mm:ss");
            try
            {
                if(instructornameTxtbx.Text == "" || courseIDTxtbx.Text == "" || coursenameTxtbx.Text == "" || sectionTxtbx.Text == "" || starttimeTxtbx.Text == "" || endtimeTxtbx.Text == "")
                {
                    MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Check if instructorID exists, otherwise show an error message
                MySqlConnection mySqlConnection1 = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                mySqlConnection1.Open();
                MySqlCommand mySqlCommand1 = new MySqlCommand($"SELECT * FROM Instructor WHERE instructorID = '{instructorIDTxtbx.Text}'", mySqlConnection1);
                MySqlDataReader mySqlDataReader1 = mySqlCommand1.ExecuteReader();
                if (!mySqlDataReader1.Read())
                {
                    MessageBox.Show("Instructor ID is not exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                mySqlConnection1.Close();
                mySqlDataReader1.Close();

                //Check if courseId exists, otherwise show an error message
                MySqlConnection mySqlConnection2 = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                mySqlConnection2.Open();
                MySqlCommand mySqlCommand2 = new MySqlCommand($"SELECT * FROM Course WHERE courseID = '{courseIDTxtbx.Text}'", mySqlConnection2);
                MySqlDataReader mySqlDataReader2 = mySqlCommand2.ExecuteReader();
                if (!mySqlDataReader2.Read())
                {
                    MessageBox.Show("Course ID is not exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                mySqlConnection2.Close();
                mySqlDataReader2.Close();

                MySqlConnection conn = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                conn.Open();
                MySqlCommand command = new MySqlCommand($"SELECT * FROM CourseTime WHERE courseID = '{courseIDTxtbx.Text}' && section = '{sectionTxtbx.Text}'", conn);
                MySqlDataReader mySqlDataReader = command.ExecuteReader();
                if (mySqlDataReader.Read())
                {
                    MessageBox.Show("Section on that subject is already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                conn.Close();


                if (MessageBox.Show("Are you sure you want to create this information data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand($"INSERT into CourseTime (courseID, instructorID, startTime, endTime, section) " +
                        $"VALUES('{courseIDTxtbx.Text}', '{instructorIDTxtbx.Text}', '{startTime}', '{endTime}', '{sectionTxtbx.Text}')", mySqlConnection);
                    mySqlCommand.ExecuteNonQuery();
                    mySqlConnection.Close();
                    MessageBox.Show("Course successfully create.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AccountManagementPage.instance.refreshData();
                    instructorIDTxtbx.Text = "";
                    instructornameTxtbx.Text = "";
                    courseIDTxtbx.Text = "";
                    coursenameTxtbx.Text = "";
                    sectionTxtbx.Text = "";
                    starttimeTxtbx.Value = DateTime.Today;
                    endtimeTxtbx.Value = DateTime.Today;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            try
            {

                if (instructornameTxtbx.Text == "" || courseIDTxtbx.Text == "" || coursenameTxtbx.Text == "" || sectionTxtbx.Text == "")
                {
                    MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Check if instructorID exists, otherwise show an error message
                MySqlConnection mySqlConnection1 = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                mySqlConnection1.Open();
                MySqlCommand mySqlCommand1 = new MySqlCommand($"SELECT * FROM Instructor WHERE instructorID = '{instructorIDTxtbx.Text}'", mySqlConnection1);
                MySqlDataReader mySqlDataReader1 = mySqlCommand1.ExecuteReader();
                if (!mySqlDataReader1.Read())
                {
                    MessageBox.Show("Instructor ID is not exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                mySqlConnection1.Close();
                mySqlDataReader1.Close();

                //Check if courseId exists, otherwise show an error message
                MySqlConnection mySqlConnection2 = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                mySqlConnection2.Open();
                MySqlCommand mySqlCommand2 = new MySqlCommand($"SELECT * FROM Course WHERE courseID = '{courseIDTxtbx.Text}'", mySqlConnection2);
                MySqlDataReader mySqlDataReader2 = mySqlCommand2.ExecuteReader();
                if (!mySqlDataReader2.Read())
                {
                    MessageBox.Show("Course ID is not exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                mySqlConnection2.Close();
                mySqlDataReader2.Close();

                if (MessageBox.Show("Are you sure you want to delete this course-subject?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Delete a course-subject
                    MySqlConnection conn = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    conn.Open();
                    MySqlCommand command = new MySqlCommand($"DELETE FROM CourseTime WHERE courseID = '{courseIDTxtbx.Text}' && instructorID = '{instructorIDTxtbx.Text}' && section = '{sectionTxtbx.Text}'", conn);
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Course successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AccountManagementPage.instance.refreshData();
                    instructorIDTxtbx.Text = "";
                    instructornameTxtbx.Text = "";
                    courseIDTxtbx.Text = "";
                    coursenameTxtbx.Text = "";
                    sectionTxtbx.Text = "";
                    starttimeTxtbx.Value = DateTime.Today;
                    endtimeTxtbx.Value = DateTime.Today;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void instructorTimer_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            instructorTimer.Stop();

            // Execute the database query
            MySqlConnection conn = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            conn.Open();
            MySqlCommand command = new MySqlCommand($"SELECT i.instructorID FROM Instructor i INNER JOIN Person p ON i.personID = p.personID WHERE CONCAT(p.firstname, ' ', p.lastname) = '{instructornameTxtbx.Text}'", conn);
            MySqlDataReader mySqlDataReader = command.ExecuteReader();
            if (mySqlDataReader.Read())
            {
                instructorIDTxtbx.Text = mySqlDataReader.GetString("instructorID");
            }
            if(instructornameTxtbx.Text == "" || instructorIDTxtbx.Text.Length < 1)
            {
                instructorIDTxtbx.Text = "";
            }
            conn.Close();
        }

        private void courseTimer_Tick(object sender, EventArgs e)
        {
            //Stop the timer
            courseTimer.Stop();

            //Execute the database query
            MySqlConnection conn = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            conn.Open();
            MySqlCommand command = new MySqlCommand($"SELECT * FROM Course WHERE courseID = '{courseIDTxtbx.Text}'", conn);
            MySqlDataReader mySqlDataReader = command.ExecuteReader();
            if (mySqlDataReader.Read())
            {
                coursenameTxtbx.Text = mySqlDataReader.GetString("coursename");
            }
            if (courseIDTxtbx.Text == "")
            {
                coursenameTxtbx.Text = "";
            }
            conn.Close();
        }

        private void coursenameTxtbx_TextChanged(object sender, EventArgs e)
        {
            coursenameTimer.Stop();
            coursenameTimer.Start();
        }

        private void coursenameTimer_Tick(object sender, EventArgs e)
        {
            //Stop the Timer
            coursenameTimer.Stop();

            //Execute the database query
            MySqlConnection conn = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            conn.Open();
            MySqlCommand command = new MySqlCommand($"SELECT c.courseID FROM Course c WHERE c.coursename = '{coursenameTxtbx.Text}'", conn);
            MySqlDataReader mySqlDataReader = command.ExecuteReader();
            if (mySqlDataReader.Read())
            {
                courseIDTxtbx.Text = mySqlDataReader.GetString("courseID");
            }
            if (coursenameTxtbx.Text == "")
            {
                courseIDTxtbx.Text = "";
            }
            conn.Close();

        }

        private void InstructorList_Load(object sender, EventArgs e)
        {
            starttimeTxtbx.Value = DateTime.Today;
            endtimeTxtbx.Value = DateTime.Today;
        }

        private void starttimeTxtbx_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
