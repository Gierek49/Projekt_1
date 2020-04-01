using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_1.Data
{
    /// <summary>
    /// Klasa przedstawia pole items w BD
    /// </summary>
    public class XmlItems
    {
        public string Title { get; set; }

        public string Link { get; set; }

        public string Description { get; set; }

        public string Guid { get; set; }

        public string Text { get; set; }
        /// <summary>
        /// Konstruktor tworzący obiekt xmlitems
        /// </summary>
        /// <param name="title">Tytul artykułu</param>
        /// <param name="link">Link do danego artykułu</param>
        /// <param name="description">Krotki opis o tym artykule</param>
        /// <param name="guid">identyfikator globalnie unikatowyz xml</param>
        /// <param name="text">Tekst artykułu</param>
        public XmlItems(string title, string link, string description, string guid, string text)
        {
            Title = title;
            Link = link;
            Description = description;
            Guid = guid;
            Text = text;
        }

    }
}
