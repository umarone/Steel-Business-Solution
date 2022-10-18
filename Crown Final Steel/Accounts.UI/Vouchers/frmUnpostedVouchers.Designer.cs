namespace Accounts.UI
{
    partial class frmUnpostedVouchers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUnpostedVouchers = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tlJournal = new MetroFramework.Controls.MetroTile();
            this.tlPurchases = new MetroFramework.Controls.MetroTile();
            this.tlSaleReturn = new MetroFramework.Controls.MetroTile();
            this.tlSale = new MetroFramework.Controls.MetroTile();
            this.tlBankPayment = new MetroFramework.Controls.MetroTile();
            this.tlBankReceipt = new MetroFramework.Controls.MetroTile();
            this.tlCashPayment = new MetroFramework.Controls.MetroTile();
            this.tlCashReceipt = new MetroFramework.Controls.MetroTile();
            this.lblVoucherName = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnpostedVouchers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUnpostedVouchers
            // 
            this.dgvUnpostedVouchers.AllowUserToAddRows = false;
            this.dgvUnpostedVouchers.AllowUserToDeleteRows = false;
            this.dgvUnpostedVouchers.BackgroundColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnpostedVouchers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUnpostedVouchers.ColumnHeadersHeight = 26;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnpostedVouchers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUnpostedVouchers.EnableHeadersVisualStyles = false;
            this.dgvUnpostedVouchers.Location = new System.Drawing.Point(2, 4);
            this.dgvUnpostedVouchers.Name = "dgvUnpostedVouchers";
            this.dgvUnpostedVouchers.ReadOnly = true;
            this.dgvUnpostedVouchers.RowHeadersVisible = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvUnpostedVouchers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUnpostedVouchers.Size = new System.Drawing.Size(804, 423);
            this.dgvUnpostedVouchers.TabIndex = 0;
            this.dgvUnpostedVouchers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnpostedVouchers_CellClick);
            this.dgvUnpostedVouchers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvUnpostedVouchers_CellFormatting);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(8, 63);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tlJournal);
            this.splitContainer1.Panel1.Controls.Add(this.tlPurchases);
            this.splitContainer1.Panel1.Controls.Add(this.tlSaleReturn);
            this.splitContainer1.Panel1.Controls.Add(this.tlSale);
            this.splitContainer1.Panel1.Controls.Add(this.tlBankPayment);
            this.splitContainer1.Panel1.Controls.Add(this.tlBankReceipt);
            this.splitContainer1.Panel1.Controls.Add(this.tlCashPayment);
            this.splitContainer1.Panel1.Controls.Add(this.tlCashReceipt);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvUnpostedVouchers);
            this.splitContainer1.Size = new System.Drawing.Size(956, 433);
            this.splitContainer1.SplitterDistance = 146;
            this.splitContainer1.TabIndex = 1;
            // 
            // tlJournal
            // 
            this.tlJournal.ActiveControl = null;
            this.tlJournal.Location = new System.Drawing.Point(15, 375);
            this.tlJournal.Name = "tlJournal";
            this.tlJournal.Size = new System.Drawing.Size(122, 46);
            this.tlJournal.Style = MetroFramework.MetroColorStyle.Brown;
            this.tlJournal.TabIndex = 1;
            this.tlJournal.Text = "Journals";
            this.tlJournal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlJournal.UseSelectable = true;
            this.tlJournal.Click += new System.EventHandler(this.btnUnposted_Click);
            // 
            // tlPurchases
            // 
            this.tlPurchases.ActiveControl = null;
            this.tlPurchases.Location = new System.Drawing.Point(15, 321);
            this.tlPurchases.Name = "tlPurchases";
            this.tlPurchases.Size = new System.Drawing.Size(122, 46);
            this.tlPurchases.Style = MetroFramework.MetroColorStyle.Brown;
            this.tlPurchases.TabIndex = 1;
            this.tlPurchases.Text = "Purchases";
            this.tlPurchases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlPurchases.UseSelectable = true;
            this.tlPurchases.Click += new System.EventHandler(this.btnUnposted_Click);
            // 
            // tlSaleReturn
            // 
            this.tlSaleReturn.ActiveControl = null;
            this.tlSaleReturn.Location = new System.Drawing.Point(15, 267);
            this.tlSaleReturn.Name = "tlSaleReturn";
            this.tlSaleReturn.Size = new System.Drawing.Size(122, 46);
            this.tlSaleReturn.Style = MetroFramework.MetroColorStyle.Brown;
            this.tlSaleReturn.TabIndex = 1;
            this.tlSaleReturn.Text = "Returns";
            this.tlSaleReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlSaleReturn.UseSelectable = true;
            this.tlSaleReturn.Click += new System.EventHandler(this.btnUnposted_Click);
            // 
            // tlSale
            // 
            this.tlSale.ActiveControl = null;
            this.tlSale.Location = new System.Drawing.Point(15, 212);
            this.tlSale.Name = "tlSale";
            this.tlSale.Size = new System.Drawing.Size(122, 46);
            this.tlSale.Style = MetroFramework.MetroColorStyle.Brown;
            this.tlSale.TabIndex = 1;
            this.tlSale.Text = "Sales";
            this.tlSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlSale.UseSelectable = true;
            this.tlSale.Click += new System.EventHandler(this.btnUnposted_Click);
            // 
            // tlBankPayment
            // 
            this.tlBankPayment.ActiveControl = null;
            this.tlBankPayment.Location = new System.Drawing.Point(15, 159);
            this.tlBankPayment.Name = "tlBankPayment";
            this.tlBankPayment.Size = new System.Drawing.Size(122, 46);
            this.tlBankPayment.Style = MetroFramework.MetroColorStyle.Brown;
            this.tlBankPayment.TabIndex = 1;
            this.tlBankPayment.Text = "Bank Payment";
            this.tlBankPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlBankPayment.UseSelectable = true;
            this.tlBankPayment.Click += new System.EventHandler(this.btnUnposted_Click);
            // 
            // tlBankReceipt
            // 
            this.tlBankReceipt.ActiveControl = null;
            this.tlBankReceipt.Location = new System.Drawing.Point(17, 104);
            this.tlBankReceipt.Name = "tlBankReceipt";
            this.tlBankReceipt.Size = new System.Drawing.Size(122, 46);
            this.tlBankReceipt.Style = MetroFramework.MetroColorStyle.Brown;
            this.tlBankReceipt.TabIndex = 1;
            this.tlBankReceipt.Text = "Bank Receipt";
            this.tlBankReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlBankReceipt.UseSelectable = true;
            this.tlBankReceipt.Click += new System.EventHandler(this.btnUnposted_Click);
            // 
            // tlCashPayment
            // 
            this.tlCashPayment.ActiveControl = null;
            this.tlCashPayment.Location = new System.Drawing.Point(15, 53);
            this.tlCashPayment.Name = "tlCashPayment";
            this.tlCashPayment.Size = new System.Drawing.Size(122, 42);
            this.tlCashPayment.Style = MetroFramework.MetroColorStyle.Brown;
            this.tlCashPayment.TabIndex = 1;
            this.tlCashPayment.Text = "Cash Payment";
            this.tlCashPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlCashPayment.UseSelectable = true;
            this.tlCashPayment.Click += new System.EventHandler(this.btnUnposted_Click);
            // 
            // tlCashReceipt
            // 
            this.tlCashReceipt.ActiveControl = null;
            this.tlCashReceipt.Location = new System.Drawing.Point(15, 4);
            this.tlCashReceipt.Name = "tlCashReceipt";
            this.tlCashReceipt.Size = new System.Drawing.Size(122, 40);
            this.tlCashReceipt.Style = MetroFramework.MetroColorStyle.Brown;
            this.tlCashReceipt.TabIndex = 1;
            this.tlCashReceipt.Text = "Cash Receipt";
            this.tlCashReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlCashReceipt.UseSelectable = true;
            this.tlCashReceipt.Click += new System.EventHandler(this.btnUnposted_Click);
            // 
            // lblVoucherName
            // 
            this.lblVoucherName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblVoucherName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblVoucherName.Location = new System.Drawing.Point(232, 26);
            this.lblVoucherName.Name = "lblVoucherName";
            this.lblVoucherName.Size = new System.Drawing.Size(148, 34);
            this.lblVoucherName.Style = MetroFramework.MetroColorStyle.Brown;
            this.lblVoucherName.TabIndex = 2;
            this.lblVoucherName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblVoucherName.UseStyleColors = true;
            // 
            // frmUnpostedVouchers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 502);
            this.Controls.Add(this.lblVoucherName);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmUnpostedVouchers";
            this.Text = "Unposted Vouchers";
            this.Load += new System.EventHandler(this.frmUnpostedVouchers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnpostedVouchers)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUnpostedVouchers;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroTile tlCashReceipt;
        private MetroFramework.Controls.MetroTile tlCashPayment;
        private MetroFramework.Controls.MetroTile tlBankReceipt;
        private MetroFramework.Controls.MetroTile tlBankPayment;
        private MetroFramework.Controls.MetroTile tlJournal;
        private MetroFramework.Controls.MetroTile tlPurchases;
        private MetroFramework.Controls.MetroTile tlSaleReturn;
        private MetroFramework.Controls.MetroTile tlSale;
        private MetroFramework.Controls.MetroLabel lblVoucherName;

    }
}