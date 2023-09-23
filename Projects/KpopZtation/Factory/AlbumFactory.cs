using Kpop_Ztation.Model;
using Kpop_Ztation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Factory
{
    public class AlbumFactory
    {
        public static Album CreateAlbum(int ArtistID, String Name, String Desc, int Price, int Stock, String Image)
        {
            Album Collection = new Album();
            Collection.ArtistID = ArtistID;
            Collection.AlbumName = Name;
            Collection.AlbumDescription = Desc;
            Collection.AlbumPrice = Price;
            Collection.AlbumStock = Stock;
            Collection.AlbumImage = Image;

            return Collection;
        }

        public static Album UpdateAlbum(int ID, String Name, String Desc, int Price, int Stock, String Image)
        {
            Album Collection = AlbumRepository.GetAlbumByAlbumID(ID);            
            Collection.AlbumName = Name;
            Collection.AlbumDescription = Desc;
            Collection.AlbumPrice = Price;
            Collection.AlbumStock = Stock;
            Collection.AlbumImage = Image;

            return Collection;
        }

        public static Album DecreaseAmount(int albumId, int qty)
        {
            Album Collection = AlbumRepository.GetAlbumByAlbumID(albumId);
            Collection.AlbumStock -= qty;

            return Collection;
        }

        public static Album IncreaseAmount(int albumId, int qty)
        {
            Album Collection = AlbumRepository.GetAlbumByAlbumID(albumId);
            Collection.AlbumStock += qty;

            return Collection;
        }
    }
}