namespace Kuma.Services
{
    public class PathManager
    {
        protected static string _programFolderPath = "C:\\ProgramData\\Kuma";
        protected static string _mainArtistFolder = "C:\\ProgramData\\Kuma\\Kuenstler";
        protected static string _programTempFolder = "C:\\ProgramData\\Kuma\\Temp";


        public static string GetTempPath()
        {
            return _programTempFolder;
        }

        public static string GetProgramPath()
        {
            return _programFolderPath;
        }

        public static string GetArtistTourPath(string artistFolder, string tourFolder)
        {
            return Path.Combine(_mainArtistFolder, artistFolder, tourFolder);
        }


    }
}
