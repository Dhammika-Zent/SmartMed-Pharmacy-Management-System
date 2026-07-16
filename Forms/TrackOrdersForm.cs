using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SmartMed.Helpers;   // SessionManager
using SmartMed.Models;    // Customer, Order

namespace SmartMed.Forms
{
    public partial class TrackOrdersForm : Form
    {
        // No extra controls – everything is in the main DataGridView

        public TrackOrdersForm()
        {
            InitializeComponent();

            // Display logged‑in customer name
            if (SessionManager.CurrentSession != null)
            {
                string displayName = string.IsNullOrEmpty(SessionManager.CurrentSession.FullName)
                                     ? SessionManager.CurrentSession.Username
                                     : SessionManager.CurrentSession.FullName;
                lblUserName.Text = displayName;
            }

            // Hide the View Details button – we no longer need it
            btnViewDetails.Visible = false;

            // Wire up events
            this.Load += TrackOrdersForm_Load;
            btnRefresh.Click += btnRefresh_Click;

            // Sidebar navigation
            btnNavDashboard.Click += (s, e) => { this.Close(); };
            btnNavMedicines.Click += (s, e) => OpenMedicineCatalog();
            btnNavCart.Click += (s, e) => OpenCart();
            btnNavOrders.Click += (s, e) => { }; // already on this form
            btnNavProfile.Click += (s, e) => OpenProfile();
            btnNavLogout.Click += (s, e) => Logout();

            // Top bar door icon – go back to dashboard
            btnLogoutIcon.Click += (s, e) => { this.Close(); };
        }

        // =====================================================
        // Form Load
        // =====================================================
        private void TrackOrdersForm_Load(object sender, EventArgs e)
        {
            // Prevent auto‑generation of columns
            dgvOrders.AutoGenerateColumns = false;

            // Map existing columns from the designer
            colOrderID.DataPropertyName = "OrderID";
            colDate.DataPropertyName = "OrderDate";
            colTotal.DataPropertyName = "TotalAmount";
            colTotal.DefaultCellStyle.Format = "N2";
            colStatus.DataPropertyName = "OrderStatus";
            colPrescription.DataPropertyName = "HasPrescription";

            // Add the Items column programmatically (shows medicine names and quantities)
            if (!dgvOrders.Columns.Contains("colItems"))
            {
                DataGridViewTextBoxColumn colItems = new DataGridViewTextBoxColumn
                {
                    Name = "colItems",
                    HeaderText = "Items",
                    DataPropertyName = "Items",
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                };
                dgvOrders.Columns.Insert(3, colItems);   // place after OrderDate
            }

            LoadOrders();
        }

        // =====================================================
        // Load customer orders
        // =====================================================
        private void LoadOrders()
        {
            Customer customer = new Customer();
            DataTable orders = customer.TrackOrder();

            if (orders == null || orders.Rows.Count == 0)
            {
                // Show empty state, hide grid
                dgvOrders.Visible = false;
                pnlEmptyState.Visible = true;
            }
            else
            {
                dgvOrders.DataSource = orders;
                dgvOrders.Visible = true;
                pnlEmptyState.Visible = false;
            }
        }

        // =====================================================
        // Refresh button
        // =====================================================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        // =====================================================
        // Navigation helpers
        // =====================================================
        private void OpenMedicineCatalog()
        {
            this.Hide();
            var form = new MedicineSearchForm();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        private void OpenCart()
        {
            this.Hide();
            var form = new CartForm();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        private void OpenProfile()
        {
            this.Hide();
            var form = new ProfileForm();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        private void Logout()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                                                  "Confirm Logout",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SessionManager.CurrentSession?.EndSession();
                var loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }
    }
}