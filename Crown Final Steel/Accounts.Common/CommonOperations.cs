using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Accounts.Common
{
    public class CommonOperations
    {
    }
    public enum AccountTypes
    { 
        Customers,
        Suppliers,
        Employees,
        Stock,
        RawMaterial,
        GLAccount
    }
    public enum HeaderAccounts
    {
        Assets=1,
        Libilities,
        Equity,
        Income,
        Expense
    }
    public enum VoucherTypes
    {
        CashReceiptVoucher = 1,
        PaymentVoucher,
        BankReceiptVoucher,
        BankPaymentVoucher,
        SaleInvoiceVoucher,
        SalesReturnVoucher,
        StockReceiptVoucher,
        StockReturnVoucher,
        JournalVoucher,
        GeneralVoucherHead,
        GeneralMaterialStoreIssuance,
        GeneralMaterialStoreReceiving
    }
    //public enum EnRoles
    //{
    //    [Description("DFB16921-F5C2-4FA3-8D9F-375F24708358")]
    //    CheifExecutive = 1,
    //    [Description("A8D997A5-C014-4294-A429-60B2AB9BA609")]
    //    Administrator = 2,
    //    [Description("D46B2019-31C3-41C6-B737-FE51046DD056")]
    //    Operators = 3
    //}
    //public static class MyEnumExtensions
    //{
    //    public static string ToDescriptionString(this EnRoles val)
    //    {
    //        DescriptionAttribute[] attributes = (DescriptionAttribute[])val.GetType().GetField(val.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
    //        return attributes.Length > 0 ? attributes[0].Description : string.Empty;
    //    }
    //}
    public class EnRoles
    {
        public static Int64 CheifExecutive = 1;
        public static Int64 Administrator = 2;
        public static Int64 Operators = 3;
    }
}
