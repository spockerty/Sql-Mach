namespace Gradingsys
{
    partial class StudentProfile
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
            this.lblProfile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Second = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Third = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fourth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.BackColor = System.Drawing.Color.Transparent;
            this.lblProfile.Location = new System.Drawing.Point(12, 9);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(107, 20);
            this.lblProfile.TabIndex = 0;
            this.lblProfile.Text = "[Data]\'s Profile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Section";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Bold);
            this.lblGender.Location = new System.Drawing.Point(75, 72);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(51, 20);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "[Data]";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Bold);
            this.lblStudentName.Location = new System.Drawing.Point(75, 52);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(51, 20);
            this.lblStudentName.TabIndex = 6;
            this.lblStudentName.Text = "[Data]";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.BackColor = System.Drawing.Color.Transparent;
            this.lblSection.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Bold);
            this.lblSection.Location = new System.Drawing.Point(75, 122);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(51, 20);
            this.lblSection.TabIndex = 8;
            this.lblSection.Text = "[Data]";
            // 
            // cboYear
            // 
            this.cboYear.BackColor = System.Drawing.SystemColors.Control;
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] {
            "Grade 7",
            "Grade 8",
            "Grade 9",
            "Grade 10"});
            this.cboYear.Location = new System.Drawing.Point(79, 95);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(122, 28);
            this.cboYear.TabIndex = 9;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectName,
            this.TeacherName,
            this.First,
            this.Second,
            this.Third,
            this.Fourth,
            this.Final,
            this.Remarks});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 145);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(801, 167);
            this.dataGridView1.TabIndex = 10;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentID.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Bold);
            this.lblStudentID.Location = new System.Drawing.Point(75, 32);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(51, 20);
            this.lblStudentID.TabIndex = 12;
            this.lblStudentID.Text = "[Data]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(12, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID";
            // 
            // SubjectName
            // 
            this.SubjectName.DataPropertyName = "SubjectName";
            this.SubjectName.Frozen = true;
            this.SubjectName.HeaderText = "Subject";
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            // 
            // TeacherName
            // 
            this.TeacherName.DataPropertyName = "TeacherName";
            this.TeacherName.Frozen = true;
            this.TeacherName.HeaderText = "Teacher";
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.ReadOnly = true;
            // 
            // First
            // 
            this.First.DataPropertyName = "First";
            this.First.HeaderText = "1st Grading";
            this.First.Name = "First";
            this.First.ReadOnly = true;
            // 
            // Second
            // 
            this.Second.DataPropertyName = "Second";
            this.Second.HeaderText = "2nd Grading";
            this.Second.Name = "Second";
            this.Second.ReadOnly = true;
            // 
            // Third
            // 
            this.Third.DataPropertyName = "Third";
            this.Third.HeaderText = "3rd Grading";
            this.Third.Name = "Third";
            this.Third.ReadOnly = true;
            // 
            // Fourth
            // 
            this.Fourth.DataPropertyName = "Fourth";
            this.Fourth.HeaderText = "4th Grading";
            this.Fourth.Name = "Fourth";
            this.Fourth.ReadOnly = true;
            // 
            // Final
            // 
            this.Final.DataPropertyName = "Final";
            this.Final.HeaderText = "Final";
            this.Final.Name = "Final";
            this.Final.ReadOnly = true;
            // 
            // Remarks
            // 
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            // 
            // StudentProfile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Gradingsys.Properties.Resources.tthtrheacher;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 312);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.lblSection);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(817, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(817, 350);
            this.Name = "StudentProfile";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Profile";
            this.Load += new System.EventHandler(this.StudentProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn First;
        private System.Windows.Forms.DataGridViewTextBoxColumn Second;
        private System.Windows.Forms.DataGridViewTextBoxColumn Third;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fourth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Final;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
    }
}