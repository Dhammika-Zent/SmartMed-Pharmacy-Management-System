namespace SmartMed.Forms
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlBackdrop = new System.Windows.Forms.Panel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.pnlCardInner = new System.Windows.Forms.Panel();
            this.lblFooterTagline = new System.Windows.Forms.Label();
            this.pnlAccountRow = new System.Windows.Forms.Panel();
            this.lblHaveAccount = new System.Windows.Forms.Label();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pnlLoading = new System.Windows.Forms.Panel();
            this.pbLoadingSpinner = new System.Windows.Forms.PictureBox();
            this.lblLoadingText = new System.Windows.Forms.Label();
            this.lblClearFields = new System.Windows.Forms.LinkLabel();
            this.pnlColumns = new System.Windows.Forms.Panel();
            this.pnlRightCol = new System.Windows.Forms.Panel();
            this.pnlAddressBox = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddressIcon = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.pnlPasswordBox = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPasswordIcon = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlConfirmPasswordBox = new System.Windows.Forms.Panel();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPasswordIcon = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.pnlLeftCol = new System.Windows.Forms.Panel();
            this.pnlFullNameBox = new System.Windows.Forms.Panel();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullNameIcon = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.pnlUsernameBox = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsernameIcon = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlEmailBox = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmailIcon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pnlPhoneBox = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhoneIcon = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblWelcomeTitle = new System.Windows.Forms.Label();
            this.pnlLogoWordmark = new System.Windows.Forms.Panel();
            this.lblLogoSuffix = new System.Windows.Forms.Label();
            this.lblLogoAccentDot = new System.Windows.Forms.Label();
            this.lblLogoPrefix = new System.Windows.Forms.Label();
            this.toolTipHints = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBackdrop.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.pnlCardInner.SuspendLayout();
            this.pnlAccountRow.SuspendLayout();
            this.pnlLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingSpinner)).BeginInit();
            this.pnlColumns.SuspendLayout();
            this.pnlRightCol.SuspendLayout();
            this.pnlAddressBox.SuspendLayout();
            this.pnlPasswordBox.SuspendLayout();
            this.pnlConfirmPasswordBox.SuspendLayout();
            this.pnlLeftCol.SuspendLayout();
            this.pnlFullNameBox.SuspendLayout();
            this.pnlUsernameBox.SuspendLayout();
            this.pnlEmailBox.SuspendLayout();
            this.pnlPhoneBox.SuspendLayout();
            this.pnlLogoWordmark.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackdrop
            // 
            this.pnlBackdrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlBackdrop.Controls.Add(this.pnlCard);
            this.pnlBackdrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackdrop.Location = new System.Drawing.Point(0, 0);
            this.pnlBackdrop.Name = "pnlBackdrop";
            this.pnlBackdrop.Size = new System.Drawing.Size(1000, 720);
            this.pnlBackdrop.TabIndex = 0;
            // 
            // pnlCard
            // 
            this.pnlCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlCard.Controls.Add(this.pnlCardInner);
            this.pnlCard.Location = new System.Drawing.Point(115, 25);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Padding = new System.Windows.Forms.Padding(40, 40, 40, 30);
            this.pnlCard.Size = new System.Drawing.Size(770, 670);
            this.pnlCard.TabIndex = 1;
            // 
            // pnlCardInner
            // 
            this.pnlCardInner.BackColor = System.Drawing.Color.Transparent;
            this.pnlCardInner.Controls.Add(this.lblFooterTagline);
            this.pnlCardInner.Controls.Add(this.pnlAccountRow);
            this.pnlCardInner.Controls.Add(this.btnRegister);
            this.pnlCardInner.Controls.Add(this.pnlLoading);
            this.pnlCardInner.Controls.Add(this.lblClearFields);
            this.pnlCardInner.Controls.Add(this.pnlColumns);
            this.pnlCardInner.Controls.Add(this.lblErrorMessage);
            this.pnlCardInner.Controls.Add(this.lblSubtitle);
            this.pnlCardInner.Controls.Add(this.lblWelcomeTitle);
            this.pnlCardInner.Controls.Add(this.pnlLogoWordmark);
            this.pnlCardInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardInner.Location = new System.Drawing.Point(40, 40);
            this.pnlCardInner.Name = "pnlCardInner";
            this.pnlCardInner.Size = new System.Drawing.Size(690, 600);
            this.pnlCardInner.TabIndex = 0;
            // 
            // lblFooterTagline
            // 
            this.lblFooterTagline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFooterTagline.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFooterTagline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblFooterTagline.Location = new System.Drawing.Point(0, 574);
            this.lblFooterTagline.Name = "lblFooterTagline";
            this.lblFooterTagline.Size = new System.Drawing.Size(690, 26);
            this.lblFooterTagline.TabIndex = 15;
            this.lblFooterTagline.Text = "Secured with role-based access · SmartMed © 2026";
            this.lblFooterTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAccountRow
            // 
            this.pnlAccountRow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAccountRow.BackColor = System.Drawing.Color.Transparent;
            this.pnlAccountRow.Controls.Add(this.lblHaveAccount);
            this.pnlAccountRow.Controls.Add(this.btnBackToLogin);
            this.pnlAccountRow.Location = new System.Drawing.Point(0, 524);
            this.pnlAccountRow.Name = "pnlAccountRow";
            this.pnlAccountRow.Size = new System.Drawing.Size(690, 47);
            this.pnlAccountRow.TabIndex = 14;
            // 
            // lblHaveAccount
            // 
            this.lblHaveAccount.AutoSize = true;
            this.lblHaveAccount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHaveAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblHaveAccount.Location = new System.Drawing.Point(437, 17);
            this.lblHaveAccount.Name = "lblHaveAccount";
            this.lblHaveAccount.Size = new System.Drawing.Size(156, 17);
            this.lblHaveAccount.TabIndex = 0;
            this.lblHaveAccount.Text = "Already have an account?";
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnBackToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnBackToLogin.FlatAppearance.BorderSize = 2;
            this.btnBackToLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnBackToLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnBackToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnBackToLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnBackToLogin.Location = new System.Drawing.Point(599, 6);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(90, 38);
            this.btnBackToLogin.TabIndex = 1;
            this.btnBackToLogin.Text = "Sign In";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(0, 476);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(690, 48);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Create Account";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // pnlLoading
            // 
            this.pnlLoading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLoading.BackColor = System.Drawing.Color.Transparent;
            this.pnlLoading.Controls.Add(this.pbLoadingSpinner);
            this.pnlLoading.Controls.Add(this.lblLoadingText);
            this.pnlLoading.Location = new System.Drawing.Point(0, 530);
            this.pnlLoading.Name = "pnlLoading";
            this.pnlLoading.Size = new System.Drawing.Size(690, 30);
            this.pnlLoading.TabIndex = 14;
            this.pnlLoading.Visible = false;
            // 
            // pbLoadingSpinner
            // 
            this.pbLoadingSpinner.Location = new System.Drawing.Point(230, 3);
            this.pbLoadingSpinner.Name = "pbLoadingSpinner";
            this.pbLoadingSpinner.Size = new System.Drawing.Size(22, 22);
            this.pbLoadingSpinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLoadingSpinner.TabIndex = 0;
            this.pbLoadingSpinner.TabStop = false;
            // 
            // lblLoadingText
            // 
            this.lblLoadingText.AutoSize = true;
            this.lblLoadingText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoadingText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblLoadingText.Location = new System.Drawing.Point(257, 6);
            this.lblLoadingText.Name = "lblLoadingText";
            this.lblLoadingText.Size = new System.Drawing.Size(107, 15);
            this.lblLoadingText.TabIndex = 1;
            this.lblLoadingText.Text = "Creating account...";
            // 
            // lblClearFields
            // 
            this.lblClearFields.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(253)))));
            this.lblClearFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClearFields.AutoSize = true;
            this.lblClearFields.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblClearFields.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblClearFields.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.lblClearFields.Location = new System.Drawing.Point(612, 140);
            this.lblClearFields.Name = "lblClearFields";
            this.lblClearFields.Size = new System.Drawing.Size(80, 15);
            this.lblClearFields.TabIndex = 10;
            this.lblClearFields.TabStop = true;
            this.lblClearFields.Text = "Clear all fields";
            // 
            // pnlColumns
            // 
            this.pnlColumns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlColumns.BackColor = System.Drawing.Color.Transparent;
            this.pnlColumns.Controls.Add(this.pnlRightCol);
            this.pnlColumns.Controls.Add(this.pnlLeftCol);
            this.pnlColumns.Location = new System.Drawing.Point(0, 160);
            this.pnlColumns.Name = "pnlColumns";
            this.pnlColumns.Size = new System.Drawing.Size(690, 280);
            this.pnlColumns.TabIndex = 11;
            // 
            // pnlRightCol
            // 
            this.pnlRightCol.Controls.Add(this.pnlAddressBox);
            this.pnlRightCol.Controls.Add(this.lblAddress);
            this.pnlRightCol.Controls.Add(this.pnlPasswordBox);
            this.pnlRightCol.Controls.Add(this.lblPassword);
            this.pnlRightCol.Controls.Add(this.pnlConfirmPasswordBox);
            this.pnlRightCol.Controls.Add(this.lblConfirmPassword);
            this.pnlRightCol.Controls.Add(this.chkShowPassword);
            this.pnlRightCol.Location = new System.Drawing.Point(365, 0);
            this.pnlRightCol.Name = "pnlRightCol";
            this.pnlRightCol.Size = new System.Drawing.Size(325, 280);
            this.pnlRightCol.TabIndex = 1;
            // 
            // pnlAddressBox
            // 
            this.pnlAddressBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAddressBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlAddressBox.Controls.Add(this.txtAddress);
            this.pnlAddressBox.Controls.Add(this.lblAddressIcon);
            this.pnlAddressBox.Location = new System.Drawing.Point(0, 22);
            this.pnlAddressBox.Name = "pnlAddressBox";
            this.pnlAddressBox.Padding = new System.Windows.Forms.Padding(1);
            this.pnlAddressBox.Size = new System.Drawing.Size(325, 44);
            this.pnlAddressBox.TabIndex = 20;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddress.ForeColor = System.Drawing.Color.White;
            this.txtAddress.Location = new System.Drawing.Point(44, 13);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(269, 18);
            this.txtAddress.TabIndex = 1;
            // 
            // lblAddressIcon
            // 
            this.lblAddressIcon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAddressIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblAddressIcon.Location = new System.Drawing.Point(12, 10);
            this.lblAddressIcon.Name = "lblAddressIcon";
            this.lblAddressIcon.Size = new System.Drawing.Size(28, 24);
            this.lblAddressIcon.TabIndex = 0;
            this.lblAddressIcon.Text = "📍";
            this.lblAddressIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblAddress.Location = new System.Drawing.Point(0, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(49, 15);
            this.lblAddress.TabIndex = 19;
            this.lblAddress.Text = "Address";
            // 
            // pnlPasswordBox
            // 
            this.pnlPasswordBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlPasswordBox.Controls.Add(this.txtPassword);
            this.pnlPasswordBox.Controls.Add(this.lblPasswordIcon);
            this.pnlPasswordBox.Location = new System.Drawing.Point(0, 92);
            this.pnlPasswordBox.Name = "pnlPasswordBox";
            this.pnlPasswordBox.Padding = new System.Windows.Forms.Padding(1);
            this.pnlPasswordBox.Size = new System.Drawing.Size(325, 44);
            this.pnlPasswordBox.TabIndex = 22;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(44, 13);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(269, 18);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPasswordIcon
            // 
            this.lblPasswordIcon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPasswordIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblPasswordIcon.Location = new System.Drawing.Point(12, 10);
            this.lblPasswordIcon.Name = "lblPasswordIcon";
            this.lblPasswordIcon.Size = new System.Drawing.Size(28, 24);
            this.lblPasswordIcon.TabIndex = 0;
            this.lblPasswordIcon.Text = "🔒";
            this.lblPasswordIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblPassword.Location = new System.Drawing.Point(0, 72);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 15);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Password";
            // 
            // pnlConfirmPasswordBox
            // 
            this.pnlConfirmPasswordBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlConfirmPasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlConfirmPasswordBox.Controls.Add(this.txtConfirmPassword);
            this.pnlConfirmPasswordBox.Controls.Add(this.lblConfirmPasswordIcon);
            this.pnlConfirmPasswordBox.Location = new System.Drawing.Point(0, 162);
            this.pnlConfirmPasswordBox.Name = "pnlConfirmPasswordBox";
            this.pnlConfirmPasswordBox.Padding = new System.Windows.Forms.Padding(1);
            this.pnlConfirmPasswordBox.Size = new System.Drawing.Size(325, 44);
            this.pnlConfirmPasswordBox.TabIndex = 24;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.txtConfirmPassword.Location = new System.Drawing.Point(44, 13);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(269, 18);
            this.txtConfirmPassword.TabIndex = 1;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPasswordIcon
            // 
            this.lblConfirmPasswordIcon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblConfirmPasswordIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblConfirmPasswordIcon.Location = new System.Drawing.Point(12, 10);
            this.lblConfirmPasswordIcon.Name = "lblConfirmPasswordIcon";
            this.lblConfirmPasswordIcon.Size = new System.Drawing.Size(28, 24);
            this.lblConfirmPasswordIcon.TabIndex = 0;
            this.lblConfirmPasswordIcon.Text = "🔒";
            this.lblConfirmPasswordIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblConfirmPassword.Location = new System.Drawing.Point(0, 142);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(103, 15);
            this.lblConfirmPassword.TabIndex = 23;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // pnlLeftCol
            // 
            this.pnlLeftCol.Controls.Add(this.pnlFullNameBox);
            this.pnlLeftCol.Controls.Add(this.lblFullName);
            this.pnlLeftCol.Controls.Add(this.pnlUsernameBox);
            this.pnlLeftCol.Controls.Add(this.lblUsername);
            this.pnlLeftCol.Controls.Add(this.pnlEmailBox);
            this.pnlLeftCol.Controls.Add(this.lblEmail);
            this.pnlLeftCol.Controls.Add(this.pnlPhoneBox);
            this.pnlLeftCol.Controls.Add(this.lblPhone);
            this.pnlLeftCol.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftCol.Name = "pnlLeftCol";
            this.pnlLeftCol.Size = new System.Drawing.Size(325, 280);
            this.pnlLeftCol.TabIndex = 0;
            // 
            // pnlFullNameBox
            // 
            this.pnlFullNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFullNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlFullNameBox.Controls.Add(this.txtFullName);
            this.pnlFullNameBox.Controls.Add(this.lblFullNameIcon);
            this.pnlFullNameBox.Location = new System.Drawing.Point(0, 21);
            this.pnlFullNameBox.Name = "pnlFullNameBox";
            this.pnlFullNameBox.Padding = new System.Windows.Forms.Padding(1);
            this.pnlFullNameBox.Size = new System.Drawing.Size(325, 44);
            this.pnlFullNameBox.TabIndex = 8;
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFullName.ForeColor = System.Drawing.Color.White;
            this.txtFullName.Location = new System.Drawing.Point(44, 13);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(269, 18);
            this.txtFullName.TabIndex = 1;
            // 
            // lblFullNameIcon
            // 
            this.lblFullNameIcon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblFullNameIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblFullNameIcon.Location = new System.Drawing.Point(12, 10);
            this.lblFullNameIcon.Name = "lblFullNameIcon";
            this.lblFullNameIcon.Size = new System.Drawing.Size(28, 24);
            this.lblFullNameIcon.TabIndex = 0;
            this.lblFullNameIcon.Text = "👤";
            this.lblFullNameIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblFullName.Location = new System.Drawing.Point(0, -1);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(61, 15);
            this.lblFullName.TabIndex = 7;
            this.lblFullName.Text = "Full Name";
            // 
            // pnlUsernameBox
            // 
            this.pnlUsernameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUsernameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlUsernameBox.Controls.Add(this.txtUsername);
            this.pnlUsernameBox.Controls.Add(this.lblUsernameIcon);
            this.pnlUsernameBox.Location = new System.Drawing.Point(0, 91);
            this.pnlUsernameBox.Name = "pnlUsernameBox";
            this.pnlUsernameBox.Padding = new System.Windows.Forms.Padding(1);
            this.pnlUsernameBox.Size = new System.Drawing.Size(325, 44);
            this.pnlUsernameBox.TabIndex = 10;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(44, 13);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(269, 18);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUsernameIcon
            // 
            this.lblUsernameIcon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblUsernameIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblUsernameIcon.Location = new System.Drawing.Point(12, 10);
            this.lblUsernameIcon.Name = "lblUsernameIcon";
            this.lblUsernameIcon.Size = new System.Drawing.Size(28, 24);
            this.lblUsernameIcon.TabIndex = 0;
            this.lblUsernameIcon.Text = "👤";
            this.lblUsernameIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblUsername.Location = new System.Drawing.Point(0, 71);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 15);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "Username";
            // 
            // pnlEmailBox
            // 
            this.pnlEmailBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEmailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlEmailBox.Controls.Add(this.txtEmail);
            this.pnlEmailBox.Controls.Add(this.lblEmailIcon);
            this.pnlEmailBox.Location = new System.Drawing.Point(0, 162);
            this.pnlEmailBox.Name = "pnlEmailBox";
            this.pnlEmailBox.Padding = new System.Windows.Forms.Padding(1);
            this.pnlEmailBox.Size = new System.Drawing.Size(325, 44);
            this.pnlEmailBox.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(44, 13);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(269, 18);
            this.txtEmail.TabIndex = 1;
            // 
            // lblEmailIcon
            // 
            this.lblEmailIcon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEmailIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblEmailIcon.Location = new System.Drawing.Point(12, 10);
            this.lblEmailIcon.Name = "lblEmailIcon";
            this.lblEmailIcon.Size = new System.Drawing.Size(28, 24);
            this.lblEmailIcon.TabIndex = 0;
            this.lblEmailIcon.Text = "✉️";
            this.lblEmailIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblEmail.Location = new System.Drawing.Point(0, 142);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // pnlPhoneBox
            // 
            this.pnlPhoneBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPhoneBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlPhoneBox.Controls.Add(this.txtPhone);
            this.pnlPhoneBox.Controls.Add(this.lblPhoneIcon);
            this.pnlPhoneBox.Location = new System.Drawing.Point(0, 232);
            this.pnlPhoneBox.Name = "pnlPhoneBox";
            this.pnlPhoneBox.Padding = new System.Windows.Forms.Padding(1);
            this.pnlPhoneBox.Size = new System.Drawing.Size(325, 44);
            this.pnlPhoneBox.TabIndex = 14;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(44, 13);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(269, 18);
            this.txtPhone.TabIndex = 1;
            // 
            // lblPhoneIcon
            // 
            this.lblPhoneIcon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPhoneIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblPhoneIcon.Location = new System.Drawing.Point(12, 10);
            this.lblPhoneIcon.Name = "lblPhoneIcon";
            this.lblPhoneIcon.Size = new System.Drawing.Size(28, 24);
            this.lblPhoneIcon.TabIndex = 0;
            this.lblPhoneIcon.Text = "📱";
            this.lblPhoneIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblPhone.Location = new System.Drawing.Point(0, 212);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(88, 15);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Phone Number";
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.chkShowPassword.Location = new System.Drawing.Point(217, 215);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(113, 19);
            this.chkShowPassword.TabIndex = 12;
            this.chkShowPassword.Text = "Show passwords";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblErrorMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblErrorMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblErrorMessage.Location = new System.Drawing.Point(0, 110);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.lblErrorMessage.Size = new System.Drawing.Size(690, 24);
            this.lblErrorMessage.TabIndex = 4;
            this.lblErrorMessage.Text = "Please fill out all required fields.";
            this.lblErrorMessage.Visible = false;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblSubtitle.Location = new System.Drawing.Point(1, 87);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(265, 19);
            this.lblSubtitle.TabIndex = 3;
            this.lblSubtitle.Text = "Create your SmartMed pharmacy account";
            // 
            // lblWelcomeTitle
            // 
            this.lblWelcomeTitle.AutoSize = true;
            this.lblWelcomeTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 21F, System.Drawing.FontStyle.Bold);
            this.lblWelcomeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblWelcomeTitle.Location = new System.Drawing.Point(-3, 47);
            this.lblWelcomeTitle.Name = "lblWelcomeTitle";
            this.lblWelcomeTitle.Size = new System.Drawing.Size(211, 38);
            this.lblWelcomeTitle.TabIndex = 2;
            this.lblWelcomeTitle.Text = "Create Account";
            // 
            // pnlLogoWordmark
            // 
            this.pnlLogoWordmark.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogoWordmark.Controls.Add(this.lblLogoSuffix);
            this.pnlLogoWordmark.Controls.Add(this.lblLogoAccentDot);
            this.pnlLogoWordmark.Controls.Add(this.lblLogoPrefix);
            this.pnlLogoWordmark.Location = new System.Drawing.Point(0, 0);
            this.pnlLogoWordmark.Name = "pnlLogoWordmark";
            this.pnlLogoWordmark.Size = new System.Drawing.Size(690, 40);
            this.pnlLogoWordmark.TabIndex = 1;
            // 
            // lblLogoSuffix
            // 
            this.lblLogoSuffix.AutoSize = true;
            this.lblLogoSuffix.Font = new System.Drawing.Font("Segoe UI Light", 19F);
            this.lblLogoSuffix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblLogoSuffix.Location = new System.Drawing.Point(340, 2);
            this.lblLogoSuffix.Name = "lblLogoSuffix";
            this.lblLogoSuffix.Size = new System.Drawing.Size(65, 36);
            this.lblLogoSuffix.TabIndex = 2;
            this.lblLogoSuffix.Text = "Med";
            // 
            // lblLogoAccentDot
            // 
            this.lblLogoAccentDot.AutoSize = true;
            this.lblLogoAccentDot.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblLogoAccentDot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblLogoAccentDot.Location = new System.Drawing.Point(398, 2);
            this.lblLogoAccentDot.Name = "lblLogoAccentDot";
            this.lblLogoAccentDot.Size = new System.Drawing.Size(22, 36);
            this.lblLogoAccentDot.TabIndex = 1;
            this.lblLogoAccentDot.Text = ".";
            // 
            // lblLogoPrefix
            // 
            this.lblLogoPrefix.AutoSize = true;
            this.lblLogoPrefix.Font = new System.Drawing.Font("Segoe UI Semibold", 19F, System.Drawing.FontStyle.Bold);
            this.lblLogoPrefix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblLogoPrefix.Location = new System.Drawing.Point(263, 2);
            this.lblLogoPrefix.Name = "lblLogoPrefix";
            this.lblLogoPrefix.Size = new System.Drawing.Size(86, 36);
            this.lblLogoPrefix.TabIndex = 0;
            this.lblLogoPrefix.Text = "Smart";
            // 
            // toolTipHints
            // 
            this.toolTipHints.AutoPopDelay = 5000;
            this.toolTipHints.InitialDelay = 400;
            this.toolTipHints.ReshowDelay = 100;
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.pnlBackdrop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(800, 650);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartMed Pharmacy Management System - Register";
            this.pnlBackdrop.ResumeLayout(false);
            this.pnlCard.ResumeLayout(false);
            this.pnlCardInner.ResumeLayout(false);
            this.pnlCardInner.PerformLayout();
            this.pnlAccountRow.ResumeLayout(false);
            this.pnlAccountRow.PerformLayout();
            this.pnlLoading.ResumeLayout(false);
            this.pnlLoading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingSpinner)).EndInit();
            this.pnlColumns.ResumeLayout(false);
            this.pnlRightCol.ResumeLayout(false);
            this.pnlRightCol.PerformLayout();
            this.pnlAddressBox.ResumeLayout(false);
            this.pnlAddressBox.PerformLayout();
            this.pnlPasswordBox.ResumeLayout(false);
            this.pnlPasswordBox.PerformLayout();
            this.pnlConfirmPasswordBox.ResumeLayout(false);
            this.pnlConfirmPasswordBox.PerformLayout();
            this.pnlLeftCol.ResumeLayout(false);
            this.pnlLeftCol.PerformLayout();
            this.pnlFullNameBox.ResumeLayout(false);
            this.pnlFullNameBox.PerformLayout();
            this.pnlUsernameBox.ResumeLayout(false);
            this.pnlUsernameBox.PerformLayout();
            this.pnlEmailBox.ResumeLayout(false);
            this.pnlEmailBox.PerformLayout();
            this.pnlPhoneBox.ResumeLayout(false);
            this.pnlPhoneBox.PerformLayout();
            this.pnlLogoWordmark.ResumeLayout(false);
            this.pnlLogoWordmark.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackdrop;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pnlCardInner;
        private System.Windows.Forms.Panel pnlLogoWordmark;
        private System.Windows.Forms.Label lblLogoPrefix;
        private System.Windows.Forms.Label lblLogoAccentDot;
        private System.Windows.Forms.Label lblLogoSuffix;
        private System.Windows.Forms.Label lblWelcomeTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Panel pnlColumns;
        private System.Windows.Forms.Panel pnlLeftCol;
        private System.Windows.Forms.Panel pnlFullNameBox;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullNameIcon;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Panel pnlUsernameBox;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsernameIcon;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel pnlEmailBox;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmailIcon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel pnlPhoneBox;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhoneIcon;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Panel pnlRightCol;
        private System.Windows.Forms.Panel pnlAddressBox;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddressIcon;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Panel pnlPasswordBox;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPasswordIcon;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnlConfirmPasswordBox;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPasswordIcon;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.LinkLabel lblClearFields;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel pnlLoading;
        private System.Windows.Forms.PictureBox pbLoadingSpinner;
        private System.Windows.Forms.Label lblLoadingText;
        private System.Windows.Forms.Panel pnlAccountRow;
        private System.Windows.Forms.Label lblHaveAccount;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.Label lblFooterTagline;
        private System.Windows.Forms.ToolTip toolTipHints;
    }
}