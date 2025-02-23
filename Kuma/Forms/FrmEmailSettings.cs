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
                   _validator.ValidateTextBox(txbPassword, "Dieses Feld darf nicht leer sein.");
        }

        private void UpdateSettings()
        {
            var ini = new IniFile(IniFilePath);
            ini.Write("FTP", "Server", txbServer.Text);
            ini.Write("FTP", "Benutzer", txbUser.Text);
            ini.Write("FTP", "Passwort", txbPassword.Text);
        }

        private void LoadSettings()
        {
            var ini = new IniFile(IniFilePath);
            var ftpSection = ini.ReadSection("FTP");

            if (ftpSection.TryGetValue("Server", out var server)) txbServer.Text = server;
            if (ftpSection.TryGetValue("Benutzer", out var user)) txbUser.Text = user;
            if (ftpSection.TryGetValue("Passwort", out var password)) txbPassword.Text = password;
        }



        #endregion
    }
}
