namespace Borrowing_System.Account_Management
{
    partial class StudentList
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
            this.firstnameTxtbx = new System.Windows.Forms.TextBox();
            this.middleinitialTxtbx = new System.Windows.Forms.TextBox();
            this.lastnameTxtbx = new System.Windows.Forms.TextBox();
            this.studentIDTxtbx = new System.Windows.Forms.TextBox();
            this.courseTxtbx = new System.Windows.Forms.TextBox();
            this.yearlevelTxtbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firstnameTxtbx
            // 
            this.firstnameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstnameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameTxtbx.Location = new System.Drawing.Point(34, 92);
            this.firstnameTxtbx.Multiline = true;
            this.firstnameTxtbx.Name = "firstnameTxtbx";
            this.firstnameTxtbx.Size = new System.Drawing.Size(213, 25);
            this.firstnameTxtbx.TabIndex = 0;
            // 
            // middleinitialTxtbx
            // 
            this.middleinitialTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.middleinitialTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleinitialTxtbx.Location = new System.Drawing.Point(34, 178);
            this.middleinitialTxtbx.Multiline = true;
            this.middleinitialTxtbx.Name = "middleinitialTxtbx";
            this.middleinitialTxtbx.Size = new System.Drawing.Size(213, 28);
            this.middleinitialTxtbx.TabIndex = 1;
            // 
            // lastnameTxtbx
            // 
            this.lastnameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastnameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameTxtbx.Location = new System.Drawing.Point(34, 262);
            this.lastnameTxtbx.Multiline = true;
            this.lastnameTxtbx.Name = "lastnameTxtbx";
            this.lastnameTxtbx.Size = new System.Drawing.Size(213, 26);
            this.lastnameTxtbx.TabIndex = 2;
            // 
            // studentIDTxtbx
            // 
            this.studentIDTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentIDTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDTxtbx.Location = new System.Drawing.Point(292, 95);
            this.studentIDTxtbx.Name = "studentIDTxtbx";
            this.studentIDTxtbx.Size = new System.Drawing.Size(157, 22);
            this.studentIDTxtbx.TabIndex = 3;
            // 
            // courseTxtbx
            // 
            this.courseTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTxtbx.Location = new System.Drawing.Point(292, 177);
            this.courseTxtbx.Name = "courseTxtbx";
            this.courseTxtbx.Size = new System.Drawing.Size(157, 22);
            this.courseTxtbx.TabIndex = 4;
            // 
            // yearlevelTxtbx
            // 
            this.yearlevelTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearlevelTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlevelTxtbx.Location = new System.Drawing.Point(292, 266);
            this.yearlevelTxtbx.Name = "yearlevelTxtbx";
            this.yearlevelTxtbx.Size = new System.Drawing.Size(157, 22);
            this.yearlevelTxtbx.TabIndex = 5;
            // 
            // StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Borrowing_System.Properties.Resources._2_4_;
            this.Controls.Add(this.yearlevelTxtbx);
            this.Controls.Add(this.courseTxtbx);
            this.Controls.Add(this.studentIDTxtbx);
            this.Controls.Add(this.lastnameTxtbx);
            this.Controls.Add(this.middleinitialTxtbx);
            this.Controls.Add(this.firstnameTxtbx);
            this.Name = "StudentList";
            this.Size = new System.Drawing.Size(484, 580);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstnameTxtbx;
        private System.Windows.Forms.TextBox middleinitialTxtbx;
        private System.Windows.Forms.TextBox lastnameTxtbx;
        private System.Windows.Forms.TextBox studentIDTxtbx;
        private System.Windows.Forms.TextBox courseTxtbx;
        private System.Windows.Forms.TextBox yearlevelTxtbx;
    }
}
