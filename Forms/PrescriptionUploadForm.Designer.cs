namespace SmartMed.Forms
{
    partial class PrescriptionUploadForm
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
            this.pnlUploadForm = new System.Windows.Forms.Panel();
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblOrder = new System.Windows.Forms.Label();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.lblPrescriptionFile = new System.Windows.Forms.Label();
            this.pnlFileSelector = new System.Windows.Forms.Panel();
            this.txtPrescriptionFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
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
            this.pnlUploadForm.SuspendLayout();
            this.tblLayout.SuspendLayout();
            this.pnlFileSelector.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlWelcome.SuspendLayout();
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
            this.pnlDashboard.Controls.Add(this.pnlUploadForm);
            this.pnlDashboard.Controls.Add(this.pnlWelcome);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 60);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Padding = new System.Windows.Forms.Padding(20);
            this.pnlDashboard.Size = new System.Drawing.Size(1062, 660);
            this.pnlDashboard.TabIndex = 1;
            // 
            // pnlUploadForm
            // 
            this.pnlUploadForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlUploadForm.Controls.Add(this.tblLayout);
            this.pnlUploadForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUploadForm.Location = new System.Drawing.Point(20, 90);
            this.pnlUploadForm.Name = "pnlUploadForm";
            this.pnlUploadForm.Padding = new System.Windows.Forms.Padding(15);
            this.pnlUploadForm.Size = new System.Drawing.Size(1022, 550);
            this.pnlUploadForm.TabIndex = 1;
            // 
            // tblLayout
            // 
            this.tblLayout.BackColor = System.Drawing.Color.Transparent;
            this.tblLayout.ColumnCount = 2;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.Controls.Add(this.lblOrder, 0, 0);
            this.tblLayout.Controls.Add(this.cmbOrder, 1, 0);
            this.tblLayout.Controls.Add(this.lblPrescriptionFile, 0, 1);
            this.tblLayout.Controls.Add(this.pnlFileSelector, 1, 1);
            this.tblLayout.Controls.Add(this.lblNotes, 0, 2);
            this.tblLayout.Controls.Add(this.txtNotes, 1, 2);
            this.tblLayout.Controls.Add(this.pnlButtons, 1, 4);
            this.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout.Location = new System.Drawing.Point(15, 15);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 5;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblLayout.Size = new System.Drawing.Size(992, 520);
            this.tblLayout.TabIndex = 0;
            // 
            // lblOrder
            // 
            this.lblOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblOrder.Location = new System.Drawing.Point(3, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(144, 40);
            this.lblOrder.TabIndex = 0;
            this.lblOrder.Text = "Order:";
            this.lblOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbOrder
            // 
            this.cmbOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOrder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbOrder.ForeColor = System.Drawing.Color.White;
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Location = new System.Drawing.Point(153, 3);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(836, 25);
            this.cmbOrder.TabIndex = 1;
            // 
            // lblPrescriptionFile
            // 
            this.lblPrescriptionFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrescriptionFile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPrescriptionFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblPrescriptionFile.Location = new System.Drawing.Point(3, 40);
            this.lblPrescriptionFile.Name = "lblPrescriptionFile";
            this.lblPrescriptionFile.Size = new System.Drawing.Size(144, 40);
            this.lblPrescriptionFile.TabIndex = 4;
            this.lblPrescriptionFile.Text = "Prescription File:";
            this.lblPrescriptionFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlFileSelector
            // 
            this.pnlFileSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlFileSelector.Controls.Add(this.txtPrescriptionFile);
            this.pnlFileSelector.Controls.Add(this.btnBrowse);
            this.pnlFileSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFileSelector.Location = new System.Drawing.Point(153, 43);
            this.pnlFileSelector.Name = "pnlFileSelector";
            this.pnlFileSelector.Size = new System.Drawing.Size(836, 34);
            this.pnlFileSelector.TabIndex = 5;
            // 
            // txtPrescriptionFile
            // 
            this.txtPrescriptionFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrescriptionFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtPrescriptionFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrescriptionFile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrescriptionFile.ForeColor = System.Drawing.Color.White;
            this.txtPrescriptionFile.Location = new System.Drawing.Point(10, 8);
            this.txtPrescriptionFile.Name = "txtPrescriptionFile";
            this.txtPrescriptionFile.ReadOnly = true;
            this.txtPrescriptionFile.Size = new System.Drawing.Size(726, 18);
            this.txtPrescriptionFile.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnBrowse.Location = new System.Drawing.Point(746, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(80, 30);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            // 
            // lblNotes
            // 
            this.lblNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblNotes.Location = new System.Drawing.Point(3, 80);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblNotes.Size = new System.Drawing.Size(144, 100);
            this.lblNotes.TabIndex = 6;
            this.lblNotes.Text = "Notes:";
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNotes.ForeColor = System.Drawing.Color.White;
            this.txtNotes.Location = new System.Drawing.Point(153, 83);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(836, 94);
            this.txtNotes.TabIndex = 7;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnRemove);
            this.pnlButtons.Controls.Add(this.btnSubmit);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(153, 473);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(836, 44);
            this.pnlButtons.TabIndex = 8;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnRemove.Location = new System.Drawing.Point(584, 8);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 32);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSubmit.Location = new System.Drawing.Point(700, 8);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 32);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlWelcome.Controls.Add(this.lblHeaderTitle);
            this.pnlWelcome.Controls.Add(this.lblHeaderSubtitle);
            this.pnlWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWelcome.Location = new System.Drawing.Point(20, 20);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Padding = new System.Windows.Forms.Padding(15);
            this.pnlWelcome.Size = new System.Drawing.Size(1022, 70);
            this.pnlWelcome.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(15, 15);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(191, 28);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Prescription Upload";
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(15, 45);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(492, 19);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Upload your prescription to complete orders containing prescription medicines.";
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
            this.pnlUserInfo.Controls.Add(this.lblUserName);
            this.pnlUserInfo.Controls.Add(this.picUserAvatar);
            this.pnlUserInfo.Controls.Add(this.btnLogoutIcon);
            this.pnlUserInfo.Location = new System.Drawing.Point(692, 0);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(370, 60);
            this.pnlUserInfo.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblUserName.Location = new System.Drawing.Point(249, 21);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(81, 24);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "John Doe";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picUserAvatar
            // 
            this.picUserAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.picUserAvatar.Location = new System.Drawing.Point(209, 14);
            this.picUserAvatar.Name = "picUserAvatar";
            this.picUserAvatar.Size = new System.Drawing.Size(32, 32);
            this.picUserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picUserAvatar.TabIndex = 1;
            this.picUserAvatar.TabStop = false;
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
            this.btnNavProfile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
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
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
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
            // PrescriptionUploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1302, 720);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "PrescriptionUploadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartMed Pharmacy - Prescription Upload";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMain.ResumeLayout(false);
            this.pnlContentArea.ResumeLayout(false);
            this.pnlDashboard.ResumeLayout(false);
            this.pnlUploadForm.ResumeLayout(false);
            this.tblLayout.ResumeLayout(false);
            this.tblLayout.PerformLayout();
            this.pnlFileSelector.ResumeLayout(false);
            this.pnlFileSelector.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
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
        private System.Windows.Forms.Panel pnlContentArea;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox picUserAvatar;
        private System.Windows.Forms.Label btnLogoutIcon;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Panel pnlUploadForm;
        private System.Windows.Forms.TableLayoutPanel tblLayout;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.Label lblPrescriptionFile;
        private System.Windows.Forms.Panel pnlFileSelector;
        private System.Windows.Forms.TextBox txtPrescriptionFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ToolTip toolTipHints;
    }
}