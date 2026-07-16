using System;
using System.Data;
using System.Windows.Forms;
using SmartMed.Helpers;
using SmartMed.Models;

namespace SmartMed.Forms
{
    public partial class ReportForm : Form
    {
        // =====================================================
        // Private fields
        // =====================================================
        private ReportManager reportManager;
        private int reportsGeneratedCount = 0;   // session counter for KPI

        // =====================================================
        // Constructor – wire all events
        // =====================================================
        public ReportForm()
        {
            InitializeComponent();

            // ----- Keep title clean – the value label already shows "LKR" -----
            lblKpiTotalSalesTitle.Text = "Total Sales";

            // Form events
            this.Load += ReportForm_Load;

            // Generate & export buttons
            btnFilterGenerate.Click += btnFilterGenerate_Click;
            btnExportPdf.Click += btnExportPdf_Click;
            btnExportExcel.Click += btnExportExcel_Click;

            // Sidebar navigation buttons
            btnNavDashboard.Click += BtnNavDashboard_Click;
            btnNavMedicines.Click += BtnNavMedicines_Click;
            btnNavCustomers.Click += BtnNavCustomers_Click;
            btnNavOrders.Click += BtnNavOrders_Click;
            btnNavReports.Click += BtnNavReports_Click;
            btnNavLogout.Click += BtnNavLogout_Click;

            // Door icon – go back to Admin Dashboard
            btnLogoutIcon.Click += (s, e) => BtnNavDashboard_Click(s, e);

            // Business layer object
            reportManager = new ReportManager();
        }

        // =====================================================
        // Form Load – session check, user info, dropdown loading
        // =====================================================
        private void ReportForm_Load(object sender, EventArgs e)
        {
            // Admin access only
            if (SessionManager.CurrentSession == null ||
                SessionManager.CurrentSession.Role != "Admin")
            {
                MessageBox.Show("Admin access required.", "Access Denied",
                                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
                return;
            }

            // Display real admin name in the top bar
            lblUserName.Text = SessionManager.CurrentSession.FullName;

            // Fill dropdowns with live data
            LoadCustomerDropdown();
            LoadMedicineDropdown();
        }

        // =====================================================
        // Load Customer Dropdown
        // =====================================================
        private void LoadCustomerDropdown()
        {
            DataTable customers = Customer.GetAllCustomers();
            cmbCustomer.DataSource = customers;
            cmbCustomer.DisplayMember = "FullName";
            cmbCustomer.ValueMember = "CustomerID";
            cmbCustomer.SelectedIndex = -1;   // no default selection
        }

        // =====================================================
        // Load Medicine Dropdown
        // =====================================================
        private void LoadMedicineDropdown()
        {
            DataTable medicines = Medicine.GetAll();
            cmbMedicine.DataSource = medicines;
            cmbMedicine.DisplayMember = "MedicineName";
            cmbMedicine.ValueMember = "MedicineID";
            cmbMedicine.SelectedIndex = -1;
        }

        // =====================================================
        // Generate Report
        // =====================================================
        private void btnFilterGenerate_Click(object sender, EventArgs e)
        {
            // Validate report type selection
            if (cmbReportType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a report type.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Clear previous results
            dgvReportPreview.DataSource = null;
            ClearKPIs();

            DataTable reportData = null;
            string selectedReport = cmbReportType.SelectedItem.ToString();

            if (selectedReport == "Sales Report")
            {
                reportData = reportManager.GenerateSalesReport();

                if (reportData != null && reportData.Rows.Count > 0)
                {
                    // Calculate total sales
                    decimal totalSales = 0;
                    foreach (DataRow row in reportData.Rows)
                        totalSales += Convert.ToDecimal(row["Total Amount"]);

                    // Two‑line display: "LKR" on first line, number (no decimals) on second line
                    lblKpiTotalSalesValue.Text = "LKR\n" + totalSales.ToString("N0");
                    lblKpiTotalOrdersValue.Text = reportData.Rows.Count.ToString();
                }
            }
            else if (selectedReport == "Stock Report")
            {
                reportData = reportManager.GenerateStockReport();

                if (reportData != null && reportData.Rows.Count > 0)
                {
                    // Count low‑stock medicines (stock <= 10)
                    int lowStockCount = 0;
                    foreach (DataRow row in reportData.Rows)
                    {
                        if (Convert.ToInt32(row["Stock"]) <= 10)
                            lowStockCount++;
                    }
                    lblKpiLowStockMedsValue.Text = lowStockCount.ToString();
                }
            }
            else if (selectedReport == "Customer Order Report")
            {
                reportData = reportManager.GenerateCustomerOrderReport();

                if (reportData != null && reportData.Rows.Count > 0)
                {
                    lblKpiTotalOrdersValue.Text = reportData.Rows.Count.ToString();
                }
            }

            // Increment the "Reports Generated" counter
            reportsGeneratedCount++;
            lblKpiReportsGeneratedValue.Text = reportsGeneratedCount.ToString();

            // Handle empty result
            if (reportData == null || reportData.Rows.Count == 0)
            {
                MessageBox.Show("No data found for the selected report.", "No Data Found",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Bind data to grid
            dgvReportPreview.DataSource = reportData;
        }

        // =====================================================
        // Clear all KPI labels (except generated counter)
        // =====================================================
        private void ClearKPIs()
        {
            lblKpiTotalSalesValue.Text = "0";
            lblKpiTotalOrdersValue.Text = "0";
            lblKpiLowStockMedsValue.Text = "0";
        }

        // =====================================================
        // Export PDF
        // =====================================================
        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            reportManager.ExportPDF();
        }

        // =====================================================
        // Export Excel
        // =====================================================
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            reportManager.ExportExcel();
        }

        // =====================================================
        // Sidebar Navigation – match AdminDashboard pattern
        // =====================================================
        private void BtnNavDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dashboard = new AdminDashboard();
            dashboard.FormClosed += (s, args) => this.Show();
            dashboard.Show();
        }

        private void BtnNavMedicines_Click(object sender, EventArgs e)
        {
            this.Hide();
            var medForm = new MedicineManagementForm();
            medForm.FormClosed += (s, args) => this.Show();
            medForm.Show();
        }

        private void BtnNavCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            var custForm = new CustomerManagement();
            custForm.FormClosed += (s, args) => this.Show();
            custForm.Show();
        }

        private void BtnNavOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            var orderForm = new OrderManagementForm();
            orderForm.FormClosed += (s, args) =>
            {
                if (!orderForm.IsLoggingOut)
                    this.Show();
            };
            orderForm.Show();
        }

        private void BtnNavReports_Click(object sender, EventArgs e)
        {
            // Already on the Reports page – do nothing
        }

        // =====================================================
        // Logout – clear session, hide all forms, show login
        // =====================================================
        private void BtnNavLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                                                  "Confirm Logout",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Clear session data
                SessionManager.CurrentSession?.EndSession();

                // Hide every open form (do NOT Close, so the app stays alive)
                foreach (Form f in Application.OpenForms)
                    f.Hide();

                // Show login as the only visible window
                new LoginForm().Show();
            }
        }
    }
}