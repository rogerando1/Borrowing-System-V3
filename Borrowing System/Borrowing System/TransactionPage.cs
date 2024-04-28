using Borrowing_System.Data;
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

namespace Borrowing_System
{
    public partial class TransactionPage : Form
    {
        public TransactionPage()
        {
            InitializeComponent();
        }

        private void TransactionPage_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void studentIDTxtbx_TextChanged(object sender, EventArgs e)
        {
            if (studentIDTxtbx.Text.Length == 11)
            {
                if (studentIDTxtbx.Text != "")
                {
                    MySqlConnection connection = null;
                    MySqlDataReader reader = null;

                    try
                    {
                        connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                        connection.Open();

                        MySqlCommand cmd = new MySqlCommand("SELECT CONCAT(IFNULL(Person.firstname, ''), ' ', IFNULL(Person.middleinitial, ''), '. ', IFNULL(Person.lastname, '')) AS personID, program, yearlevel FROM sql6690575.Student " +
                                                            "INNER JOIN Person ON Student.personID = Person.personID " +
                                                            "WHERE studentId = @studentID", connection);
                        cmd.Parameters.AddWithValue("@studentID", studentIDTxtbx.Text);

                        reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            borrowerNameTxtbx.Text = reader["personID"].ToString();
                            courseTxtbx.Text = reader["program"].ToString();
                            yearlevelTxtbx.Text = reader["yearlevel"].ToString();
                        }
                        else
                        {
                            borrowerNameTxtbx.Text = "";
                            courseTxtbx.Text = "";
                            yearlevelTxtbx.Text = "";
                            MessageBox.Show("Student ID not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (reader != null)
                        {
                            reader.Close();
                        }

                        if (connection != null)
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                borrowerNameTxtbx.Text = "";
                courseTxtbx.Text = "";
                yearlevelTxtbx.Text = "";
            }
        }

        private void FillComboBox()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT CONCAT(IFNULL(Person.firstname, ''), ' ', IFNULL(Person.middleinitial, ''), '. ', IFNULL(Person.lastname, '')) AS personID FROM sql6690575.Instructor " +
                                                             "INNER JOIN Person ON Instructor.personID = Person.personID ", connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                    
                while (reader.Read())
                   {
                       string instructorName = reader.GetString("personID");
                       instructorNameTxtbx.Items.Add(instructorName);
                   }                       
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void instructorNameTxtbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (instructorNameTxtbx.SelectedItem == null)
            {
                return;
            }

            string selectedInstructor = instructorNameTxtbx.SelectedItem.ToString();
            MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            connection.Open();
            string query = "SELECT Course.courseID " +
               "FROM Instructor " +
               "INNER JOIN Course ON Instructor.courseID = Course.courseID " +
               "INNER JOIN Person ON Instructor.personID = Person.personID " +
                 "WHERE CONCAT(IFNULL(Person.firstname, ''), ' ', IFNULL(Person.middleinitial, ''), '. ', IFNULL(Person.lastname, '')) = @instructorName";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@instructorName", selectedInstructor);
            MySqlDataReader reader = cmd.ExecuteReader();
   
            while (reader.Read())
            {
                string courseName = reader.GetString("courseID");
                subjectCodeTxtbx.Items.Add(courseName);            
            }

            connection.Close();
        }

        private void courseTimeTxtbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void subjectCodeTxtbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
