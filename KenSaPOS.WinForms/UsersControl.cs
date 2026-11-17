using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using KenSaPOS.Domain;
using KenSaPOS.Services;

namespace KenSaPOS.WinForms
{
    public partial class UsersControl : UserControl
    {
        private readonly User _user;
        private readonly UserAdminService _service;
        private bool _binding;
        private UserAccount _selected;

        public UsersControl(User user)
        {
            _user = user;
            _service = new UserAdminService(user);
            InitializeComponent();
            Theme.StyleGrid(dgvUsers);
        }

        private void UsersControl_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            LoadUsers(null);
        }

        private void LoadUsers(int? keepUserId)
        {
            try
            {
                _binding = true;
                List<UserAccount> list = _service.GetUsers();
                dgvUsers.DataSource = list;

                Theme.Hide(dgvUsers, "UserId", "RoleId");
                Theme.Header(dgvUsers, "FullName", "Full name");
                Theme.Header(dgvUsers, "RoleName", "Role");
                Theme.Header(dgvUsers, "IsActive", "Active");
                Theme.Header(dgvUsers, "CreatedAt", "Created");
                Theme.Header(dgvUsers, "LastLoginAt", "Last login");
                Theme.Number(dgvUsers, "CreatedAt", "yyyy-MM-dd");
                Theme.Number(dgvUsers, "LastLoginAt", "yyyy-MM-dd hh:mm tt");

                SelectRow(keepUserId);
            }
            catch (Exception ex)
            {
                Ui.Error(ex);
            }
            finally
            {
                _binding = false;
            }
            OnUserChanged();
        }

        private void SelectRow(int? userId)
        {
            dgvUsers.ClearSelection();
            if (dgvUsers.Rows.Count == 0) return;

            DataGridViewRow target = dgvUsers.Rows[0];
            if (userId != null)
            {
                foreach (DataGridViewRow row in dgvUsers.Rows)
                {
                    UserAccount a = row.DataBoundItem as UserAccount;
                    if (a != null && a.UserId == userId.Value)
                    {
                        target = row;
                        break;
                    }
                }
            }
            target.Selected = true;
            dgvUsers.CurrentCell = target.Cells["Username"];
        }

        private void OnUserChanged()
        {
            _selected = dgvUsers.SelectedRows.Count > 0 ? dgvUsers.SelectedRows[0].DataBoundItem as UserAccount : null;
            btnToggle.Text = (_selected != null && !_selected.IsActive) ? "Activate" : "Deactivate";
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (_binding) return;
            OnUserChanged();
        }

        private void dgvUsers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                UserAccount a = row.DataBoundItem as UserAccount;
                if (a != null) row.DefaultCellStyle.ForeColor = a.IsActive ? Color.Empty : Color.Gray;
            }
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) btnEdit.PerformClick();
        }

        private void OpenEditor(UserAccount account)
        {
            using (var editor = new UserEditorForm(_user, account))
            {
                if (editor.ShowDialog(this) == DialogResult.OK) LoadUsers(editor.SavedUserId);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenEditor(null);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selected == null)
            {
                Ui.Warn("Select a user in the list first.");
                return;
            }
            OpenEditor(_selected);
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (_selected == null)
            {
                Ui.Warn("Select a user in the list first.");
                return;
            }

            bool activate = !_selected.IsActive;
            string verb = activate ? "Activate" : "Deactivate";
            if (!Ui.Confirm(verb + " the account \"" + _selected.Username + "\"?")) return;

            int userId = _selected.UserId;
            try
            {
                _service.UpdateUser(userId, _selected.FullName, _selected.RoleId, activate, null);
                LoadUsers(userId);
            }
            catch (Exception ex)
            {
                Ui.Error(ex);
            }
        }
    }
}
