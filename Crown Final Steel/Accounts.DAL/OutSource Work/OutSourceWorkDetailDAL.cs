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
    public class OutSourceWorkDetailDAL
    {
        public bool CreateOutSourceWorkRawMaterialDetail(List<VoucherDetailEL> oelOutSourceWorkDetailCollection, Int64? Identity, SqlConnection objConn, SqlTransaction objTran)
        {
            SqlCommand cmdOutSourceWorkDetail = new SqlCommand("[Transactions].[Proc_CreateOutSourceWorkDetail]", objConn);
            cmdOutSourceWorkDetail.CommandType = CommandType.StoredProcedure;
            cmdOutSourceWorkDetail.Transaction = objTran;
            for (int i = 0; i < oelOutSourceWorkDetailCollection.Count; i++)
            {
                cmdOutSourceWorkDetail.Parameters.Add(new SqlParameter("@IdVoucherDetail", DbType.Int64)).Value = oelOutSourceWorkDetailCollection[i].IdVoucherDetail;
                cmdOutSourceWorkDetail.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = Identity;
                cmdOutSourceWorkDetail.Parameters.Add(new SqlParameter("@SeqNo", DbType.Int32)).Value = oelOutSourceWorkDetailCollection[i].SeqNo;
                cmdOutSourceWorkDetail.Parameters.Add(new SqlParameter("@IdItem", DbType.Int64)).Value = oelOutSourceWorkDetailCollection[i].IdItem;
                cmdOutSourceWorkDetail.Parameters.Add(new SqlParameter("@WorkType", DbType.Int64)).Value = oelOutSourceWorkDetailCollection[i].OutSourceWork;
                cmdOutSourceWorkDetail.Parameters.Add(new SqlParameter("@CurrentStock", DbType.Decimal)).Value = oelOutSourceWorkDetailCollection[i].CurrentStock;
                cmdOutSourceWorkDetail.Parameters.Add(new SqlParameter("@Units", DbType.Decimal)).Value = oelOutSourceWorkDetailCollection[i].Units;
                cmdOutSourceWorkDetail.Parameters.Add(new SqlParameter("@UnitPrice", DbType.Decimal)).Value = oelOutSourceWorkDetailCollection[i].UnitPrice;
                cmdOutSourceWorkDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelOutSourceWorkDetailCollection[i].Amount;
                cmdOutSourceWorkDetail.ExecuteNonQuery();
                cmdOutSourceWorkDetail.Parameters.Clear();

            }
            return true;
        }    
        public bool UpdateOutSourceWorkDetail(List<VoucherDetailEL> oelOutSourceWorkDetailCollection, SqlConnection objConn, SqlTransaction objTran)
        {
            SqlCommand cmdOutSourceWorkDetail = new SqlCommand();
            cmdOutSourceWorkDetail.CommandType = CommandType.StoredProcedure;
            cmdOutSourceWorkDetail.Connection = objConn;
            cmdOutSourceWorkDetail.Transaction = objTran;
            for (int i = 0; i < oelOutSourceWorkDetailCollection.Count; i++)
            {
                if (oelOutSourceWorkDetailCollection[i].IsNew)
                {
                    cmdOutSourceWorkDetail.CommandText = "[Transactions].[Proc_CreateOutSourceWorkDetail]";
                }
                else
                {
                    cmdOutSourceWorkDetail.CommandText = "[Transactions].[Proc_UpdateOutSourceWorkDetail]";
                }
                cmdOutSourceWorkDetail.Parameters.Add(new SqlParameter("@IdVoucherDetail", DbType.Int64)).Value = oelOutSourceWorkDetailCollection[i].IdVoucherDetail;
                cmdOutSourceWorkDetail.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelOutSourceWorkDetailCollection[i].IdVoucher;
                cmdOutSourceWorkDetail.Parameters.Add(new SqlParameter("@SeqNo", DbType.Int32)).Value = oelOutSourceWorkDetailCollection[i].SeqNo;
                cmdOutSourceWorkDetail.Parameters.Add(new SqlParameter("@IdItem", DbType.Int64)).Value = oelOutSourceWorkDetailCollection[i].IdItem;
                cmdOutSourceWorkDetail.Parameters.Add(new SqlParameter("@WorkType", DbType.Int64)).Value = oelOutSourceWorkDetailCollection[i].OutSourceWork;

                cmdOutSourceWorkDetail.Parameters.Add(new SqlParameter("@CurrentStock", DbType.Decimal)).Value = oelOutSourceWorkDetailCollection[i].CurrentStock;
                cmdOutSourceWorkDetail.Parameters.Add(new SqlParameter("@Units", DbType.Decimal)).Value = oelOutSourceWorkDetailCollection[i].Units;
                cmdOutSourceWorkDetail.Parameters.Add(new SqlParameter("@UnitPrice", DbType.Decimal)).Value = oelOutSourceWorkDetailCollection[i].UnitPrice;
                cmdOutSourceWorkDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelOutSourceWorkDetailCollection[i].Amount;

                cmdOutSourceWorkDetail.ExecuteNonQuery();
                cmdOutSourceWorkDetail.Parameters.Clear();
            }
            return true;
        }
        public bool CreateOutSourceWorkTransactionsDetail(List<VoucherDetailEL> oelDetailCollection, Int64? Identity, string LedgerVoucherNo, SqlConnection objConn, SqlTransaction objTran)
        {
            SqlCommand cmdVoucherDetail = new SqlCommand("[Transactions].[Proc_CreateTransactionsDetails]", objConn);
            cmdVoucherDetail.CommandType = CommandType.StoredProcedure;
            cmdVoucherDetail.CommandTimeout = 0;
            cmdVoucherDetail.Transaction = objTran;
            for (int i = 0; i < oelDetailCollection.Count; i++)
            {
                cmdVoucherDetail.CommandType = CommandType.StoredProcedure;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@IdTransactionDetail", DbType.Int64)).Value = oelDetailCollection[i].IdTransactionDetail;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = Identity;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelDetailCollection[i].IdProject;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@BookNo", DbType.Int64)).Value = oelDetailCollection[i].BookNo;
               
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@LedgerVoucherNo", DbType.String)).Value = "OW" + "-" + LedgerVoucherNo;
                
                //cmdVoucherDetail.Parameters.Add(new SqlParameter("@LedgerVoucherNo", DbType.String)).Value = oelDetailCollection[i].VoucherType + "-" + LedgerVoucherNo.ToString();
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelDetailCollection[i].AccountNo;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@SeqNo", DbType.Int32)).Value = oelDetailCollection[i].SeqNo;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Narration", DbType.String)).Value = oelDetailCollection[i].Description;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Debit", DbType.Decimal)).Value = oelDetailCollection[i].Debit;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Credit", DbType.Decimal)).Value = oelDetailCollection[i].Credit;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@TransactionMode", DbType.String)).Value = oelDetailCollection[i].TransactionMode;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@TrackNumber", DbType.Decimal)).Value = oelDetailCollection[i].TrackNumber;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@VType", DbType.Decimal)).Value = oelDetailCollection[i].VoucherType;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelDetailCollection[i].CreatedDateTime;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Posted", DbType.DateTime)).Value = oelDetailCollection[i].Posted;
                cmdVoucherDetail.ExecuteNonQuery();
                cmdVoucherDetail.Parameters.Clear();
            }
            return true;
        }
        public bool UpdateOutSourceWorkTransactionsDetail(List<VoucherDetailEL> oelDetailCollection, SqlConnection objConn, SqlTransaction objTran)
        {
            SqlCommand cmdVoucherDetail = new SqlCommand();
            cmdVoucherDetail.Connection = objConn;
            cmdVoucherDetail.CommandType = CommandType.StoredProcedure;
            cmdVoucherDetail.CommandTimeout = 0;
            cmdVoucherDetail.Transaction = objTran;
            for (int i = 0; i < oelDetailCollection.Count; i++)
            {
                if (oelDetailCollection[i].IsNew)
                {
                    cmdVoucherDetail.CommandText = "[Transactions].[Proc_CreateTransactionsDetails]";
                }
                else
                {
                    cmdVoucherDetail.CommandText = "[Transactions].[Proc_UpdateTransactionsDetails]";
                }
                cmdVoucherDetail.CommandType = CommandType.StoredProcedure;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@IdTransactionDetail", DbType.Int64)).Value = oelDetailCollection[i].IdTransactionDetail;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelDetailCollection[i].IdVoucher;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelDetailCollection[i].IdProject;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@BookNo", DbType.Int64)).Value = oelDetailCollection[i].BookNo;
                
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@LedgerVoucherNo", DbType.String)).Value = "OW" + "-" + oelDetailCollection[i].VoucherNo.ToString();
                
                //cmdVoucherDetail.Parameters.Add(new SqlParameter("@LedgerVoucherNo", DbType.String)).Value = oelDetailCollection[i].VoucherType + "-" + oelDetailCollection[i].VoucherNo.ToString();
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelDetailCollection[i].AccountNo;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@SeqNo", DbType.Int32)).Value = oelDetailCollection[i].SeqNo;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Narration", DbType.String)).Value = oelDetailCollection[i].Description;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Debit", DbType.Decimal)).Value = oelDetailCollection[i].Debit;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Credit", DbType.Decimal)).Value = oelDetailCollection[i].Credit;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@TransactionMode", DbType.String)).Value = oelDetailCollection[i].TransactionMode;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@TrackNumber", DbType.Decimal)).Value = oelDetailCollection[i].TrackNumber;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@VType", DbType.Decimal)).Value = oelDetailCollection[i].VoucherType;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelDetailCollection[i].CreatedDateTime;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Posted", DbType.DateTime)).Value = oelDetailCollection[i].Posted;
                cmdVoucherDetail.ExecuteNonQuery();
                cmdVoucherDetail.Parameters.Clear();
            }
            return true;
        }
    }
}
