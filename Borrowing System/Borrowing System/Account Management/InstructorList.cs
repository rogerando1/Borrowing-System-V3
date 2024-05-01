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
    public partial class InstructorList : UserControl
    {
        public InstructorList()
        {
            InitializeComponent();
        }

        public void updateInstructorList()
        {
            //    instructorIDTxtbx.Text = AccountManagementPage.instructorId;
            //    firstnameTxtbx.Text = AccountManagementPage.instructorFirstName;
            //    middleinitialTxtbx.Text = AccountManagementPage.instructorMiddleInitial;
            //    lastnameTxtbx.Text = AccountManagementPage.instructorLastName;
            sectionTxtbx.Text = AccountManagementPage.courseSection;
            starttimeTxtbx.Text = AccountManagementPage.courseTime;
        }

        private void courseIDTxtbx_TextChanged(object sender, EventArgs e)
        {           
            if (courseIDTxtbx.Text != "")
            {
                MySqlConnection connection = null;
                MySqlDataReader reader = null;

                try
                {
                    connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT coursename FROM sql6690575.Course WHERE courseId = @courseID", connection);
                    cmd.Parameters.AddWithValue("@courseID", courseIDTxtbx.Text);
                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        coursenameTxtbx.Text = reader["coursename"].ToString();
                    }
                    else
                    {
                        coursenameTxtbx.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }               
            }
            else
            {
                coursenameTxtbx.Text = "";
            }
        }

        private void instructorIDTxtbx_TextChanged(object sender, EventArgs e)
        {
            if (instructorIDTxtbx.Text.Length == 11)
            {
                if (instructorIDTxtbx.Text != "")
                {
                    MySqlConnection connection = null;
                    MySqlDataReader reader = null;

                    try
                    {
                        connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                        connection.Open();
                        MySqlCommand cmd = new MySqlCommand("SELECT CONCAT(IFNULL(Person.firstname, ''), ' ', IFNULL(Person.middleinitial, ''), '. ', IFNULL(Person.lastname, '')) AS personID FROM sql6690575.Instructor " +
                           "INNER JOIN Person ON Instructor.personID = Person.personID " +
                           "WHERE instructorId = @instructorID", connection);
                        cmd.Parameters.AddWithValue("@instructorID", instructorIDTxtbx.Text);
                        reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            instructornameTxtbx.Text = reader["personID"].ToString();                        
                        }
                        else
                        {
                            instructornameTxtbx.Text = "";                           
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }                   
                }
            }
            else
            {
                instructornameTxtbx.Text = "";    
            }
        }

        private void instructornameTxtbx_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(instructornameTxtbx.Text))
            {
                MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");              
                MySqlCommand cmd = new MySqlCommand("SELECT instructorID, CONCAT(IFNULL(Person.firstname, ''), ' ', IFNULL(Person.middleinitial, ''), '. ', IFNULL(Person.lastname, '')) AS personName " +
                   "FROM Instructor " +
                   "INNER JOIN Person ON Instructor.personID = Person.personID " +
                   "WHERE CONCAT(IFNULL(Person.firstname, ''), ' ', IFNULL(Person.middleinitial, ''), '. ', IFNULL(Person.lastname, '')) = @personName", connection);
                cmd.Parameters.AddWithValue("@personName", instructornameTxtbx.Text);
                try
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                        
                    if (reader.Read())
                    {
                        instructorIDTxtbx.Text = reader["instructorID"].ToString();
                    }
                    else
                    {
                        instructorIDTxtbx.Text = "";
                    }                      
                }
                catch (Exception ex)
                {
                       MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);               
                }
            }
            else
            {
                instructorIDTxtbx.Text = "";
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            instructornameTxtbx.Text = "";
            courseIDTxtbx.Text = "";
            coursenameTxtbx.Text = "";
            sectionTxtbx.Text = "";
            starttimeTxtbx.Text = "";    
        }

        private void createBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if(instructornameTxtbx.Text == "" || courseIDTxtbx.Text == "" || coursenameTxtbx.Text == "" || sectionTxtbx.Text == "" || starttimeTxtbx.Text == "" || endtimeTxtbx.Text == "")
                {
                    MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MySqlConnection conn = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                conn.Open();
                MySqlCommand command = new MySqlCommand($"SELECT * FROM CourseTime WHERE courseID = '{courseIDTxtbx.Text}' && section = '{sectionTxtbx.Text}'", conn);
                MySqlDataReader mySqlDataReader = command.ExecuteReader();
                if (mySqlDataReader.Read())
                {
                    MessageBox.Show("Section on that subject is already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    instructorIDTxtbx.Text = "";
                    instructornameTxtbx.Text = "";
                    courseIDTxtbx.Text = "";
                    coursenameTxtbx.Text = "";
                    sectionTxtbx.Text = "";
                    starttimeTxtbx.Text = "";
                    endtimeTxtbx.Text = "";
                    return;
                }
                conn.Close();


                if (MessageBox.Show("Are you sure you want to create this information data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand($"INSERT into CourseTime (courseID, instructorID, startTime, endTime, section) " +
                        $"VALUES('{courseIDTxtbx.Text}', '{instructorIDTxtbx.Text}', '{starttimeTxtbx.Text}', '{endtimeTxtbx.Text}', '{sectionTxtbx.Text}')", mySqlConnection);
                    mySqlCommand.ExecuteNonQuery();
                    mySqlConnection.Close();
                    MessageBox.Show("Course successfully create.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AccountManagementPage.instance.refreshData();
                    instructorIDTxtbx.Text = "";
                    instructornameTxtbx.Text = "";
                    courseIDTxtbx.Text = "";
                    coursenameTxtbx.Text = "";
                    sectionTxtbx.Text = "";
                    starttimeTxtbx.Text = "";
                    endtimeTxtbx.Text = "";
                    
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
                if (MessageBox.Show("Are you sure you want to delete this course-subject?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand($"DELETE FROM CourseTime ", mySqlConnection);
                    mySqlCommand.ExecuteNonQuery();
                   
                    mySqlConnection.Close();
                    MessageBox.Show("Account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AccountManagementPage.instance.refreshData();
                    instructorIDTxtbx.Text = "";
                    instructornameTxtbx.Text = "";
                    courseIDTxtbx.Text = "";
                    coursenameTxtbx.Text = "";
                    sectionTxtbx.Text = "";
                    starttimeTxtbx.Text = "";
                    endtimeTxtbx.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      
    }
}
