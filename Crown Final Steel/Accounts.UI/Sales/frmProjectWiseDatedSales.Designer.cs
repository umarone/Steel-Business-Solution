namespace Accounts.UI
{
    partial class frmProjectWiseDatedSales
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
            this.pnlControls = new MetroFramework.Controls.MetroPanel();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtEnd = new MetroFramework.Controls.MetroDateTime();
            this.dtStart = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtDeliveryPerson = new MetroFramework.Controls.MetroTextBox();
            this.cbxInvoices = new MetroFramework.Controls.MetroComboBox();
            this.lblInvoices = new MetroFramework.Controls.MetroLabel();
            this.ChkCredit = new MetroFramework.Controls.MetroCheckBox();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportLedger
            // 
            this.ReportLedger.ActiveViewIndex = -1;
            this.ReportLedger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportLedger.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportLedger.Location = new System.Drawing.Point(3, 103);
            this.ReportLedger.Name = "ReportLedger";
            this.ReportLedger.Size = new System.Drawing.Size(912, 661);
            this.ReportLedger.TabIndex = 3;
            this.ReportLedger.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // pnlControls
            // 
            this.pnlControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControls.Controls.Add(this.ChkCredit);
            this.pnlControls.Controls.Add(this.metroLabel2);
            this.pnlControls.Controls.Add(this.dtEnd);
            this.pnlControls.Controls.Add(this.btnLoad);
            this.pnlControls.Controls.Add(this.dtStart);
            this.pnlControls.Controls.Add(this.metroLabel4);
            this.pnlControls.Controls.Add(this.metroLabel1);
            this.pnlControls.Controls.Add(this.txtDeliveryPerson);
            this.pnlControls.HorizontalScrollbarBarColor = true;
            this.pnlControls.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlControls.HorizontalScrollbarSize = 10;
            this.pnlControls.Location = new System.Drawing.Point(1, 11);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(914, 44);
            this.pnlControls.TabIndex = 2;
            this.pnlControls.VerticalScrollbarBarColor = true;
            this.pnlControls.VerticalScrollbarHighlightOnWheel = false;
            this.pnlControls.VerticalScrollbarSize = 10;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(813, 10);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(89, 23);
            this.btnLoad.TabIndex = 30;
            this.btnLoad.Text = "Load Report";
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(547, 10);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 19);
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = "To Date :";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(613, 5);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(106, 29);
            this.dtEnd.TabIndex = 29;
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(436, 5);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(104, 29);
            this.dtStart.TabIndex = 29;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(3, 8);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(111, 19);
            this.metroLabel4.TabIndex = 28;
            this.metroLabel4.Text = "Delivery Person :";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(354, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "From Date :";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // txtDeliveryPerson
            // 
            // 
            // 
            // 
            this.txtDeliveryPerson.CustomButton.Image = null;
            this.txtDeliveryPerson.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.txtDeliveryPerson.CustomButton.Name = "";
            this.txtDeliveryPerson.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDeliveryPerson.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDeliveryPerson.CustomButton.TabIndex = 1;
            this.txtDeliveryPerson.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDeliveryPerson.CustomButton.UseSelectable = true;
            this.txtDeliveryPerson.Lines = new string[0];
            this.txtDeliveryPerson.Location = new System.Drawing.Point(116, 8);
            this.txtDeliveryPerson.MaxLength = 32767;
            this.txtDeliveryPerson.Name = "txtDeliveryPerson";
            this.txtDeliveryPerson.PasswordChar = '\0';
            this.txtDeliveryPerson.PromptText = "Type Here To Select Delivery Person";
            this.txtDeliveryPerson.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDeliveryPerson.SelectedText = "";
            this.txtDeliveryPerson.SelectionLength = 0;
            this.txtDeliveryPerson.SelectionStart = 0;
            this.txtDeliveryPerson.ShortcutsEnabled = true;
            this.txtDeliveryPerson.ShowButton = true;
            this.txtDeliveryPerson.Size = new System.Drawing.Size(230, 23);
            this.txtDeliveryPerson.Style = MetroFramework.MetroColorStyle.Green;
            this.txtDeliveryPerson.TabIndex = 27;
            this.txtDeliveryPerson.UseSelectable = true;
            this.txtDeliveryPerson.WaterMark = "Type Here To Select Delivery Person";
            this.txtDeliveryPerson.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDeliveryPerson.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDeliveryPerson.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtDeliveryPerson_ButtonClick);
            this.txtDeliveryPerson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeliveryPerson_KeyPress);
            // 
            // cbxInvoices
            // 
            this.cbxInvoices.BackColor = System.Drawing.SystemColors.Info;
            this.cbxInvoices.FormattingEnabled = true;
            this.cbxInvoices.ItemHeight = 23;
            this.cbxInvoices.Location = new System.Drawing.Point(113, 63);
            this.cbxInvoices.Name = "cbxInvoices";
            this.cbxInvoices.Size = new System.Drawing.Size(331, 29);
            this.cbxInvoices.TabIndex = 4;
            this.cbxInvoices.UseCustomBackColor = true;
            this.cbxInvoices.UseSelectable = true;
            this.cbxInvoices.SelectedIndexChanged += new System.EventHandler(this.cbxInvoices_SelectedIndexChanged);
            // 
            // lblInvoices
            // 
            this.lblInvoices.AutoSize = true;
            this.lblInvoices.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblInvoices.Location = new System.Drawing.Point(3, 68);
            this.lblInvoices.Name = "lblInvoices";
            this.lblInvoices.Size = new System.Drawing.Size(109, 19);
            this.lblInvoices.TabIndex = 5;
            this.lblInvoices.Text = "Total Invoices :";
            // 
            // ChkCredit
            // 
            this.ChkCredit.AutoSize = true;
            this.ChkCredit.Location = new System.Drawing.Point(725, 12);
            this.ChkCredit.Name = "ChkCredit";
            this.ChkCredit.Size = new System.Drawing.Size(84, 15);
            this.ChkCredit.TabIndex = 6;
            this.ChkCredit.Text = "Credit Sales";
            this.ChkCredit.UseSelectable = true;
            // 
            // frmProjectWiseDatedSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 788);
            this.Controls.Add(this.lblInvoices);
            this.Controls.Add(this.cbxInvoices);
            this.Controls.Add(this.ReportLedger);
            this.Controls.Add(this.pnlControls);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProjectWiseDatedSales";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "frmProjectWiseDatedSales";
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportLedger;
        private MetroFramework.Controls.MetroPanel pnlControls;
        private MetroFramework.Controls.MetroButton btnLoad;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime dtEnd;
        private MetroFramework.Controls.MetroDateTime dtStart;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtDeliveryPerson;
        private MetroFramework.Controls.MetroComboBox cbxInvoices;
        private MetroFramework.Controls.MetroLabel lblInvoices;
        private MetroFramework.Controls.MetroCheckBox ChkCredit;
    }
}