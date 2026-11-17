using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using KenSaPOS.Domain;
using KenSaPOS.Services;

namespace KenSaPOS.WinForms
{
    public partial class PosControl : UserControl
    {
        private readonly User _user;
        private readonly SalesService _sales;
        private readonly InventoryService _inventory;
        private readonly BindingList<CartLine> _cart = new BindingList<CartLine>();
        private decimal _taxRate;
        private ReceiptData _lastReceipt;

        public PosControl(User user)
        {
            _user = user;
            _sales = new SalesService(user);
            _inventory = new InventoryService(user);
            InitializeComponent();
            Theme.StyleGrid(dgvProducts);
            Theme.StyleGrid(dgvCart);
        }

        private void PosControl_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            _taxRate = _sales.TaxRatePercent;
            cboPayment.SelectedIndex = 0;
            nudDiscount.Enabled = _user.IsManagerOrAdmin;      // discounts need a manager (also enforced in the service)

            dgvCart.DataSource = _cart;
            Theme.Hide(dgvCart, "ProductId", "Sku", "MaxStock");
            Theme.Header(dgvCart, "Name", "Item");
            Theme.Header(dgvCart, "UnitPrice", "Price");
            Theme.Header(dgvCart, "Quantity", "Qty");
            Theme.Header(dgvCart, "LineTotal", "Total");
            Theme.Number(dgvCart, "UnitPrice", "N2");
            Theme.Number(dgvCart, "Quantity", null);
            Theme.Number(dgvCart, "LineTotal", "N2");

            LoadCustomers(null);
            LoadProducts();
            RefreshTotals();
            BeginInvoke(new Action(() => txtScan.Focus()));
        }

        // ------------------------------------------------------------ data

        private void LoadCustomers(int? selectId)
        {
            try
            {
                List<Customer> list = _sales.GetCustomers();
                list.Insert(0, new Customer { CustomerId = 0, FullName = "Walk-in customer" });
                cboCustomer.DisplayMember = "Display";
                cboCustomer.ValueMember = "CustomerId";
                cboCustomer.DataSource = list;
                if (selectId != null) cboCustomer.SelectedValue = selectId.Value;
            }
            catch (Exception ex)
            {
                Ui.Error(ex);
            }
        }

        private void LoadProducts()
        {
            try
            {
                dgvProducts.DataSource = _inventory.Search(txtFind.Text.Trim(), false, false);
                Theme.Hide(dgvProducts, "ProductId", "Sku", "Barcode", "CategoryId", "CategoryName",
                           "Cost", "ReorderLevel", "IsActive", "HasImage", "IsLow");
                Theme.Header(dgvProducts, "Name", "Product");
                Theme.Header(dgvProducts, "StockQty", "Stock");
                Theme.Number(dgvProducts, "Price", "N2");
                Theme.Number(dgvProducts, "StockQty", null);
            }
            catch (Exception ex)
            {
                Ui.Error(ex);
            }
        }

        // ------------------------------------------------------------ cart

        private bool AddToCart(Product p, int qty)
        {
            CartLine line = _cart.FirstOrDefault(l => l.ProductId == p.ProductId);
            int existing = line == null ? 0 : line.Quantity;

            if (existing + qty > p.StockQty)
            {
                Ui.Warn("Only " + p.StockQty + " of \"" + p.Name + "\" in stock" +
                        (existing > 0 ? " (" + existing + " already in the cart)." : "."));
                return false;
            }

            if (line == null)
            {
                _cart.Add(new CartLine
                {
                    ProductId = p.ProductId,
                    Sku = p.Sku,
                    Name = p.Name,
                    UnitPrice = p.Price,
                    Quantity = qty,
                    MaxStock = p.StockQty
                });
            }
            else
            {
                line.Quantity += qty;
                _cart.ResetBindings();
            }
            RefreshTotals();
            return true;
        }

        private CartLine SelectedLine
        {
            get
            {
                return dgvCart.SelectedRows.Count > 0 ? dgvCart.SelectedRows[0].DataBoundItem as CartLine : null;
            }
        }

        private void ReselectRow(int index)
        {
            if (index >= 0 && index < dgvCart.Rows.Count)
            {
                dgvCart.Rows[index].Selected = true;
                dgvCart.CurrentCell = dgvCart.Rows[index].Cells["Name"];
            }
        }

        private void ChangeQuantity(int delta)
        {
            CartLine line = SelectedLine;
            if (line == null)
            {
                Ui.Warn("Select an item in the cart first.");
                return;
            }

            int index = dgvCart.SelectedRows[0].Index;
            int newQty = line.Quantity + delta;
            if (newQty > line.MaxStock)
            {
                Ui.Warn("Only " + line.MaxStock + " in stock.");
                return;
            }

            if (newQty <= 0)
            {
                _cart.Remove(line);
            }
            else
            {
                line.Quantity = newQty;
                _cart.ResetBindings();
                ReselectRow(index);
            }
            RefreshTotals();
        }

        private void btnPlus_Click(object sender, EventArgs e) { ChangeQuantity(1); }

