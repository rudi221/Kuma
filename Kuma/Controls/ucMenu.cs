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
        private TourData currentTourData;
        private FileName currentFile;

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
            using (FrmAddArtistFile frmAddArtistFile = new FrmAddArtistFile(ucArtistFiles, currentTourData))
            {
                frmAddArtistFile.ShowDialog();
            }
        }

        // Event-Handler für das Löschen eines Künstlers  
        private void btnDeleteArtist_Click(object sender, EventArgs e)


        {

            DialogResult result = MessageBox.Show("Möchtest du den Künstler wirklich löschen?", "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    ucArtistData.DeleteSelectedArtists(currentTourData);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Es ist ein Fehler aufgetreten: {ex.Message}");
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
                    if (currentFile != null && currentFile.File != null)
                    {
                        ucArtistFiles.DeleteArtistFile(currentTourData, currentFile);
                    }
                    else
                    {
                        MessageBox.Show("Keine Datei ausgewählt.");
                    }
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

        public void InitializeWithArtistData(UcArtistData ucArtistData)
        {
            ucArtistData.TourDataClicked += ShowInListView;
        }

        public void InitializeWithArtistData(UcArtistFiles ucArtistFiles)
        {
            ucArtistFiles.CheckboxClicked += ShowFileName;
        }

        private void ShowFileName(FileName fileName)
        {
            currentFile = fileName;
        }

        private void ShowInListView(TourData tourData)
        {
            currentTourData = tourData;
        }

        // Initialisierungsmethode für die UserControls  
        public void Initialize(UcArtistData ucArtistData, UcArtistFiles ucArtistFiles)
        {
            this.ucArtistData = ucArtistData;
            this.ucArtistFiles = ucArtistFiles;
        }

        #endregion

        private void btnSendData_Click(object sender, EventArgs e)
        {

        }
    }
}
