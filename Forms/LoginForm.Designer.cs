namespace SmartMed
{
    partial class LoginForm
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
            this.pnlRegisterRow = new System.Windows.Forms.Panel();
            this.lblNoAccount = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlLoading = new System.Windows.Forms.Panel();
            this.pbLoadingSpinner = new System.Windows.Forms.PictureBox();
            this.lblLoadingText = new System.Windows.Forms.Label();
            this.lblForgotPassword = new System.Windows.Forms.LinkLabel();
            this.pnlOptionsRow = new System.Windows.Forms.Panel();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.pnlPasswordBox = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPasswordIcon = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlUsernameBox = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsernameIcon = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
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
            this.pnlRegisterRow.SuspendLayout();
            this.pnlLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingSpinner)).BeginInit();
            this.pnlOptionsRow.SuspendLayout();
            this.pnlPasswordBox.SuspendLayout();
            this.pnlUsernameBox.SuspendLayout();
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
            this.pnlBackdrop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBackdrop_Paint_1);
            // 
            // pnlCard
            // 
            this.pnlCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlCard.Controls.Add(this.pnlCardInner);
            this.pnlCard.Location = new System.Drawing.Point(260, 40);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Padding = new System.Windows.Forms.Padding(56, 48, 56, 40);
            this.pnlCard.Size = new System.Drawing.Size(480, 640);
            this.pnlCard.TabIndex = 2;
            // 
            // pnlCardInner
            // 
            this.pnlCardInner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCardInner.BackColor = System.Drawing.Color.Transparent;
            this.pnlCardInner.Controls.Add(this.lblFooterTagline);
            this.pnlCardInner.Controls.Add(this.pnlRegisterRow);
            this.pnlCardInner.Controls.Add(this.btnLogin);
            this.pnlCardInner.Controls.Add(this.pnlLoading);
            this.pnlCardInner.Controls.Add(this.lblForgotPassword);
            this.pnlCardInner.Controls.Add(this.pnlOptionsRow);
            this.pnlCardInner.Controls.Add(this.pnlPasswordBox);
            this.pnlCardInner.Controls.Add(this.lblPassword);
            this.pnlCardInner.Controls.Add(this.pnlUsernameBox);
            this.pnlCardInner.Controls.Add(this.lblUsername);
            this.pnlCardInner.Controls.Add(this.lblErrorMessage);
            this.pnlCardInner.Controls.Add(this.lblSubtitle);
            this.pnlCardInner.Controls.Add(this.lblWelcomeTitle);
            this.pnlCardInner.Controls.Add(this.pnlLogoWordmark);
            this.pnlCardInner.Location = new System.Drawing.Point(56, 48);
            this.pnlCardInner.Name = "pnlCardInner";
            this.pnlCardInner.Size = new System.Drawing.Size(368, 552);
            this.pnlCardInner.TabIndex = 0;
            // 
            // lblFooterTagline
            // 
            this.lblFooterTagline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFooterTagline.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFooterTagline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblFooterTagline.Location = new System.Drawing.Point(0, 526);
            this.lblFooterTagline.Name = "lblFooterTagline";
            this.lblFooterTagline.Size = new System.Drawing.Size(368, 26);
            this.lblFooterTagline.TabIndex = 13;
            this.lblFooterTagline.Text = "Secured with role-based access · SmartMed © 2026";
            this.lblFooterTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRegisterRow
            // 
            this.pnlRegisterRow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRegisterRow.BackColor = System.Drawing.Color.Transparent;
            this.pnlRegisterRow.Controls.Add(this.lblNoAccount);
            this.pnlRegisterRow.Controls.Add(this.btnRegister);
            this.pnlRegisterRow.Location = new System.Drawing.Point(0, 476);
            this.pnlRegisterRow.Name = "pnlRegisterRow";
            this.pnlRegisterRow.Size = new System.Drawing.Size(368, 42);
            this.pnlRegisterRow.TabIndex = 12;
            // 
            // lblNoAccount
            // 
            this.lblNoAccount.AutoSize = true;
            this.lblNoAccount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNoAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblNoAccount.Location = new System.Drawing.Point(0, 13);
            this.lblNoAccount.Name = "lblNoAccount";
            this.lblNoAccount.Size = new System.Drawing.Size(143, 17);
            this.lblNoAccount.TabIndex = 0;
            this.lblNoAccount.Text = "Don\'t have an account?";
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnRegister.FlatAppearance.BorderSize = 2;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnRegister.Location = new System.Drawing.Point(190, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(178, 38);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Create Account";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(0, 392);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(368, 48);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Sign In";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // pnlLoading
            // 
            this.pnlLoading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLoading.BackColor = System.Drawing.Color.Transparent;
            this.pnlLoading.Controls.Add(this.pbLoadingSpinner);
            this.pnlLoading.Controls.Add(this.lblLoadingText);
            this.pnlLoading.Location = new System.Drawing.Point(0, 440);
            this.pnlLoading.Name = "pnlLoading";
            this.pnlLoading.Size = new System.Drawing.Size(368, 30);
            this.pnlLoading.TabIndex = 11;
            this.pnlLoading.Visible = false;
            // 
            // pbLoadingSpinner
            // 
            this.pbLoadingSpinner.Location = new System.Drawing.Point(126, 3);
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
            this.lblLoadingText.Location = new System.Drawing.Point(153, 6);
            this.lblLoadingText.Name = "lblLoadingText";
            this.lblLoadingText.Size = new System.Drawing.Size(92, 15);
            this.lblLoadingText.TabIndex = 1;
            this.lblLoadingText.Text = "Signing you in...";
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(253)))));
            this.lblForgotPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblForgotPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblForgotPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.lblForgotPassword.Location = new System.Drawing.Point(245, 349);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(100, 15);
            this.lblForgotPassword.TabIndex = 9;
            this.lblForgotPassword.TabStop = true;
            this.lblForgotPassword.Text = "Forgot password?";
            // 
            // pnlOptionsRow
            // 
            this.pnlOptionsRow.BackColor = System.Drawing.Color.Transparent;
            this.pnlOptionsRow.Controls.Add(this.chkRememberMe);
            this.pnlOptionsRow.Controls.Add(this.chkShowPassword);
            this.pnlOptionsRow.Location = new System.Drawing.Point(0, 345);
            this.pnlOptionsRow.Name = "pnlOptionsRow";
            this.pnlOptionsRow.Size = new System.Drawing.Size(230, 24);
            this.pnlOptionsRow.TabIndex = 8;
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkRememberMe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkRememberMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.chkRememberMe.Location = new System.Drawing.Point(128, 3);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(104, 19);
            this.chkRememberMe.TabIndex = 1;
            this.chkRememberMe.Text = "Remember me";
            this.chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.chkShowPassword.Location = new System.Drawing.Point(0, 3);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(108, 19);
            this.chkShowPassword.TabIndex = 0;
            this.chkShowPassword.Text = "Show password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            // 
            // pnlPasswordBox
            // 
            this.pnlPasswordBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlPasswordBox.Controls.Add(this.txtPassword);
            this.pnlPasswordBox.Controls.Add(this.lblPasswordIcon);
            this.pnlPasswordBox.Location = new System.Drawing.Point(0, 289);
            this.pnlPasswordBox.Name = "pnlPasswordBox";
            this.pnlPasswordBox.Padding = new System.Windows.Forms.Padding(1);
            this.pnlPasswordBox.Size = new System.Drawing.Size(368, 44);
            this.pnlPasswordBox.TabIndex = 7;
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
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(312, 18);
            this.txtPassword.TabIndex = 1;
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
            this.lblPassword.Location = new System.Drawing.Point(0, 267);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 15);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // pnlUsernameBox
            // 
            this.pnlUsernameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUsernameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlUsernameBox.Controls.Add(this.txtUsername);
            this.pnlUsernameBox.Controls.Add(this.lblUsernameIcon);
            this.pnlUsernameBox.Location = new System.Drawing.Point(0, 201);
            this.pnlUsernameBox.Name = "pnlUsernameBox";
            this.pnlUsernameBox.Padding = new System.Windows.Forms.Padding(1);
            this.pnlUsernameBox.Size = new System.Drawing.Size(368, 44);
            this.pnlUsernameBox.TabIndex = 5;
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
            this.txtUsername.Size = new System.Drawing.Size(312, 18);
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
            this.lblUsername.Location = new System.Drawing.Point(0, 179);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 15);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblErrorMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblErrorMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblErrorMessage.Location = new System.Drawing.Point(0, 149);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.lblErrorMessage.Size = new System.Drawing.Size(368, 24);
            this.lblErrorMessage.TabIndex = 3;
            this.lblErrorMessage.Text = "Invalid username or password.";
            this.lblErrorMessage.Visible = false;
            this.lblErrorMessage.Click += new System.EventHandler(this.lblErrorMessage_Click_1);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblSubtitle.Location = new System.Drawing.Point(0, 118);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(295, 19);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Sign in to your pharmacy management system";
            // 
            // lblWelcomeTitle
            // 
            this.lblWelcomeTitle.AutoSize = true;
            this.lblWelcomeTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 21F, System.Drawing.FontStyle.Bold);
            this.lblWelcomeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblWelcomeTitle.Location = new System.Drawing.Point(0, 74);
            this.lblWelcomeTitle.Name = "lblWelcomeTitle";
            this.lblWelcomeTitle.Size = new System.Drawing.Size(203, 38);
            this.lblWelcomeTitle.TabIndex = 1;
            this.lblWelcomeTitle.Text = "Welcome Back";
            // 
            // pnlLogoWordmark
            // 
            this.pnlLogoWordmark.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogoWordmark.Controls.Add(this.lblLogoSuffix);
            this.pnlLogoWordmark.Controls.Add(this.lblLogoAccentDot);
            this.pnlLogoWordmark.Controls.Add(this.lblLogoPrefix);
            this.pnlLogoWordmark.Location = new System.Drawing.Point(0, 0);
            this.pnlLogoWordmark.Name = "pnlLogoWordmark";
            this.pnlLogoWordmark.Size = new System.Drawing.Size(368, 40);
            this.pnlLogoWordmark.TabIndex = 0;
            // 
            // lblLogoSuffix
            // 
            this.lblLogoSuffix.AutoSize = true;
            this.lblLogoSuffix.Font = new System.Drawing.Font("Segoe UI Light", 19F);
            this.lblLogoSuffix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblLogoSuffix.Location = new System.Drawing.Point(183, 2);
            this.lblLogoSuffix.Name = "lblLogoSuffix";
            this.lblLogoSuffix.Size = new System.Drawing.Size(65, 36);
            this.lblLogoSuffix.TabIndex = 2;
            this.lblLogoSuffix.Text = "Med";
            this.lblLogoSuffix.Click += new System.EventHandler(this.lblLogoSuffix_Click_1);
            // 
            // lblLogoAccentDot
            // 
            this.lblLogoAccentDot.AutoSize = true;
            this.lblLogoAccentDot.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblLogoAccentDot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblLogoAccentDot.Location = new System.Drawing.Point(241, 2);
            this.lblLogoAccentDot.Name = "lblLogoAccentDot";
            this.lblLogoAccentDot.Size = new System.Drawing.Size(22, 36);
            this.lblLogoAccentDot.TabIndex = 1;
            this.lblLogoAccentDot.Text = ".";
            this.lblLogoAccentDot.Click += new System.EventHandler(this.lblLogoAccentDot_Click_1);
            // 
            // lblLogoPrefix
            // 
            this.lblLogoPrefix.AutoSize = true;
            this.lblLogoPrefix.Font = new System.Drawing.Font("Segoe UI Semibold", 19F, System.Drawing.FontStyle.Bold);
            this.lblLogoPrefix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblLogoPrefix.Location = new System.Drawing.Point(106, 2);
            this.lblLogoPrefix.Name = "lblLogoPrefix";
            this.lblLogoPrefix.Size = new System.Drawing.Size(86, 36);
            this.lblLogoPrefix.TabIndex = 0;
            this.lblLogoPrefix.Text = "Smart";
            this.lblLogoPrefix.Click += new System.EventHandler(this.lblLogoPrefix_Click);
            // 
            // toolTipHints
            // 
            this.toolTipHints.AutoPopDelay = 5000;
            this.toolTipHints.InitialDelay = 400;
            this.toolTipHints.ReshowDelay = 100;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.pnlBackdrop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(760, 640);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartMed Pharmacy Management System";
            this.pnlBackdrop.ResumeLayout(false);
            this.pnlCard.ResumeLayout(false);
            this.pnlCardInner.ResumeLayout(false);
            this.pnlCardInner.PerformLayout();
            this.pnlRegisterRow.ResumeLayout(false);
            this.pnlRegisterRow.PerformLayout();
            this.pnlLoading.ResumeLayout(false);
            this.pnlLoading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingSpinner)).EndInit();
            this.pnlOptionsRow.ResumeLayout(false);
            this.pnlOptionsRow.PerformLayout();
            this.pnlPasswordBox.ResumeLayout(false);
            this.pnlPasswordBox.PerformLayout();
            this.pnlUsernameBox.ResumeLayout(false);
            this.pnlUsernameBox.PerformLayout();
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
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel pnlUsernameBox;
        private System.Windows.Forms.Label lblUsernameIcon;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnlPasswordBox;
        private System.Windows.Forms.Label lblPasswordIcon;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlOptionsRow;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.LinkLabel lblForgotPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlLoading;
        private System.Windows.Forms.PictureBox pbLoadingSpinner;
        private System.Windows.Forms.Label lblLoadingText;
        private System.Windows.Forms.Panel pnlRegisterRow;
        private System.Windows.Forms.Label lblNoAccount;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblFooterTagline;
        private System.Windows.Forms.ToolTip toolTipHints;
    }
}