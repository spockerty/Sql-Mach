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
    public partial class StudentAddUpdate : Form
    {
        DataHelper db = new DataHelper();

        public StudentList StudentListForm;
        public string Command = "Add Student";
        public string StudentID = string.Empty;

        public StudentAddUpdate()
        {
            InitializeComponent();
        }

        private void StudentAddUpdate_Load(object sender, EventArgs e)
        {
            if (Command == "Update Student")
            {
                LoadStudentInformation();
            }
        }

        private void LoadStudentInformation()
        {
            string Query = "SELECT * " +
                           "FROM StudentInformationTable " +
                           "WHERE StudentID = '" + StudentID + "'";

            DataTable dt = db.ExecuteQuery(Query);

            if (dt.Rows.Count > 0)
            {
                txtStudentID.Text = StudentID;
                txtFirstName.Text = dt.Rows[0]["FirstName"].ToString();
                txtMiddleName.Text = dt.Rows[0]["MiddleName"].ToString();
                txtLastName.Text = dt.Rows[0]["LastName"].ToString();
                cboGender.SelectedItem = dt.Rows[0]["Gender"].ToString();
                txtAddress.Text = dt.Rows[0]["Address"].ToString();
                cboYear.SelectedItem = dt.Rows[0]["Year"].ToString();
                cboSection.SelectedItem = dt.Rows[0]["Section"].ToString();
                txtContactNo.Text = dt.Rows[0]["ContactNo"].ToString();
                txtParentName.Text = dt.Rows[0]["ParentName"].ToString();
                txtStudentID.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show("Please indicate First Name");
                txtStudentID.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtFirstName.Text))

            {
                MessageBox.Show("Please indicate First Name");
                txtFirstName.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtMiddleName.Text))
            {
                MessageBox.Show("Please indicate Middle Name");
                txtMiddleName.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please indicate Last Name");
                txtLastName.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtParentName.Text))
            {
                MessageBox.Show("Please indicate Parent Name");
                txtParentName.Focus();
            }
            else if (string.IsNullOrWhiteSpace(cboGender.Text))
            {
                MessageBox.Show("Please indicate Gender");
                cboGender.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please indicate Address");
                txtAddress.Focus();
            }
            else if (string.IsNullOrWhiteSpace(cboYear.Text))
            {
                MessageBox.Show("Please indicate Year");
                cboYear.Focus();
            }
            else if (string.IsNullOrWhiteSpace(cboSection.Text))
            {
                MessageBox.Show("Please indicate Section");
                cboSection.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtContactNo.Text))
            {
                MessageBox.Show("Please indicate Contact Number");
                txtContactNo.Focus();
            }
            else if (Command == "Update Student")
            {
                //@kuroNeko UPDATE...
                string updateQuery =
                            " UPDATE " +
                            "       StudentInformationTable " +
                            " SET " +
                            "       StudentID = '" + txtStudentID.Text + "'" +
                            "       ,FirstName = '" + txtFirstName.Text + "'" +
                            "       ,MiddleName = '" + txtMiddleName.Text + "'" +
                            "       ,LastName = '" + txtLastName.Text + "'" +
                            "       ,Gender = '" + cboGender.SelectedItem.ToString() + "'" +
                            "       ,Address = '" + txtAddress.Text + "'" +
                            "       ,ParentName = '" + txtParentName.Text + "'" +
                            "       ,ContactNo = '" + txtContactNo.Text + "'" +
                            "       ,Year = '" + cboYear.SelectedItem.ToString() + "'" +
                            "       ,Section = '" + cboSection.SelectedItem.ToString() + "'" +
                            " WHERE " +
                            "       StudentID = '" + txtStudentID.Text + "'";

                db.ExecuteQuery(updateQuery);

                MessageBox.Show("Student Successfully Updated!");
                StudentListForm.LoadStudentList();
                Close();
            }
            else
            {
                string DeleteQuery = "DELETE FROM StudentInformationTable WHERE StudentID = '" + txtStudentID.Text + "'";
                db.ExecuteQuery(DeleteQuery);

                string Query = "INSERT INTO StudentInformationTable VALUES (" +
                               "'" + txtStudentID.Text + "', " +
                               "'" + txtFirstName.Text + "', " +
                               "'" + txtMiddleName.Text + "', " +
                               "'" + txtLastName.Text + "', " +
                               "'" + cboGender.SelectedItem.ToString() + "', " +
                               "'" + txtAddress.Text + "', " +
                               "'" + txtParentName.Text + "', " +
                               "'" + txtContactNo.Text + "', " +
                               "'" + cboYear.SelectedItem.ToString() + "', " +
                               "'" + cboSection.SelectedItem.ToString() + "')";
                db.ExecuteQuery(Query);

                string InsertGradesQuery = "INSERT INTO GradesTable " +
                                           "SELECT A.StudentID, " +
                                               "C.TeacherID, " +
                                               "0.00 AS 'First', " +
                                               "0.00 AS 'Second', " +
                                               "0.00 AS 'Third', " +
                                               "0.00 AS 'Fourth', " +
                                               "0.00 AS 'Final' " +
                                           "FROM StudentInformationTable A " +
                                           "LEFT JOIN SubjectsTable B " +
                                           "ON B.Year = A.Year " +
                                           "LEFT JOIN TeachersTable C " +
                                           "ON C.SubjectID = B.SubjectID " +
                                           "WHERE B.Year = '" + cboYear.SelectedItem.ToString() + "' " +
                                           "AND A.StudentID = '" + txtStudentID.Text + "'";
                db.ExecuteQuery(InsertGradesQuery);

                MessageBox.Show("Student Successfully Added!");
                StudentListForm.LoadStudentList();
                Close();
            }
        }
    }
}
