using Kuma.Controls;
using Kuma.Models;
using Kuma.Repositories;
using Kuma.Services;
using System.Data;

namespace Kuma.Forms
{
    public partial class FrmAddArtistFile : Form
    {
        #region Deklarationen  

        // Komponenten und Hilfsklassen
        private readonly UcArtistFiles ucArtistFile;
        private readonly DatabaseHelper dbHelper;

        // Künstler- und Tourdaten
        private readonly int _artistId;
        private readonly string _artistName;
        private readonly string _tourName;
        private readonly string artistFolderPath;
        private readonly string artistNameFolderPath;
        private readonly string tourNameFolderPath;

        // Zustandsvariablen
        private int checkFile = 0;
        private TourData _artistInfo;
        public string fileName { get; private set; }

        #endregion

        #region Konstruktor 

        /// <summary>
        /// Initialisiert eine neue Instanz der FrmAddArtistFile-Klasse.
        /// </summary>
        /// <param name="ucArtistFile">Die Benutzersteuerung für Künstlerdateien.</param>
        /// <param name="artistInfo">Die Tourdaten des Künstlers.</param>
        public FrmAddArtistFile(UcArtistFiles ucArtistFile, TourData artistInfo)
        {
            InitializeComponent();

            // Initialisiert Künstler- und Tourdaten
            _artistName = artistInfo.ArtistName;
            _tourName = artistInfo.TourName;
            checkFile = 0;

            this.ucArtistFile = ucArtistFile;
            dbHelper = new DatabaseHelper();

            // Lädt die Kategorien in die ComboBox
            LoadComboBox();
        }

        #endregion

        #region Event Handlers für Buttons

        /// <summary>
        /// Behandelt das Klick-Ereignis des Abbrechen-Buttons.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Behandelt das Klick-Ereignis des Aktualisieren-Buttons.
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkFile == 0)
            {
                MessageBox.Show("Sie haben noch keine Datei ausgewählt!.");
            }
            else
            {
                // Holt den Verzeichnispfad des Künstlers und der Tour
                string directoryPath = FolderManager.GetArtistTourPath(_artistName, _tourName);

                // Generiert einen eindeutigen Dateinamen
                string uniqueFileName = FileManager.GetUniqueFileName(directoryPath, fileName, cbxCategory.Text);

                // Verschiebt die Datei an den neuen Pfad
                File.Move(fileName, uniqueFileName);

                // Aktualisiert die Tourdaten
                _artistInfo = new TourData(_artistId, _artistName, _tourName);

                // Fügt die Datei der ListView hinzu
                ucArtistFile.AddToListView(_artistInfo);

                // Schließt das Formular
                Close();
            }
        }

        /// <summary>
        /// Behandelt das Klick-Ereignis des Datei Öffnen-Buttons.
        /// </summary>
        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Setzt den ausgewählten Dateinamen
                    fileName = openFileDialog.FileName;
                    checkFile = 1;
                }
            }
        }

        #endregion

        #region Methoden

        /// <summary>
        /// Lädt die Kategorien in die ComboBox.
        /// </summary>
        private void LoadComboBox()
        {
            string query = "SELECT * FROM Category";
            DataTable dataTable = dbHelper.GetDataTable(query);
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.DataSource = dataTable;
        }

        #endregion
    }
}