namespace Borrowing_System
{
    partial class TransactionLogsPage
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
            this.logsTable = new System.Windows.Forms.DataGridView();
            this.transactionlogID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiver_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returndate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returntime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBTN = new System.Windows.Forms.Button();
            this.searchData = new System.Windows.Forms.TextBox();
            this.clearDashBtn = new System.Windows.Forms.Button();
            this.staffCmbx = new System.Windows.Forms.ComboBox();
            this.dateSearch2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateSearch1 = new System.Windows.Forms.DateTimePicker();
            this.excelExportBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // logsTable
            // 
            this.logsTable.AllowUserToAddRows = false;
            this.logsTable.AllowUserToDeleteRows = false;
            this.logsTable.AllowUserToOrderColumns = true;
            this.logsTable.AllowUserToResizeColumns = false;
            this.logsTable.AllowUserToResizeRows = false;
            this.logsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.logsTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.logsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.logsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.logsTable.ColumnHeadersHeight = 50;
            this.logsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.logsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionlogID,
            this.studentName,
            this.instructorName,
            this.fullName,
            this.receiver_name,
            this.equipmentName,
            this.quantity,
            this.returndate,
            this.returntime,
            this.notes});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.logsTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.logsTable.EnableHeadersVisualStyles = false;
            this.logsTable.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.logsTable.Location = new System.Drawing.Point(17, 147);
            this.logsTable.Name = "logsTable";
            this.logsTable.ReadOnly = true;
            this.logsTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.logsTable.RowHeadersVisible = false;
            this.logsTable.RowHeadersWidth = 50;
            this.logsTable.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(140)))), ((int)(((byte)(217)))));
            this.logsTable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.logsTable.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.logsTable.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.logsTable.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.logsTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.logsTable.Size = new System.Drawing.Size(1471, 454);
            this.logsTable.TabIndex = 4;
            // 
            // transactionlogID
            // 
            this.transactionlogID.DataPropertyName = "transactionlogID";
            this.transactionlogID.FillWeight = 77.9696F;
            this.transactionlogID.HeaderText = "Log ID";
            this.transactionlogID.Name = "transactionlogID";
            this.transactionlogID.ReadOnly = true;
            // 
            // studentName
            // 
            this.studentName.DataPropertyName = "studentName";
            this.studentName.FillWeight = 147.8824F;
            this.studentName.HeaderText = "Student Name";
            this.studentName.Name = "studentName";
            this.studentName.ReadOnly = true;
            // 
            // instructorName
            // 
            this.instructorName.DataPropertyName = "instructorName";
            this.instructorName.FillWeight = 158.3756F;
            this.instructorName.HeaderText = "Instructor Name";
            this.instructorName.Name = "instructorName";
            this.instructorName.ReadOnly = true;
            // 
            // fullName
            // 
            this.fullName.DataPropertyName = "releaserName";
            this.fullName.FillWeight = 117.3844F;
            this.fullName.HeaderText = "Releaser Name";
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            // 
            // receiver_name
            // 
            this.receiver_name.DataPropertyName = "receiverName";
            this.receiver_name.HeaderText = "Receiver Name";
            this.receiver_name.Name = "receiver_name";
            this.receiver_name.ReadOnly = true;
            // 
            // equipmentName
            // 
            this.equipmentName.DataPropertyName = "partname";
            this.equipmentName.FillWeight = 117.3844F;
            this.equipmentName.HeaderText = "Equipment Name";
            this.equipmentName.Name = "equipmentName";
            this.equipmentName.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.FillWeight = 72.8822F;
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // returndate
            // 
            this.returndate.DataPropertyName = "returndate";
            this.returndate.FillWeight = 84.94601F;
            this.returndate.HeaderText = "Return Date";
            this.returndate.Name = "returndate";
            this.returndate.ReadOnly = true;
            // 
            // returntime
            // 
            this.returntime.DataPropertyName = "returntime";
            this.returntime.FillWeight = 82.8419F;
            this.returntime.HeaderText = "Return Time";
            this.returntime.Name = "returntime";
            this.returntime.ReadOnly = true;
            // 
            // notes
            // 
            this.notes.DataPropertyName = "notes";
            this.notes.FillWeight = 117.3844F;
            this.notes.HeaderText = "Notes";
            this.notes.Name = "notes";
            this.notes.ReadOnly = true;
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
            this.searchBTN.TabIndex = 33;
            this.searchBTN.UseVisualStyleBackColor = false;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // searchData
            // 
            this.searchData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchData.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchData.Location = new System.Drawing.Point(289, 43);
            this.searchData.Name = "searchData";
            this.searchData.Size = new System.Drawing.Size(829, 26);
            this.searchData.TabIndex = 32;
            this.searchData.TextChanged += new System.EventHandler(this.searchData_TextChanged);
            this.searchData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchData_KeyDown);
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
            this.clearDashBtn.Location = new System.Drawing.Point(348, 107);
            this.clearDashBtn.Name = "clearDashBtn";
            this.clearDashBtn.Size = new System.Drawing.Size(107, 36);
            this.clearDashBtn.TabIndex = 40;
            this.clearDashBtn.Text = "Clear Selection";
            this.clearDashBtn.UseVisualStyleBackColor = false;
            this.clearDashBtn.Click += new System.EventHandler(this.clearDashBtn_Click);
            // 
            // staffCmbx
            // 
            this.staffCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.staffCmbx.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffCmbx.FormattingEnabled = true;
            this.staffCmbx.Location = new System.Drawing.Point(21, 107);
            this.staffCmbx.Name = "staffCmbx";
            this.staffCmbx.Size = new System.Drawing.Size(323, 36);
            this.staffCmbx.TabIndex = 39;
            this.staffCmbx.DropDown += new System.EventHandler(this.staffCmbx_DropDown);
            this.staffCmbx.SelectedIndexChanged += new System.EventHandler(this.staffCmbx_SelectedIndexChanged);
            // 
            // dateSearch2
            // 
            this.dateSearch2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSearch2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSearch2.Location = new System.Drawing.Point(796, 110);
            this.dateSearch2.Name = "dateSearch2";
            this.dateSearch2.Size = new System.Drawing.Size(110, 29);
            this.dateSearch2.TabIndex = 46;
            this.dateSearch2.ValueChanged += new System.EventHandler(this.dateSearch2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(704, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 30);
            this.label2.TabIndex = 45;
            this.label2.Text = "To date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(464, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 30);
            this.label1.TabIndex = 44;
            this.label1.Text = "From date:";
            // 
            // dateSearch1
            // 
            this.dateSearch1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSearch1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSearch1.Location = new System.Drawing.Point(582, 110);
            this.dateSearch1.Name = "dateSearch1";
            this.dateSearch1.Size = new System.Drawing.Size(116, 29);
            this.dateSearch1.TabIndex = 43;
            this.dateSearch1.ValueChanged += new System.EventHandler(this.dateSearch1_ValueChanged);
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
            this.excelExportBTN.Location = new System.Drawing.Point(1445, 107);
            this.excelExportBTN.Name = "excelExportBTN";
            this.excelExportBTN.Size = new System.Drawing.Size(33, 36);
            this.excelExportBTN.TabIndex = 47;
            this.excelExportBTN.UseVisualStyleBackColor = false;
            this.excelExportBTN.Click += new System.EventHandler(this.excelExportBTN_Click);
            // 
            // TransactionLogsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Borrowing_System.Properties.Resources.Transaction_Logs_Page;
            this.ClientSize = new System.Drawing.Size(1532, 650);
            this.Controls.Add(this.excelExportBTN);
            this.Controls.Add(this.dateSearch2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateSearch1);
            this.Controls.Add(this.clearDashBtn);
            this.Controls.Add(this.staffCmbx);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.searchData);
            this.Controls.Add(this.logsTable);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransactionLogsPage";
            this.Text = "TransactionLogsPage";
            this.Load += new System.EventHandler(this.TransactionLogsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView logsTable;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.TextBox searchData;
        private System.Windows.Forms.Button clearDashBtn;
        private System.Windows.Forms.ComboBox staffCmbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionlogID;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiver_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn returndate;
        private System.Windows.Forms.DataGridViewTextBoxColumn returntime;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
        private System.Windows.Forms.DateTimePicker dateSearch2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateSearch1;
        private System.Windows.Forms.Button excelExportBTN;
    }
}