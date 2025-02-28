namespace Kuma.Services
{
    using System;
    using System.IO;
    using System.Security.AccessControl;



    public class FolderManager : PathManager
    {
        public static string ArtistDirectory { get; private set; }
        public static string TourDirectory { get; private set; }

        public static void SetDirectories(string artistFolder, string tourFolder)
        {
            ArtistDirectory = Path.Combine(_mainArtistFolder, artistFolder);
            TourDirectory = Path.Combine(ArtistDirectory, tourFolder);
        }



        public static void ArtistTourFolderExists()
        {
            if (!Directory.Exists(ArtistDirectory))
            {
                Directory.CreateDirectory(ArtistDirectory);
                Console.WriteLine($"Künstlerordner '{ArtistDirectory}' wurde erstellt.");
            }

            if (!Directory.Exists(TourDirectory))
            {
                Directory.CreateDirectory(TourDirectory);
                Console.WriteLine($"Tourordner '{TourDirectory}' wurde erstellt.");
            }
            else
            {
                Console.WriteLine($"Tourordner '{TourDirectory}' existiert bereits.");
            }
        }

        public static void DeleteArtistFolder()
        {
            if (Directory.Exists(TourDirectory))
            {
                DeleteAllFilesInFolder(TourDirectory);
                EnsureDirectoryDeletable(TourDirectory);
                Directory.Delete(TourDirectory, true);
            }

            if (GetSubfolderCount() == 0)
            {
                EnsureDirectoryDeletable(ArtistDirectory);
                Directory.Delete(ArtistDirectory, true);
            }
        }

        public static void EnsureDirectoryDeletable(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            DirectorySecurity directorySecurity = directoryInfo.GetAccessControl();
            directorySecurity.AddAccessRule(new FileSystemAccessRule(Environment.UserName,
                FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit,
                PropagationFlags.None, AccessControlType.Allow));
            directoryInfo.SetAccessControl(directorySecurity);
        }

        public static int GetSubfolderCount()
        {
            if (Directory.Exists(ArtistDirectory))
            {
                return Directory.GetDirectories(ArtistDirectory).Length;
            }
            else
            {
                throw new DirectoryNotFoundException($"Das Verzeichnis '{ArtistDirectory}' wurde nicht gefunden.");
            }
        }

        public static void DeleteAllFilesInFolder(string folderPath)
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