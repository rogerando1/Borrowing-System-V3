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
            this.instructorIDTxtbx = new System.Windows.Forms.TextBox();
            this.firstnameTxtbx = new System.Windows.Forms.TextBox();
            this.middleinitialTxtbx = new System.Windows.Forms.TextBox();
            this.lastnameTxtbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // instructorIDTxtbx
            // 
            this.instructorIDTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instructorIDTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorIDTxtbx.Location = new System.Drawing.Point(158, 165);
            this.instructorIDTxtbx.Name = "instructorIDTxtbx";
            this.instructorIDTxtbx.Size = new System.Drawing.Size(213, 22);
            this.instructorIDTxtbx.TabIndex = 6;
            // 
            // firstnameTxtbx
            // 
            this.firstnameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstnameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameTxtbx.Location = new System.Drawing.Point(158, 247);
            this.firstnameTxtbx.Name = "firstnameTxtbx";
            this.firstnameTxtbx.Size = new System.Drawing.Size(213, 22);
            this.firstnameTxtbx.TabIndex = 7;
            // 
            // middleinitialTxtbx
            // 
            this.middleinitialTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.middleinitialTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleinitialTxtbx.Location = new System.Drawing.Point(158, 332);
            this.middleinitialTxtbx.Name = "middleinitialTxtbx";
            this.middleinitialTxtbx.Size = new System.Drawing.Size(213, 22);
            this.middleinitialTxtbx.TabIndex = 8;
            // 
            // lastnameTxtbx
            // 
            this.lastnameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastnameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameTxtbx.Location = new System.Drawing.Point(158, 415);
            this.lastnameTxtbx.Name = "lastnameTxtbx";
            this.lastnameTxtbx.Size = new System.Drawing.Size(213, 22);
            this.lastnameTxtbx.TabIndex = 11;
            // 
            // InstructorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Borrowing_System.Properties.Resources._2_2_;
            this.Controls.Add(this.lastnameTxtbx);
            this.Controls.Add(this.middleinitialTxtbx);
            this.Controls.Add(this.firstnameTxtbx);
            this.Controls.Add(this.instructorIDTxtbx);
            this.Name = "InstructorList";
            this.Size = new System.Drawing.Size(528, 580);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox instructorIDTxtbx;
        private System.Windows.Forms.TextBox firstnameTxtbx;
        private System.Windows.Forms.TextBox middleinitialTxtbx;
        private System.Windows.Forms.TextBox lastnameTxtbx;
    }
}
