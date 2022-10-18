namespace Accounts.UI
{
    partial class frmDayBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtStart = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dtEnd = new MetroFramework.Controls.MetroDateTime();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.grdDetailedDailyBook = new System.Windows.Forms.DataGridView();
            this.colPosted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.grdSummaryDailyBook = new System.Windows.Forms.DataGridView();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.chkPurchases = new MetroFramework.Controls.MetroCheckBox();
            this.chkSales = new MetroFramework.Controls.MetroCheckBox();
            this.chkPayments = new MetroFramework.Controls.MetroCheckBox();
            this.chkReceipts = new MetroFramework.Controls.MetroCheckBox();
            this.chkNetSummary = new MetroFramework.Controls.MetroCheckBox();
            this.chkCreditSummary = new MetroFramework.Controls.MetroCheckBox();
            this.chkCompositeSummary = new MetroFramework.Controls.MetroCheckBox();
            this.chkComposite = new MetroFramework.Controls.MetroCheckBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetailedDailyBook)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSummaryDailyBook)).BeginInit();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 50);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(957, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------------------------------------------";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 72);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "From Date :";
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(103, 69);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(202, 29);
            this.dtStart.TabIndex = 2;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(310, 72);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "To Date :";
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(374, 69);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(218, 29);
            this.dtEnd.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(599, 69);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 29);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load Day Book";
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // grdDetailedDailyBook
            // 
            this.grdDetailedDailyBook.AllowUserToAddRows = false;
            this.grdDetailedDailyBook.AllowUserToDeleteRows = false;
            this.grdDetailedDailyBook.AllowUserToResizeColumns = false;
            this.grdDetailedDailyBook.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            this.grdDetailedDailyBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDetailedDailyBook.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDetailedDailyBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdDetailedDailyBook.ColumnHeadersHeight = 28;
            this.grdDetailedDailyBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColVoucherNo,
            this.colDate,
            this.colDescription,
            this.colTotalAmount,
            this.colPosted});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDetailedDailyBook.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdDetailedDailyBook.EnableHeadersVisualStyles = false;
            this.grdDetailedDailyBook.Location = new System.Drawing.Point(23, 138);
            this.grdDetailedDailyBook.MultiSelect = false;
            this.grdDetailedDailyBook.Name = "grdDetailedDailyBook";
            this.grdDetailedDailyBook.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDetailedDailyBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdDetailedDailyBook.RowHeadersVisible = false;
            this.grdDetailedDailyBook.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdDetailedDailyBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdDetailedDailyBook.Size = new System.Drawing.Size(676, 399);
            this.grdDetailedDailyBook.TabIndex = 4;
            // 
            // colPosted
            // 
            this.colPosted.DataPropertyName = "Posted";
            this.colPosted.HeaderText = "Posted";
            this.colPosted.Name = "colPosted";
            this.colPosted.ReadOnly = true;
            this.colPosted.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPosted.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.chkPurchases);
            this.metroPanel1.Controls.Add(this.chkSales);
            this.metroPanel1.Controls.Add(this.chkPayments);
            this.metroPanel1.Controls.Add(this.chkReceipts);
            this.metroPanel1.Controls.Add(this.chkComposite);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(24, 101);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(675, 33);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // grdSummaryDailyBook
            // 
            this.grdSummaryDailyBook.AllowUserToAddRows = false;
            this.grdSummaryDailyBook.AllowUserToDeleteRows = false;
            this.grdSummaryDailyBook.AllowUserToResizeColumns = false;
            this.grdSummaryDailyBook.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Beige;
            this.grdSummaryDailyBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grdSummaryDailyBook.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSummaryDailyBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdSummaryDailyBook.ColumnHeadersHeight = 28;
            this.grdSummaryDailyBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdSummaryDailyBook.DefaultCellStyle = dataGridViewCellStyle10;
            this.grdSummaryDailyBook.EnableHeadersVisualStyles = false;
            this.grdSummaryDailyBook.Location = new System.Drawing.Point(0, 50);
            this.grdSummaryDailyBook.MultiSelect = false;
            this.grdSummaryDailyBook.Name = "grdSummaryDailyBook";
            this.grdSummaryDailyBook.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSummaryDailyBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.grdSummaryDailyBook.RowHeadersVisible = false;
            this.grdSummaryDailyBook.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdSummaryDailyBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdSummaryDailyBook.Size = new System.Drawing.Size(306, 462);
            this.grdSummaryDailyBook.TabIndex = 4;
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.grdSummaryDailyBook);
            this.grpSummary.Controls.Add(this.chkCompositeSummary);
            this.grpSummary.Controls.Add(this.chkCreditSummary);
            this.grpSummary.Controls.Add(this.chkNetSummary);
            this.grpSummary.Location = new System.Drawing.Point(705, 72);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(306, 465);
            this.grpSummary.TabIndex = 6;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Day Book Summary";
            // 
            // chkPurchases
            // 
            this.chkPurchases.AutoSize = true;
            this.chkPurchases.Location = new System.Drawing.Point(14, 8);
            this.chkPurchases.Name = "chkPurchases";
            this.chkPurchases.Size = new System.Drawing.Size(105, 15);
            this.chkPurchases.TabIndex = 2;
            this.chkPurchases.Text = "Filter Purchases";
            this.chkPurchases.UseSelectable = true;
            this.chkPurchases.CheckedChanged += new System.EventHandler(this.chkPurchases_CheckedChanged);
            // 
            // chkSales
            // 
            this.chkSales.AutoSize = true;
            this.chkSales.Location = new System.Drawing.Point(167, 8);
            this.chkSales.Name = "chkSales";
            this.chkSales.Size = new System.Drawing.Size(78, 15);
            this.chkSales.TabIndex = 2;
            this.chkSales.Text = "Filter Sales";
            this.chkSales.UseSelectable = true;
            this.chkSales.CheckedChanged += new System.EventHandler(this.chkSales_CheckedChanged);
            // 
            // chkPayments
            // 
            this.chkPayments.AutoSize = true;
            this.chkPayments.Location = new System.Drawing.Point(291, 8);
            this.chkPayments.Name = "chkPayments";
            this.chkPayments.Size = new System.Drawing.Size(104, 15);
            this.chkPayments.TabIndex = 2;
            this.chkPayments.Text = "Filter Payments";
            this.chkPayments.UseSelectable = true;
            this.chkPayments.CheckedChanged += new System.EventHandler(this.chkPayments_CheckedChanged);
            // 
            // chkReceipts
            // 
            this.chkReceipts.AutoSize = true;
            this.chkReceipts.Location = new System.Drawing.Point(427, 8);
            this.chkReceipts.Name = "chkReceipts";
            this.chkReceipts.Size = new System.Drawing.Size(94, 15);
            this.chkReceipts.TabIndex = 2;
            this.chkReceipts.Text = "filter Receipts";
            this.chkReceipts.UseSelectable = true;
            this.chkReceipts.CheckedChanged += new System.EventHandler(this.chkReceipts_CheckedChanged);
            // 
            // chkNetSummary
            // 
            this.chkNetSummary.AutoSize = true;
            this.chkNetSummary.Location = new System.Drawing.Point(6, 29);
            this.chkNetSummary.Name = "chkNetSummary";
            this.chkNetSummary.Size = new System.Drawing.Size(96, 15);
            this.chkNetSummary.TabIndex = 2;
            this.chkNetSummary.Text = "Net Summary";
            this.chkNetSummary.UseSelectable = true;
            this.chkNetSummary.CheckedChanged += new System.EventHandler(this.chkNetSummary_CheckedChanged);
            // 
            // chkCreditSummary
            // 
            this.chkCreditSummary.AutoSize = true;
            this.chkCreditSummary.Location = new System.Drawing.Point(109, 31);
            this.chkCreditSummary.Name = "chkCreditSummary";
            this.chkCreditSummary.Size = new System.Drawing.Size(109, 15);
            this.chkCreditSummary.TabIndex = 2;
            this.chkCreditSummary.Text = "Credit Summary";
            this.chkCreditSummary.UseSelectable = true;
            this.chkCreditSummary.CheckedChanged += new System.EventHandler(this.chkCreditSummary_CheckedChanged);
            // 
            // chkCompositeSummary
            // 
            this.chkCompositeSummary.AutoSize = true;
            this.chkCompositeSummary.Location = new System.Drawing.Point(222, 31);
            this.chkCompositeSummary.Name = "chkCompositeSummary";
            this.chkCompositeSummary.Size = new System.Drawing.Size(81, 15);
            this.chkCompositeSummary.TabIndex = 2;
            this.chkCompositeSummary.Text = "Composite";
            this.chkCompositeSummary.UseSelectable = true;
            this.chkCompositeSummary.CheckedChanged += new System.EventHandler(this.chkCompositeSummary_CheckedChanged);
            // 
            // chkComposite
            // 
            this.chkComposite.AutoSize = true;
            this.chkComposite.Location = new System.Drawing.Point(556, 9);
            this.chkComposite.Name = "chkComposite";
            this.chkComposite.Size = new System.Drawing.Size(110, 15);
            this.chkComposite.TabIndex = 2;
            this.chkComposite.Text = "Filter Composite";
            this.chkComposite.UseSelectable = true;
            this.chkComposite.CheckedChanged += new System.EventHandler(this.chkComposite_CheckedChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Discription";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn1.HeaderText = "Narration";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TotalAmount";
            dataGridViewCellStyle13.Format = "d";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn2.HeaderText = "Total Amount";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Discription";
            this.dataGridViewTextBoxColumn5.HeaderText = "Narration";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TotalAmount";
            this.dataGridViewTextBoxColumn6.HeaderText = "Total Amount";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // ColVoucherNo
            // 
            this.ColVoucherNo.DataPropertyName = "VoucherNo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColVoucherNo.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColVoucherNo.HeaderText = "V. #";
            this.ColVoucherNo.Name = "ColVoucherNo";
            this.ColVoucherNo.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "VDate";
            dataGridViewCellStyle4.Format = "d";
            this.colDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "Discription";
            this.colDescription.HeaderText = "Narration";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Width = 250;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.DataPropertyName = "TotalAmount";
            this.colTotalAmount.HeaderText = "Total Amount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Discription";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn3.HeaderText = "Narration";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TotalAmount";
            this.dataGridViewTextBoxColumn4.HeaderText = "Total Amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // frmDayBook
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1022, 574);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.grdDetailedDailyBook);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.grpSummary);
            this.Name = "frmDayBook";
            this.Text = "Day Book Activities";
            this.Load += new System.EventHandler(this.frmDayBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetailedDailyBook)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSummaryDailyBook)).EndInit();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime dtStart;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime dtEnd;
        private MetroFramework.Controls.MetroButton btnLoad;
        private System.Windows.Forms.DataGridView grdDetailedDailyBook;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DataGridView grdSummaryDailyBook;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalAmount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colPosted;
        private MetroFramework.Controls.MetroCheckBox chkPurchases;
        private MetroFramework.Controls.MetroCheckBox chkSales;
        private MetroFramework.Controls.MetroCheckBox chkPayments;
        private MetroFramework.Controls.MetroCheckBox chkReceipts;
        private MetroFramework.Controls.MetroCheckBox chkCompositeSummary;
        private MetroFramework.Controls.MetroCheckBox chkCreditSummary;
        private MetroFramework.Controls.MetroCheckBox chkNetSummary;
        private MetroFramework.Controls.MetroCheckBox chkComposite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}