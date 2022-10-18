namespace Accounts.UI
{
    partial class frmProjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjects));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.txtProjectCode = new MetroFramework.Controls.MetroTextBox();
            this.txtProjectName = new MetroFramework.Controls.MetroTextBox();
            this.grdProjects = new MetroFramework.Controls.MetroGrid();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtProjectCity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtProjectLocation = new MetroFramework.Controls.MetroTextBox();
            this.ProjectStartDate = new MetroFramework.Controls.MetroDateTime();
            this.cbxCompanies = new MetroFramework.Controls.MetroComboBox();
            this.lblCompany = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.chkStore = new MetroFramework.Controls.MetroCheckBox();
            this.chkHeadOffice = new MetroFramework.Controls.MetroCheckBox();
            this.lblProjectStartDate = new MetroFramework.Controls.MetroLabel();
            this.colIdProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdProjects)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveControl = null;
            this.btnDelete.Location = new System.Drawing.Point(325, 282);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 35);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.Location = new System.Drawing.Point(211, 283);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 35);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TileImage = ((System.Drawing.Image)(resources.GetObject("btnSave.TileImage")));
            this.btnSave.UseSelectable = true;
            this.btnSave.UseTileImage = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtProjectCode
            // 
            // 
            // 
            // 
            this.txtProjectCode.CustomButton.Image = null;
            this.txtProjectCode.CustomButton.Location = new System.Drawing.Point(227, 1);
            this.txtProjectCode.CustomButton.Name = "";
            this.txtProjectCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProjectCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProjectCode.CustomButton.TabIndex = 1;
            this.txtProjectCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProjectCode.CustomButton.UseSelectable = true;
            this.txtProjectCode.CustomButton.Visible = false;
            this.txtProjectCode.Lines = new string[0];
            this.txtProjectCode.Location = new System.Drawing.Point(211, 89);
            this.txtProjectCode.MaxLength = 32767;
            this.txtProjectCode.Name = "txtProjectCode";
            this.txtProjectCode.PasswordChar = '\0';
            this.txtProjectCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProjectCode.SelectedText = "";
            this.txtProjectCode.SelectionLength = 0;
            this.txtProjectCode.SelectionStart = 0;
            this.txtProjectCode.ShortcutsEnabled = true;
            this.txtProjectCode.Size = new System.Drawing.Size(249, 23);
            this.txtProjectCode.TabIndex = 2;
            this.txtProjectCode.UseSelectable = true;
            this.txtProjectCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProjectCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProjectName
            // 
            // 
            // 
            // 
            this.txtProjectName.CustomButton.Image = null;
            this.txtProjectName.CustomButton.Location = new System.Drawing.Point(227, 1);
            this.txtProjectName.CustomButton.Name = "";
            this.txtProjectName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProjectName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProjectName.CustomButton.TabIndex = 1;
            this.txtProjectName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProjectName.CustomButton.UseSelectable = true;
            this.txtProjectName.CustomButton.Visible = false;
            this.txtProjectName.Lines = new string[0];
            this.txtProjectName.Location = new System.Drawing.Point(211, 63);
            this.txtProjectName.MaxLength = 32767;
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.PasswordChar = '\0';
            this.txtProjectName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProjectName.SelectedText = "";
            this.txtProjectName.SelectionLength = 0;
            this.txtProjectName.SelectionStart = 0;
            this.txtProjectName.ShortcutsEnabled = true;
            this.txtProjectName.Size = new System.Drawing.Size(249, 23);
            this.txtProjectName.TabIndex = 1;
            this.txtProjectName.UseSelectable = true;
            this.txtProjectName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProjectName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // grdProjects
            // 
            this.grdProjects.AllowUserToAddRows = false;
            this.grdProjects.AllowUserToDeleteRows = false;
            this.grdProjects.AllowUserToResizeRows = false;
            this.grdProjects.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdProjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdProjects.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdProjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProject,
            this.colIdCompany,
            this.colProjectCode,
            this.colRegionName,
            this.colProjectName,
            this.colStatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdProjects.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdProjects.EnableHeadersVisualStyles = false;
            this.grdProjects.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdProjects.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdProjects.Location = new System.Drawing.Point(63, 326);
            this.grdProjects.Name = "grdProjects";
            this.grdProjects.ReadOnly = true;
            this.grdProjects.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProjects.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdProjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProjects.Size = new System.Drawing.Size(592, 181);
            this.grdProjects.TabIndex = 9;
            this.grdProjects.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProjects_CellDoubleClick);
            this.grdProjects.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grdProjects_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(135, 89);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Code :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(136, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Name :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(141, 116);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "City :";
            // 
            // txtProjectCity
            // 
            // 
            // 
            // 
            this.txtProjectCity.CustomButton.Image = null;
            this.txtProjectCity.CustomButton.Location = new System.Drawing.Point(227, 1);
            this.txtProjectCity.CustomButton.Name = "";
            this.txtProjectCity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProjectCity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProjectCity.CustomButton.TabIndex = 1;
            this.txtProjectCity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProjectCity.CustomButton.UseSelectable = true;
            this.txtProjectCity.CustomButton.Visible = false;
            this.txtProjectCity.Lines = new string[0];
            this.txtProjectCity.Location = new System.Drawing.Point(211, 115);
            this.txtProjectCity.MaxLength = 32767;
            this.txtProjectCity.Name = "txtProjectCity";
            this.txtProjectCity.PasswordChar = '\0';
            this.txtProjectCity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProjectCity.SelectedText = "";
            this.txtProjectCity.SelectionLength = 0;
            this.txtProjectCity.SelectionStart = 0;
            this.txtProjectCity.ShortcutsEnabled = true;
            this.txtProjectCity.Size = new System.Drawing.Size(249, 23);
            this.txtProjectCity.TabIndex = 3;
            this.txtProjectCity.UseSelectable = true;
            this.txtProjectCity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProjectCity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(130, 143);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Location :";
            // 
            // txtProjectLocation
            // 
            // 
            // 
            // 
            this.txtProjectLocation.CustomButton.Image = null;
            this.txtProjectLocation.CustomButton.Location = new System.Drawing.Point(227, 1);
            this.txtProjectLocation.CustomButton.Name = "";
            this.txtProjectLocation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProjectLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProjectLocation.CustomButton.TabIndex = 1;
            this.txtProjectLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProjectLocation.CustomButton.UseSelectable = true;
            this.txtProjectLocation.CustomButton.Visible = false;
            this.txtProjectLocation.Lines = new string[0];
            this.txtProjectLocation.Location = new System.Drawing.Point(211, 141);
            this.txtProjectLocation.MaxLength = 32767;
            this.txtProjectLocation.Name = "txtProjectLocation";
            this.txtProjectLocation.PasswordChar = '\0';
            this.txtProjectLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProjectLocation.SelectedText = "";
            this.txtProjectLocation.SelectionLength = 0;
            this.txtProjectLocation.SelectionStart = 0;
            this.txtProjectLocation.ShortcutsEnabled = true;
            this.txtProjectLocation.Size = new System.Drawing.Size(249, 23);
            this.txtProjectLocation.TabIndex = 4;
            this.txtProjectLocation.UseSelectable = true;
            this.txtProjectLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProjectLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ProjectStartDate
            // 
            this.ProjectStartDate.Location = new System.Drawing.Point(211, 200);
            this.ProjectStartDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.ProjectStartDate.Name = "ProjectStartDate";
            this.ProjectStartDate.Size = new System.Drawing.Size(249, 29);
            this.ProjectStartDate.TabIndex = 5;
            // 
            // cbxCompanies
            // 
            this.cbxCompanies.FormattingEnabled = true;
            this.cbxCompanies.ItemHeight = 23;
            this.cbxCompanies.Location = new System.Drawing.Point(211, 168);
            this.cbxCompanies.Name = "cbxCompanies";
            this.cbxCompanies.Size = new System.Drawing.Size(249, 29);
            this.cbxCompanies.TabIndex = 0;
            this.cbxCompanies.UseSelectable = true;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(128, 171);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(73, 19);
            this.lblCompany.TabIndex = 5;
            this.lblCompany.Text = "Company :";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.chkStore);
            this.metroPanel1.Controls.Add(this.chkHeadOffice);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(211, 235);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(249, 41);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // chkStore
            // 
            this.chkStore.AutoSize = true;
            this.chkStore.Location = new System.Drawing.Point(23, 15);
            this.chkStore.Name = "chkStore";
            this.chkStore.Size = new System.Drawing.Size(50, 15);
            this.chkStore.TabIndex = 2;
            this.chkStore.Text = "Store";
            this.chkStore.UseSelectable = true;
            // 
            // chkHeadOffice
            // 
            this.chkHeadOffice.AutoSize = true;
            this.chkHeadOffice.Location = new System.Drawing.Point(151, 15);
            this.chkHeadOffice.Name = "chkHeadOffice";
            this.chkHeadOffice.Size = new System.Drawing.Size(86, 15);
            this.chkHeadOffice.TabIndex = 2;
            this.chkHeadOffice.Text = "Head Office";
            this.chkHeadOffice.UseSelectable = true;
            // 
            // lblProjectStartDate
            // 
            this.lblProjectStartDate.AutoSize = true;
            this.lblProjectStartDate.Location = new System.Drawing.Point(119, 203);
            this.lblProjectStartDate.Name = "lblProjectStartDate";
            this.lblProjectStartDate.Size = new System.Drawing.Size(88, 19);
            this.lblProjectStartDate.TabIndex = 4;
            this.lblProjectStartDate.Text = "Project Date :";
            // 
            // colIdProject
            // 
            this.colIdProject.DataPropertyName = "IdProject";
            this.colIdProject.HeaderText = "IdProject";
            this.colIdProject.Name = "colIdProject";
            this.colIdProject.ReadOnly = true;
            this.colIdProject.Visible = false;
            // 
            // colIdCompany
            // 
            this.colIdCompany.DataPropertyName = "IdCompany";
            this.colIdCompany.HeaderText = "IdCompany";
            this.colIdCompany.Name = "colIdCompany";
            this.colIdCompany.ReadOnly = true;
            this.colIdCompany.Visible = false;
            // 
            // colProjectCode
            // 
            this.colProjectCode.DataPropertyName = "ProjectCode";
            this.colProjectCode.HeaderText = "Project Code";
            this.colProjectCode.Name = "colProjectCode";
            this.colProjectCode.ReadOnly = true;
            // 
            // colRegionName
            // 
            this.colRegionName.DataPropertyName = "CompanyName";
            this.colRegionName.HeaderText = "Company Name";
            this.colRegionName.Name = "colRegionName";
            this.colRegionName.ReadOnly = true;
            this.colRegionName.Width = 200;
            // 
            // colProjectName
            // 
            this.colProjectName.DataPropertyName = "ProjectName";
            this.colProjectName.HeaderText = "Project Name";
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.ReadOnly = true;
            this.colProjectName.Width = 200;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "IsActive";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 50;
            // 
            // frmProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 526);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.cbxCompanies);
            this.Controls.Add(this.ProjectStartDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtProjectLocation);
            this.Controls.Add(this.txtProjectCity);
            this.Controls.Add(this.txtProjectCode);
            this.Controls.Add(this.lblProjectStartDate);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.grdProjects);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.metroLabel1);
            this.KeyPreview = true;
            this.Name = "frmProjects";
            this.Text = "Projects Setup";
            this.Load += new System.EventHandler(this.frmProjects_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmProjects_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.grdProjects)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnDelete;
        private MetroFramework.Controls.MetroTile btnSave;
        private MetroFramework.Controls.MetroTextBox txtProjectCode;
        private MetroFramework.Controls.MetroTextBox txtProjectName;
        private MetroFramework.Controls.MetroGrid grdProjects;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtProjectCity;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtProjectLocation;
        private MetroFramework.Controls.MetroDateTime ProjectStartDate;
        private MetroFramework.Controls.MetroComboBox cbxCompanies;
        private MetroFramework.Controls.MetroLabel lblCompany;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroCheckBox chkStore;
        private MetroFramework.Controls.MetroCheckBox chkHeadOffice;
        private MetroFramework.Controls.MetroLabel lblProjectStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colStatus;
    }
}