namespace Accounts.UI
{
    partial class frmAccountsBalanceReport
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
            this.AccountsReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // AccountsReport
            // 
            this.AccountsReport.ActiveViewIndex = -1;
            this.AccountsReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountsReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.AccountsReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountsReport.Location = new System.Drawing.Point(0, 0);
            this.AccountsReport.Name = "AccountsReport";
            this.AccountsReport.Size = new System.Drawing.Size(694, 448);
            this.AccountsReport.TabIndex = 0;
            this.AccountsReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmAccountsBalanceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 448);
            this.Controls.Add(this.AccountsReport);
            this.Name = "frmAccountsBalanceReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounts Balance Report";
            this.Load += new System.EventHandler(this.frmAccountsBalanceReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer AccountsReport;
    }
}