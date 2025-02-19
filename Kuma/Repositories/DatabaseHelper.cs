using Microsoft.Data.Sqlite;
using System.Data;

namespace Kuma.Repositories
{
    public class DatabaseHelper : IDisposable
    {
        private SqliteConnection connection;

        public DatabaseHelper()
        {
            SQLitePCL.Batteries.Init();
            string connectionString = "Data Source=C:\\ProgramData\\Kuma\\kuma.db";
            connection = new SqliteConnection(connectionString);
            connection.Open();
        }

        public void Dispose()
        {
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
            }
        }

        public void InsertData(string table, string[] columns, object[] values)
        {
            if (columns.Length != values.Length)
            {
                throw new ArgumentException("Die Anzahl der Spalten muss mit der Anzahl der Werte übereinstimmen.");
            }

            string query = $"INSERT INTO {table} ({string.Join(", ", columns)}) VALUES ({string.Join(", ", columns.Select((s, i) => $"@value{i}"))})";
            using (var command = new SqliteCommand(query, connection))
            {
                for (int i = 0; i < values.Length; i++)
                {
                    command.Parameters.AddWithValue($"@value{i}", values[i]);
                }
                command.ExecuteNonQuery();
            }
        }

        public SqliteDataReader ReadData(string query)
        {
            using (var command = new SqliteCommand(query, connection))
            {
                return command.ExecuteReader();
            }
        }

        public void UpdateData(string table, string column, object value, string condition)
        {
            string query = $"UPDATE {table} SET {column} = @value WHERE {condition}";
            using (var command = new SqliteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@value", value);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteData(string table, string condition)
        {
            string query = $"DELETE FROM {table} WHERE {condition}";
            using (var command = new SqliteCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public DataTable GetDataTable(string query)
        {
            using (var command = new SqliteCommand(query, connection))
            using (var reader = command.ExecuteReader())
            {
                var dataTable = new DataTable();
                dataTable.Load(reader);
                return dataTable;
            }
        }
    }

}
