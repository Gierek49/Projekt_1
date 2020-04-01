using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Projekt_1.Downloading
{
    /// <summary>
    /// Klasa do pobierania xml ze strony
    /// </summary>
    class DownloadFromXml
    {
        /// <summary>
        /// Pobieranie xml ze strony
        /// </summary>
        /// <param name="linkUrl">link do strony xml</param>
        /// <returns>Zwraca XElement</returns>
        public static XElement DownloadXml(string linkUrl)
        {
            XElement xml = XElement.Load(linkUrl);
            if(xml!=null)
            {
                return xml;
            }
            else
            {
                return null;
            }
        }
    }

   
}
