using Kpop_Ztation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Factory
{
    public class CartFactory
    {
        public static Cart CreateCart(int customerId, int albumId, int qty)
        {
            Cart customerCart = new Cart();
            customerCart.CustomerID = customerId;
            customerCart.AlbumID = albumId;
            customerCart.Qty = qty;

            return customerCart;
        }
    }
}