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
    }
}
