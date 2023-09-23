using Kpop_Ztation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Repository
{
    public class TransactionRepository
    {
        static KpopZtationDatabaseEntities1 db = new KpopZtationDatabaseEntities1();

        public static void CreateTransactionHeader(TransactionHeader th)
        {
            db.TransactionHeaders.Add(th);
            UpdateTransaction();
            return;
        }

        public static void CreateTransactionDetail(TransactionDetail td)
        {
            db.TransactionDetails.Add(td);
            UpdateTransaction();
            return;
        }

        public static void UpdateTransaction()
        {
            db.SaveChanges();
            return;
        }

        public static List<int> getAllTransactionHeaderID(int userID)
        {
            return (from TransactionHeader in db.TransactionHeaders where TransactionHeader.CustomerID == userID select TransactionHeader.TransactionID).ToList();
        }

        public static List<TransactionDetail> getAllTransactionDetail(int transactionId)
        {
            return (from TransactionDetail in db.TransactionDetails where TransactionDetail.TransactionID == transactionId select TransactionDetail).ToList();
        }

        public static List<TransactionHeader> getTransactions()
        {
            return db.TransactionHeaders.ToList();
        }
    }
}