using Borrowing_System.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Borrowing_System
{
    public partial class TransactionPage : Form
    {
        Image normalImage = Properties.Resources.delete1;
        Image hoverImage = Properties.Resources.delete2;
        private DataGridViewCell selectedCell = null;

        public TransactionPage()
        {
            InitializeComponent();
        }

        private void TransactionPage_Load(object sender, EventArgs e)
        {
            FillComboBox();
            FillProductComboBox();

            refreshData();
            subjectnameLabel.Text = "";
            availableLabel.Text = "";
            typeTxtbx.Enabled = false;
            subjectCodeTxtbx.Enabled = false;
            if (LoginPage.Position == "Admin")
            {
                FillStaffComboBox();
                staffCmbx.Visible = true;
                clearCart.Visible = true;
            }
            else
            {
                staffCmbx.Visible = false;
                clearCart.Visible = false;
            }
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

                        MySqlCommand cmd = new MySqlCommand("SELECT CONCAT(IFNULL(Person.firstname, ''), ' ', IFNULL(Person.middleinitial, ''), '. ', IFNULL(Person.lastname, '')) AS personID, program, yearlevel FROM Student " +
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
                MySqlCommand cmd = new MySqlCommand("SELECT CONCAT(IFNULL(Person.firstname, ''), ' ', IFNULL(Person.middleinitial, ''), '. ', IFNULL(Person.lastname, '')) AS personID FROM Instructor " +
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

        private void FillProductComboBox()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT productName FROM Product", connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string productName = reader.GetString("productName");
                    equipmentNameTxtbx.Items.Add(productName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillStaffComboBox()
        {
            try
            {
                //Show all staff/admin in the combobox
                MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT CONCAT(IFNULL(Person.firstname, ''), ' ', IFNULL(Person.middleinitial, ''), '. ', IFNULL(Person.lastname, '')) AS personID FROM Accounts " +
                                                                                "INNER JOIN Person ON Accounts.personID = Person.personID ", connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    string staffName = reader.GetString("personID");
                    staffCmbx.Items.Add(staffName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void instructorNameTxtbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            subjectCodeTxtbx.SelectedIndex = -1;
            subjectnameLabel.Text = "";

            if (instructorNameTxtbx.Text == "")
            {
                subjectCodeTxtbx.Enabled = false;
                return;
            }
            else
            {
                MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                connection.Open();
                string query = "SELECT CourseTime.courseID, CourseTime.section " +
                   "FROM CourseTime " +
                   "INNER JOIN Instructor ON CourseTime.instructorID = Instructor.instructorID " +
                   "INNER JOIN Person ON Instructor.personID = Person.personID " +
                   "WHERE CONCAT(IFNULL(Person.firstname, ''), ' ', IFNULL(Person.middleinitial, ''), '. ', IFNULL(Person.lastname, '')) = @instructorName";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@instructorName", instructorNameTxtbx.SelectedItem.ToString());
                MySqlDataReader reader = cmd.ExecuteReader();
                subjectCodeTxtbx.Items.Clear();
                while (reader.Read())
                {
                    string courseID = reader.GetString("courseID");
                    string section = reader.GetString("section");
                    subjectCodeTxtbx.Items.Add(courseID + " - " + section);
                }
                connection.Close();
                subjectCodeTxtbx.Enabled = true;

            }
        }

        private void subjectCodeTxtbx_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (subjectCodeTxtbx.Text == "")
            {
                return;
            }

            else
            {
                string selectedCourse = subjectCodeTxtbx.SelectedItem.ToString().Split('-')[0].Trim();
                MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                connection.Open();
                string query = "SELECT Course.courseName " +
                   "FROM CourseTime " +
                   "INNER JOIN Course ON CourseTime.courseID = Course.courseID " +
                   "WHERE CourseTime.courseID = @courseID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@courseID", selectedCourse);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    subjectnameLabel.Text = reader.GetString("courseName");
                }
                connection.Close();
            }
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            studentIDTxtbx.Text = "";
            borrowerNameTxtbx.Text = "";
            courseTxtbx.Text = "";
            yearlevelTxtbx.Text = "";
            instructorNameTxtbx.SelectedIndex = -1;
            subjectCodeTxtbx.SelectedIndex = -1;
            equipmentNameTxtbx.SelectedIndex = -1;
            typeTxtbx.SelectedIndex = -1;
            subjectnameLabel.Text = "";
            quantityTxtbx.Value = 0;
            availableLabel.Text = "";
        }

        private void equipmentNameTxtbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            availableLabel.Text = "";

            if (equipmentNameTxtbx.Text == "")
            {
                typeTxtbx.Enabled = false;
                return;
            }

            else
            {
                typeTxtbx.Enabled = true;
                //Display the parts of the selected product in the Type ComboBox
                MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                connection.Open();
                string query = "SELECT Part.partname " +
                   "FROM Part " +
                   "INNER JOIN Product ON Part.productID = Product.productID " +
                   "WHERE Product.productName = @productName";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@productName", equipmentNameTxtbx.SelectedItem.ToString());
                MySqlDataReader reader = cmd.ExecuteReader();
                typeTxtbx.Items.Clear();
                while (reader.Read())
                {
                    string partName = reader.GetString("partName");
                    typeTxtbx.Items.Add(partName);
                }
                connection.Close();

            }
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            if(LoginPage.Position == "Admin")
            {
                if(staffCmbx.Text == "")
                {
                    MessageBox.Show("Please select a staff/admin first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (cartTable.Rows.Count == 0)
                {
                    MessageBox.Show("No pending transactions found for this employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //CONFIRMATION OF DELETION
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to proceed with the transaction?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    //Insert the records of the staff/admin from the AddCart table to the Transactions table
                    MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT Accounts.accountID FROM Accounts INNER JOIN Person ON Accounts.PersonID = Person.PersonID WHERE CONCAT(IFNULL(Person.firstname, ''), ' ', IFNULL(Person.middleinitial, ''), '. ', IFNULL(Person.lastname, '')) = @staffName", connection);
                    cmd.Parameters.AddWithValue("@staffName", staffCmbx.SelectedItem.ToString());
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    int accountID = reader.GetInt32("accountID");
                    connection.Close();
                    cmd = new MySqlCommand("INSERT INTO Transactions (studentID, instructorID, accountID, partID, quantity, orderDate, orderTime, status_) SELECT studentID, instructorID, accountID, partID, quantity, orderDate, orderTime, NULL FROM AddCart WHERE accountID = @accountID", connection);
                    cmd.Parameters.AddWithValue("@accountID", accountID);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    //Subtract the quantity based on the 'AddCart' quantity from the 'Part' quantity database table
                    connection.Open();
                    cmd = new MySqlCommand("UPDATE Part INNER JOIN AddCart ON Part.partID = AddCart.partID SET Part.quantity = Part.quantity - AddCart.quantity WHERE AddCart.accountID = @accountID", connection);
                    cmd.Parameters.AddWithValue("@accountID", accountID);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    //Delete the record of the staff/admin from the AddCart table based on the employee ID
                    connection.Open();
                    cmd = new MySqlCommand("DELETE FROM AddCart WHERE accountID = @accountID", connection);
                    cmd.Parameters.AddWithValue("@accountID", accountID);
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Transaction successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshData();
                    //Clear all fields
                    studentIDTxtbx.Text = "";
                    borrowerNameTxtbx.Text = "";
                    courseTxtbx.Text = "";
                    yearlevelTxtbx.Text = "";
                    instructorNameTxtbx.SelectedIndex = -1;
                    subjectCodeTxtbx.SelectedIndex = -1;
                    equipmentNameTxtbx.SelectedIndex = -1;
                    typeTxtbx.SelectedIndex = -1;
                    staffCmbx.SelectedIndex = -1;
                    quantityTxtbx.Value = 0;
                    availableLabel.Text = "";

                }
            }
            else
            {
                if (cartTable.Rows.Count == 0)
                {
                    MessageBox.Show("Add items to the cart first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //CONFIRMATION FOR DELETION
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to proceed with the transaction?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                //Insert the records of the staff/admin from the AddCart table to the Transactions table based on the employee ID
                MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Transactions (studentID, instructorID, accountID, partID, quantity, orderDate, orderTime, status_) SELECT studentID, instructorID, accountID, partID, quantity, orderDate, orderTime, NULL FROM AddCart WHERE accountID = @accountID", connection);
                cmd.Parameters.AddWithValue("@accountID", LoginPage.EmployeeID);
                cmd.ExecuteNonQuery();
                connection.Close();
                connection.Open();
                //Subtract the quantity based on the 'AddCart' quantity from the 'Part' quantity database table based on the employee ID
                cmd = new MySqlCommand("UPDATE Part INNER JOIN AddCart ON Part.partID = AddCart.partID SET Part.quantity = Part.quantity - AddCart.quantity WHERE AddCart.accountID = @accountID", connection);
                cmd.Parameters.AddWithValue("@accountID", LoginPage.EmployeeID);
                cmd.ExecuteNonQuery();
                connection.Close();
                //Delete the record of the staff/admin from the AddCart table based on the employee ID
                connection.Open();
                cmd = new MySqlCommand("DELETE FROM AddCart WHERE accountID = @accountID", connection);
                cmd.Parameters.AddWithValue("@accountID", LoginPage.EmployeeID);
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Transaction successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //clear all fields
                studentIDTxtbx.Text = "";
                borrowerNameTxtbx.Text = "";
                courseTxtbx.Text = "";
                yearlevelTxtbx.Text = "";
                instructorNameTxtbx.SelectedIndex = -1;
                subjectCodeTxtbx.SelectedIndex = -1;
                equipmentNameTxtbx.SelectedIndex = -1;
                typeTxtbx.SelectedIndex = -1;
                quantityTxtbx.Value = 0;
                availableLabel.Text = "";
                refreshData();
            }
        }

        private void typeTxtbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string partName = typeTxtbx.SelectedItem != null ? typeTxtbx.SelectedItem.ToString() : string.Empty;

            if (typeTxtbx.Text == "")
            {
                return;
            }

            //Change the available label based on the quantity of the part selected

            MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            connection.Open();
            string query = "SELECT Part.quantity " +
               "FROM Part " +
               "WHERE Part.partname = @partName";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@partName", partName);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int quantity = reader.GetInt32("quantity");
                availableLabel.Text = quantity.ToString();
            }

            connection.Close();

        }

        private void addCartBTN_Click(object sender, EventArgs e)
        {
            if (studentIDTxtbx.Text == "" || borrowerNameTxtbx.Text == "" || courseTxtbx.Text == "" || yearlevelTxtbx.Text == "" || instructorNameTxtbx.SelectedItem == null || subjectCodeTxtbx.SelectedItem == null || equipmentNameTxtbx.SelectedItem == null || typeTxtbx.SelectedItem == null || quantityTxtbx.Value == 0)
            {
                MessageBox.Show("Please fill out all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (subjectCodeTxtbx.SelectedItem == null)
            {
                return;
            }

            //CHECK IF STUDENT ID EXISTS
            MySqlConnection conn = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            conn.Open();
            MySqlCommand cmd1 = new MySqlCommand("SELECT studentID FROM Student WHERE studentID = @studentID", conn);
            cmd1.Parameters.AddWithValue("@studentID", studentIDTxtbx.Text);
            MySqlDataReader reader1 = cmd1.ExecuteReader();
            if (!reader1.Read())
            {
                MessageBox.Show("Student ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            conn.Close();

            //CHECK TIME RANGE FOR ORDER BEFORE SUBMISSION
            string selectedCourse = subjectCodeTxtbx.SelectedItem.ToString().Split('-')[0].Trim();
            MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            connection.Open();
            string query = "SELECT startTime, endTime " +
               "FROM CourseTime " +
               "WHERE courseID = @courseID AND section = @section";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@courseID", selectedCourse);
            cmd.Parameters.AddWithValue("@section", subjectCodeTxtbx.SelectedItem.ToString().Split('-')[1].Trim());
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                TimeSpan startTime = reader.GetTimeSpan("startTime");
                TimeSpan endTime = reader.GetTimeSpan("endTime");
                TimeSpan currentTime = DateTime.Now.TimeOfDay;

                //if (currentTime >= startTime && currentTime <= endTime)
                //{
                    string instructorName = instructorNameTxtbx.SelectedItem.ToString();
                    string partName = typeTxtbx.SelectedItem.ToString();
                    string quantity = quantityTxtbx.Text;
                    string orderDate = DateTime.Now.ToString("yyyy-MM-dd");
                    string orderTime = DateTime.Now.ToString("HH:mm:ss");
                    string status = "Added to Cart";

                    //Check Quantity Amount before proceeding

                    //Check if Quantity is 0 or less
                    if (quantity == "0" || quantity == "")
                    {
                        MessageBox.Show("Please enter a quantity greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //Greater Quantity Check
                    int quantityInt = Int32.Parse(quantity);
                    connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    connection.Open();
                    query = "SELECT Part.quantity " +
                       "FROM Part " +
                       "INNER JOIN Product ON Part.productID = Product.productID " +
                       "WHERE Part.partname = @partName";
                    cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@partName", partName);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    int existingQuantity = reader.GetInt32("quantity");

                    if (quantityInt > existingQuantity)
                    {
                        MessageBox.Show($"Not enough {partName} in stock. Please enter a quantity less than or equal to {existingQuantity}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //Get Instructor ID through Instructor Name from 'Person' table to 'Instructor' table
                    MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand("SELECT Instructor.instructorID FROM Person " +
                                               "INNER JOIN Instructor ON Person.personID = Instructor.personID " +
                                               "WHERE CONCAT(IFNULL(Person.firstname, ''), ' ', IFNULL(Person.middleinitial, ''), '. ', IFNULL(Person.lastname, '')) = @instructorName", mySqlConnection);
                    mySqlCommand.Parameters.AddWithValue("@instructorName", instructorName);
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                    mySqlDataReader.Read();
                    string instructorID = mySqlDataReader.GetString("instructorID");
                    mySqlConnection.Close();
                    mySqlConnection.Dispose();

                    //Get Product ID through Type textbox from 'Part' table
                    mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    mySqlConnection.Open();
                    mySqlCommand = new MySqlCommand("SELECT Product.productID FROM Part INNER JOIN Product ON Part.productID = Product.productID WHERE Part.partname = @partName", mySqlConnection);
                    mySqlCommand.Parameters.AddWithValue("@partName", partName);
                    mySqlDataReader = mySqlCommand.ExecuteReader();
                    mySqlDataReader.Read();
                    int productIDInt = mySqlDataReader.GetInt32("productID");
                    string productID = productIDInt.ToString();
                    mySqlConnection.Close();
                    mySqlConnection.Dispose();

                    //Get the Part ID through the Product ID and Part Name from 'Part' table
                    mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    mySqlConnection.Open();
                    mySqlCommand = new MySqlCommand("SELECT Part.partID FROM Part INNER JOIN Product ON Part.productID = Product.productID WHERE Part.partname = @partName AND Product.productID = @productID", mySqlConnection);
                    mySqlCommand.Parameters.AddWithValue("@partName", partName);
                    mySqlCommand.Parameters.AddWithValue("@productID", productID);
                    mySqlDataReader = mySqlCommand.ExecuteReader();
                    mySqlDataReader.Read();
                    int partIDInt = mySqlDataReader.GetInt32("partID");
                    string partID = partIDInt.ToString();
                    mySqlConnection.Close();
                    mySqlConnection.Dispose();

                    //Insert the following data into 'Transactions' table: studentID, instructorID, accountID, productID, quantity, orderDate, orderTime, status
                    mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    mySqlConnection.Open();
                    mySqlCommand = new MySqlCommand("INSERT INTO AddCart (studentID, instructorID, accountID, partID, quantity, orderDate, orderTime, status_) " +
                                                    "VALUES (@studentID, @instructorID, @accountID, @partID, @quantity, @orderDate, @orderTime, @status_)", mySqlConnection);
                    mySqlCommand.Parameters.AddWithValue("@studentID", studentIDTxtbx.Text);
                    mySqlCommand.Parameters.AddWithValue("@instructorID", instructorID);
                    mySqlCommand.Parameters.AddWithValue("@accountID", LoginPage.EmployeeID);
                    mySqlCommand.Parameters.AddWithValue("@partID", partID);
                    mySqlCommand.Parameters.AddWithValue("@quantity", quantity);
                    mySqlCommand.Parameters.AddWithValue("@orderDate", orderDate);
                    mySqlCommand.Parameters.AddWithValue("@orderTime", orderTime);
                    mySqlCommand.Parameters.AddWithValue("@status_", status);
                    mySqlCommand.ExecuteNonQuery();
                    mySqlConnection.Close();
                    mySqlConnection.Dispose();

                    refreshData();
                    equipmentNameTxtbx.SelectedIndex = -1;
                    typeTxtbx.SelectedIndex = -1;
                    quantityTxtbx.Value = 0;
                    availableLabel.Text = "";
                    staffCmbx.SelectedIndex = -1;

                //}
                //else
                //{
                //    MessageBox.Show($"Transaction failed. Current time is not within the course time range for {selectedCourse}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            else
            {
                MessageBox.Show($"No time information found for course {selectedCourse}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
        }

        public void refreshData()
        {
            MySqlConnection conn = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            MySqlCommand cmd;

            if (LoginPage.Position == "Admin")
            {
                cmd = new MySqlCommand(@"
                    SELECT 
                        CONCAT(IFNULL(StudentPerson.firstname, ''), ' ', IFNULL(StudentPerson.middleinitial, ''), ' ', IFNULL(StudentPerson.lastname, '')) AS borrowerName,                  
                        Part.partname,
                        Product.productname,
                        AddCart.cartID,
                        AddCart.quantity, 
                        AddCart.status_
                    FROM 
                        AddCart
                    INNER JOIN 
                        Student ON AddCart.studentID = Student.studentID 
                    INNER JOIN 
                        Person AS StudentPerson ON Student.personID = StudentPerson.personID
                    INNER JOIN
                        Part ON AddCart.partID = Part.partID
                    INNER JOIN
                        Product ON Part.productID = Product.productID
                    INNER JOIN 
                        Accounts ON AddCart.accountID = Accounts.accountID
                    WHERE AddCart.status_ IS NOT NULL", conn);

                cmd.Parameters.AddWithValue("@employeeID", LoginPage.EmployeeID);
            }
            else
            {
                cmd = new MySqlCommand("SELECT CONCAT(IFNULL(Person.firstname, ''), ' ', IFNULL(Person.middleinitial, ''), '. ', IFNULL(Person.lastname, '')) AS borrowerName, " +
                    "Part.partname, Product.productname, AddCart.quantity, AddCart.cartID, AddCart.status_ FROM AddCart " +
                    "INNER JOIN Part ON AddCart.partID = Part.partID " +
                    "INNER JOIN Product ON Part.productID = Product.productID " +
                    "INNER JOIN Student ON AddCart.studentID = Student.studentID " +
                    "INNER JOIN Person ON Student.personID = Person.personID WHERE AddCart.accountID = @employeeID", conn);
                cmd.Parameters.AddWithValue("@employeeID", LoginPage.EmployeeID);
            }
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cartTable.DataSource = dt;
        }

        private void cartTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                cartTable.Cursor = Cursors.Hand;
            }
        }

        private void cartTable_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                cartTable.Cursor = Cursors.Default;
            }
        }

        private void cartTable_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 5)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var image = normalImage;
                if (selectedCell != null && selectedCell.RowIndex == e.RowIndex && selectedCell.ColumnIndex == e.ColumnIndex)
                {
                    image = hoverImage;
                }

                var w = image.Width;
                var h = image.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(image, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void cartTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 5)
            {
                //Change Image when selected
                selectedCell = cartTable[e.ColumnIndex, e.RowIndex];
                cartTable.InvalidateCell(e.ColumnIndex, e.RowIndex);
                cartTable.Refresh();
                if (MessageBox.Show("Are you sure you want to remove from cart?", "Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    int cartID = Convert.ToInt32(cartTable.Rows[e.RowIndex].Cells["cart_ID"].Value);
                    MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM AddCart WHERE cartID = @cartID", connection);
                    cmd.Parameters.AddWithValue("@cartID", cartID);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Item removed from cart.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    staffCmbx.SelectedIndex = -1;
                    refreshData();

                }
                else
                {
                    selectedCell = null;
                    cartTable.Refresh();
                }
            }
        }

        private void equipmentNameTxtbx_DropDown(object sender, EventArgs e)
        {
            //FIT THE DROPDOWN WIDTH TO THE WIDEST ITEM

            int maxWidth = equipmentNameTxtbx.Width;
            Graphics g = equipmentNameTxtbx.CreateGraphics();
            Font font = equipmentNameTxtbx.Font;

            foreach (var item in equipmentNameTxtbx.Items)
            {
                int itemWidth = (int)g.MeasureString(item.ToString(), font).Width;
                if (itemWidth > maxWidth)
                {
                    maxWidth = itemWidth;
                }
            }

            equipmentNameTxtbx.DropDownWidth = maxWidth;
        }

        private void staffCmbx_DropDown(object sender, EventArgs e)
        {
            //FIT THE DROPDOWN WIDTH TO THE WIDEST ITEM

            int maxWidth = staffCmbx.Width;
            Graphics g = staffCmbx.CreateGraphics();
            Font font = staffCmbx.Font;

            foreach (var item in staffCmbx.Items)
            {
                int itemWidth = (int)g.MeasureString(item.ToString(), font).Width;
                if (itemWidth > maxWidth)
                {
                    maxWidth = itemWidth;
                }
            }

            staffCmbx.DropDownWidth = maxWidth;
        }

        private void staffCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (staffCmbx.Text == "")
            {
                refreshData();
            }
            else
            {
                // Get the employee name from the ComboBox
                string employeeName = staffCmbx.SelectedItem.ToString();

                MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                connection.Open();

                // Create a command to get the employee ID based on the employee name
                MySqlCommand getEmployeeIdCmd = new MySqlCommand("SELECT Accounts.accountID FROM Accounts INNER JOIN Person ON Accounts.personID = Person.personID WHERE CONCAT(IFNULL(Person.firstname, ''), ' ', IFNULL(Person.middleinitial, ''), '. ', IFNULL(Person.lastname, '')) = @employeeName", connection);
                getEmployeeIdCmd.Parameters.AddWithValue("@employeeName", employeeName);

                // Execute the command and get the employee ID
                object result = getEmployeeIdCmd.ExecuteScalar();
                if (result != null)
                {
                    int employeeID = Convert.ToInt32(result);
                    MySqlCommand cmd = new MySqlCommand("SELECT CONCAT(IFNULL(Person.firstname, ''), ' ', IFNULL(Person.middleinitial, ''), ' ', IFNULL(Person.lastname, '')) AS borrowerName, Part.partname, Product.productname, AddCart.quantity, AddCart.cartID, AddCart.status_ FROM AddCart INNER JOIN Part ON AddCart.partID = Part.partID INNER JOIN Student ON AddCart.studentID = Student.studentID INNER JOIN Product ON Part.productID = Product.productID INNER JOIN Person ON Student.personID = Person.personID WHERE AddCart.accountID = @employeeID", connection);
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    cartTable.DataSource = dt;
                }

            }

        }

        private void clearCart_Click(object sender, EventArgs e)
        {
            staffCmbx.SelectedIndex = -1;
        }
    }
}
