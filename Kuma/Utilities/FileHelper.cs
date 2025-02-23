using System.Text.RegularExpressions;

namespace Kuma.Utilities
{
    public class FileHelper
    {
        public static string GetUniqueFileName(string directoryPath, string fileName)
        {
            string newFileName = fileName;
            string filePath = Path.Combine(directoryPath, newFileName);
            int counter = 1;

            while (File.Exists(filePath))
            {
                newFileName = $"{Path.GetFileNameWithoutExtension(fileName)}_{counter}{Path.GetExtension(fileName)}";
                filePath = Path.Combine(directoryPath, newFileName);
                counter++;
            }

            return newFileName;
        }


        public static string GetCleanFileName(string fileName)
        {
            // Dateiendung entfernen
            string nameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(fileName);

            // Unterstriche und Zahlen entfernen
            string cleanName = Regex.Replace(nameWithoutExtension, @"[_\d]", "");

            return cleanName;
        }



    }
}

