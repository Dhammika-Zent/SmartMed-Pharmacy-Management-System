namespace SmartMed.Forms
{
    partial class CartForm
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
            this.pnlCartContent = new System.Windows.Forms.Panel();
            this.lblCartDescription = new System.Windows.Forms.Label();
            this.lblCartTitle = new System.Windows.Forms.Label();
            this.pnlCartBody = new System.Windows.Forms.Panel();
            this.pnlCartMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCartItemsPanel = new System.Windows.Forms.Panel();
            this.lblCartItemsTitle = new System.Windows.Forms.Label();
            this.dgvCartItems = new System.Windows.Forms.DataGridView();
            this.colCartMedicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlEmptyCart = new System.Windows.Forms.Panel();
            this.lblEmptyIcon = new System.Windows.Forms.Label();
            this.lblEmptyMessage = new System.Windows.Forms.Label();
            this.lblEmptySubtext = new System.Windows.Forms.Label();
            this.btnEmptyContinueShopping = new System.Windows.Forms.Button();
            this.pnlCartSummaryPanel = new System.Windows.Forms.Panel();
            this.lblSummaryTitle = new System.Windows.Forms.Label();
            this.pnlSummaryContent = new System.Windows.Forms.Panel();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblDiscountCaption = new System.Windows.Forms.Label();
            this.lblDiscountValue = new System.Windows.Forms.Label();
            this.lblFinalTotalCaption = new System.Windows.Forms.Label();
            this.lblFinalTotalValue = new System.Windows.Forms.Label();
            this.pnlCartActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnContinueShopping = new System.Windows.Forms.Button();
            this.btnUpdateQuantity = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.pnlPrescriptionInfo = new System.Windows.Forms.Panel();
            this.lblPrescriptionMessage = new System.Windows.Forms.Label();
            this.pnlTopBar = new System.Windows.Forms.Panel();
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
            this.pnlCartContent.SuspendLayout();
            this.pnlCartBody.SuspendLayout();
            this.pnlCartMain.SuspendLayout();
            this.pnlCartItemsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartItems)).BeginInit();
            this.pnlEmptyCart.SuspendLayout();
            this.pnlCartSummaryPanel.SuspendLayout();
            this.pnlSummaryContent.SuspendLayout();
            this.pnlCartActions.SuspendLayout();
            this.pnlPrescriptionInfo.SuspendLayout();
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
            this.pnlContentArea.Controls.Add(this.pnlCartContent);
            this.pnlContentArea.Controls.Add(this.pnlTopBar);
            this.pnlContentArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentArea.Location = new System.Drawing.Point(240, 0);
            this.pnlContentArea.Name = "pnlContentArea";
            this.pnlContentArea.Size = new System.Drawing.Size(1062, 720);
            this.pnlContentArea.TabIndex = 1;
            // 
            // pnlCartContent
            // 
            this.pnlCartContent.AutoScroll = true;
            this.pnlCartContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlCartContent.Controls.Add(this.pnlCartBody);
            this.pnlCartContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCartContent.Location = new System.Drawing.Point(0, 70);
            this.pnlCartContent.Name = "pnlCartContent";
            this.pnlCartContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlCartContent.Size = new System.Drawing.Size(1062, 650);
            this.pnlCartContent.TabIndex = 1;
            // 
            // lblCartDescription
            // 
            this.lblCartDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCartDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblCartDescription.Location = new System.Drawing.Point(17, 41);
            this.lblCartDescription.Name = "lblCartDescription";
            this.lblCartDescription.Size = new System.Drawing.Size(800, 36);
            this.lblCartDescription.TabIndex = 1;
            this.lblCartDescription.Text = "Review selected medicines, update quantities and proceed to checkout.";
            // 
            // lblCartTitle
            // 
            this.lblCartTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblCartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblCartTitle.Location = new System.Drawing.Point(15, 11);
            this.lblCartTitle.Name = "lblCartTitle";
            this.lblCartTitle.Size = new System.Drawing.Size(300, 25);
            this.lblCartTitle.TabIndex = 0;
            this.lblCartTitle.Text = "Cart";
            // 
            // pnlCartBody
            // 
            this.pnlCartBody.Controls.Add(this.pnlCartMain);
            this.pnlCartBody.Controls.Add(this.pnlCartActions);
            this.pnlCartBody.Controls.Add(this.pnlPrescriptionInfo);
            this.pnlCartBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCartBody.Location = new System.Drawing.Point(20, 20);
            this.pnlCartBody.Name = "pnlCartBody";
            this.pnlCartBody.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.pnlCartBody.Size = new System.Drawing.Size(1022, 610);
            this.pnlCartBody.TabIndex = 1;
            // 
            // pnlCartMain
            // 
            this.pnlCartMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlCartMain.ColumnCount = 2;
            this.pnlCartMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.pnlCartMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.pnlCartMain.Controls.Add(this.pnlCartItemsPanel, 0, 0);
            this.pnlCartMain.Controls.Add(this.pnlCartSummaryPanel, 1, 0);
            this.pnlCartMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCartMain.Location = new System.Drawing.Point(0, 15);
            this.pnlCartMain.Name = "pnlCartMain";
            this.pnlCartMain.RowCount = 1;
            this.pnlCartMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlCartMain.Size = new System.Drawing.Size(1022, 481);
            this.pnlCartMain.TabIndex = 0;
            // 
            // pnlCartItemsPanel
            // 
            this.pnlCartItemsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlCartItemsPanel.Controls.Add(this.lblCartItemsTitle);
            this.pnlCartItemsPanel.Controls.Add(this.dgvCartItems);
            this.pnlCartItemsPanel.Controls.Add(this.pnlEmptyCart);
            this.pnlCartItemsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCartItemsPanel.Location = new System.Drawing.Point(3, 3);
            this.pnlCartItemsPanel.Name = "pnlCartItemsPanel";
            this.pnlCartItemsPanel.Padding = new System.Windows.Forms.Padding(10);
            this.pnlCartItemsPanel.Size = new System.Drawing.Size(658, 475);
            this.pnlCartItemsPanel.TabIndex = 0;
            // 
            // lblCartItemsTitle
            // 
            this.lblCartItemsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCartItemsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCartItemsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblCartItemsTitle.Location = new System.Drawing.Point(10, 10);
            this.lblCartItemsTitle.Name = "lblCartItemsTitle";
            this.lblCartItemsTitle.Size = new System.Drawing.Size(638, 25);
            this.lblCartItemsTitle.TabIndex = 0;
            this.lblCartItemsTitle.Text = "Cart Items";
            // 
            // dgvCartItems
            // 
            this.dgvCartItems.AllowUserToAddRows = false;
            this.dgvCartItems.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCartItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCartItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvCartItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCartItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            // --- FIX: header was clipping under DataGridViewColumnHeadersHeightSizeMode.AutoSize.
            // Switched to a disabled-resize mode with a generous hardcoded header height, matching
            // the established SmartMed pattern of fixed heights instead of relying on WinForms
            // autosize behaviors. Also set an explicit header cell style + disabled visual styles
            // so Windows' theme renderer can't override the custom header colors/font and cause
            // mismatched/clipped rendering. ---
            this.dgvCartItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCartItems.ColumnHeadersHeight = 40;
            this.dgvCartItems.EnableHeadersVisualStyles = false;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewHeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewHeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewHeaderStyle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewHeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewHeaderStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvCartItems.ColumnHeadersDefaultCellStyle = dataGridViewHeaderStyle;

            this.dgvCartItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCartMedicine,
            this.colCartQuantity,
            this.colCartUnitPrice,
            this.colCartDiscount,
            this.colCartSubtotal});
            this.dgvCartItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCartItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dgvCartItems.Location = new System.Drawing.Point(10, 10);
            this.dgvCartItems.Name = "dgvCartItems";
            this.dgvCartItems.ReadOnly = true;
            this.dgvCartItems.RowHeadersVisible = false;
            this.dgvCartItems.RowTemplate.Height = 30;
            this.dgvCartItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCartItems.Size = new System.Drawing.Size(638, 455);
            this.dgvCartItems.TabIndex = 1;
            this.dgvCartItems.Visible = false;
            this.dgvCartItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCartItems_CellContentClick);
            // 
            // colCartMedicine
            // 
            this.colCartMedicine.HeaderText = "Medicine";
            this.colCartMedicine.Name = "colCartMedicine";
            this.colCartMedicine.ReadOnly = true;
            this.colCartMedicine.Width = 200;
            // 
            // colCartQuantity
            // 
            this.colCartQuantity.HeaderText = "Quantity";
            this.colCartQuantity.Name = "colCartQuantity";
            this.colCartQuantity.ReadOnly = true;
            this.colCartQuantity.Width = 80;
            // 
            // colCartUnitPrice
            // 
            this.colCartUnitPrice.HeaderText = "Unit Price";
            this.colCartUnitPrice.Name = "colCartUnitPrice";
            this.colCartUnitPrice.ReadOnly = true;
            // 
            // colCartDiscount
            // 
            this.colCartDiscount.HeaderText = "Discount";
            this.colCartDiscount.Name = "colCartDiscount";
            this.colCartDiscount.ReadOnly = true;
            // 
            // colCartSubtotal
            // 
            this.colCartSubtotal.HeaderText = "Subtotal";
            this.colCartSubtotal.Name = "colCartSubtotal";
            this.colCartSubtotal.ReadOnly = true;
            this.colCartSubtotal.Width = 120;
            // 
            // pnlEmptyCart
            // 
            this.pnlEmptyCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlEmptyCart.Controls.Add(this.lblEmptyIcon);
            this.pnlEmptyCart.Controls.Add(this.lblEmptyMessage);
            this.pnlEmptyCart.Controls.Add(this.lblEmptySubtext);
            this.pnlEmptyCart.Controls.Add(this.btnEmptyContinueShopping);
            this.pnlEmptyCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmptyCart.Location = new System.Drawing.Point(10, 10);
            this.pnlEmptyCart.Name = "pnlEmptyCart";
            this.pnlEmptyCart.Size = new System.Drawing.Size(638, 455);
            this.pnlEmptyCart.TabIndex = 2;
            // 
            // lblEmptyIcon
            // 
            this.lblEmptyIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmptyIcon.Font = new System.Drawing.Font("Segoe UI", 48F);
            this.lblEmptyIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblEmptyIcon.Location = new System.Drawing.Point(220, 80);
            this.lblEmptyIcon.Name = "lblEmptyIcon";
            this.lblEmptyIcon.Size = new System.Drawing.Size(200, 80);
            this.lblEmptyIcon.TabIndex = 0;
            this.lblEmptyIcon.Text = "🛒";
            this.lblEmptyIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmptyMessage
            // 
            this.lblEmptyMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmptyMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblEmptyMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblEmptyMessage.Location = new System.Drawing.Point(120, 170);
            this.lblEmptyMessage.Name = "lblEmptyMessage";
            this.lblEmptyMessage.Size = new System.Drawing.Size(400, 30);
            this.lblEmptyMessage.TabIndex = 1;
            this.lblEmptyMessage.Text = "Your cart is empty";
            this.lblEmptyMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmptySubtext
            // 
            this.lblEmptySubtext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmptySubtext.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmptySubtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblEmptySubtext.Location = new System.Drawing.Point(120, 210);
            this.lblEmptySubtext.Name = "lblEmptySubtext";
            this.lblEmptySubtext.Size = new System.Drawing.Size(400, 23);
            this.lblEmptySubtext.TabIndex = 2;
            this.lblEmptySubtext.Text = "Browse medicines to add items.";
            this.lblEmptySubtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEmptyContinueShopping
            // 
            this.btnEmptyContinueShopping.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmptyContinueShopping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnEmptyContinueShopping.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmptyContinueShopping.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnEmptyContinueShopping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmptyContinueShopping.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnEmptyContinueShopping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnEmptyContinueShopping.Location = new System.Drawing.Point(240, 260);
            this.btnEmptyContinueShopping.Name = "btnEmptyContinueShopping";
            this.btnEmptyContinueShopping.Size = new System.Drawing.Size(160, 36);
            this.btnEmptyContinueShopping.TabIndex = 3;
            this.btnEmptyContinueShopping.Text = "Continue Shopping";
            this.btnEmptyContinueShopping.UseVisualStyleBackColor = false;
            // 
            // pnlCartSummaryPanel
            // 
            this.pnlCartSummaryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlCartSummaryPanel.Controls.Add(this.lblSummaryTitle);
            this.pnlCartSummaryPanel.Controls.Add(this.pnlSummaryContent);
            this.pnlCartSummaryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCartSummaryPanel.Location = new System.Drawing.Point(667, 3);
            this.pnlCartSummaryPanel.Name = "pnlCartSummaryPanel";
            this.pnlCartSummaryPanel.Padding = new System.Windows.Forms.Padding(10);
            this.pnlCartSummaryPanel.Size = new System.Drawing.Size(352, 475);
            this.pnlCartSummaryPanel.TabIndex = 1;
            // 
            // lblSummaryTitle
            // 
            this.lblSummaryTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSummaryTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblSummaryTitle.Location = new System.Drawing.Point(10, 10);
            this.lblSummaryTitle.Name = "lblSummaryTitle";
            this.lblSummaryTitle.Size = new System.Drawing.Size(332, 25);
            this.lblSummaryTitle.TabIndex = 0;
            this.lblSummaryTitle.Text = "Cart Summary";
            // 
            // pnlSummaryContent
            // 
            this.pnlSummaryContent.Controls.Add(this.lblTotalCaption);
            this.pnlSummaryContent.Controls.Add(this.lblTotalValue);
            this.pnlSummaryContent.Controls.Add(this.lblDiscountCaption);
            this.pnlSummaryContent.Controls.Add(this.lblDiscountValue);
            this.pnlSummaryContent.Controls.Add(this.lblFinalTotalCaption);
            this.pnlSummaryContent.Controls.Add(this.lblFinalTotalValue);
            this.pnlSummaryContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSummaryContent.Location = new System.Drawing.Point(10, 10);
            this.pnlSummaryContent.Name = "pnlSummaryContent";
            this.pnlSummaryContent.Size = new System.Drawing.Size(332, 455);
            this.pnlSummaryContent.TabIndex = 1;
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblTotalCaption.Location = new System.Drawing.Point(10, 67);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(120, 23);
            this.lblTotalCaption.TabIndex = 0;
            this.lblTotalCaption.Text = "Total:";
            this.lblTotalCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTotalValue.Location = new System.Drawing.Point(130, 67);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(180, 23);
            this.lblTotalValue.TabIndex = 1;
            this.lblTotalValue.Text = "LKR 0.00";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscountCaption
            // 
            this.lblDiscountCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDiscountCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblDiscountCaption.Location = new System.Drawing.Point(10, 102);
            this.lblDiscountCaption.Name = "lblDiscountCaption";
            this.lblDiscountCaption.Size = new System.Drawing.Size(120, 23);
            this.lblDiscountCaption.TabIndex = 2;
            this.lblDiscountCaption.Text = "Discount:";
            this.lblDiscountCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiscountValue
            // 
            this.lblDiscountValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblDiscountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.lblDiscountValue.Location = new System.Drawing.Point(130, 102);
            this.lblDiscountValue.Name = "lblDiscountValue";
            this.lblDiscountValue.Size = new System.Drawing.Size(180, 23);
            this.lblDiscountValue.TabIndex = 3;
            this.lblDiscountValue.Text = "LKR 0.00";
            this.lblDiscountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFinalTotalCaption
            // 
            this.lblFinalTotalCaption.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFinalTotalCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblFinalTotalCaption.Location = new System.Drawing.Point(10, 137);
            this.lblFinalTotalCaption.Name = "lblFinalTotalCaption";
            this.lblFinalTotalCaption.Size = new System.Drawing.Size(120, 25);
            this.lblFinalTotalCaption.TabIndex = 4;
            this.lblFinalTotalCaption.Text = "Final Total:";
            this.lblFinalTotalCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFinalTotalValue
            // 
            this.lblFinalTotalValue.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblFinalTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblFinalTotalValue.Location = new System.Drawing.Point(130, 137);
            this.lblFinalTotalValue.Name = "lblFinalTotalValue";
            this.lblFinalTotalValue.Size = new System.Drawing.Size(180, 25);
            this.lblFinalTotalValue.TabIndex = 5;
            this.lblFinalTotalValue.Text = "LKR 0.00";
            this.lblFinalTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlCartActions
            // 
            this.pnlCartActions.BackColor = System.Drawing.Color.Transparent;
            this.pnlCartActions.Controls.Add(this.btnContinueShopping);
            this.pnlCartActions.Controls.Add(this.btnUpdateQuantity);
            this.pnlCartActions.Controls.Add(this.btnRemoveItem);
            this.pnlCartActions.Controls.Add(this.btnClearCart);
            this.pnlCartActions.Controls.Add(this.btnCheckout);
            this.pnlCartActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCartActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlCartActions.Location = new System.Drawing.Point(0, 496);
            this.pnlCartActions.Name = "pnlCartActions";
            this.pnlCartActions.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.pnlCartActions.Size = new System.Drawing.Size(1022, 60);
            this.pnlCartActions.TabIndex = 1;
            this.pnlCartActions.WrapContents = false;
            // 
            // btnContinueShopping
            // 
            this.btnContinueShopping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnContinueShopping.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinueShopping.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnContinueShopping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinueShopping.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnContinueShopping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnContinueShopping.Location = new System.Drawing.Point(879, 11);
            this.btnContinueShopping.Name = "btnContinueShopping";
            this.btnContinueShopping.Size = new System.Drawing.Size(140, 32);
            this.btnContinueShopping.TabIndex = 0;
            this.btnContinueShopping.Text = "Continue Shopping";
            this.btnContinueShopping.UseVisualStyleBackColor = false;
            // 
            // btnUpdateQuantity
            // 
            this.btnUpdateQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnUpdateQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateQuantity.Enabled = false;
            this.btnUpdateQuantity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnUpdateQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnUpdateQuantity.Location = new System.Drawing.Point(753, 11);
            this.btnUpdateQuantity.Name = "btnUpdateQuantity";
            this.btnUpdateQuantity.Size = new System.Drawing.Size(120, 32);
            this.btnUpdateQuantity.TabIndex = 1;
            this.btnUpdateQuantity.Text = "Update Quantity";
            this.btnUpdateQuantity.UseVisualStyleBackColor = false;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveItem.Enabled = false;
            this.btnRemoveItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoveItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnRemoveItem.Location = new System.Drawing.Point(647, 11);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(100, 32);
            this.btnRemoveItem.TabIndex = 2;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            // 
            // btnClearCart
            // 
            this.btnClearCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnClearCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearCart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCart.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(250)))));
            this.btnClearCart.Location = new System.Drawing.Point(551, 11);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(90, 32);
            this.btnClearCart.TabIndex = 3;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.UseVisualStyleBackColor = false;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(445, 11);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(100, 32);
            this.btnCheckout.TabIndex = 4;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            // 
            // pnlPrescriptionInfo
            // 
            this.pnlPrescriptionInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlPrescriptionInfo.Controls.Add(this.lblPrescriptionMessage);
            this.pnlPrescriptionInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPrescriptionInfo.Location = new System.Drawing.Point(0, 556);
            this.pnlPrescriptionInfo.Name = "pnlPrescriptionInfo";
            this.pnlPrescriptionInfo.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.pnlPrescriptionInfo.Size = new System.Drawing.Size(1022, 54);
            this.pnlPrescriptionInfo.TabIndex = 5;
            this.pnlPrescriptionInfo.Visible = false;
            // 
            // lblPrescriptionMessage
            // 
            this.lblPrescriptionMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblPrescriptionMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrescriptionMessage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPrescriptionMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblPrescriptionMessage.Location = new System.Drawing.Point(10, 8);
            this.lblPrescriptionMessage.Name = "lblPrescriptionMessage";
            this.lblPrescriptionMessage.Size = new System.Drawing.Size(1002, 38);
            this.lblPrescriptionMessage.TabIndex = 0;
            this.lblPrescriptionMessage.Text = "One or more medicines in your cart require a valid prescription. You will be prom" +
    "pted to upload it during Checkout.";
            this.lblPrescriptionMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlTopBar.Controls.Add(this.lblCartDescription);
            this.pnlTopBar.Controls.Add(this.pnlUserInfo);
            this.pnlTopBar.Controls.Add(this.lblCartTitle);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1062, 70);
            this.pnlTopBar.TabIndex = 0;
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
            this.btnNavCart.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
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
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1302, 720);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "CartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartMed Pharmacy - Cart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMain.ResumeLayout(false);
            this.pnlContentArea.ResumeLayout(false);
            this.pnlCartContent.ResumeLayout(false);
            this.pnlCartBody.ResumeLayout(false);
            this.pnlCartMain.ResumeLayout(false);
            this.pnlCartItemsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartItems)).EndInit();
            this.pnlEmptyCart.ResumeLayout(false);
            this.pnlCartSummaryPanel.ResumeLayout(false);
            this.pnlSummaryContent.ResumeLayout(false);
            this.pnlCartActions.ResumeLayout(false);
            this.pnlPrescriptionInfo.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox picUserAvatar;
        private System.Windows.Forms.Label btnLogoutIcon;
        private System.Windows.Forms.Panel pnlCartContent;
        private System.Windows.Forms.Label lblCartTitle;
        private System.Windows.Forms.Label lblCartDescription;
        private System.Windows.Forms.Panel pnlCartBody;
        private System.Windows.Forms.TableLayoutPanel pnlCartMain;
        private System.Windows.Forms.Panel pnlCartItemsPanel;
        private System.Windows.Forms.Label lblCartItemsTitle;
        private System.Windows.Forms.DataGridView dgvCartItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartSubtotal;
        private System.Windows.Forms.Panel pnlEmptyCart;
        private System.Windows.Forms.Label lblEmptyIcon;
        private System.Windows.Forms.Label lblEmptyMessage;
        private System.Windows.Forms.Label lblEmptySubtext;
        private System.Windows.Forms.Button btnEmptyContinueShopping;
        private System.Windows.Forms.Panel pnlCartSummaryPanel;
        private System.Windows.Forms.Label lblSummaryTitle;
        private System.Windows.Forms.Panel pnlSummaryContent;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblDiscountCaption;
        private System.Windows.Forms.Label lblDiscountValue;
        private System.Windows.Forms.Label lblFinalTotalCaption;
        private System.Windows.Forms.Label lblFinalTotalValue;
        private System.Windows.Forms.FlowLayoutPanel pnlCartActions;
        private System.Windows.Forms.Button btnContinueShopping;
        private System.Windows.Forms.Button btnUpdateQuantity;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Panel pnlPrescriptionInfo;
        private System.Windows.Forms.Label lblPrescriptionMessage;
        private System.Windows.Forms.ToolTip toolTipHints;
    }
}