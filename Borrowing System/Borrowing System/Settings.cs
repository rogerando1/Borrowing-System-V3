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

namespace Borrowing_System
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            AccountInfo();
        }

        public void AccountInfo()
        {
            try
            {
                using (MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}"))
                {
                    mySqlConnection.Open();
                    string query = $"SELECT Accounts.*, Person.firstname, Person.lastname FROM Accounts INNER JOIN Person ON Accounts.personID = Person.personID WHERE Accounts.accountID = '{LoginPage.EmployeeID}'";
                    MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                    if (mySqlDataReader.Read())
                    {
                        employeeIDTxtbx.Text = mySqlDataReader["accountID"].ToString();
                        firstnameTxtbx.Text = mySqlDataReader["firstname"].ToString();
                        lastnameTxtbx.Text = mySqlDataReader["lastname"].ToString();
                        positionTxtbx.Text = mySqlDataReader["position"].ToString();
                        usernameTxtbx.Text = mySqlDataReader["username"].ToString();
                        passwordTxtbx.Text = mySqlDataReader["password_"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateInfo()
        {
            try
            {
                if (firstnameTxtbx.Text == "" || lastnameTxtbx.Text == "" || usernameTxtbx.Text == "" || passwordTxtbx.Text == "")
                {
                    MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to update this information?", "Update Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}"))
                    {
                        mySqlConnection.Open();
                        string queryAccounts = $"UPDATE Accounts SET username = '{usernameTxtbx.Text}', password_ = '{passwordTxtbx.Text}' WHERE accountID = '{employeeIDTxtbx.Text}'";
                        MySqlCommand mySqlCommandAccounts = new MySqlCommand(queryAccounts, mySqlConnection);
                        mySqlCommandAccounts.ExecuteNonQuery();

                        string queryPerson = $"UPDATE Person SET firstname = '{firstnameTxtbx.Text}', lastname = '{lastnameTxtbx.Text}' WHERE personID = (SELECT personID FROM Accounts WHERE accountID = '{employeeIDTxtbx.Text}')";
                        MySqlCommand mySqlCommandPerson = new MySqlCommand(queryPerson, mySqlConnection);
                        mySqlCommandPerson.ExecuteNonQuery();
                    }
                    MessageBox.Show("Information updated successfully!", "Information Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void doneBTN_Click(object sender, EventArgs e)
        {
            firstnameTxtbx.ReadOnly = true;
            lastnameTxtbx.ReadOnly = true;
            usernameTxtbx.ReadOnly = true;
            passwordTxtbx.ReadOnly = true;
            updateBTN.Visible = false;
            doneBTN.Visible = false;
            editBTN.Visible = true;
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            usernameTxtbx.ReadOnly = false;
            passwordTxtbx.ReadOnly = false;
            updateBTN.Visible = true;
            doneBTN.Visible = true;
            editBTN.Visible = false;
        }

        private void profileBTN_Click(object sender, EventArgs e)
        {
            aboutBTN.BackColor = Color.White;
            aboutBTN.ForeColor = Color.Black;
            profileBTN.BackColor = Color.FromArgb(162, 199, 230);
            profileBTN.ForeColor = Color.Black;
            this.aboutPanel.Hide();
            this.accountInfoPanel.Show();
            
        }

        private void aboutBTN_Click(object sender, EventArgs e)
        {
            profileBTN.BackColor = Color.White;
            profileBTN.ForeColor = Color.Black;
            aboutBTN.BackColor = Color.FromArgb(162, 199, 230);
            aboutBTN.ForeColor = Color.Black;
            this.accountInfoPanel.Hide();
            this.aboutPanel.Show();
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            if (LoginPage.Position == "Admin")
            {
                AdminPage adminpage = (AdminPage)Application.OpenForms["AdminPage"];
                adminpage.Close();
            }
            else if(LoginPage.Position == "Staff")
            {
                StaffPage staffpage = (StaffPage)Application.OpenForms["StaffPage"];
                staffpage.Close();
            }
            else
            {
                //IN CASE STUDENT FORM WILL BE ADDED
            }


        }

    }
}
