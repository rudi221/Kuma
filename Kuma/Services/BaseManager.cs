namespace Kuma.Services
{
    public class BaseManager
    {
        protected string _oneDrivePath = "C:\\ProgramData\\Kuma";
        protected string _parentFolderName = "Kuenstler";
        protected string _artistFolder;
        protected string _tourFolder;

        protected string _folderPath;
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
            _folderPath = Path.Combine(_oneDrivePath, _parentFolderName);
            _artistFolderPath = Path.Combine(_folderPath, _artistFolder);
            _tourFolderPath = Path.Combine(_artistFolderPath, _tourFolder);
        }
    }
}
