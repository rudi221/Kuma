namespace Kuma.Models
{

    public class TourData
    {
        public int ArtistID { get; set; }
        public string ArtistName { get; set; }
        public string TourName { get; set; }

        public TourData(int artistID, string artistName, string tourName)
        {
            ArtistID = artistID;
            ArtistName = artistName;
            TourName = tourName;
        }

        public override string ToString()
        {
            return $"{ArtistName} - {TourName}";
        }
    }

}






