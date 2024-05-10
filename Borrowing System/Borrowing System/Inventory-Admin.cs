﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Borrowing_System.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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
            productnameTxtbx.Enabled = false;
            conditionTxtbx.Enabled = false;
            quantityTxtbx.Enabled = false;

            MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT Product.productname, Part.partID, Part.partname, Part.partdescription, Part.quantity, Part.condition " +
                "FROM Part " +
                "INNER JOIN Product ON Part.productID = Product.productname", connection);
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
                string query = "SELECT Part.partID, Part.partname, Part.partdescription, Part.quantity, Part.condition, CONCAT(Product.productname) AS productname FROM Part " +
                        "INNER JOIN Product on Part.productID = Product.productID " +
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

            string query = "SELECT Part.partID, Part.partname, Part.partdescription, Part.quantity, Part.condition, Product.productname " +
                           "FROM Part " +
                           "INNER JOIN Product ON Part.productID = Product.productID " +
                           "WHERE CONCAT(Part.partname, Part.partdescription, Part.quantity, Part.condition, Product.productname) LIKE '%" + searchData.Text + "%'";

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
                MySqlCommand cmd = new MySqlCommand("SELECT Product.productname, Part.partID, Part.partname, Part.partdescription, Part.quantity, Part.condition " +
                 "FROM Part " +
                 "INNER JOIN Product ON Part.productID = Product.productname", connection);
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
            try
            {
                if (productnameTxtbx.Text == "" || partnameTxtbx.Text == "" || partdescriptionTxtbx.Text == "" || conditionTxtbx.Text == "")
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

                        if (MessageBox.Show("Are you sure you want to create this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            using (var command = conn.CreateCommand())
                            {
                                command.CommandText = "INSERT INTO Part (productID, partname, partdescription, quantity, `condition`) VALUES (@productname, @partname, @partdescription, @quantity, @condition)";
                                command.Parameters.AddWithValue("@productname", productnameTxtbx.Text);
                                command.Parameters.AddWithValue("@partname", partnameTxtbx.Text);
                                command.Parameters.AddWithValue("@partdescription", partdescriptionTxtbx.Text);
                                command.Parameters.AddWithValue("@quantity", quantityTxtbx.Text);
                                command.Parameters.AddWithValue("@condition", conditionTxtbx.Text);

                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Equipment created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    productnameTxtbx.SelectedIndex = -1;
                                    partIdTxtbx.Text = "";
                                    partnameTxtbx.Text = "";
                                    partdescriptionTxtbx.Text = "";
                                    quantityTxtbx.Value = 0;
                                    conditionTxtbx.SelectedIndex = -1;
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
                        conditionTxtbx.SelectedIndex = -1;

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
                    command.CommandText = "UPDATE Part SET productID = @productname, partname = @partname, partdescription = @partdescription, quantity = @quantity, `condition` = @condition WHERE partID = @partID";
                    command.Parameters.AddWithValue("@productname", productnameTxtbx.Text);
                    command.Parameters.AddWithValue("@partID", partIdTxtbx.Text);
                    command.Parameters.AddWithValue("@partname", partnameTxtbx.Text);
                    command.Parameters.AddWithValue("@partdescription", partdescriptionTxtbx.Text);
                    command.Parameters.AddWithValue("@quantity", quantityTxtbx.Text);
                    command.Parameters.AddWithValue("@condition", conditionTxtbx.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Equipment updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        productnameTxtbx.SelectedIndex = -1;
                        partIdTxtbx.Text = "";
                        partnameTxtbx.Text = "";
                        partdescriptionTxtbx.Text = "";
                        quantityTxtbx.Value = 0;
                        conditionTxtbx.SelectedIndex = -1;
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

        private void editBTN_Click_1(object sender, EventArgs e)
        {
            createBTN.Visible = true;
            updateBTN.Visible = true;
            deleteBTN.Visible = true;
            doneBTN.Visible = true;
            clearBtn.Visible = true;
            editBTN.Visible = false;
            partnameTxtbx.ReadOnly = false;
            productnameTxtbx.Enabled = true;
            partdescriptionTxtbx.ReadOnly = false;
            quantityTxtbx.Enabled = true;
            conditionTxtbx.Enabled = true;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            productnameTxtbx.SelectedIndex = -1;
            partIdTxtbx.Text = "";
            partnameTxtbx.Text = "";
            partdescriptionTxtbx.Text = "";
            quantityTxtbx.Value = 0;
            conditionTxtbx.SelectedIndex = -1;
        }

        private void doneBTN_Click(object sender, EventArgs e)
        {
            createBTN.Visible = false;
            updateBTN.Visible = false;
            deleteBTN.Visible = false;
            doneBTN.Visible = false;
            clearBtn.Visible = false;
            editBTN.Visible = true;
            partnameTxtbx.ReadOnly = true;
            productnameTxtbx.Enabled = false;
            partdescriptionTxtbx.ReadOnly = true;
            quantityTxtbx.Enabled = false;
            conditionTxtbx.Enabled = false;
            productnameTxtbx.SelectedIndex = -1;
            partIdTxtbx.Text = "";
            partnameTxtbx.Text = "";
            partdescriptionTxtbx.Text = "";
            quantityTxtbx.Value = 0;
            conditionTxtbx.SelectedIndex = -1;

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
                conditionTxtbx.Text = row.Cells["condition"].Value.ToString();
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


        //Printing Error ~~~~~~~~~~~~


        //private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    e.Graphics.DrawString("Welcome to Borrowing System", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, 10));

        //    Font font = new Font("Arial", 10);

        //    float yPos = 50;
        //    int count = 0;

        //    // Print the data from the database table
        //    foreach (DataGridView rowView in adminInventoryData.Rows)
        //    {
        //        if (count >= 30) // Maximum 30 rows per page
        //        {
        //            e.HasMorePages = true; // Indicates there are more pages to print
        //            return;
        //        }

        //        DataRow row = rowView.NewRowIndex();
        //        string data = $"{row["column1"]} {row["column2"]}"; // Assuming column1 and column2 are the columns you want to print
        //        e.Graphics.DrawString(data, font, Brushes.Black, new Point(100, (int)yPos));
        //        yPos += 20; // Adjust the spacing as needed
        //        count++;
        //    }

        //    e.HasMorePages = false;
        //}

        //Bitmap bitmap;
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    // Create a new DataTable to store the data
        //    DataTable dataTable = new DataTable();
        //    dataTable.Columns.Add("Column1"); // Replace "Column1" with your actual column name
        //    dataTable.Columns.Add("Column2"); // Replace "Column2" with your actual column name
        //    dataTable.Columns.Add("Column3");
        //    dataTable.Columns.Add("Column4");
        //    dataTable.Columns.Add("Column5");
        //    dataTable.Columns.Add("Column6");

        //    // Iterate through each row in the DataGridView and add the data to the DataTable
        //    foreach (DataGridViewRow row in adminInventoryData.Rows)
        //    {
        //        if (!row.IsNewRow)
        //        {
        //            DataRow dataRow = dataTable.NewRow();
        //            dataRow["Column1"] = row.Cells["productname"].Value.ToString(); // Replace "yourColumn1" with the actual column name
        //            dataRow["Column2"] = row.Cells["partID"].Value.ToString(); // Replace "yourColumn2" with the actual column name
        //            dataRow["Column3"] = row.Cells["partname"].Value.ToString();
        //            dataRow["Column4"] = row.Cells["partdescription"].Value.ToString();
        //            dataRow["Column5"] = row.Cells["quantity"].Value.ToString();
        //            dataRow["Column6"] = row.Cells["condition"].Value.ToString();
        //            dataTable.Rows.Add(dataRow);
        //        }
        //    }

        //    // Display the print preview dialog
        //    printPreviewDialog1.PrintPreviewControl.Zoom = 1;
        //    printPreviewDialog1.Document = printDocument1;
        //    printPreviewDialog1.ShowDialog();
        //}
    }
}
