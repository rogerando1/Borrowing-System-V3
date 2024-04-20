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
            this.searchData = new System.Windows.Forms.TextBox();
            this.accountData = new System.Windows.Forms.DataGridView();
            this.personID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleinitial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBTN = new System.Windows.Forms.Button();
            this.personIDTxtbx = new System.Windows.Forms.TextBox();
            this.fnameTxtbx = new System.Windows.Forms.TextBox();
            this.minitialTxtbx = new System.Windows.Forms.TextBox();
            this.lnameTxtbx = new System.Windows.Forms.TextBox();
            this.passwordTxtbx = new System.Windows.Forms.TextBox();
            this.usernameTxtbx = new System.Windows.Forms.TextBox();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.createBTN = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.accountmanagementPanel = new System.Windows.Forms.Panel();
            this.positionCmbx = new System.Windows.Forms.ComboBox();
            this.employeeBTN = new System.Windows.Forms.Button();
            this.studentBTN = new System.Windows.Forms.Button();
            this.instructorBTN = new System.Windows.Forms.Button();
            this.courseBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.accountData)).BeginInit();
            this.accountmanagementPanel.SuspendLayout();
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
            // accountData
            // 
            this.accountData.AllowUserToAddRows = false;
            this.accountData.AllowUserToDeleteRows = false;
            this.accountData.AllowUserToOrderColumns = true;
            this.accountData.AllowUserToResizeColumns = false;
            this.accountData.AllowUserToResizeRows = false;
            this.accountData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accountData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.accountData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.accountData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.accountData.ColumnHeadersHeight = 45;
            this.accountData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.accountData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.accountData.DefaultCellStyle = dataGridViewCellStyle2;
            this.accountData.EnableHeadersVisualStyles = false;
            this.accountData.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.accountData.Location = new System.Drawing.Point(25, 157);
            this.accountData.Name = "accountData";
            this.accountData.ReadOnly = true;
            this.accountData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.accountData.RowHeadersVisible = false;
            this.accountData.RowHeadersWidth = 51;
            this.accountData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accountData.Size = new System.Drawing.Size(957, 465);
            this.accountData.TabIndex = 15;
            this.accountData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountData_CellClick);
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
            // personIDTxtbx
            // 
            this.personIDTxtbx.BackColor = System.Drawing.Color.White;
            this.personIDTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personIDTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personIDTxtbx.Location = new System.Drawing.Point(1037, 222);
            this.personIDTxtbx.Name = "personIDTxtbx";
            this.personIDTxtbx.ReadOnly = true;
            this.personIDTxtbx.Size = new System.Drawing.Size(139, 23);
            this.personIDTxtbx.TabIndex = 23;
            // 
            // fnameTxtbx
            // 
            this.fnameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fnameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTxtbx.Location = new System.Drawing.Point(1037, 305);
            this.fnameTxtbx.Name = "fnameTxtbx";
            this.fnameTxtbx.Size = new System.Drawing.Size(240, 23);
            this.fnameTxtbx.TabIndex = 25;
            // 
            // minitialTxtbx
            // 
            this.minitialTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minitialTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.minitialTxtbx.Location = new System.Drawing.Point(1037, 392);
            this.minitialTxtbx.MaxLength = 1;
            this.minitialTxtbx.Name = "minitialTxtbx";
            this.minitialTxtbx.Size = new System.Drawing.Size(240, 23);
            this.minitialTxtbx.TabIndex = 27;
            // 
            // lnameTxtbx
            // 
            this.lnameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lnameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lnameTxtbx.Location = new System.Drawing.Point(1037, 478);
            this.lnameTxtbx.Name = "lnameTxtbx";
            this.lnameTxtbx.Size = new System.Drawing.Size(240, 23);
            this.lnameTxtbx.TabIndex = 29;
            // 
            // passwordTxtbx
            // 
            this.passwordTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.passwordTxtbx.Location = new System.Drawing.Point(1327, 305);
            this.passwordTxtbx.Name = "passwordTxtbx";
            this.passwordTxtbx.Size = new System.Drawing.Size(170, 23);
            this.passwordTxtbx.TabIndex = 33;
            // 
            // usernameTxtbx
            // 
            this.usernameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.usernameTxtbx.Location = new System.Drawing.Point(1327, 222);
            this.usernameTxtbx.Name = "usernameTxtbx";
            this.usernameTxtbx.Size = new System.Drawing.Size(170, 23);
            this.usernameTxtbx.TabIndex = 31;
            // 
            // deleteBTN
            // 
            this.deleteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.deleteBTN.FlatAppearance.BorderSize = 0;
            this.deleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBTN.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold);
            this.deleteBTN.Location = new System.Drawing.Point(1374, 552);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(96, 44);
            this.deleteBTN.TabIndex = 39;
            this.deleteBTN.Text = "Delete";
            this.deleteBTN.UseVisualStyleBackColor = false;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.updateBTN.FlatAppearance.BorderSize = 0;
            this.updateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBTN.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold);
            this.updateBTN.Location = new System.Drawing.Point(1272, 552);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(96, 44);
            this.updateBTN.TabIndex = 38;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = false;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // createBTN
            // 
            this.createBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.createBTN.FlatAppearance.BorderSize = 0;
            this.createBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBTN.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold);
            this.createBTN.Location = new System.Drawing.Point(1170, 552);
            this.createBTN.Name = "createBTN";
            this.createBTN.Size = new System.Drawing.Size(96, 44);
            this.createBTN.TabIndex = 37;
            this.createBTN.Text = "Create";
            this.createBTN.UseVisualStyleBackColor = false;
            this.createBTN.Click += new System.EventHandler(this.createBTN_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold);
            this.clearBtn.Location = new System.Drawing.Point(1068, 552);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(96, 44);
            this.clearBtn.TabIndex = 40;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // accountmanagementPanel
            // 
            this.accountmanagementPanel.BackColor = System.Drawing.Color.Transparent;
            this.accountmanagementPanel.Controls.Add(this.positionCmbx);
            this.accountmanagementPanel.Location = new System.Drawing.Point(0, 70);
            this.accountmanagementPanel.Name = "accountmanagementPanel";
            this.accountmanagementPanel.Size = new System.Drawing.Size(1532, 580);
            this.accountmanagementPanel.TabIndex = 42;
            // 
            // positionCmbx
            // 
            this.positionCmbx.BackColor = System.Drawing.Color.White;
            this.positionCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionCmbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.positionCmbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionCmbx.FormattingEnabled = true;
            this.positionCmbx.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.positionCmbx.Location = new System.Drawing.Point(1327, 316);
            this.positionCmbx.Name = "positionCmbx";
            this.positionCmbx.Size = new System.Drawing.Size(170, 33);
            this.positionCmbx.TabIndex = 43;
            // 
            // employeeBTN
            // 
            this.employeeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeeBTN.FlatAppearance.BorderSize = 0;
            this.employeeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.employeeBTN.Location = new System.Drawing.Point(226, 12);
            this.employeeBTN.Name = "employeeBTN";
            this.employeeBTN.Size = new System.Drawing.Size(174, 44);
            this.employeeBTN.TabIndex = 43;
            this.employeeBTN.Text = "Employee List";
            this.employeeBTN.UseVisualStyleBackColor = true;
            // 
            // studentBTN
            // 
            this.studentBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentBTN.FlatAppearance.BorderSize = 0;
            this.studentBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.studentBTN.Location = new System.Drawing.Point(452, 12);
            this.studentBTN.Name = "studentBTN";
            this.studentBTN.Size = new System.Drawing.Size(174, 44);
            this.studentBTN.TabIndex = 44;
            this.studentBTN.Text = "Student List";
            this.studentBTN.UseVisualStyleBackColor = true;
            // 
            // instructorBTN
            // 
            this.instructorBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.instructorBTN.FlatAppearance.BorderSize = 0;
            this.instructorBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructorBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.instructorBTN.Location = new System.Drawing.Point(663, 12);
            this.instructorBTN.Name = "instructorBTN";
            this.instructorBTN.Size = new System.Drawing.Size(174, 44);
            this.instructorBTN.TabIndex = 45;
            this.instructorBTN.Text = "Instructor List";
            this.instructorBTN.UseVisualStyleBackColor = true;
            // 
            // courseBTN
            // 
            this.courseBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.courseBTN.FlatAppearance.BorderSize = 0;
            this.courseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.courseBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.courseBTN.Location = new System.Drawing.Point(867, 12);
            this.courseBTN.Name = "courseBTN";
            this.courseBTN.Size = new System.Drawing.Size(174, 44);
            this.courseBTN.TabIndex = 46;
            this.courseBTN.Text = "Course List";
            this.courseBTN.UseVisualStyleBackColor = true;
            // 
            // AccountManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::Borrowing_System.Properties.Resources.acc_management__2_;
            this.ClientSize = new System.Drawing.Size(1532, 650);
            this.Controls.Add(this.courseBTN);
            this.Controls.Add(this.instructorBTN);
            this.Controls.Add(this.studentBTN);
            this.Controls.Add(this.employeeBTN);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.createBTN);
            this.Controls.Add(this.passwordTxtbx);
            this.Controls.Add(this.usernameTxtbx);
            this.Controls.Add(this.lnameTxtbx);
            this.Controls.Add(this.minitialTxtbx);
            this.Controls.Add(this.fnameTxtbx);
            this.Controls.Add(this.personIDTxtbx);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.accountData);
            this.Controls.Add(this.searchData);
            this.Controls.Add(this.accountmanagementPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountManagementPage";
            this.Text = "AccountManagementPage";
            this.Load += new System.EventHandler(this.AccountManagementPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountData)).EndInit();
            this.accountmanagementPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchData;
        private System.Windows.Forms.DataGridView accountData;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.TextBox personIDTxtbx;
        private System.Windows.Forms.TextBox fnameTxtbx;
        private System.Windows.Forms.TextBox minitialTxtbx;
        private System.Windows.Forms.TextBox lnameTxtbx;
        private System.Windows.Forms.TextBox passwordTxtbx;
        private System.Windows.Forms.TextBox usernameTxtbx;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button createBTN;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Panel accountmanagementPanel;
        private System.Windows.Forms.ComboBox positionCmbx;
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
    }
}