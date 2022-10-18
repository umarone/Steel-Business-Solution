namespace Accounts.UI
{
    partial class frmUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.spltPersons = new System.Windows.Forms.SplitContainer();
            this.chkSuspend = new MetroFramework.Controls.MetroCheckBox();
            this.dtUserCreation = new MetroFramework.Controls.MetroDateTime();
            this.cbxProjects = new MetroFramework.Controls.MetroComboBox();
            this.cbxCompany = new MetroFramework.Controls.MetroComboBox();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtNIC = new MetroFramework.Controls.MetroTextBox();
            this.txtContact = new MetroFramework.Controls.MetroTextBox();
            this.txtLastName = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.txtFirstName = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAll = new MetroFramework.Controls.MetroCheckBox();
            this.grdUsers = new Accounts.UI.CustomDataGrid();
            this.colIdUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colACTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNewUser = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.spltPersons)).BeginInit();
            this.spltPersons.Panel1.SuspendLayout();
            this.spltPersons.Panel2.SuspendLayout();
            this.spltPersons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // spltPersons
            // 
            this.spltPersons.Location = new System.Drawing.Point(10, 59);
            this.spltPersons.Name = "spltPersons";
            // 
            // spltPersons.Panel1
            // 
            this.spltPersons.Panel1.BackColor = System.Drawing.Color.SeaShell;
            this.spltPersons.Panel1.Controls.Add(this.chkSuspend);
            this.spltPersons.Panel1.Controls.Add(this.dtUserCreation);
            this.spltPersons.Panel1.Controls.Add(this.cbxProjects);
            this.spltPersons.Panel1.Controls.Add(this.cbxCompany);
            this.spltPersons.Panel1.Controls.Add(this.btnNewUser);
            this.spltPersons.Panel1.Controls.Add(this.btnDelete);
            this.spltPersons.Panel1.Controls.Add(this.btnSave);
            this.spltPersons.Panel1.Controls.Add(this.txtAddress);
            this.spltPersons.Panel1.Controls.Add(this.txtNIC);
            this.spltPersons.Panel1.Controls.Add(this.txtContact);
            this.spltPersons.Panel1.Controls.Add(this.txtLastName);
            this.spltPersons.Panel1.Controls.Add(this.txtPassword);
            this.spltPersons.Panel1.Controls.Add(this.txtUserName);
            this.spltPersons.Panel1.Controls.Add(this.txtFirstName);
            // 
            // spltPersons.Panel2
            // 
            this.spltPersons.Panel2.Controls.Add(this.groupBox1);
            this.spltPersons.Size = new System.Drawing.Size(1127, 478);
            this.spltPersons.SplitterDistance = 294;
            this.spltPersons.TabIndex = 1;
            // 
            // chkSuspend
            // 
            this.chkSuspend.AutoSize = true;
            this.chkSuspend.Location = new System.Drawing.Point(30, 364);
            this.chkSuspend.Name = "chkSuspend";
            this.chkSuspend.Size = new System.Drawing.Size(68, 15);
            this.chkSuspend.TabIndex = 8;
            this.chkSuspend.Text = "Suspend";
            this.chkSuspend.UseSelectable = true;
            // 
            // dtUserCreation
            // 
            this.dtUserCreation.Location = new System.Drawing.Point(30, 318);
            this.dtUserCreation.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtUserCreation.Name = "dtUserCreation";
            this.dtUserCreation.Size = new System.Drawing.Size(247, 29);
            this.dtUserCreation.TabIndex = 7;
            this.dtUserCreation.UseCustomBackColor = true;
            // 
            // cbxProjects
            // 
            this.cbxProjects.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cbxProjects.FormattingEnabled = true;
            this.cbxProjects.ItemHeight = 23;
            this.cbxProjects.Location = new System.Drawing.Point(29, 114);
            this.cbxProjects.Name = "cbxProjects";
            this.cbxProjects.Size = new System.Drawing.Size(248, 29);
            this.cbxProjects.TabIndex = 0;
            this.cbxProjects.UseCustomBackColor = true;
            this.cbxProjects.UseSelectable = true;
            // 
            // cbxCompany
            // 
            this.cbxCompany.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.cbxCompany.FormattingEnabled = true;
            this.cbxCompany.ItemHeight = 23;
            this.cbxCompany.Location = new System.Drawing.Point(29, 79);
            this.cbxCompany.Name = "cbxCompany";
            this.cbxCompany.Size = new System.Drawing.Size(248, 29);
            this.cbxCompany.TabIndex = 0;
            this.cbxCompany.UseCustomBackColor = true;
            this.cbxCompany.UseSelectable = true;
            this.cbxCompany.SelectedIndexChanged += new System.EventHandler(this.cbxCompany_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveControl = null;
            this.btnDelete.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDelete.Location = new System.Drawing.Point(198, 395);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 41);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.UseCustomBackColor = true;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSave.Location = new System.Drawing.Point(34, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 41);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(29, 283);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PromptText = "Address";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(248, 23);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMark = "Address";
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNIC
            // 
            this.txtNIC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.txtNIC.CustomButton.Image = null;
            this.txtNIC.CustomButton.Location = new System.Drawing.Point(225, 1);
            this.txtNIC.CustomButton.Name = "";
            this.txtNIC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNIC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNIC.CustomButton.TabIndex = 1;
            this.txtNIC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNIC.CustomButton.UseSelectable = true;
            this.txtNIC.CustomButton.Visible = false;
            this.txtNIC.Lines = new string[0];
            this.txtNIC.Location = new System.Drawing.Point(30, 219);
            this.txtNIC.MaxLength = 32767;
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.PasswordChar = '\0';
            this.txtNIC.PromptText = "CNIC";
            this.txtNIC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNIC.SelectedText = "";
            this.txtNIC.SelectionLength = 0;
            this.txtNIC.SelectionStart = 0;
            this.txtNIC.ShortcutsEnabled = true;
            this.txtNIC.Size = new System.Drawing.Size(247, 23);
            this.txtNIC.TabIndex = 4;
            this.txtNIC.UseSelectable = true;
            this.txtNIC.WaterMark = "CNIC";
            this.txtNIC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNIC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.txtContact.CustomButton.Image = null;
            this.txtContact.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.txtContact.CustomButton.Name = "";
            this.txtContact.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContact.CustomButton.TabIndex = 1;
            this.txtContact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContact.CustomButton.UseSelectable = true;
            this.txtContact.CustomButton.Visible = false;
            this.txtContact.Lines = new string[0];
            this.txtContact.Location = new System.Drawing.Point(29, 252);
            this.txtContact.MaxLength = 32767;
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.PromptText = "Contact";
            this.txtContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContact.SelectedText = "";
            this.txtContact.SelectionLength = 0;
            this.txtContact.SelectionStart = 0;
            this.txtContact.ShortcutsEnabled = true;
            this.txtContact.Size = new System.Drawing.Size(248, 23);
            this.txtContact.TabIndex = 5;
            this.txtContact.UseSelectable = true;
            this.txtContact.WaterMark = "Contact";
            this.txtContact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.txtLastName.CustomButton.Image = null;
            this.txtLastName.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.txtLastName.CustomButton.Name = "";
            this.txtLastName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastName.CustomButton.TabIndex = 1;
            this.txtLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLastName.CustomButton.UseSelectable = true;
            this.txtLastName.CustomButton.Visible = false;
            this.txtLastName.Lines = new string[0];
            this.txtLastName.Location = new System.Drawing.Point(29, 186);
            this.txtLastName.MaxLength = 32767;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PromptText = "Last Name";
            this.txtLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastName.SelectedText = "";
            this.txtLastName.SelectionLength = 0;
            this.txtLastName.SelectionStart = 0;
            this.txtLastName.ShortcutsEnabled = true;
            this.txtLastName.Size = new System.Drawing.Size(248, 23);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.UseSelectable = true;
            this.txtLastName.WaterMark = "Last Name";
            this.txtLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(29, 48);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PromptText = "Password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(248, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseCustomBackColor = true;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMark = "Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.txtUserName.CustomButton.Image = null;
            this.txtUserName.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.txtUserName.CustomButton.Name = "";
            this.txtUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserName.CustomButton.TabIndex = 1;
            this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserName.CustomButton.UseSelectable = true;
            this.txtUserName.CustomButton.Visible = false;
            this.txtUserName.Lines = new string[0];
            this.txtUserName.Location = new System.Drawing.Point(29, 15);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PromptText = "User Name";
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.ShortcutsEnabled = true;
            this.txtUserName.Size = new System.Drawing.Size(248, 23);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.UseCustomBackColor = true;
            this.txtUserName.UseSelectable = true;
            this.txtUserName.WaterMark = "User Name";
            this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.txtFirstName.CustomButton.Image = null;
            this.txtFirstName.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.txtFirstName.CustomButton.Name = "";
            this.txtFirstName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFirstName.CustomButton.TabIndex = 1;
            this.txtFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFirstName.CustomButton.UseSelectable = true;
            this.txtFirstName.CustomButton.Visible = false;
            this.txtFirstName.Lines = new string[0];
            this.txtFirstName.Location = new System.Drawing.Point(29, 152);
            this.txtFirstName.MaxLength = 32767;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PromptText = "First Name";
            this.txtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.ShortcutsEnabled = true;
            this.txtFirstName.Size = new System.Drawing.Size(248, 23);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.UseSelectable = true;
            this.txtFirstName.WaterMark = "First Name";
            this.txtFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.grdUsers);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(20, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 451);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Users";
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(640, 31);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(100, 15);
            this.chkAll.TabIndex = 1;
            this.chkAll.Text = "All Companies";
            this.chkAll.UseSelectable = true;
            this.chkAll.Visible = false;
            // 
            // grdUsers
            // 
            this.grdUsers.AllowUserToAddRows = false;
            this.grdUsers.AllowUserToDeleteRows = false;
            this.grdUsers.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdUser,
            this.colIdCompany,
            this.colACTitle,
            this.colLastName,
            this.colCompanyName,
            this.colNIC,
            this.colContact,
            this.colUserStatus,
            this.colEdit});
            this.grdUsers.EnableHeadersVisualStyles = false;
            this.grdUsers.Location = new System.Drawing.Point(6, 28);
            this.grdUsers.Name = "grdUsers";
            this.grdUsers.ReadOnly = true;
            this.grdUsers.RowHeadersVisible = false;
            this.grdUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUsers.Size = new System.Drawing.Size(794, 417);
            this.grdUsers.TabIndex = 1;
            this.grdUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPersons_CellClick);
            this.grdUsers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdPersons_CellFormatting);
            // 
            // colIdUser
            // 
            this.colIdUser.DataPropertyName = "UserId";
            this.colIdUser.HeaderText = "IdUser";
            this.colIdUser.Name = "colIdUser";
            this.colIdUser.ReadOnly = true;
            this.colIdUser.Visible = false;
            // 
            // colIdCompany
            // 
            this.colIdCompany.DataPropertyName = "IdCompany";
            this.colIdCompany.HeaderText = "IdCompany";
            this.colIdCompany.Name = "colIdCompany";
            this.colIdCompany.ReadOnly = true;
            this.colIdCompany.Visible = false;
            // 
            // colACTitle
            // 
            this.colACTitle.DataPropertyName = "FirstName";
            this.colACTitle.HeaderText = "First Name";
            this.colACTitle.Name = "colACTitle";
            this.colACTitle.ReadOnly = true;
            this.colACTitle.Width = 130;
            // 
            // colLastName
            // 
            this.colLastName.DataPropertyName = "LastName";
            this.colLastName.HeaderText = "Last Name";
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            this.colLastName.Width = 130;
            // 
            // colCompanyName
            // 
            this.colCompanyName.DataPropertyName = "ProjectName";
            this.colCompanyName.HeaderText = "Project";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.ReadOnly = true;
            this.colCompanyName.Width = 130;
            // 
            // colNIC
            // 
            this.colNIC.DataPropertyName = "CNIC";
            this.colNIC.HeaderText = "NIC";
            this.colNIC.Name = "colNIC";
            this.colNIC.ReadOnly = true;
            this.colNIC.Width = 110;
            // 
            // colContact
            // 
            this.colContact.DataPropertyName = "Contact";
            this.colContact.HeaderText = "Contact";
            this.colContact.Name = "colContact";
            this.colContact.ReadOnly = true;
            // 
            // colUserStatus
            // 
            this.colUserStatus.HeaderText = "Suspend";
            this.colUserStatus.Name = "colUserStatus";
            this.colUserStatus.ReadOnly = true;
            this.colUserStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colUserStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colUserStatus.Width = 80;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "....";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnNewUser
            // 
            this.btnNewUser.ActiveControl = null;
            this.btnNewUser.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNewUser.Location = new System.Drawing.Point(118, 395);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(79, 41);
            this.btnNewUser.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnNewUser.TabIndex = 10;
            this.btnNewUser.Text = "New User";
            this.btnNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewUser.UseCustomBackColor = true;
            this.btnNewUser.UseSelectable = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 542);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.spltPersons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmUsers";
            this.Text = "Manage User Accounts";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.spltPersons.Panel1.ResumeLayout(false);
            this.spltPersons.Panel1.PerformLayout();
            this.spltPersons.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltPersons)).EndInit();
            this.spltPersons.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer spltPersons;
        private MetroFramework.Controls.MetroTile btnSave;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroTextBox txtNIC;
        private MetroFramework.Controls.MetroTextBox txtContact;
        private MetroFramework.Controls.MetroTextBox txtLastName;
        private MetroFramework.Controls.MetroTextBox txtFirstName;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomDataGrid grdUsers;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtUserName;
        private MetroFramework.Controls.MetroCheckBox chkSuspend;
        private MetroFramework.Controls.MetroDateTime dtUserCreation;
        private MetroFramework.Controls.MetroTile btnDelete;
        private MetroFramework.Controls.MetroCheckBox chkAll;
        private MetroFramework.Controls.MetroComboBox cbxCompany;
        private MetroFramework.Controls.MetroComboBox cbxProjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colACTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContact;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colUserStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private MetroFramework.Controls.MetroTile btnNewUser;

    }
}