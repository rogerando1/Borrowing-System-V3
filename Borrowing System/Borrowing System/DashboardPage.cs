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
using OfficeOpenXml;
using System.IO;
using OfficeOpenXml.Style;
using System.Windows.Media;
using OfficeOpenXml.Table;

namespace Borrowing_System
{
    public partial class DashboardPage : Form
    {
        Image normalImage = Properties.Resources.return3;
        Image hoverImage = Properties.Resources.return2;
        private DataGridViewCell selectedCell = null;

        public DashboardPage()
        {
            InitializeComponent();
        }

        private void DashboardPage_Load(object sender, EventArgs e)
        {
            DefaultDate();
            refreshData();
            FillStaffComboBox();
            staffCmbx.Visible = true;
            clearDashBtn.Visible = true;

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
                while (reader.Read())
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

        private void DefaultDate()
        {
            dateSearch1.Value = DateTime.Now;
            dateSearch2.Value = DateTime.Now;

            dateSearch1.CustomFormat = "MM/dd/yyyy";
            dateSearch1.Format = DateTimePickerFormat.Custom;
            dateSearch2.CustomFormat = "MM/dd/yyyy";
            dateSearch2.Format = DateTimePickerFormat.Custom;

        }

        public void refreshData()
        {
            MySqlConnection conn = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            MySqlCommand cmd = new MySqlCommand(@"
                    SELECT 
                        Transactions.transactionID, 
                        CONCAT(IFNULL(StudentPerson.firstname, ''), ' ', IFNULL(StudentPerson.middleinitial, ''), ' ', IFNULL(StudentPerson.lastname, '')) AS studentName, 
                        CONCAT(IFNULL(InstructorPerson.firstname, ''), ' ', IFNULL(InstructorPerson.middleinitial, ''), ' ', IFNULL(InstructorPerson.lastname, '')) AS instructorName, 
                        CONCAT(IFNULL(AccountsPerson.firstname, ''), ' ', IFNULL(AccountsPerson.middleinitial, ''), ' ', IFNULL(AccountsPerson.lastname, '')) AS accountName,                    
                        Part.partname,
                        Transactions.quantity, 
                        Transactions.accountID,
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
                        Part ON Transactions.partID = Part.partID
                    INNER JOIN 
                        Accounts ON Transactions.accountID = Accounts.accountID
                    INNER JOIN 
                        Person AS AccountsPerson ON Accounts.personID = AccountsPerson.personID
                    INNER JOIN 
                        Person AS InstructorPerson ON Instructor.personID = InstructorPerson.personID 
                    WHERE Transactions.status_ IS NULL", conn);

                cmd.Parameters.AddWithValue("@employeeID", LoginPage.EmployeeID);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dashboardTable.DataSource = dt;
        }

        private void UpdateDate()
        {
            MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(@"
                SELECT 
                    Transactions.transactionID, 
                    CONCAT(IFNULL(StudentPerson.firstname, ''), ' ', IFNULL(StudentPerson.middleinitial, ''), ' ', IFNULL(StudentPerson.lastname, '')) AS studentName, 
                    CONCAT(IFNULL(InstructorPerson.firstname, ''), ' ', IFNULL(InstructorPerson.middleinitial, ''), ' ', IFNULL(InstructorPerson.lastname, '')) AS instructorName, 
                    CONCAT(IFNULL(AccountsPerson.firstname, ''), ' ', IFNULL(AccountsPerson.middleinitial, ''), ' ', IFNULL(AccountsPerson.lastname, '')) AS accountName,                    
                    Part.partname,
                    Transactions.quantity, 
                    Transactions.accountID,
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
                    Part ON Transactions.partID = Part.partID
                INNER JOIN 
                    Accounts ON Transactions.accountID = Accounts.accountID
                INNER JOIN 
                    Person AS AccountsPerson ON Accounts.personID = AccountsPerson.personID
                INNER JOIN 
                    Person AS InstructorPerson ON Instructor.personID = InstructorPerson.personID 
                WHERE 
                    Transactions.status_ IS NULL AND
                    Transactions.orderdate BETWEEN @date1 AND @date2", mySqlConnection);
            mySqlCommand.Connection = mySqlConnection;
            mySqlCommand.Parameters.AddWithValue("@date1", dateSearch1.Value.ToString("yyyy-MM-dd"));
            mySqlCommand.Parameters.AddWithValue("@date2", dateSearch2.Value.ToString("yyyy-MM-dd"));
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dashboardTable.DataSource = dataTable;
            mySqlConnection.Close();
        }

        private void dashboardTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                dashboardTable.Cursor = Cursors.Hand;
            }
        }

        private void dashboardTable_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                dashboardTable.Cursor = Cursors.Default;
            }
        }

