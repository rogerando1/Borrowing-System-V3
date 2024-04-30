namespace Borrowing_System
{
    partial class DashboardPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dashboardTable = new System.Windows.Forms.DataGridView();
            this.searchBTN = new System.Windows.Forms.Button();
            this.searchTxtbx = new System.Windows.Forms.TextBox();
            this.transactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordertime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboardTable
            // 
            this.dashboardTable.AllowUserToAddRows = false;
            this.dashboardTable.AllowUserToDeleteRows = false;
            this.dashboardTable.AllowUserToOrderColumns = true;
            this.dashboardTable.AllowUserToResizeColumns = false;
            this.dashboardTable.AllowUserToResizeRows = false;
            this.dashboardTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dashboardTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.dashboardTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dashboardTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dashboardTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dashboardTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dashboardTable.ColumnHeadersHeight = 50;
            this.dashboardTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dashboardTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionID,
            this.studentName,
            this.instructorName,
            this.accountName,
            this.partName,
            this.quantity,
            this.orderdate,
            this.ordertime,
            this.status_});
            this.dashboardTable.EnableHeadersVisualStyles = false;
            this.dashboardTable.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dashboardTable.Location = new System.Drawing.Point(18, 101);
            this.dashboardTable.Margin = new System.Windows.Forms.Padding(2);
            this.dashboardTable.Name = "dashboardTable";
            this.dashboardTable.ReadOnly = true;
            this.dashboardTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dashboardTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dashboardTable.RowHeadersVisible = false;
            this.dashboardTable.RowHeadersWidth = 50;
            this.dashboardTable.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dashboardTable.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(140)))), ((int)(((byte)(217)))));
            this.dashboardTable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardTable.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dashboardTable.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.dashboardTable.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dashboardTable.RowTemplate.Height = 30;
            this.dashboardTable.RowTemplate.ReadOnly = true;
            this.dashboardTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dashboardTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dashboardTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dashboardTable.Size = new System.Drawing.Size(1467, 500);
            this.dashboardTable.TabIndex = 3;
            this.dashboardTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dashboardTable_CellClick);
            this.dashboardTable.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dashboardTable_CellMouseEnter);
            this.dashboardTable.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dashboardTable_CellMouseLeave);
            this.dashboardTable.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dashboardTable_CellPainting);
            // 
            // searchBTN
            // 
            this.searchBTN.BackColor = System.Drawing.Color.White;
            this.searchBTN.BackgroundImage = global::Borrowing_System.Properties.Resources.search_icon;
            this.searchBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.searchBTN.FlatAppearance.BorderSize = 0;
            this.searchBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.searchBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.searchBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBTN.ForeColor = System.Drawing.Color.White;
            this.searchBTN.Location = new System.Drawing.Point(1124, 38);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(33, 36);
            this.searchBTN.TabIndex = 9;
            this.searchBTN.UseVisualStyleBackColor = false;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // searchTxtbx
            // 
            this.searchTxtbx.BackColor = System.Drawing.Color.White;
            this.searchTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.searchTxtbx.Location = new System.Drawing.Point(294, 43);
            this.searchTxtbx.Name = "searchTxtbx";
            this.searchTxtbx.Size = new System.Drawing.Size(824, 28);
            this.searchTxtbx.TabIndex = 14;
            this.searchTxtbx.TextChanged += new System.EventHandler(this.searchTxtbx_TextChanged);
            this.searchTxtbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTxtbx_KeyDown);
            // 
            // transactionID
            // 
            this.transactionID.DataPropertyName = "transactionID";
            this.transactionID.HeaderText = "Transaction ID";
            this.transactionID.MinimumWidth = 6;
            this.transactionID.Name = "transactionID";
            this.transactionID.ReadOnly = true;
            // 
            // studentName
            // 
            this.studentName.DataPropertyName = "studentName";
            this.studentName.HeaderText = "Student Name";
            this.studentName.MinimumWidth = 6;
            this.studentName.Name = "studentName";
            this.studentName.ReadOnly = true;
            // 
            // instructorName
            // 
            this.instructorName.DataPropertyName = "instructorName";
            this.instructorName.HeaderText = "Instructor Name";
            this.instructorName.MinimumWidth = 6;
            this.instructorName.Name = "instructorName";
            this.instructorName.ReadOnly = true;
            // 
            // accountName
            // 
            this.accountName.DataPropertyName = "accountName";
            this.accountName.HeaderText = "Employee Name";
            this.accountName.MinimumWidth = 6;
            this.accountName.Name = "accountName";
            this.accountName.ReadOnly = true;
            // 
            // partName
            // 
            this.partName.DataPropertyName = "partName";
            this.partName.HeaderText = "Equipment Name";
            this.partName.MinimumWidth = 6;
            this.partName.Name = "partName";
            this.partName.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // orderdate
            // 
            this.orderdate.DataPropertyName = "orderdate";
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.orderdate.DefaultCellStyle = dataGridViewCellStyle6;
            this.orderdate.HeaderText = "Order Date";
            this.orderdate.MinimumWidth = 6;
            this.orderdate.Name = "orderdate";
            this.orderdate.ReadOnly = true;
            // 
            // ordertime
            // 
            this.ordertime.DataPropertyName = "ordertime";
            dataGridViewCellStyle7.Format = "T";
            dataGridViewCellStyle7.NullValue = null;
            this.ordertime.DefaultCellStyle = dataGridViewCellStyle7;
            this.ordertime.HeaderText = "Order Time";
            this.ordertime.MinimumWidth = 6;
            this.ordertime.Name = "ordertime";
            this.ordertime.ReadOnly = true;
            // 
            // status_
            // 
            this.status_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.status_.DataPropertyName = "status_";
            this.status_.HeaderText = "Status";
            this.status_.MinimumWidth = 6;
            this.status_.Name = "status_";
            this.status_.ReadOnly = true;
            this.status_.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status_.Width = 89;
            // 
            // DashboardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Borrowing_System.Properties.Resources.Dashboard_Page;
            this.ClientSize = new System.Drawing.Size(1532, 650);
            this.Controls.Add(this.searchTxtbx);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.dashboardTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardPage";
            this.Text = "DashboardPage";
            this.Load += new System.EventHandler(this.DashboardPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dashboardTable;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.TextBox searchTxtbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn partName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordertime;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_;
    }
}