using System;
using System.Windows.Forms;

namespace Borrowing_System
{
    public partial class AddNotes : Form
    {
        public static string Notes { get; set; }
        public static string Quantity { get; set; }

        public AddNotes()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (notesTxt.Text == "")
            {
                if (MessageBox.Show("You have not added a note. Do you want to proceed?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Notes = "No Notes Added";
                    Quantity = quantityTxt.Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                }
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to submit this note?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Notes = notesTxt.Text;
                    Quantity = quantityTxt.Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            notesTxt.Clear();
            quantityTxt.Value = 0;
        }
    }
}
