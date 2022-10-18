namespace Accounts.UI
{
    partial class frmClosingBalancesReports
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
            this.lblDashed = new MetroFramework.Controls.MetroLabel();
            this.pnlPeriod = new System.Windows.Forms.GroupBox();
            this.lblToPeriod = new MetroFramework.Controls.MetroLabel();
            this.lblStartPeriod = new MetroFramework.Controls.MetroLabel();
            this.chkDate = new MetroFramework.Controls.MetroCheckBox();
            this.EndDate = new MetroFramework.Controls.MetroDateTime();
            this.StartDate = new MetroFramework.Controls.MetroDateTime();
            this.pnlTypes = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbxCategories = new MetroFramework.Controls.MetroComboBox();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.pnlflowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.chkByType = new MetroFramework.Controls.MetroCheckBox();
            this.chkHeadWise = new MetroFramework.Controls.MetroCheckBox();
            this.pnlHeads = new MetroFramework.Controls.MetroPanel();
            this.CbxHeadsLevel3 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.CbxHeadsLevel1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.CbxHeadsLevel2 = new MetroFramework.Controls.MetroComboBox();
            this.pnlPrint = new MetroFramework.Controls.MetroPanel();
            this.pnlPeriod.SuspendLayout();
            this.pnlTypes.SuspendLayout();
            this.pnlflowLayout.SuspendLayout();
            this.pnlHeads.SuspendLayout();
            this.pnlPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDashed
            // 
            this.lblDashed.Location = new System.Drawing.Point(24, 55);
            this.lblDashed.Name = "lblDashed";
            this.lblDashed.Size = new System.Drawing.Size(782, 19);
            this.lblDashed.TabIndex = 0;
            this.lblDashed.Text = "---------------------------------------------------------------------------------" +
    "---------------------------------------------------";
            // 
            // pnlPeriod
            // 
            this.pnlPeriod.BackColor = System.Drawing.Color.MistyRose;
            this.pnlPeriod.Controls.Add(this.lblToPeriod);
            this.pnlPeriod.Controls.Add(this.lblStartPeriod);
            this.pnlPeriod.Controls.Add(this.chkDate);
            this.pnlPeriod.Controls.Add(this.EndDate);
            this.pnlPeriod.Controls.Add(this.StartDate);
            this.pnlPeriod.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPeriod.ForeColor = System.Drawing.Color.Black;
            this.pnlPeriod.Location = new System.Drawing.Point(3, 3);
            this.pnlPeriod.Name = "pnlPeriod";
            this.pnlPeriod.Size = new System.Drawing.Size(780, 62);
            this.pnlPeriod.TabIndex = 7;
            this.pnlPeriod.TabStop = false;
            this.pnlPeriod.Text = "Periodic Ledger";
            // 
            // lblToPeriod
            // 
            this.lblToPeriod.AutoSize = true;
            this.lblToPeriod.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblToPeriod.Location = new System.Drawing.Point(353, 25);
            this.lblToPeriod.Name = "lblToPeriod";
            this.lblToPeriod.Size = new System.Drawing.Size(74, 19);
            this.lblToPeriod.TabIndex = 8;
            this.lblToPeriod.Text = "To Period :";
            this.lblToPeriod.UseCustomBackColor = true;
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
            this.lblStartPeriod.UseCustomBackColor = true;
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Location = new System.Drawing.Point(667, 29);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(89, 15);
            this.chkDate.TabIndex = 8;
            this.chkDate.Text = "Include Date";
            this.chkDate.UseCustomBackColor = true;
            this.chkDate.UseSelectable = true;
            // 
            // EndDate
            // 
            this.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDate.Location = new System.Drawing.Point(433, 22);
            this.EndDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(227, 29);
            this.EndDate.TabIndex = 8;
            // 
            // StartDate
            // 
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDate.Location = new System.Drawing.Point(110, 22);
            this.StartDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(237, 29);
            this.StartDate.TabIndex = 8;
            // 
            // pnlTypes
            // 
            this.pnlTypes.BackColor = System.Drawing.Color.RosyBrown;
            this.pnlTypes.Controls.Add(this.metroLabel1);
            this.pnlTypes.Controls.Add(this.cbxCategories);
            this.pnlTypes.Location = new System.Drawing.Point(3, 113);
            this.pnlTypes.Name = "pnlTypes";
            this.pnlTypes.Size = new System.Drawing.Size(780, 34);
            this.pnlTypes.TabIndex = 8;
            this.pnlTypes.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 7);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Select Type :";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // cbxCategories
            // 
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.ItemHeight = 23;
            this.cbxCategories.Items.AddRange(new object[] {
            "Select Category",
            "Accounts Recieveables / Customers",
            "Accounts Payables",
            "Cash Accounts",
            "Bank Accounts"});
            this.cbxCategories.Location = new System.Drawing.Point(88, 4);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(259, 29);
            this.cbxCategories.Style = MetroFramework.MetroColorStyle.Silver;
            this.cbxCategories.TabIndex = 8;
            this.cbxCategories.UseSelectable = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(634, 7);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(144, 29);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pnlflowLayout
            // 
            this.pnlflowLayout.AutoSize = true;
            this.pnlflowLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlflowLayout.Controls.Add(this.pnlPeriod);
            this.pnlflowLayout.Controls.Add(this.chkByType);
            this.pnlflowLayout.Controls.Add(this.chkHeadWise);
            this.pnlflowLayout.Controls.Add(this.pnlTypes);
            this.pnlflowLayout.Controls.Add(this.pnlHeads);
            this.pnlflowLayout.Controls.Add(this.pnlPrint);
            this.pnlflowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlflowLayout.Location = new System.Drawing.Point(23, 77);
            this.pnlflowLayout.Name = "pnlflowLayout";
            this.pnlflowLayout.Size = new System.Drawing.Size(786, 247);
            this.pnlflowLayout.TabIndex = 9;
            // 
            // chkByType
            // 
            this.chkByType.AutoSize = true;
            this.chkByType.Location = new System.Drawing.Point(3, 71);
            this.chkByType.Name = "chkByType";
            this.chkByType.Size = new System.Drawing.Size(153, 15);
            this.chkByType.TabIndex = 10;
            this.chkByType.Text = "By Simple Type Balances";
            this.chkByType.UseSelectable = true;
            this.chkByType.CheckedChanged += new System.EventHandler(this.chkByType_CheckedChanged);
            // 
            // chkHeadWise
            // 
            this.chkHeadWise.AutoSize = true;
            this.chkHeadWise.Location = new System.Drawing.Point(3, 92);
            this.chkHeadWise.Name = "chkHeadWise";
            this.chkHeadWise.Size = new System.Drawing.Size(134, 15);
            this.chkHeadWise.TabIndex = 10;
            this.chkHeadWise.Text = "Head Based Balances";
            this.chkHeadWise.UseSelectable = true;
            this.chkHeadWise.CheckedChanged += new System.EventHandler(this.chkHeadWise_CheckedChanged);
            // 
            // pnlHeads
            // 
            this.pnlHeads.BackColor = System.Drawing.Color.IndianRed;
            this.pnlHeads.Controls.Add(this.CbxHeadsLevel3);
            this.pnlHeads.Controls.Add(this.metroLabel4);
            this.pnlHeads.Controls.Add(this.CbxHeadsLevel1);
            this.pnlHeads.Controls.Add(this.metroLabel2);
            this.pnlHeads.Controls.Add(this.metroLabel3);
            this.pnlHeads.Controls.Add(this.CbxHeadsLevel2);
            this.pnlHeads.HorizontalScrollbarBarColor = true;
            this.pnlHeads.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlHeads.HorizontalScrollbarSize = 10;
            this.pnlHeads.Location = new System.Drawing.Point(3, 153);
            this.pnlHeads.Name = "pnlHeads";
            this.pnlHeads.Size = new System.Drawing.Size(780, 43);
            this.pnlHeads.TabIndex = 10;
            this.pnlHeads.UseCustomBackColor = true;
            this.pnlHeads.VerticalScrollbarBarColor = true;
            this.pnlHeads.VerticalScrollbarHighlightOnWheel = false;
            this.pnlHeads.VerticalScrollbarSize = 10;
            this.pnlHeads.Visible = false;
            // 
            // CbxHeadsLevel3
            // 
            this.CbxHeadsLevel3.FormattingEnabled = true;
            this.CbxHeadsLevel3.ItemHeight = 23;
            this.CbxHeadsLevel3.Location = new System.Drawing.Point(546, 8);
            this.CbxHeadsLevel3.Name = "CbxHeadsLevel3";
            this.CbxHeadsLevel3.Size = new System.Drawing.Size(231, 29);
            this.CbxHeadsLevel3.Style = MetroFramework.MetroColorStyle.Silver;
            this.CbxHeadsLevel3.TabIndex = 13;
            this.CbxHeadsLevel3.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(482, 11);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Level 3 :";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(246, 17);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Level 2 :";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // CbxHeadsLevel1
            // 
            this.CbxHeadsLevel1.FormattingEnabled = true;
            this.CbxHeadsLevel1.ItemHeight = 23;
            this.CbxHeadsLevel1.Location = new System.Drawing.Point(69, 7);
            this.CbxHeadsLevel1.Name = "CbxHeadsLevel1";
            this.CbxHeadsLevel1.Size = new System.Drawing.Size(171, 29);
            this.CbxHeadsLevel1.Style = MetroFramework.MetroColorStyle.Silver;
            this.CbxHeadsLevel1.TabIndex = 12;
            this.CbxHeadsLevel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CbxHeadsLevel1.UseSelectable = true;
            this.CbxHeadsLevel1.SelectedIndexChanged += new System.EventHandler(this.CbxHeads_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(6, 11);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Level 1 :";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // CbxHeadsLevel2
            // 
            this.CbxHeadsLevel2.FormattingEnabled = true;
            this.CbxHeadsLevel2.ItemHeight = 23;
            this.CbxHeadsLevel2.Location = new System.Drawing.Point(307, 8);
            this.CbxHeadsLevel2.Name = "CbxHeadsLevel2";
            this.CbxHeadsLevel2.Size = new System.Drawing.Size(169, 29);
            this.CbxHeadsLevel2.Style = MetroFramework.MetroColorStyle.Silver;
            this.CbxHeadsLevel2.TabIndex = 11;
            this.CbxHeadsLevel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CbxHeadsLevel2.UseSelectable = true;
            this.CbxHeadsLevel2.SelectedIndexChanged += new System.EventHandler(this.CbxHeads_SelectedIndexChanged);
            // 
            // pnlPrint
            // 
            this.pnlPrint.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlPrint.Controls.Add(this.btnPrint);
            this.pnlPrint.HorizontalScrollbarBarColor = true;
            this.pnlPrint.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlPrint.HorizontalScrollbarSize = 10;
            this.pnlPrint.Location = new System.Drawing.Point(3, 202);
            this.pnlPrint.Name = "pnlPrint";
            this.pnlPrint.Size = new System.Drawing.Size(780, 42);
            this.pnlPrint.TabIndex = 10;
            this.pnlPrint.UseCustomBackColor = true;
            this.pnlPrint.VerticalScrollbarBarColor = true;
            this.pnlPrint.VerticalScrollbarHighlightOnWheel = false;
            this.pnlPrint.VerticalScrollbarSize = 10;
            // 
            // frmClosingBalancesReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(832, 334);
            this.Controls.Add(this.pnlflowLayout);
            this.Controls.Add(this.lblDashed);
            this.Name = "frmClosingBalancesReports";
            this.Text = "Financial Closing Balances";
            this.Load += new System.EventHandler(this.frmClosingBalancesReports_Load);
            this.pnlPeriod.ResumeLayout(false);
            this.pnlPeriod.PerformLayout();
            this.pnlTypes.ResumeLayout(false);
            this.pnlTypes.PerformLayout();
            this.pnlflowLayout.ResumeLayout(false);
            this.pnlflowLayout.PerformLayout();
            this.pnlHeads.ResumeLayout(false);
            this.pnlHeads.PerformLayout();
            this.pnlPrint.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblDashed;
        private System.Windows.Forms.GroupBox pnlPeriod;
        private MetroFramework.Controls.MetroLabel lblToPeriod;
        private MetroFramework.Controls.MetroLabel lblStartPeriod;
        private MetroFramework.Controls.MetroCheckBox chkDate;
        private MetroFramework.Controls.MetroDateTime EndDate;
        private MetroFramework.Controls.MetroDateTime StartDate;
        private System.Windows.Forms.Panel pnlTypes;
        private MetroFramework.Controls.MetroButton btnPrint;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbxCategories;
        private System.Windows.Forms.FlowLayoutPanel pnlflowLayout;
        private MetroFramework.Controls.MetroCheckBox chkByType;
        private MetroFramework.Controls.MetroCheckBox chkHeadWise;
        private MetroFramework.Controls.MetroPanel pnlHeads;
        private MetroFramework.Controls.MetroComboBox CbxHeadsLevel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox CbxHeadsLevel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox CbxHeadsLevel2;
        private MetroFramework.Controls.MetroPanel pnlPrint;
    }
}