namespace Accounts.UI
{
    partial class frmInvoicesDateChange
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
            this.cbxSaleType = new MetroFramework.Controls.MetroComboBox();
            this.txtSaleNumber = new MetroFramework.Controls.MetroTextBox();
            this.dtNew = new MetroFramework.Controls.MetroDateTime();
            this.lblSaleDate = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtCurrentDate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxSaleType
            // 
            this.cbxSaleType.FormattingEnabled = true;
            this.cbxSaleType.ItemHeight = 23;
            this.cbxSaleType.Items.AddRange(new object[] {
            "",
            "Net Sales",
            "Credit Sales"});
            this.cbxSaleType.Location = new System.Drawing.Point(102, 87);
            this.cbxSaleType.Name = "cbxSaleType";
            this.cbxSaleType.Size = new System.Drawing.Size(149, 29);
            this.cbxSaleType.TabIndex = 0;
            this.cbxSaleType.UseSelectable = true;
            // 
            // txtSaleNumber
            // 
            // 
            // 
            // 
            this.txtSaleNumber.CustomButton.Image = null;
            this.txtSaleNumber.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.txtSaleNumber.CustomButton.Name = "";
            this.txtSaleNumber.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtSaleNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSaleNumber.CustomButton.TabIndex = 1;
            this.txtSaleNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSaleNumber.CustomButton.UseSelectable = true;
            this.txtSaleNumber.CustomButton.Visible = false;
            this.txtSaleNumber.Lines = new string[0];
            this.txtSaleNumber.Location = new System.Drawing.Point(351, 87);
            this.txtSaleNumber.MaxLength = 32767;
            this.txtSaleNumber.Multiline = true;
            this.txtSaleNumber.Name = "txtSaleNumber";
            this.txtSaleNumber.PasswordChar = '\0';
            this.txtSaleNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSaleNumber.SelectedText = "";
            this.txtSaleNumber.SelectionLength = 0;
            this.txtSaleNumber.SelectionStart = 0;
            this.txtSaleNumber.ShortcutsEnabled = true;
            this.txtSaleNumber.Size = new System.Drawing.Size(151, 29);
            this.txtSaleNumber.TabIndex = 1;
            this.txtSaleNumber.UseSelectable = true;
            this.txtSaleNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSaleNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSaleNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaleNumber_KeyPress);
            // 
            // dtNew
            // 
            this.dtNew.Location = new System.Drawing.Point(111, 144);
            this.dtNew.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtNew.Name = "dtNew";
            this.dtNew.Size = new System.Drawing.Size(200, 29);
            this.dtNew.TabIndex = 2;
            // 
            // lblSaleDate
            // 
            this.lblSaleDate.AutoSize = true;
            this.lblSaleDate.BackColor = System.Drawing.Color.MistyRose;
            this.lblSaleDate.Location = new System.Drawing.Point(25, 90);
            this.lblSaleDate.Name = "lblSaleDate";
            this.lblSaleDate.Size = new System.Drawing.Size(72, 19);
            this.lblSaleDate.TabIndex = 3;
            this.lblSaleDate.Text = "Sale Type :";
            this.lblSaleDate.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.MistyRose;
            this.metroLabel1.Location = new System.Drawing.Point(253, 93);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Sale Number :";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // txtCurrentDate
            // 
            // 
            // 
            // 
            this.txtCurrentDate.CustomButton.Image = null;
            this.txtCurrentDate.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtCurrentDate.CustomButton.Name = "";
            this.txtCurrentDate.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtCurrentDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCurrentDate.CustomButton.TabIndex = 1;
            this.txtCurrentDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCurrentDate.CustomButton.UseSelectable = true;
            this.txtCurrentDate.CustomButton.Visible = false;
            this.txtCurrentDate.Lines = new string[0];
            this.txtCurrentDate.Location = new System.Drawing.Point(632, 87);
            this.txtCurrentDate.MaxLength = 32767;
            this.txtCurrentDate.Multiline = true;
            this.txtCurrentDate.Name = "txtCurrentDate";
            this.txtCurrentDate.PasswordChar = '\0';
            this.txtCurrentDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCurrentDate.SelectedText = "";
            this.txtCurrentDate.SelectionLength = 0;
            this.txtCurrentDate.SelectionStart = 0;
            this.txtCurrentDate.ShortcutsEnabled = true;
            this.txtCurrentDate.Size = new System.Drawing.Size(163, 29);
            this.txtCurrentDate.TabIndex = 1;
            this.txtCurrentDate.UseSelectable = true;
            this.txtCurrentDate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCurrentDate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.MistyRose;
            this.metroLabel2.Location = new System.Drawing.Point(507, 91);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(124, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Current Date Time :";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLabel3.Location = new System.Drawing.Point(31, 147);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(73, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "New Date :";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(323, 145);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 28);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Now";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.MistyRose;
            this.metroPanel1.Controls.Add(this.btnLoad);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(22, 64);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(867, 71);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(778, 23);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 29);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(22, 138);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(867, 46);
            this.metroPanel2.TabIndex = 6;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // frmInvoicesDateChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 212);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblSaleDate);
            this.Controls.Add(this.dtNew);
            this.Controls.Add(this.txtCurrentDate);
            this.Controls.Add(this.txtSaleNumber);
            this.Controls.Add(this.cbxSaleType);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroPanel2);
            this.Name = "frmInvoicesDateChange";
            this.Text = "Change Invoice Date";
            this.Load += new System.EventHandler(this.frmInvoicesDateChange_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbxSaleType;
        private MetroFramework.Controls.MetroTextBox txtSaleNumber;
        private MetroFramework.Controls.MetroDateTime dtNew;
        private MetroFramework.Controls.MetroLabel lblSaleDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCurrentDate;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btnLoad;
    }
}