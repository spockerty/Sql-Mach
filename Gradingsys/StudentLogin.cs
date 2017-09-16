using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gradingsys
{
    public partial class StudentLogin : Form
    {
        DataHelper db = new DataHelper();

        public StudentLogin()
        {
            InitializeComponent();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show("Please enter your Student ID", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string Query = "SELECT * " +
                               "FROM StudentInformationTable " +
                               "WHERE StudentID = '" + txtStudentID.Text + "'";

                if (db.ExecuteQuery(Query).Rows.Count > 0)
                {

                    StudentProfile StudentProfileForm = new StudentProfile();
                    StudentProfileForm.StudentID = txtStudentID.Text;
                    StudentProfileForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Student ID does not exist", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
