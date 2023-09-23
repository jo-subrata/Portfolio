using Kpop_Ztation.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Controller
{
    public class AlbumController
    {
        public static String CreateAlbum(int ArtistID, String Name, String Desc, int Price, int Stock, String Image, String imageExtension, int fileSize)
        {
            if(Functions.CheckEmpty(Name) || Functions.CheckEmpty(Desc))
            {
                return "Please fill all fields";
            }

            if(Name.Length > 50)
            {
                return "Album name cannot have a length of more than 50 characters";
            }

            if (Desc.Length > 255)
            {
                return "Description cannot have a length of more than 255 characters";
            }

            if (/*Price == null ||*/ Price < 100000 || Price > 1000000)
            {
                return "Album price must be between Rp100.000 and Rp1.000.000";
            }

            if(/*Stock == null ||*/ Stock < 0)
            {
                return "Album stock must be more than 0";
            }

            if (imageExtension != ".png" && imageExtension != ".jpg" && imageExtension != ".jpeg" && imageExtension != ".jfif")
            {
                return "Incorrect image type. Uploaded image can only be .png, .jpg, .jpeg, or .jfif";
            }

            int maxFileSize = 2 * 1024 * 1024;
            if (fileSize > maxFileSize)
            {
                return "Image can not be larger than 2MB";
            }

            AlbumHandler.CreateAlbum(ArtistID, Name, Desc, Price, Stock, Image);
            return "Album succesfully added";
        }

        public static String UpdateAlbum(int ID, String Name, String Desc, int Price, int Stock, String Image, String imageExtension, int fileSize)
        {
            if (Functions.CheckEmpty(Name) || Functions.CheckEmpty(Desc))
            {
                return "Please fill all fields";
            }

            if (Name.Length > 50)
            {
                return "Album name cannot have a length of more than 50 characters";
            }

            if (Desc.Length > 255)
            {
                return "Description cannot have a length of more than 255 characters";
            }

            if (/*Price == null ||*/ Price < 100000 || Price > 1000000)
            {
                return "Album price must be between Rp100.000 and Rp1.000.000";
            }

            if (/*Stock == null ||*/ Stock < 0)
            {
                return "Album stock must be more than 0";
            }

            if (imageExtension != ".png" && imageExtension != ".jpg" && imageExtension != ".jpeg" && imageExtension != ".jfif")
            {
                return "Incorrect image type. Uploaded image can only be .png, .jpg, .jpeg, or .jfif";
            }

            int maxFileSize = 2 * 1024 * 1024;
            if (fileSize > maxFileSize)
            {
                return "Image can not be larger than 2MB";
            }

            AlbumHandler.UpdateAlbum(ID, Name, Desc, Price, Stock, Image);
            return "Album succesfully updated";
        }

        public static String AddToCart(int customerID, int albumID, int Amount)
        {
            if(Functions.CheckAmount(albumID, Amount))
            {
                return "Amount cannot be more than album stock";
            }

            CartController.CreateCart(customerID, albumID, Amount);
            return "Item added to cart";
        }
    }    
}