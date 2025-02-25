using Kuma.Controls;
using Kuma.Models;
using Kuma.Repositories;
using Kuma.Services;
using System.Data;

namespace Kuma.Forms
{
    public partial class FrmAddArtistFile : Form
    {
        #region Deklarationen  

        private UcArtistFiles ucArtistFile;
        private DatabaseHelper dbHelper;

        private int _artistId;
        private string _artistName;
        private string _tourName;
        private string artistFolderPath;
        private string artistNameFolderPath;
        private string tourNameFolderPath;
        private int checkFile = 0;

        private TourData _artistInfo;


        #endregion

        #region Konstruktor 


        public FrmAddArtistFile(UcArtistFiles ucArtistFile, TourData artistInfo)
        {
            InitializeComponent();


            _artistName = artistInfo.ArtistName;
            _tourName = artistInfo.TourName;


            checkFile = 0;

            this.ucArtistFile = ucArtistFile;
            dbHelper = new DatabaseHelper();

            LoadComboBox();
        }

        #endregion

        #region Event Handlers for Buttons

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkFile == 0)
            {

                MessageBox.Show("Sie haben noch keine Datei ausgewählt!.");

            }
            else
            {
                _artistInfo = new TourData(_artistId, _artistName, _tourName);

                ucArtistFile.AddToListView(_artistInfo);


                Close();
            }




        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    // Datei verschieben/umbenennen
                    FileManager fileManager = new FileManager(openFileDialog.FileName, tourNameFolderPath, cbxCategory.Text);

                    fileManager.MoveArtistFile();
                    checkFile = 1;



                }
            }


        }
        #endregion

        #region Methoden

        private void LoadComboBox()
        {

            string query = "SELECT * FROM Category";
            DataTable dataTable = dbHelper.GetDataTable(query);
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.DataSource = dataTable;





        }


        #endregion



    }
}
