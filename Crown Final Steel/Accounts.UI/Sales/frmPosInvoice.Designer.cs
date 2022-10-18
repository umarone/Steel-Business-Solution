namespace Accounts.UI
{
    partial class frmPosInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPosInvoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtInvoiceNumber = new MetroFramework.Controls.MetroTextBox();
            this.VInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.grdProducts = new System.Windows.Forms.DataGridView();
            this.colMinus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.txtTotalItems = new System.Windows.Forms.TextBox();
            this.txtTotalTax = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtFreeVoucher = new System.Windows.Forms.TextBox();
            this.txtInvoiceTotal = new System.Windows.Forms.TextBox();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.txtCashRecieved = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblTaxPercentage = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblFreeVoucher = new System.Windows.Forms.Label();
            this.lblInvoiceTotal = new System.Windows.Forms.Label();
            this.lblPayMode = new System.Windows.Forms.Label();
            this.lblCashRecieved = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.cbxPaymentMode = new System.Windows.Forms.ComboBox();
            this.cbxProducts = new System.Windows.Forms.ComboBox();
            this.toolPosStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnHoldSales = new System.Windows.Forms.ToolStripButton();
            this.toolStripReturn = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnCashier = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPromoCode = new System.Windows.Forms.Label();
            this.txtPromoCode = new MetroFramework.Controls.MetroTextBox();
            this.cbxCustomerType = new System.Windows.Forms.ComboBox();
            this.CustEditBox = new MetroFramework.Controls.MetroTextBox();
            this.pnlSalesAccounts = new System.Windows.Forms.Panel();
            this.cbxTaxPayables = new System.Windows.Forms.ComboBox();
            this.cbxNaturalAccounts = new System.Windows.Forms.ComboBox();
            this.lblTaxAcccount = new System.Windows.Forms.Label();
            this.lblSaleAccount = new System.Windows.Forms.Label();
            this.lblCashAccount = new System.Windows.Forms.Label();
            this.cbxCashAccounts = new System.Windows.Forms.ComboBox();
            this.lblInvoiceTotalWithTax = new System.Windows.Forms.Label();
            this.txtInvoiceTotalWithTax = new System.Windows.Forms.TextBox();
            this.lblTotalWithDicount = new System.Windows.Forms.Label();
            this.txtInvoiceTotalAfterDiscount = new System.Windows.Forms.TextBox();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            this.txtTotalTaxAmount = new System.Windows.Forms.TextBox();
            this.chkNoPrint = new System.Windows.Forms.CheckBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPackingSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).BeginInit();
            this.toolPosStrip.SuspendLayout();
            this.pnlSalesAccounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(729, 97);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date :";
            // 
            // txtInvoiceNumber
            // 
            // 
            // 
            // 
            this.txtInvoiceNumber.CustomButton.Image = null;
            this.txtInvoiceNumber.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.txtInvoiceNumber.CustomButton.Name = "";
            this.txtInvoiceNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInvoiceNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInvoiceNumber.CustomButton.TabIndex = 1;
            this.txtInvoiceNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInvoiceNumber.CustomButton.UseSelectable = true;
            this.txtInvoiceNumber.CustomButton.Visible = false;
            this.txtInvoiceNumber.Enabled = false;
            this.txtInvoiceNumber.Lines = new string[0];
            this.txtInvoiceNumber.Location = new System.Drawing.Point(94, 70);
            this.txtInvoiceNumber.MaxLength = 32767;
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.PasswordChar = '\0';
            this.txtInvoiceNumber.ReadOnly = true;
            this.txtInvoiceNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInvoiceNumber.SelectedText = "";
            this.txtInvoiceNumber.SelectionLength = 0;
            this.txtInvoiceNumber.SelectionStart = 0;
            this.txtInvoiceNumber.ShortcutsEnabled = true;
            this.txtInvoiceNumber.Size = new System.Drawing.Size(133, 23);
            this.txtInvoiceNumber.TabIndex = 4;
            this.txtInvoiceNumber.UseSelectable = true;
            this.txtInvoiceNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInvoiceNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // VInvoiceDate
            // 
            this.VInvoiceDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VInvoiceDate.Location = new System.Drawing.Point(790, 94);
            this.VInvoiceDate.Name = "VInvoiceDate";
            this.VInvoiceDate.Size = new System.Drawing.Size(169, 20);
            this.VInvoiceDate.TabIndex = 5;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Location = new System.Drawing.Point(26, 74);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(52, 13);
            this.lblInvoiceNo.TabIndex = 2;
            this.lblInvoiceNo.Text = "Invoice #";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(11, 97);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(79, 13);
            this.lblItems.TabIndex = 7;
            this.lblItems.Text = "Enter Item(s)";
            // 
            // grdProducts
            // 
            this.grdProducts.AllowUserToAddRows = false;
            this.grdProducts.AllowUserToDeleteRows = false;
            this.grdProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProducts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdProducts.ColumnHeadersHeight = 35;
            this.grdProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdItem,
            this.colBarCode,
            this.colItemName,
            this.colPackingSize,
            this.colQuantity,
            this.colUnitPrice,
            this.colAmount,
            this.colMinus,
            this.colAdd,
            this.colDelete});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdProducts.DefaultCellStyle = dataGridViewCellStyle7;
            this.grdProducts.EnableHeadersVisualStyles = false;
            this.grdProducts.Location = new System.Drawing.Point(10, 122);
            this.grdProducts.MultiSelect = false;
            this.grdProducts.Name = "grdProducts";
            this.grdProducts.ReadOnly = true;
            this.grdProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grdProducts.RowHeadersVisible = false;
            this.grdProducts.Size = new System.Drawing.Size(669, 498);
            this.grdProducts.TabIndex = 10;
            this.grdProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProducts_CellClick);
            this.grdProducts.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdProducts_CellFormatting);
            // 
            // colMinus
            // 
            this.colMinus.FillWeight = 0.1879929F;
            this.colMinus.HeaderText = ".";
            this.colMinus.MinimumWidth = 50;
            this.colMinus.Name = "colMinus";
            this.colMinus.ReadOnly = true;
            // 
            // colAdd
            // 
            this.colAdd.FillWeight = 0.1879929F;
            this.colAdd.HeaderText = "..";
            this.colAdd.MinimumWidth = 50;
            this.colAdd.Name = "colAdd";
            this.colAdd.ReadOnly = true;
            // 
            // colDelete
            // 
            this.colDelete.FillWeight = 0.1879929F;
            this.colDelete.HeaderText = "...";
            this.colDelete.MinimumWidth = 50;
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItems.Location = new System.Drawing.Point(690, 229);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(80, 16);
            this.lblTotalItems.TabIndex = 19;
            this.lblTotalItems.Text = "Total Items :";
            this.lblTotalItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalItems
            // 
            this.txtTotalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalItems.Location = new System.Drawing.Point(797, 228);
            this.txtTotalItems.Multiline = true;
            this.txtTotalItems.Name = "txtTotalItems";
            this.txtTotalItems.Size = new System.Drawing.Size(157, 20);
            this.txtTotalItems.TabIndex = 23;
            // 
            // txtTotalTax
            // 
            this.txtTotalTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTax.Location = new System.Drawing.Point(797, 365);
            this.txtTotalTax.Multiline = true;
            this.txtTotalTax.Name = "txtTotalTax";
            this.txtTotalTax.Size = new System.Drawing.Size(157, 24);
            this.txtTotalTax.TabIndex = 20;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(797, 282);
            this.txtDiscount.Multiline = true;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(157, 24);
            this.txtDiscount.TabIndex = 21;
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // txtFreeVoucher
            // 
            this.txtFreeVoucher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFreeVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFreeVoucher.Location = new System.Drawing.Point(797, 307);
            this.txtFreeVoucher.Multiline = true;
            this.txtFreeVoucher.Name = "txtFreeVoucher";
            this.txtFreeVoucher.Size = new System.Drawing.Size(157, 24);
            this.txtFreeVoucher.TabIndex = 27;
            this.txtFreeVoucher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFreeVoucher_KeyPress);
            // 
            // txtInvoiceTotal
            // 
            this.txtInvoiceTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInvoiceTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtInvoiceTotal.Enabled = false;
            this.txtInvoiceTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceTotal.Location = new System.Drawing.Point(797, 248);
            this.txtInvoiceTotal.Multiline = true;
            this.txtInvoiceTotal.Name = "txtInvoiceTotal";
            this.txtInvoiceTotal.Size = new System.Drawing.Size(157, 33);
            this.txtInvoiceTotal.TabIndex = 28;
            // 
            // txtCardNo
            // 
            this.txtCardNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNo.Location = new System.Drawing.Point(798, 472);
            this.txtCardNo.Multiline = true;
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(155, 24);
            this.txtCardNo.TabIndex = 25;
            this.txtCardNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardNo_KeyPress);
            // 
            // txtCashRecieved
            // 
            this.txtCashRecieved.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCashRecieved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCashRecieved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashRecieved.Location = new System.Drawing.Point(797, 498);
            this.txtCashRecieved.Multiline = true;
            this.txtCashRecieved.Name = "txtCashRecieved";
            this.txtCashRecieved.Size = new System.Drawing.Size(157, 24);
            this.txtCashRecieved.TabIndex = 22;
            this.txtCashRecieved.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCashRecieved_KeyPress);
            // 
            // txtBalance
            // 
            this.txtBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBalance.Enabled = false;
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(797, 524);
            this.txtBalance.Multiline = true;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(157, 24);
            this.txtBalance.TabIndex = 24;
            // 
            // lblTaxPercentage
            // 
            this.lblTaxPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTaxPercentage.AutoSize = true;
            this.lblTaxPercentage.BackColor = System.Drawing.SystemColors.Control;
            this.lblTaxPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxPercentage.Location = new System.Drawing.Point(690, 367);
            this.lblTaxPercentage.Name = "lblTaxPercentage";
            this.lblTaxPercentage.Size = new System.Drawing.Size(94, 16);
            this.lblTaxPercentage.TabIndex = 14;
            this.lblTaxPercentage.Text = "Total Tax (%) :";
            this.lblTaxPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.BackColor = System.Drawing.SystemColors.Control;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(691, 284);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(66, 16);
            this.lblDiscount.TabIndex = 11;
            this.lblDiscount.Text = "Discount :";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFreeVoucher
            // 
            this.lblFreeVoucher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFreeVoucher.AutoSize = true;
            this.lblFreeVoucher.BackColor = System.Drawing.SystemColors.Control;
            this.lblFreeVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreeVoucher.Location = new System.Drawing.Point(692, 311);
            this.lblFreeVoucher.Name = "lblFreeVoucher";
            this.lblFreeVoucher.Size = new System.Drawing.Size(95, 16);
            this.lblFreeVoucher.TabIndex = 12;
            this.lblFreeVoucher.Text = "Free Voucher :";
            this.lblFreeVoucher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInvoiceTotal
            // 
            this.lblInvoiceTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInvoiceTotal.AutoSize = true;
            this.lblInvoiceTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblInvoiceTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceTotal.Location = new System.Drawing.Point(692, 254);
            this.lblInvoiceTotal.Name = "lblInvoiceTotal";
            this.lblInvoiceTotal.Size = new System.Drawing.Size(91, 16);
            this.lblInvoiceTotal.TabIndex = 17;
            this.lblInvoiceTotal.Text = "Invoice Total :";
            this.lblInvoiceTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPayMode
            // 
            this.lblPayMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPayMode.AutoSize = true;
            this.lblPayMode.BackColor = System.Drawing.SystemColors.Control;
            this.lblPayMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayMode.Location = new System.Drawing.Point(691, 449);
            this.lblPayMode.Name = "lblPayMode";
            this.lblPayMode.Size = new System.Drawing.Size(76, 16);
            this.lblPayMode.TabIndex = 18;
            this.lblPayMode.Text = "Pay Mode :";
            this.lblPayMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCashRecieved
            // 
            this.lblCashRecieved.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCashRecieved.AutoSize = true;
            this.lblCashRecieved.BackColor = System.Drawing.SystemColors.Control;
            this.lblCashRecieved.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashRecieved.Location = new System.Drawing.Point(688, 500);
            this.lblCashRecieved.Name = "lblCashRecieved";
            this.lblCashRecieved.Size = new System.Drawing.Size(101, 16);
            this.lblCashRecieved.TabIndex = 15;
            this.lblCashRecieved.Text = "Cash Recieved";
            this.lblCashRecieved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.SystemColors.Control;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(691, 527);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(64, 16);
            this.lblBalance.TabIndex = 16;
            this.lblBalance.Text = "Balance :";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCardNo
            // 
            this.lblCardNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.BackColor = System.Drawing.SystemColors.Control;
            this.lblCardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNo.Location = new System.Drawing.Point(690, 476);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(64, 16);
            this.lblCardNo.TabIndex = 13;
            this.lblCardNo.Text = "Card No :";
            this.lblCardNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxPaymentMode
            // 
            this.cbxPaymentMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPaymentMode.DropDownWidth = 100;
            this.cbxPaymentMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxPaymentMode.FormattingEnabled = true;
            this.cbxPaymentMode.IntegralHeight = false;
            this.cbxPaymentMode.ItemHeight = 13;
            this.cbxPaymentMode.Items.AddRange(new object[] {
            "Cash Payment",
            "Debit Card Payment",
            "Credit Card Payment"});
            this.cbxPaymentMode.Location = new System.Drawing.Point(799, 448);
            this.cbxPaymentMode.Name = "cbxPaymentMode";
            this.cbxPaymentMode.Size = new System.Drawing.Size(155, 21);
            this.cbxPaymentMode.TabIndex = 30;
            // 
            // cbxProducts
            // 
            this.cbxProducts.BackColor = System.Drawing.SystemColors.Info;
            this.cbxProducts.FormattingEnabled = true;
            this.cbxProducts.Location = new System.Drawing.Point(94, 95);
            this.cbxProducts.Name = "cbxProducts";
            this.cbxProducts.Size = new System.Drawing.Size(587, 21);
            this.cbxProducts.TabIndex = 0;
            this.cbxProducts.TextChanged += new System.EventHandler(this.cbxProducts_TextChanged);
            this.cbxProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxProducts_KeyDown);
            // 
            // toolPosStrip
            // 
            this.toolPosStrip.AutoSize = false;
            this.toolPosStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnNew,
            this.toolStripbtnHoldSales,
            this.toolStripReturn,
            this.toolStripBtnCashier});
            this.toolPosStrip.Location = new System.Drawing.Point(0, 0);
            this.toolPosStrip.Name = "toolPosStrip";
            this.toolPosStrip.Size = new System.Drawing.Size(966, 66);
            this.toolPosStrip.TabIndex = 35;
            this.toolPosStrip.Text = "toolStrip1";
            // 
            // toolStripBtnNew
            // 
            this.toolStripBtnNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnNew.Image")));
            this.toolStripBtnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnNew.Name = "toolStripBtnNew";
            this.toolStripBtnNew.Size = new System.Drawing.Size(92, 63);
            this.toolStripBtnNew.Text = "New";
            this.toolStripBtnNew.Click += new System.EventHandler(this.toolStripBtnNew_Click);
            // 
            // toolStripbtnHoldSales
            // 
            this.toolStripbtnHoldSales.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnHoldSales.Image")));
            this.toolStripbtnHoldSales.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripbtnHoldSales.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnHoldSales.Name = "toolStripbtnHoldSales";
            this.toolStripbtnHoldSales.Size = new System.Drawing.Size(118, 63);
            this.toolStripbtnHoldSales.Text = "Hold Sale";
            // 
            // toolStripReturn
            // 
            this.toolStripReturn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripReturn.Image")));
            this.toolStripReturn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripReturn.Name = "toolStripReturn";
            this.toolStripReturn.Size = new System.Drawing.Size(99, 63);
            this.toolStripReturn.Text = "Return";
            this.toolStripReturn.Click += new System.EventHandler(this.toolStripReturn_Click);
            // 
            // toolStripBtnCashier
            // 
            this.toolStripBtnCashier.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtnCashier.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCashier.Image")));
            this.toolStripBtnCashier.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnCashier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCashier.Name = "toolStripBtnCashier";
            this.toolStripBtnCashier.Size = new System.Drawing.Size(106, 63);
            this.toolStripBtnCashier.Text = "Cashier";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(730, 554);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(229, 51);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPromoCode
            // 
            this.lblPromoCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPromoCode.AutoSize = true;
            this.lblPromoCode.Location = new System.Drawing.Point(727, 75);
            this.lblPromoCode.Name = "lblPromoCode";
            this.lblPromoCode.Size = new System.Drawing.Size(43, 13);
            this.lblPromoCode.TabIndex = 2;
            this.lblPromoCode.Text = "Promo :";
            // 
            // txtPromoCode
            // 
            this.txtPromoCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtPromoCode.CustomButton.Image = null;
            this.txtPromoCode.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtPromoCode.CustomButton.Name = "";
            this.txtPromoCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPromoCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPromoCode.CustomButton.TabIndex = 1;
            this.txtPromoCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPromoCode.CustomButton.UseSelectable = true;
            this.txtPromoCode.CustomButton.Visible = false;
            this.txtPromoCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPromoCode.Lines = new string[0];
            this.txtPromoCode.Location = new System.Drawing.Point(790, 69);
            this.txtPromoCode.MaxLength = 32767;
            this.txtPromoCode.Name = "txtPromoCode";
            this.txtPromoCode.PasswordChar = '\0';
            this.txtPromoCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPromoCode.SelectedText = "";
            this.txtPromoCode.SelectionLength = 0;
            this.txtPromoCode.SelectionStart = 0;
            this.txtPromoCode.ShortcutsEnabled = true;
            this.txtPromoCode.Size = new System.Drawing.Size(169, 23);
            this.txtPromoCode.TabIndex = 4;
            this.txtPromoCode.UseSelectable = true;
            this.txtPromoCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPromoCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbxCustomerType
            // 
            this.cbxCustomerType.BackColor = System.Drawing.SystemColors.Info;
            this.cbxCustomerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCustomerType.FormattingEnabled = true;
            this.cbxCustomerType.Items.AddRange(new object[] {
            "Walking Customer",
            "Credit Customer"});
            this.cbxCustomerType.Location = new System.Drawing.Point(227, 70);
            this.cbxCustomerType.Name = "cbxCustomerType";
            this.cbxCustomerType.Size = new System.Drawing.Size(161, 24);
            this.cbxCustomerType.TabIndex = 37;
            this.cbxCustomerType.SelectedIndexChanged += new System.EventHandler(this.cbxCustomerType_SelectedIndexChanged);
            this.cbxCustomerType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxCustomerType_KeyPress);
            // 
            // CustEditBox
            // 
            this.CustEditBox.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.CustEditBox.CustomButton.Image = null;
            this.CustEditBox.CustomButton.Location = new System.Drawing.Point(270, 1);
            this.CustEditBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.CustEditBox.CustomButton.Name = "";
            this.CustEditBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CustEditBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CustEditBox.CustomButton.TabIndex = 1;
            this.CustEditBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CustEditBox.CustomButton.UseSelectable = true;
            this.CustEditBox.Lines = new string[0];
            this.CustEditBox.Location = new System.Drawing.Point(389, 71);
            this.CustEditBox.MaxLength = 32767;
            this.CustEditBox.Name = "CustEditBox";
            this.CustEditBox.PasswordChar = '\0';
            this.CustEditBox.PromptText = "Type And Search Customer";
            this.CustEditBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CustEditBox.SelectedText = "";
            this.CustEditBox.SelectionLength = 0;
            this.CustEditBox.SelectionStart = 0;
            this.CustEditBox.ShortcutsEnabled = true;
            this.CustEditBox.ShowButton = true;
            this.CustEditBox.Size = new System.Drawing.Size(292, 23);
            this.CustEditBox.Style = MetroFramework.MetroColorStyle.Teal;
            this.CustEditBox.TabIndex = 39;
            this.CustEditBox.UseSelectable = true;
            this.CustEditBox.Visible = false;
            this.CustEditBox.WaterMark = "Type And Search Customer";
            this.CustEditBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CustEditBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.CustEditBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustEditBox_KeyPress);
            // 
            // pnlSalesAccounts
            // 
            this.pnlSalesAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSalesAccounts.Controls.Add(this.cbxTaxPayables);
            this.pnlSalesAccounts.Controls.Add(this.cbxNaturalAccounts);
            this.pnlSalesAccounts.Controls.Add(this.lblTaxAcccount);
            this.pnlSalesAccounts.Controls.Add(this.lblSaleAccount);
            this.pnlSalesAccounts.Controls.Add(this.lblCashAccount);
            this.pnlSalesAccounts.Controls.Add(this.cbxCashAccounts);
            this.pnlSalesAccounts.Location = new System.Drawing.Point(700, 115);
            this.pnlSalesAccounts.Name = "pnlSalesAccounts";
            this.pnlSalesAccounts.Size = new System.Drawing.Size(260, 67);
            this.pnlSalesAccounts.TabIndex = 41;
            // 
            // cbxTaxPayables
            // 
            this.cbxTaxPayables.FormattingEnabled = true;
            this.cbxTaxPayables.Location = new System.Drawing.Point(97, 43);
            this.cbxTaxPayables.Name = "cbxTaxPayables";
            this.cbxTaxPayables.Size = new System.Drawing.Size(157, 21);
            this.cbxTaxPayables.TabIndex = 45;
            this.cbxTaxPayables.SelectedIndexChanged += new System.EventHandler(this.cbxTaxPayables_SelectedIndexChanged);
            // 
            // cbxNaturalAccounts
            // 
            this.cbxNaturalAccounts.FormattingEnabled = true;
            this.cbxNaturalAccounts.Location = new System.Drawing.Point(97, 25);
            this.cbxNaturalAccounts.Name = "cbxNaturalAccounts";
            this.cbxNaturalAccounts.Size = new System.Drawing.Size(157, 21);
            this.cbxNaturalAccounts.TabIndex = 43;
            this.cbxNaturalAccounts.SelectedIndexChanged += new System.EventHandler(this.cbxNaturalAccounts_SelectedIndexChanged);
            // 
            // lblTaxAcccount
            // 
            this.lblTaxAcccount.AutoSize = true;
            this.lblTaxAcccount.Location = new System.Drawing.Point(21, 46);
            this.lblTaxAcccount.Name = "lblTaxAcccount";
            this.lblTaxAcccount.Size = new System.Drawing.Size(47, 13);
            this.lblTaxAcccount.TabIndex = 44;
            this.lblTaxAcccount.Text = "Tax A/C";
            // 
            // lblSaleAccount
            // 
            this.lblSaleAccount.AutoSize = true;
            this.lblSaleAccount.Location = new System.Drawing.Point(21, 28);
            this.lblSaleAccount.Name = "lblSaleAccount";
            this.lblSaleAccount.Size = new System.Drawing.Size(50, 13);
            this.lblSaleAccount.TabIndex = 44;
            this.lblSaleAccount.Text = "Sale A/C";
            // 
            // lblCashAccount
            // 
            this.lblCashAccount.AutoSize = true;
            this.lblCashAccount.Location = new System.Drawing.Point(21, 7);
            this.lblCashAccount.Name = "lblCashAccount";
            this.lblCashAccount.Size = new System.Drawing.Size(53, 13);
            this.lblCashAccount.TabIndex = 44;
            this.lblCashAccount.Text = "Cash A/C";
            // 
            // cbxCashAccounts
            // 
            this.cbxCashAccounts.FormattingEnabled = true;
            this.cbxCashAccounts.Location = new System.Drawing.Point(97, 3);
            this.cbxCashAccounts.Name = "cbxCashAccounts";
            this.cbxCashAccounts.Size = new System.Drawing.Size(157, 21);
            this.cbxCashAccounts.TabIndex = 43;
            this.cbxCashAccounts.SelectedIndexChanged += new System.EventHandler(this.cbxCashAccounts_SelectedIndexChanged);
            // 
            // lblInvoiceTotalWithTax
            // 
            this.lblInvoiceTotalWithTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInvoiceTotalWithTax.AutoSize = true;
            this.lblInvoiceTotalWithTax.BackColor = System.Drawing.SystemColors.Control;
            this.lblInvoiceTotalWithTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceTotalWithTax.Location = new System.Drawing.Point(690, 421);
            this.lblInvoiceTotalWithTax.Name = "lblInvoiceTotalWithTax";
            this.lblInvoiceTotalWithTax.Size = new System.Drawing.Size(100, 16);
            this.lblInvoiceTotalWithTax.TabIndex = 17;
            this.lblInvoiceTotalWithTax.Text = "Total With Tax :";
            this.lblInvoiceTotalWithTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInvoiceTotalWithTax
            // 
            this.txtInvoiceTotalWithTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInvoiceTotalWithTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtInvoiceTotalWithTax.Enabled = false;
            this.txtInvoiceTotalWithTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceTotalWithTax.Location = new System.Drawing.Point(797, 414);
            this.txtInvoiceTotalWithTax.Multiline = true;
            this.txtInvoiceTotalWithTax.Name = "txtInvoiceTotalWithTax";
            this.txtInvoiceTotalWithTax.Size = new System.Drawing.Size(157, 33);
            this.txtInvoiceTotalWithTax.TabIndex = 28;
            // 
            // lblTotalWithDicount
            // 
            this.lblTotalWithDicount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalWithDicount.AutoSize = true;
            this.lblTotalWithDicount.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalWithDicount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWithDicount.Location = new System.Drawing.Point(690, 341);
            this.lblTotalWithDicount.Name = "lblTotalWithDicount";
            this.lblTotalWithDicount.Size = new System.Drawing.Size(104, 16);
            this.lblTotalWithDicount.TabIndex = 17;
            this.lblTotalWithDicount.Text = "Total With Disc :";
            this.lblTotalWithDicount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInvoiceTotalAfterDiscount
            // 
            this.txtInvoiceTotalAfterDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInvoiceTotalAfterDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtInvoiceTotalAfterDiscount.Enabled = false;
            this.txtInvoiceTotalAfterDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceTotalAfterDiscount.Location = new System.Drawing.Point(797, 332);
            this.txtInvoiceTotalAfterDiscount.Multiline = true;
            this.txtInvoiceTotalAfterDiscount.Name = "txtInvoiceTotalAfterDiscount";
            this.txtInvoiceTotalAfterDiscount.Size = new System.Drawing.Size(157, 33);
            this.txtInvoiceTotalAfterDiscount.TabIndex = 28;
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTaxAmount.AutoSize = true;
            this.lblTaxAmount.BackColor = System.Drawing.SystemColors.Control;
            this.lblTaxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxAmount.Location = new System.Drawing.Point(690, 393);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(85, 16);
            this.lblTaxAmount.TabIndex = 14;
            this.lblTaxAmount.Text = "Tax Amount :";
            this.lblTaxAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalTaxAmount
            // 
            this.txtTotalTaxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalTaxAmount.Enabled = false;
            this.txtTotalTaxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTaxAmount.Location = new System.Drawing.Point(797, 390);
            this.txtTotalTaxAmount.Multiline = true;
            this.txtTotalTaxAmount.Name = "txtTotalTaxAmount";
            this.txtTotalTaxAmount.Size = new System.Drawing.Size(157, 24);
            this.txtTotalTaxAmount.TabIndex = 20;
            // 
            // chkNoPrint
            // 
            this.chkNoPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkNoPrint.AutoSize = true;
            this.chkNoPrint.Location = new System.Drawing.Point(797, 208);
            this.chkNoPrint.Name = "chkNoPrint";
            this.chkNoPrint.Size = new System.Drawing.Size(110, 17);
            this.chkNoPrint.TabIndex = 42;
            this.chkNoPrint.Text = "No Print Required";
            this.chkNoPrint.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Item Code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 95;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn2.FillWeight = 20.30457F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn3.FillWeight = 657.868F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn4.FillWeight = 20.30457F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Rate";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn5.FillWeight = 20.30457F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Total";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 102;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn6.FillWeight = 20.30457F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 146;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn7.FillWeight = 203.7314F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // colIdItem
            // 
            this.colIdItem.HeaderText = "IdItem";
            this.colIdItem.Name = "colIdItem";
            this.colIdItem.ReadOnly = true;
            this.colIdItem.Visible = false;
            // 
            // colBarCode
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colBarCode.DefaultCellStyle = dataGridViewCellStyle2;
            this.colBarCode.FillWeight = 406.0914F;
            this.colBarCode.HeaderText = "Bar Code";
            this.colBarCode.MinimumWidth = 80;
            this.colBarCode.Name = "colBarCode";
            this.colBarCode.ReadOnly = true;
            // 
            // colItemName
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colItemName.DefaultCellStyle = dataGridViewCellStyle3;
            this.colItemName.FillWeight = 39.66759F;
            this.colItemName.HeaderText = "Item Name";
            this.colItemName.MinimumWidth = 230;
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;
            // 
            // colPackingSize
            // 
            this.colPackingSize.HeaderText = "Packing";
            this.colPackingSize.MinimumWidth = 70;
            this.colPackingSize.Name = "colPackingSize";
            this.colPackingSize.ReadOnly = true;
            // 
            // colQuantity
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colQuantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.colQuantity.FillWeight = 49.53582F;
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.MinimumWidth = 70;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colUnitPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.colUnitPrice.FillWeight = 100.4099F;
            this.colUnitPrice.HeaderText = "Rate";
            this.colUnitPrice.MinimumWidth = 70;
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            // 
            // colAmount
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colAmount.DefaultCellStyle = dataGridViewCellStyle6;
            this.colAmount.FillWeight = 203.7314F;
            this.colAmount.HeaderText = "Amount";
            this.colAmount.MinimumWidth = 80;
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // frmPosInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 620);
            this.Controls.Add(this.lblInvoiceNo);
            this.Controls.Add(this.txtInvoiceNumber);
            this.Controls.Add(this.pnlSalesAccounts);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtPromoCode);
            this.Controls.Add(this.lblPromoCode);
            this.Controls.Add(this.chkNoPrint);
            this.Controls.Add(this.VInvoiceDate);
            this.Controls.Add(this.CustEditBox);
            this.Controls.Add(this.cbxCustomerType);
            this.Controls.Add(this.toolPosStrip);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.cbxProducts);
            this.Controls.Add(this.lblTotalWithDicount);
            this.Controls.Add(this.lblFreeVoucher);
            this.Controls.Add(this.lblPayMode);
            this.Controls.Add(this.lblCashRecieved);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblCardNo);
            this.Controls.Add(this.grdProducts);
            this.Controls.Add(this.lblTotalItems);
            this.Controls.Add(this.txtTotalItems);
            this.Controls.Add(this.lblInvoiceTotal);
            this.Controls.Add(this.cbxPaymentMode);
            this.Controls.Add(this.txtTotalTaxAmount);
            this.Controls.Add(this.txtTotalTax);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtFreeVoucher);
            this.Controls.Add(this.txtInvoiceTotalWithTax);
            this.Controls.Add(this.txtInvoiceTotalAfterDiscount);
            this.Controls.Add(this.txtInvoiceTotal);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.txtCashRecieved);
            this.Controls.Add(this.lblTaxAmount);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblTaxPercentage);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblInvoiceTotalWithTax);
            this.Controls.Add(this.btnSave);
            this.Name = "frmPosInvoice";
            this.Text = "POS Invoice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPosInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).EndInit();
            this.toolPosStrip.ResumeLayout(false);
            this.toolPosStrip.PerformLayout();
            this.pnlSalesAccounts.ResumeLayout(false);
            this.pnlSalesAccounts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private MetroFramework.Controls.MetroTextBox txtInvoiceNumber;
        private System.Windows.Forms.DateTimePicker VInvoiceDate;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.DataGridView grdProducts;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.TextBox txtTotalItems;
        private System.Windows.Forms.TextBox txtTotalTax;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtFreeVoucher;
        private System.Windows.Forms.TextBox txtInvoiceTotal;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.TextBox txtCashRecieved;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblTaxPercentage;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblFreeVoucher;
        private System.Windows.Forms.Label lblInvoiceTotal;
        private System.Windows.Forms.Label lblPayMode;
        private System.Windows.Forms.Label lblCashRecieved;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox cbxPaymentMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ComboBox cbxProducts;
        private System.Windows.Forms.ToolStrip toolPosStrip;
        private System.Windows.Forms.ToolStripButton toolStripBtnNew;
        private System.Windows.Forms.ToolStripButton toolStripbtnHoldSales;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripButton toolStripBtnCashier;
        private System.Windows.Forms.Label lblPromoCode;
        private MetroFramework.Controls.MetroTextBox txtPromoCode;
        private System.Windows.Forms.ToolStripButton toolStripReturn;
        private System.Windows.Forms.ComboBox cbxCustomerType;
        private MetroFramework.Controls.MetroTextBox CustEditBox;
        private System.Windows.Forms.Panel pnlSalesAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPackingSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewButtonColumn colMinus;
        private System.Windows.Forms.DataGridViewButtonColumn colAdd;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label lblInvoiceTotalWithTax;
        private System.Windows.Forms.TextBox txtInvoiceTotalWithTax;
        private System.Windows.Forms.Label lblTotalWithDicount;
        private System.Windows.Forms.TextBox txtInvoiceTotalAfterDiscount;
        private System.Windows.Forms.Label lblTaxAmount;
        private System.Windows.Forms.TextBox txtTotalTaxAmount;
        private System.Windows.Forms.CheckBox chkNoPrint;
        private System.Windows.Forms.ComboBox cbxCashAccounts;
        private System.Windows.Forms.Label lblCashAccount;
        private System.Windows.Forms.ComboBox cbxNaturalAccounts;
        private System.Windows.Forms.ComboBox cbxTaxPayables;
        private System.Windows.Forms.Label lblSaleAccount;
        private System.Windows.Forms.Label lblTaxAcccount;
    }
}