using Microsoft.Data.Sqlite;

namespace Kuma.Utilities
{
    public class InitializeProgramData
    {
        private readonly string _folderPath;
        private readonly string _dbPath;
        private readonly string _kuenstlerFolderPath;

        public InitializeProgramData()
        {
            _folderPath = @"C:\ProgramData\kuma";
            _dbPath = Path.Combine(_folderPath, "kuma.db");
            _kuenstlerFolderPath = Path.Combine(_folderPath, "Kuenstler");
        }

        public void InitializeDatabase()
        {
            // Überprüfe und erstelle den Ordner, falls er nicht existiert
            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
                Console.WriteLine($"Ordner '{_folderPath}' wurde erstellt.");
            }
            else
            {
                Console.WriteLine($"Ordner '{_folderPath}' existiert bereits.");
            }

            // Überprüfe und erstelle den 'Kuenstler'-Ordner, falls er nicht existiert
            if (!Directory.Exists(_kuenstlerFolderPath))
            {
                Directory.CreateDirectory(_kuenstlerFolderPath);
                Console.WriteLine($"Ordner '{_kuenstlerFolderPath}' wurde erstellt.");
            }
            else
            {
                Console.WriteLine($"Ordner '{_kuenstlerFolderPath}' existiert bereits.");
            }

            // Erstelle die SQLite-Datenbank
            if (!File.Exists(_dbPath))
            {
                using (var connection = new SqliteConnection($"Data Source={_dbPath}"))
                {
                    connection.Open();
                    Console.WriteLine("Datenbank erstellt: " + _dbPath);
                }
            }
            else
            {
                Console.WriteLine("Datenbank existiert bereits: " + _dbPath);
            }
        }

        public void CreateTables()
        {
            using (var connection = new SqliteConnection($"Data Source={_dbPath}"))
            {
                connection.Open();

                // Erstelle die Tabelle "Artist"
                string createArtistTableQuery = @"
            CREATE TABLE IF NOT EXISTS Artist (
                ArtistId INTEGER NOT NULL CONSTRAINT PK_Artist PRIMARY KEY AUTOINCREMENT,
                ArtistName TEXT NULL,
                TourName TEXT NULL,
                FolderName TEXT NULL
            )";
                ExecuteNonQuery(connection, createArtistTableQuery, "Artist");

                // Erstelle die Tabelle "Category"
                string createCategoryTableQuery = @"
            CREATE TABLE IF NOT EXISTS Category (
                CategoryId INTEGER NOT NULL CONSTRAINT PK_Category PRIMARY KEY AUTOINCREMENT,
                CategoryName TEXT NULL
            )";
                ExecuteNonQuery(connection, createCategoryTableQuery, "Category");

                // Erstelle die Tabelle "Customer"
                string createCustomerTableQuery = @"
            CREATE TABLE IF NOT EXISTS Customer (
                CustomerId INTEGER NOT NULL CONSTRAINT PK_Customer PRIMARY KEY AUTOINCREMENT,
                LastName TEXT NULL,
                CustomerEmail TEXT NULL,
                Company TEXT NULL,
                FirstName TEXT NULL,
                FormOfAdress TEXT NULL
            )";
                ExecuteNonQuery(connection, createCustomerTableQuery, "Customer");
            }
        }

        private void ExecuteNonQuery(SqliteConnection connection, string query, string tableName)
        {
            using (var command = new SqliteCommand(query, connection))
            {
                command.ExecuteNonQuery();
                Console.WriteLine($"Tabelle '{tableName}' erstellt oder existiert bereits.");
            }
        }
    }
}
