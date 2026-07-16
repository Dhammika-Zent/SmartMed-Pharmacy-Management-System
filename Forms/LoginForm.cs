// ============================================================
// LoginForm.cs – UI controller only, no SQL
// ============================================================
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SmartMed.Forms;
using SmartMed.Helpers;          // <-- added
using SmartMed.Models;

namespace SmartMed
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            btnLogin.Click += btnLogin_Click;
            btnRegister.Click += btnRegister_Click;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            this.Load += LoginForm_Load;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Text = "";
            lblErrorMessage.Visible = false;

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // ---------- UI Validation (centralised) ----------
            if (!ValidationHelper.IsRequired(username, "Username cannot be empty.", out string error))
            {
                ShowError(error, txtUsername);
                return;
            }
            if (!ValidationHelper.IsRequired(password, "Password cannot be empty.", out error))
            {
                ShowError(error, txtPassword);
                return;
            }

            // ---------- Delegate authentication to Admin ----------
            Admin admin = new Admin();
            admin.Username = username;
            admin.Password = password;

            if (admin.Login())
            {
                lblErrorMessage.Visible = false;
                AdminDashboard adminDash = new AdminDashboard();
                adminDash.FormClosed += (s, args) => this.Close();
                adminDash.Show();
                this.Hide();
                return;
            }

            // ---------- Delegate authentication to Customer ----------
            Customer cust = new Customer();
            cust.Username = username;
            cust.Password = password;

            if (cust.Login())
            {
                lblErrorMessage.Visible = false;
                CustomerDashboard custDash = new CustomerDashboard();
                custDash.FormClosed += (s, args) => this.Close();
                custDash.Show();
                this.Hide();
            }
            else
            {
                ShowError("Invalid username or password.", null);
            }
        }

        /// <summary>
        /// Displays a validation error using the dedicated error label.
        /// Preserves the original styling (height, padding).
        /// </summary>
        private void ShowError(string message, Control focusControl)
        {
            lblErrorMessage.Height = 30;
            lblErrorMessage.Padding = new Padding(12, 6, 12, 6);
            lblErrorMessage.Text = message;
            lblErrorMessage.Visible = true;
            focusControl?.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm regForm = new RegisterForm();
            regForm.ShowDialog();
            this.Show();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        // --- Rounded corners and designer‑generated handlers (unchanged) ---
        #region Rounded Corners & Designer Events
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

            int r = 20;
            RoundControl(pnlCard, r);
            RoundControl(pnlUsernameBox, r);
            RoundControl(pnlPasswordBox, r);
            RoundControl(btnLogin, r);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ApplyRoundedCorners();
        }

        private void lblLogoSuffix_Click(object sender, EventArgs e) { }
        private void lblLogoAccentDot_Click(object sender, EventArgs e) { }
        private void lblErrorMessage_Click(object sender, EventArgs e) { }
        private void pnlBackdrop_Paint(object sender, PaintEventArgs e) { }
        private void lblLogoSuffix_Click_1(object sender, EventArgs e) { }
        private void pnlBackdrop_Paint_1(object sender, PaintEventArgs e) { }
        private void lblLogoPrefix_Click(object sender, EventArgs e) { }
        private void lblLogoAccentDot_Click_1(object sender, EventArgs e) { }
        private void lblErrorMessage_Click_1(object sender, EventArgs e) { }
        #endregion
    }
}