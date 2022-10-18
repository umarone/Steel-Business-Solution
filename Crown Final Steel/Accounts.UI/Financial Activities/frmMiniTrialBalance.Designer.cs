namespace Accounts.UI
{
    partial class frmMiniTrialBalance
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
            this.grdMiniTrial = new System.Windows.Forms.DataGridView();
            this.dtStart = new MetroFramework.Controls.MetroDateTime();
            this.dtEnd = new MetroFramework.Controls.MetroDateTime();
            this.chkIncludeDate = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnLoad = new MetroFramework.Controls.MetroTile();
            this.colVoucherType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOpeningDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOpeningCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDifference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdMiniTrial)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMiniTrial
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMiniTrial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdMiniTrial.ColumnHeadersHeight = 25;
            this.grdMiniTrial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVoucherType,
            this.colOpeningDebit,
            this.colDebit,
            this.colOpeningCredit,
            this.colCredit,
            this.colDifference});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdMiniTrial.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdMiniTrial.EnableHeadersVisualStyles = false;
            this.grdMiniTrial.Location = new System.Drawing.Point(11, 127);
            this.grdMiniTrial.Name = "grdMiniTrial";
            this.grdMiniTrial.RowHeadersVisible = false;
            this.grdMiniTrial.Size = new System.Drawing.Size(1006, 314);
            this.grdMiniTrial.TabIndex = 0;
            // 
            // dtStart
            // 
            this.dtStart.Enabled = false;
            this.dtStart.Location = new System.Drawing.Point(169, 83);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(200, 29);
            this.dtStart.TabIndex = 1;
            // 
            // dtEnd
            // 
            this.dtEnd.Enabled = false;
            this.dtEnd.Location = new System.Drawing.Point(407, 83);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(200, 29);
            this.dtEnd.TabIndex = 1;
            // 
            // chkIncludeDate
            // 
            this.chkIncludeDate.AutoSize = true;
            this.chkIncludeDate.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkIncludeDate.Location = new System.Drawing.Point(11, 87);
            this.chkIncludeDate.Name = "chkIncludeDate";
            this.chkIncludeDate.Size = new System.Drawing.Size(109, 19);
            this.chkIncludeDate.TabIndex = 2;
            this.chkIncludeDate.Text = "Include Date :";
            this.chkIncludeDate.UseSelectable = true;
            this.chkIncludeDate.CheckedChanged += new System.EventHandler(this.chkIncludeDate_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(373, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(31, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "To :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(119, 88);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "From :";
            // 
            // btnLoad
            // 
            this.btnLoad.ActiveControl = null;
            this.btnLoad.Location = new System.Drawing.Point(614, 79);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(111, 39);
            this.btnLoad.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // colVoucherType
            // 
            this.colVoucherType.DataPropertyName = "VoucherType";
            this.colVoucherType.HeaderText = "Voucher Type";
            this.colVoucherType.Name = "colVoucherType";
            this.colVoucherType.Width = 250;
            // 
            // colOpeningDebit
            // 
            this.colOpeningDebit.DataPropertyName = "OpeningBalance";
            this.colOpeningDebit.HeaderText = "OpeningDebit";
            this.colOpeningDebit.Name = "colOpeningDebit";
            this.colOpeningDebit.Width = 150;
            // 
            // colDebit
            // 
            this.colDebit.DataPropertyName = "Debit";
            this.colDebit.HeaderText = "Debit";
            this.colDebit.Name = "colDebit";
            this.colDebit.Width = 150;
            // 
            // colOpeningCredit
            // 
            this.colOpeningCredit.DataPropertyName = "Amount";
            this.colOpeningCredit.HeaderText = "Opening Credit";
            this.colOpeningCredit.Name = "colOpeningCredit";
            this.colOpeningCredit.Width = 150;
            // 
            // colCredit
            // 
            this.colCredit.DataPropertyName = "Credit";
            this.colCredit.HeaderText = "Credit";
            this.colCredit.Name = "colCredit";
            this.colCredit.Width = 150;
            // 
            // colDifference
            // 
            this.colDifference.DataPropertyName = "ClosingBalance";
            this.colDifference.HeaderText = "Difference";
            this.colDifference.Name = "colDifference";
            this.colDifference.Width = 150;
            // 
            // frmMiniTrialBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 464);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.chkIncludeDate);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.grdMiniTrial);
            this.Name = "frmMiniTrialBalance";
            this.Text = "Mini Trial Balance";
            this.Load += new System.EventHandler(this.frmMiniTrialBalance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMiniTrial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdMiniTrial;
        private MetroFramework.Controls.MetroDateTime dtStart;
        private MetroFramework.Controls.MetroDateTime dtEnd;
        private MetroFramework.Controls.MetroCheckBox chkIncludeDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile btnLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOpeningDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOpeningCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDifference;
    }
}