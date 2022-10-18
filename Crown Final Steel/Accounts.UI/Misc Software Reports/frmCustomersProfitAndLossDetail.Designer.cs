namespace Accounts.UI
{
    partial class frmCustomersProfitAndLossDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdCustomers = new Accounts.UI.CustomDataGrid();
            this.colVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalItemsSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalSalesCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblCustomerName = new MetroFramework.Controls.MetroLabel();
            this.lblStartDate = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblEndDate = new MetroFramework.Controls.MetroLabel();
            this.lblPersonName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lblTotalAmount = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdCustomers
            // 
            this.grdCustomers.AllowUserToAddRows = false;
            this.grdCustomers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdCustomers.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdCustomers.ColumnHeadersHeight = 25;
            this.grdCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVoucherNo,
            this.colVDate,
            this.colTotalItemsSold,
            this.colTotalSales,
            this.colTotalSalesCost,
            this.colTotalProfit});
            this.grdCustomers.EnableHeadersVisualStyles = false;
            this.grdCustomers.Location = new System.Drawing.Point(347, 72);
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.ReadOnly = true;
            this.grdCustomers.RowHeadersVisible = false;
            this.grdCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCustomers.Size = new System.Drawing.Size(714, 410);
            this.grdCustomers.TabIndex = 15;
            // 
            // colVoucherNo
            // 
            this.colVoucherNo.DataPropertyName = "VoucherNo";
            this.colVoucherNo.HeaderText = "Voucher No";
            this.colVoucherNo.Name = "colVoucherNo";
            this.colVoucherNo.ReadOnly = true;
            // 
            // colVDate
            // 
            this.colVDate.DataPropertyName = "VDate";
            dataGridViewCellStyle6.Format = "d";
            this.colVDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.colVDate.HeaderText = "Sale Date";
            this.colVDate.Name = "colVDate";
            this.colVDate.ReadOnly = true;
            this.colVDate.Width = 120;
            // 
            // colTotalItemsSold
            // 
            this.colTotalItemsSold.DataPropertyName = "TotalSales";
            this.colTotalItemsSold.HeaderText = "Sold Items";
            this.colTotalItemsSold.Name = "colTotalItemsSold";
            this.colTotalItemsSold.ReadOnly = true;
            this.colTotalItemsSold.Width = 120;
            // 
            // colTotalSales
            // 
            this.colTotalSales.DataPropertyName = "NetSaleAmount";
            this.colTotalSales.HeaderText = "Total Sales";
            this.colTotalSales.Name = "colTotalSales";
            this.colTotalSales.ReadOnly = true;
            this.colTotalSales.Width = 120;
            // 
            // colTotalSalesCost
            // 
            this.colTotalSalesCost.DataPropertyName = "SaleCost";
            this.colTotalSalesCost.HeaderText = "Sales Cost";
            this.colTotalSalesCost.Name = "colTotalSalesCost";
            this.colTotalSalesCost.ReadOnly = true;
            this.colTotalSalesCost.Width = 120;
            // 
            // colTotalProfit
            // 
            this.colTotalProfit.DataPropertyName = "GrossProfit";
            this.colTotalProfit.HeaderText = "Proift";
            this.colTotalProfit.Name = "colTotalProfit";
            this.colTotalProfit.ReadOnly = true;
            this.colTotalProfit.Width = 120;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lblCustomerName);
            this.metroPanel1.Controls.Add(this.lblStartDate);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.lblEndDate);
            this.metroPanel1.Controls.Add(this.lblPersonName);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.lblTotalAmount);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(8, 71);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(326, 163);
            this.metroPanel1.TabIndex = 16;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCustomerName.Location = new System.Drawing.Point(151, 84);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(46, 19);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Umar";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblStartDate.Location = new System.Drawing.Point(153, 18);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(72, 19);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "StartDate";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(7, 43);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(40, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "To :";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblEndDate.Location = new System.Drawing.Point(153, 53);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(64, 19);
            this.lblEndDate.TabIndex = 2;
            this.lblEndDate.Text = "EndDate";
            // 
            // lblPersonName
            // 
            this.lblPersonName.AutoSize = true;
            this.lblPersonName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPersonName.Location = new System.Drawing.Point(7, 78);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(145, 25);
            this.lblPersonName.TabIndex = 2;
            this.lblPersonName.Text = "Customer Name :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(7, 8);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "From :";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(7, 115);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(124, 25);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Total Amount :";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTotalAmount.Location = new System.Drawing.Point(151, 121);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(17, 19);
            this.lblTotalAmount.TabIndex = 2;
            this.lblTotalAmount.Text = "0";
            // 
            // frmCustomersProfitAndLossDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 510);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.grdCustomers);
            this.MaximizeBox = false;
            this.Name = "frmCustomersProfitAndLossDetail";
            this.Text = "Sale Wise Profit Detail";
            this.Load += new System.EventHandler(this.frmCustomersProfitAndLossDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDataGrid grdCustomers;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblCustomerName;
        private MetroFramework.Controls.MetroLabel lblStartDate;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblEndDate;
        private MetroFramework.Controls.MetroLabel lblPersonName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lblTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalItemsSold;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalSalesCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalProfit;
    }
}