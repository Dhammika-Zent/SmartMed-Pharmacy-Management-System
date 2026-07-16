namespace SmartMed.Forms
{
    partial class MedicineManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlContentArea = new System.Windows.Forms.Panel();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pnlDashboardContent = new System.Windows.Forms.Panel();
            this.pnlPageHeaderContainer = new System.Windows.Forms.Panel();
            this.pnlPageHeaderCard = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageDescription = new System.Windows.Forms.Label();
            this.lblBreadcrumb = new System.Windows.Forms.Label();
            this.pnlSummaryContainer = new System.Windows.Forms.Panel();
            this.pnlSummaryCard = new System.Windows.Forms.Panel();
            this.flpSummaryCards = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSumTotalMeds = new System.Windows.Forms.Panel();
            this.lblTotalMedsValue = new System.Windows.Forms.Label();
            this.lblTotalMedsTitle = new System.Windows.Forms.Label();
            this.pnlSumAvailableMeds = new System.Windows.Forms.Panel();
            this.lblAvailableMedsValue = new System.Windows.Forms.Label();
            this.lblAvailableMedsTitle = new System.Windows.Forms.Label();
            this.pnlSumLowStock = new System.Windows.Forms.Panel();
            this.lblLowStockValue = new System.Windows.Forms.Label();
            this.lblLowStockTitle = new System.Windows.Forms.Label();
            this.pnlSumExpiredMeds = new System.Windows.Forms.Panel();
            this.lblExpiredMedsValue = new System.Windows.Forms.Label();
            this.lblExpiredMedsTitle = new System.Windows.Forms.Label();
            this.pnlSumPrescriptionMeds = new System.Windows.Forms.Panel();
            this.lblPrescriptionMedsValue = new System.Windows.Forms.Label();
            this.lblPrescriptionMedsTitle = new System.Windows.Forms.Label();
            this.pnlSearchFiltersContainer = new System.Windows.Forms.Panel();
            this.pnlSearchFiltersCard = new System.Windows.Forms.Panel();
            this.tblSearchFilters = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.lblSearchCategory = new System.Windows.Forms.Label();
            this.cmbSearchCategory = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlFilterChecks = new System.Windows.Forms.FlowLayoutPanel();
            this.chkLowStock = new System.Windows.Forms.CheckBox();
            this.chkExpired = new System.Windows.Forms.CheckBox();
            this.chkPrescriptionFilter = new System.Windows.Forms.CheckBox();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.cmbSortBy = new System.Windows.Forms.ComboBox();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.btnRefreshResults = new System.Windows.Forms.Button();
            this.pnlMedicineGridContainer = new System.Windows.Forms.Panel();
            this.pnlMedicineGridCard = new System.Windows.Forms.Panel();
            this.dgvMedicines = new System.Windows.Forms.DataGridView();
            this.colMedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedDosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedPrescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMedicineDetailsContainer = new System.Windows.Forms.Panel();
            this.pnlMedicineDetailsCard = new System.Windows.Forms.Panel();
            this.tblMedicineDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lblMedicineID = new System.Windows.Forms.Label();
            this.txtMedicineID = new System.Windows.Forms.TextBox();
            this.lblMedicineName = new System.Windows.Forms.Label();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblDosage = new System.Windows.Forms.Label();
            this.cmbDosage = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.lblStockQuantity = new System.Windows.Forms.Label();
            this.numStockQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.chkPrescription = new System.Windows.Forms.CheckBox();
            this.pnlActionButtonsContainer = new System.Windows.Forms.Panel();
            this.pnlActionButtonsCard = new System.Windows.Forms.Panel();
            this.flpActionButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.btnUpdateMedicine = new System.Windows.Forms.Button();
            this.btnDeleteMedicine = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
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
            this.btnNavReports = new System.Windows.Forms.Button();
            this.btnNavOrders = new System.Windows.Forms.Button();
            this.btnNavCustomers = new System.Windows.Forms.Button();
            this.btnNavMedicines = new System.Windows.Forms.Button();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.toolTipHints = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlContentArea.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlDashboardContent.SuspendLayout();
            this.pnlPageHeaderContainer.SuspendLayout();
            this.pnlPageHeaderCard.SuspendLayout();
            this.pnlSummaryContainer.SuspendLayout();
            this.pnlSummaryCard.SuspendLayout();
            this.flpSummaryCards.SuspendLayout();
            this.pnlSumTotalMeds.SuspendLayout();
            this.pnlSumAvailableMeds.SuspendLayout();
            this.pnlSumLowStock.SuspendLayout();
            this.pnlSumExpiredMeds.SuspendLayout();
            this.pnlSumPrescriptionMeds.SuspendLayout();
            this.pnlSearchFiltersContainer.SuspendLayout();
            this.pnlSearchFiltersCard.SuspendLayout();
            this.tblSearchFilters.SuspendLayout();
            this.pnlFilterChecks.SuspendLayout();
            this.pnlMedicineGridContainer.SuspendLayout();
            this.pnlMedicineGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).BeginInit();
            this.pnlMedicineDetailsContainer.SuspendLayout();
            this.pnlMedicineDetailsCard.SuspendLayout();
            this.tblMedicineDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            this.pnlActionButtonsContainer.SuspendLayout();
            this.pnlActionButtonsCard.SuspendLayout();
            this.flpActionButtons.SuspendLayout();
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
            this.pnlMain.Size = new System.Drawing.Size(1302, 749);
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
            this.pnlContentArea.Size = new System.Drawing.Size(1062, 749);
            this.pnlContentArea.TabIndex = 1;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.AutoScroll = true;
            this.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlDashboard.Controls.Add(this.pnlDashboardContent);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 60);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1062, 689);
            this.pnlDashboard.TabIndex = 1;
            // 
            // pnlDashboardContent
            // 
            this.pnlDashboardContent.AutoSize = true;
            this.pnlDashboardContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDashboardContent.BackColor = System.Drawing.Color.Transparent;
            this.pnlDashboardContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDashboardContent.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboardContent.Name = "pnlDashboardContent";
            this.pnlDashboardContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlDashboardContent.Size = new System.Drawing.Size(1045, 1144);
            this.pnlDashboardContent.TabIndex = 0;
            // 
            // pnlPageHeaderContainer
            // 
            this.pnlPageHeaderContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlPageHeaderContainer.Controls.Add(this.pnlPageHeaderCard);
            this.pnlPageHeaderContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPageHeaderContainer.Location = new System.Drawing.Point(20, 20);
            this.pnlPageHeaderContainer.Name = "pnlPageHeaderContainer";
            this.pnlPageHeaderContainer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlPageHeaderContainer.Size = new System.Drawing.Size(1005, 131);
            this.pnlPageHeaderContainer.TabIndex = 0;
            // 
            // pnlPageHeaderCard
            // 
            this.pnlPageHeaderCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlPageHeaderCard.Controls.Add(this.lblPageTitle);
            this.pnlPageHeaderCard.Controls.Add(this.lblPageDescription);
            this.pnlPageHeaderCard.Controls.Add(this.lblBreadcrumb);
            this.pnlPageHeaderCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPageHeaderCard.Location = new System.Drawing.Point(0, 0);
            this.pnlPageHeaderCard.Name = "pnlPageHeaderCard";
            this.pnlPageHeaderCard.Padding = new System.Windows.Forms.Padding(15);
            this.pnlPageHeaderCard.Size = new System.Drawing.Size(1005, 121);
            this.pnlPageHeaderCard.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblPageTitle.Location = new System.Drawing.Point(15, 15);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(975, 37);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Medicine Management";
            this.lblPageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPageDescription
            // 
            this.lblPageDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPageDescription.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPageDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblPageDescription.Location = new System.Drawing.Point(15, 15);
            this.lblPageDescription.Name = "lblPageDescription";
            this.lblPageDescription.Size = new System.Drawing.Size(975, 91);
            this.lblPageDescription.TabIndex = 1;
            this.lblPageDescription.Text = "Manage pharmacy medicines, stock levels, suppliers and expiry dates.";
            this.lblPageDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPageDescription.Click += new System.EventHandler(this.lblPageDescription_Click);
            // 
            // lblBreadcrumb
            // 
            this.lblBreadcrumb.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBreadcrumb.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblBreadcrumb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.lblBreadcrumb.Location = new System.Drawing.Point(15, 15);
            this.lblBreadcrumb.Name = "lblBreadcrumb";
            this.lblBreadcrumb.Size = new System.Drawing.Size(975, 0);
            this.lblBreadcrumb.TabIndex = 2;
            this.lblBreadcrumb.Text = "Dashboard > Medicine Management";
            this.lblBreadcrumb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBreadcrumb.Visible = false;
            // 
            // pnlSummaryContainer
            // 
            this.pnlSummaryContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlSummaryContainer.Controls.Add(this.pnlSummaryCard);
            this.pnlSummaryContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSummaryContainer.Location = new System.Drawing.Point(20, 151);
            this.pnlSummaryContainer.Name = "pnlSummaryContainer";
            this.pnlSummaryContainer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.pnlSummaryContainer.Size = new System.Drawing.Size(1005, 150);
            this.pnlSummaryContainer.TabIndex = 1;
            // 
            // pnlSummaryCard
            // 
            this.pnlSummaryCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlSummaryCard.Controls.Add(this.flpSummaryCards);
            this.pnlSummaryCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSummaryCard.Location = new System.Drawing.Point(0, 0);
            this.pnlSummaryCard.Name = "pnlSummaryCard";
            this.pnlSummaryCard.Padding = new System.Windows.Forms.Padding(10);
            this.pnlSummaryCard.Size = new System.Drawing.Size(1005, 130);
            this.pnlSummaryCard.TabIndex = 0;
            // 
            // flpSummaryCards
            // 
            this.flpSummaryCards.BackColor = System.Drawing.Color.Transparent;
            this.flpSummaryCards.Controls.Add(this.pnlSumTotalMeds);
            this.flpSummaryCards.Controls.Add(this.pnlSumAvailableMeds);
            this.flpSummaryCards.Controls.Add(this.pnlSumLowStock);
            this.flpSummaryCards.Controls.Add(this.pnlSumExpiredMeds);
            this.flpSummaryCards.Controls.Add(this.pnlSumPrescriptionMeds);
            this.flpSummaryCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSummaryCards.Location = new System.Drawing.Point(10, 10);
            this.flpSummaryCards.Name = "flpSummaryCards";
            this.flpSummaryCards.Size = new System.Drawing.Size(985, 110);
            this.flpSummaryCards.TabIndex = 0;
            this.flpSummaryCards.WrapContents = false;
            // 
            // pnlSumTotalMeds
            // 
            this.pnlSumTotalMeds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlSumTotalMeds.Controls.Add(this.lblTotalMedsValue);
            this.pnlSumTotalMeds.Controls.Add(this.lblTotalMedsTitle);
            this.pnlSumTotalMeds.Location = new System.Drawing.Point(3, 3);
            this.pnlSumTotalMeds.Name = "pnlSumTotalMeds";
            this.pnlSumTotalMeds.Padding = new System.Windows.Forms.Padding(10);
            this.pnlSumTotalMeds.Size = new System.Drawing.Size(160, 100);
            this.pnlSumTotalMeds.TabIndex = 0;
            // 
            // lblTotalMedsValue
            // 
            this.lblTotalMedsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalMedsValue.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalMedsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblTotalMedsValue.Location = new System.Drawing.Point(10, 10);
            this.lblTotalMedsValue.Name = "lblTotalMedsValue";
            this.lblTotalMedsValue.Size = new System.Drawing.Size(140, 55);
            this.lblTotalMedsValue.TabIndex = 0;
            this.lblTotalMedsValue.Text = "0";
            this.lblTotalMedsValue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblTotalMedsTitle
            // 
            this.lblTotalMedsTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalMedsTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalMedsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblTotalMedsTitle.Location = new System.Drawing.Point(10, 65);
            this.lblTotalMedsTitle.Name = "lblTotalMedsTitle";
            this.lblTotalMedsTitle.Size = new System.Drawing.Size(140, 25);
            this.lblTotalMedsTitle.TabIndex = 1;
            this.lblTotalMedsTitle.Text = "Total Medicines";
            this.lblTotalMedsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSumAvailableMeds
            // 
            this.pnlSumAvailableMeds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlSumAvailableMeds.Controls.Add(this.lblAvailableMedsValue);
            this.pnlSumAvailableMeds.Controls.Add(this.lblAvailableMedsTitle);
            this.pnlSumAvailableMeds.Location = new System.Drawing.Point(169, 3);
            this.pnlSumAvailableMeds.Name = "pnlSumAvailableMeds";
            this.pnlSumAvailableMeds.Padding = new System.Windows.Forms.Padding(10);
            this.pnlSumAvailableMeds.Size = new System.Drawing.Size(160, 100);
            this.pnlSumAvailableMeds.TabIndex = 1;
            // 
            // lblAvailableMedsValue
            // 
            this.lblAvailableMedsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailableMedsValue.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblAvailableMedsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblAvailableMedsValue.Location = new System.Drawing.Point(10, 10);
            this.lblAvailableMedsValue.Name = "lblAvailableMedsValue";
            this.lblAvailableMedsValue.Size = new System.Drawing.Size(140, 55);
            this.lblAvailableMedsValue.TabIndex = 0;
            this.lblAvailableMedsValue.Text = "0";
            this.lblAvailableMedsValue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblAvailableMedsTitle
            // 
            this.lblAvailableMedsTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAvailableMedsTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAvailableMedsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblAvailableMedsTitle.Location = new System.Drawing.Point(10, 65);
            this.lblAvailableMedsTitle.Name = "lblAvailableMedsTitle";
            this.lblAvailableMedsTitle.Size = new System.Drawing.Size(140, 25);
            this.lblAvailableMedsTitle.TabIndex = 1;
            this.lblAvailableMedsTitle.Text = "Available";
            this.lblAvailableMedsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSumLowStock
            // 
            this.pnlSumLowStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlSumLowStock.Controls.Add(this.lblLowStockValue);
            this.pnlSumLowStock.Controls.Add(this.lblLowStockTitle);
            this.pnlSumLowStock.Location = new System.Drawing.Point(335, 3);
            this.pnlSumLowStock.Name = "pnlSumLowStock";
            this.pnlSumLowStock.Padding = new System.Windows.Forms.Padding(10);
            this.pnlSumLowStock.Size = new System.Drawing.Size(160, 100);
            this.pnlSumLowStock.TabIndex = 2;
            // 
            // lblLowStockValue
            // 
            this.lblLowStockValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLowStockValue.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblLowStockValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblLowStockValue.Location = new System.Drawing.Point(10, 10);
            this.lblLowStockValue.Name = "lblLowStockValue";
            this.lblLowStockValue.Size = new System.Drawing.Size(140, 55);
            this.lblLowStockValue.TabIndex = 0;
            this.lblLowStockValue.Text = "0";
            this.lblLowStockValue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblLowStockTitle
            // 
            this.lblLowStockTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLowStockTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLowStockTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblLowStockTitle.Location = new System.Drawing.Point(10, 65);
            this.lblLowStockTitle.Name = "lblLowStockTitle";
            this.lblLowStockTitle.Size = new System.Drawing.Size(140, 25);
            this.lblLowStockTitle.TabIndex = 1;
            this.lblLowStockTitle.Text = "Low Stock";
            this.lblLowStockTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSumExpiredMeds
            // 
            this.pnlSumExpiredMeds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlSumExpiredMeds.Controls.Add(this.lblExpiredMedsValue);
            this.pnlSumExpiredMeds.Controls.Add(this.lblExpiredMedsTitle);
            this.pnlSumExpiredMeds.Location = new System.Drawing.Point(501, 3);
            this.pnlSumExpiredMeds.Name = "pnlSumExpiredMeds";
            this.pnlSumExpiredMeds.Padding = new System.Windows.Forms.Padding(10);
            this.pnlSumExpiredMeds.Size = new System.Drawing.Size(160, 100);
            this.pnlSumExpiredMeds.TabIndex = 3;
            // 
            // lblExpiredMedsValue
            // 
            this.lblExpiredMedsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExpiredMedsValue.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblExpiredMedsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblExpiredMedsValue.Location = new System.Drawing.Point(10, 10);
            this.lblExpiredMedsValue.Name = "lblExpiredMedsValue";
            this.lblExpiredMedsValue.Size = new System.Drawing.Size(140, 55);
            this.lblExpiredMedsValue.TabIndex = 0;
            this.lblExpiredMedsValue.Text = "0";
            this.lblExpiredMedsValue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblExpiredMedsTitle
            // 
            this.lblExpiredMedsTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblExpiredMedsTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblExpiredMedsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblExpiredMedsTitle.Location = new System.Drawing.Point(10, 65);
            this.lblExpiredMedsTitle.Name = "lblExpiredMedsTitle";
            this.lblExpiredMedsTitle.Size = new System.Drawing.Size(140, 25);
            this.lblExpiredMedsTitle.TabIndex = 1;
            this.lblExpiredMedsTitle.Text = "Expired";
            this.lblExpiredMedsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSumPrescriptionMeds
            // 
            this.pnlSumPrescriptionMeds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlSumPrescriptionMeds.Controls.Add(this.lblPrescriptionMedsValue);
            this.pnlSumPrescriptionMeds.Controls.Add(this.lblPrescriptionMedsTitle);
            this.pnlSumPrescriptionMeds.Location = new System.Drawing.Point(667, 3);
            this.pnlSumPrescriptionMeds.Name = "pnlSumPrescriptionMeds";
            this.pnlSumPrescriptionMeds.Padding = new System.Windows.Forms.Padding(10);
            this.pnlSumPrescriptionMeds.Size = new System.Drawing.Size(160, 100);
            this.pnlSumPrescriptionMeds.TabIndex = 4;
            // 
            // lblPrescriptionMedsValue
            // 
            this.lblPrescriptionMedsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrescriptionMedsValue.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblPrescriptionMedsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblPrescriptionMedsValue.Location = new System.Drawing.Point(10, 10);
            this.lblPrescriptionMedsValue.Name = "lblPrescriptionMedsValue";
            this.lblPrescriptionMedsValue.Size = new System.Drawing.Size(140, 55);
            this.lblPrescriptionMedsValue.TabIndex = 0;
            this.lblPrescriptionMedsValue.Text = "0";
            this.lblPrescriptionMedsValue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblPrescriptionMedsTitle
            // 
            this.lblPrescriptionMedsTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPrescriptionMedsTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPrescriptionMedsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblPrescriptionMedsTitle.Location = new System.Drawing.Point(10, 65);
            this.lblPrescriptionMedsTitle.Name = "lblPrescriptionMedsTitle";
            this.lblPrescriptionMedsTitle.Size = new System.Drawing.Size(140, 25);
            this.lblPrescriptionMedsTitle.TabIndex = 1;
            this.lblPrescriptionMedsTitle.Text = "Prescription";
            this.lblPrescriptionMedsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSearchFiltersContainer
            // 
            this.pnlSearchFiltersContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearchFiltersContainer.Controls.Add(this.pnlSearchFiltersCard);
            this.pnlSearchFiltersContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchFiltersContainer.Location = new System.Drawing.Point(20, 301);
            this.pnlSearchFiltersContainer.Name = "pnlSearchFiltersContainer";
            this.pnlSearchFiltersContainer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlSearchFiltersContainer.Size = new System.Drawing.Size(1005, 155);
            this.pnlSearchFiltersContainer.TabIndex = 2;
            // 
            // pnlSearchFiltersCard
            // 
            this.pnlSearchFiltersCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlSearchFiltersCard.Controls.Add(this.tblSearchFilters);
            this.pnlSearchFiltersCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearchFiltersCard.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchFiltersCard.Name = "pnlSearchFiltersCard";
            this.pnlSearchFiltersCard.Padding = new System.Windows.Forms.Padding(15);
            this.pnlSearchFiltersCard.Size = new System.Drawing.Size(1005, 145);
            this.pnlSearchFiltersCard.TabIndex = 0;
            // 
            // tblSearchFilters
            // 
            this.tblSearchFilters.BackColor = System.Drawing.Color.Transparent;
            this.tblSearchFilters.ColumnCount = 4;
            this.tblSearchFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSearchFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSearchFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSearchFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblSearchFilters.Controls.Add(this.lblSearchName, 0, 0);
            this.tblSearchFilters.Controls.Add(this.txtSearchName, 0, 1);
            this.tblSearchFilters.Controls.Add(this.lblSearchCategory, 1, 0);
            this.tblSearchFilters.Controls.Add(this.cmbSearchCategory, 1, 1);
            this.tblSearchFilters.Controls.Add(this.btnSearch, 2, 1);
            this.tblSearchFilters.Controls.Add(this.pnlFilterChecks, 0, 2);
            this.tblSearchFilters.Controls.Add(this.lblSortBy, 2, 2);
            this.tblSearchFilters.Controls.Add(this.cmbSortBy, 2, 3);
            this.tblSearchFilters.Controls.Add(this.btnResetFilters, 3, 1);
            this.tblSearchFilters.Controls.Add(this.btnRefreshResults, 3, 3);
            this.tblSearchFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSearchFilters.Location = new System.Drawing.Point(15, 15);
            this.tblSearchFilters.Name = "tblSearchFilters";
            this.tblSearchFilters.RowCount = 4;
            this.tblSearchFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblSearchFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblSearchFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblSearchFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblSearchFilters.Size = new System.Drawing.Size(975, 115);
            this.tblSearchFilters.TabIndex = 0;
            // 
            // lblSearchName
            // 
            this.lblSearchName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearchName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblSearchName.Location = new System.Drawing.Point(3, 0);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(150, 22);
            this.lblSearchName.TabIndex = 0;
            this.lblSearchName.Text = "Search by Name";
            this.lblSearchName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearchName
            // 
            this.txtSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtSearchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtSearchName.Location = new System.Drawing.Point(3, 25);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(230, 23);
            this.txtSearchName.TabIndex = 1;
            // 
            // lblSearchCategory
            // 
            this.lblSearchCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearchCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblSearchCategory.Location = new System.Drawing.Point(246, 0);
            this.lblSearchCategory.Name = "lblSearchCategory";
            this.lblSearchCategory.Size = new System.Drawing.Size(150, 22);
            this.lblSearchCategory.TabIndex = 2;
            this.lblSearchCategory.Text = "Category";
            this.lblSearchCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSearchCategory
            // 
            this.cmbSearchCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbSearchCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSearchCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbSearchCategory.FormattingEnabled = true;
            this.cmbSearchCategory.Location = new System.Drawing.Point(246, 25);
            this.cmbSearchCategory.Name = "cmbSearchCategory";
            this.cmbSearchCategory.Size = new System.Drawing.Size(230, 23);
            this.cmbSearchCategory.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(489, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 26);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // pnlFilterChecks
            // 
            this.pnlFilterChecks.BackColor = System.Drawing.Color.Transparent;
            this.tblSearchFilters.SetColumnSpan(this.pnlFilterChecks, 2);
            this.pnlFilterChecks.Controls.Add(this.chkLowStock);
            this.pnlFilterChecks.Controls.Add(this.chkExpired);
            this.pnlFilterChecks.Controls.Add(this.chkPrescriptionFilter);
            this.pnlFilterChecks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilterChecks.Location = new System.Drawing.Point(3, 57);
            this.pnlFilterChecks.Name = "pnlFilterChecks";
            this.pnlFilterChecks.Size = new System.Drawing.Size(480, 16);
            this.pnlFilterChecks.TabIndex = 5;
            this.pnlFilterChecks.WrapContents = false;
            // 
            // chkLowStock
            // 
            this.chkLowStock.AutoSize = true;
            this.chkLowStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkLowStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.chkLowStock.Location = new System.Drawing.Point(3, 3);
            this.chkLowStock.Name = "chkLowStock";
            this.chkLowStock.Size = new System.Drawing.Size(80, 19);
            this.chkLowStock.TabIndex = 0;
            this.chkLowStock.Text = "Low Stock";
            this.chkLowStock.UseVisualStyleBackColor = true;
            // 
            // chkExpired
            // 
            this.chkExpired.AutoSize = true;
            this.chkExpired.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkExpired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.chkExpired.Location = new System.Drawing.Point(89, 3);
            this.chkExpired.Name = "chkExpired";
            this.chkExpired.Size = new System.Drawing.Size(97, 19);
            this.chkExpired.TabIndex = 1;
            this.chkExpired.Text = "Expired Meds";
            this.chkExpired.UseVisualStyleBackColor = true;
            // 
            // chkPrescriptionFilter
            // 
            this.chkPrescriptionFilter.AutoSize = true;
            this.chkPrescriptionFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkPrescriptionFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.chkPrescriptionFilter.Location = new System.Drawing.Point(192, 3);
            this.chkPrescriptionFilter.Name = "chkPrescriptionFilter";
            this.chkPrescriptionFilter.Size = new System.Drawing.Size(121, 19);
            this.chkPrescriptionFilter.TabIndex = 2;
            this.chkPrescriptionFilter.Text = "Prescription Meds";
            this.chkPrescriptionFilter.UseVisualStyleBackColor = true;
            // 
            // lblSortBy
            // 
            this.lblSortBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSortBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblSortBy.Location = new System.Drawing.Point(489, 54);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(150, 22);
            this.lblSortBy.TabIndex = 6;
            this.lblSortBy.Text = "Sort By";
            this.lblSortBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSortBy
            // 
            this.cmbSortBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbSortBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSortBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbSortBy.FormattingEnabled = true;
            this.cmbSortBy.Items.AddRange(new object[] {
            "Name",
            "Price",
            "Stock",
            "Expiry Date"});
            this.cmbSortBy.Location = new System.Drawing.Point(489, 79);
            this.cmbSortBy.Name = "cmbSortBy";
            this.cmbSortBy.Size = new System.Drawing.Size(230, 23);
            this.cmbSortBy.TabIndex = 7;
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnResetFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetFilters.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnResetFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilters.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResetFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnResetFilters.Location = new System.Drawing.Point(732, 25);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(100, 26);
            this.btnResetFilters.TabIndex = 8;
            this.btnResetFilters.Text = "Reset Filters";
            this.btnResetFilters.UseVisualStyleBackColor = false;
            // 
            // btnRefreshResults
            // 
            this.btnRefreshResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnRefreshResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshResults.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRefreshResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshResults.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRefreshResults.Location = new System.Drawing.Point(732, 79);
            this.btnRefreshResults.Name = "btnRefreshResults";
            this.btnRefreshResults.Size = new System.Drawing.Size(100, 26);
            this.btnRefreshResults.TabIndex = 9;
            this.btnRefreshResults.Text = "Refresh";
            this.btnRefreshResults.UseVisualStyleBackColor = false;
            // 
            // pnlMedicineGridContainer
            // 
            this.pnlMedicineGridContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlMedicineGridContainer.Controls.Add(this.pnlMedicineGridCard);
            this.pnlMedicineGridContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMedicineGridContainer.Location = new System.Drawing.Point(20, 456);
            this.pnlMedicineGridContainer.Name = "pnlMedicineGridContainer";
            this.pnlMedicineGridContainer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlMedicineGridContainer.Size = new System.Drawing.Size(1005, 340);
            this.pnlMedicineGridContainer.TabIndex = 3;
            // 
            // pnlMedicineGridCard
            // 
            this.pnlMedicineGridCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlMedicineGridCard.Controls.Add(this.dgvMedicines);
            this.pnlMedicineGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMedicineGridCard.Location = new System.Drawing.Point(0, 0);
            this.pnlMedicineGridCard.Name = "pnlMedicineGridCard";
            this.pnlMedicineGridCard.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMedicineGridCard.Size = new System.Drawing.Size(1005, 330);
            this.pnlMedicineGridCard.TabIndex = 0;
            // 
            // dgvMedicines
            // 
            this.dgvMedicines.AllowUserToAddRows = false;
            this.dgvMedicines.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMedicines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMedicines.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvMedicines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedicines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMedID,
            this.colMedName,
            this.colMedCategory,
            this.colMedDosage,
            this.colMedSupplier,
            this.colMedPrice,
            this.colMedStock,
            this.colMedExpiry,
            this.colMedDiscount,
            this.colMedPrescription});
            this.dgvMedicines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedicines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dgvMedicines.Location = new System.Drawing.Point(10, 10);
            this.dgvMedicines.Name = "dgvMedicines";
            this.dgvMedicines.ReadOnly = true;
            this.dgvMedicines.RowHeadersVisible = false;
            this.dgvMedicines.RowTemplate.Height = 30;
            this.dgvMedicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicines.Size = new System.Drawing.Size(985, 310);
            this.dgvMedicines.TabIndex = 0;
            // 
            // colMedID
            // 
            this.colMedID.HeaderText = "Medicine ID";
            this.colMedID.Name = "colMedID";
            this.colMedID.ReadOnly = true;
            this.colMedID.Width = 90;
            // 
            // colMedName
            // 
            this.colMedName.HeaderText = "Medicine Name";
            this.colMedName.Name = "colMedName";
            this.colMedName.ReadOnly = true;
            this.colMedName.Width = 160;
            // 
            // colMedCategory
            // 
            this.colMedCategory.HeaderText = "Category";
            this.colMedCategory.Name = "colMedCategory";
            this.colMedCategory.ReadOnly = true;
            // 
            // colMedDosage
            // 
            this.colMedDosage.HeaderText = "Dosage";
            this.colMedDosage.Name = "colMedDosage";
            this.colMedDosage.ReadOnly = true;
            // 
            // colMedSupplier
            // 
            this.colMedSupplier.HeaderText = "Supplier";
            this.colMedSupplier.Name = "colMedSupplier";
            this.colMedSupplier.ReadOnly = true;
            this.colMedSupplier.Width = 120;
            // 
            // colMedPrice
            // 
            this.colMedPrice.HeaderText = "Price";
            this.colMedPrice.Name = "colMedPrice";
            this.colMedPrice.ReadOnly = true;
            this.colMedPrice.Width = 70;
            // 
            // colMedStock
            // 
            this.colMedStock.HeaderText = "Stock";
            this.colMedStock.Name = "colMedStock";
            this.colMedStock.ReadOnly = true;
            this.colMedStock.Width = 70;
            // 
            // colMedExpiry
            // 
            this.colMedExpiry.HeaderText = "Expiry Date";
            this.colMedExpiry.Name = "colMedExpiry";
            this.colMedExpiry.ReadOnly = true;
            // 
            // colMedDiscount
            // 
            this.colMedDiscount.HeaderText = "Discount %";
            this.colMedDiscount.Name = "colMedDiscount";
            this.colMedDiscount.ReadOnly = true;
            this.colMedDiscount.Width = 80;
            // 
            // colMedPrescription
            // 
            this.colMedPrescription.HeaderText = "Prescription";
            this.colMedPrescription.Name = "colMedPrescription";
            this.colMedPrescription.ReadOnly = true;
            this.colMedPrescription.Width = 90;
            // 
            // pnlMedicineDetailsContainer
            // 
            this.pnlMedicineDetailsContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlMedicineDetailsContainer.Controls.Add(this.pnlMedicineDetailsCard);
            this.pnlMedicineDetailsContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMedicineDetailsContainer.Location = new System.Drawing.Point(20, 796);
            this.pnlMedicineDetailsContainer.Name = "pnlMedicineDetailsContainer";
            this.pnlMedicineDetailsContainer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlMedicineDetailsContainer.Size = new System.Drawing.Size(1005, 270);
            this.pnlMedicineDetailsContainer.TabIndex = 4;
            // 
            // pnlMedicineDetailsCard
            // 
            this.pnlMedicineDetailsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlMedicineDetailsCard.Controls.Add(this.tblMedicineDetails);
            this.pnlMedicineDetailsCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMedicineDetailsCard.Location = new System.Drawing.Point(0, 0);
            this.pnlMedicineDetailsCard.Name = "pnlMedicineDetailsCard";
            this.pnlMedicineDetailsCard.Padding = new System.Windows.Forms.Padding(15);
            this.pnlMedicineDetailsCard.Size = new System.Drawing.Size(1005, 260);
            this.pnlMedicineDetailsCard.TabIndex = 0;
            // 
            // tblMedicineDetails
            // 
            this.tblMedicineDetails.BackColor = System.Drawing.Color.Transparent;
            this.tblMedicineDetails.ColumnCount = 2;
            this.tblMedicineDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMedicineDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMedicineDetails.Controls.Add(this.lblMedicineID, 0, 0);
            this.tblMedicineDetails.Controls.Add(this.txtMedicineID, 0, 1);
            this.tblMedicineDetails.Controls.Add(this.lblMedicineName, 1, 0);
            this.tblMedicineDetails.Controls.Add(this.txtMedicineName, 1, 1);
            this.tblMedicineDetails.Controls.Add(this.lblCategory, 0, 2);
            this.tblMedicineDetails.Controls.Add(this.cmbCategory, 0, 3);
            this.tblMedicineDetails.Controls.Add(this.lblDosage, 1, 2);
            this.tblMedicineDetails.Controls.Add(this.cmbDosage, 1, 3);
            this.tblMedicineDetails.Controls.Add(this.lblSupplier, 0, 4);
            this.tblMedicineDetails.Controls.Add(this.cmbSupplier, 0, 5);
            this.tblMedicineDetails.Controls.Add(this.lblPrice, 1, 4);
            this.tblMedicineDetails.Controls.Add(this.numPrice, 1, 5);
            this.tblMedicineDetails.Controls.Add(this.lblStockQuantity, 0, 6);
            this.tblMedicineDetails.Controls.Add(this.numStockQuantity, 0, 7);
            this.tblMedicineDetails.Controls.Add(this.lblExpiryDate, 1, 6);
            this.tblMedicineDetails.Controls.Add(this.dtpExpiryDate, 1, 7);
            this.tblMedicineDetails.Controls.Add(this.lblDiscount, 0, 8);
            this.tblMedicineDetails.Controls.Add(this.numDiscount, 0, 9);
            this.tblMedicineDetails.Controls.Add(this.chkPrescription, 1, 8);
            this.tblMedicineDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMedicineDetails.Location = new System.Drawing.Point(15, 15);
            this.tblMedicineDetails.Name = "tblMedicineDetails";
            this.tblMedicineDetails.RowCount = 10;
            this.tblMedicineDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblMedicineDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblMedicineDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblMedicineDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblMedicineDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblMedicineDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblMedicineDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblMedicineDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblMedicineDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblMedicineDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblMedicineDetails.Size = new System.Drawing.Size(975, 230);
            this.tblMedicineDetails.TabIndex = 0;
            // 
            // lblMedicineID
            // 
            this.lblMedicineID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMedicineID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblMedicineID.Location = new System.Drawing.Point(3, 0);
            this.lblMedicineID.Name = "lblMedicineID";
            this.lblMedicineID.Size = new System.Drawing.Size(200, 22);
            this.lblMedicineID.TabIndex = 0;
            this.lblMedicineID.Text = "Medicine ID";
            this.lblMedicineID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMedicineID
            // 
            this.txtMedicineID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtMedicineID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMedicineID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtMedicineID.Location = new System.Drawing.Point(3, 25);
            this.txtMedicineID.Name = "txtMedicineID";
            this.txtMedicineID.ReadOnly = true;
            this.txtMedicineID.Size = new System.Drawing.Size(380, 23);
            this.txtMedicineID.TabIndex = 1;
            // 
            // lblMedicineName
            // 
            this.lblMedicineName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMedicineName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblMedicineName.Location = new System.Drawing.Point(490, 0);
            this.lblMedicineName.Name = "lblMedicineName";
            this.lblMedicineName.Size = new System.Drawing.Size(200, 22);
            this.lblMedicineName.TabIndex = 2;
            this.lblMedicineName.Text = "Medicine Name";
            this.lblMedicineName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtMedicineName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMedicineName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtMedicineName.Location = new System.Drawing.Point(490, 25);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(380, 23);
            this.txtMedicineName.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblCategory.Location = new System.Drawing.Point(3, 52);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(200, 22);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(3, 77);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(380, 23);
            this.cmbCategory.TabIndex = 5;
            // 
            // lblDosage
            // 
            this.lblDosage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDosage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblDosage.Location = new System.Drawing.Point(490, 52);
            this.lblDosage.Name = "lblDosage";
            this.lblDosage.Size = new System.Drawing.Size(200, 22);
            this.lblDosage.TabIndex = 6;
            this.lblDosage.Text = "Dosage";
            this.lblDosage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbDosage
            // 
            this.cmbDosage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbDosage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDosage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbDosage.FormattingEnabled = true;
            this.cmbDosage.Location = new System.Drawing.Point(490, 77);
            this.cmbDosage.Name = "cmbDosage";
            this.cmbDosage.Size = new System.Drawing.Size(380, 23);
            this.cmbDosage.TabIndex = 7;
            // 
            // lblSupplier
            // 
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblSupplier.Location = new System.Drawing.Point(3, 104);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(200, 22);
            this.lblSupplier.TabIndex = 8;
            this.lblSupplier.Text = "Supplier";
            this.lblSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(3, 129);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(380, 23);
            this.cmbSupplier.TabIndex = 9;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblPrice.Location = new System.Drawing.Point(490, 104);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(200, 22);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numPrice
            // 
            this.numPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.numPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.numPrice.Location = new System.Drawing.Point(490, 129);
            this.numPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(380, 23);
            this.numPrice.TabIndex = 11;
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStockQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblStockQuantity.Location = new System.Drawing.Point(3, 156);
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(200, 22);
            this.lblStockQuantity.TabIndex = 12;
            this.lblStockQuantity.Text = "Stock Quantity";
            this.lblStockQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numStockQuantity
            // 
            this.numStockQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.numStockQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numStockQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.numStockQuantity.Location = new System.Drawing.Point(3, 181);
            this.numStockQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numStockQuantity.Name = "numStockQuantity";
            this.numStockQuantity.Size = new System.Drawing.Size(380, 23);
            this.numStockQuantity.TabIndex = 13;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblExpiryDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblExpiryDate.Location = new System.Drawing.Point(490, 156);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(200, 22);
            this.lblExpiryDate.TabIndex = 14;
            this.lblExpiryDate.Text = "Expiry Date";
            this.lblExpiryDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dtpExpiryDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dtpExpiryDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiryDate.Location = new System.Drawing.Point(490, 181);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(380, 23);
            this.dtpExpiryDate.TabIndex = 15;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblDiscount.Location = new System.Drawing.Point(3, 208);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(200, 22);
            this.lblDiscount.TabIndex = 16;
            this.lblDiscount.Text = "Discount Percentage";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numDiscount
            // 
            this.numDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.numDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numDiscount.DecimalPlaces = 2;
            this.numDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.numDiscount.Location = new System.Drawing.Point(3, 233);
            this.numDiscount.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(380, 23);
            this.numDiscount.TabIndex = 17;
            // 
            // chkPrescription
            // 
            this.chkPrescription.AutoSize = true;
            this.chkPrescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkPrescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.chkPrescription.Location = new System.Drawing.Point(490, 211);
            this.chkPrescription.Name = "chkPrescription";
            this.chkPrescription.Size = new System.Drawing.Size(139, 19);
            this.chkPrescription.TabIndex = 18;
            this.chkPrescription.Text = "Prescription Required";
            this.tblMedicineDetails.SetRowSpan(this.chkPrescription, 2);
            this.chkPrescription.UseVisualStyleBackColor = true;
            // 
            // pnlActionButtonsContainer
            // 
            this.pnlActionButtonsContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlActionButtonsContainer.Controls.Add(this.pnlActionButtonsCard);
            this.pnlActionButtonsContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActionButtonsContainer.Location = new System.Drawing.Point(20, 1066);
            this.pnlActionButtonsContainer.Name = "pnlActionButtonsContainer";
            this.pnlActionButtonsContainer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlActionButtonsContainer.Size = new System.Drawing.Size(1005, 78);
            this.pnlActionButtonsContainer.TabIndex = 5;
            // 
            // pnlActionButtonsCard
            // 
            this.pnlActionButtonsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlActionButtonsCard.Controls.Add(this.flpActionButtons);
            this.pnlActionButtonsCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActionButtonsCard.Location = new System.Drawing.Point(0, 0);
            this.pnlActionButtonsCard.Name = "pnlActionButtonsCard";
            this.pnlActionButtonsCard.Padding = new System.Windows.Forms.Padding(15);
            this.pnlActionButtonsCard.Size = new System.Drawing.Size(1005, 68);
            this.pnlActionButtonsCard.TabIndex = 0;
            // 
            // flpActionButtons
            // 
            this.flpActionButtons.BackColor = System.Drawing.Color.Transparent;
            this.flpActionButtons.Controls.Add(this.btnAddMedicine);
            this.flpActionButtons.Controls.Add(this.btnUpdateMedicine);
            this.flpActionButtons.Controls.Add(this.btnDeleteMedicine);
            this.flpActionButtons.Controls.Add(this.btnClear);
            this.flpActionButtons.Controls.Add(this.btnRefresh);
            this.flpActionButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpActionButtons.Location = new System.Drawing.Point(15, 15);
            this.flpActionButtons.Name = "flpActionButtons";
            this.flpActionButtons.Size = new System.Drawing.Size(975, 38);
            this.flpActionButtons.TabIndex = 0;
            this.flpActionButtons.WrapContents = false;
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAddMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMedicine.FlatAppearance.BorderSize = 0;
            this.btnAddMedicine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnAddMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMedicine.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddMedicine.ForeColor = System.Drawing.Color.White;
            this.btnAddMedicine.Location = new System.Drawing.Point(3, 3);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(110, 32);
            this.btnAddMedicine.TabIndex = 0;
            this.btnAddMedicine.Text = "Add Medicine";
            this.btnAddMedicine.UseVisualStyleBackColor = false;
            // 
            // btnUpdateMedicine
            // 
            this.btnUpdateMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnUpdateMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateMedicine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnUpdateMedicine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnUpdateMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMedicine.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateMedicine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnUpdateMedicine.Location = new System.Drawing.Point(119, 3);
            this.btnUpdateMedicine.Name = "btnUpdateMedicine";
            this.btnUpdateMedicine.Size = new System.Drawing.Size(110, 32);
            this.btnUpdateMedicine.TabIndex = 1;
            this.btnUpdateMedicine.Text = "Update Medicine";
            this.btnUpdateMedicine.UseVisualStyleBackColor = false;
            // 
            // btnDeleteMedicine
            // 
            this.btnDeleteMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnDeleteMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteMedicine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnDeleteMedicine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeleteMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMedicine.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteMedicine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnDeleteMedicine.Location = new System.Drawing.Point(235, 3);
            this.btnDeleteMedicine.Name = "btnDeleteMedicine";
            this.btnDeleteMedicine.Size = new System.Drawing.Size(110, 32);
            this.btnDeleteMedicine.TabIndex = 2;
            this.btnDeleteMedicine.Text = "Delete Medicine";
            this.btnDeleteMedicine.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClear.Location = new System.Drawing.Point(351, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 32);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRefresh.Location = new System.Drawing.Point(447, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 32);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
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
            this.lblAppTitle.Text = "SmartMed Pharmacy Management";
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
            this.lblUserName.Text = "Admin User";
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
            this.pnlSidebar.Size = new System.Drawing.Size(240, 749);
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
            this.pnlNav.Controls.Add(this.btnNavReports);
            this.pnlNav.Controls.Add(this.btnNavOrders);
            this.pnlNav.Controls.Add(this.btnNavCustomers);
            this.pnlNav.Controls.Add(this.btnNavMedicines);
            this.pnlNav.Controls.Add(this.btnNavDashboard);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.pnlNav.Size = new System.Drawing.Size(240, 749);
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
            this.btnNavLogout.Location = new System.Drawing.Point(9, 664);
            this.btnNavLogout.Name = "btnNavLogout";
            this.btnNavLogout.Size = new System.Drawing.Size(240, 44);
            this.btnNavLogout.TabIndex = 5;
            this.btnNavLogout.Text = "🚪  Logout";
            this.btnNavLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavLogout.UseVisualStyleBackColor = true;
            // 
            // btnNavReports
            // 
            this.btnNavReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavReports.FlatAppearance.BorderSize = 0;
            this.btnNavReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnNavReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReports.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNavReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavReports.Location = new System.Drawing.Point(8, 232);
            this.btnNavReports.Name = "btnNavReports";
            this.btnNavReports.Size = new System.Drawing.Size(240, 44);
            this.btnNavReports.TabIndex = 4;
            this.btnNavReports.Text = "📊  Reports";
            this.btnNavReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavReports.UseVisualStyleBackColor = true;
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
            this.btnNavOrders.Location = new System.Drawing.Point(8, 184);
            this.btnNavOrders.Name = "btnNavOrders";
            this.btnNavOrders.Size = new System.Drawing.Size(240, 44);
            this.btnNavOrders.TabIndex = 3;
            this.btnNavOrders.Text = "🛒  Orders";
            this.btnNavOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavOrders.UseVisualStyleBackColor = true;
            // 
            // btnNavCustomers
            // 
            this.btnNavCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavCustomers.FlatAppearance.BorderSize = 0;
            this.btnNavCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnNavCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCustomers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNavCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavCustomers.Location = new System.Drawing.Point(9, 136);
            this.btnNavCustomers.Name = "btnNavCustomers";
            this.btnNavCustomers.Size = new System.Drawing.Size(240, 44);
            this.btnNavCustomers.TabIndex = 2;
            this.btnNavCustomers.Text = "👥  Customers";
            this.btnNavCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavCustomers.UseVisualStyleBackColor = true;
            // 
            // btnNavMedicines
            // 
            this.btnNavMedicines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavMedicines.FlatAppearance.BorderSize = 0;
            this.btnNavMedicines.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnNavMedicines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMedicines.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavMedicines.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnNavMedicines.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavMedicines.Location = new System.Drawing.Point(9, 88);
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
            // MedicineManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1302, 749);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "MedicineManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartMed Pharmacy Management System - Medicine Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MedicineManagementForm_Load);

            // -------------------------------------------------
            // CRITICAL: Add all content sections to pnlDashboardContent
            // in the required top-to-bottom order.
            // -------------------------------------------------
            this.pnlDashboardContent.Controls.Add(this.pnlActionButtonsContainer);
            this.pnlDashboardContent.Controls.Add(this.pnlMedicineDetailsContainer);
            this.pnlDashboardContent.Controls.Add(this.pnlMedicineGridContainer);
            this.pnlDashboardContent.Controls.Add(this.pnlSearchFiltersContainer);
            this.pnlDashboardContent.Controls.Add(this.pnlSummaryContainer);
            this.pnlDashboardContent.Controls.Add(this.pnlPageHeaderContainer);

            this.pnlMain.ResumeLayout(false);
            this.pnlContentArea.ResumeLayout(false);
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlDashboardContent.ResumeLayout(false);
            this.pnlPageHeaderContainer.ResumeLayout(false);
            this.pnlPageHeaderCard.ResumeLayout(false);
            this.pnlSummaryContainer.ResumeLayout(false);
            this.pnlSummaryCard.ResumeLayout(false);
            this.flpSummaryCards.ResumeLayout(false);
            this.pnlSumTotalMeds.ResumeLayout(false);
            this.pnlSumAvailableMeds.ResumeLayout(false);
            this.pnlSumLowStock.ResumeLayout(false);
            this.pnlSumExpiredMeds.ResumeLayout(false);
            this.pnlSumPrescriptionMeds.ResumeLayout(false);
            this.pnlSearchFiltersContainer.ResumeLayout(false);
            this.pnlSearchFiltersCard.ResumeLayout(false);
            this.tblSearchFilters.ResumeLayout(false);
            this.tblSearchFilters.PerformLayout();
            this.pnlFilterChecks.ResumeLayout(false);
            this.pnlFilterChecks.PerformLayout();
            this.pnlMedicineGridContainer.ResumeLayout(false);
            this.pnlMedicineGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).EndInit();
            this.pnlMedicineDetailsContainer.ResumeLayout(false);
            this.pnlMedicineDetailsCard.ResumeLayout(false);
            this.tblMedicineDetails.ResumeLayout(false);
            this.tblMedicineDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            this.pnlActionButtonsContainer.ResumeLayout(false);
            this.pnlActionButtonsCard.ResumeLayout(false);
            this.flpActionButtons.ResumeLayout(false);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlUserInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebarLogo.ResumeLayout(false);
            this.pnlNav.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // Main layout panels
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlContentArea;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlSidebarLogo;
        private System.Windows.Forms.Label lblSidebarLogoPrefix;
        private System.Windows.Forms.Label lblSidebarLogoAccent;
        private System.Windows.Forms.Label lblSidebarLogoSuffix;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavMedicines;
        private System.Windows.Forms.Button btnNavCustomers;
        private System.Windows.Forms.Button btnNavOrders;
        private System.Windows.Forms.Button btnNavReports;
        private System.Windows.Forms.Button btnNavLogout;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox picUserAvatar;
        private System.Windows.Forms.Label btnLogoutIcon;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Panel pnlDashboardContent;

        // Page Header Card
        private System.Windows.Forms.Panel pnlPageHeaderContainer;
        private System.Windows.Forms.Panel pnlPageHeaderCard;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageDescription;
        private System.Windows.Forms.Label lblBreadcrumb;

        // KPI Summary Cards
        private System.Windows.Forms.Panel pnlSummaryContainer;
        private System.Windows.Forms.Panel pnlSummaryCard;
        private System.Windows.Forms.FlowLayoutPanel flpSummaryCards;
        private System.Windows.Forms.Panel pnlSumTotalMeds;
        private System.Windows.Forms.Label lblTotalMedsValue;
        private System.Windows.Forms.Label lblTotalMedsTitle;
        private System.Windows.Forms.Panel pnlSumAvailableMeds;
        private System.Windows.Forms.Label lblAvailableMedsValue;
        private System.Windows.Forms.Label lblAvailableMedsTitle;
        private System.Windows.Forms.Panel pnlSumLowStock;
        private System.Windows.Forms.Label lblLowStockValue;
        private System.Windows.Forms.Label lblLowStockTitle;
        private System.Windows.Forms.Panel pnlSumExpiredMeds;
        private System.Windows.Forms.Label lblExpiredMedsValue;
        private System.Windows.Forms.Label lblExpiredMedsTitle;
        private System.Windows.Forms.Panel pnlSumPrescriptionMeds;
        private System.Windows.Forms.Label lblPrescriptionMedsValue;
        private System.Windows.Forms.Label lblPrescriptionMedsTitle;

        // Search & Filters
        private System.Windows.Forms.Panel pnlSearchFiltersContainer;
        private System.Windows.Forms.Panel pnlSearchFiltersCard;
        private System.Windows.Forms.TableLayoutPanel tblSearchFilters;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label lblSearchCategory;
        private System.Windows.Forms.ComboBox cmbSearchCategory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.FlowLayoutPanel pnlFilterChecks;
        private System.Windows.Forms.CheckBox chkLowStock;
        private System.Windows.Forms.CheckBox chkExpired;
        private System.Windows.Forms.CheckBox chkPrescriptionFilter;
        // chkActiveFilter removed
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.ComboBox cmbSortBy;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.Button btnRefreshResults;

        // Medicine DataGrid
        private System.Windows.Forms.Panel pnlMedicineGridContainer;
        private System.Windows.Forms.Panel pnlMedicineGridCard;
        private System.Windows.Forms.DataGridView dgvMedicines;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedDosage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedPrescription;
        // colMedStatus removed

        // Medicine Details
        private System.Windows.Forms.Panel pnlMedicineDetailsContainer;
        private System.Windows.Forms.Panel pnlMedicineDetailsCard;
        private System.Windows.Forms.TableLayoutPanel tblMedicineDetails;
        private System.Windows.Forms.Label lblMedicineID;
        private System.Windows.Forms.TextBox txtMedicineID;
        private System.Windows.Forms.Label lblMedicineName;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblDosage;
        private System.Windows.Forms.ComboBox cmbDosage;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label lblStockQuantity;
        private System.Windows.Forms.NumericUpDown numStockQuantity;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.CheckBox chkPrescription;
        // chkActiveStatus removed

        // Action Buttons
        private System.Windows.Forms.Panel pnlActionButtonsContainer;
        private System.Windows.Forms.Panel pnlActionButtonsCard;
        private System.Windows.Forms.FlowLayoutPanel flpActionButtons;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.Button btnUpdateMedicine;
        private System.Windows.Forms.Button btnDeleteMedicine;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;

        // Tooltip
        private System.Windows.Forms.ToolTip toolTipHints;
    }
}