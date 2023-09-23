using Kpop_Ztation.Handler;
using Kpop_Ztation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Controller
{
    public class TransactionController
    {
        public static void CreateTransactionHeader(DateTime transactionDate, int customerId)
        {
            TransactionHandler.CreateTransactionHeader(transactionDate, customerId);
            return;
        }

        public static void CreateTransactionDetail(int transactionId, int albumId, int qty)
        {
            TransactionHandler.CreateTransactionDetail(transactionId, albumId, qty);
            return;
        }

        public static void UpdateTransaction()
        {
            TransactionHandler.UpdateTransaction();
            return;
        }

        public static List<int> getAllTransactionHeaderID(int userID)
        {
            List<int> allTransactionHeaderID = TransactionHandler.getAllTransactionHeaderID(userID);
            return allTransactionHeaderID;
        }

        public static List<TransactionDetail> getAllTransactionDetail(int transactionId)
        {
            List<TransactionDetail> allTransactionDetail = TransactionHandler.getAllTransactionDetail(transactionId);
            return allTransactionDetail;
        }
    }
}