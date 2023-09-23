using Kpop_Ztation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Factory
{
    public class TransactionFactory
    {
        public static TransactionHeader CreateTransactionHeader(DateTime transactionDate, int customerId)
        {
            TransactionHeader history = new TransactionHeader();
            history.TransactionDate = transactionDate;
            history.CustomerID = customerId;

            return history;
        }

        public static TransactionDetail CreateTransactionDetail(int transactionId, int albumId, int qty)
        {
            TransactionDetail history = new TransactionDetail();
            history.TransactionID = transactionId;
            history.AlbumID = albumId;
            history.Qty = qty;

            return history;
        }
    }
}