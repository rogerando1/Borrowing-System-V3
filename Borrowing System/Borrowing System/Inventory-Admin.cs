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
            MySqlCommand cmd = new MySqlCommand("SELECT Part.productID, Part.partname, Part.partdescription, Part.quantity, Part.condition, " +
                "CONCAT(Product.productname) AS productname FROM Part " +
                "INNER JOIN Product on Part.productID = Product.productID", connection);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            adminInventoryData.DataSource = dt;
            connection.Close();

        }

        private void productnamelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Product", connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string eqName = reader.GetString("productname");
                    productnamelist.Items.Add(eqName);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
