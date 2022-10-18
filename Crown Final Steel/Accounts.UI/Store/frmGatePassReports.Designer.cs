namespace Accounts.UI
{
    partial class frmGatePassReports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlReportTypes = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pnlDateWiseStock = new System.Windows.Forms.Panel();
            this.dtEndDateWiseStock = new MetroFramework.Controls.MetroDateTime();
            this.dtStartDateWiseStock = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnDateWiseStockReport = new System.Windows.Forms.Button();
            this.ddlReportTypes = new System.Windows.Forms.ComboBox();
            this.GrpProductSale = new System.Windows.Forms.GroupBox();
            this.chkProductDate = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.PEditBox = new MetroFramework.Controls.MetroTextBox();
            this.btnProductReport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlProductSaleDate = new System.Windows.Forms.Panel();
            this.dtProductStart = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.dtProductEnd = new MetroFramework.Controls.MetroDateTime();
            this.GrpPersonsale = new System.Windows.Forms.GroupBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.chkPersonDate = new MetroFramework.Controls.MetroCheckBox();
            this.PsEditBox = new MetroFramework.Controls.MetroTextBox();
            this.btnPersonReport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlPersonSaleDate = new System.Windows.Forms.Panel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.dtPrescriberEnd = new MetroFramework.Controls.MetroDateTime();
            this.dtPrescriberStart = new MetroFramework.Controls.MetroDateTime();
            this.pnlReportsGrid = new System.Windows.Forms.Panel();
            this.btnExcelExport = new MetroFramework.Controls.MetroTile();
            this.grdReports = new System.Windows.Forms.DataGridView();
            this.colVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlReportTypes.SuspendLayout();
            this.pnlDateWiseStock.SuspendLayout();
            this.GrpProductSale.SuspendLayout();
            this.pnlProductSaleDate.SuspendLayout();
            this.GrpPersonsale.SuspendLayout();
            this.pnlPersonSaleDate.SuspendLayout();
            this.pnlReportsGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReports)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.pnlReportTypes);
            this.flowLayoutPanel1.Controls.Add(this.GrpProductSale);
            this.flowLayoutPanel1.Controls.Add(this.GrpPersonsale);
            this.flowLayoutPanel1.Controls.Add(this.pnlReportsGrid);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1010, 675);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pnlReportTypes
            // 
            this.pnlReportTypes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlReportTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReportTypes.Controls.Add(this.metroLabel1);
            this.pnlReportTypes.Controls.Add(this.pnlDateWiseStock);
            this.pnlReportTypes.Controls.Add(this.ddlReportTypes);
            this.pnlReportTypes.Location = new System.Drawing.Point(3, 3);
            this.pnlReportTypes.Name = "pnlReportTypes";
            this.pnlReportTypes.Size = new System.Drawing.Size(1002, 41);
            this.pnlReportTypes.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 6);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Select Type :";
            // 
            // pnlDateWiseStock
            // 
            this.pnlDateWiseStock.Controls.Add(this.dtEndDateWiseStock);
            this.pnlDateWiseStock.Controls.Add(this.dtStartDateWiseStock);
            this.pnlDateWiseStock.Controls.Add(this.metroLabel2);
            this.pnlDateWiseStock.Controls.Add(this.metroLabel5);
            this.pnlDateWiseStock.Controls.Add(this.btnDateWiseStockReport);
            this.pnlDateWiseStock.Location = new System.Drawing.Point(280, 3);
            this.pnlDateWiseStock.Name = "pnlDateWiseStock";
            this.pnlDateWiseStock.Size = new System.Drawing.Size(716, 33);
            this.pnlDateWiseStock.TabIndex = 2;
            // 
            // dtEndDateWiseStock
            // 
            this.dtEndDateWiseStock.Location = new System.Drawing.Point(343, 1);
            this.dtEndDateWiseStock.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEndDateWiseStock.Name = "dtEndDateWiseStock";
            this.dtEndDateWiseStock.Size = new System.Drawing.Size(222, 29);
            this.dtEndDateWiseStock.TabIndex = 1;
            // 
            // dtStartDateWiseStock
            // 
            this.dtStartDateWiseStock.Location = new System.Drawing.Point(62, 1);
            this.dtStartDateWiseStock.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStartDateWiseStock.Name = "dtStartDateWiseStock";
            this.dtStartDateWiseStock.Size = new System.Drawing.Size(222, 29);
            this.dtStartDateWiseStock.TabIndex = 1;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 5);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Start :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(292, 6);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(38, 19);
            this.metroLabel5.TabIndex = 1;
            this.metroLabel5.Text = "End :";
            // 
            // btnDateWiseStockReport
            // 
            this.btnDateWiseStockReport.BackColor = System.Drawing.Color.AliceBlue;
            this.btnDateWiseStockReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateWiseStockReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateWiseStockReport.ForeColor = System.Drawing.Color.Black;
            this.btnDateWiseStockReport.Location = new System.Drawing.Point(593, 3);
            this.btnDateWiseStockReport.Name = "btnDateWiseStockReport";
            this.btnDateWiseStockReport.Size = new System.Drawing.Size(101, 25);
            this.btnDateWiseStockReport.TabIndex = 2;
            this.btnDateWiseStockReport.Text = "Load Report";
            this.btnDateWiseStockReport.UseVisualStyleBackColor = false;
            this.btnDateWiseStockReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // ddlReportTypes
            // 
            this.ddlReportTypes.FormattingEnabled = true;
            this.ddlReportTypes.Location = new System.Drawing.Point(89, 6);
            this.ddlReportTypes.Name = "ddlReportTypes";
            this.ddlReportTypes.Size = new System.Drawing.Size(167, 21);
            this.ddlReportTypes.TabIndex = 1;
            this.ddlReportTypes.SelectedIndexChanged += new System.EventHandler(this.ddlReportTypes_SelectedIndexChanged);
            // 
            // GrpProductSale
            // 
            this.GrpProductSale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GrpProductSale.AutoSize = true;
            this.GrpProductSale.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GrpProductSale.Controls.Add(this.chkProductDate);
            this.GrpProductSale.Controls.Add(this.metroLabel10);
            this.GrpProductSale.Controls.Add(this.PEditBox);
            this.GrpProductSale.Controls.Add(this.btnProductReport);
            this.GrpProductSale.Controls.Add(this.panel2);
            this.GrpProductSale.Controls.Add(this.pnlProductSaleDate);
            this.GrpProductSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrpProductSale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpProductSale.ForeColor = System.Drawing.SystemColors.Desktop;
            this.GrpProductSale.Location = new System.Drawing.Point(3, 50);
            this.GrpProductSale.Name = "GrpProductSale";
            this.GrpProductSale.Size = new System.Drawing.Size(1003, 126);
            this.GrpProductSale.TabIndex = 1;
            this.GrpProductSale.TabStop = false;
            this.GrpProductSale.Text = "Product Issuance Report";
            // 
            // chkProductDate
            // 
            this.chkProductDate.AutoSize = true;
            this.chkProductDate.Location = new System.Drawing.Point(523, 26);
            this.chkProductDate.Name = "chkProductDate";
            this.chkProductDate.Size = new System.Drawing.Size(89, 15);
            this.chkProductDate.TabIndex = 1;
            this.chkProductDate.Text = "Include Date";
            this.chkProductDate.UseSelectable = true;
            this.chkProductDate.CheckedChanged += new System.EventHandler(this.chkDate_CheckedChanged);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(7, 22);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(102, 19);
            this.metroLabel10.TabIndex = 1;
            this.metroLabel10.Text = "Product Name :";
            // 
            // PEditBox
            // 
            // 
            // 
            // 
            this.PEditBox.CustomButton.Image = null;
            this.PEditBox.CustomButton.Location = new System.Drawing.Point(382, 1);
            this.PEditBox.CustomButton.Name = "";
            this.PEditBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PEditBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PEditBox.CustomButton.TabIndex = 1;
            this.PEditBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PEditBox.CustomButton.UseSelectable = true;
            this.PEditBox.Lines = new string[0];
            this.PEditBox.Location = new System.Drawing.Point(113, 21);
            this.PEditBox.MaxLength = 32767;
            this.PEditBox.Name = "PEditBox";
            this.PEditBox.PasswordChar = '\0';
            this.PEditBox.PromptText = "Select Product Name";
            this.PEditBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PEditBox.SelectedText = "";
            this.PEditBox.SelectionLength = 0;
            this.PEditBox.SelectionStart = 0;
            this.PEditBox.ShortcutsEnabled = true;
            this.PEditBox.ShowButton = true;
            this.PEditBox.Size = new System.Drawing.Size(404, 23);
            this.PEditBox.TabIndex = 1;
            this.PEditBox.UseSelectable = true;
            this.PEditBox.WaterMark = "Select Product Name";
            this.PEditBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PEditBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PEditBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.PEditBox_ButtonClick);
            this.PEditBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PEditBox_KeyPress);
            // 
            // btnProductReport
            // 
            this.btnProductReport.BackColor = System.Drawing.Color.AliceBlue;
            this.btnProductReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductReport.ForeColor = System.Drawing.Color.Black;
            this.btnProductReport.Location = new System.Drawing.Point(622, 19);
            this.btnProductReport.Name = "btnProductReport";
            this.btnProductReport.Size = new System.Drawing.Size(101, 25);
            this.btnProductReport.TabIndex = 2;
            this.btnProductReport.Text = "Load Report";
            this.btnProductReport.UseVisualStyleBackColor = false;
            this.btnProductReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(742, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 19);
            this.panel2.TabIndex = 13;
            // 
            // pnlProductSaleDate
            // 
            this.pnlProductSaleDate.Controls.Add(this.dtProductStart);
            this.pnlProductSaleDate.Controls.Add(this.metroLabel3);
            this.pnlProductSaleDate.Controls.Add(this.metroLabel6);
            this.pnlProductSaleDate.Controls.Add(this.dtProductEnd);
            this.pnlProductSaleDate.Location = new System.Drawing.Point(6, 55);
            this.pnlProductSaleDate.Name = "pnlProductSaleDate";
            this.pnlProductSaleDate.Size = new System.Drawing.Size(986, 49);
            this.pnlProductSaleDate.TabIndex = 3;
            // 
            // dtProductStart
            // 
            this.dtProductStart.Location = new System.Drawing.Point(63, 9);
            this.dtProductStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtProductStart.Name = "dtProductStart";
            this.dtProductStart.Size = new System.Drawing.Size(231, 29);
            this.dtProductStart.TabIndex = 1;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 13);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(43, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Start :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(303, 13);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(38, 19);
            this.metroLabel6.TabIndex = 1;
            this.metroLabel6.Text = "End :";
            // 
            // dtProductEnd
            // 
            this.dtProductEnd.Location = new System.Drawing.Point(344, 8);
            this.dtProductEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtProductEnd.Name = "dtProductEnd";
            this.dtProductEnd.Size = new System.Drawing.Size(228, 29);
            this.dtProductEnd.TabIndex = 1;
            // 
            // GrpPersonsale
            // 
            this.GrpPersonsale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GrpPersonsale.AutoSize = true;
            this.GrpPersonsale.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GrpPersonsale.Controls.Add(this.metroLabel11);
            this.GrpPersonsale.Controls.Add(this.chkPersonDate);
            this.GrpPersonsale.Controls.Add(this.PsEditBox);
            this.GrpPersonsale.Controls.Add(this.btnPersonReport);
            this.GrpPersonsale.Controls.Add(this.panel1);
            this.GrpPersonsale.Controls.Add(this.pnlPersonSaleDate);
            this.GrpPersonsale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrpPersonsale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpPersonsale.ForeColor = System.Drawing.SystemColors.Desktop;
            this.GrpPersonsale.Location = new System.Drawing.Point(7, 182);
            this.GrpPersonsale.Name = "GrpPersonsale";
            this.GrpPersonsale.Size = new System.Drawing.Size(994, 128);
            this.GrpPersonsale.TabIndex = 1;
            this.GrpPersonsale.TabStop = false;
            this.GrpPersonsale.Text = "Employee Issuance Report";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(5, 23);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(103, 19);
            this.metroLabel11.TabIndex = 1;
            this.metroLabel11.Text = "Account Name :";
            // 
            // chkPersonDate
            // 
            this.chkPersonDate.AutoSize = true;
            this.chkPersonDate.Location = new System.Drawing.Point(519, 27);
            this.chkPersonDate.Name = "chkPersonDate";
            this.chkPersonDate.Size = new System.Drawing.Size(89, 15);
            this.chkPersonDate.TabIndex = 1;
            this.chkPersonDate.Text = "Include Date";
            this.chkPersonDate.UseSelectable = true;
            this.chkPersonDate.CheckedChanged += new System.EventHandler(this.chkDate_CheckedChanged);
            // 
            // PsEditBox
            // 
            // 
            // 
            // 
            this.PsEditBox.CustomButton.Image = null;
            this.PsEditBox.CustomButton.Location = new System.Drawing.Point(381, 1);
            this.PsEditBox.CustomButton.Name = "";
            this.PsEditBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PsEditBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PsEditBox.CustomButton.TabIndex = 1;
            this.PsEditBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PsEditBox.CustomButton.UseSelectable = true;
            this.PsEditBox.Lines = new string[0];
            this.PsEditBox.Location = new System.Drawing.Point(110, 22);
            this.PsEditBox.MaxLength = 32767;
            this.PsEditBox.Name = "PsEditBox";
            this.PsEditBox.PasswordChar = '\0';
            this.PsEditBox.PromptText = "Account Name here";
            this.PsEditBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PsEditBox.SelectedText = "";
            this.PsEditBox.SelectionLength = 0;
            this.PsEditBox.SelectionStart = 0;
            this.PsEditBox.ShortcutsEnabled = true;
            this.PsEditBox.ShowButton = true;
            this.PsEditBox.Size = new System.Drawing.Size(403, 23);
            this.PsEditBox.TabIndex = 1;
            this.PsEditBox.UseSelectable = true;
            this.PsEditBox.WaterMark = "Account Name here";
            this.PsEditBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PsEditBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PsEditBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.PsEditBox_ButtonClick);
            this.PsEditBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PsEditBox_KeyPress);
            // 
            // btnPersonReport
            // 
            this.btnPersonReport.BackColor = System.Drawing.Color.AliceBlue;
            this.btnPersonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonReport.ForeColor = System.Drawing.Color.Black;
            this.btnPersonReport.Location = new System.Drawing.Point(624, 22);
            this.btnPersonReport.Name = "btnPersonReport";
            this.btnPersonReport.Size = new System.Drawing.Size(101, 25);
            this.btnPersonReport.TabIndex = 2;
            this.btnPersonReport.Text = "Load Report";
            this.btnPersonReport.UseVisualStyleBackColor = false;
            this.btnPersonReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(742, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 19);
            this.panel1.TabIndex = 13;
            // 
            // pnlPersonSaleDate
            // 
            this.pnlPersonSaleDate.Controls.Add(this.metroLabel4);
            this.pnlPersonSaleDate.Controls.Add(this.metroLabel7);
            this.pnlPersonSaleDate.Controls.Add(this.dtPrescriberEnd);
            this.pnlPersonSaleDate.Controls.Add(this.dtPrescriberStart);
            this.pnlPersonSaleDate.Location = new System.Drawing.Point(6, 57);
            this.pnlPersonSaleDate.Name = "pnlPersonSaleDate";
            this.pnlPersonSaleDate.Size = new System.Drawing.Size(982, 49);
            this.pnlPersonSaleDate.TabIndex = 3;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(7, 15);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(43, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Start :";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(299, 15);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(38, 19);
            this.metroLabel7.TabIndex = 1;
            this.metroLabel7.Text = "End :";
            // 
            // dtPrescriberEnd
            // 
            this.dtPrescriberEnd.Location = new System.Drawing.Point(346, 10);
            this.dtPrescriberEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtPrescriberEnd.Name = "dtPrescriberEnd";
            this.dtPrescriberEnd.Size = new System.Drawing.Size(225, 29);
            this.dtPrescriberEnd.TabIndex = 1;
            // 
            // dtPrescriberStart
            // 
            this.dtPrescriberStart.Location = new System.Drawing.Point(64, 10);
            this.dtPrescriberStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtPrescriberStart.Name = "dtPrescriberStart";
            this.dtPrescriberStart.Size = new System.Drawing.Size(225, 29);
            this.dtPrescriberStart.TabIndex = 1;
            // 
            // pnlReportsGrid
            // 
            this.pnlReportsGrid.Controls.Add(this.btnExcelExport);
            this.pnlReportsGrid.Controls.Add(this.grdReports);
            this.pnlReportsGrid.Location = new System.Drawing.Point(3, 316);
            this.pnlReportsGrid.Name = "pnlReportsGrid";
            this.pnlReportsGrid.Size = new System.Drawing.Size(1000, 356);
            this.pnlReportsGrid.TabIndex = 4;
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.ActiveControl = null;
            this.btnExcelExport.Location = new System.Drawing.Point(876, 310);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(115, 42);
            this.btnExcelExport.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnExcelExport.TabIndex = 1;
            this.btnExcelExport.Text = "Excel Export";
            this.btnExcelExport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcelExport.UseSelectable = true;
            this.btnExcelExport.Click += new System.EventHandler(this.btnExcelExport_Click);
            // 
            // grdReports
            // 
            this.grdReports.AllowUserToAddRows = false;
            this.grdReports.AllowUserToDeleteRows = false;
            this.grdReports.BackgroundColor = System.Drawing.Color.Snow;
            this.grdReports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdReports.ColumnHeadersHeight = 25;
            this.grdReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVoucherNo,
            this.colProductCode,
            this.colProductName,
            this.colPersonName,
            this.colUnits,
            this.colUnitPrice,
            this.colAmount});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdReports.DefaultCellStyle = dataGridViewCellStyle4;
            this.grdReports.EnableHeadersVisualStyles = false;
            this.grdReports.Location = new System.Drawing.Point(6, 15);
            this.grdReports.Name = "grdReports";
            this.grdReports.ReadOnly = true;
            this.grdReports.RowHeadersVisible = false;
            this.grdReports.Size = new System.Drawing.Size(985, 289);
            this.grdReports.TabIndex = 0;
            // 
            // colVoucherNo
            // 
            this.colVoucherNo.HeaderText = "VoucherNo";
            this.colVoucherNo.Name = "colVoucherNo";
            this.colVoucherNo.ReadOnly = true;
            this.colVoucherNo.Width = 80;
            // 
            // colProductCode
            // 
            this.colProductCode.HeaderText = "Product Code";
            this.colProductCode.Name = "colProductCode";
            this.colProductCode.ReadOnly = true;
            // 
            // colProductName
            // 
            this.colProductName.HeaderText = "Product Name";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            this.colProductName.Width = 200;
            // 
            // colPersonName
            // 
            this.colPersonName.HeaderText = "PersonName";
            this.colPersonName.Name = "colPersonName";
            this.colPersonName.ReadOnly = true;
            this.colPersonName.Width = 150;
            // 
            // colUnits
            // 
            this.colUnits.HeaderText = "Issued Units";
            this.colUnits.Name = "colUnits";
            this.colUnits.ReadOnly = true;
            this.colUnits.Width = 110;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.HeaderText = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 80;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "VoucherNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Product Code";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "PersonName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Units";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "UnitPrice";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // frmGatePassReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1050, 755);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmGatePassReports";
            this.Text = "General Stock Issuance Reports";
            this.Load += new System.EventHandler(this.frmGatePassReports_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.pnlReportTypes.ResumeLayout(false);
            this.pnlReportTypes.PerformLayout();
            this.pnlDateWiseStock.ResumeLayout(false);
            this.pnlDateWiseStock.PerformLayout();
            this.GrpProductSale.ResumeLayout(false);
            this.GrpProductSale.PerformLayout();
            this.pnlProductSaleDate.ResumeLayout(false);
            this.pnlProductSaleDate.PerformLayout();
            this.GrpPersonsale.ResumeLayout(false);
            this.GrpPersonsale.PerformLayout();
            this.pnlPersonSaleDate.ResumeLayout(false);
            this.pnlPersonSaleDate.PerformLayout();
            this.pnlReportsGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox GrpProductSale;
        private System.Windows.Forms.Panel pnlProductSaleDate;
        private System.Windows.Forms.GroupBox GrpPersonsale;
        private System.Windows.Forms.Panel pnlPersonSaleDate;
        private System.Windows.Forms.Panel pnlReportTypes;
        private System.Windows.Forms.ComboBox ddlReportTypes;
        private System.Windows.Forms.Button btnPersonReport;
        private System.Windows.Forms.Button btnProductReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlReportsGrid;
        private System.Windows.Forms.DataGridView grdReports;
        private System.Windows.Forms.Panel pnlDateWiseStock;
        private System.Windows.Forms.Button btnDateWiseStockReport;
        private MetroFramework.Controls.MetroDateTime dtProductStart;
        private MetroFramework.Controls.MetroDateTime dtProductEnd;
        private MetroFramework.Controls.MetroDateTime dtPrescriberEnd;
        private MetroFramework.Controls.MetroDateTime dtPrescriberStart;
        private MetroFramework.Controls.MetroDateTime dtEndDateWiseStock;
        private MetroFramework.Controls.MetroDateTime dtStartDateWiseStock;
        private MetroFramework.Controls.MetroTextBox PsEditBox;
        private MetroFramework.Controls.MetroTextBox PEditBox;
        private MetroFramework.Controls.MetroCheckBox chkProductDate;
        private MetroFramework.Controls.MetroCheckBox chkPersonDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTile btnExcelExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}