using System;
using System.Collections.Generic;

namespace KenSaPOS.Domain
{
    public static class RoleNames
    {
        public const string Admin = "Admin";
        public const string Manager = "Manager";
        public const string Cashier = "Cashier";
    }

    /// <summary>The signed-in user.</summary>
    public sealed class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string RoleName { get; set; }
        public bool IsActive { get; set; }

        public bool IsAdmin
        {
            get { return string.Equals(RoleName, RoleNames.Admin, StringComparison.OrdinalIgnoreCase); }
        }

        public bool IsManagerOrAdmin
        {
            get { return IsAdmin || string.Equals(RoleName, RoleNames.Manager, StringComparison.OrdinalIgnoreCase); }
        }
    }

    public sealed class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }

    public sealed class Product
    {
        public int ProductId { get; set; }
        public string Sku { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public int StockQty { get; set; }
        public int ReorderLevel { get; set; }
        public bool IsActive { get; set; }
        public bool HasImage { get; set; }

        /// <summary>True when stock is at or below the reorder level.</summary>
        public bool IsLow
        {
            get { return StockQty <= ReorderLevel; }
        }
    }

    public sealed class InventoryLogEntry
    {
        public DateTime CreatedAt { get; set; }
        public int ChangeQty { get; set; }
        public string Reason { get; set; }
        public string ByUser { get; set; }
    }

    public sealed class DashboardMetrics
    {
        public decimal TodaySales { get; set; }
        public int TodayOrders { get; set; }
        public int LowStockCount { get; set; }
        public int ActiveProducts { get; set; }
    }

    public sealed class LowStockItem
    {
        public string Sku { get; set; }
        public string Name { get; set; }
        public int StockQty { get; set; }
        public int ReorderLevel { get; set; }
    }

    // ---------------------------------------------------------------- POS

    public sealed class Customer
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        /// <summary>Text shown in the customer drop-down.</summary>
        public string Display
        {
            get { return string.IsNullOrEmpty(Phone) ? FullName : FullName + " - " + Phone; }
        }
    }

    public sealed class CartLine
    {
        public int ProductId { get; set; }
        public string Sku { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int MaxStock { get; set; }

        public decimal LineTotal
        {
            get { return UnitPrice * Quantity; }
        }
    }

    public sealed class OrderTotals
    {
        public decimal Subtotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
    }

    public sealed class ReceiptLine
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
    }

    public sealed class ReceiptData
    {
        public string BusinessName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string OrderNumber { get; set; }
        public DateTime Date { get; set; }
        public string CashierName { get; set; }
        public string CustomerName { get; set; }
        public List<ReceiptLine> Lines { get; } = new List<ReceiptLine>();
        public decimal Subtotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public string PaymentMethod { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal Change { get; set; }
    }

    // ---------------------------------------------------------- analytics

    public sealed class DailySales
    {
        public DateTime SaleDate { get; set; }
        public int OrderCount { get; set; }
        public decimal Revenue { get; set; }
    }

    public sealed class TopProduct
    {
        public string ProductName { get; set; }
        public int QtySold { get; set; }
        public decimal Revenue { get; set; }
    }

    public sealed class CategorySales
    {
        public string CategoryName { get; set; }
        public decimal Revenue { get; set; }
    }

    // ------------------------------------------------------ users & roles

    public sealed class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }

    public sealed class UserAccount
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLoginAt { get; set; }
    }
}
