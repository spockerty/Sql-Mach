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
    public partial class SubjectAddUpdate : Form
    {
        DataHelper db = new DataHelper();

        public SubjectList SubjectListForm;
        public string Command = "Add Subject";
        public string SubjectID = string.Empty;

        public SubjectAddUpdate()
        {
            InitializeComponent();
        }

        private void SubjectAddUpdate_Load(object sender, EventArgs e)
        {
            txtSubjectID.Text = "Auto Generated";
            if (Command == "Update Subject")
            {
                LoadSubjectInformation();
            }
        }

        private string GetLastSubjectID()
        {
            string Query = "SELECT * " +
                           "FROM SubjectsTable " +
                           "ORDER BY SubjectID DESC";

            DataTable dt = db.ExecuteQuery(Query);

            if (dt.Rows.Count > 0)
            {
                return (Convert.ToInt32(dt.Rows[0]["SubjectID"].ToString()) + 1).ToString();
            }
            else
            {
                return "1";
            }
        }

        private void LoadSubjectInformation()
        {
            string Query = "SELECT * " +
                           "FROM SubjectsTable " +
                           "WHERE SubjectID = " + SubjectID;

            DataTable dt = db.ExecuteQuery(Query);

            if (dt.Rows.Count > 0)
            {
                txtSubjectID.Text = SubjectID;
                txtSubjectName.Text = dt.Rows[0]["SubjectName"].ToString();
                cboYear.SelectedItem = dt.Rows[0]["Year"].ToString();
                txtSubjectID.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string Query = string.Empty;


            if (string.IsNullOrWhiteSpace(txtSubjectID.Text))
            {
                MessageBox.Show("Please indicate Subject Id");
                txtSubjectID.Focus();

            }
        else  if (string.IsNullOrWhiteSpace(txtSubjectName.Text))
            {
                MessageBox.Show("Please indicate First Name");
                txtSubjectName.Focus();

            }
            else if (string.IsNullOrWhiteSpace(cboYear.Text))
            {
                MessageBox.Show("Please indicate Year");
                cboYear.Focus();

            }
             else if (Command == "Add Subject")
                {
                Query = "SELECT * FROM SubjectsTable WHERE SubjectName = '" + txtSubjectName.Text + "'";
                if (db.ExecuteQuery(Query).Rows.Count > 0)
                {
                    MessageBox.Show("Subject Already Exist");
                }
                else
                {

                    Query = "INSERT INTO SubjectsTable VALUES (" +
                                "'" + txtSubjectName.Text + "', " +
                                "'" + cboYear.SelectedItem.ToString() + "')";
                    db.ExecuteQuery(Query);
                    MessageBox.Show("Subject Successfully Added!");

                    SubjectListForm.LoadSubjectList();
                    Close();
                }
            }
            else if (Command == "Update Subject")
            {
                Query = "UPDATE SubjectsTable " +
                        "SET SubjectName = '" + txtSubjectName.Text + "', " +
                            "Year = '" + cboYear.SelectedItem.ToString() + "' " + 
                        "WHERE SubjectID = " + SubjectID;
                db.ExecuteQuery(Query);
                MessageBox.Show("Subject Successfully Updated!");

                SubjectListForm.LoadSubjectList();
                Close();
            }
        }
    }
}
