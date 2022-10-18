namespace Accounts.UI
{
    partial class frmLedgerreport
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
            this.ReportLedger = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ReportLedger
            // 
            this.ReportLedger.ActiveViewIndex = -1;
            this.ReportLedger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportLedger.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportLedger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportLedger.Location = new System.Drawing.Point(0, 0);
            this.ReportLedger.Name = "ReportLedger";
            this.ReportLedger.Size = new System.Drawing.Size(284, 262);
            this.ReportLedger.TabIndex = 0;
            this.ReportLedger.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmLedgerreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ReportLedger);
            this.Name = "frmLedgerreport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmLedgerreport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLedgerreport_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmLedgerreport_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportLedger;
    }
}