using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;                          // for rounded corners
using System.Windows.Forms.DataVisualization.Charting;       // for the sales chart
using SmartMed.Managers;                                     // database access
using SmartMed.Helpers;                                      // SessionManager
using SmartMed.Models;                                       // Admin & DashboardData

namespace SmartMed.Forms
{
    public partial class AdminDashboard : Form
    {
        private Chart chartSales;      // sales summary chart control

        public AdminDashboard()
        {
            InitializeComponent();

            // ----- Display logged-in user's name from the session -----
            if (SessionManager.CurrentSession != null)
            {
                // Use FullName if available, otherwise show Username
                string displayName = string.IsNullOrEmpty(SessionManager.CurrentSession.FullName)
                                     ? SessionManager.CurrentSession.Username
                                     : SessionManager.CurrentSession.FullName;
                lblUserName.Text = displayName;
            }

            // ----- Keep title clean – the value label already shows "LKR" -----
            lblKpiTotalSalesTitle.Text = "Total Sales";

            this.Load += AdminDashboard_Load;

            // ----- Wire up all navigation button clicks -----
            // Sidebar
            btnNavDashboard.Click += (s, e) => { };                     // already on dashboard – do nothing
            btnNavMedicines.Click += (s, e) => OpenMedicineManagement();
            btnNavCustomers.Click += (s, e) => OpenCustomerManagement();
            btnNavOrders.Click += (s, e) => OpenOrderManagement();
            btnNavReports.Click += (s, e) => OpenReport();
            btnNavLogout.Click += (s, e) => Logout();

            // Quick actions
            btnQuickMedicines.Click -= btnQuickMedicines_Click;        // detach old empty handler
            btnQuickMedicines.Click += (s, e) => OpenMedicineManagement();
            btnQuickCustomers.Click -= btnQuickCustomers_Click;        // detach old empty handler
            btnQuickCustomers.Click += (s, e) => OpenCustomerManagement();
            btnQuickOrders.Click += (s, e) => OpenOrderManagement();
            btnQuickReports.Click += (s, e) => OpenReport();
            btnQuickLogout.Click += (s, e) => Logout();
        }

        // =====================================================================================================================
        // EVENT HANDLERS (empty – kept for compatibility)
        // =====================================================================================================================
        private void pnlKpiRow_Paint(object sender, PaintEventArgs e) { }
        private void lblKpiExpiringValue_Click(object sender, EventArgs e) { }
        private void lblSalesChartPlaceholder_Click(object sender, EventArgs e) { }
        private void pnlKpiExpiring_Paint(object sender, PaintEventArgs e) { }
        private void lblQuickActionsTitle_Click(object sender, EventArgs e) { }
        private void pnlQuickActions_Paint(object sender, PaintEventArgs e) { }
        private void pnlDashboard_Paint(object sender, PaintEventArgs e) { }
        private void btnQuickMedicines_Click(object sender, EventArgs e) { }
        private void btnQuickCustomers_Click(object sender, EventArgs e) { }

        // =====================================================================================================================
        // ROUNDED CORNERS
        // =====================================================================================================================
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        private void ApplyRoundedCorners()
        {
            void RoundControl(Control c, int radius)
            {
                if (c != null && c.Width > 0 && c.Height > 0)
                    c.Region = Region.FromHrgn(
                        CreateRoundRectRgn(0, 0, c.Width, c.Height, radius, radius));
            }

            int r = 20; // corner radius

            RoundControl(pnlSidebar, r);
            RoundControl(pnlTopBar, r);

            RoundControl(pnlKpiTotalSales, r);
            RoundControl(pnlKpiTotalMeds, r);
            RoundControl(pnlKpiRegCustomers, r);
            RoundControl(pnlKpiActiveOrders, r);
            RoundControl(pnlKpiLowStock, r);
            RoundControl(pnlKpiExpiring, r);

            RoundControl(pnlQuickActions, r);

            RoundControl(pnlRecentOrders, r);
            RoundControl(pnlRecentCustomers, r);
            RoundControl(pnlLowStock, r);
            RoundControl(pnlExpiryList, r);
            RoundControl(pnlSalesSummary, r);
        }

