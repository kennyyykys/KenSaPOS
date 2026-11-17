using System;
using System.Collections.Generic;
using System.Data;
using KenSaPOS.Domain;

namespace KenSaPOS.Data
{
    public sealed class UserRepository
    {
        /// <summary>Returns the user when the credentials are valid and the account is active; otherwise null.</summary>
        public User Login(string username, string password)
        {
            DataTable table = Db.Table("dbo.usp_Login", Db.P("@Username", username));
            if (table.Rows.Count == 0) return null;

            DataRow r = table.Rows[0];
            if (!Convert.ToBoolean(r["IsActive"])) return null;
            if (!PasswordHasher.Verify(Convert.ToString(r["Salt"]), password, Convert.ToString(r["PasswordHash"])))
                return null;

            return new User
            {
                UserId = Convert.ToInt32(r["UserId"]),
                Username = Convert.ToString(r["Username"]),
                FullName = Convert.ToString(r["FullName"]),
                RoleName = Convert.ToString(r["RoleName"]),
                IsActive = true
            };
        }

        public void TouchLogin(int userId)
        {
            Db.Table("dbo.usp_User_TouchLogin", Db.P("@UserId", userId));
        }
    }

    public sealed class CategoryRepository
    {
        public List<Category> GetAll()
        {
            var list = new List<Category>();
            foreach (DataRow r in Db.Table("dbo.usp_Category_List").Rows)
            {
                list.Add(new Category
                {
                    CategoryId = Convert.ToInt32(r["CategoryId"]),
                    Name = Convert.ToString(r["Name"])
                });
            }
            return list;
        }
    }

    public sealed class ProductRepository
    {
        public List<Product> Search(string search, bool lowStockOnly, bool includeInactive)
        {
            DataTable table = Db.Table("dbo.usp_Product_Search",
                Db.P("@Search", string.IsNullOrWhiteSpace(search) ? null : search),
                Db.P("@LowStockOnly", lowStockOnly),
                Db.P("@IncludeInactive", includeInactive));

            var list = new List<Product>();
            foreach (DataRow r in table.Rows)
            {
                list.Add(new Product
                {
                    ProductId = Convert.ToInt32(r["ProductId"]),
                    Sku = Convert.ToString(r["Sku"]),
                    Barcode = r["Barcode"] as string,
                    Name = Convert.ToString(r["Name"]),
                    CategoryId = Convert.ToInt32(r["CategoryId"]),
                    CategoryName = Convert.ToString(r["CategoryName"]),
                    Price = Convert.ToDecimal(r["Price"]),
                    Cost = Convert.ToDecimal(r["Cost"]),
                    StockQty = Convert.ToInt32(r["StockQty"]),
                    ReorderLevel = Convert.ToInt32(r["ReorderLevel"]),
                    IsActive = Convert.ToBoolean(r["IsActive"]),
                    HasImage = Convert.ToBoolean(r["HasImage"])
                });
            }
            return list;
        }

        public byte[] GetImage(int productId)
        {
            DataTable table = Db.Table("dbo.usp_Product_GetImage", Db.P("@ProductId", productId));
            if (table.Rows.Count == 0 || table.Rows[0]["Image"] == DBNull.Value) return null;
            return (byte[])table.Rows[0]["Image"];
        }

        public int Insert(Product p, byte[] image, int userId)
        {
            DataTable table = Db.Table("dbo.usp_Product_Insert",
                Db.P("@Sku", p.Sku),
                Db.P("@Barcode", p.Barcode),
                Db.P("@Name", p.Name),
                Db.P("@CategoryId", p.CategoryId),
                Db.Money("@Price", p.Price),
                Db.Money("@Cost", p.Cost),
                Db.P("@StockQty", p.StockQty),
                Db.P("@ReorderLevel", p.ReorderLevel),
                Db.Bytes("@Image", image),
                Db.P("@UserId", userId));
            return Convert.ToInt32(table.Rows[0]["Id"]);
        }

        public void Update(Product p, byte[] image, bool changeImage)
        {
            Db.Table("dbo.usp_Product_Update",
                Db.P("@ProductId", p.ProductId),
                Db.P("@Sku", p.Sku),
                Db.P("@Barcode", p.Barcode),
                Db.P("@Name", p.Name),
                Db.P("@CategoryId", p.CategoryId),
                Db.Money("@Price", p.Price),
                Db.Money("@Cost", p.Cost),
                Db.P("@ReorderLevel", p.ReorderLevel),
                Db.P("@IsActive", p.IsActive),
                Db.Bytes("@Image", image),
                Db.P("@ChangeImage", changeImage));
        }

        public void Delete(int productId)
        {
            Db.Table("dbo.usp_Product_Delete", Db.P("@ProductId", productId));
        }
    }

