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
    public class OutSourceWorkHeadDAL
    {
       #region Variables
       TransactionsDAL Tdal;
       OutSourceWorkDetailDAL WDal;
       ItemsDAL IDal;
       Int64? Identity;
       IDataReader objReader;
       public OutSourceWorkHeadDAL()
       {
           Tdal = new TransactionsDAL();
           WDal = new OutSourceWorkDetailDAL();
           IDal = new ItemsDAL();
       }
       #endregion
       #region OutSource Work Methods
       public Int64 GetMaxOutSourceWorkNumber(Int64 IdProject, Int64 BookNo, Int32 WorkType, SqlConnection objConn)
       {
           using (SqlCommand cmdWorkType = new SqlCommand("[Transactions].[Proc_GetMaxOutSourceWorkNumber]", objConn))
           {
               cmdWorkType.CommandType = CommandType.StoredProcedure;
               cmdWorkType.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
               cmdWorkType.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
               cmdWorkType.Parameters.Add("@WorkType", SqlDbType.BigInt).Value = WorkType;
               return Validation.GetSafeLong(cmdWorkType.ExecuteScalar());
           }
       }
       public EntityoperationInfo CreateOutSourceWork(VouchersEL oelVoucher, List<VoucherDetailEL> oelPurchaseCollection,List<VoucherDetailEL> oelPurchaseTransactionsCollection, SqlConnection objConn)
       {
           lock (this)
           {
               EntityoperationInfo infoResult = new EntityoperationInfo();
               SqlTransaction objTran = null;
               SqlCommand cmdOutSourceWork = new SqlCommand("[Transactions].[Proc_CreateOutSourceWorkHead]", objConn);

               try
               {
                   objTran = objConn.BeginTransaction();
                   cmdOutSourceWork.Transaction = objTran;
                   cmdOutSourceWork.CommandType = CommandType.StoredProcedure;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelVoucher.IdVoucher;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelVoucher.IdProject;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelVoucher.IdUser;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@IdOutSourceWorkType", DbType.Int64)).Value = oelVoucher.OutSourceWorkType;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@SheetNo", DbType.String)).Value = oelVoucher.SheetNo;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@BookNo", DbType.String)).Value = oelVoucher.BookNo;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@TerminalNo", DbType.Int64)).Value = oelVoucher.TerminalNumber;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@BiltyNo", DbType.String)).Value = oelVoucher.BiltyNo;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@VDate", DbType.DateTime)).Value = oelVoucher.VDate;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@VDueDate", DbType.DateTime)).Value = oelVoucher.DueDate;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucher.AccountNo;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@EmpCode", DbType.String)).Value = oelVoucher.SubAccountNo;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@BillNo", DbType.String)).Value = oelVoucher.BillNo;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@VDiscription", DbType.String)).Value = oelVoucher.Discription;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@BillAmount", DbType.Decimal)).Value = oelVoucher.BillAmount;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@TotalFreight", DbType.Decimal)).Value = oelVoucher.TotalFreight;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@TotalAmount", DbType.Decimal)).Value = oelVoucher.TotalAmount;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@VAT", DbType.Decimal)).Value = oelVoucher.VAT;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@VATTotalAmount", DbType.Decimal)).Value = oelVoucher.VATAmount;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@WorkType", DbType.Boolean)).Value = oelVoucher.OutSourceWork;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;
                   Identity = Validation.GetSafeLong(cmdOutSourceWork.ExecuteScalar());

                   // Insert Purchase Collection...
                   WDal.CreateOutSourceWorkRawMaterialDetail(oelPurchaseCollection, Identity, objConn, objTran);

                   infoResult.VoucherNo = GetOutSourceWorkNumber(Identity.Value, oelVoucher.IdProject.Value, oelVoucher.BookNo, objConn, objTran);


                   WDal.CreateOutSourceWorkTransactionsDetail(oelPurchaseTransactionsCollection, Identity, infoResult.VoucherNo.ToString(), objConn, objTran);


                   objTran.Commit();
                   infoResult.IntID = Identity.Value;
                   infoResult.IsSuccess = true;
               }
               catch (Exception ex)
               {
                   objTran.Rollback();
                   throw ex;
               }

               return infoResult;
           }
       }
       public EntityoperationInfo UpdateOutSourceWork(VouchersEL oelVoucher, List<VoucherDetailEL> oelPurchaseCollection,List<VoucherDetailEL> oelPurchaseTransactionsCollection, SqlConnection objConn)
       {
           lock (this)
           {
               EntityoperationInfo infoResult = new EntityoperationInfo();
               SqlTransaction objTran = null;
               SqlCommand cmdOutSourceWork = new SqlCommand("[Transactions].[Proc_UpdateOutSourceWorkHead]", objConn);
               try
               {
                   objTran = objConn.BeginTransaction();

                   cmdOutSourceWork.Transaction = objTran;
                   cmdOutSourceWork.CommandType = CommandType.StoredProcedure;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelVoucher.IdVoucher;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelVoucher.IdProject;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelVoucher.IdUser;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@IdOutSourceWorkType", DbType.Int64)).Value = oelVoucher.OutSourceWorkType;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@SheetNo", DbType.String)).Value = oelVoucher.SheetNo;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@BookNo", DbType.String)).Value = oelVoucher.BookNo;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@TerminalNo", DbType.Int64)).Value = oelVoucher.TerminalNumber;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@BiltyNo", DbType.String)).Value = oelVoucher.BiltyNo;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@VDate", DbType.DateTime)).Value = oelVoucher.VDate;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@VDueDate", DbType.DateTime)).Value = oelVoucher.DueDate;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucher.AccountNo;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@EmpCode", DbType.String)).Value = oelVoucher.SubAccountNo;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@BillNo", DbType.String)).Value = oelVoucher.BillNo;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@VDiscription", DbType.String)).Value = oelVoucher.Discription;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@BillAmount", DbType.Decimal)).Value = oelVoucher.BillAmount;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@TotalFreight", DbType.Decimal)).Value = oelVoucher.TotalFreight;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@TotalAmount", DbType.Decimal)).Value = oelVoucher.TotalAmount;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@VAT", DbType.Decimal)).Value = oelVoucher.VAT;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@VATTotalAmount", DbType.Decimal)).Value = oelVoucher.VATAmount;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@WorkType", DbType.Boolean)).Value = oelVoucher.OutSourceWork;
                   cmdOutSourceWork.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;

                   cmdOutSourceWork.ExecuteNonQuery();

                   // Insert Out Source Work Detail Collection...
                   WDal.UpdateOutSourceWorkDetail(oelPurchaseCollection, objConn, objTran);

                   WDal.UpdateOutSourceWorkTransactionsDetail(oelPurchaseTransactionsCollection, objConn, objTran);

                   // Insert Purchase Transactions...
                   //Tdal.UpdateTransactions(oelTransactionsCollection, objConn, objTran);

                   //IDal.UpdateEvaluationPrice(oelPurchaseCollection, objTran, objConn);

                   objTran.Commit();
                   infoResult.IsSuccess = true;
               }
               catch (Exception ex)
               {
                   objTran.Rollback();
                   throw ex;
               }

               return infoResult;
           }
       }
       public Int64 GetOutSourceWorkNumber(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, SqlConnection objConn, SqlTransaction objTran)
       {
           SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetOutSourceWorkNumberByVoucher]", objConn, objTran);
           cmdSales.CommandType = CommandType.StoredProcedure;
           cmdSales.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
           cmdSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
           cmdSales.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
           return Validation.GetSafeLong(cmdSales.ExecuteScalar());
       }
       public List<VoucherDetailEL> GetOutSourceWorkTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, int WorkType, SqlConnection objConn)
       {
           List<VoucherDetailEL> list = new List<VoucherDetailEL>();
           using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetPurchasesTransactions]", objConn))
           {
               cmdVouchers.CommandType = CommandType.StoredProcedure;
               cmdVouchers.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
               cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
               cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
               cmdVouchers.Parameters.Add("@WorkType", SqlDbType.Int).Value = WorkType;
               objReader = cmdVouchers.ExecuteReader();
               while (objReader.Read())
               {
                   //// Getting Purchases Voucher Header Here...
                   VoucherDetailEL oelVoucher = new VoucherDetailEL();
                   oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                   oelVoucher.OutSourceWorkType = Validation.GetSafeInteger(objReader["OutSourceWorkType_Id"]);
                   oelVoucher.SheetNo = Validation.GetSafeLong(objReader["SheetNo"]);
                   oelVoucher.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                   oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                   oelVoucher.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                   oelVoucher.BillNo = Validation.GetSafeString(objReader["BillNo"]);
                   oelVoucher.BiltyNo = Validation.GetSafeString(objReader["BiltyNo"]);

                   oelVoucher.VDate = Validation.GetSafeNullableDateTime(objReader["VDate"]);
                   oelVoucher.VDate = Validation.GetSafeNullableDateTime(objReader["VDueDate"]);
                   oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                   oelVoucher.VDiscription = Validation.GetSafeString(objReader["VDiscription"]);
                   oelVoucher.Posted = Convert.ToBoolean(objReader["Posted"]);
                   oelVoucher.BillAmount = Validation.GetSafeDecimal(objReader["BillAmount"]);
                   oelVoucher.TotalFreight = Validation.GetSafeDecimal(objReader["TotalFreight"]);
                   oelVoucher.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                   oelVoucher.VAT = Validation.GetSafeLong(objReader["VAT"]);
                   oelVoucher.VATAmount = Validation.GetSafeDecimal(objReader["VATTotalAmount"]);
                   oelVoucher.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);

                   //// Getting OutSource Work VoucherDetail Here...
                   oelVoucher.IdVoucherDetail = Validation.GetSafeLong(objReader["VoucherDetail_Id"]);
                   oelVoucher.IdItem = Validation.GetSafeLong(objReader["Item_Id"]);
                   oelVoucher.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                   oelVoucher.OutSourceWork = Validation.GetSafeInteger(objReader["ChildWorkType"]);
                   oelVoucher.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                   oelVoucher.CurrentStock = Validation.GetSafeDecimal(objReader["CurrentStock"]);
                   oelVoucher.Units = Validation.GetSafeDecimal(objReader["Units"]);
                   oelVoucher.UnitPrice = Validation.GetSafeDecimal(objReader["UnitPrice"]);
                   oelVoucher.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                   
                   list.Add(oelVoucher);
               }
           }
           return list;
       }
       public List<VoucherDetailEL> GetOutSourceWorkTransactionsByNumber(Int64 VoucherNo, Int64 IdProject, Int64 BookNo, int WorkType, SqlConnection objConn)
       {
           List<VoucherDetailEL> list = new List<VoucherDetailEL>();
           using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetOutSourceTransactionsByNumber]", objConn))
           {
               cmdVouchers.CommandType = CommandType.StoredProcedure;
               cmdVouchers.Parameters.Add("@VoucherNo", SqlDbType.BigInt).Value = VoucherNo;
               cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
               cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
               cmdVouchers.Parameters.Add("@WorkType", SqlDbType.Int).Value = WorkType;
               objReader = cmdVouchers.ExecuteReader();
               while (objReader.Read())
               {
                   //// Getting Purchases Voucher Header Here...
                   VoucherDetailEL oelVoucher = new VoucherDetailEL();
                   oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                   oelVoucher.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                   oelVoucher.OutSourceWorkType = Validation.GetSafeInteger(objReader["OutSourceWorkType_Id"]);
                   oelVoucher.SheetNo = Validation.GetSafeLong(objReader["SheetNo"]);
                   oelVoucher.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                   oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                   oelVoucher.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                   oelVoucher.BillNo = Validation.GetSafeString(objReader["BillNo"]);
                   oelVoucher.BiltyNo = Validation.GetSafeString(objReader["BiltyNo"]);

                   oelVoucher.VDate = Validation.GetSafeNullableDateTime(objReader["VDate"]);
                   oelVoucher.DueDate = Validation.GetSafeNullableDateTime(objReader["VDueDate"]);
                   oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                   oelVoucher.VDiscription = Validation.GetSafeString(objReader["VDiscription"]);
                   oelVoucher.Posted = Convert.ToBoolean(objReader["Posted"]);
                   oelVoucher.BillAmount = Validation.GetSafeDecimal(objReader["BillAmount"]);
                   oelVoucher.TotalFreight = Validation.GetSafeDecimal(objReader["TotalFreight"]);
                   oelVoucher.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                   oelVoucher.VAT = Validation.GetSafeDecimal(objReader["VAT"]);
                   oelVoucher.VATAmount = Validation.GetSafeDecimal(objReader["VATTotalAmount"]);
                   oelVoucher.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);

                   //// Getting OutSource Work VoucherDetail Here...
                   oelVoucher.IdVoucherDetail = Validation.GetSafeLong(objReader["VoucherDetail_Id"]);
                   oelVoucher.IdItem = Validation.GetSafeLong(objReader["Item_Id"]);
                   oelVoucher.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                   oelVoucher.OutSourceWork = Validation.GetSafeInteger(objReader["ChildWorkType"]);
                   oelVoucher.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                   oelVoucher.CurrentStock = Validation.GetSafeDecimal(objReader["CurrentStock"]);
                   oelVoucher.Units = Validation.GetSafeDecimal(objReader["Units"]);
                   oelVoucher.UnitPrice = Validation.GetSafeDecimal(objReader["UnitPrice"]);
                   oelVoucher.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                   
                   list.Add(oelVoucher);
               }
           }
           return list;
       }
       public List<VoucherDetailEL> GetOutSourceWorkSubTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, int WorkType, SqlConnection objConn)
       {
           List<VoucherDetailEL> list = new List<VoucherDetailEL>();
           using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetOutSourceWorkSubTransactions]", objConn))
           {
               cmdVouchers.CommandType = CommandType.StoredProcedure;
               cmdVouchers.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
               cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
               cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
               cmdVouchers.Parameters.Add("@WorkType", SqlDbType.Int).Value = WorkType;
               objReader = cmdVouchers.ExecuteReader();
               while (objReader.Read())
               {
                   VoucherDetailEL oelVoucher = new VoucherDetailEL();

                   //oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                   //oelVoucher.VoucherNo = Convert.ToInt64(objReader["VoucherNo"]);
                   //oelVoucher.Date = Convert.ToDateTime(objReader["VDate"]);

                   //oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                   //oelVoucher.VDiscription = Validation.GetSafeString(objReader["VDiscription"]);
                   //oelVoucher.IsNetPurchases = Convert.ToBoolean(objReader["IsNetPurchases"]);
                   //oelVoucher.Posted = Convert.ToBoolean(objReader["Posted"]);
                   //oelVoucher.TotalAmount = Convert.ToInt64(objReader["TotalAmount"]);

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
       public bool DeleteOutSourceWorkByVoucher(Int64 IdVoucher, Int64 IdProject, SqlConnection objConn)
       {
           using (SqlTransaction objTran = objConn.BeginTransaction())
           {
               try
               {
                   SqlCommand cmdDeletePurchases = new SqlCommand("[Transactions].[Proc_DeleteOutSourceWorkHeadByVoucher]", objConn);
                   cmdDeletePurchases.CommandType = CommandType.StoredProcedure;
                   cmdDeletePurchases.Transaction = objTran;
                   cmdDeletePurchases.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                   cmdDeletePurchases.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
                   cmdDeletePurchases.ExecuteNonQuery();

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
    }
}
