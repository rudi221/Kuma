using Kuma.Controls;

namespace Kuma
{
    public partial class FrmMain : Form
    {

        private UcMenu ucMenu;
        private UcArtistData ucArtistData;
        private UcAAddressData ucAddressData;
        private UcArtistFiles ucArtistFiles;



        public FrmMain()
        {
            InitializeComponent();

            InitializeCustomControls();

        }


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


    }
}
