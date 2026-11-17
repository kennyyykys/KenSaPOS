KenSaPOS - Enterprise POS & Inventory Management System
Student: Kent Robert Sayson        Solution: KenSaPOS        Database: sayson
Visual Studio 2019/2022 - C# - Windows Forms - .NET Framework 4.8 - SQL Server

MODULES
   Login            database-driven, salted SHA-256 (matches the seed data), inactive users blocked
   Dashboard        today's sales, orders, low-stock count, active products, low-stock grid
   Point of Sale    barcode/SKU scan, product search, cart (+ / - / remove / clear), customer,
                    discount (manager/admin only), Cash/Card/Mobile, change due, F9 checkout,
                    transactional order (usp_Order_Create), receipt preview + print
   Inventory        search, low-stock filter, add/edit/delete (soft), image, stock adjustment + history
   Sales Analytics  date range, revenue/orders/average, 3 charts, CSV export
   Users & Roles    add/edit users, roles, activate/deactivate, reset password (admin only)

HOW TO RUN
1. Open Database\01_CreateDatabase.sql in SSMS (or Visual Studio > SQL Server Object Explorer) and run it.
   It creates the database "sayson", tables, stored procedures and seed data.
   Safe to run again: existing data is kept and any new procedures are added.
2. Open KenSaPOS.sln in Visual Studio. Right-click KenSaPOS.WinForms > Set as Startup Project.
3. If you do not use LocalDB, edit the Data Source in KenSaPOS.WinForms\App.config.
   (Tax rate and receipt header text are in the same file, under appSettings.)
4. Press F5.

LOGINS
   admin / Admin@123       (everything)
   manager / Manager@123   (Dashboard, POS, Inventory, Analytics)
   cashier / Cashier@123   (Dashboard, POS)

SOLUTION LAYOUT (same layers as the tutorial)
   KenSaPOS.Domain    business objects
   KenSaPOS.Data      connection, password hashing, repositories (stored procedures)
   KenSaPOS.Services  business rules and role checks
   KenSaPOS.WinForms  LoginForm, MainForm, DashboardControl, PosControl, InventoryControl,
                      AnalyticsControl, UsersControl, ProductEditorForm, UserEditorForm,
                      CustomerEditorForm, ReceiptPrinter
