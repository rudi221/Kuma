using Kuma.Utilities;

namespace Kuma
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Um die Anwendungskonfiguration anzupassen, wie z. B. hohe DPI-Einstellungen oder Standardschriftarten,
            // siehe https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMain());

            var dbHelper = new InitializeProgramData();
            dbHelper.InitializeDatabase();
            dbHelper.CreateTables();
        }
    }
}