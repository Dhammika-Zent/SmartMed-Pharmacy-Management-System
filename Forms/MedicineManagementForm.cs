using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SmartMed.Models;      // for Medicine class
using SmartMed.Helpers;     // for SessionManager
using System.Data;

namespace SmartMed.Forms
{
    public partial class MedicineManagementForm : Form
    {
        public MedicineManagementForm()
        {
            InitializeComponent();
            // Attach existing event handlers
            this.Load += MedicineManagementForm_Load;
            btnAddMedicine.Click += btnAddMedicine_Click;
            btnUpdateMedicine.Click += btnUpdateMedicine_Click;
            btnDeleteMedicine.Click += btnDeleteMedicine_Click;
            btnClear.Click += btnClear_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnSearch.Click += btnSearch_Click;
            btnResetFilters.Click += btnResetFilters_Click;
            btnRefreshResults.Click += btnRefreshResults_Click;
            dgvMedicines.SelectionChanged += dgvMedicines_SelectionChanged;
            dgvMedicines.CellFormatting += dgvMedicines_CellFormatting;

            // Wire sidebar navigation
            btnNavDashboard.Click += btnNavDashboard_Click;
            btnNavMedicines.Click += btnNavMedicines_Click;
            btnNavCustomers.Click += btnNavCustomers_Click;
            btnNavOrders.Click += btnNavOrders_Click;
            btnNavReports.Click += btnNavReports_Click;
            btnNavLogout.Click += btnNavLogout_Click;

            // Wire top bar icon (go back to dashboard)
            btnLogoutIcon.Click += btnLogoutIcon_Click;
        }

        // =====================================================================================================================
        // FORM LOAD
        // =====================================================================================================================
        private void MedicineManagementForm_Load(object sender, EventArgs e)
        {
            ApplyRoundedCorners();
            SetupGridColumns();
            LoadComboboxes();
            LoadAllMedicines();
            LoadSummary();

            // Set logged-in user name
            if (SessionManager.CurrentSession != null)
            {
                lblUserName.Text = SessionManager.CurrentSession.FullName;
            }
            else
            {
                MessageBox.Show("No active session. Please log in again.", "Session Expired", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        // =====================================================================================================================
        // SIDEBAR & TOP BAR NAVIGATION
        // =====================================================================================================================
        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            this.Close();   // Dashboard reappears thanks to FormClosed event in AdminDashboard
        }

        private void btnNavMedicines_Click(object sender, EventArgs e)
        {
            // Already here – do nothing
        }

        private void btnNavCustomers_Click(object sender, EventArgs e)
        {
            OpenCustomerManagement();
        }

        private void btnNavOrders_Click(object sender, EventArgs e)
        {
            OpenOrderManagement();
        }

        private void btnNavReports_Click(object sender, EventArgs e)
        {
            OpenReport();
        }

        private void btnNavLogout_Click(object sender, EventArgs e)
        {
            PerformLogout();
        }

        // Top‑bar icon (door emoji) returns to the dashboard
        private void btnLogoutIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PerformLogout()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SessionManager.CurrentSession?.EndSession();
                Application.Restart();
            }
        }

        // =====================================================================================================================
        // NAVIGATION HELPERS (Open other forms from sidebar)
        // =====================================================================================================================
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
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        private void OpenReport()
        {
            this.Hide();
            var form = new ReportForm();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        // =====================================================================================================================
        // GRID SETUP
        // =====================================================================================================================
        private void SetupGridColumns()
        {
            colMedID.DataPropertyName = "MedicineID";
            colMedName.DataPropertyName = "MedicineName";
            colMedCategory.DataPropertyName = "Category";
            colMedDosage.DataPropertyName = "Dosage";
            colMedSupplier.DataPropertyName = "Supplier";
            colMedPrice.DataPropertyName = "Price";
            colMedStock.DataPropertyName = "StockQuantity";
            colMedExpiry.DataPropertyName = "ExpiryDate";
            colMedDiscount.DataPropertyName = "DiscountPercentage";
            colMedPrescription.DataPropertyName = "PrescriptionRequired";
        }

        // =====================================================================================================================
        // DATA LOADING
        // =====================================================================================================================
        private void LoadAllMedicines()
        {
            DataTable dt = Medicine.GetAll();
            dgvMedicines.DataSource = dt;
        }

        private void LoadComboboxes()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(Medicine.GetCategories().ToArray());
            cmbCategory.SelectedIndex = -1;

            cmbDosage.Items.Clear();
            cmbDosage.Items.AddRange(Medicine.GetDosages().ToArray());
            cmbDosage.SelectedIndex = -1;

            cmbSupplier.Items.Clear();
            cmbSupplier.Items.AddRange(Medicine.GetSuppliers().ToArray());
            cmbSupplier.SelectedIndex = -1;

            cmbSearchCategory.Items.Clear();
            cmbSearchCategory.Items.Add("All");
            cmbSearchCategory.Items.AddRange(Medicine.GetCategories().ToArray());
            cmbSearchCategory.SelectedIndex = 0;
        }

        private void LoadSummary()
        {
            var summary = Medicine.GetSummary();
            lblTotalMedsValue.Text = summary["Total"].ToString();
            lblAvailableMedsValue.Text = summary["Available"].ToString();
            lblLowStockValue.Text = summary["LowStock"].ToString();
            lblExpiredMedsValue.Text = summary["Expired"].ToString();
            lblPrescriptionMedsValue.Text = summary["Prescription"].ToString();
        }

        // =====================================================================================================================
        // CLEAR INPUTS
        // =====================================================================================================================
        private void ClearControls()
        {
            txtMedicineID.Clear();
            txtMedicineName.Clear();
            cmbCategory.SelectedIndex = -1;
            cmbDosage.SelectedIndex = -1;
            cmbSupplier.SelectedIndex = -1;
            numPrice.Value = 0;
            numStockQuantity.Value = 0;
            dtpExpiryDate.Value = DateTime.Today;
            numDiscount.Value = 0;
            chkPrescription.Checked = false;
        }

