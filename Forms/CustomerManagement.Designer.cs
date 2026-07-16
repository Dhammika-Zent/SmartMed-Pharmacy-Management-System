namespace SmartMed.Forms
{
    partial class CustomerManagement
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlContentArea = new System.Windows.Forms.Panel();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pnlDashboardContent = new System.Windows.Forms.Panel();
            this.pnlActionButtonsContainer = new System.Windows.Forms.Panel();
            this.pnlActionButtonsCard = new System.Windows.Forms.Panel();
            this.flpActionButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlCustomerDetailsContainer = new System.Windows.Forms.Panel();
            this.pnlCustomerDetailsCard = new System.Windows.Forms.Panel();
            this.tblCustomerDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblRegisteredDate = new System.Windows.Forms.Label();
            this.dtpRegisteredDate = new System.Windows.Forms.DateTimePicker();
            this.pnlCustomerGridContainer = new System.Windows.Forms.Panel();
            this.pnlCustomerGridCard = new System.Windows.Forms.Panel();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.colCustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearchFiltersContainer = new System.Windows.Forms.Panel();
            this.pnlSearchFiltersCard = new System.Windows.Forms.Panel();
            this.tblSearchFilters = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.lblSearchUsername = new System.Windows.Forms.Label();
            this.txtSearchUsername = new System.Windows.Forms.TextBox();
            this.lblSearchEmail = new System.Windows.Forms.Label();
            this.txtSearchEmail = new System.Windows.Forms.TextBox();
            this.pnlSearchButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.btnRefreshResults = new System.Windows.Forms.Button();
            this.pnlSummaryContainer = new System.Windows.Forms.Panel();
            this.pnlSummaryCard = new System.Windows.Forms.Panel();
            this.flpSummaryCards = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSumTotalCustomers = new System.Windows.Forms.Panel();
            this.lblTotalCustomersValue = new System.Windows.Forms.Label();
            this.lblTotalCustomersTitle = new System.Windows.Forms.Label();
            this.pnlSumNewThisMonth = new System.Windows.Forms.Panel();
            this.lblNewThisMonthValue = new System.Windows.Forms.Label();
            this.lblNewThisMonthTitle = new System.Windows.Forms.Label();
            this.pnlPageHeaderContainer = new System.Windows.Forms.Panel();
            this.pnlPageHeaderCard = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageDescription = new System.Windows.Forms.Label();
            this.lblBreadcrumb = new System.Windows.Forms.Label();
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
            this.pnlActionButtonsContainer.SuspendLayout();
            this.pnlActionButtonsCard.SuspendLayout();
            this.flpActionButtons.SuspendLayout();
            this.pnlCustomerDetailsContainer.SuspendLayout();
            this.pnlCustomerDetailsCard.SuspendLayout();
            this.tblCustomerDetails.SuspendLayout();
            this.pnlCustomerGridContainer.SuspendLayout();
            this.pnlCustomerGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.pnlSearchFiltersContainer.SuspendLayout();
            this.pnlSearchFiltersCard.SuspendLayout();
            this.tblSearchFilters.SuspendLayout();
            this.pnlSearchButtons.SuspendLayout();
            this.pnlSummaryContainer.SuspendLayout();
            this.pnlSummaryCard.SuspendLayout();
            this.flpSummaryCards.SuspendLayout();
            this.pnlSumTotalCustomers.SuspendLayout();
            this.pnlSumNewThisMonth.SuspendLayout();
            this.pnlPageHeaderContainer.SuspendLayout();
            this.pnlPageHeaderCard.SuspendLayout();
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
            this.pnlDashboardContent.Size = new System.Drawing.Size(1045, 1168);
            this.pnlDashboardContent.TabIndex = 0;
            // 
            // pnlActionButtonsContainer
            // 
            this.pnlActionButtonsContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlActionButtonsContainer.Controls.Add(this.pnlActionButtonsCard);
            this.pnlActionButtonsContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActionButtonsContainer.Location = new System.Drawing.Point(20, 1090);
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
            this.flpActionButtons.Controls.Add(this.btnUpdate);
            this.flpActionButtons.Controls.Add(this.btnDeleteCustomer);
            this.flpActionButtons.Controls.Add(this.btnClear);
            this.flpActionButtons.Controls.Add(this.btnRefresh);
            this.flpActionButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpActionButtons.Location = new System.Drawing.Point(15, 15);
            this.flpActionButtons.Name = "flpActionButtons";
            this.flpActionButtons.Size = new System.Drawing.Size(975, 38);
            this.flpActionButtons.TabIndex = 0;
            this.flpActionButtons.WrapContents = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnUpdate.Location = new System.Drawing.Point(3, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 32);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnDeleteCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnDeleteCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(119, 3);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(110, 32);
            this.btnDeleteCustomer.TabIndex = 2;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
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
            this.btnClear.Location = new System.Drawing.Point(235, 3);
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
            this.btnRefresh.Location = new System.Drawing.Point(331, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 32);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // pnlCustomerDetailsContainer
            // 
            this.pnlCustomerDetailsContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlCustomerDetailsContainer.Controls.Add(this.pnlCustomerDetailsCard);
            this.pnlCustomerDetailsContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustomerDetailsContainer.Location = new System.Drawing.Point(20, 820);
            this.pnlCustomerDetailsContainer.Name = "pnlCustomerDetailsContainer";
            this.pnlCustomerDetailsContainer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlCustomerDetailsContainer.Size = new System.Drawing.Size(1005, 270);
            this.pnlCustomerDetailsContainer.TabIndex = 4;
            // 
            // pnlCustomerDetailsCard
            // 
            this.pnlCustomerDetailsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlCustomerDetailsCard.Controls.Add(this.tblCustomerDetails);
            this.pnlCustomerDetailsCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomerDetailsCard.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomerDetailsCard.Name = "pnlCustomerDetailsCard";
            this.pnlCustomerDetailsCard.Padding = new System.Windows.Forms.Padding(15);
            this.pnlCustomerDetailsCard.Size = new System.Drawing.Size(1005, 260);
            this.pnlCustomerDetailsCard.TabIndex = 0;
            // 
            // tblCustomerDetails
            // 
            this.tblCustomerDetails.BackColor = System.Drawing.Color.Transparent;
            this.tblCustomerDetails.ColumnCount = 2;
            this.tblCustomerDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCustomerDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCustomerDetails.Controls.Add(this.lblCustomerID, 0, 0);
            this.tblCustomerDetails.Controls.Add(this.txtCustomerID, 0, 1);
            this.tblCustomerDetails.Controls.Add(this.lblFullName, 1, 0);
            this.tblCustomerDetails.Controls.Add(this.txtFullName, 1, 1);
            this.tblCustomerDetails.Controls.Add(this.lblUsername, 0, 2);
            this.tblCustomerDetails.Controls.Add(this.txtUsername, 0, 3);
            this.tblCustomerDetails.Controls.Add(this.lblEmail, 1, 2);
            this.tblCustomerDetails.Controls.Add(this.txtEmail, 1, 3);
            this.tblCustomerDetails.Controls.Add(this.lblPhone, 0, 4);
            this.tblCustomerDetails.Controls.Add(this.txtPhone, 0, 5);
            this.tblCustomerDetails.Controls.Add(this.lblAddress, 1, 4);
            this.tblCustomerDetails.Controls.Add(this.txtAddress, 1, 5);
            this.tblCustomerDetails.Controls.Add(this.lblRegisteredDate, 0, 6);
            this.tblCustomerDetails.Controls.Add(this.dtpRegisteredDate, 0, 7);
            this.tblCustomerDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCustomerDetails.Location = new System.Drawing.Point(15, 15);
            this.tblCustomerDetails.Name = "tblCustomerDetails";
            this.tblCustomerDetails.RowCount = 8;
            this.tblCustomerDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblCustomerDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblCustomerDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblCustomerDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblCustomerDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblCustomerDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblCustomerDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblCustomerDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblCustomerDetails.Size = new System.Drawing.Size(975, 230);
            this.tblCustomerDetails.TabIndex = 0;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblCustomerID.Location = new System.Drawing.Point(3, 0);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(200, 22);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "Customer ID";
            this.lblCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtCustomerID.Location = new System.Drawing.Point(3, 25);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(380, 23);
            this.txtCustomerID.TabIndex = 1;
            // 
            // lblFullName
            // 
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblFullName.Location = new System.Drawing.Point(490, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(200, 22);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtFullName.Location = new System.Drawing.Point(490, 25);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(380, 23);
            this.txtFullName.TabIndex = 3;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblUsername.Location = new System.Drawing.Point(3, 52);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(200, 22);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtUsername.Location = new System.Drawing.Point(3, 77);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(380, 23);
            this.txtUsername.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblEmail.Location = new System.Drawing.Point(490, 52);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(200, 22);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtEmail.Location = new System.Drawing.Point(490, 77);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(380, 23);
            this.txtEmail.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblPhone.Location = new System.Drawing.Point(3, 104);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(200, 22);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Phone";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtPhone.Location = new System.Drawing.Point(3, 129);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(380, 23);
            this.txtPhone.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblAddress.Location = new System.Drawing.Point(490, 104);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(200, 22);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtAddress.Location = new System.Drawing.Point(490, 129);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(380, 54);
            this.txtAddress.TabIndex = 11;
            // 
            // lblRegisteredDate
            // 
            this.lblRegisteredDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRegisteredDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblRegisteredDate.Location = new System.Drawing.Point(3, 186);
            this.lblRegisteredDate.Name = "lblRegisteredDate";
            this.lblRegisteredDate.Size = new System.Drawing.Size(200, 22);
            this.lblRegisteredDate.TabIndex = 12;
            this.lblRegisteredDate.Text = "Registered Date";
            this.lblRegisteredDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpRegisteredDate
            // 
            this.dtpRegisteredDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dtpRegisteredDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dtpRegisteredDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dtpRegisteredDate.Enabled = false;
            this.dtpRegisteredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegisteredDate.Location = new System.Drawing.Point(3, 211);
            this.dtpRegisteredDate.Name = "dtpRegisteredDate";
            this.dtpRegisteredDate.Size = new System.Drawing.Size(380, 23);
            this.dtpRegisteredDate.TabIndex = 13;
            // 
            // pnlCustomerGridContainer
            // 
            this.pnlCustomerGridContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlCustomerGridContainer.Controls.Add(this.pnlCustomerGridCard);
            this.pnlCustomerGridContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustomerGridContainer.Location = new System.Drawing.Point(20, 480);
            this.pnlCustomerGridContainer.Name = "pnlCustomerGridContainer";
            this.pnlCustomerGridContainer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlCustomerGridContainer.Size = new System.Drawing.Size(1005, 340);
            this.pnlCustomerGridContainer.TabIndex = 3;
            // 
            // pnlCustomerGridCard
            // 
            this.pnlCustomerGridCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlCustomerGridCard.Controls.Add(this.dgvCustomers);
            this.pnlCustomerGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomerGridCard.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomerGridCard.Name = "pnlCustomerGridCard";
            this.pnlCustomerGridCard.Padding = new System.Windows.Forms.Padding(10);
            this.pnlCustomerGridCard.Size = new System.Drawing.Size(1005, 330);
            this.pnlCustomerGridCard.TabIndex = 0;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustID,
            this.colCustFullName,
            this.colCustUsername,
            this.colCustEmail,
            this.colCustPhone,
            this.colCustAddress,
            this.colCustCreatedDate});
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dgvCustomers.Location = new System.Drawing.Point(10, 10);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowTemplate.Height = 30;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(985, 310);
            this.dgvCustomers.TabIndex = 0;
            // 
            // colCustID
            // 
            this.colCustID.HeaderText = "Customer ID";
            this.colCustID.Name = "colCustID";
            this.colCustID.ReadOnly = true;
            this.colCustID.Width = 90;
            // 
            // colCustFullName
            // 
            this.colCustFullName.HeaderText = "Full Name";
            this.colCustFullName.Name = "colCustFullName";
            this.colCustFullName.ReadOnly = true;
            this.colCustFullName.Width = 140;
            // 
            // colCustUsername
            // 
            this.colCustUsername.HeaderText = "Username";
            this.colCustUsername.Name = "colCustUsername";
            this.colCustUsername.ReadOnly = true;
            // 
            // colCustEmail
            // 
            this.colCustEmail.HeaderText = "Email";
            this.colCustEmail.Name = "colCustEmail";
            this.colCustEmail.ReadOnly = true;
            this.colCustEmail.Width = 170;
            // 
            // colCustPhone
            // 
            this.colCustPhone.HeaderText = "Phone";
            this.colCustPhone.Name = "colCustPhone";
            this.colCustPhone.ReadOnly = true;
            this.colCustPhone.Width = 120;
            // 
            // colCustAddress
            // 
            this.colCustAddress.HeaderText = "Address";
            this.colCustAddress.Name = "colCustAddress";
            this.colCustAddress.ReadOnly = true;
            this.colCustAddress.Width = 200;
            // 
            // colCustCreatedDate
            // 
            this.colCustCreatedDate.HeaderText = "Created Date";
            this.colCustCreatedDate.Name = "colCustCreatedDate";
            this.colCustCreatedDate.ReadOnly = true;
            this.colCustCreatedDate.Width = 110;
            // 
            // pnlSearchFiltersContainer
            // 
            this.pnlSearchFiltersContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearchFiltersContainer.Controls.Add(this.pnlSearchFiltersCard);
            this.pnlSearchFiltersContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchFiltersContainer.Location = new System.Drawing.Point(20, 325);
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
            this.tblSearchFilters.Controls.Add(this.lblSearchName, 0, 0);
            this.tblSearchFilters.Controls.Add(this.txtSearchName, 0, 1);
            this.tblSearchFilters.Controls.Add(this.lblSearchUsername, 1, 0);
            this.tblSearchFilters.Controls.Add(this.txtSearchUsername, 1, 1);
            this.tblSearchFilters.Controls.Add(this.lblSearchEmail, 2, 0);
            this.tblSearchFilters.Controls.Add(this.txtSearchEmail, 2, 1);
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
            this.txtSearchName.Size = new System.Drawing.Size(310, 23);
            this.txtSearchName.TabIndex = 1;
            // 
            // lblSearchUsername
            // 
            this.lblSearchUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearchUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblSearchUsername.Location = new System.Drawing.Point(327, 0);
            this.lblSearchUsername.Name = "lblSearchUsername";
            this.lblSearchUsername.Size = new System.Drawing.Size(150, 22);
            this.lblSearchUsername.TabIndex = 2;
            this.lblSearchUsername.Text = "Search by Username";
            this.lblSearchUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearchUsername
            // 
            this.txtSearchUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtSearchUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtSearchUsername.Location = new System.Drawing.Point(327, 25);
            this.txtSearchUsername.Name = "txtSearchUsername";
            this.txtSearchUsername.Size = new System.Drawing.Size(310, 23);
            this.txtSearchUsername.TabIndex = 3;
            // 
            // lblSearchEmail
            // 
            this.lblSearchEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearchEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblSearchEmail.Location = new System.Drawing.Point(651, 0);
            this.lblSearchEmail.Name = "lblSearchEmail";
            this.lblSearchEmail.Size = new System.Drawing.Size(150, 22);
            this.lblSearchEmail.TabIndex = 4;
            this.lblSearchEmail.Text = "Search by Email";
            this.lblSearchEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearchEmail
            // 
            this.txtSearchEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtSearchEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtSearchEmail.Location = new System.Drawing.Point(651, 25);
            this.txtSearchEmail.Name = "txtSearchEmail";
            this.txtSearchEmail.Size = new System.Drawing.Size(320, 23);
            this.txtSearchEmail.TabIndex = 5;
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
            // pnlSummaryContainer
            // 
            this.pnlSummaryContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlSummaryContainer.Controls.Add(this.pnlSummaryCard);
            this.pnlSummaryContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSummaryContainer.Location = new System.Drawing.Point(20, 151);
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
            this.flpSummaryCards.Controls.Add(this.pnlSumTotalCustomers);
            this.flpSummaryCards.Controls.Add(this.pnlSumNewThisMonth);
            this.flpSummaryCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSummaryCards.Location = new System.Drawing.Point(10, 10);
            this.flpSummaryCards.Name = "flpSummaryCards";
            this.flpSummaryCards.Size = new System.Drawing.Size(985, 114);
            this.flpSummaryCards.TabIndex = 0;
            this.flpSummaryCards.WrapContents = false;
            // 
            // pnlSumTotalCustomers
            // 
            this.pnlSumTotalCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlSumTotalCustomers.Controls.Add(this.lblTotalCustomersValue);
            this.pnlSumTotalCustomers.Controls.Add(this.lblTotalCustomersTitle);
            this.pnlSumTotalCustomers.Location = new System.Drawing.Point(3, 3);
            this.pnlSumTotalCustomers.Name = "pnlSumTotalCustomers";
            this.pnlSumTotalCustomers.Padding = new System.Windows.Forms.Padding(10);
            this.pnlSumTotalCustomers.Size = new System.Drawing.Size(160, 100);
            this.pnlSumTotalCustomers.TabIndex = 0;
            // 
            // lblTotalCustomersValue
            // 
            this.lblTotalCustomersValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalCustomersValue.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalCustomersValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblTotalCustomersValue.Location = new System.Drawing.Point(10, 10);
            this.lblTotalCustomersValue.Name = "lblTotalCustomersValue";
            this.lblTotalCustomersValue.Size = new System.Drawing.Size(140, 55);
            this.lblTotalCustomersValue.TabIndex = 0;
            this.lblTotalCustomersValue.Text = "0";
            this.lblTotalCustomersValue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblTotalCustomersTitle
            // 
            this.lblTotalCustomersTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalCustomersTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalCustomersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblTotalCustomersTitle.Location = new System.Drawing.Point(10, 65);
            this.lblTotalCustomersTitle.Name = "lblTotalCustomersTitle";
            this.lblTotalCustomersTitle.Size = new System.Drawing.Size(140, 25);
            this.lblTotalCustomersTitle.TabIndex = 1;
            this.lblTotalCustomersTitle.Text = "Total Customers";
            this.lblTotalCustomersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSumNewThisMonth
            // 
            this.pnlSumNewThisMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlSumNewThisMonth.Controls.Add(this.lblNewThisMonthValue);
            this.pnlSumNewThisMonth.Controls.Add(this.lblNewThisMonthTitle);
            this.pnlSumNewThisMonth.Location = new System.Drawing.Point(169, 3);
            this.pnlSumNewThisMonth.Name = "pnlSumNewThisMonth";
            this.pnlSumNewThisMonth.Padding = new System.Windows.Forms.Padding(10);
            this.pnlSumNewThisMonth.Size = new System.Drawing.Size(160, 100);
            this.pnlSumNewThisMonth.TabIndex = 2;
            // 
            // lblNewThisMonthValue
            // 
            this.lblNewThisMonthValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNewThisMonthValue.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblNewThisMonthValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblNewThisMonthValue.Location = new System.Drawing.Point(10, 10);
            this.lblNewThisMonthValue.Name = "lblNewThisMonthValue";
            this.lblNewThisMonthValue.Size = new System.Drawing.Size(140, 55);
            this.lblNewThisMonthValue.TabIndex = 0;
            this.lblNewThisMonthValue.Text = "0";
            this.lblNewThisMonthValue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblNewThisMonthTitle
            // 
            this.lblNewThisMonthTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNewThisMonthTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNewThisMonthTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblNewThisMonthTitle.Location = new System.Drawing.Point(10, 65);
            this.lblNewThisMonthTitle.Name = "lblNewThisMonthTitle";
            this.lblNewThisMonthTitle.Size = new System.Drawing.Size(140, 25);
            this.lblNewThisMonthTitle.TabIndex = 1;
            this.lblNewThisMonthTitle.Text = "New This Month";
            this.lblNewThisMonthTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblPageTitle.Text = "Customer Management";
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
            this.lblPageDescription.Text = "View, search and manage customer accounts. (Admin only)";
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
            this.lblBreadcrumb.Text = "Dashboard > Customer Management";
            this.lblBreadcrumb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBreadcrumb.Visible = false;
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
            this.btnNavCustomers.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
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
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1302, 749);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "CustomerManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartMed Pharmacy Management System - Customer Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            // Add all content sections to pnlDashboardContent
            this.pnlDashboardContent.Controls.Add(this.pnlActionButtonsContainer);
            this.pnlDashboardContent.Controls.Add(this.pnlCustomerDetailsContainer);
            this.pnlDashboardContent.Controls.Add(this.pnlCustomerGridContainer);
            this.pnlDashboardContent.Controls.Add(this.pnlSearchFiltersContainer);
            this.pnlDashboardContent.Controls.Add(this.pnlSummaryContainer);
            this.pnlDashboardContent.Controls.Add(this.pnlPageHeaderContainer);

            this.pnlMain.ResumeLayout(false);
            this.pnlContentArea.ResumeLayout(false);
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlDashboardContent.ResumeLayout(false);
            this.pnlActionButtonsContainer.ResumeLayout(false);
            this.pnlActionButtonsCard.ResumeLayout(false);
            this.flpActionButtons.ResumeLayout(false);
            this.pnlCustomerDetailsContainer.ResumeLayout(false);
            this.pnlCustomerDetailsCard.ResumeLayout(false);
            this.tblCustomerDetails.ResumeLayout(false);
            this.tblCustomerDetails.PerformLayout();
            this.pnlCustomerGridContainer.ResumeLayout(false);
            this.pnlCustomerGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.pnlSearchFiltersContainer.ResumeLayout(false);
            this.pnlSearchFiltersCard.ResumeLayout(false);
            this.tblSearchFilters.ResumeLayout(false);
            this.tblSearchFilters.PerformLayout();
            this.pnlSearchButtons.ResumeLayout(false);
            this.pnlSummaryContainer.ResumeLayout(false);
            this.pnlSummaryCard.ResumeLayout(false);
            this.flpSummaryCards.ResumeLayout(false);
            this.pnlSumTotalCustomers.ResumeLayout(false);
            this.pnlSumNewThisMonth.ResumeLayout(false);
            this.pnlPageHeaderContainer.ResumeLayout(false);
            this.pnlPageHeaderCard.ResumeLayout(false);
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

        private System.Windows.Forms.Panel pnlPageHeaderContainer;
        private System.Windows.Forms.Panel pnlPageHeaderCard;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageDescription;
        private System.Windows.Forms.Label lblBreadcrumb;

        private System.Windows.Forms.Panel pnlSummaryContainer;
        private System.Windows.Forms.Panel pnlSummaryCard;
        private System.Windows.Forms.FlowLayoutPanel flpSummaryCards;
        private System.Windows.Forms.Panel pnlSumTotalCustomers;
        private System.Windows.Forms.Label lblTotalCustomersValue;
        private System.Windows.Forms.Label lblTotalCustomersTitle;
        private System.Windows.Forms.Panel pnlSumNewThisMonth;
        private System.Windows.Forms.Label lblNewThisMonthValue;
        private System.Windows.Forms.Label lblNewThisMonthTitle;

        private System.Windows.Forms.Panel pnlSearchFiltersContainer;
        private System.Windows.Forms.Panel pnlSearchFiltersCard;
        private System.Windows.Forms.TableLayoutPanel tblSearchFilters;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label lblSearchUsername;
        private System.Windows.Forms.TextBox txtSearchUsername;
        private System.Windows.Forms.Label lblSearchEmail;
        private System.Windows.Forms.TextBox txtSearchEmail;
        private System.Windows.Forms.FlowLayoutPanel pnlSearchButtons;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.Button btnRefreshResults;

        private System.Windows.Forms.Panel pnlCustomerGridContainer;
        private System.Windows.Forms.Panel pnlCustomerGridCard;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustCreatedDate;

        private System.Windows.Forms.Panel pnlCustomerDetailsContainer;
        private System.Windows.Forms.Panel pnlCustomerDetailsCard;
        private System.Windows.Forms.TableLayoutPanel tblCustomerDetails;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblRegisteredDate;
        private System.Windows.Forms.DateTimePicker dtpRegisteredDate;

        private System.Windows.Forms.Panel pnlActionButtonsContainer;
        private System.Windows.Forms.Panel pnlActionButtonsCard;
        private System.Windows.Forms.FlowLayoutPanel flpActionButtons;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;

        private System.Windows.Forms.ToolTip toolTipHints;
    }
}