namespace Kuma.Services
{
    public class FileManager : PathManager
    {
        public string ArtistFolder { get; set; }
        public string TourFolder { get; set; }
        public string Category { get; set; }
        public string FileName { get; set; }

        public FileManager(string fileName, string artistFolder, string tourFolder, string category)
            : base()
        {
            ArtistFolder = artistFolder;
            TourFolder = tourFolder;
            Category = category;
            FileName = fileName;
        }

        public FileManager(string artistFolder, string tourFolder)
        : base()
        {
            ArtistFolder = artistFolder;
            TourFolder = tourFolder;
        }




        public static string GetUniqueFileName(string directoryPath, string fileName, string category)
        {
            // Überprüfen, ob das Verzeichnis existiert
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string getFileName = Path.GetFileName(fileName);

            string originalFileName = category + Path.GetExtension(getFileName);

            // Ursprünglicher Dateiname
            string filePath = Path.Combine(directoryPath, originalFileName);

            // Überprüfen, ob die Datei bereits existiert
            if (File.Exists(filePath))
            {
                int counter = 1;
                string fileExtension = Path.GetExtension(originalFileName);
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(originalFileName);

                // Dateiname ändern, bis ein einzigartiger Name gefunden wird
                while (File.Exists(filePath))
                {
                    filePath = Path.Combine(directoryPath, $"{fileNameWithoutExtension}_{counter}{fileExtension}");
                    counter++;
                }
            }

            // Pfad der umbenannten Datei zurückgeben
            return filePath;
        }

        public void DeleteArtistFile(string fileName)
        {
            string filePath = Path.Combine(FolderManager.GetArtistTourPath(ArtistFolder, TourFolder), fileName);

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


        public static void DeleteAllArtistFile(string folderPath)
        {
            try
            {
                // Holen Sie alle Dateien im angegebenen Ordner
                string[] files = Directory.GetFiles(folderPath);

                // Löschen Sie jede Datei
                foreach (string file in files)
                {
                    File.Delete(file);
                    Console.WriteLine($"{file} wurde gelöscht.");
                }

                Console.WriteLine("Alle Dateien wurden erfolgreich gelöscht.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
            }
        }

    }
}