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
    public partial class TeacherInputGrade : Form
    {
        SqlConnection cn = new SqlConnection(Properties.Settings.Default.Connection);

        public string TEACHERID = string.Empty;

        public TeacherInputGrade()
        {
            InitializeComponent();
        }

        private void TeacherAddUpdate_Load(object sender, EventArgs e)
        {
            LoadStudentList();
        }

        private void LoadStudentList()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();

            try
            {
                string Query = "SELECT A.Student_Id, " +
                                      "(B.Student_FirstName + ' ' + B.Student_LastName) AS 'StudentName', " + 
                                      "B.Year, " + 
                                      "B.Section, " +
                                      "A.FirstGrading, " +
                                      "A.SecondGrading, " +
                                      "A.ThirdGrading, " +
                                      "A.FourthGrading, " +
                                      "A.FinalGrade " + 
                               "FROM tblGrade A " +
                               "INNER JOIN tblStudent_Detail B " +
                               "ON B.Student_id = A.Student_Id " +
                               "WHERE A.Teacher_Id = " + TEACHERID + " " +
                               "ORDER BY B.Student_LastName ASC";

                SqlDataAdapter da = new SqlDataAdapter(Query, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();

            try
            {
                string Query = "";
                
                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Teacher Updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadStudentList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();

            try
            {
                string Query = "";

                SqlCommand cmd = new SqlCommand(Query, cn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Teacher Deleted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadStudentList(); 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFirst.Text = dataGridView1.Rows[e.RowIndex].Cells["FirstGrading"].Value.ToString();
            txtSecond.Text = dataGridView1.Rows[e.RowIndex].Cells["SecondGrading"].Value.ToString();
            txtThird.Text = dataGridView1.Rows[e.RowIndex].Cells["ThirdGrading"].Value.ToString();
            txtFourth.Text = dataGridView1.Rows[e.RowIndex].Cells["FourthGrading"].Value.ToString();
        }
    }
}
