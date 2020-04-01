using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Projekt_1.Downloading
{
    /// <summary>
    /// Klasa służąca do pobierania strony html
    /// </summary>
    class DownloadHtml
    {
        /// <summary>
        /// Funkcja do pobierania strony html
        /// </summary>
        /// <param name="url">link do strony www którą chcemy pobrać</param>
        /// <returns>Zwraca czystego html w postaci stringu</returns>
        public static string Downloadpage(string url)
        {
            HtmlWeb webpage = new HtmlWeb();
            HtmlDocument webdoc = webpage.Load(url);
            var htmlresult = webdoc.DocumentNode.InnerHtml;

            return htmlresult;
        }
    }
}
