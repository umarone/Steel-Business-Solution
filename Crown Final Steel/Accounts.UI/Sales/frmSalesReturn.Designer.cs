namespace Accounts.UI
{
    partial class frmSalesReturn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatuMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblVouchersCount = new MetroFramework.Controls.MetroLabel();
            this.lblTotalVouchers = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lblLastVoucherNo = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.btnNext = new MetroFramework.Controls.MetroTile();
            this.btnNew = new MetroFramework.Controls.MetroTile();
            this.lblVoucherStatus = new MetroFramework.Controls.MetroLabel();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnPrevious = new MetroFramework.Controls.MetroTile();
            this.btnClose = new MetroFramework.Controls.MetroTile();
            this.tabSales = new System.Windows.Forms.TabControl();
            this.tabLineItems = new System.Windows.Forms.TabPage();
            this.txt2kgWeight = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.txtManualWeight = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.txtSystemWeight = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtFreightAmount = new MetroFramework.Controls.MetroTextBox();
            this.lblFreight = new MetroFramework.Controls.MetroLabel();
            this.txtBillAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.DgvStockSales = new Accounts.UI.TabDataGrid();
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
            this.colWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtTotalAmount = new MetroFramework.Controls.MetroTextBox();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
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
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnAddCustomer = new MetroFramework.Controls.MetroButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtCurrentBalance = new MetroFramework.Controls.MetroTextBox();
            this.txtDeliveryPerson = new MetroFramework.Controls.MetroTextBox();
            this.grpSales = new System.Windows.Forms.GroupBox();
            this.flowPurchasesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCash = new System.Windows.Forms.Panel();
            this.txtCashClosingBalance = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbxCashAccounts = new MetroFramework.Controls.MetroComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxAdjustmentTypes = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cbxNaturalAccounts = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.EmpEditCode = new MetroFramework.Controls.MetroTextBox();
            this.btnViewDetail = new MetroFramework.Controls.MetroButton();
            this.txtContact = new MetroFramework.Controls.MetroTextBox();
            this.SEditBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VEditedDateTime = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txtInvoiceNo = new MetroFramework.Controls.MetroTextBox();
            this.txtInwardGatePass = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtGatePass = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.VDate = new MetroFramework.Controls.MetroDateTime();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
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
            this.statusStrip1.Size = new System.Drawing.Size(1028, 22);
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
            this.pnlButtons.Controls.Add(this.btnNext);
            this.pnlButtons.Controls.Add(this.btnNew);
            this.pnlButtons.Controls.Add(this.lblVoucherStatus);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnPrevious);
            this.pnlButtons.Controls.Add(this.btnClose);
            this.pnlButtons.Location = new System.Drawing.Point(3, 607);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1025, 48);
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
            this.metroPanel1.Size = new System.Drawing.Size(353, 36);
            this.metroPanel1.TabIndex = 21;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblVouchersCount
            // 
            this.lblVouchersCount.AutoSize = true;
            this.lblVouchersCount.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblVouchersCount.Location = new System.Drawing.Point(3, 7);
            this.lblVouchersCount.Name = "lblVouchersCount";
            this.lblVouchersCount.Size = new System.Drawing.Size(105, 19);
            this.lblVouchersCount.TabIndex = 2;
            this.lblVouchersCount.Text = "Total Vouchers :";
            // 
            // lblTotalVouchers
            // 
            this.lblTotalVouchers.AutoSize = true;
            this.lblTotalVouchers.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTotalVouchers.Location = new System.Drawing.Point(111, 9);
            this.lblTotalVouchers.Name = "lblTotalVouchers";
            this.lblTotalVouchers.Size = new System.Drawing.Size(17, 19);
            this.lblTotalVouchers.TabIndex = 2;
            this.lblTotalVouchers.Text = "0";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(161, 7);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(117, 19);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Last Voucher No :";
            // 
            // lblLastVoucherNo
            // 
            this.lblLastVoucherNo.AutoSize = true;
            this.lblLastVoucherNo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblLastVoucherNo.Location = new System.Drawing.Point(290, 7);
            this.lblLastVoucherNo.Name = "lblLastVoucherNo";
            this.lblLastVoucherNo.Size = new System.Drawing.Size(17, 19);
            this.lblLastVoucherNo.TabIndex = 2;
            this.lblLastVoucherNo.Text = "0";
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSave.Location = new System.Drawing.Point(718, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 40);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSave.TabIndex = 11;
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
            this.btnNext.Location = new System.Drawing.Point(643, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(74, 40);
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
            this.btnNew.Location = new System.Drawing.Point(946, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 40);
            this.btnNew.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "New Voucher";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNew.UseCustomBackColor = true;
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblVoucherStatus
            // 
            this.lblVoucherStatus.AutoSize = true;
            this.lblVoucherStatus.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblVoucherStatus.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblVoucherStatus.ForeColor = System.Drawing.Color.Red;
            this.lblVoucherStatus.Location = new System.Drawing.Point(363, 11);
            this.lblVoucherStatus.Name = "lblVoucherStatus";
            this.lblVoucherStatus.Size = new System.Drawing.Size(93, 25);
            this.lblVoucherStatus.TabIndex = 38;
            this.lblVoucherStatus.Text = "asdfsdfsd";
            this.lblVoucherStatus.UseCustomForeColor = true;
            this.lblVoucherStatus.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveControl = null;
            this.btnDelete.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDelete.Location = new System.Drawing.Point(795, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 40);
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
            this.btnPrevious.Location = new System.Drawing.Point(567, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 40);
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
            this.btnClose.Location = new System.Drawing.Point(870, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 40);
            this.btnClose.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnClose.TabIndex = 13;
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
            this.tabSales.Location = new System.Drawing.Point(3, 237);
            this.tabSales.Name = "tabSales";
            this.tabSales.SelectedIndex = 0;
            this.tabSales.Size = new System.Drawing.Size(1026, 364);
            this.tabSales.TabIndex = 24;
            this.tabSales.SelectedIndexChanged += new System.EventHandler(this.tabSales_SelectedIndexChanged);
            // 
            // tabLineItems
            // 
            this.tabLineItems.Controls.Add(this.txt2kgWeight);
            this.tabLineItems.Controls.Add(this.metroLabel21);
            this.tabLineItems.Controls.Add(this.txtManualWeight);
            this.tabLineItems.Controls.Add(this.metroLabel13);
            this.tabLineItems.Controls.Add(this.txtSystemWeight);
            this.tabLineItems.Controls.Add(this.metroLabel11);
            this.tabLineItems.Controls.Add(this.txtFreightAmount);
            this.tabLineItems.Controls.Add(this.lblFreight);
            this.tabLineItems.Controls.Add(this.txtBillAmount);
            this.tabLineItems.Controls.Add(this.metroLabel10);
            this.tabLineItems.Controls.Add(this.DgvStockSales);
            this.tabLineItems.Controls.Add(this.txtTotalAmount);
            this.tabLineItems.Controls.Add(this.lblTotal);
            this.tabLineItems.Location = new System.Drawing.Point(4, 25);
            this.tabLineItems.Name = "tabLineItems";
            this.tabLineItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabLineItems.Size = new System.Drawing.Size(1018, 335);
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
            this.txt2kgWeight.CustomButton.Location = new System.Drawing.Point(156, 1);
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
            this.txt2kgWeight.Location = new System.Drawing.Point(129, 309);
            this.txt2kgWeight.MaxLength = 32767;
            this.txt2kgWeight.Name = "txt2kgWeight";
            this.txt2kgWeight.PasswordChar = '\0';
            this.txt2kgWeight.ReadOnly = true;
            this.txt2kgWeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt2kgWeight.SelectedText = "";
            this.txt2kgWeight.SelectionLength = 0;
            this.txt2kgWeight.SelectionStart = 0;
            this.txt2kgWeight.ShortcutsEnabled = true;
            this.txt2kgWeight.Size = new System.Drawing.Size(178, 23);
            this.txt2kgWeight.TabIndex = 49;
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
            this.metroLabel21.Location = new System.Drawing.Point(2, 309);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(124, 19);
            this.metroLabel21.TabIndex = 50;
            this.metroLabel21.Text = "Auto Weight(2kg) :";
            // 
            // txtManualWeight
            // 
            this.txtManualWeight.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtManualWeight.CustomButton.Image = null;
            this.txtManualWeight.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.txtManualWeight.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtManualWeight.CustomButton.Name = "";
            this.txtManualWeight.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtManualWeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtManualWeight.CustomButton.TabIndex = 1;
            this.txtManualWeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtManualWeight.CustomButton.UseSelectable = true;
            this.txtManualWeight.CustomButton.Visible = false;
            this.txtManualWeight.Lines = new string[0];
            this.txtManualWeight.Location = new System.Drawing.Point(129, 284);
            this.txtManualWeight.MaxLength = 32767;
            this.txtManualWeight.Name = "txtManualWeight";
            this.txtManualWeight.PasswordChar = '\0';
            this.txtManualWeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtManualWeight.SelectedText = "";
            this.txtManualWeight.SelectionLength = 0;
            this.txtManualWeight.SelectionStart = 0;
            this.txtManualWeight.ShortcutsEnabled = true;
            this.txtManualWeight.Size = new System.Drawing.Size(178, 23);
            this.txtManualWeight.TabIndex = 50;
            this.txtManualWeight.UseCustomBackColor = true;
            this.txtManualWeight.UseSelectable = true;
            this.txtManualWeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtManualWeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtManualWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtManualWeight_KeyPress);
            this.txtManualWeight.Leave += new System.EventHandler(this.txtManualWeight_Leave);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(16, 284);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(109, 19);
            this.metroLabel13.TabIndex = 51;
            this.metroLabel13.Text = "Manual Weight :";
            // 
            // txtSystemWeight
            // 
            this.txtSystemWeight.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtSystemWeight.CustomButton.Image = null;
            this.txtSystemWeight.CustomButton.Location = new System.Drawing.Point(156, 1);
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
            this.txtSystemWeight.Location = new System.Drawing.Point(129, 259);
            this.txtSystemWeight.MaxLength = 32767;
            this.txtSystemWeight.Name = "txtSystemWeight";
            this.txtSystemWeight.PasswordChar = '\0';
            this.txtSystemWeight.ReadOnly = true;
            this.txtSystemWeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSystemWeight.SelectedText = "";
            this.txtSystemWeight.SelectionLength = 0;
            this.txtSystemWeight.SelectionStart = 0;
            this.txtSystemWeight.ShortcutsEnabled = true;
            this.txtSystemWeight.Size = new System.Drawing.Size(178, 23);
            this.txtSystemWeight.TabIndex = 50;
            this.txtSystemWeight.UseCustomBackColor = true;
            this.txtSystemWeight.UseSelectable = true;
            this.txtSystemWeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSystemWeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(16, 259);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(107, 19);
            this.metroLabel11.TabIndex = 51;
            this.metroLabel11.Text = "System Weight :";
            // 
            // txtFreightAmount
            // 
            this.txtFreightAmount.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtFreightAmount.CustomButton.Image = null;
            this.txtFreightAmount.CustomButton.Location = new System.Drawing.Point(128, 1);
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
            this.txtFreightAmount.Location = new System.Drawing.Point(863, 282);
            this.txtFreightAmount.MaxLength = 32767;
            this.txtFreightAmount.Name = "txtFreightAmount";
            this.txtFreightAmount.PasswordChar = '\0';
            this.txtFreightAmount.PromptText = "Total Freigh";
            this.txtFreightAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFreightAmount.SelectedText = "";
            this.txtFreightAmount.SelectionLength = 0;
            this.txtFreightAmount.SelectionStart = 0;
            this.txtFreightAmount.ShortcutsEnabled = true;
            this.txtFreightAmount.Size = new System.Drawing.Size(150, 23);
            this.txtFreightAmount.TabIndex = 48;
            this.txtFreightAmount.Text = "0";
            this.txtFreightAmount.UseCustomBackColor = true;
            this.txtFreightAmount.UseSelectable = true;
            this.txtFreightAmount.WaterMark = "Total Freigh";
            this.txtFreightAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFreightAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFreightAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFreightAmount_KeyPress);
            this.txtFreightAmount.Leave += new System.EventHandler(this.txtFreightAmount_Leave);
            // 
            // lblFreight
            // 
            this.lblFreight.AutoSize = true;
            this.lblFreight.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblFreight.Location = new System.Drawing.Point(742, 282);
            this.lblFreight.Name = "lblFreight";
            this.lblFreight.Size = new System.Drawing.Size(113, 19);
            this.lblFreight.TabIndex = 49;
            this.lblFreight.Text = "Freight Amount :";
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtBillAmount.CustomButton.Image = null;
            this.txtBillAmount.CustomButton.Location = new System.Drawing.Point(128, 1);
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
            this.txtBillAmount.Location = new System.Drawing.Point(863, 257);
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
            this.txtBillAmount.Size = new System.Drawing.Size(150, 23);
            this.txtBillAmount.TabIndex = 46;
            this.txtBillAmount.UseCustomBackColor = true;
            this.txtBillAmount.UseSelectable = true;
            this.txtBillAmount.WaterMark = "Total Bill Amount";
            this.txtBillAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBillAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(770, 257);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(87, 19);
            this.metroLabel10.TabIndex = 47;
            this.metroLabel10.Text = "Bill Amount :";
            // 
            // DgvStockSales
            // 
            this.DgvStockSales.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvStockSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvStockSales.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvStockSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
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
            this.colQty,
            this.colWeight,
            this.colUnitPrice,
            this.colAmount,
            this.colDelete});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvStockSales.DefaultCellStyle = dataGridViewCellStyle13;
            this.DgvStockSales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvStockSales.EnableHeadersVisualStyles = false;
            this.DgvStockSales.Location = new System.Drawing.Point(6, 8);
            this.DgvStockSales.MultiSelect = false;
            this.DgvStockSales.Name = "DgvStockSales";
            this.DgvStockSales.RowHeadersVisible = false;
            this.DgvStockSales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvStockSales.Size = new System.Drawing.Size(1015, 246);
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colItemName.DefaultCellStyle = dataGridViewCellStyle11;
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
            // colWeight
            // 
            this.colWeight.HeaderText = "Weight";
            this.colWeight.Name = "colWeight";
            this.colWeight.Width = 85;
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
            // colDelete
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Red;
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle12;
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
            this.txtTotalAmount.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.txtTotalAmount.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalAmount.CustomButton.Name = "";
            this.txtTotalAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalAmount.CustomButton.TabIndex = 1;
            this.txtTotalAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalAmount.CustomButton.UseSelectable = true;
            this.txtTotalAmount.CustomButton.Visible = false;
            this.txtTotalAmount.Lines = new string[0];
            this.txtTotalAmount.Location = new System.Drawing.Point(863, 307);
            this.txtTotalAmount.MaxLength = 32767;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.PasswordChar = '\0';
            this.txtTotalAmount.PromptText = "Total Amount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalAmount.SelectedText = "";
            this.txtTotalAmount.SelectionLength = 0;
            this.txtTotalAmount.SelectionStart = 0;
            this.txtTotalAmount.ShortcutsEnabled = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(150, 23);
            this.txtTotalAmount.TabIndex = 22;
            this.txtTotalAmount.UseCustomBackColor = true;
            this.txtTotalAmount.UseSelectable = true;
            this.txtTotalAmount.WaterMark = "Total Amount";
            this.txtTotalAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTotal.Location = new System.Drawing.Point(758, 308);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(99, 19);
            this.lblTotal.TabIndex = 24;
            this.lblTotal.Text = "Total Amount :";
            // 
            // tabSalesTransactions
            // 
            this.tabSalesTransactions.Controls.Add(this.DgvSalesTransactions);
            this.tabSalesTransactions.Location = new System.Drawing.Point(4, 25);
            this.tabSalesTransactions.Name = "tabSalesTransactions";
            this.tabSalesTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalesTransactions.Size = new System.Drawing.Size(1018, 335);
            this.tabSalesTransactions.TabIndex = 1;
            this.tabSalesTransactions.Text = "Transactions";
            this.tabSalesTransactions.UseVisualStyleBackColor = true;
            // 
            // DgvSalesTransactions
            // 
            this.DgvSalesTransactions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvSalesTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            this.DgvSalesTransactions.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvSalesTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSalesTransactions.DefaultCellStyle = dataGridViewCellStyle16;
            this.DgvSalesTransactions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvSalesTransactions.EnableHeadersVisualStyles = false;
            this.DgvSalesTransactions.Location = new System.Drawing.Point(4, 6);
            this.DgvSalesTransactions.MultiSelect = false;
            this.DgvSalesTransactions.Name = "DgvSalesTransactions";
            this.DgvSalesTransactions.RowHeadersVisible = false;
            this.DgvSalesTransactions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvSalesTransactions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvSalesTransactions.Size = new System.Drawing.Size(1008, 299);
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
            this.colAccountName.Width = 265;
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
            this.colDescription.Width = 375;
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
            this.grpDebitor.Controls.Add(this.metroLabel6);
            this.grpDebitor.Controls.Add(this.btnAddCustomer);
            this.grpDebitor.Controls.Add(this.metroLabel9);
            this.grpDebitor.Controls.Add(this.txtCurrentBalance);
            this.grpDebitor.Controls.Add(this.txtDeliveryPerson);
            this.grpDebitor.Controls.Add(this.grpSales);
            this.grpDebitor.Controls.Add(this.EmpEditCode);
            this.grpDebitor.Controls.Add(this.btnViewDetail);
            this.grpDebitor.Controls.Add(this.txtContact);
            this.grpDebitor.Controls.Add(this.SEditBox);
            this.grpDebitor.Controls.Add(this.metroLabel2);
            this.grpDebitor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDebitor.Location = new System.Drawing.Point(3, 126);
            this.grpDebitor.Name = "grpDebitor";
            this.grpDebitor.Size = new System.Drawing.Size(1014, 105);
            this.grpDebitor.TabIndex = 22;
            this.grpDebitor.TabStop = false;
            this.grpDebitor.Text = "Customer Information";
            // 
            // rdCash
            // 
            this.rdCash.AutoSize = true;
            this.rdCash.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdCash.ForeColor = System.Drawing.Color.Black;
            this.rdCash.Location = new System.Drawing.Point(251, 79);
            this.rdCash.Name = "rdCash";
            this.rdCash.Size = new System.Drawing.Size(134, 19);
            this.rdCash.TabIndex = 37;
            this.rdCash.Text = "Cash Sales Return";
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
            this.rdCredit.Location = new System.Drawing.Point(101, 80);
            this.rdCredit.Name = "rdCredit";
            this.rdCredit.Size = new System.Drawing.Size(141, 19);
            this.rdCredit.TabIndex = 36;
            this.rdCredit.Text = "Credit Sales Return";
            this.rdCredit.UseCustomBackColor = true;
            this.rdCredit.UseCustomForeColor = true;
            this.rdCredit.UseSelectable = true;
            this.rdCredit.CheckedChanged += new System.EventHandler(this.rdCredit_CheckedChanged);
            this.rdCredit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rdCredit_KeyPress);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(445, 52);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(110, 19);
            this.metroLabel6.TabIndex = 34;
            this.metroLabel6.Text = "Delivery Person :";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(743, 24);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(99, 23);
            this.btnAddCustomer.TabIndex = 26;
            this.btnAddCustomer.Text = "Add  Customer";
            this.btnAddCustomer.UseSelectable = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(7, 52);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(87, 19);
            this.metroLabel9.TabIndex = 35;
            this.metroLabel9.Text = "Order Taker :";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel9.UseCustomBackColor = true;
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
            this.txtCurrentBalance.Location = new System.Drawing.Point(448, 25);
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
            this.txtDeliveryPerson.Location = new System.Drawing.Point(563, 52);
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
            this.txtDeliveryPerson.TabIndex = 32;
            this.txtDeliveryPerson.UseSelectable = true;
            this.txtDeliveryPerson.WaterMark = "Type Here To Select Delivery Person";
            this.txtDeliveryPerson.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDeliveryPerson.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDeliveryPerson.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtDeliveryPerson_ButtonClick);
            this.txtDeliveryPerson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeliveryPerson_KeyPress);
            // 
            // grpSales
            // 
            this.grpSales.BackColor = System.Drawing.Color.MistyRose;
            this.grpSales.Controls.Add(this.flowPurchasesPanel);
            this.grpSales.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSales.Location = new System.Drawing.Point(956, 20);
            this.grpSales.Name = "grpSales";
            this.grpSales.Size = new System.Drawing.Size(31, 23);
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
            this.pnlCash.Controls.Add(this.txtCashClosingBalance);
            this.pnlCash.Controls.Add(this.metroLabel3);
            this.pnlCash.Controls.Add(this.cbxCashAccounts);
            this.pnlCash.Location = new System.Drawing.Point(3, 3);
            this.pnlCash.Name = "pnlCash";
            this.pnlCash.Size = new System.Drawing.Size(403, 35);
            this.pnlCash.TabIndex = 10;
            // 
            // txtCashClosingBalance
            // 
            // 
            // 
            // 
            this.txtCashClosingBalance.CustomButton.Image = null;
            this.txtCashClosingBalance.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtCashClosingBalance.CustomButton.Name = "";
            this.txtCashClosingBalance.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCashClosingBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCashClosingBalance.CustomButton.TabIndex = 1;
            this.txtCashClosingBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCashClosingBalance.CustomButton.UseSelectable = true;
            this.txtCashClosingBalance.CustomButton.Visible = false;
            this.txtCashClosingBalance.Lines = new string[0];
            this.txtCashClosingBalance.Location = new System.Drawing.Point(283, 7);
            this.txtCashClosingBalance.MaxLength = 32767;
            this.txtCashClosingBalance.Name = "txtCashClosingBalance";
            this.txtCashClosingBalance.PasswordChar = '\0';
            this.txtCashClosingBalance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCashClosingBalance.SelectedText = "";
            this.txtCashClosingBalance.SelectionLength = 0;
            this.txtCashClosingBalance.SelectionStart = 0;
            this.txtCashClosingBalance.ShortcutsEnabled = true;
            this.txtCashClosingBalance.Size = new System.Drawing.Size(114, 23);
            this.txtCashClosingBalance.TabIndex = 25;
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
            // cbxCashAccounts
            // 
            this.cbxCashAccounts.FormattingEnabled = true;
            this.cbxCashAccounts.ItemHeight = 23;
            this.cbxCashAccounts.Location = new System.Drawing.Point(6, 4);
            this.cbxCashAccounts.Name = "cbxCashAccounts";
            this.cbxCashAccounts.Size = new System.Drawing.Size(24, 29);
            this.cbxCashAccounts.TabIndex = 0;
            this.cbxCashAccounts.UseSelectable = true;
            this.cbxCashAccounts.SelectedIndexChanged += new System.EventHandler(this.cbxCashAccounts_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbxAdjustmentTypes);
            this.panel2.Controls.Add(this.metroLabel5);
            this.panel2.Controls.Add(this.cbxNaturalAccounts);
            this.panel2.Controls.Add(this.metroLabel1);
            this.panel2.Location = new System.Drawing.Point(412, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 37);
            this.panel2.TabIndex = 10;
            // 
            // cbxAdjustmentTypes
            // 
            this.cbxAdjustmentTypes.FormattingEnabled = true;
            this.cbxAdjustmentTypes.ItemHeight = 23;
            this.cbxAdjustmentTypes.Location = new System.Drawing.Point(375, 6);
            this.cbxAdjustmentTypes.Name = "cbxAdjustmentTypes";
            this.cbxAdjustmentTypes.Size = new System.Drawing.Size(196, 29);
            this.cbxAdjustmentTypes.TabIndex = 29;
            this.cbxAdjustmentTypes.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(282, 9);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(89, 19);
            this.metroLabel5.TabIndex = 30;
            this.metroLabel5.Text = "Return Type :";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // cbxNaturalAccounts
            // 
            this.cbxNaturalAccounts.FormattingEnabled = true;
            this.cbxNaturalAccounts.ItemHeight = 23;
            this.cbxNaturalAccounts.Location = new System.Drawing.Point(83, 5);
            this.cbxNaturalAccounts.Name = "cbxNaturalAccounts";
            this.cbxNaturalAccounts.Size = new System.Drawing.Size(193, 29);
            this.cbxNaturalAccounts.TabIndex = 0;
            this.cbxNaturalAccounts.UseSelectable = true;
            this.cbxNaturalAccounts.SelectedIndexChanged += new System.EventHandler(this.cbxNaturalAccounts_SelectedIndexChanged);
            this.cbxNaturalAccounts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxNaturalAccounts_KeyPress);
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
            this.EmpEditCode.Location = new System.Drawing.Point(101, 51);
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
            this.EmpEditCode.TabIndex = 33;
            this.EmpEditCode.UseSelectable = true;
            this.EmpEditCode.WaterMark = "Type Here To Select Order Taker";
            this.EmpEditCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EmpEditCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.EmpEditCode.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.EmpEditCode_ButtonClick);
            this.EmpEditCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmpEditCode_KeyPress);
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.Location = new System.Drawing.Point(665, 24);
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
            this.txtContact.Location = new System.Drawing.Point(552, 25);
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
            this.SEditBox.Location = new System.Drawing.Point(101, 24);
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
            this.groupBox1.Controls.Add(this.txtInvoiceNo);
            this.groupBox1.Controls.Add(this.txtInwardGatePass);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.txtGatePass);
            this.groupBox1.Controls.Add(this.metroLabel12);
            this.groupBox1.Controls.Add(this.VDate);
            this.groupBox1.Controls.Add(this.lblDate);
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
            this.groupBox1.Size = new System.Drawing.Size(1015, 117);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice Information";
            // 
            // VEditedDateTime
            // 
            this.VEditedDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VEditedDateTime.Location = new System.Drawing.Point(884, 20);
            this.VEditedDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.VEditedDateTime.Name = "VEditedDateTime";
            this.VEditedDateTime.Size = new System.Drawing.Size(122, 29);
            this.VEditedDateTime.TabIndex = 32;
            this.VEditedDateTime.ValueChanged += new System.EventHandler(this.VEditedDateTime_ValueChanged);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(803, 25);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(77, 19);
            this.metroLabel14.TabIndex = 31;
            this.metroLabel14.Text = "Edited On :";
            this.metroLabel14.UseCustomBackColor = true;
            // 
            // txtInvoiceNo
            // 
            // 
            // 
            // 
            this.txtInvoiceNo.CustomButton.Image = null;
            this.txtInvoiceNo.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.txtInvoiceNo.CustomButton.Name = "";
            this.txtInvoiceNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInvoiceNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInvoiceNo.CustomButton.TabIndex = 1;
            this.txtInvoiceNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInvoiceNo.CustomButton.UseSelectable = true;
            this.txtInvoiceNo.CustomButton.Visible = false;
            this.txtInvoiceNo.Lines = new string[0];
            this.txtInvoiceNo.Location = new System.Drawing.Point(86, 50);
            this.txtInvoiceNo.MaxLength = 32767;
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.PasswordChar = '\0';
            this.txtInvoiceNo.PromptText = "Invoice No";
            this.txtInvoiceNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInvoiceNo.SelectedText = "";
            this.txtInvoiceNo.SelectionLength = 0;
            this.txtInvoiceNo.SelectionStart = 0;
            this.txtInvoiceNo.ShortcutsEnabled = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(145, 23);
            this.txtInvoiceNo.TabIndex = 29;
            this.txtInvoiceNo.UseSelectable = true;
            this.txtInvoiceNo.WaterMark = "Invoice No";
            this.txtInvoiceNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInvoiceNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtInwardGatePass
            // 
            // 
            // 
            // 
            this.txtInwardGatePass.CustomButton.Image = null;
            this.txtInwardGatePass.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.txtInwardGatePass.CustomButton.Name = "";
            this.txtInwardGatePass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInwardGatePass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInwardGatePass.CustomButton.TabIndex = 1;
            this.txtInwardGatePass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInwardGatePass.CustomButton.UseSelectable = true;
            this.txtInwardGatePass.CustomButton.Visible = false;
            this.txtInwardGatePass.Lines = new string[0];
            this.txtInwardGatePass.Location = new System.Drawing.Point(276, 48);
            this.txtInwardGatePass.MaxLength = 32767;
            this.txtInwardGatePass.Name = "txtInwardGatePass";
            this.txtInwardGatePass.PasswordChar = '\0';
            this.txtInwardGatePass.PromptText = "Inward Gate Pass";
            this.txtInwardGatePass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInwardGatePass.SelectedText = "";
            this.txtInwardGatePass.SelectionLength = 0;
            this.txtInwardGatePass.SelectionStart = 0;
            this.txtInwardGatePass.ShortcutsEnabled = true;
            this.txtInwardGatePass.Size = new System.Drawing.Size(143, 23);
            this.txtInwardGatePass.TabIndex = 26;
            this.txtInwardGatePass.UseSelectable = true;
            this.txtInwardGatePass.WaterMark = "Inward Gate Pass";
            this.txtInwardGatePass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInwardGatePass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(4, 50);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(81, 19);
            this.metroLabel4.TabIndex = 30;
            this.metroLabel4.Text = "Invoice No :";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(235, 51);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(38, 19);
            this.metroLabel8.TabIndex = 25;
            this.metroLabel8.Text = "IGP :";
            this.metroLabel8.UseCustomBackColor = true;
            // 
            // txtGatePass
            // 
            // 
            // 
            // 
            this.txtGatePass.CustomButton.Image = null;
            this.txtGatePass.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtGatePass.CustomButton.Name = "";
            this.txtGatePass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGatePass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGatePass.CustomButton.TabIndex = 1;
            this.txtGatePass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGatePass.CustomButton.UseSelectable = true;
            this.txtGatePass.CustomButton.Visible = false;
            this.txtGatePass.Lines = new string[0];
            this.txtGatePass.Location = new System.Drawing.Point(473, 49);
            this.txtGatePass.MaxLength = 32767;
            this.txtGatePass.Name = "txtGatePass";
            this.txtGatePass.PasswordChar = '\0';
            this.txtGatePass.PromptText = "OutWard Gate Pass";
            this.txtGatePass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGatePass.SelectedText = "";
            this.txtGatePass.SelectionLength = 0;
            this.txtGatePass.SelectionStart = 0;
            this.txtGatePass.ShortcutsEnabled = true;
            this.txtGatePass.Size = new System.Drawing.Size(163, 23);
            this.txtGatePass.TabIndex = 25;
            this.txtGatePass.UseSelectable = true;
            this.txtGatePass.WaterMark = "OutWard Gate Pass";
            this.txtGatePass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGatePass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(422, 51);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(45, 19);
            this.metroLabel12.TabIndex = 26;
            this.metroLabel12.Text = "OGP :";
            this.metroLabel12.UseCustomBackColor = true;
            // 
            // VDate
            // 
            this.VDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VDate.Location = new System.Drawing.Point(678, 21);
            this.VDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.VDate.Name = "VDate";
            this.VDate.Size = new System.Drawing.Size(116, 29);
            this.VDate.TabIndex = 22;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDate.Location = new System.Drawing.Point(628, 25);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 19);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "Date :";
            this.lblDate.UseCustomBackColor = true;
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
            this.txtSampleNo.Location = new System.Drawing.Point(482, 24);
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
            this.InvEditBox.CustomButton.Location = new System.Drawing.Point(123, 1);
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
            this.InvEditBox.PromptText = "Return No";
            this.InvEditBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InvEditBox.SelectedText = "";
            this.InvEditBox.SelectionLength = 0;
            this.InvEditBox.SelectionStart = 0;
            this.InvEditBox.ShortcutsEnabled = true;
            this.InvEditBox.ShowButton = true;
            this.InvEditBox.Size = new System.Drawing.Size(145, 23);
            this.InvEditBox.Style = MetroFramework.MetroColorStyle.Pink;
            this.InvEditBox.TabIndex = 16;
            this.InvEditBox.UseSelectable = true;
            this.InvEditBox.WaterMark = "Return No";
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
            this.lblInvoiceNo.Size = new System.Drawing.Size(79, 19);
            this.lblInvoiceNo.TabIndex = 17;
            this.lblInvoiceNo.Text = "Return No :";
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
            this.txtSheetNo.Location = new System.Drawing.Point(237, 25);
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
            this.lblDiscription.Location = new System.Drawing.Point(1, 81);
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
            this.chkPosted.Location = new System.Drawing.Point(908, 85);
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
            this.txtBiltyNo.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtBiltyNo.CustomButton.Name = "";
            this.txtBiltyNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBiltyNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBiltyNo.CustomButton.TabIndex = 1;
            this.txtBiltyNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBiltyNo.CustomButton.UseSelectable = true;
            this.txtBiltyNo.CustomButton.Visible = false;
            this.txtBiltyNo.Lines = new string[0];
            this.txtBiltyNo.Location = new System.Drawing.Point(354, 25);
            this.txtBiltyNo.MaxLength = 32767;
            this.txtBiltyNo.Name = "txtBiltyNo";
            this.txtBiltyNo.PasswordChar = '\0';
            this.txtBiltyNo.PromptText = "Bilty No Here";
            this.txtBiltyNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBiltyNo.SelectedText = "";
            this.txtBiltyNo.SelectionLength = 0;
            this.txtBiltyNo.SelectionStart = 0;
            this.txtBiltyNo.ShortcutsEnabled = true;
            this.txtBiltyNo.Size = new System.Drawing.Size(127, 23);
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
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(781, 1);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(85, 75);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(817, 37);
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
            this.flowMainPanel.Location = new System.Drawing.Point(14, 57);
            this.flowMainPanel.Name = "flowMainPanel";
            this.flowMainPanel.Size = new System.Drawing.Size(1032, 658);
            this.flowMainPanel.TabIndex = 10;
            // 
            // frmSalesReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1068, 749);
            this.Controls.Add(this.flowMainPanel);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSalesReturn";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Sales Return Invoice";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.frmSalesReturn_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSalesReturn_KeyPress);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
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
        private MetroFramework.Controls.MetroTextBox txtTotalAmount;
        private MetroFramework.Controls.MetroLabel lblTotal;
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
        private MetroFramework.Controls.MetroComboBox cbxCashAccounts;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroComboBox cbxNaturalAccounts;
        private MetroFramework.Controls.MetroLabel metroLabel1;
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
        private MetroFramework.Controls.MetroTextBox txtGatePass;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txtInwardGatePass;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtInvoiceNo;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cbxAdjustmentTypes;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblVoucherStatus;
        private MetroFramework.Controls.MetroTextBox txtCashClosingBalance;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtDeliveryPerson;
        private MetroFramework.Controls.MetroTextBox EmpEditCode;
        private MetroFramework.Controls.MetroTextBox txtBillAmount;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtFreightAmount;
        private MetroFramework.Controls.MetroLabel lblFreight;
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
        private MetroFramework.Controls.MetroDateTime VEditedDateTime;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox txtSystemWeight;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtManualWeight;
        private MetroFramework.Controls.MetroLabel metroLabel13;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private MetroFramework.Controls.MetroTextBox txt2kgWeight;
        private MetroFramework.Controls.MetroLabel metroLabel21;
    }
}