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
            MySqlCommand cmd = new MySqlCommand("SELECT Product.productname, Part.partID, Part.partname, Part.partdescription, Part.quantity, Part.condition " +
                "FROM Part " +
                "INNER JOIN Product ON Part.productID = Product.productname", connection);
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
                MySqlCommand cmd = new MySqlCommand("SELECT Product.productname, Part.partID, Part.partname, Part.partdescription, Part.quantity, Part.condition " +
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
                conditionTxtbx.Text = row.Cells["condition"].Value.ToString();
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
                string query = "SELECT Part.partID, Part.partname, Part.partdescription, Part.quantity, Part.condition, CONCAT(Product.productname) AS productname FROM Part " +
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
                conditionTxtbx.Text = row.Cells["condition"].Value.ToString();
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
