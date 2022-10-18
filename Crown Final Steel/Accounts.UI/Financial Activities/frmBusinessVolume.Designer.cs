namespace Accounts.UI
{
    partial class frmBusinessVolume
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
            this.lblDashed = new MetroFramework.Controls.MetroLabel();
            this.grdBusinessVolume = new System.Windows.Forms.DataGridView();
            this.colDiscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.dt = new MetroFramework.Controls.MetroDateTime();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusinessVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDashed
            // 
            this.lblDashed.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDashed.Location = new System.Drawing.Point(22, 53);
            this.lblDashed.Name = "lblDashed";
            this.lblDashed.Size = new System.Drawing.Size(578, 23);
            this.lblDashed.TabIndex = 0;
            this.lblDashed.Text = "-------------------------------------------------------------------------------";
            // 
            // grdBusinessVolume
            // 
            this.grdBusinessVolume.AllowUserToAddRows = false;
            this.grdBusinessVolume.AllowUserToDeleteRows = false;
            this.grdBusinessVolume.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBusinessVolume.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdBusinessVolume.ColumnHeadersHeight = 26;
            this.grdBusinessVolume.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDiscription,
            this.colAmount});
            this.grdBusinessVolume.EnableHeadersVisualStyles = false;
            this.grdBusinessVolume.GridColor = System.Drawing.Color.Linen;
            this.grdBusinessVolume.Location = new System.Drawing.Point(19, 117);
            this.grdBusinessVolume.Name = "grdBusinessVolume";
            this.grdBusinessVolume.ReadOnly = true;
            this.grdBusinessVolume.Size = new System.Drawing.Size(566, 276);
            this.grdBusinessVolume.TabIndex = 1;
            // 
            // colDiscription
            // 
            this.colDiscription.DataPropertyName = "Discription";
            this.colDiscription.HeaderText = "Discription";
            this.colDiscription.Name = "colDiscription";
            this.colDiscription.ReadOnly = true;
            this.colDiscription.Width = 380;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 130;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDate.Location = new System.Drawing.Point(25, 80);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(84, 19);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Select Date :";
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(115, 77);
            this.dt.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(365, 29);
            this.dt.TabIndex = 3;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(486, 76);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(99, 31);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Discription";
            this.dataGridViewTextBoxColumn1.HeaderText = "Discription";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 380;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn2.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // frmBusinessVolume
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(608, 412);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.grdBusinessVolume);
            this.Controls.Add(this.lblDashed);
            this.KeyPreview = true;
            this.Name = "frmBusinessVolume";
            this.Text = "Business Volume Report";
            this.Load += new System.EventHandler(this.frmBusinessVolume_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmBusinessVolume_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.grdBusinessVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblDashed;
        private System.Windows.Forms.DataGridView grdBusinessVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroDateTime dt;
        private MetroFramework.Controls.MetroButton btnLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}