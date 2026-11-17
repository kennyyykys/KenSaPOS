using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using KenSaPOS.Domain;
using KenSaPOS.Services;

namespace KenSaPOS.WinForms
{
    public partial class ProductEditorForm : Form
    {
        private readonly InventoryService _service;
        private readonly Product _product;          // null = adding a new product
        private byte[] _imageBytes;
        private bool _imageChanged;

        public int SavedProductId { get; private set; }

        public ProductEditorForm(User user, Product product)
        {
            _service = new InventoryService(user);
            _product = product;
            InitializeComponent();
        }

        private void ProductEditorForm_Load(object sender, EventArgs e)
        {
            try
            {
                cboCategory.DisplayMember = "Name";
                cboCategory.ValueMember = "CategoryId";
                cboCategory.DataSource = _service.GetCategories();

                if (_product == null)
                {
                    Text = "Add Product";
                    chkActive.Checked = true;
                    chkActive.Enabled = false;
                    lblStockNote.Visible = false;
                    return;
                }

                Text = "Edit Product";
                txtSku.Text = _product.Sku;
                txtBarcode.Text = _product.Barcode;
                txtName.Text = _product.Name;
                cboCategory.SelectedValue = _product.CategoryId;
                nudPrice.Value = _product.Price;
                nudCost.Value = _product.Cost;
                nudReorder.Value = _product.ReorderLevel;
                chkActive.Checked = _product.IsActive;

                lblStock.Text = "Stock";
                nudStock.Value = _product.StockQty;
                nudStock.Enabled = false;

                if (_product.HasImage) ShowImage(_service.GetImage(_product.ProductId));
            }
            catch (Exception ex)
            {
                Ui.Error(ex);
                btnSave.Enabled = false;
            }
        }

        private void ShowImage(byte[] bytes)
        {
            Image fresh = null;
            if (bytes != null && bytes.Length > 0)
            {
                using (var ms = new MemoryStream(bytes))
                using (Image temp = Image.FromStream(ms))
                {
                    fresh = new Bitmap(temp);       // copy, so the stream can be closed
                }
            }

            Image old = picImage.Image;
            picImage.Image = fresh;
            if (old != null) old.Dispose();
            _imageBytes = bytes;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Images (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                dialog.CheckFileExists = true;
                if (dialog.ShowDialog(this) != DialogResult.OK) return;

                if (new FileInfo(dialog.FileName).Length > 1024 * 1024)
                {
                    Ui.Warn("The image must be 1 MB or smaller.");
                    return;
                }

                try
                {
                    ShowImage(File.ReadAllBytes(dialog.FileName));
                    _imageChanged = true;
                }
                catch (Exception)
                {
                    Ui.Warn("The selected file is not a valid image.");
                }
            }
        }

        private void btnClearImage_Click(object sender, EventArgs e)
        {
            ShowImage(null);
            _imageChanged = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSku.Text.Trim().Length == 0 || txtName.Text.Trim().Length == 0)
            {
                Ui.Warn("SKU and product name are required.");
                return;
            }
            if (cboCategory.SelectedValue == null)
            {
                Ui.Warn("Select a category.");
                return;
            }

            var p = new Product
            {
                ProductId = _product == null ? 0 : _product.ProductId,
                Sku = txtSku.Text.Trim(),
                Barcode = txtBarcode.Text.Trim(),
                Name = txtName.Text.Trim(),
                CategoryId = Convert.ToInt32(cboCategory.SelectedValue),
                Price = nudPrice.Value,
                Cost = nudCost.Value,
                StockQty = (int)nudStock.Value,
                ReorderLevel = (int)nudReorder.Value,
                IsActive = chkActive.Checked
            };

            try
            {
                SavedProductId = _service.Save(p, _imageBytes, _imageChanged);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Ui.Warn(ex.Message);
            }
        }
    }
}
