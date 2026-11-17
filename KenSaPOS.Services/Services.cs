using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using KenSaPOS.Data;
using KenSaPOS.Domain;

namespace KenSaPOS.Services
{
    public sealed class AuthService
    {
        private readonly UserRepository _users = new UserRepository();

        /// <summary>Returns the user on success, or null for any invalid credential / inactive account.</summary>
        public User Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(password)) return null;

            User user = _users.Login(username.Trim(), password);
            if (user != null) _users.TouchLogin(user.UserId);
            return user;
        }
    }

    public sealed class DashboardService
    {
        private readonly DashboardRepository _repo = new DashboardRepository();

        public DashboardMetrics GetMetrics() { return _repo.GetMetrics(); }
        public List<LowStockItem> GetLowStock() { return _repo.GetLowStock(); }
    }

    public sealed class InventoryService
    {
        private const int MaxImageBytes = 1024 * 1024;

        private readonly User _actor;
        private readonly ProductRepository _products = new ProductRepository();
        private readonly CategoryRepository _categories = new CategoryRepository();
        private readonly InventoryRepository _inventory = new InventoryRepository();

        public InventoryService(User actor)
        {
            if (actor == null) throw new ArgumentNullException("actor");
            _actor = actor;
        }

        // Authorization is enforced here, not only by hiding menus.
        private void RequireManager()
        {
            if (!_actor.IsManagerOrAdmin)
                throw new UnauthorizedAccessException("You do not have permission to change inventory.");
        }

        public List<Product> Search(string search, bool lowStockOnly, bool includeInactive)
        {
            return _products.Search(search, lowStockOnly, includeInactive);
        }

        public List<Category> GetCategories() { return _categories.GetAll(); }

        public byte[] GetImage(int productId) { return _products.GetImage(productId); }

        public List<InventoryLogEntry> GetLog(int productId) { return _inventory.GetLog(productId); }

        /// <summary>Creates (ProductId == 0) or updates a product. Returns the product id.</summary>
        public int Save(Product p, byte[] image, bool changeImage)
        {
            RequireManager();

            if (p == null) throw new ArgumentNullException("p");
            p.Sku = (p.Sku ?? "").Trim();
            p.Name = (p.Name ?? "").Trim();
            p.Barcode = string.IsNullOrWhiteSpace(p.Barcode) ? null : p.Barcode.Trim();

            if (p.Sku.Length == 0) throw new ArgumentException("SKU is required.");
            if (p.Sku.Length > 30) throw new ArgumentException("SKU can have at most 30 characters.");
            if (p.Name.Length == 0) throw new ArgumentException("Product name is required.");
            if (p.Name.Length > 150) throw new ArgumentException("Product name can have at most 150 characters.");
            if (p.Barcode != null && p.Barcode.Length > 50) throw new ArgumentException("Barcode can have at most 50 characters.");
            if (p.CategoryId <= 0) throw new ArgumentException("Select a category.");
            if (p.Price < 0) throw new ArgumentException("Selling price cannot be negative.");
            if (p.Cost < 0) throw new ArgumentException("Cost price cannot be negative.");
            if (p.StockQty < 0) throw new ArgumentException("Stock cannot be negative.");
            if (p.ReorderLevel < 0) throw new ArgumentException("Reorder level cannot be negative.");
            if (image != null && image.Length > MaxImageBytes) throw new ArgumentException("Image must be 1 MB or smaller.");

            try
            {
                if (p.ProductId == 0) return _products.Insert(p, image, _actor.UserId);

                _products.Update(p, image, changeImage);
                return p.ProductId;
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                if (ex.Message.IndexOf("Barcode", StringComparison.OrdinalIgnoreCase) >= 0)
                    throw new InvalidOperationException("Another product already uses this barcode.");
                throw new InvalidOperationException("Another product already uses this SKU.");
            }
        }

        /// <summary>Soft delete: the product is deactivated so past sales stay intact.</summary>
        public void Delete(int productId)
        {
            RequireManager();
            _products.Delete(productId);
        }

        /// <summary>Adds (positive) or removes (negative) stock and writes the inventory log. Returns new stock.</summary>
        public int Adjust(int productId, int changeQty, string reason)
        {
            RequireManager();
            if (changeQty == 0) throw new ArgumentException("Enter a quantity other than zero.");
            if (string.IsNullOrWhiteSpace(reason)) throw new ArgumentException("Enter or choose a reason for the adjustment.");
            if (reason.Trim().Length > 200) throw new ArgumentException("Reason can have at most 200 characters.");

            return _inventory.Adjust(productId, changeQty, reason.Trim(), _actor.UserId);
        }
    }

    /// <summary>Printing is hidden behind this interface so checkout does not depend on a specific printer.</summary>
    public interface IReceiptPrinter
    {
        void Print(ReceiptData receipt);
        void Preview(ReceiptData receipt);
    }

    public sealed class SalesService
    {
        public static readonly string[] PaymentMethods = { "Cash", "Card", "Mobile" };

        private readonly User _actor;
        private readonly OrderRepository _orders = new OrderRepository();
        private readonly CustomerRepository _customers = new CustomerRepository();
        private readonly ProductRepository _products = new ProductRepository();

        public SalesService(User actor)
        {
            if (actor == null) throw new ArgumentNullException("actor");
            _actor = actor;
        }

        public decimal TaxRatePercent
        {
            get { return Db.TaxRatePercent; }
        }

        /// <summary>
        /// Same formula as dbo.usp_Order_Create:
        /// tax = ROUND((subtotal - discount) * rate / 100, 2), total = subtotal - discount + tax.
        /// </summary>
        public static OrderTotals Calculate(IEnumerable<CartLine> lines, decimal discount, decimal taxRatePercent)
        {
            decimal subtotal = 0m;
            foreach (CartLine l in lines) subtotal += l.LineTotal;

            decimal tax = Math.Round((subtotal - discount) * taxRatePercent / 100m, 2, MidpointRounding.AwayFromZero);
            return new OrderTotals
            {
                Subtotal = subtotal,
                Discount = discount,
                Tax = tax,
                Total = subtotal - discount + tax
            };
        }

        /// <summary>Finds an active product by exact SKU or barcode (what a barcode scanner types).</summary>
        public Product FindByCode(string code)
        {
            code = (code ?? "").Trim();
            if (code.Length == 0) return null;

            foreach (Product p in _products.Search(code, false, false))
            {
                if (string.Equals(p.Sku, code, StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(p.Barcode, code, StringComparison.OrdinalIgnoreCase))
                    return p;
            }
            return null;
        }

        public List<Customer> GetCustomers() { return _customers.GetAll(); }

        public int AddCustomer(Customer c)
        {
            if (c == null) throw new ArgumentNullException("c");
            c.FullName = (c.FullName ?? "").Trim();
            if (c.FullName.Length == 0) throw new ArgumentException("Customer name is required.");
            c.Phone = string.IsNullOrWhiteSpace(c.Phone) ? null : c.Phone.Trim();
            c.Email = string.IsNullOrWhiteSpace(c.Email) ? null : c.Email.Trim();
            c.Address = string.IsNullOrWhiteSpace(c.Address) ? null : c.Address.Trim();
            return _customers.Insert(c);
        }

        /// <summary>Creates the order. The database transaction is the source of truth for stock.</summary>
        public int Checkout(IList<CartLine> lines, int? customerId, string paymentMethod, decimal discount, decimal amountPaid)
        {
            if (lines == null || lines.Count == 0) throw new InvalidOperationException("The cart is empty.");
            if (lines.Any(l => l.Quantity <= 0)) throw new ArgumentException("Every item needs a quantity of at least 1.");
            if (Array.IndexOf(PaymentMethods, paymentMethod) < 0) throw new ArgumentException("Select a valid payment method.");
            if (discount < 0) throw new ArgumentException("Discount cannot be negative.");
            if (discount > 0 && !_actor.IsManagerOrAdmin)
                throw new UnauthorizedAccessException("Only a manager or administrator can give a discount.");

            OrderTotals totals = Calculate(lines, discount, TaxRatePercent);
            if (discount > totals.Subtotal) throw new ArgumentException("The discount cannot be more than the subtotal.");
            if (amountPaid < totals.Total) throw new ArgumentException("The amount paid is less than the total.");

            var xml = new System.Text.StringBuilder("<Items>");
            foreach (CartLine l in lines)
            {
                xml.Append(string.Format(CultureInfo.InvariantCulture,
                    "<Item ProductId=\"{0}\" Quantity=\"{1}\"/>", l.ProductId, l.Quantity));
            }
            xml.Append("</Items>");

            return _orders.Create(_actor.UserId, customerId, paymentMethod, discount, TaxRatePercent, amountPaid, xml.ToString());
        }

        /// <summary>Builds the receipt from the committed order.</summary>
        public ReceiptData GetReceipt(int orderId)
        {
            ReceiptData r = _orders.GetReceipt(orderId);
            r.BusinessName = Db.Setting("BusinessName", "Enterprise Store");
            r.Address = Db.Setting("BusinessAddress", "123 Main Street, City");
            r.Phone = Db.Setting("BusinessPhone", "");
            return r;
        }
    }

    public sealed class ReportingService
    {
        private readonly User _actor;
        private readonly ReportRepository _repo = new ReportRepository();

        public ReportingService(User actor)
        {
            if (actor == null) throw new ArgumentNullException("actor");
            _actor = actor;
        }

        private void RequireManager()
        {
            if (!_actor.IsManagerOrAdmin)
                throw new UnauthorizedAccessException("You do not have permission to view sales analytics.");
        }

        public List<DailySales> GetDaily(DateTime from, DateTime to)
        {
            RequireManager();
            return _repo.Daily(from.Date, to.Date);
        }

        public List<TopProduct> GetTopProducts(DateTime from, DateTime to, int top)
        {
            RequireManager();
            return _repo.TopProducts(from.Date, to.Date, top);
        }

        public List<CategorySales> GetCategorySales(DateTime from, DateTime to)
        {
            RequireManager();
            return _repo.Categories(from.Date, to.Date);
        }
    }

    public sealed class UserAdminService
    {
        private readonly User _actor;
        private readonly UserAdminRepository _repo = new UserAdminRepository();

        public UserAdminService(User actor)
        {
            if (actor == null) throw new ArgumentNullException("actor");
            _actor = actor;
        }

        private void RequireAdmin()
        {
            if (!_actor.IsAdmin)
                throw new UnauthorizedAccessException("Only an administrator can manage users.");
        }

        public List<UserAccount> GetUsers()
        {
            RequireAdmin();
            return _repo.GetUsers();
        }

        public List<Role> GetRoles()
        {
            RequireAdmin();
            return _repo.GetRoles();
        }

        private static void ValidatePassword(string password)
        {
            if (password == null || password.Length < 8)
                throw new ArgumentException("The password must be at least 8 characters.");
        }

        public int CreateUser(string username, string fullName, int roleId, string password)
        {
            RequireAdmin();
            username = (username ?? "").Trim();
            fullName = (fullName ?? "").Trim();

            if (username.Length < 3) throw new ArgumentException("The username must have at least 3 characters.");
            if (username.Length > 50) throw new ArgumentException("The username can have at most 50 characters.");
            if (username.Any(char.IsWhiteSpace)) throw new ArgumentException("The username cannot contain spaces.");
            if (fullName.Length == 0) throw new ArgumentException("Full name is required.");
            if (roleId <= 0) throw new ArgumentException("Select a role.");
            ValidatePassword(password);

            string salt = PasswordHasher.NewSalt();
            return _repo.Create(username, PasswordHasher.Hash(salt, password), salt, fullName, roleId);
        }

        /// <summary>Updates the account. A non-empty newPassword also resets the password.</summary>
        public void UpdateUser(int userId, string fullName, int roleId, bool isActive, string newPassword)
        {
            RequireAdmin();
            fullName = (fullName ?? "").Trim();

            if (fullName.Length == 0) throw new ArgumentException("Full name is required.");
            if (roleId <= 0) throw new ArgumentException("Select a role.");
            if (userId == _actor.UserId && !isActive)
                throw new InvalidOperationException("You cannot deactivate your own account.");

            bool resetPassword = !string.IsNullOrEmpty(newPassword);
            if (resetPassword) ValidatePassword(newPassword);

            _repo.Update(userId, fullName, roleId, isActive);     // also guarantees one active Admin remains

            if (resetPassword)
            {
                string salt = PasswordHasher.NewSalt();
                _repo.SetPassword(userId, PasswordHasher.Hash(salt, newPassword), salt);
            }
        }
    }
}
