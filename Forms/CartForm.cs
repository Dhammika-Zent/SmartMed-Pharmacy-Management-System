using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SmartMed.Helpers;       // SessionManager
using SmartMed.Managers;      // DatabaseManager (not used directly, kept for potential future use)
using SmartMed.Models;        // OrderItem, Medicine

namespace SmartMed.Forms
{
    public partial class CartForm : Form
    {
        // ====================================================================
        // Static In‑Memory Cart (now internal for Customer access)
        // ====================================================================
        internal static List<OrderItem> CartItems { get; private set; } = new List<OrderItem>();
        internal static Dictionary<int, Medicine> MedicineCache { get; private set; } = new Dictionary<int, Medicine>();

        // ====================================================================
        // Constructor
        // ====================================================================
        public CartForm()
        {
            InitializeComponent();

            // Adjust margins so the grid and empty panel don't touch the title
            dgvCartItems.Margin = new Padding(0, 5, 0, 0);
            pnlEmptyCart.Margin = new Padding(0, 5, 0, 0);

            // Display the logged‑in user's name
            if (SessionManager.CurrentSession != null)
            {
                string displayName = string.IsNullOrEmpty(SessionManager.CurrentSession.FullName)
                                     ? SessionManager.CurrentSession.Username
                                     : SessionManager.CurrentSession.FullName;
                lblUserName.Text = displayName;
            }

            // Sidebar navigation
            btnNavDashboard.Click += (s, e) => NavigateToDashboard();
            btnNavMedicines.Click += (s, e) => OpenFormSafely("MedicineSearchForm");
            btnNavCart.Click += (s, e) => { /* already on cart */ };
            btnNavOrders.Click += (s, e) => OpenTrackOrders();   // ← Now opens the actual order tracker
            btnNavProfile.Click += (s, e) => OpenFormSafely("ProfileForm");
            btnNavLogout.Click += (s, e) => Logout();

            // Top‑bar clicks → back to dashboard
            btnLogoutIcon.Click += (s, e) => NavigateToDashboard();
            picUserAvatar.Click += (s, e) => NavigateToDashboard();
            lblUserName.Click += (s, e) => NavigateToDashboard();

            // Add the "Prescription Required" column programmatically
            DataGridViewTextBoxColumn colPrescription = new DataGridViewTextBoxColumn();
            colPrescription.Name = "colCartPrescription";
            colPrescription.HeaderText = "Prescription Required";
            colPrescription.ReadOnly = true;
            colPrescription.Width = 80;
            dgvCartItems.Columns.Add(colPrescription);

            // Grid and selection events
            dgvCartItems.RowsAdded += DgvCartItems_RowsChanged;
            dgvCartItems.RowsRemoved += DgvCartItems_RowsChanged;
            dgvCartItems.SelectionChanged += DgvCartItems_SelectionChanged;

            // Button click subscriptions
            btnContinueShopping.Click += BtnContinueShopping_Click;
            btnEmptyContinueShopping.Click += BtnEmptyContinueShopping_Click;
            btnUpdateQuantity.Click += BtnUpdateQuantity_Click;
            btnRemoveItem.Click += BtnRemoveItem_Click;
            btnClearCart.Click += BtnClearCart_Click;
            btnCheckout.Click += BtnCheckout_Click;

            // Populate the grid and set initial UI state
            RefreshCartDisplay();
            UpdateEmptyState();
            UpdateActionButtons();
        }

        // ====================================================================
        // Public Static Methods (called from other forms)
        // ====================================================================

