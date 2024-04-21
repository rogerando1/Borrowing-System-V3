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
            this.deleteBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.createBTN = new System.Windows.Forms.Button();
            this.lnameTxtbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // passwordTxtbx
            // 
            this.passwordTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.passwordTxtbx.Location = new System.Drawing.Point(325, 237);
            this.passwordTxtbx.Name = "passwordTxtbx";
            this.passwordTxtbx.Size = new System.Drawing.Size(170, 23);
            this.passwordTxtbx.TabIndex = 49;
            // 
            // usernameTxtbx
            // 
            this.usernameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.usernameTxtbx.Location = new System.Drawing.Point(325, 154);
            this.usernameTxtbx.Name = "usernameTxtbx";
            this.usernameTxtbx.Size = new System.Drawing.Size(170, 23);
            this.usernameTxtbx.TabIndex = 48;
            // 
            // minitialTxtbx
            // 
            this.minitialTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minitialTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.minitialTxtbx.Location = new System.Drawing.Point(35, 324);
            this.minitialTxtbx.MaxLength = 1;
            this.minitialTxtbx.Name = "minitialTxtbx";
            this.minitialTxtbx.Size = new System.Drawing.Size(240, 23);
            this.minitialTxtbx.TabIndex = 46;
            // 
            // fnameTxtbx
            // 
            this.fnameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fnameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTxtbx.Location = new System.Drawing.Point(35, 237);
            this.fnameTxtbx.Name = "fnameTxtbx";
            this.fnameTxtbx.Size = new System.Drawing.Size(240, 23);
            this.fnameTxtbx.TabIndex = 45;
            // 
            // personIDTxtbx
            // 
            this.personIDTxtbx.BackColor = System.Drawing.Color.White;
            this.personIDTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personIDTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personIDTxtbx.Location = new System.Drawing.Point(35, 154);
            this.personIDTxtbx.Name = "personIDTxtbx";
            this.personIDTxtbx.ReadOnly = true;
            this.personIDTxtbx.Size = new System.Drawing.Size(139, 23);
            this.personIDTxtbx.TabIndex = 44;
            // 
            // positionCmbx
            // 
            this.positionCmbx.BackColor = System.Drawing.Color.White;
            this.positionCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionCmbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.positionCmbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionCmbx.FormattingEnabled = true;
            this.positionCmbx.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.positionCmbx.Location = new System.Drawing.Point(325, 318);
            this.positionCmbx.Name = "positionCmbx";
            this.positionCmbx.Size = new System.Drawing.Size(170, 33);
            this.positionCmbx.TabIndex = 54;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold);
            this.clearBtn.Location = new System.Drawing.Point(64, 484);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(96, 44);
            this.clearBtn.TabIndex = 53;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.deleteBTN.FlatAppearance.BorderSize = 0;
            this.deleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBTN.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold);
            this.deleteBTN.Location = new System.Drawing.Point(370, 484);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(96, 44);
            this.deleteBTN.TabIndex = 52;
            this.deleteBTN.Text = "Delete";
            this.deleteBTN.UseVisualStyleBackColor = false;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.updateBTN.FlatAppearance.BorderSize = 0;
            this.updateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBTN.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold);
            this.updateBTN.Location = new System.Drawing.Point(268, 484);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(96, 44);
            this.updateBTN.TabIndex = 51;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = false;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // createBTN
            // 
            this.createBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.createBTN.FlatAppearance.BorderSize = 0;
            this.createBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBTN.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold);
            this.createBTN.Location = new System.Drawing.Point(166, 484);
            this.createBTN.Name = "createBTN";
            this.createBTN.Size = new System.Drawing.Size(96, 44);
            this.createBTN.TabIndex = 50;
            this.createBTN.Text = "Create";
            this.createBTN.UseVisualStyleBackColor = false;
            this.createBTN.Click += new System.EventHandler(this.createBTN_Click);
            // 
            // lnameTxtbx
            // 
            this.lnameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lnameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lnameTxtbx.Location = new System.Drawing.Point(35, 410);
            this.lnameTxtbx.Name = "lnameTxtbx";
            this.lnameTxtbx.Size = new System.Drawing.Size(240, 23);
            this.lnameTxtbx.TabIndex = 47;
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Borrowing_System.Properties.Resources.acc_management_employee1;
            this.Controls.Add(this.passwordTxtbx);
            this.Controls.Add(this.usernameTxtbx);
            this.Controls.Add(this.minitialTxtbx);
            this.Controls.Add(this.fnameTxtbx);
            this.Controls.Add(this.personIDTxtbx);
            this.Controls.Add(this.positionCmbx);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.createBTN);
            this.Controls.Add(this.lnameTxtbx);
            this.Name = "EmployeeList";
            this.Size = new System.Drawing.Size(528, 580);
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
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button createBTN;
        private System.Windows.Forms.TextBox lnameTxtbx;
    }
}
