using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Accounts.EL;
using Accounts.Common;

namespace Accounts.DAL
{
    public class SalesHeadDAL
    {
        #region Variables
        IDataReader objReader;
        SaleDetailDAL dal;
        TransactionsDAL Tdal;
        StockDAL stockdal;
        Int64? Identity;
        #endregion      
        #region Sales Related Methods Only
        public SalesHeadDAL()
        {
            dal = new SaleDetailDAL();
            Tdal = new TransactionsDAL();
            stockdal = new StockDAL();
        }
        public Int64 GetMaxSalesInvoiceNumberBySaleType(Int64 IdProject, Int64 BookNo, bool IsNetTransaction, int SaleType, SqlConnection objConn)
        {
            using (SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetMaxSalesInvoiceNumber]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdSales.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                //cmdSales.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
                //cmdSales.Parameters.Add("@SaleType", SqlDbType.Bit).Value = SaleType;
                return Validation.GetSafeLong(cmdSales.ExecuteScalar());
            }
        }
        public EntityoperationInfo InsertSales(VouchersEL oelVoucher, List<VoucherDetailEL> oelSaleCollection, List<VoucherDetailEL> oelProductsProfitLoss, List<VoucherDetailEL> oelSalesTransactionsCollection, SqlConnection objConn)
        {
            EntityoperationInfo info = new EntityoperationInfo();
            lock (this)
            {
                SqlTransaction objTran = objConn.BeginTransaction();
                try
                {
                    //// Insert Sale Voucher
                    SqlCommand cmdSales = new SqlCommand();
                    if (oelVoucher.SoftwareType == "Distribution Trading")
                    {
                        cmdSales.CommandText = "[Transactions].[Proc_CreateDistributionSalesHead]";
                    }
                    else
                        cmdSales.CommandText = "[Transactions].[Proc_CreateSalesHead]";
                    cmdSales.Connection = objConn;
                    cmdSales.CommandType = CommandType.StoredProcedure;
                    cmdSales.Transaction = objTran;
                    cmdSales.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelVoucher.IdVoucher;
                    cmdSales.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelVoucher.IdProject;
                    cmdSales.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelVoucher.IdUser;
                    cmdSales.Parameters.Add(new SqlParameter("@IdEditedUser", DbType.Int64)).Value = oelVoucher.EditedByUserId;
                    cmdSales.Parameters.Add(new SqlParameter("@IdPostedUser", DbType.Int64)).Value = oelVoucher.PostedByUserId;
                    cmdSales.Parameters.Add(new SqlParameter("@SheetNo", DbType.String)).Value = oelVoucher.SheetNo;
                    cmdSales.Parameters.Add(new SqlParameter("@BookNo", DbType.String)).Value = oelVoucher.BookNo;
                    cmdSales.Parameters.Add(new SqlParameter("@TerminalNo", DbType.Int64)).Value = oelVoucher.TerminalNumber;
                    cmdSales.Parameters.Add(new SqlParameter("@BiltyNo", DbType.String)).Value = oelVoucher.BiltyNo;
                    cmdSales.Parameters.Add(new SqlParameter("@SampleNo", DbType.Int64)).Value = oelVoucher.SampleNo;
                    //cmdSales.Parameters.Add(new SqlParameter("@PersonName", DbType.String)).Value = oelVoucher.FirstName;
                    //cmdSales.Parameters.Add(new SqlParameter("@PersonContact", DbType.String)).Value = oelVoucher.Contact;
                    //cmdSales.Parameters.Add(new SqlParameter("@PersonCNIC", DbType.String)).Value = oelVoucher.Cnic;
                    //cmdSales.Parameters.Add(new SqlParameter("@PersonAddress", DbType.String)).Value = oelVoucher.Address;
                    cmdSales.Parameters.Add(new SqlParameter("@VDate", DbType.DateTime)).Value = oelVoucher.VDate;
                    cmdSales.Parameters.Add(new SqlParameter("@DueDate", DbType.DateTime)).Value = oelVoucher.DueDate;
                    cmdSales.Parameters.Add(new SqlParameter("@EditedDateTime", DbType.DateTime)).Value = oelVoucher.EditedDateTime;
                    cmdSales.Parameters.Add(new SqlParameter("@PostedDateTime", DbType.DateTime)).Value = oelVoucher.PostedDateTime;
                    cmdSales.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucher.AccountNo;
                    cmdSales.Parameters.Add(new SqlParameter("@TransactionAccountNo", DbType.String)).Value = oelVoucher.TransactionAccountNo;
                    if (oelVoucher.SoftwareType == "Distribution Trading")
                    {
                        cmdSales.Parameters.Add(new SqlParameter("@CashAccountNo", DbType.String)).Value = oelVoucher.CashAccountNo;
                    }
                    cmdSales.Parameters.Add(new SqlParameter("@EmpCode", DbType.String)).Value = oelVoucher.SubAccountNo;
                    cmdSales.Parameters.Add(new SqlParameter("@DeliveryEmployeeAccountNo", DbType.String)).Value = oelVoucher.EmployeeAccountNo;
                    cmdSales.Parameters.Add(new SqlParameter("@VDiscription", DbType.String)).Value = oelVoucher.VDiscription;
                    cmdSales.Parameters.Add(new SqlParameter("@VehicleNo", DbType.String)).Value = oelVoucher.VehicleNo;
                    cmdSales.Parameters.Add(new SqlParameter("@DriverName", DbType.String)).Value = oelVoucher.DriverName;
                    cmdSales.Parameters.Add(new SqlParameter("@OutWardGatePassNo", DbType.String)).Value = oelVoucher.OutWardGatePassNo;
                    cmdSales.Parameters.Add(new SqlParameter("@CustomerBalance", DbType.Decimal)).Value = oelVoucher.ClosingBalance;
                    cmdSales.Parameters.Add(new SqlParameter("@BillAmount", DbType.Decimal)).Value = oelVoucher.BillAmount;
                    cmdSales.Parameters.Add(new SqlParameter("@TotalDiscount", DbType.Decimal)).Value = oelVoucher.TotalDiscount;
                    cmdSales.Parameters.Add(new SqlParameter("@FlatDiscount", DbType.Decimal)).Value = oelVoucher.FlatDiscount;
                    cmdSales.Parameters.Add(new SqlParameter("@ExtraDiscount", DbType.Decimal)).Value = oelVoucher.ExtraDiscount;
                    cmdSales.Parameters.Add(new SqlParameter("@BillAmountAfterDiscount", DbType.Decimal)).Value = oelVoucher.BillAmountAfterDiscount;
                    cmdSales.Parameters.Add(new SqlParameter("@TotalFreight", DbType.Decimal)).Value = oelVoucher.TotalFreight;
                    cmdSales.Parameters.Add(new SqlParameter("@TotalAmount", DbType.Decimal)).Value = oelVoucher.TotalAmount;
                    cmdSales.Parameters.Add(new SqlParameter("@VAT", DbType.Decimal)).Value = oelVoucher.VAT;
                    cmdSales.Parameters.Add(new SqlParameter("@VATTotalAmount", DbType.Decimal)).Value = oelVoucher.VATAmount;
                    cmdSales.Parameters.Add(new SqlParameter("@TotalItems", DbType.Decimal)).Value = oelVoucher.TotalItems;
                    cmdSales.Parameters.Add(new SqlParameter("@TaxPercentage", DbType.Decimal)).Value = oelVoucher.TaxPercentage;
                    cmdSales.Parameters.Add(new SqlParameter("@TotalTaxAmount", DbType.Decimal)).Value = oelVoucher.TotalTaxAmount;
                    cmdSales.Parameters.Add(new SqlParameter("@TotalAmountAfterTax", DbType.Decimal)).Value = oelVoucher.TotalAmountAfterTax;
                    cmdSales.Parameters.Add(new SqlParameter("@CreditDays", DbType.Int32)).Value = oelVoucher.RemainingDays;
                    cmdSales.Parameters.Add(new SqlParameter("@IsRecieved", DbType.Decimal)).Value = oelVoucher.IsRecieved;
                    cmdSales.Parameters.Add(new SqlParameter("@IsNetTransaction", DbType.Boolean)).Value = oelVoucher.IsNetTransaction;
                    cmdSales.Parameters.Add(new SqlParameter("@IsImportTransaction", DbType.Boolean)).Value = oelVoucher.IsImportTransaction;
                    cmdSales.Parameters.Add(new SqlParameter("@FreeVoucher", DbType.Decimal)).Value = oelVoucher.FreeVoucher;
                    cmdSales.Parameters.Add(new SqlParameter("@CardNo", DbType.String)).Value = oelVoucher.CardNo;
                    cmdSales.Parameters.Add(new SqlParameter("@PaymentType", DbType.Int32)).Value = oelVoucher.PaymentType;
                    cmdSales.Parameters.Add(new SqlParameter("@CashRecieved", DbType.Decimal)).Value = oelVoucher.CashRecieved;
                    cmdSales.Parameters.Add(new SqlParameter("@CashBalance", DbType.Decimal)).Value = oelVoucher.Balance;
                    cmdSales.Parameters.Add(new SqlParameter("@LoadingCharges", DbType.String)).Value = oelVoucher.LoadingCharges;
                    cmdSales.Parameters.Add(new SqlParameter("@CuttingCharges", DbType.String)).Value = oelVoucher.CuttingCharges;
                    cmdSales.Parameters.Add(new SqlParameter("@MiscCharges", DbType.String)).Value = oelVoucher.MiscCharges;
                    cmdSales.Parameters.Add(new SqlParameter("@SystemWeight", DbType.Decimal)).Value = oelVoucher.SystemWeight;
                    cmdSales.Parameters.Add(new SqlParameter("@ManualWeight", DbType.Decimal)).Value = oelVoucher.ManualWeight;
                    cmdSales.Parameters.Add(new SqlParameter("@AutoWeight", DbType.Decimal)).Value = oelVoucher.AutoWeight;
                    cmdSales.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;
                    Identity = Validation.GetSafeLong(cmdSales.ExecuteScalar());

                    //// Insert Detail Sales In Sale Record
                    dal.InsertSaleDetail(oelSaleCollection, Identity, objConn, objTran);

                    info.VoucherNo = GetInvoiceNumber(Identity.Value, oelVoucher.IdProject.Value, oelVoucher.BookNo, objConn, objTran);

                    dal.InsertSalesTransactionsDetail(oelSalesTransactionsCollection, Identity, info.VoucherNo.ToString(), objConn, objTran);

                    if (oelVoucher.Posted.Value)
                    {
                        dal.InsertProductsProfitLoss(oelProductsProfitLoss, Identity, objConn, objTran);
                    }

                    objTran.Commit();

                    info.IntID = Identity.Value;
                    info.IsSuccess = true;

                    return info;
                }
                catch (Exception ex)
                {
                    objTran.Rollback();
                    throw ex;
                }
            }
        }
        public EntityoperationInfo UpdateSales(VouchersEL oelVoucher, List<VoucherDetailEL> oelSaleCollection, List<VoucherDetailEL> oelProductsProfitLossCollection, List<VoucherDetailEL> oelSalesTransactionsCollection, SqlConnection objConn)
        {
            EntityoperationInfo info = new EntityoperationInfo();
            lock (this)
            {
                SqlTransaction objTran = objConn.BeginTransaction();
                try
                {
                    SqlCommand cmdSales = new SqlCommand();
                    if (oelVoucher.SoftwareType == "Distribution Trading")
                    {
                        cmdSales.CommandText = "[Transactions].[Proc_UpdateDistributionSalesHead]";
                    }
                    else
                    {
                        cmdSales.CommandText = "[Transactions].[Proc_UpdateSalesHead]";
                    }
                    cmdSales.Connection = objConn;
                    cmdSales.CommandType = CommandType.StoredProcedure;
                    cmdSales.Transaction = objTran;

                    cmdSales.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelVoucher.IdVoucher;
                    cmdSales.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelVoucher.IdProject;
                    cmdSales.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelVoucher.IdUser;
                    cmdSales.Parameters.Add(new SqlParameter("@IdEditedUser", DbType.Int64)).Value = oelVoucher.EditedByUserId;
                    cmdSales.Parameters.Add(new SqlParameter("@IdPostedUser", DbType.Int64)).Value = oelVoucher.PostedByUserId;
                    cmdSales.Parameters.Add(new SqlParameter("@SheetNo", DbType.String)).Value = oelVoucher.SheetNo;
                    cmdSales.Parameters.Add(new SqlParameter("@BookNo", DbType.String)).Value = oelVoucher.BookNo;
                    cmdSales.Parameters.Add(new SqlParameter("@TerminalNo", DbType.Int64)).Value = oelVoucher.TerminalNumber;
                    cmdSales.Parameters.Add(new SqlParameter("@BiltyNo", DbType.String)).Value = oelVoucher.BiltyNo;
                    cmdSales.Parameters.Add(new SqlParameter("@SampleNo", DbType.Int64)).Value = oelVoucher.SampleNo;
                    //cmdSales.Parameters.Add(new SqlParameter("@PersonName", DbType.String)).Value = oelVoucher.FirstName;
                    //cmdSales.Parameters.Add(new SqlParameter("@PersonContact", DbType.String)).Value = oelVoucher.Contact;
                    //cmdSales.Parameters.Add(new SqlParameter("@PersonCNIC", DbType.String)).Value = oelVoucher.Cnic;
                    //cmdSales.Parameters.Add(new SqlParameter("@PersonAddress", DbType.String)).Value = oelVoucher.Address;
                    cmdSales.Parameters.Add(new SqlParameter("@VDate", DbType.DateTime)).Value = oelVoucher.VDate;
                    cmdSales.Parameters.Add(new SqlParameter("@DueDate", DbType.DateTime)).Value = oelVoucher.DueDate;
                    cmdSales.Parameters.Add(new SqlParameter("@EditedDateTime", DbType.DateTime)).Value = oelVoucher.EditedDateTime;
                    cmdSales.Parameters.Add(new SqlParameter("@PostedDateTime", DbType.DateTime)).Value = oelVoucher.PostedDateTime;
                    cmdSales.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucher.AccountNo;
                    cmdSales.Parameters.Add(new SqlParameter("@TransactionAccountNo", DbType.String)).Value = oelVoucher.TransactionAccountNo;
                    if (oelVoucher.SoftwareType == "Distribution Trading")
                    {
                        cmdSales.Parameters.Add(new SqlParameter("@CashAccountNo", DbType.String)).Value = oelVoucher.CashAccountNo;
                    }
                    cmdSales.Parameters.Add(new SqlParameter("@EmpCode", DbType.String)).Value = oelVoucher.SubAccountNo;
                    cmdSales.Parameters.Add(new SqlParameter("@DeliveryEmployeeAccountNo", DbType.String)).Value = oelVoucher.EmployeeAccountNo;
                    cmdSales.Parameters.Add(new SqlParameter("@VDiscription", DbType.String)).Value = oelVoucher.VDiscription;
                    cmdSales.Parameters.Add(new SqlParameter("@VehicleNo", DbType.String)).Value = oelVoucher.VehicleNo;
                    cmdSales.Parameters.Add(new SqlParameter("@DriverName", DbType.String)).Value = oelVoucher.DriverName;
                    cmdSales.Parameters.Add(new SqlParameter("@OutWardGatePassNo", DbType.String)).Value = oelVoucher.OutWardGatePassNo;
                    cmdSales.Parameters.Add(new SqlParameter("@CustomerBalance", DbType.Decimal)).Value = oelVoucher.ClosingBalance;
                    cmdSales.Parameters.Add(new SqlParameter("@BillAmount", DbType.Decimal)).Value = oelVoucher.BillAmount;
                    cmdSales.Parameters.Add(new SqlParameter("@TotalDiscount", DbType.Decimal)).Value = oelVoucher.TotalDiscount;
                    cmdSales.Parameters.Add(new SqlParameter("@FlatDiscount", DbType.Decimal)).Value = oelVoucher.FlatDiscount;
                    cmdSales.Parameters.Add(new SqlParameter("@ExtraDiscount", DbType.Decimal)).Value = oelVoucher.ExtraDiscount;
                    cmdSales.Parameters.Add(new SqlParameter("@BillAmountAfterDiscount", DbType.Decimal)).Value = oelVoucher.BillAmountAfterDiscount;
                    cmdSales.Parameters.Add(new SqlParameter("@TotalFreight", DbType.Decimal)).Value = oelVoucher.TotalFreight;
                    cmdSales.Parameters.Add(new SqlParameter("@TotalAmount", DbType.Decimal)).Value = oelVoucher.TotalAmount;
                    cmdSales.Parameters.Add(new SqlParameter("@VAT", DbType.Decimal)).Value = oelVoucher.VAT;
                    cmdSales.Parameters.Add(new SqlParameter("@VATTotalAmount", DbType.Decimal)).Value = oelVoucher.VATAmount;
                    cmdSales.Parameters.Add(new SqlParameter("@TotalItems", DbType.Decimal)).Value = oelVoucher.TotalItems;
                    cmdSales.Parameters.Add(new SqlParameter("@TaxPercentage", DbType.Decimal)).Value = oelVoucher.TaxPercentage;
                    cmdSales.Parameters.Add(new SqlParameter("@TotalTaxAmount", DbType.Decimal)).Value = oelVoucher.TotalTaxAmount;
                    cmdSales.Parameters.Add(new SqlParameter("@TotalAmountAfterTax", DbType.Decimal)).Value = oelVoucher.TotalAmountAfterTax;
                    cmdSales.Parameters.Add(new SqlParameter("@CreditDays", DbType.Int32)).Value = oelVoucher.RemainingDays;
                    cmdSales.Parameters.Add(new SqlParameter("@IsRecieved", DbType.Decimal)).Value = oelVoucher.Transactiondays;
                    cmdSales.Parameters.Add(new SqlParameter("@IsNetTransaction", DbType.Boolean)).Value = oelVoucher.IsNetTransaction;
                    cmdSales.Parameters.Add(new SqlParameter("@IsImportTransaction", DbType.Boolean)).Value = oelVoucher.IsImportTransaction;
                    cmdSales.Parameters.Add(new SqlParameter("@FreeVoucher", DbType.Decimal)).Value = oelVoucher.FreeVoucher;
                    cmdSales.Parameters.Add(new SqlParameter("@CardNo", DbType.String)).Value = oelVoucher.CardNo;
                    cmdSales.Parameters.Add(new SqlParameter("@PaymentType", DbType.Int32)).Value = oelVoucher.PaymentType;
                    cmdSales.Parameters.Add(new SqlParameter("@CashRecieved", DbType.Decimal)).Value = oelVoucher.CashRecieved;
                    cmdSales.Parameters.Add(new SqlParameter("@CashBalance", DbType.Decimal)).Value = oelVoucher.Balance;
                    cmdSales.Parameters.Add(new SqlParameter("@LoadingCharges", DbType.String)).Value = oelVoucher.LoadingCharges;
                    cmdSales.Parameters.Add(new SqlParameter("@CuttingCharges", DbType.String)).Value = oelVoucher.CuttingCharges;
                    cmdSales.Parameters.Add(new SqlParameter("@MiscCharges", DbType.String)).Value = oelVoucher.MiscCharges;
                    cmdSales.Parameters.Add(new SqlParameter("@SystemWeight", DbType.Decimal)).Value = oelVoucher.SystemWeight;
                    cmdSales.Parameters.Add(new SqlParameter("@ManualWeight", DbType.Decimal)).Value = oelVoucher.ManualWeight;
                    cmdSales.Parameters.Add(new SqlParameter("@AutoWeight", DbType.Decimal)).Value = oelVoucher.AutoWeight;
                    cmdSales.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;

                    info.IntID = cmdSales.ExecuteNonQuery();
                    info.IsSuccess = true;
                    //// Insert And Update Sales In Sale Record
                    dal.UpdateSaleDetail(oelSaleCollection, objConn, objTran);

                    ///
                    dal.UpdateSalesTransactionsDetail(oelSalesTransactionsCollection, objConn, objTran);

                    if (oelVoucher.Posted.Value && oelProductsProfitLossCollection.Count > 0 && !CheckProfitLossVoucher(oelVoucher.IdVoucher.Value, objConn, objTran))
                    {
                        dal.InsertProductsProfitLoss(oelProductsProfitLossCollection, oelVoucher.IdVoucher, objConn, objTran);
                    }

                    objTran.Commit();
                }
                catch (Exception ex)
                {
                    objTran.Rollback();
                    throw ex;
                }
                finally
                {

                }
                return info;
            }
        }
        public EntityoperationInfo UpdateInvoicesAndReturnsDates(Int64 IdVoucher, DateTime ChangedDate, Int32 Type, SqlConnection objConn)
        {
            EntityoperationInfo info = new EntityoperationInfo();
            lock (this)
            {
                SqlCommand cmdSales = new SqlCommand();

                cmdSales.CommandText = "[Transactions].[Proc_UpdateInvoicesAndReturnInvoicesDate]";

                cmdSales.Connection = objConn;
                cmdSales.CommandType = CommandType.StoredProcedure;

                cmdSales.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = IdVoucher;
                cmdSales.Parameters.Add(new SqlParameter("@ChangedDate", DbType.DateTime)).Value = ChangedDate;
                cmdSales.Parameters.Add(new SqlParameter("@ChangeNumber", DbType.Int64)).Value = Type;

                info.IntID = cmdSales.ExecuteNonQuery();
                info.IsSuccess = true;

                return info;
            }
        }
        public Int64 GetInvoiceNumber(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, SqlConnection objConn, SqlTransaction objTran)
        {
            SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetInvoiceNumberByVoucher]", objConn, objTran);
            cmdSales.CommandType = CommandType.StoredProcedure;
            cmdSales.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
            cmdSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
            cmdSales.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
            return Validation.GetSafeLong(cmdSales.ExecuteScalar());
        }
        public bool CheckProfitLossVoucher(Int64 IdVoucher, SqlConnection objConn, SqlTransaction objTran)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_CheckProfitLossTableForVoucher]", objConn, objTran);
            cmdSales.CommandType = CommandType.StoredProcedure;
            cmdSales.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
            objReader = cmdSales.ExecuteReader();
            while (objReader.Read())
            {
                VoucherDetailEL oelVoucher = new VoucherDetailEL();
                oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                list.Add(oelVoucher);
            }
            objReader.Close();
            if (list.Count > 0)
            {
                return true;
            }
            else
                return false;
        }
        public List<VoucherDetailEL> GetAllProjectWiseDatedSales(Int64 IdProject, Int64 BookNo, string AccountNo, DateTime StartDate, DateTime EndDate, bool IsNetTransaction, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetAllDatedSales]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;
                cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdVouchers.Parameters.Add("@DeliveryAccountNo", SqlDbType.VarChar).Value = AccountNo;
                cmdVouchers.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdVouchers.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                cmdVouchers.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
                objReader = cmdVouchers.ExecuteReader();
                while (objReader.Read())
                {
                    //// Getting Purchases Voucher Header Here...
                    VoucherDetailEL oelVoucher = new VoucherDetailEL();
                    oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                    oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);

                    oelVoucher.VDate = Convert.ToDateTime(objReader["VDate"]);

                    oelVoucher.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);


                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public List<VoucherDetailEL> GetSalesTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, bool IsNetTransaction, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetSalesTransactions]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;
                cmdVouchers.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
                cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                //cmdVouchers.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
                objReader = cmdVouchers.ExecuteReader();
                while (objReader.Read())
                {
                    //// Getting Purchases Voucher Header Here...
                    VoucherDetailEL oelVoucher = new VoucherDetailEL();
                    oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                    oelVoucher.SheetNo = Validation.GetSafeLong(objReader["SheetNo"]);
                    oelVoucher.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                    oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelVoucher.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                    oelVoucher.BiltyNo = Validation.GetSafeString(objReader["BiltyNo"]);
                    oelVoucher.SampleNo = Validation.GetSafeLong(objReader["SampleNo"]);
                    //oelVoucher.FirstName = Validation.GetSafeString(objReader["PersonName"]);
                    //oelVoucher.Contact = Validation.GetSafeString(objReader["PersonContact"]);
                    //oelVoucher.Cnic = Validation.GetSafeString(objReader["PersonCNIC"]);
                    //oelVoucher.Address = Validation.GetSafeString(objReader["PersonAddress"]);

                    oelVoucher.VDate = Convert.ToDateTime(objReader["VDate"]);
                    oelVoucher.DueDate = Validation.GetSafeDateTime(objReader["DueDate"]);
                    oelVoucher.EditedDateTime = Validation.GetSafeNullableDateTime(objReader["EditedDateTime"]);
                    oelVoucher.PostedDateTime = Validation.GetSafeNullableDateTime(objReader["PostedDateTime"]);
                    oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelVoucher.TransactionAccountNo = Validation.GetSafeString(objReader["TransactionAccountNo"]);
                    oelVoucher.SubAccountNo = Validation.GetSafeString(objReader["EmpCode"]);
                    oelVoucher.EmployeeAccountNo = Validation.GetSafeString(objReader["DeliveryEmployeeAccountNo"]);
                    oelVoucher.VDiscription = Validation.GetSafeString(objReader["VDiscription"]);
                    oelVoucher.VehicleNo = Validation.GetSafeString(objReader["VehicleNo"]);
                    oelVoucher.DriverName = Validation.GetSafeString(objReader["DriverName"]);
                    oelVoucher.OutWardGatePassNo = Validation.GetSafeString(objReader["OutWardGatePassNo"]);

                    oelVoucher.IsNetTransaction = Convert.ToBoolean(objReader["IsNetTransaction"]);
                    oelVoucher.ClosingBalance = Validation.GetSafeDecimal(objReader["CustomerBalance"]);
                    oelVoucher.BillAmount = Validation.GetSafeDecimal(objReader["BillAmount"]);
                    oelVoucher.TotalFreight = Validation.GetSafeDecimal(objReader["TotalFreight"]);
                    oelVoucher.TotalDiscount = Validation.GetSafeDecimal(objReader["TotalDiscount"]);
                    oelVoucher.FlatDiscount = Validation.GetSafeDecimal(objReader["FlatDiscount"]);
                    oelVoucher.ExtraDiscount = Validation.GetSafeDecimal(objReader["ExtraDiscount"]);
                    oelVoucher.BillAmountAfterDiscount = Validation.GetSafeDecimal(objReader["BillAmountAfterDiscount"]);
                    oelVoucher.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                    oelVoucher.VAT = Validation.GetSafeDecimal(objReader["VAT"]);
                    oelVoucher.VATAmount = Validation.GetSafeDecimal(objReader["VATTotalAmount"]);
                    oelVoucher.TotalItems = Validation.GetSafeDecimal(objReader["TotalItems"]);
                    oelVoucher.TaxPercentage = Validation.GetSafeDecimal(objReader["TaxPercentage"]);
                    oelVoucher.TotalTaxAmount = Validation.GetSafeDecimal(objReader["TotalTaxAmount"]);
                    oelVoucher.TotalAmountAfterTax = Validation.GetSafeDecimal(objReader["TotalAmountAfterTax"]);
                    oelVoucher.Transactiondays = Validation.GetSafeLong(objReader["CreditDays"]);
                    oelVoucher.IsRecieved = Validation.GetSafeBooleanNullable(objReader["IsRecieved"]);

                    oelVoucher.IsNetTransaction = Validation.GetSafeBooleanNullable(objReader["IsNetTransaction"]);
                    oelVoucher.IsImportTransaction = Validation.GetSafeBooleanNullable(objReader["IsImportTransaction"]);
                    oelVoucher.FreeVoucher = Validation.GetSafeDecimal(objReader["FreeVoucher"]);
                    oelVoucher.CardNo = Validation.GetSafeString(objReader["CardNo"]);
                    oelVoucher.PaymentType = Validation.GetSafeInteger(objReader["PaymentType"]);
                    oelVoucher.CashRecieved = Validation.GetSafeDecimal(objReader["CashRecieved"]);
                    oelVoucher.Balance = Validation.GetSafeDecimal(objReader["CashBalance"]);
                    oelVoucher.LoadingCharges = Validation.GetSafeDecimal(objReader["LoadingCharges"]);
                    oelVoucher.CuttingCharges = Validation.GetSafeDecimal(objReader["CuttingCharges"]);
                    oelVoucher.MiscCharges = Validation.GetSafeDecimal(objReader["MiscCharges"]);
                    oelVoucher.SystemWeight = Validation.GetSafeDecimal(objReader["SystemWeight"]);
                    oelVoucher.ManualWeight = Validation.GetSafeDecimal(objReader["ManualWeight"]);
                    oelVoucher.AutoWeight = Validation.GetSafeDecimal(objReader["AutoWeight"]);
                    oelVoucher.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);
                    oelVoucher.IsDeleted = Validation.GetSafeBooleanNullable(objReader["IsDeleted"]);

                    //// Getting SalesDetail Here...
                    oelVoucher.IdVoucherDetail = Validation.GetSafeLong(objReader["VoucherDetail_Id"]);
                    oelVoucher.IdItem = Validation.GetSafeLong(objReader["Item_Id"]);
                    oelVoucher.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelVoucher.AutoWeightItemIndex = Validation.GetSafeInteger(objReader["AutoWeightItemIndex"]);
                    oelVoucher.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                    oelVoucher.Discription = Validation.GetSafeString(objReader["Discription"]);
                    oelVoucher.TotalCartons = Validation.GetSafeLong(objReader["TotalCartons"]);
                    oelVoucher.BatchNo = Validation.GetSafeString(objReader["BatchNo"]);
                    oelVoucher.Expiry = Validation.GetSafeString(objReader["Expiry"]);
                    oelVoucher.EngineNo = Validation.GetSafeString(objReader["EngineNo"]);
                    oelVoucher.ChasisNo = Validation.GetSafeString(objReader["ChasisNo"]);
                    oelVoucher.VehicleNo = Validation.GetSafeString(objReader["VehicleNo"]);
                    oelVoucher.FirstIMEI = Validation.GetSafeString(objReader["FirstIMEI"]);
                    oelVoucher.SecondIMEI = Validation.GetSafeString(objReader["SecondIMEI"]);
                    oelVoucher.ColorCode = Validation.GetSafeInteger(objReader["ColorCode"]);
                    oelVoucher.CurrentStock = Validation.GetSafeDecimal(objReader["CurrentStock"]);
                    oelVoucher.Units = Validation.GetSafeDecimal(objReader["Units"]);
                    oelVoucher.Bonus = Validation.GetSafeDecimal(objReader["BonusUnits"]);
                    oelVoucher.ItemWeight = Validation.GetSafeDecimal(objReader["ItemWeight"]);
                    oelVoucher.UnitPrice = Validation.GetSafeDecimal(objReader["UnitPrice"]);
                    oelVoucher.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                    oelVoucher.Discount = Validation.GetSafeDecimal(objReader["DiscPercentage"]);
                    oelVoucher.DiscountAmount = Validation.GetSafeDecimal(objReader["DiscountAmount"]);
                    oelVoucher.LineDiscount = Validation.GetSafeDecimal(objReader["LineDiscount"]);
                    oelVoucher.NetSaleAmount = Validation.GetSafeDecimal(objReader["NetSaleAmount"]);


                    list.Add(oelVoucher);
                }
            }
            return list;
        }

        public List<VoucherDetailEL> GetSalesTransactionsByNumber(Int64 InvoiceNumber, Int64 IdProject, Int64 BookNo, bool IsNetTransaction, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetSalesTransactionsByNumber]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;
                cmdVouchers.Parameters.Add("@InvoiceNo", SqlDbType.BigInt).Value = InvoiceNumber;
                cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                //cmdVouchers.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
                objReader = cmdVouchers.ExecuteReader();
                while (objReader.Read())
                {
                    //// Getting Purchases Voucher Header Here...
                    VoucherDetailEL oelVoucher = new VoucherDetailEL();
                    oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                    oelVoucher.SheetNo = Validation.GetSafeLong(objReader["SheetNo"]);
                    oelVoucher.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                    oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelVoucher.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                    oelVoucher.BiltyNo = Validation.GetSafeString(objReader["BiltyNo"]);
                    oelVoucher.SampleNo = Validation.GetSafeLong(objReader["SampleNo"]);
                    //oelVoucher.FirstName = Validation.GetSafeString(objReader["PersonName"]);
                    //oelVoucher.Contact = Validation.GetSafeString(objReader["PersonContact"]);
                    //oelVoucher.Cnic = Validation.GetSafeString(objReader["PersonCNIC"]);
                    //oelVoucher.Address = Validation.GetSafeString(objReader["PersonAddress"]);

                    oelVoucher.VDate = Convert.ToDateTime(objReader["VDate"]);
                    oelVoucher.DueDate = Validation.GetSafeDateTime(objReader["DueDate"]);
                    oelVoucher.EditedDateTime = Validation.GetSafeNullableDateTime(objReader["EditedDateTime"]);
                    oelVoucher.PostedDateTime = Validation.GetSafeNullableDateTime(objReader["PostedDateTime"]);
                    oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelVoucher.TransactionAccountNo = Validation.GetSafeString(objReader["TransactionAccountNo"]);
                    //oelVoucher.CashAccountNo = Validation.GetSafeString(objReader["CashAccountNo"]);
                    oelVoucher.SubAccountNo = Validation.GetSafeString(objReader["EmpCode"]);
                    oelVoucher.EmployeeAccountNo = Validation.GetSafeString(objReader["DeliveryEmployeeAccountNo"]);
                    oelVoucher.VDiscription = Validation.GetSafeString(objReader["VDiscription"]);
                    oelVoucher.VehicleNo = Validation.GetSafeString(objReader["VehicleNo"]);
                    oelVoucher.DriverName = Validation.GetSafeString(objReader["DriverName"]);
                    oelVoucher.OutWardGatePassNo = Validation.GetSafeString(objReader["OutWardGatePassNo"]);

                    oelVoucher.IsNetTransaction = Convert.ToBoolean(objReader["IsNetTransaction"]);
                    oelVoucher.ClosingBalance = Validation.GetSafeDecimal(objReader["CustomerBalance"]);
                    oelVoucher.BillAmount = Validation.GetSafeDecimal(objReader["BillAmount"]);
                    oelVoucher.TotalFreight = Validation.GetSafeDecimal(objReader["TotalFreight"]);
                    oelVoucher.TotalDiscount = Validation.GetSafeDecimal(objReader["TotalDiscount"]);
                    oelVoucher.FlatDiscount = Validation.GetSafeDecimal(objReader["FlatDiscount"]);
                    oelVoucher.ExtraDiscount = Validation.GetSafeDecimal(objReader["ExtraDiscount"]);
                    oelVoucher.BillAmountAfterDiscount = Validation.GetSafeDecimal(objReader["BillAmountAfterDiscount"]);
                    oelVoucher.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                    oelVoucher.VAT = Validation.GetSafeDecimal(objReader["VAT"]);
                    oelVoucher.VATAmount = Validation.GetSafeDecimal(objReader["VATTotalAmount"]);
                    oelVoucher.TotalItems = Validation.GetSafeDecimal(objReader["TotalItems"]);
                    oelVoucher.TaxPercentage = Validation.GetSafeDecimal(objReader["TaxPercentage"]);
                    oelVoucher.TotalTaxAmount = Validation.GetSafeDecimal(objReader["TotalTaxAmount"]);
                    oelVoucher.TotalAmountAfterTax = Validation.GetSafeDecimal(objReader["TotalAmountAfterTax"]);
                    oelVoucher.Transactiondays = Validation.GetSafeLong(objReader["CreditDays"]);
                    oelVoucher.IsRecieved = Validation.GetSafeBooleanNullable(objReader["IsRecieved"]);

                    oelVoucher.IsNetTransaction = Validation.GetSafeBooleanNullable(objReader["IsNetTransaction"]);
                    oelVoucher.IsImportTransaction = Validation.GetSafeBooleanNullable(objReader["IsImportTransaction"]);
                    oelVoucher.FreeVoucher = Validation.GetSafeDecimal(objReader["FreeVoucher"]);
                    oelVoucher.CardNo = Validation.GetSafeString(objReader["CardNo"]);
                    oelVoucher.PaymentType = Validation.GetSafeInteger(objReader["PaymentType"]);
                    oelVoucher.CashRecieved = Validation.GetSafeDecimal(objReader["CashRecieved"]);
                    oelVoucher.Balance = Validation.GetSafeDecimal(objReader["CashBalance"]);
                    oelVoucher.LoadingCharges = Validation.GetSafeDecimal(objReader["LoadingCharges"]);
                    oelVoucher.CuttingCharges = Validation.GetSafeDecimal(objReader["CuttingCharges"]);
                    oelVoucher.MiscCharges = Validation.GetSafeDecimal(objReader["MiscCharges"]);
                    oelVoucher.SystemWeight = Validation.GetSafeDecimal(objReader["SystemWeight"]);
                    oelVoucher.ManualWeight = Validation.GetSafeDecimal(objReader["ManualWeight"]);
                    oelVoucher.AutoWeight = Validation.GetSafeDecimal(objReader["AutoWeight"]);
                    oelVoucher.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);
                    oelVoucher.IsDeleted = Validation.GetSafeBooleanNullable(objReader["IsDeleted"]);

                    //// Getting SalesDetail Here...
                    oelVoucher.IdVoucherDetail = Validation.GetSafeLong(objReader["VoucherDetail_Id"]);
                    oelVoucher.IdItem = Validation.GetSafeLong(objReader["Item_Id"]);
                    oelVoucher.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelVoucher.AutoWeightItemIndex = Validation.GetSafeInteger(objReader["AutoWeightItemIndex"]);
                    oelVoucher.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                    oelVoucher.Discription = Validation.GetSafeString(objReader["Discription"]);
                    oelVoucher.TotalCartons = Validation.GetSafeLong(objReader["TotalCartons"]);
                    oelVoucher.BatchNo = Validation.GetSafeString(objReader["BatchNo"]);
                    oelVoucher.Expiry = Validation.GetSafeString(objReader["Expiry"]);
                    oelVoucher.EngineNo = Validation.GetSafeString(objReader["EngineNo"]);
                    oelVoucher.ChasisNo = Validation.GetSafeString(objReader["ChasisNo"]);
                    oelVoucher.VehicleNo = Validation.GetSafeString(objReader["VehicleNo"]);
                    oelVoucher.FirstIMEI = Validation.GetSafeString(objReader["FirstIMEI"]);
                    oelVoucher.SecondIMEI = Validation.GetSafeString(objReader["SecondIMEI"]);
                    oelVoucher.ColorCode = Validation.GetSafeInteger(objReader["ColorCode"]);
                    oelVoucher.CurrentStock = Validation.GetSafeDecimal(objReader["CurrentStock"]);
                    oelVoucher.Units = Validation.GetSafeDecimal(objReader["Units"]);
                    oelVoucher.Bonus = Validation.GetSafeDecimal(objReader["BonusUnits"]);
                    oelVoucher.ItemWeight = Validation.GetSafeDecimal(objReader["ItemWeight"]);
                    oelVoucher.UnitPrice = Validation.GetSafeDecimal(objReader["UnitPrice"]);
                    oelVoucher.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                    oelVoucher.Discount = Validation.GetSafeDecimal(objReader["DiscPercentage"]);
                    oelVoucher.DiscountAmount = Validation.GetSafeDecimal(objReader["DiscountAmount"]);
                    oelVoucher.PromoDiscount = Validation.GetSafeDecimal(objReader["PromoDiscountPercentage"]);
                    oelVoucher.NetSaleAmount = Validation.GetSafeDecimal(objReader["NetSaleAmount"]);
                    oelVoucher.LineDiscount = Validation.GetSafeDecimal(objReader["LineDiscount"]);
                    oelVoucher.NetSaleAmount = Validation.GetSafeDecimal(objReader["NetSaleAmount"]);

                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public List<VoucherDetailEL> GetSalesSubTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, bool IsNetTransaction, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetSalesSubTransactions]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;
                cmdVouchers.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
                cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                // cmdVouchers.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
                objReader = cmdVouchers.ExecuteReader();
                while (objReader.Read())
                {
                    VoucherDetailEL oelVoucher = new VoucherDetailEL();

                    oelVoucher.IdTransactionDetail = Validation.GetSafeLong(objReader["TransactionDetail_Id"]);
                    oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelVoucher.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelVoucher.Narration = Validation.GetSafeString(objReader["Narration"]);
                    oelVoucher.Debit = Validation.GetSafeDecimal(objReader["Debit"]);
                    oelVoucher.Credit = Validation.GetSafeDecimal(objReader["Credit"]);
                    oelVoucher.TrackNumber = Validation.GetSafeInteger(objReader["TrackNumber"]);
                    oelVoucher.CreatedDateTime = Validation.GetSafeNullableDateTime(objReader["Created_DateTime"]);


                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public DataSet GetRdlcSalesTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, bool IsNetTransaction, SqlConnection objConn)
        {
            SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetSalesTransactions]", objConn);
            DataSet objdataSet = new DataSet();
            cmdVouchers.CommandType = CommandType.StoredProcedure;
            cmdVouchers.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
            cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
            cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
            cmdVouchers.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
            SqlDataAdapter objDa = new SqlDataAdapter(cmdVouchers);
            objDa.Fill(objdataSet);
            return objdataSet;
        
        }
        public List<VoucherDetailEL> GetDistributionSalesTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetDistributionSalesTransactions]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;
                cmdVouchers.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
                cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                objReader = cmdVouchers.ExecuteReader();
                while (objReader.Read())
                {
                    //// Getting Purchases Voucher Header Here...
                    VoucherDetailEL oelVoucher = new VoucherDetailEL();
                    oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                    oelVoucher.SheetNo = Validation.GetSafeLong(objReader["SheetNo"]);
                    oelVoucher.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                    oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelVoucher.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                    oelVoucher.BiltyNo = Validation.GetSafeString(objReader["BiltyNo"]);
                    oelVoucher.SampleNo = Validation.GetSafeLong(objReader["SampleNo"]);
                    oelVoucher.FirstName = Validation.GetSafeString(objReader["PersonName"]);
                    oelVoucher.Contact = Validation.GetSafeString(objReader["PersonContact"]);
                    oelVoucher.Cnic = Validation.GetSafeString(objReader["PersonCNIC"]);
                    oelVoucher.Address = Validation.GetSafeString(objReader["PersonAddress"]);

                    oelVoucher.VDate = Convert.ToDateTime(objReader["VDate"]);
                    oelVoucher.DueDate = Validation.GetSafeDateTime(objReader["DueDate"]);
                    oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelVoucher.CashAccountNo = Validation.GetSafeString(objReader["CashAccountNo"]);
                    oelVoucher.SubAccountNo = Validation.GetSafeString(objReader["EmpCode"]);
                    oelVoucher.EmployeeAccountNo = Validation.GetSafeString(objReader["DeliveryEmployeeAccountNo"]);
                    oelVoucher.VDiscription = Validation.GetSafeString(objReader["VDiscription"]);
                    oelVoucher.OutWardGatePassNo = Validation.GetSafeString(objReader["OutWardGatePassNo"]);

                    oelVoucher.IsNetTransaction = Convert.ToBoolean(objReader["IsNetTransaction"]);
                    oelVoucher.ClosingBalance = Validation.GetSafeDecimal(objReader["CustomerBalance"]);
                    oelVoucher.BillAmount = Validation.GetSafeDecimal(objReader["BillAmount"]);
                    oelVoucher.TotalFreight = Validation.GetSafeDecimal(objReader["TotalFreight"]);
                    oelVoucher.ExtraDiscount = Validation.GetSafeDecimal(objReader["ExtraDiscount"]);
                    oelVoucher.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                    oelVoucher.VAT = Validation.GetSafeDecimal(objReader["VAT"]);
                    oelVoucher.VATAmount = Validation.GetSafeDecimal(objReader["VATTotalAmount"]);
                    oelVoucher.TotalItems = Validation.GetSafeDecimal(objReader["TotalItems"]);
                    oelVoucher.TaxPercentage = Validation.GetSafeDecimal(objReader["TaxPercentage"]);
                    oelVoucher.TotalTaxAmount = Validation.GetSafeDecimal(objReader["TotalTaxAmount"]);
                    oelVoucher.TotalAmountAfterTax = Validation.GetSafeDecimal(objReader["TotalAmountAfterTax"]);
                    oelVoucher.Transactiondays = Validation.GetSafeLong(objReader["CreditDays"]);
                    oelVoucher.IsRecieved = Validation.GetSafeBooleanNullable(objReader["IsRecieved"]);

                    oelVoucher.IsNetTransaction = Validation.GetSafeBooleanNullable(objReader["IsNetTransaction"]);
                    oelVoucher.IsImportTransaction = Validation.GetSafeBooleanNullable(objReader["IsImportTransaction"]);
                    oelVoucher.FreeVoucher = Validation.GetSafeDecimal(objReader["FreeVoucher"]);
                    oelVoucher.CardNo = Validation.GetSafeString(objReader["CardNo"]);
                    oelVoucher.PaymentType = Validation.GetSafeInteger(objReader["PaymentType"]);
                    oelVoucher.CashRecieved = Validation.GetSafeDecimal(objReader["CashRecieved"]);
                    oelVoucher.Balance = Validation.GetSafeDecimal(objReader["CashBalance"]);
                    oelVoucher.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);
                    oelVoucher.IsDeleted = Validation.GetSafeBooleanNullable(objReader["IsDeleted"]);

                    //// Getting SalesDetail Here...
                    oelVoucher.IdVoucherDetail = Validation.GetSafeLong(objReader["VoucherDetail_Id"]);
                    oelVoucher.IdItem = Validation.GetSafeLong(objReader["Item_Id"]);
                    oelVoucher.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelVoucher.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                    oelVoucher.Discription = Validation.GetSafeString(objReader["Discription"]);
                    oelVoucher.TotalCartons = Validation.GetSafeLong(objReader["TotalCartons"]);
                    oelVoucher.BatchNo = Validation.GetSafeString(objReader["BatchNo"]);
                    oelVoucher.Expiry = Validation.GetSafeString(objReader["Expiry"]);
                    oelVoucher.EngineNo = Validation.GetSafeString(objReader["EngineNo"]);
                    oelVoucher.ChasisNo = Validation.GetSafeString(objReader["ChasisNo"]);
                    oelVoucher.VehicleNo = Validation.GetSafeString(objReader["VehicleNo"]);
                    oelVoucher.FirstIMEI = Validation.GetSafeString(objReader["FirstIMEI"]);
                    oelVoucher.SecondIMEI = Validation.GetSafeString(objReader["SecondIMEI"]);
                    oelVoucher.ColorCode = Validation.GetSafeInteger(objReader["ColorCode"]);
                    oelVoucher.CurrentStock = Validation.GetSafeDecimal(objReader["CurrentStock"]);
                    oelVoucher.Units = Validation.GetSafeDecimal(objReader["Units"]);
                    oelVoucher.Bonus = Validation.GetSafeDecimal(objReader["BonusUnits"]);
                    oelVoucher.UnitPrice = Validation.GetSafeDecimal(objReader["UnitPrice"]);
                    oelVoucher.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                    oelVoucher.Discount = Validation.GetSafeDecimal(objReader["DiscPercentage"]);
                    oelVoucher.DiscountAmount = Validation.GetSafeDecimal(objReader["DiscountAmount"]);
                    oelVoucher.PromoDiscount = Validation.GetSafeDecimal(objReader["PromoDiscountPercentage"]);
                    oelVoucher.NetSaleAmount = Validation.GetSafeDecimal(objReader["NetSaleAmount"]);


                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public List<VoucherDetailEL> GetDistributionSalesTransactionsByNumber(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetDistributionSalesTransactionsByNumber]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;
                cmdVouchers.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
                cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                objReader = cmdVouchers.ExecuteReader();
                while (objReader.Read())
                {
                    //// Getting Purchases Voucher Header Here...
                    VoucherDetailEL oelVoucher = new VoucherDetailEL();
                    oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                    oelVoucher.SheetNo = Validation.GetSafeLong(objReader["SheetNo"]);
                    oelVoucher.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                    oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelVoucher.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                    oelVoucher.BiltyNo = Validation.GetSafeString(objReader["BiltyNo"]);
                    oelVoucher.SampleNo = Validation.GetSafeLong(objReader["SampleNo"]);
                    oelVoucher.FirstName = Validation.GetSafeString(objReader["PersonName"]);
                    oelVoucher.Contact = Validation.GetSafeString(objReader["PersonContact"]);
                    oelVoucher.Cnic = Validation.GetSafeString(objReader["PersonCNIC"]);
                    oelVoucher.Address = Validation.GetSafeString(objReader["PersonAddress"]);

                    oelVoucher.VDate = Convert.ToDateTime(objReader["VDate"]);
                    oelVoucher.DueDate = Validation.GetSafeDateTime(objReader["DueDate"]);
                    oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelVoucher.CashAccountNo = Validation.GetSafeString(objReader["CashAccountNo"]);
                    oelVoucher.SubAccountNo = Validation.GetSafeString(objReader["EmpCode"]);
                    oelVoucher.EmployeeAccountNo = Validation.GetSafeString(objReader["DeliveryEmployeeAccountNo"]);
                    oelVoucher.VDiscription = Validation.GetSafeString(objReader["VDiscription"]);
                    oelVoucher.OutWardGatePassNo = Validation.GetSafeString(objReader["OutWardGatePassNo"]);

                    oelVoucher.IsNetTransaction = Convert.ToBoolean(objReader["IsNetTransaction"]);
                    oelVoucher.ClosingBalance = Validation.GetSafeDecimal(objReader["CustomerBalance"]);
                    oelVoucher.BillAmount = Validation.GetSafeDecimal(objReader["BillAmount"]);
                    oelVoucher.TotalFreight = Validation.GetSafeDecimal(objReader["TotalFreight"]);
                    oelVoucher.ExtraDiscount = Validation.GetSafeDecimal(objReader["ExtraDiscount"]);
                    oelVoucher.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                    oelVoucher.VAT = Validation.GetSafeDecimal(objReader["VAT"]);
                    oelVoucher.VATAmount = Validation.GetSafeDecimal(objReader["VATTotalAmount"]);
                    oelVoucher.Transactiondays = Validation.GetSafeLong(objReader["CreditDays"]);
                    oelVoucher.IsRecieved = Validation.GetSafeBooleanNullable(objReader["IsRecieved"]);

                    oelVoucher.IsNetTransaction = Validation.GetSafeBooleanNullable(objReader["IsNetTransaction"]);
                    oelVoucher.IsImportTransaction = Validation.GetSafeBooleanNullable(objReader["IsImportTransaction"]);
                    oelVoucher.FreeVoucher = Validation.GetSafeDecimal(objReader["FreeVoucher"]);
                    oelVoucher.CardNo = Validation.GetSafeString(objReader["CardNo"]);
                    oelVoucher.PaymentType = Validation.GetSafeInteger(objReader["PaymentType"]);
                    oelVoucher.CashRecieved = Validation.GetSafeDecimal(objReader["CashRecieved"]);
                    oelVoucher.Balance = Validation.GetSafeDecimal(objReader["CashBalance"]);
                    oelVoucher.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);
                    oelVoucher.IsDeleted = Validation.GetSafeBooleanNullable(objReader["IsDeleted"]);

                    //// Getting SalesDetail Here...
                    oelVoucher.IdVoucherDetail = Validation.GetSafeLong(objReader["VoucherDetail_Id"]);
                    oelVoucher.IdItem = Validation.GetSafeLong(objReader["Item_Id"]);
                    oelVoucher.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelVoucher.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                    oelVoucher.Discription = Validation.GetSafeString(objReader["Discription"]);
                    oelVoucher.TotalCartons = Validation.GetSafeLong(objReader["TotalCartons"]);
                    oelVoucher.BatchNo = Validation.GetSafeString(objReader["BatchNo"]);
                    oelVoucher.Expiry = Validation.GetSafeString(objReader["Expiry"]);
                    oelVoucher.EngineNo = Validation.GetSafeString(objReader["EngineNo"]);
                    oelVoucher.ChasisNo = Validation.GetSafeString(objReader["ChasisNo"]);
                    oelVoucher.VehicleNo = Validation.GetSafeString(objReader["VehicleNo"]);
                    oelVoucher.FirstIMEI = Validation.GetSafeString(objReader["FirstIMEI"]);
                    oelVoucher.SecondIMEI = Validation.GetSafeString(objReader["SecondIMEI"]);
                    oelVoucher.ColorCode = Validation.GetSafeInteger(objReader["ColorCode"]);
                    oelVoucher.CurrentStock = Validation.GetSafeDecimal(objReader["CurrentStock"]);
                    oelVoucher.Units = Validation.GetSafeDecimal(objReader["Units"]);
                    oelVoucher.Bonus = Validation.GetSafeDecimal(objReader["BonusUnits"]);
                    oelVoucher.UnitPrice = Validation.GetSafeDecimal(objReader["UnitPrice"]);
                    oelVoucher.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                    oelVoucher.Discount = Validation.GetSafeDecimal(objReader["DiscPercentage"]);
                    oelVoucher.DiscountAmount = Validation.GetSafeDecimal(objReader["DiscountAmount"]);
                    oelVoucher.PromoDiscount = Validation.GetSafeDecimal(objReader["PromoDiscountPercentage"]);
                    oelVoucher.NetSaleAmount = Validation.GetSafeDecimal(objReader["NetSaleAmount"]);

                    list.Add(oelVoucher);
                }
            }
            return list;
        }       
        public List<VoucherDetailEL> GetDistributionSalesSubTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetDistributionSalesSubTransactions]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;
                cmdVouchers.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
                cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                objReader = cmdVouchers.ExecuteReader();
                while (objReader.Read())
                {
                    VoucherDetailEL oelVoucher = new VoucherDetailEL();

                    oelVoucher.IdTransactionDetail = Validation.GetSafeLong(objReader["TransactionDetail_Id"]);
                    oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelVoucher.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelVoucher.Narration = Validation.GetSafeString(objReader["Narration"]);
                    oelVoucher.Debit = Validation.GetSafeDecimal(objReader["Debit"]);
                    oelVoucher.Credit = Validation.GetSafeDecimal(objReader["Credit"]);
                    oelVoucher.TrackNumber = Validation.GetSafeInteger(objReader["TrackNumber"]);
                    oelVoucher.CreatedDateTime = Validation.GetSafeNullableDateTime(objReader["Created_DateTime"]);


                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public List<VouchersEL> GetCustomersSalesUnpostedVouchers(Int64 IdProject, Int64 BookNo, string AccountNo, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            using (SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetCustomersSalesUnpostedVouchers]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdSales.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdSales.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    VouchersEL oelVoucher = new VouchersEL();
                    oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public bool DeleteSalesByVoucher(Int64 IdVoucher, Int64 IdProject, SqlConnection objConn)
        {
            using (SqlTransaction objTran = objConn.BeginTransaction())
            {
                try
                {
                    SqlCommand cmdDeleteSales = new SqlCommand("[Transactions].[Proc_DeleteSalesByVoucher]", objConn);
                    cmdDeleteSales.CommandType = CommandType.StoredProcedure;
                    cmdDeleteSales.Transaction = objTran;
                    cmdDeleteSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                    cmdDeleteSales.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
                    cmdDeleteSales.ExecuteNonQuery();

                    objTran.Commit();
                }
                catch (Exception ex)
                {
                    objTran.Rollback();
                    throw ex;
                }
            }
            return true;
        }
        #endregion
        #region Sales Return Related Methods Only
        public Int64 GetMaxSalesReturnInvoiceNumberBySaleReturnType(Int64 IdProject, Int64 BookNo, bool IsNetTransaction, int SaleType, SqlConnection objConn)
        {
            using (SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetMaxSalesReturnInvoiceNumber]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdSales.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                //cmdSales.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
                //cmdSales.Parameters.Add("@SaleType", SqlDbType.Bit).Value = SaleType;
                return Validation.GetSafeLong(cmdSales.ExecuteScalar());
            }
        }
        public EntityoperationInfo InsertSalesReturn(VouchersEL oelVoucher, List<VoucherDetailEL> oelSaleCollection, List<VoucherDetailEL> oelSalesReturnTransactionsCollection, SqlConnection objConn)
        {
            EntityoperationInfo info = new EntityoperationInfo();
            lock (this)
            {
                SqlTransaction objTran = objConn.BeginTransaction();

                try
                {
                    //// Insert SalesReturn Voucher
                    SqlCommand cmdSales = new SqlCommand("", objConn);
                    if (oelVoucher.SoftwareType == "Distribution Trading")
                    {
                        cmdSales.CommandText = "[Transactions].[Proc_CreateDistributionSalesReturnHead]";
                    }
                    else
                        cmdSales.CommandText = "[Transactions].[Proc_CreateSalesReturnHead]";

                    cmdSales.CommandType = CommandType.StoredProcedure;
                    cmdSales.Transaction = objTran;
                    cmdSales.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelVoucher.IdVoucher;
                    cmdSales.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelVoucher.IdProject;
                    cmdSales.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelVoucher.IdUser;
                    cmdSales.Parameters.Add(new SqlParameter("@IdEditedUser", DbType.Int64)).Value = oelVoucher.EditedByUserId;
                    cmdSales.Parameters.Add(new SqlParameter("@IdPostedUser", DbType.Int64)).Value = oelVoucher.PostedByUserId;
                    cmdSales.Parameters.Add(new SqlParameter("@SheetNo", DbType.String)).Value = oelVoucher.SheetNo;
                    cmdSales.Parameters.Add(new SqlParameter("@BookNo", DbType.String)).Value = oelVoucher.BookNo;
                    cmdSales.Parameters.Add(new SqlParameter("@InvoiceNo", DbType.Int64)).Value = oelVoucher.InvoiceNo;
                    cmdSales.Parameters.Add(new SqlParameter("@TerminalNo", DbType.Int64)).Value = oelVoucher.TerminalNumber;
                    cmdSales.Parameters.Add(new SqlParameter("@BiltyNo", DbType.String)).Value = oelVoucher.BiltyNo;
                    cmdSales.Parameters.Add(new SqlParameter("@VDate", DbType.DateTime)).Value = oelVoucher.VDate;
                    cmdSales.Parameters.Add(new SqlParameter("@EditedDateTime", DbType.DateTime)).Value = oelVoucher.EditedDateTime;
                    cmdSales.Parameters.Add(new SqlParameter("@PostedDateTime", DbType.DateTime)).Value = oelVoucher.PostedDateTime;
                    cmdSales.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucher.AccountNo;
                    if (oelVoucher.SoftwareType == "Distribution Trading")
                    {
                        cmdSales.Parameters.Add(new SqlParameter("@CashAccountNo", DbType.String)).Value = oelVoucher.CashAccountNo;
                    }
                    cmdSales.Parameters.Add(new SqlParameter("@TransactionAccountNo", DbType.String)).Value = oelVoucher.TransactionAccountNo;
                    cmdSales.Parameters.Add(new SqlParameter("@EmpCode", DbType.String)).Value = oelVoucher.SubAccountNo;
                    cmdSales.Parameters.Add(new SqlParameter("@DeliveryEmployeeAccountNo", DbType.String)).Value = oelVoucher.EmployeeAccountNo;
                    cmdSales.Parameters.Add(new SqlParameter("@VDiscription", DbType.String)).Value = oelVoucher.VDiscription;
                    cmdSales.Parameters.Add(new SqlParameter("@InwardGatePassNo", DbType.String)).Value = oelVoucher.InWardGatePassNo;
                    cmdSales.Parameters.Add(new SqlParameter("@OutWardGatePassNo", DbType.String)).Value = oelVoucher.OutWardGatePassNo;
                    cmdSales.Parameters.Add(new SqlParameter("@BillAmount", DbType.Decimal)).Value = oelVoucher.BillAmount;
                    cmdSales.Parameters.Add(new SqlParameter("@TotalFreight", DbType.Decimal)).Value = oelVoucher.TotalFreight;
                    cmdSales.Parameters.Add(new SqlParameter("@TotalAmount", DbType.Decimal)).Value = oelVoucher.TotalAmount;
                    cmdSales.Parameters.Add(new SqlParameter("@VAT", DbType.Decimal)).Value = oelVoucher.VAT;
                    cmdSales.Parameters.Add(new SqlParameter("@VATTotalAmount", DbType.Decimal)).Value = oelVoucher.VATAmount;
                    cmdSales.Parameters.Add(new SqlParameter("@TotalItems", DbType.Decimal)).Value = oelVoucher.TotalItems;
                    cmdSales.Parameters.Add(new SqlParameter("@TaxPercentage", DbType.Decimal)).Value = oelVoucher.TaxPercentage;
                    cmdSales.Parameters.Add(new SqlParameter("@TotalTaxAmount", DbType.Decimal)).Value = oelVoucher.TotalTaxAmount;
                    cmdSales.Parameters.Add(new SqlParameter("@TotalAmountAfterTax", DbType.Decimal)).Value = oelVoucher.TotalAmountAfterTax;
                    cmdSales.Parameters.Add(new SqlParameter("@IsNetTransaction", DbType.Boolean)).Value = oelVoucher.IsNetTransaction;
                    cmdSales.Parameters.Add(new SqlParameter("@IsImportTransaction", DbType.Boolean)).Value = oelVoucher.IsImportTransaction;
                    cmdSales.Parameters.Add(new SqlParameter("@IdStockAdjustmentType", DbType.Boolean)).Value = oelVoucher.IdStockAdjustmentType;
                    cmdSales.Parameters.Add(new SqlParameter("@SystemWeight", DbType.Decimal)).Value = oelVoucher.SystemWeight;
                    cmdSales.Parameters.Add(new SqlParameter("@ManualWeight", DbType.Decimal)).Value = oelVoucher.ManualWeight;
                    cmdSales.Parameters.Add(new SqlParameter("@AutoWeight", DbType.Decimal)).Value = oelVoucher.AutoWeight;
                    cmdSales.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;
                    Identity = Validation.GetSafeLong(cmdSales.ExecuteScalar());

                    //// Insert SalesReturn In SaleReturn Record
                    dal.InsertSalesReturnDetail(oelSaleCollection, Identity, objConn, objTran);

                    info.VoucherNo = GetReturnInvoiceNumber(Identity.Value, oelVoucher.IdProject.Value, oelVoucher.BookNo, objConn, objTran);

                    dal.InsertSalesTransactionsDetail(oelSalesReturnTransactionsCollection, Identity, info.VoucherNo.ToString(), objConn, objTran);

                    objTran.Commit();

                    info.IntID = Identity.Value;
                    info.IsSuccess = true;
                    return info;
                }
                catch (Exception ex)
                {
                    objTran.Rollback();
                    throw ex;
                }
            }
        }
        public EntityoperationInfo UpdateSalesReturn(VouchersEL oelVoucher, List<VoucherDetailEL> oelSaleCollection, List<VoucherDetailEL> oelSalesReturnTransactionsCollection, SqlConnection objConn)
        {
            EntityoperationInfo info = new EntityoperationInfo();
            lock (this)
            {
                SqlTransaction objTran = objConn.BeginTransaction();
                try
                {
                    SqlCommand cmdSales = new SqlCommand("", objConn);
                    if (oelVoucher.SoftwareType == "Distribution Trading")
                    {
                        cmdSales.CommandText = "[Transactions].[Proc_UpdateDistributionSalesReturnHead]";
                    }
                    else
                    {
                        cmdSales.CommandText = "[Transactions].[Proc_UpdateSalesReturnHead]";
                    }
                    cmdSales.CommandType = CommandType.StoredProcedure;
                    cmdSales.Transaction = objTran;

                    cmdSales.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelVoucher.IdVoucher;
                    cmdSales.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelVoucher.IdProject;
                    cmdSales.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelVoucher.IdUser;
                    cmdSales.Parameters.Add(new SqlParameter("@IdEditedUser", DbType.Int64)).Value = oelVoucher.EditedByUserId;
                    cmdSales.Parameters.Add(new SqlParameter("@IdPostedUser", DbType.Int64)).Value = oelVoucher.PostedByUserId;
                    cmdSales.Parameters.Add(new SqlParameter("@SheetNo", DbType.String)).Value = oelVoucher.SheetNo;
                    cmdSales.Parameters.Add(new SqlParameter("@BookNo", DbType.String)).Value = oelVoucher.BookNo;
                    cmdSales.Parameters.Add(new SqlParameter("@InvoiceNo", DbType.Int64)).Value = oelVoucher.InvoiceNo;
                    cmdSales.Parameters.Add(new SqlParameter("@TerminalNo", DbType.Int64)).Value = oelVoucher.TerminalNumber;
                    cmdSales.Parameters.Add(new SqlParameter("@BiltyNo", DbType.String)).Value = oelVoucher.BiltyNo;
                    cmdSales.Parameters.Add(new SqlParameter("@VDate", DbType.DateTime)).Value = oelVoucher.VDate;
                    cmdSales.Parameters.Add(new SqlParameter("@EditedDateTime", DbType.DateTime)).Value = oelVoucher.EditedDateTime;
                    cmdSales.Parameters.Add(new SqlParameter("@PostedDateTime", DbType.DateTime)).Value = oelVoucher.PostedDateTime;
                    cmdSales.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucher.AccountNo;
                    if (oelVoucher.SoftwareType == "Distribution Trading")
                    {
                        cmdSales.Parameters.Add(new SqlParameter("@CashAccountNo", DbType.String)).Value = oelVoucher.CashAccountNo;
                    }
                    cmdSales.Parameters.Add(new SqlParameter("@TransactionAccountNo", DbType.String)).Value = oelVoucher.TransactionAccountNo;
                    cmdSales.Parameters.Add(new SqlParameter("@EmpCode", DbType.String)).Value = oelVoucher.SubAccountNo;
                    cmdSales.Parameters.Add(new SqlParameter("@DeliveryEmployeeAccountNo", DbType.String)).Value = oelVoucher.EmployeeAccountNo;
                    cmdSales.Parameters.Add(new SqlParameter("@VDiscription", DbType.String)).Value = oelVoucher.VDiscription;
                    cmdSales.Parameters.Add(new SqlParameter("@InwardGatePassNo", DbType.String)).Value = oelVoucher.InWardGatePassNo;
                    cmdSales.Parameters.Add(new SqlParameter("@OutWardGatePassNo", DbType.String)).Value = oelVoucher.OutWardGatePassNo;
                    cmdSales.Parameters.Add(new SqlParameter("@BillAmount", DbType.Decimal)).Value = oelVoucher.BillAmount;
                    cmdSales.Parameters.Add(new SqlParameter("@TotalFreight", DbType.Decimal)).Value = oelVoucher.TotalFreight;
                    cmdSales.Parameters.Add(new SqlParameter("@TotalAmount", DbType.Decimal)).Value = oelVoucher.TotalAmount;
                    cmdSales.Parameters.Add(new SqlParameter("@VAT", DbType.Decimal)).Value = oelVoucher.VAT;
                    cmdSales.Parameters.Add(new SqlParameter("@VATTotalAmount", DbType.Decimal)).Value = oelVoucher.VATAmount;
                    cmdSales.Parameters.Add(new SqlParameter("@TotalItems", DbType.Decimal)).Value = oelVoucher.TotalItems;
                    cmdSales.Parameters.Add(new SqlParameter("@TaxPercentage", DbType.Decimal)).Value = oelVoucher.TaxPercentage;
                    cmdSales.Parameters.Add(new SqlParameter("@TotalTaxAmount", DbType.Decimal)).Value = oelVoucher.TotalTaxAmount;
                    cmdSales.Parameters.Add(new SqlParameter("@TotalAmountAfterTax", DbType.Decimal)).Value = oelVoucher.TotalAmountAfterTax;
                    cmdSales.Parameters.Add(new SqlParameter("@IsNetTransaction", DbType.Boolean)).Value = oelVoucher.IsNetTransaction;
                    cmdSales.Parameters.Add(new SqlParameter("@IsImportTransaction", DbType.Boolean)).Value = oelVoucher.IsImportTransaction;
                    cmdSales.Parameters.Add(new SqlParameter("@IdStockAdjustmentType", DbType.Boolean)).Value = oelVoucher.IdStockAdjustmentType;
                    cmdSales.Parameters.Add(new SqlParameter("@SystemWeight", DbType.Decimal)).Value = oelVoucher.SystemWeight;
                    cmdSales.Parameters.Add(new SqlParameter("@ManualWeight", DbType.Decimal)).Value = oelVoucher.ManualWeight;
                    cmdSales.Parameters.Add(new SqlParameter("@AutoWeight", DbType.Decimal)).Value = oelVoucher.AutoWeight;
                    cmdSales.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;
                    cmdSales.ExecuteNonQuery();

                    //// Insert And Update Sales In Sale Record
                    dal.UpdateSalesReturnDetail(oelSaleCollection, objConn, objTran);

                    dal.UpdateSalesTransactionsDetail(oelSalesReturnTransactionsCollection, objConn, objTran);

                    objTran.Commit();

                    info.IntID = oelVoucher.IdVoucher.Value;
                    info.IsSuccess = true;
                    return info;
                }
                catch (Exception ex)
                {
                    objTran.Rollback();
                    throw ex;
                }
            }
        }
        public Int64 GetReturnInvoiceNumber(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, SqlConnection objConn, SqlTransaction objTran)
        {
            SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetReturnInvoiceNumberByVoucher]", objConn, objTran);
            cmdSales.CommandType = CommandType.StoredProcedure;
            cmdSales.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
            cmdSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
            cmdSales.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
            return Validation.GetSafeLong(cmdSales.ExecuteScalar());
        }
        public List<VoucherDetailEL> GetSalesReturnTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, bool? IsNetTransaction, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetSalesReturnTransactions]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;
                cmdVouchers.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
                cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                //cmdVouchers.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
                objReader = cmdVouchers.ExecuteReader();
                while (objReader.Read())
                {
                    //// Getting Purchases Voucher Header Here...
                    VoucherDetailEL oelVoucher = new VoucherDetailEL();
                    oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                    oelVoucher.SheetNo = Validation.GetSafeLong(objReader["SheetNo"]);
                    oelVoucher.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                    oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelVoucher.InvoiceNo = Validation.GetSafeLong(objReader["InvoiceNo"]);
                    oelVoucher.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                    //oelVoucher.BillNo = Validation.GetSafeString(objReader["BillNo"]);
                    oelVoucher.BiltyNo = Validation.GetSafeString(objReader["BiltyNo"]);
                    //oelVoucher.SampleNo = Validation.GetSafeLong(objReader["SampleNo"]);
                    //oelVoucher.FirstName = Validation.GetSafeString(objReader["PersonName"]);
                    //oelVoucher.Contact = Validation.GetSafeString(objReader["PersonContact"]);
                    //oelVoucher.Cnic = Validation.GetSafeString(objReader["PersonCNIC"]);
                    //oelVoucher.Address = Validation.GetSafeString(objReader["PersonAddress"]);

                    oelVoucher.VDate = Convert.ToDateTime(objReader["VDate"]);
                    oelVoucher.EditedDateTime = Validation.GetSafeNullableDateTime(objReader["EditedDateTime"]);
                    oelVoucher.PostedDateTime = Validation.GetSafeNullableDateTime(objReader["PostedDateTime"]);
                    oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelVoucher.TransactionAccountNo = Validation.GetSafeString(objReader["TransactionAccountNo"]);
                    oelVoucher.SubAccountNo = Validation.GetSafeString(objReader["EmpCode"]);
                    oelVoucher.EmployeeAccountNo = Validation.GetSafeString(objReader["DeliveryEmployeeAccountNo"]);
                    oelVoucher.VDiscription = Validation.GetSafeString(objReader["VDiscription"]);
                    oelVoucher.InWardGatePassNo = Validation.GetSafeString(objReader["InWardGatePassNo"]);
                    oelVoucher.OutWardGatePassNo = Validation.GetSafeString(objReader["OutWardGatePassNo"]);

                    oelVoucher.IsNetTransaction = Convert.ToBoolean(objReader["IsNetTransaction"]);
                    oelVoucher.BillAmount = Validation.GetSafeDecimal(objReader["BillAmount"]);
                    oelVoucher.TotalFreight = Validation.GetSafeDecimal(objReader["TotalFreight"]);
                    oelVoucher.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                    oelVoucher.VAT = Validation.GetSafeDecimal(objReader["VAT"]);
                    oelVoucher.VATAmount = Validation.GetSafeDecimal(objReader["VATTotalAmount"]);
                    oelVoucher.TotalItems = Validation.GetSafeDecimal(objReader["TotalItems"]);
                    oelVoucher.TaxPercentage = Validation.GetSafeDecimal(objReader["TaxPercentage"]);
                    oelVoucher.TotalTaxAmount = Validation.GetSafeDecimal(objReader["TotalTaxAmount"]);
                    oelVoucher.TotalAmountAfterTax = Validation.GetSafeDecimal(objReader["TotalAmountAfterTax"]);
                    //oelVoucher.Transactiondays = Validation.GetSafeLong(objReader["CreditDays"]);
                    //oelVoucher.IsRecieved = Validation.GetSafeBooleanNullable(objReader["IsRecieved"]);

                    oelVoucher.IsNetTransaction = Validation.GetSafeBooleanNullable(objReader["IsNetTransaction"]);
                    oelVoucher.IsImportTransaction = Validation.GetSafeBooleanNullable(objReader["IsImportTransaction"]);
                    oelVoucher.IdStockAdjustmentType = Validation.GetSafeLong(objReader["StockAdjustmentType_Id"]);
                    oelVoucher.SystemWeight = Validation.GetSafeDecimal(objReader["SystemWeight"]);
                    oelVoucher.ManualWeight = Validation.GetSafeDecimal(objReader["ManualWeight"]);
                    oelVoucher.AutoWeight = Validation.GetSafeDecimal(objReader["AutoWeight"]);
                    oelVoucher.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);
                    oelVoucher.IsDeleted = Validation.GetSafeBooleanNullable(objReader["IsDeleted"]);

                    //// Getting SalesDetail Here...
                    oelVoucher.IdVoucherDetail = Validation.GetSafeLong(objReader["VoucherDetail_Id"]);
                    oelVoucher.IdItem = Validation.GetSafeLong(objReader["Item_Id"]);
                    oelVoucher.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelVoucher.AutoWeightItemIndex = Validation.GetSafeInteger(objReader["AutoWeightItemIndex"]);
                    oelVoucher.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                    oelVoucher.Discription = Validation.GetSafeString(objReader["Discription"]);
                    oelVoucher.TotalCartons = Validation.GetSafeLong(objReader["TotalCartons"]);
                    oelVoucher.BatchNo = Validation.GetSafeString(objReader["BatchNo"]);
                    oelVoucher.Expiry = Validation.GetSafeString(objReader["Expiry"]);
                    oelVoucher.EngineNo = Validation.GetSafeString(objReader["EngineNo"]);
                    oelVoucher.ChasisNo = Validation.GetSafeString(objReader["ChasisNo"]);
                    oelVoucher.VehicleNo = Validation.GetSafeString(objReader["VehicleNo"]);
                    oelVoucher.FirstIMEI = Validation.GetSafeString(objReader["FirstIMEI"]);
                    oelVoucher.SecondIMEI = Validation.GetSafeString(objReader["SecondIMEI"]);
                    oelVoucher.ColorCode = Validation.GetSafeInteger(objReader["ColorCode"]);
                    //oelVoucher.CurrentStock = Validation.GetSafeLong(objReader["CurrentStock"]);
                    oelVoucher.Units = Validation.GetSafeDecimal(objReader["Units"]);
                    oelVoucher.ItemWeight = Validation.GetSafeDecimal(objReader["ItemWeight"]);
                    oelVoucher.UnitPrice = Validation.GetSafeDecimal(objReader["UnitPrice"]);
                    oelVoucher.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                    //oelVoucher.Discount = Validation.GetSafeLong(objReader["DiscPercentage"]);
                    //oelVoucher.DiscountAmount = Validation.GetSafeLong(objReader["DiscountAmount"]);


                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public List<VoucherDetailEL> GetSalesReturnTransactionsByNumber(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, bool? IsNetTransaction, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetSalesReturnTransactionsByNumber]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;
                cmdVouchers.Parameters.Add("@VoucherNo", SqlDbType.BigInt).Value = IdVoucher;
                cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                //cmdVouchers.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
                objReader = cmdVouchers.ExecuteReader();
                while (objReader.Read())
                {
                    //// Getting Purchases Voucher Header Here...
                    VoucherDetailEL oelVoucher = new VoucherDetailEL();
                    oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                    oelVoucher.SheetNo = Validation.GetSafeLong(objReader["SheetNo"]);
                    oelVoucher.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                    oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelVoucher.InvoiceNo = Validation.GetSafeLong(objReader["InvoiceNo"]);
                    oelVoucher.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                    //oelVoucher.BillNo = Validation.GetSafeString(objReader["BillNo"]);
                    oelVoucher.BiltyNo = Validation.GetSafeString(objReader["BiltyNo"]);
                    //oelVoucher.SampleNo = Validation.GetSafeLong(objReader["SampleNo"]);
                    //oelVoucher.FirstName = Validation.GetSafeString(objReader["PersonName"]);
                    //oelVoucher.Contact = Validation.GetSafeString(objReader["PersonContact"]);
                    //oelVoucher.Cnic = Validation.GetSafeString(objReader["PersonCNIC"]);
                    //oelVoucher.Address = Validation.GetSafeString(objReader["PersonAddress"]);

                    oelVoucher.VDate = Convert.ToDateTime(objReader["VDate"]);
                    oelVoucher.EditedDateTime = Validation.GetSafeNullableDateTime(objReader["EditedDateTime"]);
                    oelVoucher.PostedDateTime = Validation.GetSafeNullableDateTime(objReader["PostedDateTime"]);
                    oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelVoucher.TransactionAccountNo = Validation.GetSafeString(objReader["TransactionAccountNo"]);
                    oelVoucher.SubAccountNo = Validation.GetSafeString(objReader["EmpCode"]);
                    oelVoucher.EmployeeAccountNo = Validation.GetSafeString(objReader["DeliveryEmployeeAccountNo"]);
                    oelVoucher.VDiscription = Validation.GetSafeString(objReader["VDiscription"]);
                    oelVoucher.InWardGatePassNo = Validation.GetSafeString(objReader["InWardGatePassNo"]);
                    oelVoucher.OutWardGatePassNo = Validation.GetSafeString(objReader["OutWardGatePassNo"]);

                    oelVoucher.IsNetTransaction = Convert.ToBoolean(objReader["IsNetTransaction"]);
                    oelVoucher.BillAmount = Validation.GetSafeDecimal(objReader["BillAmount"]);
                    oelVoucher.TotalFreight = Validation.GetSafeDecimal(objReader["TotalFreight"]);
                    oelVoucher.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                    oelVoucher.VAT = Validation.GetSafeDecimal(objReader["VAT"]);
                    oelVoucher.VATAmount = Validation.GetSafeDecimal(objReader["VATTotalAmount"]);
                    oelVoucher.TotalItems = Validation.GetSafeDecimal(objReader["TotalItems"]);
                    oelVoucher.TaxPercentage = Validation.GetSafeDecimal(objReader["TaxPercentage"]);
                    oelVoucher.TotalTaxAmount = Validation.GetSafeDecimal(objReader["TotalTaxAmount"]);
                    oelVoucher.TotalAmountAfterTax = Validation.GetSafeDecimal(objReader["TotalAmountAfterTax"]);
                    //oelVoucher.Transactiondays = Validation.GetSafeLong(objReader["CreditDays"]);
                    //oelVoucher.IsRecieved = Validation.GetSafeBooleanNullable(objReader["IsRecieved"]);

                    oelVoucher.IsNetTransaction = Validation.GetSafeBooleanNullable(objReader["IsNetTransaction"]);
                    oelVoucher.IsImportTransaction = Validation.GetSafeBooleanNullable(objReader["IsImportTransaction"]);
                    oelVoucher.IdStockAdjustmentType = Validation.GetSafeLong(objReader["StockAdjustmentType_Id"]);
                    oelVoucher.SystemWeight = Validation.GetSafeDecimal(objReader["SystemWeight"]);
                    oelVoucher.ManualWeight = Validation.GetSafeDecimal(objReader["ManualWeight"]);
                    oelVoucher.AutoWeight = Validation.GetSafeDecimal(objReader["AutoWeight"]);
                    oelVoucher.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);
                    oelVoucher.IsDeleted = Validation.GetSafeBooleanNullable(objReader["IsDeleted"]);

                    //// Getting SalesDetail Here...
                    oelVoucher.IdVoucherDetail = Validation.GetSafeLong(objReader["VoucherDetail_Id"]);
                    oelVoucher.IdItem = Validation.GetSafeLong(objReader["Item_Id"]);
                    oelVoucher.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelVoucher.AutoWeightItemIndex = Validation.GetSafeInteger(objReader["AutoWeightItemIndex"]);
                    oelVoucher.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                    oelVoucher.Discription = Validation.GetSafeString(objReader["Discription"]);
                    oelVoucher.TotalCartons = Validation.GetSafeLong(objReader["TotalCartons"]);
                    oelVoucher.BatchNo = Validation.GetSafeString(objReader["BatchNo"]);
                    oelVoucher.Expiry = Validation.GetSafeString(objReader["Expiry"]);
                    oelVoucher.EngineNo = Validation.GetSafeString(objReader["EngineNo"]);
                    oelVoucher.ChasisNo = Validation.GetSafeString(objReader["ChasisNo"]);
                    oelVoucher.VehicleNo = Validation.GetSafeString(objReader["VehicleNo"]);
                    oelVoucher.FirstIMEI = Validation.GetSafeString(objReader["FirstIMEI"]);
                    oelVoucher.SecondIMEI = Validation.GetSafeString(objReader["SecondIMEI"]);
                    oelVoucher.ColorCode = Validation.GetSafeInteger(objReader["ColorCode"]);
                    //oelVoucher.CurrentStock = Validation.GetSafeLong(objReader["CurrentStock"]);
                    oelVoucher.Units = Validation.GetSafeDecimal(objReader["Units"]);
                    oelVoucher.ItemWeight = Validation.GetSafeDecimal(objReader["ItemWeight"]);
                    oelVoucher.UnitPrice = Validation.GetSafeDecimal(objReader["UnitPrice"]);
                    oelVoucher.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                    //oelVoucher.Discount = Validation.GetSafeLong(objReader["DiscPercentage"]);
                    //oelVoucher.DiscountAmount = Validation.GetSafeLong(objReader["DiscountAmount"]);


                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public List<VoucherDetailEL> GetSalesReturnTransactionsOnInvoiceBasis(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, bool? IsNetTransaction, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetSalesReturnTransactionsOnInvoiceBasis]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;
                cmdVouchers.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
                cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                //cmdVouchers.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
                objReader = cmdVouchers.ExecuteReader();
                while (objReader.Read())
                {
                    //// Getting Purchases Voucher Header Here...
                    VoucherDetailEL oelVoucher = new VoucherDetailEL();
                    oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                    oelVoucher.SheetNo = Validation.GetSafeLong(objReader["SheetNo"]);
                    oelVoucher.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                    oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelVoucher.InvoiceNo = Validation.GetSafeLong(objReader["InvoiceNo"]);
                    oelVoucher.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                    //oelVoucher.BillNo = Validation.GetSafeString(objReader["BillNo"]);
                    //oelVoucher.BiltyNo = Validation.GetSafeString(objReader["BiltyNo"]);
                    ////oelVoucher.SampleNo = Validation.GetSafeLong(objReader["SampleNo"]);
                    //oelVoucher.FirstName = Validation.GetSafeString(objReader["PersonName"]);
                    //oelVoucher.Contact = Validation.GetSafeString(objReader["PersonContact"]);
                    //oelVoucher.Cnic = Validation.GetSafeString(objReader["PersonCNIC"]);
                    //oelVoucher.Address = Validation.GetSafeString(objReader["PersonAddress"]);

                    //oelVoucher.VDate = Convert.ToDateTime(objReader["VDate"]);
                    //oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    //oelVoucher.CashAccountNo = Validation.GetSafeString(objReader["CashAccountNo"]);
                    //oelVoucher.SubAccountNo = Validation.GetSafeString(objReader["EmpCode"]);
                    //oelVoucher.EmployeeAccountNo = Validation.GetSafeString(objReader["DeliveryEmployeeAccountNo"]);
                    //oelVoucher.VDiscription = Validation.GetSafeString(objReader["VDiscription"]);
                    //oelVoucher.InWardGatePassNo = Validation.GetSafeString(objReader["InWardGatePassNo"]);
                    //oelVoucher.OutWardGatePassNo = Validation.GetSafeString(objReader["OutWardGatePassNo"]);

                    //oelVoucher.IsNetTransaction = Convert.ToBoolean(objReader["IsNetTransaction"]);
                    //oelVoucher.TotalAmount = Convert.ToInt64(objReader["TotalAmount"]);
                    //oelVoucher.VAT = Validation.GetSafeLong(objReader["VAT"]);
                    //oelVoucher.VATAmount = Validation.GetSafeLong(objReader["VATTotalAmount"]);
                    ////oelVoucher.Transactiondays = Validation.GetSafeLong(objReader["CreditDays"]);
                    ////oelVoucher.IsRecieved = Validation.GetSafeBooleanNullable(objReader["IsRecieved"]);

                    //oelVoucher.IsNetTransaction = Validation.GetSafeBooleanNullable(objReader["IsNetTransaction"]);
                    //oelVoucher.IsImportTransaction = Validation.GetSafeBooleanNullable(objReader["IsImportTransaction"]);
                    //oelVoucher.IdStockAdjustmentType = Validation.GetSafeLong(objReader["StockAdjustmentType_Id"]);
                    //oelVoucher.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);
                    //oelVoucher.IsDeleted = Validation.GetSafeBooleanNullable(objReader["IsDeleted"]);

                    ////// Getting SalesDetail Here...
                    //oelVoucher.IdVoucherDetail = Validation.GetSafeLong(objReader["VoucherDetail_Id"]);
                    //oelVoucher.IdItem = Validation.GetSafeLong(objReader["Item_Id"]);
                    //oelVoucher.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    //oelVoucher.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                    //oelVoucher.Discription = Validation.GetSafeString(objReader["Discription"]);
                    //oelVoucher.TotalCartons = Validation.GetSafeLong(objReader["TotalCartons"]);
                    //oelVoucher.BatchNo = Validation.GetSafeString(objReader["BatchNo"]);
                    //oelVoucher.Expiry = Validation.GetSafeString(objReader["Expiry"]);
                    //oelVoucher.EngineNo = Validation.GetSafeString(objReader["EngineNo"]);
                    //oelVoucher.ChasisNo = Validation.GetSafeString(objReader["ChasisNo"]);
                    //oelVoucher.VehicleNo = Validation.GetSafeString(objReader["VehicleNo"]);
                    //oelVoucher.FirstIMEI = Validation.GetSafeString(objReader["FirstIMEI"]);
                    //oelVoucher.SecondIMEI = Validation.GetSafeString(objReader["SecondIMEI"]);
                    //oelVoucher.ColorCode = Validation.GetSafeInteger(objReader["ColorCode"]);
                    ////oelVoucher.CurrentStock = Validation.GetSafeLong(objReader["CurrentStock"]);
                    //oelVoucher.Units = Validation.GetSafeDecimal(objReader["Units"]);
                    //oelVoucher.UnitPrice = Validation.GetSafeDecimal(objReader["UnitPrice"]);
                    //oelVoucher.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                    //oelVoucher.Discount = Validation.GetSafeLong(objReader["DiscPercentage"]);
                    //oelVoucher.DiscountAmount = Validation.GetSafeLong(objReader["DiscountAmount"]);


                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public List<VoucherDetailEL> GetSalesReturnSubTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, bool? IsNetTransaction, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetSalesReturnSubTransactions]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;
                cmdVouchers.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
                cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                //cmdVouchers.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
                objReader = cmdVouchers.ExecuteReader();
                while (objReader.Read())
                {
                    VoucherDetailEL oelVoucher = new VoucherDetailEL();

                    oelVoucher.IdTransactionDetail = Validation.GetSafeLong(objReader["TransactionDetail_Id"]);
                    oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelVoucher.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelVoucher.Narration = Validation.GetSafeString(objReader["Narration"]);
                    oelVoucher.Debit = Validation.GetSafeDecimal(objReader["Debit"]);
                    oelVoucher.Credit = Validation.GetSafeDecimal(objReader["Credit"]);
                    oelVoucher.TrackNumber = Validation.GetSafeInteger(objReader["TrackNumber"]);
                    oelVoucher.CreatedDateTime = Validation.GetSafeNullableDateTime(objReader["Created_DateTime"]);


                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public bool DeleteSalesReturnByVoucher(Int64 IdVoucher, Int64 IdProject, SqlConnection objConn)
        {
            using (SqlTransaction objTran = objConn.BeginTransaction())
            {
                try
                {
                    SqlCommand cmdDeleteSales = new SqlCommand("[Transactions].[Proc_DeleteSalesReturnByVoucher]", objConn);
                    cmdDeleteSales.CommandType = CommandType.StoredProcedure;
                    cmdDeleteSales.Transaction = objTran;
                    cmdDeleteSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                    cmdDeleteSales.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
                    cmdDeleteSales.ExecuteNonQuery();

                    objTran.Commit();
                }
                catch (Exception ex)
                {
                    objTran.Rollback();
                    throw ex;
                }
            }
            return true;
        }
        #endregion

        //public bool UpdateSales(VouchersEL oelSaleMaster,List<SaleDetailEL> oelSaleCollection, List<TransactionsEL> oelTransactionsCollection, List<StockReceiptEL> oelStockReceiptCollection, SqlConnection objConn)

        public bool UpdateSamplesHeadForSales(Int64? IdVoucher, bool IsSold, SqlConnection objConn)
        {
            try
            {
                SqlCommand cmdSample = new SqlCommand("[Transactions].[Proc_UpdateSampleHeadForSale]", objConn);
                cmdSample.CommandType = CommandType.StoredProcedure;

                cmdSample.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Guid)).Value = IdVoucher.Value;
                cmdSample.Parameters.Add(new SqlParameter("@IsSold", DbType.Boolean)).Value = IsSold;
                cmdSample.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

            }
            return true;


        }
        public bool CheckSales(Int64 IdCompnay, Int64 VoucherNo, SqlConnection objConn)
        {
            List<VouchersEL> oelSaleCollection = new List<VouchersEL>();
            bool IsExists = false;
            using (SqlCommand cmdCheckSales = new SqlCommand("[Transactions].[Proc_CheckSale]", objConn))
            {
                cmdCheckSales.CommandType = CommandType.StoredProcedure;

                cmdCheckSales.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = IdCompnay;
                cmdCheckSales.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = VoucherNo;

                IDataReader objReader = cmdCheckSales.ExecuteReader();
                while (objReader.Read())
                {
                    VouchersEL oelSaleMaster = new VouchersEL();
                    oelSaleMaster.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelSaleCollection.Add(oelSaleMaster);
                }
            }
            if (oelSaleCollection.Count > 0)
            {
                IsExists = true;
            }
            return IsExists;
        }
        public List<VouchersEL> GetSaleDays(Int64 IdCompany, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            using (SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetSaleDays]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    VouchersEL oelVoucher = new VouchersEL();
                    oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelVoucher.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelVoucher.Date = Convert.ToDateTime(objReader["VDate"]);
                    oelVoucher.Transactiondays = Validation.GetSafeInteger(objReader["CreditDays"]);
                    oelVoucher.RemainingDays = Validation.GetSafeInteger(objReader["RemainingDays"]);

                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public List<VouchersEL> GetSaleDaysByDate(Int64 IdCompany, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            using (SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetSaleDaysByDate]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdSales.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdSales.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    VouchersEL oelVoucher = new VouchersEL();
                    oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelVoucher.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelVoucher.Date = Convert.ToDateTime(objReader["VDate"]);
                    oelVoucher.Transactiondays = Validation.GetSafeInteger(objReader["CreditDays"]);
                    oelVoucher.RemainingDays = Validation.GetSafeInteger(objReader["RemainingDays"]);

                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public List<VouchersEL> GetSaleDaysByEmployees(Int64 IdCompany, string EmpCode, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            using (SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetSaleDaysByEmployee]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdSales.Parameters.Add("@EmpCode", SqlDbType.VarChar).Value = EmpCode;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    VouchersEL oelVoucher = new VouchersEL();
                    oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelVoucher.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelVoucher.Date = Convert.ToDateTime(objReader["VDate"]);
                    oelVoucher.Transactiondays = Validation.GetSafeInteger(objReader["CreditDays"]);
                    oelVoucher.RemainingDays = Validation.GetSafeInteger(objReader["RemainingDays"]);

                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public List<VouchersEL> GetSaleDaysByEmployeesByDate(Int64 IdCompany, string EmpCode, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            using (SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetSaleDaysByEmployeeByDate]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdSales.Parameters.Add("@EmpCode", SqlDbType.VarChar).Value = EmpCode;
                cmdSales.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdSales.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    VouchersEL oelVoucher = new VouchersEL();
                    oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelVoucher.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelVoucher.Date = Convert.ToDateTime(objReader["VDate"]);
                    oelVoucher.Transactiondays = Validation.GetSafeInteger(objReader["CreditDays"]);
                    oelVoucher.RemainingDays = Validation.GetSafeInteger(objReader["RemainingDays"]);

                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public List<VouchersEL> GetDateWiseSalesReport(Int64 IdProject, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            using (SqlCommand cmdSales = new SqlCommand("[Reports].[Proc_GetDateWiseSales]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdSales.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdSales.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    VouchersEL oelVoucher = new VouchersEL();
                    oelVoucher.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelVoucher.IsNetTransaction = Validation.GetSafeBooleanNullable(objReader["IsNetTransaction"]);
                    oelVoucher.TotalSales = Validation.GetSafeLong(objReader["TotalSales"]);
                    oelVoucher.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);

                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public List<VouchersEL> GetDateAndEmployeeWiseSalesReport(Int64 IdCompany, string EmpCode, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            using (SqlCommand cmdSales = new SqlCommand("[Reports].[Proc_GetDateAndEmployeeWiseSales]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.Parameters.Add("@IdCompany", SqlDbType.UniqueIdentifier).Value = IdCompany;
                cmdSales.Parameters.Add("@EmpCode", SqlDbType.UniqueIdentifier).Value = EmpCode;
                cmdSales.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdSales.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    VouchersEL oelVoucher = new VouchersEL();
                    oelVoucher.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelVoucher.TotalSales = Validation.GetSafeLong(objReader["TotalSales"]);
                    oelVoucher.TotalAmount = Validation.GetSafeDecimal(objReader["Amount"]);

                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public List<VouchersEL> GetDateWiseClaimReturnReport(Int64 IdProject, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            using (SqlCommand cmdSales = new SqlCommand("[Reports].[Proc_GetDateWiseClaimReturns]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdSales.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdSales.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    VouchersEL oelVoucher = new VouchersEL();
                    oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelVoucher.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelVoucher.TotalSalesReturn = Validation.GetSafeLong(objReader["TotalClaims"]);
                    oelVoucher.TotalAmount = Validation.GetSafeDecimal(objReader["Amount"]);

                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public List<VouchersEL> GetClaimedVouchersByAccountNo(Int64 IdCompany, string AccountNo, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            using (SqlCommand cmdSales = new SqlCommand("[Reports].[Proc_GetClaimedVouchersByAccountNo]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdSales.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    VouchersEL oelVoucher = new VouchersEL();
                    oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                    oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelVoucher.TotalAmount = Validation.GetSafeDecimal(objReader["Amount"]);

                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public List<VoucherDetailEL> GetClaimedVouchersDetail(Guid IdVoucher, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetClaimedVoucherDetail]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.Parameters.Add("@IdVoucher", SqlDbType.UniqueIdentifier).Value = IdVoucher;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    VoucherDetailEL oelVoucherDetail = new VoucherDetailEL();
                    oelVoucherDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelVoucherDetail.Units = Validation.GetSafeInteger(objReader["Units"]);
                    oelVoucherDetail.UnitPrice = Validation.GetSafeDecimal(objReader["UnitPrice"]);
                    //oelVoucherDetail.Discount = Validation.GetSafeDecimal(objReader["DisCount"]);
                    oelVoucherDetail.Amount = Validation.GetSafeDecimal(objReader["Amount"]);

                    list.Add(oelVoucherDetail);
                }
            }
            return list;
        }
    }
}
