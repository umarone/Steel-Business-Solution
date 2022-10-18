namespace Accounts.UI
{
    partial class frmFindTradingCo
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
            this.grdFindTradingCo = new Accounts.UI.CustomDataGrid();
            this.txtID = new System.Windows.Forms.TextBox();
            this.chkFilter = new MetroFramework.Controls.MetroCheckBox();
            this.chkAll = new MetroFramework.Controls.MetroCheckBox();
            this.colIdTrading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTradingCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdFindTradingCo)).BeginInit();
            this.SuspendLayout();
            // 
            // grdFindTradingCo
            // 
            this.grdFindTradingCo.AllowUserToAddRows = false;
            this.grdFindTradingCo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdFindTradingCo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdFindTradingCo.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFindTradingCo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdFindTradingCo.ColumnHeadersHeight = 26;
            this.grdFindTradingCo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdTrading,
            this.colDate,
            this.colTradingCode,
            this.colDiscription,
            this.colStatus});
            this.grdFindTradingCo.EnableHeadersVisualStyles = false;
            this.grdFindTradingCo.Location = new System.Drawing.Point(6, 96);
            this.grdFindTradingCo.MultiSelect = false;
            this.grdFindTradingCo.Name = "grdFindTradingCo";
            this.grdFindTradingCo.ReadOnly = true;
            this.grdFindTradingCo.RowHeadersVisible = false;
            this.grdFindTradingCo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFindTradingCo.Size = new System.Drawing.Size(589, 399);
            this.grdFindTradingCo.TabIndex = 7;
            this.grdFindTradingCo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFindTradingCo_CellDoubleClick);
            this.grdFindTradingCo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grdFindTradingCo_KeyPress);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(6, 70);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(382, 20);
            this.txtID.TabIndex = 6;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // chkFilter
            // 
            this.chkFilter.AutoSize = true;
            this.chkFilter.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkFilter.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chkFilter.Location = new System.Drawing.Point(394, 70);
            this.chkFilter.Name = "chkFilter";
            this.chkFilter.Size = new System.Drawing.Size(156, 19);
            this.chkFilter.TabIndex = 8;
            this.chkFilter.Text = "Filter Active / Inactive";
            this.chkFilter.UseCustomForeColor = true;
            this.chkFilter.UseSelectable = true;
            this.chkFilter.CheckedChanged += new System.EventHandler(this.chkFilter_CheckedChanged);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chkAll.Location = new System.Drawing.Point(556, 74);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(37, 15);
            this.chkAll.TabIndex = 9;
            this.chkAll.Text = "All";
            this.chkAll.UseCustomForeColor = true;
            this.chkAll.UseSelectable = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // colIdTrading
            // 
            this.colIdTrading.DataPropertyName = "IdTrading";
            this.colIdTrading.HeaderText = "IdTradingCo";
            this.colIdTrading.Name = "colIdTrading";
            this.colIdTrading.ReadOnly = true;
            this.colIdTrading.Visible = false;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "CreatedDateTime";
            dataGridViewCellStyle3.Format = "d";
            this.colDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 80;
            // 
            // colTradingCode
            // 
            this.colTradingCode.DataPropertyName = "TradingCode";
            this.colTradingCode.HeaderText = "Code";
            this.colTradingCode.Name = "colTradingCode";
            this.colTradingCode.ReadOnly = true;
            this.colTradingCode.Width = 80;
            // 
            // colDiscription
            // 
            this.colDiscription.DataPropertyName = "TradingName";
            this.colDiscription.HeaderText = "Discription";
            this.colDiscription.Name = "colDiscription";
            this.colDiscription.ReadOnly = true;
            this.colDiscription.Width = 330;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "IsActive";
            this.colStatus.HeaderText = "Active";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 90;
            // 
            // frmFindTradingCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 518);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.chkFilter);
            this.Controls.Add(this.grdFindTradingCo);
            this.Controls.Add(this.txtID);
            this.Name = "frmFindTradingCo";
            this.Text = "Find Tradings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFindTradingCo_FormClosing);
            this.Load += new System.EventHandler(this.frmFindTradingCo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdFindTradingCo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDataGrid grdFindTradingCo;
        private System.Windows.Forms.TextBox txtID;
        private MetroFramework.Controls.MetroCheckBox chkFilter;
        private MetroFramework.Controls.MetroCheckBox chkAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdTrading;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTradingCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscription;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colStatus;
    }
}