namespace Accounts.UI
{
    partial class frmSalesManLedger
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdTotalTransactions = new System.Windows.Forms.DataGridView();
            this.colAccountNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOpening = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalRecievables = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalRecieved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClosing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPeriod = new System.Windows.Forms.GroupBox();
            this.cbxEmployees = new MetroFramework.Controls.MetroComboBox();
            this.btnExcelExport = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnLoad = new MetroFramework.Controls.MetroTile();
            this.chkDate = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.EndDate = new MetroFramework.Controls.MetroDateTime();
            this.StartDate = new MetroFramework.Controls.MetroDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.grdTotalTransactions)).BeginInit();
            this.pnlPeriod.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdTotalTransactions
            // 
            this.grdTotalTransactions.AllowUserToAddRows = false;
            this.grdTotalTransactions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Beige;
            this.grdTotalTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdTotalTransactions.BackgroundColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTotalTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdTotalTransactions.ColumnHeadersHeight = 25;
            this.grdTotalTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAccountNo,
            this.colAccountName,
            this.colOpening,
            this.colTotalSales,
            this.colTotalRecievables,
            this.colReturns,
            this.colReturnAmount,
            this.colTotalRecieved,
            this.colClosing});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTotalTransactions.DefaultCellStyle = dataGridViewCellStyle8;
            this.grdTotalTransactions.EnableHeadersVisualStyles = false;
            this.grdTotalTransactions.Location = new System.Drawing.Point(19, 155);
            this.grdTotalTransactions.Name = "grdTotalTransactions";
            this.grdTotalTransactions.ReadOnly = true;
            this.grdTotalTransactions.RowHeadersVisible = false;
            this.grdTotalTransactions.Size = new System.Drawing.Size(1094, 372);
            this.grdTotalTransactions.TabIndex = 10;
            // 
            // colAccountNo
            // 
            this.colAccountNo.DataPropertyName = "AccountNo";
            this.colAccountNo.HeaderText = "AccountNo";
            this.colAccountNo.Name = "colAccountNo";
            this.colAccountNo.ReadOnly = true;
            this.colAccountNo.Visible = false;
            // 
            // colAccountName
            // 
            this.colAccountName.DataPropertyName = "AccountName";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Blue;
            this.colAccountName.DefaultCellStyle = dataGridViewCellStyle7;
            this.colAccountName.HeaderText = "AccountName";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.ReadOnly = true;
            this.colAccountName.Width = 250;
            // 
            // colOpening
            // 
            this.colOpening.DataPropertyName = "OpeningBalance";
            this.colOpening.HeaderText = "Opening Balance";
            this.colOpening.Name = "colOpening";
            this.colOpening.ReadOnly = true;
            this.colOpening.Width = 120;
            // 
            // colTotalSales
            // 
            this.colTotalSales.DataPropertyName = "TotalSales";
            this.colTotalSales.HeaderText = "Total Sales";
            this.colTotalSales.Name = "colTotalSales";
            this.colTotalSales.ReadOnly = true;
            this.colTotalSales.Width = 120;
            // 
            // colTotalRecievables
            // 
            this.colTotalRecievables.DataPropertyName = "TotalRecieveables";
            this.colTotalRecievables.HeaderText = "Total Recievables";
            this.colTotalRecievables.Name = "colTotalRecievables";
            this.colTotalRecievables.ReadOnly = true;
            this.colTotalRecievables.Width = 120;
            // 
            // colReturns
            // 
            this.colReturns.DataPropertyName = "TotalReturns";
            this.colReturns.HeaderText = "Total Sales Return";
            this.colReturns.Name = "colReturns";
            this.colReturns.ReadOnly = true;
            this.colReturns.Width = 120;
            // 
            // colReturnAmount
            // 
            this.colReturnAmount.DataPropertyName = "TotalPayables";
            this.colReturnAmount.HeaderText = "Return Amount";
            this.colReturnAmount.Name = "colReturnAmount";
            this.colReturnAmount.ReadOnly = true;
            this.colReturnAmount.Width = 120;
            // 
            // colTotalRecieved
            // 
            this.colTotalRecieved.DataPropertyName = "TotalRecieved";
            this.colTotalRecieved.HeaderText = "Total Recieved";
            this.colTotalRecieved.Name = "colTotalRecieved";
            this.colTotalRecieved.ReadOnly = true;
            this.colTotalRecieved.Width = 120;
            // 
            // colClosing
            // 
            this.colClosing.DataPropertyName = "ClosingBalance";
            this.colClosing.HeaderText = "Closing Balance";
            this.colClosing.Name = "colClosing";
            this.colClosing.ReadOnly = true;
            this.colClosing.Width = 120;
            // 
            // pnlPeriod
            // 
            this.pnlPeriod.BackColor = System.Drawing.Color.White;
            this.pnlPeriod.Controls.Add(this.cbxEmployees);
            this.pnlPeriod.Controls.Add(this.btnExcelExport);
            this.pnlPeriod.Controls.Add(this.metroLabel3);
            this.pnlPeriod.Controls.Add(this.metroLabel2);
            this.pnlPeriod.Controls.Add(this.btnLoad);
            this.pnlPeriod.Controls.Add(this.chkDate);
            this.pnlPeriod.Controls.Add(this.metroLabel1);
            this.pnlPeriod.Controls.Add(this.EndDate);
            this.pnlPeriod.Controls.Add(this.StartDate);
            this.pnlPeriod.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPeriod.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pnlPeriod.Location = new System.Drawing.Point(19, 63);
            this.pnlPeriod.Name = "pnlPeriod";
            this.pnlPeriod.Size = new System.Drawing.Size(1094, 91);
            this.pnlPeriod.TabIndex = 9;
            this.pnlPeriod.TabStop = false;
            this.pnlPeriod.Text = "Stock Report";
            // 
            // cbxEmployees
            // 
            this.cbxEmployees.FormattingEnabled = true;
            this.cbxEmployees.ItemHeight = 23;
            this.cbxEmployees.Location = new System.Drawing.Point(91, 45);
            this.cbxEmployees.Name = "cbxEmployees";
            this.cbxEmployees.Size = new System.Drawing.Size(157, 29);
            this.cbxEmployees.TabIndex = 11;
            this.cbxEmployees.UseSelectable = true;
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.ActiveControl = null;
            this.btnExcelExport.Location = new System.Drawing.Point(981, 37);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(106, 39);
            this.btnExcelExport.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnExcelExport.TabIndex = 9;
            this.btnExcelExport.Text = "Excel Export";
            this.btnExcelExport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcelExport.UseSelectable = true;
            this.btnExcelExport.Click += new System.EventHandler(this.btnExcelExport_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(349, 51);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(78, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Start Date : ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(607, 49);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "To Period :";
            // 
            // btnLoad
            // 
            this.btnLoad.ActiveControl = null;
            this.btnLoad.Location = new System.Drawing.Point(871, 37);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(106, 39);
            this.btnLoad.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Location = new System.Drawing.Point(259, 53);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(89, 15);
            this.chkDate.TabIndex = 9;
            this.chkDate.Text = "Include Date";
            this.chkDate.UseSelectable = true;
            this.chkDate.CheckedChanged += new System.EventHandler(this.chkDate_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 49);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Employees : ";
            // 
            // EndDate
            // 
            this.EndDate.DisplayFocus = true;
            this.EndDate.Enabled = false;
            this.EndDate.Location = new System.Drawing.Point(688, 44);
            this.EndDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(168, 29);
            this.EndDate.TabIndex = 10;
            // 
            // StartDate
            // 
            this.StartDate.DisplayFocus = true;
            this.StartDate.Enabled = false;
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDate.Location = new System.Drawing.Point(436, 45);
            this.StartDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(168, 29);
            this.StartDate.TabIndex = 9;
            // 
            // frmSalesManLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 560);
            this.Controls.Add(this.grdTotalTransactions);
            this.Controls.Add(this.pnlPeriod);
            this.Name = "frmSalesManLedger";
            this.Text = "Sales Man Report";
            this.Load += new System.EventHandler(this.frmSalesManLedger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTotalTransactions)).EndInit();
            this.pnlPeriod.ResumeLayout(false);
            this.pnlPeriod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdTotalTransactions;
        private System.Windows.Forms.GroupBox pnlPeriod;
        private MetroFramework.Controls.MetroComboBox cbxEmployees;
        private MetroFramework.Controls.MetroTile btnExcelExport;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile btnLoad;
        private MetroFramework.Controls.MetroCheckBox chkDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime EndDate;
        private MetroFramework.Controls.MetroDateTime StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOpening;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalRecievables;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReturns;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReturnAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalRecieved;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClosing;
    }
}