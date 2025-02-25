namespace Kuma.Services
{
    public class BaseManager
    {
        protected string _programFolderPath = "C:\\ProgramData\\Kuma";
        protected string _mainArtitisFolder = "Kuenstler";
        protected string _programTempFolder = "Temp";


        protected string _artistFolder;
        protected string _tourFolder;
        protected string _artistMainFolderPath;
        protected string _artistFolderPath;
        protected string _tourFolderPath;

        public BaseManager(string artistFolder, string tourFolder)
        {
            _artistFolder = artistFolder;
            _tourFolder = tourFolder;
            CombinePaths();
        }

        private void CombinePaths()
        {
            _artistMainFolderPath = Path.Combine(_programFolderPath, _mainArtitisFolder);
            _programFolderPath = Path.Combine(_programFolderPath, _programTempFolder);
            _artistFolderPath = Path.Combine(_artistMainFolderPath, _artistFolder);
            _tourFolderPath = Path.Combine(_artistFolderPath, _tourFolder);
        }
    }
}
