namespace Accounts.UI
{
    partial class frmAgingReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAutoSize = new MetroFramework.Controls.MetroLabel();
            this.dtStart = new MetroFramework.Controls.MetroDateTime();
            this.dtEnd = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.btnExport = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.grdAging = new System.Windows.Forms.DataGridView();
            this.txtSearchPerson = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClosingBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastInvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastPaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastPaymentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLateDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdAging)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAutoSize
            // 
            this.lblAutoSize.Location = new System.Drawing.Point(27, 57);
            this.lblAutoSize.Name = "lblAutoSize";
            this.lblAutoSize.Size = new System.Drawing.Size(986, 23);
            this.lblAutoSize.TabIndex = 0;
            this.lblAutoSize.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "-";
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(105, 83);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(200, 29);
            this.dtStart.TabIndex = 1;
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(383, 83);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(200, 29);
            this.dtEnd.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(314, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "To Date :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 86);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "From Date :";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(609, 83);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(99, 29);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(711, 83);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(93, 28);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseSelectable = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(27, 115);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(992, 23);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "-";
            // 
            // grdAging
            // 
            this.grdAging.AllowUserToAddRows = false;
            this.grdAging.AllowUserToDeleteRows = false;
            this.grdAging.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAging.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdAging.ColumnHeadersHeight = 30;
            this.grdAging.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustomerName,
            this.colAddress,
            this.colClosingBalance,
            this.colTotalSales,
            this.colLastInvoiceDate,
            this.colLastPaymentDate,
            this.colLastPaymentAmount,
            this.colLateDays});
            this.grdAging.EnableHeadersVisualStyles = false;
            this.grdAging.GridColor = System.Drawing.Color.Linen;
            this.grdAging.Location = new System.Drawing.Point(23, 170);
            this.grdAging.Name = "grdAging";
            this.grdAging.ReadOnly = true;
            this.grdAging.RowHeadersVisible = false;
            this.grdAging.Size = new System.Drawing.Size(1066, 452);
            this.grdAging.TabIndex = 4;
            // 
            // txtSearchPerson
            // 
            // 
            // 
            // 
            this.txtSearchPerson.CustomButton.Image = null;
            this.txtSearchPerson.CustomButton.Location = new System.Drawing.Point(437, 1);
            this.txtSearchPerson.CustomButton.Name = "";
            this.txtSearchPerson.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchPerson.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchPerson.CustomButton.TabIndex = 1;
            this.txtSearchPerson.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchPerson.CustomButton.UseSelectable = true;
            this.txtSearchPerson.CustomButton.Visible = false;
            this.txtSearchPerson.Lines = new string[0];
            this.txtSearchPerson.Location = new System.Drawing.Point(105, 141);
            this.txtSearchPerson.MaxLength = 32767;
            this.txtSearchPerson.Name = "txtSearchPerson";
            this.txtSearchPerson.PasswordChar = '\0';
            this.txtSearchPerson.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchPerson.SelectedText = "";
            this.txtSearchPerson.SelectionLength = 0;
            this.txtSearchPerson.SelectionStart = 0;
            this.txtSearchPerson.ShortcutsEnabled = true;
            this.txtSearchPerson.Size = new System.Drawing.Size(459, 23);
            this.txtSearchPerson.TabIndex = 5;
            this.txtSearchPerson.UseSelectable = true;
            this.txtSearchPerson.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchPerson.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchPerson.TextChanged += new System.EventHandler(this.txtSearchPerson_TextChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 141);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(55, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Search :";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AccountName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn2.HeaderText = "Address";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ClosingBalance";
            this.dataGridViewTextBoxColumn3.HeaderText = "Balance";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CreatedDateTime";
            dataGridViewCellStyle4.Format = "d";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn4.HeaderText = "Last Invoice Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "VDate";
            dataGridViewCellStyle5.Format = "d";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn5.HeaderText = "Last Payment Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TransactionDays";
            this.dataGridViewTextBoxColumn6.HeaderText = "Credit Days";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TransactionDays";
            this.dataGridViewTextBoxColumn7.HeaderText = "Credit Days";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // colCustomerName
            // 
            this.colCustomerName.DataPropertyName = "AccountName";
            this.colCustomerName.HeaderText = "Customer Name";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.ReadOnly = true;
            this.colCustomerName.Width = 200;
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "Address";
            this.colAddress.HeaderText = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            this.colAddress.Width = 240;
            // 
            // colClosingBalance
            // 
            this.colClosingBalance.DataPropertyName = "ClosingBalance";
            this.colClosingBalance.HeaderText = "Balance";
            this.colClosingBalance.Name = "colClosingBalance";
            this.colClosingBalance.ReadOnly = true;
            this.colClosingBalance.Width = 80;
            // 
            // colTotalSales
            // 
            this.colTotalSales.DataPropertyName = "TotalSales";
            this.colTotalSales.HeaderText = "Total Sales";
            this.colTotalSales.Name = "colTotalSales";
            this.colTotalSales.ReadOnly = true;
            // 
            // colLastInvoiceDate
            // 
            this.colLastInvoiceDate.DataPropertyName = "CreatedDateTime";
            dataGridViewCellStyle2.Format = "d";
            this.colLastInvoiceDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colLastInvoiceDate.HeaderText = "Last Invoice Date";
            this.colLastInvoiceDate.Name = "colLastInvoiceDate";
            this.colLastInvoiceDate.ReadOnly = true;
            this.colLastInvoiceDate.Width = 120;
            // 
            // colLastPaymentDate
            // 
            this.colLastPaymentDate.DataPropertyName = "VDate";
            dataGridViewCellStyle3.Format = "d";
            this.colLastPaymentDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colLastPaymentDate.HeaderText = "Last Payment Date";
            this.colLastPaymentDate.Name = "colLastPaymentDate";
            this.colLastPaymentDate.ReadOnly = true;
            this.colLastPaymentDate.Width = 120;
            // 
            // colLastPaymentAmount
            // 
            this.colLastPaymentAmount.DataPropertyName = "Credit";
            this.colLastPaymentAmount.HeaderText = "Last Payment Amount";
            this.colLastPaymentAmount.Name = "colLastPaymentAmount";
            this.colLastPaymentAmount.ReadOnly = true;
            this.colLastPaymentAmount.Width = 120;
            // 
            // colLateDays
            // 
            this.colLateDays.DataPropertyName = "TransactionDays";
            this.colLateDays.HeaderText = "Credit Days";
            this.colLateDays.Name = "colLateDays";
            this.colLateDays.ReadOnly = true;
            this.colLateDays.Width = 80;
            // 
            // frmAgingReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1106, 662);
            this.Controls.Add(this.txtSearchPerson);
            this.Controls.Add(this.grdAging);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lblAutoSize);
            this.KeyPreview = true;
            this.Name = "frmAgingReport";
            this.Text = "Aging Report";
            this.Load += new System.EventHandler(this.frmAgingReport_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAgingReport_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.grdAging)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblAutoSize;
        private MetroFramework.Controls.MetroDateTime dtStart;
        private MetroFramework.Controls.MetroDateTime dtEnd;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnLoad;
        private MetroFramework.Controls.MetroButton btnExport;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridView grdAging;
        private MetroFramework.Controls.MetroTextBox txtSearchPerson;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClosingBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastInvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastPaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastPaymentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLateDays;
    }
}