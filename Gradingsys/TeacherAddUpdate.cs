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
    public partial class TeacherAddUpdate : Form
    {
        DataHelper db = new DataHelper();

        public TeacherList TeacherListForm;
        public string Command = "Add Teacher";
        public string TeacherID = string.Empty;
        public string SubjectDet = string.Empty;

        List<string> SubjectIDs = new List<string>();

        public TeacherAddUpdate()
        {
            InitializeComponent();
        }

        private void TeacherAddUpdate_Load(object sender, EventArgs e)
        {
           // LoadSubjects();
            txtTeacherID.Text = "Auto Generated";
            if (Command == "Update Teacher")
            {
                LoadSubjects(true);
                LoadTeacherInformation();
            }
        }

        private string GetLastTeacherID()
        {
            string Query = "SELECT * " +
                           "FROM TeachersTable " +
                           "ORDER BY TeacherID DESC";

            DataTable dt = db.ExecuteQuery(Query);

            if (dt.Rows.Count > 0)
            {
                return (Convert.ToInt32(dt.Rows[0]["TeacherID"].ToString()) + 1).ToString();
            }
            else
            {
                return "1";
            }
        }

        private void LoadTeacherInformation()
        {
            string Query = "SELECT * " +
                           "FROM TeachersTable " +
                           "WHERE TeacherID = " + TeacherID;

            DataTable dt = db.ExecuteQuery(Query);

            if (dt.Rows.Count > 0)
            {
                txtTeacherID.Text = TeacherID;
                txtFirstName.Text = dt.Rows[0]["FirstName"].ToString();
                txtLastName.Text = dt.Rows[0]["LastName"].ToString();
                cboSubject.SelectedIndex = SubjectIDs.IndexOf(dt.Rows[0]["SubjectID"].ToString()); // cboSubject.Items.IndexOf(dt.Rows[0]["SubjectID"].ToString());
                txtUsername.Text = dt.Rows[0]["Username"].ToString();
                txtPassword.Text = dt.Rows[0]["Password"].ToString();
                txtTeacherID.Enabled = false;
                
            }
        }

        private void LoadSubjects(bool isUpdate)
        {
            string showAvailSubQuery =
                  " SELECT  " +
                  "       subjectId" +
                  "       ,subjectName " +
                  " FROM " +
                  "       SubjectsTable t1 " +
                  " WHERE NOT EXISTS" +
                  "           ( SELECT " +
                  "                   subjectId" +
                  "             FROM " +
                  "                   TeachersTable t2" +
                  "             WHERE " +
                  "                   t1.subjectId = t2.subjectID " +
                  "           ) " +
                  " ORDER BY " +
                  "        subjectName " +
                  " ASC ";

            if (isUpdate)
            {
                showAvailSubQuery = "SELECT * " +
                         "FROM SubjectsTable " +
                         "ORDER BY SubjectName ASC";

            }

            DataTable dt = db.ExecuteQuery(showAvailSubQuery);

            if (dt.Rows.Count > 0)
            {
                cboSubject.Items.Clear();
                SubjectIDs.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cboSubject.Items.Add(dt.Rows[i]["SubjectName"].ToString());
                    SubjectIDs.Add(dt.Rows[i]["SubjectID"].ToString());
                }
            }
            //else
            //{
            //    //@kuroNeko
            //    cboSubject.Items.Add(SubjectDet);
            //    cboSubject.SelectedIndex = 0;
            //    MessageBox.Show("All SUBJECTS are filled." + SubjectDet);
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string Query = string.Empty;
            
            if (Command == "Add Teacher")
            {
                Query = "SELECT * FROM TeachersTable WHERE SubjectID = " + SubjectIDs[cboSubject.SelectedIndex];
                if (db.ExecuteQuery(Query).Rows.Count > 0)
                {
                    MessageBox.Show("The selected subject was already obtained by another teacher");
                }
                else
                {
                    Query = "INSERT INTO TeachersTable VALUES (" +
                                "'" + txtFirstName.Text + "', " +
                                "'" + txtLastName.Text + "', " +
                                " " + SubjectIDs[cboSubject.SelectedIndex] + " , " +
                                "'" + txtUsername.Text + "', " +
                                "'" + txtPassword.Text + "')";
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
                                               "WHERE B.SubjectID = " + SubjectIDs[cboSubject.SelectedIndex] + " " +
                                               "AND C.TeacherID = (SELECT TOP 1 TeacherID FROM TeachersTable WHERE Username = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "')";
                    db.ExecuteQuery(InsertGradesQuery);

                    MessageBox.Show("Teacher Successfully Added!");

                    TeacherListForm.LoadTeacherList();
                    Close();
                }
            }
            else if (Command == "Update Teacher")
            {
                Query = "UPDATE TeachersTable " +
                        "SET FirstName = '" + txtFirstName.Text + "', " +
                            "LastName = '" + txtLastName.Text + "', " +
                            "SubjectID = " + SubjectIDs[cboSubject.SelectedIndex] + ", " +
                            "Username = '" + txtUsername.Text + "', " +
                            "Password = '" + txtPassword.Text + "' " +
                        "WHERE TeacherID = " + TeacherID;
                db.ExecuteQuery(Query);

                MessageBox.Show("Teacher Successfully Updated!");

                TeacherListForm.LoadTeacherList();
                Close();
            }
        }

        ///// <summary>
        ///// [Edit by: Kuroneko]
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btnCancel_Click(object sender, EventArgs e)
        //{
        //    TeacherListForm.RestoreDGView();
        //}
    }
}
