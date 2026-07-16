namespace SmartMed.Forms
{
    partial class TrackOrdersForm
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlContentArea = new System.Windows.Forms.Panel();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.pnlOrdersCard = new System.Windows.Forms.Panel();
            this.pnlEmptyState = new System.Windows.Forms.Panel();
            this.tblEmpty = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmptyIcon = new System.Windows.Forms.Label();
            this.lblEmptyMessage = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.colOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderDescription = new System.Windows.Forms.Label();
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
            this.pnlMainContent.SuspendLayout();
            this.pnlOrdersCard.SuspendLayout();
            this.pnlEmptyState.SuspendLayout();
            this.tblEmpty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.flpButtons.SuspendLayout();
            this.pnlHeader.SuspendLayout();
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
            this.pnlContentArea.Controls.Add(this.pnlMainContent);
            this.pnlContentArea.Controls.Add(this.pnlTopBar);
            this.pnlContentArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentArea.Location = new System.Drawing.Point(240, 0);
            this.pnlContentArea.Name = "pnlContentArea";
            this.pnlContentArea.Size = new System.Drawing.Size(1062, 720);
            this.pnlContentArea.TabIndex = 1;
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.AutoScroll = true;
            this.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlMainContent.Controls.Add(this.pnlOrdersCard);
            this.pnlMainContent.Controls.Add(this.pnlHeader);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 60);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMainContent.Size = new System.Drawing.Size(1062, 660);
            this.pnlMainContent.TabIndex = 1;
            // 
            // pnlOrdersCard
            // 
            this.pnlOrdersCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlOrdersCard.Controls.Add(this.pnlEmptyState);
            this.pnlOrdersCard.Controls.Add(this.dgvOrders);
            this.pnlOrdersCard.Controls.Add(this.pnlButtons);
            this.pnlOrdersCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrdersCard.Location = new System.Drawing.Point(20, 110);
            this.pnlOrdersCard.Name = "pnlOrdersCard";
            this.pnlOrdersCard.Padding = new System.Windows.Forms.Padding(10);
            this.pnlOrdersCard.Size = new System.Drawing.Size(1022, 530);
            this.pnlOrdersCard.TabIndex = 2;
            // 
            // pnlEmptyState
            // 
            this.pnlEmptyState.BackColor = System.Drawing.Color.Transparent;
            this.pnlEmptyState.Controls.Add(this.tblEmpty);
            this.pnlEmptyState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmptyState.Location = new System.Drawing.Point(10, 10);
            this.pnlEmptyState.Name = "pnlEmptyState";
            this.pnlEmptyState.Size = new System.Drawing.Size(1002, 465);
            this.pnlEmptyState.TabIndex = 2;
            this.pnlEmptyState.Visible = true;
            // 
            // tblEmpty
            // 
            this.tblEmpty.BackColor = System.Drawing.Color.Transparent;
            this.tblEmpty.ColumnCount = 3;
            this.tblEmpty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblEmpty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblEmpty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblEmpty.Controls.Add(this.lblEmptyIcon, 1, 1);
            this.tblEmpty.Controls.Add(this.lblEmptyMessage, 1, 2);
            this.tblEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblEmpty.Location = new System.Drawing.Point(0, 0);
            this.tblEmpty.Name = "tblEmpty";
            this.tblEmpty.RowCount = 3;
            this.tblEmpty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblEmpty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblEmpty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblEmpty.Size = new System.Drawing.Size(1002, 465);
            this.tblEmpty.TabIndex = 0;
            // 
            // lblEmptyIcon
            // 
            this.lblEmptyIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmptyIcon.AutoSize = true;
            this.lblEmptyIcon.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmptyIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblEmptyIcon.Location = new System.Drawing.Point(457, 57);
            this.lblEmptyIcon.Name = "lblEmptyIcon";
            this.lblEmptyIcon.Size = new System.Drawing.Size(87, 86);
            this.lblEmptyIcon.TabIndex = 0;
            this.lblEmptyIcon.Text = "📦";
            this.lblEmptyIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmptyMessage
            // 
            this.lblEmptyMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmptyMessage.AutoSize = true;
            this.lblEmptyMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmptyMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblEmptyMessage.Location = new System.Drawing.Point(328, 238);
            this.lblEmptyMessage.Name = "lblEmptyMessage";
            this.lblEmptyMessage.Size = new System.Drawing.Size(346, 21);
            this.lblEmptyMessage.TabIndex = 1;
            this.lblEmptyMessage.Text = "No orders found.\r\nYour completed purchases will appear here.";
            this.lblEmptyMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.colDate,
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
            this.dgvOrders.Size = new System.Drawing.Size(1002, 465);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.Visible = false;
            // 
            // colOrderID
            // 
            this.colOrderID.HeaderText = "Order ID";
            this.colOrderID.Name = "colOrderID";
            this.colOrderID.ReadOnly = true;
            this.colOrderID.Width = 80;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 150;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 100;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 150;
            // 
            // colPrescription
            // 
            this.colPrescription.HeaderText = "Prescription";
            this.colPrescription.Name = "colPrescription";
            this.colPrescription.ReadOnly = true;
            this.colPrescription.Width = 200;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.Controls.Add(this.flpButtons);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(10, 475);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(5);
            this.pnlButtons.Size = new System.Drawing.Size(1002, 45);
            this.pnlButtons.TabIndex = 1;
            // 
            // flpButtons
            // 
            this.flpButtons.AutoSize = true;
            this.flpButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpButtons.BackColor = System.Drawing.Color.Transparent;
            this.flpButtons.Controls.Add(this.btnRefresh);
            this.flpButtons.Controls.Add(this.btnViewDetails);
            this.flpButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpButtons.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flpButtons.Location = new System.Drawing.Point(807, 5);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(190, 35);
            this.flpButtons.TabIndex = 0;
            this.flpButtons.WrapContents = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 32);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnViewDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewDetails.Enabled = false;
            this.btnViewDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnViewDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnViewDetails.Location = new System.Drawing.Point(99, 3);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(90, 32);
            this.btnViewDetails.TabIndex = 1;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Controls.Add(this.lblHeaderDescription);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(20, 20);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(15);
            this.pnlHeader.Size = new System.Drawing.Size(1022, 90);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(15, 15);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(138, 30);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Track Orders";
            // 
            // lblHeaderDescription
            // 
            this.lblHeaderDescription.AutoSize = true;
            this.lblHeaderDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHeaderDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblHeaderDescription.Location = new System.Drawing.Point(15, 50);
            this.lblHeaderDescription.Name = "lblHeaderDescription";
            this.lblHeaderDescription.Size = new System.Drawing.Size(427, 19);
            this.lblHeaderDescription.TabIndex = 1;
            this.lblHeaderDescription.Text = "View your previous orders, monitor their status and review order details.";
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
            this.btnNavOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
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
            // TrackOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1302, 720);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "TrackOrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartMed Pharmacy - Track Orders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMain.ResumeLayout(false);
            this.pnlContentArea.ResumeLayout(false);
            this.pnlMainContent.ResumeLayout(false);
            this.pnlOrdersCard.ResumeLayout(false);
            this.pnlEmptyState.ResumeLayout(false);
            this.tblEmpty.ResumeLayout(false);
            this.tblEmpty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.flpButtons.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
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
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Panel pnlOrdersCard;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderDescription;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox picUserAvatar;
        private System.Windows.Forms.Label btnLogoutIcon;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlSidebarLogo;
        private System.Windows.Forms.Label lblSidebarLogoSuffix;
        private System.Windows.Forms.Label lblSidebarLogoAccent;
        private System.Windows.Forms.Label lblSidebarLogoPrefix;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnNavLogout;
        private System.Windows.Forms.Button btnNavProfile;
        private System.Windows.Forms.Button btnNavOrders;
        private System.Windows.Forms.Button btnNavCart;
        private System.Windows.Forms.Button btnNavMedicines;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.ToolTip toolTipHints;
        private System.Windows.Forms.Panel pnlEmptyState;
        private System.Windows.Forms.TableLayoutPanel tblEmpty;
        private System.Windows.Forms.Label lblEmptyIcon;
        private System.Windows.Forms.Label lblEmptyMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrescription;
    }
}