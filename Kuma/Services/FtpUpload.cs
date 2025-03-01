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

        if (ftpSection.Count == 0 || ftpSection.All(kvp => string.IsNullOrWhiteSpace(kvp.Value)))
        {
            MessageBox.Show("Bitte tragen Sie zuerst die FTP-Daten in die Einstellungen ein.");
            return;
        }

        ftpAddress = ftpSection.TryGetValue("Server", out var server) && !string.IsNullOrWhiteSpace(server) ? server : throw new ArgumentException("Server fehlt in der INI-Datei");
        ftpUsername = ftpSection.TryGetValue("Benutzer", out var user) && !string.IsNullOrWhiteSpace(user) ? user : throw new ArgumentException("Benutzer fehlt in der INI-Datei");
        ftpPassword = ftpSection.TryGetValue("Passwort", out var pass) && !string.IsNullOrWhiteSpace(pass) ? pass : throw new ArgumentException("Passwort fehlt in der INI-Datei");
        ftpFolder = ftpSection.TryGetValue("Verzeichnis", out var folder) && !string.IsNullOrWhiteSpace(folder) ? folder : throw new ArgumentException("Verzeichnis fehlt in der INI-Datei");

    }

    public async Task UploadFilesAsync(List<string> localFilePaths, TourData tourData, ProgressBar progressBar)
    {

        string newDirectory = GetWebLink.GetLink($"{ftpFolder}/{tourData.ArtistName}/{tourData.TourName}");
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
                string localFilePath = Path.Combine(PathManager.GetArtistTourPath(tourData.ArtistName, tourData.TourName), filePath);

                await Task.Run(() => client.UploadFile(localFilePath, remoteFilePath));
                Console.WriteLine($"{filePath} erfolgreich hochgeladen nach {remoteFilePath}.");
                progressBar.Invoke((Action)(() => progressBar.Value++));
            }
        }
        catch (FluentFTP.Exceptions.FtpAuthenticationException ex)
        {
            MessageBox.Show($"Authentifizierungsfehler: {ex.Message}");
        }
        catch (System.Net.Sockets.SocketException ex) when (ex.SocketErrorCode == System.Net.Sockets.SocketError.HostNotFound)
        {
            MessageBox.Show("Netzwerkfehler: Der angegebene FTP-Server ist nicht erreichbar. Bitte überprüfen Sie die FTP-Serveradresse.");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Fehler beim Hochladen der Datei: {ex.Message}");
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
