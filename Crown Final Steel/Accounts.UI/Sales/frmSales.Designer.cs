namespace Accounts.UI
{
    partial class frmSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatuMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblVouchersCount = new MetroFramework.Controls.MetroLabel();
            this.lblTotalVouchers = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lblLastVoucherNo = new MetroFramework.Controls.MetroLabel();
            this.btnPrint = new MetroFramework.Controls.MetroTile();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.btnNext = new MetroFramework.Controls.MetroTile();
            this.btnNew = new MetroFramework.Controls.MetroTile();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnPrevious = new MetroFramework.Controls.MetroTile();
            this.btnClose = new MetroFramework.Controls.MetroTile();
            this.tabSales = new System.Windows.Forms.TabControl();
            this.tabLineItems = new System.Windows.Forms.TabPage();
            this.txtTotalAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtExtraDiscount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtMiscCharges = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.txtCuttingCharges = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.txtLoadingCharges = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.txt2kgWeight = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.txtManualWeight = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.txtSystemWeight = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.txtFreightAmount = new MetroFramework.Controls.MetroTextBox();
            this.lblFreight = new MetroFramework.Controls.MetroLabel();
            this.txtAmountAfterDiscount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtFlatDiscount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtTotalDiscount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtBillAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.lblVoucherStatus = new MetroFramework.Controls.MetroLabel();
            this.DgvStockSales = new Accounts.UI.TabDataGrid();
            this.ColIdVoucherDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutoWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new Accounts.UI.DataGridViewProductWaterMarkColumn();
            this.colpacking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEngineNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChassisNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicleModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicleColors = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colVehicleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstIMEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSecondIMEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBonusUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLineDisc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFlatDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabSalesTransactions = new System.Windows.Forms.TabPage();
            this.DgvSalesTransactions = new Accounts.UI.TabDataGrid();
            this.ColIdDetailVoucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClosingBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDebitor = new System.Windows.Forms.GroupBox();
            this.rdCash = new MetroFramework.Controls.MetroRadioButton();
            this.rdCredit = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.grpSales = new System.Windows.Forms.GroupBox();
            this.flowPurchasesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCash = new System.Windows.Forms.Panel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnAddCashAccount = new MetroFramework.Controls.MetroButton();
            this.cbxCashAccounts = new MetroFramework.Controls.MetroComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxNaturalAccounts = new MetroFramework.Controls.MetroComboBox();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnAddPurchasesAccount = new MetroFramework.Controls.MetroButton();
            this.txtDeliveryPerson = new MetroFramework.Controls.MetroTextBox();
            this.EmpEditCode = new MetroFramework.Controls.MetroTextBox();
            this.btnAddCustomer = new MetroFramework.Controls.MetroButton();
            this.txtCurrentBalance = new MetroFramework.Controls.MetroTextBox();
            this.btnViewDetail = new MetroFramework.Controls.MetroButton();
            this.txtContact = new MetroFramework.Controls.MetroTextBox();
            this.SEditBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VEditedDateTime = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txtCreditDays = new MetroFramework.Controls.MetroTextBox();
            this.lblCreditDays = new MetroFramework.Controls.MetroLabel();
            this.dtDueDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.VDate = new MetroFramework.Controls.MetroDateTime();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.txtGatePass = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtDriverName = new MetroFramework.Controls.MetroTextBox();
            this.txtVehicleNo = new MetroFramework.Controls.MetroTextBox();
            this.txtSampleNo = new MetroFramework.Controls.MetroTextBox();
            this.InvEditBox = new MetroFramework.Controls.MetroTextBox();
            this.lblInvoiceNo = new MetroFramework.Controls.MetroLabel();
            this.txtSheetNo = new MetroFramework.Controls.MetroTextBox();
            this.lblDiscription = new MetroFramework.Controls.MetroLabel();
            this.chkPosted = new MetroFramework.Controls.MetroCheckBox();
            this.txtBiltyNo = new MetroFramework.Controls.MetroTextBox();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.flowMainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStrip1.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.tabSales.SuspendLayout();
            this.tabLineItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStockSales)).BeginInit();
            this.tabSalesTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSalesTransactions)).BeginInit();
            this.grpDebitor.SuspendLayout();
            this.grpSales.SuspendLayout();
            this.flowPurchasesPanel.SuspendLayout();
            this.pnlCash.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatuMessage});
            this.statusStrip1.Location = new System.Drawing.Point(20, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1126, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatuMessage
            // 
            this.lblStatuMessage.Name = "lblStatuMessage";
            this.lblStatuMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.metroPanel1);
            this.pnlButtons.Controls.Add(this.btnPrint);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Controls.Add(this.btnNext);
            this.pnlButtons.Controls.Add(this.btnNew);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnPrevious);
            this.pnlButtons.Controls.Add(this.btnClose);
            this.pnlButtons.Location = new System.Drawing.Point(3, 638);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1130, 48);
            this.pnlButtons.TabIndex = 1;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.lblVouchersCount);
            this.metroPanel1.Controls.Add(this.lblTotalVouchers);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.lblLastVoucherNo);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 6);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(405, 36);
            this.metroPanel1.TabIndex = 21;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblVouchersCount
            // 
            this.lblVouchersCount.AutoSize = true;
            this.lblVouchersCount.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblVouchersCount.Location = new System.Drawing.Point(2, 4);
            this.lblVouchersCount.Name = "lblVouchersCount";
            this.lblVouchersCount.Size = new System.Drawing.Size(105, 19);
            this.lblVouchersCount.TabIndex = 2;
            this.lblVouchersCount.Text = "Total Vouchers :";
            // 
            // lblTotalVouchers
            // 
            this.lblTotalVouchers.AutoSize = true;
            this.lblTotalVouchers.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTotalVouchers.Location = new System.Drawing.Point(110, 6);
            this.lblTotalVouchers.Name = "lblTotalVouchers";
            this.lblTotalVouchers.Size = new System.Drawing.Size(17, 19);
            this.lblTotalVouchers.TabIndex = 2;
            this.lblTotalVouchers.Text = "0";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(200, 6);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(117, 19);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Last Voucher No :";
            // 
            // lblLastVoucherNo
            // 
            this.lblLastVoucherNo.AutoSize = true;
            this.lblLastVoucherNo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblLastVoucherNo.Location = new System.Drawing.Point(324, 7);
            this.lblLastVoucherNo.Name = "lblLastVoucherNo";
            this.lblLastVoucherNo.Size = new System.Drawing.Size(17, 19);
            this.lblLastVoucherNo.TabIndex = 2;
            this.lblLastVoucherNo.Text = "0";
            // 
            // btnPrint
            // 
            this.btnPrint.ActiveControl = null;
            this.btnPrint.BackColor = System.Drawing.Color.RosyBrown;
            this.btnPrint.Location = new System.Drawing.Point(702, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(82, 40);
            this.btnPrint.Style = MetroFramework.MetroColorStyle.Green;
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrint.UseCustomBackColor = true;
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSave.Location = new System.Drawing.Point(785, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 40);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNext
            // 
            this.btnNext.ActiveControl = null;
            this.btnNext.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNext.Location = new System.Drawing.Point(622, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(79, 40);
            this.btnNext.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNext.UseCustomBackColor = true;
            this.btnNext.UseSelectable = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnNew
            // 
            this.btnNew.ActiveControl = null;
            this.btnNew.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNew.Location = new System.Drawing.Point(1024, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(101, 40);
            this.btnNew.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New Voucher";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNew.UseCustomBackColor = true;
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveControl = null;
            this.btnDelete.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDelete.Location = new System.Drawing.Point(866, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 40);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Red;
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.UseCustomBackColor = true;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.ActiveControl = null;
            this.btnPrevious.BackColor = System.Drawing.Color.RosyBrown;
            this.btnPrevious.Location = new System.Drawing.Point(536, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(85, 40);
            this.btnPrevious.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnPrevious.TabIndex = 14;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrevious.UseCustomBackColor = true;
            this.btnPrevious.UseSelectable = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnClose
            // 
            this.btnClose.ActiveControl = null;
            this.btnClose.BackColor = System.Drawing.Color.RosyBrown;
            this.btnClose.Location = new System.Drawing.Point(944, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 40);
            this.btnClose.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseCustomBackColor = true;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabSales
            // 
            this.tabSales.Controls.Add(this.tabLineItems);
            this.tabSales.Controls.Add(this.tabSalesTransactions);
            this.tabSales.Location = new System.Drawing.Point(3, 226);
            this.tabSales.Name = "tabSales";
            this.tabSales.SelectedIndex = 0;
            this.tabSales.Size = new System.Drawing.Size(1130, 406);
            this.tabSales.TabIndex = 24;
            this.tabSales.SelectedIndexChanged += new System.EventHandler(this.tabSales_SelectedIndexChanged);
            // 
            // tabLineItems
            // 
            this.tabLineItems.Controls.Add(this.txtTotalAmount);
            this.tabLineItems.Controls.Add(this.metroLabel11);
            this.tabLineItems.Controls.Add(this.txtExtraDiscount);
            this.tabLineItems.Controls.Add(this.metroLabel6);
            this.tabLineItems.Controls.Add(this.txtMiscCharges);
            this.tabLineItems.Controls.Add(this.metroLabel17);
            this.tabLineItems.Controls.Add(this.txtCuttingCharges);
            this.tabLineItems.Controls.Add(this.metroLabel16);
            this.tabLineItems.Controls.Add(this.txtLoadingCharges);
            this.tabLineItems.Controls.Add(this.metroLabel15);
            this.tabLineItems.Controls.Add(this.txt2kgWeight);
            this.tabLineItems.Controls.Add(this.metroLabel21);
            this.tabLineItems.Controls.Add(this.txtManualWeight);
            this.tabLineItems.Controls.Add(this.metroLabel20);
            this.tabLineItems.Controls.Add(this.txtSystemWeight);
            this.tabLineItems.Controls.Add(this.metroLabel19);
            this.tabLineItems.Controls.Add(this.txtFreightAmount);
            this.tabLineItems.Controls.Add(this.lblFreight);
            this.tabLineItems.Controls.Add(this.txtAmountAfterDiscount);
            this.tabLineItems.Controls.Add(this.metroLabel10);
            this.tabLineItems.Controls.Add(this.txtFlatDiscount);
            this.tabLineItems.Controls.Add(this.metroLabel5);
            this.tabLineItems.Controls.Add(this.txtTotalDiscount);
            this.tabLineItems.Controls.Add(this.metroLabel8);
            this.tabLineItems.Controls.Add(this.txtBillAmount);
            this.tabLineItems.Controls.Add(this.metroLabel18);
            this.tabLineItems.Controls.Add(this.lblTotal);
            this.tabLineItems.Controls.Add(this.lblVoucherStatus);
            this.tabLineItems.Controls.Add(this.DgvStockSales);
            this.tabLineItems.Location = new System.Drawing.Point(4, 25);
            this.tabLineItems.Name = "tabLineItems";
            this.tabLineItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabLineItems.Size = new System.Drawing.Size(1122, 377);
            this.tabLineItems.TabIndex = 0;
            this.tabLineItems.Text = "Line Items";
            this.tabLineItems.UseVisualStyleBackColor = true;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtTotalAmount.CustomButton.Image = null;
            this.txtTotalAmount.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txtTotalAmount.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalAmount.CustomButton.Name = "";
            this.txtTotalAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalAmount.CustomButton.TabIndex = 1;
            this.txtTotalAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalAmount.CustomButton.UseSelectable = true;
            this.txtTotalAmount.CustomButton.Visible = false;
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Lines = new string[0];
            this.txtTotalAmount.Location = new System.Drawing.Point(956, 349);
            this.txtTotalAmount.MaxLength = 32767;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.PasswordChar = '\0';
            this.txtTotalAmount.PromptText = "Total Credit";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalAmount.SelectedText = "";
            this.txtTotalAmount.SelectionLength = 0;
            this.txtTotalAmount.SelectionStart = 0;
            this.txtTotalAmount.ShortcutsEnabled = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(160, 23);
            this.txtTotalAmount.TabIndex = 42;
            this.txtTotalAmount.UseCustomBackColor = true;
            this.txtTotalAmount.UseSelectable = true;
            this.txtTotalAmount.WaterMark = "Total Credit";
            this.txtTotalAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(831, 348);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(86, 19);
            this.metroLabel11.TabIndex = 47;
            this.metroLabel11.Text = "Total Credit :";
            // 
            // txtExtraDiscount
            // 
            this.txtExtraDiscount.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtExtraDiscount.CustomButton.Image = null;
            this.txtExtraDiscount.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txtExtraDiscount.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtExtraDiscount.CustomButton.Name = "";
            this.txtExtraDiscount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtExtraDiscount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtExtraDiscount.CustomButton.TabIndex = 1;
            this.txtExtraDiscount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtExtraDiscount.CustomButton.UseSelectable = true;
            this.txtExtraDiscount.CustomButton.Visible = false;
            this.txtExtraDiscount.Lines = new string[0];
            this.txtExtraDiscount.Location = new System.Drawing.Point(659, 274);
            this.txtExtraDiscount.MaxLength = 32767;
            this.txtExtraDiscount.Name = "txtExtraDiscount";
            this.txtExtraDiscount.PasswordChar = '\0';
            this.txtExtraDiscount.PromptText = "Extra Disc";
            this.txtExtraDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtExtraDiscount.SelectedText = "";
            this.txtExtraDiscount.SelectionLength = 0;
            this.txtExtraDiscount.SelectionStart = 0;
            this.txtExtraDiscount.ShortcutsEnabled = true;
            this.txtExtraDiscount.Size = new System.Drawing.Size(160, 23);
            this.txtExtraDiscount.TabIndex = 42;
            this.txtExtraDiscount.UseCustomBackColor = true;
            this.txtExtraDiscount.UseSelectable = true;
            this.txtExtraDiscount.WaterMark = "Extra Disc";
            this.txtExtraDiscount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtExtraDiscount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtExtraDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExtraDiscount_KeyPress);
            this.txtExtraDiscount.Leave += new System.EventHandler(this.txtExtraDiscount_Leave);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(534, 272);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(75, 19);
            this.metroLabel6.TabIndex = 47;
            this.metroLabel6.Text = "Extra Disc :";
            // 
            // txtMiscCharges
            // 
            this.txtMiscCharges.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtMiscCharges.CustomButton.Image = null;
            this.txtMiscCharges.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txtMiscCharges.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtMiscCharges.CustomButton.Name = "";
            this.txtMiscCharges.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMiscCharges.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMiscCharges.CustomButton.TabIndex = 1;
            this.txtMiscCharges.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMiscCharges.CustomButton.UseSelectable = true;
            this.txtMiscCharges.CustomButton.Visible = false;
            this.txtMiscCharges.Lines = new string[] {
        "0"};
            this.txtMiscCharges.Location = new System.Drawing.Point(956, 324);
            this.txtMiscCharges.MaxLength = 32767;
            this.txtMiscCharges.Name = "txtMiscCharges";
            this.txtMiscCharges.PasswordChar = '\0';
            this.txtMiscCharges.PromptText = "Total Freigh";
            this.txtMiscCharges.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMiscCharges.SelectedText = "";
            this.txtMiscCharges.SelectionLength = 0;
            this.txtMiscCharges.SelectionStart = 0;
            this.txtMiscCharges.ShortcutsEnabled = true;
            this.txtMiscCharges.Size = new System.Drawing.Size(160, 23);
            this.txtMiscCharges.TabIndex = 43;
            this.txtMiscCharges.Text = "0";
            this.txtMiscCharges.UseCustomBackColor = true;
            this.txtMiscCharges.UseSelectable = true;
            this.txtMiscCharges.WaterMark = "Total Freigh";
            this.txtMiscCharges.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMiscCharges.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMiscCharges.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiscCharges_KeyPress);
            this.txtMiscCharges.Leave += new System.EventHandler(this.txtMiscCharges_Leave);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel17.Location = new System.Drawing.Point(830, 324);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(98, 19);
            this.metroLabel17.TabIndex = 46;
            this.metroLabel17.Text = "Misc Charges :";
            // 
            // txtCuttingCharges
            // 
            this.txtCuttingCharges.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtCuttingCharges.CustomButton.Image = null;
            this.txtCuttingCharges.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txtCuttingCharges.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtCuttingCharges.CustomButton.Name = "";
            this.txtCuttingCharges.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCuttingCharges.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCuttingCharges.CustomButton.TabIndex = 1;
            this.txtCuttingCharges.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCuttingCharges.CustomButton.UseSelectable = true;
            this.txtCuttingCharges.CustomButton.Visible = false;
            this.txtCuttingCharges.Lines = new string[] {
        "0"};
            this.txtCuttingCharges.Location = new System.Drawing.Point(956, 298);
            this.txtCuttingCharges.MaxLength = 32767;
            this.txtCuttingCharges.Name = "txtCuttingCharges";
            this.txtCuttingCharges.PasswordChar = '\0';
            this.txtCuttingCharges.PromptText = "Total Freigh";
            this.txtCuttingCharges.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCuttingCharges.SelectedText = "";
            this.txtCuttingCharges.SelectionLength = 0;
            this.txtCuttingCharges.SelectionStart = 0;
            this.txtCuttingCharges.ShortcutsEnabled = true;
            this.txtCuttingCharges.Size = new System.Drawing.Size(160, 23);
            this.txtCuttingCharges.TabIndex = 43;
            this.txtCuttingCharges.Text = "0";
            this.txtCuttingCharges.UseCustomBackColor = true;
            this.txtCuttingCharges.UseSelectable = true;
            this.txtCuttingCharges.WaterMark = "Total Freigh";
            this.txtCuttingCharges.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCuttingCharges.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCuttingCharges.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuttingCharges_KeyPress);
            this.txtCuttingCharges.Leave += new System.EventHandler(this.txtCuttingCharges_Leave);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel16.Location = new System.Drawing.Point(830, 299);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(116, 19);
            this.metroLabel16.TabIndex = 46;
            this.metroLabel16.Text = "Cutting Charges :";
            // 
            // txtLoadingCharges
            // 
            this.txtLoadingCharges.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtLoadingCharges.CustomButton.Image = null;
            this.txtLoadingCharges.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txtLoadingCharges.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoadingCharges.CustomButton.Name = "";
            this.txtLoadingCharges.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLoadingCharges.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLoadingCharges.CustomButton.TabIndex = 1;
            this.txtLoadingCharges.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLoadingCharges.CustomButton.UseSelectable = true;
            this.txtLoadingCharges.CustomButton.Visible = false;
            this.txtLoadingCharges.Lines = new string[0];
            this.txtLoadingCharges.Location = new System.Drawing.Point(956, 272);
            this.txtLoadingCharges.MaxLength = 32767;
            this.txtLoadingCharges.Name = "txtLoadingCharges";
            this.txtLoadingCharges.PasswordChar = '\0';
            this.txtLoadingCharges.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLoadingCharges.SelectedText = "";
            this.txtLoadingCharges.SelectionLength = 0;
            this.txtLoadingCharges.SelectionStart = 0;
            this.txtLoadingCharges.ShortcutsEnabled = true;
            this.txtLoadingCharges.Size = new System.Drawing.Size(160, 23);
            this.txtLoadingCharges.TabIndex = 43;
            this.txtLoadingCharges.UseCustomBackColor = true;
            this.txtLoadingCharges.UseSelectable = true;
            this.txtLoadingCharges.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLoadingCharges.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLoadingCharges.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoadingCharges_KeyPress);
            this.txtLoadingCharges.Leave += new System.EventHandler(this.txtLoadingCharges_Leave);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel15.Location = new System.Drawing.Point(830, 274);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(119, 19);
            this.metroLabel15.TabIndex = 46;
            this.metroLabel15.Text = "Loading Charges :";
            // 
            // txt2kgWeight
            // 
            this.txt2kgWeight.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txt2kgWeight.CustomButton.Image = null;
            this.txt2kgWeight.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.txt2kgWeight.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt2kgWeight.CustomButton.Name = "";
            this.txt2kgWeight.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt2kgWeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt2kgWeight.CustomButton.TabIndex = 1;
            this.txt2kgWeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt2kgWeight.CustomButton.UseSelectable = true;
            this.txt2kgWeight.CustomButton.Visible = false;
            this.txt2kgWeight.Lines = new string[] {
        "0"};
            this.txt2kgWeight.Location = new System.Drawing.Point(404, 333);
            this.txt2kgWeight.MaxLength = 32767;
            this.txt2kgWeight.Name = "txt2kgWeight";
            this.txt2kgWeight.PasswordChar = '\0';
            this.txt2kgWeight.ReadOnly = true;
            this.txt2kgWeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt2kgWeight.SelectedText = "";
            this.txt2kgWeight.SelectionLength = 0;
            this.txt2kgWeight.SelectionStart = 0;
            this.txt2kgWeight.ShortcutsEnabled = true;
            this.txt2kgWeight.Size = new System.Drawing.Size(111, 23);
            this.txt2kgWeight.TabIndex = 43;
            this.txt2kgWeight.Text = "0";
            this.txt2kgWeight.UseCustomBackColor = true;
            this.txt2kgWeight.UseSelectable = true;
            this.txt2kgWeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt2kgWeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel21.Location = new System.Drawing.Point(277, 333);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(124, 19);
            this.metroLabel21.TabIndex = 46;
            this.metroLabel21.Text = "Auto Weight(2kg) :";
            // 
            // txtManualWeight
            // 
            this.txtManualWeight.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtManualWeight.CustomButton.Image = null;
            this.txtManualWeight.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.txtManualWeight.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtManualWeight.CustomButton.Name = "";
            this.txtManualWeight.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtManualWeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtManualWeight.CustomButton.TabIndex = 1;
            this.txtManualWeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtManualWeight.CustomButton.UseSelectable = true;
            this.txtManualWeight.CustomButton.Visible = false;
            this.txtManualWeight.Lines = new string[] {
        "0"};
            this.txtManualWeight.Location = new System.Drawing.Point(404, 304);
            this.txtManualWeight.MaxLength = 32767;
            this.txtManualWeight.Name = "txtManualWeight";
            this.txtManualWeight.PasswordChar = '\0';
            this.txtManualWeight.PromptText = "Total Freigh";
            this.txtManualWeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtManualWeight.SelectedText = "";
            this.txtManualWeight.SelectionLength = 0;
            this.txtManualWeight.SelectionStart = 0;
            this.txtManualWeight.ShortcutsEnabled = true;
            this.txtManualWeight.Size = new System.Drawing.Size(111, 23);
            this.txtManualWeight.TabIndex = 43;
            this.txtManualWeight.Text = "0";
            this.txtManualWeight.UseCustomBackColor = true;
            this.txtManualWeight.UseSelectable = true;
            this.txtManualWeight.WaterMark = "Total Freigh";
            this.txtManualWeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtManualWeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtManualWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtManualWeight_KeyPress);
            this.txtManualWeight.Leave += new System.EventHandler(this.txtManualWeight_Leave);
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel20.Location = new System.Drawing.Point(283, 304);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(109, 19);
            this.metroLabel20.TabIndex = 46;
            this.metroLabel20.Text = "Manual Weight :";
            // 
            // txtSystemWeight
            // 
            this.txtSystemWeight.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtSystemWeight.CustomButton.Image = null;
            this.txtSystemWeight.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.txtSystemWeight.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtSystemWeight.CustomButton.Name = "";
            this.txtSystemWeight.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSystemWeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSystemWeight.CustomButton.TabIndex = 1;
            this.txtSystemWeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSystemWeight.CustomButton.UseSelectable = true;
            this.txtSystemWeight.CustomButton.Visible = false;
            this.txtSystemWeight.Lines = new string[] {
        "0"};
            this.txtSystemWeight.Location = new System.Drawing.Point(404, 275);
            this.txtSystemWeight.MaxLength = 32767;
            this.txtSystemWeight.Name = "txtSystemWeight";
            this.txtSystemWeight.PasswordChar = '\0';
            this.txtSystemWeight.PromptText = "Total Freigh";
            this.txtSystemWeight.ReadOnly = true;
            this.txtSystemWeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSystemWeight.SelectedText = "";
            this.txtSystemWeight.SelectionLength = 0;
            this.txtSystemWeight.SelectionStart = 0;
            this.txtSystemWeight.ShortcutsEnabled = true;
            this.txtSystemWeight.Size = new System.Drawing.Size(111, 23);
            this.txtSystemWeight.TabIndex = 43;
            this.txtSystemWeight.Text = "0";
            this.txtSystemWeight.UseCustomBackColor = true;
            this.txtSystemWeight.UseSelectable = true;
            this.txtSystemWeight.WaterMark = "Total Freigh";
            this.txtSystemWeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSystemWeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSystemWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFreigh_KeyPress);
            this.txtSystemWeight.Leave += new System.EventHandler(this.txtFreightAmount_Leave);
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel19.Location = new System.Drawing.Point(283, 275);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(107, 19);
            this.metroLabel19.TabIndex = 46;
            this.metroLabel19.Text = "System Weight :";
            // 
            // txtFreightAmount
            // 
            this.txtFreightAmount.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtFreightAmount.CustomButton.Image = null;
            this.txtFreightAmount.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txtFreightAmount.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtFreightAmount.CustomButton.Name = "";
            this.txtFreightAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFreightAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFreightAmount.CustomButton.TabIndex = 1;
            this.txtFreightAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFreightAmount.CustomButton.UseSelectable = true;
            this.txtFreightAmount.CustomButton.Visible = false;
            this.txtFreightAmount.Lines = new string[] {
        "0"};
            this.txtFreightAmount.Location = new System.Drawing.Point(658, 323);
            this.txtFreightAmount.MaxLength = 32767;
            this.txtFreightAmount.Name = "txtFreightAmount";
            this.txtFreightAmount.PasswordChar = '\0';
            this.txtFreightAmount.PromptText = "Total Freigh";
            this.txtFreightAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFreightAmount.SelectedText = "";
            this.txtFreightAmount.SelectionLength = 0;
            this.txtFreightAmount.SelectionStart = 0;
            this.txtFreightAmount.ShortcutsEnabled = true;
            this.txtFreightAmount.Size = new System.Drawing.Size(160, 23);
            this.txtFreightAmount.TabIndex = 43;
            this.txtFreightAmount.Text = "0";
            this.txtFreightAmount.UseCustomBackColor = true;
            this.txtFreightAmount.UseSelectable = true;
            this.txtFreightAmount.WaterMark = "Total Freigh";
            this.txtFreightAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFreightAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFreightAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFreigh_KeyPress);
            this.txtFreightAmount.Leave += new System.EventHandler(this.txtFreightAmount_Leave);
            // 
            // lblFreight
            // 
            this.lblFreight.AutoSize = true;
            this.lblFreight.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblFreight.Location = new System.Drawing.Point(532, 324);
            this.lblFreight.Name = "lblFreight";
            this.lblFreight.Size = new System.Drawing.Size(113, 19);
            this.lblFreight.TabIndex = 46;
            this.lblFreight.Text = "Freight Amount :";
            // 
            // txtAmountAfterDiscount
            // 
            this.txtAmountAfterDiscount.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtAmountAfterDiscount.CustomButton.Image = null;
            this.txtAmountAfterDiscount.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txtAmountAfterDiscount.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmountAfterDiscount.CustomButton.Name = "";
            this.txtAmountAfterDiscount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAmountAfterDiscount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAmountAfterDiscount.CustomButton.TabIndex = 1;
            this.txtAmountAfterDiscount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAmountAfterDiscount.CustomButton.UseSelectable = true;
            this.txtAmountAfterDiscount.CustomButton.Visible = false;
            this.txtAmountAfterDiscount.Enabled = false;
            this.txtAmountAfterDiscount.Lines = new string[0];
            this.txtAmountAfterDiscount.Location = new System.Drawing.Point(658, 299);
            this.txtAmountAfterDiscount.MaxLength = 32767;
            this.txtAmountAfterDiscount.Name = "txtAmountAfterDiscount";
            this.txtAmountAfterDiscount.PasswordChar = '\0';
            this.txtAmountAfterDiscount.PromptText = "Amount After Discount";
            this.txtAmountAfterDiscount.ReadOnly = true;
            this.txtAmountAfterDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmountAfterDiscount.SelectedText = "";
            this.txtAmountAfterDiscount.SelectionLength = 0;
            this.txtAmountAfterDiscount.SelectionStart = 0;
            this.txtAmountAfterDiscount.ShortcutsEnabled = true;
            this.txtAmountAfterDiscount.Size = new System.Drawing.Size(161, 23);
            this.txtAmountAfterDiscount.TabIndex = 38;
            this.txtAmountAfterDiscount.UseCustomBackColor = true;
            this.txtAmountAfterDiscount.UseSelectable = true;
            this.txtAmountAfterDiscount.WaterMark = "Amount After Discount";
            this.txtAmountAfterDiscount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAmountAfterDiscount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(530, 298);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(124, 19);
            this.metroLabel10.TabIndex = 49;
            this.metroLabel10.Text = "Discount Amount :";
            // 
            // txtFlatDiscount
            // 
            this.txtFlatDiscount.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtFlatDiscount.CustomButton.Image = null;
            this.txtFlatDiscount.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txtFlatDiscount.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtFlatDiscount.CustomButton.Name = "";
            this.txtFlatDiscount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFlatDiscount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFlatDiscount.CustomButton.TabIndex = 1;
            this.txtFlatDiscount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFlatDiscount.CustomButton.UseSelectable = true;
            this.txtFlatDiscount.CustomButton.Visible = false;
            this.txtFlatDiscount.Enabled = false;
            this.txtFlatDiscount.Lines = new string[0];
            this.txtFlatDiscount.Location = new System.Drawing.Point(110, 324);
            this.txtFlatDiscount.MaxLength = 32767;
            this.txtFlatDiscount.Name = "txtFlatDiscount";
            this.txtFlatDiscount.PasswordChar = '\0';
            this.txtFlatDiscount.PromptText = "Flat Discount";
            this.txtFlatDiscount.ReadOnly = true;
            this.txtFlatDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFlatDiscount.SelectedText = "";
            this.txtFlatDiscount.SelectionLength = 0;
            this.txtFlatDiscount.SelectionStart = 0;
            this.txtFlatDiscount.ShortcutsEnabled = true;
            this.txtFlatDiscount.Size = new System.Drawing.Size(161, 23);
            this.txtFlatDiscount.TabIndex = 39;
            this.txtFlatDiscount.UseCustomBackColor = true;
            this.txtFlatDiscount.UseSelectable = true;
            this.txtFlatDiscount.WaterMark = "Flat Discount";
            this.txtFlatDiscount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFlatDiscount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(7, 325);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(96, 19);
            this.metroLabel5.TabIndex = 48;
            this.metroLabel5.Text = "Flat Discount :";
            // 
            // txtTotalDiscount
            // 
            this.txtTotalDiscount.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtTotalDiscount.CustomButton.Image = null;
            this.txtTotalDiscount.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txtTotalDiscount.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalDiscount.CustomButton.Name = "";
            this.txtTotalDiscount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalDiscount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalDiscount.CustomButton.TabIndex = 1;
            this.txtTotalDiscount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalDiscount.CustomButton.UseSelectable = true;
            this.txtTotalDiscount.CustomButton.Visible = false;
            this.txtTotalDiscount.Enabled = false;
            this.txtTotalDiscount.Lines = new string[0];
            this.txtTotalDiscount.Location = new System.Drawing.Point(110, 299);
            this.txtTotalDiscount.MaxLength = 32767;
            this.txtTotalDiscount.Name = "txtTotalDiscount";
            this.txtTotalDiscount.PasswordChar = '\0';
            this.txtTotalDiscount.PromptText = "Total Discount";
            this.txtTotalDiscount.ReadOnly = true;
            this.txtTotalDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalDiscount.SelectedText = "";
            this.txtTotalDiscount.SelectionLength = 0;
            this.txtTotalDiscount.SelectionStart = 0;
            this.txtTotalDiscount.ShortcutsEnabled = true;
            this.txtTotalDiscount.Size = new System.Drawing.Size(161, 23);
            this.txtTotalDiscount.TabIndex = 40;
            this.txtTotalDiscount.UseCustomBackColor = true;
            this.txtTotalDiscount.UseSelectable = true;
            this.txtTotalDiscount.WaterMark = "Total Discount";
            this.txtTotalDiscount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalDiscount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(7, 299);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(103, 19);
            this.metroLabel8.TabIndex = 44;
            this.metroLabel8.Text = "Total Discount :";
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtBillAmount.CustomButton.Image = null;
            this.txtBillAmount.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txtBillAmount.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtBillAmount.CustomButton.Name = "";
            this.txtBillAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBillAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBillAmount.CustomButton.TabIndex = 1;
            this.txtBillAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBillAmount.CustomButton.UseSelectable = true;
            this.txtBillAmount.CustomButton.Visible = false;
            this.txtBillAmount.Enabled = false;
            this.txtBillAmount.Lines = new string[0];
            this.txtBillAmount.Location = new System.Drawing.Point(110, 275);
            this.txtBillAmount.MaxLength = 32767;
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.PasswordChar = '\0';
            this.txtBillAmount.PromptText = "Total Bill Amount";
            this.txtBillAmount.ReadOnly = true;
            this.txtBillAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBillAmount.SelectedText = "";
            this.txtBillAmount.SelectionLength = 0;
            this.txtBillAmount.SelectionStart = 0;
            this.txtBillAmount.ShortcutsEnabled = true;
            this.txtBillAmount.Size = new System.Drawing.Size(161, 23);
            this.txtBillAmount.TabIndex = 41;
            this.txtBillAmount.UseCustomBackColor = true;
            this.txtBillAmount.UseSelectable = true;
            this.txtBillAmount.WaterMark = "Total Bill Amount";
            this.txtBillAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBillAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel18.ForeColor = System.Drawing.Color.Red;
            this.metroLabel18.Location = new System.Drawing.Point(468, 369);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(0, 0);
            this.metroLabel18.TabIndex = 37;
            this.metroLabel18.UseCustomForeColor = true;
            this.metroLabel18.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTotal.Location = new System.Drawing.Point(7, 275);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(87, 19);
            this.lblTotal.TabIndex = 45;
            this.lblTotal.Text = "Bill Amount :";
            // 
            // lblVoucherStatus
            // 
            this.lblVoucherStatus.AutoSize = true;
            this.lblVoucherStatus.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblVoucherStatus.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblVoucherStatus.ForeColor = System.Drawing.Color.Red;
            this.lblVoucherStatus.Location = new System.Drawing.Point(9, 346);
            this.lblVoucherStatus.Name = "lblVoucherStatus";
            this.lblVoucherStatus.Size = new System.Drawing.Size(0, 0);
            this.lblVoucherStatus.TabIndex = 37;
            this.lblVoucherStatus.UseCustomForeColor = true;
            this.lblVoucherStatus.Visible = false;
            // 
            // DgvStockSales
            // 
            this.DgvStockSales.AllowUserToDeleteRows = false;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvStockSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            this.DgvStockSales.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvStockSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.DgvStockSales.ColumnHeadersHeight = 25;
            this.DgvStockSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdVoucherDetail,
            this.colAutoWeight,
            this.colIdItem,
            this.colItemNo,
            this.colItemName,
            this.colpacking,
            this.colCartons,
            this.colBatchNo,
            this.colExpiry,
            this.colEngineNo,
            this.colChassisNo,
            this.colVehicleModel,
            this.colVehicleColors,
            this.colVehicleNo,
            this.colFirstIMEI,
            this.colSecondIMEI,
            this.colCurrentStock,
            this.colQty,
            this.colBonusUnit,
            this.colWeight,
            this.colUnitPrice,
            this.colAmount,
            this.colDiscount,
            this.colLineDisc,
            this.colFlatDiscount,
            this.colDiscountAmount,
            this.colDelete});
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvStockSales.DefaultCellStyle = dataGridViewCellStyle33;
            this.DgvStockSales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvStockSales.EnableHeadersVisualStyles = false;
            this.DgvStockSales.Location = new System.Drawing.Point(6, 8);
            this.DgvStockSales.MultiSelect = false;
            this.DgvStockSales.Name = "DgvStockSales";
            this.DgvStockSales.RowHeadersVisible = false;
            this.DgvStockSales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvStockSales.Size = new System.Drawing.Size(1113, 261);
            this.DgvStockSales.TabIndex = 1;
            this.DgvStockSales.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DgvStockSales_CellBeginEdit);
            this.DgvStockSales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStockSales_CellClick);
            this.DgvStockSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStockSales_CellContentClick);
            this.DgvStockSales.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStockSales_CellEndEdit);
            this.DgvStockSales.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStockSales_CellEnter);
            this.DgvStockSales.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvStockSales_CellFormatting);
            this.DgvStockSales.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStockSales_CellLeave);
            this.DgvStockSales.CurrentCellDirtyStateChanged += new System.EventHandler(this.DgvStockSales_CurrentCellDirtyStateChanged);
            this.DgvStockSales.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgvStockSales_EditingControlShowing);
            this.DgvStockSales.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DgvStockSales_RowValidating);
            this.DgvStockSales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DgvStockSales_KeyPress);
            // 
            // ColIdVoucherDetail
            // 
            this.ColIdVoucherDetail.HeaderText = "IdVoucherDetail";
            this.ColIdVoucherDetail.Name = "ColIdVoucherDetail";
            this.ColIdVoucherDetail.Visible = false;
            // 
            // colAutoWeight
            // 
            this.colAutoWeight.HeaderText = "AutoWeightID";
            this.colAutoWeight.Name = "colAutoWeight";
            this.colAutoWeight.Visible = false;
            // 
            // colIdItem
            // 
            this.colIdItem.HeaderText = "IdItem";
            this.colIdItem.Name = "colIdItem";
            this.colIdItem.Visible = false;
            // 
            // colItemNo
            // 
            this.colItemNo.DataPropertyName = "AccountNo";
            this.colItemNo.HeaderText = "Product Code";
            this.colItemNo.Name = "colItemNo";
            this.colItemNo.Visible = false;
            // 
            // colItemName
            // 
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colItemName.DefaultCellStyle = dataGridViewCellStyle30;
            this.colItemName.HeaderText = "Product Discription";
            this.colItemName.Name = "colItemName";
            this.colItemName.WatermarkText = "Type Here For Product Selection";
            this.colItemName.Width = 250;
            // 
            // colpacking
            // 
            this.colpacking.HeaderText = "UOM";
            this.colpacking.Name = "colpacking";
            this.colpacking.ReadOnly = true;
            this.colpacking.Width = 90;
            // 
            // colCartons
            // 
            this.colCartons.HeaderText = "CTN / BGS";
            this.colCartons.Name = "colCartons";
            this.colCartons.Width = 90;
            // 
            // colBatchNo
            // 
            this.colBatchNo.HeaderText = "BatchNo";
            this.colBatchNo.Name = "colBatchNo";
            this.colBatchNo.Width = 90;
            // 
            // colExpiry
            // 
            this.colExpiry.HeaderText = "Expiry";
            this.colExpiry.Name = "colExpiry";
            this.colExpiry.Width = 90;
            // 
            // colEngineNo
            // 
            this.colEngineNo.HeaderText = "Engine #";
            this.colEngineNo.Name = "colEngineNo";
            this.colEngineNo.Width = 80;
            // 
            // colChassisNo
            // 
            this.colChassisNo.HeaderText = "Chassis #";
            this.colChassisNo.Name = "colChassisNo";
            this.colChassisNo.Width = 80;
            // 
            // colVehicleModel
            // 
            this.colVehicleModel.HeaderText = "Model";
            this.colVehicleModel.Name = "colVehicleModel";
            this.colVehicleModel.Width = 80;
            // 
            // colVehicleColors
            // 
            this.colVehicleColors.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colVehicleColors.HeaderText = "Color";
            this.colVehicleColors.Items.AddRange(new object[] {
            "",
            "Red",
            "Black",
            "Blue",
            "Silver"});
            this.colVehicleColors.Name = "colVehicleColors";
            this.colVehicleColors.Width = 80;
            // 
            // colVehicleNo
            // 
            this.colVehicleNo.HeaderText = "Vehicle #";
            this.colVehicleNo.Name = "colVehicleNo";
            this.colVehicleNo.Width = 90;
            // 
            // colFirstIMEI
            // 
            this.colFirstIMEI.HeaderText = "IMEI #";
            this.colFirstIMEI.Name = "colFirstIMEI";
            // 
            // colSecondIMEI
            // 
            this.colSecondIMEI.HeaderText = "Second IMEI";
            this.colSecondIMEI.Name = "colSecondIMEI";
            // 
            // colCurrentStock
            // 
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.Red;
            this.colCurrentStock.DefaultCellStyle = dataGridViewCellStyle31;
            this.colCurrentStock.HeaderText = "Current Stock";
            this.colCurrentStock.Name = "colCurrentStock";
            this.colCurrentStock.ReadOnly = true;
            // 
            // colQty
            // 
            this.colQty.DataPropertyName = "Qty";
            this.colQty.HeaderText = "Quantity";
            this.colQty.Name = "colQty";
            this.colQty.Width = 80;
            // 
            // colBonusUnit
            // 
            this.colBonusUnit.HeaderText = "Bonus";
            this.colBonusUnit.Name = "colBonusUnit";
            this.colBonusUnit.Visible = false;
            // 
            // colWeight
            // 
            this.colWeight.HeaderText = "Weight";
            this.colWeight.Name = "colWeight";
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "Amount";
            this.colUnitPrice.HeaderText = "Unit Price";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Width = 90;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "qty*amount";
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colDiscount
            // 
            this.colDiscount.HeaderText = "Disc(%)";
            this.colDiscount.Name = "colDiscount";
            // 
            // colLineDisc
            // 
            this.colLineDisc.HeaderText = "Line Disc";
            this.colLineDisc.Name = "colLineDisc";
            this.colLineDisc.ReadOnly = true;
            // 
            // colFlatDiscount
            // 
            this.colFlatDiscount.HeaderText = "Flat Disc";
            this.colFlatDiscount.Name = "colFlatDiscount";
            // 
            // colDiscountAmount
            // 
            this.colDiscountAmount.HeaderText = "Net Amount";
            this.colDiscountAmount.Name = "colDiscountAmount";
            this.colDiscountAmount.ReadOnly = true;
            // 
            // colDelete
            // 
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.Red;
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle32;
            this.colDelete.HeaderText = "...";
            this.colDelete.Name = "colDelete";
            this.colDelete.Width = 80;
            // 
            // tabSalesTransactions
            // 
            this.tabSalesTransactions.Controls.Add(this.DgvSalesTransactions);
            this.tabSalesTransactions.Location = new System.Drawing.Point(4, 25);
            this.tabSalesTransactions.Name = "tabSalesTransactions";
            this.tabSalesTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalesTransactions.Size = new System.Drawing.Size(1122, 377);
            this.tabSalesTransactions.TabIndex = 1;
            this.tabSalesTransactions.Text = "Transactions";
            this.tabSalesTransactions.UseVisualStyleBackColor = true;
            // 
            // DgvSalesTransactions
            // 
            this.DgvSalesTransactions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvSalesTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle34;
            this.DgvSalesTransactions.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvSalesTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.DgvSalesTransactions.ColumnHeadersHeight = 25;
            this.DgvSalesTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdDetailVoucher,
            this.colIdAccount,
            this.colAccountNo,
            this.colAccountName,
            this.colClosingBalance,
            this.colDescription,
            this.colDebit,
            this.colCredit});
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSalesTransactions.DefaultCellStyle = dataGridViewCellStyle36;
            this.DgvSalesTransactions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvSalesTransactions.EnableHeadersVisualStyles = false;
            this.DgvSalesTransactions.Location = new System.Drawing.Point(4, 6);
            this.DgvSalesTransactions.MultiSelect = false;
            this.DgvSalesTransactions.Name = "DgvSalesTransactions";
            this.DgvSalesTransactions.RowHeadersVisible = false;
            this.DgvSalesTransactions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvSalesTransactions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvSalesTransactions.Size = new System.Drawing.Size(1115, 377);
            this.DgvSalesTransactions.TabIndex = 26;
            this.DgvSalesTransactions.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSalesTransactions_CellEndEdit);
            this.DgvSalesTransactions.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSalesTransactions_CellLeave);
            this.DgvSalesTransactions.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgvSalesTransactions_EditingControlShowing);
            // 
            // ColIdDetailVoucher
            // 
            this.ColIdDetailVoucher.HeaderText = "VoucherDetailId";
            this.ColIdDetailVoucher.Name = "ColIdDetailVoucher";
            this.ColIdDetailVoucher.Visible = false;
            // 
            // colIdAccount
            // 
            this.colIdAccount.HeaderText = "AccountId";
            this.colIdAccount.Name = "colIdAccount";
            this.colIdAccount.Visible = false;
            // 
            // colAccountNo
            // 
            this.colAccountNo.DataPropertyName = "AccountNo";
            this.colAccountNo.HeaderText = "Acc. #";
            this.colAccountNo.Name = "colAccountNo";
            this.colAccountNo.Visible = false;
            // 
            // colAccountName
            // 
            this.colAccountName.HeaderText = "A/C Name";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.Width = 400;
            // 
            // colClosingBalance
            // 
            this.colClosingBalance.HeaderText = "Closing Balance";
            this.colClosingBalance.Name = "colClosingBalance";
            this.colClosingBalance.Width = 120;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Narration";
            this.colDescription.Name = "colDescription";
            this.colDescription.Width = 340;
            // 
            // colDebit
            // 
            this.colDebit.HeaderText = "Debit";
            this.colDebit.Name = "colDebit";
            this.colDebit.Width = 120;
            // 
            // colCredit
            // 
            this.colCredit.HeaderText = "Credit";
            this.colCredit.Name = "colCredit";
            this.colCredit.Width = 120;
            // 
            // grpDebitor
            // 
            this.grpDebitor.BackColor = System.Drawing.Color.MistyRose;
            this.grpDebitor.Controls.Add(this.rdCash);
            this.grpDebitor.Controls.Add(this.rdCredit);
            this.grpDebitor.Controls.Add(this.metroLabel4);
            this.grpDebitor.Controls.Add(this.metroLabel9);
            this.grpDebitor.Controls.Add(this.grpSales);
            this.grpDebitor.Controls.Add(this.txtDeliveryPerson);
            this.grpDebitor.Controls.Add(this.EmpEditCode);
            this.grpDebitor.Controls.Add(this.btnAddCustomer);
            this.grpDebitor.Controls.Add(this.txtCurrentBalance);
            this.grpDebitor.Controls.Add(this.btnViewDetail);
            this.grpDebitor.Controls.Add(this.txtContact);
            this.grpDebitor.Controls.Add(this.SEditBox);
            this.grpDebitor.Controls.Add(this.metroLabel2);
            this.grpDebitor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDebitor.Location = new System.Drawing.Point(3, 119);
            this.grpDebitor.Name = "grpDebitor";
            this.grpDebitor.Size = new System.Drawing.Size(1126, 101);
            this.grpDebitor.TabIndex = 22;
            this.grpDebitor.TabStop = false;
            this.grpDebitor.Text = "Accounts Information";
            // 
            // rdCash
            // 
            this.rdCash.AutoSize = true;
            this.rdCash.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdCash.ForeColor = System.Drawing.Color.Black;
            this.rdCash.Location = new System.Drawing.Point(237, 77);
            this.rdCash.Name = "rdCash";
            this.rdCash.Size = new System.Drawing.Size(89, 19);
            this.rdCash.TabIndex = 33;
            this.rdCash.Text = "Cash Sales";
            this.rdCash.UseCustomBackColor = true;
            this.rdCash.UseCustomForeColor = true;
            this.rdCash.UseSelectable = true;
            this.rdCash.CheckedChanged += new System.EventHandler(this.rdCash_CheckedChanged);
            this.rdCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rdCash_KeyPress);
            // 
            // rdCredit
            // 
            this.rdCredit.AutoSize = true;
            this.rdCredit.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdCredit.ForeColor = System.Drawing.Color.Black;
            this.rdCredit.Location = new System.Drawing.Point(101, 78);
            this.rdCredit.Name = "rdCredit";
            this.rdCredit.Size = new System.Drawing.Size(96, 19);
            this.rdCredit.TabIndex = 32;
            this.rdCredit.Text = "Credit Sales";
            this.rdCredit.UseCustomBackColor = true;
            this.rdCredit.UseCustomForeColor = true;
            this.rdCredit.UseSelectable = true;
            this.rdCredit.CheckedChanged += new System.EventHandler(this.rdCredit_CheckedChanged);
            this.rdCredit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rdCredit_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(445, 50);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(110, 19);
            this.metroLabel4.TabIndex = 30;
            this.metroLabel4.Text = "Delivery Person :";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(7, 50);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(87, 19);
            this.metroLabel9.TabIndex = 31;
            this.metroLabel9.Text = "Order Taker :";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel9.UseCustomBackColor = true;
            // 
            // grpSales
            // 
            this.grpSales.BackColor = System.Drawing.Color.MistyRose;
            this.grpSales.Controls.Add(this.flowPurchasesPanel);
            this.grpSales.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSales.Location = new System.Drawing.Point(916, 23);
            this.grpSales.Name = "grpSales";
            this.grpSales.Size = new System.Drawing.Size(46, 18);
            this.grpSales.TabIndex = 23;
            this.grpSales.TabStop = false;
            this.grpSales.Text = "Sales Information";
            this.grpSales.Visible = false;
            // 
            // flowPurchasesPanel
            // 
            this.flowPurchasesPanel.Controls.Add(this.pnlCash);
            this.flowPurchasesPanel.Controls.Add(this.panel2);
            this.flowPurchasesPanel.Location = new System.Drawing.Point(6, 17);
            this.flowPurchasesPanel.Name = "flowPurchasesPanel";
            this.flowPurchasesPanel.Size = new System.Drawing.Size(1001, 43);
            this.flowPurchasesPanel.TabIndex = 10;
            // 
            // pnlCash
            // 
            this.pnlCash.Controls.Add(this.metroLabel3);
            this.pnlCash.Controls.Add(this.btnAddCashAccount);
            this.pnlCash.Controls.Add(this.cbxCashAccounts);
            this.pnlCash.Location = new System.Drawing.Point(3, 3);
            this.pnlCash.Name = "pnlCash";
            this.pnlCash.Size = new System.Drawing.Size(435, 35);
            this.pnlCash.TabIndex = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(6, 7);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(73, 19);
            this.metroLabel3.TabIndex = 24;
            this.metroLabel3.Text = "Cash A/C :";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // btnAddCashAccount
            // 
            this.btnAddCashAccount.Location = new System.Drawing.Point(317, 4);
            this.btnAddCashAccount.Name = "btnAddCashAccount";
            this.btnAddCashAccount.Size = new System.Drawing.Size(112, 29);
            this.btnAddCashAccount.TabIndex = 17;
            this.btnAddCashAccount.Text = "Add Cash Account";
            this.btnAddCashAccount.UseSelectable = true;
            this.btnAddCashAccount.Click += new System.EventHandler(this.btnAddCashAccount_Click);
            // 
            // cbxCashAccounts
            // 
            this.cbxCashAccounts.FormattingEnabled = true;
            this.cbxCashAccounts.ItemHeight = 23;
            this.cbxCashAccounts.Location = new System.Drawing.Point(80, 4);
            this.cbxCashAccounts.Name = "cbxCashAccounts";
            this.cbxCashAccounts.Size = new System.Drawing.Size(233, 29);
            this.cbxCashAccounts.TabIndex = 0;
            this.cbxCashAccounts.UseSelectable = true;
            this.cbxCashAccounts.SelectedIndexChanged += new System.EventHandler(this.cbxCashAccounts_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbxNaturalAccounts);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.metroLabel1);
            this.panel2.Controls.Add(this.btnAddPurchasesAccount);
            this.panel2.Location = new System.Drawing.Point(444, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 37);
            this.panel2.TabIndex = 10;
            // 
            // cbxNaturalAccounts
            // 
            this.cbxNaturalAccounts.FormattingEnabled = true;
            this.cbxNaturalAccounts.ItemHeight = 23;
            this.cbxNaturalAccounts.Location = new System.Drawing.Point(83, 5);
            this.cbxNaturalAccounts.Name = "cbxNaturalAccounts";
            this.cbxNaturalAccounts.Size = new System.Drawing.Size(227, 29);
            this.cbxNaturalAccounts.TabIndex = 0;
            this.cbxNaturalAccounts.UseSelectable = true;
            this.cbxNaturalAccounts.SelectedIndexChanged += new System.EventHandler(this.cbxNaturalAccounts_SelectedIndexChanged);
            this.cbxNaturalAccounts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxNaturalAccounts_KeyPress);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(461, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(84, 29);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 8);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Credit A/C :";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // btnAddPurchasesAccount
            // 
            this.btnAddPurchasesAccount.Location = new System.Drawing.Point(311, 5);
            this.btnAddPurchasesAccount.Name = "btnAddPurchasesAccount";
            this.btnAddPurchasesAccount.Size = new System.Drawing.Size(146, 29);
            this.btnAddPurchasesAccount.TabIndex = 17;
            this.btnAddPurchasesAccount.Text = "Add Sales Account";
            this.btnAddPurchasesAccount.UseSelectable = true;
            this.btnAddPurchasesAccount.Click += new System.EventHandler(this.btnAddPurchasesAccount_Click);
            // 
            // txtDeliveryPerson
            // 
            // 
            // 
            // 
            this.txtDeliveryPerson.CustomButton.Image = null;
            this.txtDeliveryPerson.CustomButton.Location = new System.Drawing.Point(298, 1);
            this.txtDeliveryPerson.CustomButton.Name = "";
            this.txtDeliveryPerson.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDeliveryPerson.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDeliveryPerson.CustomButton.TabIndex = 1;
            this.txtDeliveryPerson.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDeliveryPerson.CustomButton.UseSelectable = true;
            this.txtDeliveryPerson.Lines = new string[0];
            this.txtDeliveryPerson.Location = new System.Drawing.Point(563, 50);
            this.txtDeliveryPerson.MaxLength = 32767;
            this.txtDeliveryPerson.Name = "txtDeliveryPerson";
            this.txtDeliveryPerson.PasswordChar = '\0';
            this.txtDeliveryPerson.PromptText = "Type Here To Select Delivery Person";
            this.txtDeliveryPerson.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDeliveryPerson.SelectedText = "";
            this.txtDeliveryPerson.SelectionLength = 0;
            this.txtDeliveryPerson.SelectionStart = 0;
            this.txtDeliveryPerson.ShortcutsEnabled = true;
            this.txtDeliveryPerson.ShowButton = true;
            this.txtDeliveryPerson.Size = new System.Drawing.Size(320, 23);
            this.txtDeliveryPerson.Style = MetroFramework.MetroColorStyle.Green;
            this.txtDeliveryPerson.TabIndex = 28;
            this.txtDeliveryPerson.UseSelectable = true;
            this.txtDeliveryPerson.WaterMark = "Type Here To Select Delivery Person";
            this.txtDeliveryPerson.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDeliveryPerson.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDeliveryPerson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeliveryPerson_KeyPress);
            // 
            // EmpEditCode
            // 
            // 
            // 
            // 
            this.EmpEditCode.CustomButton.Image = null;
            this.EmpEditCode.CustomButton.Location = new System.Drawing.Point(316, 1);
            this.EmpEditCode.CustomButton.Name = "";
            this.EmpEditCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.EmpEditCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.EmpEditCode.CustomButton.TabIndex = 1;
            this.EmpEditCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EmpEditCode.CustomButton.UseSelectable = true;
            this.EmpEditCode.Lines = new string[0];
            this.EmpEditCode.Location = new System.Drawing.Point(101, 49);
            this.EmpEditCode.MaxLength = 32767;
            this.EmpEditCode.Name = "EmpEditCode";
            this.EmpEditCode.PasswordChar = '\0';
            this.EmpEditCode.PromptText = "Type Here To Select Order Taker";
            this.EmpEditCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EmpEditCode.SelectedText = "";
            this.EmpEditCode.SelectionLength = 0;
            this.EmpEditCode.SelectionStart = 0;
            this.EmpEditCode.ShortcutsEnabled = true;
            this.EmpEditCode.ShowButton = true;
            this.EmpEditCode.Size = new System.Drawing.Size(338, 23);
            this.EmpEditCode.Style = MetroFramework.MetroColorStyle.Brown;
            this.EmpEditCode.TabIndex = 29;
            this.EmpEditCode.UseSelectable = true;
            this.EmpEditCode.WaterMark = "Type Here To Select Order Taker";
            this.EmpEditCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EmpEditCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.EmpEditCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmpEditCode_KeyPress);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(740, 23);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(99, 23);
            this.btnAddCustomer.TabIndex = 26;
            this.btnAddCustomer.Text = "Add  Customer";
            this.btnAddCustomer.UseSelectable = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txtCurrentBalance
            // 
            // 
            // 
            // 
            this.txtCurrentBalance.CustomButton.Image = null;
            this.txtCurrentBalance.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtCurrentBalance.CustomButton.Name = "";
            this.txtCurrentBalance.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCurrentBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCurrentBalance.CustomButton.TabIndex = 1;
            this.txtCurrentBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCurrentBalance.CustomButton.UseSelectable = true;
            this.txtCurrentBalance.CustomButton.Visible = false;
            this.txtCurrentBalance.Lines = new string[0];
            this.txtCurrentBalance.Location = new System.Drawing.Point(445, 24);
            this.txtCurrentBalance.MaxLength = 32767;
            this.txtCurrentBalance.Name = "txtCurrentBalance";
            this.txtCurrentBalance.PasswordChar = '\0';
            this.txtCurrentBalance.PromptText = "Current Balance";
            this.txtCurrentBalance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCurrentBalance.SelectedText = "";
            this.txtCurrentBalance.SelectionLength = 0;
            this.txtCurrentBalance.SelectionStart = 0;
            this.txtCurrentBalance.ShortcutsEnabled = true;
            this.txtCurrentBalance.Size = new System.Drawing.Size(104, 23);
            this.txtCurrentBalance.TabIndex = 25;
            this.txtCurrentBalance.UseSelectable = true;
            this.txtCurrentBalance.WaterMark = "Current Balance";
            this.txtCurrentBalance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCurrentBalance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.Location = new System.Drawing.Point(662, 23);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(77, 23);
            this.btnViewDetail.TabIndex = 27;
            this.btnViewDetail.Text = "View Detail";
            this.btnViewDetail.UseSelectable = true;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // txtContact
            // 
            // 
            // 
            // 
            this.txtContact.CustomButton.Image = null;
            this.txtContact.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.txtContact.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtContact.CustomButton.Name = "";
            this.txtContact.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContact.CustomButton.TabIndex = 1;
            this.txtContact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContact.CustomButton.UseSelectable = true;
            this.txtContact.CustomButton.Visible = false;
            this.txtContact.Lines = new string[0];
            this.txtContact.Location = new System.Drawing.Point(549, 24);
            this.txtContact.MaxLength = 32767;
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.PromptText = "Contact";
            this.txtContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContact.SelectedText = "";
            this.txtContact.SelectionLength = 0;
            this.txtContact.SelectionStart = 0;
            this.txtContact.ShortcutsEnabled = true;
            this.txtContact.Size = new System.Drawing.Size(112, 23);
            this.txtContact.TabIndex = 21;
            this.txtContact.UseSelectable = true;
            this.txtContact.WaterMark = "Contact";
            this.txtContact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SEditBox
            // 
            // 
            // 
            // 
            this.SEditBox.CustomButton.Image = null;
            this.SEditBox.CustomButton.Location = new System.Drawing.Point(316, 1);
            this.SEditBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.SEditBox.CustomButton.Name = "";
            this.SEditBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SEditBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SEditBox.CustomButton.TabIndex = 1;
            this.SEditBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SEditBox.CustomButton.UseSelectable = true;
            this.SEditBox.Lines = new string[0];
            this.SEditBox.Location = new System.Drawing.Point(101, 23);
            this.SEditBox.MaxLength = 32767;
            this.SEditBox.Name = "SEditBox";
            this.SEditBox.PasswordChar = '\0';
            this.SEditBox.PromptText = "Account Name Here";
            this.SEditBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SEditBox.SelectedText = "";
            this.SEditBox.SelectionLength = 0;
            this.SEditBox.SelectionStart = 0;
            this.SEditBox.ShortcutsEnabled = true;
            this.SEditBox.ShowButton = true;
            this.SEditBox.Size = new System.Drawing.Size(338, 23);
            this.SEditBox.Style = MetroFramework.MetroColorStyle.Pink;
            this.SEditBox.TabIndex = 0;
            this.SEditBox.UseSelectable = true;
            this.SEditBox.WaterMark = "Account Name Here";
            this.SEditBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SEditBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SEditBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.SEditBox_ButtonClick);
            this.SEditBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SEditBox_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(7, 24);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "A/C Info :";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.VEditedDateTime);
            this.groupBox1.Controls.Add(this.metroLabel14);
            this.groupBox1.Controls.Add(this.txtCreditDays);
            this.groupBox1.Controls.Add(this.lblCreditDays);
            this.groupBox1.Controls.Add(this.dtDueDate);
            this.groupBox1.Controls.Add(this.metroLabel13);
            this.groupBox1.Controls.Add(this.VDate);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.txtGatePass);
            this.groupBox1.Controls.Add(this.metroLabel12);
            this.groupBox1.Controls.Add(this.txtDriverName);
            this.groupBox1.Controls.Add(this.txtVehicleNo);
            this.groupBox1.Controls.Add(this.txtSampleNo);
            this.groupBox1.Controls.Add(this.InvEditBox);
            this.groupBox1.Controls.Add(this.lblInvoiceNo);
            this.groupBox1.Controls.Add(this.txtSheetNo);
            this.groupBox1.Controls.Add(this.lblDiscription);
            this.groupBox1.Controls.Add(this.chkPosted);
            this.groupBox1.Controls.Add(this.txtBiltyNo);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1126, 110);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice Information";
            // 
            // VEditedDateTime
            // 
            this.VEditedDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VEditedDateTime.Location = new System.Drawing.Point(866, 19);
            this.VEditedDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.VEditedDateTime.Name = "VEditedDateTime";
            this.VEditedDateTime.Size = new System.Drawing.Size(122, 29);
            this.VEditedDateTime.TabIndex = 30;
            this.VEditedDateTime.ValueChanged += new System.EventHandler(this.VEditedDateTime_ValueChanged);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(785, 24);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(77, 19);
            this.metroLabel14.TabIndex = 29;
            this.metroLabel14.Text = "Edited On :";
            this.metroLabel14.UseCustomBackColor = true;
            // 
            // txtCreditDays
            // 
            // 
            // 
            // 
            this.txtCreditDays.CustomButton.Image = null;
            this.txtCreditDays.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.txtCreditDays.CustomButton.Name = "";
            this.txtCreditDays.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCreditDays.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCreditDays.CustomButton.TabIndex = 1;
            this.txtCreditDays.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCreditDays.CustomButton.UseSelectable = true;
            this.txtCreditDays.CustomButton.Visible = false;
            this.txtCreditDays.Lines = new string[0];
            this.txtCreditDays.Location = new System.Drawing.Point(312, 52);
            this.txtCreditDays.MaxLength = 32767;
            this.txtCreditDays.Name = "txtCreditDays";
            this.txtCreditDays.PasswordChar = '\0';
            this.txtCreditDays.PromptText = "Credit Days";
            this.txtCreditDays.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCreditDays.SelectedText = "";
            this.txtCreditDays.SelectionLength = 0;
            this.txtCreditDays.SelectionStart = 0;
            this.txtCreditDays.ShortcutsEnabled = true;
            this.txtCreditDays.Size = new System.Drawing.Size(96, 23);
            this.txtCreditDays.TabIndex = 27;
            this.txtCreditDays.UseSelectable = true;
            this.txtCreditDays.WaterMark = "Credit Days";
            this.txtCreditDays.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCreditDays.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCreditDays
            // 
            this.lblCreditDays.AutoSize = true;
            this.lblCreditDays.BackColor = System.Drawing.Color.Transparent;
            this.lblCreditDays.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCreditDays.Location = new System.Drawing.Point(221, 53);
            this.lblCreditDays.Name = "lblCreditDays";
            this.lblCreditDays.Size = new System.Drawing.Size(87, 19);
            this.lblCreditDays.TabIndex = 28;
            this.lblCreditDays.Text = "Credit Days :";
            this.lblCreditDays.UseCustomBackColor = true;
            // 
            // dtDueDate
            // 
            this.dtDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDueDate.Location = new System.Drawing.Point(662, 19);
            this.dtDueDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDueDate.Name = "dtDueDate";
            this.dtDueDate.Size = new System.Drawing.Size(119, 29);
            this.dtDueDate.TabIndex = 22;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(582, 24);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(74, 19);
            this.metroLabel13.TabIndex = 19;
            this.metroLabel13.Text = "Due Date :";
            this.metroLabel13.UseCustomBackColor = true;
            // 
            // VDate
            // 
            this.VDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VDate.Location = new System.Drawing.Point(451, 20);
            this.VDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.VDate.Name = "VDate";
            this.VDate.Size = new System.Drawing.Size(125, 29);
            this.VDate.TabIndex = 22;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDate.Location = new System.Drawing.Point(401, 24);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 19);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "Date :";
            this.lblDate.UseCustomBackColor = true;
            // 
            // txtGatePass
            // 
            // 
            // 
            // 
            this.txtGatePass.CustomButton.Image = null;
            this.txtGatePass.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.txtGatePass.CustomButton.Name = "";
            this.txtGatePass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGatePass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGatePass.CustomButton.TabIndex = 1;
            this.txtGatePass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGatePass.CustomButton.UseSelectable = true;
            this.txtGatePass.CustomButton.Visible = false;
            this.txtGatePass.Lines = new string[0];
            this.txtGatePass.Location = new System.Drawing.Point(86, 51);
            this.txtGatePass.MaxLength = 32767;
            this.txtGatePass.Name = "txtGatePass";
            this.txtGatePass.PasswordChar = '\0';
            this.txtGatePass.PromptText = "Gate Pass";
            this.txtGatePass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGatePass.SelectedText = "";
            this.txtGatePass.SelectionLength = 0;
            this.txtGatePass.SelectionStart = 0;
            this.txtGatePass.ShortcutsEnabled = true;
            this.txtGatePass.Size = new System.Drawing.Size(131, 23);
            this.txtGatePass.TabIndex = 25;
            this.txtGatePass.UseSelectable = true;
            this.txtGatePass.WaterMark = "Gate Pass";
            this.txtGatePass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGatePass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(1, 51);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(45, 19);
            this.metroLabel12.TabIndex = 26;
            this.metroLabel12.Text = "OGP :";
            this.metroLabel12.UseCustomBackColor = true;
            // 
            // txtDriverName
            // 
            // 
            // 
            // 
            this.txtDriverName.CustomButton.Image = null;
            this.txtDriverName.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.txtDriverName.CustomButton.Name = "";
            this.txtDriverName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDriverName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDriverName.CustomButton.TabIndex = 1;
            this.txtDriverName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDriverName.CustomButton.UseSelectable = true;
            this.txtDriverName.CustomButton.Visible = false;
            this.txtDriverName.Lines = new string[0];
            this.txtDriverName.Location = new System.Drawing.Point(804, 53);
            this.txtDriverName.MaxLength = 32767;
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.PasswordChar = '\0';
            this.txtDriverName.PromptText = "Driver Name";
            this.txtDriverName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDriverName.SelectedText = "";
            this.txtDriverName.SelectionLength = 0;
            this.txtDriverName.SelectionStart = 0;
            this.txtDriverName.ShortcutsEnabled = true;
            this.txtDriverName.Size = new System.Drawing.Size(141, 23);
            this.txtDriverName.TabIndex = 23;
            this.txtDriverName.UseSelectable = true;
            this.txtDriverName.WaterMark = "Driver Name";
            this.txtDriverName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDriverName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtVehicleNo
            // 
            // 
            // 
            // 
            this.txtVehicleNo.CustomButton.Image = null;
            this.txtVehicleNo.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.txtVehicleNo.CustomButton.Name = "";
            this.txtVehicleNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtVehicleNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVehicleNo.CustomButton.TabIndex = 1;
            this.txtVehicleNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVehicleNo.CustomButton.UseSelectable = true;
            this.txtVehicleNo.CustomButton.Visible = false;
            this.txtVehicleNo.Lines = new string[0];
            this.txtVehicleNo.Location = new System.Drawing.Point(662, 53);
            this.txtVehicleNo.MaxLength = 32767;
            this.txtVehicleNo.Name = "txtVehicleNo";
            this.txtVehicleNo.PasswordChar = '\0';
            this.txtVehicleNo.PromptText = "Vehicle No";
            this.txtVehicleNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVehicleNo.SelectedText = "";
            this.txtVehicleNo.SelectionLength = 0;
            this.txtVehicleNo.SelectionStart = 0;
            this.txtVehicleNo.ShortcutsEnabled = true;
            this.txtVehicleNo.Size = new System.Drawing.Size(141, 23);
            this.txtVehicleNo.TabIndex = 23;
            this.txtVehicleNo.UseSelectable = true;
            this.txtVehicleNo.WaterMark = "Vehicle No";
            this.txtVehicleNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVehicleNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSampleNo
            // 
            // 
            // 
            // 
            this.txtSampleNo.CustomButton.Image = null;
            this.txtSampleNo.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.txtSampleNo.CustomButton.Name = "";
            this.txtSampleNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSampleNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSampleNo.CustomButton.TabIndex = 1;
            this.txtSampleNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSampleNo.CustomButton.UseSelectable = true;
            this.txtSampleNo.CustomButton.Visible = false;
            this.txtSampleNo.Lines = new string[0];
            this.txtSampleNo.Location = new System.Drawing.Point(520, 53);
            this.txtSampleNo.MaxLength = 32767;
            this.txtSampleNo.Name = "txtSampleNo";
            this.txtSampleNo.PasswordChar = '\0';
            this.txtSampleNo.PromptText = "Sample No(If Any)";
            this.txtSampleNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSampleNo.SelectedText = "";
            this.txtSampleNo.SelectionLength = 0;
            this.txtSampleNo.SelectionStart = 0;
            this.txtSampleNo.ShortcutsEnabled = true;
            this.txtSampleNo.Size = new System.Drawing.Size(141, 23);
            this.txtSampleNo.TabIndex = 23;
            this.txtSampleNo.UseSelectable = true;
            this.txtSampleNo.WaterMark = "Sample No(If Any)";
            this.txtSampleNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSampleNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // InvEditBox
            // 
            // 
            // 
            // 
            this.InvEditBox.CustomButton.Image = null;
            this.InvEditBox.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.InvEditBox.CustomButton.Name = "";
            this.InvEditBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.InvEditBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InvEditBox.CustomButton.TabIndex = 1;
            this.InvEditBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InvEditBox.CustomButton.UseSelectable = true;
            this.InvEditBox.Lines = new string[0];
            this.InvEditBox.Location = new System.Drawing.Point(86, 25);
            this.InvEditBox.MaxLength = 32767;
            this.InvEditBox.Name = "InvEditBox";
            this.InvEditBox.PasswordChar = '\0';
            this.InvEditBox.PromptText = "Invoice No";
            this.InvEditBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InvEditBox.SelectedText = "";
            this.InvEditBox.SelectionLength = 0;
            this.InvEditBox.SelectionStart = 0;
            this.InvEditBox.ShortcutsEnabled = true;
            this.InvEditBox.ShowButton = true;
            this.InvEditBox.Size = new System.Drawing.Size(181, 23);
            this.InvEditBox.Style = MetroFramework.MetroColorStyle.Pink;
            this.InvEditBox.TabIndex = 16;
            this.InvEditBox.UseSelectable = true;
            this.InvEditBox.WaterMark = "Invoice No";
            this.InvEditBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InvEditBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.InvEditBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.InvEditBox_ButtonClick);
            this.InvEditBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InvEditBox_KeyPress);
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.BackColor = System.Drawing.Color.Transparent;
            this.lblInvoiceNo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblInvoiceNo.Location = new System.Drawing.Point(3, 24);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(81, 19);
            this.lblInvoiceNo.TabIndex = 17;
            this.lblInvoiceNo.Text = "Invoice No :";
            this.lblInvoiceNo.UseCustomBackColor = true;
            // 
            // txtSheetNo
            // 
            // 
            // 
            // 
            this.txtSheetNo.CustomButton.Image = null;
            this.txtSheetNo.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.txtSheetNo.CustomButton.Name = "";
            this.txtSheetNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSheetNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSheetNo.CustomButton.TabIndex = 1;
            this.txtSheetNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSheetNo.CustomButton.UseSelectable = true;
            this.txtSheetNo.CustomButton.Visible = false;
            this.txtSheetNo.Lines = new string[0];
            this.txtSheetNo.Location = new System.Drawing.Point(273, 25);
            this.txtSheetNo.MaxLength = 32767;
            this.txtSheetNo.Name = "txtSheetNo";
            this.txtSheetNo.PasswordChar = '\0';
            this.txtSheetNo.PromptText = "Sheet No";
            this.txtSheetNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSheetNo.SelectedText = "";
            this.txtSheetNo.SelectionLength = 0;
            this.txtSheetNo.SelectionStart = 0;
            this.txtSheetNo.ShortcutsEnabled = true;
            this.txtSheetNo.Size = new System.Drawing.Size(116, 23);
            this.txtSheetNo.Style = MetroFramework.MetroColorStyle.Pink;
            this.txtSheetNo.TabIndex = 21;
            this.txtSheetNo.UseSelectable = true;
            this.txtSheetNo.WaterMark = "Sheet No";
            this.txtSheetNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSheetNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDiscription
            // 
            this.lblDiscription.AutoSize = true;
            this.lblDiscription.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscription.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDiscription.Location = new System.Drawing.Point(1, 79);
            this.lblDiscription.Name = "lblDiscription";
            this.lblDiscription.Size = new System.Drawing.Size(81, 19);
            this.lblDiscription.TabIndex = 19;
            this.lblDiscription.Text = "Discription :";
            this.lblDiscription.UseCustomBackColor = true;
            // 
            // chkPosted
            // 
            this.chkPosted.AutoSize = true;
            this.chkPosted.BackColor = System.Drawing.Color.Transparent;
            this.chkPosted.Location = new System.Drawing.Point(968, 59);
            this.chkPosted.Name = "chkPosted";
            this.chkPosted.Size = new System.Drawing.Size(59, 15);
            this.chkPosted.TabIndex = 18;
            this.chkPosted.Text = "Posted";
            this.chkPosted.UseCustomBackColor = true;
            this.chkPosted.UseSelectable = true;
            // 
            // txtBiltyNo
            // 
            // 
            // 
            // 
            this.txtBiltyNo.CustomButton.Image = null;
            this.txtBiltyNo.CustomButton.Location = new System.Drawing.Point(81, 1);
            this.txtBiltyNo.CustomButton.Name = "";
            this.txtBiltyNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBiltyNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBiltyNo.CustomButton.TabIndex = 1;
            this.txtBiltyNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBiltyNo.CustomButton.UseSelectable = true;
            this.txtBiltyNo.CustomButton.Visible = false;
            this.txtBiltyNo.Lines = new string[0];
            this.txtBiltyNo.Location = new System.Drawing.Point(414, 53);
            this.txtBiltyNo.MaxLength = 32767;
            this.txtBiltyNo.Name = "txtBiltyNo";
            this.txtBiltyNo.PasswordChar = '\0';
            this.txtBiltyNo.PromptText = "Bilty No Here";
            this.txtBiltyNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBiltyNo.SelectedText = "";
            this.txtBiltyNo.SelectionLength = 0;
            this.txtBiltyNo.SelectionStart = 0;
            this.txtBiltyNo.ShortcutsEnabled = true;
            this.txtBiltyNo.Size = new System.Drawing.Size(103, 23);
            this.txtBiltyNo.TabIndex = 1;
            this.txtBiltyNo.UseSelectable = true;
            this.txtBiltyNo.WaterMark = "Bilty No Here";
            this.txtBiltyNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBiltyNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(835, 1);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(86, 79);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(859, 25);
            this.txtDescription.TabIndex = 16;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // flowMainPanel
            // 
            this.flowMainPanel.AutoSize = true;
            this.flowMainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowMainPanel.Controls.Add(this.groupBox1);
            this.flowMainPanel.Controls.Add(this.grpDebitor);
            this.flowMainPanel.Controls.Add(this.tabSales);
            this.flowMainPanel.Controls.Add(this.pnlButtons);
            this.flowMainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowMainPanel.Location = new System.Drawing.Point(9, 57);
            this.flowMainPanel.Name = "flowMainPanel";
            this.flowMainPanel.Size = new System.Drawing.Size(1136, 689);
            this.flowMainPanel.TabIndex = 10;
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1166, 749);
            this.Controls.Add(this.flowMainPanel);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSales";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Sales Invoice";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSales_KeyPress);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.tabSales.ResumeLayout(false);
            this.tabLineItems.ResumeLayout(false);
            this.tabLineItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStockSales)).EndInit();
            this.tabSalesTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSalesTransactions)).EndInit();
            this.grpDebitor.ResumeLayout(false);
            this.grpDebitor.PerformLayout();
            this.grpSales.ResumeLayout(false);
            this.flowPurchasesPanel.ResumeLayout(false);
            this.pnlCash.ResumeLayout(false);
            this.pnlCash.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowMainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.DataGridView DgvStockReceipt;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatuMessage;
        //private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlButtons;
        private MetroFramework.Controls.MetroTile btnSave;
        private MetroFramework.Controls.MetroTile btnNext;
        private MetroFramework.Controls.MetroTile btnNew;
        private MetroFramework.Controls.MetroTile btnDelete;
        private MetroFramework.Controls.MetroTile btnPrevious;
        private MetroFramework.Controls.MetroTile btnClose;
        private System.Windows.Forms.TabControl tabSales;
        private System.Windows.Forms.TabPage tabLineItems;
        private TabDataGrid DgvStockSales;
        private System.Windows.Forms.TabPage tabSalesTransactions;
        private TabDataGrid DgvSalesTransactions;
        private System.Windows.Forms.GroupBox grpDebitor;
        private MetroFramework.Controls.MetroButton btnAddCustomer;
        private MetroFramework.Controls.MetroTextBox txtCurrentBalance;
        private MetroFramework.Controls.MetroButton btnViewDetail;
        private MetroFramework.Controls.MetroTextBox txtContact;
        private MetroFramework.Controls.MetroTextBox SEditBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox grpSales;
        private System.Windows.Forms.FlowLayoutPanel flowPurchasesPanel;
        private System.Windows.Forms.Panel pnlCash;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnAddCashAccount;
        private MetroFramework.Controls.MetroComboBox cbxCashAccounts;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroComboBox cbxNaturalAccounts;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnAddPurchasesAccount;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroDateTime VDate;
        private MetroFramework.Controls.MetroTextBox txtSheetNo;
        private MetroFramework.Controls.MetroLabel lblDiscription;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroCheckBox chkPosted;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private System.Windows.Forms.FlowLayoutPanel flowMainPanel;
        private MetroFramework.Controls.MetroTextBox txtBiltyNo;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblVouchersCount;
        private MetroFramework.Controls.MetroLabel lblTotalVouchers;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lblLastVoucherNo;
        private MetroFramework.Controls.MetroTextBox InvEditBox;
        private MetroFramework.Controls.MetroLabel lblInvoiceNo;
        private MetroFramework.Controls.MetroTextBox txtSampleNo;
        private MetroFramework.Controls.MetroTextBox txtCreditDays;
        private MetroFramework.Controls.MetroLabel lblCreditDays;
        private MetroFramework.Controls.MetroTextBox txtGatePass;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel lblVoucherStatus;
        private MetroFramework.Controls.MetroTile btnPrint;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtDeliveryPerson;
        private MetroFramework.Controls.MetroTextBox EmpEditCode;
        private MetroFramework.Controls.MetroTextBox txtExtraDiscount;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtFreightAmount;
        private MetroFramework.Controls.MetroLabel lblFreight;
        private MetroFramework.Controls.MetroTextBox txtAmountAfterDiscount;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtFlatDiscount;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtTotalDiscount;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtBillAmount;
        private MetroFramework.Controls.MetroLabel lblTotal;
        private MetroFramework.Controls.MetroTextBox txtTotalAmount;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdDetailVoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClosingBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCredit;
        private MetroFramework.Controls.MetroRadioButton rdCash;
        private MetroFramework.Controls.MetroRadioButton rdCredit;
        private MetroFramework.Controls.MetroDateTime dtDueDate;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroDateTime VEditedDateTime;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox txtMiscCharges;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroTextBox txtCuttingCharges;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox txtLoadingCharges;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox txtDriverName;
        private MetroFramework.Controls.MetroTextBox txtVehicleNo;
        private MetroFramework.Controls.MetroTextBox txtSystemWeight;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroTextBox txtManualWeight;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdVoucherDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutoWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemNo;
        private DataGridViewProductWaterMarkColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpacking;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartons;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEngineNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChassisNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicleModel;
        private System.Windows.Forms.DataGridViewComboBoxColumn colVehicleColors;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicleNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstIMEI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSecondIMEI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBonusUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLineDisc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFlatDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscountAmount;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private MetroFramework.Controls.MetroTextBox txt2kgWeight;
        private MetroFramework.Controls.MetroLabel metroLabel21;
    }
}