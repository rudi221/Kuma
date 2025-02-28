using FluentFTP;
using Kuma.Models;
using Kuma.Services;
using System.Net;

public class FtpUploader
{
    private string ftpAddress;
    private string ftpUsername;
    private string ftpPassword;
    private string ftpFolder;

    private readonly string _iniFilePath = Path.Combine(PathManager.GetProgramPath(), "settings.ini");

    public FtpUploader()
    {
        var ini = new IniFile(_iniFilePath);
        var ftpSection = ini.ReadSection("FTP");

        ftpAddress = ftpSection.ContainsKey("Server") ? ftpSection["Server"] : throw new ArgumentException("Server fehlt in der INI-Datei");
        ftpUsername = ftpSection.ContainsKey("Benutzer") ? ftpSection["Benutzer"] : throw new ArgumentException("Benutzer fehlt in der INI-Datei");
        ftpPassword = ftpSection.ContainsKey("Passwort") ? ftpSection["Passwort"] : throw new ArgumentException("Passwort fehlt in der INI-Datei");
        ftpFolder = ftpSection.ContainsKey("Verzeichnis") ? ftpSection["Verzeichnis"] : throw new ArgumentException("Verzeichnis fehlt in der INI-Datei");
    }

    public async Task UploadFilesAsync(List<string> localFilePaths, TourData tourData, ProgressBar progressBar)
    {

        // string newDirectory = $"{ftpFolder}/{tourData.ArtistName}/{tourData.TourName}";
        string newDirectory = $"{ftpFolder}/{tourData.ArtistName}/{tourData.TourName}";
        string subFolder = $"{tourData.ArtistName}/{tourData.TourName}";



        FtpClient client = new FtpClient(ftpAddress)
        {
            Credentials = new NetworkCredential(ftpUsername, ftpPassword)
        };

        try
        {
            await Task.Run(() => client.Connect());

            await DeleteAllFilesInDirectoryAsync(client, newDirectory);

            await Task.Run(() => client.CreateDirectory(newDirectory, true));


            progressBar.Maximum = localFilePaths.Count;
            progressBar.Value = 0;


            foreach (string filePath in localFilePaths)
            {
                string remoteFilePath = GetWebLink.GetLink($"{ftpFolder}/{subFolder}/{System.IO.Path.GetFileName(filePath)}");
                await Task.Run(() => client.UploadFile(filePath, remoteFilePath));
                Console.WriteLine($"{filePath} erfolgreich hochgeladen nach {remoteFilePath}.");
                progressBar.Invoke((Action)(() => progressBar.Value++));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Fehler beim Hochladen der Datei: " + ex.Message);
        }
        finally
        {
            client.Disconnect();
        }
    }


    private async Task DeleteAllFilesInDirectoryAsync(FtpClient client, string directory)
    {
        try
        {
            var files = await Task.Run(() => client.GetListing(directory));
            foreach (var file in files)
            {
                if (file.Type == FtpObjectType.File)
                {
                    await Task.Run(() => client.DeleteFile(file.FullName));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Fehler beim Löschen der Dateien im Verzeichnis {directory}: " + ex.Message);
        }
    }



}
