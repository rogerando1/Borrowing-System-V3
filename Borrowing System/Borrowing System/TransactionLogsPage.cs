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
    public partial class TransactionLogsPage : Form
    {
        public TransactionLogsPage()
        {
            InitializeComponent();
        }

        private void TransactionLogsPage_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        public void refreshData()
        {
            MySqlConnection conn = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");

            MySqlCommand cmd;

            if (LoginPage.Position == "Admin")
            {
                cmd = new MySqlCommand(@"
                    SELECT 
                        TransactionLogs.transactionlogID,
                        CONCAT(IFNULL(StudentPerson.firstname, ''), ' ', IFNULL(StudentPerson.middleinitial, ''), ' ', IFNULL(StudentPerson.lastname, '')) AS studentName, 
                        CONCAT(IFNULL(InstructorPerson.firstname, ''), ' ', IFNULL(InstructorPerson.middleinitial, ''), ' ', IFNULL(InstructorPerson.lastname, '')) AS instructorName, 
                        CONCAT(IFNULL(AccountsPerson.firstname, ''), ' ', IFNULL(AccountsPerson.middleinitial, ''), ' ', IFNULL(AccountsPerson.lastname, '')) AS accountName,                    
                        Part.partname,
                        Transactions.quantity, 
                        TransactionLogs.returndate,
                        TransactionLogs.returntime, 
                        TransactionLogs.notes
                    FROM 
                        TransactionLogs
                    INNER JOIN 
                        Transactions ON TransactionLogs.transactionID = Transactions.transactionID
                    INNER JOIN 
                        Student ON Transactions.studentID = Student.studentID
                    INNER JOIN
                        Instructor ON Transactions.instructorID = Instructor.instructorID
                    INNER JOIN
                        Accounts ON Transactions.accountID = Accounts.accountID
                    INNER JOIN 
                        Person AS StudentPerson ON Student.personID = StudentPerson.personID
                    INNER JOIN 
                        Person AS InstructorPerson ON Instructor.personID = InstructorPerson.personID 
                    INNER JOIN 
                        Person AS AccountsPerson ON Accounts.personID = AccountsPerson.personID
                    INNER JOIN
                        Part ON Transactions.partID = Part.partID
                    WHERE Transactions.status_ IS NOT NULL", conn);
            }
            else
            {
                cmd = new MySqlCommand(@"
                    SELECT 
                        TransactionLogs.transactionlogID,
                        CONCAT(IFNULL(StudentPerson.firstname, ''), ' ', IFNULL(StudentPerson.middleinitial, ''), ' ', IFNULL(StudentPerson.lastname, '')) AS studentName, 
                        CONCAT(IFNULL(InstructorPerson.firstname, ''), ' ', IFNULL(InstructorPerson.middleinitial, ''), ' ', IFNULL(InstructorPerson.lastname, '')) AS instructorName, 
                        CONCAT(IFNULL(AccountsPerson.firstname, ''), ' ', IFNULL(AccountsPerson.middleinitial, ''), ' ', IFNULL(AccountsPerson.lastname, '')) AS accountName,                    
                        Part.partname,
                        Transactions.quantity, 
                        TransactionLogs.returndate,
                        TransactionLogs.returntime, 
                        TransactionLogs.notes
                    FROM 
                        TransactionLogs
                    INNER JOIN 
                        Transactions ON TransactionLogs.transactionID = Transactions.transactionID
                    INNER JOIN 
                        Student ON Transactions.studentID = Student.studentID
                    INNER JOIN
                        Instructor ON Transactions.instructorID = Instructor.instructorID
                    INNER JOIN
                        Accounts ON Transactions.accountID = Accounts.accountID
                    INNER JOIN 
                        Person AS StudentPerson ON Student.personID = StudentPerson.personID
                    INNER JOIN 
                        Person AS InstructorPerson ON Instructor.personID = InstructorPerson.personID 
                    INNER JOIN 
                        Person AS AccountsPerson ON Accounts.personID = AccountsPerson.personID
                    INNER JOIN
                        Part ON Transactions.partID = Part.partID
                    WHERE Transactions.status_ IS NOT NULL AND Transactions.accountID = @accountID", conn);
                cmd.Parameters.AddWithValue("@accountID", LoginPage.EmployeeID);
            }

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            logsTable.DataSource = dt;
        }


        private void searchLogData(string search)
        {
            MySqlCommand cmd;

            if(LoginPage.Position == "Admin")
            {
                MySqlConnection conn = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                cmd = new MySqlCommand(@"
            SELECT 
                        TransactionLogs.transactionlogID,
                        CONCAT(IFNULL(StudentPerson.firstname, ''), ' ', IFNULL(StudentPerson.middleinitial, ''), ' ', IFNULL(StudentPerson.lastname, '')) AS studentName, 
                        CONCAT(IFNULL(InstructorPerson.firstname, ''), ' ', IFNULL(InstructorPerson.middleinitial, ''), ' ', IFNULL(InstructorPerson.lastname, '')) AS instructorName, 
                        CONCAT(IFNULL(AccountsPerson.firstname, ''), ' ', IFNULL(AccountsPerson.middleinitial, ''), ' ', IFNULL(AccountsPerson.lastname, '')) AS accountName,                    
                        Part.partname,
                        Transactions.quantity, 
                        TransactionLogs.returndate,
                        TransactionLogs.returntime, 
                        TransactionLogs.notes
                    FROM 
                        TransactionLogs
                    INNER JOIN 
                        Transactions ON TransactionLogs.transactionID = Transactions.transactionID
                    INNER JOIN 
                        Student ON Transactions.studentID = Student.studentID
                    INNER JOIN
                        Instructor ON Transactions.instructorID = Instructor.instructorID
                    INNER JOIN
                        Accounts ON Transactions.accountID = Accounts.accountID
                    INNER JOIN 
                        Person AS StudentPerson ON Student.personID = StudentPerson.personID
                    INNER JOIN 
                        Person AS InstructorPerson ON Instructor.personID = InstructorPerson.personID 
                    INNER JOIN 
                        Person AS AccountsPerson ON Accounts.personID = AccountsPerson.personID
                    INNER JOIN
                        Part ON Transactions.partID = Part.partID
                    WHERE Transactions.status_ IS NOT NULL AND 
                        (CONCAT(IFNULL(StudentPerson.firstname, ''), ' ', IFNULL(StudentPerson.middleinitial, ''), ' ', IFNULL(StudentPerson.lastname, '')) LIKE @search OR 
                        CONCAT(IFNULL(InstructorPerson.firstname, ''), ' ', IFNULL(InstructorPerson.middleinitial, ''), ' ', IFNULL(InstructorPerson.lastname, '')) LIKE @search OR 
                        CONCAT(IFNULL(AccountsPerson.firstname, ''), ' ', IFNULL(AccountsPerson.middleinitial, ''), ' ', IFNULL(AccountsPerson.lastname, '')) LIKE @search OR 
                        Part.partname LIKE @search OR 
                        TransactionLogs.returndate LIKE @search OR 
                        TransactionLogs.returntime LIKE @search OR 
                        TransactionLogs.notes LIKE @search)", conn);
                
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
            }
            else
            {
                //Search Filter: Staff
                MySqlConnection conn = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                cmd = new MySqlCommand(@"
                SELECT 
                        TransactionLogs.transactionlogID,
                        CONCAT(IFNULL(StudentPerson.firstname, ''), ' ', IFNULL(StudentPerson.middleinitial, ''), ' ', IFNULL(StudentPerson.lastname, '')) AS studentName, 
                        CONCAT(IFNULL(InstructorPerson.firstname, ''), ' ', IFNULL(InstructorPerson.middleinitial, ''), ' ', IFNULL(InstructorPerson.lastname, '')) AS instructorName, 
                        CONCAT(IFNULL(AccountsPerson.firstname, ''), ' ', IFNULL(AccountsPerson.middleinitial, ''), ' ', IFNULL(AccountsPerson.lastname, '')) AS accountName,                    
                        Part.partname,
                        Transactions.quantity, 
                        TransactionLogs.returndate,
                        TransactionLogs.returntime, 
                        TransactionLogs.notes
                    FROM 
                        TransactionLogs
                    INNER JOIN 
                        Transactions ON TransactionLogs.transactionID = Transactions.transactionID
                    INNER JOIN 
                        Student ON Transactions.studentID = Student.studentID
                    INNER JOIN
                        Instructor ON Transactions.instructorID = Instructor.instructorID
                    INNER JOIN
                        Accounts ON Transactions.accountID = Accounts.accountID
                    INNER JOIN 
                        Person AS StudentPerson ON Student.personID = StudentPerson.personID
                    INNER JOIN 
                        Person AS InstructorPerson ON Instructor.personID = InstructorPerson.personID 
                    INNER JOIN 
                        Person AS AccountsPerson ON Accounts.personID = AccountsPerson.personID
                    INNER JOIN
                        Part ON Transactions.partID = Part.partID
                    WHERE Transactions.status_ IS NOT NULL AND Transactions.accountID = @accountID AND 
                        (CONCAT(IFNULL(StudentPerson.firstname, ''), ' ', IFNULL(StudentPerson.middleinitial, ''), ' ', IFNULL(StudentPerson.lastname, '')) LIKE @search OR 
                        CONCAT(IFNULL(InstructorPerson.firstname, ''), ' ', IFNULL(InstructorPerson.middleinitial, ''), ' ', IFNULL(InstructorPerson.lastname, '')) LIKE @search OR 
                        CONCAT(IFNULL(AccountsPerson.firstname, ''), ' ', IFNULL(AccountsPerson.middleinitial, ''), ' ', IFNULL(AccountsPerson.lastname, '')) LIKE @search OR 
                        Part.partname LIKE @search OR 
                        TransactionLogs.returndate LIKE @search OR 
                        TransactionLogs.returntime LIKE @search OR 
                        TransactionLogs.notes LIKE @search)", conn);
                cmd.Parameters.AddWithValue("@accountID", LoginPage.EmployeeID);
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
            }


            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            logsTable.DataSource = dt;
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            string search = searchData.Text;
            searchLogData(search);
        }

        private void searchData_TextChanged(object sender, EventArgs e)
        {
            if(searchData.Text == "")
            {
                refreshData();
            }
        }

        private void searchData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBTN.PerformClick();
            }
        }
    }
}
