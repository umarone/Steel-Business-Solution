namespace Accounts.UI
{
    partial class frmtext
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VDate = new MetroFramework.Controls.MetroDateTime();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.InvEditBox = new MetroFramework.Controls.MetroTextBox();
            this.txtOutWardGatePass = new MetroFramework.Controls.MetroTextBox();
            this.txtGatePass = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.chkPosted = new System.Windows.Forms.CheckBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtSaleMemoNo = new MetroFramework.Controls.MetroTextBox();
            this.lblInvoiceNo = new MetroFramework.Controls.MetroLabel();
            this.lblDiscription = new MetroFramework.Controls.MetroLabel();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.lblVoucherNo = new MetroFramework.Controls.MetroLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBox2 = new Accounts.UI.UserControls.EditBox();
            this.editBox1 = new Accounts.UI.UserControls.EditBox();
            this.button2 = new Accounts.UI.MenuButton();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.VDate);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.InvEditBox);
            this.groupBox1.Controls.Add(this.txtOutWardGatePass);
            this.groupBox1.Controls.Add(this.txtGatePass);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.chkPosted);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.txtSaleMemoNo);
            this.groupBox1.Controls.Add(this.lblInvoiceNo);
            this.groupBox1.Controls.Add(this.lblDiscription);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblVoucherNo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1169, 102);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice Information";
            // 
            // VDate
            // 
            this.VDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VDate.Location = new System.Drawing.Point(319, 28);
            this.VDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.VDate.Name = "VDate";
            this.VDate.Size = new System.Drawing.Size(164, 29);
            this.VDate.TabIndex = 24;
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(785, 1);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(341, 63);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(815, 31);
            this.txtDescription.TabIndex = 24;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // InvEditBox
            // 
            // 
            // 
            // 
            this.InvEditBox.CustomButton.Image = null;
            this.InvEditBox.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.InvEditBox.CustomButton.Name = "";
            this.InvEditBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.InvEditBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InvEditBox.CustomButton.TabIndex = 1;
            this.InvEditBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InvEditBox.CustomButton.UseSelectable = true;
            this.InvEditBox.Lines = new string[0];
            this.InvEditBox.Location = new System.Drawing.Point(94, 27);
            this.InvEditBox.MaxLength = 32767;
            this.InvEditBox.Name = "InvEditBox";
            this.InvEditBox.PasswordChar = '\0';
            this.InvEditBox.PromptText = "Voucher No Here";
            this.InvEditBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InvEditBox.SelectedText = "";
            this.InvEditBox.SelectionLength = 0;
            this.InvEditBox.SelectionStart = 0;
            this.InvEditBox.ShortcutsEnabled = true;
            this.InvEditBox.ShowButton = true;
            this.InvEditBox.Size = new System.Drawing.Size(164, 23);
            this.InvEditBox.Style = MetroFramework.MetroColorStyle.Green;
            this.InvEditBox.TabIndex = 24;
            this.InvEditBox.UseSelectable = true;
            this.InvEditBox.WaterMark = "Voucher No Here";
            this.InvEditBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InvEditBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtOutWardGatePass
            // 
            // 
            // 
            // 
            this.txtOutWardGatePass.CustomButton.Image = null;
            this.txtOutWardGatePass.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtOutWardGatePass.CustomButton.Name = "";
            this.txtOutWardGatePass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOutWardGatePass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOutWardGatePass.CustomButton.TabIndex = 1;
            this.txtOutWardGatePass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOutWardGatePass.CustomButton.UseSelectable = true;
            this.txtOutWardGatePass.CustomButton.Visible = false;
            this.txtOutWardGatePass.Lines = new string[0];
            this.txtOutWardGatePass.Location = new System.Drawing.Point(745, 31);
            this.txtOutWardGatePass.MaxLength = 32767;
            this.txtOutWardGatePass.Name = "txtOutWardGatePass";
            this.txtOutWardGatePass.PasswordChar = '\0';
            this.txtOutWardGatePass.PromptText = "OutWard Gate Pass";
            this.txtOutWardGatePass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOutWardGatePass.SelectedText = "";
            this.txtOutWardGatePass.SelectionLength = 0;
            this.txtOutWardGatePass.SelectionStart = 0;
            this.txtOutWardGatePass.ShortcutsEnabled = true;
            this.txtOutWardGatePass.Size = new System.Drawing.Size(170, 23);
            this.txtOutWardGatePass.TabIndex = 24;
            this.txtOutWardGatePass.UseSelectable = true;
            this.txtOutWardGatePass.WaterMark = "OutWard Gate Pass";
            this.txtOutWardGatePass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOutWardGatePass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtGatePass
            // 
            // 
            // 
            // 
            this.txtGatePass.CustomButton.Image = null;
            this.txtGatePass.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtGatePass.CustomButton.Name = "";
            this.txtGatePass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGatePass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGatePass.CustomButton.TabIndex = 1;
            this.txtGatePass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGatePass.CustomButton.UseSelectable = true;
            this.txtGatePass.CustomButton.Visible = false;
            this.txtGatePass.Lines = new string[0];
            this.txtGatePass.Location = new System.Drawing.Point(525, 31);
            this.txtGatePass.MaxLength = 32767;
            this.txtGatePass.Name = "txtGatePass";
            this.txtGatePass.PasswordChar = '\0';
            this.txtGatePass.PromptText = "Inward Gate Pass";
            this.txtGatePass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGatePass.SelectedText = "";
            this.txtGatePass.SelectionLength = 0;
            this.txtGatePass.SelectionStart = 0;
            this.txtGatePass.ShortcutsEnabled = true;
            this.txtGatePass.Size = new System.Drawing.Size(170, 23);
            this.txtGatePass.TabIndex = 24;
            this.txtGatePass.UseSelectable = true;
            this.txtGatePass.WaterMark = "Inward Gate Pass";
            this.txtGatePass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGatePass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(699, 31);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(44, 19);
            this.metroLabel9.TabIndex = 24;
            this.metroLabel9.Text = "OGP :";
            // 
            // chkPosted
            // 
            this.chkPosted.AutoSize = true;
            this.chkPosted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPosted.ForeColor = System.Drawing.Color.Red;
            this.chkPosted.Location = new System.Drawing.Point(921, 31);
            this.chkPosted.Name = "chkPosted";
            this.chkPosted.Size = new System.Drawing.Size(76, 25);
            this.chkPosted.TabIndex = 15;
            this.chkPosted.Text = "Posted";
            this.chkPosted.UseVisualStyleBackColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(489, 32);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(36, 19);
            this.metroLabel8.TabIndex = 24;
            this.metroLabel8.Text = "IGP :";
            // 
            // txtSaleMemoNo
            // 
            // 
            // 
            // 
            this.txtSaleMemoNo.CustomButton.Image = null;
            this.txtSaleMemoNo.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.txtSaleMemoNo.CustomButton.Name = "";
            this.txtSaleMemoNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSaleMemoNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSaleMemoNo.CustomButton.TabIndex = 1;
            this.txtSaleMemoNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSaleMemoNo.CustomButton.UseSelectable = true;
            this.txtSaleMemoNo.CustomButton.Visible = false;
            this.txtSaleMemoNo.Lines = new string[0];
            this.txtSaleMemoNo.Location = new System.Drawing.Point(94, 60);
            this.txtSaleMemoNo.MaxLength = 32767;
            this.txtSaleMemoNo.Name = "txtSaleMemoNo";
            this.txtSaleMemoNo.PasswordChar = '\0';
            this.txtSaleMemoNo.PromptText = "Invoice No";
            this.txtSaleMemoNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSaleMemoNo.SelectedText = "";
            this.txtSaleMemoNo.SelectionLength = 0;
            this.txtSaleMemoNo.SelectionStart = 0;
            this.txtSaleMemoNo.ShortcutsEnabled = true;
            this.txtSaleMemoNo.Size = new System.Drawing.Size(164, 23);
            this.txtSaleMemoNo.TabIndex = 0;
            this.txtSaleMemoNo.UseSelectable = true;
            this.txtSaleMemoNo.WaterMark = "Invoice No";
            this.txtSaleMemoNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSaleMemoNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Location = new System.Drawing.Point(9, 60);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(78, 19);
            this.lblInvoiceNo.TabIndex = 24;
            this.lblInvoiceNo.Text = "Invoice No :";
            // 
            // lblDiscription
            // 
            this.lblDiscription.AutoSize = true;
            this.lblDiscription.Location = new System.Drawing.Point(263, 62);
            this.lblDiscription.Name = "lblDiscription";
            this.lblDiscription.Size = new System.Drawing.Size(81, 19);
            this.lblDiscription.TabIndex = 24;
            this.lblDiscription.Text = "Description :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(270, 29);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(43, 19);
            this.lblDate.TabIndex = 24;
            this.lblDate.Text = "Date :";
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.Location = new System.Drawing.Point(9, 26);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(86, 19);
            this.lblVoucherNo.TabIndex = 24;
            this.lblVoucherNo.Text = "Voucher No :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 63);
            this.button1.TabIndex = 5;
            this.button1.Text = "Menu Button";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aOneToolStripMenuItem,
            this.bOneToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(234, 70);
            // 
            // aOneToolStripMenuItem
            // 
            this.aOneToolStripMenuItem.Name = "aOneToolStripMenuItem";
            this.aOneToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aOneToolStripMenuItem.Text = "Printing ";
            this.aOneToolStripMenuItem.Click += new System.EventHandler(this.aOneToolStripMenuItem_Click);
            // 
            // bOneToolStripMenuItem
            // 
            this.bOneToolStripMenuItem.Name = "bOneToolStripMenuItem";
            this.bOneToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.bOneToolStripMenuItem.Text = "Printing Category Wise Report";
            this.bOneToolStripMenuItem.Click += new System.EventHandler(this.bOneToolStripMenuItem_Click);
            // 
            // editBox2
            // 
            this.editBox2.Location = new System.Drawing.Point(207, 156);
            this.editBox2.Name = "editBox2";
            this.editBox2.Size = new System.Drawing.Size(196, 41);
            this.editBox2.TabIndex = 8;
            this.editBox2.Text = "";
            // 
            // editBox1
            // 
            this.editBox1.Location = new System.Drawing.Point(869, 98);
            this.editBox1.Name = "editBox1";
            this.editBox1.Size = new System.Drawing.Size(190, 31);
            this.editBox1.TabIndex = 7;
            this.editBox1.Text = "";
            // 
            // button2
            // 
            this.button2.ContextMenuStrip = this.contextMenuStrip1;
            this.button2.Location = new System.Drawing.Point(554, 203);
            this.button2.Name = "button2";
            this.button2.ShowMenuUnderCursor = true;
            this.button2.Size = new System.Drawing.Size(193, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmtext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackMaxSize = 10;
            this.ClientSize = new System.Drawing.Size(1184, 626);
            this.Controls.Add(this.editBox2);
            this.Controls.Add(this.editBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmtext";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "frmtext";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.frmtext_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroDateTime VDate;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroTextBox InvEditBox;
        private MetroFramework.Controls.MetroTextBox txtOutWardGatePass;
        private MetroFramework.Controls.MetroTextBox txtGatePass;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.CheckBox chkPosted;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtSaleMemoNo;
        private MetroFramework.Controls.MetroLabel lblInvoiceNo;
        private MetroFramework.Controls.MetroLabel lblDiscription;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroLabel lblVoucherNo;
        private System.Windows.Forms.Button button1;
        private UserControls.EditBox editBox1;
        private UserControls.EditBox editBox2;
        private MenuButton button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aOneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOneToolStripMenuItem;




    }
}