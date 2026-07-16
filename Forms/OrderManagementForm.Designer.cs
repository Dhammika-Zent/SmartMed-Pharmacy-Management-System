namespace SmartMed.Forms
{
    partial class OrderManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pnlSumTotalOrders = new System.Windows.Forms.Panel();
            this.lblTotalOrdersValue = new System.Windows.Forms.Label();
            this.lblTotalOrdersTitle = new System.Windows.Forms.Label();
            this.pnlSumPendingOrders = new System.Windows.Forms.Panel();
            this.lblPendingOrdersValue = new System.Windows.Forms.Label();
            this.lblPendingOrdersTitle = new System.Windows.Forms.Label();
            this.pnlSumReadyPickup = new System.Windows.Forms.Panel();
            this.lblReadyPickupValue = new System.Windows.Forms.Label();
            this.lblReadyPickupTitle = new System.Windows.Forms.Label();
            this.pnlSumDeliveredOrders = new System.Windows.Forms.Panel();
            this.lblDeliveredOrdersValue = new System.Windows.Forms.Label();
            this.lblDeliveredOrdersTitle = new System.Windows.Forms.Label();
            this.pnlSearchFiltersContainer = new System.Windows.Forms.Panel();
            this.pnlSearchFiltersCard = new System.Windows.Forms.Panel();
            this.tblSearchFilters = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearchCustomer = new System.Windows.Forms.Label();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.lblSearchOrderID = new System.Windows.Forms.Label();
            this.txtSearchOrderID = new System.Windows.Forms.TextBox();
            this.lblSearchStatus = new System.Windows.Forms.Label();
            this.cmbSearchStatus = new System.Windows.Forms.ComboBox();
            this.pnlSearchButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.btnRefreshResults = new System.Windows.Forms.Button();
            this.pnlOrderGridContainer = new System.Windows.Forms.Panel();
            this.pnlOrderGridCard = new System.Windows.Forms.Panel();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.colOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUpdateStatusContainer = new System.Windows.Forms.Panel();
            this.pnlUpdateStatusCard = new System.Windows.Forms.Panel();
            this.tblUpdateStatus = new System.Windows.Forms.TableLayoutPanel();
            this.lblSelectedOrder = new System.Windows.Forms.Label();
            this.txtSelectedOrderID = new System.Windows.Forms.TextBox();
            this.lblCurrentStatusCaption = new System.Windows.Forms.Label();
            this.txtCurrentStatus = new System.Windows.Forms.TextBox();
            this.lblNewStatusCaption = new System.Windows.Forms.Label();
            this.cmbNewStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdateOrderStatus = new System.Windows.Forms.Button();
            this.pnlActionButtonsContainer = new System.Windows.Forms.Panel();
            this.pnlActionButtonsCard = new System.Windows.Forms.Panel();
            this.flpActionButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnViewItems = new System.Windows.Forms.Button();
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
            this.pnlSumTotalOrders.SuspendLayout();
            this.pnlSumPendingOrders.SuspendLayout();
            this.pnlSumReadyPickup.SuspendLayout();
            this.pnlSumDeliveredOrders.SuspendLayout();
            this.pnlSearchFiltersContainer.SuspendLayout();
            this.pnlSearchFiltersCard.SuspendLayout();
            this.tblSearchFilters.SuspendLayout();
            this.pnlSearchButtons.SuspendLayout();
            this.pnlOrderGridContainer.SuspendLayout();
            this.pnlOrderGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.pnlUpdateStatusContainer.SuspendLayout();
            this.pnlUpdateStatusCard.SuspendLayout();
            this.tblUpdateStatus.SuspendLayout();
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
            this.pnlDashboardContent.Controls.Add(this.pnlActionButtonsContainer);
            this.pnlDashboardContent.Controls.Add(this.pnlUpdateStatusContainer);
            this.pnlDashboardContent.Controls.Add(this.pnlOrderGridContainer);
            this.pnlDashboardContent.Controls.Add(this.pnlSearchFiltersContainer);
            this.pnlDashboardContent.Controls.Add(this.pnlSummaryContainer);
            this.pnlDashboardContent.Controls.Add(this.pnlPageHeaderContainer);
            this.pnlDashboardContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDashboardContent.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboardContent.Name = "pnlDashboardContent";
            this.pnlDashboardContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlDashboardContent.Size = new System.Drawing.Size(1045, 1168);
            this.pnlDashboardContent.TabIndex = 0;
            // 
            // pnlPageHeaderContainer
            // 
            this.pnlPageHeaderContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlPageHeaderContainer.Controls.Add(this.pnlPageHeaderCard);
            this.pnlPageHeaderContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPageHeaderContainer.Location = new System.Drawing.Point(20, 1017);
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
            this.lblPageTitle.Text = "Order Management";
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
            this.lblPageDescription.Text = "View customer orders and update their order status.";
            this.lblPageDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lblBreadcrumb.Text = "Dashboard > Order Management";
            this.lblBreadcrumb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBreadcrumb.Visible = false;
            // 
            // pnlSummaryContainer
            // 
            this.pnlSummaryContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlSummaryContainer.Controls.Add(this.pnlSummaryCard);
            this.pnlSummaryContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSummaryContainer.Location = new System.Drawing.Point(20, 863);
            this.pnlSummaryContainer.Name = "pnlSummaryContainer";
            this.pnlSummaryContainer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.pnlSummaryContainer.Size = new System.Drawing.Size(1005, 154);
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
            this.pnlSummaryCard.Size = new System.Drawing.Size(1005, 134);
            this.pnlSummaryCard.TabIndex = 0;
            // 
            // flpSummaryCards
            // 
            this.flpSummaryCards.BackColor = System.Drawing.Color.Transparent;
            this.flpSummaryCards.Controls.Add(this.pnlSumTotalOrders);
            this.flpSummaryCards.Controls.Add(this.pnlSumPendingOrders);
            this.flpSummaryCards.Controls.Add(this.pnlSumReadyPickup);
            this.flpSummaryCards.Controls.Add(this.pnlSumDeliveredOrders);
            this.flpSummaryCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSummaryCards.Location = new System.Drawing.Point(10, 10);
            this.flpSummaryCards.Name = "flpSummaryCards";
            this.flpSummaryCards.Size = new System.Drawing.Size(985, 114);
            this.flpSummaryCards.TabIndex = 0;
            this.flpSummaryCards.WrapContents = false;
            // 
            // pnlSumTotalOrders
            // 
            this.pnlSumTotalOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlSumTotalOrders.Controls.Add(this.lblTotalOrdersValue);
            this.pnlSumTotalOrders.Controls.Add(this.lblTotalOrdersTitle);
            this.pnlSumTotalOrders.Location = new System.Drawing.Point(3, 3);
            this.pnlSumTotalOrders.Name = "pnlSumTotalOrders";
            this.pnlSumTotalOrders.Padding = new System.Windows.Forms.Padding(10);
            this.pnlSumTotalOrders.Size = new System.Drawing.Size(160, 100);
            this.pnlSumTotalOrders.TabIndex = 0;
            // 
            // lblTotalOrdersValue
            // 
            this.lblTotalOrdersValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalOrdersValue.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalOrdersValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblTotalOrdersValue.Location = new System.Drawing.Point(10, 10);
            this.lblTotalOrdersValue.Name = "lblTotalOrdersValue";
            this.lblTotalOrdersValue.Size = new System.Drawing.Size(140, 55);
            this.lblTotalOrdersValue.TabIndex = 0;
            this.lblTotalOrdersValue.Text = "0";
            this.lblTotalOrdersValue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblTotalOrdersTitle
            // 
            this.lblTotalOrdersTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalOrdersTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalOrdersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblTotalOrdersTitle.Location = new System.Drawing.Point(10, 65);
            this.lblTotalOrdersTitle.Name = "lblTotalOrdersTitle";
            this.lblTotalOrdersTitle.Size = new System.Drawing.Size(140, 25);
            this.lblTotalOrdersTitle.TabIndex = 1;
            this.lblTotalOrdersTitle.Text = "Total Orders";
            this.lblTotalOrdersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSumPendingOrders
            // 
            this.pnlSumPendingOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlSumPendingOrders.Controls.Add(this.lblPendingOrdersValue);
            this.pnlSumPendingOrders.Controls.Add(this.lblPendingOrdersTitle);
            this.pnlSumPendingOrders.Location = new System.Drawing.Point(169, 3);
            this.pnlSumPendingOrders.Name = "pnlSumPendingOrders";
            this.pnlSumPendingOrders.Padding = new System.Windows.Forms.Padding(10);
            this.pnlSumPendingOrders.Size = new System.Drawing.Size(160, 100);
            this.pnlSumPendingOrders.TabIndex = 1;
            // 
            // lblPendingOrdersValue
            // 
            this.lblPendingOrdersValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPendingOrdersValue.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblPendingOrdersValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblPendingOrdersValue.Location = new System.Drawing.Point(10, 10);
            this.lblPendingOrdersValue.Name = "lblPendingOrdersValue";
            this.lblPendingOrdersValue.Size = new System.Drawing.Size(140, 55);
            this.lblPendingOrdersValue.TabIndex = 0;
            this.lblPendingOrdersValue.Text = "0";
            this.lblPendingOrdersValue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblPendingOrdersTitle
            // 
            this.lblPendingOrdersTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPendingOrdersTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPendingOrdersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblPendingOrdersTitle.Location = new System.Drawing.Point(10, 65);
            this.lblPendingOrdersTitle.Name = "lblPendingOrdersTitle";
            this.lblPendingOrdersTitle.Size = new System.Drawing.Size(140, 25);
            this.lblPendingOrdersTitle.TabIndex = 1;
            this.lblPendingOrdersTitle.Text = "Pending Orders";
            this.lblPendingOrdersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSumReadyPickup
            // 
            this.pnlSumReadyPickup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlSumReadyPickup.Controls.Add(this.lblReadyPickupValue);
            this.pnlSumReadyPickup.Controls.Add(this.lblReadyPickupTitle);
            this.pnlSumReadyPickup.Location = new System.Drawing.Point(335, 3);
            this.pnlSumReadyPickup.Name = "pnlSumReadyPickup";
            this.pnlSumReadyPickup.Padding = new System.Windows.Forms.Padding(10);
            this.pnlSumReadyPickup.Size = new System.Drawing.Size(160, 100);
            this.pnlSumReadyPickup.TabIndex = 2;
            // 
            // lblReadyPickupValue
            // 
            this.lblReadyPickupValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReadyPickupValue.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblReadyPickupValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblReadyPickupValue.Location = new System.Drawing.Point(10, 10);
            this.lblReadyPickupValue.Name = "lblReadyPickupValue";
            this.lblReadyPickupValue.Size = new System.Drawing.Size(140, 55);
            this.lblReadyPickupValue.TabIndex = 0;
            this.lblReadyPickupValue.Text = "0";
            this.lblReadyPickupValue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblReadyPickupTitle
            // 
            this.lblReadyPickupTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblReadyPickupTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblReadyPickupTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblReadyPickupTitle.Location = new System.Drawing.Point(10, 65);
            this.lblReadyPickupTitle.Name = "lblReadyPickupTitle";
            this.lblReadyPickupTitle.Size = new System.Drawing.Size(140, 25);
            this.lblReadyPickupTitle.TabIndex = 1;
            this.lblReadyPickupTitle.Text = "Ready for Pickup";
            this.lblReadyPickupTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSumDeliveredOrders
            // 
            this.pnlSumDeliveredOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlSumDeliveredOrders.Controls.Add(this.lblDeliveredOrdersValue);
            this.pnlSumDeliveredOrders.Controls.Add(this.lblDeliveredOrdersTitle);
            this.pnlSumDeliveredOrders.Location = new System.Drawing.Point(501, 3);
            this.pnlSumDeliveredOrders.Name = "pnlSumDeliveredOrders";
            this.pnlSumDeliveredOrders.Padding = new System.Windows.Forms.Padding(10);
            this.pnlSumDeliveredOrders.Size = new System.Drawing.Size(160, 100);
            this.pnlSumDeliveredOrders.TabIndex = 3;
            // 
            // lblDeliveredOrdersValue
            // 
            this.lblDeliveredOrdersValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDeliveredOrdersValue.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblDeliveredOrdersValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.lblDeliveredOrdersValue.Location = new System.Drawing.Point(10, 10);
            this.lblDeliveredOrdersValue.Name = "lblDeliveredOrdersValue";
            this.lblDeliveredOrdersValue.Size = new System.Drawing.Size(140, 55);
            this.lblDeliveredOrdersValue.TabIndex = 0;
            this.lblDeliveredOrdersValue.Text = "0";
            this.lblDeliveredOrdersValue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblDeliveredOrdersTitle
            // 
            this.lblDeliveredOrdersTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDeliveredOrdersTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDeliveredOrdersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblDeliveredOrdersTitle.Location = new System.Drawing.Point(10, 65);
            this.lblDeliveredOrdersTitle.Name = "lblDeliveredOrdersTitle";
            this.lblDeliveredOrdersTitle.Size = new System.Drawing.Size(140, 25);
            this.lblDeliveredOrdersTitle.TabIndex = 1;
            this.lblDeliveredOrdersTitle.Text = "Delivered Orders";
            this.lblDeliveredOrdersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSearchFiltersContainer
            // 
            this.pnlSearchFiltersContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearchFiltersContainer.Controls.Add(this.pnlSearchFiltersCard);
            this.pnlSearchFiltersContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchFiltersContainer.Location = new System.Drawing.Point(20, 708);
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
            this.tblSearchFilters.ColumnCount = 3;
            this.tblSearchFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblSearchFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblSearchFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tblSearchFilters.Controls.Add(this.lblSearchCustomer, 0, 0);
            this.tblSearchFilters.Controls.Add(this.txtSearchCustomer, 0, 1);
            this.tblSearchFilters.Controls.Add(this.lblSearchOrderID, 1, 0);
            this.tblSearchFilters.Controls.Add(this.txtSearchOrderID, 1, 1);
            this.tblSearchFilters.Controls.Add(this.lblSearchStatus, 2, 0);
            this.tblSearchFilters.Controls.Add(this.cmbSearchStatus, 2, 1);
            this.tblSearchFilters.Controls.Add(this.pnlSearchButtons, 0, 2);
            this.tblSearchFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSearchFilters.Location = new System.Drawing.Point(15, 15);
            this.tblSearchFilters.Name = "tblSearchFilters";
            this.tblSearchFilters.RowCount = 3;
            this.tblSearchFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblSearchFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblSearchFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblSearchFilters.Size = new System.Drawing.Size(975, 115);
            this.tblSearchFilters.TabIndex = 0;
            // 
            // lblSearchCustomer
            // 
            this.lblSearchCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearchCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblSearchCustomer.Location = new System.Drawing.Point(3, 0);
            this.lblSearchCustomer.Name = "lblSearchCustomer";
            this.lblSearchCustomer.Size = new System.Drawing.Size(150, 22);
            this.lblSearchCustomer.TabIndex = 0;
            this.lblSearchCustomer.Text = "Search by Customer";
            this.lblSearchCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtSearchCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtSearchCustomer.Location = new System.Drawing.Point(3, 25);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(310, 23);
            this.txtSearchCustomer.TabIndex = 1;
            // 
            // lblSearchOrderID
            // 
            this.lblSearchOrderID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearchOrderID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblSearchOrderID.Location = new System.Drawing.Point(327, 0);
            this.lblSearchOrderID.Name = "lblSearchOrderID";
            this.lblSearchOrderID.Size = new System.Drawing.Size(150, 22);
            this.lblSearchOrderID.TabIndex = 2;
            this.lblSearchOrderID.Text = "Search by Order ID";
            this.lblSearchOrderID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearchOrderID
            // 
            this.txtSearchOrderID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtSearchOrderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchOrderID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtSearchOrderID.Location = new System.Drawing.Point(327, 25);
            this.txtSearchOrderID.Name = "txtSearchOrderID";
            this.txtSearchOrderID.Size = new System.Drawing.Size(310, 23);
            this.txtSearchOrderID.TabIndex = 3;
            // 
            // lblSearchStatus
            // 
            this.lblSearchStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearchStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblSearchStatus.Location = new System.Drawing.Point(651, 0);
            this.lblSearchStatus.Name = "lblSearchStatus";
            this.lblSearchStatus.Size = new System.Drawing.Size(150, 22);
            this.lblSearchStatus.TabIndex = 4;
            this.lblSearchStatus.Text = "Status";
            this.lblSearchStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSearchStatus
            // 
            this.cmbSearchStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbSearchStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSearchStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbSearchStatus.FormattingEnabled = true;
            this.cmbSearchStatus.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Ready for Pickup",
            "Delivered"});
            this.cmbSearchStatus.Location = new System.Drawing.Point(651, 25);
            this.cmbSearchStatus.Name = "cmbSearchStatus";
            this.cmbSearchStatus.Size = new System.Drawing.Size(320, 23);
            this.cmbSearchStatus.TabIndex = 5;
            // 
            // pnlSearchButtons
            // 
            this.pnlSearchButtons.BackColor = System.Drawing.Color.Transparent;
            this.tblSearchFilters.SetColumnSpan(this.pnlSearchButtons, 3);
            this.pnlSearchButtons.Controls.Add(this.btnSearch);
            this.pnlSearchButtons.Controls.Add(this.btnResetFilters);
            this.pnlSearchButtons.Controls.Add(this.btnRefreshResults);
            this.pnlSearchButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearchButtons.Location = new System.Drawing.Point(3, 57);
            this.pnlSearchButtons.Name = "pnlSearchButtons";
            this.pnlSearchButtons.Size = new System.Drawing.Size(969, 55);
            this.pnlSearchButtons.TabIndex = 6;
            this.pnlSearchButtons.WrapContents = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(3, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 26);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnResetFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetFilters.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnResetFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilters.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResetFilters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnResetFilters.Location = new System.Drawing.Point(109, 3);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(100, 26);
            this.btnResetFilters.TabIndex = 1;
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
            this.btnRefreshResults.Location = new System.Drawing.Point(215, 3);
            this.btnRefreshResults.Name = "btnRefreshResults";
            this.btnRefreshResults.Size = new System.Drawing.Size(100, 26);
            this.btnRefreshResults.TabIndex = 2;
            this.btnRefreshResults.Text = "Refresh";
            this.btnRefreshResults.UseVisualStyleBackColor = false;
            // 
            // pnlOrderGridContainer
            // 
            this.pnlOrderGridContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlOrderGridContainer.Controls.Add(this.pnlOrderGridCard);
            this.pnlOrderGridContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOrderGridContainer.Location = new System.Drawing.Point(20, 368);
            this.pnlOrderGridContainer.Name = "pnlOrderGridContainer";
            this.pnlOrderGridContainer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlOrderGridContainer.Size = new System.Drawing.Size(1005, 340);
            this.pnlOrderGridContainer.TabIndex = 3;
            // 
            // pnlOrderGridCard
            // 
            this.pnlOrderGridCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlOrderGridCard.Controls.Add(this.dgvOrders);
            this.pnlOrderGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderGridCard.Location = new System.Drawing.Point(0, 0);
            this.pnlOrderGridCard.Name = "pnlOrderGridCard";
            this.pnlOrderGridCard.Padding = new System.Windows.Forms.Padding(10);
            this.pnlOrderGridCard.Size = new System.Drawing.Size(1005, 330);
            this.pnlOrderGridCard.TabIndex = 0;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderID,
            this.colCustomer,
            this.colOrderDate,
            this.colItems,
            this.colTotal,
            this.colStatus,
            this.colPrescription});
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dgvOrders.Location = new System.Drawing.Point(10, 10);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.RowTemplate.Height = 30;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(985, 310);
            this.dgvOrders.TabIndex = 0;
            // 
            // colOrderID
            // 
            this.colOrderID.HeaderText = "Order ID";
            this.colOrderID.Name = "colOrderID";
            this.colOrderID.ReadOnly = true;
            this.colOrderID.Width = 80;
            // 
            // colCustomer
            // 
            this.colCustomer.HeaderText = "Customer";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.ReadOnly = true;
            this.colCustomer.Width = 140;
            // 
            // colOrderDate
            // 
            this.colOrderDate.HeaderText = "Order Date";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.ReadOnly = true;
            // 
            // colItems
            // 
            this.colItems.HeaderText = "Items";
            this.colItems.Name = "colItems";
            this.colItems.ReadOnly = true;
            this.colItems.Width = 60;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 80;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 120;
            // 
            // colPrescription
            // 
            this.colPrescription.HeaderText = "Prescription";
            this.colPrescription.Name = "colPrescription";
            this.colPrescription.ReadOnly = true;
            this.colPrescription.Width = 80;
            // 
            // pnlUpdateStatusContainer
            // 
            this.pnlUpdateStatusContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlUpdateStatusContainer.Controls.Add(this.pnlUpdateStatusCard);
            this.pnlUpdateStatusContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpdateStatusContainer.Location = new System.Drawing.Point(20, 98);
            this.pnlUpdateStatusContainer.Name = "pnlUpdateStatusContainer";
            this.pnlUpdateStatusContainer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlUpdateStatusContainer.Size = new System.Drawing.Size(1005, 270);
            this.pnlUpdateStatusContainer.TabIndex = 4;
            // 
            // pnlUpdateStatusCard
            // 
            this.pnlUpdateStatusCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlUpdateStatusCard.Controls.Add(this.tblUpdateStatus);
            this.pnlUpdateStatusCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUpdateStatusCard.Location = new System.Drawing.Point(0, 0);
            this.pnlUpdateStatusCard.Name = "pnlUpdateStatusCard";
            this.pnlUpdateStatusCard.Padding = new System.Windows.Forms.Padding(15);
            this.pnlUpdateStatusCard.Size = new System.Drawing.Size(1005, 260);
            this.pnlUpdateStatusCard.TabIndex = 0;
            // 
            // tblUpdateStatus
            // 
            this.tblUpdateStatus.BackColor = System.Drawing.Color.Transparent;
            this.tblUpdateStatus.ColumnCount = 2;
            this.tblUpdateStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblUpdateStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tblUpdateStatus.Controls.Add(this.lblSelectedOrder, 0, 0);
            this.tblUpdateStatus.Controls.Add(this.txtSelectedOrderID, 1, 0);
            this.tblUpdateStatus.Controls.Add(this.lblCurrentStatusCaption, 0, 1);
            this.tblUpdateStatus.Controls.Add(this.txtCurrentStatus, 1, 1);
            this.tblUpdateStatus.Controls.Add(this.lblNewStatusCaption, 0, 2);
            this.tblUpdateStatus.Controls.Add(this.cmbNewStatus, 1, 2);
            this.tblUpdateStatus.Controls.Add(this.btnUpdateOrderStatus, 1, 3);
            this.tblUpdateStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblUpdateStatus.Location = new System.Drawing.Point(15, 15);
            this.tblUpdateStatus.Name = "tblUpdateStatus";
            this.tblUpdateStatus.RowCount = 4;
            this.tblUpdateStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblUpdateStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblUpdateStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblUpdateStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblUpdateStatus.Size = new System.Drawing.Size(975, 230);
            this.tblUpdateStatus.TabIndex = 0;
            // 
            // lblSelectedOrder
            // 
            this.lblSelectedOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectedOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSelectedOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblSelectedOrder.Location = new System.Drawing.Point(3, 0);
            this.lblSelectedOrder.Name = "lblSelectedOrder";
            this.lblSelectedOrder.Size = new System.Drawing.Size(335, 40);
            this.lblSelectedOrder.TabIndex = 0;
            this.lblSelectedOrder.Text = "Selected Order";
            this.lblSelectedOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSelectedOrderID
            // 
            this.txtSelectedOrderID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtSelectedOrderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSelectedOrderID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtSelectedOrderID.Location = new System.Drawing.Point(344, 3);
            this.txtSelectedOrderID.Name = "txtSelectedOrderID";
            this.txtSelectedOrderID.ReadOnly = true;
            this.txtSelectedOrderID.Size = new System.Drawing.Size(380, 23);
            this.txtSelectedOrderID.TabIndex = 1;
            this.txtSelectedOrderID.TabStop = false;
            // 
            // lblCurrentStatusCaption
            // 
            this.lblCurrentStatusCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentStatusCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCurrentStatusCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblCurrentStatusCaption.Location = new System.Drawing.Point(3, 40);
            this.lblCurrentStatusCaption.Name = "lblCurrentStatusCaption";
            this.lblCurrentStatusCaption.Size = new System.Drawing.Size(335, 40);
            this.lblCurrentStatusCaption.TabIndex = 2;
            this.lblCurrentStatusCaption.Text = "Current Status";
            this.lblCurrentStatusCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCurrentStatus
            // 
            this.txtCurrentStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtCurrentStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtCurrentStatus.Location = new System.Drawing.Point(344, 43);
            this.txtCurrentStatus.Name = "txtCurrentStatus";
            this.txtCurrentStatus.ReadOnly = true;
            this.txtCurrentStatus.Size = new System.Drawing.Size(380, 23);
            this.txtCurrentStatus.TabIndex = 3;
            this.txtCurrentStatus.TabStop = false;
            // 
            // lblNewStatusCaption
            // 
            this.lblNewStatusCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNewStatusCaption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNewStatusCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblNewStatusCaption.Location = new System.Drawing.Point(3, 80);
            this.lblNewStatusCaption.Name = "lblNewStatusCaption";
            this.lblNewStatusCaption.Size = new System.Drawing.Size(335, 40);
            this.lblNewStatusCaption.TabIndex = 4;
            this.lblNewStatusCaption.Text = "New Status";
            this.lblNewStatusCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbNewStatus
            // 
            this.cmbNewStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbNewStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNewStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbNewStatus.FormattingEnabled = true;
            this.cmbNewStatus.Items.AddRange(new object[] {
            "Pending",
            "Ready for Pickup",
            "Delivered"});
            this.cmbNewStatus.Location = new System.Drawing.Point(344, 83);
            this.cmbNewStatus.Name = "cmbNewStatus";
            this.cmbNewStatus.Size = new System.Drawing.Size(380, 23);
            this.cmbNewStatus.TabIndex = 4;
            // 
            // btnUpdateOrderStatus
            // 
            this.btnUpdateOrderStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnUpdateOrderStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateOrderStatus.FlatAppearance.BorderSize = 0;
            this.btnUpdateOrderStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateOrderStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateOrderStatus.ForeColor = System.Drawing.Color.White;
            this.btnUpdateOrderStatus.Location = new System.Drawing.Point(344, 123);
            this.btnUpdateOrderStatus.Name = "btnUpdateOrderStatus";
            this.btnUpdateOrderStatus.Size = new System.Drawing.Size(120, 30);
            this.btnUpdateOrderStatus.TabIndex = 5;
            this.btnUpdateOrderStatus.Text = "Update Status";
            this.btnUpdateOrderStatus.UseVisualStyleBackColor = false;
            // 
            // pnlActionButtonsContainer
            // 
            this.pnlActionButtonsContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlActionButtonsContainer.Controls.Add(this.pnlActionButtonsCard);
            this.pnlActionButtonsContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActionButtonsContainer.Location = new System.Drawing.Point(20, 20);
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
            this.flpActionButtons.Controls.Add(this.btnViewItems);
            this.flpActionButtons.Controls.Add(this.btnClear);
            this.flpActionButtons.Controls.Add(this.btnRefresh);
            this.flpActionButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpActionButtons.Location = new System.Drawing.Point(15, 15);
            this.flpActionButtons.Name = "flpActionButtons";
            this.flpActionButtons.Size = new System.Drawing.Size(975, 38);
            this.flpActionButtons.TabIndex = 0;
            this.flpActionButtons.WrapContents = false;
            // 
            // btnViewItems
            // 
            this.btnViewItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnViewItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewItems.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnViewItems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnViewItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewItems.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnViewItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnViewItems.Location = new System.Drawing.Point(3, 3);
            this.btnViewItems.Name = "btnViewItems";
            this.btnViewItems.Size = new System.Drawing.Size(110, 32);
            this.btnViewItems.TabIndex = 0;
            this.btnViewItems.Text = "View Items";
            this.btnViewItems.UseVisualStyleBackColor = false;
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
            this.btnClear.Location = new System.Drawing.Point(119, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 32);
            this.btnClear.TabIndex = 1;
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
            this.btnRefresh.Location = new System.Drawing.Point(215, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 32);
            this.btnRefresh.TabIndex = 2;
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
            this.btnNavOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
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
            this.btnNavMedicines.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNavMedicines.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
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
            // OrderManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1302, 749);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "OrderManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartMed Pharmacy Management System - Order Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
            this.pnlSumTotalOrders.ResumeLayout(false);
            this.pnlSumPendingOrders.ResumeLayout(false);
            this.pnlSumReadyPickup.ResumeLayout(false);
            this.pnlSumDeliveredOrders.ResumeLayout(false);
            this.pnlSearchFiltersContainer.ResumeLayout(false);
            this.pnlSearchFiltersCard.ResumeLayout(false);
            this.tblSearchFilters.ResumeLayout(false);
            this.tblSearchFilters.PerformLayout();
            this.pnlSearchButtons.ResumeLayout(false);
            this.pnlOrderGridContainer.ResumeLayout(false);
            this.pnlOrderGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.pnlUpdateStatusContainer.ResumeLayout(false);
            this.pnlUpdateStatusCard.ResumeLayout(false);
            this.tblUpdateStatus.ResumeLayout(false);
            this.tblUpdateStatus.PerformLayout();
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

        // Page Header (1)
        private System.Windows.Forms.Panel pnlPageHeaderContainer;
        private System.Windows.Forms.Panel pnlPageHeaderCard;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageDescription;
        private System.Windows.Forms.Label lblBreadcrumb;

        // KPI Summary Cards (2)
        private System.Windows.Forms.Panel pnlSummaryContainer;
        private System.Windows.Forms.Panel pnlSummaryCard;
        private System.Windows.Forms.FlowLayoutPanel flpSummaryCards;
        private System.Windows.Forms.Panel pnlSumTotalOrders;
        private System.Windows.Forms.Label lblTotalOrdersValue;
        private System.Windows.Forms.Label lblTotalOrdersTitle;
        private System.Windows.Forms.Panel pnlSumPendingOrders;
        private System.Windows.Forms.Label lblPendingOrdersValue;
        private System.Windows.Forms.Label lblPendingOrdersTitle;
        private System.Windows.Forms.Panel pnlSumReadyPickup;
        private System.Windows.Forms.Label lblReadyPickupValue;
        private System.Windows.Forms.Label lblReadyPickupTitle;
        private System.Windows.Forms.Panel pnlSumDeliveredOrders;
        private System.Windows.Forms.Label lblDeliveredOrdersValue;
        private System.Windows.Forms.Label lblDeliveredOrdersTitle;

        // Search & Filters (3)
        private System.Windows.Forms.Panel pnlSearchFiltersContainer;
        private System.Windows.Forms.Panel pnlSearchFiltersCard;
        private System.Windows.Forms.TableLayoutPanel tblSearchFilters;
        private System.Windows.Forms.Label lblSearchCustomer;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Label lblSearchOrderID;
        private System.Windows.Forms.TextBox txtSearchOrderID;
        private System.Windows.Forms.Label lblSearchStatus;
        private System.Windows.Forms.ComboBox cmbSearchStatus;
        private System.Windows.Forms.FlowLayoutPanel pnlSearchButtons;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.Button btnRefreshResults;

        // Orders DataGrid (4)
        private System.Windows.Forms.Panel pnlOrderGridContainer;
        private System.Windows.Forms.Panel pnlOrderGridCard;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrescription;

        // Update Order Status form (5)
        private System.Windows.Forms.Panel pnlUpdateStatusContainer;
        private System.Windows.Forms.Panel pnlUpdateStatusCard;
        private System.Windows.Forms.TableLayoutPanel tblUpdateStatus;
        private System.Windows.Forms.Label lblSelectedOrder;
        private System.Windows.Forms.TextBox txtSelectedOrderID;
        private System.Windows.Forms.Label lblCurrentStatusCaption;
        private System.Windows.Forms.TextBox txtCurrentStatus;
        private System.Windows.Forms.Label lblNewStatusCaption;
        private System.Windows.Forms.ComboBox cmbNewStatus;
        private System.Windows.Forms.Button btnUpdateOrderStatus;

        // Action Buttons (6) – View Items, Clear, Refresh
        private System.Windows.Forms.Panel pnlActionButtonsContainer;
        private System.Windows.Forms.Panel pnlActionButtonsCard;
        private System.Windows.Forms.FlowLayoutPanel flpActionButtons;
        private System.Windows.Forms.Button btnViewItems;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;

        // Tooltip
        private System.Windows.Forms.ToolTip toolTipHints;
    }
}