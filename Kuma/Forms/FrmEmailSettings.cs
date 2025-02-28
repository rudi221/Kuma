using Kuma.Services;

namespace Kuma.Forms
{
    public partial class FrmEmailSettings : Form
    {
        #region Deklarationen

        private readonly Validator _validator;
        private const string IniFilePath = @"C:\ProgramData\Kuma\settings.ini";
        #endregion

        #region Konstruktor
        public FrmEmailSettings()
        {
            InitializeComponent();

            MinimumSize = new Size(150, 300);
            _validator = new Validator(errorProvider1);
        }


        #endregion


        #region LoadSettings    
        private void FrmEmailSettings_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        #endregion

        #region Event Handlers for Buttons

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                UpdateSettings();
                MessageBox.Show("Email-Daten aktualisiert!");
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Methoden

        private bool ValidateInputs()
        {
            return _validator.ValidateTextBox(txbServer, "Dieses Feld darf nicht leer sein.") &&
                   _validator.ValidateTextBox(txbUser, "Dieses Feld darf nicht leer sein.") &&
                   _validator.ValidateTextBox(txbPassword, "Dieses Feld darf nicht leer sein.") &&
                   _validator.ValidateTextBox(txbDomain, "Dieses Feld darf nicht leer sein.") &&
                   _validator.ValidateTextBox(txbEmail, "Dieses Feld darf nicht leer sein.");
        }

        private void UpdateSettings()
        {
            var ini = new IniFile(IniFilePath);
            ini.Write("Email", "Server", txbServer.Text);
            ini.Write("Email", "Port", txbPort.Text);
            ini.Write("Email", "Benutzer", txbUser.Text);
            ini.Write("Email", "Passwort", txbPassword.Text);
            ini.Write("Email", "Domain", txbDomain.Text);
            ini.Write("Email", "Email", txbEmail.Text);
        }

        private void LoadSettings()
        {
            var ini = new IniFile(IniFilePath);
            var emailSection = ini.ReadSection("Email");

            if (emailSection.TryGetValue("Server", out var server)) txbServer.Text = server;
            if (emailSection.TryGetValue("Port", out var port)) txbPort.Text = port;
            if (emailSection.TryGetValue("Benutzer", out var user)) txbUser.Text = user;
            if (emailSection.TryGetValue("Passwort", out var password)) txbPassword.Text = password;
            if (emailSection.TryGetValue("Domain", out var domain)) txbDomain.Text = domain;
            if (emailSection.TryGetValue("Email", out var email)) txbEmail.Text = email;
        }



        #endregion
    }
}
