public static class ManageTempFolder
{
    private static readonly string tempPath = Path.GetTempPath();

    /// <summary>
    /// kopiert eine Datei in den temporären Ordner.
    /// <param name="sourceFile"></param>
    /// </summary>

    public static string CopyToTemp(string sourceFile)
    {
        if (!File.Exists(sourceFile))
        {
            throw new FileNotFoundException("Datei wurde nicht gefunden.", sourceFile);
        }

        string destFile = Path.Combine(tempPath, Path.GetFileName(sourceFile));

        try
        {
            File.Copy(sourceFile, destFile);
            Console.WriteLine($"Datei wurde kopiert {destFile}.");
            return destFile;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Fehler beim kopieren: {ex.Message}");
            return null;
        }
    }

    /// <summary>
    ///Löscht eine Datei aus dem temporären Ordner.
    /// </summary>
    /// <param name="fileName">Der Name der Datei ohne dem Pfad</param>
    public static void DeleteFromTemp(string fileName)
    {
        string filePath = Path.Combine(tempPath, fileName);

        if (File.Exists(filePath))
        {
            try
            {
                File.Delete(filePath);
                Console.WriteLine($"Datei {fileName} wurde gelöscht.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Löschen: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine($"Datei {fileName} wurde nicht im Ordner gefunden.");
        }
    }

    /// <summary>
    /// Löscht alle Dateien aus dem temporären Ordner.
    /// </summary>
    public static void DeleteAllTempFiles()
    {
        try
        {
            string[] files = Directory.GetFiles(tempPath);

            foreach (string file in files)
            {
                try
                {
                    File.Delete(file);
                    Console.WriteLine($"Gelöscht: {file}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Fehler beim löschen der Datei {file}: {ex.Message}");
                }
            }

            Console.WriteLine("Alle Dateien gelöscht.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Fehler beim Zugriff auf den Ordner: {ex.Message}");
        }
    }

}





