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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {

        }

        private void doneBTN_Click(object sender, EventArgs e)
        {
            firstnameTxtbx.ReadOnly = true;
            lastnameTxtbx.ReadOnly = true;
            usernameTxtbx.ReadOnly = true;
            passwordTxtbx.ReadOnly = true;
            updateBTN.Visible = false;
            doneBTN.Visible = false;
            editBTN.Visible = true;
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            firstnameTxtbx.ReadOnly = false;
            lastnameTxtbx.ReadOnly = false;
            usernameTxtbx.ReadOnly = false;
            passwordTxtbx.ReadOnly = false;
            updateBTN.Visible = true;
            doneBTN.Visible = true;
            editBTN.Visible = false;
        }

        private void profileBTN_Click(object sender, EventArgs e)
        {
            aboutBTN.BackColor = Color.White;
            profileBTN.BackColor = Color.FromArgb(162, 199, 230);
            this.aboutPanel.Hide();
            this.accountInfoPanel.Show();
            
        }

        private void aboutBTN_Click(object sender, EventArgs e)
        {
            profileBTN.BackColor = Color.White;
            aboutBTN.BackColor = Color.FromArgb(162, 199, 230);
            this.accountInfoPanel.Hide();
            this.aboutPanel.Show();
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            StaffPage staffpage= (StaffPage)Application.OpenForms["StaffPage"];
            staffpage.Close();
        }
    }
}
