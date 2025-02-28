using Kuma.Services;
using MailKit.Net.Smtp;
using MimeKit;

public class EmailManager
{
    private readonly string _smtpServer;
    private readonly int _smtpPort;
    private readonly string _smtpUser;
    private readonly string _smtpPass;
    private readonly string _smtpEmail;
    private readonly string _userDomain;


    private readonly string _iniFilePath = Path.Combine(PathManager.GetProgramPath(), "settings.ini");


    public EmailManager()
    {

        var ini = new IniFile(_iniFilePath);
        var emailSection = ini.ReadSection("Email");

        _smtpServer = emailSection.ContainsKey("Server") ? emailSection["Server"] : throw new ArgumentException("Server fehlt in der INI-Datei");
        _smtpUser = emailSection.ContainsKey("Benutzer") ? emailSection["Benutzer"] : throw new ArgumentException("Benutzer fehlt in der INI-Datei");
        _smtpPass = emailSection.ContainsKey("Passwort") ? emailSection["Passwort"] : throw new ArgumentException("Passwort fehlt in der INI-Datei");
        _smtpEmail = emailSection.ContainsKey("Email") ? emailSection["Email"] : throw new ArgumentException("Email fehlt in der INI-Datei");
        _userDomain = emailSection.ContainsKey("Domain") ? emailSection["Domain"] : throw new ArgumentException("Domain fehlt in der INI-Datei");

    }


    public void SendEmail(string customerEmail, string artistName, string tourName, string customerName, string messageContent, string secondMail, string filename)
    {

        try
        {
            var message = new MimeMessage();

            message.From.Add(new MailboxAddress("Ihr Team von UD Promotion", _smtpEmail));
            message.To.Add(new MailboxAddress(customerName, customerEmail));

            if (!string.IsNullOrEmpty(secondMail))
            {
                message.Cc.Add(new MailboxAddress(secondMail, secondMail));

            }

            message.Subject = $"Ihre Informationen zu {artistName} {tourName}";

            string templatePath = Path.Combine(PathManager.GetProgramPath(), "Template", "email_template.html");
            string template = File.ReadAllText(templatePath);

            string link = GetWebLink.GetLink($"{artistName}/{tourName}/{filename}");
            string webLink = Path.Combine(_userDomain, "kuma", link);

            // Ersetzen Sie die Platzhalter
            template = template.Replace("{artist}", artistName);
            template = template.Replace("{tourname}", tourName);
            template = template.Replace("{kunde}", customerName);
            template = template.Replace("{message}", messageContent);
            template = template.Replace("{link}", webLink);

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