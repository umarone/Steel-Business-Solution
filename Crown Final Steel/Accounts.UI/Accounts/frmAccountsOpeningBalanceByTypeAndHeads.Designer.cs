namespace Accounts.UI
{
    partial class frmAccountsOpeningBalanceByTypeAndHeads
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
            this.pnlflowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.chkByType = new MetroFramework.Controls.MetroCheckBox();
            this.chkHeadWise = new MetroFramework.Controls.MetroCheckBox();
            this.pnlTypes = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbxCategories = new MetroFramework.Controls.MetroComboBox();
            this.pnlHeads = new MetroFramework.Controls.MetroPanel();
            this.CbxHeadsLevel3 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.CbxHeadsLevel1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.CbxHeadsLevel2 = new MetroFramework.Controls.MetroComboBox();
            this.pnlPrint = new MetroFramework.Controls.MetroPanel();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.pnlGrid = new MetroFramework.Controls.MetroPanel();
            this.txtFilter = new MetroFramework.Controls.MetroTextBox();
            this.lblFilter = new MetroFramework.Controls.MetroLabel();
            this.grdOpeningBalances = new MetroFramework.Controls.MetroGrid();
            this.colAccountNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlflowLayout.SuspendLayout();
            this.pnlTypes.SuspendLayout();
            this.pnlHeads.SuspendLayout();
            this.pnlPrint.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOpeningBalances)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlflowLayout
            // 
            this.pnlflowLayout.AutoSize = true;
            this.pnlflowLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlflowLayout.Controls.Add(this.chkByType);
            this.pnlflowLayout.Controls.Add(this.chkHeadWise);
            this.pnlflowLayout.Controls.Add(this.pnlTypes);
            this.pnlflowLayout.Controls.Add(this.pnlHeads);
            this.pnlflowLayout.Controls.Add(this.pnlPrint);
            this.pnlflowLayout.Controls.Add(this.pnlGrid);
            this.pnlflowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlflowLayout.Location = new System.Drawing.Point(26, 57);
            this.pnlflowLayout.Name = "pnlflowLayout";
            this.pnlflowLayout.Size = new System.Drawing.Size(786, 585);
            this.pnlflowLayout.TabIndex = 10;
            // 
            // chkByType
            // 
            this.chkByType.AutoSize = true;
            this.chkByType.Location = new System.Drawing.Point(3, 3);
            this.chkByType.Name = "chkByType";
            this.chkByType.Size = new System.Drawing.Size(202, 15);
            this.chkByType.TabIndex = 10;
            this.chkByType.Text = "By Simple Type Opening Balances";
            this.chkByType.UseSelectable = true;
            this.chkByType.CheckedChanged += new System.EventHandler(this.chkByType_CheckedChanged);
            // 
            // chkHeadWise
            // 
            this.chkHeadWise.AutoSize = true;
            this.chkHeadWise.Location = new System.Drawing.Point(3, 24);
            this.chkHeadWise.Name = "chkHeadWise";
            this.chkHeadWise.Size = new System.Drawing.Size(183, 15);
            this.chkHeadWise.TabIndex = 10;
            this.chkHeadWise.Text = "Head Based Opening Balances";
            this.chkHeadWise.UseSelectable = true;
            this.chkHeadWise.CheckedChanged += new System.EventHandler(this.chkHeadWise_CheckedChanged);
            // 
            // pnlTypes
            // 
            this.pnlTypes.BackColor = System.Drawing.Color.RosyBrown;
            this.pnlTypes.Controls.Add(this.metroLabel1);
            this.pnlTypes.Controls.Add(this.cbxCategories);
            this.pnlTypes.Location = new System.Drawing.Point(3, 45);
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
            this.pnlHeads.Location = new System.Drawing.Point(3, 85);
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
            this.CbxHeadsLevel3.SelectedIndexChanged += new System.EventHandler(this.CbxHeads_SelectedIndexChanged);
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
            this.pnlPrint.Controls.Add(this.btnLoad);
            this.pnlPrint.HorizontalScrollbarBarColor = true;
            this.pnlPrint.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlPrint.HorizontalScrollbarSize = 10;
            this.pnlPrint.Location = new System.Drawing.Point(3, 134);
            this.pnlPrint.Name = "pnlPrint";
            this.pnlPrint.Size = new System.Drawing.Size(780, 42);
            this.pnlPrint.TabIndex = 10;
            this.pnlPrint.UseCustomBackColor = true;
            this.pnlPrint.VerticalScrollbarBarColor = true;
            this.pnlPrint.VerticalScrollbarHighlightOnWheel = false;
            this.pnlPrint.VerticalScrollbarSize = 10;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(634, 7);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(144, 29);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.txtFilter);
            this.pnlGrid.Controls.Add(this.lblFilter);
            this.pnlGrid.Controls.Add(this.grdOpeningBalances);
            this.pnlGrid.HorizontalScrollbarBarColor = true;
            this.pnlGrid.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlGrid.HorizontalScrollbarSize = 10;
            this.pnlGrid.Location = new System.Drawing.Point(3, 182);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(777, 400);
            this.pnlGrid.TabIndex = 11;
            this.pnlGrid.VerticalScrollbarBarColor = true;
            this.pnlGrid.VerticalScrollbarHighlightOnWheel = false;
            this.pnlGrid.VerticalScrollbarSize = 10;
            this.pnlGrid.Visible = false;
            // 
            // txtFilter
            // 
            // 
            // 
            // 
            this.txtFilter.CustomButton.Image = null;
            this.txtFilter.CustomButton.Location = new System.Drawing.Point(693, 1);
            this.txtFilter.CustomButton.Name = "";
            this.txtFilter.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFilter.CustomButton.TabIndex = 1;
            this.txtFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFilter.CustomButton.UseSelectable = true;
            this.txtFilter.CustomButton.Visible = false;
            this.txtFilter.Lines = new string[0];
            this.txtFilter.Location = new System.Drawing.Point(59, 9);
            this.txtFilter.MaxLength = 32767;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PasswordChar = '\0';
            this.txtFilter.PromptText = "Type Account Name To Filter From Below Grid";
            this.txtFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilter.SelectedText = "";
            this.txtFilter.SelectionLength = 0;
            this.txtFilter.SelectionStart = 0;
            this.txtFilter.ShortcutsEnabled = true;
            this.txtFilter.Size = new System.Drawing.Size(715, 23);
            this.txtFilter.TabIndex = 4;
            this.txtFilter.UseSelectable = true;
            this.txtFilter.WaterMark = "Type Account Name To Filter From Below Grid";
            this.txtFilter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFilter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblFilter.Location = new System.Drawing.Point(4, 6);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(57, 25);
            this.lblFilter.TabIndex = 3;
            this.lblFilter.Text = "Filter :";
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
            this.colAmount,
            this.colBType});
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
            this.grdOpeningBalances.Location = new System.Drawing.Point(1, 42);
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
            this.grdOpeningBalances.Size = new System.Drawing.Size(779, 397);
            this.grdOpeningBalances.TabIndex = 2;
            // 
            // colAccountNo
            // 
            this.colAccountNo.DataPropertyName = "AccountNo";
            this.colAccountNo.HeaderText = "AccountNo";
            this.colAccountNo.Name = "colAccountNo";
            this.colAccountNo.ReadOnly = true;
            this.colAccountNo.Width = 110;
            // 
            // colAccountName
            // 
            this.colAccountName.DataPropertyName = "AccountName";
            this.colAccountName.HeaderText = "Account Name";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.ReadOnly = true;
            this.colAccountName.Width = 280;
            // 
            // colDiscription
            // 
            this.colDiscription.DataPropertyName = "Discription";
            this.colDiscription.HeaderText = "Address";
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
            // colBType
            // 
            this.colBType.DataPropertyName = "TransactionMode";
            this.colBType.HeaderText = "Type";
            this.colBType.Name = "colBType";
            this.colBType.ReadOnly = true;
            this.colBType.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AccountNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "AccountNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AccountName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Account Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Discription";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn4.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TransactionMode";
            this.dataGridViewTextBoxColumn5.HeaderText = "Type";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // frmAccountsOpeningBalanceByTypeAndHeads
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(826, 685);
            this.Controls.Add(this.pnlflowLayout);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmAccountsOpeningBalanceByTypeAndHeads";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Accounts Chart Opening Balances";
            this.Load += new System.EventHandler(this.frmAccountsOpeningBalanceByTypeAndHeads_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAccountsOpeningBalanceByTypeAndHeads_KeyPress);
            this.pnlflowLayout.ResumeLayout(false);
            this.pnlflowLayout.PerformLayout();
            this.pnlTypes.ResumeLayout(false);
            this.pnlTypes.PerformLayout();
            this.pnlHeads.ResumeLayout(false);
            this.pnlHeads.PerformLayout();
            this.pnlPrint.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOpeningBalances)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlflowLayout;
        private MetroFramework.Controls.MetroCheckBox chkByType;
        private MetroFramework.Controls.MetroCheckBox chkHeadWise;
        private System.Windows.Forms.Panel pnlTypes;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbxCategories;
        private MetroFramework.Controls.MetroPanel pnlHeads;
        private MetroFramework.Controls.MetroComboBox CbxHeadsLevel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox CbxHeadsLevel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox CbxHeadsLevel2;
        private MetroFramework.Controls.MetroPanel pnlPrint;
        private MetroFramework.Controls.MetroButton btnLoad;
        private MetroFramework.Controls.MetroPanel pnlGrid;
        private MetroFramework.Controls.MetroGrid grdOpeningBalances;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private MetroFramework.Controls.MetroTextBox txtFilter;
        private MetroFramework.Controls.MetroLabel lblFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBType;
    }
}