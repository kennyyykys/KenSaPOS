using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using KenSaPOS.Domain;
using KenSaPOS.Services;

namespace KenSaPOS.WinForms
{
    public partial class InventoryControl : UserControl
    {
        private readonly User _user;
        private readonly InventoryService _service;
        private bool _binding;
        private Product _selected;

        public InventoryControl(User user)
        {
            _user = user;
            _service = new InventoryService(user);
            InitializeComponent();
            Theme.StyleGrid(dgvProducts);
            Theme.StyleGrid(dgvLog);
        }

        private void InventoryControl_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            LoadProducts(null);
        }

        // ------------------------------------------------------------ loading

        private void LoadProducts(int? keepProductId)
        {
            try
            {
                _binding = true;
                List<Product> list = _service.Search(txtSearch.Text.Trim(), chkLowOnly.Checked, chkInactive.Checked);
                dgvProducts.DataSource = list;
                FormatProductGrid();
                SelectRow(keepProductId);
            }
            catch (Exception ex)
            {
                Ui.Error(ex);
            }
            finally
            {
                _binding = false;
            }
            OnProductChanged();
        }

        private void FormatProductGrid()
        {
            Theme.Hide(dgvProducts, "ProductId", "CategoryId", "HasImage", "IsLow");
            Theme.Header(dgvProducts, "Sku", "SKU");
            Theme.Header(dgvProducts, "Name", "Product");
            Theme.Header(dgvProducts, "CategoryName", "Category");
            Theme.Header(dgvProducts, "StockQty", "In stock");
            Theme.Header(dgvProducts, "ReorderLevel", "Reorder level");
            Theme.Header(dgvProducts, "IsActive", "Active");
            Theme.Number(dgvProducts, "Price", "N2");
            Theme.Number(dgvProducts, "Cost", "N2");
            Theme.Number(dgvProducts, "StockQty", null);
            Theme.Number(dgvProducts, "ReorderLevel", null);
        }

        private void SelectRow(int? productId)
        {
            dgvProducts.ClearSelection();
            if (dgvProducts.Rows.Count == 0) return;

            DataGridViewRow target = dgvProducts.Rows[0];
            if (productId != null)
            {
                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    Product p = row.DataBoundItem as Product;
                    if (p != null && p.ProductId == productId.Value)
                    {
                        target = row;
                        break;
                    }
                }
            }
            target.Selected = true;
            dgvProducts.CurrentCell = target.Cells["Sku"];
        }

        private void OnProductChanged()
        {
            _selected = dgvProducts.SelectedRows.Count > 0
                ? dgvProducts.SelectedRows[0].DataBoundItem as Product
                : null;

            if (_selected == null)
            {
                lblAdjustProduct.Text = "Select a product to adjust stock";
                dgvLog.DataSource = null;
                return;
            }

            lblAdjustProduct.Text = _selected.Name + "  (stock " + _selected.StockQty + ")";
            try
            {
                dgvLog.DataSource = _service.GetLog(_selected.ProductId);
                Theme.Header(dgvLog, "CreatedAt", "When");
                Theme.Header(dgvLog, "ChangeQty", "Change");
                Theme.Header(dgvLog, "ByUser", "By");
                Theme.Number(dgvLog, "ChangeQty", "+0;-0;0");
                if (dgvLog.Columns["CreatedAt"] != null)
                    dgvLog.Columns["CreatedAt"].DefaultCellStyle.Format = "yyyy-MM-dd hh:mm tt";
            }
            catch (Exception ex)
            {
                Ui.Error(ex);
            }
        }

        private int? SelectedId
        {
            get { return _selected == null ? (int?)null : _selected.ProductId; }
        }

        // ------------------------------------------------------------ grid events

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (_binding) return;
            OnProductChanged();
        }

        private void dgvProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // low stock = pink row, inactive = grey text
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                Product p = row.DataBoundItem as Product;
                if (p == null) continue;
                row.DefaultCellStyle.BackColor = p.IsLow ? Theme.LowRow : Color.Empty;
                row.DefaultCellStyle.ForeColor = p.IsActive ? Color.Empty : Color.Gray;
            }
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) btnEdit.PerformClick();
        }

        // ------------------------------------------------------------ search / filters

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                LoadProducts(null);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadProducts(null);
        }

        private void Filter_CheckedChanged(object sender, EventArgs e)
        {
            if (_binding) return;
            LoadProducts(SelectedId);
        }

        // ------------------------------------------------------------ CRUD

        private void OpenEditor(Product product)
        {
            using (var editor = new ProductEditorForm(_user, product))
            {
                if (editor.ShowDialog(this) == DialogResult.OK) LoadProducts(editor.SavedProductId);
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
                Ui.Warn("Select a product in the list first.");
                return;
            }
            OpenEditor(_selected);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selected == null)
            {
                Ui.Warn("Select a product in the list first.");
                return;
            }
            if (!Ui.Confirm("Delete \"" + _selected.Name + "\"?\n\n" +
                            "The product is deactivated (soft delete) so past sales are kept."))
                return;

            try
            {
                _service.Delete(_selected.ProductId);
                LoadProducts(null);
            }
            catch (Exception ex)
            {
                Ui.Error(ex);
            }
        }

        // ------------------------------------------------------------ stock adjustment

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (_selected == null)
            {
                Ui.Warn("Select a product first.");
                return;
            }

            int productId = _selected.ProductId;
            try
            {
                int newStock = _service.Adjust(productId, (int)nudChange.Value, cboReason.Text);
                Ui.Info("Stock updated. New stock: " + newStock);
                nudChange.Value = 0;
                cboReason.Text = "";
                LoadProducts(productId);
            }
            catch (Exception ex)
            {
                Ui.Error(ex);
            }
        }
    }
}
