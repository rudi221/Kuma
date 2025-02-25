using Kuma.Utilities;

namespace Kuma.Services
{
    public class FileManager : BaseManager
    {
        public string ArtistFolder { get; set; }
        public string TourFolder { get; set; }
        public string Category { get; set; }

        public FileManager(string artistFolder, string tourFolder, string category)
            : base(Path.GetFileName(tourFolder), category)
        {
            ArtistFolder = artistFolder;
            TourFolder = tourFolder;
            Category = category;
        }

        public FileManager(string artistFolder, string tourFolder)
        : base(artistFolder, tourFolder)
        {
            ArtistFolder = artistFolder;
            TourFolder = tourFolder;
        }



        public string GetTargetFilePath()
        {
            return Path.Combine(TourFolder, Path.GetFileName(ArtistFolder));
        }

        public string GetArtistPath()
        {

            return Path.Combine(TourFolder, Path.GetFileName(ArtistFolder));


        }

        public string GetNewFileName()
        {
            string fileName = Path.GetFileName(ArtistFolder);
            return Category + Path.GetExtension(fileName);
        }

        public string GetNewFilePath()
        {
            return Path.Combine(TourFolder, GetNewFileName());
        }

        public string GetUniqueFilePath()
        {
            string newFileName = FileHelper.GetUniqueFileName(TourFolder, GetNewFileName());
            return Path.Combine(TourFolder, newFileName);
        }

        public void MoveFile()
        {
            string targetFilePath = GetUniqueFilePath();

            try
            {
                File.Move(ArtistFolder, targetFilePath);
                Console.WriteLine($"Datei erfolgreich verschoben: {targetFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Verschieben der Datei: {ex.Message}");
            }
        }

        public void CopyFile()
        {
            string targetFilePath = GetUniqueFilePath();

            try
            {
                File.Copy(ArtistFolder, targetFilePath);
                Console.WriteLine($"Datei erfolgreich verschoben: {targetFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Verschieben der Datei: {ex.Message}");
            }
        }



        public void DeleteFile(string fileName)
        {
            string filePath = Path.Combine(_tourFolderPath, fileName);

            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    Console.WriteLine($"Datei '{filePath}' wurde erfolgreich gelöscht.");
                }
                else
                {
                    Console.WriteLine($"Datei '{filePath}' wurde nicht gefunden.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Löschen der Datei: {ex.Message}");
            }
        }



    }
}
