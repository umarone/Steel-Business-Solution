namespace Accounts.UI
{
    partial class frmCompany
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
            this.spltPersons = new System.Windows.Forms.SplitContainer();
            this.txtDiscription = new MetroFramework.Controls.MetroTextBox();
            this.chkSuspend = new MetroFramework.Controls.MetroCheckBox();
            this.CDate = new MetroFramework.Controls.MetroDateTime();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.txtCompanyName = new MetroFramework.Controls.MetroTextBox();
            this.chkAll = new MetroFramework.Controls.MetroCheckBox();
            this.grdCompanies = new Accounts.UI.CustomDataGrid();
            this.colIdCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.chkFilter = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.spltPersons)).BeginInit();
            this.spltPersons.Panel1.SuspendLayout();
            this.spltPersons.Panel2.SuspendLayout();
            this.spltPersons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanies)).BeginInit();
            this.SuspendLayout();
            // 
            // spltPersons
            // 
            this.spltPersons.Location = new System.Drawing.Point(7, 57);
            this.spltPersons.Name = "spltPersons";
            // 
            // spltPersons.Panel1
            // 
            this.spltPersons.Panel1.BackColor = System.Drawing.Color.MistyRose;
            this.spltPersons.Panel1.Controls.Add(this.txtDiscription);
            this.spltPersons.Panel1.Controls.Add(this.chkSuspend);
            this.spltPersons.Panel1.Controls.Add(this.CDate);
            this.spltPersons.Panel1.Controls.Add(this.btnSave);
            this.spltPersons.Panel1.Controls.Add(this.txtCompanyName);
            // 
            // spltPersons.Panel2
            // 
            this.spltPersons.Panel2.Controls.Add(this.chkAll);
            this.spltPersons.Panel2.Controls.Add(this.grdCompanies);
            this.spltPersons.Panel2.Controls.Add(this.chkFilter);
            this.spltPersons.Size = new System.Drawing.Size(1082, 428);
            this.spltPersons.SplitterDistance = 309;
            this.spltPersons.TabIndex = 1;
            // 
            // txtDiscription
            // 
            // 
            // 
            // 
            this.txtDiscription.CustomButton.Image = null;
            this.txtDiscription.CustomButton.Location = new System.Drawing.Point(99, 2);
            this.txtDiscription.CustomButton.Name = "";
            this.txtDiscription.CustomButton.Size = new System.Drawing.Size(119, 119);
            this.txtDiscription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiscription.CustomButton.TabIndex = 1;
            this.txtDiscription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiscription.CustomButton.UseSelectable = true;
            this.txtDiscription.CustomButton.Visible = false;
            this.txtDiscription.Lines = new string[0];
            this.txtDiscription.Location = new System.Drawing.Point(37, 88);
            this.txtDiscription.MaxLength = 32767;
            this.txtDiscription.Multiline = true;
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.PasswordChar = '\0';
            this.txtDiscription.PromptText = "Any Discription Here";
            this.txtDiscription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiscription.SelectedText = "";
            this.txtDiscription.SelectionLength = 0;
            this.txtDiscription.SelectionStart = 0;
            this.txtDiscription.ShortcutsEnabled = true;
            this.txtDiscription.Size = new System.Drawing.Size(221, 124);
            this.txtDiscription.TabIndex = 10;
            this.txtDiscription.UseSelectable = true;
            this.txtDiscription.WaterMark = "Any Discription Here";
            this.txtDiscription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiscription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkSuspend
            // 
            this.chkSuspend.AutoSize = true;
            this.chkSuspend.Location = new System.Drawing.Point(36, 218);
            this.chkSuspend.Name = "chkSuspend";
            this.chkSuspend.Size = new System.Drawing.Size(68, 15);
            this.chkSuspend.TabIndex = 9;
            this.chkSuspend.Text = "Suspend";
            this.chkSuspend.UseCustomBackColor = true;
            this.chkSuspend.UseSelectable = true;
            // 
            // CDate
            // 
            this.CDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CDate.Location = new System.Drawing.Point(36, 53);
            this.CDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.CDate.Name = "CDate";
            this.CDate.Size = new System.Drawing.Size(223, 29);
            this.CDate.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSave.Location = new System.Drawing.Point(36, 242);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(222, 41);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCompanyName
            // 
            // 
            // 
            // 
            this.txtCompanyName.CustomButton.Image = null;
            this.txtCompanyName.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtCompanyName.CustomButton.Name = "";
            this.txtCompanyName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCompanyName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCompanyName.CustomButton.TabIndex = 1;
            this.txtCompanyName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCompanyName.CustomButton.UseSelectable = true;
            this.txtCompanyName.CustomButton.Visible = false;
            this.txtCompanyName.Lines = new string[0];
            this.txtCompanyName.Location = new System.Drawing.Point(37, 25);
            this.txtCompanyName.MaxLength = 32767;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.PasswordChar = '\0';
            this.txtCompanyName.PromptText = "Company Name";
            this.txtCompanyName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCompanyName.SelectedText = "";
            this.txtCompanyName.SelectionLength = 0;
            this.txtCompanyName.SelectionStart = 0;
            this.txtCompanyName.ShortcutsEnabled = true;
            this.txtCompanyName.Size = new System.Drawing.Size(222, 23);
            this.txtCompanyName.TabIndex = 0;
            this.txtCompanyName.UseSelectable = true;
            this.txtCompanyName.WaterMark = "Company Name";
            this.txtCompanyName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCompanyName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chkAll.Location = new System.Drawing.Point(175, 6);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(37, 15);
            this.chkAll.TabIndex = 9;
            this.chkAll.Text = "All";
            this.chkAll.UseCustomForeColor = true;
            this.chkAll.UseSelectable = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // grdCompanies
            // 
            this.grdCompanies.AllowUserToAddRows = false;
            this.grdCompanies.AllowUserToDeleteRows = false;
            this.grdCompanies.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCompanies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdCompanies.ColumnHeadersHeight = 28;
            this.grdCompanies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdCompany,
            this.colCompanyName,
            this.colCreatedBy,
            this.ColCreationDate,
            this.colStatus,
            this.colEdit,
            this.colDelete});
            this.grdCompanies.EnableHeadersVisualStyles = false;
            this.grdCompanies.Location = new System.Drawing.Point(5, 25);
            this.grdCompanies.Name = "grdCompanies";
            this.grdCompanies.ReadOnly = true;
            this.grdCompanies.RowHeadersVisible = false;
            this.grdCompanies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCompanies.Size = new System.Drawing.Size(755, 397);
            this.grdCompanies.TabIndex = 1;
            this.grdCompanies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCompanies_CellClick);
            this.grdCompanies.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdCompanies_CellFormatting);
            // 
            // colIdCompany
            // 
            this.colIdCompany.DataPropertyName = "IdCompany";
            this.colIdCompany.HeaderText = "IdCompany";
            this.colIdCompany.Name = "colIdCompany";
            this.colIdCompany.ReadOnly = true;
            this.colIdCompany.Visible = false;
            // 
            // colCompanyName
            // 
            this.colCompanyName.DataPropertyName = "CompanyName";
            this.colCompanyName.FillWeight = 200F;
            this.colCompanyName.HeaderText = "Company Name";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.ReadOnly = true;
            this.colCompanyName.Width = 300;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.DataPropertyName = "UserName";
            this.colCreatedBy.HeaderText = "Created By";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.ReadOnly = true;
            this.colCreatedBy.Width = 130;
            // 
            // ColCreationDate
            // 
            this.ColCreationDate.DataPropertyName = "CreatedDateTime";
            dataGridViewCellStyle2.Format = "d";
            this.ColCreationDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColCreationDate.FillWeight = 200F;
            this.ColCreationDate.HeaderText = "Creation Date";
            this.ColCreationDate.Name = "ColCreationDate";
            this.ColCreationDate.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "IsActive";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 50;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "Edit";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Width = 80;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "Delete";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Width = 80;
            // 
            // chkFilter
            // 
            this.chkFilter.AutoSize = true;
            this.chkFilter.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkFilter.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chkFilter.Location = new System.Drawing.Point(7, 3);
            this.chkFilter.Name = "chkFilter";
            this.chkFilter.Size = new System.Drawing.Size(156, 19);
            this.chkFilter.TabIndex = 8;
            this.chkFilter.Text = "Filter Active / Inactive";
            this.chkFilter.UseCustomForeColor = true;
            this.chkFilter.UseSelectable = true;
            this.chkFilter.CheckedChanged += new System.EventHandler(this.chkFilter_CheckedChanged);
            // 
            // frmCompany
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1116, 528);
            this.Controls.Add(this.spltPersons);
            this.Name = "frmCompany";
            this.Text = "Company Setup";
            this.Load += new System.EventHandler(this.frmCompany_Load);
            this.spltPersons.Panel1.ResumeLayout(false);
            this.spltPersons.Panel1.PerformLayout();
            this.spltPersons.Panel2.ResumeLayout(false);
            this.spltPersons.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltPersons)).EndInit();
            this.spltPersons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spltPersons;
        private MetroFramework.Controls.MetroDateTime CDate;
        private MetroFramework.Controls.MetroTile btnSave;
        private MetroFramework.Controls.MetroTextBox txtCompanyName;
        private CustomDataGrid grdCompanies;
        private MetroFramework.Controls.MetroCheckBox chkSuspend;
        private MetroFramework.Controls.MetroTextBox txtDiscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCreationDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private MetroFramework.Controls.MetroCheckBox chkAll;
        private MetroFramework.Controls.MetroCheckBox chkFilter;
    }
}