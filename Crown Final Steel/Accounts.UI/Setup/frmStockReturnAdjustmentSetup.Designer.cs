namespace Accounts.UI
{
    partial class frmStockReturnAdjustmentSetup
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chkMeasure = new System.Windows.Forms.CheckBox();
            this.txtAdjustmentTypes = new System.Windows.Forms.TextBox();
            this.grdStockAdjustments = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ColIdAdjustment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMeasureable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStockAdjustments)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.24549F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.75451F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkMeasure, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtAdjustmentTypes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.grdStockAdjustments, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.552083F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.895833F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.291667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.78125F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(554, 390);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.3722F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.16878F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.18987F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDelete, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(93, 32);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(458, 32);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 26);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Adjustment";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(137, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 26);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chkMeasure
            // 
            this.chkMeasure.AutoSize = true;
            this.chkMeasure.Location = new System.Drawing.Point(93, 70);
            this.chkMeasure.Name = "chkMeasure";
            this.chkMeasure.Size = new System.Drawing.Size(88, 17);
            this.chkMeasure.TabIndex = 2;
            this.chkMeasure.Text = "MeasureAble";
            this.chkMeasure.UseVisualStyleBackColor = true;
            // 
            // txtAdjustmentTypes
            // 
            this.txtAdjustmentTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAdjustmentTypes.Location = new System.Drawing.Point(93, 3);
            this.txtAdjustmentTypes.Name = "txtAdjustmentTypes";
            this.txtAdjustmentTypes.Size = new System.Drawing.Size(458, 20);
            this.txtAdjustmentTypes.TabIndex = 3;
            // 
            // grdStockAdjustments
            // 
            this.grdStockAdjustments.AllowUserToAddRows = false;
            this.grdStockAdjustments.AllowUserToDeleteRows = false;
            this.grdStockAdjustments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdStockAdjustments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdStockAdjustments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdAdjustment,
            this.colDescription,
            this.colMeasureable,
            this.colEdit});
            this.grdStockAdjustments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdStockAdjustments.EnableHeadersVisualStyles = false;
            this.grdStockAdjustments.Location = new System.Drawing.Point(93, 98);
            this.grdStockAdjustments.Name = "grdStockAdjustments";
            this.grdStockAdjustments.ReadOnly = true;
            this.grdStockAdjustments.RowHeadersVisible = false;
            this.grdStockAdjustments.Size = new System.Drawing.Size(458, 289);
            this.grdStockAdjustments.TabIndex = 4;
            this.grdStockAdjustments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStockAdjustments_CellClick);
            this.grdStockAdjustments.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdStockAdjustments_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Adjustment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColIdAdjustment
            // 
            this.ColIdAdjustment.DataPropertyName = "IdStockAdjustmentType";
            this.ColIdAdjustment.HeaderText = "IdAdjustment";
            this.ColIdAdjustment.Name = "ColIdAdjustment";
            this.ColIdAdjustment.ReadOnly = true;
            this.ColIdAdjustment.Visible = false;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "StockAdjustmentName";
            this.colDescription.FillWeight = 71.6381F;
            this.colDescription.HeaderText = "Discription";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // colMeasureable
            // 
            this.colMeasureable.DataPropertyName = "IsMeasureAble";
            this.colMeasureable.FillWeight = 76.0776F;
            this.colMeasureable.HeaderText = "MeasureAble";
            this.colMeasureable.Name = "colMeasureable";
            this.colMeasureable.ReadOnly = true;
            this.colMeasureable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMeasureable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colEdit
            // 
            this.colEdit.FillWeight = 152.2842F;
            this.colEdit.HeaderText = "Edit";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            // 
            // frmStockReturnAdjustmentSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 470);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmStockReturnAdjustmentSetup";
            this.Text = "Stock Return Adjustments";
            this.Load += new System.EventHandler(this.frmStockReturnAdjustmentSetup_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdStockAdjustments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox chkMeasure;
        private System.Windows.Forms.TextBox txtAdjustmentTypes;
        private System.Windows.Forms.DataGridView grdStockAdjustments;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdAdjustment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colMeasureable;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
    }
}