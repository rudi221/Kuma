namespace Kuma.Models
{
    public class FileName
    {
        private string file;

        public FileName(string file)
        {
            this.File = file;
        }

        public string? File { get; set; }
    }
}
