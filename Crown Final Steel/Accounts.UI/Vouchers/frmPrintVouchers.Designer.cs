namespace Accounts.UI
{
    partial class frmPrintVouchers
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
            this.VouchersViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // VouchersViewer
            // 
            this.VouchersViewer.ActiveViewIndex = -1;
            this.VouchersViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VouchersViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.VouchersViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VouchersViewer.Location = new System.Drawing.Point(0, 0);
            this.VouchersViewer.Name = "VouchersViewer";
            this.VouchersViewer.ShowGroupTreeButton = false;
            this.VouchersViewer.ShowParameterPanelButton = false;
            this.VouchersViewer.ShowZoomButton = false;
            this.VouchersViewer.Size = new System.Drawing.Size(464, 380);
            this.VouchersViewer.TabIndex = 0;
            this.VouchersViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmPrintVouchers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 380);
            this.Controls.Add(this.VouchersViewer);
            this.Name = "frmPrintVouchers";
            this.Text = "Print Vouchers";
            this.Load += new System.EventHandler(this.frmPrintVouchers_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPrintVouchers_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer VouchersViewer;
    }
}