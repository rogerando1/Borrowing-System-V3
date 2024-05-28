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
            this.updateBTN = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.createBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructorID
            // 
            this.instructorID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instructorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorID.Location = new System.Drawing.Point(109, 76);
            this.instructorID.Multiline = true;
            this.instructorID.Name = "instructorID";
            this.instructorID.Size = new System.Drawing.Size(155, 25);
            this.instructorID.TabIndex = 0;
            // 
            // firstname
            // 
            this.firstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(109, 149);
            this.firstname.Multiline = true;
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(155, 25);
            this.firstname.TabIndex = 1;
            // 
            // middleinitial
            // 
            this.middleinitial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.middleinitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleinitial.Location = new System.Drawing.Point(109, 221);
            this.middleinitial.MaxLength = 1;
            this.middleinitial.Multiline = true;
            this.middleinitial.Name = "middleinitial";
            this.middleinitial.Size = new System.Drawing.Size(155, 25);
            this.middleinitial.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 7;
            // 
            // lastname
            // 
            this.lastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(109, 290);
            this.lastname.Multiline = true;
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(155, 25);
            this.lastname.TabIndex = 3;
            // 
            // updateBTN
            // 
            this.updateBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.updateBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBTN.FlatAppearance.BorderSize = 0;
            this.updateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.updateBTN.ForeColor = System.Drawing.Color.Black;
            this.updateBTN.Location = new System.Drawing.Point(152, 350);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(70, 40);
            this.updateBTN.TabIndex = 5;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = false;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.clearBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBTN.FlatAppearance.BorderSize = 0;
            this.clearBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.clearBTN.ForeColor = System.Drawing.Color.Black;
            this.clearBTN.Location = new System.Drawing.Point(227, 350);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(70, 40);
            this.clearBTN.TabIndex = 6;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = false;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // createBTN
            // 
            this.createBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.createBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createBTN.FlatAppearance.BorderSize = 0;
            this.createBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.createBTN.ForeColor = System.Drawing.Color.Black;
            this.createBTN.Location = new System.Drawing.Point(77, 350);
            this.createBTN.Name = "createBTN";
            this.createBTN.Size = new System.Drawing.Size(70, 40);
            this.createBTN.TabIndex = 4;
            this.createBTN.Text = "Add";
            this.createBTN.UseVisualStyleBackColor = false;
            this.createBTN.Click += new System.EventHandler(this.createBTN_Click);
            // 
            // InstructorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(199)))), ((int)(((byte)(230)))));
            this.BackgroundImage = global::Borrowing_System.Properties.Resources.InstructorListPanel__374x422_;
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
            this.Size = new System.Drawing.Size(374, 422);
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
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Button createBTN;
    }
}