        /// <summary>
        /// Adds a medicine to the in‑memory cart.
        /// If the medicine already exists in the cart, the quantity is increased.
        /// Stock checks are performed and the final price (after discount) is stored.
        /// </summary>
        internal static void AddToCart(Medicine medicine, int quantity)
        {
            if (medicine == null)
                throw new ArgumentNullException(nameof(medicine));

            // Quantity must be at least 1
            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be at least 1.", "Invalid Quantity",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Stock must be available
            if (medicine.StockQuantity <= 0)
            {
                MessageBox.Show("This medicine is out of stock.", "Out of Stock",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check for existing item in the cart
            OrderItem existingItem = CartItems.FirstOrDefault(i => i.MedicineID == medicine.MedicineID);

            if (existingItem != null)
            {
                int newQuantity = existingItem.Quantity + quantity;
                if (newQuantity > medicine.StockQuantity)
                {
                    MessageBox.Show($"Cannot add {quantity} more. Available stock is {medicine.StockQuantity}.",
                                    "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                existingItem.Quantity = newQuantity;
            }
            else
            {
                if (quantity > medicine.StockQuantity)
                {
                    MessageBox.Show($"Requested quantity exceeds available stock ({medicine.StockQuantity}).",
                                    "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Use the existing business helper to get the discounted price
                decimal finalPrice = Medicine.ComputeFinalPrice(medicine.Price, medicine.DiscountPercentage);
                OrderItem newItem = new OrderItem(medicine.MedicineID, quantity, finalPrice);
                CartItems.Add(newItem);
            }

            // Cache the medicine for fast grid display (no extra DB calls)
            if (!MedicineCache.ContainsKey(medicine.MedicineID))
                MedicineCache[medicine.MedicineID] = medicine;
        }

        // ====================================================================
        // Grid and Totals
        // ====================================================================

        /// <summary>
        /// Clears the DataGridView and repopulates it from the static CartItems list.
        /// </summary>
        private void LoadCartToGrid()
        {
            dgvCartItems.Rows.Clear();

            foreach (OrderItem item in CartItems)
            {
                Medicine med = GetMedicineForItem(item);
                if (med == null) continue;   // Should never happen, but safe guard

                // The discounted price is stored in item.UnitPrice
                decimal discountedPrice = item.UnitPrice;
                decimal discountPercent = med.DiscountPercentage;
                decimal lineTotal = item.Quantity * discountedPrice;

                int rowIndex = dgvCartItems.Rows.Add();
                DataGridViewRow row = dgvCartItems.Rows[rowIndex];
                row.Cells["colCartMedicine"].Value = med.MedicineName;
                row.Cells["colCartUnitPrice"].Value = $"LKR {discountedPrice:N2}";
                row.Cells["colCartDiscount"].Value = discountPercent.ToString("0.0") + "%";
                row.Cells["colCartQuantity"].Value = item.Quantity;
                row.Cells["colCartSubtotal"].Value = $"LKR {lineTotal:N2}";
                row.Cells["colCartPrescription"].Value = med.PrescriptionRequired ? "Yes" : "No";

                // Store the MedicineID in the row tag for easy access
                row.Tag = item.MedicineID;
            }
        }

        /// <summary>
        /// Updates the summary labels: subtotal (before discount), total discount, final total.
        /// </summary>
        private void UpdateTotals()
        {
            decimal subtotalBeforeDiscount = 0m;
            decimal totalDiscount = 0m;

            foreach (OrderItem item in CartItems)
            {
                Medicine med = GetMedicineForItem(item);
                if (med == null) continue;

                decimal originalPrice = med.Price;
                decimal finalPrice = item.UnitPrice;

                subtotalBeforeDiscount += item.Quantity * originalPrice;
                totalDiscount += item.Quantity * (originalPrice - finalPrice);
            }

            decimal grandTotal = subtotalBeforeDiscount - totalDiscount;

            lblTotalValue.Text = $"LKR {subtotalBeforeDiscount:N2}";
            lblDiscountValue.Text = $"LKR {totalDiscount:N2}";
            lblFinalTotalValue.Text = $"LKR {grandTotal:N2}";
        }

        /// <summary>
        /// Refreshes every part of the cart display in the correct order.
        /// </summary>
        private void RefreshCartDisplay()
        {
            LoadCartToGrid();
            UpdateTotals();
            UpdateEmptyState();
            UpdateActionButtons();
            UpdatePrescriptionWarning();
        }

        // ====================================================================
        // Button Handlers
        // ====================================================================

        private void BtnContinueShopping_Click(object sender, EventArgs e)
        {
            this.Hide();
            var searchForm = new MedicineSearchForm();
            searchForm.Show();
        }

        private void BtnEmptyContinueShopping_Click(object sender, EventArgs e)
        {
            BtnContinueShopping_Click(sender, e);
        }

        private void BtnUpdateQuantity_Click(object sender, EventArgs e)
        {
            if (dgvCartItems.SelectedRows.Count == 0) return;

            int selectedIndex = dgvCartItems.SelectedRows[0].Index;
            if (selectedIndex < 0 || selectedIndex >= CartItems.Count) return;

            OrderItem item = CartItems[selectedIndex];
            Medicine med = GetMedicineForItem(item);
            if (med == null) return;

            string input = ShowQuantityInputDialog(med.MedicineName, med.StockQuantity, item.Quantity);
            if (string.IsNullOrEmpty(input)) return;

            if (!int.TryParse(input, out int newQty))
            {
                MessageBox.Show("Please enter a valid number.", "Invalid Input",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newQty < 1)
            {
                MessageBox.Show("Quantity cannot be less than 1.", "Invalid Quantity",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newQty > med.StockQuantity)
            {
                MessageBox.Show($"Quantity cannot exceed available stock ({med.StockQuantity}).",
                                "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            item.Quantity = newQty;
            RefreshCartDisplay();
        }

        private void BtnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvCartItems.SelectedRows.Count == 0) return;

            int selectedIndex = dgvCartItems.SelectedRows[0].Index;
            if (selectedIndex >= 0 && selectedIndex < CartItems.Count)
            {
                CartItems.RemoveAt(selectedIndex);
                RefreshCartDisplay();
            }
        }

        private void BtnClearCart_Click(object sender, EventArgs e)
        {
            if (CartItems.Count == 0) return;

            DialogResult result = MessageBox.Show("Are you sure you want to clear the entire cart?",
                                                  "Clear Cart", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                CartItems.Clear();
                MedicineCache.Clear();
                RefreshCartDisplay();
            }
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            // ================================================================
            // Delegates checkout coordination to Customer.PlaceOrder()
            // ================================================================
            bool success = Customer.PlaceOrder(out string message);
            if (success)
            {
                MessageBox.Show(message, "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshCartDisplay();   // grid will be empty now
            }
            else
            {
                MessageBox.Show(message, "Checkout Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ====================================================================
        // UI State Helpers
        // ====================================================================

        private void DgvCartItems_RowsChanged(object sender, EventArgs e)
        {
            UpdateEmptyState();
        }

        private void DgvCartItems_SelectionChanged(object sender, EventArgs e)
        {
            UpdateActionButtons();
        }

        private void UpdateEmptyState()
        {
            bool isEmpty = dgvCartItems.Rows.Count == 0;
            dgvCartItems.Visible = !isEmpty;
            pnlEmptyCart.Visible = isEmpty;
            btnCheckout.Enabled = !isEmpty;
        }

        private void UpdateActionButtons()
        {
            bool hasSelection = dgvCartItems.SelectedRows.Count > 0;
            btnUpdateQuantity.Enabled = hasSelection;
            btnRemoveItem.Enabled = hasSelection;
        }

        private void UpdatePrescriptionWarning()
        {
            bool anyPrescriptionRequired = CartItems.Any(item =>
            {
                Medicine med = GetMedicineForItem(item);
                return med != null && med.PrescriptionRequired;
            });

            pnlPrescriptionInfo.Visible = anyPrescriptionRequired;
        }

        // ====================================================================
        // Navigation Helpers
        // ====================================================================

        private void NavigateToDashboard()
        {
            this.Hide();
            var dashboard = new CustomerDashboard();
            dashboard.Show();
        }

        /// <summary>
        /// Opens the Track Orders form (FR‑27) and re‑shows CartForm when closed.
        /// </summary>
        private void OpenTrackOrders()
        {
            this.Hide();
            var trackForm = new TrackOrdersForm();
            trackForm.FormClosed += (s, e) => this.Show();
            trackForm.Show();
        }

        private void OpenFormSafely(string formName)
        {
            try
            {
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

        // ====================================================================
        // Helper Methods
        // ====================================================================

        /// <summary>
        /// Returns the Medicine object associated with an OrderItem,
        /// using the in‑memory cache. Falls back to the database if not cached.
        /// </summary>
        private Medicine GetMedicineForItem(OrderItem item)
        {
            if (MedicineCache.ContainsKey(item.MedicineID))
                return MedicineCache[item.MedicineID];

            Medicine med = Medicine.GetMedicineByID(item.MedicineID);
            if (med != null)
                MedicineCache[item.MedicineID] = med;
            return med;
        }

        /// <summary>
        /// Shows a small input dialog for updating the quantity of a cart item.
        /// Returns the entered text, or empty string if cancelled.
        /// </summary>
        private string ShowQuantityInputDialog(string medicineName, int maxStock, int currentQuantity)
        {
            Form prompt = new Form()
            {
                Width = 360,
                Height = 180,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Update Quantity",
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label lblPrompt = new Label()
            {
                Left = 20,
                Top = 20,
                Width = 300,
                Text = $"{medicineName}\n(1 - {maxStock})"
            };

            TextBox txtInput = new TextBox()
            {
                Left = 20,
                Top = 60,
                Width = 300,
                Text = currentQuantity.ToString()
            };

            Button btnOk = new Button()
            {
                Text = "OK",
                Left = 140,
                Top = 100,
                Width = 80,
                DialogResult = DialogResult.OK
            };

            Button btnCancel = new Button()
            {
                Text = "Cancel",
                Left = 230,
                Top = 100,
                Width = 80,
                DialogResult = DialogResult.Cancel
            };

            prompt.Controls.Add(lblPrompt);
            prompt.Controls.Add(txtInput);
            prompt.Controls.Add(btnOk);
            prompt.Controls.Add(btnCancel);
            prompt.AcceptButton = btnOk;
            prompt.CancelButton = btnCancel;

            return prompt.ShowDialog() == DialogResult.OK ? txtInput.Text : "";
        }

        // ====================================================================
        // Static Cart Cleanup (called by Customer after checkout)
        // ====================================================================
        internal static void ClearCart()
        {
            CartItems.Clear();
            MedicineCache.Clear();
        }

        // ====================================================================
        // Designer Event (required by auto‑generated code, not used)
        // ====================================================================
        private void dgvCartItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Intentionally left empty – grid is read‑only
        }
    }
}