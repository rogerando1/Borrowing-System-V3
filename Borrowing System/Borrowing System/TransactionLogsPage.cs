using Borrowing_System.Data;
using MySql.Data.MySqlClient;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using OfficeOpenXml.Table;
using System;
using System.Data;
using System.IO;
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
            DefaultDate();
            refreshData();
            populateStudent();
            logsTable.Columns["studentName"].Visible = true;
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

        public void populateStudent()
        {
            using (MySqlConnection conn = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}"))
            {
                MySqlCommand cmd = new MySqlCommand(@"
                SELECT DISTINCT
                    CONCAT(IFNULL(StudentPerson.firstname, ''), ' ', IFNULL(StudentPerson.middleinitial, ''), ' ', IFNULL(StudentPerson.lastname, '')) AS studentName
                FROM 
                    TransactionLogs
                INNER JOIN 
                    Transactions ON TransactionLogs.transactionID= Transactions.transactionID
                INNER JOIN
                    Student ON Transactions.studentID = Student.studentID
                INNER JOIN 
                    Person AS StudentPerson ON Student.personID = StudentPerson.personID
                WHERE TransactionLogs.notes IS NOT NULL", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                studentView.DataSource = dt;
                studentView.Refresh();
            }


        }

        private void UpdateDate()
        {
            try
            {
                string date1 = dateSearch1.Value.ToString("yyyy-MM-dd");
                string date2 = dateSearch2.Value.ToString("yyyy-MM-dd");
                string connStr = $"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}";

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(@"
                        SELECT 
                            TransactionLogs.transactionlogID,
                            CONCAT(IFNULL(StudentPerson.firstname, ''), ' ', IFNULL(StudentPerson.middleinitial, ''), ' ', IFNULL(StudentPerson.lastname, '')) AS studentName, 
                            CONCAT(IFNULL(InstructorPerson.firstname, ''), ' ', IFNULL(InstructorPerson.middleinitial, ''), ' ', IFNULL(InstructorPerson.lastname, '')) AS instructorName, 
                            CONCAT(IFNULL(ReceiverPerson.firstname, ''), ' ', IFNULL(ReceiverPerson.middleinitial, ''), ' ', IFNULL(ReceiverPerson.lastname, '')) AS receiverName,
                            CONCAT(IFNULL(ReleaserPerson.firstname, ''), ' ', IFNULL(ReleaserPerson.middleinitial, ''), ' ', IFNULL(ReleaserPerson.lastname, '')) AS releaserName,
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
                            Accounts AS ReceiverAccount ON TransactionLogs.receiverID = ReceiverAccount.accountID
                        INNER JOIN 
                            Accounts AS ReleaserAccount ON TransactionLogs.releaserID = ReleaserAccount.accountID
                        INNER JOIN 
                            Person AS StudentPerson ON Student.personID = StudentPerson.personID
                        INNER JOIN 
                            Person AS InstructorPerson ON Instructor.personID = InstructorPerson.personID 
                        INNER JOIN 
                            Person AS ReceiverPerson ON ReceiverAccount.personID = ReceiverPerson.personID
                        INNER JOIN 
                            Person AS ReleaserPerson ON ReleaserAccount.personID = ReleaserPerson.personID
                        INNER JOIN
                            Part ON Transactions.partID = Part.partID
                        WHERE 
                            Transactions.status_ IS NOT NULL AND 
                            TransactionLogs.returndate BETWEEN @date1 AND @date2", conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@date1", date1);
                        cmd.Parameters.AddWithValue("@date2", date2);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        logsTable.DataSource = dt;
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        public void refreshData()
        {
            MySqlConnection conn = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            MySqlCommand cmd = new MySqlCommand(@"
                SELECT 
                    TransactionLogs.transactionlogID,
                    CONCAT(IFNULL(StudentPerson.firstname, ''), ' ', IFNULL(StudentPerson.middleinitial, ''), ' ', IFNULL(StudentPerson.lastname, '')) AS studentName, 
                    CONCAT(IFNULL(InstructorPerson.firstname, ''), ' ', IFNULL(InstructorPerson.middleinitial, ''), ' ', IFNULL(InstructorPerson.lastname, '')) AS instructorName, 
                    CONCAT(IFNULL(ReceiverPerson.firstname, ''), ' ', IFNULL(ReceiverPerson.middleinitial, ''), ' ', IFNULL(ReceiverPerson.lastname, '')) AS receiverName,
                    CONCAT(IFNULL(ReleaserPerson.firstname, ''), ' ', IFNULL(ReleaserPerson.middleinitial, ''), ' ', IFNULL(ReleaserPerson.lastname, '')) AS releaserName,
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
                    Accounts AS ReceiverAccount ON TransactionLogs.receiverID = ReceiverAccount.accountID
                INNER JOIN 
                    Accounts AS ReleaserAccount ON TransactionLogs.releaserID = ReleaserAccount.accountID
                INNER JOIN 
                    Person AS StudentPerson ON Student.personID = StudentPerson.personID
                INNER JOIN 
                    Person AS InstructorPerson ON Instructor.personID = InstructorPerson.personID 
                INNER JOIN 
                    Person AS ReceiverPerson ON ReceiverAccount.personID = ReceiverPerson.personID
                INNER JOIN 
                    Person AS ReleaserPerson ON ReleaserAccount.personID = ReleaserPerson.personID
                INNER JOIN
                    Part ON Transactions.partID = Part.partID
                WHERE 
                    Transactions.status_ IS NOT NULL", conn);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            logsTable.DataSource = dt;
        }





        private void searchLogData(string search)
        {
            search = "%" + search + "%";

            using (MySqlConnection conn = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}"))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(@"
                SELECT 
                    TransactionLogs.transactionlogID,
                    CONCAT(IFNULL(StudentPerson.firstname, ''), ' ', IFNULL(StudentPerson.middleinitial, ''), ' ', IFNULL(StudentPerson.lastname, '')) AS studentName, 
                    CONCAT(IFNULL(InstructorPerson.firstname, ''), ' ', IFNULL(InstructorPerson.middleinitial, ''), ' ', IFNULL(InstructorPerson.lastname, '')) AS instructorName, 
                    CONCAT(IFNULL(ReceiverPerson.firstname, ''), ' ', IFNULL(ReceiverPerson.middleinitial, ''), ' ', IFNULL(ReceiverPerson.lastname, '')) AS receiverName,
                    CONCAT(IFNULL(ReleaserPerson.firstname, ''), ' ', IFNULL(ReleaserPerson.middleinitial, ''), ' ', IFNULL(ReleaserPerson.lastname, '')) AS releaserName,
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
                    Accounts AS ReceiverAccount ON TransactionLogs.receiverID = ReceiverAccount.accountID
                INNER JOIN 
                    Accounts AS ReleaserAccount ON TransactionLogs.releaserID = ReleaserAccount.accountID
                INNER JOIN 
                    Person AS StudentPerson ON Student.personID = StudentPerson.personID
                INNER JOIN 
                    Person AS InstructorPerson ON Instructor.personID = InstructorPerson.personID 
                INNER JOIN 
                    Person AS ReceiverPerson ON ReceiverAccount.personID = ReceiverPerson.personID
                INNER JOIN 
                    Person AS ReleaserPerson ON ReleaserAccount.personID = ReleaserPerson.personID
                INNER JOIN
                    Part ON Transactions.partID = Part.partID
                WHERE 
                    Transactions.status_ IS NOT NULL AND 
                    (CONCAT(IFNULL(StudentPerson.firstname, ''), ' ', IFNULL(StudentPerson.middleinitial, ''), ' ', IFNULL(StudentPerson.lastname, '')) LIKE @search OR 
                    CONCAT(IFNULL(InstructorPerson.firstname, ''), ' ', IFNULL(InstructorPerson.middleinitial, ''), ' ', IFNULL(InstructorPerson.lastname, '')) LIKE @search OR 
                    CONCAT(IFNULL(ReceiverPerson.firstname, ''), ' ', IFNULL(ReceiverPerson.middleinitial, ''), ' ', IFNULL(ReceiverPerson.lastname, '')) LIKE @search OR
                    CONCAT(IFNULL(ReleaserPerson.firstname, ''), ' ', IFNULL(ReleaserPerson.middleinitial, ''), ' ', IFNULL(ReleaserPerson.lastname, '')) LIKE @search OR
                    Part.partname LIKE @search OR
                    TransactionLogs.notes LIKE @search)", conn))
                    {
                        cmd.Parameters.AddWithValue("@search", search);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            logsTable.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void searchBTN_Click(object sender, EventArgs e)
        {
            string search = searchData.Text;
            searchLogData(search);
            logsTable.Columns["studentName"].Visible = true;
        }

        private void searchData_TextChanged(object sender, EventArgs e)
        {
            if (searchData.Text == "")
            {
                refreshData();
                logsTable.Columns["studentName"].Visible = true;
            }
        }

        private void searchData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBTN.PerformClick();
            }
        }

        private void clearDashBtn_Click(object sender, EventArgs e)
        {
            DefaultDate();
            refreshData();
            logsTable.Columns["studentName"].Visible = true;
        }



        private void dateSearch1_ValueChanged(object sender, EventArgs e)
        {
            UpdateDate();
            logsTable.Columns["studentName"].Visible = true;
        }

        private void dateSearch2_ValueChanged(object sender, EventArgs e)
        {
            UpdateDate();
            logsTable.Columns["studentName"].Visible = true;
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

                            ExcelWorksheet ws = package.Workbook.Worksheets.Add("Transaction Logs Page");

                            DataTable dt = this.logsTable.DataSource as DataTable;

                            // Format date and time columns
                            int columnIndex = 1;
                            foreach (DataColumn col in dt.Columns)
                            {
                                if (col.ColumnName == "returndate" && col.DataType == typeof(DateTime))
                                {
                                    // Format for date only
                                    ws.Column(columnIndex).Style.Numberformat.Format = "yyyy-MM-dd";
                                }
                                else if (col.ColumnName == "returntime" && col.DataType == typeof(TimeSpan))
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
                            ws.Cells["A1"].Value = $"Returned Equipment";
                            ws.Cells["A1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                            ws.Cells["A1"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.WhiteSmoke);
                            ws.Cells["A1"].Style.Font.Color.SetColor(System.Drawing.Color.Black);
                            ws.Cells["A1"].Style.Font.Bold = true;
                            ws.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                            // Center align header row
                            ws.Row(2).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                            // Center text for each cells
                            ws.Cells[ws.Dimension.Address].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                            // Adjust column widths
                            ws.Cells[ws.Dimension.Address].AutoFitColumns();

                            ws.PrinterSettings.PaperSize = ePaperSize.Folio;
                            ws.PrinterSettings.Orientation = eOrientation.Landscape;
                            ws.PrinterSettings.FitToPage = true;

                            using (var range = ws.Cells[2, 1, dt.Rows.Count + 2, dt.Columns.Count])
                            {
                                var table = ws.Tables.Add(range, "TransactionLogsTable");
                                table.ShowHeader = true;
                                table.TableStyle = TableStyles.Light15;
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
                        //Open the file after exporting
                        System.Diagnostics.Process.Start(save.FileName);
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                logsTable.Columns["studentName"].Visible = false;
                string studentName = studentView.Rows[e.RowIndex].Cells["student_name"].Value.ToString();
                searchLogData(studentName);
                if (logsTable.Rows.Count == 0)
                {
                    searchLogData("");
                }
            }
        }
    }
}
