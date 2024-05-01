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
    public partial class StaffPage : Form
    {
        private bool dragging = false;
        private Point start_point = new Point(1, 0);

        public StaffPage()
        {
            InitializeComponent();
        }

        private void StaffPage_Load(object sender, EventArgs e)
        {
            poslbl.Text = LoginPage.Position;
            idlbl.Text = LoginPage.EmployeeID;
        }

        public void loadform(object Form)
        {
            if (this.staffFormPanel.Controls.Count > 1)
            {
                this.staffFormPanel.Controls.RemoveAt(1);
            }

            Form f = Form as Form;
            f.TopLevel = false;
            this.staffFormPanel.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.BringToFront();
            this.staffFormPanel.Tag = f;
            f.Show();
        }

      

        private void homeBTN_Click(object sender, EventArgs e)
        {
            staffFormPanel.Visible = false;
            homeBTN.BackColor = Color.FromArgb(252, 168, 115);
            homeBTN.ForeColor = Color.Black;
            dashboardBTN.BackColor = Color.FromArgb(233, 215, 174);
            dashboardBTN.ForeColor = Color.FromArgb(84, 84, 84);
            transactionBTN.BackColor = Color.FromArgb(233, 215, 174);
            transactionBTN.ForeColor = Color.FromArgb(84, 84, 84);
            inventoryBTN.BackColor = Color.FromArgb(233, 215, 174);
            inventoryBTN.ForeColor = Color.FromArgb(84, 84, 84);
            logsBTN.BackColor = Color.FromArgb(233, 215, 174);
            logsBTN.ForeColor = Color.FromArgb(84, 84, 84);
            settingsBTN.BackColor = Color.FromArgb(233, 215, 174);
            settingsBTN.ForeColor = Color.FromArgb(84, 84, 84);
        }

        private void dashboardBTN_Click(object sender, EventArgs e)
        {
            loadform(new DashboardPage());
            staffFormPanel.Visible = true;
            homeBTN.BackColor = Color.FromArgb(233, 215, 174);
            homeBTN.ForeColor = Color.FromArgb(84, 84, 84);
            dashboardBTN.BackColor = Color.FromArgb(252, 168, 115);
            dashboardBTN.ForeColor = Color.Black;
            transactionBTN.BackColor = Color.FromArgb(233, 215, 174);
            transactionBTN.ForeColor = Color.FromArgb(84, 84, 84);
            inventoryBTN.BackColor = Color.FromArgb(233, 215, 174);
            inventoryBTN.ForeColor = Color.FromArgb(84, 84, 84);
            logsBTN.BackColor = Color.FromArgb(233, 215, 174);
            logsBTN.ForeColor = Color.FromArgb(84, 84, 84);
            settingsBTN.BackColor = Color.FromArgb(233, 215, 174);
            settingsBTN.ForeColor = Color.FromArgb(84, 84, 84);
        }

        private void transactionBTN_Click(object sender, EventArgs e)
        {
            loadform(new TransactionPage());
            staffFormPanel.Visible = true;
            homeBTN.BackColor = Color.FromArgb(233, 215, 174);
            homeBTN.ForeColor = Color.FromArgb(84, 84, 84);
            dashboardBTN.BackColor = Color.FromArgb(233, 215, 174);
            dashboardBTN.ForeColor = Color.FromArgb(84, 84, 84);
            transactionBTN.BackColor = Color.FromArgb(252, 168, 115);
            transactionBTN.ForeColor = Color.Black;
            inventoryBTN.BackColor = Color.FromArgb(233, 215, 174);
            inventoryBTN.ForeColor = Color.FromArgb(84, 84, 84);
            logsBTN.BackColor = Color.FromArgb(233, 215, 174);
            logsBTN.ForeColor = Color.FromArgb(84, 84, 84);
            settingsBTN.BackColor = Color.FromArgb(233, 215, 174);
            settingsBTN.ForeColor = Color.FromArgb(84, 84, 84);
        }

        private void inventoryBTN_Click(object sender, EventArgs e)
        {
            loadform(new Inventory_Staff());
            staffFormPanel.Visible = true;
            homeBTN.BackColor = Color.FromArgb(233, 215, 174);
            homeBTN.ForeColor = Color.FromArgb(84, 84, 84);
            dashboardBTN.BackColor = Color.FromArgb(233, 215, 174);
            dashboardBTN.ForeColor = Color.FromArgb(84, 84, 84);
            transactionBTN.BackColor = Color.FromArgb(233, 215, 174);
            transactionBTN.ForeColor = Color.FromArgb(84, 84, 84);
            inventoryBTN.BackColor = Color.FromArgb(252, 168, 115);
            inventoryBTN.ForeColor = Color.Black;
            logsBTN.BackColor = Color.FromArgb(233, 215, 174);
            logsBTN.ForeColor = Color.FromArgb(84, 84, 84);
            settingsBTN.BackColor = Color.FromArgb(233, 215, 174);
            settingsBTN.ForeColor = Color.FromArgb(84, 84, 84);
        }

        private void logsBTN_Click(object sender, EventArgs e)
        {
            loadform(new TransactionLogsPage());
            staffFormPanel.Visible = true;
            homeBTN.BackColor = Color.FromArgb(233, 215, 174);
            homeBTN.ForeColor = Color.FromArgb(84, 84, 84);        
            dashboardBTN.BackColor = Color.FromArgb(233, 215, 174);
            dashboardBTN.ForeColor = Color.FromArgb(84, 84, 84);
            transactionBTN.BackColor = Color.FromArgb(233, 215, 174);
            transactionBTN.ForeColor = Color.FromArgb(84, 84, 84);
            inventoryBTN.BackColor = Color.FromArgb(233, 215, 174);
            inventoryBTN.ForeColor = Color.FromArgb(84, 84, 84);
            logsBTN.BackColor = Color.FromArgb(252, 168, 115);
            logsBTN.ForeColor = Color.Black;
            settingsBTN.BackColor = Color.FromArgb(233, 215, 174);
            settingsBTN.ForeColor = Color.FromArgb(84, 84, 84);
        }

        private void settingsBTN_Click(object sender, EventArgs e)
        {
            loadform(new Settings());
            staffFormPanel.Visible = true;          
            homeBTN.BackColor = Color.FromArgb(233, 215, 174);
            homeBTN.ForeColor = Color.FromArgb(84, 84, 84);
            dashboardBTN.BackColor = Color.FromArgb(233, 215, 174);
            dashboardBTN.ForeColor = Color.FromArgb(84, 84, 84);
            transactionBTN.BackColor = Color.FromArgb(233, 215, 174);
            transactionBTN.ForeColor = Color.FromArgb(84, 84, 84);
            inventoryBTN.BackColor = Color.FromArgb(233, 215, 174);
            inventoryBTN.ForeColor = Color.FromArgb(84, 84, 84);
            logsBTN.BackColor = Color.FromArgb(233, 215, 174);
            logsBTN.ForeColor = Color.FromArgb(84, 84, 84);
            settingsBTN.BackColor = Color.FromArgb(252, 168, 115);
            settingsBTN.ForeColor = Color.Black;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void StaffPage_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            start_point = new Point(e.X, e.Y);
        }

        private void StaffPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.start_point.X, p.Y - this.start_point.Y);
            }
        }

        private void StaffPage_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
