namespace Accounts.UI
{
    partial class frmStockReceipt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatuMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblVouchersCount = new MetroFramework.Controls.MetroLabel();
            this.lblTotalVouchers = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lblLastVoucherNo = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.btnPrintPurchaseInvoice = new MetroFramework.Controls.MetroTile();
            this.btnNext = new MetroFramework.Controls.MetroTile();
            this.btnNew = new MetroFramework.Controls.MetroTile();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnPrevious = new MetroFramework.Controls.MetroTile();
            this.btnClose = new MetroFramework.Controls.MetroTile();
            this.tabPurchaseTransactions = new System.Windows.Forms.TabControl();
            this.tabLineItems = new System.Windows.Forms.TabPage();
            this.txt2kgWeight = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.lblVoucherStatus = new MetroFramework.Controls.MetroLabel();
            this.DgvStockReceipt = new Accounts.UI.TabDataGrid();
            this.ColIdVoucherDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutoWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFlatDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtTotalAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtFreightAmount = new MetroFramework.Controls.MetroTextBox();
            this.lblFreight = new MetroFramework.Controls.MetroLabel();
            this.txtAmountAfterDiscount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtFlatDiscount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtTotalDiscount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtManualWeight = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.txtSystemWeight = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtBillAmount = new MetroFramework.Controls.MetroTextBox();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.tabSalesTransactions = new System.Windows.Forms.TabPage();
            this.DgvPurchases = new Accounts.UI.TabDataGrid();
            this.ColIdDetailVoucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClosingBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpCreditor = new System.Windows.Forms.GroupBox();
            this.rdCash = new MetroFramework.Controls.MetroRadioButton();
            this.rdCredit = new MetroFramework.Controls.MetroRadioButton();
            this.txtCurrentBalance = new MetroFramework.Controls.MetroTextBox();
            this.btnViewDetail = new MetroFramework.Controls.MetroButton();
            this.grpSales = new System.Windows.Forms.GroupBox();
            this.flowPurchasesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCash = new System.Windows.Forms.Panel();
            this.txtCashClosingBalance = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnAddCashAccount = new MetroFramework.Controls.MetroButton();
            this.cbxCashAccounts = new MetroFramework.Controls.MetroComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxNaturalAccounts = new MetroFramework.Controls.MetroComboBox();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnAddPurchasesAccount = new MetroFramework.Controls.MetroButton();
            this.SEditBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VEditedDateTime = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.VDate = new MetroFramework.Controls.MetroDateTime();
            this.VEditBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtSheetNo = new MetroFramework.Controls.MetroTextBox();
            this.lblDiscription = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblBillNo = new MetroFramework.Controls.MetroLabel();
            this.lblVoucherNo = new MetroFramework.Controls.MetroLabel();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.chkPosted = new MetroFramework.Controls.MetroCheckBox();
            this.txtBiltyNo = new MetroFramework.Controls.MetroTextBox();
            this.txtBillNo = new MetroFramework.Controls.MetroTextBox();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.flowMainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.tabPurchaseTransactions.SuspendLayout();
            this.tabLineItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStockReceipt)).BeginInit();
            this.tabSalesTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPurchases)).BeginInit();
            this.grpCreditor.SuspendLayout();
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
            this.statusStrip1.Size = new System.Drawing.Size(1110, 22);
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
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Controls.Add(this.btnPrintPurchaseInvoice);
            this.pnlButtons.Controls.Add(this.btnNext);
            this.pnlButtons.Controls.Add(this.btnNew);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnPrevious);
            this.pnlButtons.Controls.Add(this.btnClose);
            this.pnlButtons.Location = new System.Drawing.Point(3, 608);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1109, 48);
            this.pnlButtons.TabIndex = 25;
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
            this.metroPanel1.Size = new System.Drawing.Size(489, 36);
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
            this.metroLabel7.Location = new System.Drawing.Point(236, 6);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(117, 19);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Last Voucher No :";
            // 
            // lblLastVoucherNo
            // 
            this.lblLastVoucherNo.AutoSize = true;
            this.lblLastVoucherNo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblLastVoucherNo.Location = new System.Drawing.Point(365, 6);
            this.lblLastVoucherNo.Name = "lblLastVoucherNo";
            this.lblLastVoucherNo.Size = new System.Drawing.Size(17, 19);
            this.lblLastVoucherNo.TabIndex = 2;
            this.lblLastVoucherNo.Text = "0";
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSave.Location = new System.Drawing.Point(750, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 40);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrintPurchaseInvoice
            // 
            this.btnPrintPurchaseInvoice.ActiveControl = null;
            this.btnPrintPurchaseInvoice.BackColor = System.Drawing.Color.RosyBrown;
            this.btnPrintPurchaseInvoice.Location = new System.Drawing.Point(666, 3);
            this.btnPrintPurchaseInvoice.Name = "btnPrintPurchaseInvoice";
            this.btnPrintPurchaseInvoice.Size = new System.Drawing.Size(83, 40);
            this.btnPrintPurchaseInvoice.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnPrintPurchaseInvoice.TabIndex = 15;
            this.btnPrintPurchaseInvoice.Text = "Print";
            this.btnPrintPurchaseInvoice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrintPurchaseInvoice.UseCustomBackColor = true;
            this.btnPrintPurchaseInvoice.UseSelectable = true;
            this.btnPrintPurchaseInvoice.Click += new System.EventHandler(this.btnPrintPurchaseInvoice_Click);
            // 
            // btnNext
            // 
            this.btnNext.ActiveControl = null;
            this.btnNext.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNext.Location = new System.Drawing.Point(582, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(83, 40);
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
            this.btnNew.Location = new System.Drawing.Point(1002, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(101, 40);
            this.btnNew.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnNew.TabIndex = 16;
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
            this.btnDelete.Location = new System.Drawing.Point(834, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 40);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Red;
            this.btnDelete.TabIndex = 12;
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
            this.btnPrevious.Location = new System.Drawing.Point(498, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(83, 40);
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
            this.btnClose.Location = new System.Drawing.Point(918, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 40);
            this.btnClose.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseCustomBackColor = true;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabPurchaseTransactions
            // 
            this.tabPurchaseTransactions.Controls.Add(this.tabLineItems);
            this.tabPurchaseTransactions.Controls.Add(this.tabSalesTransactions);
            this.tabPurchaseTransactions.Location = new System.Drawing.Point(3, 186);
            this.tabPurchaseTransactions.Name = "tabPurchaseTransactions";
            this.tabPurchaseTransactions.SelectedIndex = 0;
            this.tabPurchaseTransactions.Size = new System.Drawing.Size(1109, 416);
            this.tabPurchaseTransactions.TabIndex = 3;
            this.tabPurchaseTransactions.SelectedIndexChanged += new System.EventHandler(this.tabPurchaseTransactions_SelectedIndexChanged);
            // 
            // tabLineItems
            // 
            this.tabLineItems.Controls.Add(this.txt2kgWeight);
            this.tabLineItems.Controls.Add(this.metroLabel21);
            this.tabLineItems.Controls.Add(this.metroLabel14);
            this.tabLineItems.Controls.Add(this.lblVoucherStatus);
            this.tabLineItems.Controls.Add(this.DgvStockReceipt);
            this.tabLineItems.Controls.Add(this.txtTotalAmount);
            this.tabLineItems.Controls.Add(this.metroLabel6);
            this.tabLineItems.Controls.Add(this.txtFreightAmount);
            this.tabLineItems.Controls.Add(this.lblFreight);
            this.tabLineItems.Controls.Add(this.txtAmountAfterDiscount);
            this.tabLineItems.Controls.Add(this.metroLabel10);
            this.tabLineItems.Controls.Add(this.txtFlatDiscount);
            this.tabLineItems.Controls.Add(this.metroLabel9);
            this.tabLineItems.Controls.Add(this.txtTotalDiscount);
            this.tabLineItems.Controls.Add(this.metroLabel8);
            this.tabLineItems.Controls.Add(this.txtManualWeight);
            this.tabLineItems.Controls.Add(this.metroLabel13);
            this.tabLineItems.Controls.Add(this.txtSystemWeight);
            this.tabLineItems.Controls.Add(this.metroLabel12);
            this.tabLineItems.Controls.Add(this.txtBillAmount);
            this.tabLineItems.Controls.Add(this.lblTotal);
            this.tabLineItems.Location = new System.Drawing.Point(4, 25);
            this.tabLineItems.Name = "tabLineItems";
            this.tabLineItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabLineItems.Size = new System.Drawing.Size(1101, 387);
            this.tabLineItems.TabIndex = 0;
            this.tabLineItems.Text = "Line Items";
            this.tabLineItems.UseVisualStyleBackColor = true;
            // 
            // txt2kgWeight
            // 
            this.txt2kgWeight.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txt2kgWeight.CustomButton.Image = null;
            this.txt2kgWeight.CustomButton.Location = new System.Drawing.Point(139, 1);
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
            this.txt2kgWeight.Location = new System.Drawing.Point(521, 335);
            this.txt2kgWeight.MaxLength = 32767;
            this.txt2kgWeight.Name = "txt2kgWeight";
            this.txt2kgWeight.PasswordChar = '\0';
            this.txt2kgWeight.ReadOnly = true;
            this.txt2kgWeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt2kgWeight.SelectedText = "";
            this.txt2kgWeight.SelectionLength = 0;
            this.txt2kgWeight.SelectionStart = 0;
            this.txt2kgWeight.ShortcutsEnabled = true;
            this.txt2kgWeight.Size = new System.Drawing.Size(161, 23);
            this.txt2kgWeight.TabIndex = 47;
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
            this.metroLabel21.Location = new System.Drawing.Point(394, 335);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(124, 19);
            this.metroLabel21.TabIndex = 48;
            this.metroLabel21.Text = "Auto Weight(2kg) :";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel14.ForeColor = System.Drawing.Color.Red;
            this.metroLabel14.Location = new System.Drawing.Point(549, 331);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(0, 0);
            this.metroLabel14.TabIndex = 38;
            this.metroLabel14.UseCustomForeColor = true;
            this.metroLabel14.Visible = false;
            // 
            // lblVoucherStatus
            // 
            this.lblVoucherStatus.AutoSize = true;
            this.lblVoucherStatus.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblVoucherStatus.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblVoucherStatus.ForeColor = System.Drawing.Color.Red;
            this.lblVoucherStatus.Location = new System.Drawing.Point(12, 356);
            this.lblVoucherStatus.Name = "lblVoucherStatus";
            this.lblVoucherStatus.Size = new System.Drawing.Size(0, 0);
            this.lblVoucherStatus.TabIndex = 38;
            this.lblVoucherStatus.UseCustomForeColor = true;
            this.lblVoucherStatus.Visible = false;
            // 
            // DgvStockReceipt
            // 
            this.DgvStockReceipt.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvStockReceipt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvStockReceipt.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvStockReceipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvStockReceipt.ColumnHeadersHeight = 25;
            this.DgvStockReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.colQty,
            this.colBonus,
            this.colWeight,
            this.colUnitPrice,
            this.colAmount,
            this.colDiscount,
            this.colDiscAmount,
            this.colFlatDiscount,
            this.colDiscountAmount,
            this.colDelete});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvStockReceipt.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvStockReceipt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvStockReceipt.EnableHeadersVisualStyles = false;
            this.DgvStockReceipt.Location = new System.Drawing.Point(6, 8);
            this.DgvStockReceipt.MultiSelect = false;
            this.DgvStockReceipt.Name = "DgvStockReceipt";
            this.DgvStockReceipt.RowHeadersVisible = false;
            this.DgvStockReceipt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvStockReceipt.Size = new System.Drawing.Size(1089, 270);
            this.DgvStockReceipt.TabIndex = 1;
            this.DgvStockReceipt.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DgvStockReceipt_CellBeginEdit);
            this.DgvStockReceipt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStockReceipt_CellClick);
            this.DgvStockReceipt.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStockReceipt_CellEndEdit);
            this.DgvStockReceipt.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvStockReceipt_CellFormatting);
            this.DgvStockReceipt.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStockReceipt_CellLeave);
            this.DgvStockReceipt.CurrentCellDirtyStateChanged += new System.EventHandler(this.DgvStockReceipt_CurrentCellDirtyStateChanged);
            this.DgvStockReceipt.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgvStockReceipt_EditingControlShowing);
            this.DgvStockReceipt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DgvStockReceipt_KeyPress);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colItemName.DefaultCellStyle = dataGridViewCellStyle3;
            this.colItemName.HeaderText = "Product Discription";
            this.colItemName.Name = "colItemName";
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
            this.colCartons.HeaderText = "CTN";
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
            // colQty
            // 
            this.colQty.DataPropertyName = "Qty";
            this.colQty.HeaderText = "Quantity";
            this.colQty.Name = "colQty";
            this.colQty.Width = 80;
            // 
            // colBonus
            // 
            this.colBonus.HeaderText = "Bonus";
            this.colBonus.Name = "colBonus";
            this.colBonus.Visible = false;
            this.colBonus.Width = 80;
            // 
            // colWeight
            // 
            this.colWeight.HeaderText = "Weight";
            this.colWeight.Name = "colWeight";
            this.colWeight.Width = 80;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "Amount";
            this.colUnitPrice.HeaderText = "Rate";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Width = 80;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "qty*amount";
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colAmount.Width = 90;
            // 
            // colDiscount
            // 
            this.colDiscount.HeaderText = "Disc(%)";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Width = 90;
            // 
            // colDiscAmount
            // 
            this.colDiscAmount.HeaderText = "Discount";
            this.colDiscAmount.Name = "colDiscAmount";
            this.colDiscAmount.ReadOnly = true;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDelete.HeaderText = "...";
            this.colDelete.Name = "colDelete";
            this.colDelete.Width = 80;
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
            this.txtTotalAmount.Location = new System.Drawing.Point(935, 335);
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
            this.txtTotalAmount.TabIndex = 22;
            this.txtTotalAmount.UseCustomBackColor = true;
            this.txtTotalAmount.UseSelectable = true;
            this.txtTotalAmount.WaterMark = "Total Credit";
            this.txtTotalAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(821, 333);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(86, 19);
            this.metroLabel6.TabIndex = 24;
            this.metroLabel6.Text = "Total Credit :";
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
            this.txtFreightAmount.Location = new System.Drawing.Point(935, 309);
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
            this.txtFreightAmount.TabIndex = 22;
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
            this.lblFreight.Location = new System.Drawing.Point(817, 310);
            this.lblFreight.Name = "lblFreight";
            this.lblFreight.Size = new System.Drawing.Size(113, 19);
            this.lblFreight.TabIndex = 24;
            this.lblFreight.Text = "Freight Amount :";
            // 
            // txtAmountAfterDiscount
            // 
            this.txtAmountAfterDiscount.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtAmountAfterDiscount.CustomButton.Image = null;
            this.txtAmountAfterDiscount.CustomButton.Location = new System.Drawing.Point(138, 1);
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
            this.txtAmountAfterDiscount.Location = new System.Drawing.Point(935, 284);
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
            this.txtAmountAfterDiscount.Size = new System.Drawing.Size(160, 23);
            this.txtAmountAfterDiscount.TabIndex = 22;
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
            this.metroLabel10.Location = new System.Drawing.Point(800, 285);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(124, 19);
            this.metroLabel10.TabIndex = 24;
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
            this.txtFlatDiscount.Location = new System.Drawing.Point(137, 333);
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
            this.txtFlatDiscount.TabIndex = 22;
            this.txtFlatDiscount.UseCustomBackColor = true;
            this.txtFlatDiscount.UseSelectable = true;
            this.txtFlatDiscount.WaterMark = "Flat Discount";
            this.txtFlatDiscount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFlatDiscount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(9, 334);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(96, 19);
            this.metroLabel9.TabIndex = 24;
            this.metroLabel9.Text = "Flat Discount :";
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
            this.txtTotalDiscount.Location = new System.Drawing.Point(137, 308);
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
            this.txtTotalDiscount.TabIndex = 22;
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
            this.metroLabel8.Location = new System.Drawing.Point(9, 308);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(103, 19);
            this.metroLabel8.TabIndex = 24;
            this.metroLabel8.Text = "Total Discount :";
            // 
            // txtManualWeight
            // 
            this.txtManualWeight.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtManualWeight.CustomButton.Image = null;
            this.txtManualWeight.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txtManualWeight.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtManualWeight.CustomButton.Name = "";
            this.txtManualWeight.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtManualWeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtManualWeight.CustomButton.TabIndex = 1;
            this.txtManualWeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtManualWeight.CustomButton.UseSelectable = true;
            this.txtManualWeight.CustomButton.Visible = false;
            this.txtManualWeight.Lines = new string[0];
            this.txtManualWeight.Location = new System.Drawing.Point(521, 308);
            this.txtManualWeight.MaxLength = 32767;
            this.txtManualWeight.Name = "txtManualWeight";
            this.txtManualWeight.PasswordChar = '\0';
            this.txtManualWeight.PromptText = "Manual Weight";
            this.txtManualWeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtManualWeight.SelectedText = "";
            this.txtManualWeight.SelectionLength = 0;
            this.txtManualWeight.SelectionStart = 0;
            this.txtManualWeight.ShortcutsEnabled = true;
            this.txtManualWeight.Size = new System.Drawing.Size(161, 23);
            this.txtManualWeight.TabIndex = 22;
            this.txtManualWeight.UseCustomBackColor = true;
            this.txtManualWeight.UseSelectable = true;
            this.txtManualWeight.WaterMark = "Manual Weight";
            this.txtManualWeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtManualWeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtManualWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtManualWeight_KeyPress);
            this.txtManualWeight.Leave += new System.EventHandler(this.txtManualWeight_Leave);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(407, 308);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(109, 19);
            this.metroLabel13.TabIndex = 24;
            this.metroLabel13.Text = "Manual Weight :";
            // 
            // txtSystemWeight
            // 
            this.txtSystemWeight.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtSystemWeight.CustomButton.Image = null;
            this.txtSystemWeight.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txtSystemWeight.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtSystemWeight.CustomButton.Name = "";
            this.txtSystemWeight.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSystemWeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSystemWeight.CustomButton.TabIndex = 1;
            this.txtSystemWeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSystemWeight.CustomButton.UseSelectable = true;
            this.txtSystemWeight.CustomButton.Visible = false;
            this.txtSystemWeight.Enabled = false;
            this.txtSystemWeight.Lines = new string[0];
            this.txtSystemWeight.Location = new System.Drawing.Point(521, 283);
            this.txtSystemWeight.MaxLength = 32767;
            this.txtSystemWeight.Name = "txtSystemWeight";
            this.txtSystemWeight.PasswordChar = '\0';
            this.txtSystemWeight.PromptText = "System Weight";
            this.txtSystemWeight.ReadOnly = true;
            this.txtSystemWeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSystemWeight.SelectedText = "";
            this.txtSystemWeight.SelectionLength = 0;
            this.txtSystemWeight.SelectionStart = 0;
            this.txtSystemWeight.ShortcutsEnabled = true;
            this.txtSystemWeight.Size = new System.Drawing.Size(161, 23);
            this.txtSystemWeight.TabIndex = 22;
            this.txtSystemWeight.UseCustomBackColor = true;
            this.txtSystemWeight.UseSelectable = true;
            this.txtSystemWeight.WaterMark = "System Weight";
            this.txtSystemWeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSystemWeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(410, 283);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(107, 19);
            this.metroLabel12.TabIndex = 24;
            this.metroLabel12.Text = "System Weight :";
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
            this.txtBillAmount.Location = new System.Drawing.Point(137, 284);
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
            this.txtBillAmount.TabIndex = 22;
            this.txtBillAmount.UseCustomBackColor = true;
            this.txtBillAmount.UseSelectable = true;
            this.txtBillAmount.WaterMark = "Total Bill Amount";
            this.txtBillAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBillAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTotal.Location = new System.Drawing.Point(9, 284);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(87, 19);
            this.lblTotal.TabIndex = 24;
            this.lblTotal.Text = "Bill Amount :";
            // 
            // tabSalesTransactions
            // 
            this.tabSalesTransactions.Controls.Add(this.DgvPurchases);
            this.tabSalesTransactions.Location = new System.Drawing.Point(4, 25);
            this.tabSalesTransactions.Name = "tabSalesTransactions";
            this.tabSalesTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalesTransactions.Size = new System.Drawing.Size(1101, 387);
            this.tabSalesTransactions.TabIndex = 1;
            this.tabSalesTransactions.Text = "Transactions";
            this.tabSalesTransactions.UseVisualStyleBackColor = true;
            // 
            // DgvPurchases
            // 
            this.DgvPurchases.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvPurchases.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvPurchases.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPurchases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvPurchases.ColumnHeadersHeight = 25;
            this.DgvPurchases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdDetailVoucher,
            this.colIdAccount,
            this.colAccountNo,
            this.colAccountName,
            this.colClosingBalance,
            this.colDescription,
            this.colDebit,
            this.colCredit});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPurchases.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgvPurchases.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvPurchases.EnableHeadersVisualStyles = false;
            this.DgvPurchases.Location = new System.Drawing.Point(4, 6);
            this.DgvPurchases.MultiSelect = false;
            this.DgvPurchases.Name = "DgvPurchases";
            this.DgvPurchases.RowHeadersVisible = false;
            this.DgvPurchases.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvPurchases.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvPurchases.Size = new System.Drawing.Size(1094, 339);
            this.DgvPurchases.TabIndex = 26;
            this.DgvPurchases.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPurchases_CellEndEdit);
            this.DgvPurchases.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPurchases_CellLeave);
            this.DgvPurchases.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgvPurchases_EditingControlShowing);
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
            this.colAccountName.Width = 250;
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
            this.colDescription.Width = 385;
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
            // grpCreditor
            // 
            this.grpCreditor.BackColor = System.Drawing.Color.MistyRose;
            this.grpCreditor.Controls.Add(this.rdCash);
            this.grpCreditor.Controls.Add(this.rdCredit);
            this.grpCreditor.Controls.Add(this.txtCurrentBalance);
            this.grpCreditor.Controls.Add(this.btnViewDetail);
            this.grpCreditor.Controls.Add(this.grpSales);
            this.grpCreditor.Controls.Add(this.SEditBox);
            this.grpCreditor.Controls.Add(this.metroLabel2);
            this.grpCreditor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCreditor.Location = new System.Drawing.Point(3, 107);
            this.grpCreditor.Name = "grpCreditor";
            this.grpCreditor.Size = new System.Drawing.Size(1103, 73);
            this.grpCreditor.TabIndex = 0;
            this.grpCreditor.TabStop = false;
            this.grpCreditor.Text = "Supplier Information";
            // 
            // rdCash
            // 
            this.rdCash.AutoSize = true;
            this.rdCash.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdCash.ForeColor = System.Drawing.Color.Black;
            this.rdCash.Location = new System.Drawing.Point(226, 49);
            this.rdCash.Name = "rdCash";
            this.rdCash.Size = new System.Drawing.Size(120, 19);
            this.rdCash.TabIndex = 28;
            this.rdCash.Text = "Cash Purchases";
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
            this.rdCredit.Location = new System.Drawing.Point(90, 49);
            this.rdCredit.Name = "rdCredit";
            this.rdCredit.Size = new System.Drawing.Size(127, 19);
            this.rdCredit.TabIndex = 28;
            this.rdCredit.Text = "Credit Purchases";
            this.rdCredit.UseCustomBackColor = true;
            this.rdCredit.UseCustomForeColor = true;
            this.rdCredit.UseSelectable = true;
            this.rdCredit.CheckedChanged += new System.EventHandler(this.rdCredit_CheckedChanged);
            this.rdCredit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rdCredit_KeyPress);
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
            this.txtCurrentBalance.Location = new System.Drawing.Point(430, 20);
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
            this.btnViewDetail.Location = new System.Drawing.Point(537, 20);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(77, 23);
            this.btnViewDetail.TabIndex = 27;
            this.btnViewDetail.Text = "View Detail";
            this.btnViewDetail.UseSelectable = true;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // grpSales
            // 
            this.grpSales.BackColor = System.Drawing.Color.MistyRose;
            this.grpSales.Controls.Add(this.flowPurchasesPanel);
            this.grpSales.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSales.Location = new System.Drawing.Point(941, 12);
            this.grpSales.Name = "grpSales";
            this.grpSales.Size = new System.Drawing.Size(41, 31);
            this.grpSales.TabIndex = 2;
            this.grpSales.TabStop = false;
            this.grpSales.Text = "Purchases Information";
            this.grpSales.Visible = false;
            // 
            // flowPurchasesPanel
            // 
            this.flowPurchasesPanel.Controls.Add(this.pnlCash);
            this.flowPurchasesPanel.Controls.Add(this.panel2);
            this.flowPurchasesPanel.Location = new System.Drawing.Point(6, 17);
            this.flowPurchasesPanel.Name = "flowPurchasesPanel";
            this.flowPurchasesPanel.Size = new System.Drawing.Size(1086, 43);
            this.flowPurchasesPanel.TabIndex = 10;
            // 
            // pnlCash
            // 
            this.pnlCash.Controls.Add(this.txtCashClosingBalance);
            this.pnlCash.Controls.Add(this.metroLabel3);
            this.pnlCash.Controls.Add(this.btnAddCashAccount);
            this.pnlCash.Controls.Add(this.cbxCashAccounts);
            this.pnlCash.Location = new System.Drawing.Point(3, 3);
            this.pnlCash.Name = "pnlCash";
            this.pnlCash.Size = new System.Drawing.Size(508, 35);
            this.pnlCash.TabIndex = 10;
            // 
            // txtCashClosingBalance
            // 
            // 
            // 
            // 
            this.txtCashClosingBalance.CustomButton.Image = null;
            this.txtCashClosingBalance.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.txtCashClosingBalance.CustomButton.Name = "";
            this.txtCashClosingBalance.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCashClosingBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCashClosingBalance.CustomButton.TabIndex = 1;
            this.txtCashClosingBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCashClosingBalance.CustomButton.UseSelectable = true;
            this.txtCashClosingBalance.CustomButton.Visible = false;
            this.txtCashClosingBalance.Lines = new string[0];
            this.txtCashClosingBalance.Location = new System.Drawing.Point(243, 8);
            this.txtCashClosingBalance.MaxLength = 32767;
            this.txtCashClosingBalance.Name = "txtCashClosingBalance";
            this.txtCashClosingBalance.PasswordChar = '\0';
            this.txtCashClosingBalance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCashClosingBalance.SelectedText = "";
            this.txtCashClosingBalance.SelectionLength = 0;
            this.txtCashClosingBalance.SelectionStart = 0;
            this.txtCashClosingBalance.ShortcutsEnabled = true;
            this.txtCashClosingBalance.Size = new System.Drawing.Size(142, 23);
            this.txtCashClosingBalance.TabIndex = 23;
            this.txtCashClosingBalance.UseSelectable = true;
            this.txtCashClosingBalance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCashClosingBalance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.btnAddCashAccount.Location = new System.Drawing.Point(391, 4);
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
            this.cbxCashAccounts.Location = new System.Drawing.Point(68, 4);
            this.cbxCashAccounts.Name = "cbxCashAccounts";
            this.cbxCashAccounts.Size = new System.Drawing.Size(45, 29);
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
            this.panel2.Location = new System.Drawing.Point(517, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 37);
            this.panel2.TabIndex = 10;
            // 
            // cbxNaturalAccounts
            // 
            this.cbxNaturalAccounts.FormattingEnabled = true;
            this.cbxNaturalAccounts.ItemHeight = 23;
            this.cbxNaturalAccounts.Location = new System.Drawing.Point(83, 5);
            this.cbxNaturalAccounts.Name = "cbxNaturalAccounts";
            this.cbxNaturalAccounts.Size = new System.Drawing.Size(203, 29);
            this.cbxNaturalAccounts.TabIndex = 0;
            this.cbxNaturalAccounts.UseSelectable = true;
            this.cbxNaturalAccounts.SelectedIndexChanged += new System.EventHandler(this.cbxNaturalAccounts_SelectedIndexChanged);
            this.cbxNaturalAccounts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxNaturalAccounts_KeyPress);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(440, 4);
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
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Debit A/C :";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // btnAddPurchasesAccount
            // 
            this.btnAddPurchasesAccount.Location = new System.Drawing.Point(290, 5);
            this.btnAddPurchasesAccount.Name = "btnAddPurchasesAccount";
            this.btnAddPurchasesAccount.Size = new System.Drawing.Size(146, 29);
            this.btnAddPurchasesAccount.TabIndex = 17;
            this.btnAddPurchasesAccount.Text = "Add Inventory Account";
            this.btnAddPurchasesAccount.UseSelectable = true;
            this.btnAddPurchasesAccount.Click += new System.EventHandler(this.btnAddPurchasesAccount_Click);
            // 
            // SEditBox
            // 
            // 
            // 
            // 
            this.SEditBox.CustomButton.Image = null;
            this.SEditBox.CustomButton.Location = new System.Drawing.Point(312, 1);
            this.SEditBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.SEditBox.CustomButton.Name = "";
            this.SEditBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SEditBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SEditBox.CustomButton.TabIndex = 1;
            this.SEditBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SEditBox.CustomButton.UseSelectable = true;
            this.SEditBox.Lines = new string[0];
            this.SEditBox.Location = new System.Drawing.Point(90, 20);
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
            this.SEditBox.Size = new System.Drawing.Size(334, 23);
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
            this.metroLabel2.Location = new System.Drawing.Point(7, 21);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Credit A/C :";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.VEditedDateTime);
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this.VDate);
            this.groupBox1.Controls.Add(this.VEditBox);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.txtSheetNo);
            this.groupBox1.Controls.Add(this.lblDiscription);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.lblBillNo);
            this.groupBox1.Controls.Add(this.lblVoucherNo);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.chkPosted);
            this.groupBox1.Controls.Add(this.txtBiltyNo);
            this.groupBox1.Controls.Add(this.txtBillNo);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1105, 98);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill Information";
            // 
            // VEditedDateTime
            // 
            this.VEditedDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VEditedDateTime.Location = new System.Drawing.Point(690, 20);
            this.VEditedDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.VEditedDateTime.Name = "VEditedDateTime";
            this.VEditedDateTime.Size = new System.Drawing.Size(104, 29);
            this.VEditedDateTime.TabIndex = 24;
            this.VEditedDateTime.ValueChanged += new System.EventHandler(this.VEditedDateTime_ValueChanged);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(609, 25);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(77, 19);
            this.metroLabel11.TabIndex = 23;
            this.metroLabel11.Text = "Edited On :";
            this.metroLabel11.UseCustomBackColor = true;
            // 
            // VDate
            // 
            this.VDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VDate.Location = new System.Drawing.Point(495, 20);
            this.VDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.VDate.Name = "VDate";
            this.VDate.Size = new System.Drawing.Size(109, 29);
            this.VDate.TabIndex = 22;
            // 
            // VEditBox
            // 
            // 
            // 
            // 
            this.VEditBox.CustomButton.Image = null;
            this.VEditBox.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.VEditBox.CustomButton.Name = "";
            this.VEditBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.VEditBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.VEditBox.CustomButton.TabIndex = 1;
            this.VEditBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.VEditBox.CustomButton.UseSelectable = true;
            this.VEditBox.Lines = new string[0];
            this.VEditBox.Location = new System.Drawing.Point(82, 24);
            this.VEditBox.MaxLength = 32767;
            this.VEditBox.Name = "VEditBox";
            this.VEditBox.PasswordChar = '\0';
            this.VEditBox.PromptText = "Purchase No";
            this.VEditBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.VEditBox.SelectedText = "";
            this.VEditBox.SelectionLength = 0;
            this.VEditBox.SelectionStart = 0;
            this.VEditBox.ShortcutsEnabled = true;
            this.VEditBox.ShowButton = true;
            this.VEditBox.Size = new System.Drawing.Size(155, 23);
            this.VEditBox.Style = MetroFramework.MetroColorStyle.Pink;
            this.VEditBox.TabIndex = 21;
            this.VEditBox.UseSelectable = true;
            this.VEditBox.WaterMark = "Purchase No";
            this.VEditBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.VEditBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.VEditBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.VEditBox_ButtonClick);
            this.VEditBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VEditBox_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(242, 26);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(55, 19);
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "Sheet #";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // txtSheetNo
            // 
            // 
            // 
            // 
            this.txtSheetNo.CustomButton.Image = null;
            this.txtSheetNo.CustomButton.Location = new System.Drawing.Point(67, 1);
            this.txtSheetNo.CustomButton.Name = "";
            this.txtSheetNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSheetNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSheetNo.CustomButton.TabIndex = 1;
            this.txtSheetNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSheetNo.CustomButton.UseSelectable = true;
            this.txtSheetNo.CustomButton.Visible = false;
            this.txtSheetNo.Lines = new string[0];
            this.txtSheetNo.Location = new System.Drawing.Point(302, 24);
            this.txtSheetNo.MaxLength = 32767;
            this.txtSheetNo.Name = "txtSheetNo";
            this.txtSheetNo.PasswordChar = '\0';
            this.txtSheetNo.PromptText = "Any Sheet No";
            this.txtSheetNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSheetNo.SelectedText = "";
            this.txtSheetNo.SelectionLength = 0;
            this.txtSheetNo.SelectionStart = 0;
            this.txtSheetNo.ShortcutsEnabled = true;
            this.txtSheetNo.Size = new System.Drawing.Size(89, 23);
            this.txtSheetNo.TabIndex = 1;
            this.txtSheetNo.UseSelectable = true;
            this.txtSheetNo.WaterMark = "Any Sheet No";
            this.txtSheetNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSheetNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSheetNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillNo_KeyPress);
            // 
            // lblDiscription
            // 
            this.lblDiscription.AutoSize = true;
            this.lblDiscription.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscription.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDiscription.Location = new System.Drawing.Point(1, 60);
            this.lblDiscription.Name = "lblDiscription";
            this.lblDiscription.Size = new System.Drawing.Size(81, 19);
            this.lblDiscription.TabIndex = 19;
            this.lblDiscription.Text = "Discription :";
            this.lblDiscription.UseCustomBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(799, 24);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 19);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "Bilty No :";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.BackColor = System.Drawing.Color.Transparent;
            this.lblBillNo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBillNo.Location = new System.Drawing.Point(959, 23);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(55, 19);
            this.lblBillNo.TabIndex = 19;
            this.lblBillNo.Text = "Bill No :";
            this.lblBillNo.UseCustomBackColor = true;
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.BackColor = System.Drawing.Color.Transparent;
            this.lblVoucherNo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblVoucherNo.Location = new System.Drawing.Point(6, 26);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(71, 19);
            this.lblVoucherNo.TabIndex = 19;
            this.lblVoucherNo.Text = "Voucher #";
            this.lblVoucherNo.UseCustomBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDate.Location = new System.Drawing.Point(395, 25);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(97, 19);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "Created Date :";
            this.lblDate.UseCustomBackColor = true;
            // 
            // chkPosted
            // 
            this.chkPosted.AutoSize = true;
            this.chkPosted.BackColor = System.Drawing.Color.Transparent;
            this.chkPosted.Location = new System.Drawing.Point(952, 64);
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
            this.txtBiltyNo.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.txtBiltyNo.CustomButton.Name = "";
            this.txtBiltyNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBiltyNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBiltyNo.CustomButton.TabIndex = 1;
            this.txtBiltyNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBiltyNo.CustomButton.UseSelectable = true;
            this.txtBiltyNo.CustomButton.Visible = false;
            this.txtBiltyNo.Lines = new string[0];
            this.txtBiltyNo.Location = new System.Drawing.Point(866, 24);
            this.txtBiltyNo.MaxLength = 32767;
            this.txtBiltyNo.Name = "txtBiltyNo";
            this.txtBiltyNo.PasswordChar = '\0';
            this.txtBiltyNo.PromptText = "Bilty No Here";
            this.txtBiltyNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBiltyNo.SelectedText = "";
            this.txtBiltyNo.SelectionLength = 0;
            this.txtBiltyNo.SelectionStart = 0;
            this.txtBiltyNo.ShortcutsEnabled = true;
            this.txtBiltyNo.Size = new System.Drawing.Size(94, 23);
            this.txtBiltyNo.TabIndex = 1;
            this.txtBiltyNo.UseSelectable = true;
            this.txtBiltyNo.WaterMark = "Bilty No Here";
            this.txtBiltyNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBiltyNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBiltyNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillNo_KeyPress);
            // 
            // txtBillNo
            // 
            // 
            // 
            // 
            this.txtBillNo.CustomButton.Image = null;
            this.txtBillNo.CustomButton.Location = new System.Drawing.Point(59, 1);
            this.txtBillNo.CustomButton.Name = "";
            this.txtBillNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBillNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBillNo.CustomButton.TabIndex = 1;
            this.txtBillNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBillNo.CustomButton.UseSelectable = true;
            this.txtBillNo.CustomButton.Visible = false;
            this.txtBillNo.Lines = new string[0];
            this.txtBillNo.Location = new System.Drawing.Point(1021, 23);
            this.txtBillNo.MaxLength = 32767;
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.PasswordChar = '\0';
            this.txtBillNo.PromptText = "Bill No";
            this.txtBillNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBillNo.SelectedText = "";
            this.txtBillNo.SelectionLength = 0;
            this.txtBillNo.SelectionStart = 0;
            this.txtBillNo.ShortcutsEnabled = true;
            this.txtBillNo.Size = new System.Drawing.Size(81, 23);
            this.txtBillNo.TabIndex = 1;
            this.txtBillNo.UseSelectable = true;
            this.txtBillNo.WaterMark = "Bill No";
            this.txtBillNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBillNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBillNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillNo_KeyPress);
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(828, 1);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(82, 51);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(864, 37);
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
            this.flowMainPanel.Controls.Add(this.grpCreditor);
            this.flowMainPanel.Controls.Add(this.tabPurchaseTransactions);
            this.flowMainPanel.Controls.Add(this.pnlButtons);
            this.flowMainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowMainPanel.Location = new System.Drawing.Point(14, 57);
            this.flowMainPanel.Name = "flowMainPanel";
            this.flowMainPanel.Size = new System.Drawing.Size(1115, 659);
            this.flowMainPanel.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "IdVoucherDetail";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "IdItem";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AccountNo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Product Code";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Product Discription";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "UOM";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 90;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "CTN";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 90;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "BatchNo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 90;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Expiry";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 90;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Engine #";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 80;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Chassis #";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 80;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Model";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 80;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Vehicle #";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 90;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "IMEI #";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Second IMEI";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn15.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 80;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Bonus";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 80;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn17.HeaderText = "Unit Price";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 80;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "qty*amount";
            this.dataGridViewTextBoxColumn18.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn18.Width = 90;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "Disc(%)";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 90;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.HeaderText = "Net Amount";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.HeaderText = "VoucherDetailId";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Visible = false;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.HeaderText = "AccountId";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Visible = false;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "AccountNo";
            this.dataGridViewTextBoxColumn23.HeaderText = "Acc. #";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Visible = false;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.HeaderText = "A/C Name";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 250;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.HeaderText = "Closing Balance";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Width = 120;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.HeaderText = "Narration";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.Width = 385;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.HeaderText = "Debit";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.Width = 120;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.HeaderText = "Credit";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.Width = 120;
            // 
            // frmStockReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1150, 749);
            this.Controls.Add(this.flowMainPanel);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStockReceipt";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Goods Purchases Receipt Note";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.frmStockReceipt_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmStockReceipt_KeyPress);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.tabPurchaseTransactions.ResumeLayout(false);
            this.tabLineItems.ResumeLayout(false);
            this.tabLineItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStockReceipt)).EndInit();
            this.tabSalesTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPurchases)).EndInit();
            this.grpCreditor.ResumeLayout(false);
            this.grpCreditor.PerformLayout();
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
        private System.Windows.Forms.TabControl tabPurchaseTransactions;
        private System.Windows.Forms.TabPage tabLineItems;
        private TabDataGrid DgvStockReceipt;
        private MetroFramework.Controls.MetroTextBox txtBillAmount;
        private MetroFramework.Controls.MetroLabel lblTotal;
        private System.Windows.Forms.TabPage tabSalesTransactions;
        private TabDataGrid DgvPurchases;
        private System.Windows.Forms.GroupBox grpCreditor;
        private MetroFramework.Controls.MetroTextBox txtCurrentBalance;
        private MetroFramework.Controls.MetroButton btnViewDetail;
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
        private MetroFramework.Controls.MetroTextBox VEditBox;
        private MetroFramework.Controls.MetroLabel lblDiscription;
        private MetroFramework.Controls.MetroLabel lblBillNo;
        private MetroFramework.Controls.MetroLabel lblVoucherNo;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroCheckBox chkPosted;
        private MetroFramework.Controls.MetroTextBox txtBillNo;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private System.Windows.Forms.FlowLayoutPanel flowMainPanel;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtBiltyNo;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblVouchersCount;
        private MetroFramework.Controls.MetroLabel lblTotalVouchers;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lblLastVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdDetailVoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClosingBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCredit;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtSheetNo;
        private MetroFramework.Controls.MetroTextBox txtTotalAmount;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtFreightAmount;
        private MetroFramework.Controls.MetroLabel lblFreight;
        private MetroFramework.Controls.MetroTile btnPrintPurchaseInvoice;
        private MetroFramework.Controls.MetroTextBox txtCashClosingBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private MetroFramework.Controls.MetroTextBox txtAmountAfterDiscount;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtFlatDiscount;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtTotalDiscount;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroRadioButton rdCash;
        private MetroFramework.Controls.MetroRadioButton rdCredit;
        private MetroFramework.Controls.MetroDateTime VEditedDateTime;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel lblVoucherStatus;
        private MetroFramework.Controls.MetroTextBox txtSystemWeight;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox txtManualWeight;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox txt2kgWeight;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdVoucherDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutoWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFlatDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscountAmount;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}