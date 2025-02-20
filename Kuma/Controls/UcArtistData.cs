using Kuma.Classes.Core;
using Kuma.Models;
using Kuma.Repositories;
using System.Data;

namespace Kuma.Controls
{



    public partial class UcArtistData : UserControl
    {
        #region Deklaration
        private DatabaseHelper dbHelper;
        private UcMenu ucMenu;
        #endregion

        #region Konstruktor
        public UcArtistData()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            ucMenu = new UcMenu();
        }
        #endregion

        #region Event Handlers for Buttons
        // Event-Handler für Buttons können hier hinzugefügt werden
        #endregion

        #region Methoden

        /// <summary>
        /// Fügt Künstlerdaten aus dem Formular in die Datenbank ein.
        /// </summary>
        /// <param name="artist">Die Künstlerinformationen.</param>
        public void InsertArtistDataFromForm(ArtistInfo artist)
        {
            string table = "Artist";
            string[] columns = { "ArtistName", "TourName" };
            object[] values = { artist.ArtistName, artist.TourName };

            dbHelper.InsertData(table, columns, values);

            // Initialisierung der Klasse zur Verwaltung der Künstlerordner
            EditArtistFolder folderHelper = new EditArtistFolder(artist.ArtistName, artist.TourName);

            // Überprüfen und Erstellen des Ordners
            folderHelper.EnsureFolderExists();

            // lädt die neuen Daten in die Tabelle
            LoadArtistData();
        }

        /// <summary>
        /// Lädt die Künstlerdaten aus der Datenbank und zeigt sie in der DataGridView an.
        /// </summary>
        public void LoadArtistData()
        {
            string query = "SELECT * FROM Artist";
            DataTable dataTable = dbHelper.GetDataTable(query);
            dgvArtist.DataSource = dataTable;

            if (dgvArtist.Columns["ArtistId"] != null)
            {
                dgvArtist.Columns["ArtistId"].Visible = false;
                dgvArtist.Columns["FolderName"].Visible = false;
                dgvArtist.Columns["ArtistName"].HeaderText = "Künstler";
                dgvArtist.Columns["TourName"].HeaderText = "Tour";
            }
        }

        /// <summary>
        /// Holt den ausgewählten Künstler aus der DataGridView.
        /// </summary>
        /// <param name="artistInfo">Die Künstlerinformationen.</param>
        /// <returns>True, wenn ein Künstler ausgewählt ist, andernfalls False.</returns>
        internal bool GetSelectedArtist(out ArtistInfo artistInfo)
        {
            artistInfo = null;
            DataGridViewRow selectedRow = null;

            if (dgvArtist.SelectedRows.Count > 0)
            {
                selectedRow = dgvArtist.SelectedRows[0];
            }
            else if (dgvArtist.CurrentRow != null)
            {
                selectedRow = dgvArtist.CurrentRow;
            }

            if (selectedRow != null)
            {
                int artistID = Convert.ToInt32(selectedRow.Cells["ArtistID"].Value);
                string artistName = selectedRow.Cells["ArtistName"].Value?.ToString();
                string tourName = selectedRow.Cells["TourName"].Value?.ToString();

                artistInfo = new ArtistInfo(artistID, artistName, tourName);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Löscht den ausgewählten Künstler aus der Datenbank und entfernt den zugehörigen Ordner.
        /// </summary>
        /// <param name="artistInfo">Die Künstlerinformationen.</param>
        public void DeleteSelectedArtists(ArtistInfo artistInfo)
        {
            int artistID = artistInfo.ArtistID;
            string artistName = artistInfo.ArtistName;
            string tourName = artistInfo.TourName;

            try
            {
                EditArtistFolder folderHelper = new EditArtistFolder(artistInfo.ArtistName, artistInfo.TourName);
                folderHelper.DeleteArtistFolder();

                string condition = $"ArtistId = {artistInfo.ArtistID}";
                dbHelper.DeleteData("Artist", condition);
                LoadArtistData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Es ist ein Fehler aufgetreten: {ex.Message}");
            }
        }

        #endregion
    }


}
