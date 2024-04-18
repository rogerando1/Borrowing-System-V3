﻿namespace Borrowing_System
{
    partial class LoginPage
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
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.loginBTN = new System.Windows.Forms.Button();
            this.usernameTxtbx = new System.Windows.Forms.TextBox();
            this.passwordTxtbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.DarkRed;
            this.MinimizeButton.BackgroundImage = global::Borrowing_System.Properties.Resources.Minimize_Icon;
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(1491, 7);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(22, 22);
            this.MinimizeButton.TabIndex = 11;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.DarkRed;
            this.CloseButton.BackgroundImage = global::Borrowing_System.Properties.Resources.Exit_Icon;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(1527, 6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(22, 22);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // loginBTN
            // 
            this.loginBTN.BackColor = System.Drawing.Color.Transparent;
            this.loginBTN.FlatAppearance.BorderSize = 0;
            this.loginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBTN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBTN.Location = new System.Drawing.Point(1119, 519);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(191, 49);
            this.loginBTN.TabIndex = 12;
            this.loginBTN.Text = "LOGIN";
            this.loginBTN.UseVisualStyleBackColor = false;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // usernameTxtbx
            // 
            this.usernameTxtbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.usernameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.usernameTxtbx.Location = new System.Drawing.Point(1080, 339);
            this.usernameTxtbx.Name = "usernameTxtbx";
            this.usernameTxtbx.Size = new System.Drawing.Size(309, 28);
            this.usernameTxtbx.TabIndex = 13;
            // 
            // passwordTxtbx
            // 
            this.passwordTxtbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.passwordTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.passwordTxtbx.Location = new System.Drawing.Point(1080, 441);
            this.passwordTxtbx.Name = "passwordTxtbx";
            this.passwordTxtbx.Size = new System.Drawing.Size(309, 28);
            this.passwordTxtbx.TabIndex = 14;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Borrowing_System.Properties.Resources.Login_Page;
            this.ClientSize = new System.Drawing.Size(1556, 850);
            this.Controls.Add(this.passwordTxtbx);
            this.Controls.Add(this.usernameTxtbx);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginPage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginPage_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginPage_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.TextBox usernameTxtbx;
        private System.Windows.Forms.TextBox passwordTxtbx;
    }
}