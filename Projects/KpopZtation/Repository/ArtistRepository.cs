using Kpop_Ztation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Repository
{
    public class ArtistRepository
    {
        static KpopZtationDatabaseEntities1 db = new KpopZtationDatabaseEntities1();

        public static void CreateArtist(Artist Idol)
        {
            db.Artists.Add(Idol);
            db.SaveChanges();
            return;
        }

        public static void UpdateArtist(Artist Idol)
        {
            db.SaveChanges();
            return;
        }

        public static List<Artist> GetAllArtist()
        {
            return db.Artists.ToList();
        }

        public static Artist GetArtistByID(int ID)
        {
            return (from u in db.Artists where ID.Equals(u.ArtistID) select u).FirstOrDefault();
        }

        public static Artist GetArtistByName(String Name)
        {
            return (from u in db.Artists where Name.Equals(u.ArtistName) select u).FirstOrDefault();
        }

        public static int RemoveArtist(Artist artist)
        {
            db.Artists.Remove(artist);
            return db.SaveChanges();
        }
    }
}