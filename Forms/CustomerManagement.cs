using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SmartMed.Helpers;
using SmartMed.Models;

namespace SmartMed.Forms
{
    public partial class CustomerManagement : Form
    {
        private Admin admin = new Admin();

        public CustomerManagement()
        {
            InitializeComponent();

            // Wire all event handlers (same pattern as MedicineManagementForm)
            this.Load += CustomerManagement_Load;
            btnUpdate.Click += btnUpdate_Click;
            btnClear.Click += btnClear_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnSearch.Click += btnSearch_Click;
            btnResetFilters.Click += btnResetFilters_Click;
            btnRefreshResults.Click += btnRefreshResults_Click;
            dgvCustomers.SelectionChanged += dgvCustomers_SelectionChanged;

            // Sidebar navigation
            btnNavDashboard.Click += btnNavDashboard_Click;
            btnNavMedicines.Click += btnNavMedicines_Click;
            btnNavCustomers.Click += btnNavCustomers_Click;
            btnNavOrders.Click += btnNavOrders_Click;
            btnNavReports.Click += btnNavReports_Click;
            btnNavLogout.Click += btnNavLogout_Click;

            // Top‑bar icon (return to dashboard)
            btnLogoutIcon.Click += btnLogoutIcon_Click;
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            ApplyRoundedCorners();
            ConfigureControls();
            LoadCustomers();
            LoadSummary();

            // Set the logged-in user's name
            if (SessionManager.CurrentSession != null &&
                SessionManager.CurrentSession.Role == "Admin")
            {
                lblUserName.Text = SessionManager.CurrentSession.FullName;
            }
            else
            {
                lblUserName.Text = "Admin User";   // fallback
            }
        }

        private void ConfigureControls()
        {
            btnDeleteCustomer.Enabled = false;          // no deletion allowed
            txtUsername.ReadOnly = true;
            dtpRegisteredDate.Enabled = false;

            // Bind grid columns to DataTable columns
            dgvCustomers.AutoGenerateColumns = false;
            colCustID.DataPropertyName = "CustomerID";
            colCustFullName.DataPropertyName = "FullName";
            colCustUsername.DataPropertyName = "Username";
            colCustEmail.DataPropertyName = "Email";
            colCustPhone.DataPropertyName = "Phone";
            colCustAddress.DataPropertyName = "Address";
            colCustCreatedDate.DataPropertyName = "CreatedDate";
        }

        // ---------------------------------------------------------------
        //  DATA LOADING
        // ---------------------------------------------------------------
        private void LoadCustomers()
        {
            string name = txtSearchName.Text.Trim();
            string user = txtSearchUsername.Text.Trim();
            string email = txtSearchEmail.Text.Trim();

            DataTable dt;
            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(user) && string.IsNullOrEmpty(email))
            {
                dt = admin.ViewCustomers();
            }
            else
            {
                dt = admin.SearchCustomers(name, user, email, "");
            }
            dgvCustomers.DataSource = dt;
        }

        private void LoadSummary()
        {
            lblTotalCustomersValue.Text = admin.GetTotalCustomers().ToString();
            lblNewThisMonthValue.Text = admin.GetNewCustomersThisMonth().ToString();
        }

        // ---------------------------------------------------------------
        //  GRID ROW SELECTION
        // ---------------------------------------------------------------
        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
                return;

            DataGridViewRow row = dgvCustomers.SelectedRows[0];
            if (row.IsNewRow) return;

            txtCustomerID.Text = row.Cells["colCustID"].Value?.ToString() ?? "";
            txtFullName.Text = row.Cells["colCustFullName"].Value?.ToString() ?? "";
            txtUsername.Text = row.Cells["colCustUsername"].Value?.ToString() ?? "";
            txtEmail.Text = row.Cells["colCustEmail"].Value?.ToString() ?? "";
            txtPhone.Text = row.Cells["colCustPhone"].Value?.ToString() ?? "";
            txtAddress.Text = row.Cells["colCustAddress"].Value?.ToString() ?? "";

            object dateObj = row.Cells["colCustCreatedDate"].Value;
            if (dateObj != null && DateTime.TryParse(dateObj.ToString(), out DateTime date))
                dtpRegisteredDate.Value = date;
        }

        // ---------------------------------------------------------------
        //  SEARCH / RESET / REFRESH
        // ---------------------------------------------------------------
        private void btnSearch_Click(object sender, EventArgs e) => LoadCustomers();
        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            txtSearchName.Clear();
            txtSearchUsername.Clear();
            txtSearchEmail.Clear();
            LoadCustomers();
        }
        private void btnRefreshResults_Click(object sender, EventArgs e) => LoadCustomers();
        private void btnRefresh_Click(object sender, EventArgs e) => LoadCustomers();

        // ---------------------------------------------------------------
        //  UPDATE CUSTOMER
        // ---------------------------------------------------------------
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();
            int customerId = Convert.ToInt32(txtCustomerID.Text);

            // Combined empty check (unchanged)
            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Replace inline email check with ValidationHelper
            string errorMsg;
            if (!ValidationHelper.IsValidEmail(email, out errorMsg))
            {
                MessageBox.Show(errorMsg, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Replace inline phone check with ValidationHelper
            if (!ValidationHelper.IsValidPhone(phone, out errorMsg))
            {
                MessageBox.Show(errorMsg, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Duplicate email check (unchanged, calls Admin)
            if (admin.IsCustomerEmailDuplicate(email, customerId))
            {
                MessageBox.Show("This email is already used by another customer.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Customer customer = new Customer
            {
                CustomerID = customerId,
                FullName = fullName,
                Email = email,
                Phone = phone,
                Address = address
            };

            bool success = admin.UpdateCustomer(customer);
            if (success)
            {
                MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomers();
                LoadSummary();
                ClearDetails();
            }
            else
            {
                MessageBox.Show("Update failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearDetails();

        private void ClearDetails()
        {
            dgvCustomers.ClearSelection();
            txtCustomerID.Clear();
            txtFullName.Clear();
            txtUsername.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            dtpRegisteredDate.Value = DateTime.Now;
        }

        // =================================================================
        //  SIDEBAR NAVIGATION & TOP‑BAR ICON
        // =================================================================

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNavMedicines_Click(object sender, EventArgs e)
        {
            this.Hide();
            MedicineManagementForm medForm = new MedicineManagementForm();
            medForm.FormClosed += (s, args) => this.Show();
            medForm.Show();
        }

        private void btnNavCustomers_Click(object sender, EventArgs e)
        {
            // Already here
        }

        private void btnNavOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderManagementForm ordersForm = new OrderManagementForm();
            ordersForm.FormClosed += (s, args) => this.Show();
            ordersForm.Show();
        }

        private void btnNavReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportForm reportsForm = new ReportForm();
            reportsForm.FormClosed += (s, args) => this.Show();
            reportsForm.Show();
        }

        private void btnNavLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SessionManager.CurrentSession?.EndSession();
                Application.Restart();
            }
        }

        private void btnLogoutIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // =================================================================
        //  ROUNDED CORNERS
        // =================================================================
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
            RoundControl(pnlPageHeaderCard, r);
            RoundControl(pnlCustomerDetailsCard, r);
            RoundControl(pnlActionButtonsCard, r);
            RoundControl(pnlSearchFiltersCard, r);
            RoundControl(pnlCustomerGridCard, r);
        }
    }
}