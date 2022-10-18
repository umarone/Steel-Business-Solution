namespace Accounts.UI
{
    partial class frmFifoAgingReport
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
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.cragingreportviewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(530, 29);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(95, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Me";
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cragingreportviewer
            // 
            this.cragingreportviewer.ActiveViewIndex = -1;
            this.cragingreportviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cragingreportviewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.cragingreportviewer.Location = new System.Drawing.Point(3, 58);
            this.cragingreportviewer.Name = "cragingreportviewer";
            this.cragingreportviewer.ShowGroupTreeButton = false;
            this.cragingreportviewer.Size = new System.Drawing.Size(625, 521);
            this.cragingreportviewer.TabIndex = 1;
            this.cragingreportviewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmFifoAgingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 602);
            this.Controls.Add(this.cragingreportviewer);
            this.Controls.Add(this.btnLoad);
            this.Name = "frmFifoAgingReport";
            this.Text = "Fifo Aging Report";
            this.Load += new System.EventHandler(this.frmFifoAgingReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLoad;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cragingreportviewer;
    }
}