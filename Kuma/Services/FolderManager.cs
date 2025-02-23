using System.Security.AccessControl;

namespace Kuma.Services
{
    public class FolderManager : BaseManager
    {
        public FolderManager(string artistFolder, string tourFolder) : base(artistFolder, tourFolder) { }

        public string GetFolderPath()
        {
            return _tourFolderPath;
        }

        public void EnsureFolderExists()
        {
            if (!Directory.Exists(_artistFolderPath))
            {
                Directory.CreateDirectory(_artistFolderPath);
                Directory.CreateDirectory(_tourFolderPath);
            }
            else if (!Directory.Exists(_tourFolderPath))
            {
                Directory.CreateDirectory(_tourFolderPath);
            }
        }

        public void DeleteArtistFolder()
        {
            if (Directory.Exists(_tourFolderPath))
            {
                DeleteAllFilesInFolder(_tourFolderPath);
                EnsureDirectoryDeletable(_tourFolderPath);
                Directory.Delete(_tourFolderPath, true);
            }

            if (GetSubfolderCount() == 0)
            {
                EnsureDirectoryDeletable(_artistFolderPath);
                Directory.Delete(_artistFolderPath, true);
            }
        }

        public void EnsureDirectoryDeletable(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            DirectorySecurity directorySecurity = directoryInfo.GetAccessControl();
            directorySecurity.AddAccessRule(new FileSystemAccessRule(Environment.UserName,
                FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit,
                PropagationFlags.None, AccessControlType.Allow));
            directoryInfo.SetAccessControl(directorySecurity);
        }

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