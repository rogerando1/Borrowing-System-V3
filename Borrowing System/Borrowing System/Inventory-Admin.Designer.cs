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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productnamelist = new System.Windows.Forms.ComboBox();
            this.adminInventoryData = new System.Windows.Forms.DataGridView();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            this.searchBTN = new System.Windows.Forms.Button();
            this.searchData = new System.Windows.Forms.TextBox();
            this.partIdTxtbx = new System.Windows.Forms.TextBox();
            this.productnameTxtbx = new System.Windows.Forms.TextBox();
            this.partnameTxtbx = new System.Windows.Forms.TextBox();
            this.partdescriptionTxtbx = new System.Windows.Forms.TextBox();
            this.quantityTxtbx = new System.Windows.Forms.TextBox();
            this.conditionTxtbx = new System.Windows.Forms.TextBox();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partdescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearBtn = new System.Windows.Forms.Button();
            this.editBTN = new System.Windows.Forms.Button();
            this.doneBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.createBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adminInventoryData)).BeginInit();
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminInventoryData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
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
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminInventoryData.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
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
            this.adminInventoryData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminInventoryData_CellContentClick);
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
            // productnameTxtbx
            // 
            this.productnameTxtbx.BackColor = System.Drawing.Color.White;
            this.productnameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productnameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.productnameTxtbx.Location = new System.Drawing.Point(146, 145);
            this.productnameTxtbx.Name = "productnameTxtbx";
            this.productnameTxtbx.ReadOnly = true;
            this.productnameTxtbx.Size = new System.Drawing.Size(200, 17);
            this.productnameTxtbx.TabIndex = 37;
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
            // quantityTxtbx
            // 
            this.quantityTxtbx.BackColor = System.Drawing.Color.White;
            this.quantityTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.quantityTxtbx.Location = new System.Drawing.Point(20, 454);
            this.quantityTxtbx.Name = "quantityTxtbx";
            this.quantityTxtbx.ReadOnly = true;
            this.quantityTxtbx.Size = new System.Drawing.Size(96, 17);
            this.quantityTxtbx.TabIndex = 40;
            // 
            // conditionTxtbx
            // 
            this.conditionTxtbx.BackColor = System.Drawing.Color.White;
            this.conditionTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conditionTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.conditionTxtbx.Location = new System.Drawing.Point(146, 455);
            this.conditionTxtbx.Name = "conditionTxtbx";
            this.conditionTxtbx.ReadOnly = true;
            this.conditionTxtbx.Size = new System.Drawing.Size(201, 17);
            this.conditionTxtbx.TabIndex = 41;
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
            this.clearBtn.Visible = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // editBTN
            // 
            this.editBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.editBTN.FlatAppearance.BorderSize = 0;
            this.editBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBTN.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.editBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.editBTN.Location = new System.Drawing.Point(136, 564);
            this.editBTN.Name = "editBTN";
            this.editBTN.Size = new System.Drawing.Size(96, 36);
            this.editBTN.TabIndex = 46;
            this.editBTN.Text = "Edit";
            this.editBTN.UseVisualStyleBackColor = false;
            this.editBTN.Click += new System.EventHandler(this.editBTN_Click_1);
            // 
            // doneBTN
            // 
            this.doneBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.doneBTN.FlatAppearance.BorderSize = 0;
            this.doneBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneBTN.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.doneBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.doneBTN.Location = new System.Drawing.Point(250, 564);
            this.doneBTN.Name = "doneBTN";
            this.doneBTN.Size = new System.Drawing.Size(96, 36);
            this.doneBTN.TabIndex = 45;
            this.doneBTN.Text = "Done";
            this.doneBTN.UseVisualStyleBackColor = false;
            this.doneBTN.Visible = false;
            this.doneBTN.Click += new System.EventHandler(this.doneBTN_Click);
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
            this.deleteBTN.Text = "Delete";
            this.deleteBTN.UseVisualStyleBackColor = false;
            this.deleteBTN.Visible = false;
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
            this.updateBTN.Visible = false;
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
            this.createBTN.Text = "Create";
            this.createBTN.UseVisualStyleBackColor = false;
            this.createBTN.Visible = false;
            this.createBTN.Click += new System.EventHandler(this.createBTN_Click);
            // 
            // Inventory_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Borrowing_System.Properties.Resources.Admin_invenotry__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1532, 650);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.editBTN);
            this.Controls.Add(this.doneBTN);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.createBTN);
            this.Controls.Add(this.conditionTxtbx);
            this.Controls.Add(this.quantityTxtbx);
            this.Controls.Add(this.partdescriptionTxtbx);
            this.Controls.Add(this.partnameTxtbx);
            this.Controls.Add(this.productnameTxtbx);
            this.Controls.Add(this.partIdTxtbx);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.searchData);
            this.Controls.Add(this.adminInventoryData);
            this.Controls.Add(this.productnamelist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory_Admin";
            this.Text = "Inventory_Admin";
            this.Load += new System.EventHandler(this.Inventory_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminInventoryData)).EndInit();
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
        private System.Windows.Forms.TextBox productnameTxtbx;
        private System.Windows.Forms.TextBox partnameTxtbx;
        private System.Windows.Forms.TextBox partdescriptionTxtbx;
        private System.Windows.Forms.TextBox quantityTxtbx;
        private System.Windows.Forms.TextBox conditionTxtbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn partID;
        private System.Windows.Forms.DataGridViewTextBoxColumn partname;
        private System.Windows.Forms.DataGridViewTextBoxColumn partdescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn condition;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button editBTN;
        private System.Windows.Forms.Button doneBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button createBTN;
    }
}