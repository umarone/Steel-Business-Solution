namespace Accounts.UI
{
    partial class frmBankVocher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatuMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.DgvBankVoucher = new System.Windows.Forms.DataGridView();
            this.chkPosted = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BEditBox = new MetroFramework.Controls.MetroTextBox();
            this.VEditBox = new MetroFramework.Controls.MetroTextBox();
            this.lblDiscription = new MetroFramework.Controls.MetroLabel();
            this.lblChequeNo = new MetroFramework.Controls.MetroLabel();
            this.lblBankAccountNo = new MetroFramework.Controls.MetroLabel();
            this.lblVoucherNo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.txtAccountName = new MetroFramework.Controls.MetroTextBox();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.txtChequeNo = new MetroFramework.Controls.MetroTextBox();
            this.VDate = new MetroFramework.Controls.MetroDateTime();
            this.btnClose = new MetroFramework.Controls.MetroTile();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.ColTransaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIdDetailVoucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBankVoucher)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatuMessage});
            this.statusStrip1.Location = new System.Drawing.Point(20, 464);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(618, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatuMessage
            // 
            this.lblStatuMessage.Name = "lblStatuMessage";
            this.lblStatuMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // DgvBankVoucher
            // 
            this.DgvBankVoucher.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvBankVoucher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvBankVoucher.BackgroundColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBankVoucher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvBankVoucher.ColumnHeadersHeight = 25;
            this.DgvBankVoucher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTransaction,
            this.ColIdDetailVoucher,
            this.colAccount,
            this.colAccountName,
            this.colDescription,
            this.colAmount});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvBankVoucher.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgvBankVoucher.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.DgvBankVoucher.EnableHeadersVisualStyles = false;
            this.DgvBankVoucher.Location = new System.Drawing.Point(3, 195);
            this.DgvBankVoucher.MultiSelect = false;
            this.DgvBankVoucher.Name = "DgvBankVoucher";
            this.DgvBankVoucher.RowHeadersVisible = false;
            this.DgvBankVoucher.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvBankVoucher.Size = new System.Drawing.Size(653, 215);
            this.DgvBankVoucher.TabIndex = 12;
            this.DgvBankVoucher.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBankVoucher_CellEndEdit);
            this.DgvBankVoucher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvBankVoucher_KeyDown);
            // 
            // chkPosted
            // 
            this.chkPosted.AutoSize = true;
            this.chkPosted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPosted.ForeColor = System.Drawing.Color.Red;
            this.chkPosted.Location = new System.Drawing.Point(552, 6);
            this.chkPosted.Name = "chkPosted";
            this.chkPosted.Size = new System.Drawing.Size(76, 25);
            this.chkPosted.TabIndex = 11;
            this.chkPosted.Text = "Posted";
            this.chkPosted.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BEditBox);
            this.panel1.Controls.Add(this.VEditBox);
            this.panel1.Controls.Add(this.lblDiscription);
            this.panel1.Controls.Add(this.lblChequeNo);
            this.panel1.Controls.Add(this.lblBankAccountNo);
            this.panel1.Controls.Add(this.lblVoucherNo);
            this.panel1.Controls.Add(this.metroLabel6);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.txtAccountName);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.txtChequeNo);
            this.panel1.Controls.Add(this.VDate);
            this.panel1.Controls.Add(this.chkPosted);
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 145);
            this.panel1.TabIndex = 11;
            // 
            // BEditBox
            // 
            // 
            // 
            // 
            this.BEditBox.CustomButton.Image = null;
            this.BEditBox.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.BEditBox.CustomButton.Name = "";
            this.BEditBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BEditBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BEditBox.CustomButton.TabIndex = 1;
            this.BEditBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BEditBox.CustomButton.UseSelectable = true;
            this.BEditBox.Lines = new string[0];
            this.BEditBox.Location = new System.Drawing.Point(107, 42);
            this.BEditBox.MaxLength = 32767;
            this.BEditBox.Name = "BEditBox";
            this.BEditBox.PasswordChar = '\0';
            this.BEditBox.PromptText = "Bank Code Here";
            this.BEditBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BEditBox.SelectedText = "";
            this.BEditBox.SelectionLength = 0;
            this.BEditBox.SelectionStart = 0;
            this.BEditBox.ShortcutsEnabled = true;
            this.BEditBox.ShowButton = true;
            this.BEditBox.Size = new System.Drawing.Size(177, 23);
            this.BEditBox.Style = MetroFramework.MetroColorStyle.Green;
            this.BEditBox.TabIndex = 20;
            this.BEditBox.UseSelectable = true;
            this.BEditBox.WaterMark = "Bank Code Here";
            this.BEditBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BEditBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BEditBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.BEditBox_ButtonClick);
            // 
            // VEditBox
            // 
            // 
            // 
            // 
            this.VEditBox.CustomButton.Image = null;
            this.VEditBox.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.VEditBox.CustomButton.Name = "";
            this.VEditBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.VEditBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.VEditBox.CustomButton.TabIndex = 1;
            this.VEditBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.VEditBox.CustomButton.UseSelectable = true;
            this.VEditBox.Lines = new string[0];
            this.VEditBox.Location = new System.Drawing.Point(107, 6);
            this.VEditBox.MaxLength = 32767;
            this.VEditBox.Name = "VEditBox";
            this.VEditBox.PasswordChar = '\0';
            this.VEditBox.PromptText = "Voucher Number Here";
            this.VEditBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.VEditBox.SelectedText = "";
            this.VEditBox.SelectionLength = 0;
            this.VEditBox.SelectionStart = 0;
            this.VEditBox.ShortcutsEnabled = true;
            this.VEditBox.ShowButton = true;
            this.VEditBox.Size = new System.Drawing.Size(177, 23);
            this.VEditBox.Style = MetroFramework.MetroColorStyle.Green;
            this.VEditBox.TabIndex = 19;
            this.VEditBox.UseSelectable = true;
            this.VEditBox.WaterMark = "Voucher Number Here";
            this.VEditBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.VEditBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.VEditBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.VEditBox_ButtonClick);
            this.VEditBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VEditBox_KeyPress);
            // 
            // lblDiscription
            // 
            this.lblDiscription.AutoSize = true;
            this.lblDiscription.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDiscription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDiscription.Location = new System.Drawing.Point(288, 81);
            this.lblDiscription.Name = "lblDiscription";
            this.lblDiscription.Size = new System.Drawing.Size(85, 19);
            this.lblDiscription.Style = MetroFramework.MetroColorStyle.Black;
            this.lblDiscription.TabIndex = 18;
            this.lblDiscription.Text = "Description :";
            this.lblDiscription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChequeNo
            // 
            this.lblChequeNo.AutoSize = true;
            this.lblChequeNo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblChequeNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblChequeNo.Location = new System.Drawing.Point(11, 78);
            this.lblChequeNo.Name = "lblChequeNo";
            this.lblChequeNo.Size = new System.Drawing.Size(85, 19);
            this.lblChequeNo.Style = MetroFramework.MetroColorStyle.Black;
            this.lblChequeNo.TabIndex = 18;
            this.lblChequeNo.Text = "Cheque No :";
            this.lblChequeNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBankAccountNo
            // 
            this.lblBankAccountNo.AutoSize = true;
            this.lblBankAccountNo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBankAccountNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBankAccountNo.Location = new System.Drawing.Point(9, 43);
            this.lblBankAccountNo.Name = "lblBankAccountNo";
            this.lblBankAccountNo.Size = new System.Drawing.Size(73, 19);
            this.lblBankAccountNo.Style = MetroFramework.MetroColorStyle.Black;
            this.lblBankAccountNo.TabIndex = 18;
            this.lblBankAccountNo.Text = "Bank A/C :";
            this.lblBankAccountNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblVoucherNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVoucherNo.Location = new System.Drawing.Point(9, 6);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(89, 19);
            this.lblVoucherNo.Style = MetroFramework.MetroColorStyle.Black;
            this.lblVoucherNo.TabIndex = 18;
            this.lblVoucherNo.Text = "Voucher No :";
            this.lblVoucherNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(330, 38);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(39, 19);
            this.metroLabel6.TabIndex = 17;
            this.metroLabel6.Text = "A/C :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDate.Location = new System.Drawing.Point(326, 6);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 19);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "Date :";
            // 
            // txtAccountName
            // 
            // 
            // 
            // 
            this.txtAccountName.CustomButton.Image = null;
            this.txtAccountName.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtAccountName.CustomButton.Name = "";
            this.txtAccountName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAccountName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccountName.CustomButton.TabIndex = 1;
            this.txtAccountName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccountName.CustomButton.UseSelectable = true;
            this.txtAccountName.CustomButton.Visible = false;
            this.txtAccountName.Lines = new string[0];
            this.txtAccountName.Location = new System.Drawing.Point(376, 39);
            this.txtAccountName.MaxLength = 32767;
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.PasswordChar = '\0';
            this.txtAccountName.PromptText = "Bank Account Name";
            this.txtAccountName.ReadOnly = true;
            this.txtAccountName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccountName.SelectedText = "";
            this.txtAccountName.SelectionLength = 0;
            this.txtAccountName.SelectionStart = 0;
            this.txtAccountName.ShortcutsEnabled = true;
            this.txtAccountName.Size = new System.Drawing.Size(171, 23);
            this.txtAccountName.TabIndex = 16;
            this.txtAccountName.UseSelectable = true;
            this.txtAccountName.WaterMark = "Bank Account Name";
            this.txtAccountName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccountName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(217, 2);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(49, 49);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(375, 70);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(269, 54);
            this.txtDescription.TabIndex = 15;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtChequeNo
            // 
            // 
            // 
            // 
            this.txtChequeNo.CustomButton.Image = null;
            this.txtChequeNo.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.txtChequeNo.CustomButton.Name = "";
            this.txtChequeNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtChequeNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChequeNo.CustomButton.TabIndex = 1;
            this.txtChequeNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChequeNo.CustomButton.UseSelectable = true;
            this.txtChequeNo.CustomButton.Visible = false;
            this.txtChequeNo.Lines = new string[0];
            this.txtChequeNo.Location = new System.Drawing.Point(104, 78);
            this.txtChequeNo.MaxLength = 32767;
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.PasswordChar = '\0';
            this.txtChequeNo.PromptText = "Cheque No";
            this.txtChequeNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChequeNo.SelectedText = "";
            this.txtChequeNo.SelectionLength = 0;
            this.txtChequeNo.SelectionStart = 0;
            this.txtChequeNo.ShortcutsEnabled = true;
            this.txtChequeNo.Size = new System.Drawing.Size(180, 23);
            this.txtChequeNo.TabIndex = 14;
            this.txtChequeNo.UseSelectable = true;
            this.txtChequeNo.WaterMark = "Cheque No";
            this.txtChequeNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChequeNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // VDate
            // 
            this.VDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VDate.Location = new System.Drawing.Point(377, 1);
            this.VDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.VDate.Name = "VDate";
            this.VDate.Size = new System.Drawing.Size(169, 29);
            this.VDate.TabIndex = 13;
            // 
            // btnClose
            // 
            this.btnClose.ActiveControl = null;
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(546, 413);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 35);
            this.btnClose.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClose.UseSelectable = true;
            this.btnClose.UseStyleColors = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveControl = null;
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(434, 413);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 35);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.UseStyleColors = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(316, 413);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 35);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ColTransaction
            // 
            this.ColTransaction.DataPropertyName = "TransactionID";
            this.ColTransaction.HeaderText = "TransactionId";
            this.ColTransaction.Name = "ColTransaction";
            this.ColTransaction.Visible = false;
            // 
            // ColIdDetailVoucher
            // 
            this.ColIdDetailVoucher.HeaderText = "ColDetailVoucher";
            this.ColIdDetailVoucher.Name = "ColIdDetailVoucher";
            this.ColIdDetailVoucher.Visible = false;
            // 
            // colAccount
            // 
            this.colAccount.DataPropertyName = "AccountNo";
            this.colAccount.HeaderText = "Acc. #";
            this.colAccount.Name = "colAccount";
            // 
            // colAccountName
            // 
            this.colAccountName.HeaderText = "A/C Name";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.Width = 150;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Width = 300;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            // 
            // frmBankVocher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 506);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DgvBankVoucher);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmBankVocher";
            this.Text = "BankPaymentVoucher";
            this.Load += new System.EventHandler(this.frmBankPaymentVoucher_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmBankPaymentVoucher_KeyPress);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBankVoucher)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatuMessage;
        private System.Windows.Forms.DataGridView DgvBankVoucher;
        private System.Windows.Forms.CheckBox chkPosted;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroDateTime VDate;
        private MetroFramework.Controls.MetroTextBox txtAccountName;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroTextBox txtChequeNo;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroLabel lblDiscription;
        private MetroFramework.Controls.MetroLabel lblChequeNo;
        private MetroFramework.Controls.MetroLabel lblBankAccountNo;
        private MetroFramework.Controls.MetroLabel lblVoucherNo;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox VEditBox;
        private MetroFramework.Controls.MetroTextBox BEditBox;
        private MetroFramework.Controls.MetroTile btnClose;
        private MetroFramework.Controls.MetroTile btnDelete;
        private MetroFramework.Controls.MetroTile btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdDetailVoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
    }
}