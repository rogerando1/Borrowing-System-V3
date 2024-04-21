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
        public static AccountManagementPage instance;
        public static string employeePersonID { get; set; }
        public static string employeeFname { get; set; }
        public static string employeeMinitial { get; set; }
        public static string employeeLname { get; set; }
        public static string employeeUsername { get; set; }
        public static string employeePassword { get; set; }
        public static string employeePosition { get; set; }


        public AccountManagementPage()
        {
            InitializeComponent();
            instance = this;
        }

        private void AccountManagementPage_Load(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT Person.personID, Person.firstname, Person.middleinitial, Person.lastname, Accounts.username, Accounts.password_, Accounts.position FROM Person INNER JOIN Accounts ON Person.personID = Accounts.personID", mySqlConnection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            employeeData.DataSource = dataTable;
            mySqlConnection.Close();

        }

        public void refreshData()
        {
            //Refresh Employee List Data
            MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT Person.personID, Person.firstname, Person.middleinitial, Person.lastname, Accounts.username, Accounts.password_, Accounts.position FROM Person INNER JOIN Accounts ON Person.personID = Accounts.personID", mySqlConnection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            employeeData.DataSource = dataTable;
            mySqlConnection.Close();

            //Refresh Instructor List Data

            //Refresh Student List Data

            //Refresh Course List Data
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            try
            {

                if(employeeBTN.BackColor == Color.FromArgb(252, 168, 115))
                {
                    //SEARCH EMPLOYEE
                    MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand($"SELECT Person.personID, Person.firstname, Person.middleinitial, Person.lastname, Accounts.username, Accounts.password_, Accounts.position FROM Person INNER JOIN Accounts ON Person.personID = Accounts.personID WHERE Person.firstname LIKE '%{searchData.Text}%' OR Person.lastname LIKE '%{searchData.Text}%' OR Accounts.username LIKE '%{searchData.Text} %' OR Accounts.position LIKE '% {searchData.Text}%'", mySqlConnection);
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                    DataTable dataTable = new DataTable();
                    mySqlDataAdapter.Fill(dataTable);
                    employeeData.DataSource = dataTable;
                    mySqlConnection.Close();
                }
                else if (studentBTN.BackColor == Color.FromArgb(252, 168, 115))
                {
                    //SEARCH STUDENT
                }
                else if (instructorBTN.BackColor == Color.FromArgb(252, 168, 115))
                {
                    //SEARCH INSTRUCTOR
                }
                else
                {
                    //SEARCH COURSE
                }

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

        private void employeeBTN_Click(object sender, EventArgs e)
        {
            employeeList1.BringToFront();
            studentBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            instructorBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            courseBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            employeeBTN.BackColor = Color.FromArgb(252, 168, 115); //SELECTED
            employeeData.BringToFront();
        }

        private void studentBTN_Click(object sender, EventArgs e)
        {
            studentList1.BringToFront();
            studentBTN.BackColor = Color.FromArgb(252, 168, 115); //SELECTED
            instructorBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            courseBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            employeeBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            studentData.BringToFront();
        }

        private void instructorBTN_Click(object sender, EventArgs e)
        {
            instructorList1.BringToFront();
            studentBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            instructorBTN.BackColor = Color.FromArgb(252, 168, 115); //SELECTED
            courseBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            employeeBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            instructorData.BringToFront();
        }

        private void courseBTN_Click(object sender, EventArgs e)
        {
            courseList1.BringToFront();
            studentBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            instructorBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            courseBTN.BackColor = Color.FromArgb(252, 168, 115); //SELECTED
            employeeBTN.BackColor = Color.FromArgb(233, 215, 174); //NOT SELECTED
            courseData.BringToFront();
        }

        private void employeeData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.employeeData.Rows[e.RowIndex];
                employeePersonID = row.Cells["personID"].Value.ToString();
                employeeFname = row.Cells["firstname"].Value.ToString();
                employeeMinitial = row.Cells["middleinitial"].Value.ToString();
                employeeLname = row.Cells["lastname"].Value.ToString();
                employeeUsername = row.Cells["username"].Value.ToString();
                employeePassword = row.Cells["password_"].Value.ToString();
                employeePosition = row.Cells["position"].Value.ToString();
                employeeList1.updateEmployeeList();
            }
        }
    }
}
