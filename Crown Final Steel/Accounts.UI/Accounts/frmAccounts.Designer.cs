namespace Accounts.UI
{
    partial class frmAccounts
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CbxHeadsLevel1 = new MetroFramework.Controls.MetroComboBox();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.chkActive = new MetroFramework.Controls.MetroCheckBox();
            this.txtDiscription = new MetroFramework.Controls.MetroTextBox();
            this.txtAccountTitle = new MetroFramework.Controls.MetroTextBox();
            this.txtPersonalCode = new MetroFramework.Controls.MetroTextBox();
            this.txtAccountNo = new MetroFramework.Controls.MetroTextBox();
            this.CbxHeadsLevel3 = new MetroFramework.Controls.MetroComboBox();
            this.CbxHeadsLevel2 = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAllInActiveAccounts = new MetroFramework.Controls.MetroCheckBox();
            this.txtSearchAccounts = new MetroFramework.Controls.MetroTextBox();
            this.chkAllAccounts = new MetroFramework.Controls.MetroCheckBox();
            this.grdAccounts = new Accounts.UI.CustomDataGrid();
            this.colAccountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdParent1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colACTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(-6, 63);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.MistyRose;
            this.splitContainer1.Panel1.Controls.Add(this.CbxHeadsLevel1);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.chkActive);
            this.splitContainer1.Panel1.Controls.Add(this.txtDiscription);
            this.splitContainer1.Panel1.Controls.Add(this.txtAccountTitle);
            this.splitContainer1.Panel1.Controls.Add(this.txtPersonalCode);
            this.splitContainer1.Panel1.Controls.Add(this.txtAccountNo);
            this.splitContainer1.Panel1.Controls.Add(this.CbxHeadsLevel3);
            this.splitContainer1.Panel1.Controls.Add(this.CbxHeadsLevel2);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1139, 446);
            this.splitContainer1.SplitterDistance = 306;
            this.splitContainer1.TabIndex = 0;
            // 
            // CbxHeadsLevel1
            // 
            this.CbxHeadsLevel1.FormattingEnabled = true;
            this.CbxHeadsLevel1.ItemHeight = 23;
            this.CbxHeadsLevel1.Location = new System.Drawing.Point(31, 18);
            this.CbxHeadsLevel1.Name = "CbxHeadsLevel1";
            this.CbxHeadsLevel1.Size = new System.Drawing.Size(251, 29);
            this.CbxHeadsLevel1.Style = MetroFramework.MetroColorStyle.Silver;
            this.CbxHeadsLevel1.TabIndex = 1;
            this.CbxHeadsLevel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CbxHeadsLevel1.UseSelectable = true;
            this.CbxHeadsLevel1.SelectedIndexChanged += new System.EventHandler(this.CbxHeads_SelectedIndexChanged);
            this.CbxHeadsLevel1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxHeads_KeyPress);
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveControl = null;
            this.btnDelete.Location = new System.Drawing.Point(121, 328);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 35);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.Location = new System.Drawing.Point(26, 328);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 35);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(27, 292);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(68, 15);
            this.chkActive.TabIndex = 6;
            this.chkActive.Text = "Suspend";
            this.chkActive.UseCustomBackColor = true;
            this.chkActive.UseSelectable = true;
            // 
            // txtDiscription
            // 
            // 
            // 
            // 
            this.txtDiscription.CustomButton.Image = null;
            this.txtDiscription.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.txtDiscription.CustomButton.Name = "";
            this.txtDiscription.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDiscription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiscription.CustomButton.TabIndex = 1;
            this.txtDiscription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiscription.CustomButton.UseSelectable = true;
            this.txtDiscription.CustomButton.Visible = false;
            this.txtDiscription.Lines = new string[0];
            this.txtDiscription.Location = new System.Drawing.Point(27, 252);
            this.txtDiscription.MaxLength = 32767;
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.PasswordChar = '\0';
            this.txtDiscription.PromptText = "Account Discription";
            this.txtDiscription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiscription.SelectedText = "";
            this.txtDiscription.SelectionLength = 0;
            this.txtDiscription.SelectionStart = 0;
            this.txtDiscription.ShortcutsEnabled = true;
            this.txtDiscription.Size = new System.Drawing.Size(257, 23);
            this.txtDiscription.TabIndex = 5;
            this.txtDiscription.UseSelectable = true;
            this.txtDiscription.WaterMark = "Account Discription";
            this.txtDiscription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiscription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAccountTitle
            // 
            // 
            // 
            // 
            this.txtAccountTitle.CustomButton.Image = null;
            this.txtAccountTitle.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txtAccountTitle.CustomButton.Name = "";
            this.txtAccountTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAccountTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccountTitle.CustomButton.TabIndex = 1;
            this.txtAccountTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccountTitle.CustomButton.UseSelectable = true;
            this.txtAccountTitle.CustomButton.Visible = false;
            this.txtAccountTitle.Lines = new string[0];
            this.txtAccountTitle.Location = new System.Drawing.Point(29, 217);
            this.txtAccountTitle.MaxLength = 32767;
            this.txtAccountTitle.Name = "txtAccountTitle";
            this.txtAccountTitle.PasswordChar = '\0';
            this.txtAccountTitle.PromptText = "Account Title";
            this.txtAccountTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccountTitle.SelectedText = "";
            this.txtAccountTitle.SelectionLength = 0;
            this.txtAccountTitle.SelectionStart = 0;
            this.txtAccountTitle.ShortcutsEnabled = true;
            this.txtAccountTitle.Size = new System.Drawing.Size(253, 23);
            this.txtAccountTitle.TabIndex = 4;
            this.txtAccountTitle.UseSelectable = true;
            this.txtAccountTitle.WaterMark = "Account Title";
            this.txtAccountTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccountTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAccountTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountTitle_KeyPress);
            // 
            // txtPersonalCode
            // 
            // 
            // 
            // 
            this.txtPersonalCode.CustomButton.Image = null;
            this.txtPersonalCode.CustomButton.Location = new System.Drawing.Point(232, 1);
            this.txtPersonalCode.CustomButton.Name = "";
            this.txtPersonalCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPersonalCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPersonalCode.CustomButton.TabIndex = 1;
            this.txtPersonalCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPersonalCode.CustomButton.UseSelectable = true;
            this.txtPersonalCode.CustomButton.Visible = false;
            this.txtPersonalCode.Lines = new string[0];
            this.txtPersonalCode.Location = new System.Drawing.Point(28, 179);
            this.txtPersonalCode.MaxLength = 32767;
            this.txtPersonalCode.Name = "txtPersonalCode";
            this.txtPersonalCode.PasswordChar = '\0';
            this.txtPersonalCode.PromptText = "Personal Account No";
            this.txtPersonalCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPersonalCode.SelectedText = "";
            this.txtPersonalCode.SelectionLength = 0;
            this.txtPersonalCode.SelectionStart = 0;
            this.txtPersonalCode.ShortcutsEnabled = true;
            this.txtPersonalCode.Size = new System.Drawing.Size(254, 23);
            this.txtPersonalCode.TabIndex = 3;
            this.txtPersonalCode.UseSelectable = true;
            this.txtPersonalCode.WaterMark = "Personal Account No";
            this.txtPersonalCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPersonalCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPersonalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonalCode_KeyPress);
            // 
            // txtAccountNo
            // 
            // 
            // 
            // 
            this.txtAccountNo.CustomButton.Image = null;
            this.txtAccountNo.CustomButton.Location = new System.Drawing.Point(232, 1);
            this.txtAccountNo.CustomButton.Name = "";
            this.txtAccountNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAccountNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccountNo.CustomButton.TabIndex = 1;
            this.txtAccountNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccountNo.CustomButton.UseSelectable = true;
            this.txtAccountNo.CustomButton.Visible = false;
            this.txtAccountNo.Enabled = false;
            this.txtAccountNo.Lines = new string[0];
            this.txtAccountNo.Location = new System.Drawing.Point(28, 142);
            this.txtAccountNo.MaxLength = 32767;
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.PasswordChar = '\0';
            this.txtAccountNo.PromptText = "Auto Account No";
            this.txtAccountNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccountNo.SelectedText = "";
            this.txtAccountNo.SelectionLength = 0;
            this.txtAccountNo.SelectionStart = 0;
            this.txtAccountNo.ShortcutsEnabled = true;
            this.txtAccountNo.Size = new System.Drawing.Size(254, 23);
            this.txtAccountNo.TabIndex = 3;
            this.txtAccountNo.UseSelectable = true;
            this.txtAccountNo.WaterMark = "Auto Account No";
            this.txtAccountNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccountNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CbxHeadsLevel3
            // 
            this.CbxHeadsLevel3.FormattingEnabled = true;
            this.CbxHeadsLevel3.ItemHeight = 23;
            this.CbxHeadsLevel3.Location = new System.Drawing.Point(29, 101);
            this.CbxHeadsLevel3.Name = "CbxHeadsLevel3";
            this.CbxHeadsLevel3.Size = new System.Drawing.Size(253, 29);
            this.CbxHeadsLevel3.Style = MetroFramework.MetroColorStyle.Silver;
            this.CbxHeadsLevel3.TabIndex = 2;
            this.CbxHeadsLevel3.UseSelectable = true;
            this.CbxHeadsLevel3.SelectedIndexChanged += new System.EventHandler(this.CbxHeads_SelectedIndexChanged);
            this.CbxHeadsLevel3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxHeads_KeyPress);
            // 
            // CbxHeadsLevel2
            // 
            this.CbxHeadsLevel2.FormattingEnabled = true;
            this.CbxHeadsLevel2.ItemHeight = 23;
            this.CbxHeadsLevel2.Location = new System.Drawing.Point(31, 60);
            this.CbxHeadsLevel2.Name = "CbxHeadsLevel2";
            this.CbxHeadsLevel2.Size = new System.Drawing.Size(251, 29);
            this.CbxHeadsLevel2.Style = MetroFramework.MetroColorStyle.Silver;
            this.CbxHeadsLevel2.TabIndex = 0;
            this.CbxHeadsLevel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CbxHeadsLevel2.UseSelectable = true;
            this.CbxHeadsLevel2.SelectedIndexChanged += new System.EventHandler(this.CbxHeads_SelectedIndexChanged);
            this.CbxHeadsLevel2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbxHeads_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.chkAllInActiveAccounts);
            this.groupBox1.Controls.Add(this.txtSearchAccounts);
            this.groupBox1.Controls.Add(this.chkAllAccounts);
            this.groupBox1.Controls.Add(this.grdAccounts);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 432);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Accounts";
            // 
            // chkAllInActiveAccounts
            // 
            this.chkAllInActiveAccounts.AutoSize = true;
            this.chkAllInActiveAccounts.Location = new System.Drawing.Point(557, 24);
            this.chkAllInActiveAccounts.Name = "chkAllInActiveAccounts";
            this.chkAllInActiveAccounts.Size = new System.Drawing.Size(147, 15);
            this.chkAllInActiveAccounts.TabIndex = 1;
            this.chkAllInActiveAccounts.Text = "View InActive Accounts";
            this.chkAllInActiveAccounts.UseSelectable = true;
            this.chkAllInActiveAccounts.CheckedChanged += new System.EventHandler(this.chkAllInActiveAccounts_CheckedChanged);
            // 
            // txtSearchAccounts
            // 
            // 
            // 
            // 
            this.txtSearchAccounts.CustomButton.Image = null;
            this.txtSearchAccounts.CustomButton.Location = new System.Drawing.Point(420, 2);
            this.txtSearchAccounts.CustomButton.Name = "";
            this.txtSearchAccounts.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtSearchAccounts.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchAccounts.CustomButton.TabIndex = 1;
            this.txtSearchAccounts.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchAccounts.CustomButton.UseSelectable = true;
            this.txtSearchAccounts.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSearchAccounts.Lines = new string[0];
            this.txtSearchAccounts.Location = new System.Drawing.Point(10, 20);
            this.txtSearchAccounts.MaxLength = 32767;
            this.txtSearchAccounts.Name = "txtSearchAccounts";
            this.txtSearchAccounts.PasswordChar = '\0';
            this.txtSearchAccounts.PromptText = "Type And Search Accounts Here";
            this.txtSearchAccounts.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchAccounts.SelectedText = "";
            this.txtSearchAccounts.SelectionLength = 0;
            this.txtSearchAccounts.SelectionStart = 0;
            this.txtSearchAccounts.ShortcutsEnabled = true;
            this.txtSearchAccounts.ShowButton = true;
            this.txtSearchAccounts.Size = new System.Drawing.Size(440, 22);
            this.txtSearchAccounts.Style = MetroFramework.MetroColorStyle.Green;
            this.txtSearchAccounts.TabIndex = 0;
            this.txtSearchAccounts.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchAccounts.UseSelectable = true;
            this.txtSearchAccounts.WaterMark = "Type And Search Accounts Here";
            this.txtSearchAccounts.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchAccounts.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchAccounts.TextChanged += new System.EventHandler(this.txtSearchAccounts_TextChanged);
            this.txtSearchAccounts.Enter += new System.EventHandler(this.txtSearchAccounts_Enter);
            this.txtSearchAccounts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchAccounts_KeyPress);
            // 
            // chkAllAccounts
            // 
            this.chkAllAccounts.AutoSize = true;
            this.chkAllAccounts.Location = new System.Drawing.Point(456, 24);
            this.chkAllAccounts.Name = "chkAllAccounts";
            this.chkAllAccounts.Size = new System.Drawing.Size(90, 15);
            this.chkAllAccounts.TabIndex = 1;
            this.chkAllAccounts.Text = "All Accounts";
            this.chkAllAccounts.UseSelectable = true;
            this.chkAllAccounts.CheckedChanged += new System.EventHandler(this.chkAllAccounts_CheckedChanged);
            // 
            // grdAccounts
            // 
            this.grdAccounts.AllowUserToAddRows = false;
            this.grdAccounts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdAccounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdAccounts.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdAccounts.ColumnHeadersHeight = 25;
            this.grdAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAccountId,
            this.colIdParent1,
            this.colAccountCode,
            this.colACTitle,
            this.colDiscription,
            this.colHeader});
            this.grdAccounts.EnableHeadersVisualStyles = false;
            this.grdAccounts.Location = new System.Drawing.Point(6, 48);
            this.grdAccounts.Name = "grdAccounts";
            this.grdAccounts.ReadOnly = true;
            this.grdAccounts.RowHeadersVisible = false;
            this.grdAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAccounts.Size = new System.Drawing.Size(804, 384);
            this.grdAccounts.TabIndex = 1;
            this.grdAccounts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAccounts_CellDoubleClick);
            this.grdAccounts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grdAccounts_KeyPress);
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
            this.colAccountCode.HeaderText = "A/C Code";
            this.colAccountCode.Name = "colAccountCode";
            this.colAccountCode.ReadOnly = true;
            this.colAccountCode.Width = 130;
            // 
            // colACTitle
            // 
            this.colACTitle.DataPropertyName = "AccountName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colACTitle.DefaultCellStyle = dataGridViewCellStyle3;
            this.colACTitle.HeaderText = "A/C Title";
            this.colACTitle.Name = "colACTitle";
            this.colACTitle.ReadOnly = true;
            this.colACTitle.Width = 200;
            // 
            // colDiscription
            // 
            this.colDiscription.DataPropertyName = "Discription";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colDiscription.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDiscription.HeaderText = "Discription";
            this.colDiscription.Name = "colDiscription";
            this.colDiscription.ReadOnly = true;
            this.colDiscription.Width = 210;
            // 
            // colHeader
            // 
            this.colHeader.DataPropertyName = "AccountType";
            this.colHeader.HeaderText = "Head";
            this.colHeader.Name = "colHeader";
            this.colHeader.ReadOnly = true;
            this.colHeader.Width = 250;
            // 
            // frmAccounts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1146, 532);
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmAccounts";
            this.Text = "Accounts Setup";
            this.Load += new System.EventHandler(this.frmAccounts_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmAccounts_KeyUp);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private CustomDataGrid grdAccounts;
        private MetroFramework.Controls.MetroComboBox CbxHeadsLevel3;
        private MetroFramework.Controls.MetroComboBox CbxHeadsLevel1;
        private MetroFramework.Controls.MetroTextBox txtAccountTitle;
        private MetroFramework.Controls.MetroTextBox txtAccountNo;
        private MetroFramework.Controls.MetroCheckBox chkActive;
        private MetroFramework.Controls.MetroTile btnDelete;
        private MetroFramework.Controls.MetroTile btnSave;
        private MetroFramework.Controls.MetroTextBox txtSearchAccounts;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtDiscription;
        private MetroFramework.Controls.MetroCheckBox chkAllAccounts;
        private MetroFramework.Controls.MetroComboBox CbxHeadsLevel2;
        private MetroFramework.Controls.MetroCheckBox chkAllInActiveAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdParent1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colACTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeader;
        private MetroFramework.Controls.MetroTextBox txtPersonalCode;
    }
}