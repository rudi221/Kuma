using Kuma.Services;
using MailKit.Net.Smtp;
using MimeKit;

public class EmailManager
{
    private readonly string _smtpServer;
    private readonly int _smtpPort;
    private readonly string _smtpUser;
    private readonly string _smtpPass;

    private readonly string _iniFilePath = Path.Combine(PathManager.GetProgramPath(), "settings.ini");


    public EmailManager()
    {

        var ini = new IniFile(_iniFilePath);
        var emailSection = ini.ReadSection("Email");

        _smtpServer = emailSection.ContainsKey("Server") ? emailSection["Server"] : throw new ArgumentException("Server fehlt in der INI-Datei");
        _smtpUser = emailSection.ContainsKey("Benutzer") ? emailSection["Benutzer"] : throw new ArgumentException("Benutzer fehlt in der INI-Datei");
        _smtpPass = emailSection.ContainsKey("Passwort") ? emailSection["Passwort"] : throw new ArgumentException("Passwort fehlt in der INI-Datei");
        _smtpPort = 587;

    }


    public void SendEmail(string customerEmail, string artistName, string tourName, string customerName, string messageContent, string secondMail, string filename)
    {

        try
        {
            var message = new MimeMessage();
            //  message.From.Add(new MailboxAddress("Rüdiger", "info@dreibach.de"));
            message.From.Add(new MailboxAddress("Ihr Team von UD Promotion", "info@dreibach.de"));
            message.To.Add(new MailboxAddress(customerName, customerEmail));

            if (!string.IsNullOrEmpty(secondMail))
            {
                message.Cc.Add(new MailboxAddress(secondMail, secondMail));

            }

            message.Subject = $"Ihre Informationen zu {artistName} {tourName}";

            string templatePath = Path.Combine(PathManager.GetProgramPath(), "Template", "email_template.html");
            string template = File.ReadAllText(templatePath);

            string link = GetWebLink.GetLink($"http://www.udpromo.de/kuma/{artistName}/{tourName}/{filename}");

            // Ersetzen Sie die Platzhalter
            template = template.Replace("{artist}", artistName);
            template = template.Replace("{kunde}", customerName);
            template = template.Replace("{message}", messageContent);
            template = template.Replace("{link}", link);

            var bodyBuilder = new BodyBuilder
            {
                HtmlBody = template
            };

            message.Body = bodyBuilder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                client.Connect(_smtpServer, _smtpPort, MailKit.Security.SecureSocketOptions.StartTls);
                client.Authenticate(_smtpUser, _smtpPass);

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