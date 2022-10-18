namespace Accounts.UI
{
    partial class frmUsersRoles
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
            this.grdUserRoles = new Accounts.UI.CustomDataGrid();
            this.colIdRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdUserRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoleRight = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdUserRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.Location = new System.Drawing.Point(384, 426);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 41);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Assign Roles";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxUsers
            // 
            this.cbxUsers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxUsers.FormattingEnabled = true;
            this.cbxUsers.ItemHeight = 23;
            this.cbxUsers.Location = new System.Drawing.Point(18, 63);
            this.cbxUsers.Name = "cbxUsers";
            this.cbxUsers.Size = new System.Drawing.Size(233, 29);
            this.cbxUsers.TabIndex = 6;
            this.cbxUsers.UseSelectable = true;
            this.cbxUsers.SelectedIndexChanged += new System.EventHandler(this.cbxUsers_SelectedIndexChanged);
            // 
            // grdUserRoles
            // 
            this.grdUserRoles.AllowUserToAddRows = false;
            this.grdUserRoles.AllowUserToDeleteRows = false;
            this.grdUserRoles.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdUserRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdUserRoles.ColumnHeadersHeight = 28;
            this.grdUserRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdRole,
            this.colIdUserRole,
            this.colRoleName,
            this.colRoleRight});
            this.grdUserRoles.EnableHeadersVisualStyles = false;
            this.grdUserRoles.Location = new System.Drawing.Point(16, 98);
            this.grdUserRoles.Name = "grdUserRoles";
            this.grdUserRoles.RowHeadersVisible = false;
            this.grdUserRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUserRoles.Size = new System.Drawing.Size(511, 325);
            this.grdUserRoles.TabIndex = 5;
            this.grdUserRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUserRoles_CellClick);
            // 
            // colIdRole
            // 
            this.colIdRole.HeaderText = "RoleId";
            this.colIdRole.Name = "colIdRole";
            this.colIdRole.Visible = false;
            // 
            // colIdUserRole
            // 
            this.colIdUserRole.HeaderText = "UserRoleId";
            this.colIdUserRole.Name = "colIdUserRole";
            this.colIdUserRole.Visible = false;
            // 
            // colRoleName
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRoleName.DefaultCellStyle = dataGridViewCellStyle2;
            this.colRoleName.HeaderText = "Role Name";
            this.colRoleName.Name = "colRoleName";
            this.colRoleName.ReadOnly = true;
            this.colRoleName.Width = 400;
            // 
            // colRoleRight
            // 
            this.colRoleRight.HeaderText = "Assign";
            this.colRoleRight.Name = "colRoleRight";
            // 
            // frmUsersRoles
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(536, 490);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxUsers);
            this.Controls.Add(this.grdUserRoles);
            this.Name = "frmUsersRoles";
            this.Text = "Roles Assignment";
            this.Load += new System.EventHandler(this.frmUsersRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUserRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnSave;
        private MetroFramework.Controls.MetroComboBox cbxUsers;
        private CustomDataGrid grdUserRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdUserRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoleName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colRoleRight;
    }
}