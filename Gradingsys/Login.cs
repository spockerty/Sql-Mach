using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Gradingsys
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if ((string.IsNullOrWhiteSpace(txtUsername.Text) || txtUsername.Text == "Username") &&
                (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text == "Password"))
            {
                errorProvider1.SetError(txtUsername, "Please indicate Username");
                errorProvider1.SetError(txtPassword, "Please indicate Password");
                txtUsername.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtUsername.Text) || txtUsername.Text == "Username")
            {
                errorProvider1.SetError(txtUsername, "Please indicate Username");
                txtUsername.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text == "Password")
            {
                errorProvider1.SetError(txtPassword, "Please indicate Password");
                txtPassword.Focus();
            }
            else
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();

                string Query = "SELECT * " +
                               "FROM AdminTable " +
                               "WHERE Username = '" + txtUsername.Text.Replace("-","") + "' " +
                               "AND Password = '" + txtPassword.Text.Replace("-", "") + "'";

                SqlDataAdapter da = new SqlDataAdapter(Query, con);
                DataTable dt = new DataTable();

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Visible = false;
                    Dashboard DashboardForm = new Dashboard();
                    DashboardForm.LoginForm = this;
                    DashboardForm.btnGrades.Enabled = false;
                    DashboardForm.listOfFailedToolStripMenuItem.Visible = false;
                    DashboardForm.listOfPassedToolStripMenuItem.Visible = false;
                    DashboardForm.inputGradesToolStripMenuItem.Visible = false;
                    DashboardForm.USERNAME = txtUsername.Text;
                    DashboardForm.PASSWORD = txtPassword.Text;
                    DashboardForm.Show();

                    txtUsername.Text = "Username";
                    txtUsername.ForeColor = Color.DarkGray;
                    txtPassword.Text = "Password";
                    txtPassword.ForeColor = Color.DarkGray;
                }
                else
                {
                    Query = "SELECT * " +
                            "FROM TeachersTable " +
                            "WHERE Username = '" + txtUsername.Text.Replace("-", "") + "' " +
                            "AND Password = '" + txtPassword.Text.Replace("-", "") + "'";

                    da = new SqlDataAdapter(Query, con);

                    dt = new DataTable();

                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        Visible = false;
                        Dashboard DashboardForm = new Dashboard();
                        DashboardForm.LoginForm = this;
                        DashboardForm.btnSubjects.Enabled = false;
                        DashboardForm.btnStudents.Enabled = false;
                        DashboardForm.btnTeachers.Enabled = false;
                        DashboardForm.subjectsToolStripMenuItem.Enabled = false;
                        DashboardForm.studentToolStripMenuItem.Enabled = false;
                        DashboardForm.teacherToolStripMenuItem.Enabled = false;
                        DashboardForm.gradesListToolStripMenuItem.Visible = false;
                        DashboardForm.TEACHERID = dt.Rows[0]["TeacherID"].ToString();
                        DashboardForm.USERNAME = txtUsername.Text;
                        DashboardForm.PASSWORD = txtPassword.Text;
                        DashboardForm.Show();
                        txtUsername.Text = "Username";
                        txtUsername.ForeColor = Color.DarkGray;
                        txtPassword.Text = "Password";
                        txtPassword.ForeColor = Color.DarkGray;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (sender.Equals(txtUsername))
            {
                if (txtUsername.Text == "Username")
                {
                    txtUsername.Clear();
                    txtUsername.ForeColor = Color.Black;
                }
            }
            if (sender.Equals(txtPassword))
            {
                if (txtPassword.Text == "Password")
                {
                    txtPassword.Clear();
                    txtPassword.UseSystemPasswordChar = true;
                    txtPassword.ForeColor = Color.Black;
                }
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (sender.Equals(txtUsername))
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    txtUsername.Text = "Username";
                    txtUsername.ForeColor = Color.DarkGray;
                }
            }
            if (sender.Equals(txtPassword))
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    txtPassword.Text = "Password";
                    txtPassword.UseSystemPasswordChar = false;
                    txtPassword.ForeColor = Color.DarkGray;
                }
            }
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            //txtUsername.Text = "admin";
            //txtPassword.Text = "admin";
            //btnLogin_Click(sender, e);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblImStudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentLogin StudentLoginForm = new StudentLogin();
            StudentLoginForm.ShowDialog();
        }

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84 && (int)message.Result == 0x1)
                message.Result = (IntPtr)0x2;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grading System"+
                            "\n"+
                            "Created By: Paul Reginald L. Santos"+
                            "\n"+
                            "BSIT 2.2A"+
                            "\n"+
                            "STI Colloege of Tanauan");
        }
    }
}
