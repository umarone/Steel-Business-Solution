namespace Accounts.UI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.mtxtPassword = new MetroFramework.Controls.MetroTextBox();
            this.mbtnLogin = new MetroFramework.Controls.MetroTile();
            this.mbtnExit = new MetroFramework.Controls.MetroTile();
            this.loginPicture = new System.Windows.Forms.PictureBox();
            this.cbxProjects = new MetroFramework.Controls.MetroComboBox();
            this.cbxUsers = new MetroFramework.Controls.MetroComboBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginPicture)).BeginInit();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mtxtPassword
            // 
            // 
            // 
            // 
            this.mtxtPassword.CustomButton.Image = null;
            this.mtxtPassword.CustomButton.Location = new System.Drawing.Point(402, 1);
            this.mtxtPassword.CustomButton.Name = "";
            this.mtxtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPassword.CustomButton.TabIndex = 1;
            this.mtxtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPassword.CustomButton.UseSelectable = true;
            this.mtxtPassword.CustomButton.Visible = false;
            this.mtxtPassword.Lines = new string[0];
            this.mtxtPassword.Location = new System.Drawing.Point(196, 158);
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
            this.mtxtPassword.Size = new System.Drawing.Size(424, 23);
            this.mtxtPassword.TabIndex = 2;
            this.mtxtPassword.UseSelectable = true;
            this.mtxtPassword.UseSystemPasswordChar = true;
            this.mtxtPassword.WaterMark = "Password";
            this.mtxtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtPassword.Click += new System.EventHandler(this.mtxtPassword_Click);
            this.mtxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtPassword_KeyPress);
            // 
            // mbtnLogin
            // 
            this.mbtnLogin.ActiveControl = null;
            this.mbtnLogin.BackColor = System.Drawing.Color.RosyBrown;
            this.mbtnLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mbtnLogin.Location = new System.Drawing.Point(377, 187);
            this.mbtnLogin.Name = "mbtnLogin";
            this.mbtnLogin.Size = new System.Drawing.Size(123, 41);
            this.mbtnLogin.Style = MetroFramework.MetroColorStyle.Teal;
            this.mbtnLogin.TabIndex = 3;
            this.mbtnLogin.Text = "Login";
            this.mbtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mbtnLogin.UseCustomBackColor = true;
            this.mbtnLogin.UseSelectable = true;
            this.mbtnLogin.Click += new System.EventHandler(this.mbtnLogin_Click);
            // 
            // mbtnExit
            // 
            this.mbtnExit.ActiveControl = null;
            this.mbtnExit.BackColor = System.Drawing.Color.RosyBrown;
            this.mbtnExit.Location = new System.Drawing.Point(501, 187);
            this.mbtnExit.Name = "mbtnExit";
            this.mbtnExit.Size = new System.Drawing.Size(117, 41);
            this.mbtnExit.Style = MetroFramework.MetroColorStyle.Teal;
            this.mbtnExit.TabIndex = 4;
            this.mbtnExit.Text = "Cancel";
            this.mbtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mbtnExit.UseCustomBackColor = true;
            this.mbtnExit.UseSelectable = true;
            this.mbtnExit.Click += new System.EventHandler(this.mbtnExit_Click);
            // 
            // loginPicture
            // 
            this.loginPicture.Image = ((System.Drawing.Image)(resources.GetObject("loginPicture.Image")));
            this.loginPicture.Location = new System.Drawing.Point(11, 77);
            this.loginPicture.Name = "loginPicture";
            this.loginPicture.Size = new System.Drawing.Size(180, 150);
            this.loginPicture.TabIndex = 14;
            this.loginPicture.TabStop = false;
            // 
            // cbxProjects
            // 
            this.cbxProjects.FormattingEnabled = true;
            this.cbxProjects.ItemHeight = 23;
            this.cbxProjects.Location = new System.Drawing.Point(195, 118);
            this.cbxProjects.Name = "cbxProjects";
            this.cbxProjects.Size = new System.Drawing.Size(424, 29);
            this.cbxProjects.Style = MetroFramework.MetroColorStyle.Silver;
            this.cbxProjects.TabIndex = 1;
            this.cbxProjects.UseSelectable = true;
            this.cbxProjects.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxCompany_KeyPress);
            // 
            // cbxUsers
            // 
            this.cbxUsers.FormattingEnabled = true;
            this.cbxUsers.ItemHeight = 23;
            this.cbxUsers.Location = new System.Drawing.Point(196, 83);
            this.cbxUsers.Name = "cbxUsers";
            this.cbxUsers.Size = new System.Drawing.Size(424, 29);
            this.cbxUsers.TabIndex = 0;
            this.cbxUsers.UseSelectable = true;
            this.cbxUsers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxUsers_KeyPress);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.RosyBrown;
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.pictureBox1);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Location = new System.Drawing.Point(5, 8);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(615, 60);
            this.pnlLogin.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(43, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 52);
            this.label1.TabIndex = 16;
            this.label1.Text = "Crown Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RosyBrown;
            this.label2.Location = new System.Drawing.Point(4, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(585, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Crown Digit (www.crowndigit.com)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 287);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.cbxUsers);
            this.Controls.Add(this.cbxProjects);
            this.Controls.Add(this.mbtnExit);
            this.Controls.Add(this.mbtnLogin);
            this.Controls.Add(this.loginPicture);
            this.Controls.Add(this.mtxtPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginPicture)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox mtxtPassword;
        private MetroFramework.Controls.MetroTile mbtnLogin;
        private MetroFramework.Controls.MetroTile mbtnExit;
        private System.Windows.Forms.PictureBox loginPicture;
        private MetroFramework.Controls.MetroComboBox cbxProjects;
        private MetroFramework.Controls.MetroComboBox cbxUsers;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}