        // =====================================================================================================================
        // BUTTON CLICKS (CRUD)
        // =====================================================================================================================
        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                Medicine med = new Medicine();
                med.MedicineName = txtMedicineName.Text.Trim();
                med.Category = cmbCategory.Text;
                med.Dosage = cmbDosage.Text;
                med.Supplier = cmbSupplier.Text;
                med.Price = numPrice.Value;
                med.StockQuantity = (int)numStockQuantity.Value;
                med.ExpiryDate = dtpExpiryDate.Value.Date;
                med.DiscountPercentage = numDiscount.Value;
                med.PrescriptionRequired = chkPrescription.Checked;

                string error = ValidationHelper.ValidateMedicine(med);
                if (error != null)
                {
                    MessageBox.Show(error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Medicine.Add(med))
                {
                    MessageBox.Show("Medicine added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllMedicines();
                    LoadSummary();
                    ClearControls();
                }
                else
                {
                    MessageBox.Show("Failed to add medicine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMedicineID.Text))
                {
                    MessageBox.Show("Please select a medicine from the grid first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Medicine med = new Medicine();
                med.MedicineID = int.Parse(txtMedicineID.Text);
                med.MedicineName = txtMedicineName.Text.Trim();
                med.Category = cmbCategory.Text;
                med.Dosage = cmbDosage.Text;
                med.Supplier = cmbSupplier.Text;
                med.Price = numPrice.Value;
                med.StockQuantity = (int)numStockQuantity.Value;
                med.ExpiryDate = dtpExpiryDate.Value.Date;
                med.DiscountPercentage = numDiscount.Value;
                med.PrescriptionRequired = chkPrescription.Checked;

                string error = ValidationHelper.ValidateMedicine(med);
                if (error != null)
                {
                    MessageBox.Show(error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Medicine.Update(med))
                {
                    MessageBox.Show("Medicine updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllMedicines();
                    LoadSummary();
                    ClearControls();
                }
                else
                {
                    MessageBox.Show("Failed to update medicine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMedicineID.Text))
                {
                    MessageBox.Show("Please select a medicine from the grid first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int id = int.Parse(txtMedicineID.Text);
                DialogResult result = MessageBox.Show("Are you sure you want to delete this medicine?",
                                                      "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (Medicine.Delete(id))
                    {
                        MessageBox.Show("Medicine deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllMedicines();
                        LoadSummary();
                        ClearControls();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete medicine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllMedicines();
            LoadSummary();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            txtSearchName.Clear();
            cmbSearchCategory.SelectedIndex = 0;
            chkLowStock.Checked = false;
            chkExpired.Checked = false;
            chkPrescriptionFilter.Checked = false;
            cmbSortBy.SelectedIndex = -1;
            LoadAllMedicines();
        }

        private void btnRefreshResults_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        // =====================================================================================================================
        // GRID EVENTS
        // =====================================================================================================================
        private void dgvMedicines_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMedicines.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvMedicines.SelectedRows[0];
                txtMedicineID.Text = row.Cells["colMedID"].Value.ToString();
                txtMedicineName.Text = row.Cells["colMedName"].Value.ToString();
                cmbCategory.Text = row.Cells["colMedCategory"].Value.ToString();
                cmbDosage.Text = row.Cells["colMedDosage"].Value.ToString();
                cmbSupplier.Text = row.Cells["colMedSupplier"].Value.ToString();
                numPrice.Value = Convert.ToDecimal(row.Cells["colMedPrice"].Value);
                numStockQuantity.Value = Convert.ToInt32(row.Cells["colMedStock"].Value);
                dtpExpiryDate.Value = DateTime.Parse(row.Cells["colMedExpiry"].Value.ToString());
                numDiscount.Value = Convert.ToDecimal(row.Cells["colMedDiscount"].Value);
                chkPrescription.Checked = Convert.ToBoolean(row.Cells["colMedPrescription"].Value);
            }
        }

        private void dgvMedicines_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMedicines.Columns[e.ColumnIndex].Name == "colMedPrescription" && e.Value != null)
            {
                int val = Convert.ToInt32(e.Value);
                e.Value = val == 1 ? "Yes" : "No";
                e.FormattingApplied = true;
            }
        }

        // =====================================================================================================================
        // SEARCH HELPER
        // =====================================================================================================================
        private void PerformSearch()
        {
            string name = txtSearchName.Text.Trim();
            string category = cmbSearchCategory.Text;
            bool lowStock = chkLowStock.Checked;
            bool expired = chkExpired.Checked;
            bool prescription = chkPrescriptionFilter.Checked;
            string sortBy = cmbSortBy.Text;

            DataTable dt = Medicine.Search(name, category, lowStock, expired, prescription, sortBy);
            dgvMedicines.DataSource = dt;
        }

        private void lblPageDescription_Click(object sender, EventArgs e)
        {

        }

        // =====================================================================================================================
        // ROUNDED CORNERS SECTION
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
            RoundControl(pnlPageHeaderCard, r);
            RoundControl(pnlSumTotalMeds, r);
            RoundControl(pnlSumAvailableMeds, r);
            RoundControl(pnlSumLowStock, r);
            RoundControl(pnlSumExpiredMeds, r);
            RoundControl(pnlSumPrescriptionMeds, r);
            RoundControl(pnlSearchFiltersCard, r);
            RoundControl(pnlMedicineGridCard, r);
            RoundControl(pnlMedicineDetailsCard, r);
            RoundControl(pnlActionButtonsCard, r);
        }
    }
}