namespace Accounts.UI
{
    partial class frmSamples
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpSales = new System.Windows.Forms.GroupBox();
            this.cbxEmployees = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.EmpEditCode = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtGatePass = new MetroFramework.Controls.MetroTextBox();
            this.txtSampleDays = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtDemandNo = new MetroFramework.Controls.MetroTextBox();
            this.lblMemoNo = new MetroFramework.Controls.MetroLabel();
            this.chkPosted = new MetroFramework.Controls.MetroCheckBox();
            this.VDate = new MetroFramework.Controls.MetroDateTime();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.InvSampleBox = new MetroFramework.Controls.MetroTextBox();
            this.lblDescription = new MetroFramework.Controls.MetroLabel();
            this.lblInvoiceNo = new MetroFramework.Controls.MetroLabel();
            this.SalesEditBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtNTN = new MetroFramework.Controls.MetroTextBox();
            this.txtContact = new MetroFramework.Controls.MetroTextBox();
            this.lblAddress = new MetroFramework.Controls.MetroLabel();
            this.txtCustomerName = new MetroFramework.Controls.MetroTextBox();
            this.CustEditBox = new MetroFramework.Controls.MetroTextBox();
            this.lblNTN = new MetroFramework.Controls.MetroLabel();
            this.lblContact = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblAccountNo = new MetroFramework.Controls.MetroLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatuMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtTotalAmount = new MetroFramework.Controls.MetroTextBox();
            this.metrolSalesTab = new MetroFramework.Controls.MetroTabControl();
            this.tabCustomers = new MetroFramework.Controls.MetroTabPage();
            this.tabLineItems = new MetroFramework.Controls.MetroTabPage();
            this.DgvSample = new Accounts.UI.TabDataGrid();
            this.colSampleDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemprature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new MetroFramework.Controls.MetroTile();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnPrint = new MetroFramework.Controls.MetroTile();
            this.btnPrevoius = new MetroFramework.Controls.MetroTile();
            this.btnNext = new MetroFramework.Controls.MetroTile();
            this.btnNewVoucher = new MetroFramework.Controls.MetroTile();
            this.btnConvert = new MetroFramework.Controls.MetroTile();
            this.panel1.SuspendLayout();
            this.grpSales.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.metrolSalesTab.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            this.tabLineItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSample)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.grpSales);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(4, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 181);
            this.panel1.TabIndex = 1;
            // 
            // grpSales
            // 
            this.grpSales.Controls.Add(this.cbxEmployees);
            this.grpSales.Controls.Add(this.metroLabel2);
            this.grpSales.Controls.Add(this.metroLabel1);
            this.grpSales.Controls.Add(this.EmpEditCode);
            this.grpSales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSales.Location = new System.Drawing.Point(552, 3);
            this.grpSales.Name = "grpSales";
            this.grpSales.Size = new System.Drawing.Size(416, 173);
            this.grpSales.TabIndex = 1;
            this.grpSales.TabStop = false;
            this.grpSales.Text = "Employees Information";
            // 
            // cbxEmployees
            // 
            this.cbxEmployees.FormattingEnabled = true;
            this.cbxEmployees.ItemHeight = 23;
            this.cbxEmployees.Location = new System.Drawing.Point(151, 57);
            this.cbxEmployees.Name = "cbxEmployees";
            this.cbxEmployees.Size = new System.Drawing.Size(205, 29);
            this.cbxEmployees.TabIndex = 19;
            this.cbxEmployees.UseSelectable = true;
            this.cbxEmployees.SelectedIndexChanged += new System.EventHandler(this.cbxEmployees_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(47, 94);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Account No :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(44, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Employee A/ C :";
            // 
            // EmpEditCode
            // 
            // 
            // 
            // 
            this.EmpEditCode.CustomButton.Image = null;
            this.EmpEditCode.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.EmpEditCode.CustomButton.Name = "";
            this.EmpEditCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.EmpEditCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.EmpEditCode.CustomButton.TabIndex = 1;
            this.EmpEditCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EmpEditCode.CustomButton.UseSelectable = true;
            this.EmpEditCode.CustomButton.Visible = false;
            this.EmpEditCode.Enabled = false;
            this.EmpEditCode.Lines = new string[0];
            this.EmpEditCode.Location = new System.Drawing.Point(152, 94);
            this.EmpEditCode.MaxLength = 32767;
            this.EmpEditCode.Name = "EmpEditCode";
            this.EmpEditCode.PasswordChar = '\0';
            this.EmpEditCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EmpEditCode.SelectedText = "";
            this.EmpEditCode.SelectionLength = 0;
            this.EmpEditCode.SelectionStart = 0;
            this.EmpEditCode.ShortcutsEnabled = true;
            this.EmpEditCode.Size = new System.Drawing.Size(204, 23);
            this.EmpEditCode.TabIndex = 2;
            this.EmpEditCode.UseSelectable = true;
            this.EmpEditCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EmpEditCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel12);
            this.groupBox2.Controls.Add(this.txtGatePass);
            this.groupBox2.Controls.Add(this.txtSampleDays);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.txtDemandNo);
            this.groupBox2.Controls.Add(this.lblMemoNo);
            this.groupBox2.Controls.Add(this.chkPosted);
            this.groupBox2.Controls.Add(this.VDate);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.lblDate);
            this.groupBox2.Controls.Add(this.InvSampleBox);
            this.groupBox2.Controls.Add(this.lblDescription);
            this.groupBox2.Controls.Add(this.lblInvoiceNo);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 174);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sample Information";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(10, 98);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(45, 19);
            this.metroLabel12.TabIndex = 19;
            this.metroLabel12.Text = "OGP :";
            // 
            // txtGatePass
            // 
            // 
            // 
            // 
            this.txtGatePass.CustomButton.Image = null;
            this.txtGatePass.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txtGatePass.CustomButton.Name = "";
            this.txtGatePass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGatePass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGatePass.CustomButton.TabIndex = 1;
            this.txtGatePass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGatePass.CustomButton.UseSelectable = true;
            this.txtGatePass.CustomButton.Visible = false;
            this.txtGatePass.Lines = new string[0];
            this.txtGatePass.Location = new System.Drawing.Point(97, 98);
            this.txtGatePass.MaxLength = 32767;
            this.txtGatePass.Name = "txtGatePass";
            this.txtGatePass.PasswordChar = '\0';
            this.txtGatePass.PromptText = "Gate Pass";
            this.txtGatePass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGatePass.SelectedText = "";
            this.txtGatePass.SelectionLength = 0;
            this.txtGatePass.SelectionStart = 0;
            this.txtGatePass.ShortcutsEnabled = true;
            this.txtGatePass.Size = new System.Drawing.Size(161, 23);
            this.txtGatePass.TabIndex = 18;
            this.txtGatePass.UseSelectable = true;
            this.txtGatePass.WaterMark = "Gate Pass";
            this.txtGatePass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGatePass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSampleDays
            // 
            // 
            // 
            // 
            this.txtSampleDays.CustomButton.Image = null;
            this.txtSampleDays.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtSampleDays.CustomButton.Name = "";
            this.txtSampleDays.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSampleDays.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSampleDays.CustomButton.TabIndex = 1;
            this.txtSampleDays.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSampleDays.CustomButton.UseSelectable = true;
            this.txtSampleDays.CustomButton.Visible = false;
            this.txtSampleDays.Lines = new string[0];
            this.txtSampleDays.Location = new System.Drawing.Point(322, 68);
            this.txtSampleDays.MaxLength = 32767;
            this.txtSampleDays.Name = "txtSampleDays";
            this.txtSampleDays.PasswordChar = '\0';
            this.txtSampleDays.PromptText = "Number Of Sample Days";
            this.txtSampleDays.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSampleDays.SelectedText = "";
            this.txtSampleDays.SelectionLength = 0;
            this.txtSampleDays.SelectionStart = 0;
            this.txtSampleDays.ShortcutsEnabled = true;
            this.txtSampleDays.Size = new System.Drawing.Size(154, 23);
            this.txtSampleDays.TabIndex = 16;
            this.txtSampleDays.UseSelectable = true;
            this.txtSampleDays.WaterMark = "Number Of Sample Days";
            this.txtSampleDays.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSampleDays.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(270, 68);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(46, 19);
            this.metroLabel6.TabIndex = 17;
            this.metroLabel6.Text = "Days :";
            // 
            // txtDemandNo
            // 
            // 
            // 
            // 
            this.txtDemandNo.CustomButton.Image = null;
            this.txtDemandNo.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txtDemandNo.CustomButton.Name = "";
            this.txtDemandNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDemandNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDemandNo.CustomButton.TabIndex = 1;
            this.txtDemandNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDemandNo.CustomButton.UseSelectable = true;
            this.txtDemandNo.CustomButton.Visible = false;
            this.txtDemandNo.Lines = new string[0];
            this.txtDemandNo.Location = new System.Drawing.Point(97, 68);
            this.txtDemandNo.MaxLength = 32767;
            this.txtDemandNo.Name = "txtDemandNo";
            this.txtDemandNo.PasswordChar = '\0';
            this.txtDemandNo.PromptText = "Demand No";
            this.txtDemandNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDemandNo.SelectedText = "";
            this.txtDemandNo.SelectionLength = 0;
            this.txtDemandNo.SelectionStart = 0;
            this.txtDemandNo.ShortcutsEnabled = true;
            this.txtDemandNo.Size = new System.Drawing.Size(161, 23);
            this.txtDemandNo.TabIndex = 16;
            this.txtDemandNo.UseSelectable = true;
            this.txtDemandNo.WaterMark = "Demand No";
            this.txtDemandNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDemandNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblMemoNo
            // 
            this.lblMemoNo.AutoSize = true;
            this.lblMemoNo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblMemoNo.Location = new System.Drawing.Point(6, 68);
            this.lblMemoNo.Name = "lblMemoNo";
            this.lblMemoNo.Size = new System.Drawing.Size(90, 19);
            this.lblMemoNo.TabIndex = 17;
            this.lblMemoNo.Text = "Demand No :";
            // 
            // chkPosted
            // 
            this.chkPosted.AutoSize = true;
            this.chkPosted.Checked = true;
            this.chkPosted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPosted.Enabled = false;
            this.chkPosted.Location = new System.Drawing.Point(491, 34);
            this.chkPosted.Name = "chkPosted";
            this.chkPosted.Size = new System.Drawing.Size(46, 15);
            this.chkPosted.TabIndex = 5;
            this.chkPosted.Text = "Post";
            this.chkPosted.UseSelectable = true;
            // 
            // VDate
            // 
            this.VDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VDate.Location = new System.Drawing.Point(324, 31);
            this.VDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.VDate.Name = "VDate";
            this.VDate.Size = new System.Drawing.Size(150, 29);
            this.VDate.TabIndex = 4;
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(349, 2);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(97, 127);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(379, 32);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDate.Location = new System.Drawing.Point(277, 35);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 19);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Date :";
            this.lblDate.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // InvSampleBox
            // 
            // 
            // 
            // 
            this.InvSampleBox.CustomButton.Image = null;
            this.InvSampleBox.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.InvSampleBox.CustomButton.Name = "";
            this.InvSampleBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.InvSampleBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InvSampleBox.CustomButton.TabIndex = 1;
            this.InvSampleBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InvSampleBox.CustomButton.UseSelectable = true;
            this.InvSampleBox.Lines = new string[0];
            this.InvSampleBox.Location = new System.Drawing.Point(94, 34);
            this.InvSampleBox.MaxLength = 32767;
            this.InvSampleBox.Name = "InvSampleBox";
            this.InvSampleBox.PasswordChar = '\0';
            this.InvSampleBox.PromptText = "voucher No";
            this.InvSampleBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InvSampleBox.SelectedText = "";
            this.InvSampleBox.SelectionLength = 0;
            this.InvSampleBox.SelectionStart = 0;
            this.InvSampleBox.ShortcutsEnabled = true;
            this.InvSampleBox.ShowButton = true;
            this.InvSampleBox.Size = new System.Drawing.Size(161, 23);
            this.InvSampleBox.Style = MetroFramework.MetroColorStyle.Green;
            this.InvSampleBox.TabIndex = 1;
            this.InvSampleBox.UseSelectable = true;
            this.InvSampleBox.WaterMark = "voucher No";
            this.InvSampleBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InvSampleBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.InvSampleBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.InvSampleBox_ButtonClick);
            this.InvSampleBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InvSampleBox_KeyPress);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDescription.Location = new System.Drawing.Point(8, 132);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(85, 19);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "Description :";
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblInvoiceNo.Location = new System.Drawing.Point(11, 33);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(82, 19);
            this.lblInvoiceNo.TabIndex = 15;
            this.lblInvoiceNo.Text = "Sample No :";
            // 
            // SalesEditBox
            // 
            // 
            // 
            // 
            this.SalesEditBox.CustomButton.Image = null;
            this.SalesEditBox.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.SalesEditBox.CustomButton.Name = "";
            this.SalesEditBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SalesEditBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SalesEditBox.CustomButton.TabIndex = 1;
            this.SalesEditBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SalesEditBox.CustomButton.UseSelectable = true;
            this.SalesEditBox.Lines = new string[0];
            this.SalesEditBox.Location = new System.Drawing.Point(425, 21);
            this.SalesEditBox.MaxLength = 32767;
            this.SalesEditBox.Name = "SalesEditBox";
            this.SalesEditBox.PasswordChar = '\0';
            this.SalesEditBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SalesEditBox.SelectedText = "";
            this.SalesEditBox.SelectionLength = 0;
            this.SalesEditBox.SelectionStart = 0;
            this.SalesEditBox.ShortcutsEnabled = true;
            this.SalesEditBox.ShowButton = true;
            this.SalesEditBox.Size = new System.Drawing.Size(163, 23);
            this.SalesEditBox.Style = MetroFramework.MetroColorStyle.Teal;
            this.SalesEditBox.TabIndex = 1;
            this.SalesEditBox.UseSelectable = true;
            this.SalesEditBox.Visible = false;
            this.SalesEditBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SalesEditBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SalesEditBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.SalesEditBox_ButtonClick);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(816, 497);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(64, 19);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Contact :";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(826, 465);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(52, 19);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Name :";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(818, 433);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(61, 19);
            this.metroLabel5.TabIndex = 15;
            this.metroLabel5.Text = "A/C No :";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(671, 1);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(129, 129);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(78, 110);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PromptText = "Customer Address";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(801, 131);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMark = "Customer Address";
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNTN
            // 
            // 
            // 
            // 
            this.txtNTN.CustomButton.Image = null;
            this.txtNTN.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.txtNTN.CustomButton.Name = "";
            this.txtNTN.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNTN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNTN.CustomButton.TabIndex = 1;
            this.txtNTN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNTN.CustomButton.UseSelectable = true;
            this.txtNTN.CustomButton.Visible = false;
            this.txtNTN.Lines = new string[0];
            this.txtNTN.Location = new System.Drawing.Point(314, 72);
            this.txtNTN.MaxLength = 32767;
            this.txtNTN.Name = "txtNTN";
            this.txtNTN.PasswordChar = '\0';
            this.txtNTN.PromptText = "NTN No";
            this.txtNTN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNTN.SelectedText = "";
            this.txtNTN.SelectionLength = 0;
            this.txtNTN.SelectionStart = 0;
            this.txtNTN.ShortcutsEnabled = true;
            this.txtNTN.Size = new System.Drawing.Size(235, 23);
            this.txtNTN.TabIndex = 3;
            this.txtNTN.UseSelectable = true;
            this.txtNTN.WaterMark = "NTN No";
            this.txtNTN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNTN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtContact
            // 
            // 
            // 
            // 
            this.txtContact.CustomButton.Image = null;
            this.txtContact.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtContact.CustomButton.Name = "";
            this.txtContact.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContact.CustomButton.TabIndex = 1;
            this.txtContact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContact.CustomButton.UseSelectable = true;
            this.txtContact.CustomButton.Visible = false;
            this.txtContact.Lines = new string[0];
            this.txtContact.Location = new System.Drawing.Point(80, 72);
            this.txtContact.MaxLength = 32767;
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.PromptText = "Contact";
            this.txtContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContact.SelectedText = "";
            this.txtContact.SelectionLength = 0;
            this.txtContact.SelectionStart = 0;
            this.txtContact.ShortcutsEnabled = true;
            this.txtContact.Size = new System.Drawing.Size(153, 23);
            this.txtContact.TabIndex = 2;
            this.txtContact.UseSelectable = true;
            this.txtContact.WaterMark = "Contact";
            this.txtContact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAddress.Location = new System.Drawing.Point(8, 161);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 19);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "Address :";
            this.lblAddress.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtCustomerName
            // 
            // 
            // 
            // 
            this.txtCustomerName.CustomButton.Image = null;
            this.txtCustomerName.CustomButton.Location = new System.Drawing.Point(215, 1);
            this.txtCustomerName.CustomButton.Name = "";
            this.txtCustomerName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCustomerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerName.CustomButton.TabIndex = 1;
            this.txtCustomerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerName.CustomButton.UseSelectable = true;
            this.txtCustomerName.CustomButton.Visible = false;
            this.txtCustomerName.Lines = new string[0];
            this.txtCustomerName.Location = new System.Drawing.Point(312, 34);
            this.txtCustomerName.MaxLength = 32767;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.PromptText = "Person Name";
            this.txtCustomerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.SelectionLength = 0;
            this.txtCustomerName.SelectionStart = 0;
            this.txtCustomerName.ShortcutsEnabled = true;
            this.txtCustomerName.Size = new System.Drawing.Size(237, 23);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.UseSelectable = true;
            this.txtCustomerName.WaterMark = "Person Name";
            this.txtCustomerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CustEditBox
            // 
            // 
            // 
            // 
            this.CustEditBox.CustomButton.Image = null;
            this.CustEditBox.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.CustEditBox.CustomButton.Name = "";
            this.CustEditBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CustEditBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CustEditBox.CustomButton.TabIndex = 1;
            this.CustEditBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CustEditBox.CustomButton.UseSelectable = true;
            this.CustEditBox.Lines = new string[0];
            this.CustEditBox.Location = new System.Drawing.Point(80, 34);
            this.CustEditBox.MaxLength = 32767;
            this.CustEditBox.Name = "CustEditBox";
            this.CustEditBox.PasswordChar = '\0';
            this.CustEditBox.PromptText = "Account No Here";
            this.CustEditBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CustEditBox.SelectedText = "";
            this.CustEditBox.SelectionLength = 0;
            this.CustEditBox.SelectionStart = 0;
            this.CustEditBox.ShortcutsEnabled = true;
            this.CustEditBox.ShowButton = true;
            this.CustEditBox.Size = new System.Drawing.Size(153, 23);
            this.CustEditBox.Style = MetroFramework.MetroColorStyle.Red;
            this.CustEditBox.TabIndex = 0;
            this.CustEditBox.UseSelectable = true;
            this.CustEditBox.WaterMark = "Account No Here";
            this.CustEditBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CustEditBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.CustEditBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.CustEditBox_ButtonClick);
            // 
            // lblNTN
            // 
            this.lblNTN.AutoSize = true;
            this.lblNTN.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNTN.Location = new System.Drawing.Point(251, 74);
            this.lblNTN.Name = "lblNTN";
            this.lblNTN.Size = new System.Drawing.Size(43, 19);
            this.lblNTN.TabIndex = 15;
            this.lblNTN.Text = "NTN :";
            this.lblNTN.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblContact.Location = new System.Drawing.Point(10, 72);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(64, 19);
            this.lblContact.TabIndex = 15;
            this.lblContact.Text = "Contact :";
            this.lblContact.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblName.Location = new System.Drawing.Point(245, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 19);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Name :";
            this.lblName.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountNo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAccountNo.Location = new System.Drawing.Point(13, 38);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(61, 19);
            this.lblAccountNo.TabIndex = 15;
            this.lblAccountNo.Text = "A/C No :";
            this.lblAccountNo.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatuMessage});
            this.statusStrip1.Location = new System.Drawing.Point(20, 658);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(948, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatuMessage
            // 
            this.lblStatuMessage.Name = "lblStatuMessage";
            this.lblStatuMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // txtTotalAmount
            // 
            // 
            // 
            // 
            this.txtTotalAmount.CustomButton.Image = null;
            this.txtTotalAmount.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.txtTotalAmount.CustomButton.Name = "";
            this.txtTotalAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalAmount.CustomButton.TabIndex = 1;
            this.txtTotalAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalAmount.CustomButton.UseSelectable = true;
            this.txtTotalAmount.CustomButton.Visible = false;
            this.txtTotalAmount.Lines = new string[0];
            this.txtTotalAmount.Location = new System.Drawing.Point(816, 291);
            this.txtTotalAmount.MaxLength = 32767;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.PasswordChar = '\0';
            this.txtTotalAmount.PromptText = "Total Invoice Amount";
            this.txtTotalAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalAmount.SelectedText = "";
            this.txtTotalAmount.SelectionLength = 0;
            this.txtTotalAmount.SelectionStart = 0;
            this.txtTotalAmount.ShortcutsEnabled = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(145, 23);
            this.txtTotalAmount.TabIndex = 17;
            this.txtTotalAmount.UseSelectable = true;
            this.txtTotalAmount.WaterMark = "Total Invoice Amount";
            this.txtTotalAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metrolSalesTab
            // 
            this.metrolSalesTab.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.metrolSalesTab.Controls.Add(this.tabCustomers);
            this.metrolSalesTab.Controls.Add(this.tabLineItems);
            this.metrolSalesTab.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.metrolSalesTab.Location = new System.Drawing.Point(8, 247);
            this.metrolSalesTab.Name = "metrolSalesTab";
            this.metrolSalesTab.SelectedIndex = 1;
            this.metrolSalesTab.Size = new System.Drawing.Size(979, 406);
            this.metrolSalesTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metrolSalesTab.Style = MetroFramework.MetroColorStyle.Green;
            this.metrolSalesTab.TabIndex = 18;
            this.metrolSalesTab.UseSelectable = true;
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.CustEditBox);
            this.tabCustomers.Controls.Add(this.txtAddress);
            this.tabCustomers.Controls.Add(this.lblAccountNo);
            this.tabCustomers.Controls.Add(this.txtContact);
            this.tabCustomers.Controls.Add(this.lblNTN);
            this.tabCustomers.Controls.Add(this.lblAddress);
            this.tabCustomers.Controls.Add(this.lblContact);
            this.tabCustomers.Controls.Add(this.txtNTN);
            this.tabCustomers.Controls.Add(this.lblName);
            this.tabCustomers.Controls.Add(this.txtCustomerName);
            this.tabCustomers.HorizontalScrollbarBarColor = true;
            this.tabCustomers.HorizontalScrollbarHighlightOnWheel = false;
            this.tabCustomers.HorizontalScrollbarSize = 10;
            this.tabCustomers.Location = new System.Drawing.Point(4, 37);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Size = new System.Drawing.Size(971, 365);
            this.tabCustomers.TabIndex = 0;
            this.tabCustomers.Text = "Customer Info";
            this.tabCustomers.VerticalScrollbarBarColor = true;
            this.tabCustomers.VerticalScrollbarHighlightOnWheel = false;
            this.tabCustomers.VerticalScrollbarSize = 10;
            // 
            // tabLineItems
            // 
            this.tabLineItems.Controls.Add(this.DgvSample);
            this.tabLineItems.Controls.Add(this.btnClose);
            this.tabLineItems.Controls.Add(this.btnSave);
            this.tabLineItems.Controls.Add(this.metroLabel11);
            this.tabLineItems.Controls.Add(this.btnDelete);
            this.tabLineItems.Controls.Add(this.btnPrint);
            this.tabLineItems.Controls.Add(this.btnPrevoius);
            this.tabLineItems.Controls.Add(this.txtTotalAmount);
            this.tabLineItems.Controls.Add(this.btnNext);
            this.tabLineItems.Controls.Add(this.btnNewVoucher);
            this.tabLineItems.Controls.Add(this.btnConvert);
            this.tabLineItems.HorizontalScrollbarBarColor = true;
            this.tabLineItems.HorizontalScrollbarHighlightOnWheel = false;
            this.tabLineItems.HorizontalScrollbarSize = 10;
            this.tabLineItems.Location = new System.Drawing.Point(4, 37);
            this.tabLineItems.Name = "tabLineItems";
            this.tabLineItems.Size = new System.Drawing.Size(971, 365);
            this.tabLineItems.TabIndex = 1;
            this.tabLineItems.Text = "Line Sample Items";
            this.tabLineItems.VerticalScrollbarBarColor = true;
            this.tabLineItems.VerticalScrollbarHighlightOnWheel = false;
            this.tabLineItems.VerticalScrollbarSize = 10;
            // 
            // DgvSample
            // 
            this.DgvSample.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            this.DgvSample.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvSample.BackgroundColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvSample.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvSample.ColumnHeadersHeight = 25;
            this.DgvSample.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSampleDetailId,
            this.colIdItem,
            this.colItemNo,
            this.colItemName,
            this.colPower,
            this.colTemprature,
            this.colUnitPrice,
            this.colQty,
            this.colAmount});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvSample.DefaultCellStyle = dataGridViewCellStyle4;
            this.DgvSample.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvSample.EnableHeadersVisualStyles = false;
            this.DgvSample.Location = new System.Drawing.Point(3, 3);
            this.DgvSample.MultiSelect = false;
            this.DgvSample.Name = "DgvSample";
            this.DgvSample.RowHeadersVisible = false;
            this.DgvSample.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvSample.Size = new System.Drawing.Size(958, 282);
            this.DgvSample.TabIndex = 2;
            this.DgvSample.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSample_CellEndEdit);
            this.DgvSample.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSample_CellLeave);
            this.DgvSample.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgvSample_EditingControlShowing);
            // 
            // colSampleDetailId
            // 
            this.colSampleDetailId.HeaderText = "SampleDetailId";
            this.colSampleDetailId.Name = "colSampleDetailId";
            this.colSampleDetailId.Visible = false;
            // 
            // colIdItem
            // 
            this.colIdItem.HeaderText = "IdItem";
            this.colIdItem.Name = "colIdItem";
            this.colIdItem.Visible = false;
            // 
            // colItemNo
            // 
            this.colItemNo.DataPropertyName = "AccountNo";
            this.colItemNo.HeaderText = "Product Code";
            this.colItemNo.Name = "colItemNo";
            this.colItemNo.Visible = false;
            this.colItemNo.Width = 104;
            // 
            // colItemName
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colItemName.DefaultCellStyle = dataGridViewCellStyle3;
            this.colItemName.HeaderText = "Product Name";
            this.colItemName.Name = "colItemName";
            this.colItemName.Width = 300;
            // 
            // colPower
            // 
            this.colPower.HeaderText = "Power";
            this.colPower.Name = "colPower";
            this.colPower.Width = 125;
            // 
            // colTemprature
            // 
            this.colTemprature.HeaderText = "Color Temprature";
            this.colTemprature.Name = "colTemprature";
            this.colTemprature.Width = 125;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "Amount";
            this.colUnitPrice.HeaderText = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Width = 125;
            // 
            // colQty
            // 
            this.colQty.DataPropertyName = "Qty";
            this.colQty.HeaderText = "Units";
            this.colQty.Name = "colQty";
            this.colQty.Width = 125;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 150;
            // 
            // btnClose
            // 
            this.btnClose.ActiveControl = null;
            this.btnClose.Location = new System.Drawing.Point(988, 316);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 40);
            this.btnClose.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.Location = new System.Drawing.Point(625, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 40);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(728, 292);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(83, 19);
            this.metroLabel11.TabIndex = 19;
            this.metroLabel11.Text = "Total Debit :";
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveControl = null;
            this.btnDelete.Location = new System.Drawing.Point(742, 316);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 40);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.ActiveControl = null;
            this.btnPrint.Location = new System.Drawing.Point(859, 316);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(102, 40);
            this.btnPrint.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnPrint.TabIndex = 18;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPrevoius
            // 
            this.btnPrevoius.ActiveControl = null;
            this.btnPrevoius.Location = new System.Drawing.Point(150, 316);
            this.btnPrevoius.Name = "btnPrevoius";
            this.btnPrevoius.Size = new System.Drawing.Size(116, 40);
            this.btnPrevoius.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnPrevoius.TabIndex = 18;
            this.btnPrevoius.Text = "Previous";
            this.btnPrevoius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrevoius.UseSelectable = true;
            this.btnPrevoius.Click += new System.EventHandler(this.btnPrevoius_Click);
            // 
            // btnNext
            // 
            this.btnNext.ActiveControl = null;
            this.btnNext.Location = new System.Drawing.Point(267, 316);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(116, 40);
            this.btnNext.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNext.UseSelectable = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnNewVoucher
            // 
            this.btnNewVoucher.ActiveControl = null;
            this.btnNewVoucher.Location = new System.Drawing.Point(384, 316);
            this.btnNewVoucher.Name = "btnNewVoucher";
            this.btnNewVoucher.Size = new System.Drawing.Size(102, 40);
            this.btnNewVoucher.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnNewVoucher.TabIndex = 18;
            this.btnNewVoucher.Text = "New Voucher";
            this.btnNewVoucher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewVoucher.UseSelectable = true;
            this.btnNewVoucher.Click += new System.EventHandler(this.btnNewVoucher_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.ActiveControl = null;
            this.btnConvert.Location = new System.Drawing.Point(487, 316);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(137, 40);
            this.btnConvert.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnConvert.TabIndex = 18;
            this.btnConvert.Text = "Convert To Sale";
            this.btnConvert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConvert.UseSelectable = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // frmSamples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 700);
            this.Controls.Add(this.metrolSalesTab);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.SalesEditBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmSamples";
            this.Text = "Samples";
            this.Load += new System.EventHandler(this.frmSamples_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSamples_KeyPress);
            this.panel1.ResumeLayout(false);
            this.grpSales.ResumeLayout(false);
            this.grpSales.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.metrolSalesTab.ResumeLayout(false);
            this.tabCustomers.ResumeLayout(false);
            this.tabCustomers.PerformLayout();
            this.tabLineItems.ResumeLayout(false);
            this.tabLineItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatuMessage;
        private TabDataGrid DgvSample;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroDateTime VDate;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroLabel lblDescription;
        private MetroFramework.Controls.MetroLabel lblInvoiceNo;
        private MetroFramework.Controls.MetroLabel lblNTN;
        private MetroFramework.Controls.MetroLabel lblContact;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblAccountNo;
        private MetroFramework.Controls.MetroLabel lblAddress;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroTextBox txtNTN;
        private MetroFramework.Controls.MetroTextBox txtContact;
        private MetroFramework.Controls.MetroTextBox txtCustomerName;
        private MetroFramework.Controls.MetroTextBox CustEditBox;
        private MetroFramework.Controls.MetroTextBox InvSampleBox;
        private MetroFramework.Controls.MetroTextBox txtTotalAmount;
        private MetroFramework.Controls.MetroCheckBox chkPosted;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTabControl metrolSalesTab;
        private MetroFramework.Controls.MetroTabPage tabCustomers;
        private MetroFramework.Controls.MetroTabPage tabLineItems;
        private MetroFramework.Controls.MetroTile btnClose;
        private MetroFramework.Controls.MetroTile btnPrint;
        private MetroFramework.Controls.MetroTile btnDelete;
        private MetroFramework.Controls.MetroTile btnSave;
        private MetroFramework.Controls.MetroTextBox SalesEditBox;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.GroupBox grpSales;
        private MetroFramework.Controls.MetroComboBox cbxEmployees;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox EmpEditCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSampleDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPower;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemprature;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private MetroFramework.Controls.MetroTextBox txtDemandNo;
        private MetroFramework.Controls.MetroLabel lblMemoNo;
        private MetroFramework.Controls.MetroTextBox txtGatePass;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTile btnPrevoius;
        private MetroFramework.Controls.MetroTile btnNext;
        private MetroFramework.Controls.MetroTile btnNewVoucher;
        private MetroFramework.Controls.MetroTile btnConvert;
        private MetroFramework.Controls.MetroTextBox txtSampleDays;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}