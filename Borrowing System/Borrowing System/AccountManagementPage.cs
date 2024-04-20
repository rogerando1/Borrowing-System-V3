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
using System.Data.SqlClient;

namespace Borrowing_System
{
    public partial class AccountManagementPage : Form
    {
        public AccountManagementPage()
        {
            InitializeComponent();
        }

        private void AccountManagementPage_Load(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT Person.personID, Person.firstname, Person.middleinitial, Person.lastname, Accounts.username, Accounts.password_, Accounts.position FROM Person INNER JOIN Accounts ON Person.personID = Accounts.personID", mySqlConnection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            accountData.DataSource = dataTable;
            mySqlConnection.Close();

        }

        private void accountData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.accountData.Rows[e.RowIndex];
                personIDTxtbx.Text = row.Cells["personID"].Value.ToString();
                fnameTxtbx.Text = row.Cells["firstname"].Value.ToString();
                minitialTxtbx.Text = row.Cells["middleinitial"].Value.ToString();
                lnameTxtbx.Text = row.Cells["lastname"].Value.ToString();
                usernameTxtbx.Text = row.Cells["username"].Value.ToString();
                passwordTxtbx.Text = row.Cells["password_"].Value.ToString();
                positionCmbx.Text = row.Cells["position"].Value.ToString();
            }
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand($"SELECT Person.personID, Person.firstname, Person.middleinitial, Person.lastname, Accounts.username, Accounts.password_, Accounts.position FROM Person INNER JOIN Accounts ON Person.personID = Accounts.personID WHERE Person.firstname LIKE '%{searchData.Text}%' OR Person.lastname LIKE '%{searchData.Text}%' OR Accounts.username LIKE '%{searchData.Text} %' OR Accounts.position LIKE '% {searchData.Text}%'", mySqlConnection);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                accountData.DataSource = dataTable;
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchData_TextChanged(object sender, EventArgs e)
        {
            if (searchData.Text == "")
            {
                AccountManagementPage_Load(sender, e);
            }

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
                    AccountManagementPage_Load(sender, e);
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
                //IF username already exist, show error message
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
                    AccountManagementPage_Load(sender, e);
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

        private void clearBtn_Click(object sender, EventArgs e)
        {
            personIDTxtbx.Text = "";
            fnameTxtbx.Text = "";
            minitialTxtbx.Text = "";
            lnameTxtbx.Text = "";
            usernameTxtbx.Text = "";
            passwordTxtbx.Text = "";
            positionCmbx.SelectedIndex = -1;
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
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
                    AccountManagementPage_Load(sender, e);
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
