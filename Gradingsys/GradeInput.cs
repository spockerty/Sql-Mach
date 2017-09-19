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
    public partial class GradeInput : Form
    {
        SqlConnection cn = new SqlConnection(Properties.Settings.Default.Connection);
        DataHelper db = new DataHelper();

        public string TEACHERID = string.Empty;

        public GradeInput()
        {
            InitializeComponent();
        }

        private void TeacherAddUpdate_Load(object sender, EventArgs e)
        {
            LoadStudentList();
            LoadCurrentSubject();
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
                      //     "LEFT JOIN TeachersTable C " +  @kuroNeko
                           "LEFT JOIN TeacherSubjectsTable C " +
                           "ON C.TeacherID = A.TeacherID " + 
                           "LEFT JOIN SubjectsTable D " +
                           "ON D.SubjectID = C.SubjectID " + 
                           "WHERE C.TeacherID = " + TEACHERID + " " +
                           "AND (B.FirstName LIKE '%" + textBox1.Text + "%' " +
                           "OR B.LastName LIKE '%" + textBox1.Text + "%' " +
                           "OR (B.FirstName + ' ' + B.LastName) LIKE '%" + textBox1.Text + "%' " +
                           "OR (B.LastName + ' ' + B.FirstName) LIKE '%" + textBox1.Text + "%' " +
                           "OR D.SubjectName LIKE '%" + textBox1.Text + "%') " +
                           "GROUP BY " +
                           "D.SubjectName, A.StudentID, " + 
                               "B.LastName,B.FirstName, B.MiddleName, " +
                               "B.Year, " +
                               "B.Section, " +
                               " " +
                               "A.First, " +
                               "A.Second, " +
                               "A.Third, " +
                               "A.Fourth, " +
                               "A.Final" +
                           " ORDER BY B.LastName ASC";

            DataTable dt = db.ExecuteQuery(Query);

            dataGridView1.DataSource = dt;

            dataGridView1.ClearSelection();

            GradesPanel.Enabled = false;
            btnSaveGrade.Enabled = false;
            txtFirst.Clear();
            txtSecond.Clear();
            txtThird.Clear();
            txtFourth.Clear();
        }

        private void LoadCurrentSubject()
        {
            String Query =
                 " SELECT " +
                "       A.SubjectID " +
                "       ,sub.SubjectName " +
                "       ,sub.Year " +
                " FROM " +
                "       TeacherSubjectsTable A " +
                " LEFT JOIN " +
                "       SubjectsTable sub " +
                " ON " +
                "       A.SubjectId = sub.SubjectId " +
                " WHERE " +
                "       A.TeacherID  = '" + TEACHERID + "'";

            Console.WriteLine(TEACHERID);

            DataTable dt = db.ExecuteQuery(Query);

            if (dt.Rows.Count > 0)
            {
                cboSubject.Items.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cboSubject.Items.Add(dt.Rows[i]["SubjectName"].ToString());
                }
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GradesPanel.Enabled = (dataGridView1.SelectedRows.Count > 0);
            btnSaveGrade.Enabled = (dataGridView1.SelectedRows.Count > 0);

            txtFirst.Text = dataGridView1.Rows[e.RowIndex].Cells["First"].Value.ToString();
            txtSecond.Text = dataGridView1.Rows[e.RowIndex].Cells["Second"].Value.ToString();
            txtThird.Text = dataGridView1.Rows[e.RowIndex].Cells["Third"].Value.ToString();
            txtFourth.Text = dataGridView1.Rows[e.RowIndex].Cells["Fourth"].Value.ToString();

            GradesPanel.Enabled = true;
            btnSaveGrade.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadStudentList();
        }

        private void btnSaveGrade_Click(object sender, EventArgs e)
        {
            try
            {
                double FirstInput = Math.Round(Convert.ToDouble(txtFirst.Text),2);
                double SecondInput = Math.Round(Convert.ToDouble(txtSecond.Text),2);
                double ThirdInput = Math.Round(Convert.ToDouble(txtThird.Text),2);
                double FourthInput = Math.Round(Convert.ToDouble(txtFourth.Text), 2);
                double Final = Math.Round((FirstInput + SecondInput + ThirdInput + FourthInput) / 4,2);

                string Query = "UPDATE GradesTable " +
                               "SET First = " + FirstInput + ", " +
                                   "Second = " + SecondInput + ", " +
                                   "Third = " + ThirdInput + ", " +
                                   "Fourth = " + FourthInput + ", " +
                                   "Final = " + Final + " " +
                               "WHERE StudentID = '" + dataGridView1.SelectedRows[0].Cells["StudentID"].Value.ToString() + "' " +
                               "AND TeacherID = " + TEACHERID;

                db.ExecuteQuery(Query);

                MessageBox.Show("Grades Input was successfully saved!");
                LoadStudentList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Print the contents.
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        Bitmap bitmap;
       private void btnprint_Click(object sender, EventArgs e)
       {
           //Add a Panel control.
           Panel panel = new Panel();
           this.Controls.Add(panel);

           //Create a Bitmap of size same as that of the Form.
           Graphics grp = panel.CreateGraphics();
           Size formSize = this.ClientSize;
          bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
           grp = Graphics.FromImage(bitmap);

           //Copy screen area that that the Panel covers.
           Point panelLocation = PointToScreen(panel.Location);
           grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);

           //Show the Print Preview Dialog.
           printPreviewDialog1.Document = printDocument1;
           printPreviewDialog1.PrintPreviewControl.Zoom = 1;
           printPreviewDialog1.ShowDialog();
       }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GradesPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
