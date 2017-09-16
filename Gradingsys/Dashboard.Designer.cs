namespace Gradingsys
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfTeachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfSubjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfFailedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfPassedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputGradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.btnGrades = new System.Windows.Forms.Button();
            this.btnSubjects = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.teacherToolStripMenuItem,
            this.subjectsToolStripMenuItem,
            this.gradesToolStripMenuItem,
            this.systemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(418, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentListToolStripMenuItem,
            this.addStudentToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // studentListToolStripMenuItem
            // 
            this.studentListToolStripMenuItem.Name = "studentListToolStripMenuItem";
            this.studentListToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.studentListToolStripMenuItem.Text = "List of Teachers";
            this.studentListToolStripMenuItem.Click += new System.EventHandler(this.studentListToolStripMenuItem_Click);
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.addStudentToolStripMenuItem.Text = "Add New Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // teacherToolStripMenuItem
            // 
            this.teacherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfTeachersToolStripMenuItem,
            this.addNewTeacherToolStripMenuItem});
            this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            this.teacherToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.teacherToolStripMenuItem.Text = "Teacher";
            // 
            // listOfTeachersToolStripMenuItem
            // 
            this.listOfTeachersToolStripMenuItem.Name = "listOfTeachersToolStripMenuItem";
            this.listOfTeachersToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.listOfTeachersToolStripMenuItem.Text = "List of Teachers";
            this.listOfTeachersToolStripMenuItem.Click += new System.EventHandler(this.listOfTeachersToolStripMenuItem_Click);
            // 
            // addNewTeacherToolStripMenuItem
            // 
            this.addNewTeacherToolStripMenuItem.Name = "addNewTeacherToolStripMenuItem";
            this.addNewTeacherToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.addNewTeacherToolStripMenuItem.Text = "Add New Teacher";
            this.addNewTeacherToolStripMenuItem.Click += new System.EventHandler(this.addNewTeacherToolStripMenuItem_Click);
            // 
            // subjectsToolStripMenuItem
            // 
            this.subjectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfSubjectsToolStripMenuItem,
            this.addNewSubjectToolStripMenuItem});
            this.subjectsToolStripMenuItem.Name = "subjectsToolStripMenuItem";
            this.subjectsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.subjectsToolStripMenuItem.Text = "Subjects";
            // 
            // listOfSubjectsToolStripMenuItem
            // 
            this.listOfSubjectsToolStripMenuItem.Name = "listOfSubjectsToolStripMenuItem";
            this.listOfSubjectsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.listOfSubjectsToolStripMenuItem.Text = "List of Subjects";
            this.listOfSubjectsToolStripMenuItem.Click += new System.EventHandler(this.listOfSubjectsToolStripMenuItem_Click);
            // 
            // addNewSubjectToolStripMenuItem
            // 
            this.addNewSubjectToolStripMenuItem.Name = "addNewSubjectToolStripMenuItem";
            this.addNewSubjectToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addNewSubjectToolStripMenuItem.Text = "Add New Subject";
            this.addNewSubjectToolStripMenuItem.Click += new System.EventHandler(this.addNewSubjectToolStripMenuItem_Click);
            // 
            // gradesToolStripMenuItem
            // 
            this.gradesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfFailedToolStripMenuItem,
            this.listOfPassedToolStripMenuItem,
            this.inputGradesToolStripMenuItem,
            this.gradesListToolStripMenuItem});
            this.gradesToolStripMenuItem.Name = "gradesToolStripMenuItem";
            this.gradesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.gradesToolStripMenuItem.Text = "Grades";
            this.gradesToolStripMenuItem.Click += new System.EventHandler(this.gradesToolStripMenuItem_Click);
            // 
            // listOfFailedToolStripMenuItem
            // 
            this.listOfFailedToolStripMenuItem.Name = "listOfFailedToolStripMenuItem";
            this.listOfFailedToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.listOfFailedToolStripMenuItem.Text = "List of Failed";
            this.listOfFailedToolStripMenuItem.Click += new System.EventHandler(this.listOfFailedToolStripMenuItem_Click);
            // 
            // listOfPassedToolStripMenuItem
            // 
            this.listOfPassedToolStripMenuItem.Name = "listOfPassedToolStripMenuItem";
            this.listOfPassedToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.listOfPassedToolStripMenuItem.Text = "List of Passed";
            this.listOfPassedToolStripMenuItem.Click += new System.EventHandler(this.listOfPassedToolStripMenuItem_Click);
            // 
            // inputGradesToolStripMenuItem
            // 
            this.inputGradesToolStripMenuItem.Name = "inputGradesToolStripMenuItem";
            this.inputGradesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.inputGradesToolStripMenuItem.Text = "Input Grades";
            this.inputGradesToolStripMenuItem.Click += new System.EventHandler(this.inputGradesToolStripMenuItem_Click);
            // 
            // gradesListToolStripMenuItem
            // 
            this.gradesListToolStripMenuItem.Name = "gradesListToolStripMenuItem";
            this.gradesListToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.gradesListToolStripMenuItem.Text = "Grades List";
            this.gradesListToolStripMenuItem.Click += new System.EventHandler(this.gradesListToolStripMenuItem_Click);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.BackgroundImage = global::Gradingsys.Properties.Resources._1490393896_add_group;
            this.btnStudents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudents.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.Location = new System.Drawing.Point(89, 74);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(118, 62);
            this.btnStudents.TabIndex = 1;
            this.btnStudents.Text = "Students";
            this.btnStudents.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.studentListToolStripMenuItem_Click);
            // 
            // btnTeachers
            // 
            this.btnTeachers.BackgroundImage = global::Gradingsys.Properties.Resources.TR;
            this.btnTeachers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTeachers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeachers.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeachers.ForeColor = System.Drawing.Color.Black;
            this.btnTeachers.Location = new System.Drawing.Point(213, 74);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size = new System.Drawing.Size(118, 62);
            this.btnTeachers.TabIndex = 2;
            this.btnTeachers.Text = "Teachers";
            this.btnTeachers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTeachers.UseVisualStyleBackColor = true;
            this.btnTeachers.Click += new System.EventHandler(this.listOfTeachersToolStripMenuItem_Click);
            // 
            // btnGrades
            // 
            this.btnGrades.BackgroundImage = global::Gradingsys.Properties.Resources.grades;
            this.btnGrades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGrades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrades.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrades.ForeColor = System.Drawing.Color.Black;
            this.btnGrades.Location = new System.Drawing.Point(213, 142);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Size = new System.Drawing.Size(118, 62);
            this.btnGrades.TabIndex = 4;
            this.btnGrades.Text = "Grades";
            this.btnGrades.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrades.UseVisualStyleBackColor = true;
            this.btnGrades.Click += new System.EventHandler(this.inputGradesToolStripMenuItem_Click);
            // 
            // btnSubjects
            // 
            this.btnSubjects.BackgroundImage = global::Gradingsys.Properties.Resources.subjectsss;
            this.btnSubjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubjects.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubjects.Location = new System.Drawing.Point(89, 142);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Size = new System.Drawing.Size(118, 62);
            this.btnSubjects.TabIndex = 3;
            this.btnSubjects.Text = "Subjects";
            this.btnSubjects.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSubjects.UseVisualStyleBackColor = true;
            this.btnSubjects.Click += new System.EventHandler(this.listOfSubjectsToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gradingsys.Properties.Resources.tthtrheacher;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(418, 282);
            this.Controls.Add(this.btnGrades);
            this.Controls.Add(this.btnSubjects);
            this.Controls.Add(this.btnTeachers);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem studentListToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem listOfTeachersToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addNewTeacherToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem subjectsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem listOfSubjectsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addNewSubjectToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem gradesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        public System.Windows.Forms.Button btnStudents;
        public System.Windows.Forms.Button btnTeachers;
        public System.Windows.Forms.Button btnGrades;
        public System.Windows.Forms.Button btnSubjects;
        public System.Windows.Forms.ToolStripMenuItem listOfFailedToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem listOfPassedToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem inputGradesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem gradesListToolStripMenuItem;

    }
}