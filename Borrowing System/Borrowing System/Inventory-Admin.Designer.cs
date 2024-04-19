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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productnamelist = new System.Windows.Forms.ComboBox();
            this.adminInventoryData = new System.Windows.Forms.DataGridView();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partdescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.adminInventoryData)).BeginInit();
            this.SuspendLayout();
            // 
            // productnamelist
            // 
            this.productnamelist.BackColor = System.Drawing.Color.White;
            this.productnamelist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productnamelist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productnamelist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.productnamelist.FormattingEnabled = true;
            this.productnamelist.Location = new System.Drawing.Point(381, 43);
            this.productnamelist.Name = "productnamelist";
            this.productnamelist.Size = new System.Drawing.Size(286, 32);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminInventoryData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.adminInventoryData.ColumnHeadersHeight = 50;
            this.adminInventoryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.adminInventoryData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productname,
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminInventoryData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            // productID
            // 
            this.productID.DataPropertyName = "productID";
            this.productID.FillWeight = 54.24955F;
            this.productID.HeaderText = "Product ID";
            this.productID.MinimumWidth = 6;
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            // 
            // productname
            // 
            this.productname.DataPropertyName = "productname";
            this.productname.FillWeight = 117.2078F;
            this.productname.HeaderText = "Product Name";
            this.productname.MinimumWidth = 6;
            this.productname.Name = "productname";
            this.productname.ReadOnly = true;
            this.productname.Width = 216;
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
            // Inventory_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Borrowing_System.Properties.Resources.Admin_invenotry__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1532, 650);
            this.Controls.Add(this.adminInventoryData);
            this.Controls.Add(this.productnamelist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory_Admin";
            this.Text = "Inventory_Admin";
            this.Load += new System.EventHandler(this.Inventory_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminInventoryData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox productnamelist;
        private System.Windows.Forms.DataGridView adminInventoryData;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn partname;
        private System.Windows.Forms.DataGridViewTextBoxColumn partdescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn condition;
    }
}