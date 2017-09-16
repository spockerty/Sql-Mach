namespace Gradingsys
{
    partial class GradeInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradeInput));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Second = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Third = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fourth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveGrade = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GradesPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFourth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThird = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnprint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.GradesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.FullName,
            this.Year,
            this.Section,
            this.Subject,
            this.First,
            this.Second,
            this.Third,
            this.Fourth,
            this.Final,
            this.Remarks});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 54);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(503, 290);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "StudentID";
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // Section
            // 
            this.Section.DataPropertyName = "Section";
            this.Section.HeaderText = "Section";
            this.Section.Name = "Section";
            this.Section.ReadOnly = true;
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
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
            this.Final.HeaderText = "Final Grade";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnprint);
            this.panel1.Controls.Add(this.btnSaveGrade);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 452);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 50);
            this.panel1.TabIndex = 1;
            // 
            // btnSaveGrade
            // 
            this.btnSaveGrade.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSaveGrade.Enabled = false;
            this.btnSaveGrade.Location = new System.Drawing.Point(359, 14);
            this.btnSaveGrade.Name = "btnSaveGrade";
            this.btnSaveGrade.Size = new System.Drawing.Size(124, 23);
            this.btnSaveGrade.TabIndex = 6;
            this.btnSaveGrade.Text = "Save Grade Input";
            this.btnSaveGrade.UseVisualStyleBackColor = true;
            this.btnSaveGrade.Click += new System.EventHandler(this.btnSaveGrade_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 44);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(369, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GradesPanel
            // 
            this.GradesPanel.BackColor = System.Drawing.Color.Transparent;
            this.GradesPanel.Controls.Add(this.label4);
            this.GradesPanel.Controls.Add(this.txtFourth);
            this.GradesPanel.Controls.Add(this.label5);
            this.GradesPanel.Controls.Add(this.txtThird);
            this.GradesPanel.Controls.Add(this.label3);
            this.GradesPanel.Controls.Add(this.txtSecond);
            this.GradesPanel.Controls.Add(this.label2);
            this.GradesPanel.Controls.Add(this.txtFirst);
            this.GradesPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GradesPanel.Enabled = false;
            this.GradesPanel.Location = new System.Drawing.Point(10, 344);
            this.GradesPanel.Name = "GradesPanel";
            this.GradesPanel.Size = new System.Drawing.Size(503, 108);
            this.GradesPanel.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(293, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "4th Grading";
            // 
            // txtFourth
            // 
            this.txtFourth.Location = new System.Drawing.Point(296, 72);
            this.txtFourth.Name = "txtFourth";
            this.txtFourth.Size = new System.Drawing.Size(156, 20);
            this.txtFourth.TabIndex = 28;
            this.txtFourth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFourth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFourth_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(293, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "3rd Grading";
            // 
            // txtThird
            // 
            this.txtThird.Location = new System.Drawing.Point(296, 33);
            this.txtThird.Name = "txtThird";
            this.txtThird.Size = new System.Drawing.Size(156, 20);
            this.txtThird.TabIndex = 26;
            this.txtThird.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtThird.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThird_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "2nd Grading";
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(53, 72);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(156, 20);
            this.txtSecond.TabIndex = 24;
            this.txtSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecond_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "1st Grading";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(53, 33);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(156, 20);
            this.txtFirst.TabIndex = 22;
            this.txtFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirst_KeyPress);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(259, 14);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 23);
            this.btnprint.TabIndex = 7;
            this.btnprint.Text = "print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // GradeInput
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Gradingsys.Properties.Resources.tthtrheacher;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(523, 512);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GradesPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GradeInput";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Grades";
            this.Load += new System.EventHandler(this.TeacherAddUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.GradesPanel.ResumeLayout(false);
            this.GradesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveGrade;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel GradesPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFourth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThird;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn First;
        private System.Windows.Forms.DataGridViewTextBoxColumn Second;
        private System.Windows.Forms.DataGridViewTextBoxColumn Third;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fourth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Final;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnprint;
    }
}