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
    public partial class StudentProfile : Form
    {
        DataHelper db = new DataHelper();

        public string StudentID = string.Empty;

        public StudentProfile()
        {
            InitializeComponent();
        }

        private void StudentProfile_Load(object sender, EventArgs e)
        {
            LoadStudentInformation();
        }

        private void LoadStudentInformation()
        {
            string Query = "SELECT * " +
                           "FROM StudentInformationTable " +
                           "WHERE StudentID = '" + StudentID + "'";

            DataTable dt = db.ExecuteQuery(Query);

            if (dt.Rows.Count > 0)
            {
                lblStudentID.Text = StudentID;
                lblStudentName.Text = dt.Rows[0]["LastName"].ToString() + ", " + dt.Rows[0]["FirstName"].ToString() + " " + dt.Rows[0]["MiddleName"].ToString();
                lblProfile.Text = dt.Rows[0]["FirstName"].ToString() + "'s Profile";
                lblSection.Text = dt.Rows[0]["Section"].ToString();
                lblGender.Text = dt.Rows[0]["Gender"].ToString();
                cboYear.SelectedItem = dt.Rows[0]["Year"].ToString();
            }
        }

        private void LoadGrades()
        {
            string Query = "SELECT C.SubjectName, " +
                               "(B.FirstName + ' ' + B.LastName) AS 'TeacherName',  " +
                               "A.First, " +
                               "A.Second, " +
                               "A.Third, " +
                               "A.Fourth, " +
                               "A.Final, " +
                               "(CASE WHEN A.Final < 75 THEN 'Fail' ELSE 'Pass' END) AS 'Remarks' " +
                           "FROM GradesTable A " +
                           "LEFT JOIN TeachersTable B " +
                           "ON B.TeacherID = A.TeacherID " +
                           "LEFT JOIN SubjectsTable C " +
                           "ON C.SubjectID = B.SubjectID " +
                           "LEFT JOIN StudentInformationTable D " +
                           "ON D.StudentID = A.StudentID " + 
                           "WHERE A.StudentID = '" + StudentID + "' " +
                           "AND C.SubjectName IS NOT NULL " +
                           "AND D.Year = '" + cboYear.SelectedItem.ToString() + "' ";

            DataTable dt = db.ExecuteQuery(Query);

            dataGridView1.DataSource = dt;
            dataGridView1.ClearSelection();
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrades();
        }
    }
}
