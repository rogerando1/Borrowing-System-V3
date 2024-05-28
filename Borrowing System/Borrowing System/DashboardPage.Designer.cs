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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dashboardTable = new System.Windows.Forms.DataGridView();
            this.transactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordertime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchTxtbx = new System.Windows.Forms.TextBox();
            this.clearDashBtn = new System.Windows.Forms.Button();
            this.dateSearch1 = new System.Windows.Forms.DateTimePicker();
            this.dateSearch2 = new System.Windows.Forms.DateTimePicker();
            this.excelExportBTN = new System.Windows.Forms.Button();
            this.studentView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentView)).BeginInit();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dashboardTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dashboardTable.ColumnHeadersHeight = 55;
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
            this.status_,
            this.account_ID});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dashboardTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.dashboardTable.EnableHeadersVisualStyles = false;
            this.dashboardTable.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dashboardTable.Location = new System.Drawing.Point(250, 69);
            this.dashboardTable.Margin = new System.Windows.Forms.Padding(2);
            this.dashboardTable.Name = "dashboardTable";
            this.dashboardTable.ReadOnly = true;
            this.dashboardTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dashboardTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            this.dashboardTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dashboardTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dashboardTable.Size = new System.Drawing.Size(1034, 501);
            this.dashboardTable.TabIndex = 3;
            this.dashboardTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dashboardTable_CellClick);
            this.dashboardTable.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dashboardTable_CellMouseEnter);
            this.dashboardTable.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dashboardTable_CellMouseLeave);
            this.dashboardTable.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dashboardTable_CellPainting);
            // 
            // transactionID
            // 
            this.transactionID.DataPropertyName = "transactionID";
            this.transactionID.FillWeight = 82.86756F;
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
            this.studentName.Visible = false;
            // 
            // instructorName
            // 
            this.instructorName.DataPropertyName = "instructorName";
            this.instructorName.FillWeight = 125.1172F;
            this.instructorName.HeaderText = "Instructor Name";
            this.instructorName.MinimumWidth = 6;
            this.instructorName.Name = "instructorName";
            this.instructorName.ReadOnly = true;
            // 
            // accountName
            // 
            this.accountName.DataPropertyName = "accountName";
            this.accountName.FillWeight = 129.6134F;
            this.accountName.HeaderText = "Releaser Name";
            this.accountName.MinimumWidth = 6;
            this.accountName.Name = "accountName";
            this.accountName.ReadOnly = true;
            // 
            // partName
            // 
            this.partName.DataPropertyName = "partName";
            this.partName.FillWeight = 129.6134F;
            this.partName.HeaderText = "Equipment Name";
            this.partName.MinimumWidth = 6;
            this.partName.Name = "partName";
            this.partName.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.FillWeight = 77.88644F;
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // orderdate
            // 
            this.orderdate.DataPropertyName = "orderdate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.orderdate.DefaultCellStyle = dataGridViewCellStyle2;
            this.orderdate.FillWeight = 77.77776F;
            this.orderdate.HeaderText = "Order Date";
            this.orderdate.MinimumWidth = 6;
            this.orderdate.Name = "orderdate";
            this.orderdate.ReadOnly = true;
            // 
            // ordertime
            // 
            this.ordertime.DataPropertyName = "ordertime";
            dataGridViewCellStyle3.Format = "T";
            dataGridViewCellStyle3.NullValue = null;
            this.ordertime.DefaultCellStyle = dataGridViewCellStyle3;
            this.ordertime.FillWeight = 77.12418F;
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
            // account_ID
            // 
            this.account_ID.DataPropertyName = "accountID";
            this.account_ID.HeaderText = "Account ID";
            this.account_ID.Name = "account_ID";
            this.account_ID.ReadOnly = true;
            this.account_ID.Visible = false;
            // 
            // searchTxtbx
            // 
            this.searchTxtbx.BackColor = System.Drawing.Color.White;
            this.searchTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxtbx.Location = new System.Drawing.Point(704, 25);
            this.searchTxtbx.Name = "searchTxtbx";
            this.searchTxtbx.Size = new System.Drawing.Size(473, 19);
            this.searchTxtbx.TabIndex = 14;
            this.searchTxtbx.TextChanged += new System.EventHandler(this.searchTxtbx_TextChanged);
            this.searchTxtbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTxtbx_KeyDown);
            // 
            // clearDashBtn
            // 
            this.clearDashBtn.BackColor = System.Drawing.Color.White;
            this.clearDashBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearDashBtn.FlatAppearance.BorderSize = 0;
            this.clearDashBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(179)))), ((int)(((byte)(232)))));
            this.clearDashBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(179)))), ((int)(((byte)(232)))));
            this.clearDashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearDashBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearDashBtn.ForeColor = System.Drawing.Color.Black;
            this.clearDashBtn.Location = new System.Drawing.Point(12, 15);
            this.clearDashBtn.Name = "clearDashBtn";
            this.clearDashBtn.Size = new System.Drawing.Size(223, 40);
            this.clearDashBtn.TabIndex = 38;
            this.clearDashBtn.Text = "Show All Data";
            this.clearDashBtn.UseVisualStyleBackColor = false;
            this.clearDashBtn.Click += new System.EventHandler(this.clearDashBtn_Click);
            // 
            // dateSearch1
            // 
            this.dateSearch1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSearch1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSearch1.Location = new System.Drawing.Point(352, 19);
            this.dateSearch1.Name = "dateSearch1";
            this.dateSearch1.Size = new System.Drawing.Size(101, 27);
            this.dateSearch1.TabIndex = 39;
            this.dateSearch1.ValueChanged += new System.EventHandler(this.dateSearch1_ValueChanged);
            // 
            // dateSearch2
            // 
            this.dateSearch2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSearch2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSearch2.Location = new System.Drawing.Point(570, 19);
            this.dateSearch2.Name = "dateSearch2";
            this.dateSearch2.Size = new System.Drawing.Size(102, 27);
            this.dateSearch2.TabIndex = 42;
            this.dateSearch2.ValueChanged += new System.EventHandler(this.dateSearch2_ValueChanged);
            // 
            // excelExportBTN
            // 
            this.excelExportBTN.BackColor = System.Drawing.Color.White;
            this.excelExportBTN.BackgroundImage = global::Borrowing_System.Properties.Resources.Excel_icon;
            this.excelExportBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.excelExportBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excelExportBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.excelExportBTN.FlatAppearance.BorderSize = 0;
            this.excelExportBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.excelExportBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.excelExportBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excelExportBTN.ForeColor = System.Drawing.Color.White;
            this.excelExportBTN.Location = new System.Drawing.Point(1244, 15);
            this.excelExportBTN.Name = "excelExportBTN";
            this.excelExportBTN.Size = new System.Drawing.Size(40, 40);
            this.excelExportBTN.TabIndex = 43;
            this.excelExportBTN.UseVisualStyleBackColor = false;
            this.excelExportBTN.Click += new System.EventHandler(this.excelExportBTN_Click);
            // 
            // studentView
            // 
            this.studentView.AllowUserToAddRows = false;
            this.studentView.AllowUserToDeleteRows = false;
            this.studentView.AllowUserToOrderColumns = true;
            this.studentView.AllowUserToResizeColumns = false;
            this.studentView.AllowUserToResizeRows = false;
            this.studentView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.studentView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.studentView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.studentView.ColumnHeadersHeight = 55;
            this.studentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.studentView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.student_name,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.studentView.EnableHeadersVisualStyles = false;
            this.studentView.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.studentView.Location = new System.Drawing.Point(12, 69);
            this.studentView.Margin = new System.Windows.Forms.Padding(2);
            this.studentView.Name = "studentView";
            this.studentView.ReadOnly = true;
            this.studentView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.studentView.RowHeadersVisible = false;
            this.studentView.RowHeadersWidth = 50;
            this.studentView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.studentView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(140)))), ((int)(((byte)(217)))));
            this.studentView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.studentView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.studentView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.studentView.RowTemplate.Height = 30;
            this.studentView.RowTemplate.ReadOnly = true;
            this.studentView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.studentView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.studentView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentView.Size = new System.Drawing.Size(223, 501);
            this.studentView.TabIndex = 44;
            this.studentView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "transactionID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Transaction ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // student_name
            // 
            this.student_name.DataPropertyName = "studentName";
            this.student_name.HeaderText = "Student Name";
            this.student_name.MinimumWidth = 6;
            this.student_name.Name = "student_name";
            this.student_name.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "instructorName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Instructor Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "accountName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Releaser Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "partName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Equipment Name";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn6.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "orderdate";
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn7.HeaderText = "Order Date";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ordertime";
            dataGridViewCellStyle8.Format = "T";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn8.HeaderText = "Order Time";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "status_";
            this.dataGridViewTextBoxColumn9.HeaderText = "Status";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 90;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "accountID";
            this.dataGridViewTextBoxColumn10.HeaderText = "Account ID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
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
            this.searchBTN.Location = new System.Drawing.Point(1183, 20);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(31, 29);
            this.searchBTN.TabIndex = 9;
            this.searchBTN.UseVisualStyleBackColor = false;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // DashboardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Borrowing_System.Properties.Resources.Dashboardpage__1296x582_;
            this.ClientSize = new System.Drawing.Size(1296, 582);
            this.Controls.Add(this.studentView);
            this.Controls.Add(this.excelExportBTN);
            this.Controls.Add(this.dateSearch2);
            this.Controls.Add(this.dateSearch1);
            this.Controls.Add(this.clearDashBtn);
            this.Controls.Add(this.searchTxtbx);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.dashboardTable);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardPage";
            this.Text = "DashboardPage";
            this.Load += new System.EventHandler(this.DashboardPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dashboardTable;
        private System.Windows.Forms.TextBox searchTxtbx;
        private System.Windows.Forms.Button clearDashBtn;
        private System.Windows.Forms.DateTimePicker dateSearch1;
        private System.Windows.Forms.DateTimePicker dateSearch2;
        private System.Windows.Forms.Button excelExportBTN;
        private System.Windows.Forms.DataGridView studentView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn partName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordertime;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_;
        private System.Windows.Forms.DataGridViewTextBoxColumn account_ID;
        private System.Windows.Forms.Button searchBTN;
    }
}