namespace Accounts.UI
{
    partial class frmUserActivityReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabUserActivity = new System.Windows.Forms.TabControl();
            this.tabAccounts = new System.Windows.Forms.TabPage();
            this.chkAllAccounts = new MetroFramework.Controls.MetroCheckBox();
            this.btnAccountsActivities = new MetroFramework.Controls.MetroTile();
            this.grdFindAccounts = new Accounts.UI.CustomDataGrid();
            this.colIdAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdParent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdHead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLinkAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabFinance = new System.Windows.Forms.TabPage();
            this.btnLoadFinancialActivities = new MetroFramework.Controls.MetroTile();
            this.chkJournalActivities = new MetroFramework.Controls.MetroCheckBox();
            this.chkBankReceiptActivities = new MetroFramework.Controls.MetroCheckBox();
            this.chkBankPaymentActivities = new MetroFramework.Controls.MetroCheckBox();
            this.chkReceiptActivities = new MetroFramework.Controls.MetroCheckBox();
            this.chkPaymentActivities = new MetroFramework.Controls.MetroCheckBox();
            this.grdFinancialActivities = new Accounts.UI.CustomDataGrid();
            this.colFinancialDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinancialVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinancialPosted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colFinancialAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabStock = new System.Windows.Forms.TabPage();
            this.btnLoadStockActivity = new MetroFramework.Controls.MetroTile();
            this.chkStockReturnAcitvities = new MetroFramework.Controls.MetroCheckBox();
            this.chkStockSaleActivites = new MetroFramework.Controls.MetroCheckBox();
            this.chkPurchasesReturnActivity = new MetroFramework.Controls.MetroCheckBox();
            this.chkPurchaseActivities = new MetroFramework.Controls.MetroCheckBox();
            this.grdStockActivities = new Accounts.UI.CustomDataGrid();
            this.colCreatedStockDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockPosted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colStockTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxUsers = new MetroFramework.Controls.MetroComboBox();
            this.lblUser = new MetroFramework.Controls.MetroLabel();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.dtActivity = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblTotalEnties = new MetroFramework.Controls.MetroLabel();
            this.lblTotalsum = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblCreditSum = new MetroFramework.Controls.MetroLabel();
            this.lblDebitSum = new MetroFramework.Controls.MetroLabel();
            this.tabUserActivity.SuspendLayout();
            this.tabAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFindAccounts)).BeginInit();
            this.tabFinance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFinancialActivities)).BeginInit();
            this.tabStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStockActivities)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(23, 56);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(826, 23);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------------------------------";
            // 
            // tabUserActivity
            // 
            this.tabUserActivity.Controls.Add(this.tabAccounts);
            this.tabUserActivity.Controls.Add(this.tabFinance);
            this.tabUserActivity.Controls.Add(this.tabStock);
            this.tabUserActivity.Location = new System.Drawing.Point(23, 139);
            this.tabUserActivity.Name = "tabUserActivity";
            this.tabUserActivity.SelectedIndex = 0;
            this.tabUserActivity.Size = new System.Drawing.Size(826, 372);
            this.tabUserActivity.TabIndex = 1;
            this.tabUserActivity.SelectedIndexChanged += new System.EventHandler(this.tabUserActivity_SelectedIndexChanged);
            // 
            // tabAccounts
            // 
            this.tabAccounts.Controls.Add(this.chkAllAccounts);
            this.tabAccounts.Controls.Add(this.btnAccountsActivities);
            this.tabAccounts.Controls.Add(this.grdFindAccounts);
            this.tabAccounts.Location = new System.Drawing.Point(4, 22);
            this.tabAccounts.Name = "tabAccounts";
            this.tabAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccounts.Size = new System.Drawing.Size(818, 346);
            this.tabAccounts.TabIndex = 0;
            this.tabAccounts.Text = "Accounts Activities";
            this.tabAccounts.UseVisualStyleBackColor = true;
            // 
            // chkAllAccounts
            // 
            this.chkAllAccounts.AutoSize = true;
            this.chkAllAccounts.Location = new System.Drawing.Point(657, 21);
            this.chkAllAccounts.Name = "chkAllAccounts";
            this.chkAllAccounts.Size = new System.Drawing.Size(108, 15);
            this.chkAllAccounts.TabIndex = 4;
            this.chkAllAccounts.Text = "Load All By User";
            this.chkAllAccounts.UseSelectable = true;
            this.chkAllAccounts.CheckedChanged += new System.EventHandler(this.chkAllAccounts_CheckedChanged);
            // 
            // btnAccountsActivities
            // 
            this.btnAccountsActivities.ActiveControl = null;
            this.btnAccountsActivities.Location = new System.Drawing.Point(656, 53);
            this.btnAccountsActivities.Name = "btnAccountsActivities";
            this.btnAccountsActivities.Size = new System.Drawing.Size(157, 47);
            this.btnAccountsActivities.TabIndex = 3;
            this.btnAccountsActivities.Text = "Load Activity";
            this.btnAccountsActivities.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAccountsActivities.UseSelectable = true;
            this.btnAccountsActivities.Click += new System.EventHandler(this.btnAccountsActivities_Click);
            // 
            // grdFindAccounts
            // 
            this.grdFindAccounts.AllowUserToAddRows = false;
            this.grdFindAccounts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdFindAccounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.grdFindAccounts.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFindAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.grdFindAccounts.ColumnHeadersHeight = 25;
            this.grdFindAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdAccount,
            this.colIdParent,
            this.colIdHead,
            this.colLinkAccount,
            this.colDate,
            this.colId,
            this.colName,
            this.colDescription,
            this.colAccountStatus});
            this.grdFindAccounts.EnableHeadersVisualStyles = false;
            this.grdFindAccounts.Location = new System.Drawing.Point(6, 6);
            this.grdFindAccounts.MultiSelect = false;
            this.grdFindAccounts.Name = "grdFindAccounts";
            this.grdFindAccounts.ReadOnly = true;
            this.grdFindAccounts.RowHeadersVisible = false;
            this.grdFindAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFindAccounts.Size = new System.Drawing.Size(646, 326);
            this.grdFindAccounts.TabIndex = 2;
            // 
            // colIdAccount
            // 
            this.colIdAccount.DataPropertyName = "IdAccount";
            this.colIdAccount.HeaderText = "IdAccount";
            this.colIdAccount.Name = "colIdAccount";
            this.colIdAccount.ReadOnly = true;
            this.colIdAccount.Visible = false;
            // 
            // colIdParent
            // 
            this.colIdParent.DataPropertyName = "IdParent";
            this.colIdParent.HeaderText = "IdParent";
            this.colIdParent.Name = "colIdParent";
            this.colIdParent.ReadOnly = true;
            this.colIdParent.Visible = false;
            // 
            // colIdHead
            // 
            this.colIdHead.DataPropertyName = "IdHead";
            this.colIdHead.HeaderText = "IdHead";
            this.colIdHead.Name = "colIdHead";
            this.colIdHead.ReadOnly = true;
            this.colIdHead.Visible = false;
            // 
            // colLinkAccount
            // 
            this.colLinkAccount.DataPropertyName = "LinkAccountNo";
            this.colLinkAccount.HeaderText = "LinkAccount";
            this.colLinkAccount.Name = "colLinkAccount";
            this.colLinkAccount.ReadOnly = true;
            this.colLinkAccount.Visible = false;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "CreatedDateTime";
            dataGridViewCellStyle12.Format = "d";
            this.colDate.DefaultCellStyle = dataGridViewCellStyle12;
            this.colDate.HeaderText = "Created Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 90;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "AccountNo";
            this.colId.HeaderText = "A/C Code";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "AccountName";
            this.colName.HeaderText = "A/C Title";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 230;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "AccountType";
            this.colDescription.HeaderText = "Head";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Width = 120;
            // 
            // colAccountStatus
            // 
            this.colAccountStatus.DataPropertyName = "IsActive";
            this.colAccountStatus.HeaderText = "Status";
            this.colAccountStatus.Name = "colAccountStatus";
            this.colAccountStatus.ReadOnly = true;
            // 
            // tabFinance
            // 
            this.tabFinance.Controls.Add(this.btnLoadFinancialActivities);
            this.tabFinance.Controls.Add(this.chkJournalActivities);
            this.tabFinance.Controls.Add(this.chkBankReceiptActivities);
            this.tabFinance.Controls.Add(this.chkBankPaymentActivities);
            this.tabFinance.Controls.Add(this.chkReceiptActivities);
            this.tabFinance.Controls.Add(this.chkPaymentActivities);
            this.tabFinance.Controls.Add(this.grdFinancialActivities);
            this.tabFinance.Location = new System.Drawing.Point(4, 22);
            this.tabFinance.Name = "tabFinance";
            this.tabFinance.Padding = new System.Windows.Forms.Padding(3);
            this.tabFinance.Size = new System.Drawing.Size(818, 346);
            this.tabFinance.TabIndex = 1;
            this.tabFinance.Text = "Financial Activities";
            this.tabFinance.UseVisualStyleBackColor = true;
            // 
            // btnLoadFinancialActivities
            // 
            this.btnLoadFinancialActivities.ActiveControl = null;
            this.btnLoadFinancialActivities.Location = new System.Drawing.Point(634, 204);
            this.btnLoadFinancialActivities.Name = "btnLoadFinancialActivities";
            this.btnLoadFinancialActivities.Size = new System.Drawing.Size(181, 47);
            this.btnLoadFinancialActivities.TabIndex = 5;
            this.btnLoadFinancialActivities.Text = "Load Activity";
            this.btnLoadFinancialActivities.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoadFinancialActivities.UseSelectable = true;
            this.btnLoadFinancialActivities.Click += new System.EventHandler(this.btnLoadFinancialActivities_Click);
            // 
            // chkJournalActivities
            // 
            this.chkJournalActivities.AutoSize = true;
            this.chkJournalActivities.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkJournalActivities.Location = new System.Drawing.Point(641, 173);
            this.chkJournalActivities.Name = "chkJournalActivities";
            this.chkJournalActivities.Size = new System.Drawing.Size(127, 19);
            this.chkJournalActivities.TabIndex = 4;
            this.chkJournalActivities.Text = "Journal Activities";
            this.chkJournalActivities.UseSelectable = true;
            this.chkJournalActivities.CheckedChanged += new System.EventHandler(this.chkJournalActivities_CheckedChanged);
            // 
            // chkBankReceiptActivities
            // 
            this.chkBankReceiptActivities.AutoSize = true;
            this.chkBankReceiptActivities.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkBankReceiptActivities.Location = new System.Drawing.Point(641, 131);
            this.chkBankReceiptActivities.Name = "chkBankReceiptActivities";
            this.chkBankReceiptActivities.Size = new System.Drawing.Size(161, 19);
            this.chkBankReceiptActivities.TabIndex = 4;
            this.chkBankReceiptActivities.Text = "Bank Receipt Activities";
            this.chkBankReceiptActivities.UseSelectable = true;
            this.chkBankReceiptActivities.CheckedChanged += new System.EventHandler(this.chkBankReceiptActivities_CheckedChanged);
            // 
            // chkBankPaymentActivities
            // 
            this.chkBankPaymentActivities.AutoSize = true;
            this.chkBankPaymentActivities.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkBankPaymentActivities.Location = new System.Drawing.Point(641, 91);
            this.chkBankPaymentActivities.Name = "chkBankPaymentActivities";
            this.chkBankPaymentActivities.Size = new System.Drawing.Size(171, 19);
            this.chkBankPaymentActivities.TabIndex = 4;
            this.chkBankPaymentActivities.Text = "Bank Payment Activities";
            this.chkBankPaymentActivities.UseSelectable = true;
            this.chkBankPaymentActivities.CheckedChanged += new System.EventHandler(this.chkBankPaymentActivities_CheckedChanged);
            // 
            // chkReceiptActivities
            // 
            this.chkReceiptActivities.AutoSize = true;
            this.chkReceiptActivities.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkReceiptActivities.Location = new System.Drawing.Point(641, 53);
            this.chkReceiptActivities.Name = "chkReceiptActivities";
            this.chkReceiptActivities.Size = new System.Drawing.Size(127, 19);
            this.chkReceiptActivities.TabIndex = 4;
            this.chkReceiptActivities.Text = "Receipt Activities";
            this.chkReceiptActivities.UseSelectable = true;
            this.chkReceiptActivities.CheckedChanged += new System.EventHandler(this.chkReceiptActivities_CheckedChanged);
            // 
            // chkPaymentActivities
            // 
            this.chkPaymentActivities.AutoSize = true;
            this.chkPaymentActivities.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkPaymentActivities.Location = new System.Drawing.Point(641, 15);
            this.chkPaymentActivities.Name = "chkPaymentActivities";
            this.chkPaymentActivities.Size = new System.Drawing.Size(137, 19);
            this.chkPaymentActivities.TabIndex = 4;
            this.chkPaymentActivities.Text = "Payment Activities";
            this.chkPaymentActivities.UseSelectable = true;
            this.chkPaymentActivities.CheckedChanged += new System.EventHandler(this.chkPaymentActivities_CheckedChanged);
            // 
            // grdFinancialActivities
            // 
            this.grdFinancialActivities.AllowUserToAddRows = false;
            this.grdFinancialActivities.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdFinancialActivities.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.grdFinancialActivities.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFinancialActivities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.grdFinancialActivities.ColumnHeadersHeight = 25;
            this.grdFinancialActivities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFinancialDate,
            this.colFinancialVoucherNo,
            this.colFinancialPosted,
            this.colFinancialAmount});
            this.grdFinancialActivities.EnableHeadersVisualStyles = false;
            this.grdFinancialActivities.Location = new System.Drawing.Point(6, 6);
            this.grdFinancialActivities.MultiSelect = false;
            this.grdFinancialActivities.Name = "grdFinancialActivities";
            this.grdFinancialActivities.ReadOnly = true;
            this.grdFinancialActivities.RowHeadersVisible = false;
            this.grdFinancialActivities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFinancialActivities.Size = new System.Drawing.Size(628, 326);
            this.grdFinancialActivities.TabIndex = 3;
            // 
            // colFinancialDate
            // 
            this.colFinancialDate.DataPropertyName = "CreatedDateTime";
            dataGridViewCellStyle15.Format = "d";
            this.colFinancialDate.DefaultCellStyle = dataGridViewCellStyle15;
            this.colFinancialDate.HeaderText = "Created Date";
            this.colFinancialDate.Name = "colFinancialDate";
            this.colFinancialDate.ReadOnly = true;
            this.colFinancialDate.Width = 150;
            // 
            // colFinancialVoucherNo
            // 
            this.colFinancialVoucherNo.DataPropertyName = "VoucherNo";
            this.colFinancialVoucherNo.HeaderText = "Voucher No";
            this.colFinancialVoucherNo.Name = "colFinancialVoucherNo";
            this.colFinancialVoucherNo.ReadOnly = true;
            this.colFinancialVoucherNo.Width = 150;
            // 
            // colFinancialPosted
            // 
            this.colFinancialPosted.DataPropertyName = "Posted";
            this.colFinancialPosted.HeaderText = "Posted";
            this.colFinancialPosted.Name = "colFinancialPosted";
            this.colFinancialPosted.ReadOnly = true;
            this.colFinancialPosted.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFinancialPosted.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colFinancialPosted.Width = 120;
            // 
            // colFinancialAmount
            // 
            this.colFinancialAmount.DataPropertyName = "TotalAmount";
            this.colFinancialAmount.HeaderText = "Total Amount";
            this.colFinancialAmount.Name = "colFinancialAmount";
            this.colFinancialAmount.ReadOnly = true;
            this.colFinancialAmount.Width = 200;
            // 
            // tabStock
            // 
            this.tabStock.Controls.Add(this.btnLoadStockActivity);
            this.tabStock.Controls.Add(this.chkStockReturnAcitvities);
            this.tabStock.Controls.Add(this.chkStockSaleActivites);
            this.tabStock.Controls.Add(this.chkPurchasesReturnActivity);
            this.tabStock.Controls.Add(this.chkPurchaseActivities);
            this.tabStock.Controls.Add(this.grdStockActivities);
            this.tabStock.Location = new System.Drawing.Point(4, 22);
            this.tabStock.Name = "tabStock";
            this.tabStock.Padding = new System.Windows.Forms.Padding(3);
            this.tabStock.Size = new System.Drawing.Size(818, 346);
            this.tabStock.TabIndex = 2;
            this.tabStock.Text = "Stock Activities";
            this.tabStock.UseVisualStyleBackColor = true;
            // 
            // btnLoadStockActivity
            // 
            this.btnLoadStockActivity.ActiveControl = null;
            this.btnLoadStockActivity.Location = new System.Drawing.Point(638, 165);
            this.btnLoadStockActivity.Name = "btnLoadStockActivity";
            this.btnLoadStockActivity.Size = new System.Drawing.Size(175, 47);
            this.btnLoadStockActivity.TabIndex = 7;
            this.btnLoadStockActivity.Text = "Load Activity";
            this.btnLoadStockActivity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoadStockActivity.UseSelectable = true;
            this.btnLoadStockActivity.Click += new System.EventHandler(this.btnLoadStockActivity_Click);
            // 
            // chkStockReturnAcitvities
            // 
            this.chkStockReturnAcitvities.AutoSize = true;
            this.chkStockReturnAcitvities.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkStockReturnAcitvities.Location = new System.Drawing.Point(640, 131);
            this.chkStockReturnAcitvities.Name = "chkStockReturnAcitvities";
            this.chkStockReturnAcitvities.Size = new System.Drawing.Size(137, 19);
            this.chkStockReturnAcitvities.TabIndex = 9;
            this.chkStockReturnAcitvities.Text = "Stock Sales Return";
            this.chkStockReturnAcitvities.UseSelectable = true;
            this.chkStockReturnAcitvities.CheckedChanged += new System.EventHandler(this.chkStockReturnAcitvities_CheckedChanged);
            // 
            // chkStockSaleActivites
            // 
            this.chkStockSaleActivites.AutoSize = true;
            this.chkStockSaleActivites.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkStockSaleActivites.Location = new System.Drawing.Point(640, 91);
            this.chkStockSaleActivites.Name = "chkStockSaleActivites";
            this.chkStockSaleActivites.Size = new System.Drawing.Size(92, 19);
            this.chkStockSaleActivites.TabIndex = 7;
            this.chkStockSaleActivites.Text = "Stock Sales";
            this.chkStockSaleActivites.UseSelectable = true;
            this.chkStockSaleActivites.CheckedChanged += new System.EventHandler(this.chkStockSaleActivites_CheckedChanged);
            // 
            // chkPurchasesReturnActivity
            // 
            this.chkPurchasesReturnActivity.AutoSize = true;
            this.chkPurchasesReturnActivity.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkPurchasesReturnActivity.Location = new System.Drawing.Point(640, 53);
            this.chkPurchasesReturnActivity.Name = "chkPurchasesReturnActivity";
            this.chkPurchasesReturnActivity.Size = new System.Drawing.Size(168, 19);
            this.chkPurchasesReturnActivity.TabIndex = 5;
            this.chkPurchasesReturnActivity.Text = "Stock Purchases Return";
            this.chkPurchasesReturnActivity.UseSelectable = true;
            this.chkPurchasesReturnActivity.CheckedChanged += new System.EventHandler(this.chkPurchasesReturnActivity_CheckedChanged);
            // 
            // chkPurchaseActivities
            // 
            this.chkPurchaseActivities.AutoSize = true;
            this.chkPurchaseActivities.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkPurchaseActivities.Location = new System.Drawing.Point(640, 15);
            this.chkPurchaseActivities.Name = "chkPurchaseActivities";
            this.chkPurchaseActivities.Size = new System.Drawing.Size(123, 19);
            this.chkPurchaseActivities.TabIndex = 6;
            this.chkPurchaseActivities.Text = "Stock Purchases";
            this.chkPurchaseActivities.UseSelectable = true;
            this.chkPurchaseActivities.CheckedChanged += new System.EventHandler(this.chkPurchaseActivities_CheckedChanged);
            // 
            // grdStockActivities
            // 
            this.grdStockActivities.AllowUserToAddRows = false;
            this.grdStockActivities.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdStockActivities.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.grdStockActivities.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdStockActivities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.grdStockActivities.ColumnHeadersHeight = 25;
            this.grdStockActivities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCreatedStockDate,
            this.colStockVoucherNo,
            this.colType,
            this.colStockPosted,
            this.colStockTotalAmount});
            this.grdStockActivities.EnableHeadersVisualStyles = false;
            this.grdStockActivities.Location = new System.Drawing.Point(6, 6);
            this.grdStockActivities.MultiSelect = false;
            this.grdStockActivities.Name = "grdStockActivities";
            this.grdStockActivities.ReadOnly = true;
            this.grdStockActivities.RowHeadersVisible = false;
            this.grdStockActivities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdStockActivities.Size = new System.Drawing.Size(628, 326);
            this.grdStockActivities.TabIndex = 4;
            // 
            // colCreatedStockDate
            // 
            this.colCreatedStockDate.DataPropertyName = "CreatedDateTime";
            dataGridViewCellStyle18.Format = "d";
            this.colCreatedStockDate.DefaultCellStyle = dataGridViewCellStyle18;
            this.colCreatedStockDate.HeaderText = "Created Date";
            this.colCreatedStockDate.Name = "colCreatedStockDate";
            this.colCreatedStockDate.ReadOnly = true;
            // 
            // colStockVoucherNo
            // 
            this.colStockVoucherNo.DataPropertyName = "VoucherNo";
            this.colStockVoucherNo.HeaderText = "Voucher No";
            this.colStockVoucherNo.Name = "colStockVoucherNo";
            this.colStockVoucherNo.ReadOnly = true;
            this.colStockVoucherNo.Width = 120;
            // 
            // colType
            // 
            this.colType.DataPropertyName = "SettlementType";
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Width = 180;
            // 
            // colStockPosted
            // 
            this.colStockPosted.DataPropertyName = "Posted";
            this.colStockPosted.HeaderText = "Posted";
            this.colStockPosted.Name = "colStockPosted";
            this.colStockPosted.ReadOnly = true;
            this.colStockPosted.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colStockPosted.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colStockPosted.Width = 80;
            // 
            // colStockTotalAmount
            // 
            this.colStockTotalAmount.DataPropertyName = "TotalAmount";
            this.colStockTotalAmount.HeaderText = "Total Amount";
            this.colStockTotalAmount.Name = "colStockTotalAmount";
            this.colStockTotalAmount.ReadOnly = true;
            this.colStockTotalAmount.Width = 130;
            // 
            // cbxUsers
            // 
            this.cbxUsers.FormattingEnabled = true;
            this.cbxUsers.ItemHeight = 23;
            this.cbxUsers.Location = new System.Drawing.Point(118, 82);
            this.cbxUsers.Name = "cbxUsers";
            this.cbxUsers.Size = new System.Drawing.Size(223, 29);
            this.cbxUsers.TabIndex = 2;
            this.cbxUsers.UseSelectable = true;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblUser.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblUser.Location = new System.Drawing.Point(30, 86);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(83, 19);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Select User :";
            this.lblUser.UseCustomBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDate.Location = new System.Drawing.Point(349, 86);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(133, 19);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Select Activity Date :";
            this.lblDate.UseCustomBackColor = true;
            // 
            // dtActivity
            // 
            this.dtActivity.Location = new System.Drawing.Point(492, 82);
            this.dtActivity.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtActivity.Name = "dtActivity";
            this.dtActivity.Size = new System.Drawing.Size(228, 29);
            this.dtActivity.TabIndex = 4;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(23, 113);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(826, 23);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------------------------------";
            // 
            // lblTotalEnties
            // 
            this.lblTotalEnties.AutoSize = true;
            this.lblTotalEnties.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTotalEnties.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTotalEnties.Location = new System.Drawing.Point(33, 517);
            this.lblTotalEnties.Name = "lblTotalEnties";
            this.lblTotalEnties.Size = new System.Drawing.Size(122, 25);
            this.lblTotalEnties.TabIndex = 5;
            this.lblTotalEnties.Text = "Total Entries : ";
            // 
            // lblTotalsum
            // 
            this.lblTotalsum.AutoSize = true;
            this.lblTotalsum.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTotalsum.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTotalsum.Location = new System.Drawing.Point(147, 519);
            this.lblTotalsum.Name = "lblTotalsum";
            this.lblTotalsum.Size = new System.Drawing.Size(0, 0);
            this.lblTotalsum.TabIndex = 6;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 71);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(826, 50);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblCreditSum
            // 
            this.lblCreditSum.AutoSize = true;
            this.lblCreditSum.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCreditSum.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCreditSum.Location = new System.Drawing.Point(349, 517);
            this.lblCreditSum.Name = "lblCreditSum";
            this.lblCreditSum.Size = new System.Drawing.Size(111, 25);
            this.lblCreditSum.TabIndex = 8;
            this.lblCreditSum.Text = "metroLabel2";
            // 
            // lblDebitSum
            // 
            this.lblDebitSum.AutoSize = true;
            this.lblDebitSum.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDebitSum.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDebitSum.Location = new System.Drawing.Point(626, 517);
            this.lblDebitSum.Name = "lblDebitSum";
            this.lblDebitSum.Size = new System.Drawing.Size(111, 25);
            this.lblDebitSum.TabIndex = 8;
            this.lblDebitSum.Text = "metroLabel2";
            // 
            // frmUserActivityReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 560);
            this.Controls.Add(this.lblDebitSum);
            this.Controls.Add(this.lblCreditSum);
            this.Controls.Add(this.lblTotalsum);
            this.Controls.Add(this.lblTotalEnties);
            this.Controls.Add(this.dtActivity);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.cbxUsers);
            this.Controls.Add(this.tabUserActivity);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmUserActivityReport";
            this.Text = "Users Activity Report";
            this.Load += new System.EventHandler(this.frmUserActivityReport_Load);
            this.tabUserActivity.ResumeLayout(false);
            this.tabAccounts.ResumeLayout(false);
            this.tabAccounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFindAccounts)).EndInit();
            this.tabFinance.ResumeLayout(false);
            this.tabFinance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFinancialActivities)).EndInit();
            this.tabStock.ResumeLayout(false);
            this.tabStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStockActivities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TabControl tabUserActivity;
        private System.Windows.Forms.TabPage tabAccounts;
        private System.Windows.Forms.TabPage tabFinance;
        private System.Windows.Forms.TabPage tabStock;
        private MetroFramework.Controls.MetroComboBox cbxUsers;
        private MetroFramework.Controls.MetroLabel lblUser;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroDateTime dtActivity;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroCheckBox chkAllAccounts;
        private MetroFramework.Controls.MetroTile btnAccountsActivities;
        private CustomDataGrid grdFindAccounts;
        private MetroFramework.Controls.MetroTile btnLoadFinancialActivities;
        private MetroFramework.Controls.MetroCheckBox chkJournalActivities;
        private MetroFramework.Controls.MetroCheckBox chkBankReceiptActivities;
        private MetroFramework.Controls.MetroCheckBox chkBankPaymentActivities;
        private MetroFramework.Controls.MetroCheckBox chkReceiptActivities;
        private MetroFramework.Controls.MetroCheckBox chkPaymentActivities;
        private CustomDataGrid grdFinancialActivities;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdParent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdHead;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLinkAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAccountStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinancialDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinancialVoucherNo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colFinancialPosted;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinancialAmount;
        private MetroFramework.Controls.MetroLabel lblTotalEnties;
        private MetroFramework.Controls.MetroLabel lblTotalsum;
        private CustomDataGrid grdStockActivities;
        private MetroFramework.Controls.MetroCheckBox chkStockReturnAcitvities;
        private MetroFramework.Controls.MetroCheckBox chkStockSaleActivites;
        private MetroFramework.Controls.MetroCheckBox chkPurchasesReturnActivity;
        private MetroFramework.Controls.MetroCheckBox chkPurchaseActivities;
        private MetroFramework.Controls.MetroTile btnLoadStockActivity;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedStockDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colStockPosted;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockTotalAmount;
        private MetroFramework.Controls.MetroLabel lblCreditSum;
        private MetroFramework.Controls.MetroLabel lblDebitSum;
    }
}