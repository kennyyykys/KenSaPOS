using System;
using System.Windows.Forms;
using KenSaPOS.Domain;
using KenSaPOS.Services;

namespace KenSaPOS.WinForms
{
    public partial class CustomerEditorForm : Form
    {
        private readonly SalesService _sales;

        public int SavedCustomerId { get; private set; }

        public CustomerEditorForm(User user)
        {
            _sales = new SalesService(user);
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length == 0)
            {
                Ui.Warn("Customer name is required.");
                return;
            }

            try
            {
                SavedCustomerId = _sales.AddCustomer(new Customer
                {
                    FullName = txtName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text
                });
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Ui.Warn(Ui.Describe(ex));
            }
        }
    }
}
