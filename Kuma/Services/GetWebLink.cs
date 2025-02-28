using System.Text.RegularExpressions;

namespace Kuma.Services
{
    public static class GetWebLink
    {

        public static string GetLink(string text)
        {

            text = text.Replace("Ä", "Ae")
                      .Replace("Ö", "Oe")
                      .Replace("Ü", "Ue")
                      .Replace("ä", "ae")
                      .Replace("ö", "oe")
                      .Replace("ü", "ue")
                      .Replace("ß", "ss");

            // Entferne Sonderzeichen außer Bindestrich, Unterstrich, Backslash und Slash
            text = Regex.Replace(text, @"[^a-zA-Z0-9\\/_\s\.-]", "");

            // Ersetze Leerzeichen durch Bindestriche
            text = text.Replace(" ", "-");



            return text;
        }
    }



}
