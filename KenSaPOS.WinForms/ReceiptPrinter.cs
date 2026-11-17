using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;
using KenSaPOS.Domain;
using KenSaPOS.Services;

namespace KenSaPOS.WinForms
{
    /// <summary>Prints (or previews) a receipt on an 80 mm roll using PrintDocument.</summary>
    public sealed class ReceiptPrinter : IReceiptPrinter
    {
        private const int Width = 40;                 // characters per line
        private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

        private readonly PrintDocument _document = new PrintDocument();
        private readonly Font _normal = new Font("Consolas", 8.5f);
        private readonly Font _bold = new Font("Consolas", 8.5f, FontStyle.Bold);
        private ReceiptData _current;

        public ReceiptPrinter()
        {
            _document.DocumentName = "KenSaPOS Receipt";
            try
            {
                _document.DefaultPageSettings.PaperSize = new PaperSize("Receipt", 315, 900);
                _document.DefaultPageSettings.Margins = new Margins(12, 12, 12, 12);
            }
            catch (InvalidPrinterException)
            {
                // No printer installed: Print/Preview will report it.
            }
            _document.PrintPage += PrintPage;
        }

        public void Print(ReceiptData receipt)
        {
            _current = receipt ?? throw new ArgumentNullException("receipt");
            using (var dialog = new PrintDialog { Document = _document, AllowSomePages = false })
            {
                if (dialog.ShowDialog() == DialogResult.OK) _document.Print();
            }
        }

        public void Preview(ReceiptData receipt)
        {
            _current = receipt ?? throw new ArgumentNullException("receipt");
            using (var preview = new PrintPreviewDialog { Document = _document, Width = 700, Height = 800 })
            {
                preview.ShowDialog();
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;
            int width = e.MarginBounds.Width;
            string line = new string('-', Width);

            Center(g, _current.BusinessName, _bold, ref y, x, width);
            if (!string.IsNullOrEmpty(_current.Address)) Center(g, _current.Address, _normal, ref y, x, width);
            if (!string.IsNullOrEmpty(_current.Phone)) Center(g, _current.Phone, _normal, ref y, x, width);
            Text(g, line, _normal, ref y, x);
            Text(g, "Order  : " + _current.OrderNumber, _normal, ref y, x);
            Text(g, "Date   : " + _current.Date.ToString("yyyy-MM-dd HH:mm", Inv), _normal, ref y, x);
            Text(g, "Cashier: " + _current.CashierName, _normal, ref y, x);
            if (!string.IsNullOrEmpty(_current.CustomerName))
                Text(g, "Customer: " + _current.CustomerName, _normal, ref y, x);
            Text(g, line, _normal, ref y, x);
            Text(g, string.Format(Inv, "{0,-22} {1,3} {2,10}", "Product", "Qty", "Amount"), _bold, ref y, x);

            foreach (ReceiptLine l in _current.Lines)
            {
                string name = l.ProductName ?? string.Empty;
                if (name.Length > 22) name = name.Substring(0, 22);
                Text(g, string.Format(Inv, "{0,-22} {1,3} {2,10:N2}", name, l.Quantity, l.Amount), _normal, ref y, x);
            }

            Text(g, line, _normal, ref y, x);
            Right(g, "Subtotal: " + _current.Subtotal.ToString("N2", Inv), _normal, ref y, x, width);
            Right(g, "Tax: " + _current.Tax.ToString("N2", Inv), _normal, ref y, x, width);
            Right(g, "Discount: " + _current.Discount.ToString("N2", Inv), _normal, ref y, x, width);
            Right(g, "TOTAL (PHP): " + _current.Total.ToString("N2", Inv), _bold, ref y, x, width);
            Text(g, line, _normal, ref y, x);
            Text(g, "Payment: " + _current.PaymentMethod, _normal, ref y, x);
            Right(g, "Paid: " + _current.AmountPaid.ToString("N2", Inv), _normal, ref y, x, width);
            Right(g, "Change: " + _current.Change.ToString("N2", Inv), _normal, ref y, x, width);
            y += 12;
            Center(g, "Thank you for your purchase!", _bold, ref y, x, width);
            e.HasMorePages = false;
        }

        private static void Text(Graphics g, string value, Font font, ref int y, int x)
        {
            g.DrawString(value, font, Brushes.Black, x, y);
            y += font.Height + 2;
        }

        private static void Center(Graphics g, string value, Font font, ref int y, int x, int width)
        {
            SizeF size = g.MeasureString(value, font);
            g.DrawString(value, font, Brushes.Black, x + (width - size.Width) / 2, y);
            y += font.Height + 2;
        }

        private static void Right(Graphics g, string value, Font font, ref int y, int x, int width)
        {
            SizeF size = g.MeasureString(value, font);
            g.DrawString(value, font, Brushes.Black, x + width - size.Width, y);
            y += font.Height + 2;
        }
    }
}
