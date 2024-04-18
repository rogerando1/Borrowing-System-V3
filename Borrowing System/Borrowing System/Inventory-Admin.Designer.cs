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
            this.studentData = new System.Windows.Forms.DataGridView();
            this.staffData = new System.Windows.Forms.DataGridView();
            this.adminData = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminData)).BeginInit();
            this.SuspendLayout();
            // 
            // studentData
            // 
            this.studentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentData.Location = new System.Drawing.Point(478, 97);
            this.studentData.Name = "studentData";
            this.studentData.RowHeadersWidth = 51;
            this.studentData.Size = new System.Drawing.Size(1008, 485);
            this.studentData.TabIndex = 23;
            // 
            // staffData
            // 
            this.staffData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffData.Location = new System.Drawing.Point(478, 97);
            this.staffData.Name = "staffData";
            this.staffData.RowHeadersWidth = 51;
            this.staffData.Size = new System.Drawing.Size(1008, 485);
            this.staffData.TabIndex = 24;
            // 
            // adminData
            // 
            this.adminData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminData.Location = new System.Drawing.Point(478, 97);
            this.adminData.Name = "adminData";
            this.adminData.RowHeadersWidth = 51;
            this.adminData.Size = new System.Drawing.Size(1008, 485);
            this.adminData.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(495, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(938, 19);
            this.textBox1.TabIndex = 26;
            // 
            // Inventory_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Borrowing_System.Properties.Resources.Admin_invenotry__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1532, 650);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.studentData);
            this.Controls.Add(this.staffData);
            this.Controls.Add(this.adminData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory_Admin";
            this.Text = "Inventory_Admin";
            ((System.ComponentModel.ISupportInitialize)(this.studentData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView studentData;
        private System.Windows.Forms.DataGridView staffData;
        private System.Windows.Forms.DataGridView adminData;
        private System.Windows.Forms.TextBox textBox1;
    }
}