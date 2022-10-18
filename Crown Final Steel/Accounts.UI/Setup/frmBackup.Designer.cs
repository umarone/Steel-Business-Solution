namespace Accounts.UI
{
    partial class frmBackup
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
            this.SaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.lblStatusMsg = new System.Windows.Forms.Label();
            this.txtPath = new MetroFramework.Controls.MetroTextBox();
            this.btnPath = new MetroFramework.Controls.MetroTile();
            this.btnBackUp = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // lblStatusMsg
            // 
            this.lblStatusMsg.AutoSize = true;
            this.lblStatusMsg.Location = new System.Drawing.Point(61, 84);
            this.lblStatusMsg.Name = "lblStatusMsg";
            this.lblStatusMsg.Size = new System.Drawing.Size(0, 13);
            this.lblStatusMsg.TabIndex = 3;
            // 
            // txtPath
            // 
            // 
            // 
            // 
            this.txtPath.CustomButton.Image = null;
            this.txtPath.CustomButton.Location = new System.Drawing.Point(406, 2);
            this.txtPath.CustomButton.Name = "";
            this.txtPath.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPath.CustomButton.TabIndex = 1;
            this.txtPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPath.CustomButton.UseSelectable = true;
            this.txtPath.CustomButton.Visible = false;
            this.txtPath.Lines = new string[0];
            this.txtPath.Location = new System.Drawing.Point(20, 73);
            this.txtPath.MaxLength = 32767;
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.PasswordChar = '\0';
            this.txtPath.PromptText = "BackUP Path";
            this.txtPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPath.SelectedText = "";
            this.txtPath.SelectionLength = 0;
            this.txtPath.SelectionStart = 0;
            this.txtPath.ShortcutsEnabled = true;
            this.txtPath.Size = new System.Drawing.Size(434, 30);
            this.txtPath.TabIndex = 4;
            this.txtPath.UseSelectable = true;
            this.txtPath.WaterMark = "BackUP Path";
            this.txtPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnPath
            // 
            this.btnPath.ActiveControl = null;
            this.btnPath.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPath.Location = new System.Drawing.Point(205, 112);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(122, 48);
            this.btnPath.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnPath.TabIndex = 5;
            this.btnPath.Text = "BackUp Path";
            this.btnPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPath.UseCustomBackColor = true;
            this.btnPath.UseSelectable = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnBackUp
            // 
            this.btnBackUp.ActiveControl = null;
            this.btnBackUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBackUp.Location = new System.Drawing.Point(328, 112);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(122, 48);
            this.btnBackUp.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnBackUp.TabIndex = 5;
            this.btnBackUp.Text = "Backup";
            this.btnBackUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBackUp.UseCustomBackColor = true;
            this.btnBackUp.UseSelectable = true;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 208);
            this.Controls.Add(this.btnBackUp);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblStatusMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "frmBackup";
            this.Text = "System Backup";
            this.Load += new System.EventHandler(this.frmBackup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog SaveDialog;
        private System.Windows.Forms.Label lblStatusMsg;
        private MetroFramework.Controls.MetroTextBox txtPath;
        private MetroFramework.Controls.MetroTile btnPath;
        private MetroFramework.Controls.MetroTile btnBackUp;
    }
}