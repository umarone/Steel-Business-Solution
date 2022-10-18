namespace Accounts.UI
{
    partial class frmDetailedJournalLedger
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
            this.pnlPeriod = new System.Windows.Forms.GroupBox();
            this.lblToPeriod = new MetroFramework.Controls.MetroLabel();
            this.lblStartPeriod = new MetroFramework.Controls.MetroLabel();
            this.chkDate = new MetroFramework.Controls.MetroCheckBox();
            this.chkClosingReport = new MetroFramework.Controls.MetroCheckBox();
            this.EndDate = new MetroFramework.Controls.MetroDateTime();
            this.StartDate = new MetroFramework.Controls.MetroDateTime();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbxCategories = new MetroFramework.Controls.MetroComboBox();
            this.pnlPeriod.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPeriod
            // 
            this.pnlPeriod.BackColor = System.Drawing.Color.White;
            this.pnlPeriod.Controls.Add(this.lblToPeriod);
            this.pnlPeriod.Controls.Add(this.lblStartPeriod);
            this.pnlPeriod.Controls.Add(this.chkDate);
            this.pnlPeriod.Controls.Add(this.chkClosingReport);
            this.pnlPeriod.Controls.Add(this.EndDate);
            this.pnlPeriod.Controls.Add(this.StartDate);
            this.pnlPeriod.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPeriod.ForeColor = System.Drawing.Color.Black;
            this.pnlPeriod.Location = new System.Drawing.Point(4, 76);
            this.pnlPeriod.Name = "pnlPeriod";
            this.pnlPeriod.Size = new System.Drawing.Size(780, 62);
            this.pnlPeriod.TabIndex = 6;
            this.pnlPeriod.TabStop = false;
            this.pnlPeriod.Text = "Periodic Ledger";
            // 
            // lblToPeriod
            // 
            this.lblToPeriod.AutoSize = true;
            this.lblToPeriod.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblToPeriod.Location = new System.Drawing.Point(269, 25);
            this.lblToPeriod.Name = "lblToPeriod";
            this.lblToPeriod.Size = new System.Drawing.Size(74, 19);
            this.lblToPeriod.TabIndex = 8;
            this.lblToPeriod.Text = "To Period :";
            // 
            // lblStartPeriod
            // 
            this.lblStartPeriod.AutoSize = true;
            this.lblStartPeriod.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblStartPeriod.Location = new System.Drawing.Point(14, 25);
            this.lblStartPeriod.Name = "lblStartPeriod";
            this.lblStartPeriod.Size = new System.Drawing.Size(88, 19);
            this.lblStartPeriod.TabIndex = 8;
            this.lblStartPeriod.Text = "Start Period :";
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Location = new System.Drawing.Point(666, 29);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(89, 15);
            this.chkDate.TabIndex = 8;
            this.chkDate.Text = "Include Date";
            this.chkDate.UseSelectable = true;
            // 
            // chkClosingReport
            // 
            this.chkClosingReport.AutoSize = true;
            this.chkClosingReport.Location = new System.Drawing.Point(508, 29);
            this.chkClosingReport.Name = "chkClosingReport";
            this.chkClosingReport.Size = new System.Drawing.Size(145, 15);
            this.chkClosingReport.TabIndex = 8;
            this.chkClosingReport.Text = "Closing Balance Report";
            this.chkClosingReport.UseSelectable = true;
            // 
            // EndDate
            // 
            this.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDate.Location = new System.Drawing.Point(349, 22);
            this.EndDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(144, 29);
            this.EndDate.TabIndex = 8;
            // 
            // StartDate
            // 
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDate.Location = new System.Drawing.Point(110, 22);
            this.StartDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(144, 29);
            this.StartDate.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.cbxCategories);
            this.panel1.Location = new System.Drawing.Point(4, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 34);
            this.panel1.TabIndex = 7;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(349, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(144, 29);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(14, 7);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Select Type :";
            // 
            // cbxCategories
            // 
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.ItemHeight = 23;
            this.cbxCategories.Items.AddRange(new object[] {
            "Select Category",
            "Accounts Recieveables",
            "Accounts Payables",
            "Cash & Bank Balances"});
            this.cbxCategories.Location = new System.Drawing.Point(110, 4);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(190, 29);
            this.cbxCategories.Style = MetroFramework.MetroColorStyle.Silver;
            this.cbxCategories.TabIndex = 8;
            this.cbxCategories.UseSelectable = true;
            // 
            // frmDetailedJournalLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 222);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPeriod);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "frmDetailedJournalLedger";
            this.Text = "Detailed Ledger Reports";
            this.Load += new System.EventHandler(this.frmDetailedJournalLedger_Load);
            this.pnlPeriod.ResumeLayout(false);
            this.pnlPeriod.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pnlPeriod;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroDateTime StartDate;
        private MetroFramework.Controls.MetroDateTime EndDate;
        private MetroFramework.Controls.MetroLabel lblToPeriod;
        private MetroFramework.Controls.MetroLabel lblStartPeriod;
        private MetroFramework.Controls.MetroCheckBox chkDate;
        private MetroFramework.Controls.MetroCheckBox chkClosingReport;
        private MetroFramework.Controls.MetroButton btnPrint;
        private MetroFramework.Controls.MetroComboBox cbxCategories;
        private MetroFramework.Controls.MetroLabel metroLabel1;

    }
}