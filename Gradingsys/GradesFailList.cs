using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gradingsys
{
    public partial class GradesFailList : Form
    {
        SqlConnection cn = new SqlConnection(Properties.Settings.Default.Connection);
        DataHelper db = new DataHelper();

        public string TEACHERID = string.Empty;

        public GradesFailList()
        {
            InitializeComponent();
        }

        private void TeacherAddUpdate_Load(object sender, EventArgs e)
        {
            LoadStudentList();
        }

        public void LoadStudentList()
        {
            string Query = "SELECT A.StudentID, " + 
	                           "(B.LastName + ', ' + B.FirstName + ' ' + B.MiddleName) AS 'FullName', " + 
	                           "B.Year, " + 
	                           "B.Section, " + 
	                           "D.SubjectName AS 'Subject', " + 
	                           "A.First, " + 
	                           "A.Second, " + 
	                           "A.Third, " + 
	                           "A.Fourth, " +
                               "A.Final, " +
                               "(CASE WHEN A.Final < 75 THEN 'Fail' ELSE 'Pass' END) AS 'Remarks' " + 
                           "FROM GradesTable A " + 
                           "LEFT JOIN StudentInformationTable B " + 
                           "ON B.StudentID = A.StudentID " + 
                           "LEFT JOIN TeachersTable C " + 
                           "ON C.TeacherID = A.TeacherID " + 
                           "LEFT JOIN SubjectsTable D " +
                           "ON D.SubjectID = C.SubjectID " + 
                           "WHERE C.TeacherID = " + TEACHERID + " " +
                           "AND A.Final < 75 " +
                           "AND (B.FirstName LIKE '%" + textBox1.Text + "%' " +
                           "OR B.LastName LIKE '%" + textBox1.Text + "%' " +
                           "OR (B.FirstName + ' ' + B.LastName) LIKE '%" + textBox1.Text + "%' " +
                           "OR (B.LastName + ' ' + B.FirstName) LIKE '%" + textBox1.Text + "%' " +
                           "OR D.SubjectName LIKE '%" + textBox1.Text + "%') " +
                           "ORDER BY B.LastName ASC";

            DataTable dt = db.ExecuteQuery(Query);

            dataGridView1.DataSource = dt;

            dataGridView1.ClearSelection();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadStudentList();
        }  

        private void txtFirst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }

            else
            {

                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtSecond_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }

            else
            {

                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtThird_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }

            else
            {

                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtFourth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }

            else
            {

                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
    }
}
