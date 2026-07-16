using SmartMed.Helpers;
using SmartMed.Models;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SmartMed.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            btnRegister.Click += btnRegister_Click;
            btnBackToLogin.Click += btnBackToLogin_Click;
            lblClearFields.LinkClicked += lblClearFields_LinkClicked;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            this.Load += RegisterForm_Load;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Reset error display
            lblErrorMessage.Visible = false;
            lblErrorMessage.Text = "";
            lblErrorMessage.Height = 24;

            // Trim all inputs
            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            string error;

            // --- Required field checks (centralised helper) ---
            if (!ValidationHelper.IsRequired(fullName, "Full Name cannot be empty.", out error))
            { ShowError(error, txtFullName); return; }
            if (!ValidationHelper.IsRequired(username, "Username cannot be empty.", out error))
            { ShowError(error, txtUsername); return; }
            if (!ValidationHelper.IsRequired(email, "Email cannot be empty.", out error))
            { ShowError(error, txtEmail); return; }
            if (!ValidationHelper.IsRequired(phone, "Phone cannot be empty.", out error))
            { ShowError(error, txtPhone); return; }
            if (!ValidationHelper.IsRequired(address, "Address cannot be empty.", out error))
            { ShowError(error, txtAddress); return; }
            if (!ValidationHelper.IsRequired(password, "Password cannot be empty.", out error))
            { ShowError(error, txtPassword); return; }
            if (!ValidationHelper.IsRequired(confirmPassword, "Confirm Password cannot be empty.", out error))
            { ShowError(error, txtConfirmPassword); return; }

            // --- Format validations (email, phone, password strength, match) ---
            if (!ValidationHelper.IsValidEmail(email, out error))
            { ShowError(error, txtEmail); return; }
            if (!ValidationHelper.IsValidPhone(phone, out error))
            { ShowError(error, txtPhone); return; }
            if (!ValidationHelper.IsValidPassword(password, out error))
            { ShowError(error, txtPassword); return; }
            if (!ValidationHelper.IsPasswordMatch(password, confirmPassword, out error))
            { ShowError(error, txtConfirmPassword); return; }

            // Build the Customer object (no validation inside it)
            Customer newCustomer = new Customer
            {
                Username = username,
                Password = password,
                FullName = fullName,
                Email = email,
                Phone = phone,
                Address = address
            };

            // Show loading animation and attempt registration
            ShowLoading(true);
            bool success = newCustomer.Register();
            ShowLoading(false);

            if (success)
            {
                ClearAllFields();
                lblErrorMessage.Visible = false;
                MessageBox.Show("Registration completed successfully.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                // Display the error stored inside the Customer model
                string errorMsg = Customer.LastRegistrationError;
                Control focusCtrl = errorMsg.Contains("Username") ? txtUsername :
                                    errorMsg.Contains("Email") ? txtEmail : null;
                ShowError(errorMsg, focusCtrl);
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e) => this.Close();

        private void lblClearFields_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearAllFields();
            lblErrorMessage.Visible = false;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool hidePassword = !chkShowPassword.Checked;
            txtPassword.UseSystemPasswordChar = hidePassword;
            txtConfirmPassword.UseSystemPasswordChar = hidePassword;
        }

        // Show error inside the dedicated label, auto‑size height, set focus
        private void ShowError(string message, Control focusControl)
        {
            lblErrorMessage.Text = message;
            int labelWidth = lblErrorMessage.ClientSize.Width - lblErrorMessage.Padding.Horizontal;
            Size textSize = TextRenderer.MeasureText(message, lblErrorMessage.Font,
                new Size(labelWidth, int.MaxValue), TextFormatFlags.WordBreak);
            lblErrorMessage.Height = textSize.Height + lblErrorMessage.Padding.Vertical + 10;
            lblErrorMessage.Visible = true;
            focusControl?.Focus();
        }

        // Clear every input field
        private void ClearAllFields()
        {
            txtFullName.Clear(); txtUsername.Clear(); txtEmail.Clear();
            txtPhone.Clear(); txtAddress.Clear();
            txtPassword.Clear(); txtConfirmPassword.Clear();
        }

        // Toggle loading overlay and disable register button
        private void ShowLoading(bool isLoading)
        {
            pnlLoading.Visible = isLoading;
            lblLoadingText.Visible = isLoading;
            pbLoadingSpinner.Visible = isLoading;
            btnRegister.Enabled = !isLoading;
            Application.DoEvents();
        }

        // --- Rounded corners (unchanged) ---
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect,
            int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void ApplyRoundedCorners()
        {
            void RoundControl(Control c, int radius)
            {
                if (c != null && c.Width > 0 && c.Height > 0)
                    c.Region = Region.FromHrgn(
                        CreateRoundRectRgn(0, 0, c.Width, c.Height, radius, radius));
            }

            int r = 20;
            RoundControl(pnlCard, r);
            RoundControl(pnlFullNameBox, r);
            RoundControl(pnlUsernameBox, r);
            RoundControl(pnlEmailBox, r);
            RoundControl(pnlPhoneBox, r);
            RoundControl(pnlAddressBox, r);
            RoundControl(pnlPasswordBox, r);
            RoundControl(pnlConfirmPasswordBox, r);
            RoundControl(btnRegister, r);
            RoundControl(btnBackToLogin, r);
        }

        private void RegisterForm_Load(object sender, EventArgs e) => ApplyRoundedCorners();
    }
}