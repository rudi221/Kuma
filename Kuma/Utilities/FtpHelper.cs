using System.Net;

public class FtpHelper
{
    private readonly string ftpServer;
    private readonly string ftpUser;
    private readonly string ftpPassword;

    public FtpHelper(string server, string user, string password)
    {
        ftpServer = server;
        ftpUser = user;
        ftpPassword = password;
    }

    public bool UploadFile(string localFilePath, string remoteFileName)
    {
        try
        {
            string ftpUrl = $"{ftpServer}/{remoteFileName}";
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpUrl);
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(ftpUser, ftpPassword);
            request.UsePassive = true;
            request.UseBinary = true;
            request.KeepAlive = false;

            byte[] fileContents = File.ReadAllBytes(localFilePath);
            request.ContentLength = fileContents.Length;

            using (Stream requestStream = request.GetRequestStream())
            {
                requestStream.Write(fileContents, 0, fileContents.Length);
            }

            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                Console.WriteLine($"✅ Upload erfolgreich! Status: {response.StatusDescription}");
            }

            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Fehler beim Hochladen: {ex.Message}");
            return false;
        }
    }
}
