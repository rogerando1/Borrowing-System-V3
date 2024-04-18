namespace Borrowing_System
{
    partial class Settings
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
            this.aboutBTN = new System.Windows.Forms.Button();
            this.logoutBTN = new System.Windows.Forms.Button();
            this.profileBTN = new System.Windows.Forms.Button();
            this.accountInfoPanel = new System.Windows.Forms.Panel();
            this.editBTN = new System.Windows.Forms.Button();
            this.doneBTN = new System.Windows.Forms.Button();
            this.positionTxtbx = new System.Windows.Forms.TextBox();
            this.passwordTxtbx = new System.Windows.Forms.TextBox();
            this.usernameTxtbx = new System.Windows.Forms.TextBox();
            this.lastnameTxtbx = new System.Windows.Forms.TextBox();
            this.firstnameTxtbx = new System.Windows.Forms.TextBox();
            this.employeeIDTxtbx = new System.Windows.Forms.TextBox();
            this.updateBTN = new System.Windows.Forms.Button();
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.accountInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // aboutBTN
            // 
            this.aboutBTN.BackColor = System.Drawing.Color.White;
            this.aboutBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutBTN.FlatAppearance.BorderSize = 0;
            this.aboutBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBTN.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.aboutBTN.ForeColor = System.Drawing.Color.Black;
            this.aboutBTN.Image = global::Borrowing_System.Properties.Resources.about_icon;
            this.aboutBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutBTN.Location = new System.Drawing.Point(148, 396);
            this.aboutBTN.Name = "aboutBTN";
            this.aboutBTN.Size = new System.Drawing.Size(180, 50);
            this.aboutBTN.TabIndex = 8;
            this.aboutBTN.Text = "       About";
            this.aboutBTN.UseVisualStyleBackColor = false;
            this.aboutBTN.Click += new System.EventHandler(this.aboutBTN_Click);
            // 
            // logoutBTN
            // 
            this.logoutBTN.BackColor = System.Drawing.Color.White;
            this.logoutBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBTN.FlatAppearance.BorderSize = 0;
            this.logoutBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logoutBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logoutBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBTN.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold);
            this.logoutBTN.ForeColor = System.Drawing.Color.Black;
            this.logoutBTN.Location = new System.Drawing.Point(148, 577);
            this.logoutBTN.Name = "logoutBTN";
            this.logoutBTN.Size = new System.Drawing.Size(180, 50);
            this.logoutBTN.TabIndex = 9;
            this.logoutBTN.Text = "LOG OUT";
            this.logoutBTN.UseVisualStyleBackColor = false;
            this.logoutBTN.Click += new System.EventHandler(this.logoutBTN_Click);
            // 
            // profileBTN
            // 
            this.profileBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.profileBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileBTN.FlatAppearance.BorderSize = 0;
            this.profileBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBTN.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBTN.ForeColor = System.Drawing.Color.Black;
            this.profileBTN.Image = global::Borrowing_System.Properties.Resources.Profile_Icon;
            this.profileBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileBTN.Location = new System.Drawing.Point(148, 327);
            this.profileBTN.Name = "profileBTN";
            this.profileBTN.Size = new System.Drawing.Size(180, 50);
            this.profileBTN.TabIndex = 11;
            this.profileBTN.Text = "       Profile";
            this.profileBTN.UseVisualStyleBackColor = false;
            this.profileBTN.Click += new System.EventHandler(this.profileBTN_Click);
            // 
            // accountInfoPanel
            // 
            this.accountInfoPanel.BackColor = System.Drawing.Color.Transparent;
            this.accountInfoPanel.BackgroundImage = global::Borrowing_System.Properties.Resources.Account_Info_Page;
            this.accountInfoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.accountInfoPanel.Controls.Add(this.editBTN);
            this.accountInfoPanel.Controls.Add(this.doneBTN);
            this.accountInfoPanel.Controls.Add(this.positionTxtbx);
            this.accountInfoPanel.Controls.Add(this.passwordTxtbx);
            this.accountInfoPanel.Controls.Add(this.usernameTxtbx);
            this.accountInfoPanel.Controls.Add(this.lastnameTxtbx);
            this.accountInfoPanel.Controls.Add(this.firstnameTxtbx);
            this.accountInfoPanel.Controls.Add(this.employeeIDTxtbx);
            this.accountInfoPanel.Controls.Add(this.updateBTN);
            this.accountInfoPanel.Location = new System.Drawing.Point(466, 1);
            this.accountInfoPanel.Name = "accountInfoPanel";
            this.accountInfoPanel.Size = new System.Drawing.Size(1065, 656);
            this.accountInfoPanel.TabIndex = 7;
            // 
            // editBTN
            // 
            this.editBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(199)))), ((int)(((byte)(137)))));
            this.editBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBTN.FlatAppearance.BorderSize = 0;
            this.editBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(168)))), ((int)(((byte)(115)))));
            this.editBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(168)))), ((int)(((byte)(115)))));
            this.editBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBTN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.editBTN.ForeColor = System.Drawing.Color.Black;
            this.editBTN.Location = new System.Drawing.Point(424, 571);
            this.editBTN.Name = "editBTN";
            this.editBTN.Size = new System.Drawing.Size(238, 47);
            this.editBTN.TabIndex = 6;
            this.editBTN.Text = "Edit";
            this.editBTN.UseVisualStyleBackColor = false;
            this.editBTN.Click += new System.EventHandler(this.editBTN_Click);
            // 
            // doneBTN
            // 
            this.doneBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(199)))), ((int)(((byte)(137)))));
            this.doneBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doneBTN.FlatAppearance.BorderSize = 0;
            this.doneBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(168)))), ((int)(((byte)(115)))));
            this.doneBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(168)))), ((int)(((byte)(115)))));
            this.doneBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneBTN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.doneBTN.Location = new System.Drawing.Point(547, 571);
            this.doneBTN.Name = "doneBTN";
            this.doneBTN.Size = new System.Drawing.Size(115, 47);
            this.doneBTN.TabIndex = 9;
            this.doneBTN.Text = "Done";
            this.doneBTN.UseVisualStyleBackColor = false;
            this.doneBTN.Visible = false;
            this.doneBTN.Click += new System.EventHandler(this.doneBTN_Click);
            // 
            // positionTxtbx
            // 
            this.positionTxtbx.BackColor = System.Drawing.SystemColors.Window;
            this.positionTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.positionTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionTxtbx.Location = new System.Drawing.Point(625, 255);
            this.positionTxtbx.Name = "positionTxtbx";
            this.positionTxtbx.ReadOnly = true;
            this.positionTxtbx.Size = new System.Drawing.Size(286, 28);
            this.positionTxtbx.TabIndex = 8;
            // 
            // passwordTxtbx
            // 
            this.passwordTxtbx.BackColor = System.Drawing.Color.White;
            this.passwordTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtbx.Location = new System.Drawing.Point(625, 508);
            this.passwordTxtbx.Name = "passwordTxtbx";
            this.passwordTxtbx.ReadOnly = true;
            this.passwordTxtbx.Size = new System.Drawing.Size(286, 28);
            this.passwordTxtbx.TabIndex = 5;
            // 
            // usernameTxtbx
            // 
            this.usernameTxtbx.BackColor = System.Drawing.Color.White;
            this.usernameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtbx.Location = new System.Drawing.Point(173, 508);
            this.usernameTxtbx.Name = "usernameTxtbx";
            this.usernameTxtbx.ReadOnly = true;
            this.usernameTxtbx.Size = new System.Drawing.Size(286, 28);
            this.usernameTxtbx.TabIndex = 4;
            // 
            // lastnameTxtbx
            // 
            this.lastnameTxtbx.BackColor = System.Drawing.Color.White;
            this.lastnameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastnameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameTxtbx.Location = new System.Drawing.Point(625, 381);
            this.lastnameTxtbx.Name = "lastnameTxtbx";
            this.lastnameTxtbx.ReadOnly = true;
            this.lastnameTxtbx.Size = new System.Drawing.Size(286, 28);
            this.lastnameTxtbx.TabIndex = 3;
            // 
            // firstnameTxtbx
            // 
            this.firstnameTxtbx.BackColor = System.Drawing.Color.White;
            this.firstnameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstnameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameTxtbx.Location = new System.Drawing.Point(173, 381);
            this.firstnameTxtbx.Name = "firstnameTxtbx";
            this.firstnameTxtbx.ReadOnly = true;
            this.firstnameTxtbx.Size = new System.Drawing.Size(286, 28);
            this.firstnameTxtbx.TabIndex = 1;
            // 
            // employeeIDTxtbx
            // 
            this.employeeIDTxtbx.BackColor = System.Drawing.Color.White;
            this.employeeIDTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeeIDTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDTxtbx.Location = new System.Drawing.Point(173, 255);
            this.employeeIDTxtbx.Name = "employeeIDTxtbx";
            this.employeeIDTxtbx.ReadOnly = true;
            this.employeeIDTxtbx.Size = new System.Drawing.Size(286, 28);
            this.employeeIDTxtbx.TabIndex = 0;
            // 
            // updateBTN
            // 
            this.updateBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(199)))), ((int)(((byte)(137)))));
            this.updateBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBTN.FlatAppearance.BorderSize = 0;
            this.updateBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(168)))), ((int)(((byte)(115)))));
            this.updateBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(168)))), ((int)(((byte)(115)))));
            this.updateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBTN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.updateBTN.Location = new System.Drawing.Point(424, 571);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(117, 47);
            this.updateBTN.TabIndex = 7;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = false;
            this.updateBTN.Visible = false;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // aboutPanel
            // 
            this.aboutPanel.BackColor = System.Drawing.Color.Transparent;
            this.aboutPanel.BackgroundImage = global::Borrowing_System.Properties.Resources.About_Page__2_;
            this.aboutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.aboutPanel.Location = new System.Drawing.Point(469, 1);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Size = new System.Drawing.Size(1065, 656);
            this.aboutPanel.TabIndex = 10;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Borrowing_System.Properties.Resources.Settings_Page;
            this.ClientSize = new System.Drawing.Size(1532, 650);
            this.Controls.Add(this.profileBTN);
            this.Controls.Add(this.logoutBTN);
            this.Controls.Add(this.aboutBTN);
            this.Controls.Add(this.accountInfoPanel);
            this.Controls.Add(this.aboutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.accountInfoPanel.ResumeLayout(false);
            this.accountInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button aboutBTN;
        private System.Windows.Forms.Button logoutBTN;
        private System.Windows.Forms.Button profileBTN;
        private System.Windows.Forms.Panel accountInfoPanel;
        private System.Windows.Forms.Button editBTN;
        private System.Windows.Forms.Button doneBTN;
        private System.Windows.Forms.TextBox positionTxtbx;
        private System.Windows.Forms.TextBox passwordTxtbx;
        private System.Windows.Forms.TextBox usernameTxtbx;
        private System.Windows.Forms.TextBox lastnameTxtbx;
        private System.Windows.Forms.TextBox firstnameTxtbx;
        private System.Windows.Forms.TextBox employeeIDTxtbx;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Panel aboutPanel;
    }
}