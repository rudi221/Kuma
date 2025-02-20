using System.Security.AccessControl;

namespace Kuma.Classes.Core
{
    public class FolderManager
    {
        private readonly string _oneDrivePath;
        private readonly string _parentFolderName;
        private readonly string _artistFolder;
        private readonly string _tourFolder;
        private readonly string _folderPath;
        private readonly string _artistFolderPath;
        private readonly string _tourFolderPath;



        // Konstruktor, der die Ordnernamen und den Pfad initialisiert
        public FolderManager(string artistFolder, string tourFolder)
        {
            _parentFolderName = "Kuenstler"; // Name des übergeordneten Ordners
            _artistFolder = artistFolder; // Name des Künstlerordners
            _tourFolder = tourFolder; // Name des Tourordners

            _oneDrivePath = "C:\\ProgramData\\Kuma"; // Pfad zum OneDrive-Verzeichnis

            // Kombiniere die Pfade, um den vollständigen Pfad zu den Ordnern zu erstellen
            _folderPath = Path.Combine(_oneDrivePath, _parentFolderName);
            _artistFolderPath = Path.Combine(_folderPath, _artistFolder);
            _tourFolderPath = Path.Combine(_artistFolderPath, _tourFolder);


        }

        // Methode zur Sicherstellung, dass die Ordner existieren
        public void EnsureFolderExists()
        {
            // Überprüfe, ob der Künstlerordner existiert
            if (!Directory.Exists(_artistFolderPath))
            {
                // Erstelle den Künstlerordner und den Tourordner
                Directory.CreateDirectory(_artistFolderPath);
                Directory.CreateDirectory(_tourFolderPath);

            }
            else if (!Directory.Exists(_tourFolderPath)) // Überprüfe, ob der Tourordner existiert
            {
                // Erstelle den Tourordner
                Directory.CreateDirectory(_tourFolderPath);


            }
        }

        // Methode zum Löschen des Künstlerordners und seiner Inhalte
        public void DeleteArtistFolder()
        {
            // Überprüfe, ob der Tourordner existiert
            if (Directory.Exists(_tourFolderPath))
            {
                // Lösche alle Dateien im Tourordner und mache das Verzeichnis löschbar
                DeleteAllFilesInFolder(_tourFolderPath);
                EnsureDirectoryDeletable(_tourFolderPath);
                Directory.Delete(_tourFolderPath, true);
            }

            // Überprüfe, ob der Künstlerordner keine weiteren Unterordner enthält
            if (GetSubfolderCount() == 0)
            {
                // Mache das Verzeichnis löschbar und lösche den Künstlerordner
                EnsureDirectoryDeletable(_artistFolderPath);
                Directory.Delete(_artistFolderPath, true);
            }
        }

        // Methode zur Sicherstellung, dass ein Verzeichnis löschbar ist, indem die Zugriffsrechte gesetzt werden
        public void EnsureDirectoryDeletable(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            DirectorySecurity directorySecurity = directoryInfo.GetAccessControl();
            directorySecurity.AddAccessRule(new FileSystemAccessRule(Environment.UserName,
                FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit,
                PropagationFlags.None, AccessControlType.Allow));
            directoryInfo.SetAccessControl(directorySecurity);
        }



        // Methode zur Ermittlung der Anzahl der Unterordner im Künstlerordner
        public int GetSubfolderCount()
        {
            if (Directory.Exists(_artistFolderPath))
            {
                return Directory.GetDirectories(_artistFolderPath).Length;
            }
            else
            {
                throw new DirectoryNotFoundException($"Das Verzeichnis '{_artistFolderPath}' wurde nicht gefunden.");
            }
        }

        // Methode zum Löschen aller Dateien in einem angegebenen Ordner
        public void DeleteAllFilesInFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                foreach (string file in Directory.GetFiles(folderPath))
                {
                    try
                    {
                        File.Delete(file);
                        Console.WriteLine($"Datei '{file}' wurde gelöscht.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Fehler beim Löschen der Datei '{file}': {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Der Ordner '{folderPath}' wurde nicht gefunden.");
            }
        }


    }
}