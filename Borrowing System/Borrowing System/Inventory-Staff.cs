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
using OfficeOpenXml;
using System.IO;
using OfficeOpenXml.Style;
using System.Windows.Media;
using OfficeOpenXml.Table;

namespace Borrowing_System
{
    public partial class Inventory_Staff : Form
    {
        public Inventory_Staff()
        {
            InitializeComponent();
        }

        private void Inventory_Staff_Load(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT Product.productname, Part.partID, Part.partname, Part.partdescription, Part.quantity, Part.defective " +
                "FROM Part " +
                "INNER JOIN Product ON Part.productID = Product.productID", connection);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            staffInventoryData.DataSource = dt;

            FillComboBox();
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                staffInventoryData.DataSource = dt;
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
                 "INNER JOIN Product ON Part.productID = Product.productname", connection);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(dt);
                staffInventoryData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reloading DataGridView: " + ex.Message);
            }
        }

        private void staffInventoryData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = staffInventoryData.Rows[e.RowIndex];

                productnameTxtbx.Text = row.Cells["productname"].Value.ToString();
                partIdTxtbx.Text = row.Cells["partID"].Value.ToString();
                partnameTxtbx.Text = row.Cells["partname"].Value?.ToString();
                partdescriptionTxtbx.Text = row.Cells["partdescription"].Value.ToString();
                quantityTxtbx.Text = row.Cells["quantity"].Value.ToString();
                defectiveTxtbx.Text = row.Cells["defective"].Value.ToString();
            }
        }

        private void productnamelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productnamelist.SelectedItem == null)
            {
                return;
            }

            if(productnamelist.Text == "(Select none)")
            {
                ReloadDataGridView();
            }
            else
            {
                string productName = productnamelist.SelectedItem.ToString();
                MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                connection.Open();
                string query = "SELECT Part.partID, Part.partname, Part.partdescription, Part.quantity, Part.defective, CONCAT(Product.productname) AS productname FROM Part " +
                        "INNER JOIN Product on Part.productID = Product.productID " +
                        "WHERE Product.productname = @productName";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@productName", productName);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                staffInventoryData.DataSource = dt;
            }
        }

        private void staffInventoryData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = staffInventoryData.Rows[e.RowIndex];

                productnameTxtbx.Text = row.Cells["productname"].Value.ToString();
                partIdTxtbx.Text = row.Cells["partID"].Value.ToString();
                partnameTxtbx.Text = row.Cells["partname"].Value?.ToString();
                partdescriptionTxtbx.Text = row.Cells["partdescription"].Value.ToString();
                quantityTxtbx.Text = row.Cells["quantity"].Value.ToString();
                defectiveTxtbx.Text = row.Cells["defective"].Value.ToString();
            }
        }

        private void searchData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBTN.PerformClick();
            }
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

                            DataTable dt = this.staffInventoryData.DataSource as DataTable;

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
                        DataTable dt = this.staffInventoryData.DataSource as DataTable;
                        //Open the file after exporting
                        System.Diagnostics.Process.Start(save.FileName);
                    }
                }
            }
        }
    }
}
