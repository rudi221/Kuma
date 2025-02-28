using Kuma.Models;
using Kuma.Repositories;
using Kuma.Services;

namespace Kuma.Controls
{


    public delegate void ReceivingTourDataEventHandler(TourData tourData);
    public partial class UcArtistData : UserControl
    {
        #region Deklaration
        private readonly DatabaseHelper dbHelper;
        private TourData tourData;

        public event ReceivingTourDataEventHandler TourDataClicked;
        #endregion

        #region Konstruktor
        public UcArtistData()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
        }
        #endregion

        #region Event Handlers for Buttons

        private void tbxArtistSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformSearch();
                e.SuppressKeyPress = true;
            }
        }

        private void btnArtistSearch_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }
        #endregion

        #region Methoden

        // Fügt Künstlerdaten aus dem Formular in die Datenbank ein
        public void InsertArtistDataFromForm(TourData tourData)
        {
            dbHelper.InsertData("Artist", new[] { "ArtistName", "TourName" }, new object[] { tourData.ArtistName, tourData.TourName });

            FolderManager.SetDirectories(tourData.ArtistName, tourData.TourName);
            FolderManager.ArtistTourFolderExists();

            LoadArtistData();
        }

        // Lädt alle Künstlerdaten aus der Datenbank und zeigt sie im DataGridView an
        public void LoadArtistData()
        {
            dgvArtist.DataSource = dbHelper.GetDataTable("SELECT * FROM Artist");

            GridSettings();
            LoadFirstRow();
        }

        // Löscht den ausgewählten Künstler aus der Datenbank und dem Dateisystem
        public void DeleteSelectedArtists(TourData tourData)
        {
            try
            {
                FolderManager.SetDirectories(tourData.ArtistName, tourData.TourName);
                FolderManager.DeleteArtistFolder();

                dbHelper.DeleteData("Artist", $"ArtistId = {tourData.ArtistID}");
                LoadArtistData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Es ist ein Fehler aufgetreten: {ex.Message}");
            }
        }
        #endregion

        // Führt eine Suche nach Künstlern durch und zeigt die Ergebnisse im DataGridView an
        private void PerformSearch()
        {
            string searchWord = tbxArtistSearch.Text.Trim();
            dgvArtist.DataSource = string.IsNullOrEmpty(searchWord)
                ? dbHelper.GetDataTable("SELECT * FROM Artist")
                : dbHelper.GetDataTable($"SELECT ArtistId, ArtistName, TourName FROM Artist WHERE ArtistName LIKE '%{searchWord}%'");

            LoadFirstRow();
        }

        // Event-Handler für das Klicken auf eine Zelle im DataGridView
        private void dgvArtist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvArtist.Rows[e.RowIndex];

            if (row.Cells["ArtistName"].Value is string artistName &&
                row.Cells["TourName"].Value is string tourName &&
                int.TryParse(row.Cells["ArtistID"].Value?.ToString(), out int artistID))
            {
                tourData = new TourData(artistID, artistName, tourName);
                OnTourDataClicked(tourData);
            }
        }

        // Löst das TourDataClicked-Event aus
        protected virtual void OnTourDataClicked(TourData tourData)
        {
            TourDataClicked?.Invoke(tourData);
        }

        // Konfiguriert die Einstellungen des DataGridView
        private void GridSettings()
        {
            if (dgvArtist.Columns["ArtistId"] != null)
            {
                dgvArtist.Columns["ArtistId"].Visible = false;
                dgvArtist.Columns["FolderName"].Visible = false;
                dgvArtist.Columns["ArtistName"].HeaderText = "Künstler";
                dgvArtist.Columns["TourName"].HeaderText = "Tour";
            }
        }

        // Lädt die erste Zeile des DataGridView und löst das TourDataClicked-Event aus
        private void LoadFirstRow()
        {
            if (dgvArtist.Rows.Count > 0)
            {
                var firstRow = dgvArtist.Rows[0];

                if (firstRow.Cells["ArtistName"].Value is string artistName &&
                    firstRow.Cells["TourName"].Value is string tourName &&
                    int.TryParse(firstRow.Cells["ArtistID"].Value?.ToString(), out int artistID))
                {
                    tourData = new TourData(artistID, artistName, tourName);
                    OnTourDataClicked(tourData);
                }
            }
        }
    }

}