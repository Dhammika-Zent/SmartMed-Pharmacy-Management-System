namespace SmartMed.Forms
{
    partial class AdminDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlContentArea = new System.Windows.Forms.Panel();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pnlWidgets = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRecentOrders = new System.Windows.Forms.Panel();
            this.dgvRecentOrders = new System.Windows.Forms.DataGridView();
            this.colOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRecentOrdersTitle = new System.Windows.Forms.Label();
            this.pnlRecentCustomers = new System.Windows.Forms.Panel();
            this.dgvRecentCustomers = new System.Windows.Forms.DataGridView();
            this.colCustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRecentCustomersTitle = new System.Windows.Forms.Label();
            this.pnlLowStock = new System.Windows.Forms.Panel();
            this.dgvLowStock = new System.Windows.Forms.DataGridView();
            this.colLowStockMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLowStockQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLowStockReorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLowStockTitle = new System.Windows.Forms.Label();
            this.pnlExpiryList = new System.Windows.Forms.Panel();
            this.dgvExpiryList = new System.Windows.Forms.DataGridView();
            this.colExpMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblExpiryListTitle = new System.Windows.Forms.Label();
            this.pnlSalesSummary = new System.Windows.Forms.Panel();
            this.lblSalesChartPlaceholder = new System.Windows.Forms.Label();
            this.lblSalesSummaryTitle = new System.Windows.Forms.Label();
            this.pnlQuickActions = new System.Windows.Forms.Panel();
            this.btnQuickLogout = new System.Windows.Forms.Button();
            this.btnQuickReports = new System.Windows.Forms.Button();
            this.btnQuickOrders = new System.Windows.Forms.Button();
            this.btnQuickCustomers = new System.Windows.Forms.Button();
            this.btnQuickMedicines = new System.Windows.Forms.Button();
            this.lblQuickActionsTitle = new System.Windows.Forms.Label();
            this.pnlKpiRow = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlKpiTotalSales = new System.Windows.Forms.Panel();
            this.lblKpiTotalSalesValue = new System.Windows.Forms.Label();
            this.lblKpiTotalSalesTitle = new System.Windows.Forms.Label();
            this.pnlKpiTotalMeds = new System.Windows.Forms.Panel();
            this.lblKpiTotalMedsValue = new System.Windows.Forms.Label();
            this.lblKpiTotalMedsTitle = new System.Windows.Forms.Label();
            this.pnlKpiRegCustomers = new System.Windows.Forms.Panel();
            this.lblKpiRegCustomersValue = new System.Windows.Forms.Label();
            this.lblKpiRegCustomersTitle = new System.Windows.Forms.Label();
            this.pnlKpiActiveOrders = new System.Windows.Forms.Panel();
            this.lblKpiActiveOrdersValue = new System.Windows.Forms.Label();
            this.lblKpiActiveOrdersTitle = new System.Windows.Forms.Label();
            this.pnlKpiLowStock = new System.Windows.Forms.Panel();
            this.lblKpiLowStockValue = new System.Windows.Forms.Label();
            this.lblKpiLowStockTitle = new System.Windows.Forms.Label();
            this.pnlKpiExpiring = new System.Windows.Forms.Panel();
            this.lblKpiExpiringValue = new System.Windows.Forms.Label();
            this.lblKpiExpiringTitle = new System.Windows.Forms.Label();
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
            this.pnlWidgets.SuspendLayout();
            this.pnlRecentOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentOrders)).BeginInit();
            this.pnlRecentCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentCustomers)).BeginInit();
            this.pnlLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).BeginInit();
            this.pnlExpiryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpiryList)).BeginInit();
            this.pnlSalesSummary.SuspendLayout();
            this.pnlQuickActions.SuspendLayout();
            this.pnlKpiRow.SuspendLayout();
            this.pnlKpiTotalSales.SuspendLayout();
            this.pnlKpiTotalMeds.SuspendLayout();
            this.pnlKpiRegCustomers.SuspendLayout();
            this.pnlKpiActiveOrders.SuspendLayout();
            this.pnlKpiLowStock.SuspendLayout();
            this.pnlKpiExpiring.SuspendLayout();
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
            this.pnlDashboard.Controls.Add(this.pnlWidgets);
            this.pnlDashboard.Controls.Add(this.pnlQuickActions);
            this.pnlDashboard.Controls.Add(this.pnlKpiRow);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 60);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Padding = new System.Windows.Forms.Padding(20);
            this.pnlDashboard.Size = new System.Drawing.Size(1062, 660);
            this.pnlDashboard.TabIndex = 1;
            // 
            // pnlWidgets
            // 
            this.pnlWidgets.AutoSize = true;
            this.pnlWidgets.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlWidgets.BackColor = System.Drawing.Color.Transparent;
            this.pnlWidgets.ColumnCount = 2;
            this.pnlWidgets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlWidgets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlWidgets.Controls.Add(this.pnlRecentOrders, 0, 0);
            this.pnlWidgets.Controls.Add(this.pnlRecentCustomers, 1, 0);
            this.pnlWidgets.Controls.Add(this.pnlLowStock, 0, 1);
            this.pnlWidgets.Controls.Add(this.pnlExpiryList, 1, 1);
            this.pnlWidgets.Controls.Add(this.pnlSalesSummary, 0, 2);
            this.pnlWidgets.Location = new System.Drawing.Point(20, 204);
            this.pnlWidgets.Name = "pnlWidgets";
            this.pnlWidgets.RowCount = 3;
            this.pnlWidgets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.pnlWidgets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            // *** CHANGED: increased the Sales Summary row height from 250 to 400 ***
            this.pnlWidgets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            // *** CHANGED: total height now 900 instead of 750 ***
            this.pnlWidgets.Size = new System.Drawing.Size(1022, 900);
            this.pnlWidgets.TabIndex = 2;
            // 
            // pnlRecentOrders
            // 
            this.pnlRecentOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlRecentOrders.Controls.Add(this.dgvRecentOrders);
            this.pnlRecentOrders.Controls.Add(this.lblRecentOrdersTitle);
            this.pnlRecentOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRecentOrders.Location = new System.Drawing.Point(3, 3);
            this.pnlRecentOrders.Name = "pnlRecentOrders";
            this.pnlRecentOrders.Padding = new System.Windows.Forms.Padding(10);
            this.pnlRecentOrders.Size = new System.Drawing.Size(505, 244);
            this.pnlRecentOrders.TabIndex = 0;
            // 
            // dgvRecentOrders
            // 
            this.dgvRecentOrders.AllowUserToAddRows = false;
            this.dgvRecentOrders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRecentOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecentOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvRecentOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRecentOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderID,
            this.colOrderCustomer,
            this.colOrderDate,
            this.colOrderTotal,
            this.colOrderStatus});
            this.dgvRecentOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecentOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dgvRecentOrders.Location = new System.Drawing.Point(10, 35);
            this.dgvRecentOrders.Name = "dgvRecentOrders";
            this.dgvRecentOrders.ReadOnly = true;
            this.dgvRecentOrders.RowHeadersVisible = false;
            this.dgvRecentOrders.RowTemplate.Height = 30;
            this.dgvRecentOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentOrders.Size = new System.Drawing.Size(485, 199);
            this.dgvRecentOrders.TabIndex = 1;
            // 
            // colOrderID
            // 
            this.colOrderID.HeaderText = "Order ID";
            this.colOrderID.Name = "colOrderID";
            this.colOrderID.ReadOnly = true;
            this.colOrderID.Width = 80;
            // 
            // colOrderCustomer
            // 
            this.colOrderCustomer.HeaderText = "Customer";
            this.colOrderCustomer.Name = "colOrderCustomer";
            this.colOrderCustomer.ReadOnly = true;
            this.colOrderCustomer.Width = 130;
            // 
            // colOrderDate
            // 
            this.colOrderDate.HeaderText = "Date";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.ReadOnly = true;
            // 
            // colOrderTotal
            // 
            this.colOrderTotal.HeaderText = "Total";
            this.colOrderTotal.Name = "colOrderTotal";
            this.colOrderTotal.ReadOnly = true;
            this.colOrderTotal.Width = 80;
            // 
            // colOrderStatus
            // 
            this.colOrderStatus.HeaderText = "Status";
            this.colOrderStatus.Name = "colOrderStatus";
            this.colOrderStatus.ReadOnly = true;
            // 
            // lblRecentOrdersTitle
            // 
            this.lblRecentOrdersTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRecentOrdersTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecentOrdersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblRecentOrdersTitle.Location = new System.Drawing.Point(10, 10);
            this.lblRecentOrdersTitle.Name = "lblRecentOrdersTitle";
            this.lblRecentOrdersTitle.Size = new System.Drawing.Size(485, 25);
            this.lblRecentOrdersTitle.TabIndex = 0;
            this.lblRecentOrdersTitle.Text = "Recent Orders";
            // 
            // pnlRecentCustomers
            // 
            this.pnlRecentCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlRecentCustomers.Controls.Add(this.dgvRecentCustomers);
            this.pnlRecentCustomers.Controls.Add(this.lblRecentCustomersTitle);
            this.pnlRecentCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRecentCustomers.Location = new System.Drawing.Point(514, 3);
            this.pnlRecentCustomers.Name = "pnlRecentCustomers";
            this.pnlRecentCustomers.Padding = new System.Windows.Forms.Padding(10);
            this.pnlRecentCustomers.Size = new System.Drawing.Size(505, 244);
            this.pnlRecentCustomers.TabIndex = 1;
            // 
            // dgvRecentCustomers
            // 
            this.dgvRecentCustomers.AllowUserToAddRows = false;
            this.dgvRecentCustomers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRecentCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecentCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvRecentCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRecentCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustID,
            this.colCustName,
            this.colCustPhone,
            this.colCustEmail});
            this.dgvRecentCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecentCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dgvRecentCustomers.Location = new System.Drawing.Point(10, 35);
            this.dgvRecentCustomers.Name = "dgvRecentCustomers";
            this.dgvRecentCustomers.ReadOnly = true;
            this.dgvRecentCustomers.RowHeadersVisible = false;
            this.dgvRecentCustomers.RowTemplate.Height = 30;
            this.dgvRecentCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentCustomers.Size = new System.Drawing.Size(485, 199);
            this.dgvRecentCustomers.TabIndex = 1;
            // 
            // colCustID
            // 
            this.colCustID.HeaderText = "ID";
            this.colCustID.Name = "colCustID";
            this.colCustID.ReadOnly = true;
            this.colCustID.Width = 50;
            // 
            // colCustName
            // 
            this.colCustName.HeaderText = "Name";
            this.colCustName.Name = "colCustName";
            this.colCustName.ReadOnly = true;
            this.colCustName.Width = 160;
            // 
            // colCustPhone
            // 
            this.colCustPhone.HeaderText = "Phone";
            this.colCustPhone.Name = "colCustPhone";
            this.colCustPhone.ReadOnly = true;
            this.colCustPhone.Width = 120;
            // 
            // colCustEmail
            // 
            this.colCustEmail.HeaderText = "Email";
            this.colCustEmail.Name = "colCustEmail";
            this.colCustEmail.ReadOnly = true;
            this.colCustEmail.Width = 180;
            // 
            // lblRecentCustomersTitle
            // 
            this.lblRecentCustomersTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRecentCustomersTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecentCustomersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblRecentCustomersTitle.Location = new System.Drawing.Point(10, 10);
            this.lblRecentCustomersTitle.Name = "lblRecentCustomersTitle";
            this.lblRecentCustomersTitle.Size = new System.Drawing.Size(485, 25);
            this.lblRecentCustomersTitle.TabIndex = 0;
            this.lblRecentCustomersTitle.Text = "Recent Customers";
            // 
            // pnlLowStock
            // 
            this.pnlLowStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlLowStock.Controls.Add(this.dgvLowStock);
            this.pnlLowStock.Controls.Add(this.lblLowStockTitle);
            this.pnlLowStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLowStock.Location = new System.Drawing.Point(3, 253);
            this.pnlLowStock.Name = "pnlLowStock";
            this.pnlLowStock.Padding = new System.Windows.Forms.Padding(10);
            this.pnlLowStock.Size = new System.Drawing.Size(505, 244);
            this.pnlLowStock.TabIndex = 2;
            // 
            // dgvLowStock
            // 
            this.dgvLowStock.AllowUserToAddRows = false;
            this.dgvLowStock.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLowStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLowStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvLowStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLowStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLowStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLowStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLowStockMed,
            this.colLowStockQty,
            this.colLowStockReorder});
            this.dgvLowStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLowStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dgvLowStock.Location = new System.Drawing.Point(10, 35);
            this.dgvLowStock.Name = "dgvLowStock";
            this.dgvLowStock.ReadOnly = true;
            this.dgvLowStock.RowHeadersVisible = false;
            this.dgvLowStock.RowTemplate.Height = 30;
            this.dgvLowStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLowStock.Size = new System.Drawing.Size(485, 199);
            this.dgvLowStock.TabIndex = 1;
            // 
            // colLowStockMed
            // 
            this.colLowStockMed.HeaderText = "Medicine";
            this.colLowStockMed.Name = "colLowStockMed";
            this.colLowStockMed.ReadOnly = true;
            this.colLowStockMed.Width = 200;
            // 
            // colLowStockQty
            // 
            this.colLowStockQty.HeaderText = "Stock";
            this.colLowStockQty.Name = "colLowStockQty";
            this.colLowStockQty.ReadOnly = true;
            // 
            // colLowStockReorder
            // 
            this.colLowStockReorder.HeaderText = "Reorder Level";
            this.colLowStockReorder.Name = "colLowStockReorder";
            this.colLowStockReorder.ReadOnly = true;
            this.colLowStockReorder.Width = 120;
            // 
            // lblLowStockTitle
            // 
            this.lblLowStockTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLowStockTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblLowStockTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblLowStockTitle.Location = new System.Drawing.Point(10, 10);
            this.lblLowStockTitle.Name = "lblLowStockTitle";
            this.lblLowStockTitle.Size = new System.Drawing.Size(485, 25);
            this.lblLowStockTitle.TabIndex = 0;
            this.lblLowStockTitle.Text = "Low Stock Medicines";
            // 
            // pnlExpiryList
            // 
            this.pnlExpiryList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlExpiryList.Controls.Add(this.dgvExpiryList);
            this.pnlExpiryList.Controls.Add(this.lblExpiryListTitle);
            this.pnlExpiryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExpiryList.Location = new System.Drawing.Point(514, 253);
            this.pnlExpiryList.Name = "pnlExpiryList";
            this.pnlExpiryList.Padding = new System.Windows.Forms.Padding(10);
            this.pnlExpiryList.Size = new System.Drawing.Size(505, 244);
            this.pnlExpiryList.TabIndex = 3;
            // 
            // dgvExpiryList
            // 
            this.dgvExpiryList.AllowUserToAddRows = false;
            this.dgvExpiryList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvExpiryList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExpiryList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvExpiryList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExpiryList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvExpiryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpiryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colExpMed,
            this.colExpBatch,
            this.colExpDate,
            this.colExpQty});
            this.dgvExpiryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpiryList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dgvExpiryList.Location = new System.Drawing.Point(10, 35);
            this.dgvExpiryList.Name = "dgvExpiryList";
            this.dgvExpiryList.ReadOnly = true;
            this.dgvExpiryList.RowHeadersVisible = false;
            this.dgvExpiryList.RowTemplate.Height = 30;
            this.dgvExpiryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpiryList.Size = new System.Drawing.Size(485, 199);
            this.dgvExpiryList.TabIndex = 1;
            // 
            // colExpMed
            // 
            this.colExpMed.HeaderText = "Medicine";
            this.colExpMed.Name = "colExpMed";
            this.colExpMed.ReadOnly = true;
            this.colExpMed.Width = 180;
            // 
            // colExpBatch
            // 
            this.colExpBatch.HeaderText = "Batch";
            this.colExpBatch.Name = "colExpBatch";
            this.colExpBatch.ReadOnly = true;
            // 
            // colExpDate
            // 
            this.colExpDate.HeaderText = "Expiry Date";
            this.colExpDate.Name = "colExpDate";
            this.colExpDate.ReadOnly = true;
            this.colExpDate.Width = 120;
            // 
            // colExpQty
            // 
            this.colExpQty.HeaderText = "Quantity";
            this.colExpQty.Name = "colExpQty";
            this.colExpQty.ReadOnly = true;
            this.colExpQty.Width = 80;
            // 
            // lblExpiryListTitle
            // 
            this.lblExpiryListTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblExpiryListTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblExpiryListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblExpiryListTitle.Location = new System.Drawing.Point(10, 10);
            this.lblExpiryListTitle.Name = "lblExpiryListTitle";
            this.lblExpiryListTitle.Size = new System.Drawing.Size(485, 25);
            this.lblExpiryListTitle.TabIndex = 0;
            this.lblExpiryListTitle.Text = "Expiring Medicines";
            // 
            // pnlSalesSummary
            // 
            this.pnlSalesSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlWidgets.SetColumnSpan(this.pnlSalesSummary, 2);
            this.pnlSalesSummary.Controls.Add(this.lblSalesChartPlaceholder);
            this.pnlSalesSummary.Controls.Add(this.lblSalesSummaryTitle);
            this.pnlSalesSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSalesSummary.Location = new System.Drawing.Point(3, 503);
            this.pnlSalesSummary.Name = "pnlSalesSummary";
            this.pnlSalesSummary.Padding = new System.Windows.Forms.Padding(10);
            // *** Size is now automatically 1016 x 394 because row height = 400 ***
            this.pnlSalesSummary.Size = new System.Drawing.Size(1016, 394);
            this.pnlSalesSummary.TabIndex = 4;
            // 
            // lblSalesChartPlaceholder
            // 
            this.lblSalesChartPlaceholder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSalesChartPlaceholder.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSalesChartPlaceholder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblSalesChartPlaceholder.Location = new System.Drawing.Point(10, 35);
            this.lblSalesChartPlaceholder.Name = "lblSalesChartPlaceholder";
            // *** Height adjusted automatically by docking ***
            this.lblSalesChartPlaceholder.Size = new System.Drawing.Size(996, 349);
            this.lblSalesChartPlaceholder.TabIndex = 1;
            this.lblSalesChartPlaceholder.Text = "📈 Sales chart will be displayed here";
            this.lblSalesChartPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSalesSummaryTitle
            // 
            this.lblSalesSummaryTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSalesSummaryTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblSalesSummaryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblSalesSummaryTitle.Location = new System.Drawing.Point(10, 10);
            this.lblSalesSummaryTitle.Name = "lblSalesSummaryTitle";
            this.lblSalesSummaryTitle.Size = new System.Drawing.Size(996, 25);
            this.lblSalesSummaryTitle.TabIndex = 0;
            this.lblSalesSummaryTitle.Text = "Sales Summary";
            // 
            // pnlQuickActions
            // 
            this.pnlQuickActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlQuickActions.Controls.Add(this.btnQuickLogout);
            this.pnlQuickActions.Controls.Add(this.btnQuickReports);
            this.pnlQuickActions.Controls.Add(this.btnQuickOrders);
            this.pnlQuickActions.Controls.Add(this.btnQuickCustomers);
            this.pnlQuickActions.Controls.Add(this.btnQuickMedicines);
            this.pnlQuickActions.Controls.Add(this.lblQuickActionsTitle);
            this.pnlQuickActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuickActions.Location = new System.Drawing.Point(20, 146);
            this.pnlQuickActions.Name = "pnlQuickActions";
            this.pnlQuickActions.Size = new System.Drawing.Size(1005, 58);
            this.pnlQuickActions.TabIndex = 1;
            // 
            // btnQuickLogout
            // 
            this.btnQuickLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuickLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnQuickLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuickLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnQuickLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuickLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnQuickLogout.Location = new System.Drawing.Point(890, 14);
            this.btnQuickLogout.Name = "btnQuickLogout";
            this.btnQuickLogout.Size = new System.Drawing.Size(90, 32);
            this.btnQuickLogout.TabIndex = 6;
            this.btnQuickLogout.Text = "Logout";
            this.btnQuickLogout.UseVisualStyleBackColor = false;
            // 
            // btnQuickReports
            // 
            this.btnQuickReports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuickReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnQuickReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuickReports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnQuickReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickReports.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuickReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnQuickReports.Location = new System.Drawing.Point(790, 14);
            this.btnQuickReports.Name = "btnQuickReports";
            this.btnQuickReports.Size = new System.Drawing.Size(90, 32);
            this.btnQuickReports.TabIndex = 5;
            this.btnQuickReports.Text = "Reports";
            this.btnQuickReports.UseVisualStyleBackColor = false;
            // 
            // btnQuickOrders
            // 
            this.btnQuickOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuickOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnQuickOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuickOrders.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnQuickOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuickOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnQuickOrders.Location = new System.Drawing.Point(690, 14);
            this.btnQuickOrders.Name = "btnQuickOrders";
            this.btnQuickOrders.Size = new System.Drawing.Size(90, 32);
            this.btnQuickOrders.TabIndex = 4;
            this.btnQuickOrders.Text = "Orders";
            this.btnQuickOrders.UseVisualStyleBackColor = false;
            // 
            // btnQuickCustomers
            // 
            this.btnQuickCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuickCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnQuickCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuickCustomers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnQuickCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickCustomers.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuickCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnQuickCustomers.Location = new System.Drawing.Point(590, 14);
            this.btnQuickCustomers.Name = "btnQuickCustomers";
            this.btnQuickCustomers.Size = new System.Drawing.Size(90, 32);
            this.btnQuickCustomers.TabIndex = 3;
            this.btnQuickCustomers.Text = "Customers";
            this.btnQuickCustomers.UseVisualStyleBackColor = false;
            // 
            // btnQuickMedicines
            // 
            this.btnQuickMedicines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuickMedicines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnQuickMedicines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuickMedicines.FlatAppearance.BorderSize = 0;
            this.btnQuickMedicines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickMedicines.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuickMedicines.ForeColor = System.Drawing.Color.White;
            this.btnQuickMedicines.Location = new System.Drawing.Point(490, 14);
            this.btnQuickMedicines.Name = "btnQuickMedicines";
            this.btnQuickMedicines.Size = new System.Drawing.Size(90, 32);
            this.btnQuickMedicines.TabIndex = 2;
            this.btnQuickMedicines.Text = "Medicines";
            this.btnQuickMedicines.UseVisualStyleBackColor = false;
            // 
            // lblQuickActionsTitle
            // 
            this.lblQuickActionsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblQuickActionsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblQuickActionsTitle.Location = new System.Drawing.Point(13, 14);
            this.lblQuickActionsTitle.Name = "lblQuickActionsTitle";
            this.lblQuickActionsTitle.Size = new System.Drawing.Size(120, 30);
            this.lblQuickActionsTitle.TabIndex = 0;
            this.lblQuickActionsTitle.Text = "Quick Actions";
            this.lblQuickActionsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlKpiRow
            // 
            this.pnlKpiRow.AutoSize = true;
            this.pnlKpiRow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlKpiRow.BackColor = System.Drawing.Color.Transparent;
            this.pnlKpiRow.Controls.Add(this.pnlKpiTotalSales);
            this.pnlKpiRow.Controls.Add(this.pnlKpiTotalMeds);
            this.pnlKpiRow.Controls.Add(this.pnlKpiRegCustomers);
            this.pnlKpiRow.Controls.Add(this.pnlKpiActiveOrders);
            this.pnlKpiRow.Controls.Add(this.pnlKpiLowStock);
            this.pnlKpiRow.Controls.Add(this.pnlKpiExpiring);
            this.pnlKpiRow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKpiRow.Location = new System.Drawing.Point(20, 20);
            this.pnlKpiRow.Name = "pnlKpiRow";
            this.pnlKpiRow.Size = new System.Drawing.Size(1005, 126);
            this.pnlKpiRow.TabIndex = 0;
            // 
            // pnlKpiTotalSales
            // 
            this.pnlKpiTotalSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlKpiTotalSales.Controls.Add(this.lblKpiTotalSalesValue);
            this.pnlKpiTotalSales.Controls.Add(this.lblKpiTotalSalesTitle);
            this.pnlKpiTotalSales.Location = new System.Drawing.Point(3, 3);
            this.pnlKpiTotalSales.Name = "pnlKpiTotalSales";
            this.pnlKpiTotalSales.Padding = new System.Windows.Forms.Padding(10);
            this.pnlKpiTotalSales.Size = new System.Drawing.Size(160, 120);
            this.pnlKpiTotalSales.TabIndex = 0;
            // 
            // lblKpiTotalSalesValue
            // 
            this.lblKpiTotalSalesValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKpiTotalSalesValue.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblKpiTotalSalesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblKpiTotalSalesValue.Location = new System.Drawing.Point(10, 10);
            this.lblKpiTotalSalesValue.Name = "lblKpiTotalSalesValue";
            this.lblKpiTotalSalesValue.Size = new System.Drawing.Size(140, 75);
            this.lblKpiTotalSalesValue.TabIndex = 0;
            this.lblKpiTotalSalesValue.Text = "0";
            this.lblKpiTotalSalesValue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblKpiTotalSalesTitle
            // 
            this.lblKpiTotalSalesTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblKpiTotalSalesTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKpiTotalSalesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblKpiTotalSalesTitle.Location = new System.Drawing.Point(10, 85);
            this.lblKpiTotalSalesTitle.Name = "lblKpiTotalSalesTitle";
            this.lblKpiTotalSalesTitle.Size = new System.Drawing.Size(140, 25);
            this.lblKpiTotalSalesTitle.TabIndex = 1;
            this.lblKpiTotalSalesTitle.Text = "Total Sales";
            this.lblKpiTotalSalesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlKpiTotalMeds
            // 
            this.pnlKpiTotalMeds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlKpiTotalMeds.Controls.Add(this.lblKpiTotalMedsValue);
            this.pnlKpiTotalMeds.Controls.Add(this.lblKpiTotalMedsTitle);
            this.pnlKpiTotalMeds.Location = new System.Drawing.Point(169, 3);
            this.pnlKpiTotalMeds.Name = "pnlKpiTotalMeds";
            this.pnlKpiTotalMeds.Padding = new System.Windows.Forms.Padding(10);
            this.pnlKpiTotalMeds.Size = new System.Drawing.Size(160, 120);
            this.pnlKpiTotalMeds.TabIndex = 1;
            // 
            // lblKpiTotalMedsValue
            // 
            this.lblKpiTotalMedsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKpiTotalMedsValue.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblKpiTotalMedsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblKpiTotalMedsValue.Location = new System.Drawing.Point(10, 10);
            this.lblKpiTotalMedsValue.Name = "lblKpiTotalMedsValue";
            this.lblKpiTotalMedsValue.Size = new System.Drawing.Size(140, 75);
            this.lblKpiTotalMedsValue.TabIndex = 0;
            this.lblKpiTotalMedsValue.Text = "0";
            this.lblKpiTotalMedsValue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblKpiTotalMedsTitle
            // 
            this.lblKpiTotalMedsTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblKpiTotalMedsTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKpiTotalMedsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblKpiTotalMedsTitle.Location = new System.Drawing.Point(10, 85);
            this.lblKpiTotalMedsTitle.Name = "lblKpiTotalMedsTitle";
            this.lblKpiTotalMedsTitle.Size = new System.Drawing.Size(140, 25);
            this.lblKpiTotalMedsTitle.TabIndex = 1;
            this.lblKpiTotalMedsTitle.Text = "Total Medicines";
            this.lblKpiTotalMedsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlKpiRegCustomers
            // 
            this.pnlKpiRegCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlKpiRegCustomers.Controls.Add(this.lblKpiRegCustomersValue);
            this.pnlKpiRegCustomers.Controls.Add(this.lblKpiRegCustomersTitle);
            this.pnlKpiRegCustomers.Location = new System.Drawing.Point(335, 3);
            this.pnlKpiRegCustomers.Name = "pnlKpiRegCustomers";
            this.pnlKpiRegCustomers.Padding = new System.Windows.Forms.Padding(10);
            this.pnlKpiRegCustomers.Size = new System.Drawing.Size(160, 120);
            this.pnlKpiRegCustomers.TabIndex = 2;
            // 
            // lblKpiRegCustomersValue
            // 
            this.lblKpiRegCustomersValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKpiRegCustomersValue.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblKpiRegCustomersValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblKpiRegCustomersValue.Location = new System.Drawing.Point(10, 10);
            this.lblKpiRegCustomersValue.Name = "lblKpiRegCustomersValue";
            this.lblKpiRegCustomersValue.Size = new System.Drawing.Size(140, 75);
            this.lblKpiRegCustomersValue.TabIndex = 0;
            this.lblKpiRegCustomersValue.Text = "0";
            this.lblKpiRegCustomersValue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblKpiRegCustomersTitle
            // 
            this.lblKpiRegCustomersTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblKpiRegCustomersTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKpiRegCustomersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblKpiRegCustomersTitle.Location = new System.Drawing.Point(10, 85);
            this.lblKpiRegCustomersTitle.Name = "lblKpiRegCustomersTitle";
            this.lblKpiRegCustomersTitle.Size = new System.Drawing.Size(140, 25);
            this.lblKpiRegCustomersTitle.TabIndex = 1;
            this.lblKpiRegCustomersTitle.Text = "Reg. Customers";
            this.lblKpiRegCustomersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlKpiActiveOrders
            // 
            this.pnlKpiActiveOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlKpiActiveOrders.Controls.Add(this.lblKpiActiveOrdersValue);
            this.pnlKpiActiveOrders.Controls.Add(this.lblKpiActiveOrdersTitle);
            this.pnlKpiActiveOrders.Location = new System.Drawing.Point(501, 3);
            this.pnlKpiActiveOrders.Name = "pnlKpiActiveOrders";
            this.pnlKpiActiveOrders.Padding = new System.Windows.Forms.Padding(10);
            this.pnlKpiActiveOrders.Size = new System.Drawing.Size(160, 120);
            this.pnlKpiActiveOrders.TabIndex = 3;
            // 
            // lblKpiActiveOrdersValue
            // 
            this.lblKpiActiveOrdersValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKpiActiveOrdersValue.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblKpiActiveOrdersValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblKpiActiveOrdersValue.Location = new System.Drawing.Point(10, 10);
            this.lblKpiActiveOrdersValue.Name = "lblKpiActiveOrdersValue";
            this.lblKpiActiveOrdersValue.Size = new System.Drawing.Size(140, 75);
            this.lblKpiActiveOrdersValue.TabIndex = 0;
            this.lblKpiActiveOrdersValue.Text = "0";
            this.lblKpiActiveOrdersValue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblKpiActiveOrdersTitle
            // 
            this.lblKpiActiveOrdersTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblKpiActiveOrdersTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKpiActiveOrdersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblKpiActiveOrdersTitle.Location = new System.Drawing.Point(10, 85);
            this.lblKpiActiveOrdersTitle.Name = "lblKpiActiveOrdersTitle";
            this.lblKpiActiveOrdersTitle.Size = new System.Drawing.Size(140, 25);
            this.lblKpiActiveOrdersTitle.TabIndex = 1;
            this.lblKpiActiveOrdersTitle.Text = "Active Orders";
            this.lblKpiActiveOrdersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlKpiLowStock
            // 
            this.pnlKpiLowStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlKpiLowStock.Controls.Add(this.lblKpiLowStockValue);
            this.pnlKpiLowStock.Controls.Add(this.lblKpiLowStockTitle);
            this.pnlKpiLowStock.Location = new System.Drawing.Point(667, 3);
            this.pnlKpiLowStock.Name = "pnlKpiLowStock";
            this.pnlKpiLowStock.Padding = new System.Windows.Forms.Padding(10);
            this.pnlKpiLowStock.Size = new System.Drawing.Size(160, 120);
            this.pnlKpiLowStock.TabIndex = 4;
            // 
            // lblKpiLowStockValue
            // 
            this.lblKpiLowStockValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKpiLowStockValue.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblKpiLowStockValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblKpiLowStockValue.Location = new System.Drawing.Point(10, 10);
            this.lblKpiLowStockValue.Name = "lblKpiLowStockValue";
            this.lblKpiLowStockValue.Size = new System.Drawing.Size(140, 75);
            this.lblKpiLowStockValue.TabIndex = 0;
            this.lblKpiLowStockValue.Text = "0";
            this.lblKpiLowStockValue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblKpiLowStockTitle
            // 
            this.lblKpiLowStockTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblKpiLowStockTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKpiLowStockTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblKpiLowStockTitle.Location = new System.Drawing.Point(10, 85);
            this.lblKpiLowStockTitle.Name = "lblKpiLowStockTitle";
            this.lblKpiLowStockTitle.Size = new System.Drawing.Size(140, 25);
            this.lblKpiLowStockTitle.TabIndex = 1;
            this.lblKpiLowStockTitle.Text = "Low Stock";
            this.lblKpiLowStockTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlKpiExpiring
            // 
            this.pnlKpiExpiring.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlKpiExpiring.Controls.Add(this.lblKpiExpiringValue);
            this.pnlKpiExpiring.Controls.Add(this.lblKpiExpiringTitle);
            this.pnlKpiExpiring.Location = new System.Drawing.Point(833, 3);
            this.pnlKpiExpiring.Name = "pnlKpiExpiring";
            this.pnlKpiExpiring.Padding = new System.Windows.Forms.Padding(10);
            this.pnlKpiExpiring.Size = new System.Drawing.Size(169, 120);
            this.pnlKpiExpiring.TabIndex = 5;
            // 
            // lblKpiExpiringValue
            // 
            this.lblKpiExpiringValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKpiExpiringValue.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblKpiExpiringValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblKpiExpiringValue.Location = new System.Drawing.Point(10, 10);
            this.lblKpiExpiringValue.Name = "lblKpiExpiringValue";
            this.lblKpiExpiringValue.Size = new System.Drawing.Size(149, 75);
            this.lblKpiExpiringValue.TabIndex = 0;
            this.lblKpiExpiringValue.Text = "0";
            this.lblKpiExpiringValue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblKpiExpiringTitle
            // 
            this.lblKpiExpiringTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblKpiExpiringTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKpiExpiringTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblKpiExpiringTitle.Location = new System.Drawing.Point(10, 85);
            this.lblKpiExpiringTitle.Name = "lblKpiExpiringTitle";
            this.lblKpiExpiringTitle.Size = new System.Drawing.Size(149, 25);
            this.lblKpiExpiringTitle.TabIndex = 1;
            this.lblKpiExpiringTitle.Text = "Expiring Meds";
            this.lblKpiExpiringTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pnlNav.Controls.Add(this.btnNavReports);
            this.pnlNav.Controls.Add(this.btnNavOrders);
            this.pnlNav.Controls.Add(this.btnNavCustomers);
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
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1302, 720);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartMed Pharmacy Management System - Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMain.ResumeLayout(false);
            this.pnlContentArea.ResumeLayout(false);
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlWidgets.ResumeLayout(false);
            this.pnlRecentOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentOrders)).EndInit();
            this.pnlRecentCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentCustomers)).EndInit();
            this.pnlLowStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).EndInit();
            this.pnlExpiryList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpiryList)).EndInit();
            this.pnlSalesSummary.ResumeLayout(false);
            this.pnlQuickActions.ResumeLayout(false);
            this.pnlKpiRow.ResumeLayout(false);
            this.pnlKpiTotalSales.ResumeLayout(false);
            this.pnlKpiTotalMeds.ResumeLayout(false);
            this.pnlKpiRegCustomers.ResumeLayout(false);
            this.pnlKpiActiveOrders.ResumeLayout(false);
            this.pnlKpiLowStock.ResumeLayout(false);
            this.pnlKpiExpiring.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlContentArea;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox picUserAvatar;
        private System.Windows.Forms.Label btnLogoutIcon;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.FlowLayoutPanel pnlKpiRow;
        private System.Windows.Forms.Panel pnlKpiTotalSales;
        private System.Windows.Forms.Label lblKpiTotalSalesValue;
        private System.Windows.Forms.Label lblKpiTotalSalesTitle;
        private System.Windows.Forms.Panel pnlKpiTotalMeds;
        private System.Windows.Forms.Label lblKpiTotalMedsValue;
        private System.Windows.Forms.Label lblKpiTotalMedsTitle;
        private System.Windows.Forms.Panel pnlKpiRegCustomers;
        private System.Windows.Forms.Label lblKpiRegCustomersValue;
        private System.Windows.Forms.Label lblKpiRegCustomersTitle;
        private System.Windows.Forms.Panel pnlKpiActiveOrders;
        private System.Windows.Forms.Label lblKpiActiveOrdersValue;
        private System.Windows.Forms.Label lblKpiActiveOrdersTitle;
        private System.Windows.Forms.Panel pnlKpiLowStock;
        private System.Windows.Forms.Label lblKpiLowStockValue;
        private System.Windows.Forms.Label lblKpiLowStockTitle;
        private System.Windows.Forms.Panel pnlKpiExpiring;
        private System.Windows.Forms.Label lblKpiExpiringValue;
        private System.Windows.Forms.Label lblKpiExpiringTitle;
        private System.Windows.Forms.Panel pnlQuickActions;
        private System.Windows.Forms.Label lblQuickActionsTitle;
        private System.Windows.Forms.Button btnQuickMedicines;
        private System.Windows.Forms.Button btnQuickCustomers;
        private System.Windows.Forms.Button btnQuickOrders;
        private System.Windows.Forms.Button btnQuickReports;
        private System.Windows.Forms.Button btnQuickLogout;
        private System.Windows.Forms.TableLayoutPanel pnlWidgets;
        private System.Windows.Forms.Panel pnlRecentOrders;
        private System.Windows.Forms.Label lblRecentOrdersTitle;
        private System.Windows.Forms.DataGridView dgvRecentOrders;
        private System.Windows.Forms.Panel pnlRecentCustomers;
        private System.Windows.Forms.Label lblRecentCustomersTitle;
        private System.Windows.Forms.DataGridView dgvRecentCustomers;
        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.Label lblLowStockTitle;
        private System.Windows.Forms.DataGridView dgvLowStock;
        private System.Windows.Forms.Panel pnlExpiryList;
        private System.Windows.Forms.Label lblExpiryListTitle;
        private System.Windows.Forms.DataGridView dgvExpiryList;
        private System.Windows.Forms.Panel pnlSalesSummary;
        private System.Windows.Forms.Label lblSalesSummaryTitle;
        private System.Windows.Forms.Label lblSalesChartPlaceholder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLowStockMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLowStockQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLowStockReorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpQty;
        private System.Windows.Forms.ToolTip toolTipHints;
    }
}