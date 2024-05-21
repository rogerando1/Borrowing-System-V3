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

namespace Borrowing_System.Account_Management
{
    public partial class CourseList : UserControl
    {
        public CourseList()
        {
            InitializeComponent();
        }

        public void updateCourseList()
        {
            courseIDTxtbx.Text = AccountManagementPage.courseId;
            coursenameTxtbx.Text = AccountManagementPage.courseName;

        }

        private void createBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (courseIDTxtbx.Text == "" || coursenameTxtbx.Text == "")
                {
                    MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Check if the course ID is already in the database
                MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM Course WHERE courseID = @courseID", connection);
                command.Parameters.AddWithValue("@courseID", courseIDTxtbx.Text);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Course ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                    return;
                }
                connection.Close();

                //Insert the course into the database
                if (MessageBox.Show("Are you sure you want to create this course?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                connection.Open();
                command = new MySqlCommand("INSERT INTO Course (courseID, courseName) VALUES (@courseID, @courseName)", connection);
                command.Parameters.AddWithValue("@courseID", courseIDTxtbx.Text);
                command.Parameters.AddWithValue("@courseName", coursenameTxtbx.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Course successfully created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AccountManagementPage.instance.refreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void clearBTN_Click(object sender, EventArgs e)
        {
            courseIDTxtbx.Text = "";
            coursenameTxtbx.Text = "";
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            //Check all fields are filled
            if (courseIDTxtbx.Text == "" || coursenameTxtbx.Text == "")
            {
                MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Check if the course ID is in the database
            MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM Course WHERE courseID = @courseID", connection);
            command.Parameters.AddWithValue("@courseID", courseIDTxtbx.Text);
            MySqlDataReader reader = command.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("Course ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                return;
            }
            connection.Close();

            //Delete the course from the database
            if(MessageBox.Show("Are you sure you want to delete this course?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            connection.Open();
            command = new MySqlCommand("DELETE FROM Course WHERE courseID = @courseID", connection);
            command.Parameters.AddWithValue("@courseID", courseIDTxtbx.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Course successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AccountManagementPage.instance.refreshData();


        }
    }
}
