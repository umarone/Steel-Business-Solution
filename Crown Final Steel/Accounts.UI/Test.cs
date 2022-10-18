using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CombineAssociates.BLL;
using CombineAssociatesEL;

namespace CombineAssociatesUI
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
           
        }

        private void editBox1_ClickButton(object sender, EventArgs e)
        {
            MessageBox.Show("Hurray janab");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int64 qty = 0;
            Int64 remaining = 0;
            decimal Amount = 0;
            var manager = new ItemsBLL();
            List<StockReceiptEL> list = manager.GetStockByItemNo("GLU-01");
            List<StockReceiptEL> ListToUpdateStock = new List<StockReceiptEL>();
            List<StockReceiptEL> ListToCheck = new List<StockReceiptEL>();
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    StockReceiptEL oelStockReceipt = new StockReceiptEL();
                    StockReceiptEL oelStockCheck = new StockReceiptEL();

                    qty = item.Units;
                    if (Convert.ToInt64(txtunits.Text) == item.Units)
                    {
                        if (remaining > 0)
                        {
                            remaining += qty;
                            oelStockReceipt.IdStockReceipt = item.IdStockReceipt;
                            if (qty > remaining)
                            {
                                oelStockReceipt.Units = qty - remaining;
                            }
                            else
                            {
                                oelStockReceipt.Units = remaining - qty;
                            }
                            oelStockReceipt.Amount = item.Amount;
                            Amount = Amount + (item.Units - oelStockReceipt.Units) * (item.Amount / item.Units);
                            ListToUpdateStock.Add(oelStockReceipt);
                            remaining = 0;
                            break;
                        }
                        else
                        {
                            oelStockReceipt.IdStockReceipt = item.IdStockReceipt;
                            oelStockReceipt.Units = qty - Convert.ToInt64(txtunits.Text); ;
                            oelStockCheck.Units = item.Units;
                            oelStockReceipt.Amount = item.Amount;
                            Amount = Amount + (item.Amount / item.Units);
                            oelStockCheck.Amount = Amount;
                            ListToCheck.Add(oelStockCheck);
                            ListToUpdateStock.Add(oelStockReceipt);
                            
                            break;
                        }
                    }
                    else if (item.Units > Convert.ToInt64(txtunits.Text))
                    {
                        if (remaining > 0)
                        {
                            remaining += qty;
                            oelStockReceipt.Units = remaining - Convert.ToInt64(txtunits.Text);
                            oelStockReceipt.IdStockReceipt = item.IdStockReceipt;
                            oelStockReceipt.Amount = item.Amount;
                            oelStockCheck.Units = item.Units - oelStockReceipt.Units;
                            Amount = Amount + (item.Units - oelStockReceipt.Units) * (item.Amount / item.Units);
                            oelStockCheck.Amount = Amount;
                            ListToCheck.Add(oelStockCheck);
                            ListToUpdateStock.Add(oelStockReceipt);
                            remaining = 0;
                            break;
                        }                       
                        else
                        {
                            oelStockReceipt.IdStockReceipt = item.IdStockReceipt;
                            oelStockReceipt.Units = qty - Convert.ToInt64(txtunits.Text);
                            oelStockReceipt.Amount = item.Amount;
                            oelStockCheck.Units = item.Units;
                            Amount = Amount + (item.Amount / item.Units);
                            oelStockCheck.Amount = Amount;
                            ListToCheck.Add(oelStockCheck);
                            ListToUpdateStock.Add(item);
                            break;
                        }
                    }
                    else if (item.Units < Convert.ToInt64(txtunits.Text))
                    {
                        remaining += qty;
                        if (remaining < Convert.ToInt64(txtunits.Text))
                        {
                            oelStockReceipt.Units = item.Units - qty;
                        }
                        else if(remaining == Convert.ToInt64(txtunits.Text))
                        {
                            oelStockReceipt.Units = item.Units - qty;
                        }
                        else if (remaining > Convert.ToInt64(txtunits.Text))
                        {
                            oelStockReceipt.Units = remaining - Convert.ToInt64(txtunits.Text);
                        }
                        oelStockReceipt.IdStockReceipt = item.IdStockReceipt;
                        oelStockCheck.Units = item.Units;                                        
                        oelStockReceipt.Amount = item.Amount;
                        Amount = Amount + (item.Amount / item.Units);
                        oelStockCheck.Amount = Amount;
                        ListToUpdateStock.Add(oelStockReceipt);
                        ListToCheck.Add(oelStockCheck);
                        if (ListToCheck.Sum(x => x.Units) == Convert.ToInt64(txtunits.Text))
                        {
                            remaining = 0;
                            break;
                        }                       
                    }                   
                }
            }
        }
    }
}
