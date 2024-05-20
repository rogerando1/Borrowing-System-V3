namespace Borrowing_System.Account_Management
{
    partial class ScheduleList
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
            this.components = new System.ComponentModel.Container();
            this.courseIDTxtbx = new System.Windows.Forms.TextBox();
            this.coursenameTxtbx = new System.Windows.Forms.TextBox();
            this.sectionTxtbx = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.createBTN = new System.Windows.Forms.Button();
            this.instructornameTxtbx = new System.Windows.Forms.TextBox();
            this.instructorIDTxtbx = new System.Windows.Forms.TextBox();
            this.instructorTimer = new System.Windows.Forms.Timer(this.components);
            this.courseTimer = new System.Windows.Forms.Timer(this.components);
            this.coursenameTimer = new System.Windows.Forms.Timer(this.components);
            this.starttimeTxtbx = new System.Windows.Forms.DateTimePicker();
            this.endtimeTxtbx = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // courseIDTxtbx
            // 
            this.courseIDTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseIDTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.courseIDTxtbx.Location = new System.Drawing.Point(43, 257);
            this.courseIDTxtbx.Multiline = true;
            this.courseIDTxtbx.Name = "courseIDTxtbx";
            this.courseIDTxtbx.Size = new System.Drawing.Size(234, 28);
            this.courseIDTxtbx.TabIndex = 25;
            this.courseIDTxtbx.TextChanged += new System.EventHandler(this.courseIDTxtbx_TextChanged);
            // 
            // coursenameTxtbx
            // 
            this.coursenameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.coursenameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.coursenameTxtbx.Location = new System.Drawing.Point(43, 342);
            this.coursenameTxtbx.Multiline = true;
            this.coursenameTxtbx.Name = "coursenameTxtbx";
            this.coursenameTxtbx.Size = new System.Drawing.Size(393, 28);
            this.coursenameTxtbx.TabIndex = 26;
            this.coursenameTxtbx.TextChanged += new System.EventHandler(this.coursenameTxtbx_TextChanged);
            // 
            // sectionTxtbx
            // 
            this.sectionTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sectionTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.sectionTxtbx.Location = new System.Drawing.Point(43, 426);
            this.sectionTxtbx.Multiline = true;
            this.sectionTxtbx.Name = "sectionTxtbx";
            this.sectionTxtbx.Size = new System.Drawing.Size(100, 28);
            this.sectionTxtbx.TabIndex = 27;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.Black;
            this.clearBtn.Location = new System.Drawing.Point(84, 487);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(96, 44);
            this.clearBtn.TabIndex = 57;
            this.clearBtn.Text = " Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.deleteBTN.FlatAppearance.BorderSize = 0;
            this.deleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBTN.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold);
            this.deleteBTN.ForeColor = System.Drawing.Color.Black;
            this.deleteBTN.Location = new System.Drawing.Point(288, 487);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(110, 44);
            this.deleteBTN.TabIndex = 56;
            this.deleteBTN.Text = "Remove";
            this.deleteBTN.UseVisualStyleBackColor = false;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // createBTN
            // 
            this.createBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(215)))), ((int)(((byte)(174)))));
            this.createBTN.FlatAppearance.BorderSize = 0;
            this.createBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBTN.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold);
            this.createBTN.ForeColor = System.Drawing.Color.Black;
            this.createBTN.Location = new System.Drawing.Point(186, 487);
            this.createBTN.Name = "createBTN";
            this.createBTN.Size = new System.Drawing.Size(96, 44);
            this.createBTN.TabIndex = 54;
            this.createBTN.Text = "Add";
            this.createBTN.UseVisualStyleBackColor = false;
            this.createBTN.Click += new System.EventHandler(this.createBTN_Click);
            // 
            // instructornameTxtbx
            // 
            this.instructornameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instructornameTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.instructornameTxtbx.Location = new System.Drawing.Point(48, 173);
            this.instructornameTxtbx.Multiline = true;
            this.instructornameTxtbx.Name = "instructornameTxtbx";
            this.instructornameTxtbx.Size = new System.Drawing.Size(336, 28);
            this.instructornameTxtbx.TabIndex = 60;
            this.instructornameTxtbx.TextChanged += new System.EventHandler(this.instructornameTxtbx_TextChanged);
            // 
            // instructorIDTxtbx
            // 
            this.instructorIDTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instructorIDTxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.instructorIDTxtbx.Location = new System.Drawing.Point(46, 91);
            this.instructorIDTxtbx.Multiline = true;
            this.instructorIDTxtbx.Name = "instructorIDTxtbx";
            this.instructorIDTxtbx.Size = new System.Drawing.Size(238, 28);
            this.instructorIDTxtbx.TabIndex = 61;
            this.instructorIDTxtbx.TextChanged += new System.EventHandler(this.instructorIDTxtbx_TextChanged);
            // 
            // instructorTimer
            // 
            this.instructorTimer.Interval = 500;
            this.instructorTimer.Tick += new System.EventHandler(this.instructorTimer_Tick);
            // 
            // courseTimer
            // 
            this.courseTimer.Interval = 500;
            this.courseTimer.Tick += new System.EventHandler(this.courseTimer_Tick);
            // 
            // coursenameTimer
            // 
            this.coursenameTimer.Interval = 500;
            this.coursenameTimer.Tick += new System.EventHandler(this.coursenameTimer_Tick);
            // 
            // starttimeTxtbx
            // 
            this.starttimeTxtbx.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starttimeTxtbx.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.starttimeTxtbx.Location = new System.Drawing.Point(173, 427);
            this.starttimeTxtbx.Name = "starttimeTxtbx";
            this.starttimeTxtbx.ShowUpDown = true;
            this.starttimeTxtbx.Size = new System.Drawing.Size(113, 25);
            this.starttimeTxtbx.TabIndex = 62;
            this.starttimeTxtbx.ValueChanged += new System.EventHandler(this.starttimeTxtbx_ValueChanged);
            // 
            // endtimeTxtbx
            // 
            this.endtimeTxtbx.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endtimeTxtbx.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endtimeTxtbx.Location = new System.Drawing.Point(323, 426);
            this.endtimeTxtbx.Name = "endtimeTxtbx";
            this.endtimeTxtbx.ShowUpDown = true;
            this.endtimeTxtbx.Size = new System.Drawing.Size(113, 25);
            this.endtimeTxtbx.TabIndex = 63;
            // 
            // ScheduleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Borrowing_System.Properties.Resources._111;
            this.Controls.Add(this.endtimeTxtbx);
            this.Controls.Add(this.starttimeTxtbx);
            this.Controls.Add(this.instructorIDTxtbx);
            this.Controls.Add(this.instructornameTxtbx);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.createBTN);
            this.Controls.Add(this.sectionTxtbx);
            this.Controls.Add(this.coursenameTxtbx);
            this.Controls.Add(this.courseIDTxtbx);
            this.DoubleBuffered = true;
            this.Name = "ScheduleList";
            this.Size = new System.Drawing.Size(484, 580);
            this.Load += new System.EventHandler(this.InstructorList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox courseIDTxtbx;
        private System.Windows.Forms.TextBox coursenameTxtbx;
        private System.Windows.Forms.TextBox sectionTxtbx;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button createBTN;
        private System.Windows.Forms.TextBox instructornameTxtbx;
        private System.Windows.Forms.TextBox instructorIDTxtbx;
        private System.Windows.Forms.Timer instructorTimer;
        private System.Windows.Forms.Timer courseTimer;
        private System.Windows.Forms.Timer coursenameTimer;
        private System.Windows.Forms.DateTimePicker starttimeTxtbx;
        private System.Windows.Forms.DateTimePicker endtimeTxtbx;
    }
}
