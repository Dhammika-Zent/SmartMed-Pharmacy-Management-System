using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using SmartMed.Managers;

namespace SmartMed.Models
{
    internal class ReportManager
    {
        // =====================================================
        // UML Property
        // =====================================================
        public int ReportID { get; set; }

        // =====================================================
        // Private field to hold the last generated report data
        // =====================================================
        private DataTable _lastReportData;

        // =====================================================
        // UML Methods – Report Generation
        // =====================================================

        // Generate Sales Report (FR-32)
        public DataTable GenerateSalesReport()
        {
            DatabaseManager db = new DatabaseManager();
            string sql = @"
                SELECT o.OrderID          AS [Order ID],
                       c.FullName         AS Customer,
                       o.OrderDate        AS [Date],
                       o.TotalAmount      AS [Total Amount],
                       o.OrderStatus      AS Status
                FROM [Order] o
                JOIN Customer c ON o.CustomerID = c.CustomerID
                ORDER BY o.OrderDate DESC;";

            DataTable dt = db.ExecuteQuery(sql);
            _lastReportData = dt;          // store for export
            return dt;
        }

        // Generate Stock Report (FR-33)
        public DataTable GenerateStockReport()
        {
            DatabaseManager db = new DatabaseManager();
            string sql = @"
                SELECT MedicineID             AS [Medicine ID],
                       MedicineName           AS [Medicine Name],
                       Category,
                       Supplier,
                       StockQuantity          AS Stock,
                       ExpiryDate             AS [Expiry Date],
                       DiscountPercentage     AS Discount,
                       PrescriptionRequired   AS [Prescription Required]
                FROM Medicine
                ORDER BY MedicineName;";

            DataTable dt = db.ExecuteQuery(sql);
            _lastReportData = dt;
            return dt;
        }

        // Generate Customer Order History Report (FR-34)
        public DataTable GenerateCustomerOrderReport()
        {
            DatabaseManager db = new DatabaseManager();
            string sql = @"
                SELECT c.FullName             AS Customer,
                       o.OrderID              AS [Order ID],
                       o.OrderDate            AS [Date],
                       o.OrderStatus          AS Status,
                       (SELECT GROUP_CONCAT(m.MedicineName || ' (x' || oi.Quantity || ')', ', ')
                        FROM OrderItem oi
                        JOIN Medicine m ON oi.MedicineID = m.MedicineID
                        WHERE oi.OrderID = o.OrderID) AS Medicines,
                       o.TotalAmount          AS [Total Amount]
                FROM [Order] o
                JOIN Customer c ON o.CustomerID = c.CustomerID
                ORDER BY c.FullName, o.OrderDate DESC;";

            DataTable dt = db.ExecuteQuery(sql);
            _lastReportData = dt;
            return dt;
        }

        // =====================================================
        // UML Methods – Export
        // =====================================================

