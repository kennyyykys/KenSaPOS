using System;
using System.Windows.Forms;
using KenSaPOS.Domain;
using KenSaPOS.Services;

namespace KenSaPOS.WinForms
{
    public partial class UserEditorForm : Form
    {
        private readonly UserAdminService _service;
        private readonly UserAccount _account;           // null = adding a new user

        public int SavedUserId { get; private set; }

        public UserEditorForm(User actor, UserAccount account)
        {
            _service = new UserAdminService(actor);
            _account = account;
            InitializeComponent();
        }

        private void UserEditorForm_Load(object sender, EventArgs e)
        {
            try
            {
                cboRole.DisplayMember = "RoleName";
                cboRole.ValueMember = "RoleId";
                cboRole.DataSource = _service.GetRoles();

                if (_account == null)
                {
                    Text = "Add User";
                    chkActive.Checked = true;
                    chkActive.Enabled = false;
                    return;
                }

                Text = "Edit User";
                txtUsername.Text = _account.Username;
                txtUsername.ReadOnly = true;
                txtFullName.Text = _account.FullName;
                cboRole.SelectedValue = _account.RoleId;
                chkActive.Checked = _account.IsActive;
                lblPassword.Text = "New password";
                lblConfirm.Text = "Confirm";
                lblPasswordNote.Text = "Leave blank to keep the current password.";
            }
            catch (Exception ex)
            {
                Ui.Error(ex);
                btnSave.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboRole.SelectedValue == null)
            {
                Ui.Warn("Select a role.");
                return;
            }

            string password = txtPassword.Text;
            if ((password.Length > 0 || txtConfirm.Text.Length > 0) && password != txtConfirm.Text)
            {
                Ui.Warn("The password and its confirmation do not match.");
                return;
            }

            try
            {
                int roleId = Convert.ToInt32(cboRole.SelectedValue);
                if (_account == null)
                {
                    SavedUserId = _service.CreateUser(txtUsername.Text, txtFullName.Text, roleId, password);
                }
                else
                {
                    _service.UpdateUser(_account.UserId, txtFullName.Text, roleId, chkActive.Checked, password);
                    SavedUserId = _account.UserId;
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Ui.Warn(Ui.Describe(ex));
            }
        }
    }
}
