using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gradingsys
{
    public partial class Dashboard : Form
    {
        public string USERNAME = string.Empty;
        public string PASSWORD = string.Empty;
        public string TEACHERID = string.Empty;

        public Login LoginForm;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentList StudentListForm = new StudentList();
            StudentListForm.ShowDialog();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentList StudentListForm = new StudentList();
            StudentListForm.Shown += new EventHandler(StudentListForm.btnAdd_Click);
            StudentListForm.ShowDialog();
        }

        private void listOfTeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherList TeacherListForm = new TeacherList();
            TeacherListForm.ShowDialog();
        }

        private void addNewTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherList TeacherListForm = new TeacherList();
            TeacherListForm.Shown += new EventHandler(TeacherListForm.btnAdd_Click);
            TeacherListForm.ShowDialog();
        }

        private void listOfSubjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubjectList SubjectListForm = new SubjectList();
            SubjectListForm.ShowDialog();
        }

        private void addNewSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubjectList SubjectListForm = new SubjectList();
            SubjectListForm.Shown += new EventHandler(SubjectListForm.btnAdd_Click);
            SubjectListForm.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm.Visible = true;
            Close();
        }

        private void gradesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnGrades_Click(object sender, EventArgs e)
        {

        }

        private void listOfFailedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GradesFailList GradesFailListForm = new GradesFailList();
            GradesFailListForm.TEACHERID = TEACHERID;
            GradesFailListForm.ShowDialog();
        }

        private void listOfPassedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GradesPassList GradesPassListForm = new GradesPassList();
            GradesPassListForm.TEACHERID = TEACHERID;
            GradesPassListForm.ShowDialog();
        }

        private void inputGradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GradeInput GradeInputForm = new GradeInput();
            GradeInputForm.TEACHERID = TEACHERID;
            GradeInputForm.ShowDialog();
        }

        private void gradesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GradesList GradesListForm = new GradesList();
            GradesListForm.ShowDialog();
        }
    }
}
