using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Borrowing_System.Data;
using MySql.Data.MySqlClient;


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
        private void FillComboBox()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT productname FROM sql6690575.Product", connection);
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

        private void adminInventoryData_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                if (productnameTxtbx.Text == "" || partnameTxtbx.Text == "" || partdescriptionTxtbx.Text == "" || quantityTxtbx.Text == "" || conditionTxtbx.Text == "")
                {
                    MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var conn = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}"))
                {
                    conn.Open();

                    // Check if the product name exists
                    using (var command = new MySqlCommand($"SELECT * FROM Product WHERE productname = @productname", conn))
                    {
                        command.Parameters.AddWithValue("@productname", productnameTxtbx.Text);
                        using (var reader = command.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Product name does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    // Check if the part name already exists
                    using (var command = new MySqlCommand($"SELECT * FROM Part WHERE partname = @partname", conn))
                    {
                        command.Parameters.AddWithValue("@partname", partnameTxtbx.Text);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Part Name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    if (MessageBox.Show("Are you sure you want to create this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (var mySqlCommand = new MySqlCommand("INSERT INTO Part (productID, partname, partdescription, quantity, `condition`) VALUES (@productID, @partname, @partdescription, @quantity, @condition)", conn))
                        {
                            mySqlCommand.Parameters.AddWithValue("@productID", productnameTxtbx.Text);
                            mySqlCommand.Parameters.AddWithValue("@partname", partnameTxtbx.Text);
                            mySqlCommand.Parameters.AddWithValue("@partdescription", partdescriptionTxtbx.Text);
                            mySqlCommand.Parameters.AddWithValue("@quantity", quantityTxtbx.Text);
                            mySqlCommand.Parameters.AddWithValue("@condition", conditionTxtbx.Text);

                            mySqlCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Account created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AccountManagementPage.instance.refreshData();
                        partIdTxtbx.Text = "";
                        productnameTxtbx.Text = "";
                        partnameTxtbx.Text = "";
                        partdescriptionTxtbx.Text = "";
                        quantityTxtbx.Text = "";
                        conditionTxtbx.Text = "";
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
                        productnameTxtbx.Text = "";
                        partIdTxtbx.Text = "";
                        partnameTxtbx.Text = "";
                        partdescriptionTxtbx.Text = "";
                        quantityTxtbx.Text = "";
                        conditionTxtbx.Text = "";

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
                if(string.IsNullOrWhiteSpace(partdescriptionTxtbx.Text) || string.IsNullOrWhiteSpace(quantityTxtbx.Text))
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
                    command.Parameters.AddWithValue("@partdescription",partdescriptionTxtbx.Text);
                    command.Parameters.AddWithValue("@quantity", quantityTxtbx.Text);
                    command.Parameters.AddWithValue("@condition", conditionTxtbx.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    if(rowsAffected > 0)
                    {
                        MessageBox.Show("Equipment updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        productnameTxtbx.Text = "";
                        partIdTxtbx.Text = "";
                        partnameTxtbx.Text = "";
                        partdescriptionTxtbx.Text = "";
                        quantityTxtbx.Text = "";
                        conditionTxtbx.Text = "";
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
            productnameTxtbx.ReadOnly = false;
            partdescriptionTxtbx.ReadOnly = false;
            quantityTxtbx.ReadOnly = false;
            conditionTxtbx.ReadOnly = false;
        }
        
        private void clearBtn_Click(object sender, EventArgs e)
        {
            productnameTxtbx.Text = "";
            partIdTxtbx.Text = "";
            partnameTxtbx.Text = "";
            partdescriptionTxtbx.Text = "";
            quantityTxtbx.Text = "";
            conditionTxtbx.Text = "";
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
            productnameTxtbx.ReadOnly = true;
            partdescriptionTxtbx.ReadOnly = true;
            quantityTxtbx.ReadOnly = true;
            conditionTxtbx.ReadOnly = true;
            productnameTxtbx.Text = "";
            partIdTxtbx.Text = "";
            partnameTxtbx.Text = "";
            partdescriptionTxtbx.Text = "";
            quantityTxtbx.Text = "";
            conditionTxtbx.Text = "";
          
        }
    }
}
