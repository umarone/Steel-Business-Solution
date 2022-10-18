namespace Accounts.UI
{
    partial class frmBalanceSheet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAssetHeadName = new MetroFramework.Controls.MetroLabel();
            this.lblTotalAssetsAmount = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtAssetsAccounts = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.grdAssets = new Accounts.UI.CustomDataGrid();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trvAssets = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLibilitiesHeadName = new MetroFramework.Controls.MetroLabel();
            this.lblTotalLibilitiesAmount = new MetroFramework.Controls.MetroLabel();
            this.lblTotalLibilities = new MetroFramework.Controls.MetroLabel();
            this.txtLibilitiesAccounts = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.grdLibilities = new Accounts.UI.CustomDataGrid();
            this.colLAccountNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.trvLibilities = new System.Windows.Forms.TreeView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAssets)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLibilities)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAssetHeadName);
            this.groupBox1.Controls.Add(this.lblTotalAssetsAmount);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txtAssetsAccounts);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.grdAssets);
            this.groupBox1.Controls.Add(this.trvAssets);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 658);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assets";
            // 
            // lblAssetHeadName
            // 
            this.lblAssetHeadName.AutoSize = true;
            this.lblAssetHeadName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAssetHeadName.Location = new System.Drawing.Point(245, 273);
            this.lblAssetHeadName.Name = "lblAssetHeadName";
            this.lblAssetHeadName.Size = new System.Drawing.Size(0, 0);
            this.lblAssetHeadName.TabIndex = 7;
            // 
            // lblTotalAssetsAmount
            // 
            this.lblTotalAssetsAmount.AutoSize = true;
            this.lblTotalAssetsAmount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTotalAssetsAmount.Location = new System.Drawing.Point(145, 271);
            this.lblTotalAssetsAmount.Name = "lblTotalAssetsAmount";
            this.lblTotalAssetsAmount.Size = new System.Drawing.Size(17, 19);
            this.lblTotalAssetsAmount.TabIndex = 6;
            this.lblTotalAssetsAmount.Text = "0";
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(6, 253);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(534, 23);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "---------------------------------------------------------------------------------" +
    "------";
            // 
            // txtAssetsAccounts
            // 
            // 
            // 
            // 
            this.txtAssetsAccounts.CustomButton.Image = null;
            this.txtAssetsAccounts.CustomButton.Location = new System.Drawing.Point(457, 1);
            this.txtAssetsAccounts.CustomButton.Name = "";
            this.txtAssetsAccounts.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAssetsAccounts.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAssetsAccounts.CustomButton.TabIndex = 1;
            this.txtAssetsAccounts.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAssetsAccounts.CustomButton.UseSelectable = true;
            this.txtAssetsAccounts.CustomButton.Visible = false;
            this.txtAssetsAccounts.Lines = new string[0];
            this.txtAssetsAccounts.Location = new System.Drawing.Point(61, 296);
            this.txtAssetsAccounts.MaxLength = 32767;
            this.txtAssetsAccounts.Name = "txtAssetsAccounts";
            this.txtAssetsAccounts.PasswordChar = '\0';
            this.txtAssetsAccounts.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAssetsAccounts.SelectedText = "";
            this.txtAssetsAccounts.SelectionLength = 0;
            this.txtAssetsAccounts.SelectionStart = 0;
            this.txtAssetsAccounts.ShortcutsEnabled = true;
            this.txtAssetsAccounts.Size = new System.Drawing.Size(479, 23);
            this.txtAssetsAccounts.TabIndex = 4;
            this.txtAssetsAccounts.UseSelectable = true;
            this.txtAssetsAccounts.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAssetsAccounts.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAssetsAccounts.TextChanged += new System.EventHandler(this.txtAssetsAccounts_TextChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(55, 271);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(89, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Total Assets :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 297);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Search :";
            // 
            // grdAssets
            // 
            this.grdAssets.AllowUserToAddRows = false;
            this.grdAssets.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdAssets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdAssets.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAssets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdAssets.ColumnHeadersHeight = 25;
            this.grdAssets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colBalance,
            this.colType});
            this.grdAssets.EnableHeadersVisualStyles = false;
            this.grdAssets.Location = new System.Drawing.Point(2, 321);
            this.grdAssets.MultiSelect = false;
            this.grdAssets.Name = "grdAssets";
            this.grdAssets.ReadOnly = true;
            this.grdAssets.RowHeadersVisible = false;
            this.grdAssets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAssets.Size = new System.Drawing.Size(538, 335);
            this.grdAssets.TabIndex = 2;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "AccountNo";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.colId.DefaultCellStyle = dataGridViewCellStyle3;
            this.colId.HeaderText = "A/C Code";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 110;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "AccountName";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.colName.DefaultCellStyle = dataGridViewCellStyle4;
            this.colName.HeaderText = "A/C Title";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 250;
            // 
            // colBalance
            // 
            this.colBalance.DataPropertyName = "ClosingBalance";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.colBalance.DefaultCellStyle = dataGridViewCellStyle5;
            this.colBalance.HeaderText = "Balance";
            this.colBalance.Name = "colBalance";
            this.colBalance.ReadOnly = true;
            this.colBalance.Width = 110;
            // 
            // colType
            // 
            this.colType.DataPropertyName = "BalanceType";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.colType.DefaultCellStyle = dataGridViewCellStyle6;
            this.colType.HeaderText = "....";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Width = 60;
            // 
            // trvAssets
            // 
            this.trvAssets.Location = new System.Drawing.Point(6, 26);
            this.trvAssets.Name = "trvAssets";
            this.trvAssets.Size = new System.Drawing.Size(534, 224);
            this.trvAssets.TabIndex = 0;
            this.trvAssets.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.trvAssets_AfterExpand);
            this.trvAssets.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvAssets_NodeMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLibilitiesHeadName);
            this.groupBox2.Controls.Add(this.lblTotalLibilitiesAmount);
            this.groupBox2.Controls.Add(this.lblTotalLibilities);
            this.groupBox2.Controls.Add(this.txtLibilitiesAccounts);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.grdLibilities);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.trvLibilities);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(555, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 658);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Libilities";
            // 
            // lblLibilitiesHeadName
            // 
            this.lblLibilitiesHeadName.AutoSize = true;
            this.lblLibilitiesHeadName.Location = new System.Drawing.Point(305, 271);
            this.lblLibilitiesHeadName.Name = "lblLibilitiesHeadName";
            this.lblLibilitiesHeadName.Size = new System.Drawing.Size(16, 19);
            this.lblLibilitiesHeadName.TabIndex = 7;
            this.lblLibilitiesHeadName.Text = "0";
            // 
            // lblTotalLibilitiesAmount
            // 
            this.lblTotalLibilitiesAmount.AutoSize = true;
            this.lblTotalLibilitiesAmount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTotalLibilitiesAmount.Location = new System.Drawing.Point(150, 272);
            this.lblTotalLibilitiesAmount.Name = "lblTotalLibilitiesAmount";
            this.lblTotalLibilitiesAmount.Size = new System.Drawing.Size(17, 19);
            this.lblTotalLibilitiesAmount.TabIndex = 6;
            this.lblTotalLibilitiesAmount.Text = "1";
            // 
            // lblTotalLibilities
            // 
            this.lblTotalLibilities.AutoSize = true;
            this.lblTotalLibilities.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTotalLibilities.Location = new System.Drawing.Point(52, 272);
            this.lblTotalLibilities.Name = "lblTotalLibilities";
            this.lblTotalLibilities.Size = new System.Drawing.Size(98, 19);
            this.lblTotalLibilities.TabIndex = 5;
            this.lblTotalLibilities.Text = "Total Libilities :";
            // 
            // txtLibilitiesAccounts
            // 
            // 
            // 
            // 
            this.txtLibilitiesAccounts.CustomButton.Image = null;
            this.txtLibilitiesAccounts.CustomButton.Location = new System.Drawing.Point(459, 1);
            this.txtLibilitiesAccounts.CustomButton.Name = "";
            this.txtLibilitiesAccounts.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLibilitiesAccounts.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLibilitiesAccounts.CustomButton.TabIndex = 1;
            this.txtLibilitiesAccounts.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLibilitiesAccounts.CustomButton.UseSelectable = true;
            this.txtLibilitiesAccounts.CustomButton.Visible = false;
            this.txtLibilitiesAccounts.Lines = new string[0];
            this.txtLibilitiesAccounts.Location = new System.Drawing.Point(59, 296);
            this.txtLibilitiesAccounts.MaxLength = 32767;
            this.txtLibilitiesAccounts.Name = "txtLibilitiesAccounts";
            this.txtLibilitiesAccounts.PasswordChar = '\0';
            this.txtLibilitiesAccounts.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLibilitiesAccounts.SelectedText = "";
            this.txtLibilitiesAccounts.SelectionLength = 0;
            this.txtLibilitiesAccounts.SelectionStart = 0;
            this.txtLibilitiesAccounts.ShortcutsEnabled = true;
            this.txtLibilitiesAccounts.Size = new System.Drawing.Size(481, 23);
            this.txtLibilitiesAccounts.TabIndex = 4;
            this.txtLibilitiesAccounts.UseSelectable = true;
            this.txtLibilitiesAccounts.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLibilitiesAccounts.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLibilitiesAccounts.TextChanged += new System.EventHandler(this.txtLibilitiesAccounts_TextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(4, 297);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Search :";
            // 
            // grdLibilities
            // 
            this.grdLibilities.AllowUserToAddRows = false;
            this.grdLibilities.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdLibilities.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grdLibilities.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdLibilities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdLibilities.ColumnHeadersHeight = 25;
            this.grdLibilities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLAccountNo,
            this.colLAccountName,
            this.colLBalance,
            this.dataGridViewTextBoxColumn4});
            this.grdLibilities.EnableHeadersVisualStyles = false;
            this.grdLibilities.Location = new System.Drawing.Point(2, 321);
            this.grdLibilities.MultiSelect = false;
            this.grdLibilities.Name = "grdLibilities";
            this.grdLibilities.ReadOnly = true;
            this.grdLibilities.RowHeadersVisible = false;
            this.grdLibilities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdLibilities.Size = new System.Drawing.Size(538, 335);
            this.grdLibilities.TabIndex = 2;
            // 
            // colLAccountNo
            // 
            this.colLAccountNo.DataPropertyName = "AccountNo";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.colLAccountNo.DefaultCellStyle = dataGridViewCellStyle9;
            this.colLAccountNo.HeaderText = "A/C Code";
            this.colLAccountNo.Name = "colLAccountNo";
            this.colLAccountNo.ReadOnly = true;
            this.colLAccountNo.Width = 110;
            // 
            // colLAccountName
            // 
            this.colLAccountName.DataPropertyName = "AccountName";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.colLAccountName.DefaultCellStyle = dataGridViewCellStyle10;
            this.colLAccountName.HeaderText = "A/C Title";
            this.colLAccountName.Name = "colLAccountName";
            this.colLAccountName.ReadOnly = true;
            this.colLAccountName.Width = 250;
            // 
            // colLBalance
            // 
            this.colLBalance.DataPropertyName = "ClosingBalance";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.colLBalance.DefaultCellStyle = dataGridViewCellStyle11;
            this.colLBalance.HeaderText = "Balance";
            this.colLBalance.Name = "colLBalance";
            this.colLBalance.ReadOnly = true;
            this.colLBalance.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BalanceType";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn4.HeaderText = "....";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(6, 255);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(534, 23);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "---------------------------------------------------------------------------------" +
    "------";
            // 
            // trvLibilities
            // 
            this.trvLibilities.Location = new System.Drawing.Point(6, 26);
            this.trvLibilities.Name = "trvLibilities";
            this.trvLibilities.Size = new System.Drawing.Size(534, 224);
            this.trvLibilities.TabIndex = 0;
            this.trvLibilities.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.trvLibilities_AfterExpand);
            this.trvLibilities.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvLibilities_NodeMouseClick);
            // 
            // frmBalanceSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 727);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DisplayHeader = false;
            this.Name = "frmBalanceSheet";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "frmBalanceSheet";
            this.Load += new System.EventHandler(this.frmBalanceSheet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAssets)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLibilities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TreeView trvAssets;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private CustomDataGrid grdAssets;
        private MetroFramework.Controls.MetroTextBox txtAssetsAccounts;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txtLibilitiesAccounts;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private CustomDataGrid grdLibilities;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TreeView trvLibilities;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblTotalLibilities;
        private MetroFramework.Controls.MetroLabel lblTotalAssetsAmount;
        private MetroFramework.Controls.MetroLabel lblTotalLibilitiesAmount;
        private MetroFramework.Controls.MetroLabel lblAssetHeadName;
        private MetroFramework.Controls.MetroLabel lblLibilitiesHeadName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLAccountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}