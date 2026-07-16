using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SmartMed.Helpers;   // SessionManager
using SmartMed.Models;   // Customer, Medicine

namespace SmartMed.Forms
{
    public partial class MedicineSearchForm : Form
    {
        // The currently logged‑in customer (used to call SearchMedicine)
        private Customer currentCustomer;

        public MedicineSearchForm()
        {
            InitializeComponent();

            // Create a Customer instance from the current session
            currentCustomer = new Customer();
            if (SessionManager.CurrentSession != null)
            {
                currentCustomer.UserID = SessionManager.CurrentSession.UserID;
                currentCustomer.Username = SessionManager.CurrentSession.Username;
                currentCustomer.FullName = SessionManager.CurrentSession.FullName;
            }

            // ----- Display logged‑in user name -----
            if (SessionManager.CurrentSession != null)
            {
                string displayName = string.IsNullOrEmpty(SessionManager.CurrentSession.FullName)
                                     ? SessionManager.CurrentSession.Username
                                     : SessionManager.CurrentSession.FullName;
                lblUserName.Text = displayName;
            }

            // Set up DataGridView columns to map to the DataTable columns
            ConfigureDataGridView();

            // Populate dropdowns
            PopulateCategoryComboBox();
            PopulateSortingComboBox();

            // Wire up button events
            btnSearch.Click += btnSearch_Click;
            btnClear.Click += btnClear_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnAddToCart.Click += btnAddToCart_Click;

            // ----- Wire sidebar navigation -----
            btnNavDashboard.Click += (s, e) => NavigateToDashboard();
            btnNavMedicines.Click += (s, e) => { /* already here */ };
            btnNavCart.Click += (s, e) => OpenFormSafely("CartForm");
            btnNavOrders.Click += (s, e) => OpenFormSafely("OrdersForm");
            btnNavProfile.Click += (s, e) => OpenFormSafely("ProfileForm");

            // ----- Wire logout (only sidebar logout button) -----
            btnNavLogout.Click += (s, e) => Logout();

            // ----- Wire top‑bar user avatar, name, and door icon → back to dashboard -----
            picUserAvatar.Click += (s, e) => NavigateToDashboard();
            lblUserName.Click += (s, e) => NavigateToDashboard();
            btnLogoutIcon.Click += (s, e) => NavigateToDashboard();  // Now goes to dashboard, not logout

            // Load all medicines when the form first appears
            this.Load += MedicineSearchForm_Load;
        }

        // =====================================================================================================================
        //  NAVIGATION HELPERS
        // =====================================================================================================================

        /// <summary>Returns to the Customer Dashboard.</summary>
        private void NavigateToDashboard()
        {
            this.Hide();
            var dashboard = new CustomerDashboard();
            dashboard.Show();
        }

