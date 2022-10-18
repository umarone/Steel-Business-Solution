namespace Accounts.UI
{
    partial class frmMonthlyPurchasesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonthlyPurchasesReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.chkNet = new MetroFramework.Controls.MetroCheckBox();
            this.chkCredit = new MetroFramework.Controls.MetroCheckBox();
            this.dtEnd = new MetroFramework.Controls.MetroDateTime();
            this.dtStart = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.grdMonthlyReports = new Accounts.UI.CustomDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcelExport = new MetroFramework.Controls.MetroButton();
            this.chkSummary = new MetroFramework.Controls.MetroCheckBox();
            this.colAccountNo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdMonthlyReports)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(799, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // chkNet
            // 
            this.chkNet.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkNet.Location = new System.Drawing.Point(334, 70);
            this.chkNet.Name = "chkNet";
            this.chkNet.Size = new System.Drawing.Size(113, 24);
            this.chkNet.TabIndex = 3;
            this.chkNet.Text = "Net";
            this.chkNet.UseSelectable = true;
            this.chkNet.CheckedChanged += new System.EventHandler(this.chkNet_CheckedChanged);
            // 
            // chkCredit
            // 
            this.chkCredit.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkCredit.Location = new System.Drawing.Point(460, 70);
            this.chkCredit.Name = "chkCredit";
            this.chkCredit.Size = new System.Drawing.Size(132, 29);
            this.chkCredit.TabIndex = 3;
            this.chkCredit.Text = "Credit";
            this.chkCredit.UseSelectable = true;
            this.chkCredit.CheckedChanged += new System.EventHandler(this.chkCredit_CheckedChanged);
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(220, 68);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(110, 29);
            this.dtEnd.TabIndex = 4;
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(76, 69);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(106, 29);
            this.dtStart.TabIndex = 4;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "From :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(186, 74);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(31, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "To :";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(662, 73);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(85, 23);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(799, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // grdMonthlyReports
            // 
            this.grdMonthlyReports.AllowUserToAddRows = false;
            this.grdMonthlyReports.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdMonthlyReports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grdMonthlyReports.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMonthlyReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdMonthlyReports.ColumnHeadersHeight = 25;
            this.grdMonthlyReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAccountNo,
            this.colAccountName,
            this.colTotalAmount,
            this.colDetail});
            this.grdMonthlyReports.EnableHeadersVisualStyles = false;
            this.grdMonthlyReports.Location = new System.Drawing.Point(28, 118);
            this.grdMonthlyReports.Name = "grdMonthlyReports";
            this.grdMonthlyReports.ReadOnly = true;
            this.grdMonthlyReports.RowHeadersVisible = false;
            this.grdMonthlyReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMonthlyReports.Size = new System.Drawing.Size(798, 455);
            this.grdMonthlyReports.TabIndex = 2;
            this.grdMonthlyReports.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMonthlyReports_CellClick);
            this.grdMonthlyReports.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdMonthlyReports_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AccountName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Account Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 430;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TotalAmount";
            this.dataGridViewTextBoxColumn2.HeaderText = "Total Amount";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.Location = new System.Drawing.Point(753, 73);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(71, 23);
            this.btnExcelExport.TabIndex = 14;
            this.btnExcelExport.Text = "Excel Export";
            this.btnExcelExport.UseSelectable = true;
            // 
            // chkSummary
            // 
            this.chkSummary.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkSummary.Location = new System.Drawing.Point(606, 73);
            this.chkSummary.Name = "chkSummary";
            this.chkSummary.Size = new System.Drawing.Size(50, 29);
            this.chkSummary.TabIndex = 3;
            this.chkSummary.Text = "ALL";
            this.chkSummary.UseSelectable = true;
            this.chkSummary.CheckedChanged += new System.EventHandler(this.chkSummary_CheckedChanged);
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
            this.colAccountName.HeaderText = "Account Name";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.ReadOnly = true;
            this.colAccountName.Width = 550;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.DataPropertyName = "TotalAmount";
            this.colTotalAmount.HeaderText = "Total Amount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.ReadOnly = true;
            this.colTotalAmount.Width = 130;
            // 
            // colDetail
            // 
            this.colDetail.HeaderText = "...";
            this.colDetail.Name = "colDetail";
            this.colDetail.ReadOnly = true;
            // 
            // frmMonthlyPurchasesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 606);
            this.Controls.Add(this.btnExcelExport);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.chkSummary);
            this.Controls.Add(this.chkCredit);
            this.Controls.Add(this.chkNet);
            this.Controls.Add(this.grdMonthlyReports);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMonthlyPurchasesReport";
            this.Text = "Monthly Purchases / Sales Report";
            this.Load += new System.EventHandler(this.frmMonthlyPurchasesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMonthlyReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomDataGrid grdMonthlyReports;
        private MetroFramework.Controls.MetroCheckBox chkNet;
        private MetroFramework.Controls.MetroCheckBox chkCredit;
        private MetroFramework.Controls.MetroDateTime dtEnd;
        private MetroFramework.Controls.MetroDateTime dtStart;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private MetroFramework.Controls.MetroButton btnExcelExport;
        private MetroFramework.Controls.MetroCheckBox chkSummary;
        private System.Windows.Forms.DataGridViewButtonColumn colAccountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalAmount;
        private System.Windows.Forms.DataGridViewButtonColumn colDetail;
    }
}