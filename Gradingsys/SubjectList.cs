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
    public partial class SubjectList : Form
    {
        SqlConnection cn = new SqlConnection(Properties.Settings.Default.Connection);
        DataHelper db = new DataHelper();

        public SubjectList()
        {
            InitializeComponent();
        }

        private void TeacherAddUpdate_Load(object sender, EventArgs e)
        {
            LoadSubjectList();
        }

        public void LoadSubjectList()
        {
            string Query = "SELECT * " +
                           "FROM SubjectsTable " +
                           "WHERE SubjectName LIKE '%" + textBox1.Text + "%' " +
                           "ORDER BY SubjectName ASC";

            DataTable dt = db.ExecuteQuery(Query);

            dataGridView1.DataSource = dt;

            dataGridView1.ClearSelection();
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            SubjectAddUpdate SubjectAddUpdateForm = new SubjectAddUpdate();
            SubjectAddUpdateForm.Command = "Add Subject";
            SubjectAddUpdateForm.SubjectListForm = this;
            dataGridView1.ClearSelection();
            SubjectAddUpdateForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SubjectAddUpdate SubjectAddUpdateForm = new SubjectAddUpdate();
            SubjectAddUpdateForm.Command = "Update Subject";
            SubjectAddUpdateForm.SubjectListForm = this;
            SubjectAddUpdateForm.SubjectID = dataGridView1.SelectedRows[0].Cells["SubjectID"].Value.ToString();
            dataGridView1.ClearSelection();
            SubjectAddUpdateForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete selected Subject?", "Delete Subject", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string Query = "DELETE FROM SubjectsTable WHERE SubjectID = '" + dataGridView1.SelectedRows[0].Cells["SubjectID"].Value.ToString() + "'";

                db.ExecuteQuery(Query);

                MessageBox.Show("Subject Successfully Deleted!");
                LoadSubjectList();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = (dataGridView1.SelectedRows.Count > 0);
            btnEdit.Enabled = (dataGridView1.SelectedRows.Count > 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadSubjectList();
        }
    }
}
