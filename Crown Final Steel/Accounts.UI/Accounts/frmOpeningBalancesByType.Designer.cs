namespace Accounts.UI
{
    partial class frmOpeningBalancesByType
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
            this.cbxCategory = new MetroFramework.Controls.MetroComboBox();
            this.grdOpeningBalances = new MetroFramework.Controls.MetroGrid();
            this.colAccountNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblSearch = new MetroFramework.Controls.MetroLabel();
            this.txtsearchAccounts = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdOpeningBalances)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.ItemHeight = 23;
            this.cbxCategory.Items.AddRange(new object[] {
            "Select Category",
            "Accounts Recieveables / Customers",
            "Accounts Payables",
            "Cash & Bank Balances"});
            this.cbxCategory.Location = new System.Drawing.Point(135, 34);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(325, 29);
            this.cbxCategory.TabIndex = 0;
            this.cbxCategory.UseSelectable = true;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // grdOpeningBalances
            // 
            this.grdOpeningBalances.AllowUserToAddRows = false;
            this.grdOpeningBalances.AllowUserToDeleteRows = false;
            this.grdOpeningBalances.AllowUserToResizeRows = false;
            this.grdOpeningBalances.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdOpeningBalances.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdOpeningBalances.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdOpeningBalances.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdOpeningBalances.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdOpeningBalances.ColumnHeadersHeight = 28;
            this.grdOpeningBalances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAccountNo,
            this.colAccountName,
            this.colDiscription,
            this.colAmount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdOpeningBalances.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdOpeningBalances.EnableHeadersVisualStyles = false;
            this.grdOpeningBalances.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdOpeningBalances.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdOpeningBalances.Location = new System.Drawing.Point(23, 97);
            this.grdOpeningBalances.Name = "grdOpeningBalances";
            this.grdOpeningBalances.ReadOnly = true;
            this.grdOpeningBalances.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdOpeningBalances.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdOpeningBalances.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdOpeningBalances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdOpeningBalances.Size = new System.Drawing.Size(822, 430);
            this.grdOpeningBalances.TabIndex = 1;
            // 
            // colAccountNo
            // 
            this.colAccountNo.DataPropertyName = "AccountNo";
            this.colAccountNo.HeaderText = "AccountNo";
            this.colAccountNo.Name = "colAccountNo";
            this.colAccountNo.ReadOnly = true;
            this.colAccountNo.Width = 150;
            // 
            // colAccountName
            // 
            this.colAccountName.DataPropertyName = "AccountName";
            this.colAccountName.HeaderText = "Account Name";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.ReadOnly = true;
            this.colAccountName.Width = 300;
            // 
            // colDiscription
            // 
            this.colDiscription.DataPropertyName = "Description";
            this.colDiscription.HeaderText = "Discription";
            this.colDiscription.Name = "colDiscription";
            this.colDiscription.ReadOnly = true;
            this.colDiscription.Width = 200;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Select Category :";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(23, 69);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(111, 19);
            this.lblSearch.TabIndex = 14;
            this.lblSearch.Text = "Search Accounts :";
            // 
            // txtsearchAccounts
            // 
            // 
            // 
            // 
            this.txtsearchAccounts.CustomButton.Image = null;
            this.txtsearchAccounts.CustomButton.Location = new System.Drawing.Point(303, 1);
            this.txtsearchAccounts.CustomButton.Name = "";
            this.txtsearchAccounts.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtsearchAccounts.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtsearchAccounts.CustomButton.TabIndex = 1;
            this.txtsearchAccounts.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtsearchAccounts.CustomButton.UseSelectable = true;
            this.txtsearchAccounts.CustomButton.Visible = false;
            this.txtsearchAccounts.Lines = new string[0];
            this.txtsearchAccounts.Location = new System.Drawing.Point(135, 69);
            this.txtsearchAccounts.MaxLength = 32767;
            this.txtsearchAccounts.Name = "txtsearchAccounts";
            this.txtsearchAccounts.PasswordChar = '\0';
            this.txtsearchAccounts.PromptText = "Search Here";
            this.txtsearchAccounts.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsearchAccounts.SelectedText = "";
            this.txtsearchAccounts.SelectionLength = 0;
            this.txtsearchAccounts.SelectionStart = 0;
            this.txtsearchAccounts.ShortcutsEnabled = true;
            this.txtsearchAccounts.Size = new System.Drawing.Size(325, 23);
            this.txtsearchAccounts.TabIndex = 13;
            this.txtsearchAccounts.UseSelectable = true;
            this.txtsearchAccounts.WaterMark = "Search Here";
            this.txtsearchAccounts.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtsearchAccounts.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtsearchAccounts.TextChanged += new System.EventHandler(this.txtsearchAccounts_TextChanged);
            // 
            // frmOpeningBalancesByType
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(854, 550);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtsearchAccounts);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.grdOpeningBalances);
            this.Controls.Add(this.cbxCategory);
            this.DisplayHeader = false;
            this.Name = "frmOpeningBalancesByType";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "frmOpeningBalancesByType";
            this.Load += new System.EventHandler(this.frmOpeningBalancesByType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOpeningBalances)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbxCategory;
        private MetroFramework.Controls.MetroGrid grdOpeningBalances;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private MetroFramework.Controls.MetroLabel lblSearch;
        private MetroFramework.Controls.MetroTextBox txtsearchAccounts;
    }
}