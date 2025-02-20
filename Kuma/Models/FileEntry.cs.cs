namespace Kuma.Models
{
    public class FileEntry
    {
        public string FileName { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            return $"{FileName} ({Category})";
        }
    }
}
