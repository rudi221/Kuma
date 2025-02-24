using Kuma.Controls;
using Kuma.Forms;
using Kuma.Utilities;

namespace Kuma
{
    public partial class FrmMain : Form
    {

        #region Deklaration

        private UcMenu ucMenu;
        private UcArtistData ucArtistData;
        private UcAddressData ucAddressData;
        private UcArtistFiles ucArtistFiles;


        #endregion

        #region Konstruktor
        public FrmMain()
        {
            InitializeComponent();
            InitializeDatabase();



            InitializeCustomControls();

            LoadArtistData();

        }


        #endregion

        #region Methoden






        private void InitializeDatabase()
        {
            var initialize = new InitializeProgramData();
            initialize.InitializeDatabase();
            initialize.CreateTables();

        }


        private void LoadArtistData()
        {
            ucArtistData.LoadArtistData();
        }



        private void InitializeCustomControls()
        {
            ucMenu = new UcMenu();
            ucArtistData = new UcArtistData();
            ucAddressData = new UcAddressData();
            ucArtistFiles = new UcArtistFiles();

            //ucMenu.Initialize(ucArtistData, ucArtistFiles);

            pnlMenu.Controls.Add(ucMenu);
            ucMenu.Dock = DockStyle.Fill;

            pnlArtistData.Controls.Add(ucArtistData);
            ucArtistData.Dock = DockStyle.Fill;

            pnlAddress.Controls.Add(ucAddressData);
            ucAddressData.Dock = DockStyle.Fill;

            pnlArtistFiles.Controls.Add(ucArtistFiles);
            ucArtistFiles.Dock = DockStyle.Fill;
            ucArtistFiles.InitializeWithArtistData(ucArtistData);
            ucMenu.InitializeWithArtistData(ucArtistData);
            ucMenu.InitializeWithArtistFiles(ucArtistFiles);
            ucMenu.InitializeWithAddressData(ucAddressData);



            ;
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
