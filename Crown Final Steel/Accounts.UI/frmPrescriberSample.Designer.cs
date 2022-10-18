namespace Accounts.UI
{
    partial class frmPrescriberSample
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.VEditBox = new Accounts.UI.UserControls.EditBox();
            this.chkPost = new System.Windows.Forms.CheckBox();
            this.lblSampleNo = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.VDate = new System.Windows.Forms.DateTimePicker();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNTN = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtPrescriberName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNTN = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PrescriberEditBox = new Accounts.UI.UserControls.EditBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatuMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.DgvPrescriberSample = new Accounts.UI.TabDataGrid();
            this.ColTransaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSampleDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemPackingSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrescriberSample)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.VEditBox);
            this.groupBox2.Controls.Add(this.chkPost);
            this.groupBox2.Controls.Add(this.lblSampleNo);
            this.groupBox2.Controls.Add(this.lblDate);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.VDate);
            this.groupBox2.Controls.Add(this.lblDescription);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 132);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sample Information";
            // 
            // VEditBox
            // 
            this.VEditBox.BackColor = System.Drawing.SystemColors.Info;
            this.VEditBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VEditBox.Location = new System.Drawing.Point(97, 24);
            this.VEditBox.Name = "VEditBox";
            this.VEditBox.Size = new System.Drawing.Size(118, 31);
            this.VEditBox.TabIndex = 20;
            this.VEditBox.Text = "";
            this.VEditBox.ClickButton += new System.EventHandler(this.VEditBox_ClickButton);
            // 
            // chkPost
            // 
            this.chkPost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPost.ForeColor = System.Drawing.Color.Red;
            this.chkPost.Location = new System.Drawing.Point(236, 58);
            this.chkPost.Name = "chkPost";
            this.chkPost.Size = new System.Drawing.Size(82, 32);
            this.chkPost.TabIndex = 28;
            this.chkPost.Text = "Posted";
            this.chkPost.UseVisualStyleBackColor = true;
            // 
            // lblSampleNo
            // 
            this.lblSampleNo.AutoSize = true;
            this.lblSampleNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSampleNo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSampleNo.Location = new System.Drawing.Point(9, 29);
            this.lblSampleNo.Name = "lblSampleNo";
            this.lblSampleNo.Size = new System.Drawing.Size(80, 17);
            this.lblSampleNo.TabIndex = 21;
            this.lblSampleNo.Text = "Sample No :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDate.Location = new System.Drawing.Point(10, 61);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 22;
            this.lblDate.Text = "Date :";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescription.Location = new System.Drawing.Point(97, 92);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(283, 33);
            this.txtDescription.TabIndex = 23;
            // 
            // VDate
            // 
            this.VDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VDate.Location = new System.Drawing.Point(97, 59);
            this.VDate.Name = "VDate";
            this.VDate.Size = new System.Drawing.Size(116, 29);
            this.VDate.TabIndex = 24;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDescription.Location = new System.Drawing.Point(8, 94);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(81, 17);
            this.lblDescription.TabIndex = 26;
            this.lblDescription.Text = "Description :";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtAddress.Location = new System.Drawing.Point(323, 49);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(179, 74);
            this.txtAddress.TabIndex = 2;
            // 
            // txtNTN
            // 
            this.txtNTN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNTN.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtNTN.Location = new System.Drawing.Point(321, 23);
            this.txtNTN.Name = "txtNTN";
            this.txtNTN.Size = new System.Drawing.Size(181, 22);
            this.txtNTN.TabIndex = 2;
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtContact.Location = new System.Drawing.Point(67, 87);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(181, 22);
            this.txtContact.TabIndex = 2;
            // 
            // txtPrescriberName
            // 
            this.txtPrescriberName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrescriberName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtPrescriberName.Location = new System.Drawing.Point(67, 61);
            this.txtPrescriberName.Name = "txtPrescriberName";
            this.txtPrescriberName.Size = new System.Drawing.Size(181, 22);
            this.txtPrescriberName.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAddress.Location = new System.Drawing.Point(254, 69);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(63, 17);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "Address :";
            // 
            // lblNTN
            // 
            this.lblNTN.AutoSize = true;
            this.lblNTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNTN.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNTN.Location = new System.Drawing.Point(273, 27);
            this.lblNTN.Name = "lblNTN";
            this.lblNTN.Size = new System.Drawing.Size(42, 17);
            this.lblNTN.TabIndex = 16;
            this.lblNTN.Text = "NTN :";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCustomer.Location = new System.Drawing.Point(8, 32);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(36, 17);
            this.lblCustomer.TabIndex = 10;
            this.lblCustomer.Text = "A/C :";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCustomerName.Location = new System.Drawing.Point(6, 60);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(50, 17);
            this.lblCustomerName.TabIndex = 16;
            this.lblCustomerName.Text = "Name :";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblContact.Location = new System.Drawing.Point(6, 88);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(59, 17);
            this.lblContact.TabIndex = 16;
            this.lblContact.Text = "Contact :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PrescriberEditBox);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtNTN);
            this.groupBox1.Controls.Add(this.txtContact);
            this.groupBox1.Controls.Add(this.txtPrescriberName);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblNTN);
            this.groupBox1.Controls.Add(this.lblCustomer);
            this.groupBox1.Controls.Add(this.lblContact);
            this.groupBox1.Controls.Add(this.lblCustomerName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(391, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 130);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor / Prescriber Information";
            // 
            // PrescriberEditBox
            // 
            this.PrescriberEditBox.BackColor = System.Drawing.SystemColors.Info;
            this.PrescriberEditBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrescriberEditBox.Location = new System.Drawing.Point(67, 27);
            this.PrescriberEditBox.Name = "PrescriberEditBox";
            this.PrescriberEditBox.Size = new System.Drawing.Size(179, 29);
            this.PrescriberEditBox.TabIndex = 1;
            this.PrescriberEditBox.Text = "";
            this.PrescriberEditBox.ClickButton += new System.EventHandler(this.PrecriberEditBox_ClickButton);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(317, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 30);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "S&ave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.AliceBlue;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(489, 361);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.AliceBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(403, 361);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 30);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTotalAmount.Location = new System.Drawing.Point(708, 323);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(44, 17);
            this.lblTotalAmount.TabIndex = 24;
            this.lblTotalAmount.Text = "Total :";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Location = new System.Drawing.Point(761, 317);
            this.txtTotalAmount.Multiline = true;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(142, 30);
            this.txtTotalAmount.TabIndex = 23;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatuMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 390);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(908, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatuMessage
            // 
            this.lblStatuMessage.Name = "lblStatuMessage";
            this.lblStatuMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // DgvPrescriberSample
            // 
            this.DgvPrescriberSample.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Beige;
            this.DgvPrescriberSample.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvPrescriberSample.BackgroundColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPrescriberSample.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvPrescriberSample.ColumnHeadersHeight = 25;
            this.DgvPrescriberSample.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTransaction,
            this.colSampleDetailId,
            this.colItem,
            this.colItemName,
            this.colItemPackingSize,
            this.colItemBatchNo,
            this.colUnitPrice,
            this.colQty,
            this.colAmount});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPrescriberSample.DefaultCellStyle = dataGridViewCellStyle9;
            this.DgvPrescriberSample.EnableHeadersVisualStyles = false;
            this.DgvPrescriberSample.Location = new System.Drawing.Point(2, 140);
            this.DgvPrescriberSample.MultiSelect = false;
            this.DgvPrescriberSample.Name = "DgvPrescriberSample";
            this.DgvPrescriberSample.RowHeadersVisible = false;
            this.DgvPrescriberSample.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvPrescriberSample.Size = new System.Drawing.Size(901, 174);
            this.DgvPrescriberSample.TabIndex = 21;
            this.DgvPrescriberSample.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPrescriberSample_CellEndEdit);
            this.DgvPrescriberSample.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvPrescriberSample_KeyDown);
            // 
            // ColTransaction
            // 
            this.ColTransaction.DataPropertyName = "TransactionID";
            this.ColTransaction.HeaderText = "TransactionId";
            this.ColTransaction.Name = "ColTransaction";
            this.ColTransaction.Visible = false;
            this.ColTransaction.Width = 105;
            // 
            // colSampleDetailId
            // 
            this.colSampleDetailId.HeaderText = "SampleDetailId";
            this.colSampleDetailId.Name = "colSampleDetailId";
            this.colSampleDetailId.Visible = false;
            // 
            // colItem
            // 
            this.colItem.DataPropertyName = "AccountNo";
            this.colItem.HeaderText = "Product Code";
            this.colItem.Name = "colItem";
            this.colItem.Width = 104;
            // 
            // colItemName
            // 
            this.colItemName.HeaderText = "Product Name";
            this.colItemName.Name = "colItemName";
            this.colItemName.Width = 250;
            // 
            // colItemPackingSize
            // 
            this.colItemPackingSize.HeaderText = "Packing Sizing";
            this.colItemPackingSize.Name = "colItemPackingSize";
            this.colItemPackingSize.ReadOnly = true;
            // 
            // colItemBatchNo
            // 
            this.colItemBatchNo.HeaderText = "BatchNo";
            this.colItemBatchNo.Name = "colItemBatchNo";
            this.colItemBatchNo.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "Amount";
            this.colUnitPrice.HeaderText = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Width = 105;
            // 
            // colQty
            // 
            this.colQty.DataPropertyName = "Qty";
            this.colQty.HeaderText = "Units";
            this.colQty.Name = "colQty";
            this.colQty.Width = 105;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 104;
            // 
            // frmPrescriberSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(908, 412);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.DgvPrescriberSample);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "frmPrescriberSample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor Sample";
            this.Load += new System.EventHandler(this.frmPrescriberSample_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPrescriberSample_KeyPress);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrescriberSample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private UserControls.EditBox VEditBox;
        private System.Windows.Forms.CheckBox chkPost;
        private System.Windows.Forms.Label lblSampleNo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker VDate;
        private System.Windows.Forms.Label lblDescription;
        private UserControls.EditBox PrescriberEditBox;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNTN;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtPrescriberName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblNTN;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.GroupBox groupBox1;
        private TabDataGrid DgvPrescriberSample;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatuMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSampleDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemPackingSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
    }
}