using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Projekt_1.Downloading
{
    class DownloadSpecificalyItems
    {
        public List<string> DownloadSpecificaly(string url, string specificalItem)
        {
            XElement xml = DownloadFromXml.DownloadXml(url);

           var itemFromXml = xml.Descendants(specificalItem).Select(x => x.Value).ToList();

            return itemFromXml;

        }
    }
}
