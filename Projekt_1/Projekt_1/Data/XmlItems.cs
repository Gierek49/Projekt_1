using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_1.Data
{
    class XmlItems
    {
        private string Title;
        private string Link;
        private string Description;
        private string Guid;
        private string Text;

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