        private void dashboardTable_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 9)
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

        private void dashboardTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 9)
            {
                //Change Image when selected
                selectedCell = dashboardTable[e.ColumnIndex, e.RowIndex];
                dashboardTable.InvalidateCell(e.ColumnIndex, e.RowIndex);
                dashboardTable.Refresh();
                if (MessageBox.Show("Are you sure you want to return the item?", "Return Item", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //SHOW NOTES FORM
                    AddNotes addnote = new AddNotes();
                    addnote.ShowDialog();

                    if (addnote.DialogResult == DialogResult.Cancel)
                    {
                        selectedCell = null;
                        dashboardTable.Refresh();
                    }
                    if(addnote.DialogResult == DialogResult.OK)
                    {
                        DateTime return_DATE = DateTime.Now;
                        DateTime return_TIME = DateTime.Now;

                        using (MySqlConnection conn = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}"))
                        {
                            //Check if quantity for AddNotes.Notes is less than to the quantity of item borrowed

                            conn.Open();
                            MySqlCommand cmd = new MySqlCommand("SELECT quantity FROM Transactions WHERE transactionID = @transactionID", conn);
                            cmd.Parameters.AddWithValue("@transactionID", dashboardTable.Rows[e.RowIndex].Cells["transactionID"].Value.ToString());
                            MySqlDataReader reader = cmd.ExecuteReader();
                            reader.Read();
                            int quantity = reader.GetInt32(0);
                            reader.Close();

                            if (Convert.ToInt32(AddNotes.Quantity) > quantity)
                            {
                                MessageBox.Show("Quantity to be returned is greater than the quantity borrowed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                selectedCell = null;
                                dashboardTable.Refresh();
                                return;
                            }
                            else
                            {
                                try
                                {
                                    //INSERT INTO TransactionLogs
                                    cmd = new MySqlCommand("INSERT INTO TransactionLogs (transactionID, returndate, returntime, notes, releaserID, receiverID) VALUES (@transactionID, @returndate, @returntime, @notes, @releaserID, @receiverID)", conn);
                                    cmd.Parameters.AddWithValue("@transactionID", Convert.ToInt32(dashboardTable.Rows[e.RowIndex].Cells["transactionID"].Value.ToString()));
                                    cmd.Parameters.AddWithValue("@returndate", return_DATE.ToString("yyyy-MM-dd"));
                                    cmd.Parameters.AddWithValue("@returntime", return_TIME.ToString("HH:mm:ss"));
                                    cmd.Parameters.AddWithValue("@notes", AddNotes.Notes);
                                    cmd.Parameters.AddWithValue("@releaserID", Convert.ToInt32(dashboardTable.Rows[e.RowIndex].Cells["account_ID"].Value.ToString()));
                                    cmd.Parameters.AddWithValue("@receiverID", LoginPage.EmployeeID);

                                    cmd.ExecuteNonQuery();

                                    //UPDATE THE STATUS OF THE TRANSACTION INTO "RETURNED"
                                    cmd = new MySqlCommand("UPDATE Transactions SET status_ = 'Returned' WHERE transactionID = @transactionID", conn);
                                    cmd.Parameters.AddWithValue("@transactionID", Convert.ToInt32(dashboardTable.Rows[e.RowIndex].Cells["transactionID"].Value.ToString()));
                                    cmd.ExecuteNonQuery();

                                    //UPDATE THE QUANTITY OF THE ITEM IN THE INVENTORY
                                    string equipmentName = dashboardTable.Rows[e.RowIndex].Cells["partName"].Value.ToString();
                                    cmd = new MySqlCommand($"UPDATE Part SET quantity = quantity + {AddNotes.Quantity} WHERE Part.partname = '{equipmentName}'", conn);
                                    cmd.ExecuteNonQuery();

                                    refreshData();
                                    MessageBox.Show("Item has been returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    selectedCell = null;
                                    dashboardTable.Refresh();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }

                            }
                        }


                    }
                }
                else
                {
                    selectedCell = null;
                    dashboardTable.Refresh();
                }
            }
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            string searchText = searchTxtbx.Text.Trim();
            searchData(searchText);
        }

        public void searchData(string search)
        {
                MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(@"
                SELECT 
                    Transactions.transactionID, 
                    CONCAT(IFNULL(StudentPerson.firstname, ''), ' ', IFNULL(StudentPerson.middleinitial, ''), ' ', IFNULL(StudentPerson.lastname, '')) AS studentName, 
                    CONCAT(IFNULL(InstructorPerson.firstname, ''), ' ', IFNULL(InstructorPerson.middleinitial, ''), ' ', IFNULL(InstructorPerson.lastname, '')) AS instructorName, 
                    CONCAT(IFNULL(AccountsPerson.firstname, ''), ' ', IFNULL(AccountsPerson.middleinitial, ''), ' ', IFNULL(AccountsPerson.lastname, '')) AS accountName,                    
                    Part.partname,
                    Transactions.quantity, 
                    Transactions.accountID,
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
                    Part ON Transactions.partID = Part.partID
                INNER JOIN 
                    Accounts ON Transactions.accountID = Accounts.accountID
                INNER JOIN 
                    Person AS AccountsPerson ON Accounts.personID = AccountsPerson.personID
                INNER JOIN 
                    Person AS InstructorPerson ON Instructor.personID = InstructorPerson.personID 
                WHERE 
                    Transactions.status_ IS NULL AND
                    (CONCAT(IFNULL(StudentPerson.firstname, ''), ' ', IFNULL(StudentPerson.middleinitial, ''), ' ', IFNULL(StudentPerson.lastname, '')) LIKE @search OR
                    CONCAT(IFNULL(InstructorPerson.firstname, ''), ' ', IFNULL(InstructorPerson.middleinitial, ''), ' ', IFNULL(InstructorPerson.lastname, '')) LIKE @search OR
                    CONCAT(IFNULL(AccountsPerson.firstname, ''), ' ', IFNULL(AccountsPerson.middleinitial, ''), ' ', IFNULL(AccountsPerson.lastname, '')) LIKE @search OR
                    Part.partname LIKE @search)", mySqlConnection);
                mySqlCommand.Connection = mySqlConnection;
                mySqlCommand.Parameters.AddWithValue("@search", "%" + search + "%");
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                dashboardTable.DataSource = dataTable;
                mySqlConnection.Close();

        }

        private void searchTxtbx_TextChanged(object sender, EventArgs e)
        {
            if(searchTxtbx.Text == "")
            {
                refreshData();
            }
        }

        private void searchTxtbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBTN.PerformClick();
            }
        }

        private void clearDashBtn_Click(object sender, EventArgs e)
        {
            staffCmbx.SelectedIndex = -1;
            DefaultDate();
            refreshData();

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
            if(staffCmbx.SelectedIndex == -1)
            {
                refreshData();
                return;
            }
            else
            {
                //search data by staff
                string staffName = staffCmbx.Text;
                string[] name = staffName.Split(' ');
                string firstName = name[0];

                searchData($"{firstName}");
            }
        }

        private void dateSearch2_ValueChanged(object sender, EventArgs e)
        {
            UpdateDate();   
        }

        private void dateSearch1_ValueChanged(object sender, EventArgs e)
        {
            UpdateDate();
        }

        private void excelExportBTN_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog()
            {
                Filter = "Excel Workbook|*.xlsx"
            })
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; // or OfficeOpenXml.LicenseContext.Commercial
                        using (ExcelPackage package = new ExcelPackage())
                        {
                            ExcelWorksheet ws = package.Workbook.Worksheets.Add("Transaction Page");

                            DataTable dt = this.dashboardTable.DataSource as DataTable;

                            // Set the status for each row
                            foreach (DataRow row in dt.Rows)
                            {
                                row["status_"] = "Not yet returned";
                            }

                            // Format date and time columns
                            int columnIndex = 1;
                            foreach (DataColumn col in dt.Columns)
                            {
                                if (col.ColumnName == "orderdate" && col.DataType == typeof(DateTime))
                                {
                                    // Format for date only
                                    ws.Column(columnIndex).Style.Numberformat.Format = "yyyy-MM-dd";
                                }
                                else if (col.ColumnName == "ordertime" && col.DataType == typeof(TimeSpan))
                                {
                                    // Convert TimeSpan to Excel time and format it
                                    for (int rowIndex = 0; rowIndex < dt.Rows.Count; rowIndex++)
                                    {
                                        TimeSpan timeSpan = (TimeSpan)dt.Rows[rowIndex][col.ColumnName];
                                        double excelTime = timeSpan.TotalDays; // Convert TimeSpan to Excel time
                                        ws.Cells[rowIndex + 3, columnIndex].Value = excelTime; // +3 because Excel is 1-indexed and we have a header row
                                    }
                                    ws.Column(columnIndex).Style.Numberformat.Format = "hh:mm:ss AM/PM";
                                }
                                columnIndex++;
                            }

                            // Load data into worksheet
                            ws.Cells["A2"].LoadFromDataTable(dt, true);

                            // Merge and format the title row
                            ws.Cells["A1:J1"].Merge = true;
                            ws.Cells["A1"].Value = $"Borrowed Equipment";
                            ws.Cells["A1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                            ws.Cells["A1"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Cyan);
                            ws.Cells["A1"].Style.Font.Color.SetColor(System.Drawing.Color.DarkBlue);
                            ws.Cells["A1"].Style.Font.Bold = true;
                            ws.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                            // Center align header row
                            ws.Row(2).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            ws.PrinterSettings.PaperSize = ePaperSize.Folio;
                            ws.PrinterSettings.Orientation = eOrientation.Landscape;
                            ws.PrinterSettings.FitToPage = true;

                            // Adjust column widths
                            ws.Cells[ws.Dimension.Address].AutoFitColumns();

                            using (var range = ws.Cells[2, 1, dt.Rows.Count + 2, dt.Columns.Count])
                            {
                                var table = ws.Tables.Add(range, "TransactionTable");
                                table.ShowHeader = true;
                                table.TableStyle = TableStyles.Medium9;
                            }

                            var fi = new FileInfo(save.FileName);
                            package.SaveAs(fi);
                        }

                        MessageBox.Show("You have successfully exported the database table", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        DataTable dt = this.dashboardTable.DataSource as DataTable;
                        //Open the file after exporting
                        System.Diagnostics.Process.Start(save.FileName);
                        // Set the status for each row
                        foreach (DataRow row in dt.Rows)
                        {
                            row["status_"] = null;
                        }
                    }
                }
            }
        }
    }
}
