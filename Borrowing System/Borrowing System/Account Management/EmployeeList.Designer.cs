namespace Borrowing_System.Account_Management
{
    partial class EmployeeList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.passwordTxtbx = new System.Windows.Forms.TextBox();
            this.usernameTxtbx = new System.Windows.Forms.TextBox();
            this.minitialTxtbx = new System.Windows.Forms.TextBox();
            this.fnameTxtbx = new System.Windows.Forms.TextBox();
            this.personIDTxtbx = new System.Windows.Forms.TextBox();
            this.positionCmbx = new System.Windows.Forms.ComboBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.createBTN = new System.Windows.Forms.Button();
            this.lnameTxtbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // passwordTxtbx
            // 
            this.passwordTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtbx.Location = new System.Drawing.Point(203, 149);
            this.passwordTxtbx.Name = "passwordTxtbx";
            this.passwordTxtbx.Size = new System.Drawing.Size(151, 19);
            this.passwordTxtbx.TabIndex = 49;
            // 
            // usernameTxtbx
            // 
            this.usernameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtbx.Location = new System.Drawing.Point(203, 77);
            this.usernameTxtbx.Name = "usernameTxtbx";
            this.usernameTxtbx.Size = new System.Drawing.Size(151, 19);
            this.usernameTxtbx.TabIndex = 48;
            // 
            // minitialTxtbx
            // 
            this.minitialTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minitialTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minitialTxtbx.Location = new System.Drawing.Point(20, 221);
            this.minitialTxtbx.MaxLength = 1;
            this.minitialTxtbx.Multiline = true;
            this.minitialTxtbx.Name = "minitialTxtbx";
            this.minitialTxtbx.Size = new System.Drawing.Size(153, 20);
            this.minitialTxtbx.TabIndex = 46;
            // 
            // fnameTxtbx
            // 
            this.fnameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fnameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTxtbx.Location = new System.Drawing.Point(20, 149);
            this.fnameTxtbx.Multiline = true;
            this.fnameTxtbx.Name = "fnameTxtbx";
            this.fnameTxtbx.Size = new System.Drawing.Size(153, 20);
            this.fnameTxtbx.TabIndex = 45;
            // 
            // personIDTxtbx
            // 
            this.personIDTxtbx.BackColor = System.Drawing.Color.White;
            this.personIDTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personIDTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personIDTxtbx.Location = new System.Drawing.Point(20, 76);
            this.personIDTxtbx.Multiline = true;
            this.personIDTxtbx.Name = "personIDTxtbx";
            this.personIDTxtbx.ReadOnly = true;
            this.personIDTxtbx.Size = new System.Drawing.Size(153, 20);
            this.personIDTxtbx.TabIndex = 44;
            // 
            // positionCmbx
            // 
            this.positionCmbx.BackColor = System.Drawing.Color.White;
            this.positionCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionCmbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.positionCmbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionCmbx.FormattingEnabled = true;
            this.positionCmbx.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.positionCmbx.Location = new System.Drawing.Point(203, 217);
            this.positionCmbx.Name = "positionCmbx";
            this.positionCmbx.Size = new System.Drawing.Size(152, 28);
            this.positionCmbx.TabIndex = 54;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.clearBtn.ForeColor = System.Drawing.Color.Black;
            this.clearBtn.Location = new System.Drawing.Point(77, 349);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(70, 41);
            this.clearBtn.TabIndex = 53;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.updateBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBTN.FlatAppearance.BorderSize = 0;
            this.updateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.updateBTN.ForeColor = System.Drawing.Color.Black;
            this.updateBTN.Location = new System.Drawing.Point(227, 349);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(70, 41);
            this.updateBTN.TabIndex = 51;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = false;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // createBTN
            // 
            this.createBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.createBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createBTN.FlatAppearance.BorderSize = 0;
            this.createBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.createBTN.ForeColor = System.Drawing.Color.Black;
            this.createBTN.Location = new System.Drawing.Point(152, 349);
            this.createBTN.Name = "createBTN";
            this.createBTN.Size = new System.Drawing.Size(70, 41);
            this.createBTN.TabIndex = 50;
            this.createBTN.Text = "Add";
            this.createBTN.UseVisualStyleBackColor = false;
            this.createBTN.Click += new System.EventHandler(this.createBTN_Click);
            // 
            // lnameTxtbx
            // 
            this.lnameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lnameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameTxtbx.Location = new System.Drawing.Point(20, 290);
            this.lnameTxtbx.Multiline = true;
            this.lnameTxtbx.Name = "lnameTxtbx";
            this.lnameTxtbx.Size = new System.Drawing.Size(153, 20);
            this.lnameTxtbx.TabIndex = 47;
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Borrowing_System.Properties.Resources.EmploeeListPanel__374x422___1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.passwordTxtbx);
            this.Controls.Add(this.usernameTxtbx);
            this.Controls.Add(this.minitialTxtbx);
            this.Controls.Add(this.fnameTxtbx);
            this.Controls.Add(this.personIDTxtbx);
            this.Controls.Add(this.positionCmbx);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.createBTN);
            this.Controls.Add(this.lnameTxtbx);
            this.DoubleBuffered = true;
            this.Name = "EmployeeList";
            this.Size = new System.Drawing.Size(374, 422);
            this.Load += new System.EventHandler(this.EmployeeList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTxtbx;
        private System.Windows.Forms.TextBox usernameTxtbx;
        private System.Windows.Forms.TextBox minitialTxtbx;
        private System.Windows.Forms.TextBox fnameTxtbx;
        private System.Windows.Forms.TextBox personIDTxtbx;
        private System.Windows.Forms.ComboBox positionCmbx;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button createBTN;
        private System.Windows.Forms.TextBox lnameTxtbx;
    }
}
