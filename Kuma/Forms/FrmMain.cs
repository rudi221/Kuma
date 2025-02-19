using Kuma.Controls;

namespace Kuma
{
    public partial class FrmMain : Form
    {

        #region Deklaration

        private UcMenu ucMenu;
        private UcArtistData ucArtistData;
        private UcAAddressData ucAddressData;
        private UcArtistFiles ucArtistFiles;

        #endregion

        #region Konstruktor
        public FrmMain()
        {
            InitializeComponent();

            InitializeCustomControls();

        }
        #endregion


        #region Methoden
        private void InitializeCustomControls()
        {
            ucMenu = new UcMenu();
            ucArtistData = new UcArtistData();
            ucAddressData = new UcAAddressData();
            ucArtistFiles = new UcArtistFiles();

            ucMenu.Initialize(ucArtistData, ucArtistFiles);

            pnlMenu.Controls.Add(ucMenu);
            ucMenu.Dock = DockStyle.Fill;

            pnlArtistData.Controls.Add(ucArtistData);
            ucArtistData.Dock = DockStyle.Fill;

            pnlAddress.Controls.Add(ucAddressData);
            ucAddressData.Dock = DockStyle.Fill;

            pnlArtistFiles.Controls.Add(ucArtistFiles);
            ucArtistFiles.Dock = DockStyle.Fill;
        }
        #endregion


    }
}
