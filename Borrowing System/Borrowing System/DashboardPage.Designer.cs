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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dashboardTable = new System.Windows.Forms.DataGridView();
            this.searchBTN = new System.Windows.Forms.Button();
            this.searchTxtbx = new System.Windows.Forms.TextBox();
            this.clearDashBtn = new System.Windows.Forms.Button();
            this.dateSearch1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateSearch2 = new System.Windows.Forms.DateTimePicker();
            this.excelExportBTN = new System.Windows.Forms.Button();
            this.studentView = new System.Windows.Forms.DataGridView();
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dashboardTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dashboardTable.ColumnHeadersHeight = 60;
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
            this.dashboardTable.EnableHeadersVisualStyles = false;
            this.dashboardTable.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dashboardTable.Location = new System.Drawing.Point(423, 154);
            this.dashboardTable.Margin = new System.Windows.Forms.Padding(2);
            this.dashboardTable.Name = "dashboardTable";
            this.dashboardTable.ReadOnly = true;
            this.dashboardTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dashboardTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
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
            this.dashboardTable.Size = new System.Drawing.Size(1052, 436);
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
            // clearDashBtn
            // 
            this.clearDashBtn.BackColor = System.Drawing.Color.White;
            this.clearDashBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearDashBtn.FlatAppearance.BorderSize = 0;
            this.clearDashBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(168)))), ((int)(((byte)(115)))));
            this.clearDashBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(168)))), ((int)(((byte)(115)))));
            this.clearDashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearDashBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearDashBtn.ForeColor = System.Drawing.Color.Black;
            this.clearDashBtn.Location = new System.Drawing.Point(80, 110);
            this.clearDashBtn.Name = "clearDashBtn";
            this.clearDashBtn.Size = new System.Drawing.Size(263, 36);
            this.clearDashBtn.TabIndex = 38;
            this.clearDashBtn.Text = "Show All";
            this.clearDashBtn.UseVisualStyleBackColor = false;
            this.clearDashBtn.Click += new System.EventHandler(this.clearDashBtn_Click);
            // 
            // dateSearch1
            // 
            this.dateSearch1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSearch1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSearch1.Location = new System.Drawing.Point(535, 111);
            this.dateSearch1.Name = "dateSearch1";
            this.dateSearch1.Size = new System.Drawing.Size(116, 29);
            this.dateSearch1.TabIndex = 39;
            this.dateSearch1.ValueChanged += new System.EventHandler(this.dateSearch1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(417, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 30);
            this.label1.TabIndex = 40;
            this.label1.Text = "From date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(657, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 30);
            this.label2.TabIndex = 41;
            this.label2.Text = "To date:";
            // 
            // dateSearch2
            // 
            this.dateSearch2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSearch2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSearch2.Location = new System.Drawing.Point(749, 111);
            this.dateSearch2.Name = "dateSearch2";
            this.dateSearch2.Size = new System.Drawing.Size(110, 29);
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
            this.excelExportBTN.Location = new System.Drawing.Point(1442, 113);
            this.excelExportBTN.Name = "excelExportBTN";
            this.excelExportBTN.Size = new System.Drawing.Size(33, 36);
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.studentView.ColumnHeadersHeight = 50;
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
            this.studentView.Location = new System.Drawing.Point(33, 154);
            this.studentView.Margin = new System.Windows.Forms.Padding(2);
            this.studentView.Name = "studentView";
            this.studentView.ReadOnly = true;
            this.studentView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentView.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
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
            this.studentView.Size = new System.Drawing.Size(372, 436);
            this.studentView.TabIndex = 44;
            this.studentView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentView_CellClick);
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
            this.studentName.Visible = false;
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
            this.accountName.HeaderText = "Releaser Name";
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
            dataGridViewCellStyle10.Format = "d";
            dataGridViewCellStyle10.NullValue = null;
            this.orderdate.DefaultCellStyle = dataGridViewCellStyle10;
            this.orderdate.HeaderText = "Order Date";
            this.orderdate.MinimumWidth = 6;
            this.orderdate.Name = "orderdate";
            this.orderdate.ReadOnly = true;
            // 
            // ordertime
            // 
            this.ordertime.DataPropertyName = "ordertime";
            dataGridViewCellStyle11.Format = "T";
            dataGridViewCellStyle11.NullValue = null;
            this.ordertime.DefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle14.Format = "d";
            dataGridViewCellStyle14.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn7.HeaderText = "Order Date";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ordertime";
            dataGridViewCellStyle15.Format = "T";
            dataGridViewCellStyle15.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle15;
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
            this.dataGridViewTextBoxColumn9.Width = 89;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "accountID";
            this.dataGridViewTextBoxColumn10.HeaderText = "Account ID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // DashboardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Borrowing_System.Properties.Resources.Dashboard_Page;
            this.ClientSize = new System.Drawing.Size(1532, 650);
            this.Controls.Add(this.studentView);
            this.Controls.Add(this.excelExportBTN);
            this.Controls.Add(this.dateSearch2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.TextBox searchTxtbx;
        private System.Windows.Forms.Button clearDashBtn;
        private System.Windows.Forms.DateTimePicker dateSearch1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateSearch2;
        private System.Windows.Forms.Button excelExportBTN;
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
    }
}