namespace Accounts.UI
{
    partial class frmFindAccounts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearchAccounts = new System.Windows.Forms.TextBox();
            this.grdFindAccounts = new Accounts.UI.CustomDataGrid();
            this.colIdAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdParent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdHead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPersonalAccount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdFindAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchAccounts
            // 
            this.txtSearchAccounts.Location = new System.Drawing.Point(4, 60);
            this.txtSearchAccounts.Multiline = true;
            this.txtSearchAccounts.Name = "txtSearchAccounts";
            this.txtSearchAccounts.Size = new System.Drawing.Size(450, 26);
            this.txtSearchAccounts.TabIndex = 0;
            this.txtSearchAccounts.TextChanged += new System.EventHandler(this.txtSearchAccounts_TextChanged);
            this.txtSearchAccounts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchAccounts_KeyDown);
            this.txtSearchAccounts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchAccounts_KeyPress);
            // 
            // grdFindAccounts
            // 
            this.grdFindAccounts.AllowUserToAddRows = false;
            this.grdFindAccounts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdFindAccounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdFindAccounts.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFindAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdFindAccounts.ColumnHeadersHeight = 25;
            this.grdFindAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdAccount,
            this.colIdParent,
            this.colIdHead,
            this.colId,
            this.colName,
            this.colAddress,
            this.colDiscription,
            this.colDescription});
            this.grdFindAccounts.EnableHeadersVisualStyles = false;
            this.grdFindAccounts.Location = new System.Drawing.Point(2, 88);
            this.grdFindAccounts.MultiSelect = false;
            this.grdFindAccounts.Name = "grdFindAccounts";
            this.grdFindAccounts.ReadOnly = true;
            this.grdFindAccounts.RowHeadersVisible = false;
            this.grdFindAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFindAccounts.Size = new System.Drawing.Size(967, 348);
            this.grdFindAccounts.TabIndex = 1;
            this.grdFindAccounts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFindAccount_CellDoubleClick);
            this.grdFindAccounts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grdFindAccount_KeyPress);
            // 
            // colIdAccount
            // 
            this.colIdAccount.DataPropertyName = "IdAccount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colIdAccount.DefaultCellStyle = dataGridViewCellStyle3;
            this.colIdAccount.HeaderText = "IdAccount";
            this.colIdAccount.Name = "colIdAccount";
            this.colIdAccount.ReadOnly = true;
            this.colIdAccount.Visible = false;
            // 
            // colIdParent
            // 
            this.colIdParent.DataPropertyName = "IdParent";
            this.colIdParent.HeaderText = "IdParent";
            this.colIdParent.Name = "colIdParent";
            this.colIdParent.ReadOnly = true;
            this.colIdParent.Visible = false;
            // 
            // colIdHead
            // 
            this.colIdHead.DataPropertyName = "IdHead";
            this.colIdHead.HeaderText = "IdHead";
            this.colIdHead.Name = "colIdHead";
            this.colIdHead.ReadOnly = true;
            this.colIdHead.Visible = false;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "AccountNo";
            this.colId.HeaderText = "A/C Code";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "AccountName";
            this.colName.HeaderText = "A/C Title";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 250;
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "Address";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colAddress.DefaultCellStyle = dataGridViewCellStyle4;
            this.colAddress.HeaderText = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            this.colAddress.Width = 250;
            // 
            // colDiscription
            // 
            this.colDiscription.DataPropertyName = "Discription";
            this.colDiscription.HeaderText = "Discription";
            this.colDiscription.Name = "colDiscription";
            this.colDiscription.ReadOnly = true;
            this.colDiscription.Width = 180;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "AccountType";
            this.colDescription.HeaderText = "Head";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Width = 180;
            // 
            // txtPersonalAccount
            // 
            // 
            // 
            // 
            this.txtPersonalAccount.CustomButton.Image = null;
            this.txtPersonalAccount.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtPersonalAccount.CustomButton.Name = "";
            this.txtPersonalAccount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPersonalAccount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPersonalAccount.CustomButton.TabIndex = 1;
            this.txtPersonalAccount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPersonalAccount.CustomButton.UseSelectable = true;
            this.txtPersonalAccount.CustomButton.Visible = false;
            this.txtPersonalAccount.Lines = new string[0];
            this.txtPersonalAccount.Location = new System.Drawing.Point(640, 62);
            this.txtPersonalAccount.MaxLength = 32767;
            this.txtPersonalAccount.Name = "txtPersonalAccount";
            this.txtPersonalAccount.PasswordChar = '\0';
            this.txtPersonalAccount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPersonalAccount.SelectedText = "";
            this.txtPersonalAccount.SelectionLength = 0;
            this.txtPersonalAccount.SelectionStart = 0;
            this.txtPersonalAccount.ShortcutsEnabled = true;
            this.txtPersonalAccount.Size = new System.Drawing.Size(157, 23);
            this.txtPersonalAccount.TabIndex = 2;
            this.txtPersonalAccount.UseSelectable = true;
            this.txtPersonalAccount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPersonalAccount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPersonalAccount.TextChanged += new System.EventHandler(this.txtPersonalAccount_TextChanged);
            this.txtPersonalAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPersonalAccount_KeyDown);
            this.txtPersonalAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonalAccount_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(463, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(171, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Search By Personal Account";
            // 
            // frmFindAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 456);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtPersonalAccount);
            this.Controls.Add(this.grdFindAccounts);
            this.Controls.Add(this.txtSearchAccounts);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmFindAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find Accounts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAccounts_FormClosing);
            this.Load += new System.EventHandler(this.frmAccounts_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmFindAccounts_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.grdFindAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchAccounts;
        private CustomDataGrid grdFindAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdParent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdHead;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private MetroFramework.Controls.MetroTextBox txtPersonalAccount;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}