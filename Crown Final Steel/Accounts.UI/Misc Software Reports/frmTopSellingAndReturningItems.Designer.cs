namespace Accounts.UI
{
    partial class frmTopSellingAndReturningItems
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
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtStart = new MetroFramework.Controls.MetroDateTime();
            this.dtEnd = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtSearchItem = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkReturned = new MetroFramework.Controls.MetroCheckBox();
            this.chkSales = new MetroFramework.Controls.MetroCheckBox();
            this.grdMostSelling = new Accounts.UI.CustomDataGrid();
            this.btnExcelExport = new MetroFramework.Controls.MetroButton();
            this.colIdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoldUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOneTimeMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdMostSelling)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(531, 87);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(64, 23);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(189, 88);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(31, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "To :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "From :";
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(76, 83);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(106, 29);
            this.dtStart.TabIndex = 7;
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(223, 82);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(110, 29);
            this.dtEnd.TabIndex = 8;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 135);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Search :";
            // 
            // txtSearchItem
            // 
            // 
            // 
            // 
            this.txtSearchItem.CustomButton.Image = null;
            this.txtSearchItem.CustomButton.Location = new System.Drawing.Point(531, 1);
            this.txtSearchItem.CustomButton.Name = "";
            this.txtSearchItem.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchItem.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchItem.CustomButton.TabIndex = 1;
            this.txtSearchItem.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchItem.CustomButton.UseSelectable = true;
            this.txtSearchItem.CustomButton.Visible = false;
            this.txtSearchItem.Lines = new string[0];
            this.txtSearchItem.Location = new System.Drawing.Point(76, 135);
            this.txtSearchItem.MaxLength = 32767;
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.PasswordChar = '\0';
            this.txtSearchItem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchItem.SelectedText = "";
            this.txtSearchItem.SelectionLength = 0;
            this.txtSearchItem.SelectionStart = 0;
            this.txtSearchItem.ShortcutsEnabled = true;
            this.txtSearchItem.Size = new System.Drawing.Size(553, 23);
            this.txtSearchItem.TabIndex = 12;
            this.txtSearchItem.UseSelectable = true;
            this.txtSearchItem.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchItem.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchItem.TextChanged += new System.EventHandler(this.txtSearchItem_TextChanged);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(74, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "---------------------";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(73, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(553, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "---------------------";
            // 
            // chkReturned
            // 
            this.chkReturned.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkReturned.Location = new System.Drawing.Point(422, 83);
            this.chkReturned.Name = "chkReturned";
            this.chkReturned.Size = new System.Drawing.Size(108, 29);
            this.chkReturned.TabIndex = 15;
            this.chkReturned.Text = "Top Returned";
            this.chkReturned.UseSelectable = true;
            this.chkReturned.CheckedChanged += new System.EventHandler(this.chkReturned_CheckedChanged);
            // 
            // chkSales
            // 
            this.chkSales.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkSales.Location = new System.Drawing.Point(342, 83);
            this.chkSales.Name = "chkSales";
            this.chkSales.Size = new System.Drawing.Size(84, 27);
            this.chkSales.TabIndex = 14;
            this.chkSales.Text = "Top Sold";
            this.chkSales.UseSelectable = true;
            this.chkSales.CheckedChanged += new System.EventHandler(this.chkSales_CheckedChanged);
            // 
            // grdMostSelling
            // 
            this.grdMostSelling.AllowUserToAddRows = false;
            this.grdMostSelling.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdMostSelling.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdMostSelling.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMostSelling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdMostSelling.ColumnHeadersHeight = 25;
            this.grdMostSelling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdItem,
            this.colItemName,
            this.colSoldUnits,
            this.colOneTimeMax});
            this.grdMostSelling.EnableHeadersVisualStyles = false;
            this.grdMostSelling.Location = new System.Drawing.Point(23, 172);
            this.grdMostSelling.Name = "grdMostSelling";
            this.grdMostSelling.ReadOnly = true;
            this.grdMostSelling.RowHeadersVisible = false;
            this.grdMostSelling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMostSelling.Size = new System.Drawing.Size(646, 439);
            this.grdMostSelling.TabIndex = 3;
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.Location = new System.Drawing.Point(598, 87);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(71, 23);
            this.btnExcelExport.TabIndex = 16;
            this.btnExcelExport.Text = "Excel Export";
            this.btnExcelExport.UseSelectable = true;
            // 
            // colIdItem
            // 
            this.colIdItem.DataPropertyName = "IdItem";
            this.colIdItem.HeaderText = "IdItem";
            this.colIdItem.Name = "colIdItem";
            this.colIdItem.ReadOnly = true;
            this.colIdItem.Visible = false;
            // 
            // colItemName
            // 
            this.colItemName.DataPropertyName = "ItemName";
            this.colItemName.HeaderText = "Product Description";
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;
            this.colItemName.Width = 355;
            // 
            // colSoldUnits
            // 
            this.colSoldUnits.DataPropertyName = "Units";
            this.colSoldUnits.HeaderText = "Sold Units";
            this.colSoldUnits.Name = "colSoldUnits";
            this.colSoldUnits.ReadOnly = true;
            this.colSoldUnits.Width = 130;
            // 
            // colOneTimeMax
            // 
            this.colOneTimeMax.DataPropertyName = "OneTimeUnits";
            this.colOneTimeMax.HeaderText = "One Time Max";
            this.colOneTimeMax.Name = "colOneTimeMax";
            this.colOneTimeMax.ReadOnly = true;
            this.colOneTimeMax.Width = 110;
            // 
            // frmTopSellingAndReturningItems
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(676, 634);
            this.Controls.Add(this.btnExcelExport);
            this.Controls.Add(this.chkReturned);
            this.Controls.Add(this.chkSales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchItem);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.grdMostSelling);
            this.MaximizeBox = false;
            this.Name = "frmTopSellingAndReturningItems";
            this.Text = "Top Most Selling And Returned Items";
            this.Load += new System.EventHandler(this.frmTopSellingAndReturningItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMostSelling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDataGrid grdMostSelling;
        private MetroFramework.Controls.MetroButton btnLoad;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dtStart;
        private MetroFramework.Controls.MetroDateTime dtEnd;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtSearchItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroCheckBox chkReturned;
        private MetroFramework.Controls.MetroCheckBox chkSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoldUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOneTimeMax;
        private MetroFramework.Controls.MetroButton btnExcelExport;

    }
}