    public sealed class InventoryRepository
    {
        public int Adjust(int productId, int changeQty, string reason, int userId)
        {
            DataTable table = Db.Table("dbo.usp_Inventory_Adjust",
                Db.P("@ProductId", productId),
                Db.P("@ChangeQty", changeQty),
                Db.P("@Reason", reason),
                Db.P("@UserId", userId));
            return Convert.ToInt32(table.Rows[0]["NewStock"]);
        }

        public List<InventoryLogEntry> GetLog(int productId)
        {
            var list = new List<InventoryLogEntry>();
            foreach (DataRow r in Db.Table("dbo.usp_InventoryLog_ByProduct", Db.P("@ProductId", productId)).Rows)
            {
                list.Add(new InventoryLogEntry
                {
                    CreatedAt = Convert.ToDateTime(r["CreatedAt"]),
                    ChangeQty = Convert.ToInt32(r["ChangeQty"]),
                    Reason = Convert.ToString(r["Reason"]),
                    ByUser = Convert.ToString(r["ByUser"])
                });
            }
            return list;
        }
    }

    public sealed class DashboardRepository
    {
        public DashboardMetrics GetMetrics()
        {
            DataTable table = Db.Table("dbo.usp_Report_Dashboard");
            DataRow r = table.Rows[0];
            return new DashboardMetrics
            {
                TodaySales = Convert.ToDecimal(r["TodaySales"]),
                TodayOrders = Convert.ToInt32(r["TodayOrders"]),
                LowStockCount = Convert.ToInt32(r["LowStockCount"]),
                ActiveProducts = Convert.ToInt32(r["ActiveProducts"])
            };
        }

        public List<LowStockItem> GetLowStock()
        {
            var list = new List<LowStockItem>();
            foreach (DataRow r in Db.Table("dbo.usp_Report_LowStock").Rows)
            {
                list.Add(new LowStockItem
                {
                    Sku = Convert.ToString(r["Sku"]),
                    Name = Convert.ToString(r["Name"]),
                    StockQty = Convert.ToInt32(r["StockQty"]),
                    ReorderLevel = Convert.ToInt32(r["ReorderLevel"])
                });
            }
            return list;
        }
    }

    public sealed class CustomerRepository
    {
        public List<Customer> GetAll()
        {
            var list = new List<Customer>();
            foreach (DataRow r in Db.Table("dbo.usp_Customer_List").Rows)
            {
                list.Add(new Customer
                {
                    CustomerId = Convert.ToInt32(r["CustomerId"]),
                    FullName = Convert.ToString(r["FullName"]),
                    Phone = r["Phone"] as string,
                    Email = r["Email"] as string,
                    Address = r["Address"] as string
                });
            }
            return list;
        }

        public int Insert(Customer c)
        {
            DataTable t = Db.Table("dbo.usp_Customer_Insert",
                Db.P("@FullName", c.FullName),
                Db.P("@Phone", c.Phone),
                Db.P("@Email", c.Email),
                Db.P("@Address", c.Address));
            return Convert.ToInt32(t.Rows[0]["Id"]);
        }
    }

    public sealed class OrderRepository
    {
        /// <summary>
        /// Creates the order in ONE database transaction (stock check, lines, stock deduction, inventory log).
        /// itemsXml looks like: &lt;Items&gt;&lt;Item ProductId="1" Quantity="2"/&gt;&lt;/Items&gt;
        /// </summary>
        public int Create(int userId, int? customerId, string paymentMethod, decimal discount,
                          decimal taxRatePercent, decimal amountPaid, string itemsXml)
        {
            DataTable t = Db.Table("dbo.usp_Order_Create",
                Db.P("@UserId", userId),
                Db.P("@CustomerId", customerId),
                Db.P("@PaymentMethod", paymentMethod),
                Db.Money("@DiscountAmount", discount),
                Db.Decimal("@TaxRate", taxRatePercent, 5, 2),
                Db.Money("@AmountPaid", amountPaid),
                Db.Xml("@ItemsXml", itemsXml));
            return Convert.ToInt32(t.Rows[0]["Id"]);
        }

