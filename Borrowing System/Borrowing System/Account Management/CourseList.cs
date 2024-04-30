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
    public partial class CourseList : UserControl
    {
        public CourseList()
        {
            InitializeComponent();
        }

        public void updateCouseList()
        {
            courseIDTxtbx.Text = AccountManagementPage.courseID;
            coursenameTxtbx.Text = AccountManagementPage.courseName;
            sectionTxtbx.Text = AccountManagementPage.courseSection;
            coursetimeTxtbx.Text = AccountManagementPage.courseTime;

        }
    }
}
