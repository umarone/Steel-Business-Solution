using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Accounts.Common;
using Accounts.EL;
using Accounts.BLL;

namespace Accounts.UI
{
    internal class CommonFunctions
    {
        #region Stock Related Functions
        #endregion
        #region Finance Related Methods
        public static List<TransactionsEL> GetClosingBalanceByAccount(Int64 IdProject, Int64 BookNo, string AccountNo)
        {
            var Manager = new TransactionBLL();
            List<TransactionsEL> list = Manager.GetClosingBalanceByAccount(IdProject, BookNo, AccountNo);
            return list;
        }
        public static List<TransactionsEL> GetUnPostedClosingBalanceByAccount(Int64 IdProject, Int64 BookNo, string AccountNo)
        {
            var Manager = new TransactionBLL();
            List<TransactionsEL> list = Manager.GetUnPostedClosingBalanceByAccount(IdProject, BookNo, AccountNo);
            return list;
        }
        public static string RemoveTrailingZeros(decimal Value)
        {
            if (Value == null)
                return "";
            else
            {
                string[] TrailingString = Value.ToString().Split('.');
                if (TrailingString.Length == 2)
                {
                    if (Validation.GetSafeLong(TrailingString[1]) > 0)
                    {
                        return Value.ToString();
                    }
                    else
                    {
                        return TrailingString[0];
                    }
                }
                else
                {
                    return Value.ToString();
                }
            }
        }
        #endregion
    }
}
