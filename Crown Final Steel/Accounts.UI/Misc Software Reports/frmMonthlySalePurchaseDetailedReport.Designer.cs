namespace Accounts.UI
{
    partial class frmMonthlySalePurchaseDetailedReport
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
            this.grdMonthlyDetailedReports = new Accounts.UI.CustomDataGrid();
            this.colVDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblCustomerName = new MetroFramework.Controls.MetroLabel();
            this.lblStartDate = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblEndDate = new MetroFramework.Controls.MetroLabel();
            this.lblPersonName = new MetroFramework.Controls.MetroLabel();
            this.lblReportType = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblTransactionType = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lblTotalAmount = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdMonthlyDetailedReports)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdMonthlyDetailedReports
            // 
            this.grdMonthlyDetailedReports.AllowUserToAddRows = false;
            this.grdMonthlyDetailedReports.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdMonthlyDetailedReports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdMonthlyDetailedReports.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMonthlyDetailedReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdMonthlyDetailedReports.ColumnHeadersHeight = 25;
            this.grdMonthlyDetailedReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVDate,
            this.colTotalAmount});
            this.grdMonthlyDetailedReports.EnableHeadersVisualStyles = false;
            this.grdMonthlyDetailedReports.Location = new System.Drawing.Point(334, 12);
            this.grdMonthlyDetailedReports.Name = "grdMonthlyDetailedReports";
            this.grdMonthlyDetailedReports.ReadOnly = true;
            this.grdMonthlyDetailedReports.RowHeadersVisible = false;
            this.grdMonthlyDetailedReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMonthlyDetailedReports.Size = new System.Drawing.Size(415, 493);
            this.grdMonthlyDetailedReports.TabIndex = 3;
            // 
            // colVDate
            // 
            this.colVDate.DataPropertyName = "VDate";
            dataGridViewCellStyle6.Format = "d";
            this.colVDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.colVDate.HeaderText = "Date";
            this.colVDate.Name = "colVDate";
            this.colVDate.ReadOnly = true;
            this.colVDate.Width = 280;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.DataPropertyName = "TotalAmount";
            this.colTotalAmount.HeaderText = "Total Amount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.ReadOnly = true;
            this.colTotalAmount.Width = 130;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lblCustomerName);
            this.metroPanel1.Controls.Add(this.lblStartDate);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.lblEndDate);
            this.metroPanel1.Controls.Add(this.lblPersonName);
            this.metroPanel1.Controls.Add(this.lblReportType);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.lblTransactionType);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.lblTotalAmount);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(4, 12);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(326, 257);
            this.metroPanel1.TabIndex = 4;
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
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblReportType.Location = new System.Drawing.Point(149, 118);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(69, 19);
            this.lblReportType.TabIndex = 2;
            this.lblReportType.Text = "Purchase";
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
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(7, 150);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(108, 25);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Transaction :";
            // 
            // lblTransactionType
            // 
            this.lblTransactionType.AutoSize = true;
            this.lblTransactionType.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTransactionType.Location = new System.Drawing.Point(151, 156);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(33, 19);
            this.lblTransactionType.TabIndex = 2;
            this.lblTransactionType.Text = "Net";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(9, 188);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(124, 25);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Total Amount :";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTotalAmount.Location = new System.Drawing.Point(153, 194);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(17, 19);
            this.lblTotalAmount.TabIndex = 2;
            this.lblTotalAmount.Text = "0";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(5, 112);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(112, 25);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Report Type :";
            // 
            // frmMonthlySalePurchaseDetailedReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 528);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.grdMonthlyDetailedReports);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMonthlySalePurchaseDetailedReport";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "frmMonthlySalePurchaseDetailedReport";
            this.Load += new System.EventHandler(this.frmMonthlySalePurchaseDetailedReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMonthlyDetailedReports)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDataGrid grdMonthlyDetailedReports;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblCustomerName;
        private MetroFramework.Controls.MetroLabel lblStartDate;
        private MetroFramework.Controls.MetroLabel lblPersonName;
        private MetroFramework.Controls.MetroLabel lblEndDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblReportType;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lblTransactionType;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalAmount;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lblTotalAmount;
    }
}