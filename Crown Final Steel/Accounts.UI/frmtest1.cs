using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Accounts.UI
{
    public partial class frmtest1 : Form
    {
        public frmtest1()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            int icolumn = dataGridView1.CurrentCell.ColumnIndex;
            int irow = dataGridView1.CurrentCell.RowIndex;

            if (keyData == Keys.Enter)
            {
                if (icolumn == dataGridView1.Columns.Count - 1)
                {
                    //dataGridView1.Rows.Add();
                    dataGridView1.CurrentCell = dataGridView1[0, irow + 1];
                }
                else
                {
                    if (icolumn == 1)
                    {
                        if (dataGridView1.Rows[irow].Cells["colName"].Value == null)
                        {
                            MessageBox.Show("Please Enter Name First...");
                            dataGridView1.CurrentCell = dataGridView1.CurrentCell;
                            return false;
                        }
                        dataGridView1.CurrentCell = dataGridView1[icolumn + 1, irow];
                    }
                    else
                    {
                        dataGridView1.CurrentCell = dataGridView1[icolumn + 1, irow];
                    }
                }
                return true;
                
            }
            else
                return base.ProcessCmdKey(ref msg, keyData);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmtest1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

