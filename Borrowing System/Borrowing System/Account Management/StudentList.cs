using Borrowing_System.Data;
using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;

namespace Borrowing_System.Account_Management
{
    public partial class StudentList : UserControl
    {
        public StudentList()
        {
            InitializeComponent();
        }

        public void updateStudentList()
        {
            firstnameTxtbx.Text = AccountManagementPage.studentFirstName;
            middleinitialTxtbx.Text = AccountManagementPage.studentMiddleInitial;
            lastnameTxtbx.Text = AccountManagementPage.studentLastName;
            studentIDTxtbx.Text = AccountManagementPage.studentId;
            courseTxtbx.Text = AccountManagementPage.studentProgram;
            yearlevelTxtbx.Text = AccountManagementPage.studentYearLevel;
        }

        private void uploadBTN_Click(object sender, EventArgs e)
        {
            try
            {
                //Upload CSV and insert first the firstname, middleinitial, and lastname to the Person table and then the studentID as varchar inserted into 'Student' table with foreign key of personID auto increment from the 'Person' table
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "CSV Files|*.csv";
                openFileDialog.Title = "Select a CSV File";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string[] lines = File.ReadAllLines(filePath);
                    string[] fields;
                    string query = "";
                    MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    for (int i = 1; i < lines.Length; i++)
                    {
                        fields = lines[i].Split(',');
                        string studentID = fields[0];
                        string firstname = fields[1];
                        string middleinitial = fields[2];
                        string lastname = fields[3];
                        string program = fields[4];
                        string yearlevel = fields[5];

                        // Check if studentID already exists
                        query = $"SELECT * FROM Student WHERE studentID = '{studentID}'";
                        cmd = new MySqlCommand(query, connection);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            // If studentID already exists, show an error message and stop the process
                            reader.Close();
                            MessageBox.Show($"Duplicate student ID found: {studentID}. Process stopped. You may clean the data and upload the CSV again to proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        reader.Close();

                        // If studentID does not exist, proceed with insertion
                        query = $"INSERT INTO Person (firstname, middleinitial, lastname) VALUES ('{firstname}', '{middleinitial}', '{lastname}')";
                        cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                        query = $"INSERT INTO Student (studentID, program, yearlevel, personID) VALUES ('{studentID}', '{program}', '{yearlevel}', (SELECT personID FROM Person ORDER BY personID DESC LIMIT 1))";
                        cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    MessageBox.Show("Data has been successfully imported", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AccountManagementPage.instance.refreshData();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("DO NOT USE special characters like a comma and please follow the correct excel/csv format: studentID, firstname, middleinitial, lastname, program, and yearlevel as columns respectively.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextBox()
        {
            firstnameTxtbx.Text = "";
            middleinitialTxtbx.Text = "";
            lastnameTxtbx.Text = "";
            studentIDTxtbx.Text = "";
            courseTxtbx.Text = "";
            yearlevelTxtbx.Text = "";
        }

        private void cleanBTN_Click(object sender, EventArgs e)
        {
            //// Delete all data from 'Student' table and also its relation to 'Person' table data
            //DialogResult dialogResult = MessageBox.Show("All data related to all student will be deleted. Are you sure you want to proceed cleaning all the data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            //    connection.Open();

            //    // Get the list of 'PersonID's from the 'Student' table
            //    string query = "SELECT PersonID FROM Student";
            //    MySqlCommand cmd = new MySqlCommand(query, connection);
            //    MySqlDataReader reader = cmd.ExecuteReader();
            //    List<string> personIDs = new List<string>();
            //    while (reader.Read())
            //    {
            //        personIDs.Add(reader["PersonID"].ToString());
            //    }
            //    reader.Close();

            //    // Delete all data from 'Student' table
            //    query = "DELETE FROM Student";
            //    cmd = new MySqlCommand(query, connection);
            //    cmd.ExecuteNonQuery();

            //    // Delete the 'Person' records that have a 'PersonID' in the stored list
            //    foreach (string personID in personIDs)
            //    {
            //        query = $"DELETE FROM Person WHERE PersonID = {personID}";
            //        cmd = new MySqlCommand(query, connection);
            //        cmd.ExecuteNonQuery();
            //    }

            //    connection.Close();
            //    MessageBox.Show("Data has been successfully cleaned", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    AccountManagementPage.instance.refreshData();
            //}


        }

        private void createBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstnameTxtbx.Text) || string.IsNullOrEmpty(lastnameTxtbx.Text) || string.IsNullOrEmpty(studentIDTxtbx.Text) || string.IsNullOrEmpty(courseTxtbx.Text) || string.IsNullOrEmpty(yearlevelTxtbx.Text))
            {
                MessageBox.Show("Please fill up all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string studentID = studentIDTxtbx.Text;
                string firstname = firstnameTxtbx.Text;
                string middleinitial = middleinitialTxtbx.Text;
                string lastname = lastnameTxtbx.Text;
                string program = courseTxtbx.Text;
                string yearlevel = yearlevelTxtbx.Text;
                MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                mySqlConnection.Open();
                string query = $"SELECT * FROM Student WHERE studentID = '{studentID}'";
                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    MessageBox.Show("Student ID already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mySqlConnection.Close();
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to create this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                reader.Close();
                query = $"INSERT INTO Person (firstname, middleinitial, lastname) VALUES ('{firstname}', '{middleinitial}', '{lastname}')";
                cmd = new MySqlCommand(query, mySqlConnection);
                cmd.ExecuteNonQuery();
                query = $"INSERT INTO Student (studentID, program, yearlevel, personID) VALUES ('{studentID}', '{program}', '{yearlevel}', (SELECT personID FROM Person ORDER BY personID DESC LIMIT 1))";
                cmd = new MySqlCommand(query, mySqlConnection);
                cmd.ExecuteNonQuery();
                mySqlConnection.Close();
                MessageBox.Show("Student has been successfully created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AccountManagementPage.instance.refreshData();
                ClearTextBox();
            }

        }

        public void clearBTN_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstnameTxtbx.Text) || string.IsNullOrEmpty(lastnameTxtbx.Text) || string.IsNullOrEmpty(studentIDTxtbx.Text) || string.IsNullOrEmpty(courseTxtbx.Text) || string.IsNullOrEmpty(yearlevelTxtbx.Text))
            {
                MessageBox.Show("Please fill up all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string studentID = studentIDTxtbx.Text;
                string firstname = firstnameTxtbx.Text;
                string middleinitial = middleinitialTxtbx.Text;
                string lastname = lastnameTxtbx.Text;
                string program = courseTxtbx.Text;
                string yearlevel = yearlevelTxtbx.Text;
                MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                mySqlConnection.Open();
                string query = $"SELECT * FROM Student WHERE studentID = '{studentID}'";
                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    reader.Close();
                    MessageBox.Show("Student ID does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mySqlConnection.Close();
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                reader.Close();
                query = $"UPDATE Person SET firstname = '{firstname}', middleinitial = '{middleinitial}', lastname = '{lastname}' WHERE personID = (SELECT personID FROM Student WHERE studentID = '{studentID}')";
                cmd = new MySqlCommand(query, mySqlConnection);
                cmd.ExecuteNonQuery();
                query = $"UPDATE Student SET program = '{program}', yearlevel = '{yearlevel}' WHERE studentID = '{studentID}'";
                cmd = new MySqlCommand(query, mySqlConnection);
                cmd.ExecuteNonQuery();
                mySqlConnection.Close();
                MessageBox.Show("Student has been successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AccountManagementPage.instance.refreshData();
                ClearTextBox();
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            //Delete student data from 'Student' table and also its relation to 'Person' table data
            if (string.IsNullOrEmpty(firstnameTxtbx.Text) || string.IsNullOrEmpty(lastnameTxtbx.Text) || string.IsNullOrEmpty(studentIDTxtbx.Text) || string.IsNullOrEmpty(courseTxtbx.Text) || string.IsNullOrEmpty(yearlevelTxtbx.Text))
            {
                MessageBox.Show("Please fill up all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string studentID = studentIDTxtbx.Text;
                MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                mySqlConnection.Open();
                string query = $"SELECT * FROM Student WHERE studentID = '{studentID}'";
                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    reader.Close();
                    MessageBox.Show("Student ID does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mySqlConnection.Close();
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                reader.Close();
                query = $"DELETE FROM Person WHERE personID = (SELECT personID FROM Student WHERE studentID = '{studentID}')";
                cmd = new MySqlCommand(query, mySqlConnection);
                cmd.ExecuteNonQuery();
                query = $"DELETE FROM Student WHERE studentID = '{studentID}'";
                cmd = new MySqlCommand(query, mySqlConnection);
                cmd.ExecuteNonQuery();
                mySqlConnection.Close();
                MessageBox.Show("Student has been successfully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AccountManagementPage.instance.refreshData();
                ClearTextBox();
            }

        }
    }
}
