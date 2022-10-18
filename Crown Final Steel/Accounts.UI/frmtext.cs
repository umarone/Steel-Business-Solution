using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroFramework.Forms;

namespace Accounts.UI
{
    public partial class frmtext : MetroForm
    {
        public frmtext()
        {
            InitializeComponent();
        }

        private void frmtext_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button2, new Point(0, button2.Height));
        }

        private void aOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi");
        }

        private void bOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bye");
        }
    }
}