        // Export to Excel (FR-35) – simple CSV format
        public void ExportExcel()
        {
            if (_lastReportData == null || _lastReportData.Rows.Count == 0)
            {
                MessageBox.Show("No report data to export.", "Export Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel CSV (*.csv)|*.csv|All Files (*.*)|*.*";
                sfd.Title = "Export to Excel";
                sfd.FileName = "Report.csv";

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    StringBuilder csv = new StringBuilder();

                    // Header
                    string[] columnNames = new string[_lastReportData.Columns.Count];
                    for (int i = 0; i < _lastReportData.Columns.Count; i++)
                        columnNames[i] = QuoteCsvField(_lastReportData.Columns[i].ColumnName);
                    csv.AppendLine(string.Join(",", columnNames));

                    // Data rows
                    foreach (DataRow row in _lastReportData.Rows)
                    {
                        string[] fields = new string[_lastReportData.Columns.Count];
                        for (int i = 0; i < _lastReportData.Columns.Count; i++)
                            fields[i] = QuoteCsvField(row[i].ToString());
                        csv.AppendLine(string.Join(",", fields));
                    }

                    File.WriteAllText(sfd.FileName, csv.ToString());
                    MessageBox.Show("Report exported to Excel (CSV) successfully.", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Export failed: " + ex.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Export to PDF (FR-35) – basic PDF with text
        public void ExportPDF()
        {
            if (_lastReportData == null || _lastReportData.Rows.Count == 0)
            {
                MessageBox.Show("No report data to export.", "Export Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                sfd.Title = "Export to PDF";
                sfd.FileName = "Report.pdf";

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    byte[] pdfBytes = BuildSimplePDF(_lastReportData);
                    File.WriteAllBytes(sfd.FileName, pdfBytes);
                    MessageBox.Show("Report exported to PDF successfully.", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Export failed: " + ex.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // =====================================================
        // Private Helpers
        // =====================================================

        // Escape a field for CSV (wrap in quotes, double up internal quotes)
        private string QuoteCsvField(string field)
        {
            if (field.Contains(",") || field.Contains("\"") || field.Contains("\n"))
                return "\"" + field.Replace("\"", "\"\"") + "\"";
            return field;
        }

        // Build a minimal PDF document that prints the DataTable as text
        private byte[] BuildSimplePDF(DataTable dt)
        {
            // Font: Courier, size 9
            float fontSize = 9;
            float lineHeight = fontSize + 2;
            float margin = 40;
            float pageWidth = 595;  // A4
            float pageHeight = 842;
            float yStart = pageHeight - margin;
            float yPosition = yStart;
            int maxLinesPerPage = (int)((pageHeight - 2 * margin) / lineHeight);

            StringBuilder content = new StringBuilder();
            int lineCount = 0;

            // Helper to add a line of text to the content stream
            void AddLine(string text)
            {
                if (lineCount >= maxLinesPerPage)
                {
                    lineCount = 0;
                    yPosition = yStart;
                }
                // PDF text positioning: Td (x y) then Tj (show text)
                content.AppendLine($"BT /F1 {fontSize} Tf {margin} {yPosition} Td ({EscapePDFString(text)}) Tj ET");
                yPosition -= lineHeight;
                lineCount++;
            }

            // Build column headers
            StringBuilder header = new StringBuilder();
            for (int c = 0; c < dt.Columns.Count; c++)
            {
                if (c > 0) header.Append("  ");
                header.Append(dt.Columns[c].ColumnName);
            }
            AddLine(header.ToString());
            AddLine(new string('-', header.Length)); // underline

            // Data rows
            foreach (DataRow row in dt.Rows)
            {
                StringBuilder line = new StringBuilder();
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    if (c > 0) line.Append("  ");
                    line.Append(row[c].ToString());
                }
                AddLine(line.ToString());
            }

            // Assemble PDF
            string pdfContent = content.ToString();

            // Object numbers
            int objCatalog = 1;
            int objPages = 2;
            int objPage = 3;
            int objContent = 4;
            int objFont = 5;

            // Font object (Courier)
            string fontObj = $"{objFont} 0 obj\n<</Type /Font /Subtype /Type1 /BaseFont /Courier>>\nendobj\n";

            // Content stream
            string contentStream = $"{objContent} 0 obj\n<</Length {pdfContent.Length + 1}>>\nstream\n{pdfContent}\nendstream\nendobj\n";

            // Page object
            string pageObj = $"{objPage} 0 obj\n<</Type /Page /Parent {objPages} 0 R /MediaBox [0 0 {pageWidth} {pageHeight}] /Contents {objContent} 0 R /Resources <</Font <</F1 {objFont} 0 R>>>> >>\nendobj\n";

            // Pages object
            string pagesObj = $"{objPages} 0 obj\n<</Type /Pages /Kids [{objPage} 0 R] /Count 1>>\nendobj\n";

            // Catalog
            string catalogObj = $"{objCatalog} 0 obj\n<</Type /Catalog /Pages {objPages} 0 R>>\nendobj\n";

            // Cross‑reference table
            long[] offsets = new long[6];
            StringBuilder xref = new StringBuilder();
            xref.AppendLine("xref");
            xref.AppendLine("0 6");
            xref.AppendLine("0000000000 65535 f "); // free entry

            StringBuilder body = new StringBuilder();
            body.Append(catalogObj);
            offsets[1] = body.Length;
            body.Append(pagesObj);
            offsets[2] = body.Length;
            body.Append(pageObj);
            offsets[3] = body.Length;
            body.Append(contentStream);
            offsets[4] = body.Length;
            body.Append(fontObj);
            offsets[5] = body.Length;

            // Add offsets to xref (10-digit zero-padded)
            for (int i = 1; i <= 5; i++)
                xref.AppendLine($"{offsets[i]:0000000000} 00000 n ");

            // Trailer
            long startXref = body.Length;
            string trailer = $"trailer\n<</Size 6 /Root {objCatalog} 0 R>>\nstartxref\n{startXref}\n%%EOF";

            // Combine
            string pdfHeader = "%PDF-1.4\n";
            byte[] pdfBytes = Encoding.ASCII.GetBytes(pdfHeader + body.ToString() + xref.ToString() + trailer);
            return pdfBytes;
        }

        // Escape special PDF string characters
        private string EscapePDFString(string text)
        {
            return text.Replace("\\", "\\\\")
                       .Replace("(", "\\(")
                       .Replace(")", "\\)");
        }
    }
}