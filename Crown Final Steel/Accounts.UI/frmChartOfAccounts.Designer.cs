namespace Accounts.UI
{
    partial class frmChartOfAccounts
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxHeaders = new System.Windows.Forms.ComboBox();
            this.cbxSubCategory = new System.Windows.Forms.ComboBox();
            this.pnlChartOfAccounts = new System.Windows.Forms.GroupBox();
            this.txtAccountNo = new Accounts.UI.UserControls.EditBox();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlPersons = new System.Windows.Forms.Panel();
            this.lblNTN = new System.Windows.Forms.Label();
            this.txtNTN = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.Clear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.txtPackingSize = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblPackingSize = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.AccountsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AccountError = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlChartOfAccounts.SuspendLayout();
            this.pnlPersons.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlItems.SuspendLayout();
            this.AccountsFlowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(6, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sub. Category :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CbxHeaders
            // 
            this.CbxHeaders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxHeaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxHeaders.FormattingEnabled = true;
            this.CbxHeaders.Location = new System.Drawing.Point(112, 75);
            this.CbxHeaders.Name = "CbxHeaders";
            this.CbxHeaders.Size = new System.Drawing.Size(189, 21);
            this.CbxHeaders.TabIndex = 2;
            this.CbxHeaders.SelectedIndexChanged += new System.EventHandler(this.CbxHeaders_SelectedIndexChanged);
            // 
            // cbxSubCategory
            // 
            this.cbxSubCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSubCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSubCategory.FormattingEnabled = true;
            this.cbxSubCategory.Location = new System.Drawing.Point(112, 99);
            this.cbxSubCategory.Name = "cbxSubCategory";
            this.cbxSubCategory.Size = new System.Drawing.Size(224, 21);
            this.cbxSubCategory.TabIndex = 3;
            this.cbxSubCategory.SelectedIndexChanged += new System.EventHandler(this.cbxSubCategory_SelectedIndexChanged);
            // 
            // pnlChartOfAccounts
            // 
            this.pnlChartOfAccounts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlChartOfAccounts.Controls.Add(this.txtAccountNo);
            this.pnlChartOfAccounts.Controls.Add(this.lblAccountNo);
            this.pnlChartOfAccounts.Controls.Add(this.txtAccountName);
            this.pnlChartOfAccounts.Controls.Add(this.label3);
            this.pnlChartOfAccounts.Controls.Add(this.cbxSubCategory);
            this.pnlChartOfAccounts.Controls.Add(this.label1);
            this.pnlChartOfAccounts.Controls.Add(this.CbxHeaders);
            this.pnlChartOfAccounts.Controls.Add(this.label2);
            this.pnlChartOfAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlChartOfAccounts.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlChartOfAccounts.ForeColor = System.Drawing.Color.Black;
            this.pnlChartOfAccounts.Location = new System.Drawing.Point(3, 3);
            this.pnlChartOfAccounts.Name = "pnlChartOfAccounts";
            this.pnlChartOfAccounts.Size = new System.Drawing.Size(556, 125);
            this.pnlChartOfAccounts.TabIndex = 0;
            this.pnlChartOfAccounts.TabStop = false;
            this.pnlChartOfAccounts.Text = "Chart Of Accounts";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.BackColor = System.Drawing.SystemColors.Info;
            this.txtAccountNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNo.Location = new System.Drawing.Point(112, 19);
            this.txtAccountNo.Multiline = false;
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(182, 26);
            this.txtAccountNo.TabIndex = 0;
            this.txtAccountNo.Text = "";
            this.txtAccountNo.ClickButton += new System.EventHandler(this.txtAccountNo_ClickButton);
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNo.ForeColor = System.Drawing.Color.Blue;
            this.lblAccountNo.Location = new System.Drawing.Point(7, 21);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(79, 17);
            this.lblAccountNo.TabIndex = 4;
            this.lblAccountNo.Text = "AccountNo :";
            // 
            // txtAccountName
            // 
            this.txtAccountName.BackColor = System.Drawing.SystemColors.Info;
            this.txtAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountName.Location = new System.Drawing.Point(112, 48);
            this.txtAccountName.Multiline = true;
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(280, 26);
            this.txtAccountName.TabIndex = 1;
            this.txtAccountName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account Name :";
            // 
            // pnlPersons
            // 
            this.pnlPersons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPersons.Controls.Add(this.lblNTN);
            this.pnlPersons.Controls.Add(this.txtNTN);
            this.pnlPersons.Controls.Add(this.txtAddress);
            this.pnlPersons.Controls.Add(this.txtContact);
            this.pnlPersons.Controls.Add(this.txtPersonName);
            this.pnlPersons.Controls.Add(this.lblAddress);
            this.pnlPersons.Controls.Add(this.lblContact);
            this.pnlPersons.Controls.Add(this.lblCustomerName);
            this.pnlPersons.Location = new System.Drawing.Point(3, 134);
            this.pnlPersons.Name = "pnlPersons";
            this.pnlPersons.Padding = new System.Windows.Forms.Padding(3);
            this.pnlPersons.Size = new System.Drawing.Size(556, 128);
            this.pnlPersons.TabIndex = 4;
            // 
            // lblNTN
            // 
            this.lblNTN.AutoSize = true;
            this.lblNTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNTN.ForeColor = System.Drawing.Color.Blue;
            this.lblNTN.Location = new System.Drawing.Point(4, 55);
            this.lblNTN.Name = "lblNTN";
            this.lblNTN.Size = new System.Drawing.Size(48, 17);
            this.lblNTN.TabIndex = 28;
            this.lblNTN.Text = "N.T.N :";
            // 
            // txtNTN
            // 
            this.txtNTN.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNTN.Location = new System.Drawing.Point(112, 54);
            this.txtNTN.Name = "txtNTN";
            this.txtNTN.Size = new System.Drawing.Size(300, 20);
            this.txtNTN.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAddress.Location = new System.Drawing.Point(112, 79);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(429, 41);
            this.txtAddress.TabIndex = 4;
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtContact.Location = new System.Drawing.Point(112, 30);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(300, 20);
            this.txtContact.TabIndex = 2;
            // 
            // txtPersonName
            // 
            this.txtPersonName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPersonName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPersonName.Location = new System.Drawing.Point(112, 7);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(300, 20);
            this.txtPersonName.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Blue;
            this.lblAddress.Location = new System.Drawing.Point(4, 89);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(63, 17);
            this.lblAddress.TabIndex = 26;
            this.lblAddress.Text = "Address :";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.Blue;
            this.lblContact.Location = new System.Drawing.Point(4, 28);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(63, 17);
            this.lblContact.TabIndex = 24;
            this.lblContact.Text = "Contact : ";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.Blue;
            this.lblCustomerName.Location = new System.Drawing.Point(4, 6);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(50, 17);
            this.lblCustomerName.TabIndex = 22;
            this.lblCustomerName.Text = "Name :";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.Clear);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnClose);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(3, 464);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(556, 29);
            this.pnlButtons.TabIndex = 5;
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Clear.BackColor = System.Drawing.Color.AliceBlue;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Location = new System.Drawing.Point(151, 3);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Cl&ear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.AliceBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(77, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "De&lete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.BackColor = System.Drawing.Color.AliceBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(225, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "C&lose";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "S&ave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlItems
            // 
            this.pnlItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlItems.Controls.Add(this.label4);
            this.pnlItems.Controls.Add(this.txtItemDescription);
            this.pnlItems.Controls.Add(this.txtPackingSize);
            this.pnlItems.Controls.Add(this.txtItemName);
            this.pnlItems.Controls.Add(this.lblPackingSize);
            this.pnlItems.Controls.Add(this.lblItemName);
            this.pnlItems.Location = new System.Drawing.Point(3, 268);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(556, 190);
            this.pnlItems.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Description :";
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Location = new System.Drawing.Point(112, 64);
            this.txtItemDescription.Multiline = true;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(402, 50);
            this.txtItemDescription.TabIndex = 1;
            // 
            // txtPackingSize
            // 
            this.txtPackingSize.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPackingSize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPackingSize.Location = new System.Drawing.Point(112, 39);
            this.txtPackingSize.Name = "txtPackingSize";
            this.txtPackingSize.Size = new System.Drawing.Size(128, 20);
            this.txtPackingSize.TabIndex = 0;
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtItemName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtItemName.Location = new System.Drawing.Point(112, 15);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(300, 20);
            this.txtItemName.TabIndex = 0;
            // 
            // lblPackingSize
            // 
            this.lblPackingSize.AutoSize = true;
            this.lblPackingSize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackingSize.ForeColor = System.Drawing.Color.Blue;
            this.lblPackingSize.Location = new System.Drawing.Point(4, 40);
            this.lblPackingSize.Name = "lblPackingSize";
            this.lblPackingSize.Size = new System.Drawing.Size(62, 17);
            this.lblPackingSize.TabIndex = 24;
            this.lblPackingSize.Text = "Size(Kg) :";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.Blue;
            this.lblItemName.Location = new System.Drawing.Point(4, 15);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(75, 17);
            this.lblItemName.TabIndex = 24;
            this.lblItemName.Text = "ItemName :";
            // 
            // AccountsFlowPanel
            // 
            this.AccountsFlowPanel.AutoSize = true;
            this.AccountsFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AccountsFlowPanel.Controls.Add(this.pnlChartOfAccounts);
            this.AccountsFlowPanel.Controls.Add(this.pnlPersons);
            this.AccountsFlowPanel.Controls.Add(this.pnlItems);
            this.AccountsFlowPanel.Controls.Add(this.pnlButtons);
            this.AccountsFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountsFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.AccountsFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.AccountsFlowPanel.Name = "AccountsFlowPanel";
            this.AccountsFlowPanel.Size = new System.Drawing.Size(556, 496);
            this.AccountsFlowPanel.TabIndex = 6;
            // 
            // AccountError
            // 
            this.AccountError.ContainerControl = this;
            // 
            // frmChartOfAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(556, 496);
            this.Controls.Add(this.AccountsFlowPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChartOfAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "r";
            this.Load += new System.EventHandler(this.frmChartOfAccounts_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmChartOfAccounts_KeyPress);
            this.pnlChartOfAccounts.ResumeLayout(false);
            this.pnlChartOfAccounts.PerformLayout();
            this.pnlPersons.ResumeLayout(false);
            this.pnlPersons.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlItems.ResumeLayout(false);
            this.pnlItems.PerformLayout();
            this.AccountsFlowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxHeaders;
        private System.Windows.Forms.ComboBox cbxSubCategory;
        private System.Windows.Forms.GroupBox pnlChartOfAccounts;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.Panel pnlPersons;
        private System.Windows.Forms.Label lblNTN;
        private System.Windows.Forms.TextBox txtNTN;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlItems;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.FlowLayoutPanel AccountsFlowPanel;
        private UserControls.EditBox txtAccountNo;
        private System.Windows.Forms.ErrorProvider AccountError;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtPackingSize;
        private System.Windows.Forms.Label lblPackingSize;
    }
}