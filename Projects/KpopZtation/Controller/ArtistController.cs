using Kpop_Ztation.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Controller
{
    public class ArtistController
    {
        public static String CreateArtist(String Name, String Image, String imageExtension, int fileSize)
        {
            if(Functions.CheckEmpty(Name) || Functions.CheckEmpty(Image) || Functions.CheckEmpty(imageExtension))
            {
                return "Please enter an artist name and upload an image";
            }

            if(Functions.CheckArtistUnique(Name))
            {
                return "Artist already exists";
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

            ArtistHandler.CreateArtist(Name, Image);
            return "Artist Succesfully Added";
        }

        public static String UpdateArtist(int ID, string Name, string Image, string imageExtension, int fileSize)
        {
            if (Functions.CheckEmpty(Name) || Functions.CheckEmpty(Image) || Functions.CheckEmpty(imageExtension))
            {
                return "Please enter an artist name and upload an image";
            }

            if (Functions.CheckArtistUnique(Name))
            {
                return "Artist already exists";
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

            ArtistHandler.UpdateArtist(ID, Name, Image);
            return "Artist succesfully updated";
        }
    }
}