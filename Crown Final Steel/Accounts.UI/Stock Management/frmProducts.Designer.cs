namespace Accounts.UI
{
    partial class frmProducts
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
            this.lblMRP = new MetroFramework.Controls.MetroLabel();
            this.txtunitPrice = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnClose = new MetroFramework.Controls.MetroTile();
            this.btnSearch = new MetroFramework.Controls.MetroTile();
            this.txtMRP = new MetroFramework.Controls.MetroTextBox();
            this.btnFindCategory = new MetroFramework.Controls.MetroButton();
            this.txtBarCode = new MetroFramework.Controls.MetroTextBox();
            this.txtTradingCo = new MetroFramework.Controls.MetroTextBox();
            this.btnFindTradingCo = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtReorderlevel = new MetroFramework.Controls.MetroTextBox();
            this.txtCategoryName = new MetroFramework.Controls.MetroTextBox();
            this.txtProductName = new MetroFramework.Controls.MetroTextBox();
            this.txtProdcutNo = new MetroFramework.Controls.MetroTextBox();
            this.txtProductCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lblBarCode = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblProductNo = new MetroFramework.Controls.MetroLabel();
            this.lblProductDiscription = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbxUOM = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtDiscription = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxItemType = new MetroFramework.Controls.MetroComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxSalesAccounts = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.cbxCogsAccounts = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.cbxInventoryAccounts = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtwight = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.btnAddStock = new MetroFramework.Controls.MetroTile();
            this.btnNewProduct = new MetroFramework.Controls.MetroTile();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMRP
            // 
            this.lblMRP.AutoSize = true;
            this.lblMRP.BackColor = System.Drawing.Color.MistyRose;
            this.lblMRP.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblMRP.Location = new System.Drawing.Point(15, 41);
            this.lblMRP.Name = "lblMRP";
            this.lblMRP.Size = new System.Drawing.Size(93, 19);
            this.lblMRP.TabIndex = 1;
            this.lblMRP.Text = "Per Unit Cost:";
            this.lblMRP.UseCustomBackColor = true;
            // 
            // txtunitPrice
            // 
            this.txtunitPrice.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtunitPrice.CustomButton.Image = null;
            this.txtunitPrice.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.txtunitPrice.CustomButton.Name = "";
            this.txtunitPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtunitPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtunitPrice.CustomButton.TabIndex = 1;
            this.txtunitPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtunitPrice.CustomButton.UseSelectable = true;
            this.txtunitPrice.CustomButton.Visible = false;
            this.txtunitPrice.Lines = new string[0];
            this.txtunitPrice.Location = new System.Drawing.Point(120, 41);
            this.txtunitPrice.MaxLength = 32767;
            this.txtunitPrice.Name = "txtunitPrice";
            this.txtunitPrice.PasswordChar = '\0';
            this.txtunitPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtunitPrice.SelectedText = "";
            this.txtunitPrice.SelectionLength = 0;
            this.txtunitPrice.SelectionStart = 0;
            this.txtunitPrice.ShortcutsEnabled = true;
            this.txtunitPrice.Size = new System.Drawing.Size(233, 23);
            this.txtunitPrice.TabIndex = 0;
            this.txtunitPrice.UseCustomBackColor = true;
            this.txtunitPrice.UseSelectable = true;
            this.txtunitPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtunitPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSave.Location = new System.Drawing.Point(11, 430);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 41);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseTileImage = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveControl = null;
            this.btnDelete.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDelete.Location = new System.Drawing.Point(329, 430);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 41);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.UseCustomBackColor = true;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.UseTileImage = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.ActiveControl = null;
            this.btnClose.BackColor = System.Drawing.Color.RosyBrown;
            this.btnClose.Location = new System.Drawing.Point(541, 430);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 41);
            this.btnClose.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseCustomBackColor = true;
            this.btnClose.UseSelectable = true;
            this.btnClose.UseTileImage = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ActiveControl = null;
            this.btnSearch.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSearch.Location = new System.Drawing.Point(435, 430);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 41);
            this.btnSearch.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.UseCustomBackColor = true;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.UseTileImage = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtMRP
            // 
            this.txtMRP.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txtMRP.CustomButton.Image = null;
            this.txtMRP.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.txtMRP.CustomButton.Name = "";
            this.txtMRP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMRP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMRP.CustomButton.TabIndex = 1;
            this.txtMRP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMRP.CustomButton.UseSelectable = true;
            this.txtMRP.CustomButton.Visible = false;
            this.txtMRP.Lines = new string[0];
            this.txtMRP.Location = new System.Drawing.Point(120, 68);
            this.txtMRP.MaxLength = 32767;
            this.txtMRP.Name = "txtMRP";
            this.txtMRP.PasswordChar = '\0';
            this.txtMRP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMRP.SelectedText = "";
            this.txtMRP.SelectionLength = 0;
            this.txtMRP.SelectionStart = 0;
            this.txtMRP.ShortcutsEnabled = true;
            this.txtMRP.Size = new System.Drawing.Size(233, 23);
            this.txtMRP.TabIndex = 1;
            this.txtMRP.UseCustomBackColor = true;
            this.txtMRP.UseSelectable = true;
            this.txtMRP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMRP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnFindCategory
            // 
            this.btnFindCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFindCategory.Location = new System.Drawing.Point(361, 239);
            this.btnFindCategory.Name = "btnFindCategory";
            this.btnFindCategory.Size = new System.Drawing.Size(49, 23);
            this.btnFindCategory.TabIndex = 6;
            this.btnFindCategory.Text = "+";
            this.btnFindCategory.UseCustomBackColor = true;
            this.btnFindCategory.UseSelectable = true;
            this.btnFindCategory.Click += new System.EventHandler(this.btnFindCategory_Click);
            // 
            // txtBarCode
            // 
            this.txtBarCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.txtBarCode.CustomButton.Image = null;
            this.txtBarCode.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txtBarCode.CustomButton.Name = "";
            this.txtBarCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBarCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBarCode.CustomButton.TabIndex = 1;
            this.txtBarCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBarCode.CustomButton.UseSelectable = true;
            this.txtBarCode.CustomButton.Visible = false;
            this.txtBarCode.Lines = new string[0];
            this.txtBarCode.Location = new System.Drawing.Point(127, 120);
            this.txtBarCode.MaxLength = 32767;
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.PasswordChar = '\0';
            this.txtBarCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBarCode.SelectedText = "";
            this.txtBarCode.SelectionLength = 0;
            this.txtBarCode.SelectionStart = 0;
            this.txtBarCode.ShortcutsEnabled = true;
            this.txtBarCode.Size = new System.Drawing.Size(232, 23);
            this.txtBarCode.TabIndex = 2;
            this.txtBarCode.UseCustomBackColor = true;
            this.txtBarCode.UseSelectable = true;
            this.txtBarCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBarCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarCode_KeyPress);
            // 
            // txtTradingCo
            // 
            this.txtTradingCo.BackColor = System.Drawing.Color.AntiqueWhite;
            // 
            // 
            // 
            this.txtTradingCo.CustomButton.Image = null;
            this.txtTradingCo.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.txtTradingCo.CustomButton.Name = "";
            this.txtTradingCo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTradingCo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTradingCo.CustomButton.TabIndex = 1;
            this.txtTradingCo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTradingCo.CustomButton.UseSelectable = true;
            this.txtTradingCo.CustomButton.Visible = false;
            this.txtTradingCo.Enabled = false;
            this.txtTradingCo.Lines = new string[0];
            this.txtTradingCo.Location = new System.Drawing.Point(127, 266);
            this.txtTradingCo.MaxLength = 32767;
            this.txtTradingCo.Name = "txtTradingCo";
            this.txtTradingCo.PasswordChar = '\0';
            this.txtTradingCo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTradingCo.SelectedText = "";
            this.txtTradingCo.SelectionLength = 0;
            this.txtTradingCo.SelectionStart = 0;
            this.txtTradingCo.ShortcutsEnabled = true;
            this.txtTradingCo.Size = new System.Drawing.Size(233, 23);
            this.txtTradingCo.TabIndex = 7;
            this.txtTradingCo.UseCustomBackColor = true;
            this.txtTradingCo.UseSelectable = true;
            this.txtTradingCo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTradingCo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnFindTradingCo
            // 
            this.btnFindTradingCo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFindTradingCo.Location = new System.Drawing.Point(361, 266);
            this.btnFindTradingCo.Name = "btnFindTradingCo";
            this.btnFindTradingCo.Size = new System.Drawing.Size(49, 23);
            this.btnFindTradingCo.TabIndex = 8;
            this.btnFindTradingCo.Text = "+";
            this.btnFindTradingCo.UseCustomBackColor = true;
            this.btnFindTradingCo.UseSelectable = true;
            this.btnFindTradingCo.Click += new System.EventHandler(this.btnFindTradingCo_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.MistyRose;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(12, 71);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(105, 19);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Trade Price(TP) :";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // txtReorderlevel
            // 
            // 
            // 
            // 
            this.txtReorderlevel.CustomButton.Image = null;
            this.txtReorderlevel.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.txtReorderlevel.CustomButton.Name = "";
            this.txtReorderlevel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtReorderlevel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReorderlevel.CustomButton.TabIndex = 1;
            this.txtReorderlevel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReorderlevel.CustomButton.UseSelectable = true;
            this.txtReorderlevel.CustomButton.Visible = false;
            this.txtReorderlevel.Lines = new string[0];
            this.txtReorderlevel.Location = new System.Drawing.Point(113, 327);
            this.txtReorderlevel.MaxLength = 32767;
            this.txtReorderlevel.Name = "txtReorderlevel";
            this.txtReorderlevel.PasswordChar = '\0';
            this.txtReorderlevel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReorderlevel.SelectedText = "";
            this.txtReorderlevel.SelectionLength = 0;
            this.txtReorderlevel.SelectionStart = 0;
            this.txtReorderlevel.ShortcutsEnabled = true;
            this.txtReorderlevel.Size = new System.Drawing.Size(233, 23);
            this.txtReorderlevel.TabIndex = 1;
            this.txtReorderlevel.UseSelectable = true;
            this.txtReorderlevel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReorderlevel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BackColor = System.Drawing.Color.AntiqueWhite;
            // 
            // 
            // 
            this.txtCategoryName.CustomButton.Image = null;
            this.txtCategoryName.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.txtCategoryName.CustomButton.Name = "";
            this.txtCategoryName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCategoryName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCategoryName.CustomButton.TabIndex = 1;
            this.txtCategoryName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCategoryName.CustomButton.UseSelectable = true;
            this.txtCategoryName.CustomButton.Visible = false;
            this.txtCategoryName.Enabled = false;
            this.txtCategoryName.Lines = new string[0];
            this.txtCategoryName.Location = new System.Drawing.Point(127, 239);
            this.txtCategoryName.MaxLength = 32767;
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.PasswordChar = '\0';
            this.txtCategoryName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCategoryName.SelectedText = "";
            this.txtCategoryName.SelectionLength = 0;
            this.txtCategoryName.SelectionStart = 0;
            this.txtCategoryName.ShortcutsEnabled = true;
            this.txtCategoryName.Size = new System.Drawing.Size(233, 23);
            this.txtCategoryName.TabIndex = 5;
            this.txtCategoryName.UseCustomBackColor = true;
            this.txtCategoryName.UseSelectable = true;
            this.txtCategoryName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCategoryName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.Linen;
            // 
            // 
            // 
            this.txtProductName.CustomButton.Image = null;
            this.txtProductName.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.txtProductName.CustomButton.Name = "";
            this.txtProductName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductName.CustomButton.TabIndex = 1;
            this.txtProductName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductName.CustomButton.UseSelectable = true;
            this.txtProductName.CustomButton.Visible = false;
            this.txtProductName.Lines = new string[0];
            this.txtProductName.Location = new System.Drawing.Point(127, 147);
            this.txtProductName.MaxLength = 32767;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductName.SelectedText = "";
            this.txtProductName.SelectionLength = 0;
            this.txtProductName.SelectionStart = 0;
            this.txtProductName.ShortcutsEnabled = true;
            this.txtProductName.Size = new System.Drawing.Size(233, 23);
            this.txtProductName.TabIndex = 3;
            this.txtProductName.UseCustomBackColor = true;
            this.txtProductName.UseSelectable = true;
            this.txtProductName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProdcutNo
            // 
            // 
            // 
            // 
            this.txtProdcutNo.CustomButton.Image = null;
            this.txtProdcutNo.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.txtProdcutNo.CustomButton.Name = "";
            this.txtProdcutNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProdcutNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProdcutNo.CustomButton.TabIndex = 1;
            this.txtProdcutNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProdcutNo.CustomButton.UseSelectable = true;
            this.txtProdcutNo.CustomButton.Visible = false;
            this.txtProdcutNo.Enabled = false;
            this.txtProdcutNo.Lines = new string[0];
            this.txtProdcutNo.Location = new System.Drawing.Point(127, 67);
            this.txtProdcutNo.MaxLength = 32767;
            this.txtProdcutNo.Name = "txtProdcutNo";
            this.txtProdcutNo.PasswordChar = '\0';
            this.txtProdcutNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProdcutNo.SelectedText = "";
            this.txtProdcutNo.SelectionLength = 0;
            this.txtProdcutNo.SelectionStart = 0;
            this.txtProdcutNo.ShortcutsEnabled = true;
            this.txtProdcutNo.Size = new System.Drawing.Size(231, 23);
            this.txtProdcutNo.TabIndex = 0;
            this.txtProdcutNo.UseSelectable = true;
            this.txtProdcutNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProdcutNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProductCode
            // 
            // 
            // 
            // 
            this.txtProductCode.CustomButton.Image = null;
            this.txtProductCode.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txtProductCode.CustomButton.Name = "";
            this.txtProductCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductCode.CustomButton.TabIndex = 1;
            this.txtProductCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductCode.CustomButton.UseSelectable = true;
            this.txtProductCode.CustomButton.Visible = false;
            this.txtProductCode.Lines = new string[0];
            this.txtProductCode.Location = new System.Drawing.Point(127, 94);
            this.txtProductCode.MaxLength = 32767;
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.PasswordChar = '\0';
            this.txtProductCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductCode.SelectedText = "";
            this.txtProductCode.SelectionLength = 0;
            this.txtProductCode.SelectionStart = 0;
            this.txtProductCode.ShortcutsEnabled = true;
            this.txtProductCode.Size = new System.Drawing.Size(232, 23);
            this.txtProductCode.TabIndex = 1;
            this.txtProductCode.UseSelectable = true;
            this.txtProductCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.MistyRose;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(8, 327);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(99, 19);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Reorder Level :";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.MistyRose;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(21, 266);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(52, 19);
            this.metroLabel7.TabIndex = 18;
            this.metroLabel7.Text = "Brand :";
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.MistyRose;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(21, 238);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(72, 19);
            this.metroLabel6.TabIndex = 19;
            this.metroLabel6.Text = "Category :";
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // lblBarCode
            // 
            this.lblBarCode.AutoSize = true;
            this.lblBarCode.BackColor = System.Drawing.Color.MistyRose;
            this.lblBarCode.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBarCode.Location = new System.Drawing.Point(23, 117);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(72, 19);
            this.lblBarCode.TabIndex = 27;
            this.lblBarCode.Text = "Bar Code :";
            this.lblBarCode.UseCustomBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.MistyRose;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(8, 266);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(84, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Unit(UOM) :";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // lblProductNo
            // 
            this.lblProductNo.AutoSize = true;
            this.lblProductNo.BackColor = System.Drawing.Color.MistyRose;
            this.lblProductNo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblProductNo.Location = new System.Drawing.Point(23, 67);
            this.lblProductNo.Name = "lblProductNo";
            this.lblProductNo.Size = new System.Drawing.Size(86, 19);
            this.lblProductNo.TabIndex = 14;
            this.lblProductNo.Text = "Product No :";
            this.lblProductNo.UseCustomBackColor = true;
            // 
            // lblProductDiscription
            // 
            this.lblProductDiscription.AutoSize = true;
            this.lblProductDiscription.BackColor = System.Drawing.Color.MistyRose;
            this.lblProductDiscription.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblProductDiscription.Location = new System.Drawing.Point(21, 147);
            this.lblProductDiscription.Name = "lblProductDiscription";
            this.lblProductDiscription.Size = new System.Drawing.Size(52, 19);
            this.lblProductDiscription.TabIndex = 24;
            this.lblProductDiscription.Text = "Name :";
            this.lblProductDiscription.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.MistyRose;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 93);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 19);
            this.metroLabel1.TabIndex = 21;
            this.metroLabel1.Text = "Product Code :";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // cbxUOM
            // 
            this.cbxUOM.FormattingEnabled = true;
            this.cbxUOM.ItemHeight = 23;
            this.cbxUOM.Location = new System.Drawing.Point(115, 266);
            this.cbxUOM.Name = "cbxUOM";
            this.cbxUOM.Size = new System.Drawing.Size(233, 29);
            this.cbxUOM.TabIndex = 0;
            this.cbxUOM.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.MistyRose;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(20, 182);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(81, 19);
            this.metroLabel8.TabIndex = 24;
            this.metroLabel8.Text = "Discription :";
            this.metroLabel8.UseCustomBackColor = true;
            // 
            // txtDiscription
            // 
            this.txtDiscription.BackColor = System.Drawing.Color.SeaShell;
            // 
            // 
            // 
            this.txtDiscription.CustomButton.Image = null;
            this.txtDiscription.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.txtDiscription.CustomButton.Name = "";
            this.txtDiscription.CustomButton.Size = new System.Drawing.Size(57, 57);
            this.txtDiscription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiscription.CustomButton.TabIndex = 1;
            this.txtDiscription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiscription.CustomButton.UseSelectable = true;
            this.txtDiscription.CustomButton.Visible = false;
            this.txtDiscription.Lines = new string[0];
            this.txtDiscription.Location = new System.Drawing.Point(127, 174);
            this.txtDiscription.MaxLength = 32767;
            this.txtDiscription.Multiline = true;
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.PasswordChar = '\0';
            this.txtDiscription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiscription.SelectedText = "";
            this.txtDiscription.SelectionLength = 0;
            this.txtDiscription.SelectionStart = 0;
            this.txtDiscription.ShortcutsEnabled = true;
            this.txtDiscription.Size = new System.Drawing.Size(233, 59);
            this.txtDiscription.TabIndex = 4;
            this.txtDiscription.UseCustomBackColor = true;
            this.txtDiscription.UseSelectable = true;
            this.txtDiscription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiscription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.cbxItemType);
            this.panel1.Controls.Add(this.cbxUOM);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.metroLabel13);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.txtReorderlevel);
            this.panel1.Controls.Add(this.txtwight);
            this.panel1.Controls.Add(this.metroLabel12);
            this.panel1.Controls.Add(this.metroLabel11);
            this.panel1.Location = new System.Drawing.Point(11, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 366);
            this.panel1.TabIndex = 9;
            // 
            // cbxItemType
            // 
            this.cbxItemType.FormattingEnabled = true;
            this.cbxItemType.ItemHeight = 23;
            this.cbxItemType.Items.AddRange(new object[] {
            "",
            "Auto Weight",
            "Manual Weight"});
            this.cbxItemType.Location = new System.Drawing.Point(116, 231);
            this.cbxItemType.Name = "cbxItemType";
            this.cbxItemType.Size = new System.Drawing.Size(233, 29);
            this.cbxItemType.TabIndex = 0;
            this.cbxItemType.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxSalesAccounts);
            this.groupBox2.Controls.Add(this.metroLabel10);
            this.groupBox2.Controls.Add(this.cbxCogsAccounts);
            this.groupBox2.Controls.Add(this.metroLabel9);
            this.groupBox2.Controls.Add(this.cbxInventoryAccounts);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(411, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 158);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products Accounts";
            // 
            // cbxSalesAccounts
            // 
            this.cbxSalesAccounts.FormattingEnabled = true;
            this.cbxSalesAccounts.ItemHeight = 23;
            this.cbxSalesAccounts.Location = new System.Drawing.Point(123, 113);
            this.cbxSalesAccounts.Name = "cbxSalesAccounts";
            this.cbxSalesAccounts.Size = new System.Drawing.Size(233, 29);
            this.cbxSalesAccounts.TabIndex = 2;
            this.cbxSalesAccounts.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.MistyRose;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(18, 117);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(73, 19);
            this.metroLabel10.TabIndex = 25;
            this.metroLabel10.Text = "Sales A/C :";
            this.metroLabel10.UseCustomBackColor = true;
            // 
            // cbxCogsAccounts
            // 
            this.cbxCogsAccounts.FormattingEnabled = true;
            this.cbxCogsAccounts.ItemHeight = 23;
            this.cbxCogsAccounts.Location = new System.Drawing.Point(123, 76);
            this.cbxCogsAccounts.Name = "cbxCogsAccounts";
            this.cbxCogsAccounts.Size = new System.Drawing.Size(233, 29);
            this.cbxCogsAccounts.TabIndex = 1;
            this.cbxCogsAccounts.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.MistyRose;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(18, 80);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(80, 19);
            this.metroLabel9.TabIndex = 25;
            this.metroLabel9.Text = "COGS A/C :";
            this.metroLabel9.UseCustomBackColor = true;
            // 
            // cbxInventoryAccounts
            // 
            this.cbxInventoryAccounts.FormattingEnabled = true;
            this.cbxInventoryAccounts.ItemHeight = 23;
            this.cbxInventoryAccounts.Location = new System.Drawing.Point(123, 38);
            this.cbxInventoryAccounts.Name = "cbxInventoryAccounts";
            this.cbxInventoryAccounts.Size = new System.Drawing.Size(233, 29);
            this.cbxInventoryAccounts.TabIndex = 0;
            this.cbxInventoryAccounts.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.MistyRose;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(17, 41);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(102, 19);
            this.metroLabel5.TabIndex = 25;
            this.metroLabel5.Text = "Inventory A/C :";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.Color.MistyRose;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(11, 234);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(44, 19);
            this.metroLabel13.TabIndex = 1;
            this.metroLabel13.Text = "Type :";
            this.metroLabel13.UseCustomBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtunitPrice);
            this.groupBox1.Controls.Add(this.txtMRP);
            this.groupBox1.Controls.Add(this.lblMRP);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(411, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 122);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Price / Cost";
            // 
            // txtwight
            // 
            // 
            // 
            // 
            this.txtwight.CustomButton.Image = null;
            this.txtwight.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtwight.CustomButton.Name = "";
            this.txtwight.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtwight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtwight.CustomButton.TabIndex = 1;
            this.txtwight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtwight.CustomButton.UseSelectable = true;
            this.txtwight.CustomButton.Visible = false;
            this.txtwight.Lines = new string[0];
            this.txtwight.Location = new System.Drawing.Point(115, 300);
            this.txtwight.MaxLength = 32767;
            this.txtwight.Name = "txtwight";
            this.txtwight.PasswordChar = '\0';
            this.txtwight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtwight.SelectedText = "";
            this.txtwight.SelectionLength = 0;
            this.txtwight.SelectionStart = 0;
            this.txtwight.ShortcutsEnabled = true;
            this.txtwight.Size = new System.Drawing.Size(154, 23);
            this.txtwight.TabIndex = 0;
            this.txtwight.UseSelectable = true;
            this.txtwight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtwight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.MistyRose;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(275, 301);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(57, 19);
            this.metroLabel12.TabIndex = 18;
            this.metroLabel12.Text = "( In Kg )";
            this.metroLabel12.UseCustomBackColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.MistyRose;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(10, 299);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(59, 19);
            this.metroLabel11.TabIndex = 18;
            this.metroLabel11.Text = "Weight :";
            this.metroLabel11.UseCustomBackColor = true;
            // 
            // btnAddStock
            // 
            this.btnAddStock.ActiveControl = null;
            this.btnAddStock.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAddStock.Location = new System.Drawing.Point(122, 430);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(100, 41);
            this.btnAddStock.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnAddStock.TabIndex = 13;
            this.btnAddStock.Text = "Add Stock";
            this.btnAddStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddStock.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddStock.UseCustomBackColor = true;
            this.btnAddStock.UseSelectable = true;
            this.btnAddStock.UseTileImage = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.ActiveControl = null;
            this.btnNewProduct.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNewProduct.Location = new System.Drawing.Point(223, 430);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(105, 41);
            this.btnNewProduct.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnNewProduct.TabIndex = 14;
            this.btnNewProduct.Text = "New Product";
            this.btnNewProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewProduct.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewProduct.UseCustomBackColor = true;
            this.btnNewProduct.UseSelectable = true;
            this.btnNewProduct.UseTileImage = true;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 491);
            this.Controls.Add(this.btnFindCategory);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.txtTradingCo);
            this.Controls.Add(this.btnFindTradingCo);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.txtDiscription);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProdcutNo);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.lblBarCode);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.lblProductNo);
            this.Controls.Add(this.lblProductDiscription);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNewProduct);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmProducts";
            this.Text = "Products Registeration";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmProducts_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblMRP;
        private MetroFramework.Controls.MetroTextBox txtunitPrice;
        private MetroFramework.Controls.MetroTile btnSave;
        private MetroFramework.Controls.MetroTile btnDelete;
        private MetroFramework.Controls.MetroTile btnClose;
        private MetroFramework.Controls.MetroTile btnSearch;
        private MetroFramework.Controls.MetroTextBox txtMRP;
        private MetroFramework.Controls.MetroButton btnFindCategory;
        private MetroFramework.Controls.MetroTextBox txtBarCode;
        private MetroFramework.Controls.MetroTextBox txtTradingCo;
        private MetroFramework.Controls.MetroButton btnFindTradingCo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtReorderlevel;
        private MetroFramework.Controls.MetroTextBox txtCategoryName;
        private MetroFramework.Controls.MetroTextBox txtProductName;
        private MetroFramework.Controls.MetroTextBox txtProdcutNo;
        private MetroFramework.Controls.MetroTextBox txtProductCode;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel lblBarCode;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lblProductNo;
        private MetroFramework.Controls.MetroLabel lblProductDiscription;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbxUOM;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtDiscription;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile btnAddStock;
        private MetroFramework.Controls.MetroComboBox cbxInventoryAccounts;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroComboBox cbxCogsAccounts;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroComboBox cbxSalesAccounts;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtwight;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroComboBox cbxItemType;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTile btnNewProduct;
    }
}