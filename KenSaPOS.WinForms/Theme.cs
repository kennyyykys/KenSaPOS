using System.Drawing;
using System.Windows.Forms;

namespace KenSaPOS.WinForms
{
    /// <summary>Shared colours and grid styling so every screen looks the same.</summary>
    public static class Theme
    {
        public static readonly Color Navy = Color.FromArgb(30, 58, 110);
        public static readonly Color NavyActive = Color.FromArgb(45, 80, 150);
        public static readonly Color NavyHeader = Color.FromArgb(31, 56, 111);
        public static readonly Color LowRow = Color.FromArgb(253, 228, 228);

        public static void StyleGrid(DataGridView g)
        {
            g.BackgroundColor = Color.White;
            g.BorderStyle = BorderStyle.None;
            g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            g.GridColor = Color.FromArgb(225, 228, 235);
            g.EnableHeadersVisualStyles = false;
            g.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            g.ColumnHeadersDefaultCellStyle.BackColor = NavyHeader;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            g.ColumnHeadersDefaultCellStyle.SelectionBackColor = NavyHeader;
            g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            g.ColumnHeadersDefaultCellStyle.Padding = new Padding(4, 6, 4, 6);
            g.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            g.DefaultCellStyle.SelectionForeColor = Color.White;
            g.DefaultCellStyle.Padding = new Padding(3, 2, 3, 2);
            g.RowTemplate.Height = 28;
            g.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 249, 252);
        }

        public static void Header(DataGridView g, string column, string text)
        {
            if (g.Columns[column] != null) g.Columns[column].HeaderText = text;
        }

        public static void Hide(DataGridView g, params string[] columns)
        {
            foreach (string name in columns)
            {
                if (g.Columns[name] != null) g.Columns[name].Visible = false;
            }
        }

        /// <summary>Right-aligns a numeric column and optionally applies a number format.</summary>
        public static void Number(DataGridView g, string column, string format)
        {
            DataGridViewColumn c = g.Columns[column];
            if (c == null) return;
            c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            if (format != null) c.DefaultCellStyle.Format = format;
        }
    }
}
