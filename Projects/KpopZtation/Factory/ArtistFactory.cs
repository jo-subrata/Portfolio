using Kpop_Ztation.Model;
using Kpop_Ztation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kpop_Ztation.Factory
{
    public class ArtistFactory
    {
        public static Artist CreateArtist(String Name, String Image)
        {
            Artist Idol = new Artist();
            Idol.ArtistName = Name;
            Idol.ArtistImage = Image;


            return Idol;
        }

        public static Artist UpdateArtist(int ID, String Name, String Image)
        {
            Artist Idol = ArtistRepository.GetArtistByID(ID);
            Idol.ArtistName = Name;
            Idol.ArtistImage = Image;

            return Idol;
        }
    }
}