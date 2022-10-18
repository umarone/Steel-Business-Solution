namespace Accounts.UI
{
    partial class frmStockItems
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
            this.spltPersons = new System.Windows.Forms.SplitContainer();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.txtDiscription = new MetroFramework.Controls.MetroTextBox();
            this.txtPackingSize = new MetroFramework.Controls.MetroTextBox();
            this.txtItemName = new MetroFramework.Controls.MetroTextBox();
            this.txtItemCode = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchItems = new MetroFramework.Controls.MetroTextBox();
            this.grdItems = new Accounts.UI.CustomDataGrid();
            this.colItemtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colACTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPackingSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.spltPersons)).BeginInit();
            this.spltPersons.Panel1.SuspendLayout();
            this.spltPersons.Panel2.SuspendLayout();
            this.spltPersons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).BeginInit();
            this.SuspendLayout();
            // 
            // spltPersons
            // 
            this.spltPersons.Location = new System.Drawing.Point(7, 60);
            this.spltPersons.Name = "spltPersons";
            // 
            // spltPersons.Panel1
            // 
            this.spltPersons.Panel1.Controls.Add(this.btnSave);
            this.spltPersons.Panel1.Controls.Add(this.txtDiscription);
            this.spltPersons.Panel1.Controls.Add(this.txtPackingSize);
            this.spltPersons.Panel1.Controls.Add(this.txtItemName);
            this.spltPersons.Panel1.Controls.Add(this.txtItemCode);
            // 
            // spltPersons.Panel2
            // 
            this.spltPersons.Panel2.Controls.Add(this.groupBox1);
            this.spltPersons.Size = new System.Drawing.Size(1002, 432);
            this.spltPersons.SplitterDistance = 252;
            this.spltPersons.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.Location = new System.Drawing.Point(16, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(222, 45);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDiscription
            // 
            // 
            // 
            // 
            this.txtDiscription.CustomButton.Image = null;
            this.txtDiscription.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txtDiscription.CustomButton.Name = "";
            this.txtDiscription.CustomButton.Size = new System.Drawing.Size(61, 61);
            this.txtDiscription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiscription.CustomButton.TabIndex = 1;
            this.txtDiscription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiscription.CustomButton.UseSelectable = true;
            this.txtDiscription.CustomButton.Visible = false;
            this.txtDiscription.Lines = new string[0];
            this.txtDiscription.Location = new System.Drawing.Point(16, 140);
            this.txtDiscription.MaxLength = 32767;
            this.txtDiscription.Multiline = true;
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.PasswordChar = '\0';
            this.txtDiscription.PromptText = "Discription";
            this.txtDiscription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiscription.SelectedText = "";
            this.txtDiscription.SelectionLength = 0;
            this.txtDiscription.SelectionStart = 0;
            this.txtDiscription.ShortcutsEnabled = true;
            this.txtDiscription.Size = new System.Drawing.Size(222, 63);
            this.txtDiscription.TabIndex = 3;
            this.txtDiscription.UseSelectable = true;
            this.txtDiscription.WaterMark = "Discription";
            this.txtDiscription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiscription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPackingSize
            // 
            // 
            // 
            // 
            this.txtPackingSize.CustomButton.Image = null;
            this.txtPackingSize.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtPackingSize.CustomButton.Name = "";
            this.txtPackingSize.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPackingSize.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPackingSize.CustomButton.TabIndex = 1;
            this.txtPackingSize.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPackingSize.CustomButton.UseSelectable = true;
            this.txtPackingSize.CustomButton.Visible = false;
            this.txtPackingSize.Lines = new string[0];
            this.txtPackingSize.Location = new System.Drawing.Point(16, 103);
            this.txtPackingSize.MaxLength = 32767;
            this.txtPackingSize.Name = "txtPackingSize";
            this.txtPackingSize.PasswordChar = '\0';
            this.txtPackingSize.PromptText = "Packing Size";
            this.txtPackingSize.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPackingSize.SelectedText = "";
            this.txtPackingSize.SelectionLength = 0;
            this.txtPackingSize.SelectionStart = 0;
            this.txtPackingSize.ShortcutsEnabled = true;
            this.txtPackingSize.Size = new System.Drawing.Size(222, 23);
            this.txtPackingSize.TabIndex = 2;
            this.txtPackingSize.UseSelectable = true;
            this.txtPackingSize.WaterMark = "Packing Size";
            this.txtPackingSize.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPackingSize.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtItemName
            // 
            // 
            // 
            // 
            this.txtItemName.CustomButton.Image = null;
            this.txtItemName.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtItemName.CustomButton.Name = "";
            this.txtItemName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItemName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemName.CustomButton.TabIndex = 1;
            this.txtItemName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemName.CustomButton.UseSelectable = true;
            this.txtItemName.CustomButton.Visible = false;
            this.txtItemName.Lines = new string[0];
            this.txtItemName.Location = new System.Drawing.Point(16, 67);
            this.txtItemName.MaxLength = 32767;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PasswordChar = '\0';
            this.txtItemName.PromptText = "Item Name";
            this.txtItemName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemName.SelectedText = "";
            this.txtItemName.SelectionLength = 0;
            this.txtItemName.SelectionStart = 0;
            this.txtItemName.ShortcutsEnabled = true;
            this.txtItemName.Size = new System.Drawing.Size(222, 23);
            this.txtItemName.TabIndex = 1;
            this.txtItemName.UseSelectable = true;
            this.txtItemName.WaterMark = "Item Name";
            this.txtItemName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtItemCode
            // 
            // 
            // 
            // 
            this.txtItemCode.CustomButton.Image = null;
            this.txtItemCode.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtItemCode.CustomButton.Name = "";
            this.txtItemCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItemCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemCode.CustomButton.TabIndex = 1;
            this.txtItemCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemCode.CustomButton.UseSelectable = true;
            this.txtItemCode.CustomButton.Visible = false;
            this.txtItemCode.Enabled = false;
            this.txtItemCode.Lines = new string[0];
            this.txtItemCode.Location = new System.Drawing.Point(16, 32);
            this.txtItemCode.MaxLength = 32767;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.PasswordChar = '\0';
            this.txtItemCode.PromptText = "Item Code";
            this.txtItemCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemCode.SelectedText = "";
            this.txtItemCode.SelectionLength = 0;
            this.txtItemCode.SelectionStart = 0;
            this.txtItemCode.ShortcutsEnabled = true;
            this.txtItemCode.Size = new System.Drawing.Size(222, 23);
            this.txtItemCode.TabIndex = 0;
            this.txtItemCode.UseSelectable = true;
            this.txtItemCode.WaterMark = "Item Code";
            this.txtItemCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtSearchItems);
            this.groupBox1.Controls.Add(this.grdItems);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 419);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Items";
            // 
            // txtSearchItems
            // 
            // 
            // 
            // 
            this.txtSearchItems.CustomButton.Image = null;
            this.txtSearchItems.CustomButton.Location = new System.Drawing.Point(706, 2);
            this.txtSearchItems.CustomButton.Name = "";
            this.txtSearchItems.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtSearchItems.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchItems.CustomButton.TabIndex = 1;
            this.txtSearchItems.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchItems.CustomButton.UseSelectable = true;
            this.txtSearchItems.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSearchItems.Lines = new string[0];
            this.txtSearchItems.Location = new System.Drawing.Point(8, 23);
            this.txtSearchItems.MaxLength = 32767;
            this.txtSearchItems.Name = "txtSearchItems";
            this.txtSearchItems.PasswordChar = '\0';
            this.txtSearchItems.PromptText = "Type And Search Items Here";
            this.txtSearchItems.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchItems.SelectedText = "";
            this.txtSearchItems.SelectionLength = 0;
            this.txtSearchItems.SelectionStart = 0;
            this.txtSearchItems.ShortcutsEnabled = true;
            this.txtSearchItems.ShowButton = true;
            this.txtSearchItems.Size = new System.Drawing.Size(726, 22);
            this.txtSearchItems.Style = MetroFramework.MetroColorStyle.Green;
            this.txtSearchItems.TabIndex = 0;
            this.txtSearchItems.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchItems.UseSelectable = true;
            this.txtSearchItems.WaterMark = "Type And Search Items Here";
            this.txtSearchItems.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchItems.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchItems.TextChanged += new System.EventHandler(this.txtSearchItems_TextChanged);
            this.txtSearchItems.Enter += new System.EventHandler(this.txtSearchItems_Enter);
            this.txtSearchItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchItems_KeyPress);
            // 
            // grdItems
            // 
            this.grdItems.AllowUserToAddRows = false;
            this.grdItems.AllowUserToDeleteRows = false;
            this.grdItems.BackgroundColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemtId,
            this.colAccountCode,
            this.colACTitle,
            this.colPackingSize,
            this.colDiscription});
            this.grdItems.EnableHeadersVisualStyles = false;
            this.grdItems.Location = new System.Drawing.Point(6, 48);
            this.grdItems.Name = "grdItems";
            this.grdItems.ReadOnly = true;
            this.grdItems.RowHeadersVisible = false;
            this.grdItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdItems.Size = new System.Drawing.Size(728, 365);
            this.grdItems.TabIndex = 1;
            this.grdItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdItems_CellDoubleClick);
            this.grdItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grdItems_KeyPress);
            // 
            // colItemtId
            // 
            this.colItemtId.DataPropertyName = "IdItem";
            this.colItemtId.HeaderText = "ItemId";
            this.colItemtId.Name = "colItemtId";
            this.colItemtId.ReadOnly = true;
            this.colItemtId.Visible = false;
            // 
            // colAccountCode
            // 
            this.colAccountCode.DataPropertyName = "AccountNo";
            this.colAccountCode.HeaderText = "Item Code";
            this.colAccountCode.Name = "colAccountCode";
            this.colAccountCode.ReadOnly = true;
            // 
            // colACTitle
            // 
            this.colACTitle.DataPropertyName = "ItemName";
            this.colACTitle.HeaderText = "Item Name";
            this.colACTitle.Name = "colACTitle";
            this.colACTitle.ReadOnly = true;
            this.colACTitle.Width = 150;
            // 
            // colPackingSize
            // 
            this.colPackingSize.DataPropertyName = "PackingSize";
            this.colPackingSize.HeaderText = "Packing Size";
            this.colPackingSize.Name = "colPackingSize";
            this.colPackingSize.ReadOnly = true;
            this.colPackingSize.Width = 200;
            // 
            // colDiscription
            // 
            this.colDiscription.DataPropertyName = "Discription";
            this.colDiscription.HeaderText = "Discription";
            this.colDiscription.Name = "colDiscription";
            this.colDiscription.ReadOnly = true;
            this.colDiscription.Width = 200;
            // 
            // frmStockItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 502);
            this.Controls.Add(this.spltPersons);
            this.KeyPreview = true;
            this.Name = "frmStockItems";
            this.Text = "Stock Items";
            this.Load += new System.EventHandler(this.frmStockItems_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmStockItems_KeyPress);
            this.spltPersons.Panel1.ResumeLayout(false);
            this.spltPersons.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltPersons)).EndInit();
            this.spltPersons.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spltPersons;
        private MetroFramework.Controls.MetroTile btnSave;
        private MetroFramework.Controls.MetroTextBox txtDiscription;
        private MetroFramework.Controls.MetroTextBox txtPackingSize;
        private MetroFramework.Controls.MetroTextBox txtItemName;
        private MetroFramework.Controls.MetroTextBox txtItemCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtSearchItems;
        private CustomDataGrid grdItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colACTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPackingSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscription;
    }
}