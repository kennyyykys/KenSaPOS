using System;
using System.Windows.Forms;
using KenSaPOS.Domain;
using KenSaPOS.Services;

namespace KenSaPOS.WinForms
{
    public partial class DashboardControl : UserControl
    {
        private readonly DashboardService _service = new DashboardService();

        public DashboardControl(User user)
        {
            InitializeComponent();
            Theme.StyleGrid(dgvLowStock);
            lblWelcome.Text = "Welcome, " + user.FullName;
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DashboardMetrics m = _service.GetMetrics();
                lblSalesValue.Text = Ui.Peso(m.TodaySales);
                lblOrdersValue.Text = m.TodayOrders.ToString();
                lblLowValue.Text = m.LowStockCount.ToString();
                lblProductsValue.Text = m.ActiveProducts.ToString();

                dgvLowStock.DataSource = _service.GetLowStock();
                Theme.Header(dgvLowStock, "Sku", "SKU");
                Theme.Header(dgvLowStock, "Name", "Product");
                Theme.Header(dgvLowStock, "StockQty", "In stock");
                Theme.Header(dgvLowStock, "ReorderLevel", "Reorder level");
                Theme.Number(dgvLowStock, "StockQty", null);
                Theme.Number(dgvLowStock, "ReorderLevel", null);
            }
            catch (Exception ex)
            {
                Ui.Error(ex);
            }
        }
    }
}
