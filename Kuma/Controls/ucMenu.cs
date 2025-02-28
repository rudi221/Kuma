using Kuma.Forms;
using Kuma.Models;
using Kuma.Services;

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
        private UcAddressData ucAddressData;
        private AddressData currentAdressdata;
        private List<ArtistFileList> currentFileList;
        private static int counter = 0;

        // Konstruktor  
        public UcMenu()
        {
            InitializeComponent();

            currentFileList = new List<ArtistFileList>();


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
            this.ucArtistData = ucArtistData;
            ucArtistData.TourDataClicked += ShowInListView;
        }

        private void ShowInListView(TourData tourData)
        {
            currentTourData = tourData;
        }

        public void InitializeWithAddressData(UcAddressData ucAddressData)
        {
            this.ucAddressData = ucAddressData;
            ucAddressData.GetAdressData += ShowAddressData;
        }

        public void ShowAddressData(AddressData addressData)
        {
            currentAdressdata = addressData;
        }



        public void InitializeWithArtistFiles(UcArtistFiles ucArtistFiles)
        {
            this.ucArtistFiles = ucArtistFiles;
            ucArtistFiles.GetFileName += ShowFileName;
            ucArtistFiles.GetArtistFileList += ShowFileList;

        }

        private void ShowFileName(FileName fileName)
        {

            currentFile = fileName;

        }

        private void ShowFileList(List<ArtistFileList> artistFileList)
        {
            counter++;


            currentFileList = artistFileList;

        }

        public static int getCounter()
        {
            return counter;

        }

        private async Task btnSendData_ClickAsync(object sender, EventArgs e)


        {



            CustomerTour customerTour = new CustomerTour(currentAdressdata, currentTourData);

            if (currentFileList != null && currentFileList.Count > 0)
            {
                foreach (var artistFile in currentFileList)
                {
                    customerTour.AddFile(artistFile.FileName, artistFile.Category);
                }
            }

            if (customerTour.Customer != null)
            {
                FrmSendData frmSendData = new FrmSendData(customerTour, currentFileList);
                frmSendData.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einen Kunden aus.");
            }


        }
    }
}
#endregion