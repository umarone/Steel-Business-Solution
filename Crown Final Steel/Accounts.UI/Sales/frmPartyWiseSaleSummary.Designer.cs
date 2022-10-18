namespace Accounts.UI
{
    partial class frmPartyWiseSaleSummary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtDeliveryPerson = new MetroFramework.Controls.MetroTextBox();
            this.EmpEditCode = new MetroFramework.Controls.MetroTextBox();
            this.dtStart = new MetroFramework.Controls.MetroDateTime();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.dtEnd = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnExcelExport = new MetroFramework.Controls.MetroTile();
            this.btnLoad = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.grdTotalSales = new System.Windows.Forms.DataGridView();
            this.lblDiscount = new MetroFramework.Controls.MetroLabel();
            this.lblTotalAmount = new MetroFramework.Controls.MetroLabel();
            this.lblNetAmount = new MetroFramework.Controls.MetroLabel();
            this.chkIgnore = new System.Windows.Forms.CheckBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCustomerBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTotalSales)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.MistyRose;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(355, 71);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(111, 19);
            this.metroLabel4.TabIndex = 26;
            this.metroLabel4.Text = "Delivery Person :";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.MistyRose;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(6, 69);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(89, 19);
            this.metroLabel9.TabIndex = 26;
            this.metroLabel9.Text = "Order Taker :";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel9.UseCustomBackColor = true;
            // 
            // txtDeliveryPerson
            // 
            // 
            // 
            // 
            this.txtDeliveryPerson.CustomButton.Image = null;
            this.txtDeliveryPerson.CustomButton.Location = new System.Drawing.Point(268, 1);
            this.txtDeliveryPerson.CustomButton.Name = "";
            this.txtDeliveryPerson.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDeliveryPerson.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDeliveryPerson.CustomButton.TabIndex = 1;
            this.txtDeliveryPerson.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDeliveryPerson.CustomButton.UseSelectable = true;
            this.txtDeliveryPerson.Lines = new string[0];
            this.txtDeliveryPerson.Location = new System.Drawing.Point(471, 70);
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
            this.txtDeliveryPerson.Size = new System.Drawing.Size(290, 23);
            this.txtDeliveryPerson.Style = MetroFramework.MetroColorStyle.Green;
            this.txtDeliveryPerson.TabIndex = 1;
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
            this.EmpEditCode.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.EmpEditCode.CustomButton.Name = "";
            this.EmpEditCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.EmpEditCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.EmpEditCode.CustomButton.TabIndex = 1;
            this.EmpEditCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EmpEditCode.CustomButton.UseSelectable = true;
            this.EmpEditCode.Lines = new string[0];
            this.EmpEditCode.Location = new System.Drawing.Point(100, 69);
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
            this.EmpEditCode.Size = new System.Drawing.Size(246, 23);
            this.EmpEditCode.Style = MetroFramework.MetroColorStyle.Brown;
            this.EmpEditCode.TabIndex = 0;
            this.EmpEditCode.UseSelectable = true;
            this.EmpEditCode.WaterMark = "Type Here To Select Order Taker";
            this.EmpEditCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EmpEditCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.EmpEditCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmpEditCode_KeyPress);
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(100, 94);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(246, 29);
            this.dtStart.TabIndex = 27;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.MistyRose;
            this.lblDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDate.Location = new System.Drawing.Point(11, 95);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(81, 19);
            this.lblDate.TabIndex = 28;
            this.lblDate.Text = "From Date :";
            this.lblDate.UseCustomBackColor = true;
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(471, 96);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(290, 29);
            this.dtEnd.TabIndex = 20;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.MistyRose;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(359, 96);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 21;
            this.metroLabel1.Text = "To Date :";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.ActiveControl = null;
            this.btnExcelExport.BackColor = System.Drawing.Color.RosyBrown;
            this.btnExcelExport.Location = new System.Drawing.Point(881, 90);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(104, 39);
            this.btnExcelExport.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnExcelExport.TabIndex = 30;
            this.btnExcelExport.Text = "Excel Export";
            this.btnExcelExport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcelExport.UseCustomBackColor = true;
            this.btnExcelExport.UseSelectable = true;
            this.btnExcelExport.Click += new System.EventHandler(this.btnExcelExport_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.ActiveControl = null;
            this.btnLoad.BackColor = System.Drawing.Color.RosyBrown;
            this.btnLoad.Location = new System.Drawing.Point(774, 90);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(106, 39);
            this.btnLoad.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnLoad.TabIndex = 29;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoad.UseCustomBackColor = true;
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.MistyRose;
            this.metroPanel1.Controls.Add(this.chkIgnore);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(2, 59);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1114, 78);
            this.metroPanel1.TabIndex = 31;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // grdTotalSales
            // 
            this.grdTotalSales.AllowUserToAddRows = false;
            this.grdTotalSales.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdTotalSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdTotalSales.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTotalSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdTotalSales.ColumnHeadersHeight = 26;
            this.grdTotalSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInvoiceNo,
            this.colInvoiceDate,
            this.colAccountName,
            this.ColCustomerAddress,
            this.ColCustomerBalance,
            this.colAmount,
            this.colDiscount,
            this.colNetAmount,
            this.colSaleType});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTotalSales.DefaultCellStyle = dataGridViewCellStyle6;
            this.grdTotalSales.EnableHeadersVisualStyles = false;
            this.grdTotalSales.Location = new System.Drawing.Point(6, 140);
            this.grdTotalSales.Name = "grdTotalSales";
            this.grdTotalSales.ReadOnly = true;
            this.grdTotalSales.RowHeadersVisible = false;
            this.grdTotalSales.Size = new System.Drawing.Size(1110, 445);
            this.grdTotalSales.TabIndex = 32;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDiscount.Location = new System.Drawing.Point(803, 590);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(17, 19);
            this.lblDiscount.TabIndex = 33;
            this.lblDiscount.Text = "0";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTotalAmount.Location = new System.Drawing.Point(721, 590);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(17, 19);
            this.lblTotalAmount.TabIndex = 33;
            this.lblTotalAmount.Text = "0";
            // 
            // lblNetAmount
            // 
            this.lblNetAmount.AutoSize = true;
            this.lblNetAmount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblNetAmount.Location = new System.Drawing.Point(922, 590);
            this.lblNetAmount.Name = "lblNetAmount";
            this.lblNetAmount.Size = new System.Drawing.Size(17, 19);
            this.lblNetAmount.TabIndex = 33;
            this.lblNetAmount.Text = "0";
            // 
            // chkIgnore
            // 
            this.chkIgnore.AutoSize = true;
            this.chkIgnore.Location = new System.Drawing.Point(772, 10);
            this.chkIgnore.Name = "chkIgnore";
            this.chkIgnore.Size = new System.Drawing.Size(110, 17);
            this.chkIgnore.TabIndex = 2;
            this.chkIgnore.Text = "Ignore Employees";
            this.chkIgnore.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AccountName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Account Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Address";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn2.HeaderText = "Customer Address";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 180;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ClosingBalance";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn3.HeaderText = "Previouse Balance";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Amount";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn4.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 90;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Discount";
            this.dataGridViewTextBoxColumn5.HeaderText = "Dicount";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 90;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DiscountAmount";
            this.dataGridViewTextBoxColumn6.HeaderText = "Net Amount";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 90;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TransactionMode";
            this.dataGridViewTextBoxColumn7.HeaderText = "Sale Type";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 90;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TransactionMode";
            this.dataGridViewTextBoxColumn8.HeaderText = "Sale Type";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TransactionMode";
            this.dataGridViewTextBoxColumn9.HeaderText = "Sale Type";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.DataPropertyName = "VoucherNo";
            this.colInvoiceNo.HeaderText = "Invoice #";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.ReadOnly = true;
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.DataPropertyName = "VDate";
            dataGridViewCellStyle3.Format = "d";
            this.colInvoiceDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colInvoiceDate.HeaderText = "Date";
            this.colInvoiceDate.Name = "colInvoiceDate";
            this.colInvoiceDate.ReadOnly = true;
            // 
            // colAccountName
            // 
            this.colAccountName.DataPropertyName = "AccountName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colAccountName.DefaultCellStyle = dataGridViewCellStyle4;
            this.colAccountName.HeaderText = "Party Name";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.ReadOnly = true;
            this.colAccountName.Width = 250;
            // 
            // ColCustomerAddress
            // 
            this.ColCustomerAddress.DataPropertyName = "Address";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ColCustomerAddress.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColCustomerAddress.HeaderText = "Customer Address";
            this.ColCustomerAddress.Name = "ColCustomerAddress";
            this.ColCustomerAddress.ReadOnly = true;
            this.ColCustomerAddress.Width = 150;
            // 
            // ColCustomerBalance
            // 
            this.ColCustomerBalance.DataPropertyName = "ClosingBalance";
            this.ColCustomerBalance.HeaderText = "Previouse Balance";
            this.ColCustomerBalance.Name = "ColCustomerBalance";
            this.ColCustomerBalance.ReadOnly = true;
            this.ColCustomerBalance.Width = 120;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 90;
            // 
            // colDiscount
            // 
            this.colDiscount.DataPropertyName = "Discount";
            this.colDiscount.HeaderText = "Dicount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.ReadOnly = true;
            this.colDiscount.Width = 90;
            // 
            // colNetAmount
            // 
            this.colNetAmount.DataPropertyName = "DiscountAmount";
            this.colNetAmount.HeaderText = "Net Amount";
            this.colNetAmount.Name = "colNetAmount";
            this.colNetAmount.ReadOnly = true;
            // 
            // colSaleType
            // 
            this.colSaleType.DataPropertyName = "TransactionMode";
            this.colSaleType.HeaderText = "Sale Type";
            this.colSaleType.Name = "colSaleType";
            this.colSaleType.ReadOnly = true;
            // 
            // frmPartyWiseSaleSummary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1128, 634);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblNetAmount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.grdTotalSales);
            this.Controls.Add(this.btnExcelExport);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.EmpEditCode);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtDeliveryPerson);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmPartyWiseSaleSummary";
            this.Text = "Party Wise Sale Summary";
            this.Load += new System.EventHandler(this.frmPartyWiseSaleSummary_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTotalSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtDeliveryPerson;
        private MetroFramework.Controls.MetroTextBox EmpEditCode;
        private MetroFramework.Controls.MetroDateTime dtStart;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroDateTime dtEnd;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile btnExcelExport;
        private MetroFramework.Controls.MetroTile btnLoad;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DataGridView grdTotalSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private MetroFramework.Controls.MetroLabel lblDiscount;
        private MetroFramework.Controls.MetroLabel lblTotalAmount;
        private MetroFramework.Controls.MetroLabel lblNetAmount;
        private System.Windows.Forms.CheckBox chkIgnore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCustomerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCustomerBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNetAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}