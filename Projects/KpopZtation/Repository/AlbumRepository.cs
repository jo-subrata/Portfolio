using Kpop_Ztation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Repository
{
    public class AlbumRepository
    {
        static KpopZtationDatabaseEntities1 db = new KpopZtationDatabaseEntities1();
        public static void CreateAlbum(Album Collection)
        {
            db.Albums.Add(Collection);
            db.SaveChanges();
            return;
        }

        public static void UpdateAlbum(Album Collection)
        {
            db.SaveChanges();
            return;
        }

        public static Album GetAlbumByAlbumID(int ID)
        {
            return (from u in db.Albums where ID.Equals(u.AlbumID) select u).FirstOrDefault();            
        }

        public static Album GetAlbumByArtistID(int ID)
        {
            return (from u in db.Albums where ID.Equals(u.ArtistID) select u).FirstOrDefault();
        }

        public static List<Album> GetAllAlbumByArtistID(int ID)
        {
            return (from u in db.Albums where ID.Equals(u.ArtistID) select u).ToList();
        }

        public static int RemoveAlbum(Album album)
        {
            db.Albums.Remove(album);
            return db.SaveChanges();
        }

        public static int RemoveAllAlbums(List<Album> albums)
        {
            db.Albums.RemoveRange(albums);
            return db.SaveChanges();
        }


    }
}