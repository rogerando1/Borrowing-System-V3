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
            this.lastname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // instructorID
            // 
            this.instructorID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instructorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorID.Location = new System.Drawing.Point(158, 165);
            this.instructorID.Name = "instructorID";
            this.instructorID.Size = new System.Drawing.Size(213, 22);
            this.instructorID.TabIndex = 6;
            // 
            // firstname
            // 
            this.firstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(158, 247);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(213, 22);
            this.firstname.TabIndex = 7;
            // 
            // middleinitial
            // 
            this.middleinitial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.middleinitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleinitial.Location = new System.Drawing.Point(158, 332);
            this.middleinitial.Name = "middleinitial";
            this.middleinitial.Size = new System.Drawing.Size(213, 22);
            this.middleinitial.TabIndex = 8;
            // 
            // lastname
            // 
            this.lastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(158, 415);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(213, 22);
            this.lastname.TabIndex = 11;
            // 
            // InstructorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Borrowing_System.Properties.Resources._2_2_;
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.middleinitial);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.instructorID);
            this.Name = "InstructorList";
            this.Size = new System.Drawing.Size(528, 580);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox instructorID;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox middleinitial;
        private System.Windows.Forms.TextBox lastname;
    }
}
