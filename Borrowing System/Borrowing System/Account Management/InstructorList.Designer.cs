namespace Borrowing_System.Account_Management
{
    partial class InstructorList
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
            this.instructorID = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.middleinitial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.createBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructorID
            // 
            this.instructorID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instructorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorID.Location = new System.Drawing.Point(94, 102);
            this.instructorID.Multiline = true;
            this.instructorID.Name = "instructorID";
            this.instructorID.Size = new System.Drawing.Size(297, 25);
            this.instructorID.TabIndex = 1;
            // 
            // firstname
            // 
            this.firstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(94, 188);
            this.firstname.Multiline = true;
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(297, 25);
            this.firstname.TabIndex = 3;
            // 
            // middleinitial
            // 
            this.middleinitial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.middleinitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleinitial.Location = new System.Drawing.Point(94, 273);
            this.middleinitial.MaxLength = 1;
            this.middleinitial.Multiline = true;
            this.middleinitial.Name = "middleinitial";
            this.middleinitial.Size = new System.Drawing.Size(297, 25);
            this.middleinitial.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 4;
            // 
            // lastname
            // 
            this.lastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(94, 359);
            this.lastname.MaxLength = 1;
            this.lastname.Multiline = true;
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(297, 25);
            this.lastname.TabIndex = 7;
            // 
            // deleteBTN
            // 
            this.deleteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.deleteBTN.FlatAppearance.BorderSize = 0;
            this.deleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBTN.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold);
            this.deleteBTN.ForeColor = System.Drawing.Color.Black;
            this.deleteBTN.Location = new System.Drawing.Point(351, 470);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(110, 48);
            this.deleteBTN.TabIndex = 61;
            this.deleteBTN.Text = "Remove";
            this.deleteBTN.UseVisualStyleBackColor = false;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.updateBTN.FlatAppearance.BorderSize = 0;
            this.updateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBTN.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold);
            this.updateBTN.ForeColor = System.Drawing.Color.Black;
            this.updateBTN.Location = new System.Drawing.Point(246, 470);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(99, 48);
            this.updateBTN.TabIndex = 60;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = false;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.clearBTN.FlatAppearance.BorderSize = 0;
            this.clearBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBTN.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold);
            this.clearBTN.ForeColor = System.Drawing.Color.Black;
            this.clearBTN.Location = new System.Drawing.Point(34, 470);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(100, 48);
            this.clearBTN.TabIndex = 59;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = false;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // createBTN
            // 
            this.createBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.createBTN.FlatAppearance.BorderSize = 0;
            this.createBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBTN.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold);
            this.createBTN.ForeColor = System.Drawing.Color.Black;
            this.createBTN.Location = new System.Drawing.Point(140, 470);
            this.createBTN.Name = "createBTN";
            this.createBTN.Size = new System.Drawing.Size(100, 48);
            this.createBTN.TabIndex = 58;
            this.createBTN.Text = "Add";
            this.createBTN.UseVisualStyleBackColor = false;
            this.createBTN.Click += new System.EventHandler(this.createBTN_Click);
            // 
            // InstructorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.BackgroundImage = global::Borrowing_System.Properties.Resources.instructor1;
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.createBTN);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.middleinitial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.instructorID);
            this.DoubleBuffered = true;
            this.Name = "InstructorList";
            this.Size = new System.Drawing.Size(484, 580);
            this.Load += new System.EventHandler(this.InstructorList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox instructorID;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox middleinitial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Button createBTN;
    }
}
