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
    public partial class InstructorList : UserControl
    {
        public InstructorList()
        {
            InitializeComponent();
        }

        public void updateInstructorList()
        {
            instructorIDTxtbx.Text = AccountManagementPage.instructorId;
            firstnameTxtbx.Text = AccountManagementPage.instructorFirstName;
            middleinitialTxtbx.Text = AccountManagementPage.instructorMiddleInitial;
            lastnameTxtbx.Text = AccountManagementPage.instructorLastName;
        }
    }
}
