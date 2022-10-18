namespace Accounts.UI
{
    partial class frmExpenses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkExcludeDate = new MetroFramework.Controls.MetroCheckBox();
            this.btnExport = new MetroFramework.Controls.MetroTile();
            this.btnLoadExpense = new MetroFramework.Controls.MetroTile();
            this.lblToDate = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtEnd = new MetroFramework.Controls.MetroDateTime();
            this.dtStart = new MetroFramework.Controls.MetroDateTime();
            this.ExpPanel = new System.Windows.Forms.GroupBox();
            this.lblSearch = new MetroFramework.Controls.MetroLabel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.colVDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtExpenseAmount = new MetroFramework.Controls.MetroTextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.ExpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chkExcludeDate);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnLoadExpense);
            this.panel1.Controls.Add(this.lblToDate);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.dtEnd);
            this.panel1.Controls.Add(this.dtStart);
            this.panel1.Location = new System.Drawing.Point(3, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 52);
            this.panel1.TabIndex = 2;
            // 
            // chkExcludeDate
            // 
            this.chkExcludeDate.AutoSize = true;
            this.chkExcludeDate.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkExcludeDate.Location = new System.Drawing.Point(545, 17);
            this.chkExcludeDate.Name = "chkExcludeDate";
            this.chkExcludeDate.Size = new System.Drawing.Size(95, 19);
            this.chkExcludeDate.TabIndex = 8;
            this.chkExcludeDate.Text = "Exclue Date";
            this.chkExcludeDate.UseCustomBackColor = true;
            this.chkExcludeDate.UseSelectable = true;
            this.chkExcludeDate.CheckedChanged += new System.EventHandler(this.chkExcludeDate_CheckedChanged);
            // 
            // btnExport
            // 
            this.btnExport.ActiveControl = null;
            this.btnExport.BackColor = System.Drawing.Color.IndianRed;
            this.btnExport.Location = new System.Drawing.Point(805, 6);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(109, 39);
            this.btnExport.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExport.UseCustomBackColor = true;
            this.btnExport.UseSelectable = true;
            // 
            // btnLoadExpense
            // 
            this.btnLoadExpense.ActiveControl = null;
            this.btnLoadExpense.BackColor = System.Drawing.Color.IndianRed;
            this.btnLoadExpense.Location = new System.Drawing.Point(694, 6);
            this.btnLoadExpense.Name = "btnLoadExpense";
            this.btnLoadExpense.Size = new System.Drawing.Size(109, 39);
            this.btnLoadExpense.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnLoadExpense.TabIndex = 6;
            this.btnLoadExpense.Text = "Load";
            this.btnLoadExpense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoadExpense.UseCustomBackColor = true;
            this.btnLoadExpense.UseSelectable = true;
            this.btnLoadExpense.Click += new System.EventHandler(this.btnLoadExpense_Click);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(290, 17);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(69, 19);
            this.lblToDate.Style = MetroFramework.MetroColorStyle.Black;
            this.lblToDate.TabIndex = 7;
            this.lblToDate.Text = "End Date :";
            this.lblToDate.UseCustomBackColor = true;
            this.lblToDate.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(19, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Start Date :";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(363, 12);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(166, 29);
            this.dtEnd.TabIndex = 6;
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(99, 12);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(180, 29);
            this.dtStart.TabIndex = 6;
            // 
            // ExpPanel
            // 
            this.ExpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ExpPanel.Controls.Add(this.lblSearch);
            this.ExpPanel.Controls.Add(this.txtSearch);
            this.ExpPanel.Controls.Add(this.dgvExpenses);
            this.ExpPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpPanel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ExpPanel.Location = new System.Drawing.Point(3, 114);
            this.ExpPanel.Name = "ExpPanel";
            this.ExpPanel.Size = new System.Drawing.Size(920, 389);
            this.ExpPanel.TabIndex = 3;
            this.ExpPanel.TabStop = false;
            this.ExpPanel.Text = "Expense Detail";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(8, 23);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(111, 19);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search Accounts :";
            this.lblSearch.UseCustomBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(331, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(119, 23);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(353, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.UseCustomBackColor = true;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.AllowUserToAddRows = false;
            this.dgvExpenses.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            this.dgvExpenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExpenses.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExpenses.ColumnHeadersHeight = 28;
            this.dgvExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVDate,
            this.colAccountName,
            this.colDescription,
            this.colAmount});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpenses.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExpenses.EnableHeadersVisualStyles = false;
            this.dgvExpenses.Location = new System.Drawing.Point(3, 52);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.ReadOnly = true;
            this.dgvExpenses.RowHeadersVisible = false;
            this.dgvExpenses.Size = new System.Drawing.Size(911, 331);
            this.dgvExpenses.TabIndex = 0;
            // 
            // colVDate
            // 
            this.colVDate.DataPropertyName = "VDate";
            dataGridViewCellStyle3.Format = "d";
            this.colVDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colVDate.HeaderText = "VDate";
            this.colVDate.Name = "colVDate";
            this.colVDate.ReadOnly = true;
            this.colVDate.Width = 90;
            // 
            // colAccountName
            // 
            this.colAccountName.DataPropertyName = "AccountName";
            this.colAccountName.HeaderText = "Account Name";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.ReadOnly = true;
            this.colAccountName.Width = 300;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "Discription";
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Width = 400;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Debit";
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // txtExpenseAmount
            // 
            this.txtExpenseAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.txtExpenseAmount.CustomButton.Image = null;
            this.txtExpenseAmount.CustomButton.Location = new System.Drawing.Point(282, 1);
            this.txtExpenseAmount.CustomButton.Name = "";
            this.txtExpenseAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtExpenseAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtExpenseAmount.CustomButton.TabIndex = 1;
            this.txtExpenseAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtExpenseAmount.CustomButton.UseSelectable = true;
            this.txtExpenseAmount.CustomButton.Visible = false;
            this.txtExpenseAmount.Lines = new string[0];
            this.txtExpenseAmount.Location = new System.Drawing.Point(615, 503);
            this.txtExpenseAmount.MaxLength = 32767;
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.PasswordChar = '\0';
            this.txtExpenseAmount.PromptText = "Total Expenses";
            this.txtExpenseAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtExpenseAmount.SelectedText = "";
            this.txtExpenseAmount.SelectionLength = 0;
            this.txtExpenseAmount.SelectionStart = 0;
            this.txtExpenseAmount.ShortcutsEnabled = true;
            this.txtExpenseAmount.Size = new System.Drawing.Size(304, 23);
            this.txtExpenseAmount.TabIndex = 7;
            this.txtExpenseAmount.UseCustomBackColor = true;
            this.txtExpenseAmount.UseSelectable = true;
            this.txtExpenseAmount.WaterMark = "Total Expenses";
            this.txtExpenseAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtExpenseAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle5.Format = "d";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn1.HeaderText = "VDate";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Account Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 400;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // frmExpenses
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(934, 550);
            this.Controls.Add(this.txtExpenseAmount);
            this.Controls.Add(this.ExpPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmExpenses";
            this.Text = "Daily Expense Register";
            this.Load += new System.EventHandler(this.frmExpenses_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmExpenses_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ExpPanel.ResumeLayout(false);
            this.ExpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox ExpPanel;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private MetroFramework.Controls.MetroLabel lblToDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dtEnd;
        private MetroFramework.Controls.MetroDateTime dtStart;
        private MetroFramework.Controls.MetroTile btnLoadExpense;
        private MetroFramework.Controls.MetroTextBox txtExpenseAmount;
        private MetroFramework.Controls.MetroTile btnExport;
        private MetroFramework.Controls.MetroCheckBox chkExcludeDate;
        private MetroFramework.Controls.MetroLabel lblSearch;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
    }
}