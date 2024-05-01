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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.logsTable = new System.Windows.Forms.DataGridView();
            this.searchBTN = new System.Windows.Forms.Button();
            this.searchData = new System.Windows.Forms.TextBox();
            this.transactionlogID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returndate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returntime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.logsTable.ColumnHeadersHeight = 50;
            this.logsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.logsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionlogID,
            this.studentName,
            this.instructorName,
            this.fullName,
            this.equipmentName,
            this.quantity,
            this.returndate,
            this.returntime,
            this.notes});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.logsTable.DefaultCellStyle = dataGridViewCellStyle8;
            this.logsTable.EnableHeadersVisualStyles = false;
            this.logsTable.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.logsTable.Location = new System.Drawing.Point(17, 102);
            this.logsTable.Name = "logsTable";
            this.logsTable.ReadOnly = true;
            this.logsTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.logsTable.RowHeadersVisible = false;
            this.logsTable.RowHeadersWidth = 50;
            this.logsTable.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(140)))), ((int)(((byte)(217)))));
            this.logsTable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.logsTable.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.logsTable.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.logsTable.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.logsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.logsTable.Size = new System.Drawing.Size(1471, 499);
            this.logsTable.TabIndex = 4;
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
            this.fullName.DataPropertyName = "accountName";
            this.fullName.FillWeight = 117.3844F;
            this.fullName.HeaderText = "Employee Name";
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
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
            // TransactionLogsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Borrowing_System.Properties.Resources.Transaction_Logs_Page;
            this.ClientSize = new System.Drawing.Size(1532, 650);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.searchData);
            this.Controls.Add(this.logsTable);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionlogID;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn returndate;
        private System.Windows.Forms.DataGridViewTextBoxColumn returntime;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
    }
}