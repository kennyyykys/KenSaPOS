using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using KenSaPOS.Domain;
using KenSaPOS.Services;

namespace KenSaPOS.WinForms
{
    public partial class LoginForm : Form
    {
        public User AuthenticatedUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            string username = txtUsername.Text.Trim();

            if (username.Length == 0 || txtPassword.Text.Length == 0)
            {
                lblStatus.Text = "Enter your username and password.";
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                User user = new AuthService().Login(username, txtPassword.Text);
                if (user == null)
                {
                    // Same message for unknown user, wrong password and inactive account.
                    lblStatus.Text = "Invalid credentials or inactive user.";
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }

                AuthenticatedUser = user;
                DialogResult = DialogResult.OK;
            }
            catch (SqlException)
            {
                lblStatus.Text = "Unable to connect to the database 'sayson'. Check SQL Server and App.config.";
            }
            catch (Exception)
            {
                lblStatus.Text = "Unable to sign in. Contact the administrator.";
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
