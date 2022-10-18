namespace Accounts.UI
{
    partial class frmTrialBalance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlPeriod = new System.Windows.Forms.GroupBox();
            this.btnExportTrial = new MetroFramework.Controls.MetroTile();
            this.lblToPeriod = new MetroFramework.Controls.MetroLabel();
            this.btnGetTrial = new MetroFramework.Controls.MetroTile();
            this.chkDate = new MetroFramework.Controls.MetroCheckBox();
            this.lblStartPeriod = new MetroFramework.Controls.MetroLabel();
            this.StartDate = new MetroFramework.Controls.MetroDateTime();
            this.EndDate = new MetroFramework.Controls.MetroDateTime();
            this.DgvTrial = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOpeningBalanceDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOpeningBalanceCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClosingBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPeriod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTrial)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPeriod
            // 
            this.pnlPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlPeriod.Controls.Add(this.btnExportTrial);
            this.pnlPeriod.Controls.Add(this.lblToPeriod);
            this.pnlPeriod.Controls.Add(this.btnGetTrial);
            this.pnlPeriod.Controls.Add(this.chkDate);
            this.pnlPeriod.Controls.Add(this.lblStartPeriod);
            this.pnlPeriod.Controls.Add(this.StartDate);
            this.pnlPeriod.Controls.Add(this.EndDate);
            this.pnlPeriod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPeriod.ForeColor = System.Drawing.Color.Black;
            this.pnlPeriod.Location = new System.Drawing.Point(1, 60);
            this.pnlPeriod.Name = "pnlPeriod";
            this.pnlPeriod.Size = new System.Drawing.Size(980, 62);
            this.pnlPeriod.TabIndex = 6;
            this.pnlPeriod.TabStop = false;
            this.pnlPeriod.Text = "Trial Pane";
            // 
            // btnExportTrial
            // 
            this.btnExportTrial.ActiveControl = null;
            this.btnExportTrial.BackColor = System.Drawing.Color.IndianRed;
            this.btnExportTrial.Location = new System.Drawing.Point(863, 18);
            this.btnExportTrial.Name = "btnExportTrial";
            this.btnExportTrial.Size = new System.Drawing.Size(109, 38);
            this.btnExportTrial.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnExportTrial.TabIndex = 8;
            this.btnExportTrial.Text = "Export Trial";
            this.btnExportTrial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExportTrial.UseCustomBackColor = true;
            this.btnExportTrial.UseSelectable = true;
            this.btnExportTrial.Click += new System.EventHandler(this.btnExportTrial_Click);
            // 
            // lblToPeriod
            // 
            this.lblToPeriod.AutoSize = true;
            this.lblToPeriod.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblToPeriod.Location = new System.Drawing.Point(323, 24);
            this.lblToPeriod.Name = "lblToPeriod";
            this.lblToPeriod.Size = new System.Drawing.Size(74, 19);
            this.lblToPeriod.TabIndex = 8;
            this.lblToPeriod.Text = "To Period :";
            this.lblToPeriod.UseCustomBackColor = true;
            // 
            // btnGetTrial
            // 
            this.btnGetTrial.ActiveControl = null;
            this.btnGetTrial.BackColor = System.Drawing.Color.IndianRed;
            this.btnGetTrial.Location = new System.Drawing.Point(754, 18);
            this.btnGetTrial.Name = "btnGetTrial";
            this.btnGetTrial.Size = new System.Drawing.Size(107, 38);
            this.btnGetTrial.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnGetTrial.TabIndex = 8;
            this.btnGetTrial.Text = "Load";
            this.btnGetTrial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGetTrial.UseCustomBackColor = true;
            this.btnGetTrial.UseSelectable = true;
            this.btnGetTrial.Click += new System.EventHandler(this.btnGetTrial_Click);
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Location = new System.Drawing.Point(630, 27);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(90, 15);
            this.chkDate.TabIndex = 10;
            this.chkDate.Text = "Exclude Date";
            this.chkDate.UseCustomBackColor = true;
            this.chkDate.UseSelectable = true;
            // 
            // lblStartPeriod
            // 
            this.lblStartPeriod.AutoSize = true;
            this.lblStartPeriod.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblStartPeriod.Location = new System.Drawing.Point(6, 25);
            this.lblStartPeriod.Name = "lblStartPeriod";
            this.lblStartPeriod.Size = new System.Drawing.Size(88, 19);
            this.lblStartPeriod.TabIndex = 8;
            this.lblStartPeriod.Text = "Start Period :";
            this.lblStartPeriod.UseCustomBackColor = true;
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(101, 20);
            this.StartDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(216, 29);
            this.StartDate.TabIndex = 8;
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(403, 20);
            this.EndDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(221, 29);
            this.EndDate.TabIndex = 8;
            // 
            // DgvTrial
            // 
            this.DgvTrial.AllowUserToAddRows = false;
            this.DgvTrial.AllowUserToDeleteRows = false;
            this.DgvTrial.AllowUserToResizeColumns = false;
            this.DgvTrial.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Beige;
            this.DgvTrial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.DgvTrial.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTrial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.DgvTrial.ColumnHeadersHeight = 26;
            this.DgvTrial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAccountNo,
            this.colAccountName,
            this.colOpeningBalanceDebit,
            this.colOpeningBalanceCredit,
            this.colDebit,
            this.colCredit,
            this.colClosingBalance});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvTrial.DefaultCellStyle = dataGridViewCellStyle24;
            this.DgvTrial.EnableHeadersVisualStyles = false;
            this.DgvTrial.Location = new System.Drawing.Point(1, 125);
            this.DgvTrial.MultiSelect = false;
            this.DgvTrial.Name = "DgvTrial";
            this.DgvTrial.ReadOnly = true;
            this.DgvTrial.RowHeadersVisible = false;
            this.DgvTrial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgvTrial.Size = new System.Drawing.Size(980, 418);
            this.DgvTrial.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AccountNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Account No.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AccountName";
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewTextBoxColumn2.HeaderText = "Account Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 225;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DebitX";
            this.dataGridViewTextBoxColumn3.HeaderText = "Debit X";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CreditX";
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Red;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewTextBoxColumn4.HeaderText = "Credit X";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Debit";
            this.dataGridViewTextBoxColumn5.HeaderText = "Debit";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Credit";
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Red;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewTextBoxColumn6.HeaderText = "Credit";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ClosingBalance";
            this.dataGridViewTextBoxColumn7.HeaderText = "Closing Balance";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // colAccountNo
            // 
            this.colAccountNo.DataPropertyName = "AccountNo";
            this.colAccountNo.HeaderText = "Account No.";
            this.colAccountNo.Name = "colAccountNo";
            this.colAccountNo.ReadOnly = true;
            this.colAccountNo.Width = 120;
            // 
            // colAccountName
            // 
            this.colAccountName.DataPropertyName = "AccountName";
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAccountName.DefaultCellStyle = dataGridViewCellStyle21;
            this.colAccountName.HeaderText = "Account Name";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.ReadOnly = true;
            this.colAccountName.Width = 225;
            // 
            // colOpeningBalanceDebit
            // 
            this.colOpeningBalanceDebit.DataPropertyName = "DebitX";
            this.colOpeningBalanceDebit.HeaderText = "Debit X";
            this.colOpeningBalanceDebit.Name = "colOpeningBalanceDebit";
            this.colOpeningBalanceDebit.ReadOnly = true;
            this.colOpeningBalanceDebit.Width = 125;
            // 
            // colOpeningBalanceCredit
            // 
            this.colOpeningBalanceCredit.DataPropertyName = "CreditX";
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Red;
            this.colOpeningBalanceCredit.DefaultCellStyle = dataGridViewCellStyle22;
            this.colOpeningBalanceCredit.HeaderText = "Credit X";
            this.colOpeningBalanceCredit.Name = "colOpeningBalanceCredit";
            this.colOpeningBalanceCredit.ReadOnly = true;
            this.colOpeningBalanceCredit.Width = 125;
            // 
            // colDebit
            // 
            this.colDebit.DataPropertyName = "Debit";
            this.colDebit.HeaderText = "Debit";
            this.colDebit.Name = "colDebit";
            this.colDebit.ReadOnly = true;
            this.colDebit.Width = 125;
            // 
            // colCredit
            // 
            this.colCredit.DataPropertyName = "Credit";
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Red;
            this.colCredit.DefaultCellStyle = dataGridViewCellStyle23;
            this.colCredit.HeaderText = "Credit";
            this.colCredit.Name = "colCredit";
            this.colCredit.ReadOnly = true;
            this.colCredit.Width = 125;
            // 
            // colClosingBalance
            // 
            this.colClosingBalance.DataPropertyName = "ClosingBalance";
            this.colClosingBalance.HeaderText = "Closing Balance";
            this.colClosingBalance.Name = "colClosingBalance";
            this.colClosingBalance.ReadOnly = true;
            this.colClosingBalance.Width = 125;
            // 
            // frmTrialBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 566);
            this.Controls.Add(this.DgvTrial);
            this.Controls.Add(this.pnlPeriod);
            this.Name = "frmTrialBalance";
            this.Text = "Trial Balance";
            this.Load += new System.EventHandler(this.frmTrialBalance_Load);
            this.pnlPeriod.ResumeLayout(false);
            this.pnlPeriod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTrial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pnlPeriod;
        private System.Windows.Forms.DataGridView DgvTrial;
        private MetroFramework.Controls.MetroLabel lblToPeriod;
        private MetroFramework.Controls.MetroCheckBox chkDate;
        private MetroFramework.Controls.MetroLabel lblStartPeriod;
        private MetroFramework.Controls.MetroDateTime StartDate;
        private MetroFramework.Controls.MetroDateTime EndDate;
        private MetroFramework.Controls.MetroTile btnExportTrial;
        private MetroFramework.Controls.MetroTile btnGetTrial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOpeningBalanceDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOpeningBalanceCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClosingBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}