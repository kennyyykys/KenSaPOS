using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace KenSaPOS.Data
{
    /// <summary>Shared connection and stored-procedure helpers. Repositories use these; forms never do.</summary>
    public static class Db
    {
        public static string ConnectionString
        {
            get
            {
                ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["KenSaPOS"];
                if (settings == null)
                    throw new InvalidOperationException("Connection string 'KenSaPOS' was not found in App.config.");
                return settings.ConnectionString;
            }
        }

        /// <summary>Reads an appSettings value from App.config, or returns the fallback.</summary>
        public static string Setting(string key, string fallback)
        {
            string value = ConfigurationManager.AppSettings[key];
            return string.IsNullOrWhiteSpace(value) ? fallback : value;
        }

        /// <summary>Sales tax percentage (App.config key TaxRatePercent, default 8).</summary>
        public static decimal TaxRatePercent
        {
            get
            {
                decimal rate;
                if (decimal.TryParse(Setting("TaxRatePercent", "8"), NumberStyles.Number, CultureInfo.InvariantCulture, out rate)
                    && rate >= 0m && rate <= 100m)
                    return rate;
                return 8m;
            }
        }

        public static SqlConnection Open()
        {
            var connection = new SqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }

        /// <summary>Runs a stored procedure and returns its first result set (empty table if none).</summary>
        public static DataTable Table(string procedure, params SqlParameter[] parameters)
        {
            using (var connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(procedure, connection))
            using (var adapter = new SqlDataAdapter(command))
            {
                command.CommandType = CommandType.StoredProcedure;
                if (parameters != null && parameters.Length > 0) command.Parameters.AddRange(parameters);
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public static SqlParameter P(string name, object value)
        {
            return new SqlParameter(name, value ?? DBNull.Value);
        }

        public static SqlParameter Money(string name, decimal value)
        {
            return Decimal(name, value, 18, 2);
        }

        public static SqlParameter Decimal(string name, decimal value, byte precision, byte scale)
        {
            return new SqlParameter(name, SqlDbType.Decimal) { Precision = precision, Scale = scale, Value = value };
        }

        public static SqlParameter Bytes(string name, byte[] value)
        {
            return new SqlParameter(name, SqlDbType.VarBinary, -1) { Value = (object)value ?? DBNull.Value };
        }

        public static SqlParameter Xml(string name, string xml)
        {
            return new SqlParameter(name, SqlDbType.Xml) { Value = xml };
        }
    }
}
