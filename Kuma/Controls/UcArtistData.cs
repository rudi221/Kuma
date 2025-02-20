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
        /// <param name="tourData">Die Künstlerinformationen.</param>
        public void InsertArtistDataFromForm(TourData tourData)
        {
            string table = "Artist";
            string[] columns = { "ArtistName", "TourName" };
            object[] values = { tourData.ArtistName, tourData.TourName };

            dbHelper.InsertData(table, columns, values);

            // Initialisierung der Klasse zur Verwaltung der Künstlerordner
            FolderManager folderHelper = new FolderManager(tourData.ArtistName, tourData.TourName);

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
        /// <param name="tourData">Die Künstlerinformationen.</param>
        /// <returns>True, wenn ein Künstler ausgewählt ist, andernfalls False.</returns>
        internal bool GetSelectedArtist(out TourData tourData)
        {
            tourData = null;
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

                tourData = new TourData(artistID, artistName, tourName);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Löscht den ausgewählten Künstler aus der Datenbank und entfernt den zugehörigen Ordner.
        /// </summary>
        /// <param name="artistInfo">Die Künstlerinformationen.</param>
        public void DeleteSelectedArtists(TourData tourData)
        {

            string artistName = tourData.ArtistName;
            string tourName = tourData.TourName;

            try
            {
                FolderManager folderHelper = new FolderManager(tourData.ArtistName, tourData.TourName);
                folderHelper.DeleteArtistFolder();

                string condition = $"ArtistId = {tourData.ArtistID}";
                dbHelper.DeleteData("Artist", condition);
                LoadArtistData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Es ist ein Fehler aufgetreten: {ex.Message}");
            }
        }

        #endregion

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


        private void PerformSearch()
        {
            string searchWord = tbxArtistSearch.Text;

            if (searchWord.Length > 0)
            {
                string query = $"SELECT ArtistId, ArtistName,TourName FROM Artist WHERE ArtistName LIKE '%{searchWord}%'";



                DataTable dataTable = dbHelper.GetDataTable(query);
                dgvArtist.DataSource = dataTable;
            }
            else
            {
                LoadArtistData();
            }

        }


    }

}