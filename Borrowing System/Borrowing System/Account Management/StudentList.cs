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
using System.IO;

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
                MessageBox.Show("Please follow the correct excel/csv format: studentID, firstname, middleinitial, lastname, program, and yearlevel as columns respectively.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cleanBTN_Click(object sender, EventArgs e)
        {
            // Delete all data from 'Student' table and also its relation to 'Person' table data
            DialogResult dialogResult = MessageBox.Show("All data related to all student will be deleted. Are you sure you want to proceed cleaning all the data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                connection.Open();

                // Get the list of 'PersonID's from the 'Student' table
                string query = "SELECT PersonID FROM Student";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                List<string> personIDs = new List<string>();
                while (reader.Read())
                {
                    personIDs.Add(reader["PersonID"].ToString());
                }
                reader.Close();

                // Delete all data from 'Student' table
                query = "DELETE FROM Student";
                cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                // Delete the 'Person' records that have a 'PersonID' in the stored list
                foreach (string personID in personIDs)
                {
                    query = $"DELETE FROM Person WHERE PersonID = {personID}";
                    cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }

                connection.Close();
                MessageBox.Show("Data has been successfully cleaned", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AccountManagementPage.instance.refreshData();
            }


        }
    }
}
