using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace KenSaPOS.WinForms
{
    public static class Ui
    {
        public static string Describe(Exception ex)
        {
            SqlException sql = ex as SqlException;
            if (sql != null && (sql.Number == -1 || sql.Number == 2 || sql.Number == 53 ||
                                sql.Number == 40 || sql.Number == 4060 || sql.Number == 18456))
            {
                return "Cannot connect to the database 'sayson'.\n\nCheck that SQL Server is running, that " +
                       "Database\\01_CreateDatabase.sql was executed, and that the connection string in App.config is correct.";
            }
            return ex.Message;
        }

        public static void Error(Exception ex)
        {
            MessageBox.Show(Describe(ex), "KenSaPOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Warn(string message)
        {
            MessageBox.Show(message, "Please check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Info(string message)
        {
            MessageBox.Show(message, "KenSaPOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool Confirm(string message)
        {
            return MessageBox.Show(message, "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        /// <summary>Formats an amount in Philippine pesos.</summary>
        public static string Peso(decimal value)
        {
            return "\u20B1" + value.ToString("N2", CultureInfo.InvariantCulture);
        }
    }
}
