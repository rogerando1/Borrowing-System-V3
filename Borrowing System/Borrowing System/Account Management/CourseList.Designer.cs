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
            this.clearBTN = new System.Windows.Forms.Button();
            this.createBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coursetimeTxtbx
            // 
            this.coursetimeTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.coursetimeTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursetimeTxtbx.Location = new System.Drawing.Point(269, 266);
            this.coursetimeTxtbx.Name = "coursetimeTxtbx";
            this.coursetimeTxtbx.Size = new System.Drawing.Size(182, 22);
            this.coursetimeTxtbx.TabIndex = 11;
            // 
            // sectionTxtbx
            // 
            this.sectionTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sectionTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionTxtbx.Location = new System.Drawing.Point(36, 267);
            this.sectionTxtbx.Name = "sectionTxtbx";
            this.sectionTxtbx.Size = new System.Drawing.Size(210, 22);
            this.sectionTxtbx.TabIndex = 8;
            // 
            // coursenameTxtbx
            // 
            this.coursenameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.coursenameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursenameTxtbx.Location = new System.Drawing.Point(45, 177);
            this.coursenameTxtbx.Name = "coursenameTxtbx";
            this.coursenameTxtbx.Size = new System.Drawing.Size(393, 22);
            this.coursenameTxtbx.TabIndex = 7;
            // 
            // courseIDTxtbx
            // 
            this.courseIDTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseIDTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIDTxtbx.Location = new System.Drawing.Point(36, 92);
            this.courseIDTxtbx.Name = "courseIDTxtbx";
            this.courseIDTxtbx.Size = new System.Drawing.Size(210, 22);
            this.courseIDTxtbx.TabIndex = 6;
            // 
            // clearBTN
            // 
            this.clearBTN.ForeColor = System.Drawing.Color.Black;
            this.clearBTN.Location = new System.Drawing.Point(97, 400);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(75, 23);
            this.clearBTN.TabIndex = 12;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = true;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // createBTN
            // 
            this.createBTN.ForeColor = System.Drawing.Color.Black;
            this.createBTN.Location = new System.Drawing.Point(208, 400);
            this.createBTN.Name = "createBTN";
            this.createBTN.Size = new System.Drawing.Size(75, 23);
            this.createBTN.TabIndex = 13;
            this.createBTN.Text = "Create";
            this.createBTN.UseVisualStyleBackColor = true;
            this.createBTN.Click += new System.EventHandler(this.createBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.ForeColor = System.Drawing.Color.Black;
            this.deleteBTN.Location = new System.Drawing.Point(321, 400);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(75, 23);
            this.deleteBTN.TabIndex = 14;
            this.deleteBTN.Text = "Delete";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // CourseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Borrowing_System.Properties.Resources.courselistUI1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.createBTN);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.coursetimeTxtbx);
            this.Controls.Add(this.sectionTxtbx);
            this.Controls.Add(this.coursenameTxtbx);
            this.Controls.Add(this.courseIDTxtbx);
            this.Name = "CourseList";
            this.Size = new System.Drawing.Size(484, 580);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox coursetimeTxtbx;
        private System.Windows.Forms.TextBox sectionTxtbx;
        private System.Windows.Forms.TextBox coursenameTxtbx;
        private System.Windows.Forms.TextBox courseIDTxtbx;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Button createBTN;
        private System.Windows.Forms.Button deleteBTN;
    }
}
