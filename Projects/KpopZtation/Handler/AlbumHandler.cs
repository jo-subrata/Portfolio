using Kpop_Ztation.Factory;
using Kpop_Ztation.Model;
using Kpop_Ztation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Handler
{
    public class AlbumHandler
    {
        public static void CreateAlbum(int ArtistID, String Name, String Desc, int Price, int Stock, String Image)
        {
            Album Collection = AlbumFactory.CreateAlbum(ArtistID, Name, Desc, Price, Stock, Image);

            AlbumRepository.CreateAlbum(Collection);
            return;
        }

        public static void UpdateAlbum(int ID, String Name, String Desc, int Price, int Stock, String Image)
        {
            Album Collection = AlbumFactory.UpdateAlbum(ID, Name, Desc, Price, Stock, Image);

            AlbumRepository.UpdateAlbum(Collection);
            return;
        }

        public static void DeleteAlbum(int AlbumID)
        {
            Album album = AlbumRepository.GetAlbumByAlbumID(AlbumID);
            AlbumRepository.RemoveAlbum(album);
        }

        public static void DeleteAllAlbum(int ArtistID)
        {
            List<Album> albums = AlbumRepository.GetAllAlbumByArtistID(ArtistID);
            AlbumRepository.RemoveAllAlbums(albums);
        }

        public static bool CheckArtistAlbum(int ArtistID)
        {
            if (AlbumRepository.GetAlbumByArtistID(ArtistID) != null)
            {
                return true;
            }
            return false;
        }
    }
}