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
using Borrowing_System.Data;

namespace Borrowing_System
{
    public partial class LoginPage : Form
    {
        private bool dragging = false;
        private Point start_point = new Point(1, 0);

        public static string Username { get; set; }
        public static string EmployeeID { get; set; }
        public static string Position { get; set; }

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if(usernameTxtbx.Text == "" || passwordTxtbx.Text == "")
                {
                    MessageBox.Show("Please fill in the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MySqlConnection mySqlConnection = new MySqlConnection($"datasource={DatabaseConfig.ServerName};port=3306;username={DatabaseConfig.UserId};password={DatabaseConfig.Password};database={DatabaseConfig.DatabaseName}");
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand($"SELECT * FROM Accounts WHERE username = '{usernameTxtbx.Text}' AND password_ = '{passwordTxtbx.Text}'", mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                if (mySqlDataReader.Read())
                {
                    Username = mySqlDataReader["username"].ToString();
                    EmployeeID = mySqlDataReader["personID"].ToString();
                    Position = mySqlDataReader["position"].ToString();

                    if (mySqlDataReader["position"].ToString() == "Admin")
                    {
                        this.Hide();
                        AdminPage adminPage = new AdminPage();
                        adminPage.Show();
                    }
                    else
                    {
                        this.Hide();
                        StaffPage staffPage = new StaffPage();
                        staffPage.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoginPage_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            start_point = new Point(e.X, e.Y);
        }

        private void LoginPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.start_point.X, p.Y - this.start_point.Y);
            }
        }

        private void LoginPage_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void usernameTxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTxtbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBTN.PerformClick();
            }
        }

        private void passwordTxtbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBTN.PerformClick();
            }
        }
    }
}
