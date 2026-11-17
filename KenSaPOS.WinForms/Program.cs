using System;
using System.Windows.Forms;
using KenSaPOS.Domain;

namespace KenSaPOS.WinForms
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += (s, e) => Ui.Error(e.Exception);

            // Login -> main window. "Log out" returns to the login screen; closing the window exits.
            while (true)
            {
                User user;
                using (var login = new LoginForm())
                {
                    if (login.ShowDialog() != DialogResult.OK) break;
                    user = login.AuthenticatedUser;
                }

                using (var main = new MainForm(user))
                {
                    main.ShowDialog();
                    if (!main.LoggedOut) break;
                }
            }
        }
    }
}
