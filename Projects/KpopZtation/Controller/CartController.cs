using Kpop_Ztation.Handler;
using Kpop_Ztation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Controller
{
    public class CartController
    {
        public static void CreateCart(int customerId, int albumId, int qty)
        {
            CartHandler.CreateCart(customerId, albumId, qty);
            return;
        }

        public static void UpdateCart()
        {
            CartHandler.UpdateCart();
            return;
        }

        public static String RemoveAllItems(List<Cart> cartList, int userID)
        {
            CartHandler.RemoveAllItems(cartList, userID);
            return "Cart checked out successfuly";
        }

        public static List<Cart> getAllCarts(int userID)
        {
            List<Cart> allUserItems = CartHandler.getAllCarts(userID);
            return allUserItems;
        }

        public static int getLastTransactionID(int userID)
        {
            int lastTransactionID = CartHandler.getLastTransactionID(userID);
            return lastTransactionID;
        }

        public static void getCartDelete(int userID, int albumID, int qty)
        {
            CartHandler.getCartDelete(userID, albumID, qty);
            return;
        }

        public static void addTransactionHeader(DateTime transactionDate, int userId)
        {
            TransactionController.CreateTransactionHeader(transactionDate, userId);
            return;
        }

        public static void addTransactionDetail(int transactionId, int albumId, int qty)
        {
            TransactionController.CreateTransactionDetail(transactionId, albumId, qty);
            return;
        }
    }
}