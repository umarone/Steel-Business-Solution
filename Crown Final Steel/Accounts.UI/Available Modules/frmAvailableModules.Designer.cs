namespace Accounts.UI
{
    partial class frmAvailableModules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAvailableModules));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tabModules = new MetroFramework.Controls.MetroTabControl();
            this.mTabModules = new MetroFramework.Controls.MetroTabPage();
            this.mTabAdministrationReportModules = new System.Windows.Forms.TabPage();
            this.mTabStockReportModules = new MetroFramework.Controls.MetroTabPage();
            this.mTabFinancialReportModules = new System.Windows.Forms.TabPage();
            this.cbxModuleCategories = new MetroFramework.Controls.MetroComboBox();
            this.lblFilter = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.grdAvailableModules = new Accounts.UI.CustomDataGrid();
            this.colIdModules = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModuleCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModuleCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreview = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grdAvailableAdministration = new Accounts.UI.CustomDataGrid();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grdAvailableModulesReports = new Accounts.UI.CustomDataGrid();
            this.colIdReportModule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReportModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReportModuleCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReportModuleCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModuleReportPreview = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grdAvailableFinancialModules = new Accounts.UI.CustomDataGrid();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabModules.SuspendLayout();
            this.mTabModules.SuspendLayout();
            this.mTabAdministrationReportModules.SuspendLayout();
            this.mTabStockReportModules.SuspendLayout();
            this.mTabFinancialReportModules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAvailableModules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAvailableAdministration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAvailableModulesReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAvailableFinancialModules)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(760, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // tabModules
            // 
            this.tabModules.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabModules.Controls.Add(this.mTabModules);
            this.tabModules.Controls.Add(this.mTabAdministrationReportModules);
            this.tabModules.Controls.Add(this.mTabStockReportModules);
            this.tabModules.Controls.Add(this.mTabFinancialReportModules);
            this.tabModules.Location = new System.Drawing.Point(20, 112);
            this.tabModules.Name = "tabModules";
            this.tabModules.SelectedIndex = 1;
            this.tabModules.Size = new System.Drawing.Size(765, 421);
            this.tabModules.TabIndex = 0;
            this.tabModules.UseSelectable = true;
            // 
            // mTabModules
            // 
            this.mTabModules.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mTabModules.Controls.Add(this.grdAvailableModules);
            this.mTabModules.HorizontalScrollbarBarColor = true;
            this.mTabModules.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabModules.HorizontalScrollbarSize = 10;
            this.mTabModules.Location = new System.Drawing.Point(4, 41);
            this.mTabModules.Name = "mTabModules";
            this.mTabModules.Size = new System.Drawing.Size(757, 376);
            this.mTabModules.TabIndex = 0;
            this.mTabModules.Text = "Available Modules";
            this.mTabModules.VerticalScrollbarBarColor = true;
            this.mTabModules.VerticalScrollbarHighlightOnWheel = false;
            this.mTabModules.VerticalScrollbarSize = 10;
            // 
            // mTabAdministrationReportModules
            // 
            this.mTabAdministrationReportModules.Controls.Add(this.grdAvailableAdministration);
            this.mTabAdministrationReportModules.Location = new System.Drawing.Point(4, 41);
            this.mTabAdministrationReportModules.Name = "mTabAdministrationReportModules";
            this.mTabAdministrationReportModules.Size = new System.Drawing.Size(757, 376);
            this.mTabAdministrationReportModules.TabIndex = 3;
            this.mTabAdministrationReportModules.Text = "Available Administration Reports";
            // 
            // mTabStockReportModules
            // 
            this.mTabStockReportModules.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mTabStockReportModules.Controls.Add(this.grdAvailableModulesReports);
            this.mTabStockReportModules.HorizontalScrollbarBarColor = true;
            this.mTabStockReportModules.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabStockReportModules.HorizontalScrollbarSize = 10;
            this.mTabStockReportModules.Location = new System.Drawing.Point(4, 41);
            this.mTabStockReportModules.Name = "mTabStockReportModules";
            this.mTabStockReportModules.Size = new System.Drawing.Size(757, 376);
            this.mTabStockReportModules.TabIndex = 1;
            this.mTabStockReportModules.Text = "Available Stock Report";
            this.mTabStockReportModules.VerticalScrollbarBarColor = true;
            this.mTabStockReportModules.VerticalScrollbarHighlightOnWheel = false;
            this.mTabStockReportModules.VerticalScrollbarSize = 10;
            // 
            // mTabFinancialReportModules
            // 
            this.mTabFinancialReportModules.Controls.Add(this.grdAvailableFinancialModules);
            this.mTabFinancialReportModules.Location = new System.Drawing.Point(4, 41);
            this.mTabFinancialReportModules.Name = "mTabFinancialReportModules";
            this.mTabFinancialReportModules.Size = new System.Drawing.Size(757, 376);
            this.mTabFinancialReportModules.TabIndex = 2;
            this.mTabFinancialReportModules.Text = "Available Financial Report";
            // 
            // cbxModuleCategories
            // 
            this.cbxModuleCategories.FormattingEnabled = true;
            this.cbxModuleCategories.ItemHeight = 23;
            this.cbxModuleCategories.Items.AddRange(new object[] {
            "",
            "Available Modules",
            "Administration Modules",
            "Stock Modules Report",
            "Financial Modules Report"});
            this.cbxModuleCategories.Location = new System.Drawing.Point(100, 74);
            this.cbxModuleCategories.Name = "cbxModuleCategories";
            this.cbxModuleCategories.Size = new System.Drawing.Size(365, 29);
            this.cbxModuleCategories.TabIndex = 1;
            this.cbxModuleCategories.UseSelectable = true;
            this.cbxModuleCategories.SelectedIndexChanged += new System.EventHandler(this.cbxModuleCategories_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.BackColor = System.Drawing.Color.MistyRose;
            this.lblFilter.Location = new System.Drawing.Point(32, 79);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(63, 19);
            this.lblFilter.TabIndex = 2;
            this.lblFilter.Text = "Filter By :";
            this.lblFilter.UseCustomBackColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.MistyRose;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(25, 68);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(760, 41);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // grdAvailableModules
            // 
            this.grdAvailableModules.AllowUserToAddRows = false;
            this.grdAvailableModules.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdAvailableModules.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdAvailableModules.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAvailableModules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdAvailableModules.ColumnHeadersHeight = 25;
            this.grdAvailableModules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdModules,
            this.colModuleName,
            this.colModuleCategory,
            this.colModuleCost,
            this.colPreview});
            this.grdAvailableModules.EnableHeadersVisualStyles = false;
            this.grdAvailableModules.Location = new System.Drawing.Point(1, 4);
            this.grdAvailableModules.MultiSelect = false;
            this.grdAvailableModules.Name = "grdAvailableModules";
            this.grdAvailableModules.ReadOnly = true;
            this.grdAvailableModules.RowHeadersVisible = false;
            this.grdAvailableModules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAvailableModules.Size = new System.Drawing.Size(760, 366);
            this.grdAvailableModules.TabIndex = 2;
            this.grdAvailableModules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAvailableModules_CellClick);
            this.grdAvailableModules.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdAvailableModules_CellFormatting);
            // 
            // colIdModules
            // 
            this.colIdModules.DataPropertyName = "IdModule";
            this.colIdModules.HeaderText = "IdModule";
            this.colIdModules.Name = "colIdModules";
            this.colIdModules.ReadOnly = true;
            this.colIdModules.Visible = false;
            // 
            // colModuleName
            // 
            this.colModuleName.DataPropertyName = "ModuleName";
            this.colModuleName.HeaderText = "Module Name";
            this.colModuleName.Name = "colModuleName";
            this.colModuleName.ReadOnly = true;
            this.colModuleName.Width = 390;
            // 
            // colModuleCategory
            // 
            this.colModuleCategory.DataPropertyName = "ModuleCategory";
            this.colModuleCategory.HeaderText = "Category";
            this.colModuleCategory.Name = "colModuleCategory";
            this.colModuleCategory.ReadOnly = true;
            this.colModuleCategory.Width = 150;
            // 
            // colModuleCost
            // 
            this.colModuleCost.DataPropertyName = "ModuleCost";
            this.colModuleCost.HeaderText = "Module Cost";
            this.colModuleCost.Name = "colModuleCost";
            this.colModuleCost.ReadOnly = true;
            // 
            // colPreview
            // 
            this.colPreview.HeaderText = "...";
            this.colPreview.Name = "colPreview";
            this.colPreview.ReadOnly = true;
            this.colPreview.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPreview.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // grdAvailableAdministration
            // 
            this.grdAvailableAdministration.AllowUserToAddRows = false;
            this.grdAvailableAdministration.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdAvailableAdministration.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grdAvailableAdministration.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAvailableAdministration.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdAvailableAdministration.ColumnHeadersHeight = 25;
            this.grdAvailableAdministration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewButtonColumn2});
            this.grdAvailableAdministration.EnableHeadersVisualStyles = false;
            this.grdAvailableAdministration.Location = new System.Drawing.Point(4, 5);
            this.grdAvailableAdministration.MultiSelect = false;
            this.grdAvailableAdministration.Name = "grdAvailableAdministration";
            this.grdAvailableAdministration.ReadOnly = true;
            this.grdAvailableAdministration.RowHeadersVisible = false;
            this.grdAvailableAdministration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAvailableAdministration.Size = new System.Drawing.Size(750, 366);
            this.grdAvailableAdministration.TabIndex = 3;
            this.grdAvailableAdministration.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAvailableAdministration_CellClick);
            this.grdAvailableAdministration.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdAvailableAdministration_CellFormatting);
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "IdModule";
            this.dataGridViewTextBoxColumn13.HeaderText = "IdModule";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "ModuleName";
            this.dataGridViewTextBoxColumn14.HeaderText = "Module Name";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 390;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "ModuleCategory";
            this.dataGridViewTextBoxColumn15.HeaderText = "Category";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 150;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "ModuleCost";
            this.dataGridViewTextBoxColumn16.HeaderText = "Module Cost";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "...";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            this.dataGridViewButtonColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // grdAvailableModulesReports
            // 
            this.grdAvailableModulesReports.AllowUserToAddRows = false;
            this.grdAvailableModulesReports.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdAvailableModulesReports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdAvailableModulesReports.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAvailableModulesReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdAvailableModulesReports.ColumnHeadersHeight = 25;
            this.grdAvailableModulesReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdReportModule,
            this.colReportModuleName,
            this.colReportModuleCategory,
            this.colReportModuleCost,
            this.colModuleReportPreview});
            this.grdAvailableModulesReports.EnableHeadersVisualStyles = false;
            this.grdAvailableModulesReports.Location = new System.Drawing.Point(2, 5);
            this.grdAvailableModulesReports.MultiSelect = false;
            this.grdAvailableModulesReports.Name = "grdAvailableModulesReports";
            this.grdAvailableModulesReports.ReadOnly = true;
            this.grdAvailableModulesReports.RowHeadersVisible = false;
            this.grdAvailableModulesReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAvailableModulesReports.Size = new System.Drawing.Size(759, 366);
            this.grdAvailableModulesReports.TabIndex = 3;
            this.grdAvailableModulesReports.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAvailableModulesReports_CellClick);
            this.grdAvailableModulesReports.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdAvailableModulesReports_CellFormatting);
            // 
            // colIdReportModule
            // 
            this.colIdReportModule.DataPropertyName = "IdModule";
            this.colIdReportModule.HeaderText = "IdReportModule";
            this.colIdReportModule.Name = "colIdReportModule";
            this.colIdReportModule.ReadOnly = true;
            this.colIdReportModule.Visible = false;
            // 
            // colReportModuleName
            // 
            this.colReportModuleName.DataPropertyName = "ModuleName";
            this.colReportModuleName.HeaderText = "Report Name";
            this.colReportModuleName.Name = "colReportModuleName";
            this.colReportModuleName.ReadOnly = true;
            this.colReportModuleName.Width = 390;
            // 
            // colReportModuleCategory
            // 
            this.colReportModuleCategory.DataPropertyName = "ModuleCategory";
            this.colReportModuleCategory.HeaderText = "Category";
            this.colReportModuleCategory.Name = "colReportModuleCategory";
            this.colReportModuleCategory.ReadOnly = true;
            this.colReportModuleCategory.Width = 150;
            // 
            // colReportModuleCost
            // 
            this.colReportModuleCost.DataPropertyName = "ModuleCost";
            this.colReportModuleCost.HeaderText = "Report Cost";
            this.colReportModuleCost.Name = "colReportModuleCost";
            this.colReportModuleCost.ReadOnly = true;
            // 
            // colModuleReportPreview
            // 
            this.colModuleReportPreview.HeaderText = "...";
            this.colModuleReportPreview.Name = "colModuleReportPreview";
            this.colModuleReportPreview.ReadOnly = true;
            this.colModuleReportPreview.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colModuleReportPreview.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // grdAvailableFinancialModules
            // 
            this.grdAvailableFinancialModules.AllowUserToAddRows = false;
            this.grdAvailableFinancialModules.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdAvailableFinancialModules.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grdAvailableFinancialModules.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAvailableFinancialModules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdAvailableFinancialModules.ColumnHeadersHeight = 25;
            this.grdAvailableFinancialModules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewButtonColumn1});
            this.grdAvailableFinancialModules.EnableHeadersVisualStyles = false;
            this.grdAvailableFinancialModules.Location = new System.Drawing.Point(4, 5);
            this.grdAvailableFinancialModules.MultiSelect = false;
            this.grdAvailableFinancialModules.Name = "grdAvailableFinancialModules";
            this.grdAvailableFinancialModules.ReadOnly = true;
            this.grdAvailableFinancialModules.RowHeadersVisible = false;
            this.grdAvailableFinancialModules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAvailableFinancialModules.Size = new System.Drawing.Size(746, 366);
            this.grdAvailableFinancialModules.TabIndex = 3;
            this.grdAvailableFinancialModules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAvailableFinancialModules_CellClick);
            this.grdAvailableFinancialModules.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdAvailableFinancialModules_CellFormatting);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IdModule";
            this.dataGridViewTextBoxColumn9.HeaderText = "IdModule";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ModuleName";
            this.dataGridViewTextBoxColumn10.HeaderText = "Module Name";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 390;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ModuleCategory";
            this.dataGridViewTextBoxColumn11.HeaderText = "Category";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ModuleCost";
            this.dataGridViewTextBoxColumn12.HeaderText = "Report Cost";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "...";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdModule";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdModule";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ModuleName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Module Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 400;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ModuleCost";
            this.dataGridViewTextBoxColumn3.HeaderText = "Module Cost";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdModule";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdReportModule";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ModuleName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Report Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 400;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ModuleCost";
            this.dataGridViewTextBoxColumn6.HeaderText = "Report Cost";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 400;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ModuleCategory";
            this.dataGridViewTextBoxColumn7.HeaderText = "Category";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ModuleCost";
            this.dataGridViewTextBoxColumn8.HeaderText = "Report Cost";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // frmAvailableModules
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(804, 564);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cbxModuleCategories);
            this.Controls.Add(this.tabModules);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroPanel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmAvailableModules";
            this.Text = "Available Modules";
            this.Load += new System.EventHandler(this.frmAvailableModules_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAvailableModules_KeyPress);
            this.tabModules.ResumeLayout(false);
            this.mTabModules.ResumeLayout(false);
            this.mTabAdministrationReportModules.ResumeLayout(false);
            this.mTabStockReportModules.ResumeLayout(false);
            this.mTabFinancialReportModules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAvailableModules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAvailableAdministration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAvailableModulesReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAvailableFinancialModules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTabControl tabModules;
        private MetroFramework.Controls.MetroTabPage mTabModules;
        private MetroFramework.Controls.MetroTabPage mTabStockReportModules;
        private CustomDataGrid grdAvailableModules;
        private CustomDataGrid grdAvailableModulesReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private MetroFramework.Controls.MetroComboBox cbxModuleCategories;
        private MetroFramework.Controls.MetroLabel lblFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdReportModule;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReportModuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReportModuleCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReportModuleCost;
        private System.Windows.Forms.DataGridViewButtonColumn colModuleReportPreview;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdModules;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModuleCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModuleCost;
        private System.Windows.Forms.DataGridViewButtonColumn colPreview;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.TabPage mTabFinancialReportModules;
        private CustomDataGrid grdAvailableFinancialModules;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.TabPage mTabAdministrationReportModules;
        private CustomDataGrid grdAvailableAdministration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
    }
}