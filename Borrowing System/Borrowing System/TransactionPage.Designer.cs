namespace Borrowing_System
{
    partial class TransactionPage
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
            this.studentIDTxtbx = new System.Windows.Forms.TextBox();
            this.borrowerNameTxtbx = new System.Windows.Forms.TextBox();
            this.courseTxtbx = new System.Windows.Forms.TextBox();
            this.yearlevelTxtbx = new System.Windows.Forms.TextBox();
            this.availableLabel = new System.Windows.Forms.Label();
            this.instructorNameTxtbx = new System.Windows.Forms.ComboBox();
            this.subjectCodeTxtbx = new System.Windows.Forms.ComboBox();
            this.equipmentNameTxtbx = new System.Windows.Forms.ComboBox();
            this.typeTxtbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subjectnameLabel = new System.Windows.Forms.Label();
            this.quantityTxtbx = new System.Windows.Forms.NumericUpDown();
            this.submitBTN = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.addCartBTN = new System.Windows.Forms.Button();
            this.cartTable = new System.Windows.Forms.DataGridView();
            this.staffCmbx = new System.Windows.Forms.ComboBox();
            this.clearCart = new System.Windows.Forms.Button();
            this.borrower_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.part_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTxtbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartTable)).BeginInit();
            this.SuspendLayout();
            // 
            // studentIDTxtbx
            // 
            this.studentIDTxtbx.BackColor = System.Drawing.Color.White;
            this.studentIDTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentIDTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDTxtbx.Location = new System.Drawing.Point(759, 80);
            this.studentIDTxtbx.Multiline = true;
            this.studentIDTxtbx.Name = "studentIDTxtbx";
            this.studentIDTxtbx.Size = new System.Drawing.Size(290, 40);
            this.studentIDTxtbx.TabIndex = 11;
            this.studentIDTxtbx.TextChanged += new System.EventHandler(this.studentIDTxtbx_TextChanged);
            // 
            // borrowerNameTxtbx
            // 
            this.borrowerNameTxtbx.BackColor = System.Drawing.Color.White;
            this.borrowerNameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.borrowerNameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerNameTxtbx.Location = new System.Drawing.Point(759, 178);
            this.borrowerNameTxtbx.Multiline = true;
            this.borrowerNameTxtbx.Name = "borrowerNameTxtbx";
            this.borrowerNameTxtbx.Size = new System.Drawing.Size(290, 38);
            this.borrowerNameTxtbx.TabIndex = 12;
            // 
            // courseTxtbx
            // 
            this.courseTxtbx.BackColor = System.Drawing.Color.White;
            this.courseTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTxtbx.Location = new System.Drawing.Point(759, 281);
            this.courseTxtbx.Name = "courseTxtbx";
            this.courseTxtbx.Size = new System.Drawing.Size(290, 22);
            this.courseTxtbx.TabIndex = 15;
            // 
            // yearlevelTxtbx
            // 
            this.yearlevelTxtbx.BackColor = System.Drawing.Color.White;
            this.yearlevelTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearlevelTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlevelTxtbx.Location = new System.Drawing.Point(759, 379);
            this.yearlevelTxtbx.Name = "yearlevelTxtbx";
            this.yearlevelTxtbx.Size = new System.Drawing.Size(290, 22);
            this.yearlevelTxtbx.TabIndex = 16;
            // 
            // availableLabel
            // 
            this.availableLabel.AutoSize = true;
            this.availableLabel.BackColor = System.Drawing.Color.Transparent;
            this.availableLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableLabel.ForeColor = System.Drawing.Color.Blue;
            this.availableLabel.Location = new System.Drawing.Point(1425, 521);
            this.availableLabel.Name = "availableLabel";
            this.availableLabel.Size = new System.Drawing.Size(106, 17);
            this.availableLabel.TabIndex = 20;
            this.availableLabel.Text = "{availableLabel}";
            // 
            // instructorNameTxtbx
            // 
            this.instructorNameTxtbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instructorNameTxtbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructorNameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.instructorNameTxtbx.FormattingEnabled = true;
            this.instructorNameTxtbx.Location = new System.Drawing.Point(1157, 83);
            this.instructorNameTxtbx.Name = "instructorNameTxtbx";
            this.instructorNameTxtbx.Size = new System.Drawing.Size(290, 32);
            this.instructorNameTxtbx.TabIndex = 21;
            this.instructorNameTxtbx.SelectedIndexChanged += new System.EventHandler(this.instructorNameTxtbx_SelectedIndexChanged);
            // 
            // subjectCodeTxtbx
            // 
            this.subjectCodeTxtbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjectCodeTxtbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectCodeTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.subjectCodeTxtbx.FormattingEnabled = true;
            this.subjectCodeTxtbx.Items.AddRange(new object[] {
            "Please select an instructor first"});
            this.subjectCodeTxtbx.Location = new System.Drawing.Point(1157, 181);
            this.subjectCodeTxtbx.Name = "subjectCodeTxtbx";
            this.subjectCodeTxtbx.Size = new System.Drawing.Size(290, 32);
            this.subjectCodeTxtbx.TabIndex = 22;
            this.subjectCodeTxtbx.SelectedIndexChanged += new System.EventHandler(this.subjectCodeTxtbx_SelectedIndexChanged);
            // 
            // equipmentNameTxtbx
            // 
            this.equipmentNameTxtbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmentNameTxtbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equipmentNameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.equipmentNameTxtbx.FormattingEnabled = true;
            this.equipmentNameTxtbx.Location = new System.Drawing.Point(1157, 276);
            this.equipmentNameTxtbx.Name = "equipmentNameTxtbx";
            this.equipmentNameTxtbx.Size = new System.Drawing.Size(290, 32);
            this.equipmentNameTxtbx.TabIndex = 23;
            this.equipmentNameTxtbx.DropDown += new System.EventHandler(this.equipmentNameTxtbx_DropDown);
            this.equipmentNameTxtbx.SelectedIndexChanged += new System.EventHandler(this.equipmentNameTxtbx_SelectedIndexChanged);
            // 
            // typeTxtbx
            // 
            this.typeTxtbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeTxtbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.typeTxtbx.FormattingEnabled = true;
            this.typeTxtbx.Location = new System.Drawing.Point(1157, 374);
            this.typeTxtbx.Name = "typeTxtbx";
            this.typeTxtbx.Size = new System.Drawing.Size(290, 32);
            this.typeTxtbx.TabIndex = 24;
            this.typeTxtbx.SelectedIndexChanged += new System.EventHandler(this.typeTxtbx_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(83)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(1150, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Subject Name:";
            // 
            // subjectnameLabel
            // 
            this.subjectnameLabel.AutoSize = true;
            this.subjectnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.subjectnameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectnameLabel.ForeColor = System.Drawing.Color.Blue;
            this.subjectnameLabel.Location = new System.Drawing.Point(1261, 228);
            this.subjectnameLabel.Name = "subjectnameLabel";
            this.subjectnameLabel.Size = new System.Drawing.Size(112, 17);
            this.subjectnameLabel.TabIndex = 29;
            this.subjectnameLabel.Text = "{subjectnamelbl}";
            // 
            // quantityTxtbx
            // 
            this.quantityTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.quantityTxtbx.Location = new System.Drawing.Point(1157, 473);
            this.quantityTxtbx.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.quantityTxtbx.Name = "quantityTxtbx";
            this.quantityTxtbx.Size = new System.Drawing.Size(289, 25);
            this.quantityTxtbx.TabIndex = 31;
            // 
            // submitBTN
            // 
            this.submitBTN.BackColor = System.Drawing.Color.White;
            this.submitBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBTN.FlatAppearance.BorderSize = 0;
            this.submitBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(168)))), ((int)(((byte)(115)))));
            this.submitBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(168)))), ((int)(((byte)(115)))));
            this.submitBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBTN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBTN.ForeColor = System.Drawing.Color.Black;
            this.submitBTN.Location = new System.Drawing.Point(254, 586);
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.Size = new System.Drawing.Size(142, 45);
            this.submitBTN.TabIndex = 33;
            this.submitBTN.Text = "Submit Order";
            this.submitBTN.UseVisualStyleBackColor = false;
            this.submitBTN.Click += new System.EventHandler(this.submitBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.BackColor = System.Drawing.Color.White;
            this.clearBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBTN.FlatAppearance.BorderSize = 0;
            this.clearBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(168)))), ((int)(((byte)(115)))));
            this.clearBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(168)))), ((int)(((byte)(115)))));
            this.clearBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBTN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBTN.ForeColor = System.Drawing.Color.Black;
            this.clearBTN.Location = new System.Drawing.Point(951, 560);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(139, 45);
            this.clearBTN.TabIndex = 32;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = false;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click_1);
            // 
            // addCartBTN
            // 
            this.addCartBTN.BackColor = System.Drawing.Color.White;
            this.addCartBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCartBTN.FlatAppearance.BorderSize = 0;
            this.addCartBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(168)))), ((int)(((byte)(115)))));
            this.addCartBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(168)))), ((int)(((byte)(115)))));
            this.addCartBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCartBTN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCartBTN.ForeColor = System.Drawing.Color.Black;
            this.addCartBTN.Location = new System.Drawing.Point(1113, 560);
            this.addCartBTN.Name = "addCartBTN";
            this.addCartBTN.Size = new System.Drawing.Size(142, 45);
            this.addCartBTN.TabIndex = 34;
            this.addCartBTN.Text = "Add to Cart";
            this.addCartBTN.UseVisualStyleBackColor = false;
            this.addCartBTN.Click += new System.EventHandler(this.addCartBTN_Click);
            // 
            // cartTable
            // 
            this.cartTable.AllowUserToAddRows = false;
            this.cartTable.AllowUserToDeleteRows = false;
            this.cartTable.AllowUserToOrderColumns = true;
            this.cartTable.AllowUserToResizeColumns = false;
            this.cartTable.AllowUserToResizeRows = false;
            this.cartTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cartTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.cartTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cartTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.cartTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cartTable.ColumnHeadersHeight = 50;
            this.cartTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.cartTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrower_name,
            this.part_name,
            this.quantity,
            this.status});
            this.cartTable.EnableHeadersVisualStyles = false;
            this.cartTable.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.cartTable.Location = new System.Drawing.Point(32, 49);
            this.cartTable.Margin = new System.Windows.Forms.Padding(2);
            this.cartTable.Name = "cartTable";
            this.cartTable.ReadOnly = true;
            this.cartTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cartTable.RowHeadersVisible = false;
            this.cartTable.RowHeadersWidth = 50;
            this.cartTable.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cartTable.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(140)))), ((int)(((byte)(217)))));
            this.cartTable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartTable.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.cartTable.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.cartTable.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cartTable.RowTemplate.Height = 50;
            this.cartTable.RowTemplate.ReadOnly = true;
            this.cartTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cartTable.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.cartTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartTable.Size = new System.Drawing.Size(600, 520);
            this.cartTable.TabIndex = 35;
            this.cartTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartTable_CellClick);
            this.cartTable.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartTable_CellMouseEnter);
            this.cartTable.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartTable_CellMouseLeave);
            this.cartTable.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.cartTable_CellPainting);
            // 
            // staffCmbx
            // 
            this.staffCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.staffCmbx.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffCmbx.FormattingEnabled = true;
            this.staffCmbx.Location = new System.Drawing.Point(32, 12);
            this.staffCmbx.Name = "staffCmbx";
            this.staffCmbx.Size = new System.Drawing.Size(323, 36);
            this.staffCmbx.TabIndex = 36;
            this.staffCmbx.DropDown += new System.EventHandler(this.staffCmbx_DropDown);
            this.staffCmbx.SelectedIndexChanged += new System.EventHandler(this.staffCmbx_SelectedIndexChanged);
            // 
            // clearCart
            // 
            this.clearCart.BackColor = System.Drawing.Color.White;
            this.clearCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearCart.FlatAppearance.BorderSize = 0;
            this.clearCart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(168)))), ((int)(((byte)(115)))));
            this.clearCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(168)))), ((int)(((byte)(115)))));
            this.clearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearCart.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearCart.ForeColor = System.Drawing.Color.Black;
            this.clearCart.Location = new System.Drawing.Point(361, 12);
            this.clearCart.Name = "clearCart";
            this.clearCart.Size = new System.Drawing.Size(107, 36);
            this.clearCart.TabIndex = 37;
            this.clearCart.Text = "Clear Selection";
            this.clearCart.UseVisualStyleBackColor = false;
            this.clearCart.Click += new System.EventHandler(this.clearCart_Click);
            // 
            // borrower_name
            // 
            this.borrower_name.DataPropertyName = "borrowerName";
            this.borrower_name.HeaderText = "Borrower Name";
            this.borrower_name.Name = "borrower_name";
            this.borrower_name.ReadOnly = true;
            // 
            // part_name
            // 
            this.part_name.DataPropertyName = "partname";
            this.part_name.FillWeight = 140.8629F;
            this.part_name.HeaderText = "Equipment Name";
            this.part_name.MinimumWidth = 6;
            this.part_name.Name = "part_name";
            this.part_name.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.FillWeight = 140.8629F;
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status_";
            this.status.FillWeight = 18.27411F;
            this.status.HeaderText = "";
            this.status.MinimumWidth = 2;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // TransactionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Borrowing_System.Properties.Resources.Transaction_Page;
            this.ClientSize = new System.Drawing.Size(1532, 650);
            this.Controls.Add(this.clearCart);
            this.Controls.Add(this.staffCmbx);
            this.Controls.Add(this.cartTable);
            this.Controls.Add(this.addCartBTN);
            this.Controls.Add(this.submitBTN);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.quantityTxtbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subjectnameLabel);
            this.Controls.Add(this.typeTxtbx);
            this.Controls.Add(this.equipmentNameTxtbx);
            this.Controls.Add(this.subjectCodeTxtbx);
            this.Controls.Add(this.instructorNameTxtbx);
            this.Controls.Add(this.availableLabel);
            this.Controls.Add(this.yearlevelTxtbx);
            this.Controls.Add(this.courseTxtbx);
            this.Controls.Add(this.borrowerNameTxtbx);
            this.Controls.Add(this.studentIDTxtbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransactionPage";
            this.Text = "TransactionPage";
            this.Load += new System.EventHandler(this.TransactionPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantityTxtbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentIDTxtbx;
        private System.Windows.Forms.TextBox borrowerNameTxtbx;
        private System.Windows.Forms.TextBox courseTxtbx;
        private System.Windows.Forms.TextBox yearlevelTxtbx;
        private System.Windows.Forms.Label availableLabel;
        private System.Windows.Forms.ComboBox instructorNameTxtbx;
        private System.Windows.Forms.ComboBox subjectCodeTxtbx;
        private System.Windows.Forms.ComboBox equipmentNameTxtbx;
        private System.Windows.Forms.ComboBox typeTxtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label subjectnameLabel;
        private System.Windows.Forms.NumericUpDown quantityTxtbx;
        private System.Windows.Forms.Button submitBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Button addCartBTN;
        private System.Windows.Forms.DataGridView cartTable;
        private System.Windows.Forms.ComboBox staffCmbx;
        private System.Windows.Forms.Button clearCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrower_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn part_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}