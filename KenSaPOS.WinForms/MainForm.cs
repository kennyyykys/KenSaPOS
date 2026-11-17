using System;
using System.Linq;
using System.Windows.Forms;
using KenSaPOS.Domain;

namespace KenSaPOS.WinForms
{
    public partial class MainForm : Form
    {
        private readonly User _user;
        private Button _activeButton;

        /// <summary>True when the user chose "Log out" (so the login screen is shown again).</summary>
        public bool LoggedOut { get; private set; }

        public MainForm(User user)
        {
            _user = user;
            InitializeComponent();

            lblUser.Text = user.FullName + Environment.NewLine + user.RoleName;

            // Role-aware navigation. Services enforce the same rules; hiding a button is not security.
            btnInventory.Visible = user.IsManagerOrAdmin;
            btnAnalytics.Visible = user.IsManagerOrAdmin;
            btnUsers.Visible = user.IsAdmin;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnDashboard.PerformClick();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                e.Handled = true;
                btnPos.PerformClick();
            }
            else if (e.KeyCode == Keys.F9)
            {
                // checkout shortcut, only while the Point of Sale page is open
                PosControl pos = pnlContent.Controls.OfType<PosControl>().FirstOrDefault();
                if (pos != null)
                {
                    e.Handled = true;
                    pos.Checkout();
                }
            }
        }

        private void ShowPage(Button source, Control page)
        {
            if (_activeButton != null) _activeButton.BackColor = Theme.Navy;
            _activeButton = source;
            source.BackColor = Theme.NavyActive;

            var old = pnlContent.Controls.Cast<Control>().ToList();
            pnlContent.Controls.Clear();
            foreach (Control c in old) c.Dispose();

            page.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(page);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowPage(btnDashboard, new DashboardControl(_user));
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            ShowPage(btnPos, new PosControl(_user));
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ShowPage(btnInventory, new InventoryControl(_user));
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            ShowPage(btnAnalytics, new AnalyticsControl(_user));
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ShowPage(btnUsers, new UsersControl(_user));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (!Ui.Confirm("Log out of KenSaPOS?")) return;
            LoggedOut = true;
            Close();
        }
    }
}
