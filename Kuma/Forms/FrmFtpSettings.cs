using Kuma.Services;

namespace Kuma.Forms
{
    public partial class FrmFtpSettings : Form
    {
        #region Deklarationen
        private readonly Validator _validator;
        private readonly string _iniFilePath = Path.Combine(PathManager.GetProgramPath(), "settings.ini");
        #endregion

        #region Konstruktor
        public FrmFtpSettings()
        {
            InitializeComponent();
            _validator = new Validator(errorProvider1);
        }
        #endregion


        #region LoadSettings
        private void FrmFtpSettings_Load(object sender, EventArgs e)
        {
            LoadFtpSettings();
        }
        #endregion


        #region Event Handlers for Buttons
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                UpdateIniFile();
                MessageBox.Show("FTP-Daten aktualisiert!");
                Close();
            }
        }
        #endregion

        #region Methoden
        private bool ValidateInputs()
        {
            return _validator.ValidateTextBox(txbServer, "Dieses Feld darf nicht leer sein.") &&
                   _validator.ValidateTextBox(txbUser, "Dieses Feld darf nicht leer sein.") &&
                   _validator.ValidateTextBox(txbPassword, "Dieses Feld darf nicht leer sein.") &&
                   _validator.ValidateTextBox(txbFolder, "Dieses Feld darf nicht leer sein.");
        }

        private void UpdateIniFile()
        {
            var ini = new IniFile(_iniFilePath);
            ini.Write("FTP", "Server", txbServer.Text);
            ini.Write("FTP", "Benutzer", txbUser.Text);
            ini.Write("FTP", "Passwort", txbPassword.Text);
            ini.Write("FTP", "Verzeichnis", txbFolder.Text);
        }

        private void LoadFtpSettings()
        {
            var ini = new IniFile(_iniFilePath);
            var ftpSection = ini.ReadSection("FTP");

            if (ftpSection.ContainsKey("Server")) txbServer.Text = ftpSection["Server"];
            if (ftpSection.ContainsKey("Benutzer")) txbUser.Text = ftpSection["Benutzer"];
            if (ftpSection.ContainsKey("Passwort")) txbPassword.Text = ftpSection["Passwort"];
            if (ftpSection.ContainsKey("Verzeichnis")) txbFolder.Text = ftpSection["Verzeichnis"];
        }
        #endregion


    }
}
