using Kpop_Ztation.Controller;
using Kpop_Ztation.Repository;
using Kpop_Ztation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kpop_Ztation.Repository
{
    public class CartRepository
    {
        static KpopZtationDatabaseEntities1 db = new KpopZtationDatabaseEntities1();


        public static void CreateCart(Cart newCart)
        {
            Album stock = (from u in db.Albums where newCart.AlbumID == u.AlbumID select u).FirstOrDefault();
            stock.AlbumStock -= newCart.Qty;
            db.SaveChanges();

            db.Carts.Add(newCart);
            UpdateCart();
            return;
        }

        public static void UpdateCart()
        {
            db.SaveChanges();
            return;
        }

        public static int RemoveAllItems(List<Cart> cartList)
        {
            db.Carts.RemoveRange(cartList);
            return db.SaveChanges();
        }

        public static List<Cart> getAllCarts(int userID)
        {
            return (from Cart in db.Carts where Cart.CustomerID == userID select Cart).ToList();
        }

        public static int getLastTransactionID(int userID)
        {
            var lastTransactionID = db.TransactionHeaders.Where(t => t.CustomerID == userID).OrderByDescending(t => t.TransactionID).Select(t => t.TransactionID).FirstOrDefault();
            return lastTransactionID;
        }

        public static void getCartDelete(int userID, int albumID, int qty)
        {
            Album stock = (from u in db.Albums where albumID == u.AlbumID select u).FirstOrDefault();
            stock.AlbumStock += qty;

            Cart toDelete = db.Carts.Find(userID, albumID);
            db.Carts.Remove(toDelete);
            UpdateCart();
            return;
        }

        
    }
}