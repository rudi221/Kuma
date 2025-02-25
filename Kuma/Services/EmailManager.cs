using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

public class EmailManager
{
    private readonly string smtpServer;
    private readonly int smtpPort;
    private readonly string smtpUser;
    private readonly string smtpPass;

    public EmailManager(string server, int port, string user, string pass)
    {
        smtpServer = server;
        smtpPort = port;
        smtpUser = user;
        smtpPass = pass;
    }

    public void SendEmail(string to, string subject, string body, bool isHtml = false)
    {
        try
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Dein Name", smtpUser));
            message.To.Add(new MailboxAddress("", to));
            message.Subject = subject;

            message.Body = new TextPart(isHtml ? "html" : "plain") { Text = body };

            using (var client = new SmtpClient())
            {
                client.Connect(smtpServer, smtpPort, SecureSocketOptions.StartTls);
                client.Authenticate(smtpUser, smtpPass);
                client.Send(message);
                client.Disconnect(true);
            }

            Console.WriteLine("E-Mail erfolgreich gesendet!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Fehler beim Senden: " + ex.Message);
        }
    }
}