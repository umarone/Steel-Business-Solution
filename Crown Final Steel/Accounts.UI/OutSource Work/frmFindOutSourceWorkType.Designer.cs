namespace Accounts.UI
{
    partial class frmFindOutSourceWorkType
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.chkFilter = new MetroFramework.Controls.MetroCheckBox();
            this.chkAll = new MetroFramework.Controls.MetroCheckBox();
            this.grdFindOutSourceWorkTypes = new Accounts.UI.CustomDataGrid();
            this.colIdCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdFindOutSourceWorkTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(23, 61);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(332, 20);
            this.txtID.TabIndex = 4;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // chkFilter
            // 
            this.chkFilter.AutoSize = true;
            this.chkFilter.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkFilter.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chkFilter.Location = new System.Drawing.Point(360, 61);
            this.chkFilter.Name = "chkFilter";
            this.chkFilter.Size = new System.Drawing.Size(156, 19);
            this.chkFilter.TabIndex = 6;
            this.chkFilter.Text = "Filter Active / Inactive";
            this.chkFilter.UseCustomForeColor = true;
            this.chkFilter.UseSelectable = true;
            this.chkFilter.CheckedChanged += new System.EventHandler(this.chkFilter_CheckedChanged);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chkAll.Location = new System.Drawing.Point(525, 63);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(37, 15);
            this.chkAll.TabIndex = 7;
            this.chkAll.Text = "All";
            this.chkAll.UseCustomForeColor = true;
            this.chkAll.UseSelectable = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // grdFindOutSourceWorkTypes
            // 
            this.grdFindOutSourceWorkTypes.AllowUserToAddRows = false;
            this.grdFindOutSourceWorkTypes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdFindOutSourceWorkTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdFindOutSourceWorkTypes.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFindOutSourceWorkTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdFindOutSourceWorkTypes.ColumnHeadersHeight = 27;
            this.grdFindOutSourceWorkTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdCategory,
            this.colDateTime,
            this.colCategoryCode,
            this.colDiscription,
            this.colStatus});
            this.grdFindOutSourceWorkTypes.EnableHeadersVisualStyles = false;
            this.grdFindOutSourceWorkTypes.Location = new System.Drawing.Point(23, 84);
            this.grdFindOutSourceWorkTypes.MultiSelect = false;
            this.grdFindOutSourceWorkTypes.Name = "grdFindOutSourceWorkTypes";
            this.grdFindOutSourceWorkTypes.ReadOnly = true;
            this.grdFindOutSourceWorkTypes.RowHeadersVisible = false;
            this.grdFindOutSourceWorkTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFindOutSourceWorkTypes.Size = new System.Drawing.Size(581, 411);
            this.grdFindOutSourceWorkTypes.TabIndex = 5;
            this.grdFindOutSourceWorkTypes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFindOutSourceWorkTypes_CellDoubleClick);
            this.grdFindOutSourceWorkTypes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grdFindOutSourceWorkTypes_KeyPress);
            // 
            // colIdCategory
            // 
            this.colIdCategory.DataPropertyName = "IdOutSourceWorkType";
            this.colIdCategory.HeaderText = "IdOutSourceWork";
            this.colIdCategory.Name = "colIdCategory";
            this.colIdCategory.ReadOnly = true;
            this.colIdCategory.Visible = false;
            // 
            // colDateTime
            // 
            this.colDateTime.DataPropertyName = "CreatedDateTime";
            dataGridViewCellStyle3.Format = "d";
            this.colDateTime.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDateTime.HeaderText = "Date";
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.ReadOnly = true;
            this.colDateTime.Width = 70;
            // 
            // colCategoryCode
            // 
            this.colCategoryCode.DataPropertyName = "CategoryCode";
            this.colCategoryCode.HeaderText = "Code";
            this.colCategoryCode.Name = "colCategoryCode";
            this.colCategoryCode.ReadOnly = true;
            this.colCategoryCode.Width = 80;
            // 
            // colDiscription
            // 
            this.colDiscription.DataPropertyName = "OutSourceWorkTypeName";
            this.colDiscription.HeaderText = "Description";
            this.colDiscription.Name = "colDiscription";
            this.colDiscription.ReadOnly = true;
            this.colDiscription.Width = 330;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "IsActive";
            this.colStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colStatus.HeaderText = "Active";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 90;
            // 
            // frmFindOutSourceWorkType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 518);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.chkFilter);
            this.Controls.Add(this.grdFindOutSourceWorkTypes);
            this.Controls.Add(this.txtID);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmFindOutSourceWorkType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find OutSource Work Types";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFindOutSourceWorkType_FormClosing);
            this.Load += new System.EventHandler(this.frmFindOutSourceWorkType_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmFindOutSourceWorkType_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.grdFindOutSourceWorkTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private CustomDataGrid grdFindOutSourceWorkTypes;
        private MetroFramework.Controls.MetroCheckBox chkFilter;
        private MetroFramework.Controls.MetroCheckBox chkAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscription;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colStatus;
    }
}