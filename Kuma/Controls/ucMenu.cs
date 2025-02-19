using Kuma.Forms;

namespace Kuma.Controls
{
    public partial class UcMenu : UserControl
    {
        private UcArtistData ucArtistData;
        private UcArtistFiles ucArtistFiles;

        public UcMenu()
        {
            InitializeComponent();
        }


        #region Event Handlers for Buttons

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            FrmAddArtist frmAddArtist = new FrmAddArtist(ucArtistData);
            frmAddArtist.ShowDialog();
        }

        private void btnAddArtistFile_Click(object sender, EventArgs e)
        {
            FrmAddArtistFile frmAddArtistFile = new FrmAddArtistFile(ucArtistFiles);
            frmAddArtistFile.ShowDialog();
        }

        private void btnDeleteArtist_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Möchtest du die ausgewählten Künstler wirklich löschen?", "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Es ist ein Fehler aufgetreten: {ex.Message}");
                }




            }
        }

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

        public void Initialize(UcArtistData ucArtistData, UcArtistFiles ucArtistFiles)
        {
            this.ucArtistData = ucArtistData;
            this.ucArtistFiles = ucArtistFiles;
        }
        #endregion




    }
}
