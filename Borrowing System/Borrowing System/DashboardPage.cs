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

namespace Borrowing_System
{
    public partial class DashboardPage : Form
    {
        Image normalImage = Properties.Resources.return3;
        Image hoverImage = Properties.Resources.return2;

        public DashboardPage()
        {
            InitializeComponent();
        }

        private void DashboardPage_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        public void refreshData()
        {
            MySqlConnection conn = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");

            MySqlCommand cmd;

            if(LoginPage.Position == "Admin")
            {
                cmd = new MySqlCommand(@"
                SELECT 
                    Transactions.transactionID, 
                    CONCAT(IFNULL(StudentPerson.firstname, ''), ' ', IFNULL(StudentPerson.middleinitial, ''), ' ', IFNULL(StudentPerson.lastname, '')) AS studentName, 
                    CONCAT(IFNULL(InstructorPerson.firstname, ''), ' ', IFNULL(InstructorPerson.middleinitial, ''), ' ', IFNULL(InstructorPerson.lastname, '')) AS instructorName, 
                    CONCAT(IFNULL(AccountsPerson.firstname, ''), ' ', IFNULL(AccountsPerson.middleinitial, ''), ' ', IFNULL(AccountsPerson.lastname, '')) AS accountName,                    
                    Transactions.quantity, 
                    Transactions.orderdate,
                    Transactions.ordertime, 
                    Transactions.status_
                FROM 
                    Transactions 
                INNER JOIN 
                    Student ON Transactions.studentID = Student.studentID 
                INNER JOIN 
                    Person AS StudentPerson ON Student.personID = StudentPerson.personID
                INNER JOIN 
                    Instructor ON Transactions.instructorID = Instructor.instructorID 
                INNER JOIN 
                    Accounts ON Transactions.accountID = Accounts.accountID
                INNER JOIN 
                    Person AS AccountsPerson ON Accounts.personID = AccountsPerson.personID
                INNER JOIN 
                    Person AS InstructorPerson ON Instructor.personID = InstructorPerson.personID", conn);

                cmd.Parameters.AddWithValue("@employeeID", LoginPage.EmployeeID);
            }
            else
            {
                cmd = new MySqlCommand(@"
                    SELECT 
                        Transactions.transactionID, 
                        CONCAT(IFNULL(StudentPerson.firstname, ''), ' ', IFNULL(StudentPerson.middleinitial, ''), ' ', IFNULL(StudentPerson.lastname, '')) AS studentName, 
                        CONCAT(IFNULL(InstructorPerson.firstname, ''), ' ', IFNULL(InstructorPerson.middleinitial, ''), ' ', IFNULL(InstructorPerson.lastname, '')) AS instructorName, 
                        CONCAT(IFNULL(AccountsPerson.firstname, ''), ' ', IFNULL(AccountsPerson.middleinitial, ''), ' ', IFNULL(AccountsPerson.lastname, '')) AS accountName,                       
                        Transactions.quantity, 
                        Transactions.orderdate,
                        Transactions.ordertime, 
                        Transactions.status_
                    FROM 
                        Transactions 
                    INNER JOIN 
                        Student ON Transactions.studentID = Student.studentID 
                    INNER JOIN 
                        Person AS StudentPerson ON Student.personID = StudentPerson.personID
                    INNER JOIN 
                        Instructor ON Transactions.instructorID = Instructor.instructorID 
                    INNER JOIN 
                        Accounts ON Transactions.accountID = Accounts.accountID
                    INNER JOIN 
                        Person AS AccountsPerson ON Accounts.personID = AccountsPerson.personID
                    INNER JOIN 
                        Person AS InstructorPerson ON Instructor.personID = InstructorPerson.personID
                    WHERE 
                        Transactions.accountID = @employeeID OR
                        Transactions.status_ IS NULL", conn);

                cmd.Parameters.AddWithValue("@employeeID", LoginPage.EmployeeID);
            }

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dashboardTable.DataSource = dt;
        }

    }
}
