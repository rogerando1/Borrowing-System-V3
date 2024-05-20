namespace Borrowing_System
{
    partial class Inventory_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory_Admin));
            this.productnamelist = new System.Windows.Forms.ComboBox();
            this.adminInventoryData = new System.Windows.Forms.DataGridView();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partdescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            this.searchBTN = new System.Windows.Forms.Button();
            this.searchData = new System.Windows.Forms.TextBox();
            this.partIdTxtbx = new System.Windows.Forms.TextBox();
            this.partnameTxtbx = new System.Windows.Forms.TextBox();
            this.partdescriptionTxtbx = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.createBTN = new System.Windows.Forms.Button();
            this.productnameTxtbx = new System.Windows.Forms.ComboBox();
            this.conditionTxtbx = new System.Windows.Forms.ComboBox();
            this.quantityTxtbx = new System.Windows.Forms.NumericUpDown();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.uploadBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adminInventoryData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTxtbx)).BeginInit();
            this.SuspendLayout();
            // 
            // productnamelist
            // 
            this.productnamelist.BackColor = System.Drawing.Color.White;
            this.productnamelist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productnamelist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productnamelist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.productnamelist.FormattingEnabled = true;
            this.productnamelist.Location = new System.Drawing.Point(381, 47);
            this.productnamelist.Name = "productnamelist";
            this.productnamelist.Size = new System.Drawing.Size(284, 26);
            this.productnamelist.TabIndex = 25;
            this.productnamelist.DropDown += new System.EventHandler(this.productnamelist_DropDown);
            this.productnamelist.SelectedIndexChanged += new System.EventHandler(this.productnamelist_SelectedIndexChanged);
            // 
            // adminInventoryData
            // 
            this.adminInventoryData.AllowUserToAddRows = false;
            this.adminInventoryData.AllowUserToDeleteRows = false;
            this.adminInventoryData.AllowUserToOrderColumns = true;
            this.adminInventoryData.AllowUserToResizeColumns = false;
            this.adminInventoryData.AllowUserToResizeRows = false;
            this.adminInventoryData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(147)))));
            this.adminInventoryData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminInventoryData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.adminInventoryData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminInventoryData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.adminInventoryData.ColumnHeadersHeight = 50;
            this.adminInventoryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.adminInventoryData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productname,
            this.partID,
            this.partname,
            this.partdescription,
            this.quantity,
            this.condition});
            this.adminInventoryData.EnableHeadersVisualStyles = false;
            this.adminInventoryData.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminInventoryData.Location = new System.Drawing.Point(381, 109);
            this.adminInventoryData.Margin = new System.Windows.Forms.Padding(2);
            this.adminInventoryData.Name = "adminInventoryData";
            this.adminInventoryData.ReadOnly = true;
            this.adminInventoryData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminInventoryData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.adminInventoryData.RowHeadersVisible = false;
            this.adminInventoryData.RowHeadersWidth = 50;
            this.adminInventoryData.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.adminInventoryData.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(140)))), ((int)(((byte)(217)))));
            this.adminInventoryData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminInventoryData.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.adminInventoryData.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.adminInventoryData.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.adminInventoryData.RowTemplate.Height = 30;
            this.adminInventoryData.RowTemplate.ReadOnly = true;
            this.adminInventoryData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.adminInventoryData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adminInventoryData.Size = new System.Drawing.Size(1106, 491);
            this.adminInventoryData.TabIndex = 26;
            this.adminInventoryData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminInventoryData_CellClick);
            this.adminInventoryData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminInventoryData_CellContentClick);
            // 
            // productname
            // 
            this.productname.DataPropertyName = "productname";
            this.productname.FillWeight = 117.2078F;
            this.productname.HeaderText = "Product Name";
            this.productname.MinimumWidth = 6;
            this.productname.Name = "productname";
            this.productname.ReadOnly = true;
            this.productname.Width = 218;
            // 
            // partID
            // 
            this.partID.DataPropertyName = "partID";
            this.partID.FillWeight = 54.24955F;
            this.partID.HeaderText = "Part ID";
            this.partID.MinimumWidth = 6;
            this.partID.Name = "partID";
            this.partID.ReadOnly = true;
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
            this.partdescription.Width = 439;
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
            // condition
            // 
            this.condition.DataPropertyName = "condition";
            this.condition.FillWeight = 42.95186F;
            this.condition.HeaderText = "Condition";
            this.condition.MinimumWidth = 6;
            this.condition.Name = "condition";
            this.condition.ReadOnly = true;
            this.condition.Width = 79;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // mySqlCommand2
            // 
            this.mySqlCommand2.CacheAge = 0;
            this.mySqlCommand2.Connection = null;
            this.mySqlCommand2.EnableCaching = false;
            this.mySqlCommand2.Transaction = null;
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
            this.searchBTN.Location = new System.Drawing.Point(1431, 42);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(33, 36);
            this.searchBTN.TabIndex = 35;
            this.searchBTN.UseVisualStyleBackColor = false;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // searchData
            // 
            this.searchData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchData.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchData.Location = new System.Drawing.Point(715, 47);
            this.searchData.Name = "searchData";
            this.searchData.Size = new System.Drawing.Size(710, 26);
            this.searchData.TabIndex = 34;
            this.searchData.TextChanged += new System.EventHandler(this.searchData_TextChanged);
            this.searchData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchData_KeyDown);
            // 
            // partIdTxtbx
            // 
            this.partIdTxtbx.BackColor = System.Drawing.Color.White;
            this.partIdTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.partIdTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.partIdTxtbx.Location = new System.Drawing.Point(20, 145);
            this.partIdTxtbx.Name = "partIdTxtbx";
            this.partIdTxtbx.ReadOnly = true;
            this.partIdTxtbx.Size = new System.Drawing.Size(96, 17);
            this.partIdTxtbx.TabIndex = 36;
            // 
            // partnameTxtbx
            // 
            this.partnameTxtbx.BackColor = System.Drawing.Color.White;
            this.partnameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.partnameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.partnameTxtbx.Location = new System.Drawing.Point(19, 226);
            this.partnameTxtbx.Name = "partnameTxtbx";
            this.partnameTxtbx.ReadOnly = true;
            this.partnameTxtbx.Size = new System.Drawing.Size(328, 17);
            this.partnameTxtbx.TabIndex = 38;
            // 
            // partdescriptionTxtbx
            // 
            this.partdescriptionTxtbx.BackColor = System.Drawing.Color.White;
            this.partdescriptionTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.partdescriptionTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.partdescriptionTxtbx.Location = new System.Drawing.Point(18, 301);
            this.partdescriptionTxtbx.Multiline = true;
            this.partdescriptionTxtbx.Name = "partdescriptionTxtbx";
            this.partdescriptionTxtbx.ReadOnly = true;
            this.partdescriptionTxtbx.Size = new System.Drawing.Size(328, 95);
            this.partdescriptionTxtbx.TabIndex = 39;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.clearBtn.Location = new System.Drawing.Point(251, 511);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(96, 36);
            this.clearBtn.TabIndex = 47;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.deleteBTN.FlatAppearance.BorderSize = 0;
            this.deleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBTN.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.deleteBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.deleteBTN.Location = new System.Drawing.Point(20, 564);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(96, 36);
            this.deleteBTN.TabIndex = 44;
            this.deleteBTN.Text = "Remove";
            this.deleteBTN.UseVisualStyleBackColor = false;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.updateBTN.FlatAppearance.BorderSize = 0;
            this.updateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBTN.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.updateBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.updateBTN.Location = new System.Drawing.Point(136, 511);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(96, 36);
            this.updateBTN.TabIndex = 43;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = false;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // createBTN
            // 
            this.createBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.createBTN.FlatAppearance.BorderSize = 0;
            this.createBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBTN.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.createBTN.Location = new System.Drawing.Point(19, 511);
            this.createBTN.Name = "createBTN";
            this.createBTN.Size = new System.Drawing.Size(96, 36);
            this.createBTN.TabIndex = 42;
            this.createBTN.Text = "Add";
            this.createBTN.UseVisualStyleBackColor = false;
            this.createBTN.Click += new System.EventHandler(this.createBTN_Click);
            // 
            // productnameTxtbx
            // 
            this.productnameTxtbx.BackColor = System.Drawing.Color.White;
            this.productnameTxtbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productnameTxtbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productnameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.productnameTxtbx.FormattingEnabled = true;
            this.productnameTxtbx.Location = new System.Drawing.Point(151, 141);
            this.productnameTxtbx.Name = "productnameTxtbx";
            this.productnameTxtbx.Size = new System.Drawing.Size(190, 26);
            this.productnameTxtbx.TabIndex = 48;
            this.productnameTxtbx.DropDown += new System.EventHandler(this.productnameTxtbx_DropDown);
            // 
            // conditionTxtbx
            // 
            this.conditionTxtbx.BackColor = System.Drawing.Color.White;
            this.conditionTxtbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conditionTxtbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conditionTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.conditionTxtbx.FormattingEnabled = true;
            this.conditionTxtbx.Items.AddRange(new object[] {
            "Good",
            "Missing",
            "Damaged"});
            this.conditionTxtbx.Location = new System.Drawing.Point(152, 451);
            this.conditionTxtbx.Name = "conditionTxtbx";
            this.conditionTxtbx.Size = new System.Drawing.Size(190, 26);
            this.conditionTxtbx.TabIndex = 49;
            // 
            // quantityTxtbx
            // 
            this.quantityTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTxtbx.Location = new System.Drawing.Point(25, 454);
            this.quantityTxtbx.Name = "quantityTxtbx";
            this.quantityTxtbx.Size = new System.Drawing.Size(89, 20);
            this.quantityTxtbx.TabIndex = 51;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // uploadBTN
            // 
            this.uploadBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.uploadBTN.FlatAppearance.BorderSize = 0;
            this.uploadBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadBTN.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.uploadBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.uploadBTN.Location = new System.Drawing.Point(136, 564);
            this.uploadBTN.Name = "uploadBTN";
            this.uploadBTN.Size = new System.Drawing.Size(210, 36);
            this.uploadBTN.TabIndex = 54;
            this.uploadBTN.Text = "Upload through CSV";
            this.uploadBTN.UseVisualStyleBackColor = false;
            this.uploadBTN.Click += new System.EventHandler(this.uploadBTN_Click);
            // 
            // Inventory_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Borrowing_System.Properties.Resources.Admin_invenotry__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1532, 650);
            this.Controls.Add(this.uploadBTN);
            this.Controls.Add(this.quantityTxtbx);
            this.Controls.Add(this.conditionTxtbx);
            this.Controls.Add(this.productnameTxtbx);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.createBTN);
            this.Controls.Add(this.partdescriptionTxtbx);
            this.Controls.Add(this.partnameTxtbx);
            this.Controls.Add(this.partIdTxtbx);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.searchData);
            this.Controls.Add(this.adminInventoryData);
            this.Controls.Add(this.productnamelist);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory_Admin";
            this.Text = "Inventory_Admin";
            this.Load += new System.EventHandler(this.Inventory_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminInventoryData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTxtbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox productnamelist;
        private System.Windows.Forms.DataGridView adminInventoryData;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.TextBox searchData;
        private System.Windows.Forms.TextBox partIdTxtbx;
        private System.Windows.Forms.TextBox partnameTxtbx;
        private System.Windows.Forms.TextBox partdescriptionTxtbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn partID;
        private System.Windows.Forms.DataGridViewTextBoxColumn partname;
        private System.Windows.Forms.DataGridViewTextBoxColumn partdescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn condition;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button createBTN;
        private System.Windows.Forms.ComboBox productnameTxtbx;
        private System.Windows.Forms.ComboBox conditionTxtbx;
        private System.Windows.Forms.NumericUpDown quantityTxtbx;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button uploadBTN;
    }
}