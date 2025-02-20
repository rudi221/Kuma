namespace Kuma.Models
{

    public class ArtistInfo
    {
        public int ArtistID { get; set; }
        public string ArtistName { get; set; }
        public string TourName { get; set; }

        public ArtistInfo(int artistID, string artistName, string tourName)
        {
            ArtistID = artistID;
            ArtistName = artistName;
            TourName = tourName;
        }
    }
}






