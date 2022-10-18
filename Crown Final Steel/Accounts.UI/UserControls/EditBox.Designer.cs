namespace Accounts.UI.UserControls
{
    partial class EditBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBox));
            this.myButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myButton
            // 
            this.myButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.myButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.myButton.Image = ((System.Drawing.Image)(resources.GetObject("myButton.Image")));
            this.myButton.Location = new System.Drawing.Point(169, 0);
            this.myButton.Name = "myButton";
            this.myButton.Size = new System.Drawing.Size(23, 79);
            this.myButton.TabIndex = 0;
            this.myButton.UseVisualStyleBackColor = true;
            // 
            // EditBox
            // 
            this.Controls.Add(this.myButton);
            this.Size = new System.Drawing.Size(196, 83);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button myButton;
    }
}
