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
    public partial class TeacherNewSubjectAdd : Form
    {
        private string _teacherId;
        private string _teacherName;
        private string _username;
        private string _password;
        public DataGridViewRow dataRow;

        SqlConnection cn = new SqlConnection(Properties.Settings.Default.Connection);
        DataHelper db = new DataHelper();

        public TeacherNewSubjectAdd()
        {
            InitializeComponent();
        }

        private void TeacherNewSubjectAdd_Load(object sender, EventArgs e)
        {
            this._teacherId = dataRow.Cells[0].Value.ToString();
            this._teacherName = dataRow.Cells[1].Value.ToString();
            this._username = dataRow.Cells[3].Value.ToString();
            this._password = dataRow.Cells[4].Value.ToString();

            this.txtTeacherID.Text = this._teacherId;
            this.txtTeacherName.Text = this._teacherName;
            this.txtUsername.Text = this._username;
            this.txtPassword.Text = this._password;

            ShowCurrentSubjects();
            ShowAvailSubjects();
        }

        private void ShowCurrentSubjects()
        {
            string showCurrSubQuery =
                " SELECT " +
                "       A.SubjectID " +
                "       ,sub.SubjectName " +
                "       ,sub.Year " +
                " FROM " +
                "       TeachersTable A " +
                " LEFT JOIN " +
                "       SubjectsTable sub " +
                " ON " +
                "       A.SubjectId = sub.SubjectId " +
                " WHERE " +
                "       A.TeacherID  = '" + this._teacherId + "'";

            DataTable dt = db.ExecuteQuery(showCurrSubQuery);

            dataGridView1.DataSource = dt;

            dataGridView1.ClearSelection();

        }

        private void ShowAvailSubjects()
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

            DataTable dt = db.ExecuteQuery(showAvailSubQuery);
            

            if (dt.Rows.Count > 0)
            {
                cboSubject.Items.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cboSubject.Items.Add(dt.Rows[i][1].ToString());
                }
            }
        }

        private void AddNewSubject()
        {

            string showAvailSubQuery =
               " INSERT INTO " +
               "        teachersTable " +
               "        (  " +
               "            TeacherID" +
               "            ,FirstName" +
               "            ,LastName" +
               "            ,SubjectID" +
               "            ,UserName" +
               "            ,Password" +
               "        )" +
               " VALUES " +
               "        (" +
               "         ";
    

            DataTable dt = db.ExecuteQuery(showAvailSubQuery);
        }

        private void cboSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddSubject.Enabled = true;
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {

        }


    }
}
