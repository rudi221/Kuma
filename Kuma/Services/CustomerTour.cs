using Kuma.Models;

namespace Kuma.Services
{
    public class CustomerTour
    {
        public AddressData Customer { get; set; }
        public TourData TourData { get; set; }
        public List<ArtistFileList> Files { get; set; } = new List<ArtistFileList>();

        public CustomerTour(AddressData customer, TourData tourData)
        {
            Customer = customer;
            TourData = tourData;
        }

        public void AddFile(string fileName, string category)
        {
            Files.Add(new ArtistFileList(category, fileName));
        }

        public override string ToString()
        {
            string fileList = Files.Count > 0 ? string.Join(", ", Files) : "Keine Dateien hjjjh";
            return $"{Customer} -> {TourData} | Dateien: {fileList}";
        }
    }
}
