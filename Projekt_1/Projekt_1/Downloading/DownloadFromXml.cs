using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Projekt_1.Downloading
{
    class DownloadFromXml
    {
        public static XElement DownloadXml(string linkUrl)
        {
            XElement xml = XElement.Load(linkUrl);

            return xml;
        }
    }
}
