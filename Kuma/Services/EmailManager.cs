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

        if (emailSection.Count == 0 || emailSection.All(kvp => string.IsNullOrWhiteSpace(kvp.Value)))
        {
            MessageBox.Show("Bitte tragen Sie zuerst die Emaildaten in die Einstellungen ein.");
            return;
        }

        _smtpServer = emailSection.TryGetValue("Server", out var server) && !string.IsNullOrWhiteSpace(server) ? server : throw new ArgumentException("Server fehlt in der INI-Datei");
        _smtpUser = emailSection.TryGetValue("Benutzer", out var user) && !string.IsNullOrWhiteSpace(user) ? user : throw new ArgumentException("Benutzer fehlt in der INI-Datei");
        _smtpPass = emailSection.TryGetValue("Passwort", out var pass) && !string.IsNullOrWhiteSpace(pass) ? pass : throw new ArgumentException("Passwort fehlt in der INI-Datei");
        _smtpEmail = emailSection.TryGetValue("Email", out var email) && !string.IsNullOrWhiteSpace(email) ? email : throw new ArgumentException("Email fehlt in der INI-Datei");
        _userDomain = emailSection.TryGetValue("Domain", out var domain) && !string.IsNullOrWhiteSpace(domain) ? domain : throw new ArgumentException("Domain fehlt in der INI-Datei");
    }

    public async Task SendEmailAsync(string customerEmail, string artistName, string tourName, string customerName, string messageContent, string secondMail, string filename)
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
            string template = await File.ReadAllTextAsync(templatePath);

            string link = GetWebLink.GetLink($"{artistName}/{tourName}/{filename}");
            string webLink = Path.Combine(_userDomain, "kuma", link);

            template = template.Replace("{artist}", artistName)
                               .Replace("{tourname}", tourName)
                               .Replace("{kunde}", customerName)
                               .Replace("{message}", messageContent)
                               .Replace("{link}", webLink);

            message.Body = new BodyBuilder { HtmlBody = template }.ToMessageBody();

            using var client = new SmtpClient();
            await client.ConnectAsync(_smtpServer, _smtpPort, MailKit.Security.SecureSocketOptions.StartTls);
            await client.AuthenticateAsync(_smtpUser, _smtpPass);
            await client.SendAsync(message);
            await client.DisconnectAsync(true);

            MessageBox.Show("E-Mail erfolgreich gesendet!");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Fehler beim Senden: {ex.Message}");
        }
    }
}
