using Borrowing_System.Data;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Borrowing_System.Account_Management
{
    public partial class EmployeeList : UserControl
    {
        public EmployeeList()
        {
            InitializeComponent();
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {

        }

        public void updateEmployeeList()
        {
            personIDTxtbx.Text = AccountManagementPage.employeePersonID;
            fnameTxtbx.Text = AccountManagementPage.employeeFname;
            minitialTxtbx.Text = AccountManagementPage.employeeMinitial;
            lnameTxtbx.Text = AccountManagementPage.employeeLname;
            usernameTxtbx.Text = AccountManagementPage.employeeUsername;
            passwordTxtbx.Text = AccountManagementPage.employeePassword;
            positionCmbx.Text = AccountManagementPage.employeePosition;
        }

        public void clearBtn_Click(object sender, EventArgs e)
        {
            personIDTxtbx.Text = "";
            fnameTxtbx.Text = "";
            minitialTxtbx.Text = "";
            lnameTxtbx.Text = "";
            usernameTxtbx.Text = "";
            passwordTxtbx.Text = "";
            positionCmbx.SelectedIndex = -1;
        }

        private void createBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (fnameTxtbx.Text == "" || lnameTxtbx.Text == "" || usernameTxtbx.Text == "" || passwordTxtbx.Text == "" || positionCmbx.Text == "")
                {
                    MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                personIDTxtbx.Text = null;
                //If ID already exists, show error message
                MySqlConnection conn = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                conn.Open();
                MySqlCommand command = new MySqlCommand($"SELECT * FROM Person WHERE personID = '{personIDTxtbx.Text}'", conn);
                MySqlDataReader mySqlDataReader = command.ExecuteReader();
                if (mySqlDataReader.Read())
                {
                    MessageBox.Show("Person ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                conn.Close();

                //If username already exists, show error message
                conn.Open();
                command = new MySqlCommand($"SELECT * FROM Accounts WHERE username = '{usernameTxtbx.Text}'", conn);
                mySqlDataReader = command.ExecuteReader();
                if (mySqlDataReader.Read())
                {
                    MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    personIDTxtbx.Text = "";
                    fnameTxtbx.Text = "";
                    minitialTxtbx.Text = "";
                    lnameTxtbx.Text = "";
                    usernameTxtbx.Text = "";
                    passwordTxtbx.Text = "";
                    positionCmbx.SelectedIndex = -1;
                    return;
                }
                conn.Close();


                if (MessageBox.Show("Are you sure you want to create this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand($"INSERT INTO Person (firstname, middleinitial, lastname) VALUES ('{fnameTxtbx.Text}', '{minitialTxtbx.Text}', '{lnameTxtbx.Text}'); SELECT LAST_INSERT_ID();", mySqlConnection);
                    var personID = mySqlCommand.ExecuteScalar();
                    mySqlConnection.Close();

                    mySqlConnection.Open();
                    mySqlCommand = new MySqlCommand($"INSERT INTO Accounts (personID, username, password_, position) VALUES ('{personID}', '{usernameTxtbx.Text}', '{passwordTxtbx.Text}', '{positionCmbx.Text}')", mySqlConnection);
                    mySqlCommand.ExecuteNonQuery();
                    mySqlConnection.Close();

                    MessageBox.Show("Account created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AccountManagementPage.instance.refreshData();
                    personIDTxtbx.Text = "";
                    fnameTxtbx.Text = "";
                    minitialTxtbx.Text = "";
                    lnameTxtbx.Text = "";
                    usernameTxtbx.Text = "";
                    passwordTxtbx.Text = "";
                    positionCmbx.SelectedIndex = -1;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (fnameTxtbx.Text == "" || lnameTxtbx.Text == "" || usernameTxtbx.Text == "" || passwordTxtbx.Text == "" || positionCmbx.Text == "")
                {
                    MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (usernameTxtbx.Text != AccountManagementPage.employeeUsername)
                {
                    MySqlConnection conn = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    conn.Open();
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM Accounts WHERE username = '{usernameTxtbx.Text}'", conn);
                    MySqlDataReader mySqlDataReader = command.ExecuteReader();
                    if (mySqlDataReader.Read())
                    {
                        MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    conn.Close();
                }



                if (MessageBox.Show("Are you sure you want to update this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand($"UPDATE Person SET firstname = '{fnameTxtbx.Text}', middleinitial = '{minitialTxtbx.Text}', lastname = '{lnameTxtbx.Text}' WHERE personID = '{personIDTxtbx.Text}'", mySqlConnection);
                    mySqlCommand.ExecuteNonQuery();
                    mySqlCommand = new MySqlCommand($"UPDATE Accounts SET username = '{usernameTxtbx.Text}', password_ = '{passwordTxtbx.Text}', position = '{positionCmbx.Text}' WHERE personID = '{personIDTxtbx.Text}'", mySqlConnection);
                    mySqlCommand.ExecuteNonQuery();
                    mySqlConnection.Close();
                    MessageBox.Show("Account updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AccountManagementPage.instance.refreshData();
                    personIDTxtbx.Text = "";
                    fnameTxtbx.Text = "";
                    minitialTxtbx.Text = "";
                    lnameTxtbx.Text = "";
                    usernameTxtbx.Text = "";
                    passwordTxtbx.Text = "";
                    positionCmbx.SelectedIndex = -1;
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
                if (personIDTxtbx.Text == "" || fnameTxtbx.Text == "" || lnameTxtbx.Text == "" || usernameTxtbx.Text == "" || passwordTxtbx.Text == "" || positionCmbx.Text == "")
                {
                    MessageBox.Show("Please select an account to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to delete this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand($"DELETE FROM Person WHERE personID = '{personIDTxtbx.Text}'", mySqlConnection);
                    mySqlCommand.ExecuteNonQuery();
                    mySqlCommand = new MySqlCommand($"DELETE FROM Accounts WHERE personID = '{personIDTxtbx.Text}'", mySqlConnection);
                    mySqlCommand.ExecuteNonQuery();
                    mySqlConnection.Close();
                    MessageBox.Show("Account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AccountManagementPage.instance.refreshData();
                    personIDTxtbx.Text = "";
                    fnameTxtbx.Text = "";
                    minitialTxtbx.Text = "";
                    lnameTxtbx.Text = "";
                    usernameTxtbx.Text = "";
                    passwordTxtbx.Text = "";
                    positionCmbx.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
