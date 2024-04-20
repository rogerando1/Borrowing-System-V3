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
            string query = "SELECT Part.productID, Part.partname, Part.partdescription, Part.quantity, Part.condition, CONCAT(Product.productname) AS productname FROM Part " +
                    "INNER JOIN Product on Part.productID = Product.productID " +
                    "WHERE Product.productname = @productName";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@productName", productName);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            adminInventoryData.DataSource = dt;
            
        }
      
        private void adminInventoryData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = adminInventoryData.Rows[e.RowIndex];

                productnameTxtbx.Text = row.Cells["productname"].Value.ToString();
                partIdTxtbx.Text = row.Cells["partID"].Value.ToString();
                partnameTxtbx.Text = row.Cells["partname"].Value.ToString();
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

        private void editBTN_Click(object sender, EventArgs e)
        {

        }

        private void createBTN_Click(object sender, EventArgs e)
        {

        }

        private void editBTN_Click_1(object sender, EventArgs e)
        {
            createBTN.Visible = true;
            updateBTN.Visible = true;
            deleteBTN.Visible = true;
            doneBTN.Visible = true;
            clearBtn.Visible = true;
            editBTN.Visible = false;
            partdescriptionTxtbx.ReadOnly = false;
            quantityTxtbx.ReadOnly = false;
            conditionTxtbx.ReadOnly = false;
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {

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

        private void deleteBTN_Click(object sender, EventArgs e)
        {

        }

        private void doneBTN_Click(object sender, EventArgs e)
        {
            createBTN.Visible = false;
            updateBTN.Visible = false;
            deleteBTN.Visible = false;
            doneBTN.Visible = false;
            clearBtn.Visible = false;
            editBTN.Visible = true;
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
