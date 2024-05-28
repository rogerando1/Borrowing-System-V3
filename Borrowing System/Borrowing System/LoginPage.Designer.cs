namespace Borrowing_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.loginBTN = new System.Windows.Forms.Button();
            this.usernameTxtbx = new System.Windows.Forms.TextBox();
            this.passwordTxtbx = new System.Windows.Forms.TextBox();
            this.unhideButton = new System.Windows.Forms.Button();
            this.hideButton = new System.Windows.Forms.Button();
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
            this.MinimizeButton.Location = new System.Drawing.Point(1252, 5);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(22, 22);
            this.MinimizeButton.TabIndex = 5;
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
            this.CloseButton.Location = new System.Drawing.Point(1288, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(22, 22);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // loginBTN
            // 
            this.loginBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(208)))), ((int)(((byte)(155)))));
            this.loginBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(208)))), ((int)(((byte)(155)))));
            this.loginBTN.FlatAppearance.BorderSize = 0;
            this.loginBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(208)))), ((int)(((byte)(155)))));
            this.loginBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(208)))), ((int)(((byte)(155)))));
            this.loginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBTN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBTN.Location = new System.Drawing.Point(964, 482);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(135, 44);
            this.loginBTN.TabIndex = 4;
            this.loginBTN.Text = "LOGIN";
            this.loginBTN.UseVisualStyleBackColor = false;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // usernameTxtbx
            // 
            this.usernameTxtbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.usernameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtbx.Location = new System.Drawing.Point(942, 327);
            this.usernameTxtbx.Multiline = true;
            this.usernameTxtbx.Name = "usernameTxtbx";
            this.usernameTxtbx.Size = new System.Drawing.Size(214, 20);
            this.usernameTxtbx.TabIndex = 0;
            this.usernameTxtbx.UseSystemPasswordChar = true;
            this.usernameTxtbx.TextChanged += new System.EventHandler(this.usernameTxtbx_TextChanged);
            this.usernameTxtbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameTxtbx_KeyDown);
            // 
            // passwordTxtbx
            // 
            this.passwordTxtbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.passwordTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtbx.Location = new System.Drawing.Point(942, 414);
            this.passwordTxtbx.Name = "passwordTxtbx";
            this.passwordTxtbx.Size = new System.Drawing.Size(214, 19);
            this.passwordTxtbx.TabIndex = 1;
            this.passwordTxtbx.UseSystemPasswordChar = true;
            this.passwordTxtbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTxtbx_KeyDown);
            // 
            // unhideButton
            // 
            this.unhideButton.BackgroundImage = global::Borrowing_System.Properties.Resources.eye1;
            this.unhideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.unhideButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unhideButton.FlatAppearance.BorderSize = 0;
            this.unhideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unhideButton.Location = new System.Drawing.Point(1111, 408);
            this.unhideButton.Name = "unhideButton";
            this.unhideButton.Size = new System.Drawing.Size(40, 30);
            this.unhideButton.TabIndex = 2;
            this.unhideButton.UseVisualStyleBackColor = true;
            this.unhideButton.Click += new System.EventHandler(this.unhideButton_Click);
            // 
            // hideButton
            // 
            this.hideButton.BackgroundImage = global::Borrowing_System.Properties.Resources.eye2;
            this.hideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hideButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideButton.FlatAppearance.BorderSize = 0;
            this.hideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideButton.Location = new System.Drawing.Point(1111, 405);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(44, 35);
            this.hideButton.TabIndex = 3;
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Borrowing_System.Properties.Resources.Loginpage__1320x770_;
            this.ClientSize = new System.Drawing.Size(1320, 770);
            this.Controls.Add(this.unhideButton);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.passwordTxtbx);
            this.Controls.Add(this.usernameTxtbx);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.CloseButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button unhideButton;
        private System.Windows.Forms.Button hideButton;
    }
}