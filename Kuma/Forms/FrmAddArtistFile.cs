using Kuma.Controls;

namespace Kuma.Forms
{
    public partial class FrmAddArtistFile : Form
    {
        #region Deklarationen  

        private UcArtistFiles ucArtistFile;
        #endregion

        #region Konstruktor 
        public FrmAddArtistFile(UcArtistFiles ucArtistFile)
        {
            InitializeComponent();

            this.ucArtistFile = ucArtistFile;
        }

        #endregion

        #region Event Handlers for Buttons

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Close();

            ucArtistFile.FillArtistFileListView();
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Methoden
        #endregion


    }
}
