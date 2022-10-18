namespace Accounts.UI
{
    partial class frmCustomerDiscount
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
            this.grdCustomerDiscounts = new Accounts.UI.CustomDataGrid();
            this.colBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomerDiscounts)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCustomerDiscounts
            // 
            this.grdCustomerDiscounts.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdCustomerDiscounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdCustomerDiscounts.BackgroundColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCustomerDiscounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdCustomerDiscounts.ColumnHeadersHeight = 25;
            this.grdCustomerDiscounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBatchNo,
            this.colUnitPrice,
            this.colPercentage,
            this.colDiscountAmount,
            this.colAmount});
            this.grdCustomerDiscounts.EnableHeadersVisualStyles = false;
            this.grdCustomerDiscounts.Location = new System.Drawing.Point(23, 63);
            this.grdCustomerDiscounts.MultiSelect = false;
            this.grdCustomerDiscounts.Name = "grdCustomerDiscounts";
            this.grdCustomerDiscounts.RowHeadersVisible = false;
            this.grdCustomerDiscounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCustomerDiscounts.Size = new System.Drawing.Size(578, 281);
            this.grdCustomerDiscounts.TabIndex = 2;
            // 
            // colBatchNo
            // 
            this.colBatchNo.DataPropertyName = "BatchNo";
            this.colBatchNo.HeaderText = "Batch No";
            this.colBatchNo.Name = "colBatchNo";
            this.colBatchNo.Width = 120;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "UnitPrice";
            this.colUnitPrice.HeaderText = "Unit Price";
            this.colUnitPrice.Name = "colUnitPrice";
            // 
            // colPercentage
            // 
            this.colPercentage.DataPropertyName = "Discount";
            this.colPercentage.HeaderText = "Discount(%)";
            this.colPercentage.Name = "colPercentage";
            // 
            // colDiscountAmount
            // 
            this.colDiscountAmount.DataPropertyName = "DiscountAmount";
            this.colDiscountAmount.HeaderText = "Disc Amount";
            this.colDiscountAmount.Name = "colDiscountAmount";
            this.colDiscountAmount.Width = 150;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            // 
            // frmCustomerDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 378);
            this.Controls.Add(this.grdCustomerDiscounts);
            this.KeyPreview = true;
            this.Name = "frmCustomerDiscount";
            this.Text = "Customer Discounts";
            this.Load += new System.EventHandler(this.frmCustomerDiscount_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCustomerDiscount_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomerDiscounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDataGrid grdCustomerDiscounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscountAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
    }
}