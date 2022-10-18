using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accounts.EL;
using Accounts.BLL;
using Accounts.Common;

namespace Accounts.UI
{
    public partial class frmTotalUsers : Form
    {
        UsersEL oelUsers = null;
        public delegate void UsersDelegate(UsersEL oelSingleUser);
        public event UsersDelegate ExecuteUserEvent;
        public frmTotalUsers()
        {
            InitializeComponent();
        }
        private void frmTotalUsers_Load(object sender, EventArgs e)
        {
            var manager = new UsersBLL();
            this.DgvUsers.AutoGenerateColumns = false;
            this.DgvUsers.DataSource = manager.GetAllUsers();
        }

        private void DgvUsers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (DgvUsers.CurrentRow != null)
            {
                int RowIndex = DgvUsers.CurrentRow.Index;
                oelUsers = new UsersEL();
                oelUsers.UserId = Validation.GetSafeLong(DgvUsers.Rows[RowIndex].Cells["colUserId"].Value.ToString());
                oelUsers.UserName = Validation.GetSafeString(DgvUsers.Rows[RowIndex].Cells["colUserName"].Value.ToString());
                oelUsers.Password = Validation.GetSafeString(DgvUsers.Rows[RowIndex].Cells["colPassword"].Value.ToString());
                oelUsers.Cnic = Validation.GetSafeString(DgvUsers.Rows[RowIndex].Cells["colCnic"].Value);
                oelUsers.Address = Validation.GetSafeString(DgvUsers.Rows[RowIndex].Cells["colAddress"].Value);
                this.Close();
            }
        }

        private void frmTotalUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (oelUsers != null)
            {
                ExecuteUserEvent(oelUsers);
            }
        }
    }
}
