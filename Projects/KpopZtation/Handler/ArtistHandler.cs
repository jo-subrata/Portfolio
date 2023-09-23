using Kpop_Ztation.Factory;
using Kpop_Ztation.Model;
using Kpop_Ztation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Handler
{
    public class ArtistHandler
    {
        public static void CreateArtist(String Name, String Image)
        {
            Artist Idol = ArtistFactory.CreateArtist(Name, Image);

            ArtistRepository.CreateArtist(Idol);
            return;
        }

        public static void UpdateArtist(int ID, String Name, String Image)
        {
            Artist Idol = ArtistFactory.UpdateArtist(ID, Name, Image);

            ArtistRepository.UpdateArtist(Idol);
            return;
        }

        public static void DeleteArtist(int ArtistID)
        {
            Artist artist = ArtistRepository.GetArtistByID(ArtistID);
            ArtistRepository.RemoveArtist(artist);
        }

        public static Artist GetArtist(String Name)
        {
            return ArtistRepository.GetArtistByName(Name);
        }
    }
}