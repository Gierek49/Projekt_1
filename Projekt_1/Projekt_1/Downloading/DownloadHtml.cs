using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Projekt_1.Downloading
{
    class DownloadHtml
    {
        public string Downloadpage(string url)
        {
            HtmlWeb webpage = new HtmlWeb();
            HtmlDocument webdoc = webpage.Load(url);
            var htmlresult = webdoc.DocumentNode.InnerHtml;

            return htmlresult;
        }
    }
}
