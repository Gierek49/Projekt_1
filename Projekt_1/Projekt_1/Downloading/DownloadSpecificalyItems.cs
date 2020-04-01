using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Projekt_1.Downloading
{
    /// <summary>
    /// Klasa służąca do pobierania danego atrybutu z xml
    /// </summary>
   public class DownloadSpecificalyItems
    {
        /// <summary>
        /// Funkcja pobierająca dany atrybut z xml
        /// </summary>
        /// <param name="url">Link do strony xml</param>
        /// <param name="specificalItem">Co dokładnie chcemy pobrać z xml np. link</param>
        /// <returns>Zwraca liste stringów z pobranymi atrybutami</returns>
        public static List<string> DownloadSpecificaly(string url, string specificalItem)
        {
            XElement xml = DownloadFromXml.DownloadXml(url);

           var itemFromXml = xml.Descendants(specificalItem).Select(x => x.Value).ToList();

            return itemFromXml;

        }
    }
}
