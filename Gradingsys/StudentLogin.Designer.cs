namespace Gradingsys
{
    partial class StudentLogin
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
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStudentID
            // 
            this.txtStudentID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtStudentID.ForeColor = System.Drawing.Color.Black;
            this.txtStudentID.Location = new System.Drawing.Point(11, 25);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(260, 27);
            this.txtStudentID.TabIndex = 4;
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnViewProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewProfile.FlatAppearance.BorderSize = 0;
            this.btnViewProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnViewProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnViewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProfile.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnViewProfile.ForeColor = System.Drawing.Color.Transparent;
            this.btnViewProfile.Location = new System.Drawing.Point(11, 60);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(260, 33);
            this.btnViewProfile.TabIndex = 5;
            this.btnViewProfile.Text = "View Grades";
            this.btnViewProfile.UseVisualStyleBackColor = false;
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter your Student ID";
            // 
            // StudentLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(282, 102);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.btnViewProfile);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(298, 140);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(298, 140);
            this.Name = "StudentLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Label label1;
    }
}