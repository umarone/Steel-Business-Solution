namespace Accounts.UI
{
    partial class frmFindVouchers
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.chkAllVouchers = new MetroFramework.Controls.MetroCheckBox();
            this.AcEditBox = new MetroFramework.Controls.MetroTextBox();
            this.dtVouchers = new MetroFramework.Controls.MetroDateTime();
            this.chkVoucherByName = new MetroFramework.Controls.MetroCheckBox();
            this.chkVByDate = new MetroFramework.Controls.MetroCheckBox();
            this.txtVoucherNo = new MetroFramework.Controls.MetroTextBox();
            this.chkByVoucherNo = new MetroFramework.Controls.MetroCheckBox();
            this.DgvVoucher = new Accounts.UI.CustomDataGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtEditedDateTime = new MetroFramework.Controls.MetroDateTime();
            this.chkVByEditDate = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVoucher)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.dtEditedDateTime);
            this.groupBox1.Controls.Add(this.chkVByEditDate);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.chkAllVouchers);
            this.groupBox1.Controls.Add(this.AcEditBox);
            this.groupBox1.Controls.Add(this.dtVouchers);
            this.groupBox1.Controls.Add(this.chkVoucherByName);
            this.groupBox1.Controls.Add(this.chkVByDate);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(3, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1074, 56);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voucher Entries";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(962, 20);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(104, 27);
            this.btnLoad.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // chkAllVouchers
            // 
            this.chkAllVouchers.AutoSize = true;
            this.chkAllVouchers.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkAllVouchers.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkAllVouchers.Location = new System.Drawing.Point(859, 22);
            this.chkAllVouchers.Name = "chkAllVouchers";
            this.chkAllVouchers.Size = new System.Drawing.Size(96, 19);
            this.chkAllVouchers.TabIndex = 2;
            this.chkAllVouchers.Text = "All Vouchers";
            this.chkAllVouchers.UseCustomBackColor = true;
            this.chkAllVouchers.UseSelectable = true;
            this.chkAllVouchers.CheckedChanged += new System.EventHandler(this.chkVoucher_CheckedChanged);
            // 
            // AcEditBox
            // 
            // 
            // 
            // 
            this.AcEditBox.CustomButton.Image = null;
            this.AcEditBox.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.AcEditBox.CustomButton.Name = "";
            this.AcEditBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AcEditBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AcEditBox.CustomButton.TabIndex = 1;
            this.AcEditBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AcEditBox.CustomButton.UseSelectable = true;
            this.AcEditBox.Lines = new string[0];
            this.AcEditBox.Location = new System.Drawing.Point(639, 21);
            this.AcEditBox.MaxLength = 32767;
            this.AcEditBox.Name = "AcEditBox";
            this.AcEditBox.PasswordChar = '\0';
            this.AcEditBox.PromptText = "By Account Name";
            this.AcEditBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AcEditBox.SelectedText = "";
            this.AcEditBox.SelectionLength = 0;
            this.AcEditBox.SelectionStart = 0;
            this.AcEditBox.ShortcutsEnabled = true;
            this.AcEditBox.ShowButton = true;
            this.AcEditBox.Size = new System.Drawing.Size(215, 23);
            this.AcEditBox.Style = MetroFramework.MetroColorStyle.Green;
            this.AcEditBox.TabIndex = 2;
            this.AcEditBox.UseSelectable = true;
            this.AcEditBox.WaterMark = "By Account Name";
            this.AcEditBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AcEditBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.AcEditBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.AcEditBox_ButtonClick);
            this.AcEditBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AcEditBox_KeyPress);
            // 
            // dtVouchers
            // 
            this.dtVouchers.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVouchers.Location = new System.Drawing.Point(132, 21);
            this.dtVouchers.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtVouchers.Name = "dtVouchers";
            this.dtVouchers.Size = new System.Drawing.Size(163, 29);
            this.dtVouchers.TabIndex = 2;
            // 
            // chkVoucherByName
            // 
            this.chkVoucherByName.AutoSize = true;
            this.chkVoucherByName.Location = new System.Drawing.Point(549, 25);
            this.chkVoucherByName.Name = "chkVoucherByName";
            this.chkVoucherByName.Size = new System.Drawing.Size(84, 15);
            this.chkVoucherByName.TabIndex = 2;
            this.chkVoucherByName.Text = "By Account";
            this.chkVoucherByName.UseCustomBackColor = true;
            this.chkVoucherByName.UseSelectable = true;
            this.chkVoucherByName.CheckedChanged += new System.EventHandler(this.chkVoucher_CheckedChanged);
            // 
            // chkVByDate
            // 
            this.chkVByDate.AutoSize = true;
            this.chkVByDate.Location = new System.Drawing.Point(9, 27);
            this.chkVByDate.Name = "chkVByDate";
            this.chkVByDate.Size = new System.Drawing.Size(120, 15);
            this.chkVByDate.TabIndex = 2;
            this.chkVByDate.Text = "By Creation Date : ";
            this.chkVByDate.UseCustomBackColor = true;
            this.chkVByDate.UseSelectable = true;
            this.chkVByDate.CheckedChanged += new System.EventHandler(this.chkVoucher_CheckedChanged);
            // 
            // txtVoucherNo
            // 
            // 
            // 
            // 
            this.txtVoucherNo.CustomButton.Image = null;
            this.txtVoucherNo.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.txtVoucherNo.CustomButton.Name = "";
            this.txtVoucherNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtVoucherNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVoucherNo.CustomButton.TabIndex = 1;
            this.txtVoucherNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVoucherNo.CustomButton.UseSelectable = true;
            this.txtVoucherNo.CustomButton.Visible = false;
            this.txtVoucherNo.Lines = new string[0];
            this.txtVoucherNo.Location = new System.Drawing.Point(457, 17);
            this.txtVoucherNo.MaxLength = 32767;
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.PasswordChar = '\0';
            this.txtVoucherNo.PromptText = "By Voucher No";
            this.txtVoucherNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVoucherNo.SelectedText = "";
            this.txtVoucherNo.SelectionLength = 0;
            this.txtVoucherNo.SelectionStart = 0;
            this.txtVoucherNo.ShortcutsEnabled = true;
            this.txtVoucherNo.Size = new System.Drawing.Size(142, 23);
            this.txtVoucherNo.TabIndex = 2;
            this.txtVoucherNo.UseSelectable = true;
            this.txtVoucherNo.Visible = false;
            this.txtVoucherNo.WaterMark = "By Voucher No";
            this.txtVoucherNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVoucherNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkByVoucherNo
            // 
            this.chkByVoucherNo.AutoSize = true;
            this.chkByVoucherNo.Location = new System.Drawing.Point(368, 17);
            this.chkByVoucherNo.Name = "chkByVoucherNo";
            this.chkByVoucherNo.Size = new System.Drawing.Size(82, 15);
            this.chkByVoucherNo.TabIndex = 2;
            this.chkByVoucherNo.Text = "By Voucher";
            this.chkByVoucherNo.UseCustomBackColor = true;
            this.chkByVoucherNo.UseSelectable = true;
            this.chkByVoucherNo.Visible = false;
            this.chkByVoucherNo.CheckedChanged += new System.EventHandler(this.chkVoucher_CheckedChanged);
            // 
            // DgvVoucher
            // 
            this.DgvVoucher.AllowUserToAddRows = false;
            this.DgvVoucher.AllowUserToDeleteRows = false;
            this.DgvVoucher.AllowUserToOrderColumns = true;
            this.DgvVoucher.AllowUserToResizeColumns = false;
            this.DgvVoucher.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvVoucher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvVoucher.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.DgvVoucher.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvVoucher.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvVoucher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvVoucher.ColumnHeadersHeight = 26;
            this.DgvVoucher.EnableHeadersVisualStyles = false;
            this.DgvVoucher.Location = new System.Drawing.Point(3, 132);
            this.DgvVoucher.Name = "DgvVoucher";
            this.DgvVoucher.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvVoucher.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvVoucher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvVoucher.Size = new System.Drawing.Size(1074, 329);
            this.DgvVoucher.TabIndex = 0;
            this.DgvVoucher.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVoucher_CellDoubleClick);
            this.DgvVoucher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DgvVoucher_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 53);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(1071, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "----------------";
            // 
            // dtEditedDateTime
            // 
            this.dtEditedDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEditedDateTime.Location = new System.Drawing.Point(401, 20);
            this.dtEditedDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEditedDateTime.Name = "dtEditedDateTime";
            this.dtEditedDateTime.Size = new System.Drawing.Size(142, 29);
            this.dtEditedDateTime.TabIndex = 4;
            // 
            // chkVByEditDate
            // 
            this.chkVByEditDate.AutoSize = true;
            this.chkVByEditDate.Location = new System.Drawing.Point(303, 28);
            this.chkVByEditDate.Name = "chkVByEditDate";
            this.chkVByEditDate.Size = new System.Drawing.Size(92, 15);
            this.chkVByEditDate.TabIndex = 5;
            this.chkVByEditDate.Text = "By Edit Date :";
            this.chkVByEditDate.UseCustomBackColor = true;
            this.chkVByEditDate.UseSelectable = true;
            this.chkVByEditDate.CheckedChanged += new System.EventHandler(this.chkVoucher_CheckedChanged);
            // 
            // frmFindVouchers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 484);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvVoucher);
            this.Controls.Add(this.chkByVoucherNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmFindVouchers";
            this.Text = "Search Vouchers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVouchers_FormClosing);
            this.Load += new System.EventHandler(this.frmVouchers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVoucher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDataGrid DgvVoucher;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox AcEditBox;
        private MetroFramework.Controls.MetroTextBox txtVoucherNo;
        private MetroFramework.Controls.MetroDateTime dtVouchers;
        private MetroFramework.Controls.MetroCheckBox chkVoucherByName;
        private MetroFramework.Controls.MetroCheckBox chkByVoucherNo;
        private MetroFramework.Controls.MetroCheckBox chkVByDate;
        private MetroFramework.Controls.MetroButton btnLoad;
        private MetroFramework.Controls.MetroCheckBox chkAllVouchers;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dtEditedDateTime;
        private MetroFramework.Controls.MetroCheckBox chkVByEditDate;
    }
}