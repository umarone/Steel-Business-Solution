namespace Accounts.UI
{
    partial class frmAuthentication
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
            this.mbtnExit = new MetroFramework.Controls.MetroTile();
            this.mbtnLogin = new MetroFramework.Controls.MetroTile();
            this.mtxtPassword = new MetroFramework.Controls.MetroTextBox();
            this.mtxtUserName = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // mbtnExit
            // 
            this.mbtnExit.ActiveControl = null;
            this.mbtnExit.Location = new System.Drawing.Point(264, 138);
            this.mbtnExit.Name = "mbtnExit";
            this.mbtnExit.Size = new System.Drawing.Size(87, 41);
            this.mbtnExit.Style = MetroFramework.MetroColorStyle.Silver;
            this.mbtnExit.TabIndex = 8;
            this.mbtnExit.Text = "Cancel";
            this.mbtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mbtnExit.UseSelectable = true;
            this.mbtnExit.Click += new System.EventHandler(this.mbtnExit_Click);
            // 
            // mbtnLogin
            // 
            this.mbtnLogin.ActiveControl = null;
            this.mbtnLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mbtnLogin.Location = new System.Drawing.Point(156, 138);
            this.mbtnLogin.Name = "mbtnLogin";
            this.mbtnLogin.Size = new System.Drawing.Size(107, 41);
            this.mbtnLogin.Style = MetroFramework.MetroColorStyle.Silver;
            this.mbtnLogin.TabIndex = 7;
            this.mbtnLogin.Text = "Authenticate";
            this.mbtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mbtnLogin.UseSelectable = true;
            this.mbtnLogin.Click += new System.EventHandler(this.mbtnLogin_Click);
            // 
            // mtxtPassword
            // 
            // 
            // 
            // 
            this.mtxtPassword.CustomButton.Image = null;
            this.mtxtPassword.CustomButton.Location = new System.Drawing.Point(305, 1);
            this.mtxtPassword.CustomButton.Name = "";
            this.mtxtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPassword.CustomButton.TabIndex = 1;
            this.mtxtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPassword.CustomButton.UseSelectable = true;
            this.mtxtPassword.CustomButton.Visible = false;
            this.mtxtPassword.Lines = new string[0];
            this.mtxtPassword.Location = new System.Drawing.Point(26, 109);
            this.mtxtPassword.MaxLength = 32767;
            this.mtxtPassword.Name = "mtxtPassword";
            this.mtxtPassword.PasswordChar = '●';
            this.mtxtPassword.PromptText = "Password";
            this.mtxtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPassword.SelectedText = "";
            this.mtxtPassword.SelectionLength = 0;
            this.mtxtPassword.SelectionStart = 0;
            this.mtxtPassword.ShortcutsEnabled = true;
            this.mtxtPassword.ShowClearButton = true;
            this.mtxtPassword.Size = new System.Drawing.Size(327, 23);
            this.mtxtPassword.TabIndex = 6;
            this.mtxtPassword.UseSelectable = true;
            this.mtxtPassword.UseSystemPasswordChar = true;
            this.mtxtPassword.WaterMark = "Password";
            this.mtxtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtUserName
            // 
            // 
            // 
            // 
            this.mtxtUserName.CustomButton.Image = null;
            this.mtxtUserName.CustomButton.Location = new System.Drawing.Point(305, 1);
            this.mtxtUserName.CustomButton.Name = "";
            this.mtxtUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtUserName.CustomButton.TabIndex = 1;
            this.mtxtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtUserName.CustomButton.UseSelectable = true;
            this.mtxtUserName.CustomButton.Visible = false;
            this.mtxtUserName.Lines = new string[0];
            this.mtxtUserName.Location = new System.Drawing.Point(26, 70);
            this.mtxtUserName.MaxLength = 32767;
            this.mtxtUserName.Name = "mtxtUserName";
            this.mtxtUserName.PasswordChar = '\0';
            this.mtxtUserName.PromptText = "User Name";
            this.mtxtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtUserName.SelectedText = "";
            this.mtxtUserName.SelectionLength = 0;
            this.mtxtUserName.SelectionStart = 0;
            this.mtxtUserName.ShortcutsEnabled = true;
            this.mtxtUserName.Size = new System.Drawing.Size(327, 23);
            this.mtxtUserName.TabIndex = 5;
            this.mtxtUserName.UseSelectable = true;
            this.mtxtUserName.UseStyleColors = true;
            this.mtxtUserName.WaterMark = "User Name";
            this.mtxtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmAuthentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 224);
            this.Controls.Add(this.mbtnExit);
            this.Controls.Add(this.mbtnLogin);
            this.Controls.Add(this.mtxtPassword);
            this.Controls.Add(this.mtxtUserName);
            this.Name = "frmAuthentication";
            this.Text = "Authentication Required";
            this.Load += new System.EventHandler(this.frmAuthentication_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mbtnExit;
        private MetroFramework.Controls.MetroTile mbtnLogin;
        private MetroFramework.Controls.MetroTextBox mtxtPassword;
        private MetroFramework.Controls.MetroTextBox mtxtUserName;
    }
}