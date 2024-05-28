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
            this.coursenameTxtbx = new System.Windows.Forms.TextBox();
            this.courseIDTxtbx = new System.Windows.Forms.TextBox();
            this.clearBTN = new System.Windows.Forms.Button();
            this.createBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coursenameTxtbx
            // 
            this.coursenameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.coursenameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursenameTxtbx.Location = new System.Drawing.Point(18, 150);
            this.coursenameTxtbx.Name = "coursenameTxtbx";
            this.coursenameTxtbx.Size = new System.Drawing.Size(337, 19);
            this.coursenameTxtbx.TabIndex = 7;
            // 
            // courseIDTxtbx
            // 
            this.courseIDTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseIDTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIDTxtbx.Location = new System.Drawing.Point(18, 77);
            this.courseIDTxtbx.Name = "courseIDTxtbx";
            this.courseIDTxtbx.Size = new System.Drawing.Size(155, 19);
            this.courseIDTxtbx.TabIndex = 6;
            // 
            // clearBTN
            // 
            this.clearBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.clearBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBTN.FlatAppearance.BorderSize = 0;
            this.clearBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.clearBTN.ForeColor = System.Drawing.Color.Black;
            this.clearBTN.Location = new System.Drawing.Point(189, 303);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(71, 40);
            this.clearBTN.TabIndex = 12;
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
            this.createBTN.Location = new System.Drawing.Point(114, 303);
            this.createBTN.Name = "createBTN";
            this.createBTN.Size = new System.Drawing.Size(71, 40);
            this.createBTN.TabIndex = 13;
            this.createBTN.Text = "Add";
            this.createBTN.UseVisualStyleBackColor = false;
            this.createBTN.Click += new System.EventHandler(this.createBTN_Click);
            // 
            // CourseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Borrowing_System.Properties.Resources.CourseListPanel__374x422_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.createBTN);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.coursenameTxtbx);
            this.Controls.Add(this.courseIDTxtbx);
            this.DoubleBuffered = true;
            this.Name = "CourseList";
            this.Size = new System.Drawing.Size(374, 422);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox coursenameTxtbx;
        private System.Windows.Forms.TextBox courseIDTxtbx;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Button createBTN;
    }
}
