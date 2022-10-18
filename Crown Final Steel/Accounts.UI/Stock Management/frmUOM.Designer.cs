namespace Accounts.UI
{
    partial class frmUOM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUOM));
            this.txtUOM = new MetroFramework.Controls.MetroTextBox();
            this.lblProductDiscription = new MetroFramework.Controls.MetroLabel();
            this.UOMDate = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.chkActive = new MetroFramework.Controls.MetroCheckBox();
            this.btnClose = new MetroFramework.Controls.MetroTile();
            this.btnSave = new MetroFramework.Controls.MetroTile();
            this.grdUOM = new System.Windows.Forms.DataGridView();
            this.colIdUOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUOMName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnClear = new MetroFramework.Controls.MetroTile();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdUOM)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUOM
            // 
            // 
            // 
            // 
            this.txtUOM.CustomButton.Image = null;
            this.txtUOM.CustomButton.Location = new System.Drawing.Point(255, 1);
            this.txtUOM.CustomButton.Name = "";
            this.txtUOM.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUOM.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUOM.CustomButton.TabIndex = 1;
            this.txtUOM.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUOM.CustomButton.UseSelectable = true;
            this.txtUOM.CustomButton.Visible = false;
            this.txtUOM.Lines = new string[0];
            this.txtUOM.Location = new System.Drawing.Point(137, 86);
            this.txtUOM.MaxLength = 32767;
            this.txtUOM.Name = "txtUOM";
            this.txtUOM.PasswordChar = '\0';
            this.txtUOM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUOM.SelectedText = "";
            this.txtUOM.SelectionLength = 0;
            this.txtUOM.SelectionStart = 0;
            this.txtUOM.ShortcutsEnabled = true;
            this.txtUOM.Size = new System.Drawing.Size(277, 23);
            this.txtUOM.TabIndex = 1;
            this.txtUOM.UseSelectable = true;
            this.txtUOM.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUOM.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblProductDiscription
            // 
            this.lblProductDiscription.AutoSize = true;
            this.lblProductDiscription.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblProductDiscription.Location = new System.Drawing.Point(29, 86);
            this.lblProductDiscription.Name = "lblProductDiscription";
            this.lblProductDiscription.Size = new System.Drawing.Size(85, 19);
            this.lblProductDiscription.TabIndex = 3;
            this.lblProductDiscription.Text = "Description :";
            // 
            // UOMDate
            // 
            this.UOMDate.Location = new System.Drawing.Point(137, 114);
            this.UOMDate.Name = "UOMDate";
            this.UOMDate.Size = new System.Drawing.Size(277, 20);
            this.UOMDate.TabIndex = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(27, 112);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Created On :";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(137, 146);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(66, 15);
            this.chkActive.TabIndex = 2;
            this.chkActive.Text = "InActive";
            this.chkActive.UseSelectable = true;
            // 
            // btnClose
            // 
            this.btnClose.ActiveControl = null;
            this.btnClose.Location = new System.Drawing.Point(349, 173);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 84);
            this.btnClose.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.TileImage = ((System.Drawing.Image)(resources.GetObject("btnClose.TileImage")));
            this.btnClose.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseSelectable = true;
            this.btnClose.UseTileImage = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.ActiveControl = null;
            this.btnSave.Location = new System.Drawing.Point(137, 173);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 84);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.TileImage = ((System.Drawing.Image)(resources.GetObject("btnSave.TileImage")));
            this.btnSave.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseTileImage = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grdUOM
            // 
            this.grdUOM.AllowUserToAddRows = false;
            this.grdUOM.AllowUserToDeleteRows = false;
            this.grdUOM.ColumnHeadersHeight = 30;
            this.grdUOM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdUOM,
            this.colUOMName,
            this.colActive,
            this.colEdit});
            this.grdUOM.EnableHeadersVisualStyles = false;
            this.grdUOM.Location = new System.Drawing.Point(11, 263);
            this.grdUOM.Name = "grdUOM";
            this.grdUOM.ReadOnly = true;
            this.grdUOM.Size = new System.Drawing.Size(574, 210);
            this.grdUOM.TabIndex = 7;
            this.grdUOM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUOM_CellClick);
            this.grdUOM.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdUOM_CellFormatting);
            // 
            // colIdUOM
            // 
            this.colIdUOM.DataPropertyName = "IdUOM";
            this.colIdUOM.HeaderText = "IDUOM";
            this.colIdUOM.Name = "colIdUOM";
            this.colIdUOM.ReadOnly = true;
            this.colIdUOM.Visible = false;
            // 
            // colUOMName
            // 
            this.colUOMName.DataPropertyName = "UOMName";
            this.colUOMName.HeaderText = "Uom Name";
            this.colUOMName.Name = "colUOMName";
            this.colUOMName.ReadOnly = true;
            this.colUOMName.Width = 330;
            // 
            // colActive
            // 
            this.colActive.DataPropertyName = "IsActive";
            this.colActive.HeaderText = "Status";
            this.colActive.Name = "colActive";
            this.colActive.ReadOnly = true;
            this.colActive.Width = 50;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "...";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Width = 150;
            // 
            // btnClear
            // 
            this.btnClear.ActiveControl = null;
            this.btnClear.Location = new System.Drawing.Point(243, 173);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 84);
            this.btnClear.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClear.TileImage = ((System.Drawing.Image)(resources.GetObject("btnClear.TileImage")));
            this.btnClear.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClear.UseSelectable = true;
            this.btnClear.UseTileImage = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "-----------------";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "IDUOM";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Uom Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 350;
            // 
            // frmUOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdUOM);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.UOMDate);
            this.Controls.Add(this.txtUOM);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lblProductDiscription);
            this.KeyPreview = true;
            this.Name = "frmUOM";
            this.Text = "UOM Setup";
            this.Load += new System.EventHandler(this.frmUOM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUOM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtUOM;
        private MetroFramework.Controls.MetroLabel lblProductDiscription;
        private System.Windows.Forms.DateTimePicker UOMDate;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox chkActive;
        private MetroFramework.Controls.MetroTile btnClose;
        private MetroFramework.Controls.MetroTile btnSave;
        private System.Windows.Forms.DataGridView grdUOM;
        private MetroFramework.Controls.MetroTile btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdUOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUOMName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
    }
}