        public ReceiptData GetReceipt(int orderId)
        {
            DataTable header = Db.Table("dbo.usp_Receipt_Header", Db.P("@OrderId", orderId));
            if (header.Rows.Count == 0) throw new InvalidOperationException("Order not found.");

            DataRow h = header.Rows[0];
            var receipt = new ReceiptData
            {
                OrderNumber = Convert.ToString(h["OrderNumber"]),
                Date = Convert.ToDateTime(h["OrderDate"]),
                CashierName = Convert.ToString(h["CashierName"]),
                CustomerName = h["CustomerName"] as string,
                Subtotal = Convert.ToDecimal(h["Subtotal"]),
                Tax = Convert.ToDecimal(h["TaxAmount"]),
                Discount = Convert.ToDecimal(h["DiscountAmount"]),
                Total = Convert.ToDecimal(h["Total"]),
                PaymentMethod = Convert.ToString(h["PaymentMethod"]),
                AmountPaid = Convert.ToDecimal(h["AmountPaid"]),
                Change = Convert.ToDecimal(h["ChangeDue"])
            };

            foreach (DataRow r in Db.Table("dbo.usp_Receipt_Lines", Db.P("@OrderId", orderId)).Rows)
            {
                receipt.Lines.Add(new ReceiptLine
                {
                    ProductName = Convert.ToString(r["ProductName"]),
                    Quantity = Convert.ToInt32(r["Quantity"]),
                    UnitPrice = Convert.ToDecimal(r["UnitPrice"]),
                    Amount = Convert.ToDecimal(r["LineTotal"])
                });
            }
            return receipt;
        }
    }

    public sealed class ReportRepository
    {
        public List<DailySales> Daily(DateTime from, DateTime to)
        {
            var list = new List<DailySales>();
            foreach (DataRow r in Db.Table("dbo.usp_Report_DailySales", Db.P("@From", from), Db.P("@To", to)).Rows)
            {
                list.Add(new DailySales
                {
                    SaleDate = Convert.ToDateTime(r["SaleDate"]),
                    OrderCount = Convert.ToInt32(r["OrderCount"]),
                    Revenue = Convert.ToDecimal(r["Revenue"])
                });
            }
            return list;
        }

        public List<TopProduct> TopProducts(DateTime from, DateTime to, int top)
        {
            var list = new List<TopProduct>();
            foreach (DataRow r in Db.Table("dbo.usp_Report_TopProducts",
                         Db.P("@From", from), Db.P("@To", to), Db.P("@Top", top)).Rows)
            {
                list.Add(new TopProduct
                {
                    ProductName = Convert.ToString(r["ProductName"]),
                    QtySold = Convert.ToInt32(r["QtySold"]),
                    Revenue = Convert.ToDecimal(r["Revenue"])
                });
            }
            return list;
        }

        public List<CategorySales> Categories(DateTime from, DateTime to)
        {
            var list = new List<CategorySales>();
            foreach (DataRow r in Db.Table("dbo.usp_Report_SalesByCategory", Db.P("@From", from), Db.P("@To", to)).Rows)
            {
                list.Add(new CategorySales
                {
                    CategoryName = Convert.ToString(r["CategoryName"]),
                    Revenue = Convert.ToDecimal(r["Revenue"])
                });
            }
            return list;
        }
    }

    public sealed class UserAdminRepository
    {
        public List<Role> GetRoles()
        {
            var list = new List<Role>();
            foreach (DataRow r in Db.Table("dbo.usp_Role_List").Rows)
            {
                list.Add(new Role
                {
                    RoleId = Convert.ToInt32(r["RoleId"]),
                    RoleName = Convert.ToString(r["RoleName"])
                });
            }
            return list;
        }

        public List<UserAccount> GetUsers()
        {
            var list = new List<UserAccount>();
            foreach (DataRow r in Db.Table("dbo.usp_User_List").Rows)
            {
                list.Add(new UserAccount
                {
                    UserId = Convert.ToInt32(r["UserId"]),
                    Username = Convert.ToString(r["Username"]),
                    FullName = Convert.ToString(r["FullName"]),
                    RoleId = Convert.ToInt32(r["RoleId"]),
                    RoleName = Convert.ToString(r["RoleName"]),
                    IsActive = Convert.ToBoolean(r["IsActive"]),
                    CreatedAt = Convert.ToDateTime(r["CreatedAt"]),
                    LastLoginAt = r["LastLoginAt"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(r["LastLoginAt"])
                });
            }
            return list;
        }

        public int Create(string username, string passwordHash, string salt, string fullName, int roleId)
        {
            DataTable t = Db.Table("dbo.usp_User_Create",
                Db.P("@Username", username),
                Db.P("@PasswordHash", passwordHash),
                Db.P("@Salt", salt),
                Db.P("@FullName", fullName),
                Db.P("@RoleId", roleId));
            return Convert.ToInt32(t.Rows[0]["Id"]);
        }

        public void Update(int userId, string fullName, int roleId, bool isActive)
        {
            Db.Table("dbo.usp_User_Update",
                Db.P("@UserId", userId),
                Db.P("@FullName", fullName),
                Db.P("@RoleId", roleId),
                Db.P("@IsActive", isActive));
        }

        public void SetPassword(int userId, string passwordHash, string salt)
        {
            Db.Table("dbo.usp_User_SetPassword",
                Db.P("@UserId", userId),
                Db.P("@PasswordHash", passwordHash),
                Db.P("@Salt", salt));
        }
    }
}
