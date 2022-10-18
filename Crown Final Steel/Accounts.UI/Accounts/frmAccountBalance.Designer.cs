namespace Accounts.UI
{
    partial class frmAccountBalance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEndPeriod = new MetroFramework.Controls.MetroLabel();
            this.StartBalanceDate = new MetroFramework.Controls.MetroDateTime();
            this.chkIncludeDate = new MetroFramework.Controls.MetroCheckBox();
            this.lblStartDate = new MetroFramework.Controls.MetroLabel();
            this.btnPrint = new MetroFramework.Controls.MetroTile();
            this.btnLoad = new MetroFramework.Controls.MetroTile();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSearch = new MetroFramework.Controls.MetroLabel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.DgvAccountBalance = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdBank = new MetroFramework.Controls.MetroRadioButton();
            this.rdCash = new MetroFramework.Controls.MetroRadioButton();
            this.rdCustomers = new MetroFramework.Controls.MetroRadioButton();
            this.rdSuppliers = new MetroFramework.Controls.MetroRadioButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.EndBalanceDate = new MetroFramework.Controls.MetroDateTime();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOpeningBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalanceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccountBalance)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblEndPeriod);
            this.panel1.Controls.Add(this.StartBalanceDate);
            this.panel1.Controls.Add(this.chkIncludeDate);
            this.panel1.Controls.Add(this.lblStartDate);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Location = new System.Drawing.Point(170, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 50);
            this.panel1.TabIndex = 0;
            // 
            // lblEndPeriod
            // 
            this.lblEndPeriod.AutoSize = true;
            this.lblEndPeriod.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblEndPeriod.Location = new System.Drawing.Point(323, 16);
            this.lblEndPeriod.Name = "lblEndPeriod";
            this.lblEndPeriod.Size = new System.Drawing.Size(74, 19);
            this.lblEndPeriod.TabIndex = 12;
            this.lblEndPeriod.Text = "To Period :";
            this.lblEndPeriod.UseCustomBackColor = true;
            // 
            // StartBalanceDate
            // 
            this.StartBalanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartBalanceDate.Location = new System.Drawing.Point(197, 12);
            this.StartBalanceDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.StartBalanceDate.Name = "StartBalanceDate";
            this.StartBalanceDate.Size = new System.Drawing.Size(114, 29);
            this.StartBalanceDate.TabIndex = 10;
            // 
            // chkIncludeDate
            // 
            this.chkIncludeDate.AutoSize = true;
            this.chkIncludeDate.Location = new System.Drawing.Point(10, 19);
            this.chkIncludeDate.Name = "chkIncludeDate";
            this.chkIncludeDate.Size = new System.Drawing.Size(89, 15);
            this.chkIncludeDate.TabIndex = 10;
            this.chkIncludeDate.Text = "Include Date";
            this.chkIncludeDate.UseCustomBackColor = true;
            this.chkIncludeDate.UseSelectable = true;
            this.chkIncludeDate.CheckedChanged += new System.EventHandler(this.chkIncludeDate_CheckedChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblStartDate.Location = new System.Drawing.Point(106, 16);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(88, 19);
            this.lblStartDate.TabIndex = 12;
            this.lblStartDate.Text = "Start Period :";
            this.lblStartDate.UseCustomBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.ActiveControl = null;
            this.btnPrint.BackColor = System.Drawing.Color.IndianRed;
            this.btnPrint.Location = new System.Drawing.Point(611, 10);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(79, 35);
            this.btnPrint.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrint.UseCustomBackColor = true;
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.ActiveControl = null;
            this.btnLoad.BackColor = System.Drawing.Color.IndianRed;
            this.btnLoad.Location = new System.Drawing.Point(529, 10);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(80, 35);
            this.btnLoad.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoad.UseCustomBackColor = true;
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.DgvAccountBalance);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(168, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 458);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accounts Balances";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(8, 22);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(111, 19);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search Accounts :";
            this.lblSearch.UseCustomBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(331, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(119, 22);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(353, 23);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.UseCustomBackColor = true;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // DgvAccountBalance
            // 
            this.DgvAccountBalance.AllowUserToAddRows = false;
            this.DgvAccountBalance.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            this.DgvAccountBalance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvAccountBalance.BackgroundColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAccountBalance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvAccountBalance.ColumnHeadersHeight = 25;
            this.DgvAccountBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAccountName,
            this.colOpeningBalance,
            this.colDebit,
            this.colCredit,
            this.colBalance,
            this.colBalanceType});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvAccountBalance.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvAccountBalance.EnableHeadersVisualStyles = false;
            this.DgvAccountBalance.Location = new System.Drawing.Point(6, 52);
            this.DgvAccountBalance.Name = "DgvAccountBalance";
            this.DgvAccountBalance.ReadOnly = true;
            this.DgvAccountBalance.RowHeadersVisible = false;
            this.DgvAccountBalance.Size = new System.Drawing.Size(708, 400);
            this.DgvAccountBalance.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rdBank);
            this.panel2.Controls.Add(this.rdCash);
            this.panel2.Controls.Add(this.rdCustomers);
            this.panel2.Controls.Add(this.rdSuppliers);
            this.panel2.Location = new System.Drawing.Point(2, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 507);
            this.panel2.TabIndex = 7;
            // 
            // rdBank
            // 
            this.rdBank.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdBank.BackColor = System.Drawing.Color.MistyRose;
            this.rdBank.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdBank.Location = new System.Drawing.Point(7, 163);
            this.rdBank.Name = "rdBank";
            this.rdBank.Size = new System.Drawing.Size(126, 33);
            this.rdBank.Style = MetroFramework.MetroColorStyle.Silver;
            this.rdBank.TabIndex = 12;
            this.rdBank.Text = "Bank Balances";
            this.rdBank.UseCustomBackColor = true;
            this.rdBank.UseSelectable = true;
            this.rdBank.CheckedChanged += new System.EventHandler(this.rdStock_CheckedChanged);
            // 
            // rdCash
            // 
            this.rdCash.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdCash.BackColor = System.Drawing.Color.MistyRose;
            this.rdCash.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdCash.Location = new System.Drawing.Point(7, 120);
            this.rdCash.Name = "rdCash";
            this.rdCash.Size = new System.Drawing.Size(126, 33);
            this.rdCash.Style = MetroFramework.MetroColorStyle.Silver;
            this.rdCash.TabIndex = 12;
            this.rdCash.Text = "Cash Balances";
            this.rdCash.UseCustomBackColor = true;
            this.rdCash.UseSelectable = true;
            this.rdCash.CheckedChanged += new System.EventHandler(this.rdStock_CheckedChanged);
            // 
            // rdCustomers
            // 
            this.rdCustomers.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdCustomers.BackColor = System.Drawing.Color.MistyRose;
            this.rdCustomers.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdCustomers.Location = new System.Drawing.Point(6, 28);
            this.rdCustomers.Name = "rdCustomers";
            this.rdCustomers.Size = new System.Drawing.Size(149, 42);
            this.rdCustomers.Style = MetroFramework.MetroColorStyle.Silver;
            this.rdCustomers.TabIndex = 12;
            this.rdCustomers.Text = "Customers Balances";
            this.rdCustomers.UseCustomBackColor = true;
            this.rdCustomers.UseSelectable = true;
            this.rdCustomers.CheckedChanged += new System.EventHandler(this.rdStock_CheckedChanged);
            // 
            // rdSuppliers
            // 
            this.rdSuppliers.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdSuppliers.BackColor = System.Drawing.Color.MistyRose;
            this.rdSuppliers.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdSuppliers.Location = new System.Drawing.Point(7, 76);
            this.rdSuppliers.Name = "rdSuppliers";
            this.rdSuppliers.Size = new System.Drawing.Size(136, 33);
            this.rdSuppliers.Style = MetroFramework.MetroColorStyle.Silver;
            this.rdSuppliers.TabIndex = 12;
            this.rdSuppliers.Text = "Suppliers Balances";
            this.rdSuppliers.UseCustomBackColor = true;
            this.rdSuppliers.UseSelectable = true;
            this.rdSuppliers.CheckedChanged += new System.EventHandler(this.rdStock_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(651, 575);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 30);
            this.lblTotal.TabIndex = 8;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(827, 573);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(0, 21);
            this.lblTotalAmount.TabIndex = 9;
            // 
            // EndBalanceDate
            // 
            this.EndBalanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndBalanceDate.Location = new System.Drawing.Point(576, 71);
            this.EndBalanceDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.EndBalanceDate.Name = "EndBalanceDate";
            this.EndBalanceDate.Size = new System.Drawing.Size(120, 29);
            this.EndBalanceDate.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AccountName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Account Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OpeningBalanec";
            this.dataGridViewTextBoxColumn2.HeaderText = "Opening";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Debit";
            this.dataGridViewTextBoxColumn3.HeaderText = "Deibt";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Credit";
            this.dataGridViewTextBoxColumn4.HeaderText = "Debit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ClosingBalance";
            dataGridViewCellStyle6.NullValue = "0";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn5.HeaderText = "Closing Balance";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BalanceType";
            this.dataGridViewTextBoxColumn6.HeaderText = "Type";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // colAccountName
            // 
            this.colAccountName.DataPropertyName = "AccountName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colAccountName.DefaultCellStyle = dataGridViewCellStyle3;
            this.colAccountName.HeaderText = "Account Name";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.ReadOnly = true;
            this.colAccountName.Width = 300;
            // 
            // colOpeningBalance
            // 
            this.colOpeningBalance.DataPropertyName = "OpeningBalance";
            this.colOpeningBalance.HeaderText = "Opening";
            this.colOpeningBalance.Name = "colOpeningBalance";
            this.colOpeningBalance.ReadOnly = true;
            this.colOpeningBalance.Visible = false;
            // 
            // colDebit
            // 
            this.colDebit.DataPropertyName = "Debit";
            this.colDebit.HeaderText = "Deibt";
            this.colDebit.Name = "colDebit";
            this.colDebit.ReadOnly = true;
            // 
            // colCredit
            // 
            this.colCredit.DataPropertyName = "Credit";
            this.colCredit.HeaderText = "Credit";
            this.colCredit.Name = "colCredit";
            this.colCredit.ReadOnly = true;
            // 
            // colBalance
            // 
            this.colBalance.DataPropertyName = "ClosingBalance";
            dataGridViewCellStyle4.NullValue = "0";
            this.colBalance.DefaultCellStyle = dataGridViewCellStyle4;
            this.colBalance.HeaderText = "Closing Balance";
            this.colBalance.Name = "colBalance";
            this.colBalance.ReadOnly = true;
            // 
            // colBalanceType
            // 
            this.colBalanceType.DataPropertyName = "BalanceType";
            this.colBalanceType.HeaderText = "Type";
            this.colBalanceType.Name = "colBalanceType";
            this.colBalanceType.ReadOnly = true;
            // 
            // frmAccountBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 614);
            this.Controls.Add(this.EndBalanceDate);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmAccountBalance";
            this.Text = "Accounts Balances";
            this.Load += new System.EventHandler(this.frmAccountBalance_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAccountBalance_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccountBalance)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvAccountBalance;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalAmount;
        private MetroFramework.Controls.MetroTile btnLoad;
        private MetroFramework.Controls.MetroTile btnPrint;
        private MetroFramework.Controls.MetroCheckBox chkIncludeDate;
        private MetroFramework.Controls.MetroDateTime StartBalanceDate;
        private MetroFramework.Controls.MetroDateTime EndBalanceDate;
        private MetroFramework.Controls.MetroRadioButton rdCustomers;
        private MetroFramework.Controls.MetroRadioButton rdSuppliers;
        private MetroFramework.Controls.MetroRadioButton rdCash;
        private MetroFramework.Controls.MetroLabel lblEndPeriod;
        private MetroFramework.Controls.MetroLabel lblStartDate;
        private MetroFramework.Controls.MetroRadioButton rdBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private MetroFramework.Controls.MetroLabel lblSearch;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOpeningBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalanceType;
    }
}