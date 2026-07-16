using System;
using System.Windows.Forms;
using SmartMed.Helpers;
using SmartMed.Models;

namespace SmartMed.Forms
{
    public partial class ProfileForm : Form
    {
        private Customer _currentCustomer;

        public ProfileForm()
        {
            InitializeComponent();

            // Wire up form and control events
            this.Load += ProfileForm_Load;
            this.btnUpdateProfile.Click += btnUpdateProfile_Click;
            this.btnCancel.Click += btnCancel_Click;
            this.btnChangePassword.Click += btnChangePassword_Click;

            // Sidebar navigation – all use Hide/Show pattern
            this.btnNavDashboard.Click += (s, e) => OpenForm<CustomerDashboard>();
            this.btnNavMedicines.Click += (s, e) => OpenForm<MedicineSearchForm>();
            this.btnNavCart.Click += (s, e) => OpenForm<CartForm>();
            this.btnNavOrders.Click += (s, e) => OpenForm<TrackOrdersForm>();
            this.btnNavProfile.Click += btnNavProfile_Click;   // stay on profile
            this.btnNavLogout.Click += btnNavLogout_Click;

            // Top‑bar door icon → customer dashboard (same pattern)
            this.btnLogoutIcon.Click += (s, e) => OpenForm<CustomerDashboard>();
        }

        // =====================================================
        // Generic navigation helper – hides profile, opens target form,
        // and shows profile again when the target form is closed.
        // =====================================================
        private void OpenForm<T>() where T : Form, new()
        {
            this.Hide();
            var form = new T();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            // Guard: session must exist
            if (SessionManager.CurrentSession == null)
            {
                MessageBox.Show("Session expired. Please login again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Load customer object from database
            int customerID = SessionManager.CurrentSession.UserID;
            _currentCustomer = Customer.GetCustomerByID(customerID);

            if (_currentCustomer == null)
            {
                MessageBox.Show("Unable to load profile data.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Populate UI fields with current data
            lblUserName.Text = _currentCustomer.FullName;
            txtUsername.Text = _currentCustomer.Username;
            txtFullName.Text = _currentCustomer.FullName;
            txtEmail.Text = _currentCustomer.Email;
            txtPhone.Text = _currentCustomer.Phone;
            txtAddress.Text = _currentCustomer.Address;

            // Password fields always start empty
            txtPassword.Clear();
            txtConfirmPassword.Clear();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            // Read and trim all inputs
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();
            string newPassword = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            // --- Validate using centralized ValidationHelper ---
            if (!ValidationHelper.IsRequired(fullName, "Full name is required.", out string error))
            { ShowError(error, txtFullName); return; }
            if (!ValidationHelper.IsRequired(email, "Email is required.", out error))
            { ShowError(error, txtEmail); return; }
            if (!ValidationHelper.IsValidEmail(email, out error))
            { ShowError(error, txtEmail); return; }
            if (!ValidationHelper.IsRequired(phone, "Phone number is required.", out error))
            { ShowError(error, txtPhone); return; }
            if (!ValidationHelper.IsValidPhone(phone, out error))
            { ShowError(error, txtPhone); return; }

            // Password validations only run when any password field is filled
            if (!string.IsNullOrEmpty(newPassword) || !string.IsNullOrEmpty(confirmPassword))
            {
                if (!ValidationHelper.IsValidPassword(newPassword, out error))
                { ShowError(error, txtPassword); return; }
                if (!ValidationHelper.IsPasswordMatch(newPassword, confirmPassword, out error))
                { ShowError(error, txtConfirmPassword); return; }
            }

            // Apply changes to the in‑memory customer object
            _currentCustomer.FullName = fullName;
            _currentCustomer.Email = email;
            _currentCustomer.Phone = phone;
            _currentCustomer.Address = address;

            // Send null if no password change, otherwise the new password
            string passwordToSend = string.IsNullOrEmpty(newPassword) ? null : newPassword;
            bool success = _currentCustomer.UpdateProfile(passwordToSend, out string updateError);

            if (!success)
            {
                MessageBox.Show(updateError, "Update Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Refresh session data so top‑bar name updates instantly
            if (SessionManager.CurrentSession != null)
                SessionManager.CurrentSession.FullName = _currentCustomer.FullName;
            lblUserName.Text = _currentCustomer.FullName;

            MessageBox.Show("Profile updated successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear password fields after successful update
            txtPassword.Clear();
            txtConfirmPassword.Clear();
        }

        // Centralised error display – shows message box and sets focus
        private void ShowError(string message, Control focusControl)
        {
            MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            focusControl?.Focus();
        }

        // Cancel – reload original data from the database
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ProfileForm_Load(sender, e);
        }

        // Inform the user how to change the password
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter a new password and confirm it, then click 'Update Profile'.",
                "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNavProfile_Click(object sender, EventArgs e)
        {
            // Already on profile – just refresh data
            ProfileForm_Load(sender, e);
        }

        // =====================================================
        // LOGOUT – closes every open form except the login form
        // to prevent orphan windows.
        // =====================================================
        private void btnNavLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            // Clear session
            SessionManager.CurrentSession?.EndSession();

            // Show login form first (keeps the application alive)
            var loginForm = new LoginForm();
            loginForm.Show();

            // Close every other open form (including hidden ones)
            // Iterate backwards to avoid index shifting while closing
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form f = Application.OpenForms[i];
                if (f != loginForm)
                    f.Close();
            }
        }

        // =====================================================================================================================
        // REQUIRED EVENT HANDLERS (designer generated subscriptions)
        // =====================================================================================================================

        private void picUserAvatar_Click(object sender, EventArgs e)
        {
            // Intentionally empty – navigation is handled elsewhere (top‑bar door icon)
        }

        private void lblHeaderTitle_Click(object sender, EventArgs e) { }
        private void lblUsername_Click(object sender, EventArgs e) { }
        private void txtPassword_TextChanged(object sender, EventArgs e) { }
    }
}