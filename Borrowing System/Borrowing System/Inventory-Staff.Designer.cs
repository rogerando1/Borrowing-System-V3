namespace Borrowing_System
{
    partial class Inventory_Staff
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
            this.defectiveTxtbx = new System.Windows.Forms.TextBox();
            this.partdescriptionTxtbx = new System.Windows.Forms.TextBox();
            this.partnameTxtbx = new System.Windows.Forms.TextBox();
            this.productnameTxtbx = new System.Windows.Forms.TextBox();
            this.partIdTxtbx = new System.Windows.Forms.TextBox();
            this.searchBTN = new System.Windows.Forms.Button();
            this.searchData = new System.Windows.Forms.TextBox();
            this.mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.quantityTxtbx = new System.Windows.Forms.TextBox();
            this.staffInventoryData = new System.Windows.Forms.DataGridView();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partdescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defective = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnamelist = new System.Windows.Forms.ComboBox();
            this.excelExportBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.staffInventoryData)).BeginInit();
            this.SuspendLayout();
            // 
            // defectiveTxtbx
            // 
            this.defectiveTxtbx.BackColor = System.Drawing.Color.White;
            this.defectiveTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.defectiveTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defectiveTxtbx.Location = new System.Drawing.Point(129, 377);
            this.defectiveTxtbx.Name = "defectiveTxtbx";
            this.defectiveTxtbx.ReadOnly = true;
            this.defectiveTxtbx.Size = new System.Drawing.Size(162, 19);
            this.defectiveTxtbx.TabIndex = 5;
            // 
            // partdescriptionTxtbx
            // 
            this.partdescriptionTxtbx.BackColor = System.Drawing.Color.White;
            this.partdescriptionTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.partdescriptionTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partdescriptionTxtbx.Location = new System.Drawing.Point(21, 246);
            this.partdescriptionTxtbx.Multiline = true;
            this.partdescriptionTxtbx.Name = "partdescriptionTxtbx";
            this.partdescriptionTxtbx.ReadOnly = true;
            this.partdescriptionTxtbx.Size = new System.Drawing.Size(270, 80);
            this.partdescriptionTxtbx.TabIndex = 3;
            // 
            // partnameTxtbx
            // 
            this.partnameTxtbx.BackColor = System.Drawing.Color.White;
            this.partnameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.partnameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.partnameTxtbx.Location = new System.Drawing.Point(17, 185);
            this.partnameTxtbx.Name = "partnameTxtbx";
            this.partnameTxtbx.ReadOnly = true;
            this.partnameTxtbx.Size = new System.Drawing.Size(275, 17);
            this.partnameTxtbx.TabIndex = 2;
            // 
            // productnameTxtbx
            // 
            this.productnameTxtbx.BackColor = System.Drawing.Color.White;
            this.productnameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productnameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.productnameTxtbx.Location = new System.Drawing.Point(125, 117);
            this.productnameTxtbx.Name = "productnameTxtbx";
            this.productnameTxtbx.ReadOnly = true;
            this.productnameTxtbx.Size = new System.Drawing.Size(167, 17);
            this.productnameTxtbx.TabIndex = 1;
            // 
            // partIdTxtbx
            // 
            this.partIdTxtbx.BackColor = System.Drawing.Color.White;
            this.partIdTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.partIdTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.partIdTxtbx.Location = new System.Drawing.Point(17, 116);
            this.partIdTxtbx.Name = "partIdTxtbx";
            this.partIdTxtbx.ReadOnly = true;
            this.partIdTxtbx.Size = new System.Drawing.Size(80, 17);
            this.partIdTxtbx.TabIndex = 0;
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
            this.searchBTN.Location = new System.Drawing.Point(1185, 28);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(31, 29);
            this.searchBTN.TabIndex = 8;
            this.searchBTN.UseVisualStyleBackColor = false;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // searchData
            // 
            this.searchData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchData.Location = new System.Drawing.Point(653, 33);
            this.searchData.Name = "searchData";
            this.searchData.Size = new System.Drawing.Size(520, 19);
            this.searchData.TabIndex = 7;
            this.searchData.TextChanged += new System.EventHandler(this.searchData_TextChanged);
            this.searchData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchData_KeyDown);
            // 
            // mySqlCommand2
            // 
            this.mySqlCommand2.CacheAge = 0;
            this.mySqlCommand2.Connection = null;
            this.mySqlCommand2.EnableCaching = false;
            this.mySqlCommand2.Transaction = null;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // quantityTxtbx
            // 
            this.quantityTxtbx.BackColor = System.Drawing.Color.White;
            this.quantityTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTxtbx.Location = new System.Drawing.Point(21, 377);
            this.quantityTxtbx.Name = "quantityTxtbx";
            this.quantityTxtbx.ReadOnly = true;
            this.quantityTxtbx.Size = new System.Drawing.Size(76, 19);
            this.quantityTxtbx.TabIndex = 4;
            // 
            // staffInventoryData
            // 
            this.staffInventoryData.AllowUserToAddRows = false;
            this.staffInventoryData.AllowUserToDeleteRows = false;
            this.staffInventoryData.AllowUserToOrderColumns = true;
            this.staffInventoryData.AllowUserToResizeColumns = false;
            this.staffInventoryData.AllowUserToResizeRows = false;
            this.staffInventoryData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.staffInventoryData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffInventoryData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.staffInventoryData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffInventoryData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.staffInventoryData.ColumnHeadersHeight = 50;
            this.staffInventoryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.staffInventoryData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productname,
            this.partID,
            this.partname,
            this.partdescription,
            this.quantity,
            this.defective});
            this.staffInventoryData.EnableHeadersVisualStyles = false;
            this.staffInventoryData.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.staffInventoryData.Location = new System.Drawing.Point(319, 78);
            this.staffInventoryData.Margin = new System.Windows.Forms.Padding(2);
            this.staffInventoryData.Name = "staffInventoryData";
            this.staffInventoryData.ReadOnly = true;
            this.staffInventoryData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffInventoryData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.staffInventoryData.RowHeadersVisible = false;
            this.staffInventoryData.RowHeadersWidth = 50;
            this.staffInventoryData.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.staffInventoryData.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(140)))), ((int)(((byte)(217)))));
            this.staffInventoryData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffInventoryData.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.staffInventoryData.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.staffInventoryData.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.staffInventoryData.RowTemplate.Height = 30;
            this.staffInventoryData.RowTemplate.ReadOnly = true;
            this.staffInventoryData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.staffInventoryData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staffInventoryData.Size = new System.Drawing.Size(966, 493);
            this.staffInventoryData.TabIndex = 10;
            this.staffInventoryData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffInventoryData_CellClick);
            this.staffInventoryData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffInventoryData_CellContentClick);
            // 
            // productname
            // 
            this.productname.DataPropertyName = "productname";
            this.productname.FillWeight = 117.2078F;
            this.productname.HeaderText = "Product Name";
            this.productname.MinimumWidth = 6;
            this.productname.Name = "productname";
            this.productname.ReadOnly = true;
            this.productname.Width = 200;
            // 
            // partID
            // 
            this.partID.DataPropertyName = "partID";
            this.partID.FillWeight = 54.24955F;
            this.partID.HeaderText = "Part ID";
            this.partID.MinimumWidth = 6;
            this.partID.Name = "partID";
            this.partID.ReadOnly = true;
            this.partID.Width = 83;
            // 
            // partname
            // 
            this.partname.DataPropertyName = "partname";
            this.partname.FillWeight = 105.6566F;
            this.partname.HeaderText = "Part Name";
            this.partname.MinimumWidth = 6;
            this.partname.Name = "partname";
            this.partname.ReadOnly = true;
            this.partname.Width = 170;
            // 
            // partdescription
            // 
            this.partdescription.DataPropertyName = "partdescription";
            this.partdescription.FillWeight = 236.8824F;
            this.partdescription.HeaderText = "Part Description";
            this.partdescription.MinimumWidth = 6;
            this.partdescription.Name = "partdescription";
            this.partdescription.ReadOnly = true;
            this.partdescription.Width = 338;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.FillWeight = 43.05165F;
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 80;
            // 
            // defective
            // 
            this.defective.DataPropertyName = "defective";
            this.defective.FillWeight = 42.95186F;
            this.defective.HeaderText = "Defective";
            this.defective.MinimumWidth = 6;
            this.defective.Name = "defective";
            this.defective.ReadOnly = true;
            this.defective.Width = 79;
            // 
            // productnamelist
            // 
            this.productnamelist.BackColor = System.Drawing.Color.White;
            this.productnamelist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productnamelist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productnamelist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.productnamelist.FormattingEnabled = true;
            this.productnamelist.Location = new System.Drawing.Point(324, 31);
            this.productnamelist.Name = "productnamelist";
            this.productnamelist.Size = new System.Drawing.Size(307, 26);
            this.productnamelist.TabIndex = 6;
            this.productnamelist.DropDown += new System.EventHandler(this.productnamelist_DropDown);
            this.productnamelist.SelectedIndexChanged += new System.EventHandler(this.productnamelist_SelectedIndexChanged);
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
            this.excelExportBTN.Location = new System.Drawing.Point(1245, 24);
            this.excelExportBTN.Name = "excelExportBTN";
            this.excelExportBTN.Size = new System.Drawing.Size(40, 40);
            this.excelExportBTN.TabIndex = 9;
            this.excelExportBTN.UseVisualStyleBackColor = false;
            this.excelExportBTN.Click += new System.EventHandler(this.excelExportBTN_Click);
            // 
            // Inventory_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Borrowing_System.Properties.Resources.Staffinventorypage__1296x582___3_;
            this.ClientSize = new System.Drawing.Size(1296, 582);
            this.Controls.Add(this.excelExportBTN);
            this.Controls.Add(this.defectiveTxtbx);
            this.Controls.Add(this.partdescriptionTxtbx);
            this.Controls.Add(this.partnameTxtbx);
            this.Controls.Add(this.productnameTxtbx);
            this.Controls.Add(this.partIdTxtbx);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.searchData);
            this.Controls.Add(this.quantityTxtbx);
            this.Controls.Add(this.staffInventoryData);
            this.Controls.Add(this.productnamelist);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory_Staff";
            this.Text = "Inventory_Staff";
            this.Load += new System.EventHandler(this.Inventory_Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffInventoryData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox defectiveTxtbx;
        private System.Windows.Forms.TextBox partdescriptionTxtbx;
        private System.Windows.Forms.TextBox partnameTxtbx;
        private System.Windows.Forms.TextBox productnameTxtbx;
        private System.Windows.Forms.TextBox partIdTxtbx;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.TextBox searchData;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.TextBox quantityTxtbx;
        private System.Windows.Forms.DataGridView staffInventoryData;
        private System.Windows.Forms.ComboBox productnamelist;
        private System.Windows.Forms.Button excelExportBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn partID;
        private System.Windows.Forms.DataGridViewTextBoxColumn partname;
        private System.Windows.Forms.DataGridViewTextBoxColumn partdescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn defective;
    }
}