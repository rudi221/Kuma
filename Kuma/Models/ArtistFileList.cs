namespace Kuma.Models
{
    public class ArtistFileList
    {
        public string Category { get; set; }
        public string FileName { get; set; }

        public ArtistFileList(string category, string fileName)
        {
            Category = category;
            FileName = fileName;
        }

        public override string ToString()
        {
            return $"Category: {Category}, FileName: {FileName}";
        }
    }
}
