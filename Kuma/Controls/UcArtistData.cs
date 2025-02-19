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

        #endregion

        #region Konstruktor
        public UcArtistData()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();

        }
        #endregion

        #region Event Handlers for Buttons
        #endregion

        #region Methoden

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

            // lädt die Daten in die Tabelle
            LoadArtistData();



        }

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
        #endregion
    }
}