        /// <summary>Opens a form by its class name (must exist in SmartMed.Forms).</summary>
        private void OpenFormSafely(string formName)
        {
            try
            {
                // Build the full type name
                Type formType = Type.GetType($"SmartMed.Forms.{formName}, {System.Reflection.Assembly.GetExecutingAssembly().FullName}");
                if (formType == null)
                    throw new Exception("Form not found.");

                Form form = (Form)Activator.CreateInstance(formType);
                this.Hide();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The {formName} feature is not available yet.\n({ex.Message})", "Coming Soon",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // =====================================================================================================================
        //  LOGOUT
        // =====================================================================================================================
        private void Logout()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                                                  "Confirm Logout",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Clear the session data
                SessionManager.CurrentSession?.EndSession();

                // Return to login form
                this.Hide();
                var loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        // =====================================================================================================================
        //  FORM LOAD
        // =====================================================================================================================
        private void MedicineSearchForm_Load(object sender, EventArgs e)
        {
            // Perform an initial search with no filters (shows all medicines)
            PerformSearch();
        }

        // =====================================================================================================================
        //  POPULATE COMBOBOXES
        // =====================================================================================================================
        private void PopulateCategoryComboBox()
        {
            var categories = Medicine.GetCategories();
            categories.Insert(0, "All");
            cmbCategory.DataSource = categories;
            cmbCategory.SelectedIndex = 0;
        }

        private void PopulateSortingComboBox()
        {
            string[] sortOptions = new string[]
            {
                "Medicine Name A-Z",
                "Medicine Name Z-A",
                "Price Low → High",
                "Price High → Low"
            };
            cmbSorting.DataSource = sortOptions;
            cmbSorting.SelectedIndex = 0;
        }

        // =====================================================================================================================
        //  CONFIGURE DATAGRIDVIEW
        // =====================================================================================================================
        private void ConfigureDataGridView()
        {
            colMedName.DataPropertyName = "MedicineName";
            colCategory.DataPropertyName = "Category";
            colDosage.DataPropertyName = "Dosage";
            colPrice.DataPropertyName = "Price";
            colDiscount.DataPropertyName = "DiscountPercentage";
            colFinalPrice.DataPropertyName = "FinalPrice";
            colStock.DataPropertyName = "StockQuantity";
            colExpiryDate.DataPropertyName = "ExpiryDate";
            colPrescriptionRequired.DataPropertyName = "PrescriptionRequired";

            colPrice.DefaultCellStyle.Format = "LKR #,##0.00";
            colFinalPrice.DefaultCellStyle.Format = "LKR #,##0.00";
            colDiscount.DefaultCellStyle.Format = "0.0%";
        }

        // =====================================================================================================================
        //  BUTTON CLICK HANDLERS
        // =====================================================================================================================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMedicineName.Clear();
            cmbCategory.SelectedIndex = 0;
            txtMinPrice.Clear();
            txtMaxPrice.Clear();
            cmbSorting.SelectedIndex = 0;
            chkDiscounted.Checked = false;
            chkPrescriptionRequired.Checked = false;
            chkInStock.Checked = false;

            PerformSearch();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        // ---------------------------------------------------
        //  ADD TO CART 
        // ---------------------------------------------------
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            // 1. Validate selection
            if (dgvMedicines.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a medicine first.", "No Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 2. Read selected row data
            DataRowView selectedRow = (DataRowView)dgvMedicines.SelectedRows[0].DataBoundItem;
            int stock = Convert.ToInt32(selectedRow["StockQuantity"]);

            if (stock <= 0)
            {
                MessageBox.Show("This medicine is out of stock.", "Out of Stock",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Build a Medicine object from the DataRow (only the fields we need)
            Medicine medicine = new Medicine
            {
                MedicineID = Convert.ToInt32(selectedRow["MedicineID"]),
                MedicineName = selectedRow["MedicineName"].ToString(),
                Price = Convert.ToDecimal(selectedRow["Price"]),
                DiscountPercentage = Convert.ToDecimal(selectedRow["DiscountPercentage"]),
                StockQuantity = stock,
                PrescriptionRequired = Convert.ToBoolean(selectedRow["PrescriptionRequired"])
            };

            // 4. Get the quantity from the NumericUpDown
            int quantity = (int)nudQuantity.Value;

            // 5. Add to the cart (static method on CartForm)
            CartForm.AddToCart(medicine, quantity);

            // 6. Feedback to the user
            string message = $"\"{medicine.MedicineName}\" (x{quantity}) added to cart.";
            DialogResult result = MessageBox.Show(message + "\n\nWould you like to view your cart now?",
                                                  "Added to Cart",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Navigate to the cart form
                this.Hide();
                var cartForm = new CartForm();
                cartForm.Show();
            }
        }

        // =====================================================================================================================
        //  CORE SEARCH
        // =====================================================================================================================
        private void PerformSearch()
        {
            string name = txtMedicineName.Text.Trim();
            string category = cmbCategory.SelectedItem?.ToString() ?? "All";
            string sortBy = cmbSorting.SelectedItem?.ToString() ?? "Medicine Name A-Z";

            decimal? minPrice = null;
            decimal? maxPrice = null;

            if (!string.IsNullOrWhiteSpace(txtMinPrice.Text))
            {
                if (!decimal.TryParse(txtMinPrice.Text, out decimal min))
                {
                    MessageBox.Show("Minimum price must be a valid number.", "Invalid Input",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMinPrice.Focus();
                    return;
                }
                minPrice = min;
            }

            if (!string.IsNullOrWhiteSpace(txtMaxPrice.Text))
            {
                if (!decimal.TryParse(txtMaxPrice.Text, out decimal max))
                {
                    MessageBox.Show("Maximum price must be a valid number.", "Invalid Input",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaxPrice.Focus();
                    return;
                }
                maxPrice = max;
            }

            if (minPrice.HasValue && maxPrice.HasValue && minPrice.Value > maxPrice.Value)
            {
                MessageBox.Show("Minimum price cannot be greater than maximum price.", "Invalid Price Range",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable results = null;
            try
            {
                results = currentCustomer.SearchMedicine(name, category, minPrice, maxPrice,
                                                         chkDiscounted.Checked, chkPrescriptionRequired.Checked,
                                                         chkInStock.Checked, sortBy);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching: " + ex.Message, "Search Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (results != null && results.Rows.Count > 0)
            {
                dgvMedicines.DataSource = results;
            }
            else
            {
                dgvMedicines.DataSource = null;
                MessageBox.Show("No medicines found matching your criteria.", "No Results",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}