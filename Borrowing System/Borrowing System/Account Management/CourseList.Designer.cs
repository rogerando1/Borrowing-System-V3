namespace Borrowing_System.Account_Management
{
    partial class CourseList
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
            this.coursetimeTxtbx = new System.Windows.Forms.TextBox();
            this.sectionTxtbx = new System.Windows.Forms.TextBox();
            this.coursenameTxtbx = new System.Windows.Forms.TextBox();
            this.courseIDTxtbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // coursetimeTxtbx
            // 
            this.coursetimeTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.coursetimeTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursetimeTxtbx.Location = new System.Drawing.Point(72, 411);
            this.coursetimeTxtbx.Name = "coursetimeTxtbx";
            this.coursetimeTxtbx.Size = new System.Drawing.Size(382, 22);
            this.coursetimeTxtbx.TabIndex = 11;
            // 
            // sectionTxtbx
            // 
            this.sectionTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sectionTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionTxtbx.Location = new System.Drawing.Point(72, 321);
            this.sectionTxtbx.Name = "sectionTxtbx";
            this.sectionTxtbx.Size = new System.Drawing.Size(382, 22);
            this.sectionTxtbx.TabIndex = 8;
            // 
            // coursenameTxtbx
            // 
            this.coursenameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.coursenameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursenameTxtbx.Location = new System.Drawing.Point(72, 238);
            this.coursenameTxtbx.Name = "coursenameTxtbx";
            this.coursenameTxtbx.Size = new System.Drawing.Size(382, 22);
            this.coursenameTxtbx.TabIndex = 7;
            // 
            // courseIDTxtbx
            // 
            this.courseIDTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseIDTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIDTxtbx.Location = new System.Drawing.Point(72, 152);
            this.courseIDTxtbx.Name = "courseIDTxtbx";
            this.courseIDTxtbx.Size = new System.Drawing.Size(382, 22);
            this.courseIDTxtbx.TabIndex = 6;
            // 
            // CourseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Borrowing_System.Properties.Resources._3_1_;
            this.Controls.Add(this.coursetimeTxtbx);
            this.Controls.Add(this.sectionTxtbx);
            this.Controls.Add(this.coursenameTxtbx);
            this.Controls.Add(this.courseIDTxtbx);
            this.Name = "CourseList";
            this.Size = new System.Drawing.Size(528, 580);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox coursetimeTxtbx;
        private System.Windows.Forms.TextBox sectionTxtbx;
        private System.Windows.Forms.TextBox coursenameTxtbx;
        private System.Windows.Forms.TextBox courseIDTxtbx;
    }
}
