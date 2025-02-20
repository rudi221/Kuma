namespace Kuma.Services
{
    public class Artist
    {
        public int ArtistID { get; set; }
        public string ArtistName { get; set; }
        public string TourName { get; set; }

        public Artist(int artistID, string artistName, string tourName)
        {
            ArtistID = artistID;
            ArtistName = artistName;
            TourName = tourName;
        }

        public int GetArtistID()
        {
            return ArtistID;
        }

        public string GetArtistName()
        {
            return ArtistName;
        }

        public string GetTourName()
        {
            return TourName;
        }

        public Artist GetArtistInfo()
        {
            return new Artist(ArtistID, ArtistName, TourName);
        }



    }
}


