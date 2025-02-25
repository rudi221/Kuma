using HtmlAgilityPack;

namespace Kuma.Forms
{
    public partial class FrmEmailTemplate : Form
    {


        private const string filePath = @"C:\ProgramData\Kuma\Template\email_template.html"; // Pfad zur HTML-Datei
        public FrmEmailTemplate()
        {
            InitializeComponent();



            LoadHtmlText();

        }

        private void LoadHtmlText()
        {
            if (File.Exists(filePath))
            {
                string htmlContent = File.ReadAllText(filePath);

                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

                doc.LoadHtml(htmlContent);

                // Den Body-Tag finden
                HtmlNode bodyNode = doc.DocumentNode.SelectSingleNode("//body");

                if (bodyNode != null)
                {
                    // Nur den reinen Text ohne HTML-Tags extrahieren
                    string bodyText = bodyNode.InnerHtml.Trim();
                    tbxEmailText.Text = bodyText;
                }
                else
                {
                    Console.WriteLine("Kein <body>-Tag gefunden.");
                }
            }
            else
            {
                Console.WriteLine("Datei nicht gefunden.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (File.Exists(filePath))
            {
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(File.ReadAllText(filePath));

                HtmlNode bodyNode = doc.DocumentNode.SelectSingleNode("//body");

                if (bodyNode != null)
                {
                    bodyNode.InnerHtml = tbxEmailText.Text; // Neuen Inhalt setzen
                    File.WriteAllText(filePath, doc.DocumentNode.OuterHtml); // Datei speichern
                    MessageBox.Show("HTML-Datei erfolgreich aktualisiert!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Datei nicht gefunden!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            Close();
        }
    }
}
