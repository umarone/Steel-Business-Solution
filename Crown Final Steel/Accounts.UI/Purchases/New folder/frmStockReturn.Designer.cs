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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatuMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.btnNext = new MetroFramework.Controls.MetroTile();
            this.btnNew = new MetroFramework.Controls.MetroTile();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnPrevious = new MetroFramework.Controls.MetroTile();
            this.btnClose = new MetroFramework.Controls.MetroTile();
            this.tabPurchaseTransactions = new System.Windows.Forms.TabControl();
            this.tabLineItems = new System.Windows.Forms.TabPage();
            this.DgvStockReceipt = new Accounts.UI.TabDataGrid();
            this.ColIdVoucherDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtTotalAmount = new MetroFramework.Controls.MetroTextBox();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.tabSalesTransactions = new System.Windows.Forms.TabPage();
            this.DgvPurchases = new Accounts.UI.TabDataGrid();
            this.ColIdDetailVoucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpCreditor = new System.Windows.Forms.GroupBox();
            this.btnAddSupplier = new MetroFramework.Controls.MetroButton();
            this.txtCurrentBalance = new MetroFramework.Controls.MetroTextBox();
            this.btnViewDetail = new MetroFramework.Controls.MetroButton();
            this.txtContact = new MetroFramework.Controls.MetroTextBox();
            this.SEditBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VDate = new MetroFramework.Controls.MetroDateTime();
            this.VEditBox = new MetroFramework.Controls.MetroTextBox();
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
            this.grpSupplier = new System.Windows.Forms.GroupBox();
            this.txtSupplierAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtSupplerCNIC = new MetroFramework.Controls.MetroTextBox();
            this.txtSupplierContact = new MetroFramework.Controls.MetroTextBox();
            this.txtSupplierName = new MetroFramework.Controls.MetroTextBox();
            this.lblSupplierName = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblVouchersCount = new MetroFramework.Controls.MetroLabel();
            this.lblTotalVouchers = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lblLastVoucherNo = new MetroFramework.Controls.MetroLabel();
            this.statusStrip1.SuspendLayout();
            this.pnlButtons.SuspendLayout();
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
            this.grpSupplier.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatuMessage});
            this.statusStrip1.Location = new System.Drawing.Point(20, 650);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1016, 22);
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
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnPrevious);
            this.pnlButtons.Controls.Add(this.btnClose);
            this.pnlButtons.Location = new System.Drawing.Point(3, 575);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1025, 48);
            this.pnlButtons.TabIndex = 25;
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSave.Location = new System.Drawing.Point(613, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 40);
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
            this.btnNext.Location = new System.Drawing.Point(511, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(101, 40);
            this.btnNext.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNext.UseCustomBackColor = true;
            this.btnNext.UseSelectable = true;
            this.btnNext.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.ActiveControl = null;
            this.btnNew.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNew.Location = new System.Drawing.Point(920, 3);
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
            this.btnDelete.Location = new System.Drawing.Point(716, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 40);
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
            this.btnPrevious.Location = new System.Drawing.Point(409, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(101, 40);
            this.btnPrevious.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnPrevious.TabIndex = 14;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrevious.UseCustomBackColor = true;
            this.btnPrevious.UseSelectable = true;
            this.btnPrevious.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.ActiveControl = null;
            this.btnClose.BackColor = System.Drawing.Color.RosyBrown;
            this.btnClose.Location = new System.Drawing.Point(818, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 40);
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
            this.tabPurchaseTransactions.Location = new System.Drawing.Point(3, 307);
            this.tabPurchaseTransactions.Name = "tabPurchaseTransactions";
            this.tabPurchaseTransactions.SelectedIndex = 0;
            this.tabPurchaseTransactions.Size = new System.Drawing.Size(1026, 262);
            this.tabPurchaseTransactions.TabIndex = 24;
            this.tabPurchaseTransactions.SelectedIndexChanged += new System.EventHandler(this.tabPurchaseTransactions_SelectedIndexChanged);
            // 
            // tabLineItems
            // 
            this.tabLineItems.Controls.Add(this.DgvStockReceipt);
            this.tabLineItems.Controls.Add(this.txtTotalAmount);
            this.tabLineItems.Controls.Add(this.lblTotal);
            this.tabLineItems.Location = new System.Drawing.Point(4, 25);
            this.tabLineItems.Name = "tabLineItems";
            this.tabLineItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabLineItems.Size = new System.Drawing.Size(1018, 233);
            this.tabLineItems.TabIndex = 0;
            this.tabLineItems.Text = "Line Items";
            this.tabLineItems.UseVisualStyleBackColor = true;
            // 
            // DgvStockReceipt
            // 
            this.DgvStockReceipt.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvStockReceipt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvStockReceipt.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvStockReceipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvStockReceipt.ColumnHeadersHeight = 25;
            this.DgvStockReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdVoucherDetail,
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
            this.colUnitPrice,
            this.colAmount,
            this.colDelete});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvStockReceipt.DefaultCellStyle = dataGridViewCellStyle11;
            this.DgvStockReceipt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvStockReceipt.EnableHeadersVisualStyles = false;
            this.DgvStockReceipt.Location = new System.Drawing.Point(6, 8);
            this.DgvStockReceipt.MultiSelect = false;
            this.DgvStockReceipt.Name = "DgvStockReceipt";
            this.DgvStockReceipt.RowHeadersVisible = false;
            this.DgvStockReceipt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvStockReceipt.Size = new System.Drawing.Size(1015, 193);
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
            this.colFirstIMEI.HeaderText = "First IMEI";
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Red;
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle10;
            this.colDelete.HeaderText = "...";
            this.colDelete.Name = "colDelete";
            this.colDelete.Width = 80;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.White;
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
            this.txtTotalAmount.Location = new System.Drawing.Point(862, 204);
            this.txtTotalAmount.MaxLength = 32767;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.PasswordChar = '\0';
            this.txtTotalAmount.PromptText = "Total Amount";
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
            this.lblTotal.Location = new System.Drawing.Point(757, 205);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 19);
            this.lblTotal.TabIndex = 24;
            this.lblTotal.Text = "Total Amount :";
            // 
            // tabSalesTransactions
            // 
            this.tabSalesTransactions.Controls.Add(this.DgvPurchases);
            this.tabSalesTransactions.Location = new System.Drawing.Point(4, 25);
            this.tabSalesTransactions.Name = "tabSalesTransactions";
            this.tabSalesTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalesTransactions.Size = new System.Drawing.Size(1018, 233);
            this.tabSalesTransactions.TabIndex = 1;
            this.tabSalesTransactions.Text = "Transactions";
            this.tabSalesTransactions.UseVisualStyleBackColor = true;
            // 
            // DgvPurchases
            // 
            this.DgvPurchases.AllowUserToDeleteRows = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvPurchases.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DgvPurchases.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPurchases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.DgvPurchases.ColumnHeadersHeight = 25;
            this.DgvPurchases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdDetailVoucher,
            this.colIdAccount,
            this.colAccountNo,
            this.colAccountName,
            this.colDescription,
            this.colDebit,
            this.colCredit});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPurchases.DefaultCellStyle = dataGridViewCellStyle14;
            this.DgvPurchases.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvPurchases.EnableHeadersVisualStyles = false;
            this.DgvPurchases.Location = new System.Drawing.Point(4, 6);
            this.DgvPurchases.MultiSelect = false;
            this.DgvPurchases.Name = "DgvPurchases";
            this.DgvPurchases.RowHeadersVisible = false;
            this.DgvPurchases.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvPurchases.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvPurchases.Size = new System.Drawing.Size(1008, 221);
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
            this.colAccountName.Width = 270;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Narration";
            this.colDescription.Name = "colDescription";
            this.colDescription.Width = 490;
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
            this.grpCreditor.Controls.Add(this.btnAddSupplier);
            this.grpCreditor.Controls.Add(this.txtCurrentBalance);
            this.grpCreditor.Controls.Add(this.btnViewDetail);
            this.grpCreditor.Controls.Add(this.txtContact);
            this.grpCreditor.Controls.Add(this.SEditBox);
            this.grpCreditor.Controls.Add(this.metroLabel2);
            this.grpCreditor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCreditor.Location = new System.Drawing.Point(3, 107);
            this.grpCreditor.Name = "grpCreditor";
            this.grpCreditor.Size = new System.Drawing.Size(1014, 57);
            this.grpCreditor.TabIndex = 22;
            this.grpCreditor.TabStop = false;
            this.grpCreditor.Text = "Creditor Information";
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(740, 20);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(127, 23);
            this.btnAddSupplier.TabIndex = 26;
            this.btnAddSupplier.Text = "Add Supplier Account";
            this.btnAddSupplier.UseSelectable = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
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
            this.txtCurrentBalance.Location = new System.Drawing.Point(445, 20);
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
            this.btnViewDetail.Location = new System.Drawing.Point(662, 20);
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
            this.txtContact.Location = new System.Drawing.Point(549, 20);
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
            this.SEditBox.CustomButton.Location = new System.Drawing.Point(332, 1);
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
            this.SEditBox.Size = new System.Drawing.Size(354, 23);
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
            // grpSales
            // 
            this.grpSales.BackColor = System.Drawing.Color.MistyRose;
            this.grpSales.Controls.Add(this.flowPurchasesPanel);
            this.grpSales.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSales.Location = new System.Drawing.Point(3, 236);
            this.grpSales.Name = "grpSales";
            this.grpSales.Size = new System.Drawing.Size(1015, 65);
            this.grpSales.TabIndex = 23;
            this.grpSales.TabStop = false;
            this.grpSales.Text = "Purchases Information";
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
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Debit A/C :";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // btnAddPurchasesAccount
            // 
            this.btnAddPurchasesAccount.Location = new System.Drawing.Point(311, 5);
            this.btnAddPurchasesAccount.Name = "btnAddPurchasesAccount";
            this.btnAddPurchasesAccount.Size = new System.Drawing.Size(146, 29);
            this.btnAddPurchasesAccount.TabIndex = 17;
            this.btnAddPurchasesAccount.Text = "Add Inventory Account";
            this.btnAddPurchasesAccount.UseSelectable = true;
            this.btnAddPurchasesAccount.Click += new System.EventHandler(this.btnAddPurchasesAccount_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.VDate);
            this.groupBox1.Controls.Add(this.VEditBox);
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
            this.groupBox1.Size = new System.Drawing.Size(1015, 98);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill Information";
            // 
            // VDate
            // 
            this.VDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VDate.Location = new System.Drawing.Point(334, 22);
            this.VDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.VDate.Name = "VDate";
            this.VDate.Size = new System.Drawing.Size(155, 29);
            this.VDate.TabIndex = 22;
            // 
            // VEditBox
            // 
            // 
            // 
            // 
            this.VEditBox.CustomButton.Image = null;
            this.VEditBox.CustomButton.Location = new System.Drawing.Point(174, 1);
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
            this.VEditBox.PromptText = "Sheet No";
            this.VEditBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.VEditBox.SelectedText = "";
            this.VEditBox.SelectionLength = 0;
            this.VEditBox.SelectionStart = 0;
            this.VEditBox.ShortcutsEnabled = true;
            this.VEditBox.ShowButton = true;
            this.VEditBox.Size = new System.Drawing.Size(196, 23);
            this.VEditBox.Style = MetroFramework.MetroColorStyle.Pink;
            this.VEditBox.TabIndex = 21;
            this.VEditBox.UseSelectable = true;
            this.VEditBox.WaterMark = "Sheet No";
            this.VEditBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.VEditBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.VEditBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.VEditBox_ButtonClick);
            this.VEditBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VEditBox_KeyPress);
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
            this.metroLabel4.Location = new System.Drawing.Point(494, 26);
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
            this.lblBillNo.Location = new System.Drawing.Point(695, 28);
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
            this.lblVoucherNo.Location = new System.Drawing.Point(11, 24);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(72, 19);
            this.lblVoucherNo.TabIndex = 19;
            this.lblVoucherNo.Text = "Sheet No :";
            this.lblVoucherNo.UseCustomBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDate.Location = new System.Drawing.Point(283, 25);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 19);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "Date :";
            this.lblDate.UseCustomBackColor = true;
            // 
            // chkPosted
            // 
            this.chkPosted.AutoSize = true;
            this.chkPosted.BackColor = System.Drawing.Color.Transparent;
            this.chkPosted.Location = new System.Drawing.Point(890, 30);
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
            this.txtBiltyNo.Location = new System.Drawing.Point(563, 26);
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
            this.txtBiltyNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillNo_KeyPress);
            // 
            // txtBillNo
            // 
            // 
            // 
            // 
            this.txtBillNo.CustomButton.Image = null;
            this.txtBillNo.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtBillNo.CustomButton.Name = "";
            this.txtBillNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBillNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBillNo.CustomButton.TabIndex = 1;
            this.txtBillNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBillNo.CustomButton.UseSelectable = true;
            this.txtBillNo.CustomButton.Visible = false;
            this.txtBillNo.Lines = new string[0];
            this.txtBillNo.Location = new System.Drawing.Point(759, 26);
            this.txtBillNo.MaxLength = 32767;
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.PasswordChar = '\0';
            this.txtBillNo.PromptText = "Bill No";
            this.txtBillNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBillNo.SelectedText = "";
            this.txtBillNo.SelectionLength = 0;
            this.txtBillNo.SelectionStart = 0;
            this.txtBillNo.ShortcutsEnabled = true;
            this.txtBillNo.Size = new System.Drawing.Size(127, 23);
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
            this.txtDescription.Location = new System.Drawing.Point(82, 55);
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
            this.flowMainPanel.Controls.Add(this.grpSupplier);
            this.flowMainPanel.Controls.Add(this.grpSales);
            this.flowMainPanel.Controls.Add(this.tabPurchaseTransactions);
            this.flowMainPanel.Controls.Add(this.pnlButtons);
            this.flowMainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowMainPanel.Location = new System.Drawing.Point(14, 57);
            this.flowMainPanel.Name = "flowMainPanel";
            this.flowMainPanel.Size = new System.Drawing.Size(1032, 626);
            this.flowMainPanel.TabIndex = 10;
            // 
            // grpSupplier
            // 
            this.grpSupplier.BackColor = System.Drawing.Color.MistyRose;
            this.grpSupplier.Controls.Add(this.txtSupplierAddress);
            this.grpSupplier.Controls.Add(this.txtSupplerCNIC);
            this.grpSupplier.Controls.Add(this.txtSupplierContact);
            this.grpSupplier.Controls.Add(this.txtSupplierName);
            this.grpSupplier.Controls.Add(this.lblSupplierName);
            this.grpSupplier.Location = new System.Drawing.Point(3, 170);
            this.grpSupplier.Name = "grpSupplier";
            this.grpSupplier.Size = new System.Drawing.Size(1014, 60);
            this.grpSupplier.TabIndex = 26;
            this.grpSupplier.TabStop = false;
            this.grpSupplier.Text = "Supplier Information";
            // 
            // txtSupplierAddress
            // 
            // 
            // 
            // 
            this.txtSupplierAddress.CustomButton.Image = null;
            this.txtSupplierAddress.CustomButton.Location = new System.Drawing.Point(474, 1);
            this.txtSupplierAddress.CustomButton.Name = "";
            this.txtSupplierAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSupplierAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupplierAddress.CustomButton.TabIndex = 1;
            this.txtSupplierAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupplierAddress.CustomButton.UseSelectable = true;
            this.txtSupplierAddress.CustomButton.Visible = false;
            this.txtSupplierAddress.Lines = new string[0];
            this.txtSupplierAddress.Location = new System.Drawing.Point(499, 28);
            this.txtSupplierAddress.MaxLength = 32767;
            this.txtSupplierAddress.Multiline = true;
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.PasswordChar = '\0';
            this.txtSupplierAddress.PromptText = "Address";
            this.txtSupplierAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupplierAddress.SelectedText = "";
            this.txtSupplierAddress.SelectionLength = 0;
            this.txtSupplierAddress.SelectionStart = 0;
            this.txtSupplierAddress.ShortcutsEnabled = true;
            this.txtSupplierAddress.Size = new System.Drawing.Size(496, 23);
            this.txtSupplierAddress.TabIndex = 1;
            this.txtSupplierAddress.UseSelectable = true;
            this.txtSupplierAddress.WaterMark = "Address";
            this.txtSupplierAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSupplierAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSupplerCNIC
            // 
            // 
            // 
            // 
            this.txtSupplerCNIC.CustomButton.Image = null;
            this.txtSupplerCNIC.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtSupplerCNIC.CustomButton.Name = "";
            this.txtSupplerCNIC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSupplerCNIC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupplerCNIC.CustomButton.TabIndex = 1;
            this.txtSupplerCNIC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupplerCNIC.CustomButton.UseSelectable = true;
            this.txtSupplerCNIC.CustomButton.Visible = false;
            this.txtSupplerCNIC.Lines = new string[0];
            this.txtSupplerCNIC.Location = new System.Drawing.Point(394, 28);
            this.txtSupplerCNIC.MaxLength = 32767;
            this.txtSupplerCNIC.Name = "txtSupplerCNIC";
            this.txtSupplerCNIC.PasswordChar = '\0';
            this.txtSupplerCNIC.PromptText = "CNIC";
            this.txtSupplerCNIC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupplerCNIC.SelectedText = "";
            this.txtSupplerCNIC.SelectionLength = 0;
            this.txtSupplerCNIC.SelectionStart = 0;
            this.txtSupplerCNIC.ShortcutsEnabled = true;
            this.txtSupplerCNIC.Size = new System.Drawing.Size(104, 23);
            this.txtSupplerCNIC.TabIndex = 1;
            this.txtSupplerCNIC.UseSelectable = true;
            this.txtSupplerCNIC.WaterMark = "CNIC";
            this.txtSupplerCNIC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSupplerCNIC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSupplierContact
            // 
            // 
            // 
            // 
            this.txtSupplierContact.CustomButton.Image = null;
            this.txtSupplierContact.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtSupplierContact.CustomButton.Name = "";
            this.txtSupplierContact.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSupplierContact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupplierContact.CustomButton.TabIndex = 1;
            this.txtSupplierContact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupplierContact.CustomButton.UseSelectable = true;
            this.txtSupplierContact.CustomButton.Visible = false;
            this.txtSupplierContact.Lines = new string[0];
            this.txtSupplierContact.Location = new System.Drawing.Point(290, 28);
            this.txtSupplierContact.MaxLength = 32767;
            this.txtSupplierContact.Name = "txtSupplierContact";
            this.txtSupplierContact.PasswordChar = '\0';
            this.txtSupplierContact.PromptText = "Contact";
            this.txtSupplierContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupplierContact.SelectedText = "";
            this.txtSupplierContact.SelectionLength = 0;
            this.txtSupplierContact.SelectionStart = 0;
            this.txtSupplierContact.ShortcutsEnabled = true;
            this.txtSupplierContact.Size = new System.Drawing.Size(104, 23);
            this.txtSupplierContact.TabIndex = 1;
            this.txtSupplierContact.UseSelectable = true;
            this.txtSupplierContact.WaterMark = "Contact";
            this.txtSupplierContact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSupplierContact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSupplierName
            // 
            // 
            // 
            // 
            this.txtSupplierName.CustomButton.Image = null;
            this.txtSupplierName.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtSupplierName.CustomButton.Name = "";
            this.txtSupplierName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSupplierName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupplierName.CustomButton.TabIndex = 1;
            this.txtSupplierName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupplierName.CustomButton.UseSelectable = true;
            this.txtSupplierName.CustomButton.Visible = false;
            this.txtSupplierName.Lines = new string[0];
            this.txtSupplierName.Location = new System.Drawing.Point(89, 28);
            this.txtSupplierName.MaxLength = 32767;
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.PasswordChar = '\0';
            this.txtSupplierName.PromptText = "Supplier Name";
            this.txtSupplierName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupplierName.SelectedText = "";
            this.txtSupplierName.SelectionLength = 0;
            this.txtSupplierName.SelectionStart = 0;
            this.txtSupplierName.ShortcutsEnabled = true;
            this.txtSupplierName.Size = new System.Drawing.Size(200, 23);
            this.txtSupplierName.TabIndex = 1;
            this.txtSupplierName.UseSelectable = true;
            this.txtSupplierName.WaterMark = "Supplier Name";
            this.txtSupplierName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSupplierName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.BackColor = System.Drawing.Color.Transparent;
            this.lblSupplierName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblSupplierName.Location = new System.Drawing.Point(8, 28);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(82, 19);
            this.lblSupplierName.TabIndex = 0;
            this.lblSupplierName.Text = "First Name :";
            this.lblSupplierName.UseCustomBackColor = true;
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
            this.metroPanel1.Size = new System.Drawing.Size(295, 36);
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
            this.lblVouchersCount.Size = new System.Drawing.Size(107, 19);
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
            this.metroLabel7.Location = new System.Drawing.Point(136, 4);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(118, 19);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Last Voucher No :";
            // 
            // lblLastVoucherNo
            // 
            this.lblLastVoucherNo.AutoSize = true;
            this.lblLastVoucherNo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblLastVoucherNo.Location = new System.Drawing.Point(265, 4);
            this.lblLastVoucherNo.Name = "lblLastVoucherNo";
            this.lblLastVoucherNo.Size = new System.Drawing.Size(17, 19);
            this.lblLastVoucherNo.TabIndex = 2;
            this.lblLastVoucherNo.Text = "0";
            // 
            // frmStockReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1056, 692);
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
            this.grpSupplier.ResumeLayout(false);
            this.grpSupplier.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
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
        private MetroFramework.Controls.MetroTextBox txtTotalAmount;
        private MetroFramework.Controls.MetroLabel lblTotal;
        private System.Windows.Forms.TabPage tabSalesTransactions;
        private TabDataGrid DgvPurchases;
        private System.Windows.Forms.GroupBox grpCreditor;
        private MetroFramework.Controls.MetroButton btnAddSupplier;
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
        private MetroFramework.Controls.MetroTextBox VEditBox;
        private MetroFramework.Controls.MetroLabel lblDiscription;
        private MetroFramework.Controls.MetroLabel lblBillNo;
        private MetroFramework.Controls.MetroLabel lblVoucherNo;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroCheckBox chkPosted;
        private MetroFramework.Controls.MetroTextBox txtBillNo;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private System.Windows.Forms.FlowLayoutPanel flowMainPanel;
        private System.Windows.Forms.GroupBox grpSupplier;
        private MetroFramework.Controls.MetroTextBox txtSupplierAddress;
        private MetroFramework.Controls.MetroTextBox txtSupplerCNIC;
        private MetroFramework.Controls.MetroTextBox txtSupplierContact;
        private MetroFramework.Controls.MetroTextBox txtSupplierName;
        private MetroFramework.Controls.MetroLabel lblSupplierName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtBiltyNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdVoucherDetail;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdDetailVoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCredit;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblVouchersCount;
        private MetroFramework.Controls.MetroLabel lblTotalVouchers;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lblLastVoucherNo;
    }
}