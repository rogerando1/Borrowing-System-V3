namespace Borrowing_System
{
    partial class AccountManagementPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountManagementPage));
            this.searchData = new System.Windows.Forms.TextBox();
            this.employeeData = new System.Windows.Forms.DataGridView();
            this.personID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleinitial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBTN = new System.Windows.Forms.Button();
            this.accountmanagementPanel = new System.Windows.Forms.Panel();
            this.studentData = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorData = new System.Windows.Forms.DataGridView();
            this.courseData = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBTN = new System.Windows.Forms.Button();
            this.studentBTN = new System.Windows.Forms.Button();
            this.instructorBTN = new System.Windows.Forms.Button();
            this.courseBTN = new System.Windows.Forms.Button();
            this.instructorlistTxtbx = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeList1 = new Borrowing_System.Account_Management.EmployeeList();
            this.studentList1 = new Borrowing_System.Account_Management.StudentList();
            this.instructorList1 = new Borrowing_System.Account_Management.InstructorList();
            this.courseList1 = new Borrowing_System.Account_Management.CourseList();
            ((System.ComponentModel.ISupportInitialize)(this.employeeData)).BeginInit();
            this.accountmanagementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseData)).BeginInit();
            this.SuspendLayout();
            // 
            // searchData
            // 
            this.searchData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.searchData.Location = new System.Drawing.Point(44, 102);
            this.searchData.Name = "searchData";
            this.searchData.Size = new System.Drawing.Size(860, 23);
            this.searchData.TabIndex = 0;
            this.searchData.TextChanged += new System.EventHandler(this.searchData_TextChanged);
            // 
            // employeeData
            // 
            this.employeeData.AllowUserToAddRows = false;
            this.employeeData.AllowUserToDeleteRows = false;
            this.employeeData.AllowUserToOrderColumns = true;
            this.employeeData.AllowUserToResizeColumns = false;
            this.employeeData.AllowUserToResizeRows = false;
            this.employeeData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeeData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.employeeData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeeData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.employeeData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.employeeData.ColumnHeadersHeight = 45;
            this.employeeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.employeeData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personID,
            this.firstname,
            this.middleinitial,
            this.lastname,
            this.username,
            this.password_,
            this.position});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeData.DefaultCellStyle = dataGridViewCellStyle2;
            this.employeeData.EnableHeadersVisualStyles = false;
            this.employeeData.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.employeeData.Location = new System.Drawing.Point(24, 361);
            this.employeeData.Name = "employeeData";
            this.employeeData.ReadOnly = true;
            this.employeeData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.employeeData.RowHeadersVisible = false;
            this.employeeData.RowHeadersWidth = 51;
            this.employeeData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeData.Size = new System.Drawing.Size(957, 179);
            this.employeeData.TabIndex = 15;
            this.employeeData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeData_CellClick);
            // 
            // personID
            // 
            this.personID.DataPropertyName = "personID";
            this.personID.FillWeight = 75.63123F;
            this.personID.HeaderText = "Person ID";
            this.personID.Name = "personID";
            this.personID.ReadOnly = true;
            // 
            // firstname
            // 
            this.firstname.DataPropertyName = "firstname";
            this.firstname.FillWeight = 118.0909F;
            this.firstname.HeaderText = "First Name";
            this.firstname.Name = "firstname";
            this.firstname.ReadOnly = true;
            // 
            // middleinitial
            // 
            this.middleinitial.DataPropertyName = "middleinitial";
            this.middleinitial.FillWeight = 88.04581F;
            this.middleinitial.HeaderText = "Middle Initial";
            this.middleinitial.Name = "middleinitial";
            this.middleinitial.ReadOnly = true;
            // 
            // lastname
            // 
            this.lastname.DataPropertyName = "lastname";
            this.lastname.FillWeight = 118.0909F;
            this.lastname.HeaderText = "Last Name";
            this.lastname.Name = "lastname";
            this.lastname.ReadOnly = true;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.FillWeight = 118.0909F;
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // password_
            // 
            this.password_.DataPropertyName = "password_";
            this.password_.FillWeight = 118.0909F;
            this.password_.HeaderText = "Password";
            this.password_.Name = "password_";
            this.password_.ReadOnly = true;
            // 
            // position
            // 
            this.position.DataPropertyName = "position";
            this.position.FillWeight = 63.95938F;
            this.position.HeaderText = "Position";
            this.position.Name = "position";
            this.position.ReadOnly = true;
            // 
            // searchBTN
            // 
            this.searchBTN.BackColor = System.Drawing.Color.Transparent;
            this.searchBTN.BackgroundImage = global::Borrowing_System.Properties.Resources.search_icon;
            this.searchBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.searchBTN.FlatAppearance.BorderSize = 0;
            this.searchBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.searchBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.searchBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBTN.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold);
            this.searchBTN.ForeColor = System.Drawing.Color.Transparent;
            this.searchBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBTN.Location = new System.Drawing.Point(911, 92);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(46, 42);
            this.searchBTN.TabIndex = 22;
            this.searchBTN.UseVisualStyleBackColor = false;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // accountmanagementPanel
            // 
            this.accountmanagementPanel.BackColor = System.Drawing.Color.Transparent;
            this.accountmanagementPanel.Controls.Add(this.instructorlistTxtbx);
            this.accountmanagementPanel.Controls.Add(this.employeeList1);
            this.accountmanagementPanel.Controls.Add(this.studentList1);
            this.accountmanagementPanel.Controls.Add(this.instructorList1);
            this.accountmanagementPanel.Controls.Add(this.courseList1);
            this.accountmanagementPanel.Controls.Add(this.employeeData);
            this.accountmanagementPanel.Controls.Add(this.studentData);
            this.accountmanagementPanel.Controls.Add(this.instructorData);
            this.accountmanagementPanel.Controls.Add(this.courseData);
            this.accountmanagementPanel.Location = new System.Drawing.Point(0, 70);
            this.accountmanagementPanel.Name = "accountmanagementPanel";
            this.accountmanagementPanel.Size = new System.Drawing.Size(1532, 580);
            this.accountmanagementPanel.TabIndex = 42;
            // 
            // studentData
            // 
            this.studentData.AllowUserToAddRows = false;
            this.studentData.AllowUserToDeleteRows = false;
            this.studentData.AllowUserToOrderColumns = true;
            this.studentData.AllowUserToResizeColumns = false;
            this.studentData.AllowUserToResizeRows = false;
            this.studentData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.studentData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.studentData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.studentData.ColumnHeadersHeight = 45;
            this.studentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.studentData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentData.DefaultCellStyle = dataGridViewCellStyle5;
            this.studentData.EnableHeadersVisualStyles = false;
            this.studentData.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.studentData.Location = new System.Drawing.Point(24, 302);
            this.studentData.Name = "studentData";
            this.studentData.ReadOnly = true;
            this.studentData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentData.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.studentData.RowHeadersVisible = false;
            this.studentData.RowHeadersWidth = 51;
            this.studentData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentData.Size = new System.Drawing.Size(957, 251);
            this.studentData.TabIndex = 16;
            this.studentData.Visible = false;
            this.studentData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentData_CellContentClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "studentID";
            this.dataGridViewTextBoxColumn5.FillWeight = 119.3331F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Student ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "firstname";
            this.dataGridViewTextBoxColumn2.FillWeight = 119.3331F;
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "middleinitial";
            this.dataGridViewTextBoxColumn3.FillWeight = 82.404F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Middle Initial";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "lastname";
            this.dataGridViewTextBoxColumn4.FillWeight = 119.3331F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "program";
            this.dataGridViewTextBoxColumn6.FillWeight = 119.3331F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Program";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "yearlevel";
            this.dataGridViewTextBoxColumn7.FillWeight = 64.63219F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Year Level";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // instructorData
            // 
            this.instructorData.AllowUserToAddRows = false;
            this.instructorData.AllowUserToDeleteRows = false;
            this.instructorData.AllowUserToOrderColumns = true;
            this.instructorData.AllowUserToResizeColumns = false;
            this.instructorData.AllowUserToResizeRows = false;
            this.instructorData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.instructorData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.instructorData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instructorData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.instructorData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.instructorData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.instructorData.ColumnHeadersHeight = 45;
            this.instructorData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.instructorData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.instructorData.DefaultCellStyle = dataGridViewCellStyle8;
            this.instructorData.EnableHeadersVisualStyles = false;
            this.instructorData.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.instructorData.Location = new System.Drawing.Point(24, 126);
            this.instructorData.Name = "instructorData";
            this.instructorData.ReadOnly = true;
            this.instructorData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.instructorData.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.instructorData.RowHeadersVisible = false;
            this.instructorData.RowHeadersWidth = 51;
            this.instructorData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.instructorData.Size = new System.Drawing.Size(1505, 427);
            this.instructorData.TabIndex = 17;
            this.instructorData.Visible = false;
            // 
            // courseData
            // 
            this.courseData.AllowUserToAddRows = false;
            this.courseData.AllowUserToDeleteRows = false;
            this.courseData.AllowUserToOrderColumns = true;
            this.courseData.AllowUserToResizeColumns = false;
            this.courseData.AllowUserToResizeRows = false;
            this.courseData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.courseData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.courseData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.courseData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.courseData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.courseData.ColumnHeadersHeight = 45;
            this.courseData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.courseData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.courseData.DefaultCellStyle = dataGridViewCellStyle11;
            this.courseData.EnableHeadersVisualStyles = false;
            this.courseData.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.courseData.Location = new System.Drawing.Point(24, 88);
            this.courseData.Name = "courseData";
            this.courseData.ReadOnly = true;
            this.courseData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.courseData.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.courseData.RowHeadersVisible = false;
            this.courseData.RowHeadersWidth = 51;
            this.courseData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.courseData.Size = new System.Drawing.Size(957, 465);
            this.courseData.TabIndex = 18;
            this.courseData.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "courseID";
            this.dataGridViewTextBoxColumn15.FillWeight = 69.45326F;
            this.dataGridViewTextBoxColumn15.HeaderText = "Course ID";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "coursename";
            this.dataGridViewTextBoxColumn16.FillWeight = 244.5144F;
            this.dataGridViewTextBoxColumn16.HeaderText = "Course Name";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "startTime";
            this.dataGridViewTextBoxColumn17.FillWeight = 67.18204F;
            this.dataGridViewTextBoxColumn17.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "endTime";
            this.dataGridViewTextBoxColumn18.FillWeight = 77.42522F;
            this.dataGridViewTextBoxColumn18.HeaderText = "End Time";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "section";
            this.dataGridViewTextBoxColumn19.FillWeight = 59.37489F;
            this.dataGridViewTextBoxColumn19.HeaderText = "Section";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // employeeBTN
            // 
            this.employeeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(168)))), ((int)(((byte)(115)))));
            this.employeeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeeBTN.FlatAppearance.BorderSize = 0;
            this.employeeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.employeeBTN.Location = new System.Drawing.Point(90, 12);
            this.employeeBTN.Name = "employeeBTN";
            this.employeeBTN.Size = new System.Drawing.Size(174, 44);
            this.employeeBTN.TabIndex = 43;
            this.employeeBTN.Text = "Employee List";
            this.employeeBTN.UseVisualStyleBackColor = false;
            this.employeeBTN.Click += new System.EventHandler(this.employeeBTN_Click);
            // 
            // studentBTN
            // 
            this.studentBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.studentBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentBTN.FlatAppearance.BorderSize = 0;
            this.studentBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.studentBTN.Location = new System.Drawing.Point(298, 12);
            this.studentBTN.Name = "studentBTN";
            this.studentBTN.Size = new System.Drawing.Size(174, 44);
            this.studentBTN.TabIndex = 44;
            this.studentBTN.Text = "Student List";
            this.studentBTN.UseVisualStyleBackColor = false;
            this.studentBTN.Click += new System.EventHandler(this.studentBTN_Click);
            // 
            // instructorBTN
            // 
            this.instructorBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.instructorBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.instructorBTN.FlatAppearance.BorderSize = 0;
            this.instructorBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructorBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.instructorBTN.Location = new System.Drawing.Point(513, 12);
            this.instructorBTN.Name = "instructorBTN";
            this.instructorBTN.Size = new System.Drawing.Size(174, 44);
            this.instructorBTN.TabIndex = 45;
            this.instructorBTN.Text = "Instructor List";
            this.instructorBTN.UseVisualStyleBackColor = false;
            this.instructorBTN.Click += new System.EventHandler(this.instructorBTN_Click);
            // 
            // courseBTN
            // 
            this.courseBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.courseBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.courseBTN.FlatAppearance.BorderSize = 0;
            this.courseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.courseBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.courseBTN.Location = new System.Drawing.Point(717, 12);
            this.courseBTN.Name = "courseBTN";
            this.courseBTN.Size = new System.Drawing.Size(174, 44);
            this.courseBTN.TabIndex = 46;
            this.courseBTN.Text = "Course List";
            this.courseBTN.UseVisualStyleBackColor = false;
            this.courseBTN.Click += new System.EventHandler(this.courseBTN_Click);
            // 
            // instructorlistTxtbx
            // 
            this.instructorlistTxtbx.BackColor = System.Drawing.SystemColors.Window;
            this.instructorlistTxtbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instructorlistTxtbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructorlistTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorlistTxtbx.FormattingEnabled = true;
            this.instructorlistTxtbx.Location = new System.Drawing.Point(24, 88);
            this.instructorlistTxtbx.Name = "instructorlistTxtbx";
            this.instructorlistTxtbx.Size = new System.Drawing.Size(334, 32);
            this.instructorlistTxtbx.TabIndex = 23;
            this.instructorlistTxtbx.Visible = false;
            this.instructorlistTxtbx.SelectedIndexChanged += new System.EventHandler(this.instructorlistTxtbx_SelectedIndexChanged);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "instructorname";
            this.dataGridViewTextBoxColumn8.FillWeight = 75.63123F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Instructor Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "courseID";
            this.dataGridViewTextBoxColumn9.FillWeight = 118.0909F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Course ID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "coursename";
            this.dataGridViewTextBoxColumn10.FillWeight = 88.04581F;
            this.dataGridViewTextBoxColumn10.HeaderText = "Course Name";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "section";
            this.dataGridViewTextBoxColumn11.FillWeight = 118.0909F;
            this.dataGridViewTextBoxColumn11.HeaderText = "Section";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "startTime";
            this.Column1.HeaderText = "Start Time";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "endTime";
            this.Column2.HeaderText = "End Time";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // employeeList1
            // 
            this.employeeList1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("employeeList1.BackgroundImage")));
            this.employeeList1.Location = new System.Drawing.Point(1004, 0);
            this.employeeList1.Name = "employeeList1";
            this.employeeList1.Size = new System.Drawing.Size(528, 580);
            this.employeeList1.TabIndex = 0;
            // 
            // studentList1
            // 
            this.studentList1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("studentList1.BackgroundImage")));
            this.studentList1.Location = new System.Drawing.Point(1004, 0);
            this.studentList1.Name = "studentList1";
            this.studentList1.Size = new System.Drawing.Size(528, 580);
            this.studentList1.TabIndex = 19;
            // 
            // instructorList1
            // 
            this.instructorList1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("instructorList1.BackgroundImage")));
            this.instructorList1.Location = new System.Drawing.Point(1004, 0);
            this.instructorList1.Name = "instructorList1";
            this.instructorList1.Size = new System.Drawing.Size(528, 580);
            this.instructorList1.TabIndex = 20;
            // 
            // courseList1
            // 
            this.courseList1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("courseList1.BackgroundImage")));
            this.courseList1.Location = new System.Drawing.Point(1004, 0);
            this.courseList1.Name = "courseList1";
            this.courseList1.Size = new System.Drawing.Size(528, 580);
            this.courseList1.TabIndex = 21;
            // 
            // AccountManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::Borrowing_System.Properties.Resources.acc_management_background1;
            this.ClientSize = new System.Drawing.Size(1532, 650);
            this.Controls.Add(this.courseBTN);
            this.Controls.Add(this.instructorBTN);
            this.Controls.Add(this.studentBTN);
            this.Controls.Add(this.employeeBTN);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.searchData);
            this.Controls.Add(this.accountmanagementPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountManagementPage";
            this.Text = "AccountManagementPage";
            this.Load += new System.EventHandler(this.AccountManagementPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeData)).EndInit();
            this.accountmanagementPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchData;
        private System.Windows.Forms.DataGridView employeeData;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.Panel accountmanagementPanel;
        private System.Windows.Forms.Button employeeBTN;
        private System.Windows.Forms.Button studentBTN;
        private System.Windows.Forms.Button instructorBTN;
        private System.Windows.Forms.Button courseBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn personID;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleinitial;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password_;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private Account_Management.EmployeeList employeeList1;
        private System.Windows.Forms.DataGridView instructorData;
        private System.Windows.Forms.DataGridView studentData;
        private System.Windows.Forms.DataGridView courseData;
        private Account_Management.StudentList studentList1;
        private Account_Management.InstructorList instructorList1;
        private Account_Management.CourseList courseList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.ComboBox instructorlistTxtbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}