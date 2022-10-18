namespace Accounts.UI
{
    partial class frmAllProductsInOutWithAvg
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtEnd = new MetroFramework.Controls.MetroDateTime();
            this.dtStart = new MetroFramework.Controls.MetroDateTime();
            this.btnExport = new MetroFramework.Controls.MetroButton();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.chkExcludeDate = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtFilter = new MetroFramework.Controls.MetroTextBox();
            this.lblFilter = new MetroFramework.Controls.MetroLabel();
            this.grdAllProducts = new Accounts.UI.CustomDataGrid();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurchaseQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurchaseAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleAVERAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAllProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.dtEnd);
            this.groupBox1.Controls.Add(this.dtStart);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.chkExcludeDate);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(23, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 60);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Stock";
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(329, 23);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(242, 29);
            this.dtEnd.TabIndex = 5;
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(63, 24);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(222, 29);
            this.dtStart.TabIndex = 5;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(753, 27);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseSelectable = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(675, 27);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // chkExcludeDate
            // 
            this.chkExcludeDate.AutoSize = true;
            this.chkExcludeDate.Checked = true;
            this.chkExcludeDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExcludeDate.Location = new System.Drawing.Point(581, 31);
            this.chkExcludeDate.Name = "chkExcludeDate";
            this.chkExcludeDate.Size = new System.Drawing.Size(90, 15);
            this.chkExcludeDate.TabIndex = 3;
            this.chkExcludeDate.Text = "Exclude Date";
            this.chkExcludeDate.UseCustomBackColor = true;
            this.chkExcludeDate.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(290, 28);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(31, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "To :";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(8, 27);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "From :";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.metroPanel1.Controls.Add(this.txtFilter);
            this.metroPanel1.Controls.Add(this.lblFilter);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 117);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(834, 45);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtFilter
            // 
            // 
            // 
            // 
            this.txtFilter.CustomButton.Image = null;
            this.txtFilter.CustomButton.Location = new System.Drawing.Point(741, 1);
            this.txtFilter.CustomButton.Name = "";
            this.txtFilter.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFilter.CustomButton.TabIndex = 1;
            this.txtFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFilter.CustomButton.UseSelectable = true;
            this.txtFilter.CustomButton.Visible = false;
            this.txtFilter.Lines = new string[0];
            this.txtFilter.Location = new System.Drawing.Point(65, 12);
            this.txtFilter.MaxLength = 32767;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PasswordChar = '\0';
            this.txtFilter.PromptText = "Type Product Name To Filter From Below Grid";
            this.txtFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilter.SelectedText = "";
            this.txtFilter.SelectionLength = 0;
            this.txtFilter.SelectionStart = 0;
            this.txtFilter.ShortcutsEnabled = true;
            this.txtFilter.Size = new System.Drawing.Size(763, 23);
            this.txtFilter.TabIndex = 6;
            this.txtFilter.UseSelectable = true;
            this.txtFilter.WaterMark = "Type Product Name To Filter From Below Grid";
            this.txtFilter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFilter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblFilter.Location = new System.Drawing.Point(4, 9);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(57, 25);
            this.lblFilter.TabIndex = 5;
            this.lblFilter.Text = "Filter :";
            this.lblFilter.UseCustomBackColor = true;
            // 
            // grdAllProducts
            // 
            this.grdAllProducts.AllowUserToAddRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdAllProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.grdAllProducts.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAllProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grdAllProducts.ColumnHeadersHeight = 25;
            this.grdAllProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemName,
            this.colPurchaseQuantity,
            this.colPurchaseAverage,
            this.colSaleQuantity,
            this.colSaleAVERAGE,
            this.colRemaining});
            this.grdAllProducts.EnableHeadersVisualStyles = false;
            this.grdAllProducts.Location = new System.Drawing.Point(21, 164);
            this.grdAllProducts.MultiSelect = false;
            this.grdAllProducts.Name = "grdAllProducts";
            this.grdAllProducts.RowHeadersVisible = false;
            this.grdAllProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAllProducts.Size = new System.Drawing.Size(836, 434);
            this.grdAllProducts.TabIndex = 5;
            // 
            // colItemName
            // 
            this.colItemName.DataPropertyName = "ItemName";
            this.colItemName.HeaderText = "Product Name";
            this.colItemName.Name = "colItemName";
            this.colItemName.Width = 325;
            // 
            // colPurchaseQuantity
            // 
            this.colPurchaseQuantity.DataPropertyName = "Purchases";
            this.colPurchaseQuantity.HeaderText = "IN";
            this.colPurchaseQuantity.Name = "colPurchaseQuantity";
            // 
            // colPurchaseAverage
            // 
            this.colPurchaseAverage.DataPropertyName = "AVGEvaluationUnitPrice";
            this.colPurchaseAverage.HeaderText = "IN AVG";
            this.colPurchaseAverage.Name = "colPurchaseAverage";
            // 
            // colSaleQuantity
            // 
            this.colSaleQuantity.DataPropertyName = "Sales";
            this.colSaleQuantity.HeaderText = "OUT";
            this.colSaleQuantity.Name = "colSaleQuantity";
            // 
            // colSaleAVERAGE
            // 
            this.colSaleAVERAGE.DataPropertyName = "AVR";
            this.colSaleAVERAGE.HeaderText = "OUT AVG";
            this.colSaleAVERAGE.Name = "colSaleAVERAGE";
            // 
            // colRemaining
            // 
            this.colRemaining.DataPropertyName = "Closing";
            this.colRemaining.HeaderText = "Closing";
            this.colRemaining.Name = "colRemaining";
            this.colRemaining.Width = 90;
            // 
            // frmAllProductsInOutWithAvg
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(868, 622);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.grdAllProducts);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmAllProductsInOutWithAvg";
            this.Text = "All Products IN / OUT With Average";
            this.Load += new System.EventHandler(this.frmAllProductsInOutWithAvg_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAllProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDataGrid grdAllProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroDateTime dtEnd;
        private MetroFramework.Controls.MetroDateTime dtStart;
        private MetroFramework.Controls.MetroButton btnExport;
        private MetroFramework.Controls.MetroButton btnLoad;
        private MetroFramework.Controls.MetroCheckBox chkExcludeDate;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtFilter;
        private MetroFramework.Controls.MetroLabel lblFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchaseQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchaseAverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleAVERAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemaining;
    }
}