        /// <summary>Form Load event – setup UI and load all data.</summary>
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            ApplyRoundedCorners();
            ApplyDarkThemeToDataGridViews();
            LoadDashboardKPIs();
            LoadRecentOrders();
            LoadRecentCustomers();
            LoadLowStockMedicines();
            LoadExpiringMedicines();
            LoadSalesChart();
        }

        // =====================================================================================================================
        // DARK THEME FOR ALL DataGridViews
        // =====================================================================================================================
        private void ApplyDarkThemeToDataGridViews()
        {
            void StyleGrid(DataGridView grid)
            {
                grid.DefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
                grid.DefaultCellStyle.ForeColor = Color.FromArgb(240, 240, 240);
                grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 99, 235);
                grid.DefaultCellStyle.SelectionForeColor = Color.White;

                grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
                grid.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(240, 240, 240);
                grid.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 99, 235);
                grid.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;

                grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
                grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                grid.EnableHeadersVisualStyles = false;
            }

            StyleGrid(dgvRecentOrders);
            StyleGrid(dgvRecentCustomers);
            StyleGrid(dgvLowStock);
            StyleGrid(dgvExpiryList);
        }

        // =====================================================================================================================
        // KPI CARDS
        // =====================================================================================================================
        private void LoadDashboardKPIs()
        {
            try
            {
                // Delegate all medicine and customer statistics to the Admin coordinator
                Admin admin = new Admin();
                Admin.DashboardData data = admin.ViewDashboard();

                // ---- Medicine KPIs ----
                lblKpiTotalMedsValue.Text = data.TotalMedicines.ToString();
                lblKpiLowStockValue.Text = data.LowStockMedicines.ToString();
                lblKpiExpiringValue.Text = data.ExpiringMedicines.ToString();

                // ---- Customer KPIs ----
                lblKpiRegCustomersValue.Text = data.TotalCustomers.ToString();

                // ---- Order KPIs (still direct – no domain method available yet) ----
                DatabaseManager db = new DatabaseManager();

                object totalSales = db.ExecuteScalar("SELECT IFNULL(SUM(TotalAmount),0) FROM [Order];");
                decimal salesAmount = (totalSales != null && totalSales != DBNull.Value)
                                      ? Convert.ToDecimal(totalSales) : 0m;

                // Two‑line display: "LKR" on first line, number (no decimals) on second line
                lblKpiTotalSalesValue.Text = "LKR\n" + salesAmount.ToString("N0");

                object activeOrders = db.ExecuteScalar(
                    "SELECT COUNT(*) FROM [Order] WHERE OrderStatus IN ('Pending','Ready for Pickup');");
                lblKpiActiveOrdersValue.Text = (activeOrders != null && activeOrders != DBNull.Value)
                                               ? activeOrders.ToString() : "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load dashboard KPIs.\n" + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // =====================================================================================================================
        // RECENT ORDERS
        // =====================================================================================================================
        private void LoadRecentOrders()
        {
            try
            {
                DatabaseManager db = new DatabaseManager();
                string sql = "SELECT OrderID, CustomerID AS Customer, OrderDate, TotalAmount, OrderStatus " +
                             "FROM [Order] ORDER BY OrderDate DESC LIMIT 5;";
                DataTable dt = db.ExecuteQuery(sql);

                dgvRecentOrders.Columns["colOrderID"].DataPropertyName = "OrderID";
                dgvRecentOrders.Columns["colOrderCustomer"].DataPropertyName = "Customer";
                dgvRecentOrders.Columns["colOrderDate"].DataPropertyName = "OrderDate";
                dgvRecentOrders.Columns["colOrderTotal"].DataPropertyName = "TotalAmount";
                dgvRecentOrders.Columns["colOrderStatus"].DataPropertyName = "OrderStatus";

                dgvRecentOrders.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load recent orders.\n" + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // =====================================================================================================================
        // RECENT CUSTOMERS
        // =====================================================================================================================
        private void LoadRecentCustomers()
        {
            try
            {
                DatabaseManager db = new DatabaseManager();
                string sql = "SELECT CustomerID, FullName, Email, Phone, CreatedDate " +
                             "FROM Customer ORDER BY CreatedDate DESC LIMIT 5;";
                DataTable dt = db.ExecuteQuery(sql);

                dgvRecentCustomers.AutoGenerateColumns = false;

                dgvRecentCustomers.Columns["colCustID"].DataPropertyName = "CustomerID";
                dgvRecentCustomers.Columns["colCustID"].HeaderText = "Customer ID";

                dgvRecentCustomers.Columns["colCustName"].DataPropertyName = "FullName";
                dgvRecentCustomers.Columns["colCustName"].HeaderText = "Full Name";

                dgvRecentCustomers.Columns["colCustPhone"].DataPropertyName = "Phone";
                dgvRecentCustomers.Columns["colCustPhone"].HeaderText = "Phone";

                dgvRecentCustomers.Columns["colCustEmail"].DataPropertyName = "Email";
                dgvRecentCustomers.Columns["colCustEmail"].HeaderText = "Email";

                DataGridViewTextBoxColumn createdDateCol = new DataGridViewTextBoxColumn();
                createdDateCol.Name = "colCreatedDate";
                createdDateCol.HeaderText = "Created Date";
                createdDateCol.DataPropertyName = "CreatedDate";
                createdDateCol.ReadOnly = true;
                if (!dgvRecentCustomers.Columns.Contains("colCreatedDate"))
                    dgvRecentCustomers.Columns.Add(createdDateCol);

                dgvRecentCustomers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load recent customers.\n" + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // =====================================================================================================================
        // LOW STOCK MEDICINES
        // =====================================================================================================================
        private void LoadLowStockMedicines()
        {
            try
            {
                DatabaseManager db = new DatabaseManager();
                string sql = "SELECT MedicineID, MedicineName, Category, StockQuantity, Supplier " +
                             "FROM Medicine WHERE StockQuantity <= 10 ORDER BY StockQuantity ASC;";
                DataTable dt = db.ExecuteQuery(sql);

                dgvLowStock.AutoGenerateColumns = false;
                dgvLowStock.Columns.Clear();

                dgvLowStock.Columns.Add(CreateColumn("colMedID", "Medicine ID", "MedicineID"));
                dgvLowStock.Columns.Add(CreateColumn("colMedName", "Medicine Name", "MedicineName"));
                dgvLowStock.Columns.Add(CreateColumn("colCategory", "Category", "Category"));
                dgvLowStock.Columns.Add(CreateColumn("colStock", "Stock Quantity", "StockQuantity"));
                dgvLowStock.Columns.Add(CreateColumn("colSupplier", "Supplier", "Supplier"));

                dgvLowStock.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load low stock medicines.\n" + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // =====================================================================================================================
        // EXPIRING MEDICINES
        // =====================================================================================================================
        private void LoadExpiringMedicines()
        {
            try
            {
                DatabaseManager db = new DatabaseManager();
                string sql = "SELECT MedicineID, MedicineName, ExpiryDate, StockQuantity " +
                             "FROM Medicine WHERE date(ExpiryDate) <= date('now','+30 day') " +
                             "ORDER BY ExpiryDate ASC;";
                DataTable dt = db.ExecuteQuery(sql);

                dgvExpiryList.AutoGenerateColumns = false;
                dgvExpiryList.Columns.Clear();

                dgvExpiryList.Columns.Add(CreateColumn("colExpMedID", "Medicine ID", "MedicineID"));
                dgvExpiryList.Columns.Add(CreateColumn("colExpMedName", "Medicine Name", "MedicineName"));
                dgvExpiryList.Columns.Add(CreateColumn("colExpDate", "Expiry Date", "ExpiryDate"));
                dgvExpiryList.Columns.Add(CreateColumn("colExpStock", "Stock Quantity", "StockQuantity"));

                dgvExpiryList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load expiring medicines.\n" + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>Creates a read‑only DataGridViewTextBoxColumn with the given properties.</summary>
        private DataGridViewTextBoxColumn CreateColumn(string name, string header, string dataProperty)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = name;
            col.HeaderText = header;
            col.DataPropertyName = dataProperty;
            col.ReadOnly = true;
            return col;
        }

        // =====================================================================================================================
        // SALES SUMMARY CHART
        // =====================================================================================================================
        private void LoadSalesChart()
        {
            try
            {
                lblSalesChartPlaceholder.Visible = false;

                if (chartSales != null)
                {
                    pnlSalesSummary.Controls.Remove(chartSales);
                    chartSales.Dispose();
                }

                chartSales = new Chart();
                chartSales.Dock = DockStyle.Fill;
                chartSales.BackColor = Color.FromArgb(26, 26, 26);
                chartSales.Palette = ChartColorPalette.None;

                ChartArea area = new ChartArea("MainArea");
                area.BackColor = Color.FromArgb(43, 43, 43);
                area.AxisX.Title = "Month";
                area.AxisX.TitleFont = new Font("Segoe UI", 9f, FontStyle.Bold);
                area.AxisX.TitleForeColor = Color.FromArgb(240, 240, 240);
                area.AxisX.LabelStyle.Font = new Font("Segoe UI", 8f);
                area.AxisX.LabelStyle.ForeColor = Color.FromArgb(200, 200, 200);
                area.AxisX.MajorGrid.LineColor = Color.FromArgb(70, 70, 70);
                area.AxisX.LineColor = Color.FromArgb(120, 120, 120);

                area.AxisY.Title = "Sales (LKR)";
                area.AxisY.TitleFont = new Font("Segoe UI", 9f, FontStyle.Bold);
                area.AxisY.TitleForeColor = Color.FromArgb(240, 240, 240);
                area.AxisY.LabelStyle.Font = new Font("Segoe UI", 8f);
                area.AxisY.LabelStyle.ForeColor = Color.FromArgb(200, 200, 200);
                area.AxisY.LabelStyle.Format = "#,##0";
                area.AxisY.MajorGrid.LineColor = Color.FromArgb(70, 70, 70);
                area.AxisY.LineColor = Color.FromArgb(120, 120, 120);

                area.Position = new ElementPosition(0, 12, 100, 85);

                chartSales.ChartAreas.Add(area);

                Title title = new Title("Sales Summary", Docking.Top,
                                        new Font("Segoe UI", 11f, FontStyle.Bold),
                                        Color.FromArgb(240, 240, 240));
                chartSales.Titles.Add(title);

                Series series = new Series("MonthlySales");
                series.ChartType = SeriesChartType.Column;
                series.Color = Color.FromArgb(37, 99, 235);
                series.BorderWidth = 0;
                series.IsValueShownAsLabel = true;
                series.LabelForeColor = Color.FromArgb(220, 220, 220);
                series.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
                series.ToolTip = "#VALY";
                chartSales.Series.Add(series);

                DatabaseManager db = new DatabaseManager();
                string sql = "SELECT strftime('%Y-%m', OrderDate) AS SalesMonth, SUM(TotalAmount) AS MonthlySales " +
                             "FROM [Order] GROUP BY SalesMonth ORDER BY SalesMonth;";
                DataTable dt = db.ExecuteQuery(sql);

                foreach (DataRow row in dt.Rows)
                {
                    string month = row["SalesMonth"].ToString();
                    decimal sales = Convert.ToDecimal(row["MonthlySales"]);
                    series.Points.AddXY(month, sales);
                }

                pnlSalesSummary.Controls.Add(chartSales);
                chartSales.SendToBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load sales chart.\n" + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // =====================================================================================================================
        // NAVIGATION METHODS
        // =====================================================================================================================

        private void OpenMedicineManagement()
        {
            this.Hide();
            var form = new MedicineManagementForm();
            // ★ FIX: Show the dashboard again when the medicine form is closed
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        private void OpenCustomerManagement()
        {
            this.Hide();
            var form = new CustomerManagement();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        private void OpenOrderManagement()
        {
            this.Hide();
            var form = new OrderManagementForm();
            form.FormClosed += (s, args) =>
            {
                // Only show the dashboard if the order form was NOT closed by a logout action
                if (!form.IsLoggingOut)
                    this.Show();
            };
            form.Show();
        }

        private void OpenReport()
        {
            this.Hide();
            var form = new ReportForm();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        /// <summary>Logs out – clears session, hides the dashboard, shows LoginForm.</summary>
        private void Logout()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                                                  "Confirm Logout",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Clear session data
                SessionManager.CurrentSession?.EndSession();

                // Return to login form
                this.Hide();
                var loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        // =====================================================================================================================
        // OTHER DESIGNER EVENTS (empty)
        // =====================================================================================================================
        private void dgvRecentOrders_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvLowStock_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}