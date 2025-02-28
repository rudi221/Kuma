namespace Kuma.Models
{
    public class FileName
    {
        public FileName(string? file)
        {
            File = file;
        }

        public string? File { get; set; }
    }
}
