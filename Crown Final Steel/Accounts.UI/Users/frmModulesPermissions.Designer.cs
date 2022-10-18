namespace Accounts.UI
{
    partial class frmModulesPermissions
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
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.cbxUsers = new MetroFramework.Controls.MetroComboBox();
            this.grdUserModulePermissions = new Accounts.UI.CustomDataGrid();
            this.colIdModulePermission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdModule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdUserModule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSave = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colUpdate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colView = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPost = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPrinting = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdUserModulePermissions)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.Location = new System.Drawing.Point(688, 477);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 41);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Permissions";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxUsers
            // 
            this.cbxUsers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxUsers.FormattingEnabled = true;
            this.cbxUsers.ItemHeight = 23;
            this.cbxUsers.Location = new System.Drawing.Point(26, 69);
            this.cbxUsers.Name = "cbxUsers";
            this.cbxUsers.Size = new System.Drawing.Size(233, 29);
            this.cbxUsers.TabIndex = 6;
            this.cbxUsers.UseSelectable = true;
            this.cbxUsers.SelectedIndexChanged += new System.EventHandler(this.cbxUsers_SelectedIndexChanged);
            // 
            // grdUserModulePermissions
            // 
            this.grdUserModulePermissions.AllowUserToAddRows = false;
            this.grdUserModulePermissions.AllowUserToDeleteRows = false;
            this.grdUserModulePermissions.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdUserModulePermissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdUserModulePermissions.ColumnHeadersHeight = 28;
            this.grdUserModulePermissions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdModulePermission,
            this.colIdModule,
            this.colIdUserModule,
            this.colModuleName,
            this.colSave,
            this.colUpdate,
            this.colDelete,
            this.colView,
            this.colPost,
            this.colPrinting});
            this.grdUserModulePermissions.EnableHeadersVisualStyles = false;
            this.grdUserModulePermissions.Location = new System.Drawing.Point(24, 102);
            this.grdUserModulePermissions.Name = "grdUserModulePermissions";
            this.grdUserModulePermissions.RowHeadersVisible = false;
            this.grdUserModulePermissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUserModulePermissions.Size = new System.Drawing.Size(807, 372);
            this.grdUserModulePermissions.TabIndex = 5;
            // 
            // colIdModulePermission
            // 
            this.colIdModulePermission.HeaderText = "ModulePermissionId";
            this.colIdModulePermission.Name = "colIdModulePermission";
            this.colIdModulePermission.Visible = false;
            // 
            // colIdModule
            // 
            this.colIdModule.HeaderText = "ModuleId";
            this.colIdModule.Name = "colIdModule";
            this.colIdModule.Visible = false;
            // 
            // colIdUserModule
            // 
            this.colIdUserModule.HeaderText = "UserModuleId";
            this.colIdUserModule.Name = "colIdUserModule";
            this.colIdUserModule.Visible = false;
            // 
            // colModuleName
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colModuleName.DefaultCellStyle = dataGridViewCellStyle2;
            this.colModuleName.HeaderText = "Module Name";
            this.colModuleName.Name = "colModuleName";
            this.colModuleName.Width = 200;
            // 
            // colSave
            // 
            this.colSave.HeaderText = "Save";
            this.colSave.Name = "colSave";
            // 
            // colUpdate
            // 
            this.colUpdate.HeaderText = "Update";
            this.colUpdate.Name = "colUpdate";
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "Delete";
            this.colDelete.Name = "colDelete";
            // 
            // colView
            // 
            this.colView.HeaderText = "View";
            this.colView.Name = "colView";
            // 
            // colPost
            // 
            this.colPost.HeaderText = "Posting";
            this.colPost.Name = "colPost";
            // 
            // colPrinting
            // 
            this.colPrinting.HeaderText = "Printing";
            this.colPrinting.Name = "colPrinting";
            // 
            // frmModulesPermissions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(844, 542);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxUsers);
            this.Controls.Add(this.grdUserModulePermissions);
            this.Name = "frmModulesPermissions";
            this.Text = "Modules Permissions";
            this.Load += new System.EventHandler(this.frmModulesPermissions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUserModulePermissions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnSave;
        private MetroFramework.Controls.MetroComboBox cbxUsers;
        private CustomDataGrid grdUserModulePermissions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdModulePermission;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdModule;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdUserModule;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModuleName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colUpdate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colPost;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colPrinting;
    }
}