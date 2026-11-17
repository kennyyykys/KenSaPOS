using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using KenSaPOS.Domain;
using KenSaPOS.Services;

namespace KenSaPOS.WinForms
{
    public partial class AnalyticsControl : UserControl
    {
        private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

        private readonly ReportingService _service;
        private List<DailySales> _daily = new List<DailySales>();
        private List<TopProduct> _top = new List<TopProduct>();
        private List<CategorySales> _categories = new List<CategorySales>();

        public AnalyticsControl(User user)
        {
            _service = new ReportingService(user);
            InitializeComponent();

            PrepareChart(chartDaily, "Daily revenue", SeriesChartType.Column, false);
            PrepareChart(chartTop, "Top products by revenue", SeriesChartType.Bar, false);
            PrepareChart(chartCategory, "Revenue by category", SeriesChartType.Doughnut, true);
            chartTop.ChartAreas[0].AxisX.IsReversed = true;        // biggest bar on top
        }

        private void AnalyticsControl_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            dtpTo.Value = DateTime.Today;
            dtpFrom.Value = DateTime.Today.AddDays(-30);
            RunReport();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            RunReport();
        }

        // ------------------------------------------------------------ charts

        private static void PrepareChart(Chart chart, string title, SeriesChartType type, bool legend)
        {
            chart.ChartAreas.Clear();
            chart.Series.Clear();
            chart.Titles.Clear();
            chart.Legends.Clear();

            var area = new ChartArea("main");
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.Gainsboro;
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 8F);
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 8F);
            chart.ChartAreas.Add(area);

            chart.Titles.Add(new Title(title, Docking.Top, new Font("Segoe UI", 10F, FontStyle.Bold), Color.Black));

            var series = new Series("data") { ChartType = type, ChartArea = "main" };
            series.Color = Color.FromArgb(0, 128, 107);
            if (legend)
            {
                chart.Legends.Add(new Legend("legend") { Docking = Docking.Right });
                series.Legend = "legend";
                series.IsValueShownAsLabel = false;
                series["PieLabelStyle"] = "Disabled";
            }
            else
            {
                series.IsValueShownAsLabel = true;
                series.LabelFormat = "N2";
            }
            chart.Series.Add(series);
        }

        private static void SetEmptyNotice(Chart chart, bool empty)
        {
            Title notice = chart.Titles.FindByName("empty");
            if (empty && notice == null)
            {
                chart.Titles.Add(new Title("No sales in this period", Docking.Top,
                    new Font("Segoe UI", 9F), Color.Gray) { Name = "empty" });
            }
            else if (!empty && notice != null)
            {
                chart.Titles.Remove(notice);
            }
        }

        // ------------------------------------------------------------ report

        private void RunReport()
        {
            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date;
            if (from > to)
            {
                Ui.Warn("The 'From' date must be on or before the 'To' date.");
                return;
            }

            try
            {
                _daily = _service.GetDaily(from, to);
                _top = _service.GetTopProducts(from, to, 10);
                _categories = _service.GetCategorySales(from, to);
            }
            catch (Exception ex)
            {
                Ui.Error(ex);
                return;
            }

            decimal revenue = _daily.Sum(d => d.Revenue);
            int orders = _daily.Sum(d => d.OrderCount);
            decimal average = orders > 0 ? revenue / orders : 0m;
            lblRevenue.Text = "Revenue: " + Ui.Peso(revenue);
            lblOrders.Text = "Orders: " + orders;
            lblAverage.Text = "Avg order: " + Ui.Peso(average);

            Series daily = chartDaily.Series["data"];
            daily.Points.Clear();
            foreach (DailySales d in _daily) daily.Points.AddXY(d.SaleDate.ToString("MMM dd", Inv), (double)d.Revenue);
            SetEmptyNotice(chartDaily, _daily.Count == 0);

            Series top = chartTop.Series["data"];
            top.Points.Clear();
            foreach (TopProduct p in _top) top.Points.AddXY(p.ProductName, (double)p.Revenue);
            SetEmptyNotice(chartTop, _top.Count == 0);

            Series cat = chartCategory.Series["data"];
            cat.Points.Clear();
            foreach (CategorySales c in _categories)
            {
                int i = cat.Points.AddXY(c.CategoryName, (double)c.Revenue);
                cat.Points[i].LegendText = c.CategoryName;
            }
            SetEmptyNotice(chartCategory, _categories.Count == 0);
        }

        // ------------------------------------------------------------ CSV export

        private static string Csv(string value)
        {
            value = value ?? "";
            // stop spreadsheet formula injection from text that starts with = + - @
            if (value.Length > 0 && "=+-@".IndexOf(value[0]) >= 0) value = "'" + value;
            return "\"" + value.Replace("\"", "\"\"") + "\"";
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (_daily.Count == 0 && _top.Count == 0 && _categories.Count == 0)
            {
                Ui.Warn("There is nothing to export. Run a report that has sales first.");
                return;
            }

            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date;

            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "CSV file (*.csv)|*.csv";
                dialog.FileName = "sales-report-" + from.ToString("yyyyMMdd", Inv) + "-" + to.ToString("yyyyMMdd", Inv) + ".csv";
                if (dialog.ShowDialog(this) != DialogResult.OK) return;

                var sb = new StringBuilder();
                sb.AppendLine("Sales report," + Csv(from.ToString("yyyy-MM-dd", Inv) + " to " + to.ToString("yyyy-MM-dd", Inv)));
                sb.AppendLine();
                sb.AppendLine("Daily sales");
                sb.AppendLine("Date,Orders,Revenue");
                foreach (DailySales d in _daily)
                    sb.AppendLine(d.SaleDate.ToString("yyyy-MM-dd", Inv) + "," + d.OrderCount + "," + d.Revenue.ToString("0.00", Inv));
                sb.AppendLine();
                sb.AppendLine("Top products");
                sb.AppendLine("Product,Quantity sold,Revenue");
                foreach (TopProduct p in _top)
                    sb.AppendLine(Csv(p.ProductName) + "," + p.QtySold + "," + p.Revenue.ToString("0.00", Inv));
                sb.AppendLine();
                sb.AppendLine("Revenue by category");
                sb.AppendLine("Category,Revenue");
                foreach (CategorySales c in _categories)
                    sb.AppendLine(Csv(c.CategoryName) + "," + c.Revenue.ToString("0.00", Inv));

                try
                {
                    File.WriteAllText(dialog.FileName, sb.ToString(), new UTF8Encoding(true));
                    Ui.Info("Report exported:\n" + dialog.FileName);
                }
                catch (Exception ex)
                {
                    Ui.Error(ex);
                }
            }
        }
    }
}
