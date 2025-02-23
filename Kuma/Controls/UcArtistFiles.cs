using Kuma.Models;
using Kuma.Services;

namespace Kuma.Controls
{

    public delegate void ReceivingFileNameEventHandler(FileName fileName);
    public partial class UcArtistFiles : UserControl


    {

        public event ReceivingFileNameEventHandler CheckboxClicked;
        #region Deklaration
        private UcArtistData ucArtistData;
        private FileName fileName;
        #endregion

        #region Konstruktor
        public UcArtistFiles()
        {
            InitializeComponent();


            // Add columns (optional)
            ltvArtistFiles.Columns.Add("Icon", -2, HorizontalAlignment.Left);
            ltvArtistFiles.Columns.Add("File Name", -2, HorizontalAlignment.Left);

        }

        #endregion

        #region Event Handlers for Buttons
        #endregion

        #region Methoden


        public void SetArtistData(TourData artistInfo)


        {

            string artistFolderPath = "C:\\ProgramData\\Kuma\\Kuenstler";
            string artistNameFolderPath = Path.Combine(artistFolderPath, artistInfo.ArtistName);
            string tourNameFolderPath = Path.Combine(artistNameFolderPath, artistInfo.TourName);


            //Überprüfe, ob das Verzeichnis existiert
            if (Directory.Exists(tourNameFolderPath))
            {
                // Lade alle Dateien aus dem Verzeichnis
                string[] files = Directory.GetFiles(tourNameFolderPath);

                //  Leere das ListView
                ltvArtistFiles.Items.Clear();

                //  Füge jede Datei dem ListView hinzu
                foreach (string filePath in files)
                {




                    ListViewItem item = new ListViewItem(Path.GetFileName(filePath));
                    item.SubItems.Add(filePath);
                    ltvArtistFiles.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Das Verzeichnis existiert nicht.");
            }
        }


        public void DeleteArtistFile(TourData currentTourData, FileName currentFile)
        {
            if (currentFile?.File != null)
            {

                FileManager fileManager = new FileManager(currentTourData.ArtistName, currentTourData.TourName);

                fileManager.DeleteFile(currentFile.File);

                AddToListView(currentTourData);
            }
            else
            {
                MessageBox.Show("Dateipfad ist null.");
            }
        }


        public void InitializeWithArtistData(UcArtistData artistData)
        {
            artistData.TourDataClicked += AddToListView;
        }

        public void AddToListView(TourData tourData)
        {

            ltvArtistFiles.CheckBoxes = true;

            // Set view to show details (optional)
            ltvArtistFiles.View = View.Details;
            ltvArtistFiles.Items.Clear();




            // Set up the ImageList
            ImageList imageList = new ImageList();
            imageList.Images.Add("png", Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "FolderAdd58.png")));

            // Assign ImageList to ListView
            ltvArtistFiles.SmallImageList = imageList;



            FolderManager folderManager = new FolderManager(tourData.ArtistName, tourData.TourName);

            string[] files = Directory.GetFiles(folderManager.GetFolderPath());



            foreach (string file in files)
            {

                ListViewItem item = new ListViewItem();
                item.SubItems.Add(Path.GetFileName(file));

                item.Checked = true;
                // Check if the file is a PDF
                if (Path.GetExtension(file).Equals(".jpg", StringComparison.OrdinalIgnoreCase))
                {
                    item.ImageKey = "pdf"; // Set the PDF icon
                }

                ltvArtistFiles.Items.Add(item);


            }


        }




        #endregion



        private void ltvArtistFiles_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = ltvArtistFiles.HitTest(e.Location);
            ListViewItem item = info.Item;
            if (item != null)
            {

                fileName = new FileName(item.SubItems[1].Text);





                OnCheckboxClicked(fileName);
            }
        }

        protected virtual void OnCheckboxClicked(FileName fileName)
        {
            CheckboxClicked?.Invoke(fileName);
        }

        private void ltvArtistFiles_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            ListViewItem item = ltvArtistFiles.Items[e.Index];

            ;
        }


    }
}
