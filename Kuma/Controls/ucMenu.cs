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
            FrmAddArtistFile frmAddArtistFile = new FrmAddArtistFile();
            frmAddArtistFile.ShowDialog();
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
