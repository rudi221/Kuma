using Kuma.Controls;
using Kuma.Forms;

namespace Kuma
{
    public partial class FrmMain : Form
    {

        #region Deklaration

        private UcMenu ucMenu;
        private UcArtistData ucArtistData;
        private UcAAddressData ucAddressData;
        private UcArtistFiles ucArtistFiles;
        private UcArtistSearch ucArtistSearch;

        #endregion

        #region Konstruktor
        public FrmMain()
        {
            InitializeComponent();

            InitializeCustomControls();

            LoadArtistData();

        }


        #endregion

        #region Methoden


        private void LoadArtistData()
        {
            ucArtistData.FillDataView();
        }



        private void InitializeCustomControls()
        {
            ucMenu = new UcMenu();
            ucArtistData = new UcArtistData();
            ucAddressData = new UcAAddressData();
            ucArtistFiles = new UcArtistFiles();
            ucArtistSearch = new UcArtistSearch();

            ucMenu.Initialize(ucArtistData, ucArtistFiles);

            pnlMenu.Controls.Add(ucMenu);
            ucMenu.Dock = DockStyle.Fill;

            pnlArtistData.Controls.Add(ucArtistData);
            ucArtistData.Dock = DockStyle.Fill;

            pnlAddress.Controls.Add(ucAddressData);
            ucAddressData.Dock = DockStyle.Fill;

            pnlArtistFiles.Controls.Add(ucArtistFiles);
            ucArtistFiles.Dock = DockStyle.Fill;

            pnlArtistSearch.Controls.Add(ucArtistSearch);
            ucArtistSearch.Dock = DockStyle.Fill;
        }
        #endregion

        #region Event Handlers for Buttons

        private void tsmCloseItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmKategorieItem_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.ShowDialog();
        }

        private void tsmEmailItem_Click(object sender, EventArgs e)
        {
            FrmEmailSettings frmEmailSettings = new FrmEmailSettings();
            frmEmailSettings.ShowDialog();
        }

        private void tsmFtpItem_Click(object sender, EventArgs e)
        {
            FrmFtpSettings frmFtpSettings = new FrmFtpSettings();
            frmFtpSettings.ShowDialog();
        }



        #endregion



    }
}
