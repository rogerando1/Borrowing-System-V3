using Borrowing_System.Data;
using MySql.Data.MySqlClient;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using OfficeOpenXml.Table;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Borrowing_System
{
    public partial class Inventory_Admin : Form
    {
        public Inventory_Admin()
        {
            InitializeComponent();
        }

        private void Inventory_Admin_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT Product.productname, Part.partID, Part.partname, Part.partdescription, Part.quantity, Part.defective " +
                "FROM Part " +
                "INNER JOIN Product ON Part.productID = Product.productID", connection);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            adminInventoryData.DataSource = dt;
            FillComboBox();
        }

        private void productnamelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productnamelist.SelectedItem == null)
            {
                return;
            }

            if (productnamelist.Text == "(Select none)")
            {
                ReloadDataGridView();
            }
            else
            {
                string productName = productnamelist.SelectedItem.ToString();
                MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                connection.Open();
                string query = "SELECT Part.partID, Part.partname, Part.partdescription, Part.quantity, Part.defective, " +
                        "CONCAT(Product.productname) AS productname FROM Part " +
                        "LEFT JOIN Product on Part.productID = Product.productID " +
                        "WHERE Product.productname = @productName";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@productName", productName);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                adminInventoryData.DataSource = dt;
            }

        }
        private void FillComboBox()
        {
            try
            {
                //Default Empty Value for Name List
                productnamelist.Items.Add("(Select none)");

                MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT productname FROM Product", connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string eqName = reader.GetString("productname");
                    productnamelist.Items.Add(eqName);
                    productnameTxtbx.Items.Add(eqName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void adminInventoryData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            string Search = searchData.Text.ToString();
            searchDatas(Search);
        }

        private void searchData_TextChanged(object sender, EventArgs e)
        {
            if (searchData.Text == "")
            {
                ReloadDataGridView();
            }
        }

        public void searchDatas(string Search)
        {
            MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            connection.Open();

            string query = "SELECT Part.partID, Part.partname, Part.partdescription, Part.quantity, Part.defective, Product.productname " +
                           "FROM Part " +
                           "INNER JOIN Product ON Part.productID = Product.productID " +
                           "WHERE CONCAT(Part.partname, Part.partdescription, Part.quantity, Part.defective, Product.productname) LIKE '%" + searchData.Text + "%'";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                adminInventoryData.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Data not found.");
            }
        }

        private void ReloadDataGridView()
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT Product.productname, Part.partID, Part.partname, Part.partdescription, Part.quantity, Part.defective " +
                 "FROM Part " +
                 "INNER JOIN Product ON Part.productID = Product.productID", connection);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(dt);
                adminInventoryData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reloading DataGridView: " + ex.Message);
            }
        }

        private void createBTN_Click(object sender, EventArgs e)
        {
            //Read the product name from the textbox and convert it into its productID and store it in a variable and make sure it is integer
            string productName = productnameTxtbx.Text;
            int productID = 0;

            MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT productID FROM Product WHERE productname = @productName", connection);
            cmd.Parameters.AddWithValue("@productName", productName);
            MySqlDataReader reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                productID = reader1.GetInt32("productID");
            }
            reader1.Close();



            try
            {
                if (productnameTxtbx.Text == "" || partnameTxtbx.Text == "" || partdescriptionTxtbx.Text == "" || defectiveTxtbx.Text == "")
                {
                    MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (quantityTxtbx.Value == 0)
                {
                    MessageBox.Show("Quantity should not be 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (var conn = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}"))
                    {
                        conn.Open();

                        //Check if Product name exists
                        using (var command = new MySqlCommand($"SELECT * FROM Product WHERE productname = @productname", conn))
                        {
                            command.Parameters.AddWithValue("@productname", productnameTxtbx.Text);
                            using (var reader = command.ExecuteReader())
                            {
                                if (!reader.HasRows)
                                {
                                    MessageBox.Show("Product name does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }

                        // Check if Part name already exists
                        using (var command = new MySqlCommand($"SELECT * FROM Part WHERE partname = @partname", conn))
                        {
                            command.Parameters.AddWithValue("@partname", partnameTxtbx.Text);
                            using (var reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    MessageBox.Show("Part name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }

                        }

                        partIdTxtbx.Text = "";

                        if (MessageBox.Show("Are you sure you want to add this equipment to inventory?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            using (var command = conn.CreateCommand())
                            {
                                command.CommandText = "INSERT INTO Part (productID, partname, partdescription, quantity, `defective`) " +
                                                         "VALUES (@productname, @partname, @partdescription, @quantity, @defective)";
                                command.Parameters.AddWithValue("@productname", productID);
                                command.Parameters.AddWithValue("@partname", partnameTxtbx.Text);
                                command.Parameters.AddWithValue("@partdescription", partdescriptionTxtbx.Text);
                                command.Parameters.AddWithValue("@quantity", quantityTxtbx.Text);
                                command.Parameters.AddWithValue("@defective", defectiveTxtbx.Text);

                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Equipment created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    productnameTxtbx.SelectedIndex = -1;
                                    partIdTxtbx.Text = "";
                                    partnameTxtbx.Text = "";
                                    partdescriptionTxtbx.Text = "";
                                    quantityTxtbx.Value = 0;
                                    defectiveTxtbx.Value = 0;
                                    ReloadDataGridView();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to create equipment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            string partID = partIdTxtbx.Text;
            MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            connection.Open();
            string queryCheck = "SELECT * FROM Part where partID = @partID";
            MySqlCommand cmd = new MySqlCommand(queryCheck, connection);
            cmd.Parameters.AddWithValue("@partID", partID);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("Equipment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    MySqlConnection con = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    con.Open();
                    MySqlCommand command = con.CreateCommand();
                    command.CommandText = "DELETE FROM Part WHERE partID = @partID";
                    command.Parameters.AddWithValue("@partID", partID);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Equipment deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        productnameTxtbx.SelectedIndex = -1;
                        partIdTxtbx.Text = "";
                        partnameTxtbx.Text = "";
                        partdescriptionTxtbx.Text = "";
                        quantityTxtbx.Value = 0;
                        defectiveTxtbx.Value = 0;

                        ReloadDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete equipment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void updateBTN_Click(object sender, EventArgs e)
        {

            //Read the product name from the textbox and convert it into its productID and store it in a variable and make sure it is integer
            string productName = productnameTxtbx.Text;
            int productID = 0;

            MySqlConnection connection1 = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            connection1.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT productID FROM Product WHERE productname = @productName", connection1);
            cmd.Parameters.AddWithValue("@productName", productName);
            MySqlDataReader reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                productID = reader1.GetInt32("productID");
            }
            reader1.Close();

            try
            {
                if (string.IsNullOrWhiteSpace(partdescriptionTxtbx.Text) || string.IsNullOrWhiteSpace(quantityTxtbx.Text))
                {
                    MessageBox.Show("Please provide all necessary information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string partID = partIdTxtbx.Text;
                MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                connection.Open();
                string queryCheck = "SELECT * FROM Part where partID = @partID";
                MySqlCommand command = new MySqlCommand(queryCheck, connection);
                command.Parameters.AddWithValue("@partID", partID);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Equipment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to update this equipment?", "Update Equipment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    command = connection.CreateCommand();
                    command.CommandText = "UPDATE Part SET productID = @productname, partname = @partname, partdescription = @partdescription, quantity = @quantity, `defective` = @defective WHERE partID = @partID";
                    command.Parameters.AddWithValue("@productname", productID);
                    command.Parameters.AddWithValue("@partID", partIdTxtbx.Text);
                    command.Parameters.AddWithValue("@partname", partnameTxtbx.Text);
                    command.Parameters.AddWithValue("@partdescription", partdescriptionTxtbx.Text);
                    command.Parameters.AddWithValue("@quantity", quantityTxtbx.Text);
                    command.Parameters.AddWithValue("@defective", defectiveTxtbx.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Equipment updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        productnameTxtbx.SelectedIndex = -1;
                        partIdTxtbx.Text = "";
                        partnameTxtbx.Text = "";
                        partdescriptionTxtbx.Text = "";
                        quantityTxtbx.Value = 0;
                        defectiveTxtbx.Value = 0;
                        ReloadDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update equipment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            productnameTxtbx.SelectedIndex = -1;
            partIdTxtbx.Text = "";
            partnameTxtbx.Text = "";
            partdescriptionTxtbx.Text = "";
            quantityTxtbx.Value = 0;
            defectiveTxtbx.Value = 0;
        }

        private void adminInventoryData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = adminInventoryData.Rows[e.RowIndex];

                productnameTxtbx.Text = row.Cells["productname"].Value.ToString();
                partIdTxtbx.Text = row.Cells["partID"].Value.ToString();
                partnameTxtbx.Text = row.Cells["partname"].Value?.ToString();
                partdescriptionTxtbx.Text = row.Cells["partdescription"].Value.ToString();
                quantityTxtbx.Text = row.Cells["quantity"].Value.ToString();
                defectiveTxtbx.Text = row.Cells["defective"].Value.ToString();
            }
        }

        private void productnameTxtbx_DropDown(object sender, EventArgs e)
        {
            //FIT THE DROPDOWN WIDTH TO THE WIDEST ITEM

            int maxWidth = productnameTxtbx.Width;
            Graphics g = productnameTxtbx.CreateGraphics();
            Font font = productnameTxtbx.Font;

            foreach (var item in productnameTxtbx.Items)
            {
                int itemWidth = (int)g.MeasureString(item.ToString(), font).Width;
                if (itemWidth > maxWidth)
                {
                    maxWidth = itemWidth;
                }
            }

            productnameTxtbx.DropDownWidth = maxWidth;
        }

        private void productnamelist_DropDown(object sender, EventArgs e)
        {
            //FIT THE DROPDOWN WIDTH TO THE WIDEST ITEM

            int maxWidth = productnamelist.Width;
            Graphics g = productnamelist.CreateGraphics();
            Font font = productnamelist.Font;

            foreach (var item in productnamelist.Items)
            {
                int itemWidth = (int)g.MeasureString(item.ToString(), font).Width;
                if (itemWidth > maxWidth)
                {
                    maxWidth = itemWidth;
                }
            }

            productnamelist.DropDownWidth = maxWidth;
        }

        private void searchData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBTN.PerformClick();
            }
        }

        private void uploadBTN_Click(object sender, EventArgs e)
        {
            //Upload CSV for Inventory
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "CSV Files|*.csv";
                openFileDialog.Title = "Select a CSV File";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string[] lines = File.ReadAllLines(filePath);
                    string[] fields;
                    string query = "";
                    MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    for (int i = 1; i < lines.Length; i++)
                    {
                        fields = lines[i].Split(',');
                        string productID = fields[0];
                        string partname = fields[1];
                        string partdescription = fields[2];
                        string quantity = fields[3];
                        string defective = fields[4];

                        //If a part already existed, show an error message
                        query = $"SELECT * FROM Part WHERE productID = '{productID}' AND partname = '{partname}' AND partdescription = '{partdescription}' AND quantity = '{quantity}' AND `defective` = '{defective}'";
                        cmd = new MySqlCommand(query, connection);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Some parts already exists. Please check for duplicates.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            connection.Close();
                            return;
                        }
                        reader.Close();

                        // If productID does not exist, proceed with insertion
                        query = $"INSERT INTO Part (productID, partname, partdescription, quantity, `defective`) VALUES ('{productID}', '{partname}', '{partdescription}', '{quantity}', '{defective}')";
                        cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    MessageBox.Show("Data has been successfully imported", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadDataGridView();
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"DO NOT USE special characters like a comma and please follow the correct excel/csv format: productID, partname, partdescription, quantity, and defective as columns respectively.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                            ExcelWorksheet ws = package.Workbook.Worksheets.Add("Inventory Page");

                            DataTable dt = this.adminInventoryData.DataSource as DataTable;
                                                                                 
                            // Load data into worksheet
                            ws.Cells["A2"].LoadFromDataTable(dt, true);

                            // Merge and format the title row
                            ws.Cells["A1:F1"].Merge = true;
                            ws.Cells["A1"].Value = $"Inventory Details";
                            ws.Cells["A1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                            ws.Cells["A1"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.WhiteSmoke);
                            ws.Cells["A1"].Style.Font.Color.SetColor(System.Drawing.Color.Black);
                            ws.Cells["A1"].Style.Font.Bold = true;
                            ws.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                            // Center align header row
                            ws.Row(2).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            ws.PrinterSettings.PaperSize = ePaperSize.Legal;
                            ws.PrinterSettings.Orientation = eOrientation.Landscape;

                            // Center text for each cells
                            ws.Cells[ws.Dimension.Address].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                            // Adjust column widths
                            ws.Cells[ws.Dimension.Address].AutoFitColumns();

                            using (var range = ws.Cells[2, 1, dt.Rows.Count + 2, dt.Columns.Count])
                            {
                                var table = ws.Tables.Add(range, "InventoryTable");
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
                        DataTable dt = this.adminInventoryData.DataSource as DataTable;
                        //Open the file after exporting
                        System.Diagnostics.Process.Start(save.FileName);
                    }
                }
            }
        }
    }
}
