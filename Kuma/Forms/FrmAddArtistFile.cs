using Kuma.Controls;
using Kuma.Models;
using Kuma.Repositories;
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



            _artistId = artistInfo.ArtistID;
            _artistName = artistInfo.ArtistName;
            _tourName = artistInfo.TourName;
            _artistInfo = artistInfo;

            checkFile = 0;

            this.ucArtistFile = ucArtistFile;
            dbHelper = new DatabaseHelper();

            artistFolderPath = "C:\\ProgramData\\Kuma\\Kuenstler";
            artistNameFolderPath = Path.Combine(artistFolderPath, _artistName);
            tourNameFolderPath = Path.Combine(artistNameFolderPath, _tourName);

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
                ucArtistFile.FillArtistFileListView(_artistInfo);

                Close();
            }




        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceFilePath = openFileDialog.FileName;
                    string targetDirectory = tourNameFolderPath;
                    string targetFilePath = Path.Combine(targetDirectory, Path.GetFileName(sourceFilePath));
                    string fileName = System.IO.Path.GetFileName(sourceFilePath);
                    string newFileName = cbxCategory.Text + Path.GetExtension(fileName);
                    string newFilePath = Path.Combine(targetDirectory, newFileName);

                    try
                    {


                        if (!String.IsNullOrEmpty(fileName))
                        {

                            File.Move(sourceFilePath, newFilePath);


                            // File.Copy(sourceFilePath, targetFilePath, overwrite: true);
                            AddFileToDatabase(newFileName);
                            checkFile = 1;
                        }



                        MessageBox.Show("Datei erfolgreich geladen!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fehler: " + ex.Message);
                    }
                }
            }


        }
        #endregion

        #region Methoden
        #endregion


        private void LoadComboBox()
        {

            string query = "SELECT * FROM Category";
            DataTable dataTable = dbHelper.GetDataTable(query);



            cbxCategory.DisplayMember = "CategoryName"; // Ersetzen Sie ColumnName durch den tatsächlichen Spaltennamen, der angezeigt werden soll
            cbxCategory.DataSource = dataTable;





        }



        private void AddFileToDatabase(string fileName)
        {
            string table = "ArtistFiles";
            string[] columns = { "ArtistId", "Category", "FileName", "FolderName" };

            object[] values = { _artistId, cbxCategory.Text, fileName, _tourName };

            dbHelper.InsertData(table, columns, values);
        }



    }
}