        private void btnMinus_Click(object sender, EventArgs e) { ChangeQuantity(-1); }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            CartLine line = SelectedLine;
            if (line == null)
            {
                Ui.Warn("Select an item in the cart first.");
                return;
            }
            _cart.Remove(line);
            RefreshTotals();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0) return;
            if (!Ui.Confirm("Remove all items from the cart?")) return;
            _cart.Clear();
            RefreshTotals();
            txtScan.Focus();
        }

        // ------------------------------------------------------------ scan / find

        private void txtScan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;                  // scanners "press Enter" after the code

            string code = txtScan.Text.Trim();
            if (code.Length == 0) return;

            try
            {
                Product p = _sales.FindByCode(code);
                if (p == null)
                {
                    Ui.Warn("Product not found: " + code);
                    txtScan.SelectAll();
                    return;
                }
                if (AddToCart(p, (int)nudQty.Value)) nudQty.Value = 1;
                txtScan.Clear();
            }
            catch (Exception ex)
            {
                Ui.Error(ex);
            }
            txtScan.Focus();
        }

        private void txtFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                LoadProducts();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void AddSelectedProduct()
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                Ui.Warn("Select a product in the list first.");
                return;
            }
            Product p = dgvProducts.SelectedRows[0].DataBoundItem as Product;
            if (p != null && AddToCart(p, (int)nudQty.Value)) nudQty.Value = 1;
            txtScan.Focus();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            AddSelectedProduct();
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) AddSelectedProduct();
        }

        // ------------------------------------------------------------ totals

        private void RefreshTotals()
        {
            decimal subtotal = _cart.Sum(l => l.LineTotal);
            decimal discount = Math.Min(nudDiscount.Value, subtotal);
            OrderTotals t = SalesService.Calculate(_cart, discount, _taxRate);

            lblSubtotal.Text = Ui.Peso(t.Subtotal);
            lblTaxCaption.Text = "Tax (" + _taxRate.ToString("0.##", CultureInfo.InvariantCulture) + "%)";
            lblTax.Text = Ui.Peso(t.Tax);
            lblDiscountValue.Text = "-" + Ui.Peso(t.Discount);
            lblTotal.Text = Ui.Peso(t.Total);

            bool cash = cboPayment.Text == "Cash";
            nudTendered.Enabled = cash;
            lblChange.Text = Ui.Peso(cash ? Math.Max(0m, nudTendered.Value - t.Total) : 0m);
        }

        private void nudDiscount_ValueChanged(object sender, EventArgs e) { RefreshTotals(); }

        private void nudTendered_ValueChanged(object sender, EventArgs e) { RefreshTotals(); }

        private void cboPayment_SelectedIndexChanged(object sender, EventArgs e) { RefreshTotals(); }

        // ------------------------------------------------------------ customer

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            using (var editor = new CustomerEditorForm(_user))
            {
                if (editor.ShowDialog(this) == DialogResult.OK) LoadCustomers(editor.SavedCustomerId);
            }
        }

        // ------------------------------------------------------------ checkout

        /// <summary>Also called by the F9 shortcut from MainForm.</summary>
        public void Checkout()
        {
            if (_cart.Count == 0)
            {
                Ui.Warn("The cart is empty.");
                return;
            }

            string method = cboPayment.Text;
            decimal subtotal = _cart.Sum(l => l.LineTotal);
            decimal discount = nudDiscount.Value;
            if (discount > subtotal)
            {
                Ui.Warn("The discount cannot be more than the subtotal.");
                return;
            }

            OrderTotals totals = SalesService.Calculate(_cart, discount, _taxRate);
            decimal paid = method == "Cash" ? nudTendered.Value : totals.Total;
            if (paid < totals.Total)
            {
                Ui.Warn("The amount tendered is less than the total (" + Ui.Peso(totals.Total) + ").");
                nudTendered.Focus();
                return;
            }

            Customer customer = cboCustomer.SelectedItem as Customer;
            int? customerId = (customer == null || customer.CustomerId == 0) ? (int?)null : customer.CustomerId;

            try
            {
                int orderId = _sales.Checkout(_cart.ToList(), customerId, method, discount, paid);
                _lastReceipt = _sales.GetReceipt(orderId);
                btnPreview.Enabled = true;
                btnPrint.Enabled = true;

                Ui.Info("Sale completed.\n\nOrder: " + _lastReceipt.OrderNumber +
                        "\nTotal: " + Ui.Peso(_lastReceipt.Total) +
                        "\nChange: " + Ui.Peso(_lastReceipt.Change) +
                        "\n\nUse Preview / Print receipt if the customer wants a receipt.");

                _cart.Clear();
                nudDiscount.Value = 0;
                nudTendered.Value = 0;
                cboCustomer.SelectedIndex = 0;
                RefreshTotals();
            }
            catch (Exception ex)
            {
                Ui.Error(ex);          // e.g. "Insufficient stock for ..." from the database transaction
            }

            LoadProducts();            // stock changed (or another terminal sold the item)
            txtScan.Focus();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Checkout();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (_lastReceipt == null) return;
            try { new ReceiptPrinter().Preview(_lastReceipt); }
            catch (Exception ex) { Ui.Error(ex); }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (_lastReceipt == null) return;
            try { new ReceiptPrinter().Print(_lastReceipt); }
            catch (Exception ex) { Ui.Error(ex); }
        }
    }
}
