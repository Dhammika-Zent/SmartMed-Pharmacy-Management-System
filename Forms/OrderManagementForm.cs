using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SmartMed.Helpers;
using SmartMed.Managers;
using SmartMed.Models;

namespace SmartMed.Forms
{
    public partial class OrderManagementForm : Form
    {
        // =====================================================
        // Property – used by AdminDashboard to avoid showing
        // a disposed dashboard after logout.
        // =====================================================
        public bool IsLoggingOut { get; private set; } = false;

        // =====================================================
        // Constructor
        // =====================================================
        public OrderManagementForm()
        {
            InitializeComponent();

            // Display logged-in admin name
            if (SessionManager.CurrentSession != null)
            {
                string displayName = string.IsNullOrEmpty(SessionManager.CurrentSession.FullName)
                                     ? SessionManager.CurrentSession.Username
                                     : SessionManager.CurrentSession.FullName;
                lblUserName.Text = displayName;
            }

            // Wire up events for core functionality
            this.Load += OrderManagementForm_Load;
            dgvOrders.SelectionChanged += dgvOrders_SelectionChanged;
            btnSearch.Click += btnSearch_Click;
            btnResetFilters.Click += btnResetFilters_Click;
            btnRefreshResults.Click += btnRefresh_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnClear.Click += btnClear_Click;
            btnUpdateOrderStatus.Click += btnUpdateOrderStatus_Click;
            btnViewItems.Click += (s, e) =>
                MessageBox.Show("View order items will be implemented in a future update.", "Coming Soon",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // =====================================================
            // Sidebar navigation
            // =====================================================
            btnNavDashboard.Click += (s, e) => { this.Close(); };
            btnNavMedicines.Click += (s, e) => OpenMedicineManagement();
            btnNavCustomers.Click += (s, e) => OpenCustomerManagement();
            btnNavOrders.Click += (s, e) => { };
            btnNavReports.Click += (s, e) => OpenReports();
            btnNavLogout.Click += (s, e) => Logout();

            // Top bar door icon → go to dashboard
            btnLogoutIcon.Click += (s, e) => { this.Close(); };
        }

        // =====================================================
        // Form Load
        // =====================================================
        private void OrderManagementForm_Load(object sender, EventArgs e)
        {
            dgvOrders.AutoGenerateColumns = false;

            colOrderID.DataPropertyName = "OrderID";
            colCustomer.DataPropertyName = "CustomerName";
            colOrderDate.DataPropertyName = "OrderDate";
            // ★ The Items column now shows medicine names and quantities, not just a count
            colItems.DataPropertyName = "Items";
            colTotal.DataPropertyName = "TotalAmount";
            colTotal.DefaultCellStyle.Format = "N2";
            colStatus.DataPropertyName = "OrderStatus";
            colPrescription.DataPropertyName = "HasPrescription";

            LoadAllOrders();
            LoadSummaryCounts();
        }

        // =====================================================
        // Data Loading
        // =====================================================
        private void LoadAllOrders()
        {
            Admin admin = new Admin();
            DataTable orders = admin.ViewOrders();
            dgvOrders.DataSource = orders;
        }

        private void LoadSummaryCounts()
        {
            var summary = Order.GetOrderSummary();
            lblTotalOrdersValue.Text = summary["Total"].ToString();
            lblPendingOrdersValue.Text = summary["Pending"].ToString();
            lblReadyPickupValue.Text = summary["ReadyForPickup"].ToString();
            lblDeliveredOrdersValue.Text = summary["Delivered"].ToString();
        }

        // =====================================================
        // Grid Selection Changed
        // =====================================================
        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null || dgvOrders.SelectedRows.Count == 0)
            {
                txtSelectedOrderID.Clear();
                txtCurrentStatus.Clear();
                return;
            }

            DataGridViewRow row = dgvOrders.CurrentRow;
            txtSelectedOrderID.Text = row.Cells["colOrderID"].Value?.ToString();
            txtCurrentStatus.Text = row.Cells["colStatus"].Value?.ToString();
        }

        // =====================================================
        // Search, Reset, Refresh
        // =====================================================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            string customer = txtSearchCustomer.Text.Trim();
            string orderId = txtSearchOrderID.Text.Trim();
            string status = cmbSearchStatus.SelectedItem?.ToString();

            DataTable result = admin.SearchOrders(customer, orderId, status);
            dgvOrders.DataSource = result;
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            txtSearchCustomer.Clear();
            txtSearchOrderID.Clear();
            cmbSearchStatus.SelectedIndex = 0;
            LoadAllOrders();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllOrders();
            LoadSummaryCounts();
        }

        // =====================================================
        // Update Order Status (FR-26)
        // =====================================================
        private void btnUpdateOrderStatus_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null)
            {
                MessageBox.Show("Please select an order first.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtSelectedOrderID.Text, out int orderId))
            {
                MessageBox.Show("Invalid order ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbNewStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a new status.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newStatus = cmbNewStatus.SelectedItem.ToString();

            Admin admin = new Admin();
            bool success = admin.UpdateOrderStatus(orderId, newStatus);

            if (success)
            {
                MessageBox.Show("Order status updated successfully.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllOrders();
                LoadSummaryCounts();
            }
        }

        // =====================================================
        // Clear selection
        // =====================================================
        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvOrders.ClearSelection();
            txtSelectedOrderID.Clear();
            txtCurrentStatus.Clear();
        }

        // =====================================================
        // Sidebar Navigation Methods
        // =====================================================
        private void OpenMedicineManagement()
        {
            this.Hide();
            var form = new MedicineManagementForm();
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

        private void OpenReports()
        {
            this.Hide();
            var form = new ReportForm();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        // =====================================================
        // Logout (sidebar) 
        // =====================================================
        private void Logout()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                                                  "Confirm Logout",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            // Clear session
            SessionManager.CurrentSession?.EndSession();

            // Show login form first to keep application alive
            var loginForm = new LoginForm();
            loginForm.Show();

            // Signal that we are logging out – the dashboard’s FormClosed handler will skip re‑showing it
            IsLoggingOut = true;
            this.Close();
        }
    }
}