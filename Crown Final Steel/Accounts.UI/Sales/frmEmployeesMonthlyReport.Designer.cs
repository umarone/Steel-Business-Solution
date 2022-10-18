namespace Accounts.UI
{
    partial class frmEmployeesMonthlyReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlControls = new MetroFramework.Controls.MetroPanel();
            this.cbxEmpType = new System.Windows.Forms.ComboBox();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnExcelExport = new MetroFramework.Controls.MetroButton();
            this.dtEnd = new MetroFramework.Controls.MetroDateTime();
            this.dtStart = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtDeliveryPerson = new MetroFramework.Controls.MetroTextBox();
            this.grdReports = new System.Windows.Forms.DataGridView();
            this.txtUnits = new MetroFramework.Controls.MetroTextBox();
            this.txtAmount = new MetroFramework.Controls.MetroTextBox();
            this.txtDiscount = new MetroFramework.Controls.MetroTextBox();
            this.txtNetAmount = new MetroFramework.Controls.MetroTextBox();
            this.txtDiscount2 = new MetroFramework.Controls.MetroTextBox();
            this.txtReturnAmount = new MetroFramework.Controls.MetroTextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscountPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscountPercentage2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReports)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.MistyRose;
            this.pnlControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControls.Controls.Add(this.cbxEmpType);
            this.pnlControls.Controls.Add(this.btnLoad);
            this.pnlControls.Controls.Add(this.metroLabel2);
            this.pnlControls.Controls.Add(this.btnExcelExport);
            this.pnlControls.Controls.Add(this.dtEnd);
            this.pnlControls.Controls.Add(this.dtStart);
            this.pnlControls.Controls.Add(this.metroLabel4);
            this.pnlControls.Controls.Add(this.metroLabel1);
            this.pnlControls.Controls.Add(this.txtDeliveryPerson);
            this.pnlControls.HorizontalScrollbarBarColor = true;
            this.pnlControls.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlControls.HorizontalScrollbarSize = 10;
            this.pnlControls.Location = new System.Drawing.Point(23, 63);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1030, 44);
            this.pnlControls.TabIndex = 1;
            this.pnlControls.UseCustomBackColor = true;
            this.pnlControls.VerticalScrollbarBarColor = true;
            this.pnlControls.VerticalScrollbarHighlightOnWheel = false;
            this.pnlControls.VerticalScrollbarSize = 10;
            // 
            // cbxEmpType
            // 
            this.cbxEmpType.FormattingEnabled = true;
            this.cbxEmpType.Items.AddRange(new object[] {
            "",
            "Order Booker",
            "Supply Man"});
            this.cbxEmpType.Location = new System.Drawing.Point(275, 9);
            this.cbxEmpType.Name = "cbxEmpType";
            this.cbxEmpType.Size = new System.Drawing.Size(129, 21);
            this.cbxEmpType.TabIndex = 31;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(797, 8);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(89, 23);
            this.btnLoad.TabIndex = 30;
            this.btnLoad.Text = "Load Report";
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(610, 10);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 19);
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = "To Date :";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.Location = new System.Drawing.Point(889, 9);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(89, 23);
            this.btnExcelExport.TabIndex = 30;
            this.btnExcelExport.Text = "Excel Export";
            this.btnExcelExport.UseSelectable = true;
            this.btnExcelExport.Click += new System.EventHandler(this.btnExcelExport_Click);
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(676, 5);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(110, 29);
            this.dtEnd.TabIndex = 29;
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(487, 5);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(116, 29);
            this.dtStart.TabIndex = 29;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(3, 8);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(75, 19);
            this.metroLabel4.TabIndex = 28;
            this.metroLabel4.Text = "Employee :";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(405, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "From Date :";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // txtDeliveryPerson
            // 
            // 
            // 
            // 
            this.txtDeliveryPerson.CustomButton.Image = null;
            this.txtDeliveryPerson.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.txtDeliveryPerson.CustomButton.Name = "";
            this.txtDeliveryPerson.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDeliveryPerson.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDeliveryPerson.CustomButton.TabIndex = 1;
            this.txtDeliveryPerson.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDeliveryPerson.CustomButton.UseSelectable = true;
            this.txtDeliveryPerson.Lines = new string[0];
            this.txtDeliveryPerson.Location = new System.Drawing.Point(80, 7);
            this.txtDeliveryPerson.MaxLength = 32767;
            this.txtDeliveryPerson.Name = "txtDeliveryPerson";
            this.txtDeliveryPerson.PasswordChar = '\0';
            this.txtDeliveryPerson.PromptText = "Type Here To Select Employee";
            this.txtDeliveryPerson.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDeliveryPerson.SelectedText = "";
            this.txtDeliveryPerson.SelectionLength = 0;
            this.txtDeliveryPerson.SelectionStart = 0;
            this.txtDeliveryPerson.ShortcutsEnabled = true;
            this.txtDeliveryPerson.ShowButton = true;
            this.txtDeliveryPerson.Size = new System.Drawing.Size(189, 23);
            this.txtDeliveryPerson.Style = MetroFramework.MetroColorStyle.Green;
            this.txtDeliveryPerson.TabIndex = 27;
            this.txtDeliveryPerson.UseSelectable = true;
            this.txtDeliveryPerson.WaterMark = "Type Here To Select Employee";
            this.txtDeliveryPerson.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDeliveryPerson.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDeliveryPerson.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtDeliveryPerson_ButtonClick);
            this.txtDeliveryPerson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeliveryPerson_KeyPress);
            // 
            // grdReports
            // 
            this.grdReports.AllowUserToAddRows = false;
            this.grdReports.AllowUserToDeleteRows = false;
            this.grdReports.BackgroundColor = System.Drawing.Color.Linen;
            this.grdReports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdReports.ColumnHeadersHeight = 27;
            this.grdReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductName,
            this.colUnits,
            this.colUnitPrice,
            this.colAmount,
            this.colReturnAmount,
            this.colDiscountPercentage,
            this.colDiscountPercentage2,
            this.colNetAmount});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdReports.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdReports.EnableHeadersVisualStyles = false;
            this.grdReports.Location = new System.Drawing.Point(23, 109);
            this.grdReports.Name = "grdReports";
            this.grdReports.ReadOnly = true;
            this.grdReports.RowHeadersVisible = false;
            this.grdReports.Size = new System.Drawing.Size(1030, 511);
            this.grdReports.TabIndex = 2;
            // 
            // txtUnits
            // 
            // 
            // 
            // 
            this.txtUnits.CustomButton.Image = null;
            this.txtUnits.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txtUnits.CustomButton.Name = "";
            this.txtUnits.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUnits.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUnits.CustomButton.TabIndex = 1;
            this.txtUnits.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUnits.CustomButton.UseSelectable = true;
            this.txtUnits.CustomButton.Visible = false;
            this.txtUnits.Lines = new string[0];
            this.txtUnits.Location = new System.Drawing.Point(323, 627);
            this.txtUnits.MaxLength = 32767;
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.PasswordChar = '\0';
            this.txtUnits.PromptText = "Quantity";
            this.txtUnits.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUnits.SelectedText = "";
            this.txtUnits.SelectionLength = 0;
            this.txtUnits.SelectionStart = 0;
            this.txtUnits.ShortcutsEnabled = true;
            this.txtUnits.Size = new System.Drawing.Size(100, 23);
            this.txtUnits.TabIndex = 3;
            this.txtUnits.UseSelectable = true;
            this.txtUnits.WaterMark = "Quantity";
            this.txtUnits.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUnits.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAmount
            // 
            // 
            // 
            // 
            this.txtAmount.CustomButton.Image = null;
            this.txtAmount.CustomButton.Location = new System.Drawing.Point(81, 1);
            this.txtAmount.CustomButton.Name = "";
            this.txtAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAmount.CustomButton.TabIndex = 1;
            this.txtAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAmount.CustomButton.UseSelectable = true;
            this.txtAmount.CustomButton.Visible = false;
            this.txtAmount.Lines = new string[0];
            this.txtAmount.Location = new System.Drawing.Point(529, 627);
            this.txtAmount.MaxLength = 32767;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PromptText = "Amount";
            this.txtAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionLength = 0;
            this.txtAmount.SelectionStart = 0;
            this.txtAmount.ShortcutsEnabled = true;
            this.txtAmount.Size = new System.Drawing.Size(103, 23);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.UseSelectable = true;
            this.txtAmount.WaterMark = "Amount";
            this.txtAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDiscount
            // 
            // 
            // 
            // 
            this.txtDiscount.CustomButton.Image = null;
            this.txtDiscount.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.txtDiscount.CustomButton.Name = "";
            this.txtDiscount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDiscount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiscount.CustomButton.TabIndex = 1;
            this.txtDiscount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiscount.CustomButton.UseSelectable = true;
            this.txtDiscount.CustomButton.Visible = false;
            this.txtDiscount.Lines = new string[0];
            this.txtDiscount.Location = new System.Drawing.Point(746, 627);
            this.txtDiscount.MaxLength = 32767;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.PromptText = "Discount";
            this.txtDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.SelectionLength = 0;
            this.txtDiscount.SelectionStart = 0;
            this.txtDiscount.ShortcutsEnabled = true;
            this.txtDiscount.Size = new System.Drawing.Size(95, 23);
            this.txtDiscount.TabIndex = 3;
            this.txtDiscount.UseSelectable = true;
            this.txtDiscount.WaterMark = "Discount";
            this.txtDiscount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiscount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNetAmount
            // 
            // 
            // 
            // 
            this.txtNetAmount.CustomButton.Image = null;
            this.txtNetAmount.CustomButton.Location = new System.Drawing.Point(79, 1);
            this.txtNetAmount.CustomButton.Name = "";
            this.txtNetAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNetAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNetAmount.CustomButton.TabIndex = 1;
            this.txtNetAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNetAmount.CustomButton.UseSelectable = true;
            this.txtNetAmount.CustomButton.Visible = false;
            this.txtNetAmount.Lines = new string[0];
            this.txtNetAmount.Location = new System.Drawing.Point(945, 625);
            this.txtNetAmount.MaxLength = 32767;
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.PasswordChar = '\0';
            this.txtNetAmount.PromptText = "Net Amount";
            this.txtNetAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNetAmount.SelectedText = "";
            this.txtNetAmount.SelectionLength = 0;
            this.txtNetAmount.SelectionStart = 0;
            this.txtNetAmount.ShortcutsEnabled = true;
            this.txtNetAmount.Size = new System.Drawing.Size(101, 23);
            this.txtNetAmount.TabIndex = 3;
            this.txtNetAmount.UseSelectable = true;
            this.txtNetAmount.WaterMark = "Net Amount";
            this.txtNetAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNetAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDiscount2
            // 
            // 
            // 
            // 
            this.txtDiscount2.CustomButton.Image = null;
            this.txtDiscount2.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.txtDiscount2.CustomButton.Name = "";
            this.txtDiscount2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDiscount2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiscount2.CustomButton.TabIndex = 1;
            this.txtDiscount2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiscount2.CustomButton.UseSelectable = true;
            this.txtDiscount2.CustomButton.Visible = false;
            this.txtDiscount2.Lines = new string[0];
            this.txtDiscount2.Location = new System.Drawing.Point(844, 627);
            this.txtDiscount2.MaxLength = 32767;
            this.txtDiscount2.Name = "txtDiscount2";
            this.txtDiscount2.PasswordChar = '\0';
            this.txtDiscount2.PromptText = "Discount 2";
            this.txtDiscount2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiscount2.SelectedText = "";
            this.txtDiscount2.SelectionLength = 0;
            this.txtDiscount2.SelectionStart = 0;
            this.txtDiscount2.ShortcutsEnabled = true;
            this.txtDiscount2.Size = new System.Drawing.Size(95, 23);
            this.txtDiscount2.TabIndex = 3;
            this.txtDiscount2.UseSelectable = true;
            this.txtDiscount2.WaterMark = "Discount 2";
            this.txtDiscount2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiscount2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtReturnAmount
            // 
            // 
            // 
            // 
            this.txtReturnAmount.CustomButton.Image = null;
            this.txtReturnAmount.CustomButton.Location = new System.Drawing.Point(81, 1);
            this.txtReturnAmount.CustomButton.Name = "";
            this.txtReturnAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtReturnAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReturnAmount.CustomButton.TabIndex = 1;
            this.txtReturnAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReturnAmount.CustomButton.UseSelectable = true;
            this.txtReturnAmount.CustomButton.Visible = false;
            this.txtReturnAmount.Lines = new string[0];
            this.txtReturnAmount.Location = new System.Drawing.Point(638, 627);
            this.txtReturnAmount.MaxLength = 32767;
            this.txtReturnAmount.Name = "txtReturnAmount";
            this.txtReturnAmount.PasswordChar = '\0';
            this.txtReturnAmount.PromptText = "Return Amount";
            this.txtReturnAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReturnAmount.SelectedText = "";
            this.txtReturnAmount.SelectionLength = 0;
            this.txtReturnAmount.SelectionStart = 0;
            this.txtReturnAmount.ShortcutsEnabled = true;
            this.txtReturnAmount.Size = new System.Drawing.Size(103, 23);
            this.txtReturnAmount.TabIndex = 3;
            this.txtReturnAmount.UseSelectable = true;
            this.txtReturnAmount.WaterMark = "Return Amount";
            this.txtReturnAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReturnAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ItemName";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn1.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 350;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Units";
            this.dataGridViewTextBoxColumn2.HeaderText = "Units";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UnitPrice";
            this.dataGridViewTextBoxColumn3.HeaderText = "UnitPrice";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn4.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Discount";
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn5.HeaderText = "Disc(%)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DisCountAmount";
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = "0";
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn6.HeaderText = "Net Amount";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 95;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NetSaleAmount";
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = "0";
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn7.HeaderText = "Net Amount";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NetSaleAmount";
            this.dataGridViewTextBoxColumn8.HeaderText = "Net Amount";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 120;
            // 
            // colProductName
            // 
            this.colProductName.DataPropertyName = "ItemName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colProductName.DefaultCellStyle = dataGridViewCellStyle2;
            this.colProductName.HeaderText = "Product Name";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            this.colProductName.Width = 300;
            // 
            // colUnits
            // 
            this.colUnits.DataPropertyName = "Qty";
            this.colUnits.HeaderText = "Units";
            this.colUnits.Name = "colUnits";
            this.colUnits.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "UnitPrice";
            this.colUnitPrice.HeaderText = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colReturnAmount
            // 
            this.colReturnAmount.DataPropertyName = "NetSaleReturnAmount";
            this.colReturnAmount.HeaderText = "Return Amount";
            this.colReturnAmount.Name = "colReturnAmount";
            this.colReturnAmount.ReadOnly = true;
            // 
            // colDiscountPercentage
            // 
            this.colDiscountPercentage.DataPropertyName = "Discount";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.colDiscountPercentage.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDiscountPercentage.HeaderText = "Disc(%)";
            this.colDiscountPercentage.Name = "colDiscountPercentage";
            this.colDiscountPercentage.ReadOnly = true;
            this.colDiscountPercentage.Width = 95;
            // 
            // colDiscountPercentage2
            // 
            this.colDiscountPercentage2.DataPropertyName = "PromoDiscount";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.colDiscountPercentage2.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDiscountPercentage2.HeaderText = "Disc 2(%)";
            this.colDiscountPercentage2.Name = "colDiscountPercentage2";
            this.colDiscountPercentage2.ReadOnly = true;
            this.colDiscountPercentage2.Width = 95;
            // 
            // colNetAmount
            // 
            this.colNetAmount.DataPropertyName = "NetSaleAmount";
            this.colNetAmount.HeaderText = "Net Amount";
            this.colNetAmount.Name = "colNetAmount";
            this.colNetAmount.ReadOnly = true;
            this.colNetAmount.Width = 120;
            // 
            // frmEmployeesMonthlyReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1076, 685);
            this.Controls.Add(this.txtNetAmount);
            this.Controls.Add(this.txtDiscount2);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtReturnAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtUnits);
            this.Controls.Add(this.grdReports);
            this.Controls.Add(this.pnlControls);
            this.MaximizeBox = false;
            this.Name = "frmEmployeesMonthlyReport";
            this.Text = "Employees Monthly Performance Report";
            this.Load += new System.EventHandler(this.frmEmployeesMonthlyReport_Load);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlControls;
        private MetroFramework.Controls.MetroButton btnLoad;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime dtEnd;
        private MetroFramework.Controls.MetroDateTime dtStart;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtDeliveryPerson;
        private System.Windows.Forms.DataGridView grdReports;
        private System.Windows.Forms.ComboBox cbxEmpType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private MetroFramework.Controls.MetroButton btnExcelExport;
        private MetroFramework.Controls.MetroTextBox txtUnits;
        private MetroFramework.Controls.MetroTextBox txtAmount;
        private MetroFramework.Controls.MetroTextBox txtDiscount;
        private MetroFramework.Controls.MetroTextBox txtNetAmount;
        private MetroFramework.Controls.MetroTextBox txtDiscount2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReturnAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscountPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscountPercentage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNetAmount;
        private MetroFramework.Controls.MetroTextBox txtReturnAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}