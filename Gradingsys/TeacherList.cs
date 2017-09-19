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
    public partial class TeacherList : Form
    {
        SqlConnection cn = new SqlConnection(Properties.Settings.Default.Connection);
        DataHelper db = new DataHelper();

        ///// <summary>
        ///// I put it here so that you can rearrange it yourself...
        ///// 
        ///// After clicking the update/Add new Teacher Button, then cancel...
        ///// the datagridview1 selection clears its selection...
        ///// and the update/Add new Teacher button doesnt disable...
        ///// so if user click the "Update button again", it will fail.
        ///// 
        ///// @kuroNeko 
        ///// </summary>
        //DataGridViewCell dgvCell;

        //public void RestoreDGView()
        //{
        //    //dataGridView1
        //    //    .Rows[dgvCell.RowIndex].Cells[dgvCell.ColumnIndex].Selected = true;
        //}


        public TeacherList()
        {
            InitializeComponent();
        }

        private void TeacherAddUpdate_Load(object sender, EventArgs e)
        {
            LoadTeacherList();
        }

        public void LoadTeacherList()
        {
            string _Query =
                         " SELECT " +
                         "      A.TeacherID " +
                         "      ,(C.FirstName + ' ' + C.LastName) as 'FullName' " +
                         "      ,A.SubjectID" + //Only needed, if you really need to sort by Last Name
                         "      ,B.SubjectName" +
                         "      ,C.UserName " +
                         "      ,C.PassWord " +
                         " FROM " +
                         "      TeacherSubjectsTable A " +
                         " LEFT JOIN " +
                         "      SubjectsTable B " +
                         " ON " +
                         "      A.SubjectID = B.SubjectID " +
                         " LEFT JOIN " +
                         "      TeachersTable C " +
                         " ON " +
                         "      A.TeacherId = C.TeacherID " +
                         "          WHERE " +
                         "              C.FirstName LIKE '%" + textBox1.Text + "%' " +
                         "          OR" +
                         "              C.LastName LIKE '%" + textBox1.Text + "%' " +
                         "          OR " +
                         "              (C.FirstName + ' ' + C.LastName) LIKE '%" + textBox1.Text + "%' " +
                         "          OR " +
                         "              (C.FirstName + ' ' + C.LastName) LIKE '%" + textBox1.Text + "%' " +
                         "          OR " +
                         "              B.SubjectName LIKE '%" + textBox1.Text + "%' " +
                         " ORDER BY " +
                         "      C.LastName " +
                         " ASC";

            DataTable dt = db.ExecuteQuery(_Query);

            dataGridView1.DataSource = dt;
            //dataGridView1.Columns["SubjectID"].Visible = true;

            dataGridView1.ClearSelection();
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            TeacherAddUpdate TeacherAddUpdateForm = new TeacherAddUpdate();
            TeacherAddUpdateForm.Command = "Add Teacher";
            TeacherAddUpdateForm.TeacherListForm = this;

            ////@kuroNeko
            //dgvCell = dataGridView1.CurrentCell;

            //dataGridView1.ClearSelection();
            TeacherAddUpdateForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TeacherAddUpdate TeacherAddUpdateForm = new TeacherAddUpdate();
            TeacherAddUpdateForm.Command = "Update Teacher";
            TeacherAddUpdateForm.TeacherListForm = this;
            //TeacherAddUpdateForm.dataRow = dataGridView1.Rows[dataGridView1.CurrentRow.Index];
            TeacherAddUpdateForm.TeacherID = dataGridView1.SelectedRows[0].Cells["TeacherID"].Value.ToString();
            TeacherAddUpdateForm.SubjectID = dataGridView1.SelectedRows[0].Cells["SubjectID"].Value.ToString(); //@kuroNeko Access data of hidden column
            TeacherAddUpdateForm.SubjectName = dataGridView1.SelectedRows[0].Cells["SubjectName"].Value.ToString();

            ////@kuroNeko
            //dgvCell = dataGridView1.CurrentCell;

            //dataGridView1.ClearSelection();
            TeacherAddUpdateForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete selected Teacher?", "Delete Teacher", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string Query = "DELETE " +
                               "FROM " +
                               "        TeacherSubjectsTable " +
                               " WHERE " +
                               "        TeacherID = " + dataGridView1.SelectedRows[0].Cells["TeacherID"].Value.ToString() +
                               " AND" +
                               "        SubjectId = " + dataGridView1.SelectedRows[0].Cells["SubjectID"].Value.ToString();

                db.ExecuteQuery(Query);

                MessageBox.Show("Teacher Successfully Deleted!");
                LoadTeacherList();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = (dataGridView1.SelectedRows.Count > 0);
            btnEdit.Enabled = (dataGridView1.SelectedRows.Count > 0);
            addNewSubBtn.Enabled = (dataGridView1.SelectedRows.Count == 1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadTeacherList();
        }

        /// <summary>
        /// @kuroNeko
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNewSubBtn_Click(object sender, EventArgs e)
        {
            TeacherNewSubjectAdd teachNewSubject = new TeacherNewSubjectAdd();
            teachNewSubject.dataRow = dataGridView1.Rows[dataGridView1.CurrentRow.Index];
            teachNewSubject.ShowDialog();
        }
    }
}
