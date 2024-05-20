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
using MySql.Data.MySqlClient;

namespace Borrowing_System.Account_Management
{
    public partial class InstructorList : UserControl
    {
        public InstructorList()
        {
            InitializeComponent();
        }

        private void InstructorList_Load(object sender, EventArgs e)
        {

        }

        public void updateInstructorList()
        {
            instructorID.Text = AccountManagementPage.instructorId1;
            firstname.Text = AccountManagementPage.instructor1Firstname;
            middleinitial.Text = AccountManagementPage.instructor1MiddleInitial;
            lastname.Text = AccountManagementPage.instructor1Lastname;
        }

        private void ClearTextBox()
        {
            instructorID.Text = "";
            firstname.Text = "";
            middleinitial.Text = "";
            lastname.Text = "";
        }

        private void createBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstname.Text) || string.IsNullOrEmpty(lastname.Text) || string.IsNullOrEmpty(instructorID.Text))
            {
                MessageBox.Show("Please fill up all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string instructorID = this.instructorID.Text;
                string firstname = this.firstname.Text;
                string middleinitial = this.middleinitial.Text;
                string lastname = this.lastname.Text;
                MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                mySqlConnection.Open();
                string query = $"SELECT * FROM Instructor WHERE instructorID = '{instructorID}'";
                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    MessageBox.Show("Instructor ID already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mySqlConnection.Close();
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to create this instructor?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                reader.Close();
                query = $"INSERT INTO Person (firstname, middleinitial, lastname) VALUES ('{firstname}', '{middleinitial}', '{lastname}')";
                cmd = new MySqlCommand(query, mySqlConnection);
                cmd.ExecuteNonQuery();
                query = $"INSERT INTO Instructor (instructorID, personID) VALUES ('{instructorID}', (SELECT personID FROM Person ORDER BY personID DESC LIMIT 1))";
                cmd = new MySqlCommand(query, mySqlConnection);
                cmd.ExecuteNonQuery();
                mySqlConnection.Close();
                MessageBox.Show("Instructor has been successfully created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AccountManagementPage.instance.refreshData();
                ClearTextBox();
            }


        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstname.Text) || string.IsNullOrEmpty(lastname.Text) || string.IsNullOrEmpty(instructorID.Text))
            {
                MessageBox.Show("Please fill up all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string instructorID = this.instructorID.Text;
                string firstname = this.firstname.Text;
                string middleinitial = this.middleinitial.Text;
                string lastname = this.lastname.Text;
                MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                mySqlConnection.Open();
                string query = $"SELECT * FROM Instructor WHERE instructorID = '{instructorID}'";
                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    reader.Close();
                    MessageBox.Show("Instructor ID does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mySqlConnection.Close();
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this instructor?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                reader.Close();
                query = $"UPDATE Person SET firstname = '{firstname}', middleinitial = '{middleinitial}', lastname = '{lastname}' WHERE personID = (SELECT personID FROM Instructor WHERE instructorID = '{instructorID}')";
                cmd = new MySqlCommand(query, mySqlConnection);
                cmd.ExecuteNonQuery();
                mySqlConnection.Close();
                MessageBox.Show("Instructor has been successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AccountManagementPage.instance.refreshData();
                ClearTextBox();
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstname.Text) || string.IsNullOrEmpty(lastname.Text) || string.IsNullOrEmpty(instructorID.Text))
            {
                MessageBox.Show("Please fill up all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string instructorID = this.instructorID.Text;
                MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                mySqlConnection.Open();
                string query = $"SELECT * FROM Instructor WHERE instructorID = '{instructorID}'";
                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    reader.Close();
                    MessageBox.Show("Instructor ID does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mySqlConnection.Close();
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this instructor?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                reader.Close();
                query = $"DELETE FROM Person WHERE personID = (SELECT personID FROM Instructor WHERE instructorID = '{instructorID}')";
                cmd = new MySqlCommand(query, mySqlConnection);
                cmd.ExecuteNonQuery();
                query = $"DELETE FROM Instructor WHERE instructorID = '{instructorID}'";
                cmd = new MySqlCommand(query, mySqlConnection);
                cmd.ExecuteNonQuery();
                mySqlConnection.Close();
                MessageBox.Show("Instructor has been successfully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AccountManagementPage.instance.refreshData();
                ClearTextBox();
            }
        }

        public void clearBTN_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }
    }
}
