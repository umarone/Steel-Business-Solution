namespace Accounts.UI
{
    partial class frmHeadsSetup
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
            this.cbxHeadsLevel2 = new MetroFramework.Controls.MetroComboBox();
            this.btnSaveLevel2 = new MetroFramework.Controls.MetroTile();
            this.txtAccountNumberLevel2 = new MetroFramework.Controls.MetroTextBox();
            this.txtAccountNameLevel2 = new MetroFramework.Controls.MetroTextBox();
            this.cbxHeadsLevel3 = new MetroFramework.Controls.MetroComboBox();
            this.cbxSubHeadsLevel3 = new MetroFramework.Controls.MetroComboBox();
            this.btnSaveLevel3 = new MetroFramework.Controls.MetroTile();
            this.txtAccountNumberLevel3 = new MetroFramework.Controls.MetroTextBox();
            this.txtAccountNameLevel3 = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteLevel2 = new MetroFramework.Controls.MetroTile();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteLevel3 = new MetroFramework.Controls.MetroTile();
            this.grdHeadsLevel3 = new Accounts.UI.CustomDataGrid();
            this.colLevel3IsSystemAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLevel3IdAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLevel3IdParent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLevel3HeadCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLevel3AcTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLevel3Discription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLevel3Head = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdHeadsLevel2 = new Accounts.UI.CustomDataGrid();
            this.colIsSystemAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdParent1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colACTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHeadsLevel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdHeadsLevel2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxHeadsLevel2
            // 
            this.cbxHeadsLevel2.FormattingEnabled = true;
            this.cbxHeadsLevel2.ItemHeight = 23;
            this.cbxHeadsLevel2.Location = new System.Drawing.Point(23, 83);
            this.cbxHeadsLevel2.Name = "cbxHeadsLevel2";
            this.cbxHeadsLevel2.Size = new System.Drawing.Size(193, 29);
            this.cbxHeadsLevel2.Style = MetroFramework.MetroColorStyle.Silver;
            this.cbxHeadsLevel2.TabIndex = 2;
            this.cbxHeadsLevel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbxHeadsLevel2.UseSelectable = true;
            this.cbxHeadsLevel2.SelectedIndexChanged += new System.EventHandler(this.CbxHeads_SelectedIndexChanged);
            // 
            // btnSaveLevel2
            // 
            this.btnSaveLevel2.ActiveControl = null;
            this.btnSaveLevel2.Location = new System.Drawing.Point(9, 150);
            this.btnSaveLevel2.Name = "btnSaveLevel2";
            this.btnSaveLevel2.Size = new System.Drawing.Size(94, 71);
            this.btnSaveLevel2.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnSaveLevel2.TabIndex = 9;
            this.btnSaveLevel2.Text = "Save";
            this.btnSaveLevel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveLevel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSaveLevel2.UseSelectable = true;
            this.btnSaveLevel2.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAccountNumberLevel2
            // 
            // 
            // 
            // 
            this.txtAccountNumberLevel2.CustomButton.Image = null;
            this.txtAccountNumberLevel2.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtAccountNumberLevel2.CustomButton.Name = "";
            this.txtAccountNumberLevel2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAccountNumberLevel2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccountNumberLevel2.CustomButton.TabIndex = 1;
            this.txtAccountNumberLevel2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccountNumberLevel2.CustomButton.UseSelectable = true;
            this.txtAccountNumberLevel2.CustomButton.Visible = false;
            this.txtAccountNumberLevel2.Enabled = false;
            this.txtAccountNumberLevel2.Lines = new string[0];
            this.txtAccountNumberLevel2.Location = new System.Drawing.Point(23, 116);
            this.txtAccountNumberLevel2.MaxLength = 32767;
            this.txtAccountNumberLevel2.Name = "txtAccountNumberLevel2";
            this.txtAccountNumberLevel2.PasswordChar = '\0';
            this.txtAccountNumberLevel2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccountNumberLevel2.SelectedText = "";
            this.txtAccountNumberLevel2.SelectionLength = 0;
            this.txtAccountNumberLevel2.SelectionStart = 0;
            this.txtAccountNumberLevel2.ShortcutsEnabled = true;
            this.txtAccountNumberLevel2.Size = new System.Drawing.Size(193, 23);
            this.txtAccountNumberLevel2.TabIndex = 11;
            this.txtAccountNumberLevel2.UseSelectable = true;
            this.txtAccountNumberLevel2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccountNumberLevel2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAccountNameLevel2
            // 
            // 
            // 
            // 
            this.txtAccountNameLevel2.CustomButton.Image = null;
            this.txtAccountNameLevel2.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtAccountNameLevel2.CustomButton.Name = "";
            this.txtAccountNameLevel2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAccountNameLevel2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccountNameLevel2.CustomButton.TabIndex = 1;
            this.txtAccountNameLevel2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccountNameLevel2.CustomButton.UseSelectable = true;
            this.txtAccountNameLevel2.CustomButton.Visible = false;
            this.txtAccountNameLevel2.Lines = new string[0];
            this.txtAccountNameLevel2.Location = new System.Drawing.Point(23, 144);
            this.txtAccountNameLevel2.MaxLength = 32767;
            this.txtAccountNameLevel2.Name = "txtAccountNameLevel2";
            this.txtAccountNameLevel2.PasswordChar = '\0';
            this.txtAccountNameLevel2.PromptText = "Head Title";
            this.txtAccountNameLevel2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccountNameLevel2.SelectedText = "";
            this.txtAccountNameLevel2.SelectionLength = 0;
            this.txtAccountNameLevel2.SelectionStart = 0;
            this.txtAccountNameLevel2.ShortcutsEnabled = true;
            this.txtAccountNameLevel2.Size = new System.Drawing.Size(193, 23);
            this.txtAccountNameLevel2.TabIndex = 11;
            this.txtAccountNameLevel2.UseSelectable = true;
            this.txtAccountNameLevel2.WaterMark = "Head Title";
            this.txtAccountNameLevel2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccountNameLevel2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbxHeadsLevel3
            // 
            this.cbxHeadsLevel3.FormattingEnabled = true;
            this.cbxHeadsLevel3.ItemHeight = 23;
            this.cbxHeadsLevel3.Location = new System.Drawing.Point(481, 85);
            this.cbxHeadsLevel3.Name = "cbxHeadsLevel3";
            this.cbxHeadsLevel3.Size = new System.Drawing.Size(193, 29);
            this.cbxHeadsLevel3.Style = MetroFramework.MetroColorStyle.Silver;
            this.cbxHeadsLevel3.TabIndex = 2;
            this.cbxHeadsLevel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbxHeadsLevel3.UseSelectable = true;
            this.cbxHeadsLevel3.SelectedIndexChanged += new System.EventHandler(this.CbxHeads_SelectedIndexChanged);
            // 
            // cbxSubHeadsLevel3
            // 
            this.cbxSubHeadsLevel3.FormattingEnabled = true;
            this.cbxSubHeadsLevel3.ItemHeight = 23;
            this.cbxSubHeadsLevel3.Location = new System.Drawing.Point(481, 118);
            this.cbxSubHeadsLevel3.Name = "cbxSubHeadsLevel3";
            this.cbxSubHeadsLevel3.Size = new System.Drawing.Size(193, 29);
            this.cbxSubHeadsLevel3.Style = MetroFramework.MetroColorStyle.Silver;
            this.cbxSubHeadsLevel3.TabIndex = 2;
            this.cbxSubHeadsLevel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbxSubHeadsLevel3.UseSelectable = true;
            this.cbxSubHeadsLevel3.SelectedIndexChanged += new System.EventHandler(this.CbxHeads_SelectedIndexChanged);
            // 
            // btnSaveLevel3
            // 
            this.btnSaveLevel3.ActiveControl = null;
            this.btnSaveLevel3.Location = new System.Drawing.Point(481, 210);
            this.btnSaveLevel3.Name = "btnSaveLevel3";
            this.btnSaveLevel3.Size = new System.Drawing.Size(94, 71);
            this.btnSaveLevel3.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnSaveLevel3.TabIndex = 9;
            this.btnSaveLevel3.Text = "Save";
            this.btnSaveLevel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveLevel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSaveLevel3.UseSelectable = true;
            this.btnSaveLevel3.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAccountNumberLevel3
            // 
            // 
            // 
            // 
            this.txtAccountNumberLevel3.CustomButton.Image = null;
            this.txtAccountNumberLevel3.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtAccountNumberLevel3.CustomButton.Name = "";
            this.txtAccountNumberLevel3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAccountNumberLevel3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccountNumberLevel3.CustomButton.TabIndex = 1;
            this.txtAccountNumberLevel3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccountNumberLevel3.CustomButton.UseSelectable = true;
            this.txtAccountNumberLevel3.CustomButton.Visible = false;
            this.txtAccountNumberLevel3.Enabled = false;
            this.txtAccountNumberLevel3.Lines = new string[0];
            this.txtAccountNumberLevel3.Location = new System.Drawing.Point(481, 150);
            this.txtAccountNumberLevel3.MaxLength = 32767;
            this.txtAccountNumberLevel3.Name = "txtAccountNumberLevel3";
            this.txtAccountNumberLevel3.PasswordChar = '\0';
            this.txtAccountNumberLevel3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccountNumberLevel3.SelectedText = "";
            this.txtAccountNumberLevel3.SelectionLength = 0;
            this.txtAccountNumberLevel3.SelectionStart = 0;
            this.txtAccountNumberLevel3.ShortcutsEnabled = true;
            this.txtAccountNumberLevel3.Size = new System.Drawing.Size(193, 23);
            this.txtAccountNumberLevel3.TabIndex = 11;
            this.txtAccountNumberLevel3.UseSelectable = true;
            this.txtAccountNumberLevel3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccountNumberLevel3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAccountNameLevel3
            // 
            // 
            // 
            // 
            this.txtAccountNameLevel3.CustomButton.Image = null;
            this.txtAccountNameLevel3.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtAccountNameLevel3.CustomButton.Name = "";
            this.txtAccountNameLevel3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAccountNameLevel3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccountNameLevel3.CustomButton.TabIndex = 1;
            this.txtAccountNameLevel3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccountNameLevel3.CustomButton.UseSelectable = true;
            this.txtAccountNameLevel3.CustomButton.Visible = false;
            this.txtAccountNameLevel3.Lines = new string[0];
            this.txtAccountNameLevel3.Location = new System.Drawing.Point(481, 177);
            this.txtAccountNameLevel3.MaxLength = 32767;
            this.txtAccountNameLevel3.Name = "txtAccountNameLevel3";
            this.txtAccountNameLevel3.PasswordChar = '\0';
            this.txtAccountNameLevel3.PromptText = "Head Title";
            this.txtAccountNameLevel3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccountNameLevel3.SelectedText = "";
            this.txtAccountNameLevel3.SelectionLength = 0;
            this.txtAccountNameLevel3.SelectionStart = 0;
            this.txtAccountNameLevel3.ShortcutsEnabled = true;
            this.txtAccountNameLevel3.Size = new System.Drawing.Size(193, 23);
            this.txtAccountNameLevel3.TabIndex = 11;
            this.txtAccountNameLevel3.UseSelectable = true;
            this.txtAccountNameLevel3.WaterMark = "Head Title";
            this.txtAccountNameLevel3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccountNameLevel3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.btnDeleteLevel2);
            this.groupBox1.Controls.Add(this.btnSaveLevel2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 456);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Level2";
            // 
            // btnDeleteLevel2
            // 
            this.btnDeleteLevel2.ActiveControl = null;
            this.btnDeleteLevel2.Location = new System.Drawing.Point(105, 150);
            this.btnDeleteLevel2.Name = "btnDeleteLevel2";
            this.btnDeleteLevel2.Size = new System.Drawing.Size(94, 71);
            this.btnDeleteLevel2.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnDeleteLevel2.TabIndex = 9;
            this.btnDeleteLevel2.Text = "Delete";
            this.btnDeleteLevel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteLevel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDeleteLevel2.UseSelectable = true;
            this.btnDeleteLevel2.Click += new System.EventHandler(this.btnDeleteLevel2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Snow;
            this.groupBox2.Controls.Add(this.btnDeleteLevel3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(467, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 456);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Level 3 ";
            // 
            // btnDeleteLevel3
            // 
            this.btnDeleteLevel3.ActiveControl = null;
            this.btnDeleteLevel3.Location = new System.Drawing.Point(109, 149);
            this.btnDeleteLevel3.Name = "btnDeleteLevel3";
            this.btnDeleteLevel3.Size = new System.Drawing.Size(94, 71);
            this.btnDeleteLevel3.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnDeleteLevel3.TabIndex = 9;
            this.btnDeleteLevel3.Text = "Delete";
            this.btnDeleteLevel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteLevel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDeleteLevel3.UseSelectable = true;
            this.btnDeleteLevel3.Click += new System.EventHandler(this.btnDeleteLevel3_Click);
            // 
            // grdHeadsLevel3
            // 
            this.grdHeadsLevel3.AllowUserToAddRows = false;
            this.grdHeadsLevel3.AllowUserToDeleteRows = false;
            this.grdHeadsLevel3.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdHeadsLevel3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdHeadsLevel3.ColumnHeadersHeight = 26;
            this.grdHeadsLevel3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLevel3IsSystemAccount,
            this.colLevel3IdAccount,
            this.colLevel3IdParent,
            this.colLevel3HeadCode,
            this.colLevel3AcTitle,
            this.colLevel3Discription,
            this.colLevel3Head});
            this.grdHeadsLevel3.EnableHeadersVisualStyles = false;
            this.grdHeadsLevel3.Location = new System.Drawing.Point(481, 287);
            this.grdHeadsLevel3.Name = "grdHeadsLevel3";
            this.grdHeadsLevel3.ReadOnly = true;
            this.grdHeadsLevel3.RowHeadersVisible = false;
            this.grdHeadsLevel3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdHeadsLevel3.Size = new System.Drawing.Size(424, 224);
            this.grdHeadsLevel3.TabIndex = 12;
            this.grdHeadsLevel3.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdHeadsLevel3_CellDoubleClick);
            // 
            // colLevel3IsSystemAccount
            // 
            this.colLevel3IsSystemAccount.DataPropertyName = "IsSystemAccount";
            this.colLevel3IsSystemAccount.HeaderText = "...";
            this.colLevel3IsSystemAccount.Name = "colLevel3IsSystemAccount";
            this.colLevel3IsSystemAccount.ReadOnly = true;
            this.colLevel3IsSystemAccount.Visible = false;
            // 
            // colLevel3IdAccount
            // 
            this.colLevel3IdAccount.DataPropertyName = "IdAccount";
            this.colLevel3IdAccount.HeaderText = "AccountId";
            this.colLevel3IdAccount.Name = "colLevel3IdAccount";
            this.colLevel3IdAccount.ReadOnly = true;
            this.colLevel3IdAccount.Visible = false;
            // 
            // colLevel3IdParent
            // 
            this.colLevel3IdParent.DataPropertyName = "IdParent";
            this.colLevel3IdParent.HeaderText = "IdParent";
            this.colLevel3IdParent.Name = "colLevel3IdParent";
            this.colLevel3IdParent.ReadOnly = true;
            this.colLevel3IdParent.Visible = false;
            // 
            // colLevel3HeadCode
            // 
            this.colLevel3HeadCode.DataPropertyName = "AccountNo";
            this.colLevel3HeadCode.HeaderText = "Head Code";
            this.colLevel3HeadCode.Name = "colLevel3HeadCode";
            this.colLevel3HeadCode.ReadOnly = true;
            // 
            // colLevel3AcTitle
            // 
            this.colLevel3AcTitle.DataPropertyName = "AccountName";
            this.colLevel3AcTitle.HeaderText = "Head Title";
            this.colLevel3AcTitle.Name = "colLevel3AcTitle";
            this.colLevel3AcTitle.ReadOnly = true;
            this.colLevel3AcTitle.Width = 170;
            // 
            // colLevel3Discription
            // 
            this.colLevel3Discription.DataPropertyName = "Discription";
            this.colLevel3Discription.HeaderText = "Discription";
            this.colLevel3Discription.Name = "colLevel3Discription";
            this.colLevel3Discription.ReadOnly = true;
            this.colLevel3Discription.Visible = false;
            this.colLevel3Discription.Width = 210;
            // 
            // colLevel3Head
            // 
            this.colLevel3Head.DataPropertyName = "AccountType";
            this.colLevel3Head.HeaderText = "Head";
            this.colLevel3Head.Name = "colLevel3Head";
            this.colLevel3Head.ReadOnly = true;
            this.colLevel3Head.Width = 150;
            // 
            // grdHeadsLevel2
            // 
            this.grdHeadsLevel2.AllowUserToAddRows = false;
            this.grdHeadsLevel2.AllowUserToDeleteRows = false;
            this.grdHeadsLevel2.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdHeadsLevel2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdHeadsLevel2.ColumnHeadersHeight = 26;
            this.grdHeadsLevel2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIsSystemAccount,
            this.colAccountId,
            this.colIdParent1,
            this.colAccountCode,
            this.colACTitle,
            this.colDiscription,
            this.colHeader});
            this.grdHeadsLevel2.EnableHeadersVisualStyles = false;
            this.grdHeadsLevel2.Location = new System.Drawing.Point(23, 287);
            this.grdHeadsLevel2.Name = "grdHeadsLevel2";
            this.grdHeadsLevel2.ReadOnly = true;
            this.grdHeadsLevel2.RowHeadersVisible = false;
            this.grdHeadsLevel2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdHeadsLevel2.Size = new System.Drawing.Size(431, 223);
            this.grdHeadsLevel2.TabIndex = 12;
            this.grdHeadsLevel2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdHeadsLevel2_CellDoubleClick);
            // 
            // colIsSystemAccount
            // 
            this.colIsSystemAccount.DataPropertyName = "IsSystemAccount";
            this.colIsSystemAccount.HeaderText = "....";
            this.colIsSystemAccount.Name = "colIsSystemAccount";
            this.colIsSystemAccount.ReadOnly = true;
            this.colIsSystemAccount.Visible = false;
            // 
            // colAccountId
            // 
            this.colAccountId.DataPropertyName = "IdAccount";
            this.colAccountId.HeaderText = "AccountId";
            this.colAccountId.Name = "colAccountId";
            this.colAccountId.ReadOnly = true;
            this.colAccountId.Visible = false;
            // 
            // colIdParent1
            // 
            this.colIdParent1.DataPropertyName = "IdParent";
            this.colIdParent1.HeaderText = "IdParent";
            this.colIdParent1.Name = "colIdParent1";
            this.colIdParent1.ReadOnly = true;
            this.colIdParent1.Visible = false;
            // 
            // colAccountCode
            // 
            this.colAccountCode.DataPropertyName = "AccountNo";
            this.colAccountCode.HeaderText = "Head Code";
            this.colAccountCode.Name = "colAccountCode";
            this.colAccountCode.ReadOnly = true;
            // 
            // colACTitle
            // 
            this.colACTitle.DataPropertyName = "AccountName";
            this.colACTitle.HeaderText = "Head Title";
            this.colACTitle.Name = "colACTitle";
            this.colACTitle.ReadOnly = true;
            this.colACTitle.Width = 170;
            // 
            // colDiscription
            // 
            this.colDiscription.DataPropertyName = "Discription";
            this.colDiscription.HeaderText = "Discription";
            this.colDiscription.Name = "colDiscription";
            this.colDiscription.ReadOnly = true;
            this.colDiscription.Visible = false;
            this.colDiscription.Width = 210;
            // 
            // colHeader
            // 
            this.colHeader.DataPropertyName = "AccountType";
            this.colHeader.HeaderText = "Head";
            this.colHeader.Name = "colHeader";
            this.colHeader.ReadOnly = true;
            this.colHeader.Width = 150;
            // 
            // frmHeadsSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 530);
            this.Controls.Add(this.grdHeadsLevel3);
            this.Controls.Add(this.txtAccountNameLevel3);
            this.Controls.Add(this.grdHeadsLevel2);
            this.Controls.Add(this.txtAccountNumberLevel3);
            this.Controls.Add(this.txtAccountNameLevel2);
            this.Controls.Add(this.btnSaveLevel3);
            this.Controls.Add(this.txtAccountNumberLevel2);
            this.Controls.Add(this.cbxSubHeadsLevel3);
            this.Controls.Add(this.cbxHeadsLevel3);
            this.Controls.Add(this.cbxHeadsLevel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.KeyPreview = true;
            this.Name = "frmHeadsSetup";
            this.Text = "Heads Setup";
            this.Load += new System.EventHandler(this.frmHeadsSetup_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmHeadsSetup_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdHeadsLevel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdHeadsLevel2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbxHeadsLevel2;
        private MetroFramework.Controls.MetroTile btnSaveLevel2;
        private MetroFramework.Controls.MetroTextBox txtAccountNumberLevel2;
        private MetroFramework.Controls.MetroTextBox txtAccountNameLevel2;
        private CustomDataGrid grdHeadsLevel2;
        private MetroFramework.Controls.MetroComboBox cbxHeadsLevel3;
        private MetroFramework.Controls.MetroComboBox cbxSubHeadsLevel3;
        private MetroFramework.Controls.MetroTile btnSaveLevel3;
        private MetroFramework.Controls.MetroTextBox txtAccountNumberLevel3;
        private MetroFramework.Controls.MetroTextBox txtAccountNameLevel3;
        private CustomDataGrid grdHeadsLevel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsSystemAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdParent1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colACTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeader;
        private MetroFramework.Controls.MetroTile btnDeleteLevel2;
        private MetroFramework.Controls.MetroTile btnDeleteLevel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevel3IsSystemAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevel3IdAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevel3IdParent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevel3HeadCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevel3AcTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevel3Discription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevel3Head;
    }
}