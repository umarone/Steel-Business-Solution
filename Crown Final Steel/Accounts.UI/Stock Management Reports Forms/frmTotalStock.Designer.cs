namespace Accounts.UI
{
    partial class frmTotalStock
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlPeriod = new System.Windows.Forms.GroupBox();
            this.btnPrint = new MetroFramework.Controls.MetroTile();
            this.ctxStock = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printTotalStockReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printGroupingStockReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExcelExport = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnLoad = new MetroFramework.Controls.MetroTile();
            this.chkDate = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.EndDate = new MetroFramework.Controls.MetroDateTime();
            this.StartDate = new MetroFramework.Controls.MetroDateTime();
            this.grdTotalStock = new System.Windows.Forms.DataGridView();
            this.CbxCategories = new MetroFramework.Controls.MetroComboBox();
            this.txtsearch = new MetroFramework.Controls.MetroTextBox();
            this.lblSearch = new MetroFramework.Controls.MetroLabel();
            this.chkByCategory = new MetroFramework.Controls.MetroCheckBox();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.lblSelectCategory = new MetroFramework.Controls.MetroLabel();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.chkAllStock = new MetroFramework.Controls.MetroCheckBox();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.chkByBrand = new MetroFramework.Controls.MetroCheckBox();
            this.pnlBrand = new System.Windows.Forms.Panel();
            this.lblBrand = new MetroFramework.Controls.MetroLabel();
            this.cbxBrands = new MetroFramework.Controls.MetroComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPackingSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOpening = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurchases = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurchasesReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStoreIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStoreOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClosing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAVRBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPeriod.SuspendLayout();
            this.ctxStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTotalStock)).BeginInit();
            this.pnlGrid.SuspendLayout();
            this.pnlCategory.SuspendLayout();
            this.flowPanel.SuspendLayout();
            this.pnlBrand.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPeriod
            // 
            this.pnlPeriod.BackColor = System.Drawing.Color.MistyRose;
            this.pnlPeriod.Controls.Add(this.btnPrint);
            this.pnlPeriod.Controls.Add(this.btnExcelExport);
            this.pnlPeriod.Controls.Add(this.metroLabel2);
            this.pnlPeriod.Controls.Add(this.btnLoad);
            this.pnlPeriod.Controls.Add(this.chkDate);
            this.pnlPeriod.Controls.Add(this.metroLabel1);
            this.pnlPeriod.Controls.Add(this.EndDate);
            this.pnlPeriod.Controls.Add(this.StartDate);
            this.pnlPeriod.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPeriod.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pnlPeriod.Location = new System.Drawing.Point(3, 3);
            this.pnlPeriod.Name = "pnlPeriod";
            this.pnlPeriod.Size = new System.Drawing.Size(1143, 66);
            this.pnlPeriod.TabIndex = 7;
            this.pnlPeriod.TabStop = false;
            this.pnlPeriod.Text = "Periodic Stock";
            // 
            // btnPrint
            // 
            this.btnPrint.ActiveControl = null;
            this.btnPrint.BackColor = System.Drawing.Color.RosyBrown;
            this.btnPrint.ContextMenuStrip = this.ctxStock;
            this.btnPrint.Location = new System.Drawing.Point(877, 18);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(106, 39);
            this.btnPrint.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrint.UseCustomBackColor = true;
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ctxStock
            // 
            this.ctxStock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printTotalStockReportToolStripMenuItem,
            this.printGroupingStockReportToolStripMenuItem});
            this.ctxStock.Name = "ctxStock";
            this.ctxStock.Size = new System.Drawing.Size(223, 70);
            // 
            // printTotalStockReportToolStripMenuItem
            // 
            this.printTotalStockReportToolStripMenuItem.Name = "printTotalStockReportToolStripMenuItem";
            this.printTotalStockReportToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.printTotalStockReportToolStripMenuItem.Text = "Print Total Stock Report";
            this.printTotalStockReportToolStripMenuItem.Click += new System.EventHandler(this.printTotalStockReportToolStripMenuItem_Click);
            // 
            // printGroupingStockReportToolStripMenuItem
            // 
            this.printGroupingStockReportToolStripMenuItem.Name = "printGroupingStockReportToolStripMenuItem";
            this.printGroupingStockReportToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.printGroupingStockReportToolStripMenuItem.Text = "Print Grouping Stock Report";
            this.printGroupingStockReportToolStripMenuItem.Click += new System.EventHandler(this.printGroupingStockReportToolStripMenuItem_Click);
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.ActiveControl = null;
            this.btnExcelExport.BackColor = System.Drawing.Color.RosyBrown;
            this.btnExcelExport.Location = new System.Drawing.Point(770, 18);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(106, 39);
            this.btnExcelExport.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnExcelExport.TabIndex = 9;
            this.btnExcelExport.Text = "Excel Export";
            this.btnExcelExport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcelExport.UseCustomBackColor = true;
            this.btnExcelExport.UseSelectable = true;
            this.btnExcelExport.Click += new System.EventHandler(this.btnExcelExport_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(294, 30);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "To Period :";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.ActiveControl = null;
            this.btnLoad.BackColor = System.Drawing.Color.RosyBrown;
            this.btnLoad.Location = new System.Drawing.Point(663, 18);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(106, 39);
            this.btnLoad.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoad.UseCustomBackColor = true;
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Checked = true;
            this.chkDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDate.Location = new System.Drawing.Point(561, 31);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(90, 15);
            this.chkDate.TabIndex = 9;
            this.chkDate.Text = "Exclude Date";
            this.chkDate.UseCustomBackColor = true;
            this.chkDate.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 31);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Start Period : ";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // EndDate
            // 
            this.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDate.Location = new System.Drawing.Point(374, 26);
            this.EndDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(181, 29);
            this.EndDate.TabIndex = 10;
            // 
            // StartDate
            // 
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDate.Location = new System.Drawing.Point(110, 26);
            this.StartDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(179, 29);
            this.StartDate.TabIndex = 9;
            // 
            // grdTotalStock
            // 
            this.grdTotalStock.AllowUserToAddRows = false;
            this.grdTotalStock.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            this.grdTotalStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdTotalStock.BackgroundColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTotalStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdTotalStock.ColumnHeadersHeight = 35;
            this.grdTotalStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAccountName,
            this.colPackingSize,
            this.colOpening,
            this.colPurchases,
            this.colPurchasesReturn,
            this.colSales,
            this.colReturns,
            this.colStoreIn,
            this.colStoreOut,
            this.colClosing,
            this.colStockBalance,
            this.colAVRBalance});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTotalStock.DefaultCellStyle = dataGridViewCellStyle4;
            this.grdTotalStock.EnableHeadersVisualStyles = false;
            this.grdTotalStock.Location = new System.Drawing.Point(3, 34);
            this.grdTotalStock.Name = "grdTotalStock";
            this.grdTotalStock.ReadOnly = true;
            this.grdTotalStock.RowHeadersVisible = false;
            this.grdTotalStock.Size = new System.Drawing.Size(1140, 308);
            this.grdTotalStock.TabIndex = 8;
            // 
            // CbxCategories
            // 
            this.CbxCategories.FormattingEnabled = true;
            this.CbxCategories.ItemHeight = 23;
            this.CbxCategories.Location = new System.Drawing.Point(123, 7);
            this.CbxCategories.Name = "CbxCategories";
            this.CbxCategories.Size = new System.Drawing.Size(360, 29);
            this.CbxCategories.TabIndex = 10;
            this.CbxCategories.UseSelectable = true;
            // 
            // txtsearch
            // 
            // 
            // 
            // 
            this.txtsearch.CustomButton.Image = null;
            this.txtsearch.CustomButton.Location = new System.Drawing.Point(377, 1);
            this.txtsearch.CustomButton.Name = "";
            this.txtsearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtsearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtsearch.CustomButton.TabIndex = 1;
            this.txtsearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtsearch.CustomButton.UseSelectable = true;
            this.txtsearch.CustomButton.Visible = false;
            this.txtsearch.Lines = new string[0];
            this.txtsearch.Location = new System.Drawing.Point(98, 5);
            this.txtsearch.MaxLength = 32767;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.PromptText = "Search Here";
            this.txtsearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsearch.SelectedText = "";
            this.txtsearch.SelectionLength = 0;
            this.txtsearch.SelectionStart = 0;
            this.txtsearch.ShortcutsEnabled = true;
            this.txtsearch.Size = new System.Drawing.Size(399, 23);
            this.txtsearch.TabIndex = 11;
            this.txtsearch.UseSelectable = true;
            this.txtsearch.WaterMark = "Search Here";
            this.txtsearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtsearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblSearch.Location = new System.Drawing.Point(6, 5);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(90, 19);
            this.lblSearch.TabIndex = 12;
            this.lblSearch.Text = "Search Stock :";
            this.lblSearch.UseCustomBackColor = true;
            // 
            // chkByCategory
            // 
            this.chkByCategory.AutoSize = true;
            this.chkByCategory.Location = new System.Drawing.Point(3, 75);
            this.chkByCategory.Name = "chkByCategory";
            this.chkByCategory.Size = new System.Drawing.Size(119, 15);
            this.chkByCategory.TabIndex = 13;
            this.chkByCategory.Text = "By Category Stock";
            this.chkByCategory.UseSelectable = true;
            this.chkByCategory.CheckedChanged += new System.EventHandler(this.chkByCategory_CheckedChanged);
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnlGrid.Controls.Add(this.lblSearch);
            this.pnlGrid.Controls.Add(this.txtsearch);
            this.pnlGrid.Controls.Add(this.grdTotalStock);
            this.pnlGrid.Location = new System.Drawing.Point(3, 232);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1146, 345);
            this.pnlGrid.TabIndex = 14;
            // 
            // lblSelectCategory
            // 
            this.lblSelectCategory.AutoSize = true;
            this.lblSelectCategory.Location = new System.Drawing.Point(7, 11);
            this.lblSelectCategory.Name = "lblSelectCategory";
            this.lblSelectCategory.Size = new System.Drawing.Size(112, 19);
            this.lblSelectCategory.TabIndex = 9;
            this.lblSelectCategory.Text = "Select Category : ";
            this.lblSelectCategory.UseCustomBackColor = true;
            // 
            // pnlCategory
            // 
            this.pnlCategory.BackColor = System.Drawing.Color.RosyBrown;
            this.pnlCategory.Controls.Add(this.lblSelectCategory);
            this.pnlCategory.Controls.Add(this.CbxCategories);
            this.pnlCategory.Location = new System.Drawing.Point(3, 138);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(1143, 41);
            this.pnlCategory.TabIndex = 15;
            this.pnlCategory.Visible = false;
            // 
            // chkAllStock
            // 
            this.chkAllStock.AutoSize = true;
            this.chkAllStock.Location = new System.Drawing.Point(3, 117);
            this.chkAllStock.Name = "chkAllStock";
            this.chkAllStock.Size = new System.Drawing.Size(104, 15);
            this.chkAllStock.TabIndex = 13;
            this.chkAllStock.Text = "Igone Category";
            this.chkAllStock.UseSelectable = true;
            this.chkAllStock.CheckedChanged += new System.EventHandler(this.chkAllStock_CheckedChanged);
            // 
            // flowPanel
            // 
            this.flowPanel.AutoSize = true;
            this.flowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowPanel.Controls.Add(this.pnlPeriod);
            this.flowPanel.Controls.Add(this.chkByCategory);
            this.flowPanel.Controls.Add(this.chkByBrand);
            this.flowPanel.Controls.Add(this.chkAllStock);
            this.flowPanel.Controls.Add(this.pnlCategory);
            this.flowPanel.Controls.Add(this.pnlBrand);
            this.flowPanel.Controls.Add(this.pnlGrid);
            this.flowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanel.Location = new System.Drawing.Point(6, 56);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(1152, 580);
            this.flowPanel.TabIndex = 16;
            // 
            // chkByBrand
            // 
            this.chkByBrand.AutoSize = true;
            this.chkByBrand.Location = new System.Drawing.Point(3, 96);
            this.chkByBrand.Name = "chkByBrand";
            this.chkByBrand.Size = new System.Drawing.Size(102, 15);
            this.chkByBrand.TabIndex = 13;
            this.chkByBrand.Text = "By Brand Stock";
            this.chkByBrand.UseSelectable = true;
            this.chkByBrand.CheckedChanged += new System.EventHandler(this.chkByBrand_CheckedChanged);
            // 
            // pnlBrand
            // 
            this.pnlBrand.BackColor = System.Drawing.Color.RosyBrown;
            this.pnlBrand.Controls.Add(this.lblBrand);
            this.pnlBrand.Controls.Add(this.cbxBrands);
            this.pnlBrand.Location = new System.Drawing.Point(3, 185);
            this.pnlBrand.Name = "pnlBrand";
            this.pnlBrand.Size = new System.Drawing.Size(1143, 41);
            this.pnlBrand.TabIndex = 15;
            this.pnlBrand.Visible = false;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(7, 11);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(93, 19);
            this.lblBrand.TabIndex = 9;
            this.lblBrand.Text = "Select Brand : ";
            this.lblBrand.UseCustomBackColor = true;
            // 
            // cbxBrands
            // 
            this.cbxBrands.FormattingEnabled = true;
            this.cbxBrands.ItemHeight = 23;
            this.cbxBrands.Location = new System.Drawing.Point(123, 7);
            this.cbxBrands.Name = "cbxBrands";
            this.cbxBrands.Size = new System.Drawing.Size(360, 29);
            this.cbxBrands.TabIndex = 10;
            this.cbxBrands.UseSelectable = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AccountName";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn1.HeaderText = "Product Discription";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PackingSize";
            this.dataGridViewTextBoxColumn2.HeaderText = "Packing Size";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Opening";
            this.dataGridViewTextBoxColumn3.HeaderText = "OPening";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Purchases";
            this.dataGridViewTextBoxColumn4.HeaderText = "Purchases";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sales";
            this.dataGridViewTextBoxColumn5.HeaderText = "Sold";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Returns";
            this.dataGridViewTextBoxColumn6.HeaderText = "Returns";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Closing";
            this.dataGridViewTextBoxColumn7.HeaderText = "Closing Stock";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NVR";
            this.dataGridViewTextBoxColumn8.HeaderText = "NVR Balance";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 120;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "AVR";
            this.dataGridViewTextBoxColumn9.HeaderText = "AVR Balance";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 120;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "AVR";
            this.dataGridViewTextBoxColumn10.HeaderText = "AVR Balance";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // colAccountName
            // 
            this.colAccountName.DataPropertyName = "ItemName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAccountName.DefaultCellStyle = dataGridViewCellStyle3;
            this.colAccountName.HeaderText = "Product Discription";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.ReadOnly = true;
            this.colAccountName.Width = 220;
            // 
            // colPackingSize
            // 
            this.colPackingSize.DataPropertyName = "PackingSize";
            this.colPackingSize.HeaderText = "UOM";
            this.colPackingSize.Name = "colPackingSize";
            this.colPackingSize.ReadOnly = true;
            this.colPackingSize.Width = 70;
            // 
            // colOpening
            // 
            this.colOpening.DataPropertyName = "Opening";
            this.colOpening.HeaderText = "Opening";
            this.colOpening.Name = "colOpening";
            this.colOpening.ReadOnly = true;
            this.colOpening.Width = 70;
            // 
            // colPurchases
            // 
            this.colPurchases.DataPropertyName = "Purchases";
            this.colPurchases.HeaderText = "Purchases";
            this.colPurchases.Name = "colPurchases";
            this.colPurchases.ReadOnly = true;
            this.colPurchases.Width = 70;
            // 
            // colPurchasesReturn
            // 
            this.colPurchasesReturn.DataPropertyName = "PurchasesReturn";
            this.colPurchasesReturn.HeaderText = "P. Return";
            this.colPurchasesReturn.Name = "colPurchasesReturn";
            this.colPurchasesReturn.ReadOnly = true;
            this.colPurchasesReturn.Width = 80;
            // 
            // colSales
            // 
            this.colSales.DataPropertyName = "Sales";
            this.colSales.HeaderText = "Sold";
            this.colSales.Name = "colSales";
            this.colSales.ReadOnly = true;
            this.colSales.Width = 80;
            // 
            // colReturns
            // 
            this.colReturns.DataPropertyName = "Returns";
            this.colReturns.HeaderText = "S. Return";
            this.colReturns.Name = "colReturns";
            this.colReturns.ReadOnly = true;
            this.colReturns.Width = 80;
            // 
            // colStoreIn
            // 
            this.colStoreIn.DataPropertyName = "StoreIn";
            this.colStoreIn.HeaderText = "Store In";
            this.colStoreIn.Name = "colStoreIn";
            this.colStoreIn.ReadOnly = true;
            this.colStoreIn.Width = 70;
            // 
            // colStoreOut
            // 
            this.colStoreOut.DataPropertyName = "StoreOut";
            this.colStoreOut.HeaderText = "Store Out";
            this.colStoreOut.Name = "colStoreOut";
            this.colStoreOut.ReadOnly = true;
            this.colStoreOut.Width = 70;
            // 
            // colClosing
            // 
            this.colClosing.DataPropertyName = "Closing";
            this.colClosing.HeaderText = "Closing Stock";
            this.colClosing.Name = "colClosing";
            this.colClosing.ReadOnly = true;
            // 
            // colStockBalance
            // 
            this.colStockBalance.DataPropertyName = "NVR";
            this.colStockBalance.HeaderText = "NVR Balance";
            this.colStockBalance.Name = "colStockBalance";
            this.colStockBalance.ReadOnly = true;
            // 
            // colAVRBalance
            // 
            this.colAVRBalance.DataPropertyName = "AVR";
            this.colAVRBalance.HeaderText = "AVR Balance";
            this.colAVRBalance.Name = "colAVRBalance";
            this.colAVRBalance.ReadOnly = true;
            // 
            // frmTotalStock
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1166, 670);
            this.Controls.Add(this.flowPanel);
            this.KeyPreview = true;
            this.Name = "frmTotalStock";
            this.Text = "Stock Analysis";
            this.Load += new System.EventHandler(this.frmTotalStock_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmTotalStock_KeyPress);
            this.pnlPeriod.ResumeLayout(false);
            this.pnlPeriod.PerformLayout();
            this.ctxStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTotalStock)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            this.pnlGrid.PerformLayout();
            this.pnlCategory.ResumeLayout(false);
            this.pnlCategory.PerformLayout();
            this.flowPanel.ResumeLayout(false);
            this.flowPanel.PerformLayout();
            this.pnlBrand.ResumeLayout(false);
            this.pnlBrand.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox pnlPeriod;
        private System.Windows.Forms.DataGridView grdTotalStock;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox chkDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime EndDate;
        private MetroFramework.Controls.MetroDateTime StartDate;
        private MetroFramework.Controls.MetroTile btnExcelExport;
        private MetroFramework.Controls.MetroTile btnLoad;
        private MetroFramework.Controls.MetroComboBox CbxCategories;
        private MetroFramework.Controls.MetroTextBox txtsearch;
        private MetroFramework.Controls.MetroLabel lblSearch;
        private MetroFramework.Controls.MetroCheckBox chkByCategory;
        private System.Windows.Forms.Panel pnlGrid;
        private MetroFramework.Controls.MetroLabel lblSelectCategory;
        private System.Windows.Forms.Panel pnlCategory;
        private MetroFramework.Controls.MetroCheckBox chkAllStock;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private MetroFramework.Controls.MetroCheckBox chkByBrand;
        private System.Windows.Forms.Panel pnlBrand;
        private MetroFramework.Controls.MetroLabel lblBrand;
        private MetroFramework.Controls.MetroComboBox cbxBrands;
        private MetroFramework.Controls.MetroTile btnPrint;
        private System.Windows.Forms.ContextMenuStrip ctxStock;
        private System.Windows.Forms.ToolStripMenuItem printTotalStockReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printGroupingStockReportToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPackingSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOpening;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchases;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchasesReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReturns;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStoreIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStoreOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClosing;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAVRBalance;
    }
}