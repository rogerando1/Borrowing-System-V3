using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borrowing_System.Account_Management
{
    public partial class StudentList : UserControl
    {
        public StudentList()
        {
            InitializeComponent();
        }

        public void updateStudentList()
        {
            firstnameTxtbx.Text = AccountManagementPage.studentFirstName;
            middleinitialTxtbx.Text = AccountManagementPage.studentMiddleInitial;
            lastnameTxtbx.Text = AccountManagementPage.studentLastName;
            studentIDTxtbx.Text = AccountManagementPage.studentId;
            courseTxtbx.Text = AccountManagementPage.studentProgram;
            yearlevelTxtbx.Text = AccountManagementPage.studentYearLevel;
        }
    }
}
