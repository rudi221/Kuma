using Kuma.Models;
using Kuma.Services;
using Kuma.Utilities;

namespace Kuma.Controls

{
    #region Delegates
    // Delegates zur Übergabe von Dateinamen und Künstlerdateilisten.
    public delegate void FileNameEventHandler(FileName fileName);
    public delegate void FileListEventHandler(List<ArtistFileList> artistFileList);
    #endregion
    public partial class UcArtistFiles : UserControl
    {
        #region Deklaration

        // Ereignisse zur Übergabe von Dateinamen und Künstlerdateilisten.
        public event FileNameEventHandler GetFileName;
        public event FileListEventHandler GetArtistFileList;

        private FileName fileName;
        private TourData currentTourData;
        private string sourcePath;
        private readonly List<ArtistFileList> artistFilesList = new();
        private static int counter = 0;

        #endregion

        #region Konstruktor

        public UcArtistFiles()
        {
            InitializeComponent();
            InitializeListView();
        }

        /// <summary>
        /// Initialisiert das ListView mit Spalten und einer ImageList für Icons.
        /// </summary>
        private void InitializeListView()
        {
            ltvArtistFiles.View = View.Details;
            ltvArtistFiles.CheckBoxes = true;
            ltvArtistFiles.Columns.Add("Icon", -2, HorizontalAlignment.Left);
            ltvArtistFiles.Columns.Add("File Name", -2, HorizontalAlignment.Left);

            var imageList = new ImageList();
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "FolderAdd58.png");

            // Überprüft, ob die Bilddatei existiert, bevor sie geladen wird.
            if (File.Exists(imagePath))
            {
                imageList.Images.Add("folder", Image.FromFile(imagePath));
            }

            ltvArtistFiles.SmallImageList = imageList;
        }

        #endregion

        #region Methoden

        /// <summary>
        /// Setzt die Daten des Künstlers und lädt die zugehörigen Dateien aus dem Verzeichnis.
        /// </summary>
        /// <param name="artistInfo">Die Tour-Informationen des Künstlers.</param>
        public void SetArtistData(TourData artistInfo)
        {
            if (artistInfo == null) return;

            // Setzt den Verzeichnispfad für die Tourdaten.
            string tourPath = PathManager.GetArtistTourPath(artistInfo.ArtistName, artistInfo.TourName);

            // Prüft, ob das Verzeichnis existiert, bevor Dateien geladen werden.
            if (!Directory.Exists(tourPath))
            {
                MessageBox.Show("Das Verzeichnis existiert nicht.");
                return;
            }

            // Lädt alle Dateien aus dem Verzeichnis in die ListView.
            LoadFilesIntoListView(Directory.GetFiles(tourPath));
        }

        /// <summary>
        /// Löscht eine ausgewählte Datei der aktuellen Tour.
        /// </summary>
        /// <param name="tourData">Die Tour-Informationen.</param>
        /// <param name="file">Die zu löschende Datei.</param>
        public void DeleteArtistFile(TourData tourData, FileName file)
        {
            if (tourData == null || file?.File == null) return;

            // Erstellt eine Instanz des FileManagers und löscht die Datei.
            new FileManager(tourData.ArtistName, tourData.TourName).DeleteArtistFile(file.File);

            // Aktualisiert die ListView nach dem Löschen.
            AddToListView(tourData);
        }

        /// <summary>
        /// Initialisiert die Daten mit einer Verbindung zu einer Künstler-Datenquelle.
        /// </summary>
        /// <param name="artistData">Die Künstler-Datenquelle.</param>
        public void InitializeWithArtistData(UcArtistData artistData)
        {
            if (artistData != null)
            {
                artistData.TourDataClicked += AddToListView;
            }
        }

        /// <summary>
        /// Lädt die Dateien der aktuellen Tour in die ListView.
        /// </summary>
        /// <param name="tourData">Die Tour-Informationen.</param>
        public void AddToListView(TourData tourData)
        {
            if (tourData == null) return;

            // Löscht alle temporären Künstlerdateien.
            FileManager.DeleteAllArtistFile(PathManager.GetTempPath());

            currentTourData = tourData;
            artistFilesList.Clear();
            ltvArtistFiles.Items.Clear();

            // Ermittelt den Verzeichnispfad der Tour.
            string artistTourFolder = FolderManager.GetArtistTourPath(tourData.ArtistName, tourData.TourName);

            // Prüft, ob das Verzeichnis existiert, bevor Dateien geladen werden.
            if (Directory.Exists(artistTourFolder))
            {
                LoadFilesIntoListView(Directory.GetFiles(artistTourFolder));
            }

            // Aktualisiert die Liste der Künstlerdateien.
            GetArtistFileList?.Invoke(artistFilesList);
        }

        /// <summary>
        /// Fügt eine Liste von Dateien in das ListView hinzu.
        /// </summary>
        /// <param name="files">Ein Array mit Dateipfaden.</param>
        private void LoadFilesIntoListView(string[] files)

        {
            foreach (var file in files)
            {
                var item = new ListViewItem { Checked = true };
                item.SubItems.Add(Path.GetFileName(file));

                // Prüft, ob die Datei eine JPG-Datei ist, und weist ggf. ein Symbol zu.
                if (Path.GetExtension(file).Equals(".jpg", StringComparison.OrdinalIgnoreCase))
                {
                    item.ImageKey = "folder";
                }

                ltvArtistFiles.Items.Add(item);

            }
        }



        #endregion

        #region Event Handler

        /// <summary>
        /// Behandelt das Mausklick-Ereignis auf der ListView und setzt den Dateinamen.
        /// </summary>
        private void ltvArtistFiles_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = ltvArtistFiles.HitTest(e.Location)?.Item!;
            if (item != null)
            {
                fileName = new FileName(item.SubItems[1].Text);
                GetFileName?.Invoke(fileName);
            }
        }

        /// <summary>
        /// Behandelt das Check/Uncheck-Event in der ListView und aktualisiert die Liste.
        /// </summary>
        private void ltvArtistFiles_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Ermittelt den Verzeichnispfad der aktuellen Tour.
            string artistTourFolder = FolderManager.GetArtistTourPath(currentTourData.ArtistName, currentTourData.TourName);
            string fileName = ltvArtistFiles.Items[e.Index].SubItems[1].Text;
            sourcePath = Path.Combine(artistTourFolder, fileName);

            if (e.NewValue == CheckState.Checked)
            {
                // Fügt die Datei zur Liste hinzu, wenn sie markiert wird.
                artistFilesList.Add(new ArtistFileList(FileHelper.GetCleanFileName(fileName), GetWebLink.GetLink(fileName)));
                ManageTempFolder.CopyToTemp(sourcePath);
            }
            else
            {
                // Entfernt die Datei aus der Liste, wenn die Markierung entfernt wird.
                artistFilesList.RemoveAll(f => f.FileName == fileName);
                ManageTempFolder.DeleteFromTemp(fileName);
            }

            // Aktualisiert die Liste der Künstlerdateien.
            GetArtistFileList?.Invoke(artistFilesList);
        }

        #endregion
    }
}