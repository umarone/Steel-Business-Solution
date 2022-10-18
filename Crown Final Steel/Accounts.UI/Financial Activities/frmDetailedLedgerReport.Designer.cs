namespace Accounts.UI
{
    partial class frmDetailedLedgerReport
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
            this.DetailedReportLedgerViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // DetailedReportLedgerViewer
            // 
            this.DetailedReportLedgerViewer.ActiveViewIndex = -1;
            this.DetailedReportLedgerViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DetailedReportLedgerViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.DetailedReportLedgerViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailedReportLedgerViewer.Location = new System.Drawing.Point(0, 0);
            this.DetailedReportLedgerViewer.Name = "DetailedReportLedgerViewer";
            this.DetailedReportLedgerViewer.Size = new System.Drawing.Size(592, 398);
            this.DetailedReportLedgerViewer.TabIndex = 0;
            this.DetailedReportLedgerViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmDetailedLedgerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 398);
            this.Controls.Add(this.DetailedReportLedgerViewer);
            this.Name = "frmDetailedLedgerReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detailed Report View";
            this.Load += new System.EventHandler(this.frmDetailedLedgerReport_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmDetailedLedgerReport_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer DetailedReportLedgerViewer;
    }
}