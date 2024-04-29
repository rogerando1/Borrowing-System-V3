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
    public partial class TransactionPage : Form
    {
        public TransactionPage()
        {
            InitializeComponent();
        }

        private void TransactionPage_Load(object sender, EventArgs e)
        {
            FillComboBox();
            FillProductComboBox();
            subjectnameLabel.Text = "";
            availableLabel.Text = "";
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

                        MySqlCommand cmd = new MySqlCommand("SELECT CONCAT(IFNULL(Person.firstname, ''), ' ', IFNULL(Person.middleinitial, ''), '. ', IFNULL(Person.lastname, '')) AS personID, program, yearlevel FROM sql6690575.Student " +
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
                MySqlCommand cmd = new MySqlCommand("SELECT CONCAT(IFNULL(Person.firstname, ''), ' ', IFNULL(Person.middleinitial, ''), '. ', IFNULL(Person.lastname, '')) AS personID FROM sql6690575.Instructor " +
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

        // Declare a Dictionary to store the mapping between instructors and subject codes
        private Dictionary<string, List<string>> instructorSubjectCodes = new Dictionary<string, List<string>>();

        private void instructorNameTxtbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            subjectCodeTxtbx.SelectedIndex = -1;
            subjectnameLabel.Text = "";

            if (instructorNameTxtbx.SelectedItem == null)
            {
                return;
            }

            string selectedInstructor = instructorNameTxtbx.SelectedItem.ToString();

            // If the selected instructor's subject codes are already stored in the Dictionary, use them
            if (instructorSubjectCodes.ContainsKey(selectedInstructor))
            {
                subjectCodeTxtbx.Items.Clear();
                foreach (string subjectCode in instructorSubjectCodes[selectedInstructor])
                {
                    subjectCodeTxtbx.Items.Add(subjectCode);
                }
            }
            else
            {
                // If the selected instructor's subject codes are not in the Dictionary, fetch them from the database
                MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                connection.Open();
                string query = "SELECT CourseTime.courseID, CourseTime.section " +
                   "FROM Instructor " +
                   "INNER JOIN Person ON Instructor.personID = Person.personID " +
                   "INNER JOIN CourseTime ON Instructor.instructorID = CourseTime.instructorID " +
                   "WHERE CONCAT(IFNULL(Person.firstname, ''), ' ', IFNULL(Person.middleinitial, ''), '. ', IFNULL(Person.lastname, '')) = @instructorName";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@instructorName", selectedInstructor);
                MySqlDataReader reader = cmd.ExecuteReader();

                // Store the fetched subject codes in a List
                List<string> subjectCodes = new List<string>();
                while (reader.Read())
                {
                    string courseName = reader.GetString("courseID");
                    string section = reader.GetString("section");
                    subjectCodes.Add($"{courseName} - {section}");
                }

                // Add the List of subject codes to the Dictionary
                instructorSubjectCodes.Add(selectedInstructor, subjectCodes);

                // Add the subject codes to the ComboBox
                subjectCodeTxtbx.Items.Clear();
                foreach (string subjectCode in subjectCodes)
                {
                    subjectCodeTxtbx.Items.Add(subjectCode);
                }

                connection.Close();
            }
        }

        private void subjectCodeTxtbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string defaultIndex = "Please select an instructor first";

            if (subjectCodeTxtbx.SelectedItem == null || subjectCodeTxtbx.Text == defaultIndex)
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
            quantityTxtbx.Text = "";
            availableLabel.Text = "";
            subjectCodeTxtbx.Items.Clear();
            subjectCodeTxtbx.Items.Add("Please select an instructor first");
            typeTxtbx.Items.Clear();
            typeTxtbx.Items.Add("Please select an equipment first");

        }

        // Declare a Dictionary to store the mapping between products and parts
        private Dictionary<string, List<string>> productParts = new Dictionary<string, List<string>>();

        private void equipmentNameTxtbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            availableLabel.Text = "";
            string defaultIndex = "Please select an equipment first";

            if (equipmentNameTxtbx.SelectedItem == null || equipmentNameTxtbx.Text == defaultIndex)
            {
                return;
            }

            else
            {
                string selectedProductName = equipmentNameTxtbx.SelectedItem.ToString();

                // If the selected product's parts are already stored in the Dictionary, use them
                if (productParts.ContainsKey(selectedProductName))
                {
                    typeTxtbx.Items.Clear();
                    foreach (string part in productParts[selectedProductName])
                    {
                        typeTxtbx.Items.Add(part);
                    }
                }
                else
                {
                    // If the selected product's parts are not in the Dictionary, fetch them from the database
                    MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    connection.Open();
                    string query = "SELECT Part.partName " +
                        "FROM Product " +
                        "INNER JOIN Part ON Product.productID = Part.productID " +
                        "WHERE Product.productName = @productName";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@productName", selectedProductName);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Store the fetched parts in a List
                    List<string> parts = new List<string>();
                    while (reader.Read())
                    {
                        string partName = reader.GetString("partName");
                        parts.Add(partName);
                    }

                    // Add the List of parts to the Dictionary
                    productParts.Add(selectedProductName, parts);

                    // Add the parts to the ComboBox
                    typeTxtbx.Items.Clear();
                    foreach (string part in parts)
                    {
                        typeTxtbx.Items.Add(part);
                    }

                    connection.Close();
                }
            }
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            if (studentIDTxtbx.Text == "" || borrowerNameTxtbx.Text == "" || courseTxtbx.Text == "" || yearlevelTxtbx.Text == "" || instructorNameTxtbx.SelectedItem == null || subjectCodeTxtbx.SelectedItem == null || equipmentNameTxtbx.SelectedItem == null || typeTxtbx.SelectedItem == null || quantityTxtbx.Text == "")
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
               "WHERE courseID = @courseID";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@courseID", selectedCourse);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                TimeSpan startTime = reader.GetTimeSpan("startTime");
                TimeSpan endTime = reader.GetTimeSpan("endTime");
                TimeSpan currentTime = DateTime.Now.TimeOfDay;

                if (currentTime >= startTime && currentTime <= endTime)
                {
                    string instructorName = instructorNameTxtbx.SelectedItem.ToString();
                    string partName = typeTxtbx.SelectedItem.ToString();
                    string quantity = quantityTxtbx.Text;
                    string orderDate = DateTime.Now.ToString("yyyy-MM-dd");
                    string orderTime = DateTime.Now.ToString("HH:mm:ss");
                    string status = "";

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
                       "WHERE Part.partName = @partName";
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

                    //User transaction confirmation
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to proceed with the transaction?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.No)
                    {
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
                    mySqlCommand = new MySqlCommand("SELECT Product.productID FROM Part INNER JOIN Product ON Part.productID = Product.productID WHERE Part.partName = @partName", mySqlConnection);
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
                    mySqlCommand = new MySqlCommand("SELECT Part.partID FROM Part INNER JOIN Product ON Part.productID = Product.productID WHERE Part.partName = @partName AND Product.productID = @productID", mySqlConnection);
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
                    mySqlCommand = new MySqlCommand("INSERT INTO Transactions (studentID, instructorID, accountID, productID, quantity, orderDate, orderTime, status_) " +
                                                    "VALUES (@studentID, @instructorID, @accountID, @productID, @quantity, @orderDate, @orderTime, @status_)", mySqlConnection);
                    mySqlCommand.Parameters.AddWithValue("@studentID", studentIDTxtbx.Text);
                    mySqlCommand.Parameters.AddWithValue("@instructorID", instructorID);
                    mySqlCommand.Parameters.AddWithValue("@accountID", LoginPage.EmployeeID);
                    mySqlCommand.Parameters.AddWithValue("@productID", productID);
                    mySqlCommand.Parameters.AddWithValue("@quantity", quantity);
                    mySqlCommand.Parameters.AddWithValue("@orderDate", orderDate);
                    mySqlCommand.Parameters.AddWithValue("@orderTime", orderTime);
                    mySqlCommand.Parameters.AddWithValue("@status_", status);
                    mySqlCommand.ExecuteNonQuery();
                    mySqlConnection.Close();
                    mySqlConnection.Dispose();


                    //Subtract the quantity of the product from the 'Part' database table based on the type of product
                    mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    mySqlConnection.Open();
                    mySqlCommand = new MySqlCommand("UPDATE Part SET quantity = quantity - @quantity WHERE partID = @partID", mySqlConnection);
                    mySqlCommand.Parameters.AddWithValue("@quantity", quantity);
                    mySqlCommand.Parameters.AddWithValue("@partID", partID);
                    mySqlCommand.ExecuteNonQuery();
                    mySqlConnection.Close();
                    mySqlConnection.Dispose();

                    MessageBox.Show($"Transaction successful for course {selectedCourse}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
                    studentIDTxtbx.Text = "";
                    borrowerNameTxtbx.Text = "";
                    courseTxtbx.Text = "";
                    yearlevelTxtbx.Text = "";
                    instructorNameTxtbx.SelectedIndex = -1;
                    subjectCodeTxtbx.SelectedIndex = -1;
                    equipmentNameTxtbx.SelectedIndex = -1;
                    typeTxtbx.SelectedIndex = -1;
                    quantityTxtbx.Text = "";
                    availableLabel.Text = "";
                    subjectCodeTxtbx.Items.Clear();
                    subjectCodeTxtbx.Items.Add("Please select an instructor first");

                }
                else
                {
                    MessageBox.Show($"Transaction failed. Current time is not within the course time range for {selectedCourse}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"No time information found for course {selectedCourse}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
        }

        private void typeTxtbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string defaultIndex = "Please select an equipment first";
            string partName = typeTxtbx.SelectedItem != null ? typeTxtbx.SelectedItem.ToString() : string.Empty;

            if (typeTxtbx.Text == defaultIndex || typeTxtbx.Text == null)
            {
                return;
            }

            //Change the available label based on the quantity of the part selected

            MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            connection.Open();
            string query = "SELECT Part.quantity " +
               "FROM Part " +
               "WHERE Part.partName = @partName";
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
    }
}
