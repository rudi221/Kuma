using Kuma.Forms;
using Kuma.Models;

namespace Kuma.Controls
{
    public partial class UcMenu : UserControl
    {
        // Private Felder für Künstlerinformationen  
        private int artistID;
        private string artistName;
        private string tourName;

        // Referenzen auf andere UserControls  
        private UcArtistData ucArtistData;
        private UcArtistFiles ucArtistFiles;

        // Konstruktor  
        public UcMenu()
        {
            InitializeComponent();
        }

        #region Event Handlers für Buttons  

        // Event-Handler für das Hinzufügen eines Künstlers  
        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            using (FrmAddArtist frmAddArtist = new FrmAddArtist(ucArtistData))
            {
                frmAddArtist.ShowDialog();
            }
        }

        // Event-Handler für das Hinzufügen einer Künstlerdatei  
        private void btnAddArtistFile_Click(object sender, EventArgs e)
        {
            using (FrmAddArtistFile frmAddArtistFile = new FrmAddArtistFile(ucArtistFiles))
            {
                frmAddArtistFile.ShowDialog();
            }
        }

        // Event-Handler für das Löschen eines Künstlers  
        private void btnDeleteArtist_Click(object sender, EventArgs e)
        {
            if (ucArtistData != null && ucArtistData.GetSelectedArtist(out ArtistInfo artistInfo))
            {
                DialogResult result = MessageBox.Show("Möchtest du die ausgewählten Künstler wirklich löschen?", "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ucArtistData.DeleteSelectedArtists(artistInfo);
                }
            }
        }

        // Event-Handler für das Löschen einer Künstlerdatei  
        private void btnDeleteArtistFile_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Möchtest du die ausgewählte Datei wirklich löschen?", "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    ucArtistFiles.FillArtistFileListView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Es ist ein Fehler aufgetreten: {ex.Message}");
                }
            }
        }

        #endregion

        #region Methoden  

        // Initialisierungsmethode für die UserControls  
        public void Initialize(UcArtistData ucArtistData, UcArtistFiles ucArtistFiles)
        {
            this.ucArtistData = ucArtistData;
            this.ucArtistFiles = ucArtistFiles;
        }

        #endregion
    }
}
