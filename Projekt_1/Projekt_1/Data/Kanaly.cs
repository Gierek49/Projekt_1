using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_1.Data
{
    /// <summary>
    /// Przedstawienie bazy danych za pomocą klasy
    /// </summary>
    public class Kanaly
    {
        public int _id;
        public string Kanal;
        public string link;
       public List<XmlItems> item;
        /// <summary>
        /// Konstruktor tworzy obiekt klasy kanaly 
        /// </summary>
        /// <param name="id">odpowiednik indeksu w BD</param>
        /// <param name="kanal">Nazwa kanału</param>
        /// <param name="link">Link xml do tego kanału</param>
        /// <param name="item">Lista zawierająca elementy klasy XmlItems</param>
        public Kanaly(int id, string kanal, string link, List<XmlItems> item)
        {
            _id = id;
            Kanal = kanal;
            this.link = link;
            this.item = item;
        }
    }
}
