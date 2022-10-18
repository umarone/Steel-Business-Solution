namespace Accounts.UI
{
    partial class frmMonthlyClaimedVouchers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdClamiedVouchers = new System.Windows.Forms.DataGridView();
            this.grdClaimDetail = new System.Windows.Forms.DataGridView();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLineAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdVoucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdClamiedVouchers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdClaimDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // grdClamiedVouchers
            // 
            this.grdClamiedVouchers.AllowUserToAddRows = false;
            this.grdClamiedVouchers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdClamiedVouchers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdClamiedVouchers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdClamiedVouchers.ColumnHeadersHeight = 26;
            this.grdClamiedVouchers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdVoucher,
            this.colVoucherNo,
            this.colAmount,
            this.colDetail});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdClamiedVouchers.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdClamiedVouchers.EnableHeadersVisualStyles = false;
            this.grdClamiedVouchers.Location = new System.Drawing.Point(13, 68);
            this.grdClamiedVouchers.Name = "grdClamiedVouchers";
            this.grdClamiedVouchers.ReadOnly = true;
            this.grdClamiedVouchers.RowHeadersVisible = false;
            this.grdClamiedVouchers.Size = new System.Drawing.Size(734, 164);
            this.grdClamiedVouchers.TabIndex = 19;
            this.grdClamiedVouchers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdClamiedVouchers_CellContentClick);
            this.grdClamiedVouchers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdClamiedVouchers_CellFormatting);
            // 
            // grdClaimDetail
            // 
            this.grdClaimDetail.AllowUserToAddRows = false;
            this.grdClaimDetail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdClaimDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdClaimDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdClaimDetail.ColumnHeadersHeight = 26;
            this.grdClaimDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProduct,
            this.colUnits,
            this.colUnitPrice,
            this.colDiscount,
            this.colLineAmount});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdClaimDetail.DefaultCellStyle = dataGridViewCellStyle6;
            this.grdClaimDetail.EnableHeadersVisualStyles = false;
            this.grdClaimDetail.Location = new System.Drawing.Point(13, 238);
            this.grdClaimDetail.Name = "grdClaimDetail";
            this.grdClaimDetail.ReadOnly = true;
            this.grdClaimDetail.RowHeadersVisible = false;
            this.grdClaimDetail.Size = new System.Drawing.Size(734, 228);
            this.grdClaimDetail.TabIndex = 19;
            // 
            // colProduct
            // 
            this.colProduct.DataPropertyName = "ItemName";
            this.colProduct.HeaderText = "Product Description";
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            this.colProduct.Width = 300;
            // 
            // colUnits
            // 
            this.colUnits.DataPropertyName = "Units";
            this.colUnits.HeaderText = "Units";
            this.colUnits.Name = "colUnits";
            this.colUnits.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "UnitPrice";
            this.colUnitPrice.HeaderText = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            // 
            // colDiscount
            // 
            this.colDiscount.DataPropertyName = "Discount";
            this.colDiscount.HeaderText = "Discount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.ReadOnly = true;
            // 
            // colLineAmount
            // 
            this.colLineAmount.DataPropertyName = "Amount";
            this.colLineAmount.HeaderText = "Amount";
            this.colLineAmount.Name = "colLineAmount";
            this.colLineAmount.ReadOnly = true;
            // 
            // colIdVoucher
            // 
            this.colIdVoucher.DataPropertyName = "IdVoucher";
            this.colIdVoucher.HeaderText = "IdVoucher";
            this.colIdVoucher.Name = "colIdVoucher";
            this.colIdVoucher.ReadOnly = true;
            this.colIdVoucher.Visible = false;
            // 
            // colVoucherNo
            // 
            this.colVoucherNo.DataPropertyName = "VoucherNo";
            this.colVoucherNo.HeaderText = "Voucher No .";
            this.colVoucherNo.Name = "colVoucherNo";
            this.colVoucherNo.ReadOnly = true;
            this.colVoucherNo.Width = 200;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "TotalAmount";
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 200;
            // 
            // colDetail
            // 
            this.colDetail.HeaderText = "...";
            this.colDetail.Name = "colDetail";
            this.colDetail.ReadOnly = true;
            this.colDetail.Width = 200;
            // 
            // frmMonthlyClaimedVouchers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 502);
            this.Controls.Add(this.grdClaimDetail);
            this.Controls.Add(this.grdClamiedVouchers);
            this.Name = "frmMonthlyClaimedVouchers";
            this.Text = "Monthly Claimed Vouchers";
            this.Load += new System.EventHandler(this.frmMonthlyClaimedVouchers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdClamiedVouchers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdClaimDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdClamiedVouchers;
        private System.Windows.Forms.DataGridView grdClaimDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLineAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdVoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewButtonColumn colDetail;
    }
}