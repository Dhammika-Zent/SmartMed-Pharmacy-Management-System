namespace SmartMed.Forms
{
    partial class ProfileForm
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlContentArea = new System.Windows.Forms.Panel();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pnlProfileCard = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.tlpProfileFields = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFieldFullName = new System.Windows.Forms.Panel();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.pnlFieldUsername = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pnlFieldPhone = new System.Windows.Forms.Panel();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.pnlFieldPassword = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlFieldEmail = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pnlFieldAddress = new System.Windows.Forms.Panel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.pnlFieldConfirmPassword = new System.Windows.Forms.Panel();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.pnlProfileHeader = new System.Windows.Forms.Panel();
            this.lblProfileDescription = new System.Windows.Forms.Label();
            this.lblProfileTitle = new System.Windows.Forms.Label();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();       // user name label
            this.picUserAvatar = new System.Windows.Forms.PictureBox();
            this.btnLogoutIcon = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlSidebarLogo = new System.Windows.Forms.Panel();
            this.lblSidebarLogoSuffix = new System.Windows.Forms.Label();
            this.lblSidebarLogoAccent = new System.Windows.Forms.Label();
            this.lblSidebarLogoPrefix = new System.Windows.Forms.Label();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnNavLogout = new System.Windows.Forms.Button();
            this.btnNavProfile = new System.Windows.Forms.Button();
            this.btnNavOrders = new System.Windows.Forms.Button();
            this.btnNavCart = new System.Windows.Forms.Button();
            this.btnNavMedicines = new System.Windows.Forms.Button();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.toolTipHints = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlContentArea.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlProfileCard.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.tlpProfileFields.SuspendLayout();
            this.pnlFieldFullName.SuspendLayout();
            this.pnlFieldUsername.SuspendLayout();
            this.pnlFieldPhone.SuspendLayout();
            this.pnlFieldPassword.SuspendLayout();
            this.pnlFieldEmail.SuspendLayout();
            this.pnlFieldAddress.SuspendLayout();
            this.pnlFieldConfirmPassword.SuspendLayout();
            this.pnlProfileHeader.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.pnlSidebarLogo.SuspendLayout();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlMain.Controls.Add(this.pnlContentArea);
            this.pnlMain.Controls.Add(this.pnlSidebar);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1302, 720);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlContentArea
            // 
            this.pnlContentArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlContentArea.Controls.Add(this.pnlDashboard);
            this.pnlContentArea.Controls.Add(this.pnlTopBar);
            this.pnlContentArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentArea.Location = new System.Drawing.Point(240, 0);
            this.pnlContentArea.Name = "pnlContentArea";
            this.pnlContentArea.Size = new System.Drawing.Size(1062, 720);
            this.pnlContentArea.TabIndex = 1;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.AutoScroll = true;
            this.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlDashboard.Controls.Add(this.pnlProfileCard);
            this.pnlDashboard.Controls.Add(this.pnlProfileHeader);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 60);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Padding = new System.Windows.Forms.Padding(20);
            this.pnlDashboard.Size = new System.Drawing.Size(1062, 660);
            this.pnlDashboard.TabIndex = 1;
            // 
            // pnlProfileCard
            // 
            this.pnlProfileCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlProfileCard.Controls.Add(this.pnlButtons);
            this.pnlProfileCard.Controls.Add(this.tlpProfileFields);
            this.pnlProfileCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProfileCard.Location = new System.Drawing.Point(20, 100);
            this.pnlProfileCard.Name = "pnlProfileCard";
            this.pnlProfileCard.Padding = new System.Windows.Forms.Padding(20);
            this.pnlProfileCard.Size = new System.Drawing.Size(1022, 540);
            this.pnlProfileCard.TabIndex = 1;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnChangePassword);
            this.pnlButtons.Controls.Add(this.btnUpdateProfile);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(20, 490);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(982, 30);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnCancel.Location = new System.Drawing.Point(872, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 30);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnChangePassword.Location = new System.Drawing.Point(752, 0);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(110, 30);
            this.btnChangePassword.TabIndex = 7;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnUpdateProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnUpdateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnUpdateProfile.Location = new System.Drawing.Point(632, 0);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(110, 30);
            this.btnUpdateProfile.TabIndex = 6;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            // 
            // tlpProfileFields
            // 
            this.tlpProfileFields.BackColor = System.Drawing.Color.Transparent;
            this.tlpProfileFields.ColumnCount = 2;
            this.tlpProfileFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProfileFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProfileFields.Controls.Add(this.pnlFieldFullName, 0, 0);
            this.tlpProfileFields.Controls.Add(this.pnlFieldUsername, 0, 1);
            this.tlpProfileFields.Controls.Add(this.pnlFieldPhone, 0, 2);
            this.tlpProfileFields.Controls.Add(this.pnlFieldPassword, 0, 3);
            this.tlpProfileFields.Controls.Add(this.pnlFieldEmail, 1, 0);
            this.tlpProfileFields.Controls.Add(this.pnlFieldAddress, 1, 1);
            this.tlpProfileFields.Controls.Add(this.pnlFieldConfirmPassword, 1, 3);
            this.tlpProfileFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProfileFields.Location = new System.Drawing.Point(20, 20);
            this.tlpProfileFields.Name = "tlpProfileFields";
            this.tlpProfileFields.RowCount = 4;
            this.tlpProfileFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpProfileFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpProfileFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpProfileFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpProfileFields.Size = new System.Drawing.Size(982, 500);
            this.tlpProfileFields.TabIndex = 0;
            // 
            // pnlFieldFullName
            // 
            this.pnlFieldFullName.Controls.Add(this.lblFullName);
            this.pnlFieldFullName.Controls.Add(this.txtFullName);
            this.pnlFieldFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFieldFullName.Location = new System.Drawing.Point(3, 3);
            this.pnlFieldFullName.Name = "pnlFieldFullName";
            this.pnlFieldFullName.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlFieldFullName.Size = new System.Drawing.Size(485, 119);
            this.pnlFieldFullName.TabIndex = 0;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblFullName.Location = new System.Drawing.Point(0, 10);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(61, 15);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFullName.ForeColor = System.Drawing.Color.White;
            this.txtFullName.Location = new System.Drawing.Point(0, 30);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(472, 18);
            this.txtFullName.TabIndex = 1;
            // 
            // pnlFieldUsername
            // 
            this.pnlFieldUsername.Controls.Add(this.lblUsername);
            this.pnlFieldUsername.Controls.Add(this.txtUsername);
            this.pnlFieldUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFieldUsername.Location = new System.Drawing.Point(3, 128);
            this.pnlFieldUsername.Name = "pnlFieldUsername";
            this.pnlFieldUsername.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlFieldUsername.Size = new System.Drawing.Size(485, 119);
            this.pnlFieldUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblUsername.Location = new System.Drawing.Point(1, 10);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 15);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(0, 30);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(472, 18);
            this.txtUsername.TabIndex = 1;
            // 
            // pnlFieldPhone
            // 
            this.pnlFieldPhone.Controls.Add(this.lblPhone);
            this.pnlFieldPhone.Controls.Add(this.txtPhone);
            this.pnlFieldPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFieldPhone.Location = new System.Drawing.Point(3, 253);
            this.pnlFieldPhone.Name = "pnlFieldPhone";
            this.pnlFieldPhone.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlFieldPhone.Size = new System.Drawing.Size(485, 119);
            this.pnlFieldPhone.TabIndex = 2;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblPhone.Location = new System.Drawing.Point(0, 10);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 15);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(0, 30);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(472, 18);
            this.txtPhone.TabIndex = 1;
            // 
            // pnlFieldPassword
            // 
            this.pnlFieldPassword.Controls.Add(this.lblPassword);
            this.pnlFieldPassword.Controls.Add(this.txtPassword);
            this.pnlFieldPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFieldPassword.Location = new System.Drawing.Point(3, 378);
            this.pnlFieldPassword.Name = "pnlFieldPassword";
            this.pnlFieldPassword.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlFieldPassword.Size = new System.Drawing.Size(485, 119);
            this.pnlFieldPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblPassword.Location = new System.Drawing.Point(0, 10);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 15);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(0, 30);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(472, 18);
            this.txtPassword.TabIndex = 1;
            // 
            // pnlFieldEmail
            // 
            this.pnlFieldEmail.Controls.Add(this.lblEmail);
            this.pnlFieldEmail.Controls.Add(this.txtEmail);
            this.pnlFieldEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFieldEmail.Location = new System.Drawing.Point(494, 3);
            this.pnlFieldEmail.Name = "pnlFieldEmail";
            this.pnlFieldEmail.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlFieldEmail.Size = new System.Drawing.Size(485, 119);
            this.pnlFieldEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblEmail.Location = new System.Drawing.Point(10, 10);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(10, 30);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(462, 18);
            this.txtEmail.TabIndex = 1;
            // 
            // pnlFieldAddress
            // 
            this.pnlFieldAddress.Controls.Add(this.lblAddress);
            this.pnlFieldAddress.Controls.Add(this.txtAddress);
            this.pnlFieldAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFieldAddress.Location = new System.Drawing.Point(494, 128);
            this.pnlFieldAddress.Name = "pnlFieldAddress";
            this.pnlFieldAddress.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlFieldAddress.Size = new System.Drawing.Size(485, 119);
            this.pnlFieldAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblAddress.Location = new System.Drawing.Point(10, 10);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(49, 15);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddress.ForeColor = System.Drawing.Color.White;
            this.txtAddress.Location = new System.Drawing.Point(10, 30);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(462, 76);
            this.txtAddress.TabIndex = 1;
            // 
            // pnlFieldConfirmPassword
            // 
            this.pnlFieldConfirmPassword.Controls.Add(this.lblConfirmPassword);
            this.pnlFieldConfirmPassword.Controls.Add(this.txtConfirmPassword);
            this.pnlFieldConfirmPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFieldConfirmPassword.Location = new System.Drawing.Point(494, 378);
            this.pnlFieldConfirmPassword.Name = "pnlFieldConfirmPassword";
            this.pnlFieldConfirmPassword.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlFieldConfirmPassword.Size = new System.Drawing.Size(485, 119);
            this.pnlFieldConfirmPassword.TabIndex = 6;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblConfirmPassword.Location = new System.Drawing.Point(10, 10);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(104, 15);
            this.lblConfirmPassword.TabIndex = 0;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.txtConfirmPassword.Location = new System.Drawing.Point(10, 30);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.Size = new System.Drawing.Size(462, 18);
            this.txtConfirmPassword.TabIndex = 1;
            // 
            // pnlProfileHeader
            // 
            this.pnlProfileHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlProfileHeader.Controls.Add(this.lblProfileDescription);
            this.pnlProfileHeader.Controls.Add(this.lblProfileTitle);
            this.pnlProfileHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfileHeader.Location = new System.Drawing.Point(20, 20);
            this.pnlProfileHeader.Name = "pnlProfileHeader";
            this.pnlProfileHeader.Padding = new System.Windows.Forms.Padding(15);
            this.pnlProfileHeader.Size = new System.Drawing.Size(1022, 80);
            this.pnlProfileHeader.TabIndex = 0;
            // 
            // lblProfileDescription
            // 
            this.lblProfileDescription.AutoSize = true;
            this.lblProfileDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProfileDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblProfileDescription.Location = new System.Drawing.Point(15, 48);
            this.lblProfileDescription.Name = "lblProfileDescription";
            this.lblProfileDescription.Size = new System.Drawing.Size(336, 19);
            this.lblProfileDescription.TabIndex = 1;
            this.lblProfileDescription.Text = "View and manage your personal account information.";
            // 
            // lblProfileTitle
            // 
            this.lblProfileTitle.AutoSize = true;
            this.lblProfileTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblProfileTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblProfileTitle.Location = new System.Drawing.Point(15, 15);
            this.lblProfileTitle.Name = "lblProfileTitle";
            this.lblProfileTitle.Size = new System.Drawing.Size(79, 30);
            this.lblProfileTitle.TabIndex = 0;
            this.lblProfileTitle.Text = "Profile";
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlTopBar.Controls.Add(this.lblAppTitle);
            this.pnlTopBar.Controls.Add(this.pnlUserInfo);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1062, 60);
            this.pnlTopBar.TabIndex = 0;
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblAppTitle.Location = new System.Drawing.Point(25, 12);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(400, 36);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "SmartMed Pharmacy - Customer Portal";
            this.lblAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUserInfo.BackColor = System.Drawing.Color.Transparent;
            // ADD lblUserName BEFORE the other controls so it appears behind/left of avatar
            this.pnlUserInfo.Controls.Add(this.lblUserName);
            this.pnlUserInfo.Controls.Add(this.picUserAvatar);
            this.pnlUserInfo.Controls.Add(this.btnLogoutIcon);
            this.pnlUserInfo.Location = new System.Drawing.Point(692, 0);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(370, 60);
            this.pnlUserInfo.TabIndex = 1;
            // 
            // lblUserName (displays logged‑in customer's full name)
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(94, 18);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(109, 23);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User Name";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picUserAvatar
            // 
            this.picUserAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.picUserAvatar.Cursor = System.Windows.Forms.Cursors.Hand;          // << make it look clickable
            this.picUserAvatar.Location = new System.Drawing.Point(209, 14);
            this.picUserAvatar.Name = "picUserAvatar";
            this.picUserAvatar.Size = new System.Drawing.Size(32, 32);
            this.picUserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picUserAvatar.TabIndex = 1;
            this.picUserAvatar.TabStop = false;
            this.picUserAvatar.Click += new System.EventHandler(this.picUserAvatar_Click); // << wire click event
            // 
            // btnLogoutIcon
            // 
            this.btnLogoutIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoutIcon.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLogoutIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogoutIcon.Location = new System.Drawing.Point(330, 16);
            this.btnLogoutIcon.Name = "btnLogoutIcon";
            this.btnLogoutIcon.Size = new System.Drawing.Size(30, 28);
            this.btnLogoutIcon.TabIndex = 0;
            this.btnLogoutIcon.Text = "🚪";
            this.btnLogoutIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pnlSidebar.Controls.Add(this.pnlSidebarLogo);
            this.pnlSidebar.Controls.Add(this.pnlNav);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(240, 720);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pnlSidebarLogo
            // 
            this.pnlSidebarLogo.BackColor = System.Drawing.Color.Transparent;
            this.pnlSidebarLogo.Controls.Add(this.lblSidebarLogoSuffix);
            this.pnlSidebarLogo.Controls.Add(this.lblSidebarLogoAccent);
            this.pnlSidebarLogo.Controls.Add(this.lblSidebarLogoPrefix);
            this.pnlSidebarLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSidebarLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebarLogo.Name = "pnlSidebarLogo";
            this.pnlSidebarLogo.Size = new System.Drawing.Size(240, 70);
            this.pnlSidebarLogo.TabIndex = 0;
            // 
            // lblSidebarLogoSuffix
            // 
            this.lblSidebarLogoSuffix.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.lblSidebarLogoSuffix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblSidebarLogoSuffix.Location = new System.Drawing.Point(117, 20);
            this.lblSidebarLogoSuffix.Name = "lblSidebarLogoSuffix";
            this.lblSidebarLogoSuffix.Size = new System.Drawing.Size(60, 30);
            this.lblSidebarLogoSuffix.TabIndex = 2;
            this.lblSidebarLogoSuffix.Text = "Med";
            this.lblSidebarLogoSuffix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSidebarLogoAccent
            // 
            this.lblSidebarLogoAccent.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblSidebarLogoAccent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblSidebarLogoAccent.Location = new System.Drawing.Point(172, 20);
            this.lblSidebarLogoAccent.Name = "lblSidebarLogoAccent";
            this.lblSidebarLogoAccent.Size = new System.Drawing.Size(20, 30);
            this.lblSidebarLogoAccent.TabIndex = 1;
            this.lblSidebarLogoAccent.Text = ".";
            this.lblSidebarLogoAccent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSidebarLogoPrefix
            // 
            this.lblSidebarLogoPrefix.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblSidebarLogoPrefix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblSidebarLogoPrefix.Location = new System.Drawing.Point(25, 20);
            this.lblSidebarLogoPrefix.Name = "lblSidebarLogoPrefix";
            this.lblSidebarLogoPrefix.Size = new System.Drawing.Size(100, 30);
            this.lblSidebarLogoPrefix.TabIndex = 0;
            this.lblSidebarLogoPrefix.Text = "Smart";
            this.lblSidebarLogoPrefix.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.Transparent;
            this.pnlNav.Controls.Add(this.btnNavLogout);
            this.pnlNav.Controls.Add(this.btnNavProfile);
            this.pnlNav.Controls.Add(this.btnNavOrders);
            this.pnlNav.Controls.Add(this.btnNavCart);
            this.pnlNav.Controls.Add(this.btnNavMedicines);
            this.pnlNav.Controls.Add(this.btnNavDashboard);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.pnlNav.Size = new System.Drawing.Size(240, 720);
            this.pnlNav.TabIndex = 1;
            // 
            // btnNavLogout
            // 
            this.btnNavLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavLogout.FlatAppearance.BorderSize = 0;
            this.btnNavLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnNavLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnNavLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavLogout.Location = new System.Drawing.Point(14, 664);
            this.btnNavLogout.Name = "btnNavLogout";
            this.btnNavLogout.Size = new System.Drawing.Size(240, 44);
            this.btnNavLogout.TabIndex = 5;
            this.btnNavLogout.Text = "🚪  Logout";
            this.btnNavLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavLogout.UseVisualStyleBackColor = true;
            // 
            // btnNavProfile
            // 
            this.btnNavProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavProfile.FlatAppearance.BorderSize = 0;
            this.btnNavProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnNavProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnNavProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavProfile.Location = new System.Drawing.Point(10, 232);
            this.btnNavProfile.Name = "btnNavProfile";
            this.btnNavProfile.Size = new System.Drawing.Size(240, 44);
            this.btnNavProfile.TabIndex = 4;
            this.btnNavProfile.Text = "👤  Profile";
            this.btnNavProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavProfile.UseVisualStyleBackColor = true;
            // 
            // btnNavOrders
            // 
            this.btnNavOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavOrders.FlatAppearance.BorderSize = 0;
            this.btnNavOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnNavOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavOrders.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNavOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavOrders.Location = new System.Drawing.Point(10, 184);
            this.btnNavOrders.Name = "btnNavOrders";
            this.btnNavOrders.Size = new System.Drawing.Size(240, 44);
            this.btnNavOrders.TabIndex = 3;
            this.btnNavOrders.Text = "📦  Orders";
            this.btnNavOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavOrders.UseVisualStyleBackColor = true;
            // 
            // btnNavCart
            // 
            this.btnNavCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavCart.FlatAppearance.BorderSize = 0;
            this.btnNavCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnNavCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCart.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNavCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavCart.Location = new System.Drawing.Point(10, 136);
            this.btnNavCart.Name = "btnNavCart";
            this.btnNavCart.Size = new System.Drawing.Size(240, 44);
            this.btnNavCart.TabIndex = 2;
            this.btnNavCart.Text = "🛒  Cart";
            this.btnNavCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavCart.UseVisualStyleBackColor = true;
            // 
            // btnNavMedicines
            // 
            this.btnNavMedicines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavMedicines.FlatAppearance.BorderSize = 0;
            this.btnNavMedicines.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnNavMedicines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMedicines.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavMedicines.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNavMedicines.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavMedicines.Location = new System.Drawing.Point(10, 88);
            this.btnNavMedicines.Name = "btnNavMedicines";
            this.btnNavMedicines.Size = new System.Drawing.Size(240, 44);
            this.btnNavMedicines.TabIndex = 1;
            this.btnNavMedicines.Text = "💊  Medicines";
            this.btnNavMedicines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavMedicines.UseVisualStyleBackColor = true;
            // 
            // btnNavDashboard
            // 
            this.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNavDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.Location = new System.Drawing.Point(0, 40);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Size = new System.Drawing.Size(240, 44);
            this.btnNavDashboard.TabIndex = 0;
            this.btnNavDashboard.Text = "📋  Dashboard";
            this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.UseVisualStyleBackColor = true;
            // 
            // toolTipHints
            // 
            this.toolTipHints.AutoPopDelay = 5000;
            this.toolTipHints.InitialDelay = 400;
            this.toolTipHints.ReshowDelay = 100;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1302, 720);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartMed Pharmacy - Profile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMain.ResumeLayout(false);
            this.pnlContentArea.ResumeLayout(false);
            this.pnlDashboard.ResumeLayout(false);
            this.pnlProfileCard.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.tlpProfileFields.ResumeLayout(false);
            this.pnlFieldFullName.ResumeLayout(false);
            this.pnlFieldFullName.PerformLayout();
            this.pnlFieldUsername.ResumeLayout(false);
            this.pnlFieldUsername.PerformLayout();
            this.pnlFieldPhone.ResumeLayout(false);
            this.pnlFieldPhone.PerformLayout();
            this.pnlFieldPassword.ResumeLayout(false);
            this.pnlFieldPassword.PerformLayout();
            this.pnlFieldEmail.ResumeLayout(false);
            this.pnlFieldEmail.PerformLayout();
            this.pnlFieldAddress.ResumeLayout(false);
            this.pnlFieldAddress.PerformLayout();
            this.pnlFieldConfirmPassword.ResumeLayout(false);
            this.pnlFieldConfirmPassword.PerformLayout();
            this.pnlProfileHeader.ResumeLayout(false);
            this.pnlProfileHeader.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlUserInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebarLogo.ResumeLayout(false);
            this.pnlNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlContentArea;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.Label lblUserName;          // user name label
        private System.Windows.Forms.PictureBox picUserAvatar;
        private System.Windows.Forms.Label btnLogoutIcon;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlSidebarLogo;
        private System.Windows.Forms.Label lblSidebarLogoSuffix;
        private System.Windows.Forms.Label lblSidebarLogoAccent;
        private System.Windows.Forms.Label lblSidebarLogoPrefix;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavMedicines;
        private System.Windows.Forms.Button btnNavCart;
        private System.Windows.Forms.Button btnNavOrders;
        private System.Windows.Forms.Button btnNavProfile;
        private System.Windows.Forms.Button btnNavLogout;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Panel pnlProfileHeader;
        private System.Windows.Forms.Label lblProfileDescription;
        private System.Windows.Forms.Label lblProfileTitle;
        private System.Windows.Forms.Panel pnlProfileCard;
        private System.Windows.Forms.TableLayoutPanel tlpProfileFields;
        private System.Windows.Forms.Panel pnlFieldFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Panel pnlFieldUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel pnlFieldPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Panel pnlFieldPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlFieldEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel pnlFieldAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Panel pnlFieldConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.ToolTip toolTipHints;
    }
}