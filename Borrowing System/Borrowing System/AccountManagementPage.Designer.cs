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
            this.studentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentMiddleinitial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearlevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeList1 = new Borrowing_System.Account_Management.EmployeeList();
            this.studentList1 = new Borrowing_System.Account_Management.StudentList();
            this.instructorData = new System.Windows.Forms.DataGridView();
            this.courseData = new System.Windows.Forms.DataGridView();
            this.instructorList1 = new Borrowing_System.Account_Management.InstructorList();
            this.courseList1 = new Borrowing_System.Account_Management.CourseList();
            this.employeeBTN = new System.Windows.Forms.Button();
            this.studentBTN = new System.Windows.Forms.Button();
            this.instructorBTN = new System.Windows.Forms.Button();
            this.courseBTN = new System.Windows.Forms.Button();
            this.instructorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorMiddleinitial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorcourseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursename = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.searchData.Location = new System.Drawing.Point(349, 22);
            this.searchData.Name = "searchData";
            this.searchData.Size = new System.Drawing.Size(620, 23);
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
            this.employeeData.Location = new System.Drawing.Point(8, 66);
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
            this.employeeData.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.employeeData.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(140)))), ((int)(((byte)(217)))));
            this.employeeData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeData.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.employeeData.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.employeeData.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.employeeData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeData.Size = new System.Drawing.Size(1034, 503);
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
            this.searchBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.searchBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.searchBTN.FlatAppearance.BorderSize = 0;
            this.searchBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.searchBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.searchBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBTN.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold);
            this.searchBTN.ForeColor = System.Drawing.Color.Transparent;
            this.searchBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBTN.Location = new System.Drawing.Point(975, 16);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(35, 35);
            this.searchBTN.TabIndex = 22;
            this.searchBTN.UseVisualStyleBackColor = false;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // accountmanagementPanel
            // 
            this.accountmanagementPanel.BackColor = System.Drawing.Color.Transparent;
            this.accountmanagementPanel.Controls.Add(this.instructorlistTxtbx);
            this.accountmanagementPanel.Controls.Add(this.searchData);
            this.accountmanagementPanel.Controls.Add(this.searchBTN);
            this.accountmanagementPanel.Controls.Add(this.employeeData);
            this.accountmanagementPanel.Controls.Add(this.studentData);
            this.accountmanagementPanel.Controls.Add(this.employeeList1);
            this.accountmanagementPanel.Controls.Add(this.studentList1);
            this.accountmanagementPanel.Controls.Add(this.instructorData);
            this.accountmanagementPanel.Controls.Add(this.courseData);
            this.accountmanagementPanel.Controls.Add(this.instructorList1);
            this.accountmanagementPanel.Controls.Add(this.courseList1);
            this.accountmanagementPanel.Location = new System.Drawing.Point(0, 70);
            this.accountmanagementPanel.Name = "accountmanagementPanel";
            this.accountmanagementPanel.Size = new System.Drawing.Size(1533, 580);
            this.accountmanagementPanel.TabIndex = 42;
            // 
            // instructorlistTxtbx
            // 
            this.instructorlistTxtbx.BackColor = System.Drawing.SystemColors.Window;
            this.instructorlistTxtbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instructorlistTxtbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructorlistTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorlistTxtbx.FormattingEnabled = true;
            this.instructorlistTxtbx.Location = new System.Drawing.Point(22, 19);
            this.instructorlistTxtbx.Name = "instructorlistTxtbx";
            this.instructorlistTxtbx.Size = new System.Drawing.Size(298, 32);
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
            this.studentFirstname,
            this.studentID,
            this.studentMiddleinitial,
            this.studentLastname,
            this.program,
            this.yearlevel});
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
            this.studentData.Location = new System.Drawing.Point(8, 66);
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
            this.studentData.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.studentData.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(140)))), ((int)(((byte)(217)))));
            this.studentData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentData.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.studentData.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.studentData.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.studentData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentData.Size = new System.Drawing.Size(1034, 502);
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
            // studentID
            // 
            this.studentID.DataPropertyName = "studentID";
            this.studentID.HeaderText = "Student ID";
            this.studentID.Name = "studentID";
            this.studentID.ReadOnly = true;
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
            // employeeList1
            // 
            this.employeeList1.BackgroundImage = global::Borrowing_System.Properties.Resources._1_3_;
            this.employeeList1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.employeeList1.Location = new System.Drawing.Point(1053, -8);
            this.employeeList1.Name = "employeeList1";
            this.employeeList1.Size = new System.Drawing.Size(484, 588);
            this.employeeList1.TabIndex = 0;
            this.employeeList1.Load += new System.EventHandler(this.employeeList1_Load);
            // 
            // studentList1
            // 
            this.studentList1.BackgroundImage = global::Borrowing_System.Properties.Resources._2_4_;
            this.studentList1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.studentList1.Location = new System.Drawing.Point(1054, -8);
            this.studentList1.Name = "studentList1";
            this.studentList1.Size = new System.Drawing.Size(484, 588);
            this.studentList1.TabIndex = 19;
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
            this.instructorID,
            this.instructorname,
            this.instructorFirstname,
            this.instructorLastname,
            this.instructorMiddleinitial,
            this.instructorcourseId,
            this.instructorcName,
            this.instructorSection,
            this.instructorStartTime,
            this.instructorEndTime});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.instructorData.DefaultCellStyle = dataGridViewCellStyle8;
            this.instructorData.EnableHeadersVisualStyles = false;
            this.instructorData.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.instructorData.Location = new System.Drawing.Point(8, 66);
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
            this.instructorData.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.instructorData.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(140)))), ((int)(((byte)(217)))));
            this.instructorData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorData.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.instructorData.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.instructorData.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.instructorData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.instructorData.Size = new System.Drawing.Size(1034, 411);
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
            this.courseID,
            this.coursename});
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
            this.courseData.Location = new System.Drawing.Point(8, 66);
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
            this.courseData.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.courseData.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(140)))), ((int)(((byte)(217)))));
            this.courseData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseData.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.courseData.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.courseData.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.courseData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.courseData.Size = new System.Drawing.Size(1034, 502);
            this.courseData.TabIndex = 18;
            this.courseData.Visible = false;
            this.courseData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseData_CellClick);
            // 
            // instructorList1
            // 
            this.instructorList1.BackgroundImage = global::Borrowing_System.Properties.Resources.instructorsUI;
            this.instructorList1.Location = new System.Drawing.Point(1053, -8);
            this.instructorList1.Name = "instructorList1";
            this.instructorList1.Size = new System.Drawing.Size(484, 588);
            this.instructorList1.TabIndex = 20;
            // 
            // courseList1
            // 
            this.courseList1.BackgroundImage = global::Borrowing_System.Properties.Resources.courselistUI1;
            this.courseList1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.courseList1.Location = new System.Drawing.Point(1054, -11);
            this.courseList1.Name = "courseList1";
            this.courseList1.Size = new System.Drawing.Size(484, 591);
            this.courseList1.TabIndex = 21;
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
            this.instructorBTN.Location = new System.Drawing.Point(505, 12);
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
            this.courseBTN.Location = new System.Drawing.Point(713, 12);
            this.courseBTN.Name = "courseBTN";
            this.courseBTN.Size = new System.Drawing.Size(174, 44);
            this.courseBTN.TabIndex = 46;
            this.courseBTN.Text = "Course List";
            this.courseBTN.UseVisualStyleBackColor = false;
            this.courseBTN.Click += new System.EventHandler(this.courseBTN_Click);
            // 
            // instructorID
            // 
            this.instructorID.DataPropertyName = "instructorID";
            this.instructorID.HeaderText = "Instructor ID";
            this.instructorID.Name = "instructorID";
            this.instructorID.ReadOnly = true;
            // 
            // instructorname
            // 
            this.instructorname.DataPropertyName = "instructorname";
            this.instructorname.FillWeight = 109.7531F;
            this.instructorname.HeaderText = "Instructor Name";
            this.instructorname.Name = "instructorname";
            this.instructorname.ReadOnly = true;
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
            // instructorcourseId
            // 
            this.instructorcourseId.DataPropertyName = "courseID";
            this.instructorcourseId.FillWeight = 73.07925F;
            this.instructorcourseId.HeaderText = "Course ID";
            this.instructorcourseId.Name = "instructorcourseId";
            this.instructorcourseId.ReadOnly = true;
            // 
            // instructorcName
            // 
            this.instructorcName.DataPropertyName = "coursename";
            this.instructorcName.FillWeight = 271.7144F;
            this.instructorcName.HeaderText = "Course Name";
            this.instructorcName.Name = "instructorcName";
            this.instructorcName.ReadOnly = true;
            // 
            // instructorSection
            // 
            this.instructorSection.DataPropertyName = "section";
            this.instructorSection.FillWeight = 52.33739F;
            this.instructorSection.HeaderText = "Section";
            this.instructorSection.Name = "instructorSection";
            this.instructorSection.ReadOnly = true;
            // 
            // instructorStartTime
            // 
            this.instructorStartTime.DataPropertyName = "startTime";
            this.instructorStartTime.FillWeight = 50.65809F;
            this.instructorStartTime.HeaderText = "Start Time";
            this.instructorStartTime.Name = "instructorStartTime";
            this.instructorStartTime.ReadOnly = true;
            // 
            // instructorEndTime
            // 
            this.instructorEndTime.DataPropertyName = "endTime";
            this.instructorEndTime.FillWeight = 42.31669F;
            this.instructorEndTime.HeaderText = "End Time";
            this.instructorEndTime.Name = "instructorEndTime";
            this.instructorEndTime.ReadOnly = true;
            // 
            // courseID
            // 
            this.courseID.DataPropertyName = "courseID";
            this.courseID.HeaderText = "Course ID";
            this.courseID.Name = "courseID";
            this.courseID.ReadOnly = true;
            // 
            // coursename
            // 
            this.coursename.DataPropertyName = "coursename";
            this.coursename.FillWeight = 244.5144F;
            this.coursename.HeaderText = "Course Name";
            this.coursename.Name = "coursename";
            this.coursename.ReadOnly = true;
            // 
            // AccountManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::Borrowing_System.Properties.Resources.accmangemtnt;
            this.ClientSize = new System.Drawing.Size(1532, 650);
            this.Controls.Add(this.courseBTN);
            this.Controls.Add(this.instructorBTN);
            this.Controls.Add(this.studentBTN);
            this.Controls.Add(this.employeeBTN);
            this.Controls.Add(this.accountmanagementPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountManagementPage";
            this.Text = "AccountManagementPage";
            this.Load += new System.EventHandler(this.AccountManagementPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeData)).EndInit();
            this.accountmanagementPanel.ResumeLayout(false);
            this.accountmanagementPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox searchData;
        private System.Windows.Forms.DataGridView employeeData;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.Panel accountmanagementPanel;
        private System.Windows.Forms.Button employeeBTN;
        private System.Windows.Forms.Button studentBTN;
        private System.Windows.Forms.Button instructorBTN;
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
        private Account_Management.StudentList studentList1;
        private Account_Management.InstructorList instructorList1;
        private Account_Management.CourseList courseList1;
        private System.Windows.Forms.ComboBox instructorlistTxtbx;
        private System.Windows.Forms.DataGridView courseData;
        private System.Windows.Forms.Button courseBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentMiddleinitial;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn program;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearlevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorMiddleinitial;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorcourseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursename;
    }
}