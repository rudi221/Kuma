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

        public void Initialize(UcArtistData ucArtistData, UcArtistFiles ucArtistFiles)
        {
            this.ucArtistData = ucArtistData;
            this.ucArtistFiles = ucArtistFiles;
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            FrmAddArtist frmAddArtist = new FrmAddArtist();
            frmAddArtist.ShowDialog();
        }

        private void btnAddArtistFile_Click(object sender, EventArgs e)
        {
            FrmAddArtistFile frmAddArtistFile = new FrmAddArtistFile();
            frmAddArtistFile.ShowDialog();
        }
    }
}
