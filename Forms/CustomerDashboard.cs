using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SmartMed.Helpers;          // SessionManager
using SmartMed.Managers;         // DatabaseManager

namespace SmartMed.Forms
{
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
            this.Load += CustomerDashboard_Load;

            // ----- Wire logout buttons -----
            btnNavLogout.Click += (s, e) => Logout();
            btnQuickLogout.Click += (s, e) => Logout();           // quick actions logout
            btnLogoutIcon.Click += (s, e) => Logout();            // top‑bar logout icon

            // ----- Wire navigation buttons -----
            btnNavDashboard.Click += (s, e) => { /* already on dashboard */ };
            btnNavMedicines.Click += (s, e) => OpenMedicineSearch();
            btnNavCart.Click += (s, e) => ShowComingSoon("Cart");
            btnNavOrders.Click += (s, e) => OpenTrackOrders();
            btnNavProfile.Click += (s, e) => OpenProfile();

            // ----- Wire quick action buttons (top bar) -----
            btnQuickProfile.Click += (s, e) => OpenProfile();
            btnQuickTrackOrders.Click += (s, e) => OpenTrackOrders();
            btnQuickCart.Click += (s, e) => ShowComingSoon("Cart");
        }

        // =====================================================================================================================
        // NAVIGATION METHODS
        // =====================================================================================================================

        /// <summary>Opens the Medicine Search form.</summary>
        private void OpenMedicineSearch()
        {
            this.Hide();
            var form = new MedicineSearchForm();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        /// <summary>Opens the Track Orders form.</summary>
        private void OpenTrackOrders()
        {
            this.Hide();
            var form = new TrackOrdersForm();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        /// <summary>Opens the Customer Profile form.</summary>
        private void OpenProfile()
        {
            try
            {
                this.Hide();
                var form = new ProfileForm();
                form.FormClosed += (s, args) => this.Show();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Profile form is not available yet.\n" + ex.Message,
                                "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Show();
            }
        }

        /// <summary>Displays a friendly "coming soon" message.</summary>
        private void ShowComingSoon(string feature)
        {
            MessageBox.Show($"{feature} feature will be available soon.",
                            "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // =====================================================================================================================
        // LOGOUT METHOD
        // =====================================================================================================================
        private void Logout()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                                                  "Confirm Logout",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SessionManager.CurrentSession?.EndSession();
                this.Hide();
                var loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        // =====================================================================================================================
        // ROUNDED CORNERS
        // =====================================================================================================================
        [DllImport("Gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        private void ApplyRoundedCorners()
        {
            void RoundControl(Control c, int radius)
            {
                if (c != null && c.Width > 0 && c.Height > 0)
                    c.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, c.Width, c.Height, radius, radius));
            }

            int r = 20;

            RoundControl(pnlSidebar, r);
            RoundControl(pnlTopBar, r);
            RoundControl(pnlWelcome, r);
            RoundControl(pnlQuickCardOrders, r);
            RoundControl(pnlQuickCardCart, r);
            RoundControl(pnlQuickCardPrescriptions, r);
            RoundControl(pnlQuickCardDiscounts, r);
            RoundControl(pnlQuickButtons, r);
            RoundControl(pnlLatestMedicines, r);
            RoundControl(pnlCurrentPromotions, r);
            RoundControl(pnlRecentOrders, r);
            RoundControl(pnlSearchBar, r);
        }

        // =====================================================================================================================
        // FORM LOAD EVENT
        // =====================================================================================================================
        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            ApplyRoundedCorners();

            // Display logged‑in user info from the session
            if (SessionManager.CurrentSession != null)
            {
                string displayName = string.IsNullOrEmpty(SessionManager.CurrentSession.FullName)
                                     ? SessionManager.CurrentSession.Username
                                     : SessionManager.CurrentSession.FullName;

                lblUserName.Text = displayName;

                string greeting = GetTimeBasedGreeting();
                lblWelcomeGreeting.Text = $"{greeting}, {displayName}";
                lblWelcomeCustomer.Text = displayName;
                lblWelcomeDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            }

            // Apply dark theme to all DataGridViews (matching admin dashboard style)
            ApplyDarkThemeToGrids();

            // Load all dashboard data
            LoadDashboardData();
        }

        /// <summary>Returns a time‑appropriate greeting.</summary>
        private string GetTimeBasedGreeting()
        {
            int hour = DateTime.Now.Hour;
            if (hour >= 5 && hour < 12) return "Good Morning";
            if (hour >= 12 && hour < 17) return "Good Afternoon";
            if (hour >= 17 && hour < 21) return "Good Evening";
            return "Good Night";
        }

        // =====================================================================================================================
        // DARK THEME FOR DataGridViews
        // =====================================================================================================================
        private void ApplyDarkThemeToGrids()
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

            StyleGrid(dgvLatestMedicines);
            StyleGrid(dgvCurrentPromotions);
            StyleGrid(dgvRecentOrders);
        }

        // =====================================================================================================================
        // LOAD ALL DASHBOARD DATA
        // =====================================================================================================================
        private void LoadDashboardData()
        {
            if (SessionManager.CurrentSession == null) return;

            // Retrieve the logged‑in customer's ID from the session.
            // Assumes SessionManager.CurrentSession.UserId holds the CustomerID.
            int customerId = SessionManager.CurrentSession.UserID;

            LoadQuickStats(customerId);          // KPI cards
            LoadLatestMedicines();                // "Latest Medicines" grid
            LoadCurrentPromotions();              // "Current Promotions" grid (discounted medicines)
            LoadRecentOrders(customerId);         // "Recent Orders" grid
        }

        /// <summary>Fills the four quick‑stat cards with real numbers.</summary>
        private void LoadQuickStats(int customerId)
        {
            try
            {
                DatabaseManager db = new DatabaseManager();

                // 1. Total orders for this customer
                object orderCount = db.ExecuteScalar(
                    $"SELECT COUNT(*) FROM [Order] WHERE CustomerID = {customerId};");
                lblQuickCardOrdersValue.Text = (orderCount != DBNull.Value) ? orderCount.ToString() : "0";

                // 2. Cart items – no cart table exists, keep as 0 for now
                lblQuickCardCartValue.Text = "0";

                // 3. Prescriptions for this customer
                object prescriptionCount = db.ExecuteScalar(
                    $"SELECT COUNT(*) FROM Prescription WHERE CustomerID = {customerId};");
                lblQuickCardPrescriptionsValue.Text = (prescriptionCount != DBNull.Value) ? prescriptionCount.ToString() : "0";

                // 4. Available discounts = medicines with DiscountPercentage > 0
                object discountCount = db.ExecuteScalar(
                    "SELECT COUNT(*) FROM Medicine WHERE DiscountPercentage > 0;");
                lblQuickCardDiscountsValue.Text = (discountCount != DBNull.Value) ? discountCount.ToString() : "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load quick stats.\n" + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>Loads the 5 most recently added medicines.</summary>
        private void LoadLatestMedicines()
        {
            try
            {
                DatabaseManager db = new DatabaseManager();
                // Sort by MedicineID descending (newest first) and take top 5
                string sql = "SELECT MedicineName, Category, Price, StockQuantity " +
                             "FROM Medicine ORDER BY MedicineID DESC LIMIT 5;";
                DataTable dt = db.ExecuteQuery(sql);

                // Map columns to the grid
                dgvLatestMedicines.AutoGenerateColumns = false;
                dgvLatestMedicines.DataSource = dt;
                colMedName.DataPropertyName = "MedicineName";
                colMedCategory.DataPropertyName = "Category";
                colMedPrice.DataPropertyName = "Price";
                colMedStock.DataPropertyName = "StockQuantity";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load latest medicines.\n" + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>Loads medicines that currently have a discount (promotions).</summary>
        private void LoadCurrentPromotions()
        {
            try
            {
                DatabaseManager db = new DatabaseManager();
                // Select discounted medicines, ordered by expiry date soonest first
                string sql = "SELECT MedicineName, DiscountPercentage, ExpiryDate " +
                             "FROM Medicine WHERE DiscountPercentage > 0 " +
                             "ORDER BY ExpiryDate ASC;";
                DataTable dt = db.ExecuteQuery(sql);

                dgvCurrentPromotions.AutoGenerateColumns = false;
                dgvCurrentPromotions.DataSource = dt;

                // Map the predefined columns
                colPromoCode.DataPropertyName = "MedicineName";       // Show medicine name as "Promo Code"
                colPromoDescription.DataPropertyName = "DiscountPercentage"; // We'll format in the cell
                colPromoDiscount.DataPropertyName = "DiscountPercentage";
                colPromoExpiry.DataPropertyName = "ExpiryDate";

                // Format the discount percentage with a "%" suffix in the grid
                dgvCurrentPromotions.CellFormatting += (sender, e) =>
                {
                    if (e.ColumnIndex == colPromoDiscount.Index && e.Value != null)
                    {
                        e.Value = e.Value.ToString() + "%";
                        e.FormattingApplied = true;
                    }
                    if (e.ColumnIndex == colPromoDescription.Index && e.Value != null)
                    {
                        e.Value = e.Value.ToString() + "% off";
                        e.FormattingApplied = true;
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load promotions.\n" + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>Loads the 5 most recent orders for the logged‑in customer.</summary>
        private void LoadRecentOrders(int customerId)
        {
            try
            {
                DatabaseManager db = new DatabaseManager();
                string sql = $"SELECT OrderID, OrderDate, TotalAmount, OrderStatus " +
                             $"FROM [Order] WHERE CustomerID = {customerId} " +
                             "ORDER BY OrderDate DESC LIMIT 5;";
                DataTable dt = db.ExecuteQuery(sql);

                dgvRecentOrders.AutoGenerateColumns = false;
                dgvRecentOrders.DataSource = dt;

                colOrderID.DataPropertyName = "OrderID";
                colOrderDate.DataPropertyName = "OrderDate";
                colOrderTotal.DataPropertyName = "TotalAmount";
                colOrderStatus.DataPropertyName = "OrderStatus";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load recent orders.\n" + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}