using Kpop_Ztation.Repository;
using Kpop_Ztation.Factory;
using Kpop_Ztation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Handler
{
    public class TransactionHandler
    {
        public static void CreateTransactionHeader(DateTime transactionDate, int customerId)
        {
            TransactionHeader history = TransactionFactory.CreateTransactionHeader(transactionDate, customerId);

            TransactionRepository.CreateTransactionHeader(history);
            return;
        }

        public static void CreateTransactionDetail(int transactionId, int albumId, int qty)
        {
            TransactionDetail history = TransactionFactory.CreateTransactionDetail(transactionId, albumId, qty);

            TransactionRepository.CreateTransactionDetail(history);
            return;
        }

        public static void UpdateTransaction()
        {
            TransactionRepository.UpdateTransaction();
            return;
        }


        public static List<int> getAllTransactionHeaderID(int userID)
        {
            List<int> allTransactionHeaderID = TransactionRepository.getAllTransactionHeaderID(userID);
            return allTransactionHeaderID;
        }

        public static List<TransactionDetail> getAllTransactionDetail(int transactionId)
        {
            List<TransactionDetail> allTransactionDetail = TransactionRepository.getAllTransactionDetail(transactionId);
            return allTransactionDetail;
        }

        public static List<TransactionHeader> getTransaction()
        {
            return TransactionRepository.getTransactions();
        }
    }
}