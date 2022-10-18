using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Accounts.UI.UserControls
{
    public partial class EditBox : RichTextBox
    {
        public EditBox()
        {
            InitializeComponent();
        }
        public event EventHandler ClickButton
        {
            add
            {
                this.myButton.Click += value;
            }
            remove
            {
                this.myButton.Click -= value;
            }
        }
        protected override void OnCreateControl()
        {
            if (!this.Controls.Contains(this.myButton))
            {
                this.Controls.Add(this.myButton);
                //size of control - size control button +10
                this.RightMargin = this.Size.Width - (this.myButton.Size.Width + 10);
            }

            base.OnCreateControl();
        }
        private void OnMouseEnter(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                this.myButton.Cursor = Cursors.Default;
            }
            else
            {
                this.Cursor = Cursors.Arrow;
            }

        }
    }
}
