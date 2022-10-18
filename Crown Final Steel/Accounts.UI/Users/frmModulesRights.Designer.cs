namespace Accounts.UI
{
    partial class frmModulesRights
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
            this.cbxUsers = new MetroFramework.Controls.MetroComboBox();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.grdModules = new Accounts.UI.CustomDataGrid();
            this.colIdModule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdUserModule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModuleRight = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdModules)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxUsers
            // 
            this.cbxUsers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxUsers.FormattingEnabled = true;
            this.cbxUsers.ItemHeight = 23;
            this.cbxUsers.Location = new System.Drawing.Point(24, 65);
            this.cbxUsers.Name = "cbxUsers";
            this.cbxUsers.Size = new System.Drawing.Size(233, 29);
            this.cbxUsers.TabIndex = 3;
            this.cbxUsers.UseSelectable = true;
            this.cbxUsers.SelectedIndexChanged += new System.EventHandler(this.cbxUsers_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.Location = new System.Drawing.Point(389, 493);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 41);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save User Modules";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grdModules
            // 
            this.grdModules.AllowUserToAddRows = false;
            this.grdModules.AllowUserToDeleteRows = false;
            this.grdModules.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdModules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdModules.ColumnHeadersHeight = 28;
            this.grdModules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdModule,
            this.colIdUserModule,
            this.colModuleName,
            this.colModuleRight});
            this.grdModules.EnableHeadersVisualStyles = false;
            this.grdModules.Location = new System.Drawing.Point(23, 97);
            this.grdModules.Name = "grdModules";
            this.grdModules.RowHeadersVisible = false;
            this.grdModules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdModules.Size = new System.Drawing.Size(519, 390);
            this.grdModules.TabIndex = 2;
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
            this.colModuleName.Width = 380;
            // 
            // colModuleRight
            // 
            this.colModuleRight.HeaderText = "Access";
            this.colModuleRight.Name = "colModuleRight";
            // 
            // frmModulesRights
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(558, 542);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxUsers);
            this.Controls.Add(this.grdModules);
            this.Name = "frmModulesRights";
            this.Resizable = false;
            this.Text = "Modules Access Rights";
            this.Load += new System.EventHandler(this.frmModulesRights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdModules)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDataGrid grdModules;
        private MetroFramework.Controls.MetroComboBox cbxUsers;
        private MetroFramework.Controls.MetroTile btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdModule;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdUserModule;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModuleName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colModuleRight;

    }
}