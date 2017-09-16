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
    public partial class StudentList : Form
    {
        SqlConnection cn = new SqlConnection(Properties.Settings.Default.Connection);
        DataHelper db = new DataHelper();

        public StudentList()
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
                                "(A.LastName + ', ' + A.FirstName + ' ' + A.MiddleName) AS 'FullName', " +
                                "A.Gender, " +
                                "A.Address, " +
                                "A.ParentName, " +
                                "A.ContactNo, " +
                                "A.Year, " +
                                "A.Section " +
                           "FROM StudentInformationTable A " +
                           "WHERE A.FirstName LIKE '%" + textBox1.Text + "%' " +
                           "OR A.MiddleName LIKE '%" + textBox1.Text + "%' " +
                           "OR A.LastName LIKE '%" + textBox1.Text + "%' " +
                           "OR (A.LastName + ', ' + A.FirstName + ' ' + A.MiddleName) LIKE '%" + textBox1.Text + "%' " +
                           "OR (A.FirstName + ' ' + A.LastName) LIKE '%" + textBox1.Text + "%' " + 
                           "ORDER BY A.LastName ASC";

            DataTable dt = db.ExecuteQuery(Query);

            dataGridView1.DataSource = dt;

            dataGridView1.ClearSelection();

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnViewStudentProfile.Enabled = false;
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            StudentAddUpdate StudentAddUpdateForm = new StudentAddUpdate();
            StudentAddUpdateForm.Command = "Add New Student";
            StudentAddUpdateForm.StudentListForm = this;
            dataGridView1.ClearSelection();
            StudentAddUpdateForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            StudentAddUpdate StudentAddUpdateForm = new StudentAddUpdate();
            StudentAddUpdateForm.Command = "Update Student";
            StudentAddUpdateForm.StudentListForm = this;
            StudentAddUpdateForm.StudentID = dataGridView1.SelectedRows[0].Cells["StudentID"].Value.ToString();
            dataGridView1.ClearSelection();
            StudentAddUpdateForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete selected Student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string Query = "DELETE FROM StudentInformationTable WHERE StudentID = '" + dataGridView1.SelectedRows[0].Cells["StudentID"].Value.ToString() + "'";

                db.ExecuteQuery(Query);

                MessageBox.Show("Student Successfully Deleted!");
                LoadStudentList();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = (dataGridView1.SelectedRows.Count > 0);
            btnEdit.Enabled = (dataGridView1.SelectedRows.Count > 0);
            btnViewStudentProfile.Enabled = (dataGridView1.SelectedRows.Count > 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadStudentList();
        }

        private void btnViewStudentProfile_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                StudentProfile StudentProfileForm = new StudentProfile();
                StudentProfileForm.StudentID = dataGridView1.SelectedRows[0].Cells["StudentID"].Value.ToString();
                StudentProfileForm.ShowDialog();
            }
        }
    }
}
