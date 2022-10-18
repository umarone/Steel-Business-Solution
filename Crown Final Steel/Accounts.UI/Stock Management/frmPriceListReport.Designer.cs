namespace Accounts.UI
{
    partial class frmPriceListReport
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
            this.PriceListViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // PriceListViewer
            // 
            this.PriceListViewer.ActiveViewIndex = -1;
            this.PriceListViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceListViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.PriceListViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceListViewer.Location = new System.Drawing.Point(0, 0);
            this.PriceListViewer.Name = "PriceListViewer";
            this.PriceListViewer.Size = new System.Drawing.Size(744, 468);
            this.PriceListViewer.TabIndex = 0;
            this.PriceListViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmPriceListReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(744, 468);
            this.Controls.Add(this.PriceListViewer);
            this.Name = "frmPriceListReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Price List Report";
            this.Load += new System.EventHandler(this.frmPriceListReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer PriceListViewer;
    }
}