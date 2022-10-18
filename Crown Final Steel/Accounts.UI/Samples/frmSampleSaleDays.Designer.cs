namespace Accounts.UI
{
    partial class frmSampleSaleDays
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.rdSales = new MetroFramework.Controls.MetroRadioButton();
            this.rdSamples = new MetroFramework.Controls.MetroRadioButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.cbxEmployees = new MetroFramework.Controls.MetroComboBox();
            this.chkEmployees = new MetroFramework.Controls.MetroCheckBox();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.grdRemaingDays = new System.Windows.Forms.DataGridView();
            this.colVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemainingDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colRecieved = new System.Windows.Forms.DataGridViewButtonColumn();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.chkDate = new MetroFramework.Controls.MetroCheckBox();
            this.dtEnd = new MetroFramework.Controls.MetroDateTime();
            this.dtStart = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnLoadByDate = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRemaingDays)).BeginInit();
            this.metroPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.rdSales);
            this.metroPanel1.Controls.Add(this.rdSamples);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(13, 28);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1032, 46);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // rdSales
            // 
            this.rdSales.AutoSize = true;
            this.rdSales.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rdSales.Location = new System.Drawing.Point(725, 11);
            this.rdSales.Name = "rdSales";
            this.rdSales.Size = new System.Drawing.Size(68, 25);
            this.rdSales.TabIndex = 2;
            this.rdSales.Text = "Sales";
            this.rdSales.UseSelectable = true;
            this.rdSales.CheckedChanged += new System.EventHandler(this.rdSamples_CheckedChanged);
            // 
            // rdSamples
            // 
            this.rdSamples.AutoSize = true;
            this.rdSamples.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rdSamples.Location = new System.Drawing.Point(87, 11);
            this.rdSamples.Name = "rdSamples";
            this.rdSamples.Size = new System.Drawing.Size(95, 25);
            this.rdSamples.TabIndex = 2;
            this.rdSamples.Text = "Samples";
            this.rdSamples.UseSelectable = true;
            this.rdSamples.CheckedChanged += new System.EventHandler(this.rdSamples_CheckedChanged);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.btnLoad);
            this.metroPanel2.Controls.Add(this.cbxEmployees);
            this.metroPanel2.Controls.Add(this.chkEmployees);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(13, 80);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1032, 46);
            this.metroPanel2.TabIndex = 0;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(432, 8);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(105, 29);
            this.btnLoad.TabIndex = 15;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cbxEmployees
            // 
            this.cbxEmployees.FormattingEnabled = true;
            this.cbxEmployees.ItemHeight = 23;
            this.cbxEmployees.Location = new System.Drawing.Point(183, 8);
            this.cbxEmployees.Name = "cbxEmployees";
            this.cbxEmployees.Size = new System.Drawing.Size(242, 29);
            this.cbxEmployees.TabIndex = 14;
            this.cbxEmployees.UseSelectable = true;
            // 
            // chkEmployees
            // 
            this.chkEmployees.AutoSize = true;
            this.chkEmployees.Location = new System.Drawing.Point(89, 14);
            this.chkEmployees.Name = "chkEmployees";
            this.chkEmployees.Size = new System.Drawing.Size(80, 15);
            this.chkEmployees.TabIndex = 2;
            this.chkEmployees.Text = "Employees";
            this.chkEmployees.UseSelectable = true;
            this.chkEmployees.CheckedChanged += new System.EventHandler(this.chkEmployees_CheckedChanged);
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.grdRemaingDays);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(13, 182);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(1032, 317);
            this.metroPanel3.TabIndex = 0;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // grdRemaingDays
            // 
            this.grdRemaingDays.AllowUserToAddRows = false;
            this.grdRemaingDays.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdRemaingDays.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdRemaingDays.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVoucherNo,
            this.ColDate,
            this.colAccountName,
            this.colTotalDays,
            this.colRemainingDays,
            this.colDetail,
            this.colRecieved});
            this.grdRemaingDays.EnableHeadersVisualStyles = false;
            this.grdRemaingDays.Location = new System.Drawing.Point(21, 3);
            this.grdRemaingDays.Name = "grdRemaingDays";
            this.grdRemaingDays.ReadOnly = true;
            this.grdRemaingDays.Size = new System.Drawing.Size(998, 300);
            this.grdRemaingDays.TabIndex = 2;
            this.grdRemaingDays.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRemaingDays_CellContentClick);
            this.grdRemaingDays.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdRemaingDays_CellFormatting);
            // 
            // colVoucherNo
            // 
            this.colVoucherNo.DataPropertyName = "VoucherNo";
            this.colVoucherNo.HeaderText = "Voucher No";
            this.colVoucherNo.Name = "colVoucherNo";
            this.colVoucherNo.ReadOnly = true;
            // 
            // ColDate
            // 
            this.ColDate.DataPropertyName = "Date";
            this.ColDate.HeaderText = "VDate";
            this.ColDate.Name = "ColDate";
            this.ColDate.ReadOnly = true;
            // 
            // colAccountName
            // 
            this.colAccountName.DataPropertyName = "AccountName";
            this.colAccountName.HeaderText = "Account Name";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.ReadOnly = true;
            this.colAccountName.Width = 300;
            // 
            // colTotalDays
            // 
            this.colTotalDays.DataPropertyName = "Transactiondays";
            this.colTotalDays.HeaderText = "Total Days";
            this.colTotalDays.Name = "colTotalDays";
            this.colTotalDays.ReadOnly = true;
            this.colTotalDays.Width = 120;
            // 
            // colRemainingDays
            // 
            this.colRemainingDays.DataPropertyName = "RemainingDays";
            this.colRemainingDays.HeaderText = "Remaining Days";
            this.colRemainingDays.Name = "colRemainingDays";
            this.colRemainingDays.ReadOnly = true;
            this.colRemainingDays.Width = 120;
            // 
            // colDetail
            // 
            this.colDetail.HeaderText = ".";
            this.colDetail.Name = "colDetail";
            this.colDetail.ReadOnly = true;
            // 
            // colRecieved
            // 
            this.colRecieved.HeaderText = "..";
            this.colRecieved.Name = "colRecieved";
            this.colRecieved.ReadOnly = true;
            // 
            // metroPanel4
            // 
            this.metroPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel4.Controls.Add(this.metroLabel2);
            this.metroPanel4.Controls.Add(this.metroLabel1);
            this.metroPanel4.Controls.Add(this.btnLoadByDate);
            this.metroPanel4.Controls.Add(this.dtStart);
            this.metroPanel4.Controls.Add(this.dtEnd);
            this.metroPanel4.Controls.Add(this.chkDate);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(13, 130);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(1032, 46);
            this.metroPanel4.TabIndex = 1;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Location = new System.Drawing.Point(87, 12);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(92, 15);
            this.chkDate.TabIndex = 2;
            this.chkDate.Text = "Include Date ";
            this.chkDate.UseSelectable = true;
            this.chkDate.CheckedChanged += new System.EventHandler(this.chkDate_CheckedChanged);
            // 
            // dtEnd
            // 
            this.dtEnd.Enabled = false;
            this.dtEnd.Location = new System.Drawing.Point(657, 7);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(200, 29);
            this.dtEnd.TabIndex = 3;
            // 
            // dtStart
            // 
            this.dtStart.Enabled = false;
            this.dtStart.Location = new System.Drawing.Point(286, 7);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(200, 29);
            this.dtStart.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(232, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "From :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(620, 12);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(31, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "To :";
            // 
            // btnLoadByDate
            // 
            this.btnLoadByDate.Location = new System.Drawing.Point(890, 7);
            this.btnLoadByDate.Name = "btnLoadByDate";
            this.btnLoadByDate.Size = new System.Drawing.Size(105, 29);
            this.btnLoadByDate.TabIndex = 15;
            this.btnLoadByDate.Text = "Load";
            this.btnLoadByDate.UseSelectable = true;
            this.btnLoadByDate.Click += new System.EventHandler(this.btnLoadByDate_Click);
            // 
            // frmSampleSaleDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 516);
            this.Controls.Add(this.metroPanel4);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmSampleSaleDays";
            this.Load += new System.EventHandler(this.frmSampleSaleDays_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdRemaingDays)).EndInit();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroRadioButton rdSales;
        private MetroFramework.Controls.MetroRadioButton rdSamples;
        private System.Windows.Forms.DataGridView grdRemaingDays;
        private MetroFramework.Controls.MetroCheckBox chkEmployees;
        private MetroFramework.Controls.MetroComboBox cbxEmployees;
        private MetroFramework.Controls.MetroButton btnLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemainingDays;
        private System.Windows.Forms.DataGridViewButtonColumn colDetail;
        private System.Windows.Forms.DataGridViewButtonColumn colRecieved;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dtStart;
        private MetroFramework.Controls.MetroDateTime dtEnd;
        private MetroFramework.Controls.MetroCheckBox chkDate;
        private MetroFramework.Controls.MetroButton btnLoadByDate;
    }
}