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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.instructorlistTxtbx = new System.Windows.Forms.ComboBox();
            this.studentData = new System.Windows.Forms.DataGridView();
            this.studentFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentMiddleinitial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearlevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorData = new System.Windows.Forms.DataGridView();
            this.courseData = new System.Windows.Forms.DataGridView();
            this.employeeBTN = new System.Windows.Forms.Button();
            this.studentBTN = new System.Windows.Forms.Button();
            this.instructorBTN = new System.Windows.Forms.Button();
            this.courseBTN = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorMiddleinitial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeList1 = new Borrowing_System.Account_Management.EmployeeList();
            this.studentList1 = new Borrowing_System.Account_Management.StudentList();
            this.instructorList1 = new Borrowing_System.Account_Management.InstructorList();
            this.courseList1 = new Borrowing_System.Account_Management.CourseList();
            this.coursename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.searchData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchData_KeyDown);
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
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
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeData.DefaultCellStyle = dataGridViewCellStyle14;
            this.employeeData.EnableHeadersVisualStyles = false;
            this.employeeData.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.employeeData.Location = new System.Drawing.Point(24, 88);
            this.employeeData.Name = "employeeData";
            this.employeeData.ReadOnly = true;
            this.employeeData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeData.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.employeeData.RowHeadersVisible = false;
            this.employeeData.RowHeadersWidth = 51;
            this.employeeData.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.employeeData.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(140)))), ((int)(((byte)(217)))));
            this.employeeData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeData.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.employeeData.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.employeeData.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.employeeData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeData.Size = new System.Drawing.Size(957, 452);
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
            this.accountmanagementPanel.Controls.Add(this.employeeData);
            this.accountmanagementPanel.Controls.Add(this.studentData);
            this.accountmanagementPanel.Controls.Add(this.instructorData);
            this.accountmanagementPanel.Controls.Add(this.courseData);
            this.accountmanagementPanel.Controls.Add(this.employeeList1);
            this.accountmanagementPanel.Controls.Add(this.studentList1);
            this.accountmanagementPanel.Controls.Add(this.instructorList1);
            this.accountmanagementPanel.Controls.Add(this.courseList1);
            this.accountmanagementPanel.Location = new System.Drawing.Point(0, 70);
            this.accountmanagementPanel.Name = "accountmanagementPanel";
            this.accountmanagementPanel.Size = new System.Drawing.Size(1532, 580);
            this.accountmanagementPanel.TabIndex = 42;
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.studentData.ColumnHeadersHeight = 45;
            this.studentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.studentData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentFirstname,
            this.studentMiddleinitial,
            this.studentLastname,
            this.program,
            this.yearlevel});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentData.DefaultCellStyle = dataGridViewCellStyle17;
            this.studentData.EnableHeadersVisualStyles = false;
            this.studentData.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.studentData.Location = new System.Drawing.Point(24, 88);
            this.studentData.Name = "studentData";
            this.studentData.ReadOnly = true;
            this.studentData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentData.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.studentData.RowHeadersVisible = false;
            this.studentData.RowHeadersWidth = 51;
            this.studentData.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.studentData.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(140)))), ((int)(((byte)(217)))));
            this.studentData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentData.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.studentData.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.studentData.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.studentData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentData.Size = new System.Drawing.Size(981, 465);
            this.studentData.TabIndex = 16;
            this.studentData.Visible = false;
            this.studentData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentData_CellClick);
            this.studentData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentData_CellContentClick);
            // 
            // studentFirstname
            // 
            this.studentFirstname.DataPropertyName = "studentFirstname";
            this.studentFirstname.FillWeight = 119.3331F;
            this.studentFirstname.HeaderText = "First Name";
            this.studentFirstname.Name = "studentFirstname";
            this.studentFirstname.ReadOnly = true;
            // 
            // studentMiddleinitial
            // 
            this.studentMiddleinitial.DataPropertyName = "studentMiddleinitial";
            this.studentMiddleinitial.FillWeight = 82.404F;
            this.studentMiddleinitial.HeaderText = "Middle Initial";
            this.studentMiddleinitial.Name = "studentMiddleinitial";
            this.studentMiddleinitial.ReadOnly = true;
            // 
            // studentLastname
            // 
            this.studentLastname.DataPropertyName = "studentLastname";
            this.studentLastname.FillWeight = 119.3331F;
            this.studentLastname.HeaderText = "Last Name";
            this.studentLastname.Name = "studentLastname";
            this.studentLastname.ReadOnly = true;
            // 
            // program
            // 
            this.program.DataPropertyName = "program";
            this.program.FillWeight = 119.3331F;
            this.program.HeaderText = "Program";
            this.program.Name = "program";
            this.program.ReadOnly = true;
            // 
            // yearlevel
            // 
            this.yearlevel.DataPropertyName = "yearlevel";
            this.yearlevel.FillWeight = 64.63219F;
            this.yearlevel.HeaderText = "Year Level";
            this.yearlevel.Name = "yearlevel";
            this.yearlevel.ReadOnly = true;
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
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.instructorData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.instructorData.ColumnHeadersHeight = 45;
            this.instructorData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.instructorData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.instructorID,
            this.instructorFirstname,
            this.instructorLastname,
            this.instructorMiddleinitial,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.instructorData.DefaultCellStyle = dataGridViewCellStyle20;
            this.instructorData.EnableHeadersVisualStyles = false;
            this.instructorData.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.instructorData.Location = new System.Drawing.Point(24, 126);
            this.instructorData.Name = "instructorData";
            this.instructorData.ReadOnly = true;
            this.instructorData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.instructorData.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.instructorData.RowHeadersVisible = false;
            this.instructorData.RowHeadersWidth = 51;
            this.instructorData.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.instructorData.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(140)))), ((int)(((byte)(217)))));
            this.instructorData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorData.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.instructorData.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.instructorData.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.instructorData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.instructorData.Size = new System.Drawing.Size(981, 427);
            this.instructorData.TabIndex = 17;
            this.instructorData.Visible = false;
            this.instructorData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.instructorData_CellClick);
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
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.courseData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.courseData.ColumnHeadersHeight = 45;
            this.courseData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.courseData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coursename,
            this.fullTime,
            this.startTime,
            this.endTime,
            this.section});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.courseData.DefaultCellStyle = dataGridViewCellStyle23;
            this.courseData.EnableHeadersVisualStyles = false;
            this.courseData.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.courseData.Location = new System.Drawing.Point(24, 88);
            this.courseData.Name = "courseData";
            this.courseData.ReadOnly = true;
            this.courseData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.courseData.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.courseData.RowHeadersVisible = false;
            this.courseData.RowHeadersWidth = 51;
            this.courseData.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.courseData.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(140)))), ((int)(((byte)(217)))));
            this.courseData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseData.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.courseData.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.courseData.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.courseData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.courseData.Size = new System.Drawing.Size(981, 465);
            this.courseData.TabIndex = 18;
            this.courseData.Visible = false;
            this.courseData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseData_CellClick);
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
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "instructorname";
            this.dataGridViewTextBoxColumn8.FillWeight = 109.7531F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Instructor Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // instructorID
            // 
            this.instructorID.DataPropertyName = "instructorID";
            this.instructorID.HeaderText = "Instructor ID";
            this.instructorID.Name = "instructorID";
            this.instructorID.ReadOnly = true;
            // 
            // instructorFirstname
            // 
            this.instructorFirstname.DataPropertyName = "instructorFirstname";
            this.instructorFirstname.HeaderText = "Instructor First Name";
            this.instructorFirstname.Name = "instructorFirstname";
            this.instructorFirstname.ReadOnly = true;
            this.instructorFirstname.Visible = false;
            // 
            // instructorLastname
            // 
            this.instructorLastname.DataPropertyName = "instructorLastname";
            this.instructorLastname.HeaderText = "Instructor Last Name";
            this.instructorLastname.Name = "instructorLastname";
            this.instructorLastname.ReadOnly = true;
            this.instructorLastname.Visible = false;
            // 
            // instructorMiddleinitial
            // 
            this.instructorMiddleinitial.DataPropertyName = "instructorMiddleinitial";
            this.instructorMiddleinitial.HeaderText = "Instructor Middle Initial";
            this.instructorMiddleinitial.Name = "instructorMiddleinitial";
            this.instructorMiddleinitial.ReadOnly = true;
            this.instructorMiddleinitial.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "courseID";
            this.dataGridViewTextBoxColumn9.FillWeight = 73.07925F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Course ID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "coursename";
            this.dataGridViewTextBoxColumn10.FillWeight = 271.7144F;
            this.dataGridViewTextBoxColumn10.HeaderText = "Course Name";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "section";
            this.dataGridViewTextBoxColumn11.FillWeight = 52.33739F;
            this.dataGridViewTextBoxColumn11.HeaderText = "Section";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "startTime";
            this.Column1.FillWeight = 50.65809F;
            this.Column1.HeaderText = "Start Time";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "endTime";
            this.Column2.FillWeight = 42.31669F;
            this.Column2.HeaderText = "End Time";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // employeeList1
            // 
            this.employeeList1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("employeeList1.BackgroundImage")));
            this.employeeList1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.employeeList1.Location = new System.Drawing.Point(1011, 0);
            this.employeeList1.Name = "employeeList1";
            this.employeeList1.Size = new System.Drawing.Size(521, 580);
            this.employeeList1.TabIndex = 0;
            this.employeeList1.Load += new System.EventHandler(this.employeeList1_Load);
            // 
            // studentList1
            // 
            this.studentList1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("studentList1.BackgroundImage")));
            this.studentList1.Location = new System.Drawing.Point(1011, 0);
            this.studentList1.Name = "studentList1";
            this.studentList1.Size = new System.Drawing.Size(521, 580);
            this.studentList1.TabIndex = 19;
            // 
            // instructorList1
            // 
            this.instructorList1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("instructorList1.BackgroundImage")));
            this.instructorList1.Location = new System.Drawing.Point(1011, 0);
            this.instructorList1.Name = "instructorList1";
            this.instructorList1.Size = new System.Drawing.Size(521, 580);
            this.instructorList1.TabIndex = 20;
            // 
            // courseList1
            // 
            this.courseList1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("courseList1.BackgroundImage")));
            this.courseList1.Location = new System.Drawing.Point(1011, 0);
            this.courseList1.Name = "courseList1";
            this.courseList1.Size = new System.Drawing.Size(521, 580);
            this.courseList1.TabIndex = 21;
            // 
            // coursename
            // 
            this.coursename.DataPropertyName = "coursename";
            this.coursename.FillWeight = 244.5144F;
            this.coursename.HeaderText = "Course Name";
            this.coursename.Name = "coursename";
            this.coursename.ReadOnly = true;
            // 
            // fullTime
            // 
            this.fullTime.DataPropertyName = "fullTime";
            this.fullTime.HeaderText = "Full Time";
            this.fullTime.Name = "fullTime";
            this.fullTime.ReadOnly = true;
            this.fullTime.Visible = false;
            // 
            // startTime
            // 
            this.startTime.DataPropertyName = "startTime";
            this.startTime.FillWeight = 67.18204F;
            this.startTime.HeaderText = "Start Time";
            this.startTime.Name = "startTime";
            this.startTime.ReadOnly = true;
            // 
            // endTime
            // 
            this.endTime.DataPropertyName = "endTime";
            this.endTime.FillWeight = 77.42522F;
            this.endTime.HeaderText = "End Time";
            this.endTime.Name = "endTime";
            this.endTime.ReadOnly = true;
            // 
            // section
            // 
            this.section.DataPropertyName = "section";
            this.section.FillWeight = 59.37489F;
            this.section.HeaderText = "Section";
            this.section.Name = "section";
            this.section.ReadOnly = true;
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
        private System.Windows.Forms.ComboBox instructorlistTxtbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentMiddleinitial;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn program;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearlevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorMiddleinitial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursename;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn section;
    }
}