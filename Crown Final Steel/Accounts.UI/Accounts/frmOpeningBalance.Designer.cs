namespace Accounts.UI
{
    partial class frmOpeningBalance
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatuMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxEmployees = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblBalanceDate = new MetroFramework.Controls.MetroLabel();
            this.dtOpeningBalance = new MetroFramework.Controls.MetroDateTime();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.DgvOpeningBalance = new Accounts.UI.TabDataGrid();
            this.colIdOpeningBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeadId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOpeningBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatuMessage});
            this.statusStrip1.Location = new System.Drawing.Point(20, 388);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(912, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatuMessage
            // 
            this.lblStatuMessage.Name = "lblStatuMessage";
            this.lblStatuMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbxEmployees);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.lblBalanceDate);
            this.panel1.Controls.Add(this.dtOpeningBalance);
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 45);
            this.panel1.TabIndex = 4;
            // 
            // cbxEmployees
            // 
            this.cbxEmployees.FormattingEnabled = true;
            this.cbxEmployees.ItemHeight = 23;
            this.cbxEmployees.Location = new System.Drawing.Point(444, 8);
            this.cbxEmployees.Name = "cbxEmployees";
            this.cbxEmployees.Size = new System.Drawing.Size(242, 29);
            this.cbxEmployees.TabIndex = 13;
            this.cbxEmployees.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(355, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Employees : ";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // lblBalanceDate
            // 
            this.lblBalanceDate.AutoSize = true;
            this.lblBalanceDate.BackColor = System.Drawing.Color.Transparent;
            this.lblBalanceDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBalanceDate.Location = new System.Drawing.Point(10, 12);
            this.lblBalanceDate.Name = "lblBalanceDate";
            this.lblBalanceDate.Size = new System.Drawing.Size(95, 19);
            this.lblBalanceDate.TabIndex = 4;
            this.lblBalanceDate.Text = "Balance Date :";
            this.lblBalanceDate.UseCustomBackColor = true;
            // 
            // dtOpeningBalance
            // 
            this.dtOpeningBalance.Location = new System.Drawing.Point(110, 7);
            this.dtOpeningBalance.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtOpeningBalance.Name = "dtOpeningBalance";
            this.dtOpeningBalance.Size = new System.Drawing.Size(239, 29);
            this.dtOpeningBalance.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(758, 345);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 31);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(843, 345);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 31);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(672, 345);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 31);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // DgvOpeningBalance
            // 
            this.DgvOpeningBalance.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvOpeningBalance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvOpeningBalance.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvOpeningBalance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvOpeningBalance.ColumnHeadersHeight = 25;
            this.DgvOpeningBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdOpeningBalance,
            this.colHeadId,
            this.colAccount,
            this.colAccountName,
            this.colDiscription,
            this.colAmount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvOpeningBalance.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvOpeningBalance.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvOpeningBalance.EnableHeadersVisualStyles = false;
            this.DgvOpeningBalance.Location = new System.Drawing.Point(0, 116);
            this.DgvOpeningBalance.MultiSelect = false;
            this.DgvOpeningBalance.Name = "DgvOpeningBalance";
            this.DgvOpeningBalance.RowHeadersVisible = false;
            this.DgvOpeningBalance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvOpeningBalance.Size = new System.Drawing.Size(928, 223);
            this.DgvOpeningBalance.TabIndex = 0;
            this.DgvOpeningBalance.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOpeningBalance_CellEnter);
            this.DgvOpeningBalance.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgvOpeningBalance_EditingControlShowing);
            // 
            // colIdOpeningBalance
            // 
            this.colIdOpeningBalance.HeaderText = "IdOpeningBalance";
            this.colIdOpeningBalance.Name = "colIdOpeningBalance";
            this.colIdOpeningBalance.Visible = false;
            // 
            // colHeadId
            // 
            this.colHeadId.HeaderText = "HeadId";
            this.colHeadId.Name = "colHeadId";
            this.colHeadId.Visible = false;
            // 
            // colAccount
            // 
            this.colAccount.DataPropertyName = "AccountNo";
            this.colAccount.HeaderText = "Acc. #";
            this.colAccount.Name = "colAccount";
            this.colAccount.Visible = false;
            // 
            // colAccountName
            // 
            this.colAccountName.HeaderText = "AccountName";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.Width = 300;
            // 
            // colDiscription
            // 
            this.colDiscription.HeaderText = "Narration";
            this.colDiscription.Name = "colDiscription";
            this.colDiscription.Width = 500;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Opening Balance";
            this.colAmount.Name = "colAmount";
            this.colAmount.Width = 120;
            // 
            // frmOpeningBalance
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(952, 430);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DgvOpeningBalance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmOpeningBalance";
            this.Text = "GL Opening Balances";
            this.Load += new System.EventHandler(this.frmOpeningBalance_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmOpeningBalance_KeyPress);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOpeningBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatuMessage;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel lblBalanceDate;
        private MetroFramework.Controls.MetroDateTime dtOpeningBalance;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnSave;
        private TabDataGrid DgvOpeningBalance;
        private MetroFramework.Controls.MetroComboBox cbxEmployees;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdOpeningBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeadId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;

    }
}