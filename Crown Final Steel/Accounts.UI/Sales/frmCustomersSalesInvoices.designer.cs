namespace Accounts.UI
{
    partial class frmCustomersSalesInvoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomersSalesInvoices));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.txtCustomer = new MetroFramework.Controls.MetroTextBox();
            this.grdInvoices = new Accounts.UI.CustomDataGrid();
            this.colIdVoucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreviousBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 52);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(720, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = resources.GetString("metroLabel1.Text");
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroPanel1.Controls.Add(this.btnLoad);
            this.metroPanel1.Controls.Add(this.txtCustomer);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(27, 77);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(706, 40);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(541, 9);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(159, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load Customer Invoices";
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtCustomer
            // 
            // 
            // 
            // 
            this.txtCustomer.CustomButton.Image = null;
            this.txtCustomer.CustomButton.Location = new System.Drawing.Point(507, 1);
            this.txtCustomer.CustomButton.Name = "";
            this.txtCustomer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCustomer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomer.CustomButton.TabIndex = 1;
            this.txtCustomer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomer.CustomButton.UseSelectable = true;
            this.txtCustomer.Lines = new string[0];
            this.txtCustomer.Location = new System.Drawing.Point(6, 9);
            this.txtCustomer.MaxLength = 32767;
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.PasswordChar = '\0';
            this.txtCustomer.PromptText = "Type Here To Load Customer";
            this.txtCustomer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomer.SelectedText = "";
            this.txtCustomer.SelectionLength = 0;
            this.txtCustomer.SelectionStart = 0;
            this.txtCustomer.ShortcutsEnabled = true;
            this.txtCustomer.ShowButton = true;
            this.txtCustomer.Size = new System.Drawing.Size(529, 23);
            this.txtCustomer.TabIndex = 2;
            this.txtCustomer.UseSelectable = true;
            this.txtCustomer.WaterMark = "Type Here To Load Customer";
            this.txtCustomer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustomer.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtCustomer_ButtonClick);
            this.txtCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomer_KeyPress);
            // 
            // grdInvoices
            // 
            this.grdInvoices.AllowUserToAddRows = false;
            this.grdInvoices.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdInvoices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdInvoices.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdInvoices.ColumnHeadersHeight = 35;
            this.grdInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdVoucher,
            this.colInvoiceNo,
            this.colInvoiceDate,
            this.colDueDate,
            this.colInvoiceTotal,
            this.colPreviousBalance,
            this.colInvoiceType,
            this.colUpdate});
            this.grdInvoices.EnableHeadersVisualStyles = false;
            this.grdInvoices.Location = new System.Drawing.Point(27, 123);
            this.grdInvoices.MultiSelect = false;
            this.grdInvoices.Name = "grdInvoices";
            this.grdInvoices.RowHeadersVisible = false;
            this.grdInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdInvoices.Size = new System.Drawing.Size(706, 456);
            this.grdInvoices.TabIndex = 2;
            this.grdInvoices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdInvoices_CellClick);
            this.grdInvoices.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdInvoices_CellFormatting);
            // 
            // colIdVoucher
            // 
            this.colIdVoucher.DataPropertyName = "IdVoucher";
            this.colIdVoucher.HeaderText = "IdVoucher";
            this.colIdVoucher.Name = "colIdVoucher";
            this.colIdVoucher.Visible = false;
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.DataPropertyName = "VoucherNo";
            this.colInvoiceNo.HeaderText = "Invoice #";
            this.colInvoiceNo.Name = "colInvoiceNo";
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.DataPropertyName = "VDate";
            dataGridViewCellStyle3.Format = "d";
            this.colInvoiceDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colInvoiceDate.HeaderText = "Inv. Date";
            this.colInvoiceDate.Name = "colInvoiceDate";
            // 
            // colDueDate
            // 
            this.colDueDate.DataPropertyName = "DueDate";
            dataGridViewCellStyle4.Format = "d";
            this.colDueDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDueDate.HeaderText = "Due Date";
            this.colDueDate.Name = "colDueDate";
            // 
            // colInvoiceTotal
            // 
            this.colInvoiceTotal.DataPropertyName = "TotalAmount";
            this.colInvoiceTotal.HeaderText = "Invoice Total";
            this.colInvoiceTotal.Name = "colInvoiceTotal";
            // 
            // colPreviousBalance
            // 
            this.colPreviousBalance.DataPropertyName = "Balance";
            this.colPreviousBalance.HeaderText = "Previous Balance";
            this.colPreviousBalance.Name = "colPreviousBalance";
            // 
            // colInvoiceType
            // 
            this.colInvoiceType.DataPropertyName = "VoucherType";
            this.colInvoiceType.HeaderText = "Invoice Type";
            this.colInvoiceType.Name = "colInvoiceType";
            // 
            // colUpdate
            // 
            this.colUpdate.HeaderText = "....";
            this.colUpdate.Name = "colUpdate";
            // 
            // frmCustomersSalesInvoices
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(754, 602);
            this.Controls.Add(this.grdInvoices);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmCustomersSalesInvoices";
            this.Text = "Customer Invoices";
            this.Load += new System.EventHandler(this.frmCustomersSalesInvoices_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnLoad;
        private MetroFramework.Controls.MetroTextBox txtCustomer;
        private CustomDataGrid grdInvoices;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdVoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPreviousBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceType;
        private System.Windows.Forms.DataGridViewButtonColumn colUpdate;
    }
}